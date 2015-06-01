#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2015 the Open Toolkit library.
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

namespace OpenTK.Graphics.Vulkan
{
    // ------------------------------------------------------------------------------------------------
    // Error and return codes

    enum Result
    {
        // Return codes for successful operation execution (> = 0)
        Success                                              = 0x0000000,
        Unsupported                                          = 0x0000001,
        NotReady                                            = 0x0000002,
        Timeout                                              = 0x0000003,
        EventSet                                            = 0x0000004,
        EventReset                                          = 0x0000005,

        // Error codes (negative values)
        ErrorUnknown                                        = -(0x00000001),
        ErrorUnavailable                                    = -(0x00000002),
        ErrorInitializationFailed                          = -(0x00000003),
        ErrorOutOfHostMemory                             = -(0x00000004),
        ErrorOutOfDeviceMemory                           = -(0x00000005),
        ErrorDeviceAlreadyCreated                         = -(0x00000006),
        ErrorDeviceLost                                    = -(0x00000007),
        ErrorInvalidPointer                                = -(0x00000008),
        ErrorInvalidValue                                  = -(0x00000009),
        ErrorInvalidHandle                                 = -(0x0000000A),
        ErrorInvalidOrdinal                                = -(0x0000000B),
        ErrorInvalidMemorySize                            = -(0x0000000C),
        ErrorInvalidExtension                              = -(0x0000000D),
        ErrorInvalidFlags                                  = -(0x0000000E),
        ErrorInvalidAlignment                              = -(0x0000000F),
        ErrorInvalidFormat                                 = -(0x00000010),
        ErrorInvalidImage                                  = -(0x00000011),
        ErrorInvalidDescriptorSetData                    = -(0x00000012),
        ErrorInvalidQueueType                             = -(0x00000013),
        ErrorInvalidObjectType                            = -(0x00000014),
        ErrorUnsupportedShaderIlVersion                  = -(0x00000015),
        ErrorBadShaderCode                                = -(0x00000016),
        ErrorBadPipelineData                              = -(0x00000017),
        ErrorNotMappable                                   = -(0x00000018),
        ErrorMemoryMapFailed                              = -(0x00000019),
        ErrorMemoryUnmapFailed                            = -(0x0000001A),
        ErrorIncompatibleDevice                            = -(0x0000001B),
        ErrorIncompatibleDriver                            = -(0x0000001C),
        ErrorIncompleteCommandBuffer                      = -(0x0000001D),
        ErrorBuildingCommandBuffer                        = -(0x0000001E),
        ErrorMemoryNotBound                               = -(0x0000001F),
        ErrorIncompatibleQueue                             = -(0x00000020),
        ErrorNotShareable                                  = -(0x00000021)
    }
}
