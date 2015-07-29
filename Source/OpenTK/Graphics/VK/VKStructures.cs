//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
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



namespace OpenTK.Graphics.Vulkan
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AllocCallbacks
    {
        void* pUserData;
        IntPtr pfnAlloc;
        IntPtr pfnFree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ApplicationInfo
    {
        StructureType sType;
        void* pNext;
        char* pAppName;
        uint appVersion;
        char* pEngineName;
        uint engineVersion;
        uint apiVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AttachmentDescription
    {
        StructureType sType;
        void* pNext;
        Format format;
        uint samples;
        AttachmentLoadOp loadOp;
        AttachmentStoreOp storeOp;
        AttachmentLoadOp stencilLoadOp;
        AttachmentStoreOp stencilStoreOp;
        ImageLayout initialLayout;
        ImageLayout finalLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AttachmentReference
    {
        uint attachment;
        ImageLayout layout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AttachmentViewCreateInfo
    {
        StructureType sType;
        void* pNext;
        Image image;
        Format format;
        uint mipLevel;
        uint baseArraySlice;
        uint arraySize;
        AttachmentViewCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferCopy
    {
        IntPtr srcOffset;
        IntPtr destOffset;
        IntPtr copySize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BufferCreateInfo
    {
        StructureType sType;
        void* pNext;
        IntPtr size;
        BufferUsageFlags usage;
        BufferCreateFlags flags;
        SharingMode sharingMode;
        uint queueFamilyCount;
        uint* pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferImageCopy
    {
        IntPtr bufferOffset;
        uint bufferRowLength;
        uint bufferImageHeight;
        ImageSubresource imageSubresource;
        Offset3D imageOffset;
        Extent3D imageExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BufferMemoryBarrier
    {
        StructureType sType;
        void* pNext;
        MemoryOutputFlags outputMask;
        MemoryInputFlags inputMask;
        uint srcQueueFamilyIndex;
        uint destQueueFamilyIndex;
        Buffer buffer;
        IntPtr offset;
        IntPtr size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BufferViewCreateInfo
    {
        StructureType sType;
        void* pNext;
        Buffer buffer;
        BufferViewType viewType;
        Format format;
        IntPtr offset;
        IntPtr range;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ChannelMapping
    {
        ChannelSwizzle r;
        ChannelSwizzle g;
        ChannelSwizzle b;
        ChannelSwizzle a;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct ClearColorValue
    {
        [FieldOffset(0)]
        fixed Single f32[4];
        [FieldOffset(0)]
        fixed int s32[4];
        [FieldOffset(0)]
        fixed uint u32[4];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ClearDepthStencilValue
    {
        Single depth;
        uint stencil;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ClearValue
    {
        [FieldOffset(0)]
        ClearColorValue color;
        [FieldOffset(0)]
        ClearDepthStencilValue ds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CmdBufferBeginInfo
    {
        StructureType sType;
        void* pNext;
        CmdBufferOptimizeFlags flags;
        RenderPass renderPass;
        Framebuffer framebuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CmdBufferCreateInfo
    {
        StructureType sType;
        void* pNext;
        CmdPool cmdPool;
        CmdBufferLevel level;
        CmdBufferCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CmdPoolCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint queueFamilyIndex;
        CmdPoolCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ComputePipelineCreateInfo
    {
        StructureType sType;
        void* pNext;
        PipelineShaderStageCreateInfo cs;
        PipelineCreateFlags flags;
        PipelineLayout layout;
        Pipeline basePipelineHandle;
        int basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CopyDescriptorSet
    {
        StructureType sType;
        void* pNext;
        DescriptorSet srcSet;
        uint srcBinding;
        uint srcArrayElement;
        DescriptorSet destSet;
        uint destBinding;
        uint destArrayElement;
        uint count;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorInfo
    {
        BufferView bufferView;
        Sampler sampler;
        ImageView imageView;
        AttachmentView attachmentView;
        ImageLayout imageLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DescriptorPoolCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint count;
        DescriptorTypeCount* pTypeCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DescriptorSetLayoutBinding
    {
        DescriptorType descriptorType;
        uint arraySize;
        ShaderStageFlags stageFlags;
        Sampler* pImmutableSamplers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DescriptorSetLayoutCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint count;
        DescriptorSetLayoutBinding* pBinding;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorTypeCount
    {
        DescriptorType type;
        uint count;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DeviceCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint queueRecordCount;
        DeviceQueueCreateInfo* pRequestedQueues;
        uint layerCount;
        char** ppEnabledLayerNames;
        uint extensionCount;
        char** ppEnabledExtensionNames;
        PhysicalDeviceFeatures* pEnabledFeatures;
        DeviceCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceQueueCreateInfo
    {
        uint queueFamilyIndex;
        uint queueCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DispatchIndirectCmd
    {
        uint x;
        uint y;
        uint z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DrawIndexedIndirectCmd
    {
        uint indexCount;
        uint instanceCount;
        uint firstIndex;
        int vertexOffset;
        uint firstInstance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DrawIndirectCmd
    {
        uint vertexCount;
        uint instanceCount;
        uint firstVertex;
        uint firstInstance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DynamicColorBlendStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        fixed Single blendConst[4];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DynamicDepthStencilStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        Single minDepthBounds;
        Single maxDepthBounds;
        uint stencilReadMask;
        uint stencilWriteMask;
        uint stencilFrontRef;
        uint stencilBackRef;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DynamicRasterStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        Single depthBias;
        Single depthBiasClamp;
        Single slopeScaledDepthBias;
        Single lineWidth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DynamicViewportStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint viewportAndScissorCount;
        Viewport* pViewports;
        Rect2D* pScissors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct EventCreateInfo
    {
        StructureType sType;
        void* pNext;
        EventCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ExtensionProperties
    {
        char[] extName;
        uint specVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Extent2D
    {
        int width;
        int height;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Extent3D
    {
        int width;
        int height;
        int depth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FenceCreateInfo
    {
        StructureType sType;
        void* pNext;
        FenceCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FormatProperties
    {
        FormatFeatureFlags linearTilingFeatures;
        FormatFeatureFlags optimalTilingFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FramebufferCreateInfo
    {
        StructureType sType;
        void* pNext;
        RenderPass renderPass;
        uint attachmentCount;
        AttachmentView* pAttachments;
        uint width;
        uint height;
        uint layers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GraphicsPipelineCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint stageCount;
        PipelineShaderStageCreateInfo* pStages;
        PipelineVertexInputStateCreateInfo* pVertexInputState;
        PipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        PipelineTessellationStateCreateInfo* pTessellationState;
        PipelineViewportStateCreateInfo* pViewportState;
        PipelineRasterStateCreateInfo* pRasterState;
        PipelineMultisampleStateCreateInfo* pMultisampleState;
        PipelineDepthStencilStateCreateInfo* pDepthStencilState;
        PipelineColorBlendStateCreateInfo* pColorBlendState;
        PipelineCreateFlags flags;
        PipelineLayout layout;
        RenderPass renderPass;
        uint subpass;
        Pipeline basePipelineHandle;
        int basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageBlit
    {
        ImageSubresource srcSubresource;
        Offset3D srcOffset;
        Extent3D srcExtent;
        ImageSubresource destSubresource;
        Offset3D destOffset;
        Extent3D destExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageCopy
    {
        ImageSubresource srcSubresource;
        Offset3D srcOffset;
        ImageSubresource destSubresource;
        Offset3D destOffset;
        Extent3D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImageCreateInfo
    {
        StructureType sType;
        void* pNext;
        ImageType imageType;
        Format format;
        Extent3D extent;
        uint mipLevels;
        uint arraySize;
        uint samples;
        ImageTiling tiling;
        ImageUsageFlags usage;
        ImageCreateFlags flags;
        SharingMode sharingMode;
        uint queueFamilyCount;
        uint* pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageFormatProperties
    {
        ulong maxResourceSize;
        uint maxSamples;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImageMemoryBarrier
    {
        StructureType sType;
        void* pNext;
        MemoryOutputFlags outputMask;
        MemoryInputFlags inputMask;
        ImageLayout oldLayout;
        ImageLayout newLayout;
        uint srcQueueFamilyIndex;
        uint destQueueFamilyIndex;
        Image image;
        ImageSubresourceRange subresourceRange;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageResolve
    {
        ImageSubresource srcSubresource;
        Offset3D srcOffset;
        ImageSubresource destSubresource;
        Offset3D destOffset;
        Extent3D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageSubresource
    {
        ImageAspect aspect;
        uint mipLevel;
        uint arraySlice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageSubresourceRange
    {
        ImageAspect aspect;
        uint baseMipLevel;
        uint mipLevels;
        uint baseArraySlice;
        uint arraySize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImageViewCreateInfo
    {
        StructureType sType;
        void* pNext;
        Image image;
        ImageViewType viewType;
        Format format;
        ChannelMapping channels;
        ImageSubresourceRange subresourceRange;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct InstanceCreateInfo
    {
        StructureType sType;
        void* pNext;
        ApplicationInfo* pAppInfo;
        AllocCallbacks* pAllocCb;
        uint layerCount;
        char** ppEnabledLayerNames;
        uint extensionCount;
        char** ppEnabledExtensionNames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LayerProperties
    {
        char[] layerName;
        uint specVersion;
        uint implVersion;
        char[] description;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MappedMemoryRange
    {
        StructureType sType;
        void* pNext;
        DeviceMemory mem;
        IntPtr offset;
        IntPtr size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MemoryAllocInfo
    {
        StructureType sType;
        void* pNext;
        IntPtr allocationSize;
        uint memoryTypeIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MemoryBarrier
    {
        StructureType sType;
        void* pNext;
        MemoryOutputFlags outputMask;
        MemoryInputFlags inputMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryHeap
    {
        IntPtr size;
        MemoryHeapFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryRequirements
    {
        IntPtr size;
        IntPtr alignment;
        uint memoryTypeBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryType
    {
        MemoryPropertyFlags propertyFlags;
        uint heapIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Offset2D
    {
        int x;
        int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Offset3D
    {
        int x;
        int y;
        int z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceFeatures
    {
        bool robustBufferAccess;
        bool fullDrawIndexUint32;
        bool imageCubeArray;
        bool independentBlend;
        bool geometryShader;
        bool tessellationShader;
        bool sampleRateShading;
        bool dualSourceBlend;
        bool logicOp;
        bool instancedDrawIndirect;
        bool depthClip;
        bool depthBiasClamp;
        bool fillModeNonSolid;
        bool depthBounds;
        bool wideLines;
        bool largePoints;
        bool textureCompressionETC2;
        bool textureCompressionASTC_LDR;
        bool textureCompressionBC;
        bool pipelineStatisticsQuery;
        bool vertexSideEffects;
        bool tessellationSideEffects;
        bool geometrySideEffects;
        bool fragmentSideEffects;
        bool shaderTessellationPointSize;
        bool shaderGeometryPointSize;
        bool shaderTextureGatherExtended;
        bool shaderStorageImageExtendedFormats;
        bool shaderStorageImageMultisample;
        bool shaderStorageBufferArrayConstantIndexing;
        bool shaderStorageImageArrayConstantIndexing;
        bool shaderUniformBufferArrayDynamicIndexing;
        bool shaderSampledImageArrayDynamicIndexing;
        bool shaderStorageBufferArrayDynamicIndexing;
        bool shaderStorageImageArrayDynamicIndexing;
        bool shaderClipDistance;
        bool shaderCullDistance;
        bool shaderFloat64;
        bool shaderInt64;
        bool shaderFloat16;
        bool shaderInt16;
        bool shaderResourceResidency;
        bool shaderResourceMinLOD;
        bool sparse;
        bool sparseResidencyBuffer;
        bool sparseResidencyImage2D;
        bool sparseResidencyImage3D;
        bool sparseResidency2Samples;
        bool sparseResidency4Samples;
        bool sparseResidency8Samples;
        bool sparseResidency16Samples;
        bool sparseResidencyStandard2DBlockShape;
        bool sparseResidencyStandard2DMSBlockShape;
        bool sparseResidencyStandard3DBlockShape;
        bool sparseResidencyAlignedMipSize;
        bool sparseResidencyNonResident;
        bool sparseResidencyNonResidentStrict;
        bool sparseResidencyAliased;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceLimits
    {
        uint maxImageDimension1D;
        uint maxImageDimension2D;
        uint maxImageDimension3D;
        uint maxImageDimensionCube;
        uint maxImageArrayLayers;
        uint maxTexelBufferSize;
        uint maxUniformBufferSize;
        uint maxStorageBufferSize;
        uint maxPushConstantsSize;
        uint maxMemoryAllocationCount;
        IntPtr bufferImageGranularity;
        uint maxBoundDescriptorSets;
        uint maxDescriptorSets;
        uint maxPerStageDescriptorSamplers;
        uint maxPerStageDescriptorUniformBuffers;
        uint maxPerStageDescriptorStorageBuffers;
        uint maxPerStageDescriptorSampledImages;
        uint maxPerStageDescriptorStorageImages;
        uint maxDescriptorSetSamplers;
        uint maxDescriptorSetUniformBuffers;
        uint maxDescriptorSetStorageBuffers;
        uint maxDescriptorSetSampledImages;
        uint maxDescriptorSetStorageImages;
        uint maxVertexInputAttributes;
        uint maxVertexInputAttributeOffset;
        uint maxVertexInputBindingStride;
        uint maxVertexOutputComponents;
        uint maxTessGenLevel;
        uint maxTessPatchSize;
        uint maxTessControlPerVertexInputComponents;
        uint maxTessControlPerVertexOutputComponents;
        uint maxTessControlPerPatchOutputComponents;
        uint maxTessControlTotalOutputComponents;
        uint maxTessEvaluationInputComponents;
        uint maxTessEvaluationOutputComponents;
        uint maxGeometryShaderInvocations;
        uint maxGeometryInputComponents;
        uint maxGeometryOutputComponents;
        uint maxGeometryOutputVertices;
        uint maxGeometryTotalOutputComponents;
        uint maxFragmentInputComponents;
        uint maxFragmentOutputBuffers;
        uint maxFragmentDualSourceBuffers;
        uint maxFragmentCombinedOutputResources;
        uint maxComputeSharedMemorySize;
        fixed uint maxComputeWorkGroupCount[3];
        uint maxComputeWorkGroupInvocations;
        fixed uint maxComputeWorkGroupSize[3];
        uint subPixelPrecisionBits;
        uint subTexelPrecisionBits;
        uint mipmapPrecisionBits;
        uint maxDrawIndexedIndexValue;
        uint maxDrawIndirectInstanceCount;
        bool primitiveRestartForPatches;
        Single maxSamplerLodBias;
        Single maxSamplerAnisotropy;
        uint maxViewports;
        uint maxDynamicViewportStates;
        fixed uint maxViewportDimensions[2];
        fixed Single viewportBoundsRange[2];
        uint viewportSubPixelBits;
        uint minMemoryMapAlignment;
        uint minTexelBufferOffsetAlignment;
        uint minUniformBufferOffsetAlignment;
        uint minStorageBufferOffsetAlignment;
        uint minTexelOffset;
        uint maxTexelOffset;
        uint minTexelGatherOffset;
        uint maxTexelGatherOffset;
        Single minInterpolationOffset;
        Single maxInterpolationOffset;
        uint subPixelInterpolationOffsetBits;
        uint maxFramebufferWidth;
        uint maxFramebufferHeight;
        uint maxFramebufferLayers;
        uint maxFramebufferColorSamples;
        uint maxFramebufferDepthSamples;
        uint maxFramebufferStencilSamples;
        uint maxColorAttachments;
        uint maxSampledImageColorSamples;
        uint maxSampledImageDepthSamples;
        uint maxSampledImageIntegerSamples;
        uint maxStorageImageSamples;
        uint maxSampleMaskWords;
        ulong timestampFrequency;
        uint maxClipDistances;
        uint maxCullDistances;
        uint maxCombinedClipAndCullDistances;
        fixed Single pointSizeRange[2];
        fixed Single lineWidthRange[2];
        Single pointSizeGranularity;
        Single lineWidthGranularity;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceMemoryProperties
    {
        uint memoryTypeCount;
        MemoryType[] memoryTypes;
        uint memoryHeapCount;
        MemoryHeap[] memoryHeaps;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceProperties
    {
        uint apiVersion;
        uint driverVersion;
        uint vendorId;
        uint deviceId;
        PhysicalDeviceType deviceType;
        char[] deviceName;
        byte[] pipelineCacheUUID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineCacheCreateInfo
    {
        StructureType sType;
        void* pNext;
        IntPtr initialSize;
        void* initialData;
        IntPtr maxSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineColorBlendAttachmentState
    {
        bool blendEnable;
        Blend srcBlendColor;
        Blend destBlendColor;
        BlendOp blendOpColor;
        Blend srcBlendAlpha;
        Blend destBlendAlpha;
        BlendOp blendOpAlpha;
        ChannelFlags channelWriteMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineColorBlendStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        bool alphaToCoverageEnable;
        bool logicOpEnable;
        LogicOp logicOp;
        uint attachmentCount;
        PipelineColorBlendAttachmentState* pAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineDepthStencilStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        bool depthTestEnable;
        bool depthWriteEnable;
        CompareOp depthCompareOp;
        bool depthBoundsEnable;
        bool stencilTestEnable;
        StencilOpState front;
        StencilOpState back;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineInputAssemblyStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        PrimitiveTopology topology;
        bool primitiveRestartEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineLayoutCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint descriptorSetCount;
        DescriptorSetLayout* pSetLayouts;
        uint pushConstantRangeCount;
        PushConstantRange* pPushConstantRanges;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineMultisampleStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint rasterSamples;
        bool sampleShadingEnable;
        Single minSampleShading;
        uint sampleMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineRasterStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        bool depthClipEnable;
        bool rasterizerDiscardEnable;
        FillMode fillMode;
        CullMode cullMode;
        FrontFace frontFace;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineShaderStageCreateInfo
    {
        StructureType sType;
        void* pNext;
        ShaderStage stage;
        Shader shader;
        SpecializationInfo* pSpecializationInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineTessellationStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint patchControlPoints;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineVertexInputStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint bindingCount;
        VertexInputBindingDescription* pVertexBindingDescriptions;
        uint attributeCount;
        VertexInputAttributeDescription* pVertexAttributeDescriptions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineViewportStateCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint viewportCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PushConstantRange
    {
        ShaderStageFlags stageFlags;
        uint start;
        uint length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct QueryPoolCreateInfo
    {
        StructureType sType;
        void* pNext;
        QueryType queryType;
        uint slots;
        QueryPipelineStatisticFlags pipelineStatistics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QueueFamilyProperties
    {
        QueueFlags queueFlags;
        uint queueCount;
        bool supportsTimestamps;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Rect2D
    {
        Offset2D offset;
        Extent2D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Rect3D
    {
        Offset3D offset;
        Extent3D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RenderPassBeginInfo
    {
        StructureType sType;
        void* pNext;
        RenderPass renderPass;
        Framebuffer framebuffer;
        Rect2D renderArea;
        uint clearValueCount;
        ClearValue* pClearValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RenderPassCreateInfo
    {
        StructureType sType;
        void* pNext;
        uint attachmentCount;
        AttachmentDescription* pAttachments;
        uint subpassCount;
        SubpassDescription* pSubpasses;
        uint dependencyCount;
        SubpassDependency* pDependencies;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SamplerCreateInfo
    {
        StructureType sType;
        void* pNext;
        TexFilter magFilter;
        TexFilter minFilter;
        TexMipmapMode mipMode;
        TexAddress addressU;
        TexAddress addressV;
        TexAddress addressW;
        Single mipLodBias;
        Single maxAnisotropy;
        bool compareEnable;
        CompareOp compareOp;
        Single minLod;
        Single maxLod;
        BorderColor borderColor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SemaphoreCreateInfo
    {
        StructureType sType;
        void* pNext;
        SemaphoreCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ShaderCreateInfo
    {
        StructureType sType;
        void* pNext;
        ShaderModule module;
        char* pName;
        ShaderCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ShaderModuleCreateInfo
    {
        StructureType sType;
        void* pNext;
        IntPtr codeSize;
        void* pCode;
        ShaderModuleCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageFormatProperties
    {
        ImageAspect aspect;
        Extent3D imageGranularity;
        SparseImageFormatFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageMemoryBindInfo
    {
        ImageSubresource subresource;
        Offset3D offset;
        Extent3D extent;
        IntPtr memOffset;
        DeviceMemory mem;
        SparseMemoryBindFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageMemoryRequirements
    {
        SparseImageFormatProperties formatProps;
        uint imageMipTailStartLOD;
        IntPtr imageMipTailSize;
        IntPtr imageMipTailOffset;
        IntPtr imageMipTailStride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseMemoryBindInfo
    {
        IntPtr offset;
        IntPtr memOffset;
        DeviceMemory mem;
        SparseMemoryBindFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SpecializationInfo
    {
        uint mapEntryCount;
        SpecializationMapEntry* pMap;
        IntPtr dataSize;
        void* pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpecializationMapEntry
    {
        uint constantId;
        IntPtr size;
        uint offset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct StencilOpState
    {
        StencilOp stencilFailOp;
        StencilOp stencilPassOp;
        StencilOp stencilDepthFailOp;
        CompareOp stencilCompareOp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SubpassDependency
    {
        StructureType sType;
        void* pNext;
        uint srcSubpass;
        uint destSubpass;
        PipelineStageFlags srcStageMask;
        PipelineStageFlags destStageMask;
        MemoryOutputFlags outputMask;
        MemoryInputFlags inputMask;
        bool byRegion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SubpassDescription
    {
        StructureType sType;
        void* pNext;
        PipelineBindPoint pipelineBindPoint;
        SubpassDescriptionFlags flags;
        uint inputCount;
        AttachmentReference* pInputAttachments;
        uint colorCount;
        AttachmentReference* pColorAttachments;
        AttachmentReference* pResolveAttachments;
        AttachmentReference depthStencilAttachment;
        uint preserveCount;
        AttachmentReference* pPreserveAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SubresourceLayout
    {
        IntPtr offset;
        IntPtr size;
        IntPtr rowPitch;
        IntPtr depthPitch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VertexInputAttributeDescription
    {
        uint location;
        uint binding;
        Format format;
        uint offsetInBytes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VertexInputBindingDescription
    {
        uint binding;
        uint strideInBytes;
        VertexInputStepRate stepRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Viewport
    {
        Single originX;
        Single originY;
        Single width;
        Single height;
        Single minDepth;
        Single maxDepth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct WriteDescriptorSet
    {
        StructureType sType;
        void* pNext;
        DescriptorSet destSet;
        uint destBinding;
        uint destArrayElement;
        uint count;
        DescriptorType descriptorType;
        DescriptorInfo* pDescriptors;
    }
}
