using System;
using System.Collections.Generic;
using System.Text;

namespace OpenTK.Graphics.Vulkan
{
    /// <summary>
    /// Provides access to Vulkan 1.x methods for the core profile.
    /// </summary>
    public sealed partial class VK
    {
        const string Library = "vulkan.dll";
        static readonly object sync_root = new object();

        static IntPtr[] EntryPoints;
        static byte[] EntryPointNames;
        static int[] EntryPointNameOffsets;
    }
}
