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
        public void* pUserData;
        public IntPtr pfnAlloc;
        public IntPtr pfnFree;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ApplicationInfo
    {
        public StructureType sType;
        public void* pNext;
        public char* pAppName;
        public uint appVersion;
        public char* pEngineName;
        public uint engineVersion;
        public uint apiVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AttachmentDescription
    {
        public StructureType sType;
        public void* pNext;
        public Format format;
        public uint samples;
        public AttachmentLoadOp loadOp;
        public AttachmentStoreOp storeOp;
        public AttachmentLoadOp stencilLoadOp;
        public AttachmentStoreOp stencilStoreOp;
        public ImageLayout initialLayout;
        public ImageLayout finalLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct AttachmentReference
    {
        public uint attachment;
        public ImageLayout layout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct AttachmentViewCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public Image image;
        public Format format;
        public uint mipLevel;
        public uint baseArraySlice;
        public uint arraySize;
        public AttachmentViewCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferCopy
    {
        public IntPtr srcOffset;
        public IntPtr destOffset;
        public IntPtr copySize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BufferCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public IntPtr size;
        public BufferUsageFlags usage;
        public BufferCreateFlags flags;
        public SharingMode sharingMode;
        public uint queueFamilyCount;
        public uint* pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct BufferImageCopy
    {
        public IntPtr bufferOffset;
        public uint bufferRowLength;
        public uint bufferImageHeight;
        public ImageSubresource imageSubresource;
        public Offset3D imageOffset;
        public Extent3D imageExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BufferMemoryBarrier
    {
        public StructureType sType;
        public void* pNext;
        public MemoryOutputFlags outputMask;
        public MemoryInputFlags inputMask;
        public uint srcQueueFamilyIndex;
        public uint destQueueFamilyIndex;
        public Buffer buffer;
        public IntPtr offset;
        public IntPtr size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct BufferViewCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public Buffer buffer;
        public BufferViewType viewType;
        public Format format;
        public IntPtr offset;
        public IntPtr range;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ChannelMapping
    {
        public ChannelSwizzle r;
        public ChannelSwizzle g;
        public ChannelSwizzle b;
        public ChannelSwizzle a;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct ClearColorValue
    {
        [FieldOffset(0)]
        public fixed Single f32[4];
        [FieldOffset(0)]
        public fixed int s32[4];
        [FieldOffset(0)]
        public fixed uint u32[4];
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ClearDepthStencilValue
    {
        public Single depth;
        public uint stencil;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ClearValue
    {
        [FieldOffset(0)]
        public ClearColorValue color;
        [FieldOffset(0)]
        public ClearDepthStencilValue ds;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CmdBufferBeginInfo
    {
        public StructureType sType;
        public void* pNext;
        public CmdBufferOptimizeFlags flags;
        public RenderPass renderPass;
        public Framebuffer framebuffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CmdBufferCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public CmdPool cmdPool;
        public CmdBufferLevel level;
        public CmdBufferCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CmdPoolCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint queueFamilyIndex;
        public CmdPoolCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ComputePipelineCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public PipelineShaderStageCreateInfo cs;
        public PipelineCreateFlags flags;
        public PipelineLayout layout;
        public Pipeline basePipelineHandle;
        public int basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct CopyDescriptorSet
    {
        public StructureType sType;
        public void* pNext;
        public DescriptorSet srcSet;
        public uint srcBinding;
        public uint srcArrayElement;
        public DescriptorSet destSet;
        public uint destBinding;
        public uint destArrayElement;
        public uint count;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorInfo
    {
        public BufferView bufferView;
        public Sampler sampler;
        public ImageView imageView;
        public AttachmentView attachmentView;
        public ImageLayout imageLayout;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DescriptorPoolCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint count;
        public DescriptorTypeCount* pTypeCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DescriptorSetLayoutBinding
    {
        public DescriptorType descriptorType;
        public uint arraySize;
        public ShaderStageFlags stageFlags;
        public Sampler* pImmutableSamplers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DescriptorSetLayoutCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint count;
        public DescriptorSetLayoutBinding* pBinding;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DescriptorTypeCount
    {
        public DescriptorType type;
        public uint count;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DeviceCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint queueRecordCount;
        public DeviceQueueCreateInfo* pRequestedQueues;
        public uint layerCount;
        public char** ppEnabledLayerNames;
        public uint extensionCount;
        public char** ppEnabledExtensionNames;
        public PhysicalDeviceFeatures* pEnabledFeatures;
        public DeviceCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DeviceQueueCreateInfo
    {
        public uint queueFamilyIndex;
        public uint queueCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DispatchIndirectCmd
    {
        public uint x;
        public uint y;
        public uint z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DrawIndexedIndirectCmd
    {
        public uint indexCount;
        public uint instanceCount;
        public uint firstIndex;
        public int vertexOffset;
        public uint firstInstance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DrawIndirectCmd
    {
        public uint vertexCount;
        public uint instanceCount;
        public uint firstVertex;
        public uint firstInstance;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DynamicColorBlendStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public fixed Single blendConst[4];
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DynamicDepthStencilStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public Single minDepthBounds;
        public Single maxDepthBounds;
        public uint stencilReadMask;
        public uint stencilWriteMask;
        public uint stencilFrontRef;
        public uint stencilBackRef;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DynamicRasterStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public Single depthBias;
        public Single depthBiasClamp;
        public Single slopeScaledDepthBias;
        public Single lineWidth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct DynamicViewportStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint viewportAndScissorCount;
        public Viewport* pViewports;
        public Rect2D* pScissors;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct EventCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public EventCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ExtensionProperties
    {
        public char* extName;
        public uint specVersion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Extent2D
    {
        public int width;
        public int height;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Extent3D
    {
        public int width;
        public int height;
        public int depth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FenceCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public FenceCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct FormatProperties
    {
        public FormatFeatureFlags linearTilingFeatures;
        public FormatFeatureFlags optimalTilingFeatures;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct FramebufferCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public RenderPass renderPass;
        public uint attachmentCount;
        public AttachmentView* pAttachments;
        public uint width;
        public uint height;
        public uint layers;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct GraphicsPipelineCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint stageCount;
        public PipelineShaderStageCreateInfo* pStages;
        public PipelineVertexInputStateCreateInfo* pVertexInputState;
        public PipelineInputAssemblyStateCreateInfo* pInputAssemblyState;
        public PipelineTessellationStateCreateInfo* pTessellationState;
        public PipelineViewportStateCreateInfo* pViewportState;
        public PipelineRasterStateCreateInfo* pRasterState;
        public PipelineMultisampleStateCreateInfo* pMultisampleState;
        public PipelineDepthStencilStateCreateInfo* pDepthStencilState;
        public PipelineColorBlendStateCreateInfo* pColorBlendState;
        public PipelineCreateFlags flags;
        public PipelineLayout layout;
        public RenderPass renderPass;
        public uint subpass;
        public Pipeline basePipelineHandle;
        public int basePipelineIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageBlit
    {
        public ImageSubresource srcSubresource;
        public Offset3D srcOffset;
        public Extent3D srcExtent;
        public ImageSubresource destSubresource;
        public Offset3D destOffset;
        public Extent3D destExtent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageCopy
    {
        public ImageSubresource srcSubresource;
        public Offset3D srcOffset;
        public ImageSubresource destSubresource;
        public Offset3D destOffset;
        public Extent3D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImageCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public ImageType imageType;
        public Format format;
        public Extent3D extent;
        public uint mipLevels;
        public uint arraySize;
        public uint samples;
        public ImageTiling tiling;
        public ImageUsageFlags usage;
        public ImageCreateFlags flags;
        public SharingMode sharingMode;
        public uint queueFamilyCount;
        public uint* pQueueFamilyIndices;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageFormatProperties
    {
        public ulong maxResourceSize;
        public uint maxSamples;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImageMemoryBarrier
    {
        public StructureType sType;
        public void* pNext;
        public MemoryOutputFlags outputMask;
        public MemoryInputFlags inputMask;
        public ImageLayout oldLayout;
        public ImageLayout newLayout;
        public uint srcQueueFamilyIndex;
        public uint destQueueFamilyIndex;
        public Image image;
        public ImageSubresourceRange subresourceRange;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageResolve
    {
        public ImageSubresource srcSubresource;
        public Offset3D srcOffset;
        public ImageSubresource destSubresource;
        public Offset3D destOffset;
        public Extent3D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageSubresource
    {
        public ImageAspect aspect;
        public uint mipLevel;
        public uint arraySlice;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ImageSubresourceRange
    {
        public ImageAspect aspect;
        public uint baseMipLevel;
        public uint mipLevels;
        public uint baseArraySlice;
        public uint arraySize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ImageViewCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public Image image;
        public ImageViewType viewType;
        public Format format;
        public ChannelMapping channels;
        public ImageSubresourceRange subresourceRange;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct InstanceCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public ApplicationInfo* pAppInfo;
        public AllocCallbacks* pAllocCb;
        public uint layerCount;
        public char** ppEnabledLayerNames;
        public uint extensionCount;
        public char** ppEnabledExtensionNames;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct LayerProperties
    {
        public char* layerName;
        public uint specVersion;
        public uint implVersion;
        public char* description;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MappedMemoryRange
    {
        public StructureType sType;
        public void* pNext;
        public DeviceMemory mem;
        public IntPtr offset;
        public IntPtr size;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MemoryAllocInfo
    {
        public StructureType sType;
        public void* pNext;
        public IntPtr allocationSize;
        public uint memoryTypeIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct MemoryBarrier
    {
        public StructureType sType;
        public void* pNext;
        public MemoryOutputFlags outputMask;
        public MemoryInputFlags inputMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryHeap
    {
        public IntPtr size;
        public MemoryHeapFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryRequirements
    {
        public IntPtr size;
        public IntPtr alignment;
        public uint memoryTypeBits;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct MemoryType
    {
        public MemoryPropertyFlags propertyFlags;
        public uint heapIndex;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Offset2D
    {
        public int x;
        public int y;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Offset3D
    {
        public int x;
        public int y;
        public int z;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PhysicalDeviceFeatures
    {
        public bool robustBufferAccess;
        public bool fullDrawIndexUint32;
        public bool imageCubeArray;
        public bool independentBlend;
        public bool geometryShader;
        public bool tessellationShader;
        public bool sampleRateShading;
        public bool dualSourceBlend;
        public bool logicOp;
        public bool instancedDrawIndirect;
        public bool depthClip;
        public bool depthBiasClamp;
        public bool fillModeNonSolid;
        public bool depthBounds;
        public bool wideLines;
        public bool largePoints;
        public bool textureCompressionETC2;
        public bool textureCompressionASTC_LDR;
        public bool textureCompressionBC;
        public bool pipelineStatisticsQuery;
        public bool vertexSideEffects;
        public bool tessellationSideEffects;
        public bool geometrySideEffects;
        public bool fragmentSideEffects;
        public bool shaderTessellationPointSize;
        public bool shaderGeometryPointSize;
        public bool shaderTextureGatherExtended;
        public bool shaderStorageImageExtendedFormats;
        public bool shaderStorageImageMultisample;
        public bool shaderStorageBufferArrayConstantIndexing;
        public bool shaderStorageImageArrayConstantIndexing;
        public bool shaderUniformBufferArrayDynamicIndexing;
        public bool shaderSampledImageArrayDynamicIndexing;
        public bool shaderStorageBufferArrayDynamicIndexing;
        public bool shaderStorageImageArrayDynamicIndexing;
        public bool shaderClipDistance;
        public bool shaderCullDistance;
        public bool shaderFloat64;
        public bool shaderInt64;
        public bool shaderFloat16;
        public bool shaderInt16;
        public bool shaderResourceResidency;
        public bool shaderResourceMinLOD;
        public bool sparse;
        public bool sparseResidencyBuffer;
        public bool sparseResidencyImage2D;
        public bool sparseResidencyImage3D;
        public bool sparseResidency2Samples;
        public bool sparseResidency4Samples;
        public bool sparseResidency8Samples;
        public bool sparseResidency16Samples;
        public bool sparseResidencyStandard2DBlockShape;
        public bool sparseResidencyStandard2DMSBlockShape;
        public bool sparseResidencyStandard3DBlockShape;
        public bool sparseResidencyAlignedMipSize;
        public bool sparseResidencyNonResident;
        public bool sparseResidencyNonResidentStrict;
        public bool sparseResidencyAliased;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceLimits
    {
        public uint maxImageDimension1D;
        public uint maxImageDimension2D;
        public uint maxImageDimension3D;
        public uint maxImageDimensionCube;
        public uint maxImageArrayLayers;
        public uint maxTexelBufferSize;
        public uint maxUniformBufferSize;
        public uint maxStorageBufferSize;
        public uint maxPushConstantsSize;
        public uint maxMemoryAllocationCount;
        public IntPtr bufferImageGranularity;
        public uint maxBoundDescriptorSets;
        public uint maxDescriptorSets;
        public uint maxPerStageDescriptorSamplers;
        public uint maxPerStageDescriptorUniformBuffers;
        public uint maxPerStageDescriptorStorageBuffers;
        public uint maxPerStageDescriptorSampledImages;
        public uint maxPerStageDescriptorStorageImages;
        public uint maxDescriptorSetSamplers;
        public uint maxDescriptorSetUniformBuffers;
        public uint maxDescriptorSetStorageBuffers;
        public uint maxDescriptorSetSampledImages;
        public uint maxDescriptorSetStorageImages;
        public uint maxVertexInputAttributes;
        public uint maxVertexInputAttributeOffset;
        public uint maxVertexInputBindingStride;
        public uint maxVertexOutputComponents;
        public uint maxTessGenLevel;
        public uint maxTessPatchSize;
        public uint maxTessControlPerVertexInputComponents;
        public uint maxTessControlPerVertexOutputComponents;
        public uint maxTessControlPerPatchOutputComponents;
        public uint maxTessControlTotalOutputComponents;
        public uint maxTessEvaluationInputComponents;
        public uint maxTessEvaluationOutputComponents;
        public uint maxGeometryShaderInvocations;
        public uint maxGeometryInputComponents;
        public uint maxGeometryOutputComponents;
        public uint maxGeometryOutputVertices;
        public uint maxGeometryTotalOutputComponents;
        public uint maxFragmentInputComponents;
        public uint maxFragmentOutputBuffers;
        public uint maxFragmentDualSourceBuffers;
        public uint maxFragmentCombinedOutputResources;
        public uint maxComputeSharedMemorySize;
        public fixed uint maxComputeWorkGroupCount[3];
        public uint maxComputeWorkGroupInvocations;
        public fixed uint maxComputeWorkGroupSize[3];
        public uint subPixelPrecisionBits;
        public uint subTexelPrecisionBits;
        public uint mipmapPrecisionBits;
        public uint maxDrawIndexedIndexValue;
        public uint maxDrawIndirectInstanceCount;
        public bool primitiveRestartForPatches;
        public Single maxSamplerLodBias;
        public Single maxSamplerAnisotropy;
        public uint maxViewports;
        public uint maxDynamicViewportStates;
        public fixed uint maxViewportDimensions[2];
        public fixed Single viewportBoundsRange[2];
        public uint viewportSubPixelBits;
        public uint minMemoryMapAlignment;
        public uint minTexelBufferOffsetAlignment;
        public uint minUniformBufferOffsetAlignment;
        public uint minStorageBufferOffsetAlignment;
        public uint minTexelOffset;
        public uint maxTexelOffset;
        public uint minTexelGatherOffset;
        public uint maxTexelGatherOffset;
        public Single minInterpolationOffset;
        public Single maxInterpolationOffset;
        public uint subPixelInterpolationOffsetBits;
        public uint maxFramebufferWidth;
        public uint maxFramebufferHeight;
        public uint maxFramebufferLayers;
        public uint maxFramebufferColorSamples;
        public uint maxFramebufferDepthSamples;
        public uint maxFramebufferStencilSamples;
        public uint maxColorAttachments;
        public uint maxSampledImageColorSamples;
        public uint maxSampledImageDepthSamples;
        public uint maxSampledImageIntegerSamples;
        public uint maxStorageImageSamples;
        public uint maxSampleMaskWords;
        public ulong timestampFrequency;
        public uint maxClipDistances;
        public uint maxCullDistances;
        public uint maxCombinedClipAndCullDistances;
        public fixed Single pointSizeRange[2];
        public fixed Single lineWidthRange[2];
        public Single pointSizeGranularity;
        public Single lineWidthGranularity;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceMemoryProperties
    {
        public uint memoryTypeCount;
        public MemoryType* memoryTypes;
        public uint memoryHeapCount;
        public MemoryHeap* memoryHeaps;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PhysicalDeviceProperties
    {
        public uint apiVersion;
        public uint driverVersion;
        public uint vendorId;
        public uint deviceId;
        public PhysicalDeviceType deviceType;
        public char* deviceName;
        public byte* pipelineCacheUUID;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineCacheCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public IntPtr initialSize;
        public void* initialData;
        public IntPtr maxSize;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PipelineColorBlendAttachmentState
    {
        public bool blendEnable;
        public Blend srcBlendColor;
        public Blend destBlendColor;
        public BlendOp blendOpColor;
        public Blend srcBlendAlpha;
        public Blend destBlendAlpha;
        public BlendOp blendOpAlpha;
        public ChannelFlags channelWriteMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineColorBlendStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public bool alphaToCoverageEnable;
        public bool logicOpEnable;
        public LogicOp logicOp;
        public uint attachmentCount;
        public PipelineColorBlendAttachmentState* pAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineDepthStencilStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public bool depthTestEnable;
        public bool depthWriteEnable;
        public CompareOp depthCompareOp;
        public bool depthBoundsEnable;
        public bool stencilTestEnable;
        public StencilOpState front;
        public StencilOpState back;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineInputAssemblyStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public PrimitiveTopology topology;
        public bool primitiveRestartEnable;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineLayoutCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint descriptorSetCount;
        public DescriptorSetLayout* pSetLayouts;
        public uint pushConstantRangeCount;
        public PushConstantRange* pPushConstantRanges;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineMultisampleStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint rasterSamples;
        public bool sampleShadingEnable;
        public Single minSampleShading;
        public uint sampleMask;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineRasterStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public bool depthClipEnable;
        public bool rasterizerDiscardEnable;
        public FillMode fillMode;
        public CullMode cullMode;
        public FrontFace frontFace;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineShaderStageCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public ShaderStage stage;
        public Shader shader;
        public SpecializationInfo* pSpecializationInfo;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineTessellationStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint patchControlPoints;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineVertexInputStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint bindingCount;
        public VertexInputBindingDescription* pVertexBindingDescriptions;
        public uint attributeCount;
        public VertexInputAttributeDescription* pVertexAttributeDescriptions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct PipelineViewportStateCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint viewportCount;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct PushConstantRange
    {
        public ShaderStageFlags stageFlags;
        public uint start;
        public uint length;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct QueryPoolCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public QueryType queryType;
        public uint slots;
        public QueryPipelineStatisticFlags pipelineStatistics;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct QueueFamilyProperties
    {
        public QueueFlags queueFlags;
        public uint queueCount;
        public bool supportsTimestamps;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Rect2D
    {
        public Offset2D offset;
        public Extent2D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Rect3D
    {
        public Offset3D offset;
        public Extent3D extent;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RenderPassBeginInfo
    {
        public StructureType sType;
        public void* pNext;
        public RenderPass renderPass;
        public Framebuffer framebuffer;
        public Rect2D renderArea;
        public uint clearValueCount;
        public ClearValue* pClearValues;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct RenderPassCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public uint attachmentCount;
        public AttachmentDescription* pAttachments;
        public uint subpassCount;
        public SubpassDescription* pSubpasses;
        public uint dependencyCount;
        public SubpassDependency* pDependencies;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SamplerCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public TexFilter magFilter;
        public TexFilter minFilter;
        public TexMipmapMode mipMode;
        public TexAddress addressU;
        public TexAddress addressV;
        public TexAddress addressW;
        public Single mipLodBias;
        public Single maxAnisotropy;
        public bool compareEnable;
        public CompareOp compareOp;
        public Single minLod;
        public Single maxLod;
        public BorderColor borderColor;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SemaphoreCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public SemaphoreCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ShaderCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public ShaderModule module;
        public char* pName;
        public ShaderCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ShaderModuleCreateInfo
    {
        public StructureType sType;
        public void* pNext;
        public IntPtr codeSize;
        public void* pCode;
        public ShaderModuleCreateFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageFormatProperties
    {
        public ImageAspect aspect;
        public Extent3D imageGranularity;
        public SparseImageFormatFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageMemoryBindInfo
    {
        public ImageSubresource subresource;
        public Offset3D offset;
        public Extent3D extent;
        public IntPtr memOffset;
        public DeviceMemory mem;
        public SparseMemoryBindFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseImageMemoryRequirements
    {
        public SparseImageFormatProperties formatProps;
        public uint imageMipTailStartLOD;
        public IntPtr imageMipTailSize;
        public IntPtr imageMipTailOffset;
        public IntPtr imageMipTailStride;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SparseMemoryBindInfo
    {
        public IntPtr offset;
        public IntPtr memOffset;
        public DeviceMemory mem;
        public SparseMemoryBindFlags flags;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SpecializationInfo
    {
        public uint mapEntryCount;
        public SpecializationMapEntry* pMap;
        public IntPtr dataSize;
        public void* pData;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SpecializationMapEntry
    {
        public uint constantId;
        public IntPtr size;
        public uint offset;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct StencilOpState
    {
        public StencilOp stencilFailOp;
        public StencilOp stencilPassOp;
        public StencilOp stencilDepthFailOp;
        public CompareOp stencilCompareOp;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SubpassDependency
    {
        public StructureType sType;
        public void* pNext;
        public uint srcSubpass;
        public uint destSubpass;
        public PipelineStageFlags srcStageMask;
        public PipelineStageFlags destStageMask;
        public MemoryOutputFlags outputMask;
        public MemoryInputFlags inputMask;
        public bool byRegion;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct SubpassDescription
    {
        public StructureType sType;
        public void* pNext;
        public PipelineBindPoint pipelineBindPoint;
        public SubpassDescriptionFlags flags;
        public uint inputCount;
        public AttachmentReference* pInputAttachments;
        public uint colorCount;
        public AttachmentReference* pColorAttachments;
        public AttachmentReference* pResolveAttachments;
        public AttachmentReference depthStencilAttachment;
        public uint preserveCount;
        public AttachmentReference* pPreserveAttachments;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct SubresourceLayout
    {
        public IntPtr offset;
        public IntPtr size;
        public IntPtr rowPitch;
        public IntPtr depthPitch;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VertexInputAttributeDescription
    {
        public uint location;
        public uint binding;
        public Format format;
        public uint offsetInBytes;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct VertexInputBindingDescription
    {
        public uint binding;
        public uint strideInBytes;
        public VertexInputStepRate stepRate;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Viewport
    {
        public Single originX;
        public Single originY;
        public Single width;
        public Single height;
        public Single minDepth;
        public Single maxDepth;
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct WriteDescriptorSet
    {
        public StructureType sType;
        public void* pNext;
        public DescriptorSet destSet;
        public uint destBinding;
        public uint destArrayElement;
        public uint count;
        public DescriptorType descriptorType;
        public DescriptorInfo* pDescriptors;
    }
}
