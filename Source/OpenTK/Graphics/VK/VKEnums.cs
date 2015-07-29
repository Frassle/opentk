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



using System;

namespace OpenTK.Graphics.Vulkan
{
    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum All : int
    {
        /// <summary>
        /// Original was VK_ATTACHMENT_LOAD_OP_LOAD = 0
        /// </summary>
        AttachmentLoadOpLoad = ((int)0),
        /// <summary>
        /// Original was VK_ATTACHMENT_STORE_OP_STORE = 0
        /// </summary>
        AttachmentStoreOpStore = ((int)0),
        /// <summary>
        /// Original was VK_BLEND_OP_ADD = 0
        /// </summary>
        BlendOpAdd = ((int)0),
        /// <summary>
        /// Original was VK_BLEND_ZERO = 0
        /// </summary>
        BlendZero = ((int)0),
        /// <summary>
        /// Original was VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = 0
        /// </summary>
        BorderColorFloatTransparentBlack = ((int)0),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_GENERAL = 0
        /// </summary>
        BufferUsageGeneral = ((int)0),
        /// <summary>
        /// Original was VK_BUFFER_VIEW_TYPE_RAW = 0
        /// </summary>
        BufferViewTypeRaw = ((int)0),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_ZERO = 0
        /// </summary>
        ChannelSwizzleZero = ((int)0),
        /// <summary>
        /// Original was VK_CMD_BUFFER_LEVEL_PRIMARY = 0
        /// </summary>
        CmdBufferLevelPrimary = ((int)0),
        /// <summary>
        /// Original was VK_COMPARE_OP_NEVER = 0
        /// </summary>
        CompareOpNever = ((int)0),
        /// <summary>
        /// Original was VK_CULL_MODE_NONE = 0
        /// </summary>
        CullModeNone = ((int)0),
        /// <summary>
        /// Original was VK_DESCRIPTOR_POOL_USAGE_ONE_SHOT = 0
        /// </summary>
        DescriptorPoolUsageOneShot = ((int)0),
        /// <summary>
        /// Original was VK_DESCRIPTOR_SET_USAGE_ONE_SHOT = 0
        /// </summary>
        DescriptorSetUsageOneShot = ((int)0),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_SAMPLER = 0
        /// </summary>
        DescriptorTypeSampler = ((int)0),
        /// <summary>
        /// Original was VK_FILL_MODE_POINTS = 0
        /// </summary>
        FillModePoints = ((int)0),
        /// <summary>
        /// Original was VK_FORMAT_UNDEFINED = 0
        /// </summary>
        FormatUndefined = ((int)0),
        /// <summary>
        /// Original was VK_FRONT_FACE_CCW = 0
        /// </summary>
        FrontFaceCcw = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_COLOR = 0
        /// </summary>
        ImageAspectColor = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_UNDEFINED = 0
        /// </summary>
        ImageLayoutUndefined = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_TILING_LINEAR = 0
        /// </summary>
        ImageTilingLinear = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_TYPE_1D = 0
        /// </summary>
        ImageType1D = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_GENERAL = 0
        /// </summary>
        ImageUsageGeneral = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_1D = 0
        /// </summary>
        ImageViewType1D = ((int)0),
        /// <summary>
        /// Original was VK_INDEX_TYPE_UINT16 = 0
        /// </summary>
        IndexTypeUint16 = ((int)0),
        /// <summary>
        /// Original was VK_LOGIC_OP_CLEAR = 0
        /// </summary>
        LogicOpClear = ((int)0),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_DEVICE_ONLY = 0
        /// </summary>
        MemoryPropertyDeviceOnly = ((int)0),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_OTHER = 0
        /// </summary>
        PhysicalDeviceTypeOther = ((int)0),
        /// <summary>
        /// Original was VK_PIPELINE_BIND_POINT_COMPUTE = 0
        /// </summary>
        PipelineBindPointCompute = ((int)0),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_POINT_LIST = 0
        /// </summary>
        PrimitiveTopologyPointList = ((int)0),
        /// <summary>
        /// Original was VK_QUERY_RESULT_DEFAULT = 0
        /// </summary>
        QueryResultDefault = ((int)0),
        /// <summary>
        /// Original was VK_QUERY_TYPE_OCCLUSION = 0
        /// </summary>
        QueryTypeOcclusion = ((int)0),
        /// <summary>
        /// Original was VK_RENDER_PASS_CONTENTS_INLINE = 0
        /// </summary>
        RenderPassContentsInline = ((int)0),
        /// <summary>
        /// Original was VK_SHADER_STAGE_VERTEX = 0
        /// </summary>
        ShaderStageVertex = ((int)0),
        /// <summary>
        /// Original was VK_SHARING_MODE_EXCLUSIVE = 0
        /// </summary>
        SharingModeExclusive = ((int)0),
        /// <summary>
        /// Original was VK_STENCIL_OP_KEEP = 0
        /// </summary>
        StencilOpKeep = ((int)0),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_APPLICATION_INFO = 0
        /// </summary>
        StructureTypeApplicationInfo = ((int)0),
        /// <summary>
        /// Original was VK_SUCCESS = 0
        /// </summary>
        Success = ((int)0),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_API_OBJECT = 0
        /// </summary>
        SystemAllocTypeApiObject = ((int)0),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_WRAP = 0
        /// </summary>
        TexAddressWrap = ((int)0),
        /// <summary>
        /// Original was VK_TEX_FILTER_NEAREST = 0
        /// </summary>
        TexFilterNearest = ((int)0),
        /// <summary>
        /// Original was VK_TEX_MIPMAP_MODE_BASE = 0
        /// </summary>
        TexMipmapModeBase = ((int)0),
        /// <summary>
        /// Original was VK_TIMESTAMP_TYPE_TOP = 0
        /// </summary>
        TimestampTypeTop = ((int)0),
        /// <summary>
        /// Original was VK_VERTEX_INPUT_STEP_RATE_VERTEX = 0
        /// </summary>
        VertexInputStepRateVertex = ((int)0),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_ALL_GRAPHICS = 0x000007FF
        /// </summary>
        PipelineStageAllGraphics = ((int)0x000007FF),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_ALL_GPU_COMMANDS = 0x00003FFF
        /// </summary>
        PipelineStageAllGpuCommands = ((int)0x00003FFF),
        /// <summary>
        /// Original was VK_ATTACHMENT_VIEW_CREATE_READ_ONLY_DEPTH_BIT = 0x1
        /// </summary>
        AttachmentViewCreateReadOnlyDepthBit = ((int)0x1),
        /// <summary>
        /// Original was VK_BUFFER_CREATE_SPARSE_BIT = 0x1
        /// </summary>
        BufferCreateSparseBit = ((int)0x1),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_TRANSFER_SOURCE_BIT = 0x1
        /// </summary>
        BufferUsageTransferSourceBit = ((int)0x1),
        /// <summary>
        /// Original was VK_CHANNEL_R_BIT = 0x1
        /// </summary>
        ChannelRBit = ((int)0x1),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_SMALL_BATCH_BIT = 0x1
        /// </summary>
        CmdBufferOptimizeSmallBatchBit = ((int)0x1),
        /// <summary>
        /// Original was VK_CMD_BUFFER_RESET_RELEASE_RESOURCES = 0x1
        /// </summary>
        CmdBufferResetReleaseResources = ((int)0x1),
        /// <summary>
        /// Original was VK_CMD_POOL_CREATE_TRANSIENT_BIT = 0x1
        /// </summary>
        CmdPoolCreateTransientBit = ((int)0x1),
        /// <summary>
        /// Original was VK_CMD_POOL_RESET_RELEASE_RESOURCES = 0x1
        /// </summary>
        CmdPoolResetReleaseResources = ((int)0x1),
        /// <summary>
        /// Original was VK_DEVICE_CREATE_VALIDATION_BIT = 0x1
        /// </summary>
        DeviceCreateValidationBit = ((int)0x1),
        /// <summary>
        /// Original was VK_FENCE_CREATE_SIGNALED_BIT = 0x1
        /// </summary>
        FenceCreateSignaledBit = ((int)0x1),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT = 0x1
        /// </summary>
        FormatFeatureSampledImageBit = ((int)0x1),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_COLOR_BIT = 0x1
        /// </summary>
        ImageAspectColorBit = ((int)0x1),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_SPARSE_BIT = 0x1
        /// </summary>
        ImageCreateSparseBit = ((int)0x1),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_TRANSFER_SOURCE_BIT = 0x1
        /// </summary>
        ImageUsageTransferSourceBit = ((int)0x1),
        /// <summary>
        /// Original was VK_MEMORY_HEAP_HOST_LOCAL = 0x1
        /// </summary>
        MemoryHeapHostLocal = ((int)0x1),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_HOST_READ_BIT = 0x1
        /// </summary>
        MemoryInputHostReadBit = ((int)0x1),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_HOST_WRITE_BIT = 0x1
        /// </summary>
        MemoryOutputHostWriteBit = ((int)0x1),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = 0x1
        /// </summary>
        MemoryPropertyHostVisibleBit = ((int)0x1),
        /// <summary>
        /// Original was VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = 0x1
        /// </summary>
        PipelineCreateDisableOptimizationBit = ((int)0x1),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT = 0x1
        /// </summary>
        PipelineStageTopOfPipeBit = ((int)0x1),
        /// <summary>
        /// Original was VK_QUERY_CONTROL_CONSERVATIVE_BIT = 0x1
        /// </summary>
        QueryControlConservativeBit = ((int)0x1),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_IA_VERTICES_BIT = 0x1
        /// </summary>
        QueryPipelineStatisticIaVerticesBit = ((int)0x1),
        /// <summary>
        /// Original was VK_QUERY_RESULT_64_BIT = 0x1
        /// </summary>
        QueryResult64Bit = ((int)0x1),
        /// <summary>
        /// Original was VK_QUEUE_GRAPHICS_BIT = 0x1
        /// </summary>
        QueueGraphicsBit = ((int)0x1),
        /// <summary>
        /// Original was VK_SHADER_STAGE_VERTEX_BIT = 0x1
        /// </summary>
        ShaderStageVertexBit = ((int)0x1),
        /// <summary>
        /// Original was VK_SPARSE_IMAGE_FMT_SINGLE_MIPTAIL_BIT = 0x1
        /// </summary>
        SparseImageFmtSingleMiptailBit = ((int)0x1),
        /// <summary>
        /// Original was VK_SPARSE_MEMORY_BIND_REPLICATE_64KIB_BLOCK_BIT = 0x1
        /// </summary>
        SparseMemoryBindReplicate64KibBlockBit = ((int)0x1),
        /// <summary>
        /// Original was VK_SUBPASS_DESCRIPTION_NO_OVERDRAW_BIT = 0x1
        /// </summary>
        SubpassDescriptionNoOverdrawBit = ((int)0x1),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = 0x10
        /// </summary>
        BufferUsageUniformBufferBit = ((int)0x10),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_NO_SIMULTANEOUS_USE_BIT = 0x10
        /// </summary>
        CmdBufferOptimizeNoSimultaneousUseBit = ((int)0x10),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT = 0x10
        /// </summary>
        FormatFeatureStorageTexelBufferBit = ((int)0x10),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT = 0x10
        /// </summary>
        ImageCreateMutableFormatBit = ((int)0x10),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = 0x10
        /// </summary>
        ImageUsageColorAttachmentBit = ((int)0x10),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_UNIFORM_READ_BIT = 0x10
        /// </summary>
        MemoryInputUniformReadBit = ((int)0x10),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_TRANSFER_BIT = 0x10
        /// </summary>
        MemoryOutputTransferBit = ((int)0x10),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = 0x10
        /// </summary>
        MemoryPropertyLazilyAllocatedBit = ((int)0x10),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TESS_CONTROL_SHADER_BIT = 0x10
        /// </summary>
        PipelineStageTessControlShaderBit = ((int)0x10),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_GS_PRIMITIVES_BIT = 0x10
        /// </summary>
        QueryPipelineStatisticGsPrimitivesBit = ((int)0x10),
        /// <summary>
        /// Original was VK_SHADER_STAGE_FRAGMENT_BIT = 0x10
        /// </summary>
        ShaderStageFragmentBit = ((int)0x10),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = 0x100
        /// </summary>
        BufferUsageIndirectBufferBit = ((int)0x100),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT = 0x100
        /// </summary>
        FormatFeatureColorAttachmentBlendBit = ((int)0x100),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_INPUT_ATTACHMENT_BIT = 0x100
        /// </summary>
        MemoryInputInputAttachmentBit = ((int)0x100),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT = 0x100
        /// </summary>
        PipelineStageEarlyFragmentTestsBit = ((int)0x100),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_TCS_PATCHES_BIT = 0x100
        /// </summary>
        QueryPipelineStatisticTcsPatchesBit = ((int)0x100),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TRANSFER_BIT = 0x1000
        /// </summary>
        PipelineStageTransferBit = ((int)0x1000),
        /// <summary>
        /// Original was VK_ATTACHMENT_VIEW_CREATE_READ_ONLY_STENCIL_BIT = 0x2
        /// </summary>
        AttachmentViewCreateReadOnlyStencilBit = ((int)0x2),
        /// <summary>
        /// Original was VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = 0x2
        /// </summary>
        BufferCreateSparseResidencyBit = ((int)0x2),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_TRANSFER_DESTINATION_BIT = 0x2
        /// </summary>
        BufferUsageTransferDestinationBit = ((int)0x2),
        /// <summary>
        /// Original was VK_CHANNEL_G_BIT = 0x2
        /// </summary>
        ChannelGBit = ((int)0x2),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_PIPELINE_SWITCH_BIT = 0x2
        /// </summary>
        CmdBufferOptimizePipelineSwitchBit = ((int)0x2),
        /// <summary>
        /// Original was VK_CMD_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = 0x2
        /// </summary>
        CmdPoolCreateResetCommandBufferBit = ((int)0x2),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT = 0x2
        /// </summary>
        FormatFeatureStorageImageBit = ((int)0x2),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_DEPTH_BIT = 0x2
        /// </summary>
        ImageAspectDepthBit = ((int)0x2),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT = 0x2
        /// </summary>
        ImageCreateSparseResidencyBit = ((int)0x2),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_TRANSFER_DESTINATION_BIT = 0x2
        /// </summary>
        ImageUsageTransferDestinationBit = ((int)0x2),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_INDIRECT_COMMAND_BIT = 0x2
        /// </summary>
        MemoryInputIndirectCommandBit = ((int)0x2),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_SHADER_WRITE_BIT = 0x2
        /// </summary>
        MemoryOutputShaderWriteBit = ((int)0x2),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_HOST_NON_COHERENT_BIT = 0x2
        /// </summary>
        MemoryPropertyHostNonCoherentBit = ((int)0x2),
        /// <summary>
        /// Original was VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = 0x2
        /// </summary>
        PipelineCreateAllowDerivativesBit = ((int)0x2),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT = 0x2
        /// </summary>
        PipelineStageDrawIndirectBit = ((int)0x2),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_IA_PRIMITIVES_BIT = 0x2
        /// </summary>
        QueryPipelineStatisticIaPrimitivesBit = ((int)0x2),
        /// <summary>
        /// Original was VK_QUERY_RESULT_WAIT_BIT = 0x2
        /// </summary>
        QueryResultWaitBit = ((int)0x2),
        /// <summary>
        /// Original was VK_QUEUE_COMPUTE_BIT = 0x2
        /// </summary>
        QueueComputeBit = ((int)0x2),
        /// <summary>
        /// Original was VK_SHADER_STAGE_TESS_CONTROL_BIT = 0x2
        /// </summary>
        ShaderStageTessControlBit = ((int)0x2),
        /// <summary>
        /// Original was VK_SPARSE_IMAGE_FMT_ALIGNED_MIP_SIZE_BIT = 0x2
        /// </summary>
        SparseImageFmtAlignedMipSizeBit = ((int)0x2),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = 0x20
        /// </summary>
        BufferUsageStorageBufferBit = ((int)0x20),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 0x20
        /// </summary>
        FormatFeatureStorageTexelBufferAtomicBit = ((int)0x20),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT = 0x20
        /// </summary>
        ImageCreateCubeCompatibleBit = ((int)0x20),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_DEPTH_STENCIL_BIT = 0x20
        /// </summary>
        ImageUsageDepthStencilBit = ((int)0x20),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_SHADER_READ_BIT = 0x20
        /// </summary>
        MemoryInputShaderReadBit = ((int)0x20),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TESS_EVALUATION_SHADER_BIT = 0x20
        /// </summary>
        PipelineStageTessEvaluationShaderBit = ((int)0x20),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_C_INVOCATIONS_BIT = 0x20
        /// </summary>
        QueryPipelineStatisticCInvocationsBit = ((int)0x20),
        /// <summary>
        /// Original was VK_SHADER_STAGE_COMPUTE_BIT = 0x20
        /// </summary>
        ShaderStageComputeBit = ((int)0x20),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT = 0x200
        /// </summary>
        FormatFeatureDepthStencilAttachmentBit = ((int)0x200),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_TRANSFER_BIT = 0x200
        /// </summary>
        MemoryInputTransferBit = ((int)0x200),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT = 0x200
        /// </summary>
        PipelineStageLateFragmentTestsBit = ((int)0x200),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_TES_INVOCATIONS_BIT = 0x200
        /// </summary>
        QueryPipelineStatisticTesInvocationsBit = ((int)0x200),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TRANSITION_BIT = 0x2000
        /// </summary>
        PipelineStageTransitionBit = ((int)0x2000),
        /// <summary>
        /// Original was VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = 0x4
        /// </summary>
        BufferCreateSparseAliasedBit = ((int)0x4),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = 0x4
        /// </summary>
        BufferUsageUniformTexelBufferBit = ((int)0x4),
        /// <summary>
        /// Original was VK_CHANNEL_B_BIT = 0x4
        /// </summary>
        ChannelBBit = ((int)0x4),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_ONE_TIME_SUBMIT_BIT = 0x4
        /// </summary>
        CmdBufferOptimizeOneTimeSubmitBit = ((int)0x4),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT = 0x4
        /// </summary>
        FormatFeatureStorageImageAtomicBit = ((int)0x4),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_STENCIL_BIT = 0x4
        /// </summary>
        ImageAspectStencilBit = ((int)0x4),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_SPARSE_ALIASED_BIT = 0x4
        /// </summary>
        ImageCreateSparseAliasedBit = ((int)0x4),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_SAMPLED_BIT = 0x4
        /// </summary>
        ImageUsageSampledBit = ((int)0x4),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_INDEX_FETCH_BIT = 0x4
        /// </summary>
        MemoryInputIndexFetchBit = ((int)0x4),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_COLOR_ATTACHMENT_BIT = 0x4
        /// </summary>
        MemoryOutputColorAttachmentBit = ((int)0x4),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_HOST_UNCACHED_BIT = 0x4
        /// </summary>
        MemoryPropertyHostUncachedBit = ((int)0x4),
        /// <summary>
        /// Original was VK_PIPELINE_CREATE_DERIVATIVE_BIT = 0x4
        /// </summary>
        PipelineCreateDerivativeBit = ((int)0x4),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_VERTEX_INPUT_BIT = 0x4
        /// </summary>
        PipelineStageVertexInputBit = ((int)0x4),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_VS_INVOCATIONS_BIT = 0x4
        /// </summary>
        QueryPipelineStatisticVsInvocationsBit = ((int)0x4),
        /// <summary>
        /// Original was VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = 0x4
        /// </summary>
        QueryResultWithAvailabilityBit = ((int)0x4),
        /// <summary>
        /// Original was VK_QUEUE_DMA_BIT = 0x4
        /// </summary>
        QueueDmaBit = ((int)0x4),
        /// <summary>
        /// Original was VK_SHADER_STAGE_TESS_EVALUATION_BIT = 0x4
        /// </summary>
        ShaderStageTessEvaluationBit = ((int)0x4),
        /// <summary>
        /// Original was VK_SPARSE_IMAGE_FMT_NONSTD_BLOCK_SIZE_BIT = 0x4
        /// </summary>
        SparseImageFmtNonstdBlockSizeBit = ((int)0x4),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_INDEX_BUFFER_BIT = 0x40
        /// </summary>
        BufferUsageIndexBufferBit = ((int)0x40),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT = 0x40
        /// </summary>
        FormatFeatureVertexBufferBit = ((int)0x40),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = 0x40
        /// </summary>
        ImageUsageTransientAttachmentBit = ((int)0x40),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_COLOR_ATTACHMENT_BIT = 0x40
        /// </summary>
        MemoryInputColorAttachmentBit = ((int)0x40),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT = 0x40
        /// </summary>
        PipelineStageGeometryShaderBit = ((int)0x40),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_C_PRIMITIVES_BIT = 0x40
        /// </summary>
        QueryPipelineStatisticCPrimitivesBit = ((int)0x40),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_CONVERSION_BIT = 0x400
        /// </summary>
        FormatFeatureConversionBit = ((int)0x400),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT = 0x400
        /// </summary>
        PipelineStageColorAttachmentOutputBit = ((int)0x400),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_CS_INVOCATIONS_BIT = 0x400
        /// </summary>
        QueryPipelineStatisticCsInvocationsBit = ((int)0x400),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_HOST_BIT = 0x4000
        /// </summary>
        PipelineStageHostBit = ((int)0x4000),
        /// <summary>
        /// Original was VK_QUEUE_EXTENDED_BIT = 0x40000000
        /// </summary>
        QueueExtendedBit = ((int)0x40000000),
        /// <summary>
        /// Original was VK_SHADER_STAGE_ALL = 0x7FFFFFFF
        /// </summary>
        ShaderStageAll = ((int)0x7FFFFFFF),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = 0x8
        /// </summary>
        BufferUsageStorageTexelBufferBit = ((int)0x8),
        /// <summary>
        /// Original was VK_CHANNEL_A_BIT = 0x8
        /// </summary>
        ChannelABit = ((int)0x8),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_DESCRIPTOR_SET_SWITCH_BIT = 0x8
        /// </summary>
        CmdBufferOptimizeDescriptorSetSwitchBit = ((int)0x8),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT = 0x8
        /// </summary>
        FormatFeatureUniformTexelBufferBit = ((int)0x8),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_METADATA_BIT = 0x8
        /// </summary>
        ImageAspectMetadataBit = ((int)0x8),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_INVARIANT_DATA_BIT = 0x8
        /// </summary>
        ImageCreateInvariantDataBit = ((int)0x8),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_STORAGE_BIT = 0x8
        /// </summary>
        ImageUsageStorageBit = ((int)0x8),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_VERTEX_ATTRIBUTE_FETCH_BIT = 0x8
        /// </summary>
        MemoryInputVertexAttributeFetchBit = ((int)0x8),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_DEPTH_STENCIL_ATTACHMENT_BIT = 0x8
        /// </summary>
        MemoryOutputDepthStencilAttachmentBit = ((int)0x8),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_HOST_WRITE_COMBINED_BIT = 0x8
        /// </summary>
        MemoryPropertyHostWriteCombinedBit = ((int)0x8),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_VERTEX_SHADER_BIT = 0x8
        /// </summary>
        PipelineStageVertexShaderBit = ((int)0x8),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_GS_INVOCATIONS_BIT = 0x8
        /// </summary>
        QueryPipelineStatisticGsInvocationsBit = ((int)0x8),
        /// <summary>
        /// Original was VK_QUERY_RESULT_PARTIAL_BIT = 0x8
        /// </summary>
        QueryResultPartialBit = ((int)0x8),
        /// <summary>
        /// Original was VK_QUEUE_SPARSE_MEMMGR_BIT = 0x8
        /// </summary>
        QueueSparseMemmgrBit = ((int)0x8),
        /// <summary>
        /// Original was VK_SHADER_STAGE_GEOMETRY_BIT = 0x8
        /// </summary>
        ShaderStageGeometryBit = ((int)0x8),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = 0x80
        /// </summary>
        BufferUsageVertexBufferBit = ((int)0x80),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT = 0x80
        /// </summary>
        FormatFeatureColorAttachmentBit = ((int)0x80),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = 0x80
        /// </summary>
        ImageUsageInputAttachmentBit = ((int)0x80),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_DEPTH_STENCIL_ATTACHMENT_BIT = 0x80
        /// </summary>
        MemoryInputDepthStencilAttachmentBit = ((int)0x80),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT = 0x80
        /// </summary>
        PipelineStageFragmentShaderBit = ((int)0x80),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_FS_INVOCATIONS_BIT = 0x80
        /// </summary>
        QueryPipelineStatisticFsInvocationsBit = ((int)0x80),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT = 0x800
        /// </summary>
        PipelineStageComputeShaderBit = ((int)0x800),
        /// <summary>
        /// Original was VK_ATTACHMENT_LOAD_OP_CLEAR = 1
        /// </summary>
        AttachmentLoadOpClear = ((int)1),
        /// <summary>
        /// Original was VK_ATTACHMENT_STORE_OP_DONT_CARE = 1
        /// </summary>
        AttachmentStoreOpDontCare = ((int)1),
        /// <summary>
        /// Original was VK_BLEND_ONE = 1
        /// </summary>
        BlendOne = ((int)1),
        /// <summary>
        /// Original was VK_BLEND_OP_SUBTRACT = 1
        /// </summary>
        BlendOpSubtract = ((int)1),
        /// <summary>
        /// Original was VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = 1
        /// </summary>
        BorderColorIntTransparentBlack = ((int)1),
        /// <summary>
        /// Original was VK_BUFFER_VIEW_TYPE_FORMATTED = 1
        /// </summary>
        BufferViewTypeFormatted = ((int)1),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_ONE = 1
        /// </summary>
        ChannelSwizzleOne = ((int)1),
        /// <summary>
        /// Original was VK_CMD_BUFFER_LEVEL_SECONDARY = 1
        /// </summary>
        CmdBufferLevelSecondary = ((int)1),
        /// <summary>
        /// Original was VK_COMPARE_OP_LESS = 1
        /// </summary>
        CompareOpLess = ((int)1),
        /// <summary>
        /// Original was VK_CULL_MODE_FRONT = 1
        /// </summary>
        CullModeFront = ((int)1),
        /// <summary>
        /// Original was VK_DESCRIPTOR_POOL_USAGE_DYNAMIC = 1
        /// </summary>
        DescriptorPoolUsageDynamic = ((int)1),
        /// <summary>
        /// Original was VK_DESCRIPTOR_SET_USAGE_STATIC = 1
        /// </summary>
        DescriptorSetUsageStatic = ((int)1),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER = 1
        /// </summary>
        DescriptorTypeCombinedImageSampler = ((int)1),
        /// <summary>
        /// Original was VK_FILL_MODE_WIREFRAME = 1
        /// </summary>
        FillModeWireframe = ((int)1),
        /// <summary>
        /// Original was VK_FORMAT_R4G4_UNORM = 1
        /// </summary>
        FormatR4G4Unorm = ((int)1),
        /// <summary>
        /// Original was VK_FRONT_FACE_CW = 1
        /// </summary>
        FrontFaceCw = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_DEPTH = 1
        /// </summary>
        ImageAspectDepth = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_GENERAL = 1
        /// </summary>
        ImageLayoutGeneral = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_TILING_OPTIMAL = 1
        /// </summary>
        ImageTilingOptimal = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_TYPE_2D = 1
        /// </summary>
        ImageType2D = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_2D = 1
        /// </summary>
        ImageViewType2D = ((int)1),
        /// <summary>
        /// Original was VK_INDEX_TYPE_UINT32 = 1
        /// </summary>
        IndexTypeUint32 = ((int)1),
        /// <summary>
        /// Original was VK_LOGIC_OP_AND = 1
        /// </summary>
        LogicOpAnd = ((int)1),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU = 1
        /// </summary>
        PhysicalDeviceTypeIntegratedGpu = ((int)1),
        /// <summary>
        /// Original was VK_PIPELINE_BIND_POINT_GRAPHICS = 1
        /// </summary>
        PipelineBindPointGraphics = ((int)1),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_LINE_LIST = 1
        /// </summary>
        PrimitiveTopologyLineList = ((int)1),
        /// <summary>
        /// Original was VK_QUERY_TYPE_PIPELINE_STATISTICS = 1
        /// </summary>
        QueryTypePipelineStatistics = ((int)1),
        /// <summary>
        /// Original was VK_RENDER_PASS_CONTENTS_SECONDARY_CMD_BUFFERS = 1
        /// </summary>
        RenderPassContentsSecondaryCmdBuffers = ((int)1),
        /// <summary>
        /// Original was VK_SHADER_STAGE_TESS_CONTROL = 1
        /// </summary>
        ShaderStageTessControl = ((int)1),
        /// <summary>
        /// Original was VK_SHARING_MODE_CONCURRENT = 1
        /// </summary>
        SharingModeConcurrent = ((int)1),
        /// <summary>
        /// Original was VK_STENCIL_OP_ZERO = 1
        /// </summary>
        StencilOpZero = ((int)1),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 1
        /// </summary>
        StructureTypeDeviceCreateInfo = ((int)1),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_INTERNAL = 1
        /// </summary>
        SystemAllocTypeInternal = ((int)1),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_MIRROR = 1
        /// </summary>
        TexAddressMirror = ((int)1),
        /// <summary>
        /// Original was VK_TEX_FILTER_LINEAR = 1
        /// </summary>
        TexFilterLinear = ((int)1),
        /// <summary>
        /// Original was VK_TEX_MIPMAP_MODE_NEAREST = 1
        /// </summary>
        TexMipmapModeNearest = ((int)1),
        /// <summary>
        /// Original was VK_TIMESTAMP_TYPE_BOTTOM = 1
        /// </summary>
        TimestampTypeBottom = ((int)1),
        /// <summary>
        /// Original was VK_UNSUPPORTED = 1
        /// </summary>
        Unsupported = ((int)1),
        /// <summary>
        /// Original was VK_VERTEX_INPUT_STEP_RATE_INSTANCE = 1
        /// </summary>
        VertexInputStepRateInstance = ((int)1),
        /// <summary>
        /// Original was VK_ERROR_UNKNOWN = -1
        /// </summary>
        ErrorUnknown = ((int)-1),
        /// <summary>
        /// Original was VK_BLEND_CONSTANT_COLOR = 10
        /// </summary>
        BlendConstantColor = ((int)10),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT = 10
        /// </summary>
        DescriptorTypeInputAttachment = ((int)10),
        /// <summary>
        /// Original was VK_FORMAT_R8_SNORM = 10
        /// </summary>
        FormatR8Snorm = ((int)10),
        /// <summary>
        /// Original was VK_LOGIC_OP_INVERT = 10
        /// </summary>
        LogicOpInvert = ((int)10),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_PATCH = 10
        /// </summary>
        PrimitiveTopologyPatch = ((int)10),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DYNAMIC_VIEWPORT_STATE_CREATE_INFO = 10
        /// </summary>
        StructureTypeDynamicViewportStateCreateInfo = ((int)10),
        /// <summary>
        /// Original was VK_ERROR_INVALID_HANDLE = -10
        /// </summary>
        ErrorInvalidHandle = ((int)-10),
        /// <summary>
        /// Original was VK_FORMAT_BC2_UNORM = 100
        /// </summary>
        FormatBc2Unorm = ((int)100),
        /// <summary>
        /// Original was VK_FORMAT_BC2_SRGB = 101
        /// </summary>
        FormatBc2Srgb = ((int)101),
        /// <summary>
        /// Original was VK_FORMAT_BC3_UNORM = 102
        /// </summary>
        FormatBc3Unorm = ((int)102),
        /// <summary>
        /// Original was VK_FORMAT_BC3_SRGB = 103
        /// </summary>
        FormatBc3Srgb = ((int)103),
        /// <summary>
        /// Original was VK_FORMAT_BC4_UNORM = 104
        /// </summary>
        FormatBc4Unorm = ((int)104),
        /// <summary>
        /// Original was VK_FORMAT_BC4_SNORM = 105
        /// </summary>
        FormatBc4Snorm = ((int)105),
        /// <summary>
        /// Original was VK_FORMAT_BC5_UNORM = 106
        /// </summary>
        FormatBc5Unorm = ((int)106),
        /// <summary>
        /// Original was VK_FORMAT_BC5_SNORM = 107
        /// </summary>
        FormatBc5Snorm = ((int)107),
        /// <summary>
        /// Original was VK_FORMAT_BC6H_UFLOAT = 108
        /// </summary>
        FormatBc6hUfloat = ((int)108),
        /// <summary>
        /// Original was VK_FORMAT_BC6H_SFLOAT = 109
        /// </summary>
        FormatBc6hSfloat = ((int)109),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_CONSTANT_COLOR = 11
        /// </summary>
        BlendOneMinusConstantColor = ((int)11),
        /// <summary>
        /// Original was VK_FORMAT_R8_USCALED = 11
        /// </summary>
        FormatR8Uscaled = ((int)11),
        /// <summary>
        /// Original was VK_LOGIC_OP_OR_REVERSE = 11
        /// </summary>
        LogicOpOrReverse = ((int)11),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DYNAMIC_RASTER_STATE_CREATE_INFO = 11
        /// </summary>
        StructureTypeDynamicRasterStateCreateInfo = ((int)11),
        /// <summary>
        /// Original was VK_ERROR_INVALID_ORDINAL = -11
        /// </summary>
        ErrorInvalidOrdinal = ((int)-11),
        /// <summary>
        /// Original was VK_FORMAT_BC7_UNORM = 110
        /// </summary>
        FormatBc7Unorm = ((int)110),
        /// <summary>
        /// Original was VK_FORMAT_BC7_SRGB = 111
        /// </summary>
        FormatBc7Srgb = ((int)111),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8_UNORM = 112
        /// </summary>
        FormatEtc2R8G8B8Unorm = ((int)112),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8_SRGB = 113
        /// </summary>
        FormatEtc2R8G8B8Srgb = ((int)113),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8A1_UNORM = 114
        /// </summary>
        FormatEtc2R8G8B8A1Unorm = ((int)114),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8A1_SRGB = 115
        /// </summary>
        FormatEtc2R8G8B8A1Srgb = ((int)115),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8A8_UNORM = 116
        /// </summary>
        FormatEtc2R8G8B8A8Unorm = ((int)116),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8A8_SRGB = 117
        /// </summary>
        FormatEtc2R8G8B8A8Srgb = ((int)117),
        /// <summary>
        /// Original was VK_FORMAT_EAC_R11_UNORM = 118
        /// </summary>
        FormatEacR11Unorm = ((int)118),
        /// <summary>
        /// Original was VK_FORMAT_EAC_R11_SNORM = 119
        /// </summary>
        FormatEacR11Snorm = ((int)119),
        /// <summary>
        /// Original was VK_BLEND_CONSTANT_ALPHA = 12
        /// </summary>
        BlendConstantAlpha = ((int)12),
        /// <summary>
        /// Original was VK_FORMAT_R8_SSCALED = 12
        /// </summary>
        FormatR8Sscaled = ((int)12),
        /// <summary>
        /// Original was VK_LOGIC_OP_COPY_INVERTED = 12
        /// </summary>
        LogicOpCopyInverted = ((int)12),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DYNAMIC_COLOR_BLEND_STATE_CREATE_INFO = 12
        /// </summary>
        StructureTypeDynamicColorBlendStateCreateInfo = ((int)12),
        /// <summary>
        /// Original was VK_ERROR_INVALID_MEMORY_SIZE = -12
        /// </summary>
        ErrorInvalidMemorySize = ((int)-12),
        /// <summary>
        /// Original was VK_FORMAT_EAC_R11G11_UNORM = 120
        /// </summary>
        FormatEacR11G11Unorm = ((int)120),
        /// <summary>
        /// Original was VK_FORMAT_EAC_R11G11_SNORM = 121
        /// </summary>
        FormatEacR11G11Snorm = ((int)121),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_4x4_UNORM = 122
        /// </summary>
        FormatAstc4X4Unorm = ((int)122),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_4x4_SRGB = 123
        /// </summary>
        FormatAstc4X4Srgb = ((int)123),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_5x4_UNORM = 124
        /// </summary>
        FormatAstc5X4Unorm = ((int)124),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_5x4_SRGB = 125
        /// </summary>
        FormatAstc5X4Srgb = ((int)125),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_5x5_UNORM = 126
        /// </summary>
        FormatAstc5X5Unorm = ((int)126),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_5x5_SRGB = 127
        /// </summary>
        FormatAstc5X5Srgb = ((int)127),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_6x5_UNORM = 128
        /// </summary>
        FormatAstc6X5Unorm = ((int)128),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_6x5_SRGB = 129
        /// </summary>
        FormatAstc6X5Srgb = ((int)129),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_CONSTANT_ALPHA = 13
        /// </summary>
        BlendOneMinusConstantAlpha = ((int)13),
        /// <summary>
        /// Original was VK_FORMAT_R8_UINT = 13
        /// </summary>
        FormatR8Uint = ((int)13),
        /// <summary>
        /// Original was VK_LOGIC_OP_OR_INVERTED = 13
        /// </summary>
        LogicOpOrInverted = ((int)13),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DYNAMIC_DEPTH_STENCIL_STATE_CREATE_INFO = 13
        /// </summary>
        StructureTypeDynamicDepthStencilStateCreateInfo = ((int)13),
        /// <summary>
        /// Original was VK_ERROR_INVALID_EXTENSION = -13
        /// </summary>
        ErrorInvalidExtension = ((int)-13),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_6x6_UNORM = 130
        /// </summary>
        FormatAstc6X6Unorm = ((int)130),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_6x6_SRGB = 131
        /// </summary>
        FormatAstc6X6Srgb = ((int)131),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x5_UNORM = 132
        /// </summary>
        FormatAstc8X5Unorm = ((int)132),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x5_SRGB = 133
        /// </summary>
        FormatAstc8X5Srgb = ((int)133),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x6_UNORM = 134
        /// </summary>
        FormatAstc8X6Unorm = ((int)134),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x6_SRGB = 135
        /// </summary>
        FormatAstc8X6Srgb = ((int)135),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x8_UNORM = 136
        /// </summary>
        FormatAstc8X8Unorm = ((int)136),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x8_SRGB = 137
        /// </summary>
        FormatAstc8X8Srgb = ((int)137),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x5_UNORM = 138
        /// </summary>
        FormatAstc10X5Unorm = ((int)138),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x5_SRGB = 139
        /// </summary>
        FormatAstc10X5Srgb = ((int)139),
        /// <summary>
        /// Original was VK_BLEND_SRC_ALPHA_SATURATE = 14
        /// </summary>
        BlendSrcAlphaSaturate = ((int)14),
        /// <summary>
        /// Original was VK_FORMAT_R8_SINT = 14
        /// </summary>
        FormatR8Sint = ((int)14),
        /// <summary>
        /// Original was VK_LOGIC_OP_NAND = 14
        /// </summary>
        LogicOpNand = ((int)14),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_CMD_BUFFER_CREATE_INFO = 14
        /// </summary>
        StructureTypeCmdBufferCreateInfo = ((int)14),
        /// <summary>
        /// Original was VK_ERROR_INVALID_FLAGS = -14
        /// </summary>
        ErrorInvalidFlags = ((int)-14),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x6_UNORM = 140
        /// </summary>
        FormatAstc10X6Unorm = ((int)140),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x6_SRGB = 141
        /// </summary>
        FormatAstc10X6Srgb = ((int)141),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x8_UNORM = 142
        /// </summary>
        FormatAstc10X8Unorm = ((int)142),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x8_SRGB = 143
        /// </summary>
        FormatAstc10X8Srgb = ((int)143),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x10_UNORM = 144
        /// </summary>
        FormatAstc10X10Unorm = ((int)144),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x10_SRGB = 145
        /// </summary>
        FormatAstc10X10Srgb = ((int)145),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_12x10_UNORM = 146
        /// </summary>
        FormatAstc12X10Unorm = ((int)146),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_12x10_SRGB = 147
        /// </summary>
        FormatAstc12X10Srgb = ((int)147),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_12x12_UNORM = 148
        /// </summary>
        FormatAstc12X12Unorm = ((int)148),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_12x12_SRGB = 149
        /// </summary>
        FormatAstc12X12Srgb = ((int)149),
        /// <summary>
        /// Original was VK_BLEND_SRC1_COLOR = 15
        /// </summary>
        BlendSrc1Color = ((int)15),
        /// <summary>
        /// Original was VK_FORMAT_R8_SRGB = 15
        /// </summary>
        FormatR8Srgb = ((int)15),
        /// <summary>
        /// Original was VK_LOGIC_OP_SET = 15
        /// </summary>
        LogicOpSet = ((int)15),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = 15
        /// </summary>
        StructureTypeEventCreateInfo = ((int)15),
        /// <summary>
        /// Original was VK_ERROR_INVALID_ALIGNMENT = -15
        /// </summary>
        ErrorInvalidAlignment = ((int)-15),
        /// <summary>
        /// Original was VK_FORMAT_B4G4R4A4_UNORM = 150
        /// </summary>
        FormatB4G4R4A4Unorm = ((int)150),
        /// <summary>
        /// Original was VK_FORMAT_B5G5R5A1_UNORM = 151
        /// </summary>
        FormatB5G5R5A1Unorm = ((int)151),
        /// <summary>
        /// Original was VK_FORMAT_B5G6R5_UNORM = 152
        /// </summary>
        FormatB5G6R5Unorm = ((int)152),
        /// <summary>
        /// Original was VK_FORMAT_B5G6R5_USCALED = 153
        /// </summary>
        FormatB5G6R5Uscaled = ((int)153),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_UNORM = 154
        /// </summary>
        FormatB8G8R8Unorm = ((int)154),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_SNORM = 155
        /// </summary>
        FormatB8G8R8Snorm = ((int)155),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_USCALED = 156
        /// </summary>
        FormatB8G8R8Uscaled = ((int)156),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_SSCALED = 157
        /// </summary>
        FormatB8G8R8Sscaled = ((int)157),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_UINT = 158
        /// </summary>
        FormatB8G8R8Uint = ((int)158),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_SINT = 159
        /// </summary>
        FormatB8G8R8Sint = ((int)159),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_SRC1_COLOR = 16
        /// </summary>
        BlendOneMinusSrc1Color = ((int)16),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_UNORM = 16
        /// </summary>
        FormatR8G8Unorm = ((int)16),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = 16
        /// </summary>
        StructureTypeFenceCreateInfo = ((int)16),
        /// <summary>
        /// Original was VK_ERROR_INVALID_FORMAT = -16
        /// </summary>
        ErrorInvalidFormat = ((int)-16),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_SRGB = 160
        /// </summary>
        FormatB8G8R8Srgb = ((int)160),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_UNORM = 161
        /// </summary>
        FormatB8G8R8A8Unorm = ((int)161),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_SNORM = 162
        /// </summary>
        FormatB8G8R8A8Snorm = ((int)162),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_USCALED = 163
        /// </summary>
        FormatB8G8R8A8Uscaled = ((int)163),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_SSCALED = 164
        /// </summary>
        FormatB8G8R8A8Sscaled = ((int)164),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_UINT = 165
        /// </summary>
        FormatB8G8R8A8Uint = ((int)165),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_SINT = 166
        /// </summary>
        FormatB8G8R8A8Sint = ((int)166),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_SRGB = 167
        /// </summary>
        FormatB8G8R8A8Srgb = ((int)167),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_UNORM = 168
        /// </summary>
        FormatB10G10R10A2Unorm = ((int)168),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_SNORM = 169
        /// </summary>
        FormatB10G10R10A2Snorm = ((int)169),
        /// <summary>
        /// Original was VK_BLEND_SRC1_ALPHA = 17
        /// </summary>
        BlendSrc1Alpha = ((int)17),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_SNORM = 17
        /// </summary>
        FormatR8G8Snorm = ((int)17),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = 17
        /// </summary>
        StructureTypeSemaphoreCreateInfo = ((int)17),
        /// <summary>
        /// Original was VK_ERROR_INVALID_IMAGE = -17
        /// </summary>
        ErrorInvalidImage = ((int)-17),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_USCALED = 170
        /// </summary>
        FormatB10G10R10A2Uscaled = ((int)170),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_SSCALED = 171
        /// </summary>
        FormatB10G10R10A2Sscaled = ((int)171),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_UINT = 172
        /// </summary>
        FormatB10G10R10A2Uint = ((int)172),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_SINT = 173
        /// </summary>
        FormatB10G10R10A2Sint = ((int)173),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_SRC1_ALPHA = 18
        /// </summary>
        BlendOneMinusSrc1Alpha = ((int)18),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_USCALED = 18
        /// </summary>
        FormatR8G8Uscaled = ((int)18),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = 18
        /// </summary>
        StructureTypeQueryPoolCreateInfo = ((int)18),
        /// <summary>
        /// Original was VK_ERROR_INVALID_DESCRIPTOR_SET_DATA = -18
        /// </summary>
        ErrorInvalidDescriptorSetData = ((int)-18),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_SSCALED = 19
        /// </summary>
        FormatR8G8Sscaled = ((int)19),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = 19
        /// </summary>
        StructureTypePipelineShaderStageCreateInfo = ((int)19),
        /// <summary>
        /// Original was VK_ERROR_INVALID_QUEUE_TYPE = -19
        /// </summary>
        ErrorInvalidQueueType = ((int)-19),
        /// <summary>
        /// Original was VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2
        /// </summary>
        AttachmentLoadOpDontCare = ((int)2),
        /// <summary>
        /// Original was VK_BLEND_OP_REVERSE_SUBTRACT = 2
        /// </summary>
        BlendOpReverseSubtract = ((int)2),
        /// <summary>
        /// Original was VK_BLEND_SRC_COLOR = 2
        /// </summary>
        BlendSrcColor = ((int)2),
        /// <summary>
        /// Original was VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = 2
        /// </summary>
        BorderColorFloatOpaqueBlack = ((int)2),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_R = 2
        /// </summary>
        ChannelSwizzleR = ((int)2),
        /// <summary>
        /// Original was VK_COMPARE_OP_EQUAL = 2
        /// </summary>
        CompareOpEqual = ((int)2),
        /// <summary>
        /// Original was VK_CULL_MODE_BACK = 2
        /// </summary>
        CullModeBack = ((int)2),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE = 2
        /// </summary>
        DescriptorTypeSampledImage = ((int)2),
        /// <summary>
        /// Original was VK_FILL_MODE_SOLID = 2
        /// </summary>
        FillModeSolid = ((int)2),
        /// <summary>
        /// Original was VK_FORMAT_R4G4_USCALED = 2
        /// </summary>
        FormatR4G4Uscaled = ((int)2),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_STENCIL = 2
        /// </summary>
        ImageAspectStencil = ((int)2),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = 2
        /// </summary>
        ImageLayoutColorAttachmentOptimal = ((int)2),
        /// <summary>
        /// Original was VK_IMAGE_TYPE_3D = 2
        /// </summary>
        ImageType3D = ((int)2),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_3D = 2
        /// </summary>
        ImageViewType3D = ((int)2),
        /// <summary>
        /// Original was VK_LOGIC_OP_AND_REVERSE = 2
        /// </summary>
        LogicOpAndReverse = ((int)2),
        /// <summary>
        /// Original was VK_NOT_READY = 2
        /// </summary>
        NotReady = ((int)2),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU = 2
        /// </summary>
        PhysicalDeviceTypeDiscreteGpu = ((int)2),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_LINE_STRIP = 2
        /// </summary>
        PrimitiveTopologyLineStrip = ((int)2),
        /// <summary>
        /// Original was VK_SHADER_STAGE_TESS_EVALUATION = 2
        /// </summary>
        ShaderStageTessEvaluation = ((int)2),
        /// <summary>
        /// Original was VK_STENCIL_OP_REPLACE = 2
        /// </summary>
        StencilOpReplace = ((int)2),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_MEMORY_ALLOC_INFO = 2
        /// </summary>
        StructureTypeMemoryAllocInfo = ((int)2),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_INTERNAL_TEMP = 2
        /// </summary>
        SystemAllocTypeInternalTemp = ((int)2),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_CLAMP = 2
        /// </summary>
        TexAddressClamp = ((int)2),
        /// <summary>
        /// Original was VK_TEX_MIPMAP_MODE_LINEAR = 2
        /// </summary>
        TexMipmapModeLinear = ((int)2),
        /// <summary>
        /// Original was VK_ERROR_UNAVAILABLE = -2
        /// </summary>
        ErrorUnavailable = ((int)-2),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_UINT = 20
        /// </summary>
        FormatR8G8Uint = ((int)20),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = 20
        /// </summary>
        StructureTypeGraphicsPipelineCreateInfo = ((int)20),
        /// <summary>
        /// Original was VK_ERROR_UNSUPPORTED_SHADER_IL_VERSION = -20
        /// </summary>
        ErrorUnsupportedShaderIlVersion = ((int)-20),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_SINT = 21
        /// </summary>
        FormatR8G8Sint = ((int)21),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = 21
        /// </summary>
        StructureTypePipelineVertexInputStateCreateInfo = ((int)21),
        /// <summary>
        /// Original was VK_ERROR_BAD_SHADER_CODE = -21
        /// </summary>
        ErrorBadShaderCode = ((int)-21),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_SRGB = 22
        /// </summary>
        FormatR8G8Srgb = ((int)22),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = 22
        /// </summary>
        StructureTypePipelineInputAssemblyStateCreateInfo = ((int)22),
        /// <summary>
        /// Original was VK_ERROR_BAD_PIPELINE_DATA = -22
        /// </summary>
        ErrorBadPipelineData = ((int)-22),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_UNORM = 23
        /// </summary>
        FormatR8G8B8Unorm = ((int)23),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = 23
        /// </summary>
        StructureTypePipelineTessellationStateCreateInfo = ((int)23),
        /// <summary>
        /// Original was VK_ERROR_NOT_MAPPABLE = -23
        /// </summary>
        ErrorNotMappable = ((int)-23),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_SNORM = 24
        /// </summary>
        FormatR8G8B8Snorm = ((int)24),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = 24
        /// </summary>
        StructureTypePipelineViewportStateCreateInfo = ((int)24),
        /// <summary>
        /// Original was VK_ERROR_MEMORY_MAP_FAILED = -24
        /// </summary>
        ErrorMemoryMapFailed = ((int)-24),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_USCALED = 25
        /// </summary>
        FormatR8G8B8Uscaled = ((int)25),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_RASTER_STATE_CREATE_INFO = 25
        /// </summary>
        StructureTypePipelineRasterStateCreateInfo = ((int)25),
        /// <summary>
        /// Original was VK_ERROR_MEMORY_UNMAP_FAILED = -25
        /// </summary>
        ErrorMemoryUnmapFailed = ((int)-25),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_SSCALED = 26
        /// </summary>
        FormatR8G8B8Sscaled = ((int)26),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = 26
        /// </summary>
        StructureTypePipelineMultisampleStateCreateInfo = ((int)26),
        /// <summary>
        /// Original was VK_ERROR_INCOMPATIBLE_DEVICE = -26
        /// </summary>
        ErrorIncompatibleDevice = ((int)-26),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_UINT = 27
        /// </summary>
        FormatR8G8B8Uint = ((int)27),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = 27
        /// </summary>
        StructureTypePipelineColorBlendStateCreateInfo = ((int)27),
        /// <summary>
        /// Original was VK_ERROR_INCOMPATIBLE_DRIVER = -27
        /// </summary>
        ErrorIncompatibleDriver = ((int)-27),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_SINT = 28
        /// </summary>
        FormatR8G8B8Sint = ((int)28),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = 28
        /// </summary>
        StructureTypePipelineDepthStencilStateCreateInfo = ((int)28),
        /// <summary>
        /// Original was VK_ERROR_INCOMPLETE_COMMAND_BUFFER = -28
        /// </summary>
        ErrorIncompleteCommandBuffer = ((int)-28),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_SRGB = 29
        /// </summary>
        FormatR8G8B8Srgb = ((int)29),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = 29
        /// </summary>
        StructureTypeImageCreateInfo = ((int)29),
        /// <summary>
        /// Original was VK_ERROR_BUILDING_COMMAND_BUFFER = -29
        /// </summary>
        ErrorBuildingCommandBuffer = ((int)-29),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_SRC_COLOR = 3
        /// </summary>
        BlendOneMinusSrcColor = ((int)3),
        /// <summary>
        /// Original was VK_BLEND_OP_MIN = 3
        /// </summary>
        BlendOpMin = ((int)3),
        /// <summary>
        /// Original was VK_BORDER_COLOR_INT_OPAQUE_BLACK = 3
        /// </summary>
        BorderColorIntOpaqueBlack = ((int)3),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_G = 3
        /// </summary>
        ChannelSwizzleG = ((int)3),
        /// <summary>
        /// Original was VK_COMPARE_OP_LESS_EQUAL = 3
        /// </summary>
        CompareOpLessEqual = ((int)3),
        /// <summary>
        /// Original was VK_CULL_MODE_FRONT_AND_BACK = 3
        /// </summary>
        CullModeFrontAndBack = ((int)3),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_STORAGE_IMAGE = 3
        /// </summary>
        DescriptorTypeStorageImage = ((int)3),
        /// <summary>
        /// Original was VK_FORMAT_R4G4B4A4_UNORM = 3
        /// </summary>
        FormatR4G4B4A4Unorm = ((int)3),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_METADATA = 3
        /// </summary>
        ImageAspectMetadata = ((int)3),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = 3
        /// </summary>
        ImageLayoutDepthStencilAttachmentOptimal = ((int)3),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_CUBE = 3
        /// </summary>
        ImageViewTypeCube = ((int)3),
        /// <summary>
        /// Original was VK_LOGIC_OP_COPY = 3
        /// </summary>
        LogicOpCopy = ((int)3),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU = 3
        /// </summary>
        PhysicalDeviceTypeVirtualGpu = ((int)3),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST = 3
        /// </summary>
        PrimitiveTopologyTriangleList = ((int)3),
        /// <summary>
        /// Original was VK_SHADER_STAGE_GEOMETRY = 3
        /// </summary>
        ShaderStageGeometry = ((int)3),
        /// <summary>
        /// Original was VK_STENCIL_OP_INC_CLAMP = 3
        /// </summary>
        StencilOpIncClamp = ((int)3),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = 3
        /// </summary>
        StructureTypeImageViewCreateInfo = ((int)3),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_INTERNAL_SHADER = 3
        /// </summary>
        SystemAllocTypeInternalShader = ((int)3),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_MIRROR_ONCE = 3
        /// </summary>
        TexAddressMirrorOnce = ((int)3),
        /// <summary>
        /// Original was VK_TIMEOUT = 3
        /// </summary>
        Timeout = ((int)3),
        /// <summary>
        /// Original was VK_ERROR_INITIALIZATION_FAILED = -3
        /// </summary>
        ErrorInitializationFailed = ((int)-3),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_UNORM = 30
        /// </summary>
        FormatR8G8B8A8Unorm = ((int)30),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = 30
        /// </summary>
        StructureTypeBufferCreateInfo = ((int)30),
        /// <summary>
        /// Original was VK_ERROR_MEMORY_NOT_BOUND = -30
        /// </summary>
        ErrorMemoryNotBound = ((int)-30),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_SNORM = 31
        /// </summary>
        FormatR8G8B8A8Snorm = ((int)31),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = 31
        /// </summary>
        StructureTypeBufferViewCreateInfo = ((int)31),
        /// <summary>
        /// Original was VK_ERROR_INCOMPATIBLE_QUEUE = -31
        /// </summary>
        ErrorIncompatibleQueue = ((int)-31),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_USCALED = 32
        /// </summary>
        FormatR8G8B8A8Uscaled = ((int)32),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = 32
        /// </summary>
        StructureTypeFramebufferCreateInfo = ((int)32),
        /// <summary>
        /// Original was VK_ERROR_INVALID_LAYER = -32
        /// </summary>
        ErrorInvalidLayer = ((int)-32),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_SSCALED = 33
        /// </summary>
        FormatR8G8B8A8Sscaled = ((int)33),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_CMD_BUFFER_BEGIN_INFO = 33
        /// </summary>
        StructureTypeCmdBufferBeginInfo = ((int)33),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_UINT = 34
        /// </summary>
        FormatR8G8B8A8Uint = ((int)34),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = 34
        /// </summary>
        StructureTypeRenderPassCreateInfo = ((int)34),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_SINT = 35
        /// </summary>
        FormatR8G8B8A8Sint = ((int)35),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_MEMORY_BARRIER = 35
        /// </summary>
        StructureTypeMemoryBarrier = ((int)35),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_SRGB = 36
        /// </summary>
        FormatR8G8B8A8Srgb = ((int)36),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = 36
        /// </summary>
        StructureTypeBufferMemoryBarrier = ((int)36),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_UNORM = 37
        /// </summary>
        FormatR10G10B10A2Unorm = ((int)37),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = 37
        /// </summary>
        StructureTypeImageMemoryBarrier = ((int)37),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_SNORM = 38
        /// </summary>
        FormatR10G10B10A2Snorm = ((int)38),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = 38
        /// </summary>
        StructureTypeDescriptorPoolCreateInfo = ((int)38),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_USCALED = 39
        /// </summary>
        FormatR10G10B10A2Uscaled = ((int)39),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = 39
        /// </summary>
        StructureTypeWriteDescriptorSet = ((int)39),
        /// <summary>
        /// Original was VK_BLEND_DEST_COLOR = 4
        /// </summary>
        BlendDestColor = ((int)4),
        /// <summary>
        /// Original was VK_BLEND_OP_MAX = 4
        /// </summary>
        BlendOpMax = ((int)4),
        /// <summary>
        /// Original was VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = 4
        /// </summary>
        BorderColorFloatOpaqueWhite = ((int)4),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_B = 4
        /// </summary>
        ChannelSwizzleB = ((int)4),
        /// <summary>
        /// Original was VK_COMPARE_OP_GREATER = 4
        /// </summary>
        CompareOpGreater = ((int)4),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER = 4
        /// </summary>
        DescriptorTypeUniformTexelBuffer = ((int)4),
        /// <summary>
        /// Original was VK_EVENT_SET = 4
        /// </summary>
        EventSet = ((int)4),
        /// <summary>
        /// Original was VK_FORMAT_R4G4B4A4_USCALED = 4
        /// </summary>
        FormatR4G4B4A4Uscaled = ((int)4),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = 4
        /// </summary>
        ImageLayoutDepthStencilReadOnlyOptimal = ((int)4),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_1D_ARRAY = 4
        /// </summary>
        ImageViewType1DArray = ((int)4),
        /// <summary>
        /// Original was VK_LOGIC_OP_AND_INVERTED = 4
        /// </summary>
        LogicOpAndInverted = ((int)4),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_CPU = 4
        /// </summary>
        PhysicalDeviceTypeCpu = ((int)4),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP = 4
        /// </summary>
        PrimitiveTopologyTriangleStrip = ((int)4),
        /// <summary>
        /// Original was VK_SHADER_STAGE_FRAGMENT = 4
        /// </summary>
        ShaderStageFragment = ((int)4),
        /// <summary>
        /// Original was VK_STENCIL_OP_DEC_CLAMP = 4
        /// </summary>
        StencilOpDecClamp = ((int)4),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_ATTACHMENT_VIEW_CREATE_INFO = 4
        /// </summary>
        StructureTypeAttachmentViewCreateInfo = ((int)4),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_DEBUG = 4
        /// </summary>
        SystemAllocTypeDebug = ((int)4),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_CLAMP_BORDER = 4
        /// </summary>
        TexAddressClampBorder = ((int)4),
        /// <summary>
        /// Original was VK_ERROR_OUT_OF_HOST_MEMORY = -4
        /// </summary>
        ErrorOutOfHostMemory = ((int)-4),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_SSCALED = 40
        /// </summary>
        FormatR10G10B10A2Sscaled = ((int)40),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = 40
        /// </summary>
        StructureTypeCopyDescriptorSet = ((int)40),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_UINT = 41
        /// </summary>
        FormatR10G10B10A2Uint = ((int)41),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 41
        /// </summary>
        StructureTypeInstanceCreateInfo = ((int)41),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_SINT = 42
        /// </summary>
        FormatR10G10B10A2Sint = ((int)42),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = 42
        /// </summary>
        StructureTypePipelineLayoutCreateInfo = ((int)42),
        /// <summary>
        /// Original was VK_FORMAT_R16_UNORM = 43
        /// </summary>
        FormatR16Unorm = ((int)43),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = 43
        /// </summary>
        StructureTypeMappedMemoryRange = ((int)43),
        /// <summary>
        /// Original was VK_FORMAT_R16_SNORM = 44
        /// </summary>
        FormatR16Snorm = ((int)44),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = 44
        /// </summary>
        StructureTypePipelineCacheCreateInfo = ((int)44),
        /// <summary>
        /// Original was VK_FORMAT_R16_USCALED = 45
        /// </summary>
        FormatR16Uscaled = ((int)45),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION = 45
        /// </summary>
        StructureTypeAttachmentDescription = ((int)45),
        /// <summary>
        /// Original was VK_FORMAT_R16_SSCALED = 46
        /// </summary>
        FormatR16Sscaled = ((int)46),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION = 46
        /// </summary>
        StructureTypeSubpassDescription = ((int)46),
        /// <summary>
        /// Original was VK_FORMAT_R16_UINT = 47
        /// </summary>
        FormatR16Uint = ((int)47),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY = 47
        /// </summary>
        StructureTypeSubpassDependency = ((int)47),
        /// <summary>
        /// Original was VK_FORMAT_R16_SINT = 48
        /// </summary>
        FormatR16Sint = ((int)48),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = 48
        /// </summary>
        StructureTypeRenderPassBeginInfo = ((int)48),
        /// <summary>
        /// Original was VK_FORMAT_R16_SFLOAT = 49
        /// </summary>
        FormatR16Sfloat = ((int)49),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_CMD_POOL_CREATE_INFO = 49
        /// </summary>
        StructureTypeCmdPoolCreateInfo = ((int)49),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_DEST_COLOR = 5
        /// </summary>
        BlendOneMinusDestColor = ((int)5),
        /// <summary>
        /// Original was VK_BORDER_COLOR_INT_OPAQUE_WHITE = 5
        /// </summary>
        BorderColorIntOpaqueWhite = ((int)5),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_A = 5
        /// </summary>
        ChannelSwizzleA = ((int)5),
        /// <summary>
        /// Original was VK_COMPARE_OP_NOT_EQUAL = 5
        /// </summary>
        CompareOpNotEqual = ((int)5),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER = 5
        /// </summary>
        DescriptorTypeStorageTexelBuffer = ((int)5),
        /// <summary>
        /// Original was VK_EVENT_RESET = 5
        /// </summary>
        EventReset = ((int)5),
        /// <summary>
        /// Original was VK_FORMAT_R5G6B5_UNORM = 5
        /// </summary>
        FormatR5G6B5Unorm = ((int)5),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = 5
        /// </summary>
        ImageLayoutShaderReadOnlyOptimal = ((int)5),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_2D_ARRAY = 5
        /// </summary>
        ImageViewType2DArray = ((int)5),
        /// <summary>
        /// Original was VK_LOGIC_OP_NOOP = 5
        /// </summary>
        LogicOpNoop = ((int)5),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN = 5
        /// </summary>
        PrimitiveTopologyTriangleFan = ((int)5),
        /// <summary>
        /// Original was VK_SHADER_STAGE_COMPUTE = 5
        /// </summary>
        ShaderStageCompute = ((int)5),
        /// <summary>
        /// Original was VK_STENCIL_OP_INVERT = 5
        /// </summary>
        StencilOpInvert = ((int)5),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = 5
        /// </summary>
        StructureTypeShaderModuleCreateInfo = ((int)5),
        /// <summary>
        /// Original was VK_ERROR_OUT_OF_DEVICE_MEMORY = -5
        /// </summary>
        ErrorOutOfDeviceMemory = ((int)-5),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_UNORM = 50
        /// </summary>
        FormatR16G16Unorm = ((int)50),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_SNORM = 51
        /// </summary>
        FormatR16G16Snorm = ((int)51),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_USCALED = 52
        /// </summary>
        FormatR16G16Uscaled = ((int)52),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_SSCALED = 53
        /// </summary>
        FormatR16G16Sscaled = ((int)53),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_UINT = 54
        /// </summary>
        FormatR16G16Uint = ((int)54),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_SINT = 55
        /// </summary>
        FormatR16G16Sint = ((int)55),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_SFLOAT = 56
        /// </summary>
        FormatR16G16Sfloat = ((int)56),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_UNORM = 57
        /// </summary>
        FormatR16G16B16Unorm = ((int)57),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_SNORM = 58
        /// </summary>
        FormatR16G16B16Snorm = ((int)58),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_USCALED = 59
        /// </summary>
        FormatR16G16B16Uscaled = ((int)59),
        /// <summary>
        /// Original was VK_BLEND_SRC_ALPHA = 6
        /// </summary>
        BlendSrcAlpha = ((int)6),
        /// <summary>
        /// Original was VK_COMPARE_OP_GREATER_EQUAL = 6
        /// </summary>
        CompareOpGreaterEqual = ((int)6),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER = 6
        /// </summary>
        DescriptorTypeUniformBuffer = ((int)6),
        /// <summary>
        /// Original was VK_FORMAT_R5G6B5_USCALED = 6
        /// </summary>
        FormatR5G6B5Uscaled = ((int)6),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_TRANSFER_SOURCE_OPTIMAL = 6
        /// </summary>
        ImageLayoutTransferSourceOptimal = ((int)6),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_CUBE_ARRAY = 6
        /// </summary>
        ImageViewTypeCubeArray = ((int)6),
        /// <summary>
        /// Original was VK_INCOMPLETE = 6
        /// </summary>
        Incomplete = ((int)6),
        /// <summary>
        /// Original was VK_LOGIC_OP_XOR = 6
        /// </summary>
        LogicOpXor = ((int)6),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_LINE_LIST_ADJ = 6
        /// </summary>
        PrimitiveTopologyLineListAdj = ((int)6),
        /// <summary>
        /// Original was VK_STENCIL_OP_INC_WRAP = 6
        /// </summary>
        StencilOpIncWrap = ((int)6),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SHADER_CREATE_INFO = 6
        /// </summary>
        StructureTypeShaderCreateInfo = ((int)6),
        /// <summary>
        /// Original was VK_ERROR_DEVICE_ALREADY_CREATED = -6
        /// </summary>
        ErrorDeviceAlreadyCreated = ((int)-6),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_SSCALED = 60
        /// </summary>
        FormatR16G16B16Sscaled = ((int)60),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_UINT = 61
        /// </summary>
        FormatR16G16B16Uint = ((int)61),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_SINT = 62
        /// </summary>
        FormatR16G16B16Sint = ((int)62),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_SFLOAT = 63
        /// </summary>
        FormatR16G16B16Sfloat = ((int)63),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_UNORM = 64
        /// </summary>
        FormatR16G16B16A16Unorm = ((int)64),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_SNORM = 65
        /// </summary>
        FormatR16G16B16A16Snorm = ((int)65),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_USCALED = 66
        /// </summary>
        FormatR16G16B16A16Uscaled = ((int)66),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_SSCALED = 67
        /// </summary>
        FormatR16G16B16A16Sscaled = ((int)67),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_UINT = 68
        /// </summary>
        FormatR16G16B16A16Uint = ((int)68),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_SINT = 69
        /// </summary>
        FormatR16G16B16A16Sint = ((int)69),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_SRC_ALPHA = 7
        /// </summary>
        BlendOneMinusSrcAlpha = ((int)7),
        /// <summary>
        /// Original was VK_COMPARE_OP_ALWAYS = 7
        /// </summary>
        CompareOpAlways = ((int)7),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_STORAGE_BUFFER = 7
        /// </summary>
        DescriptorTypeStorageBuffer = ((int)7),
        /// <summary>
        /// Original was VK_FORMAT_R5G5B5A1_UNORM = 7
        /// </summary>
        FormatR5G5B5A1Unorm = ((int)7),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_TRANSFER_DESTINATION_OPTIMAL = 7
        /// </summary>
        ImageLayoutTransferDestinationOptimal = ((int)7),
        /// <summary>
        /// Original was VK_LOGIC_OP_OR = 7
        /// </summary>
        LogicOpOr = ((int)7),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_ADJ = 7
        /// </summary>
        PrimitiveTopologyLineStripAdj = ((int)7),
        /// <summary>
        /// Original was VK_STENCIL_OP_DEC_WRAP = 7
        /// </summary>
        StencilOpDecWrap = ((int)7),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = 7
        /// </summary>
        StructureTypeComputePipelineCreateInfo = ((int)7),
        /// <summary>
        /// Original was VK_ERROR_DEVICE_LOST = -7
        /// </summary>
        ErrorDeviceLost = ((int)-7),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_SFLOAT = 70
        /// </summary>
        FormatR16G16B16A16Sfloat = ((int)70),
        /// <summary>
        /// Original was VK_FORMAT_R32_UINT = 71
        /// </summary>
        FormatR32Uint = ((int)71),
        /// <summary>
        /// Original was VK_FORMAT_R32_SINT = 72
        /// </summary>
        FormatR32Sint = ((int)72),
        /// <summary>
        /// Original was VK_FORMAT_R32_SFLOAT = 73
        /// </summary>
        FormatR32Sfloat = ((int)73),
        /// <summary>
        /// Original was VK_FORMAT_R32G32_UINT = 74
        /// </summary>
        FormatR32G32Uint = ((int)74),
        /// <summary>
        /// Original was VK_FORMAT_R32G32_SINT = 75
        /// </summary>
        FormatR32G32Sint = ((int)75),
        /// <summary>
        /// Original was VK_FORMAT_R32G32_SFLOAT = 76
        /// </summary>
        FormatR32G32Sfloat = ((int)76),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32_UINT = 77
        /// </summary>
        FormatR32G32B32Uint = ((int)77),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32_SINT = 78
        /// </summary>
        FormatR32G32B32Sint = ((int)78),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32_SFLOAT = 79
        /// </summary>
        FormatR32G32B32Sfloat = ((int)79),
        /// <summary>
        /// Original was VK_BLEND_DEST_ALPHA = 8
        /// </summary>
        BlendDestAlpha = ((int)8),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC = 8
        /// </summary>
        DescriptorTypeUniformBufferDynamic = ((int)8),
        /// <summary>
        /// Original was VK_FORMAT_R5G5B5A1_USCALED = 8
        /// </summary>
        FormatR5G5B5A1Uscaled = ((int)8),
        /// <summary>
        /// Original was VK_LOGIC_OP_NOR = 8
        /// </summary>
        LogicOpNor = ((int)8),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_ADJ = 8
        /// </summary>
        PrimitiveTopologyTriangleListAdj = ((int)8),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = 8
        /// </summary>
        StructureTypeSamplerCreateInfo = ((int)8),
        /// <summary>
        /// Original was VK_ERROR_INVALID_POINTER = -8
        /// </summary>
        ErrorInvalidPointer = ((int)-8),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32A32_UINT = 80
        /// </summary>
        FormatR32G32B32A32Uint = ((int)80),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32A32_SINT = 81
        /// </summary>
        FormatR32G32B32A32Sint = ((int)81),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32A32_SFLOAT = 82
        /// </summary>
        FormatR32G32B32A32Sfloat = ((int)82),
        /// <summary>
        /// Original was VK_FORMAT_R64_SFLOAT = 83
        /// </summary>
        FormatR64Sfloat = ((int)83),
        /// <summary>
        /// Original was VK_FORMAT_R64G64_SFLOAT = 84
        /// </summary>
        FormatR64G64Sfloat = ((int)84),
        /// <summary>
        /// Original was VK_FORMAT_R64G64B64_SFLOAT = 85
        /// </summary>
        FormatR64G64B64Sfloat = ((int)85),
        /// <summary>
        /// Original was VK_FORMAT_R64G64B64A64_SFLOAT = 86
        /// </summary>
        FormatR64G64B64A64Sfloat = ((int)86),
        /// <summary>
        /// Original was VK_FORMAT_R11G11B10_UFLOAT = 87
        /// </summary>
        FormatR11G11B10Ufloat = ((int)87),
        /// <summary>
        /// Original was VK_FORMAT_R9G9B9E5_UFLOAT = 88
        /// </summary>
        FormatR9G9B9e5Ufloat = ((int)88),
        /// <summary>
        /// Original was VK_FORMAT_D16_UNORM = 89
        /// </summary>
        FormatD16Unorm = ((int)89),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_DEST_ALPHA = 9
        /// </summary>
        BlendOneMinusDestAlpha = ((int)9),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC = 9
        /// </summary>
        DescriptorTypeStorageBufferDynamic = ((int)9),
        /// <summary>
        /// Original was VK_FORMAT_R8_UNORM = 9
        /// </summary>
        FormatR8Unorm = ((int)9),
        /// <summary>
        /// Original was VK_LOGIC_OP_EQUIV = 9
        /// </summary>
        LogicOpEquiv = ((int)9),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_ADJ = 9
        /// </summary>
        PrimitiveTopologyTriangleStripAdj = ((int)9),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = 9
        /// </summary>
        StructureTypeDescriptorSetLayoutCreateInfo = ((int)9),
        /// <summary>
        /// Original was VK_ERROR_INVALID_VALUE = -9
        /// </summary>
        ErrorInvalidValue = ((int)-9),
        /// <summary>
        /// Original was VK_FORMAT_D24_UNORM = 90
        /// </summary>
        FormatD24Unorm = ((int)90),
        /// <summary>
        /// Original was VK_FORMAT_D32_SFLOAT = 91
        /// </summary>
        FormatD32Sfloat = ((int)91),
        /// <summary>
        /// Original was VK_FORMAT_S8_UINT = 92
        /// </summary>
        FormatS8Uint = ((int)92),
        /// <summary>
        /// Original was VK_FORMAT_D16_UNORM_S8_UINT = 93
        /// </summary>
        FormatD16UnormS8Uint = ((int)93),
        /// <summary>
        /// Original was VK_FORMAT_D24_UNORM_S8_UINT = 94
        /// </summary>
        FormatD24UnormS8Uint = ((int)94),
        /// <summary>
        /// Original was VK_FORMAT_D32_SFLOAT_S8_UINT = 95
        /// </summary>
        FormatD32SfloatS8Uint = ((int)95),
        /// <summary>
        /// Original was VK_FORMAT_BC1_RGB_UNORM = 96
        /// </summary>
        FormatBc1RgbUnorm = ((int)96),
        /// <summary>
        /// Original was VK_FORMAT_BC1_RGB_SRGB = 97
        /// </summary>
        FormatBc1RgbSrgb = ((int)97),
        /// <summary>
        /// Original was VK_FORMAT_BC1_RGBA_UNORM = 98
        /// </summary>
        FormatBc1RgbaUnorm = ((int)98),
        /// <summary>
        /// Original was VK_FORMAT_BC1_RGBA_SRGB = 99
        /// </summary>
        FormatBc1RgbaSrgb = ((int)99),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AttachmentLoadOp : int
    {
        /// <summary>
        /// Original was VK_ATTACHMENT_LOAD_OP_LOAD = 0
        /// </summary>
        AttachmentLoadOpLoad = ((int)0),
        /// <summary>
        /// Original was VK_ATTACHMENT_LOAD_OP_CLEAR = 1
        /// </summary>
        AttachmentLoadOpClear = ((int)1),
        /// <summary>
        /// Original was VK_ATTACHMENT_LOAD_OP_DONT_CARE = 2
        /// </summary>
        AttachmentLoadOpDontCare = ((int)2),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum AttachmentStoreOp : int
    {
        /// <summary>
        /// Original was VK_ATTACHMENT_STORE_OP_STORE = 0
        /// </summary>
        AttachmentStoreOpStore = ((int)0),
        /// <summary>
        /// Original was VK_ATTACHMENT_STORE_OP_DONT_CARE = 1
        /// </summary>
        AttachmentStoreOpDontCare = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum AttachmentViewCreateFlags : int
    {
        /// <summary>
        /// Original was VK_ATTACHMENT_VIEW_CREATE_READ_ONLY_DEPTH_BIT = 0x1
        /// </summary>
        AttachmentViewCreateReadOnlyDepthBit = ((int)0x1),
        /// <summary>
        /// Original was VK_ATTACHMENT_VIEW_CREATE_READ_ONLY_STENCIL_BIT = 0x2
        /// </summary>
        AttachmentViewCreateReadOnlyStencilBit = ((int)0x2),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Blend : int
    {
        /// <summary>
        /// Original was VK_BLEND_ZERO = 0
        /// </summary>
        BlendZero = ((int)0),
        /// <summary>
        /// Original was VK_BLEND_ONE = 1
        /// </summary>
        BlendOne = ((int)1),
        /// <summary>
        /// Original was VK_BLEND_CONSTANT_COLOR = 10
        /// </summary>
        BlendConstantColor = ((int)10),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_CONSTANT_COLOR = 11
        /// </summary>
        BlendOneMinusConstantColor = ((int)11),
        /// <summary>
        /// Original was VK_BLEND_CONSTANT_ALPHA = 12
        /// </summary>
        BlendConstantAlpha = ((int)12),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_CONSTANT_ALPHA = 13
        /// </summary>
        BlendOneMinusConstantAlpha = ((int)13),
        /// <summary>
        /// Original was VK_BLEND_SRC_ALPHA_SATURATE = 14
        /// </summary>
        BlendSrcAlphaSaturate = ((int)14),
        /// <summary>
        /// Original was VK_BLEND_SRC1_COLOR = 15
        /// </summary>
        BlendSrc1Color = ((int)15),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_SRC1_COLOR = 16
        /// </summary>
        BlendOneMinusSrc1Color = ((int)16),
        /// <summary>
        /// Original was VK_BLEND_SRC1_ALPHA = 17
        /// </summary>
        BlendSrc1Alpha = ((int)17),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_SRC1_ALPHA = 18
        /// </summary>
        BlendOneMinusSrc1Alpha = ((int)18),
        /// <summary>
        /// Original was VK_BLEND_SRC_COLOR = 2
        /// </summary>
        BlendSrcColor = ((int)2),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_SRC_COLOR = 3
        /// </summary>
        BlendOneMinusSrcColor = ((int)3),
        /// <summary>
        /// Original was VK_BLEND_DEST_COLOR = 4
        /// </summary>
        BlendDestColor = ((int)4),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_DEST_COLOR = 5
        /// </summary>
        BlendOneMinusDestColor = ((int)5),
        /// <summary>
        /// Original was VK_BLEND_SRC_ALPHA = 6
        /// </summary>
        BlendSrcAlpha = ((int)6),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_SRC_ALPHA = 7
        /// </summary>
        BlendOneMinusSrcAlpha = ((int)7),
        /// <summary>
        /// Original was VK_BLEND_DEST_ALPHA = 8
        /// </summary>
        BlendDestAlpha = ((int)8),
        /// <summary>
        /// Original was VK_BLEND_ONE_MINUS_DEST_ALPHA = 9
        /// </summary>
        BlendOneMinusDestAlpha = ((int)9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BlendOp : int
    {
        /// <summary>
        /// Original was VK_BLEND_OP_ADD = 0
        /// </summary>
        BlendOpAdd = ((int)0),
        /// <summary>
        /// Original was VK_BLEND_OP_SUBTRACT = 1
        /// </summary>
        BlendOpSubtract = ((int)1),
        /// <summary>
        /// Original was VK_BLEND_OP_REVERSE_SUBTRACT = 2
        /// </summary>
        BlendOpReverseSubtract = ((int)2),
        /// <summary>
        /// Original was VK_BLEND_OP_MIN = 3
        /// </summary>
        BlendOpMin = ((int)3),
        /// <summary>
        /// Original was VK_BLEND_OP_MAX = 4
        /// </summary>
        BlendOpMax = ((int)4),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BorderColor : int
    {
        /// <summary>
        /// Original was VK_BORDER_COLOR_FLOAT_TRANSPARENT_BLACK = 0
        /// </summary>
        BorderColorFloatTransparentBlack = ((int)0),
        /// <summary>
        /// Original was VK_BORDER_COLOR_INT_TRANSPARENT_BLACK = 1
        /// </summary>
        BorderColorIntTransparentBlack = ((int)1),
        /// <summary>
        /// Original was VK_BORDER_COLOR_FLOAT_OPAQUE_BLACK = 2
        /// </summary>
        BorderColorFloatOpaqueBlack = ((int)2),
        /// <summary>
        /// Original was VK_BORDER_COLOR_INT_OPAQUE_BLACK = 3
        /// </summary>
        BorderColorIntOpaqueBlack = ((int)3),
        /// <summary>
        /// Original was VK_BORDER_COLOR_FLOAT_OPAQUE_WHITE = 4
        /// </summary>
        BorderColorFloatOpaqueWhite = ((int)4),
        /// <summary>
        /// Original was VK_BORDER_COLOR_INT_OPAQUE_WHITE = 5
        /// </summary>
        BorderColorIntOpaqueWhite = ((int)5),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum BufferCreateFlags : int
    {
        /// <summary>
        /// Original was VK_BUFFER_CREATE_SPARSE_BIT = 0x1
        /// </summary>
        BufferCreateSparseBit = ((int)0x1),
        /// <summary>
        /// Original was VK_BUFFER_CREATE_SPARSE_RESIDENCY_BIT = 0x2
        /// </summary>
        BufferCreateSparseResidencyBit = ((int)0x2),
        /// <summary>
        /// Original was VK_BUFFER_CREATE_SPARSE_ALIASED_BIT = 0x4
        /// </summary>
        BufferCreateSparseAliasedBit = ((int)0x4),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum BufferUsageFlags : int
    {
        /// <summary>
        /// Original was VK_BUFFER_USAGE_GENERAL = 0
        /// </summary>
        BufferUsageGeneral = ((int)0),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_TRANSFER_SOURCE_BIT = 0x1
        /// </summary>
        BufferUsageTransferSourceBit = ((int)0x1),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT = 0x10
        /// </summary>
        BufferUsageUniformBufferBit = ((int)0x10),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_INDIRECT_BUFFER_BIT = 0x100
        /// </summary>
        BufferUsageIndirectBufferBit = ((int)0x100),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_TRANSFER_DESTINATION_BIT = 0x2
        /// </summary>
        BufferUsageTransferDestinationBit = ((int)0x2),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_STORAGE_BUFFER_BIT = 0x20
        /// </summary>
        BufferUsageStorageBufferBit = ((int)0x20),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_UNIFORM_TEXEL_BUFFER_BIT = 0x4
        /// </summary>
        BufferUsageUniformTexelBufferBit = ((int)0x4),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_INDEX_BUFFER_BIT = 0x40
        /// </summary>
        BufferUsageIndexBufferBit = ((int)0x40),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_STORAGE_TEXEL_BUFFER_BIT = 0x8
        /// </summary>
        BufferUsageStorageTexelBufferBit = ((int)0x8),
        /// <summary>
        /// Original was VK_BUFFER_USAGE_VERTEX_BUFFER_BIT = 0x80
        /// </summary>
        BufferUsageVertexBufferBit = ((int)0x80),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum BufferViewType : int
    {
        /// <summary>
        /// Original was VK_BUFFER_VIEW_TYPE_RAW = 0
        /// </summary>
        BufferViewTypeRaw = ((int)0),
        /// <summary>
        /// Original was VK_BUFFER_VIEW_TYPE_FORMATTED = 1
        /// </summary>
        BufferViewTypeFormatted = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ChannelFlags : int
    {
        /// <summary>
        /// Original was VK_CHANNEL_R_BIT = 0x1
        /// </summary>
        ChannelRBit = ((int)0x1),
        /// <summary>
        /// Original was VK_CHANNEL_G_BIT = 0x2
        /// </summary>
        ChannelGBit = ((int)0x2),
        /// <summary>
        /// Original was VK_CHANNEL_B_BIT = 0x4
        /// </summary>
        ChannelBBit = ((int)0x4),
        /// <summary>
        /// Original was VK_CHANNEL_A_BIT = 0x8
        /// </summary>
        ChannelABit = ((int)0x8),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ChannelSwizzle : int
    {
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_ZERO = 0
        /// </summary>
        ChannelSwizzleZero = ((int)0),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_ONE = 1
        /// </summary>
        ChannelSwizzleOne = ((int)1),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_R = 2
        /// </summary>
        ChannelSwizzleR = ((int)2),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_G = 3
        /// </summary>
        ChannelSwizzleG = ((int)3),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_B = 4
        /// </summary>
        ChannelSwizzleB = ((int)4),
        /// <summary>
        /// Original was VK_CHANNEL_SWIZZLE_A = 5
        /// </summary>
        ChannelSwizzleA = ((int)5),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum CmdBufferLevel : int
    {
        /// <summary>
        /// Original was VK_CMD_BUFFER_LEVEL_PRIMARY = 0
        /// </summary>
        CmdBufferLevelPrimary = ((int)0),
        /// <summary>
        /// Original was VK_CMD_BUFFER_LEVEL_SECONDARY = 1
        /// </summary>
        CmdBufferLevelSecondary = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum CmdBufferOptimizeFlags : int
    {
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_SMALL_BATCH_BIT = 0x1
        /// </summary>
        CmdBufferOptimizeSmallBatchBit = ((int)0x1),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_NO_SIMULTANEOUS_USE_BIT = 0x10
        /// </summary>
        CmdBufferOptimizeNoSimultaneousUseBit = ((int)0x10),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_PIPELINE_SWITCH_BIT = 0x2
        /// </summary>
        CmdBufferOptimizePipelineSwitchBit = ((int)0x2),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_ONE_TIME_SUBMIT_BIT = 0x4
        /// </summary>
        CmdBufferOptimizeOneTimeSubmitBit = ((int)0x4),
        /// <summary>
        /// Original was VK_CMD_BUFFER_OPTIMIZE_DESCRIPTOR_SET_SWITCH_BIT = 0x8
        /// </summary>
        CmdBufferOptimizeDescriptorSetSwitchBit = ((int)0x8),
    }

    /// <summary>
    /// Used in GL.ResetCommandBuffer
    /// </summary>
    [Flags]
    public enum CmdBufferResetFlags : int
    {
        /// <summary>
        /// Original was VK_CMD_BUFFER_RESET_RELEASE_RESOURCES = 0x1
        /// </summary>
        CmdBufferResetReleaseResources = ((int)0x1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum CmdPoolCreateFlags : int
    {
        /// <summary>
        /// Original was VK_CMD_POOL_CREATE_TRANSIENT_BIT = 0x1
        /// </summary>
        CmdPoolCreateTransientBit = ((int)0x1),
        /// <summary>
        /// Original was VK_CMD_POOL_CREATE_RESET_COMMAND_BUFFER_BIT = 0x2
        /// </summary>
        CmdPoolCreateResetCommandBufferBit = ((int)0x2),
    }

    /// <summary>
    /// Used in GL.ResetCommandPool
    /// </summary>
    [Flags]
    public enum CmdPoolResetFlags : int
    {
        /// <summary>
        /// Original was VK_CMD_POOL_RESET_RELEASE_RESOURCES = 0x1
        /// </summary>
        CmdPoolResetReleaseResources = ((int)0x1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum CompareOp : int
    {
        /// <summary>
        /// Original was VK_COMPARE_OP_NEVER = 0
        /// </summary>
        CompareOpNever = ((int)0),
        /// <summary>
        /// Original was VK_COMPARE_OP_LESS = 1
        /// </summary>
        CompareOpLess = ((int)1),
        /// <summary>
        /// Original was VK_COMPARE_OP_EQUAL = 2
        /// </summary>
        CompareOpEqual = ((int)2),
        /// <summary>
        /// Original was VK_COMPARE_OP_LESS_EQUAL = 3
        /// </summary>
        CompareOpLessEqual = ((int)3),
        /// <summary>
        /// Original was VK_COMPARE_OP_GREATER = 4
        /// </summary>
        CompareOpGreater = ((int)4),
        /// <summary>
        /// Original was VK_COMPARE_OP_NOT_EQUAL = 5
        /// </summary>
        CompareOpNotEqual = ((int)5),
        /// <summary>
        /// Original was VK_COMPARE_OP_GREATER_EQUAL = 6
        /// </summary>
        CompareOpGreaterEqual = ((int)6),
        /// <summary>
        /// Original was VK_COMPARE_OP_ALWAYS = 7
        /// </summary>
        CompareOpAlways = ((int)7),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum CullMode : int
    {
        /// <summary>
        /// Original was VK_CULL_MODE_NONE = 0
        /// </summary>
        CullModeNone = ((int)0),
        /// <summary>
        /// Original was VK_CULL_MODE_FRONT = 1
        /// </summary>
        CullModeFront = ((int)1),
        /// <summary>
        /// Original was VK_CULL_MODE_BACK = 2
        /// </summary>
        CullModeBack = ((int)2),
        /// <summary>
        /// Original was VK_CULL_MODE_FRONT_AND_BACK = 3
        /// </summary>
        CullModeFrontAndBack = ((int)3),
    }

    /// <summary>
    /// Used in GL.CreateDescriptorPool
    /// </summary>
    public enum DescriptorPoolUsage : int
    {
        /// <summary>
        /// Original was VK_DESCRIPTOR_POOL_USAGE_ONE_SHOT = 0
        /// </summary>
        DescriptorPoolUsageOneShot = ((int)0),
        /// <summary>
        /// Original was VK_DESCRIPTOR_POOL_USAGE_DYNAMIC = 1
        /// </summary>
        DescriptorPoolUsageDynamic = ((int)1),
    }

    /// <summary>
    /// Used in GL.AllocDescriptorSets
    /// </summary>
    public enum DescriptorSetUsage : int
    {
        /// <summary>
        /// Original was VK_DESCRIPTOR_SET_USAGE_ONE_SHOT = 0
        /// </summary>
        DescriptorSetUsageOneShot = ((int)0),
        /// <summary>
        /// Original was VK_DESCRIPTOR_SET_USAGE_STATIC = 1
        /// </summary>
        DescriptorSetUsageStatic = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum DescriptorType : int
    {
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_SAMPLER = 0
        /// </summary>
        DescriptorTypeSampler = ((int)0),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_COMBINED_IMAGE_SAMPLER = 1
        /// </summary>
        DescriptorTypeCombinedImageSampler = ((int)1),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_INPUT_ATTACHMENT = 10
        /// </summary>
        DescriptorTypeInputAttachment = ((int)10),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_SAMPLED_IMAGE = 2
        /// </summary>
        DescriptorTypeSampledImage = ((int)2),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_STORAGE_IMAGE = 3
        /// </summary>
        DescriptorTypeStorageImage = ((int)3),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_UNIFORM_TEXEL_BUFFER = 4
        /// </summary>
        DescriptorTypeUniformTexelBuffer = ((int)4),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_STORAGE_TEXEL_BUFFER = 5
        /// </summary>
        DescriptorTypeStorageTexelBuffer = ((int)5),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER = 6
        /// </summary>
        DescriptorTypeUniformBuffer = ((int)6),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_STORAGE_BUFFER = 7
        /// </summary>
        DescriptorTypeStorageBuffer = ((int)7),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_UNIFORM_BUFFER_DYNAMIC = 8
        /// </summary>
        DescriptorTypeUniformBufferDynamic = ((int)8),
        /// <summary>
        /// Original was VK_DESCRIPTOR_TYPE_STORAGE_BUFFER_DYNAMIC = 9
        /// </summary>
        DescriptorTypeStorageBufferDynamic = ((int)9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum DeviceCreateFlags : int
    {
        /// <summary>
        /// Original was VK_DEVICE_CREATE_VALIDATION_BIT = 0x1
        /// </summary>
        DeviceCreateValidationBit = ((int)0x1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum FenceCreateFlags : int
    {
        /// <summary>
        /// Original was VK_FENCE_CREATE_SIGNALED_BIT = 0x1
        /// </summary>
        FenceCreateSignaledBit = ((int)0x1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FillMode : int
    {
        /// <summary>
        /// Original was VK_FILL_MODE_POINTS = 0
        /// </summary>
        FillModePoints = ((int)0),
        /// <summary>
        /// Original was VK_FILL_MODE_WIREFRAME = 1
        /// </summary>
        FillModeWireframe = ((int)1),
        /// <summary>
        /// Original was VK_FILL_MODE_SOLID = 2
        /// </summary>
        FillModeSolid = ((int)2),
    }

    /// <summary>
    /// Used in GL.GetPhysicalDeviceFormatProperties, GL.GetPhysicalDeviceImageFormatProperties and 1 other function
    /// </summary>
    public enum Format : int
    {
        /// <summary>
        /// Original was VK_FORMAT_UNDEFINED = 0
        /// </summary>
        FormatUndefined = ((int)0),
        /// <summary>
        /// Original was VK_FORMAT_R4G4_UNORM = 1
        /// </summary>
        FormatR4G4Unorm = ((int)1),
        /// <summary>
        /// Original was VK_FORMAT_R8_SNORM = 10
        /// </summary>
        FormatR8Snorm = ((int)10),
        /// <summary>
        /// Original was VK_FORMAT_BC2_UNORM = 100
        /// </summary>
        FormatBc2Unorm = ((int)100),
        /// <summary>
        /// Original was VK_FORMAT_BC2_SRGB = 101
        /// </summary>
        FormatBc2Srgb = ((int)101),
        /// <summary>
        /// Original was VK_FORMAT_BC3_UNORM = 102
        /// </summary>
        FormatBc3Unorm = ((int)102),
        /// <summary>
        /// Original was VK_FORMAT_BC3_SRGB = 103
        /// </summary>
        FormatBc3Srgb = ((int)103),
        /// <summary>
        /// Original was VK_FORMAT_BC4_UNORM = 104
        /// </summary>
        FormatBc4Unorm = ((int)104),
        /// <summary>
        /// Original was VK_FORMAT_BC4_SNORM = 105
        /// </summary>
        FormatBc4Snorm = ((int)105),
        /// <summary>
        /// Original was VK_FORMAT_BC5_UNORM = 106
        /// </summary>
        FormatBc5Unorm = ((int)106),
        /// <summary>
        /// Original was VK_FORMAT_BC5_SNORM = 107
        /// </summary>
        FormatBc5Snorm = ((int)107),
        /// <summary>
        /// Original was VK_FORMAT_BC6H_UFLOAT = 108
        /// </summary>
        FormatBc6hUfloat = ((int)108),
        /// <summary>
        /// Original was VK_FORMAT_BC6H_SFLOAT = 109
        /// </summary>
        FormatBc6hSfloat = ((int)109),
        /// <summary>
        /// Original was VK_FORMAT_R8_USCALED = 11
        /// </summary>
        FormatR8Uscaled = ((int)11),
        /// <summary>
        /// Original was VK_FORMAT_BC7_UNORM = 110
        /// </summary>
        FormatBc7Unorm = ((int)110),
        /// <summary>
        /// Original was VK_FORMAT_BC7_SRGB = 111
        /// </summary>
        FormatBc7Srgb = ((int)111),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8_UNORM = 112
        /// </summary>
        FormatEtc2R8G8B8Unorm = ((int)112),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8_SRGB = 113
        /// </summary>
        FormatEtc2R8G8B8Srgb = ((int)113),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8A1_UNORM = 114
        /// </summary>
        FormatEtc2R8G8B8A1Unorm = ((int)114),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8A1_SRGB = 115
        /// </summary>
        FormatEtc2R8G8B8A1Srgb = ((int)115),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8A8_UNORM = 116
        /// </summary>
        FormatEtc2R8G8B8A8Unorm = ((int)116),
        /// <summary>
        /// Original was VK_FORMAT_ETC2_R8G8B8A8_SRGB = 117
        /// </summary>
        FormatEtc2R8G8B8A8Srgb = ((int)117),
        /// <summary>
        /// Original was VK_FORMAT_EAC_R11_UNORM = 118
        /// </summary>
        FormatEacR11Unorm = ((int)118),
        /// <summary>
        /// Original was VK_FORMAT_EAC_R11_SNORM = 119
        /// </summary>
        FormatEacR11Snorm = ((int)119),
        /// <summary>
        /// Original was VK_FORMAT_R8_SSCALED = 12
        /// </summary>
        FormatR8Sscaled = ((int)12),
        /// <summary>
        /// Original was VK_FORMAT_EAC_R11G11_UNORM = 120
        /// </summary>
        FormatEacR11G11Unorm = ((int)120),
        /// <summary>
        /// Original was VK_FORMAT_EAC_R11G11_SNORM = 121
        /// </summary>
        FormatEacR11G11Snorm = ((int)121),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_4x4_UNORM = 122
        /// </summary>
        FormatAstc4X4Unorm = ((int)122),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_4x4_SRGB = 123
        /// </summary>
        FormatAstc4X4Srgb = ((int)123),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_5x4_UNORM = 124
        /// </summary>
        FormatAstc5X4Unorm = ((int)124),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_5x4_SRGB = 125
        /// </summary>
        FormatAstc5X4Srgb = ((int)125),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_5x5_UNORM = 126
        /// </summary>
        FormatAstc5X5Unorm = ((int)126),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_5x5_SRGB = 127
        /// </summary>
        FormatAstc5X5Srgb = ((int)127),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_6x5_UNORM = 128
        /// </summary>
        FormatAstc6X5Unorm = ((int)128),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_6x5_SRGB = 129
        /// </summary>
        FormatAstc6X5Srgb = ((int)129),
        /// <summary>
        /// Original was VK_FORMAT_R8_UINT = 13
        /// </summary>
        FormatR8Uint = ((int)13),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_6x6_UNORM = 130
        /// </summary>
        FormatAstc6X6Unorm = ((int)130),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_6x6_SRGB = 131
        /// </summary>
        FormatAstc6X6Srgb = ((int)131),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x5_UNORM = 132
        /// </summary>
        FormatAstc8X5Unorm = ((int)132),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x5_SRGB = 133
        /// </summary>
        FormatAstc8X5Srgb = ((int)133),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x6_UNORM = 134
        /// </summary>
        FormatAstc8X6Unorm = ((int)134),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x6_SRGB = 135
        /// </summary>
        FormatAstc8X6Srgb = ((int)135),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x8_UNORM = 136
        /// </summary>
        FormatAstc8X8Unorm = ((int)136),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_8x8_SRGB = 137
        /// </summary>
        FormatAstc8X8Srgb = ((int)137),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x5_UNORM = 138
        /// </summary>
        FormatAstc10X5Unorm = ((int)138),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x5_SRGB = 139
        /// </summary>
        FormatAstc10X5Srgb = ((int)139),
        /// <summary>
        /// Original was VK_FORMAT_R8_SINT = 14
        /// </summary>
        FormatR8Sint = ((int)14),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x6_UNORM = 140
        /// </summary>
        FormatAstc10X6Unorm = ((int)140),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x6_SRGB = 141
        /// </summary>
        FormatAstc10X6Srgb = ((int)141),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x8_UNORM = 142
        /// </summary>
        FormatAstc10X8Unorm = ((int)142),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x8_SRGB = 143
        /// </summary>
        FormatAstc10X8Srgb = ((int)143),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x10_UNORM = 144
        /// </summary>
        FormatAstc10X10Unorm = ((int)144),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_10x10_SRGB = 145
        /// </summary>
        FormatAstc10X10Srgb = ((int)145),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_12x10_UNORM = 146
        /// </summary>
        FormatAstc12X10Unorm = ((int)146),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_12x10_SRGB = 147
        /// </summary>
        FormatAstc12X10Srgb = ((int)147),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_12x12_UNORM = 148
        /// </summary>
        FormatAstc12X12Unorm = ((int)148),
        /// <summary>
        /// Original was VK_FORMAT_ASTC_12x12_SRGB = 149
        /// </summary>
        FormatAstc12X12Srgb = ((int)149),
        /// <summary>
        /// Original was VK_FORMAT_R8_SRGB = 15
        /// </summary>
        FormatR8Srgb = ((int)15),
        /// <summary>
        /// Original was VK_FORMAT_B4G4R4A4_UNORM = 150
        /// </summary>
        FormatB4G4R4A4Unorm = ((int)150),
        /// <summary>
        /// Original was VK_FORMAT_B5G5R5A1_UNORM = 151
        /// </summary>
        FormatB5G5R5A1Unorm = ((int)151),
        /// <summary>
        /// Original was VK_FORMAT_B5G6R5_UNORM = 152
        /// </summary>
        FormatB5G6R5Unorm = ((int)152),
        /// <summary>
        /// Original was VK_FORMAT_B5G6R5_USCALED = 153
        /// </summary>
        FormatB5G6R5Uscaled = ((int)153),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_UNORM = 154
        /// </summary>
        FormatB8G8R8Unorm = ((int)154),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_SNORM = 155
        /// </summary>
        FormatB8G8R8Snorm = ((int)155),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_USCALED = 156
        /// </summary>
        FormatB8G8R8Uscaled = ((int)156),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_SSCALED = 157
        /// </summary>
        FormatB8G8R8Sscaled = ((int)157),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_UINT = 158
        /// </summary>
        FormatB8G8R8Uint = ((int)158),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_SINT = 159
        /// </summary>
        FormatB8G8R8Sint = ((int)159),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_UNORM = 16
        /// </summary>
        FormatR8G8Unorm = ((int)16),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8_SRGB = 160
        /// </summary>
        FormatB8G8R8Srgb = ((int)160),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_UNORM = 161
        /// </summary>
        FormatB8G8R8A8Unorm = ((int)161),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_SNORM = 162
        /// </summary>
        FormatB8G8R8A8Snorm = ((int)162),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_USCALED = 163
        /// </summary>
        FormatB8G8R8A8Uscaled = ((int)163),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_SSCALED = 164
        /// </summary>
        FormatB8G8R8A8Sscaled = ((int)164),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_UINT = 165
        /// </summary>
        FormatB8G8R8A8Uint = ((int)165),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_SINT = 166
        /// </summary>
        FormatB8G8R8A8Sint = ((int)166),
        /// <summary>
        /// Original was VK_FORMAT_B8G8R8A8_SRGB = 167
        /// </summary>
        FormatB8G8R8A8Srgb = ((int)167),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_UNORM = 168
        /// </summary>
        FormatB10G10R10A2Unorm = ((int)168),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_SNORM = 169
        /// </summary>
        FormatB10G10R10A2Snorm = ((int)169),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_SNORM = 17
        /// </summary>
        FormatR8G8Snorm = ((int)17),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_USCALED = 170
        /// </summary>
        FormatB10G10R10A2Uscaled = ((int)170),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_SSCALED = 171
        /// </summary>
        FormatB10G10R10A2Sscaled = ((int)171),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_UINT = 172
        /// </summary>
        FormatB10G10R10A2Uint = ((int)172),
        /// <summary>
        /// Original was VK_FORMAT_B10G10R10A2_SINT = 173
        /// </summary>
        FormatB10G10R10A2Sint = ((int)173),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_USCALED = 18
        /// </summary>
        FormatR8G8Uscaled = ((int)18),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_SSCALED = 19
        /// </summary>
        FormatR8G8Sscaled = ((int)19),
        /// <summary>
        /// Original was VK_FORMAT_R4G4_USCALED = 2
        /// </summary>
        FormatR4G4Uscaled = ((int)2),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_UINT = 20
        /// </summary>
        FormatR8G8Uint = ((int)20),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_SINT = 21
        /// </summary>
        FormatR8G8Sint = ((int)21),
        /// <summary>
        /// Original was VK_FORMAT_R8G8_SRGB = 22
        /// </summary>
        FormatR8G8Srgb = ((int)22),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_UNORM = 23
        /// </summary>
        FormatR8G8B8Unorm = ((int)23),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_SNORM = 24
        /// </summary>
        FormatR8G8B8Snorm = ((int)24),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_USCALED = 25
        /// </summary>
        FormatR8G8B8Uscaled = ((int)25),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_SSCALED = 26
        /// </summary>
        FormatR8G8B8Sscaled = ((int)26),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_UINT = 27
        /// </summary>
        FormatR8G8B8Uint = ((int)27),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_SINT = 28
        /// </summary>
        FormatR8G8B8Sint = ((int)28),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8_SRGB = 29
        /// </summary>
        FormatR8G8B8Srgb = ((int)29),
        /// <summary>
        /// Original was VK_FORMAT_R4G4B4A4_UNORM = 3
        /// </summary>
        FormatR4G4B4A4Unorm = ((int)3),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_UNORM = 30
        /// </summary>
        FormatR8G8B8A8Unorm = ((int)30),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_SNORM = 31
        /// </summary>
        FormatR8G8B8A8Snorm = ((int)31),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_USCALED = 32
        /// </summary>
        FormatR8G8B8A8Uscaled = ((int)32),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_SSCALED = 33
        /// </summary>
        FormatR8G8B8A8Sscaled = ((int)33),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_UINT = 34
        /// </summary>
        FormatR8G8B8A8Uint = ((int)34),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_SINT = 35
        /// </summary>
        FormatR8G8B8A8Sint = ((int)35),
        /// <summary>
        /// Original was VK_FORMAT_R8G8B8A8_SRGB = 36
        /// </summary>
        FormatR8G8B8A8Srgb = ((int)36),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_UNORM = 37
        /// </summary>
        FormatR10G10B10A2Unorm = ((int)37),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_SNORM = 38
        /// </summary>
        FormatR10G10B10A2Snorm = ((int)38),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_USCALED = 39
        /// </summary>
        FormatR10G10B10A2Uscaled = ((int)39),
        /// <summary>
        /// Original was VK_FORMAT_R4G4B4A4_USCALED = 4
        /// </summary>
        FormatR4G4B4A4Uscaled = ((int)4),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_SSCALED = 40
        /// </summary>
        FormatR10G10B10A2Sscaled = ((int)40),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_UINT = 41
        /// </summary>
        FormatR10G10B10A2Uint = ((int)41),
        /// <summary>
        /// Original was VK_FORMAT_R10G10B10A2_SINT = 42
        /// </summary>
        FormatR10G10B10A2Sint = ((int)42),
        /// <summary>
        /// Original was VK_FORMAT_R16_UNORM = 43
        /// </summary>
        FormatR16Unorm = ((int)43),
        /// <summary>
        /// Original was VK_FORMAT_R16_SNORM = 44
        /// </summary>
        FormatR16Snorm = ((int)44),
        /// <summary>
        /// Original was VK_FORMAT_R16_USCALED = 45
        /// </summary>
        FormatR16Uscaled = ((int)45),
        /// <summary>
        /// Original was VK_FORMAT_R16_SSCALED = 46
        /// </summary>
        FormatR16Sscaled = ((int)46),
        /// <summary>
        /// Original was VK_FORMAT_R16_UINT = 47
        /// </summary>
        FormatR16Uint = ((int)47),
        /// <summary>
        /// Original was VK_FORMAT_R16_SINT = 48
        /// </summary>
        FormatR16Sint = ((int)48),
        /// <summary>
        /// Original was VK_FORMAT_R16_SFLOAT = 49
        /// </summary>
        FormatR16Sfloat = ((int)49),
        /// <summary>
        /// Original was VK_FORMAT_R5G6B5_UNORM = 5
        /// </summary>
        FormatR5G6B5Unorm = ((int)5),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_UNORM = 50
        /// </summary>
        FormatR16G16Unorm = ((int)50),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_SNORM = 51
        /// </summary>
        FormatR16G16Snorm = ((int)51),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_USCALED = 52
        /// </summary>
        FormatR16G16Uscaled = ((int)52),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_SSCALED = 53
        /// </summary>
        FormatR16G16Sscaled = ((int)53),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_UINT = 54
        /// </summary>
        FormatR16G16Uint = ((int)54),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_SINT = 55
        /// </summary>
        FormatR16G16Sint = ((int)55),
        /// <summary>
        /// Original was VK_FORMAT_R16G16_SFLOAT = 56
        /// </summary>
        FormatR16G16Sfloat = ((int)56),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_UNORM = 57
        /// </summary>
        FormatR16G16B16Unorm = ((int)57),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_SNORM = 58
        /// </summary>
        FormatR16G16B16Snorm = ((int)58),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_USCALED = 59
        /// </summary>
        FormatR16G16B16Uscaled = ((int)59),
        /// <summary>
        /// Original was VK_FORMAT_R5G6B5_USCALED = 6
        /// </summary>
        FormatR5G6B5Uscaled = ((int)6),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_SSCALED = 60
        /// </summary>
        FormatR16G16B16Sscaled = ((int)60),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_UINT = 61
        /// </summary>
        FormatR16G16B16Uint = ((int)61),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_SINT = 62
        /// </summary>
        FormatR16G16B16Sint = ((int)62),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16_SFLOAT = 63
        /// </summary>
        FormatR16G16B16Sfloat = ((int)63),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_UNORM = 64
        /// </summary>
        FormatR16G16B16A16Unorm = ((int)64),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_SNORM = 65
        /// </summary>
        FormatR16G16B16A16Snorm = ((int)65),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_USCALED = 66
        /// </summary>
        FormatR16G16B16A16Uscaled = ((int)66),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_SSCALED = 67
        /// </summary>
        FormatR16G16B16A16Sscaled = ((int)67),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_UINT = 68
        /// </summary>
        FormatR16G16B16A16Uint = ((int)68),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_SINT = 69
        /// </summary>
        FormatR16G16B16A16Sint = ((int)69),
        /// <summary>
        /// Original was VK_FORMAT_R5G5B5A1_UNORM = 7
        /// </summary>
        FormatR5G5B5A1Unorm = ((int)7),
        /// <summary>
        /// Original was VK_FORMAT_R16G16B16A16_SFLOAT = 70
        /// </summary>
        FormatR16G16B16A16Sfloat = ((int)70),
        /// <summary>
        /// Original was VK_FORMAT_R32_UINT = 71
        /// </summary>
        FormatR32Uint = ((int)71),
        /// <summary>
        /// Original was VK_FORMAT_R32_SINT = 72
        /// </summary>
        FormatR32Sint = ((int)72),
        /// <summary>
        /// Original was VK_FORMAT_R32_SFLOAT = 73
        /// </summary>
        FormatR32Sfloat = ((int)73),
        /// <summary>
        /// Original was VK_FORMAT_R32G32_UINT = 74
        /// </summary>
        FormatR32G32Uint = ((int)74),
        /// <summary>
        /// Original was VK_FORMAT_R32G32_SINT = 75
        /// </summary>
        FormatR32G32Sint = ((int)75),
        /// <summary>
        /// Original was VK_FORMAT_R32G32_SFLOAT = 76
        /// </summary>
        FormatR32G32Sfloat = ((int)76),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32_UINT = 77
        /// </summary>
        FormatR32G32B32Uint = ((int)77),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32_SINT = 78
        /// </summary>
        FormatR32G32B32Sint = ((int)78),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32_SFLOAT = 79
        /// </summary>
        FormatR32G32B32Sfloat = ((int)79),
        /// <summary>
        /// Original was VK_FORMAT_R5G5B5A1_USCALED = 8
        /// </summary>
        FormatR5G5B5A1Uscaled = ((int)8),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32A32_UINT = 80
        /// </summary>
        FormatR32G32B32A32Uint = ((int)80),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32A32_SINT = 81
        /// </summary>
        FormatR32G32B32A32Sint = ((int)81),
        /// <summary>
        /// Original was VK_FORMAT_R32G32B32A32_SFLOAT = 82
        /// </summary>
        FormatR32G32B32A32Sfloat = ((int)82),
        /// <summary>
        /// Original was VK_FORMAT_R64_SFLOAT = 83
        /// </summary>
        FormatR64Sfloat = ((int)83),
        /// <summary>
        /// Original was VK_FORMAT_R64G64_SFLOAT = 84
        /// </summary>
        FormatR64G64Sfloat = ((int)84),
        /// <summary>
        /// Original was VK_FORMAT_R64G64B64_SFLOAT = 85
        /// </summary>
        FormatR64G64B64Sfloat = ((int)85),
        /// <summary>
        /// Original was VK_FORMAT_R64G64B64A64_SFLOAT = 86
        /// </summary>
        FormatR64G64B64A64Sfloat = ((int)86),
        /// <summary>
        /// Original was VK_FORMAT_R11G11B10_UFLOAT = 87
        /// </summary>
        FormatR11G11B10Ufloat = ((int)87),
        /// <summary>
        /// Original was VK_FORMAT_R9G9B9E5_UFLOAT = 88
        /// </summary>
        FormatR9G9B9e5Ufloat = ((int)88),
        /// <summary>
        /// Original was VK_FORMAT_D16_UNORM = 89
        /// </summary>
        FormatD16Unorm = ((int)89),
        /// <summary>
        /// Original was VK_FORMAT_R8_UNORM = 9
        /// </summary>
        FormatR8Unorm = ((int)9),
        /// <summary>
        /// Original was VK_FORMAT_D24_UNORM = 90
        /// </summary>
        FormatD24Unorm = ((int)90),
        /// <summary>
        /// Original was VK_FORMAT_D32_SFLOAT = 91
        /// </summary>
        FormatD32Sfloat = ((int)91),
        /// <summary>
        /// Original was VK_FORMAT_S8_UINT = 92
        /// </summary>
        FormatS8Uint = ((int)92),
        /// <summary>
        /// Original was VK_FORMAT_D16_UNORM_S8_UINT = 93
        /// </summary>
        FormatD16UnormS8Uint = ((int)93),
        /// <summary>
        /// Original was VK_FORMAT_D24_UNORM_S8_UINT = 94
        /// </summary>
        FormatD24UnormS8Uint = ((int)94),
        /// <summary>
        /// Original was VK_FORMAT_D32_SFLOAT_S8_UINT = 95
        /// </summary>
        FormatD32SfloatS8Uint = ((int)95),
        /// <summary>
        /// Original was VK_FORMAT_BC1_RGB_UNORM = 96
        /// </summary>
        FormatBc1RgbUnorm = ((int)96),
        /// <summary>
        /// Original was VK_FORMAT_BC1_RGB_SRGB = 97
        /// </summary>
        FormatBc1RgbSrgb = ((int)97),
        /// <summary>
        /// Original was VK_FORMAT_BC1_RGBA_UNORM = 98
        /// </summary>
        FormatBc1RgbaUnorm = ((int)98),
        /// <summary>
        /// Original was VK_FORMAT_BC1_RGBA_SRGB = 99
        /// </summary>
        FormatBc1RgbaSrgb = ((int)99),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum FormatFeatureFlags : int
    {
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_SAMPLED_IMAGE_BIT = 0x1
        /// </summary>
        FormatFeatureSampledImageBit = ((int)0x1),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_BIT = 0x10
        /// </summary>
        FormatFeatureStorageTexelBufferBit = ((int)0x10),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BLEND_BIT = 0x100
        /// </summary>
        FormatFeatureColorAttachmentBlendBit = ((int)0x100),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_STORAGE_IMAGE_BIT = 0x2
        /// </summary>
        FormatFeatureStorageImageBit = ((int)0x2),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_STORAGE_TEXEL_BUFFER_ATOMIC_BIT = 0x20
        /// </summary>
        FormatFeatureStorageTexelBufferAtomicBit = ((int)0x20),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_DEPTH_STENCIL_ATTACHMENT_BIT = 0x200
        /// </summary>
        FormatFeatureDepthStencilAttachmentBit = ((int)0x200),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_STORAGE_IMAGE_ATOMIC_BIT = 0x4
        /// </summary>
        FormatFeatureStorageImageAtomicBit = ((int)0x4),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_VERTEX_BUFFER_BIT = 0x40
        /// </summary>
        FormatFeatureVertexBufferBit = ((int)0x40),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_CONVERSION_BIT = 0x400
        /// </summary>
        FormatFeatureConversionBit = ((int)0x400),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_UNIFORM_TEXEL_BUFFER_BIT = 0x8
        /// </summary>
        FormatFeatureUniformTexelBufferBit = ((int)0x8),
        /// <summary>
        /// Original was VK_FORMAT_FEATURE_COLOR_ATTACHMENT_BIT = 0x80
        /// </summary>
        FormatFeatureColorAttachmentBit = ((int)0x80),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum FrontFace : int
    {
        /// <summary>
        /// Original was VK_FRONT_FACE_CCW = 0
        /// </summary>
        FrontFaceCcw = ((int)0),
        /// <summary>
        /// Original was VK_FRONT_FACE_CW = 1
        /// </summary>
        FrontFaceCw = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImageAspect : int
    {
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_COLOR = 0
        /// </summary>
        ImageAspectColor = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_DEPTH = 1
        /// </summary>
        ImageAspectDepth = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_STENCIL = 2
        /// </summary>
        ImageAspectStencil = ((int)2),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_METADATA = 3
        /// </summary>
        ImageAspectMetadata = ((int)3),
    }

    /// <summary>
    /// Used in GL.CmdClearDepthStencilAttachment
    /// </summary>
    [Flags]
    public enum ImageAspectFlags : int
    {
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_COLOR_BIT = 0x1
        /// </summary>
        ImageAspectColorBit = ((int)0x1),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_DEPTH_BIT = 0x2
        /// </summary>
        ImageAspectDepthBit = ((int)0x2),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_STENCIL_BIT = 0x4
        /// </summary>
        ImageAspectStencilBit = ((int)0x4),
        /// <summary>
        /// Original was VK_IMAGE_ASPECT_METADATA_BIT = 0x8
        /// </summary>
        ImageAspectMetadataBit = ((int)0x8),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum ImageCreateFlags : int
    {
        /// <summary>
        /// Original was VK_IMAGE_CREATE_SPARSE_BIT = 0x1
        /// </summary>
        ImageCreateSparseBit = ((int)0x1),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_MUTABLE_FORMAT_BIT = 0x10
        /// </summary>
        ImageCreateMutableFormatBit = ((int)0x10),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_SPARSE_RESIDENCY_BIT = 0x2
        /// </summary>
        ImageCreateSparseResidencyBit = ((int)0x2),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_CUBE_COMPATIBLE_BIT = 0x20
        /// </summary>
        ImageCreateCubeCompatibleBit = ((int)0x20),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_SPARSE_ALIASED_BIT = 0x4
        /// </summary>
        ImageCreateSparseAliasedBit = ((int)0x4),
        /// <summary>
        /// Original was VK_IMAGE_CREATE_INVARIANT_DATA_BIT = 0x8
        /// </summary>
        ImageCreateInvariantDataBit = ((int)0x8),
    }

    /// <summary>
    /// Used in GL.CmdBlitImage, GL.CmdClearColorAttachment and 7 other functions
    /// </summary>
    public enum ImageLayout : int
    {
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_UNDEFINED = 0
        /// </summary>
        ImageLayoutUndefined = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_GENERAL = 1
        /// </summary>
        ImageLayoutGeneral = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_COLOR_ATTACHMENT_OPTIMAL = 2
        /// </summary>
        ImageLayoutColorAttachmentOptimal = ((int)2),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_DEPTH_STENCIL_ATTACHMENT_OPTIMAL = 3
        /// </summary>
        ImageLayoutDepthStencilAttachmentOptimal = ((int)3),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_DEPTH_STENCIL_READ_ONLY_OPTIMAL = 4
        /// </summary>
        ImageLayoutDepthStencilReadOnlyOptimal = ((int)4),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_SHADER_READ_ONLY_OPTIMAL = 5
        /// </summary>
        ImageLayoutShaderReadOnlyOptimal = ((int)5),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_TRANSFER_SOURCE_OPTIMAL = 6
        /// </summary>
        ImageLayoutTransferSourceOptimal = ((int)6),
        /// <summary>
        /// Original was VK_IMAGE_LAYOUT_TRANSFER_DESTINATION_OPTIMAL = 7
        /// </summary>
        ImageLayoutTransferDestinationOptimal = ((int)7),
    }

    /// <summary>
    /// Used in GL.GetPhysicalDeviceImageFormatProperties, GL.GetPhysicalDeviceSparseImageFormatProperties
    /// </summary>
    public enum ImageTiling : int
    {
        /// <summary>
        /// Original was VK_IMAGE_TILING_LINEAR = 0
        /// </summary>
        ImageTilingLinear = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_TILING_OPTIMAL = 1
        /// </summary>
        ImageTilingOptimal = ((int)1),
    }

    /// <summary>
    /// Used in GL.GetPhysicalDeviceImageFormatProperties, GL.GetPhysicalDeviceSparseImageFormatProperties
    /// </summary>
    public enum ImageType : int
    {
        /// <summary>
        /// Original was VK_IMAGE_TYPE_1D = 0
        /// </summary>
        ImageType1D = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_TYPE_2D = 1
        /// </summary>
        ImageType2D = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_TYPE_3D = 2
        /// </summary>
        ImageType3D = ((int)2),
    }

    /// <summary>
    /// Used in GL.GetPhysicalDeviceImageFormatProperties, GL.GetPhysicalDeviceSparseImageFormatProperties
    /// </summary>
    [Flags]
    public enum ImageUsageFlags : int
    {
        /// <summary>
        /// Original was VK_IMAGE_USAGE_GENERAL = 0
        /// </summary>
        ImageUsageGeneral = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_TRANSFER_SOURCE_BIT = 0x1
        /// </summary>
        ImageUsageTransferSourceBit = ((int)0x1),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_COLOR_ATTACHMENT_BIT = 0x10
        /// </summary>
        ImageUsageColorAttachmentBit = ((int)0x10),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_TRANSFER_DESTINATION_BIT = 0x2
        /// </summary>
        ImageUsageTransferDestinationBit = ((int)0x2),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_DEPTH_STENCIL_BIT = 0x20
        /// </summary>
        ImageUsageDepthStencilBit = ((int)0x20),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_SAMPLED_BIT = 0x4
        /// </summary>
        ImageUsageSampledBit = ((int)0x4),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_TRANSIENT_ATTACHMENT_BIT = 0x40
        /// </summary>
        ImageUsageTransientAttachmentBit = ((int)0x40),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_STORAGE_BIT = 0x8
        /// </summary>
        ImageUsageStorageBit = ((int)0x8),
        /// <summary>
        /// Original was VK_IMAGE_USAGE_INPUT_ATTACHMENT_BIT = 0x80
        /// </summary>
        ImageUsageInputAttachmentBit = ((int)0x80),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ImageViewType : int
    {
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_1D = 0
        /// </summary>
        ImageViewType1D = ((int)0),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_2D = 1
        /// </summary>
        ImageViewType2D = ((int)1),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_3D = 2
        /// </summary>
        ImageViewType3D = ((int)2),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_CUBE = 3
        /// </summary>
        ImageViewTypeCube = ((int)3),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_1D_ARRAY = 4
        /// </summary>
        ImageViewType1DArray = ((int)4),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_2D_ARRAY = 5
        /// </summary>
        ImageViewType2DArray = ((int)5),
        /// <summary>
        /// Original was VK_IMAGE_VIEW_TYPE_CUBE_ARRAY = 6
        /// </summary>
        ImageViewTypeCubeArray = ((int)6),
    }

    /// <summary>
    /// Used in GL.CmdBindIndexBuffer
    /// </summary>
    public enum IndexType : int
    {
        /// <summary>
        /// Original was VK_INDEX_TYPE_UINT16 = 0
        /// </summary>
        IndexTypeUint16 = ((int)0),
        /// <summary>
        /// Original was VK_INDEX_TYPE_UINT32 = 1
        /// </summary>
        IndexTypeUint32 = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum LogicOp : int
    {
        /// <summary>
        /// Original was VK_LOGIC_OP_CLEAR = 0
        /// </summary>
        LogicOpClear = ((int)0),
        /// <summary>
        /// Original was VK_LOGIC_OP_AND = 1
        /// </summary>
        LogicOpAnd = ((int)1),
        /// <summary>
        /// Original was VK_LOGIC_OP_INVERT = 10
        /// </summary>
        LogicOpInvert = ((int)10),
        /// <summary>
        /// Original was VK_LOGIC_OP_OR_REVERSE = 11
        /// </summary>
        LogicOpOrReverse = ((int)11),
        /// <summary>
        /// Original was VK_LOGIC_OP_COPY_INVERTED = 12
        /// </summary>
        LogicOpCopyInverted = ((int)12),
        /// <summary>
        /// Original was VK_LOGIC_OP_OR_INVERTED = 13
        /// </summary>
        LogicOpOrInverted = ((int)13),
        /// <summary>
        /// Original was VK_LOGIC_OP_NAND = 14
        /// </summary>
        LogicOpNand = ((int)14),
        /// <summary>
        /// Original was VK_LOGIC_OP_SET = 15
        /// </summary>
        LogicOpSet = ((int)15),
        /// <summary>
        /// Original was VK_LOGIC_OP_AND_REVERSE = 2
        /// </summary>
        LogicOpAndReverse = ((int)2),
        /// <summary>
        /// Original was VK_LOGIC_OP_COPY = 3
        /// </summary>
        LogicOpCopy = ((int)3),
        /// <summary>
        /// Original was VK_LOGIC_OP_AND_INVERTED = 4
        /// </summary>
        LogicOpAndInverted = ((int)4),
        /// <summary>
        /// Original was VK_LOGIC_OP_NOOP = 5
        /// </summary>
        LogicOpNoop = ((int)5),
        /// <summary>
        /// Original was VK_LOGIC_OP_XOR = 6
        /// </summary>
        LogicOpXor = ((int)6),
        /// <summary>
        /// Original was VK_LOGIC_OP_OR = 7
        /// </summary>
        LogicOpOr = ((int)7),
        /// <summary>
        /// Original was VK_LOGIC_OP_NOR = 8
        /// </summary>
        LogicOpNor = ((int)8),
        /// <summary>
        /// Original was VK_LOGIC_OP_EQUIV = 9
        /// </summary>
        LogicOpEquiv = ((int)9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MemoryHeapFlags : int
    {
        /// <summary>
        /// Original was VK_MEMORY_HEAP_HOST_LOCAL = 0x1
        /// </summary>
        MemoryHeapHostLocal = ((int)0x1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MemoryInputFlags : int
    {
        /// <summary>
        /// Original was VK_MEMORY_INPUT_HOST_READ_BIT = 0x1
        /// </summary>
        MemoryInputHostReadBit = ((int)0x1),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_UNIFORM_READ_BIT = 0x10
        /// </summary>
        MemoryInputUniformReadBit = ((int)0x10),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_INPUT_ATTACHMENT_BIT = 0x100
        /// </summary>
        MemoryInputInputAttachmentBit = ((int)0x100),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_INDIRECT_COMMAND_BIT = 0x2
        /// </summary>
        MemoryInputIndirectCommandBit = ((int)0x2),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_SHADER_READ_BIT = 0x20
        /// </summary>
        MemoryInputShaderReadBit = ((int)0x20),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_TRANSFER_BIT = 0x200
        /// </summary>
        MemoryInputTransferBit = ((int)0x200),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_INDEX_FETCH_BIT = 0x4
        /// </summary>
        MemoryInputIndexFetchBit = ((int)0x4),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_COLOR_ATTACHMENT_BIT = 0x40
        /// </summary>
        MemoryInputColorAttachmentBit = ((int)0x40),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_VERTEX_ATTRIBUTE_FETCH_BIT = 0x8
        /// </summary>
        MemoryInputVertexAttributeFetchBit = ((int)0x8),
        /// <summary>
        /// Original was VK_MEMORY_INPUT_DEPTH_STENCIL_ATTACHMENT_BIT = 0x80
        /// </summary>
        MemoryInputDepthStencilAttachmentBit = ((int)0x80),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MemoryOutputFlags : int
    {
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_HOST_WRITE_BIT = 0x1
        /// </summary>
        MemoryOutputHostWriteBit = ((int)0x1),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_TRANSFER_BIT = 0x10
        /// </summary>
        MemoryOutputTransferBit = ((int)0x10),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_SHADER_WRITE_BIT = 0x2
        /// </summary>
        MemoryOutputShaderWriteBit = ((int)0x2),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_COLOR_ATTACHMENT_BIT = 0x4
        /// </summary>
        MemoryOutputColorAttachmentBit = ((int)0x4),
        /// <summary>
        /// Original was VK_MEMORY_OUTPUT_DEPTH_STENCIL_ATTACHMENT_BIT = 0x8
        /// </summary>
        MemoryOutputDepthStencilAttachmentBit = ((int)0x8),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum MemoryPropertyFlags : int
    {
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_DEVICE_ONLY = 0
        /// </summary>
        MemoryPropertyDeviceOnly = ((int)0),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT = 0x1
        /// </summary>
        MemoryPropertyHostVisibleBit = ((int)0x1),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_LAZILY_ALLOCATED_BIT = 0x10
        /// </summary>
        MemoryPropertyLazilyAllocatedBit = ((int)0x10),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_HOST_NON_COHERENT_BIT = 0x2
        /// </summary>
        MemoryPropertyHostNonCoherentBit = ((int)0x2),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_HOST_UNCACHED_BIT = 0x4
        /// </summary>
        MemoryPropertyHostUncachedBit = ((int)0x4),
        /// <summary>
        /// Original was VK_MEMORY_PROPERTY_HOST_WRITE_COMBINED_BIT = 0x8
        /// </summary>
        MemoryPropertyHostWriteCombinedBit = ((int)0x8),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PhysicalDeviceType : int
    {
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_OTHER = 0
        /// </summary>
        PhysicalDeviceTypeOther = ((int)0),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_INTEGRATED_GPU = 1
        /// </summary>
        PhysicalDeviceTypeIntegratedGpu = ((int)1),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_DISCRETE_GPU = 2
        /// </summary>
        PhysicalDeviceTypeDiscreteGpu = ((int)2),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_VIRTUAL_GPU = 3
        /// </summary>
        PhysicalDeviceTypeVirtualGpu = ((int)3),
        /// <summary>
        /// Original was VK_PHYSICAL_DEVICE_TYPE_CPU = 4
        /// </summary>
        PhysicalDeviceTypeCpu = ((int)4),
    }

    /// <summary>
    /// Used in GL.CmdBindDescriptorSets, GL.CmdBindPipeline
    /// </summary>
    public enum PipelineBindPoint : int
    {
        /// <summary>
        /// Original was VK_PIPELINE_BIND_POINT_COMPUTE = 0
        /// </summary>
        PipelineBindPointCompute = ((int)0),
        /// <summary>
        /// Original was VK_PIPELINE_BIND_POINT_GRAPHICS = 1
        /// </summary>
        PipelineBindPointGraphics = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum PipelineCreateFlags : int
    {
        /// <summary>
        /// Original was VK_PIPELINE_CREATE_DISABLE_OPTIMIZATION_BIT = 0x1
        /// </summary>
        PipelineCreateDisableOptimizationBit = ((int)0x1),
        /// <summary>
        /// Original was VK_PIPELINE_CREATE_ALLOW_DERIVATIVES_BIT = 0x2
        /// </summary>
        PipelineCreateAllowDerivativesBit = ((int)0x2),
        /// <summary>
        /// Original was VK_PIPELINE_CREATE_DERIVATIVE_BIT = 0x4
        /// </summary>
        PipelineCreateDerivativeBit = ((int)0x4),
    }

    /// <summary>
    /// Used in GL.CmdPipelineBarrier, GL.CmdResetEvent and 2 other functions
    /// </summary>
    [Flags]
    public enum PipelineStageFlags : int
    {
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_ALL_GRAPHICS = 0x000007FF
        /// </summary>
        PipelineStageAllGraphics = ((int)0x000007FF),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_ALL_GPU_COMMANDS = 0x00003FFF
        /// </summary>
        PipelineStageAllGpuCommands = ((int)0x00003FFF),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TOP_OF_PIPE_BIT = 0x1
        /// </summary>
        PipelineStageTopOfPipeBit = ((int)0x1),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TESS_CONTROL_SHADER_BIT = 0x10
        /// </summary>
        PipelineStageTessControlShaderBit = ((int)0x10),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_EARLY_FRAGMENT_TESTS_BIT = 0x100
        /// </summary>
        PipelineStageEarlyFragmentTestsBit = ((int)0x100),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TRANSFER_BIT = 0x1000
        /// </summary>
        PipelineStageTransferBit = ((int)0x1000),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_DRAW_INDIRECT_BIT = 0x2
        /// </summary>
        PipelineStageDrawIndirectBit = ((int)0x2),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TESS_EVALUATION_SHADER_BIT = 0x20
        /// </summary>
        PipelineStageTessEvaluationShaderBit = ((int)0x20),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_LATE_FRAGMENT_TESTS_BIT = 0x200
        /// </summary>
        PipelineStageLateFragmentTestsBit = ((int)0x200),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_TRANSITION_BIT = 0x2000
        /// </summary>
        PipelineStageTransitionBit = ((int)0x2000),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_VERTEX_INPUT_BIT = 0x4
        /// </summary>
        PipelineStageVertexInputBit = ((int)0x4),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_GEOMETRY_SHADER_BIT = 0x40
        /// </summary>
        PipelineStageGeometryShaderBit = ((int)0x40),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_COLOR_ATTACHMENT_OUTPUT_BIT = 0x400
        /// </summary>
        PipelineStageColorAttachmentOutputBit = ((int)0x400),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_HOST_BIT = 0x4000
        /// </summary>
        PipelineStageHostBit = ((int)0x4000),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_VERTEX_SHADER_BIT = 0x8
        /// </summary>
        PipelineStageVertexShaderBit = ((int)0x8),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_FRAGMENT_SHADER_BIT = 0x80
        /// </summary>
        PipelineStageFragmentShaderBit = ((int)0x80),
        /// <summary>
        /// Original was VK_PIPELINE_STAGE_COMPUTE_SHADER_BIT = 0x800
        /// </summary>
        PipelineStageComputeShaderBit = ((int)0x800),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum PrimitiveTopology : int
    {
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_POINT_LIST = 0
        /// </summary>
        PrimitiveTopologyPointList = ((int)0),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_LINE_LIST = 1
        /// </summary>
        PrimitiveTopologyLineList = ((int)1),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_PATCH = 10
        /// </summary>
        PrimitiveTopologyPatch = ((int)10),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_LINE_STRIP = 2
        /// </summary>
        PrimitiveTopologyLineStrip = ((int)2),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST = 3
        /// </summary>
        PrimitiveTopologyTriangleList = ((int)3),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP = 4
        /// </summary>
        PrimitiveTopologyTriangleStrip = ((int)4),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_FAN = 5
        /// </summary>
        PrimitiveTopologyTriangleFan = ((int)5),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_LINE_LIST_ADJ = 6
        /// </summary>
        PrimitiveTopologyLineListAdj = ((int)6),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_LINE_STRIP_ADJ = 7
        /// </summary>
        PrimitiveTopologyLineStripAdj = ((int)7),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_LIST_ADJ = 8
        /// </summary>
        PrimitiveTopologyTriangleListAdj = ((int)8),
        /// <summary>
        /// Original was VK_PRIMITIVE_TOPOLOGY_TRIANGLE_STRIP_ADJ = 9
        /// </summary>
        PrimitiveTopologyTriangleStripAdj = ((int)9),
    }

    /// <summary>
    /// Used in GL.CmdBeginQuery
    /// </summary>
    [Flags]
    public enum QueryControlFlags : int
    {
        /// <summary>
        /// Original was VK_QUERY_CONTROL_CONSERVATIVE_BIT = 0x1
        /// </summary>
        QueryControlConservativeBit = ((int)0x1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum QueryPipelineStatisticFlags : int
    {
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_IA_VERTICES_BIT = 0x1
        /// </summary>
        QueryPipelineStatisticIaVerticesBit = ((int)0x1),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_GS_PRIMITIVES_BIT = 0x10
        /// </summary>
        QueryPipelineStatisticGsPrimitivesBit = ((int)0x10),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_TCS_PATCHES_BIT = 0x100
        /// </summary>
        QueryPipelineStatisticTcsPatchesBit = ((int)0x100),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_IA_PRIMITIVES_BIT = 0x2
        /// </summary>
        QueryPipelineStatisticIaPrimitivesBit = ((int)0x2),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_C_INVOCATIONS_BIT = 0x20
        /// </summary>
        QueryPipelineStatisticCInvocationsBit = ((int)0x20),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_TES_INVOCATIONS_BIT = 0x200
        /// </summary>
        QueryPipelineStatisticTesInvocationsBit = ((int)0x200),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_VS_INVOCATIONS_BIT = 0x4
        /// </summary>
        QueryPipelineStatisticVsInvocationsBit = ((int)0x4),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_C_PRIMITIVES_BIT = 0x40
        /// </summary>
        QueryPipelineStatisticCPrimitivesBit = ((int)0x40),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_CS_INVOCATIONS_BIT = 0x400
        /// </summary>
        QueryPipelineStatisticCsInvocationsBit = ((int)0x400),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_GS_INVOCATIONS_BIT = 0x8
        /// </summary>
        QueryPipelineStatisticGsInvocationsBit = ((int)0x8),
        /// <summary>
        /// Original was VK_QUERY_PIPELINE_STATISTIC_FS_INVOCATIONS_BIT = 0x80
        /// </summary>
        QueryPipelineStatisticFsInvocationsBit = ((int)0x80),
    }

    /// <summary>
    /// Used in GL.CmdCopyQueryPoolResults, GL.GetQueryPoolResults
    /// </summary>
    [Flags]
    public enum QueryResultFlags : int
    {
        /// <summary>
        /// Original was VK_QUERY_RESULT_DEFAULT = 0
        /// </summary>
        QueryResultDefault = ((int)0),
        /// <summary>
        /// Original was VK_QUERY_RESULT_64_BIT = 0x1
        /// </summary>
        QueryResult64Bit = ((int)0x1),
        /// <summary>
        /// Original was VK_QUERY_RESULT_WAIT_BIT = 0x2
        /// </summary>
        QueryResultWaitBit = ((int)0x2),
        /// <summary>
        /// Original was VK_QUERY_RESULT_WITH_AVAILABILITY_BIT = 0x4
        /// </summary>
        QueryResultWithAvailabilityBit = ((int)0x4),
        /// <summary>
        /// Original was VK_QUERY_RESULT_PARTIAL_BIT = 0x8
        /// </summary>
        QueryResultPartialBit = ((int)0x8),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum QueryType : int
    {
        /// <summary>
        /// Original was VK_QUERY_TYPE_OCCLUSION = 0
        /// </summary>
        QueryTypeOcclusion = ((int)0),
        /// <summary>
        /// Original was VK_QUERY_TYPE_PIPELINE_STATISTICS = 1
        /// </summary>
        QueryTypePipelineStatistics = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum QueueFlags : int
    {
        /// <summary>
        /// Original was VK_QUEUE_GRAPHICS_BIT = 0x1
        /// </summary>
        QueueGraphicsBit = ((int)0x1),
        /// <summary>
        /// Original was VK_QUEUE_COMPUTE_BIT = 0x2
        /// </summary>
        QueueComputeBit = ((int)0x2),
        /// <summary>
        /// Original was VK_QUEUE_DMA_BIT = 0x4
        /// </summary>
        QueueDmaBit = ((int)0x4),
        /// <summary>
        /// Original was VK_QUEUE_EXTENDED_BIT = 0x40000000
        /// </summary>
        QueueExtendedBit = ((int)0x40000000),
        /// <summary>
        /// Original was VK_QUEUE_SPARSE_MEMMGR_BIT = 0x8
        /// </summary>
        QueueSparseMemmgrBit = ((int)0x8),
    }

    /// <summary>
    /// Used in GL.CmdBeginRenderPas, GL.CmdNextSubpas
    /// </summary>
    public enum RenderPassContents : int
    {
        /// <summary>
        /// Original was VK_RENDER_PASS_CONTENTS_INLINE = 0
        /// </summary>
        RenderPassContentsInline = ((int)0),
        /// <summary>
        /// Original was VK_RENDER_PASS_CONTENTS_SECONDARY_CMD_BUFFERS = 1
        /// </summary>
        RenderPassContentsSecondaryCmdBuffers = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum Result : int
    {
        /// <summary>
        /// Original was VK_SUCCESS = 0
        /// </summary>
        Success = ((int)0),
        /// <summary>
        /// Original was VK_UNSUPPORTED = 1
        /// </summary>
        Unsupported = ((int)1),
        /// <summary>
        /// Original was VK_ERROR_UNKNOWN = -1
        /// </summary>
        ErrorUnknown = ((int)-1),
        /// <summary>
        /// Original was VK_ERROR_INVALID_HANDLE = -10
        /// </summary>
        ErrorInvalidHandle = ((int)-10),
        /// <summary>
        /// Original was VK_ERROR_INVALID_ORDINAL = -11
        /// </summary>
        ErrorInvalidOrdinal = ((int)-11),
        /// <summary>
        /// Original was VK_ERROR_INVALID_MEMORY_SIZE = -12
        /// </summary>
        ErrorInvalidMemorySize = ((int)-12),
        /// <summary>
        /// Original was VK_ERROR_INVALID_EXTENSION = -13
        /// </summary>
        ErrorInvalidExtension = ((int)-13),
        /// <summary>
        /// Original was VK_ERROR_INVALID_FLAGS = -14
        /// </summary>
        ErrorInvalidFlags = ((int)-14),
        /// <summary>
        /// Original was VK_ERROR_INVALID_ALIGNMENT = -15
        /// </summary>
        ErrorInvalidAlignment = ((int)-15),
        /// <summary>
        /// Original was VK_ERROR_INVALID_FORMAT = -16
        /// </summary>
        ErrorInvalidFormat = ((int)-16),
        /// <summary>
        /// Original was VK_ERROR_INVALID_IMAGE = -17
        /// </summary>
        ErrorInvalidImage = ((int)-17),
        /// <summary>
        /// Original was VK_ERROR_INVALID_DESCRIPTOR_SET_DATA = -18
        /// </summary>
        ErrorInvalidDescriptorSetData = ((int)-18),
        /// <summary>
        /// Original was VK_ERROR_INVALID_QUEUE_TYPE = -19
        /// </summary>
        ErrorInvalidQueueType = ((int)-19),
        /// <summary>
        /// Original was VK_NOT_READY = 2
        /// </summary>
        NotReady = ((int)2),
        /// <summary>
        /// Original was VK_ERROR_UNAVAILABLE = -2
        /// </summary>
        ErrorUnavailable = ((int)-2),
        /// <summary>
        /// Original was VK_ERROR_UNSUPPORTED_SHADER_IL_VERSION = -20
        /// </summary>
        ErrorUnsupportedShaderIlVersion = ((int)-20),
        /// <summary>
        /// Original was VK_ERROR_BAD_SHADER_CODE = -21
        /// </summary>
        ErrorBadShaderCode = ((int)-21),
        /// <summary>
        /// Original was VK_ERROR_BAD_PIPELINE_DATA = -22
        /// </summary>
        ErrorBadPipelineData = ((int)-22),
        /// <summary>
        /// Original was VK_ERROR_NOT_MAPPABLE = -23
        /// </summary>
        ErrorNotMappable = ((int)-23),
        /// <summary>
        /// Original was VK_ERROR_MEMORY_MAP_FAILED = -24
        /// </summary>
        ErrorMemoryMapFailed = ((int)-24),
        /// <summary>
        /// Original was VK_ERROR_MEMORY_UNMAP_FAILED = -25
        /// </summary>
        ErrorMemoryUnmapFailed = ((int)-25),
        /// <summary>
        /// Original was VK_ERROR_INCOMPATIBLE_DEVICE = -26
        /// </summary>
        ErrorIncompatibleDevice = ((int)-26),
        /// <summary>
        /// Original was VK_ERROR_INCOMPATIBLE_DRIVER = -27
        /// </summary>
        ErrorIncompatibleDriver = ((int)-27),
        /// <summary>
        /// Original was VK_ERROR_INCOMPLETE_COMMAND_BUFFER = -28
        /// </summary>
        ErrorIncompleteCommandBuffer = ((int)-28),
        /// <summary>
        /// Original was VK_ERROR_BUILDING_COMMAND_BUFFER = -29
        /// </summary>
        ErrorBuildingCommandBuffer = ((int)-29),
        /// <summary>
        /// Original was VK_TIMEOUT = 3
        /// </summary>
        Timeout = ((int)3),
        /// <summary>
        /// Original was VK_ERROR_INITIALIZATION_FAILED = -3
        /// </summary>
        ErrorInitializationFailed = ((int)-3),
        /// <summary>
        /// Original was VK_ERROR_MEMORY_NOT_BOUND = -30
        /// </summary>
        ErrorMemoryNotBound = ((int)-30),
        /// <summary>
        /// Original was VK_ERROR_INCOMPATIBLE_QUEUE = -31
        /// </summary>
        ErrorIncompatibleQueue = ((int)-31),
        /// <summary>
        /// Original was VK_ERROR_INVALID_LAYER = -32
        /// </summary>
        ErrorInvalidLayer = ((int)-32),
        /// <summary>
        /// Original was VK_EVENT_SET = 4
        /// </summary>
        EventSet = ((int)4),
        /// <summary>
        /// Original was VK_ERROR_OUT_OF_HOST_MEMORY = -4
        /// </summary>
        ErrorOutOfHostMemory = ((int)-4),
        /// <summary>
        /// Original was VK_EVENT_RESET = 5
        /// </summary>
        EventReset = ((int)5),
        /// <summary>
        /// Original was VK_ERROR_OUT_OF_DEVICE_MEMORY = -5
        /// </summary>
        ErrorOutOfDeviceMemory = ((int)-5),
        /// <summary>
        /// Original was VK_INCOMPLETE = 6
        /// </summary>
        Incomplete = ((int)6),
        /// <summary>
        /// Original was VK_ERROR_DEVICE_ALREADY_CREATED = -6
        /// </summary>
        ErrorDeviceAlreadyCreated = ((int)-6),
        /// <summary>
        /// Original was VK_ERROR_DEVICE_LOST = -7
        /// </summary>
        ErrorDeviceLost = ((int)-7),
        /// <summary>
        /// Original was VK_ERROR_INVALID_POINTER = -8
        /// </summary>
        ErrorInvalidPointer = ((int)-8),
        /// <summary>
        /// Original was VK_ERROR_INVALID_VALUE = -9
        /// </summary>
        ErrorInvalidValue = ((int)-9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum ShaderStage : int
    {
        /// <summary>
        /// Original was VK_SHADER_STAGE_VERTEX = 0
        /// </summary>
        ShaderStageVertex = ((int)0),
        /// <summary>
        /// Original was VK_SHADER_STAGE_TESS_CONTROL = 1
        /// </summary>
        ShaderStageTessControl = ((int)1),
        /// <summary>
        /// Original was VK_SHADER_STAGE_TESS_EVALUATION = 2
        /// </summary>
        ShaderStageTessEvaluation = ((int)2),
        /// <summary>
        /// Original was VK_SHADER_STAGE_GEOMETRY = 3
        /// </summary>
        ShaderStageGeometry = ((int)3),
        /// <summary>
        /// Original was VK_SHADER_STAGE_FRAGMENT = 4
        /// </summary>
        ShaderStageFragment = ((int)4),
        /// <summary>
        /// Original was VK_SHADER_STAGE_COMPUTE = 5
        /// </summary>
        ShaderStageCompute = ((int)5),
    }

    /// <summary>
    /// Used in GL.CmdPushConstants
    /// </summary>
    [Flags]
    public enum ShaderStageFlags : int
    {
        /// <summary>
        /// Original was VK_SHADER_STAGE_VERTEX_BIT = 0x1
        /// </summary>
        ShaderStageVertexBit = ((int)0x1),
        /// <summary>
        /// Original was VK_SHADER_STAGE_FRAGMENT_BIT = 0x10
        /// </summary>
        ShaderStageFragmentBit = ((int)0x10),
        /// <summary>
        /// Original was VK_SHADER_STAGE_TESS_CONTROL_BIT = 0x2
        /// </summary>
        ShaderStageTessControlBit = ((int)0x2),
        /// <summary>
        /// Original was VK_SHADER_STAGE_COMPUTE_BIT = 0x20
        /// </summary>
        ShaderStageComputeBit = ((int)0x20),
        /// <summary>
        /// Original was VK_SHADER_STAGE_TESS_EVALUATION_BIT = 0x4
        /// </summary>
        ShaderStageTessEvaluationBit = ((int)0x4),
        /// <summary>
        /// Original was VK_SHADER_STAGE_ALL = 0x7FFFFFFF
        /// </summary>
        ShaderStageAll = ((int)0x7FFFFFFF),
        /// <summary>
        /// Original was VK_SHADER_STAGE_GEOMETRY_BIT = 0x8
        /// </summary>
        ShaderStageGeometryBit = ((int)0x8),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SharingMode : int
    {
        /// <summary>
        /// Original was VK_SHARING_MODE_EXCLUSIVE = 0
        /// </summary>
        SharingModeExclusive = ((int)0),
        /// <summary>
        /// Original was VK_SHARING_MODE_CONCURRENT = 1
        /// </summary>
        SharingModeConcurrent = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum SparseImageFormatFlags : int
    {
        /// <summary>
        /// Original was VK_SPARSE_IMAGE_FMT_SINGLE_MIPTAIL_BIT = 0x1
        /// </summary>
        SparseImageFmtSingleMiptailBit = ((int)0x1),
        /// <summary>
        /// Original was VK_SPARSE_IMAGE_FMT_ALIGNED_MIP_SIZE_BIT = 0x2
        /// </summary>
        SparseImageFmtAlignedMipSizeBit = ((int)0x2),
        /// <summary>
        /// Original was VK_SPARSE_IMAGE_FMT_NONSTD_BLOCK_SIZE_BIT = 0x4
        /// </summary>
        SparseImageFmtNonstdBlockSizeBit = ((int)0x4),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum SparseMemoryBindFlags : int
    {
        /// <summary>
        /// Original was VK_SPARSE_MEMORY_BIND_REPLICATE_64KIB_BLOCK_BIT = 0x1
        /// </summary>
        SparseMemoryBindReplicate64KibBlockBit = ((int)0x1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum StencilOp : int
    {
        /// <summary>
        /// Original was VK_STENCIL_OP_KEEP = 0
        /// </summary>
        StencilOpKeep = ((int)0),
        /// <summary>
        /// Original was VK_STENCIL_OP_ZERO = 1
        /// </summary>
        StencilOpZero = ((int)1),
        /// <summary>
        /// Original was VK_STENCIL_OP_REPLACE = 2
        /// </summary>
        StencilOpReplace = ((int)2),
        /// <summary>
        /// Original was VK_STENCIL_OP_INC_CLAMP = 3
        /// </summary>
        StencilOpIncClamp = ((int)3),
        /// <summary>
        /// Original was VK_STENCIL_OP_DEC_CLAMP = 4
        /// </summary>
        StencilOpDecClamp = ((int)4),
        /// <summary>
        /// Original was VK_STENCIL_OP_INVERT = 5
        /// </summary>
        StencilOpInvert = ((int)5),
        /// <summary>
        /// Original was VK_STENCIL_OP_INC_WRAP = 6
        /// </summary>
        StencilOpIncWrap = ((int)6),
        /// <summary>
        /// Original was VK_STENCIL_OP_DEC_WRAP = 7
        /// </summary>
        StencilOpDecWrap = ((int)7),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum StructureType : int
    {
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_APPLICATION_INFO = 0
        /// </summary>
        StructureTypeApplicationInfo = ((int)0),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DEVICE_CREATE_INFO = 1
        /// </summary>
        StructureTypeDeviceCreateInfo = ((int)1),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DYNAMIC_VIEWPORT_STATE_CREATE_INFO = 10
        /// </summary>
        StructureTypeDynamicViewportStateCreateInfo = ((int)10),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DYNAMIC_RASTER_STATE_CREATE_INFO = 11
        /// </summary>
        StructureTypeDynamicRasterStateCreateInfo = ((int)11),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DYNAMIC_COLOR_BLEND_STATE_CREATE_INFO = 12
        /// </summary>
        StructureTypeDynamicColorBlendStateCreateInfo = ((int)12),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DYNAMIC_DEPTH_STENCIL_STATE_CREATE_INFO = 13
        /// </summary>
        StructureTypeDynamicDepthStencilStateCreateInfo = ((int)13),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_CMD_BUFFER_CREATE_INFO = 14
        /// </summary>
        StructureTypeCmdBufferCreateInfo = ((int)14),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_EVENT_CREATE_INFO = 15
        /// </summary>
        StructureTypeEventCreateInfo = ((int)15),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_FENCE_CREATE_INFO = 16
        /// </summary>
        StructureTypeFenceCreateInfo = ((int)16),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SEMAPHORE_CREATE_INFO = 17
        /// </summary>
        StructureTypeSemaphoreCreateInfo = ((int)17),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_QUERY_POOL_CREATE_INFO = 18
        /// </summary>
        StructureTypeQueryPoolCreateInfo = ((int)18),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_SHADER_STAGE_CREATE_INFO = 19
        /// </summary>
        StructureTypePipelineShaderStageCreateInfo = ((int)19),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_MEMORY_ALLOC_INFO = 2
        /// </summary>
        StructureTypeMemoryAllocInfo = ((int)2),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_GRAPHICS_PIPELINE_CREATE_INFO = 20
        /// </summary>
        StructureTypeGraphicsPipelineCreateInfo = ((int)20),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_VERTEX_INPUT_STATE_CREATE_INFO = 21
        /// </summary>
        StructureTypePipelineVertexInputStateCreateInfo = ((int)21),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_INPUT_ASSEMBLY_STATE_CREATE_INFO = 22
        /// </summary>
        StructureTypePipelineInputAssemblyStateCreateInfo = ((int)22),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_TESSELLATION_STATE_CREATE_INFO = 23
        /// </summary>
        StructureTypePipelineTessellationStateCreateInfo = ((int)23),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_VIEWPORT_STATE_CREATE_INFO = 24
        /// </summary>
        StructureTypePipelineViewportStateCreateInfo = ((int)24),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_RASTER_STATE_CREATE_INFO = 25
        /// </summary>
        StructureTypePipelineRasterStateCreateInfo = ((int)25),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_MULTISAMPLE_STATE_CREATE_INFO = 26
        /// </summary>
        StructureTypePipelineMultisampleStateCreateInfo = ((int)26),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_COLOR_BLEND_STATE_CREATE_INFO = 27
        /// </summary>
        StructureTypePipelineColorBlendStateCreateInfo = ((int)27),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_DEPTH_STENCIL_STATE_CREATE_INFO = 28
        /// </summary>
        StructureTypePipelineDepthStencilStateCreateInfo = ((int)28),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_IMAGE_CREATE_INFO = 29
        /// </summary>
        StructureTypeImageCreateInfo = ((int)29),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_IMAGE_VIEW_CREATE_INFO = 3
        /// </summary>
        StructureTypeImageViewCreateInfo = ((int)3),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_BUFFER_CREATE_INFO = 30
        /// </summary>
        StructureTypeBufferCreateInfo = ((int)30),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_BUFFER_VIEW_CREATE_INFO = 31
        /// </summary>
        StructureTypeBufferViewCreateInfo = ((int)31),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_FRAMEBUFFER_CREATE_INFO = 32
        /// </summary>
        StructureTypeFramebufferCreateInfo = ((int)32),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_CMD_BUFFER_BEGIN_INFO = 33
        /// </summary>
        StructureTypeCmdBufferBeginInfo = ((int)33),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_RENDER_PASS_CREATE_INFO = 34
        /// </summary>
        StructureTypeRenderPassCreateInfo = ((int)34),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_MEMORY_BARRIER = 35
        /// </summary>
        StructureTypeMemoryBarrier = ((int)35),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_BUFFER_MEMORY_BARRIER = 36
        /// </summary>
        StructureTypeBufferMemoryBarrier = ((int)36),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_IMAGE_MEMORY_BARRIER = 37
        /// </summary>
        StructureTypeImageMemoryBarrier = ((int)37),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DESCRIPTOR_POOL_CREATE_INFO = 38
        /// </summary>
        StructureTypeDescriptorPoolCreateInfo = ((int)38),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_WRITE_DESCRIPTOR_SET = 39
        /// </summary>
        StructureTypeWriteDescriptorSet = ((int)39),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_ATTACHMENT_VIEW_CREATE_INFO = 4
        /// </summary>
        StructureTypeAttachmentViewCreateInfo = ((int)4),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_COPY_DESCRIPTOR_SET = 40
        /// </summary>
        StructureTypeCopyDescriptorSet = ((int)40),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_INSTANCE_CREATE_INFO = 41
        /// </summary>
        StructureTypeInstanceCreateInfo = ((int)41),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_LAYOUT_CREATE_INFO = 42
        /// </summary>
        StructureTypePipelineLayoutCreateInfo = ((int)42),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_MAPPED_MEMORY_RANGE = 43
        /// </summary>
        StructureTypeMappedMemoryRange = ((int)43),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_PIPELINE_CACHE_CREATE_INFO = 44
        /// </summary>
        StructureTypePipelineCacheCreateInfo = ((int)44),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_ATTACHMENT_DESCRIPTION = 45
        /// </summary>
        StructureTypeAttachmentDescription = ((int)45),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SUBPASS_DESCRIPTION = 46
        /// </summary>
        StructureTypeSubpassDescription = ((int)46),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SUBPASS_DEPENDENCY = 47
        /// </summary>
        StructureTypeSubpassDependency = ((int)47),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_RENDER_PASS_BEGIN_INFO = 48
        /// </summary>
        StructureTypeRenderPassBeginInfo = ((int)48),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_CMD_POOL_CREATE_INFO = 49
        /// </summary>
        StructureTypeCmdPoolCreateInfo = ((int)49),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SHADER_MODULE_CREATE_INFO = 5
        /// </summary>
        StructureTypeShaderModuleCreateInfo = ((int)5),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SHADER_CREATE_INFO = 6
        /// </summary>
        StructureTypeShaderCreateInfo = ((int)6),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_COMPUTE_PIPELINE_CREATE_INFO = 7
        /// </summary>
        StructureTypeComputePipelineCreateInfo = ((int)7),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_SAMPLER_CREATE_INFO = 8
        /// </summary>
        StructureTypeSamplerCreateInfo = ((int)8),
        /// <summary>
        /// Original was VK_STRUCTURE_TYPE_DESCRIPTOR_SET_LAYOUT_CREATE_INFO = 9
        /// </summary>
        StructureTypeDescriptorSetLayoutCreateInfo = ((int)9),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    [Flags]
    public enum SubpassDescriptionFlags : int
    {
        /// <summary>
        /// Original was VK_SUBPASS_DESCRIPTION_NO_OVERDRAW_BIT = 0x1
        /// </summary>
        SubpassDescriptionNoOverdrawBit = ((int)0x1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum SystemAllocType : int
    {
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_API_OBJECT = 0
        /// </summary>
        SystemAllocTypeApiObject = ((int)0),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_INTERNAL = 1
        /// </summary>
        SystemAllocTypeInternal = ((int)1),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_INTERNAL_TEMP = 2
        /// </summary>
        SystemAllocTypeInternalTemp = ((int)2),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_INTERNAL_SHADER = 3
        /// </summary>
        SystemAllocTypeInternalShader = ((int)3),
        /// <summary>
        /// Original was VK_SYSTEM_ALLOC_TYPE_DEBUG = 4
        /// </summary>
        SystemAllocTypeDebug = ((int)4),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TexAddress : int
    {
        /// <summary>
        /// Original was VK_TEX_ADDRESS_WRAP = 0
        /// </summary>
        TexAddressWrap = ((int)0),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_MIRROR = 1
        /// </summary>
        TexAddressMirror = ((int)1),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_CLAMP = 2
        /// </summary>
        TexAddressClamp = ((int)2),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_MIRROR_ONCE = 3
        /// </summary>
        TexAddressMirrorOnce = ((int)3),
        /// <summary>
        /// Original was VK_TEX_ADDRESS_CLAMP_BORDER = 4
        /// </summary>
        TexAddressClampBorder = ((int)4),
    }

    /// <summary>
    /// Used in GL.CmdBlitImage
    /// </summary>
    public enum TexFilter : int
    {
        /// <summary>
        /// Original was VK_TEX_FILTER_NEAREST = 0
        /// </summary>
        TexFilterNearest = ((int)0),
        /// <summary>
        /// Original was VK_TEX_FILTER_LINEAR = 1
        /// </summary>
        TexFilterLinear = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum TexMipmapMode : int
    {
        /// <summary>
        /// Original was VK_TEX_MIPMAP_MODE_BASE = 0
        /// </summary>
        TexMipmapModeBase = ((int)0),
        /// <summary>
        /// Original was VK_TEX_MIPMAP_MODE_NEAREST = 1
        /// </summary>
        TexMipmapModeNearest = ((int)1),
        /// <summary>
        /// Original was VK_TEX_MIPMAP_MODE_LINEAR = 2
        /// </summary>
        TexMipmapModeLinear = ((int)2),
    }

    /// <summary>
    /// Used in GL.CmdWriteTimestamp
    /// </summary>
    public enum TimestampType : int
    {
        /// <summary>
        /// Original was VK_TIMESTAMP_TYPE_TOP = 0
        /// </summary>
        TimestampTypeTop = ((int)0),
        /// <summary>
        /// Original was VK_TIMESTAMP_TYPE_BOTTOM = 1
        /// </summary>
        TimestampTypeBottom = ((int)1),
    }

    /// <summary>
    /// Not used directly.
    /// </summary>
    public enum VertexInputStepRate : int
    {
        /// <summary>
        /// Original was VK_VERTEX_INPUT_STEP_RATE_VERTEX = 0
        /// </summary>
        VertexInputStepRateVertex = ((int)0),
        /// <summary>
        /// Original was VK_VERTEX_INPUT_STEP_RATE_INSTANCE = 1
        /// </summary>
        VertexInputStepRateInstance = ((int)1),
    }

}
