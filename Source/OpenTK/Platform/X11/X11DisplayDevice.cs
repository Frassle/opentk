#region License
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
#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
#if !MINIMAL
using System.Drawing;
#endif
using System.Runtime.InteropServices;

namespace OpenTK.Platform.X11
{
    sealed class X11DisplayDevice : DisplayDeviceBase
    {
        // Store a mapping between resolutions and their respective
        // size_index (needed for XRRSetScreenConfig). The size_index
        // is simply the sequence number of the resolution as returned by
        // XRRSizes. This is done per available screen.
        readonly List<Dictionary<DisplayResolution, int>> screenResolutionToIndex =
            new List<Dictionary<DisplayResolution, int>>();
        // Store a mapping between DisplayDevices and their default resolutions.
        readonly Dictionary<DisplayDevice, int> deviceToDefaultResolution = new Dictionary<DisplayDevice, int>();

        bool xrandr_supported, xf86_supported;

        #region Constructors

        public X11DisplayDevice()
        {
            RefreshDisplayDevices();
        }

        #endregion

        #region Private Methods

        struct XDevice
        {
            public bool IsPrimary;
            public int ScreenIndex;
            public Rectangle Bounds;
            public int BitsPerPixel;
            public float RefreshRate;
            public int DefaultResolution;
            public List<DisplayResolution> AvailableResolutions;
        }

        void RefreshDisplayDevices()
        {
            using (new XLock(API.DefaultDisplay))
            {
                Debug.Print("API.ScreenCount = {0}", API.ScreenCount);

                AvailableDevices.Clear();
                List<XDevice> devices = null;

                try
                {
                    devices = QueryXRandR();
                    xrandr_supported = devices != null && devices.Count > 0;
                }
                catch (Exception e)
                {
                    Debug.Print("XRandR query failed {0}.", e);
                }

                if (!xrandr_supported)
                {
                    Debug.Print("XRandR not supported.");

                    try
                    {
                        devices = QueryXF86();
                        xf86_supported = devices != null && devices.Count > 0;
                    }
                    catch (Exception e)
                    {
                        Debug.Print("XF86 query failed {0}.", e);
                    }
                }

                if (!xf86_supported)
                {
                        Debug.Print("XF86 not supported, no DisplayDevice support available.");
                        return;
                }

                foreach (XDevice xdev in devices)
                {
                    var resolution = new DisplayResolution(
                        xdev.Bounds.X, xdev.Bounds.Y,
                        xdev.Bounds.Width, xdev.Bounds.Height,
                        xdev.BitsPerPixel, xdev.RefreshRate);
                    var device = new DisplayDevice(
                        xdev.IsPrimary, resolution, xdev.AvailableResolutions, xdev.ScreenIndex);

                    deviceToDefaultResolution[device] = xdev.DefaultResolution;

                    AvailableDevices.Add(device);

                    if (device.IsPrimary)
                    {
                        Primary = device;
                    }
                }
            }
        }

        List<XDevice> QueryXRandR()
        {
            int event_base, error_base;
            int major, minor;

            try
            {
                if (!API.XRRQueryExtension(API.DefaultDisplay, out event_base, out error_base))
                {
                    Debug.Print("XRRQueryExtension failed");
                    return null;
                }
                else if(!API.XRRQueryVersion(API.DefaultDisplay, out major, out minor))
                {
                    Debug.Print("XRRQueryVersion failed");
                    return null;
                }
            }
            catch (DllNotFoundException)
            {
                Debug.Print("XRandR library not found");
                return null;
            }

            Debug.Print("Using XRandR v" + major.ToString() + "." + minor.ToString());

            List<XDevice> devices = new List<XDevice>();
            // Can query XRandR for each connected X screen
            for(int currentScreen = 0; currentScreen < API.ScreenCount; ++currentScreen)
            {
                var root = Functions.XRootWindow(API.DefaultDisplay, currentScreen);
                var res = XRRGetScreenResources(API.DefaultDisplay, root);


            // Get available resolutions. Then, for each resolution get all available rates.
            for(int i = 0; i < devices.Count; ++i)
            {
                XDevice device = devices[i];
                int screen = device.ScreenIndex;

                Console.WriteLine("Query XRandR for {0}", screen);

                List<DisplayResolution> available_res = new List<DisplayResolution>();

                // Add info for a new screen.
                screenResolutionToIndex.Add(new Dictionary<DisplayResolution, int>());

                Console.WriteLine("Get depths for {0}", screen);
                int[] depths = FindAvailableDepths(screen);
                string[] depth_strs = new string[depths.Length];
                for(int j = 0; j < depths.Length; ++j)
                {
                    depth_strs[j] = depths[j].ToString();
                }

                Console.WriteLine("Depths: {0}", String.Join(", ", depth_strs));

                int resolution_count = 0;
                foreach (XRRScreenSize size in FindAvailableResolutions(screen))
                {
                    Console.WriteLine("	Size = ({0}, {1}) ({2}, {3})", size.Width, size.Height, size.MWidth, size.MHeight);
                    if (size.Width == 0 || size.Height == 0)
                    {
                        Debug.Print("[Warning] XRandR returned an invalid resolution ({0}) for display device {1}", size, screen);
                        continue;
                    }
                    short[] rates = null;
                    rates = Functions.XRRRates(API.DefaultDisplay, screen, resolution_count);

                    // It seems that XRRRates returns 0 for modes that are larger than the screen
                    // can support, as well as for all supported modes. On Ubuntu 7.10 the tool
                    // "Screens and Graphics" does report these modes, though.
                    foreach (short rate in rates)
                    {
                        // Note: some X servers (like Xming on Windows) do not report any rates other than 0.
                        // If we only have 1 rate, add it even if it is 0.
                        if (rate != 0 || rates.Length == 1)
                            foreach (int depth in depths)
                                available_res.Add(new DisplayResolution(0, 0, size.Width, size.Height, depth, (float)rate));
                    }
                    // Keep the index of this resolution - we will need it for resolution changes later.
                    foreach (int depth in depths)
                    {
                        // Note that Xinerama may return multiple devices for a single screen. XRandR will
                        // not distinguish between the two as far as resolutions are supported (since XRandR
                        // operates on X screens, not display devices) - we need to be careful not to add the
                        // same resolution twice!
                        DisplayResolution res = new DisplayResolution(0, 0, size.Width, size.Height, depth, 0);
                        if (!screenResolutionToIndex[screen].ContainsKey(res))
                            screenResolutionToIndex[screen].Add(res, resolution_count);
                    }

                    ++resolution_count;
                }


                // The resolution of the current DisplayDevice is discovered through XRRConfigCurrentConfiguration.
                // Its refresh rate is discovered by the FindCurrentRefreshRate call.
                // Its depth is discovered by the FindCurrentDepth call.
                float current_refresh_rate = FindCurrentRefreshRate(screen);
                int current_depth = FindCurrentDepth(screen);
                IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, Functions.XRootWindow(API.DefaultDisplay, screen));
                ushort current_rotation;  // Not needed.
                int current_resolution_index = Functions.XRRConfigCurrentConfiguration(screen_config, out current_rotation);

                if (device.Bounds == Rectangle.Empty)
                {
                    // We have added depths.Length copies of each resolution
                    // Adjust the return value of XRRGetScreenInfo to retrieve the correct resolution
                    int index = current_resolution_index * depths.Length;
                    
                    // Make sure we are within the bounds of the available_res array
                    if (index >= available_res.Count)
                    {
                        // If not, use the return value of XRRGetScreenInfo directly
                        index = current_resolution_index;
                    }
                    DisplayResolution current_resolution = available_res[index];
                    device.Bounds = new Rectangle(0, 0, current_resolution.Width, current_resolution.Height);
                }
                device.BitsPerPixel = current_depth;
                device.RefreshRate = current_refresh_rate;
                device.DefaultResolution = current_resolution_index;
                device.AvailableResolutions = available_res;

                devices[i] = device;
            }

            return devices;
        }

        List<XDevice> QueryXF86()
        {
            int major;
            int minor;

            try
            {
                if (!API.XF86VidModeQueryVersion(API.DefaultDisplay, out major, out minor))
                {
                    Debug.Print("XF86VidModeQueryVersion failed");
                    return null;
                }
            }
            catch (DllNotFoundException)
            {
                Debug.Print("XF86 library not found");
                return null;
            }

            Debug.Print("Using XF86 v" + major.ToString() + "." + minor.ToString());

            List<XDevice> devices = new List<XDevice>();
            // We assume that devices are equivalent to the number of available screens.
            // Note: this won't work correctly in the case of distinct X servers.
            for(int currentScreen = 0; currentScreen < API.ScreenCount; ++currentScreen)
            {
                int count;
                IntPtr srcArray;
                API.XF86VidModeGetAllModeLines(API.DefaultDisplay, currentScreen, out count, out srcArray);

                Debug.Print(count.ToString() + " modes detected on screen " + currentScreen.ToString());
                IntPtr[] array = new IntPtr[count];
                Marshal.Copy(srcArray, array, 0, count);
                API.XF86VidModeModeInfo Mode = new API.XF86VidModeModeInfo();

                int x;
                int y;
                API.XF86VidModeGetViewPort(API.DefaultDisplay, currentScreen, out x, out y);
                List<DisplayResolution> resolutions = new List<DisplayResolution>();
                for (int j = 0; j < count; j++)
                {
                    Mode = (API.XF86VidModeModeInfo)Marshal.PtrToStructure(array[j], typeof(API.XF86VidModeModeInfo));
                    resolutions.Add(new DisplayResolution(x, y, Mode.hdisplay, Mode.vdisplay, 24, (Mode.dotclock * 1000F) / (Mode.vtotal * Mode.htotal)));
                }

                int pixelClock;
                API.XF86VidModeModeLine currentMode;
                API.XF86VidModeGetModeLine(API.DefaultDisplay, currentScreen, out pixelClock, out currentMode);

                XDevice dev = new XDevice();
                dev.AvailableResolutions = resolutions;
                dev.IsPrimary = currentScreen == Functions.XDefaultScreen(API.DefaultDisplay);
                dev.Bounds = new Rectangle(x, y, currentMode.hdisplay, (currentMode.vdisplay == 0) ? currentMode.vsyncstart : currentMode.vdisplay);
                dev.BitsPerPixel = FindCurrentDepth(currentScreen);
                dev.RefreshRate = (pixelClock * 1000F) / (currentMode.vtotal * currentMode.htotal);
                dev.ScreenIndex = currentScreen;
                devices.Add(dev);
            }
            return devices;
        }

        #region static int[] FindAvailableDepths(int screen)

        static int[] FindAvailableDepths(int screen)
        {
            return Functions.XListDepths(API.DefaultDisplay, screen);
        }

        #endregion

        #region static XRRScreenSize[] FindAvailableResolutions(int screen)

        static XRRScreenSize[] FindAvailableResolutions(int screen)
        {
            XRRScreenSize[] resolutions = null;
            resolutions = Functions.XRRSizes(API.DefaultDisplay, screen);
            if (resolutions == null)
                throw new NotSupportedException("XRandR extensions not available.");
            return resolutions;
        }

        #endregion

        #region static float FindCurrentRefreshRate(int screen)

        static float FindCurrentRefreshRate(int screen)
        {
            short rate = 0;
            IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, Functions.XRootWindow(API.DefaultDisplay, screen));
            rate = Functions.XRRConfigCurrentRate(screen_config);
            Functions.XRRFreeScreenConfigInfo(screen_config);
            return (float)rate;
        }

        #endregion

        #region private static int FindCurrentDepth(int screen)

        static int FindCurrentDepth(int screen)
        {
            return (int)Functions.XDefaultDepth(API.DefaultDisplay, screen);
        }

        #endregion

        bool ChangeResolutionXRandR(DisplayDevice device, DisplayResolution resolution)
        {
            using (new XLock(API.DefaultDisplay))
            {
                int screen = (int)device.id;
                IntPtr root = Functions.XRootWindow(API.DefaultDisplay, screen);
                IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, root);

                ushort current_rotation;
                int current_resolution_index = Functions.XRRConfigCurrentConfiguration(screen_config, out current_rotation);
                int new_resolution_index;
                if (resolution != null)
                    new_resolution_index = screenResolutionToIndex[screen]
                        [new DisplayResolution(0, 0, resolution.Width, resolution.Height, resolution.BitsPerPixel, 0)];
                else
                    new_resolution_index = deviceToDefaultResolution[device];

                Debug.Print("Changing size of screen {0} from {1} to {2}",
                    screen, current_resolution_index, new_resolution_index);

                int ret = 0;
                short refresh_rate =(short)(resolution != null ? resolution.RefreshRate : 0);
                if (refresh_rate > 0)
                {
                    ret = Functions.XRRSetScreenConfigAndRate(API.DefaultDisplay,
                    screen_config, root, new_resolution_index, current_rotation,
                    refresh_rate, IntPtr.Zero);
                }
                else
                {
                    ret = Functions.XRRSetScreenConfig(API.DefaultDisplay,
                    screen_config, root, new_resolution_index, current_rotation,
                    IntPtr.Zero);
                }

                if (ret != 0)
                {
                    Debug.Print("[Error] Change to resolution {0} failed with error {1}.",
                        resolution, (ErrorCode)ret);
                }

                return ret == 0;
            }
        }

        static bool ChangeResolutionXF86(DisplayDevice device, DisplayResolution resolution)
        {
            return false;
        }

        DisplayResolution GetXRandRResolution(DisplayDevice device)
        {
            int screen = (int)device.id;
            IntPtr root = Functions.XRootWindow(API.DefaultDisplay, screen);
            IntPtr screen_config = Functions.XRRGetScreenInfo(API.DefaultDisplay, root);
            
            ushort current_rotation;  // Not needed.
            int current_resolution_index = Functions.XRRConfigCurrentConfiguration(screen_config, out current_rotation);

            Functions.XRRFreeScreenConfigInfo(screen_config);

            // reverse lookup in the resolution index map
            foreach(var keyvalue in screenResolutionToIndex[screen])
            {
                if(keyvalue.Value == current_resolution_index)
                {
                    return keyvalue.Key;
                }
            }

            throw new Exception(
                string.Format("Could not find index {0} in resolution-index map for screen {1}.",
                current_resolution_index, screen));
        }

        DisplayResolution GetXF86Resolution(DisplayDevice device)
        {
            int screen = (int)device.id;

            int x;
            int y;
            API.XF86VidModeGetViewPort(API.DefaultDisplay, screen, out x, out y);

            int pixelClock;
            API.XF86VidModeModeLine currentMode;
            API.XF86VidModeGetModeLine(API.DefaultDisplay, screen, out pixelClock, out currentMode);
            var width = currentMode.hdisplay;
            var height = (currentMode.vdisplay == 0) ? currentMode.vsyncstart : currentMode.vdisplay;
            var bitsPerPixel = FindCurrentDepth(screen);
            var refreshRate = (pixelClock * 1000F) / (currentMode.vtotal * currentMode.htotal);

            return new DisplayResolution(x, y, width, height, bitsPerPixel, refreshRate);
        }

        #endregion

        #region IDisplayDeviceDriver Members

        public sealed override bool TryChangeResolution(DisplayDevice device, DisplayResolution resolution)
        {
            // If resolution is null, restore the default resolution (new_resolution_index = 0).

            if (xrandr_supported)
            {
                return ChangeResolutionXRandR(device, resolution);
            }
            else if (xf86_supported)
            {
                return ChangeResolutionXF86(device, resolution);
            }
            else
            {
                return false;
            }
        }

        public sealed override bool TryRestoreResolution(DisplayDevice device)
        {
            return TryChangeResolution(device, null);
        }

        public sealed override DisplayResolution GetResolution(DisplayDevice device)
        {
            if (xrandr_supported)
            {
                return GetXRandRResolution(device);
            }
            else if (xf86_supported)
            {
                return GetXF86Resolution(device);
            }
            else
            {
                throw new NotSupportedException("Cannot get device resolution.");
            }
        }

        #endregion
    }
}
