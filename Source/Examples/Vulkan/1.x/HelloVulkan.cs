// This code was written for the OpenTK library and has been released
// to the Public Domain.
// It is provided "as is" without express or implied warranty of any kind.

using System;
using System.Diagnostics;
using System.IO;

using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.Vulkan;
using System.Runtime.InteropServices;

namespace Examples.Tutorial
{
    [Example("Hello Vulkan", ExampleCategory.Vulkan, "1.x", Documentation = "HelloVulkan")]
    public unsafe class HelloVulkan : GameWindow
    {
        public HelloVulkan()
            : base(640, 480,
            new GraphicsMode(), "Vulkan Example", 0,
            DisplayDevice.Default, 1, 0,
            GraphicsContextFlags.Vulkan | GraphicsContextFlags.Debug)
        { }

        protected override void OnLoad(System.EventArgs e)
        {
            VSync = VSyncMode.On;

            var appInfo = new ApplicationInfo()
            {
                apiVersion = (147 << 12),
                pAppName = (char*)Marshal.StringToHGlobalUni("Hello Triangle").ToPointer(),
                appVersion = 1,
            };

            var pCreateInfo = new InstanceCreateInfo()
            {
                pAppInfo = &appInfo,
            };

            var pInstance = new Instance();
            VK.CreateInstance(ref pCreateInfo, ref pInstance);

            var pPhysicalDeviceCount = new int[1];
            VK.EnumeratePhysicalDevices(pInstance, pPhysicalDeviceCount, null);
            var pPhysicalDevices = new PhysicalDevice[pPhysicalDeviceCount[0]];
            VK.EnumeratePhysicalDevices(pInstance, pPhysicalDeviceCount, pPhysicalDevices);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            var keyboard = OpenTK.Input.Keyboard.GetState();
            if (keyboard[OpenTK.Input.Key.Escape])
                Exit();
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            SwapBuffers();
        }

        [STAThread]
        public static void Main()
        {
            using (HelloVulkan example = new HelloVulkan())
            {
                Utilities.SetWindowTitle(example);
                example.Run(30);
            }
        }
    }
}