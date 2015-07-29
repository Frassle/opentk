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
    public struct AllocCallbacks
    {
        void* pUserData;
        PFN_vkAllocFunction pfnAlloc;
        PFN_vkFreeFunction pfnFree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ApplicationInfo
    {
        StructureType sType;
        const void* pNext;
        const char* pAppName;
        uint32_t appVersion;
        const char* pEngineName;
        uint32_t engineVersion;
        uint32_t apiVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AttachmentDescription
    {
        StructureType sType;
        const void* pNext;
        Format format;
        uint32_t samples;
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
        uint32_t attachment;
        ImageLayout layout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AttachmentViewCreateInfo
    {
        StructureType sType;
        const void* pNext;
        Image image;
        Format format;
        uint32_t mipLevel;
        uint32_t baseArraySlice;
        uint32_t arraySize;
        AttachmentViewCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferCopy
    {
        DeviceSize srcOffset;
        DeviceSize destOffset;
        DeviceSize copySize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferCreateInfo
    {
        StructureType sType;
        const void* pNext;
        DeviceSize size;
        BufferUsageFlags usage;
        BufferCreateFlags flags;
        SharingMode sharingMode;
        uint32_t queueFamilyCount;
        const uint32_t* pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferImageCopy
    {
        DeviceSize bufferOffset;
        uint32_t bufferRowLength;
        uint32_t bufferImageHeight;
        ImageSubresource imageSubresource;
        Offset3D imageOffset;
        Extent3D imageExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferMemoryBarrier
    {
        StructureType sType;
        const void* pNext;
        MemoryOutputFlags outputMask;
        MemoryInputFlags inputMask;
        uint32_t srcQueueFamilyIndex;
        uint32_t destQueueFamilyIndex;
        Buffer buffer;
        DeviceSize offset;
        DeviceSize size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferViewCreateInfo
    {
        StructureType sType;
        const void* pNext;
        Buffer buffer;
        BufferViewType viewType;
        Format format;
        DeviceSize offset;
        DeviceSize range;
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
    public struct ClearColorValue
    {
        [FieldOffset(0)]
        float [4] f32;
        [FieldOffset(0)]
        int32_t [4] s32;
        [FieldOffset(0)]
        uint32_t [4] u32;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ClearDepthStencilValue
    {
        float depth;
        uint32_t stencil;
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
    public struct CmdBufferBeginInfo
    {
        StructureType sType;
        const void* pNext;
        CmdBufferOptimizeFlags flags;
        RenderPass renderPass;
        Framebuffer framebuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CmdBufferCreateInfo
    {
        StructureType sType;
        const void* pNext;
        CmdPool cmdPool;
        CmdBufferLevel level;
        CmdBufferCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CmdPoolCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t queueFamilyIndex;
        CmdPoolCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ComputePipelineCreateInfo
    {
        StructureType sType;
        const void* pNext;
        PipelineShaderStageCreateInfo cs;
        PipelineCreateFlags flags;
        PipelineLayout layout;
        Pipeline basePipelineHandle;
        int32_t basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CopyDescriptorSet
    {
        StructureType sType;
        const void* pNext;
        DescriptorSet srcSet;
        uint32_t srcBinding;
        uint32_t srcArrayElement;
        DescriptorSet destSet;
        uint32_t destBinding;
        uint32_t destArrayElement;
        uint32_t count;
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
    public struct DescriptorPoolCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t count;
        const DescriptorTypeCount* pTypeCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorSetLayoutBinding
    {
        DescriptorType descriptorType;
        uint32_t arraySize;
        ShaderStageFlags stageFlags;
        const Sampler* pImmutableSamplers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorSetLayoutCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t count;
        const DescriptorSetLayoutBinding* pBinding;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorTypeCount
    {
        DescriptorType type;
        uint32_t count;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t queueRecordCount;
        const DeviceQueueCreateInfo* pRequestedQueues;
        uint32_t layerCount;
        const char*const* ppEnabledLayerNames;
        uint32_t extensionCount;
        const char*const* ppEnabledExtensionNames;
        const PhysicalDeviceFeatures* pEnabledFeatures;
        DeviceCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceQueueCreateInfo
    {
        uint32_t queueFamilyIndex;
        uint32_t queueCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DispatchIndirectCmd
    {
        uint32_t x;
        uint32_t y;
        uint32_t z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DrawIndexedIndirectCmd
    {
        uint32_t indexCount;
        uint32_t instanceCount;
        uint32_t firstIndex;
        int32_t vertexOffset;
        uint32_t firstInstance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DrawIndirectCmd
    {
        uint32_t vertexCount;
        uint32_t instanceCount;
        uint32_t firstVertex;
        uint32_t firstInstance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DynamicColorBlendStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        float [4] blendConst;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DynamicDepthStencilStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        float minDepthBounds;
        float maxDepthBounds;
        uint32_t stencilReadMask;
        uint32_t stencilWriteMask;
        uint32_t stencilFrontRef;
        uint32_t stencilBackRef;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DynamicRasterStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        float depthBias;
        float depthBiasClamp;
        float slopeScaledDepthBias;
        float lineWidth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DynamicViewportStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t viewportAndScissorCount;
        const Viewport* pViewports;
        const Rect2D* pScissors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct EventCreateInfo
    {
        StructureType sType;
        const void* pNext;
        EventCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ExtensionProperties
    {
        char [] extName;
        uint32_t specVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Extent2D
    {
        int32_t width;
        int32_t height;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Extent3D
    {
        int32_t width;
        int32_t height;
        int32_t depth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FenceCreateInfo
    {
        StructureType sType;
        const void* pNext;
        FenceCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FormatProperties
    {
        FormatFeatureFlags linearTilingFeatures;
        FormatFeatureFlags optimalTilingFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FramebufferCreateInfo
    {
        StructureType sType;
        const void* pNext;
        RenderPass renderPass;
        uint32_t attachmentCount;
        const AttachmentView* pAttachments;
        uint32_t width;
        uint32_t height;
        uint32_t layers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct GraphicsPipelineCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t stageCount;
        const PipelineShaderStageCreateInfo* pStages;
        const PipelineVertexInputStateCreateInfo* pVertexInputState;
        const PipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        const PipelineTessellationStateCreateInfo* pTessellationState;
        const PipelineViewportStateCreateInfo* pViewportState;
        const PipelineRasterStateCreateInfo* pRasterState;
        const PipelineMultisampleStateCreateInfo* pMultisampleState;
        const PipelineDepthStencilStateCreateInfo* pDepthStencilState;
        const PipelineColorBlendStateCreateInfo* pColorBlendState;
        PipelineCreateFlags flags;
        PipelineLayout layout;
        RenderPass renderPass;
        uint32_t subpass;
        Pipeline basePipelineHandle;
        int32_t basePipelineIndex;
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
    public struct ImageCreateInfo
    {
        StructureType sType;
        const void* pNext;
        ImageType imageType;
        Format format;
        Extent3D extent;
        uint32_t mipLevels;
        uint32_t arraySize;
        uint32_t samples;
        ImageTiling tiling;
        ImageUsageFlags usage;
        ImageCreateFlags flags;
        SharingMode sharingMode;
        uint32_t queueFamilyCount;
        const uint32_t* pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageFormatProperties
    {
        uint64_t maxResourceSize;
        uint32_t maxSamples;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageMemoryBarrier
    {
        StructureType sType;
        const void* pNext;
        MemoryOutputFlags outputMask;
        MemoryInputFlags inputMask;
        ImageLayout oldLayout;
        ImageLayout newLayout;
        uint32_t srcQueueFamilyIndex;
        uint32_t destQueueFamilyIndex;
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
        uint32_t mipLevel;
        uint32_t arraySlice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageSubresourceRange
    {
        ImageAspect aspect;
        uint32_t baseMipLevel;
        uint32_t mipLevels;
        uint32_t baseArraySlice;
        uint32_t arraySize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageViewCreateInfo
    {
        StructureType sType;
        const void* pNext;
        Image image;
        ImageViewType viewType;
        Format format;
        ChannelMapping channels;
        ImageSubresourceRange subresourceRange;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct InstanceCreateInfo
    {
        StructureType sType;
        const void* pNext;
        const ApplicationInfo* pAppInfo;
        const AllocCallbacks* pAllocCb;
        uint32_t layerCount;
        const char*const* ppEnabledLayerNames;
        uint32_t extensionCount;
        const char*const* ppEnabledExtensionNames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LayerProperties
    {
        char [] layerName;
        uint32_t specVersion;
        uint32_t implVersion;
        char [] description;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MappedMemoryRange
    {
        StructureType sType;
        const void* pNext;
        DeviceMemory mem;
        DeviceSize offset;
        DeviceSize size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryAllocInfo
    {
        StructureType sType;
        const void* pNext;
        DeviceSize allocationSize;
        uint32_t memoryTypeIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryBarrier
    {
        StructureType sType;
        const void* pNext;
        MemoryOutputFlags outputMask;
        MemoryInputFlags inputMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryHeap
    {
        DeviceSize size;
        MemoryHeapFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryRequirements
    {
        DeviceSize size;
        DeviceSize alignment;
        uint32_t memoryTypeBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryType
    {
        MemoryPropertyFlags propertyFlags;
        uint32_t heapIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Offset2D
    {
        int32_t x;
        int32_t y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Offset3D
    {
        int32_t x;
        int32_t y;
        int32_t z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceFeatures
    {
        Bool32 robustBufferAccess;
        Bool32 fullDrawIndexUint32;
        Bool32 imageCubeArray;
        Bool32 independentBlend;
        Bool32 geometryShader;
        Bool32 tessellationShader;
        Bool32 sampleRateShading;
        Bool32 dualSourceBlend;
        Bool32 logicOp;
        Bool32 instancedDrawIndirect;
        Bool32 depthClip;
        Bool32 depthBiasClamp;
        Bool32 fillModeNonSolid;
        Bool32 depthBounds;
        Bool32 wideLines;
        Bool32 largePoints;
        Bool32 textureCompressionETC2;
        Bool32 textureCompressionASTC_LDR;
        Bool32 textureCompressionBC;
        Bool32 pipelineStatisticsQuery;
        Bool32 vertexSideEffects;
        Bool32 tessellationSideEffects;
        Bool32 geometrySideEffects;
        Bool32 fragmentSideEffects;
        Bool32 shaderTessellationPointSize;
        Bool32 shaderGeometryPointSize;
        Bool32 shaderTextureGatherExtended;
        Bool32 shaderStorageImageExtendedFormats;
        Bool32 shaderStorageImageMultisample;
        Bool32 shaderStorageBufferArrayConstantIndexing;
        Bool32 shaderStorageImageArrayConstantIndexing;
        Bool32 shaderUniformBufferArrayDynamicIndexing;
        Bool32 shaderSampledImageArrayDynamicIndexing;
        Bool32 shaderStorageBufferArrayDynamicIndexing;
        Bool32 shaderStorageImageArrayDynamicIndexing;
        Bool32 shaderClipDistance;
        Bool32 shaderCullDistance;
        Bool32 shaderFloat64;
        Bool32 shaderInt64;
        Bool32 shaderFloat16;
        Bool32 shaderInt16;
        Bool32 shaderResourceResidency;
        Bool32 shaderResourceMinLOD;
        Bool32 sparse;
        Bool32 sparseResidencyBuffer;
        Bool32 sparseResidencyImage2D;
        Bool32 sparseResidencyImage3D;
        Bool32 sparseResidency2Samples;
        Bool32 sparseResidency4Samples;
        Bool32 sparseResidency8Samples;
        Bool32 sparseResidency16Samples;
        Bool32 sparseResidencyStandard2DBlockShape;
        Bool32 sparseResidencyStandard2DMSBlockShape;
        Bool32 sparseResidencyStandard3DBlockShape;
        Bool32 sparseResidencyAlignedMipSize;
        Bool32 sparseResidencyNonResident;
        Bool32 sparseResidencyNonResidentStrict;
        Bool32 sparseResidencyAliased;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceLimits
    {
        uint32_t maxImageDimension1D;
        uint32_t maxImageDimension2D;
        uint32_t maxImageDimension3D;
        uint32_t maxImageDimensionCube;
        uint32_t maxImageArrayLayers;
        uint32_t maxTexelBufferSize;
        uint32_t maxUniformBufferSize;
        uint32_t maxStorageBufferSize;
        uint32_t maxPushConstantsSize;
        uint32_t maxMemoryAllocationCount;
        DeviceSize bufferImageGranularity;
        uint32_t maxBoundDescriptorSets;
        uint32_t maxDescriptorSets;
        uint32_t maxPerStageDescriptorSamplers;
        uint32_t maxPerStageDescriptorUniformBuffers;
        uint32_t maxPerStageDescriptorStorageBuffers;
        uint32_t maxPerStageDescriptorSampledImages;
        uint32_t maxPerStageDescriptorStorageImages;
        uint32_t maxDescriptorSetSamplers;
        uint32_t maxDescriptorSetUniformBuffers;
        uint32_t maxDescriptorSetStorageBuffers;
        uint32_t maxDescriptorSetSampledImages;
        uint32_t maxDescriptorSetStorageImages;
        uint32_t maxVertexInputAttributes;
        uint32_t maxVertexInputAttributeOffset;
        uint32_t maxVertexInputBindingStride;
        uint32_t maxVertexOutputComponents;
        uint32_t maxTessGenLevel;
        uint32_t maxTessPatchSize;
        uint32_t maxTessControlPerVertexInputComponents;
        uint32_t maxTessControlPerVertexOutputComponents;
        uint32_t maxTessControlPerPatchOutputComponents;
        uint32_t maxTessControlTotalOutputComponents;
        uint32_t maxTessEvaluationInputComponents;
        uint32_t maxTessEvaluationOutputComponents;
        uint32_t maxGeometryShaderInvocations;
        uint32_t maxGeometryInputComponents;
        uint32_t maxGeometryOutputComponents;
        uint32_t maxGeometryOutputVertices;
        uint32_t maxGeometryTotalOutputComponents;
        uint32_t maxFragmentInputComponents;
        uint32_t maxFragmentOutputBuffers;
        uint32_t maxFragmentDualSourceBuffers;
        uint32_t maxFragmentCombinedOutputResources;
        uint32_t maxComputeSharedMemorySize;
        uint32_t [3] maxComputeWorkGroupCount;
        uint32_t maxComputeWorkGroupInvocations;
        uint32_t [3] maxComputeWorkGroupSize;
        uint32_t subPixelPrecisionBits;
        uint32_t subTexelPrecisionBits;
        uint32_t mipmapPrecisionBits;
        uint32_t maxDrawIndexedIndexValue;
        uint32_t maxDrawIndirectInstanceCount;
        Bool32 primitiveRestartForPatches;
        float maxSamplerLodBias;
        float maxSamplerAnisotropy;
        uint32_t maxViewports;
        uint32_t maxDynamicViewportStates;
        uint32_t [2] maxViewportDimensions;
        float [2] viewportBoundsRange;
        uint32_t viewportSubPixelBits;
        uint32_t minMemoryMapAlignment;
        uint32_t minTexelBufferOffsetAlignment;
        uint32_t minUniformBufferOffsetAlignment;
        uint32_t minStorageBufferOffsetAlignment;
        uint32_t minTexelOffset;
        uint32_t maxTexelOffset;
        uint32_t minTexelGatherOffset;
        uint32_t maxTexelGatherOffset;
        float minInterpolationOffset;
        float maxInterpolationOffset;
        uint32_t subPixelInterpolationOffsetBits;
        uint32_t maxFramebufferWidth;
        uint32_t maxFramebufferHeight;
        uint32_t maxFramebufferLayers;
        uint32_t maxFramebufferColorSamples;
        uint32_t maxFramebufferDepthSamples;
        uint32_t maxFramebufferStencilSamples;
        uint32_t maxColorAttachments;
        uint32_t maxSampledImageColorSamples;
        uint32_t maxSampledImageDepthSamples;
        uint32_t maxSampledImageIntegerSamples;
        uint32_t maxStorageImageSamples;
        uint32_t maxSampleMaskWords;
        uint64_t timestampFrequency;
        uint32_t maxClipDistances;
        uint32_t maxCullDistances;
        uint32_t maxCombinedClipAndCullDistances;
        float [2] pointSizeRange;
        float [2] lineWidthRange;
        float pointSizeGranularity;
        float lineWidthGranularity;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceMemoryProperties
    {
        uint32_t memoryTypeCount;
        MemoryType [] memoryTypes;
        uint32_t memoryHeapCount;
        MemoryHeap [] memoryHeaps;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceProperties
    {
        uint32_t apiVersion;
        uint32_t driverVersion;
        uint32_t vendorId;
        uint32_t deviceId;
        PhysicalDeviceType deviceType;
        char [] deviceName;
        uint8_t [] pipelineCacheUUID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineCacheCreateInfo
    {
        StructureType sType;
        const void* pNext;
        size_t initialSize;
        const void* initialData;
        size_t maxSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineColorBlendAttachmentState
    {
        Bool32 blendEnable;
        Blend srcBlendColor;
        Blend destBlendColor;
        BlendOp blendOpColor;
        Blend srcBlendAlpha;
        Blend destBlendAlpha;
        BlendOp blendOpAlpha;
        ChannelFlags channelWriteMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineColorBlendStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        Bool32 alphaToCoverageEnable;
        Bool32 logicOpEnable;
        LogicOp logicOp;
        uint32_t attachmentCount;
        const PipelineColorBlendAttachmentState* pAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineDepthStencilStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        Bool32 depthTestEnable;
        Bool32 depthWriteEnable;
        CompareOp depthCompareOp;
        Bool32 depthBoundsEnable;
        Bool32 stencilTestEnable;
        StencilOpState front;
        StencilOpState back;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineInputAssemblyStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        PrimitiveTopology topology;
        Bool32 primitiveRestartEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineLayoutCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t descriptorSetCount;
        const DescriptorSetLayout* pSetLayouts;
        uint32_t pushConstantRangeCount;
        const PushConstantRange* pPushConstantRanges;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineMultisampleStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t rasterSamples;
        Bool32 sampleShadingEnable;
        float minSampleShading;
        SampleMask sampleMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineRasterStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        Bool32 depthClipEnable;
        Bool32 rasterizerDiscardEnable;
        FillMode fillMode;
        CullMode cullMode;
        FrontFace frontFace;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineShaderStageCreateInfo
    {
        StructureType sType;
        const void* pNext;
        ShaderStage stage;
        Shader shader;
        const SpecializationInfo* pSpecializationInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineTessellationStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t patchControlPoints;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineVertexInputStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t bindingCount;
        const VertexInputBindingDescription* pVertexBindingDescriptions;
        uint32_t attributeCount;
        const VertexInputAttributeDescription* pVertexAttributeDescriptions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineViewportStateCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t viewportCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PushConstantRange
    {
        ShaderStageFlags stageFlags;
        uint32_t start;
        uint32_t length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QueryPoolCreateInfo
    {
        StructureType sType;
        const void* pNext;
        QueryType queryType;
        uint32_t slots;
        QueryPipelineStatisticFlags pipelineStatistics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QueueFamilyProperties
    {
        QueueFlags queueFlags;
        uint32_t queueCount;
        Bool32 supportsTimestamps;
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
    public struct RenderPassBeginInfo
    {
        StructureType sType;
        const void* pNext;
        RenderPass renderPass;
        Framebuffer framebuffer;
        Rect2D renderArea;
        uint32_t clearValueCount;
        const ClearValue* pClearValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RenderPassCreateInfo
    {
        StructureType sType;
        const void* pNext;
        uint32_t attachmentCount;
        const AttachmentDescription* pAttachments;
        uint32_t subpassCount;
        const SubpassDescription* pSubpasses;
        uint32_t dependencyCount;
        const SubpassDependency* pDependencies;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SamplerCreateInfo
    {
        StructureType sType;
        const void* pNext;
        TexFilter magFilter;
        TexFilter minFilter;
        TexMipmapMode mipMode;
        TexAddress addressU;
        TexAddress addressV;
        TexAddress addressW;
        float mipLodBias;
        float maxAnisotropy;
        Bool32 compareEnable;
        CompareOp compareOp;
        float minLod;
        float maxLod;
        BorderColor borderColor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SemaphoreCreateInfo
    {
        StructureType sType;
        const void* pNext;
        SemaphoreCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ShaderCreateInfo
    {
        StructureType sType;
        const void* pNext;
        ShaderModule module;
        const char* pName;
        ShaderCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ShaderModuleCreateInfo
    {
        StructureType sType;
        const void* pNext;
        size_t codeSize;
        const void* pCode;
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
        DeviceSize memOffset;
        DeviceMemory mem;
        SparseMemoryBindFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageMemoryRequirements
    {
        SparseImageFormatProperties formatProps;
        uint32_t imageMipTailStartLOD;
        DeviceSize imageMipTailSize;
        DeviceSize imageMipTailOffset;
        DeviceSize imageMipTailStride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseMemoryBindInfo
    {
        DeviceSize offset;
        DeviceSize memOffset;
        DeviceMemory mem;
        SparseMemoryBindFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpecializationInfo
    {
        uint32_t mapEntryCount;
        const SpecializationMapEntry* pMap;
        size_t dataSize;
        const void* pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpecializationMapEntry
    {
        uint32_t constantId;
        size_t size;
        uint32_t offset;
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
    public struct SubpassDependency
    {
        StructureType sType;
        const void* pNext;
        uint32_t srcSubpass;
        uint32_t destSubpass;
        PipelineStageFlags srcStageMask;
        PipelineStageFlags destStageMask;
        MemoryOutputFlags outputMask;
        MemoryInputFlags inputMask;
        Bool32 byRegion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SubpassDescription
    {
        StructureType sType;
        const void* pNext;
        PipelineBindPoint pipelineBindPoint;
        SubpassDescriptionFlags flags;
        uint32_t inputCount;
        const AttachmentReference* pInputAttachments;
        uint32_t colorCount;
        const AttachmentReference* pColorAttachments;
        const AttachmentReference* pResolveAttachments;
        AttachmentReference depthStencilAttachment;
        uint32_t preserveCount;
        const AttachmentReference* pPreserveAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SubresourceLayout
    {
        DeviceSize offset;
        DeviceSize size;
        DeviceSize rowPitch;
        DeviceSize depthPitch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VertexInputAttributeDescription
    {
        uint32_t location;
        uint32_t binding;
        Format format;
        uint32_t offsetInBytes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VertexInputBindingDescription
    {
        uint32_t binding;
        uint32_t strideInBytes;
        VertexInputStepRate stepRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Viewport
    {
        float originX;
        float originY;
        float width;
        float height;
        float minDepth;
        float maxDepth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct WriteDescriptorSet
    {
        StructureType sType;
        const void* pNext;
        DescriptorSet destSet;
        uint32_t destBinding;
        uint32_t destArrayElement;
        uint32_t count;
        DescriptorType descriptorType;
        const DescriptorInfo* pDescriptors;
    }
}
