
using System;
using System.IO;
using Bind.GL2;

namespace Bind.VK
{
    class VK10Generator : Generator
    {
        public VK10Generator(Settings settings)
            : base(settings)
        {
            Profile = "vulkan";
            Version = "1.0";

            Settings.FunctionPrefix = "vk";
            Settings.ConstantPrefix = "VK_";
            Settings.EnumPrefix = "Vk";

            Settings.OutputClass = "VK";

            enumSpec = Path.Combine("VK", "signatures.xml");
            glSpec = Path.Combine("VK", "signatures.xml");

            Settings.DefaultOutputNamespace = "OpenTK.Graphics.Vulkan";
            Settings.DefaultImportsFile = "VKCore.cs";
            Settings.DefaultDelegatesFile = "VKDelegates.cs";
            Settings.DefaultEnumsFile = "VKEnums.cs";
            Settings.DefaultWrappersFile = "VK.cs";
            Settings.DefaultStructsFile = "VKStructures.cs";
            Settings.DefaultHandlesFile = "VKHandles.tt";
            Settings.DefaultDocPath = Path.Combine(
                Settings.DefaultDocPath, "VK");
            Settings.DefaultOutputPath = Path.Combine(
                Settings.DefaultOutputPath, "../VK");

            Settings.OverridesFiles.Add("VK/overrides.xml");
        }
    }
}

