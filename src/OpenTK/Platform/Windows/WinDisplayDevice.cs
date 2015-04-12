//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2010 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using Microsoft.Win32;
#endif

namespace OpenTK.Platform.Windows
{
    internal sealed class WinDisplayDeviceDriver : DisplayDeviceDriver
    {
        private readonly object display_lock = new object();

        // Small object for tracking name, available resolutions, and original resolution.
        private sealed class WinDevice
        {
            public int DevNum;
            public string Name;
            public DisplayResolution OriginalResolution;
            public List<DisplayResolution> AvailableResolutions;
        }

        public WinDisplayDeviceDriver()
        {
            RefreshDisplayDevices();
            SystemEvents.DisplaySettingsChanged += HandleDisplaySettingsChanged;
        }

        public override bool GetIsPrimary(object device)
        {
            var winDevice = (WinDevice)device;
            WindowsDisplayDevice dev1 = new WindowsDisplayDevice();
            if (!Functions.EnumDisplayDevices(null, winDevice.DevNum, dev1, 0))
            {
                Debug.Print(
                    "[Warning] DisplayDevice '{0}' not enumerated by EnumDisplayDevices. Please create a bug report at http://github.com/opentk/opentk/issues",
                    winDevice.Name);
                return false;
            }
            Debug.Print("GetIsPrimary.dev1:\n{0}", dev1);

            return (dev1.StateFlags & DisplayDeviceStateFlags.PrimaryDevice) != DisplayDeviceStateFlags.None;
        }

        public override DisplayResolution GetResolution(object device)
        {
            var winDevice = (WinDevice)device;
            var monitorMode = new DeviceMode();

            // The second function should only be executed when the first one fails
            // (e.g. when the monitor is disabled)
            if (Functions.EnumDisplaySettingsEx(winDevice.Name, DisplayModeSettingsEnum.CurrentSettings, monitorMode, 0) ||
                Functions.EnumDisplaySettingsEx(winDevice.Name, DisplayModeSettingsEnum.RegistrySettings, monitorMode, 0))
            {
                VerifyMode(winDevice.Name, monitorMode);

                float scale = GetScale(monitorMode);
                return new DisplayResolution(
                    (int)(monitorMode.Position.X / scale), (int)(monitorMode.Position.Y / scale),
                    (int)(monitorMode.PelsWidth / scale), (int)(monitorMode.PelsHeight / scale),
                    monitorMode.BitsPerPel, monitorMode.DisplayFrequency);
            }
            else
            {
                Debug.Print(
                    "[Warning] DisplayDevice '{0}' reported no resolution. Please create a bug report at http://github.com/opentk/opentk/issues",
                    winDevice.Name);
                return null;
            }
        }

        public override IList<DisplayResolution> GetAvailableResolutions(object device)
        {
            var winDevice = (WinDevice)device;
            return winDevice.AvailableResolutions.AsReadOnly();
        }

        public override bool TryChangeResolution(object device, DisplayResolution resolution)
        {
            var winDevice = (WinDevice)device;
            DeviceMode mode = null;

            if (resolution != null)
            {
                mode = new DeviceMode();
                mode.PelsWidth = resolution.Width;
                mode.PelsHeight = resolution.Height;
                mode.BitsPerPel = resolution.BitsPerPixel;
                mode.DisplayFrequency = (int)resolution.RefreshRate;
                mode.Fields = Constants.DM_BITSPERPEL
                    | Constants.DM_PELSWIDTH
                    | Constants.DM_PELSHEIGHT
                    | Constants.DM_DISPLAYFREQUENCY;
            }

            return Constants.DISP_CHANGE_SUCCESSFUL ==
                Functions.ChangeDisplaySettingsEx(winDevice.Name, mode, IntPtr.Zero,
                    ChangeDisplaySettingsEnum.Fullscreen, IntPtr.Zero);
        }

        public override bool TryRestoreResolution(object device)
        {
            return TryChangeResolution(device, null);
        }

        public void RefreshDisplayDevices()
        {
            lock (display_lock)
            {
                // Store an array of the current available DisplayDevice objects.
                // This is needed to preserve the original resolution.
                DisplayDevice[] previousDevices = Devices.ToArray();

                Devices.Clear();
                
                int deviceCount = 0;

                // Get available video adapters and enumerate all monitors
                WindowsDisplayDevice dev1 = new WindowsDisplayDevice();
                while (Functions.EnumDisplayDevices(null, deviceCount++, dev1, 0))
                {
                    Debug.Print("RefreshDisplayDevices.EnumDisplayDevices[{0}]:\n{1}", deviceCount - 1, dev1);

                    var deviceName = dev1.DeviceName;

                    if ((dev1.StateFlags & DisplayDeviceStateFlags.AttachedToDesktop) == DisplayDeviceStateFlags.None)
                    {
                        continue;
                    }

                    bool isPrimary =
                        (dev1.StateFlags & DisplayDeviceStateFlags.PrimaryDevice) != DisplayDeviceStateFlags.None;

                    var winDevice = new WinDevice() { DevNum = deviceCount - 1 };
                    winDevice.Name = dev1.DeviceName;

                    winDevice.AvailableResolutions = new List<DisplayResolution>();
                    int modeCount = 0;
                    DeviceMode monitorMode = new DeviceMode();
                    while (Functions.EnumDisplaySettingsEx(winDevice.Name, modeCount++, monitorMode, 0))
                    {
                        VerifyMode(winDevice.Name, monitorMode);

                        float scale = GetScale(monitorMode);
                        DisplayResolution res = new DisplayResolution(
                            (int)(monitorMode.Position.X / scale), (int)(monitorMode.Position.Y / scale),
                            (int)(monitorMode.PelsWidth / scale), (int)(monitorMode.PelsHeight / scale),
                            monitorMode.BitsPerPel, monitorMode.DisplayFrequency);

                        winDevice.AvailableResolutions.Add(res);
                    }

                    // Set the original resolution if the DisplayDevice was previously available.
                    foreach (DisplayDevice existingDevice in previousDevices)
                    {
                        var winExistingDevice = (WinDevice)existingDevice.id;
                        if (winExistingDevice.Name == winDevice.Name)
                        {
                            winDevice.OriginalResolution = winExistingDevice.OriginalResolution;
                        }
                    }

                    // New device, need to get it's current resolution to save
                    if (winDevice.OriginalResolution == null)
                    {
                        winDevice.OriginalResolution = GetResolution(winDevice);
                    }

                    DisplayDevice displayDevice = new DisplayDevice(winDevice);
                    Devices.Add(displayDevice);

                    Debug.Print("DisplayDevice {0} ({1}) added.",
                        deviceCount, isPrimary ? "primary" : "secondary");
                }
            }
        }

        private float GetScale(DeviceMode monitor_mode)
        {
            var scale = 1.0f;
            if ((monitor_mode.Fields & Constants.DM_LOGPIXELS) != 0)
            {
                scale = monitor_mode.LogPixels / 96.0f;
            }
            return scale;
        }

        private static void VerifyMode(string deviceName, DeviceMode mode)
        {
            if (mode.BitsPerPel == 0)
            {
                Debug.Print(
                    "[Warning] DisplayDevice '{0}' reported a mode with 0 bpp. Please create a bug report at http://github.com/opentk/opentk/issues",
                    deviceName);
                mode.BitsPerPel = 32;
            }
        }

        private void HandleDisplaySettingsChanged(object sender, EventArgs e)
        {
            Debug.Print("Display Settings Changed");
            RefreshDisplayDevices();
        }

        ~WinDisplayDeviceDriver()
        {
            SystemEvents.DisplaySettingsChanged -= HandleDisplaySettingsChanged;
        }
    }
}
