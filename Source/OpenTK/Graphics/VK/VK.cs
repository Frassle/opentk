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
    #pragma warning disable 3019
    #pragma warning disable 1591
    #pragma warning disable 1572
    #pragma warning disable 1573
    #pragma warning disable 626

    partial class VK
    {
        static VK()
        {
            EntryPointNames = new byte[]
            {
                118, 107, 65, 108, 108, 111, 99, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 83, 101, 116, 115, 0,
                118, 107, 65, 108, 108, 111, 99, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 66, 101, 103, 105, 110, 67, 111, 109, 109, 97, 110, 100, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 66, 105, 110, 100, 66, 117, 102, 102, 101, 114, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 66, 105, 110, 100, 73, 109, 97, 103, 101, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 67, 109, 100, 66, 101, 103, 105, 110, 81, 117, 101, 114, 121, 0,
                118, 107, 67, 109, 100, 66, 101, 103, 105, 110, 82, 101, 110, 100, 101, 114, 80, 97, 115, 115, 0,
                118, 107, 67, 109, 100, 66, 105, 110, 100, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 83, 101, 116, 115, 0,
                118, 107, 67, 109, 100, 66, 105, 110, 100, 68, 121, 110, 97, 109, 105, 99, 67, 111, 108, 111, 114, 66, 108, 101, 110, 100, 83, 116, 97, 116, 101, 0,
                118, 107, 67, 109, 100, 66, 105, 110, 100, 68, 121, 110, 97, 109, 105, 99, 68, 101, 112, 116, 104, 83, 116, 101, 110, 99, 105, 108, 83, 116, 97, 116, 101, 0,
                118, 107, 67, 109, 100, 66, 105, 110, 100, 68, 121, 110, 97, 109, 105, 99, 82, 97, 115, 116, 101, 114, 83, 116, 97, 116, 101, 0,
                118, 107, 67, 109, 100, 66, 105, 110, 100, 68, 121, 110, 97, 109, 105, 99, 86, 105, 101, 119, 112, 111, 114, 116, 83, 116, 97, 116, 101, 0,
                118, 107, 67, 109, 100, 66, 105, 110, 100, 73, 110, 100, 101, 120, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 67, 109, 100, 66, 105, 110, 100, 80, 105, 112, 101, 108, 105, 110, 101, 0,
                118, 107, 67, 109, 100, 66, 105, 110, 100, 86, 101, 114, 116, 101, 120, 66, 117, 102, 102, 101, 114, 115, 0,
                118, 107, 67, 109, 100, 66, 108, 105, 116, 73, 109, 97, 103, 101, 0,
                118, 107, 67, 109, 100, 67, 108, 101, 97, 114, 67, 111, 108, 111, 114, 65, 116, 116, 97, 99, 104, 109, 101, 110, 116, 0,
                118, 107, 67, 109, 100, 67, 108, 101, 97, 114, 67, 111, 108, 111, 114, 73, 109, 97, 103, 101, 0,
                118, 107, 67, 109, 100, 67, 108, 101, 97, 114, 68, 101, 112, 116, 104, 83, 116, 101, 110, 99, 105, 108, 65, 116, 116, 97, 99, 104, 109, 101, 110, 116, 0,
                118, 107, 67, 109, 100, 67, 108, 101, 97, 114, 68, 101, 112, 116, 104, 83, 116, 101, 110, 99, 105, 108, 73, 109, 97, 103, 101, 0,
                118, 107, 67, 109, 100, 67, 111, 112, 121, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 67, 109, 100, 67, 111, 112, 121, 66, 117, 102, 102, 101, 114, 84, 111, 73, 109, 97, 103, 101, 0,
                118, 107, 67, 109, 100, 67, 111, 112, 121, 73, 109, 97, 103, 101, 0,
                118, 107, 67, 109, 100, 67, 111, 112, 121, 73, 109, 97, 103, 101, 84, 111, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 67, 109, 100, 67, 111, 112, 121, 81, 117, 101, 114, 121, 80, 111, 111, 108, 82, 101, 115, 117, 108, 116, 115, 0,
                118, 107, 67, 109, 100, 68, 105, 115, 112, 97, 116, 99, 104, 0,
                118, 107, 67, 109, 100, 68, 105, 115, 112, 97, 116, 99, 104, 73, 110, 100, 105, 114, 101, 99, 116, 0,
                118, 107, 67, 109, 100, 68, 114, 97, 119, 0,
                118, 107, 67, 109, 100, 68, 114, 97, 119, 73, 110, 100, 101, 120, 101, 100, 0,
                118, 107, 67, 109, 100, 68, 114, 97, 119, 73, 110, 100, 101, 120, 101, 100, 73, 110, 100, 105, 114, 101, 99, 116, 0,
                118, 107, 67, 109, 100, 68, 114, 97, 119, 73, 110, 100, 105, 114, 101, 99, 116, 0,
                118, 107, 67, 109, 100, 69, 110, 100, 81, 117, 101, 114, 121, 0,
                118, 107, 67, 109, 100, 69, 110, 100, 82, 101, 110, 100, 101, 114, 80, 97, 115, 115, 0,
                118, 107, 67, 109, 100, 69, 120, 101, 99, 117, 116, 101, 67, 111, 109, 109, 97, 110, 100, 115, 0,
                118, 107, 67, 109, 100, 70, 105, 108, 108, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 67, 109, 100, 78, 101, 120, 116, 83, 117, 98, 112, 97, 115, 115, 0,
                118, 107, 67, 109, 100, 80, 105, 112, 101, 108, 105, 110, 101, 66, 97, 114, 114, 105, 101, 114, 0,
                118, 107, 67, 109, 100, 80, 117, 115, 104, 67, 111, 110, 115, 116, 97, 110, 116, 115, 0,
                118, 107, 67, 109, 100, 82, 101, 115, 101, 116, 69, 118, 101, 110, 116, 0,
                118, 107, 67, 109, 100, 82, 101, 115, 101, 116, 81, 117, 101, 114, 121, 80, 111, 111, 108, 0,
                118, 107, 67, 109, 100, 82, 101, 115, 111, 108, 118, 101, 73, 109, 97, 103, 101, 0,
                118, 107, 67, 109, 100, 83, 101, 116, 69, 118, 101, 110, 116, 0,
                118, 107, 67, 109, 100, 85, 112, 100, 97, 116, 101, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 67, 109, 100, 87, 97, 105, 116, 69, 118, 101, 110, 116, 115, 0,
                118, 107, 67, 109, 100, 87, 114, 105, 116, 101, 84, 105, 109, 101, 115, 116, 97, 109, 112, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 65, 116, 116, 97, 99, 104, 109, 101, 110, 116, 86, 105, 101, 119, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 66, 117, 102, 102, 101, 114, 86, 105, 101, 119, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 67, 111, 109, 109, 97, 110, 100, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 67, 111, 109, 109, 97, 110, 100, 80, 111, 111, 108, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 67, 111, 109, 112, 117, 116, 101, 80, 105, 112, 101, 108, 105, 110, 101, 115, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 80, 111, 111, 108, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 83, 101, 116, 76, 97, 121, 111, 117, 116, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 68, 101, 118, 105, 99, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 68, 121, 110, 97, 109, 105, 99, 67, 111, 108, 111, 114, 66, 108, 101, 110, 100, 83, 116, 97, 116, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 68, 121, 110, 97, 109, 105, 99, 68, 101, 112, 116, 104, 83, 116, 101, 110, 99, 105, 108, 83, 116, 97, 116, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 68, 121, 110, 97, 109, 105, 99, 82, 97, 115, 116, 101, 114, 83, 116, 97, 116, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 68, 121, 110, 97, 109, 105, 99, 86, 105, 101, 119, 112, 111, 114, 116, 83, 116, 97, 116, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 69, 118, 101, 110, 116, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 70, 101, 110, 99, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 71, 114, 97, 112, 104, 105, 99, 115, 80, 105, 112, 101, 108, 105, 110, 101, 115, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 73, 109, 97, 103, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 73, 109, 97, 103, 101, 86, 105, 101, 119, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 73, 110, 115, 116, 97, 110, 99, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 80, 105, 112, 101, 108, 105, 110, 101, 67, 97, 99, 104, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 80, 105, 112, 101, 108, 105, 110, 101, 76, 97, 121, 111, 117, 116, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 81, 117, 101, 114, 121, 80, 111, 111, 108, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 82, 101, 110, 100, 101, 114, 80, 97, 115, 115, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 83, 97, 109, 112, 108, 101, 114, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 83, 101, 109, 97, 112, 104, 111, 114, 101, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 83, 104, 97, 100, 101, 114, 0,
                118, 107, 67, 114, 101, 97, 116, 101, 83, 104, 97, 100, 101, 114, 77, 111, 100, 117, 108, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 65, 116, 116, 97, 99, 104, 109, 101, 110, 116, 86, 105, 101, 119, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 66, 117, 102, 102, 101, 114, 86, 105, 101, 119, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 67, 111, 109, 109, 97, 110, 100, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 67, 111, 109, 109, 97, 110, 100, 80, 111, 111, 108, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 80, 111, 111, 108, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 83, 101, 116, 76, 97, 121, 111, 117, 116, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 68, 101, 118, 105, 99, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 68, 121, 110, 97, 109, 105, 99, 67, 111, 108, 111, 114, 66, 108, 101, 110, 100, 83, 116, 97, 116, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 68, 121, 110, 97, 109, 105, 99, 68, 101, 112, 116, 104, 83, 116, 101, 110, 99, 105, 108, 83, 116, 97, 116, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 68, 121, 110, 97, 109, 105, 99, 82, 97, 115, 116, 101, 114, 83, 116, 97, 116, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 68, 121, 110, 97, 109, 105, 99, 86, 105, 101, 119, 112, 111, 114, 116, 83, 116, 97, 116, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 69, 118, 101, 110, 116, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 70, 101, 110, 99, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 70, 114, 97, 109, 101, 98, 117, 102, 102, 101, 114, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 73, 109, 97, 103, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 73, 109, 97, 103, 101, 86, 105, 101, 119, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 73, 110, 115, 116, 97, 110, 99, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 80, 105, 112, 101, 108, 105, 110, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 80, 105, 112, 101, 108, 105, 110, 101, 67, 97, 99, 104, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 80, 105, 112, 101, 108, 105, 110, 101, 76, 97, 121, 111, 117, 116, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 81, 117, 101, 114, 121, 80, 111, 111, 108, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 82, 101, 110, 100, 101, 114, 80, 97, 115, 115, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 83, 97, 109, 112, 108, 101, 114, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 83, 101, 109, 97, 112, 104, 111, 114, 101, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 83, 104, 97, 100, 101, 114, 0,
                118, 107, 68, 101, 115, 116, 114, 111, 121, 83, 104, 97, 100, 101, 114, 77, 111, 100, 117, 108, 101, 0,
                118, 107, 68, 101, 118, 105, 99, 101, 87, 97, 105, 116, 73, 100, 108, 101, 0,
                118, 107, 69, 110, 100, 67, 111, 109, 109, 97, 110, 100, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 69, 110, 117, 109, 101, 114, 97, 116, 101, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 115, 0,
                118, 107, 70, 108, 117, 115, 104, 77, 97, 112, 112, 101, 100, 77, 101, 109, 111, 114, 121, 82, 97, 110, 103, 101, 115, 0,
                118, 107, 70, 114, 101, 101, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 83, 101, 116, 115, 0,
                118, 107, 70, 114, 101, 101, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 71, 101, 116, 66, 117, 102, 102, 101, 114, 77, 101, 109, 111, 114, 121, 82, 101, 113, 117, 105, 114, 101, 109, 101, 110, 116, 115, 0,
                118, 107, 71, 101, 116, 68, 101, 118, 105, 99, 101, 77, 101, 109, 111, 114, 121, 67, 111, 109, 109, 105, 116, 109, 101, 110, 116, 0,
                118, 107, 71, 101, 116, 68, 101, 118, 105, 99, 101, 80, 114, 111, 99, 65, 100, 100, 114, 0,
                118, 107, 71, 101, 116, 68, 101, 118, 105, 99, 101, 81, 117, 101, 117, 101, 0,
                118, 107, 71, 101, 116, 69, 118, 101, 110, 116, 83, 116, 97, 116, 117, 115, 0,
                118, 107, 71, 101, 116, 70, 101, 110, 99, 101, 83, 116, 97, 116, 117, 115, 0,
                118, 107, 71, 101, 116, 71, 108, 111, 98, 97, 108, 69, 120, 116, 101, 110, 115, 105, 111, 110, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 71, 108, 111, 98, 97, 108, 76, 97, 121, 101, 114, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 73, 109, 97, 103, 101, 77, 101, 109, 111, 114, 121, 82, 101, 113, 117, 105, 114, 101, 109, 101, 110, 116, 115, 0,
                118, 107, 71, 101, 116, 73, 109, 97, 103, 101, 83, 112, 97, 114, 115, 101, 77, 101, 109, 111, 114, 121, 82, 101, 113, 117, 105, 114, 101, 109, 101, 110, 116, 115, 0,
                118, 107, 71, 101, 116, 73, 109, 97, 103, 101, 83, 117, 98, 114, 101, 115, 111, 117, 114, 99, 101, 76, 97, 121, 111, 117, 116, 0,
                118, 107, 71, 101, 116, 73, 110, 115, 116, 97, 110, 99, 101, 80, 114, 111, 99, 65, 100, 100, 114, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 69, 120, 116, 101, 110, 115, 105, 111, 110, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 70, 101, 97, 116, 117, 114, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 70, 111, 114, 109, 97, 116, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 73, 109, 97, 103, 101, 70, 111, 114, 109, 97, 116, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 76, 97, 121, 101, 114, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 76, 105, 109, 105, 116, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 77, 101, 109, 111, 114, 121, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 81, 117, 101, 117, 101, 70, 97, 109, 105, 108, 121, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 104, 121, 115, 105, 99, 97, 108, 68, 101, 118, 105, 99, 101, 83, 112, 97, 114, 115, 101, 73, 109, 97, 103, 101, 70, 111, 114, 109, 97, 116, 80, 114, 111, 112, 101, 114, 116, 105, 101, 115, 0,
                118, 107, 71, 101, 116, 80, 105, 112, 101, 108, 105, 110, 101, 67, 97, 99, 104, 101, 68, 97, 116, 97, 0,
                118, 107, 71, 101, 116, 80, 105, 112, 101, 108, 105, 110, 101, 67, 97, 99, 104, 101, 83, 105, 122, 101, 0,
                118, 107, 71, 101, 116, 81, 117, 101, 114, 121, 80, 111, 111, 108, 82, 101, 115, 117, 108, 116, 115, 0,
                118, 107, 71, 101, 116, 82, 101, 110, 100, 101, 114, 65, 114, 101, 97, 71, 114, 97, 110, 117, 108, 97, 114, 105, 116, 121, 0,
                118, 107, 73, 110, 118, 97, 108, 105, 100, 97, 116, 101, 77, 97, 112, 112, 101, 100, 77, 101, 109, 111, 114, 121, 82, 97, 110, 103, 101, 115, 0,
                118, 107, 77, 97, 112, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 77, 101, 114, 103, 101, 80, 105, 112, 101, 108, 105, 110, 101, 67, 97, 99, 104, 101, 115, 0,
                118, 107, 81, 117, 101, 117, 101, 66, 105, 110, 100, 83, 112, 97, 114, 115, 101, 66, 117, 102, 102, 101, 114, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 81, 117, 101, 117, 101, 66, 105, 110, 100, 83, 112, 97, 114, 115, 101, 73, 109, 97, 103, 101, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 81, 117, 101, 117, 101, 66, 105, 110, 100, 83, 112, 97, 114, 115, 101, 73, 109, 97, 103, 101, 79, 112, 97, 113, 117, 101, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 81, 117, 101, 117, 101, 83, 105, 103, 110, 97, 108, 83, 101, 109, 97, 112, 104, 111, 114, 101, 0,
                118, 107, 81, 117, 101, 117, 101, 83, 117, 98, 109, 105, 116, 0,
                118, 107, 81, 117, 101, 117, 101, 87, 97, 105, 116, 73, 100, 108, 101, 0,
                118, 107, 81, 117, 101, 117, 101, 87, 97, 105, 116, 83, 101, 109, 97, 112, 104, 111, 114, 101, 0,
                118, 107, 82, 101, 115, 101, 116, 67, 111, 109, 109, 97, 110, 100, 66, 117, 102, 102, 101, 114, 0,
                118, 107, 82, 101, 115, 101, 116, 67, 111, 109, 109, 97, 110, 100, 80, 111, 111, 108, 0,
                118, 107, 82, 101, 115, 101, 116, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 80, 111, 111, 108, 0,
                118, 107, 82, 101, 115, 101, 116, 69, 118, 101, 110, 116, 0,
                118, 107, 82, 101, 115, 101, 116, 70, 101, 110, 99, 101, 115, 0,
                118, 107, 83, 101, 116, 69, 118, 101, 110, 116, 0,
                118, 107, 85, 110, 109, 97, 112, 77, 101, 109, 111, 114, 121, 0,
                118, 107, 85, 112, 100, 97, 116, 101, 68, 101, 115, 99, 114, 105, 112, 116, 111, 114, 83, 101, 116, 115, 0,
                118, 107, 87, 97, 105, 116, 70, 111, 114, 70, 101, 110, 99, 101, 115, 0,
            };
            EntryPointNameOffsets = new int[]
            {
                0,
                22,
                36,
                57,
                76,
                94,
                110,
                131,
                155,
                187,
                221,
                249,
                279,
                300,
                318,
                341,
                356,
                382,
                403,
                436,
                464,
                480,
                503,
                518,
                541,
                567,
                581,
                603,
                613,
                630,
                655,
                673,
                687,
                706,
                727,
                743,
                760,
                781,
                800,
                816,
                836,
                854,
                868,
                886,
                902,
                922,
                945,
                960,
                979,
                1001,
                1021,
                1046,
                1069,
                1097,
                1112,
                1143,
                1176,
                1203,
                1232,
                1246,
                1260,
                1280,
                1306,
                1320,
                1338,
                1355,
                1377,
                1400,
                1418,
                1437,
                1453,
                1471,
                1486,
                1507,
                1531,
                1547,
                1567,
                1590,
                1611,
                1635,
                1664,
                1680,
                1712,
                1746,
                1774,
                1804,
                1819,
                1834,
                1855,
                1870,
                1889,
                1907,
                1925,
                1948,
                1972,
                1991,
                2011,
                2028,
                2047,
                2063,
                2085,
                2102,
                2121,
                2148,
                2174,
                2195,
                2208,
                2238,
                2266,
                2286,
                2303,
                2320,
                2337,
                2368,
                2395,
                2424,
                2459,
                2487,
                2509,
                2548,
                2576,
                2612,
                2653,
                2688,
                2714,
                2750,
                2780,
                2821,
                2868,
                2891,
                2914,
                2936,
                2963,
                2994,
                3006,
                3028,
                3058,
                3087,
                3122,
                3145,
                3159,
                3175,
                3196,
                3217,
                3236,
                3258,
                3271,
                3285,
                3296,
                3310,
                3333,
            };
            EntryPoints = new IntPtr[EntryPointNameOffsets.Length];
        }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="setUsage"></param>
        /// <param name="count"></param>
        /// <param name="pSetLayouts"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result AllocDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorSetUsage setUsage, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] ref DescriptorSetLayout pSetLayouts, [InAttribute, OutAttribute] ref DescriptorSet pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="setUsage"></param>
        /// <param name="count"></param>
        /// <param name="pSetLayouts"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result AllocDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorSetUsage setUsage, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] DescriptorSetLayout[] pSetLayouts, [InAttribute, OutAttribute] DescriptorSet[] pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="setUsage"></param>
        /// <param name="count"></param>
        /// <param name="pSetLayouts"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocDescriptorSets")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result AllocDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorSetUsage setUsage, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] DescriptorSetLayout* pSetLayouts, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="setUsage"></param>
        /// <param name="count"></param>
        /// <param name="pSetLayouts"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result AllocDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorSetUsage setUsage, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] ref DescriptorSetLayout pSetLayouts, [InAttribute, OutAttribute] ref DescriptorSet pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="setUsage"></param>
        /// <param name="count"></param>
        /// <param name="pSetLayouts"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result AllocDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorSetUsage setUsage, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] DescriptorSetLayout[] pSetLayouts, [InAttribute, OutAttribute] DescriptorSet[] pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="setUsage"></param>
        /// <param name="count"></param>
        /// <param name="pSetLayouts"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocDescriptorSets")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result AllocDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorSetUsage setUsage, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] DescriptorSetLayout* pSetLayouts, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pAllocInfo"></param>
        /// <param name="pMem"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result AllocMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref MemoryAllocInfo pAllocInfo, [InAttribute, OutAttribute] ref DeviceMemory pMem) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pAllocInfo"></param>
        /// <param name="pMem"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result AllocMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] MemoryAllocInfo[] pAllocInfo, [InAttribute, OutAttribute] DeviceMemory[] pMem) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pAllocInfo"></param>
        /// <param name="pMem"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkAllocMemory")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result AllocMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] MemoryAllocInfo* pAllocInfo, [InAttribute, OutAttribute] DeviceMemory* pMem) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pBeginInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkBeginCommandBuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result BeginCommandBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] ref CmdBufferBeginInfo pBeginInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pBeginInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkBeginCommandBuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result BeginCommandBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] CmdBufferBeginInfo[] pBeginInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pBeginInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkBeginCommandBuffer")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result BeginCommandBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] CmdBufferBeginInfo* pBeginInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="buffer"></param>
        /// <param name="mem"></param>
        /// <param name="memOffset"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkBindBufferMemory")]
        public static OpenTK.Graphics.Vulkan.Result BindBufferMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr memOffset) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="mem"></param>
        /// <param name="memOffset"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkBindImageMemory")]
        public static OpenTK.Graphics.Vulkan.Result BindImageMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr memOffset) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="queryPool"></param>
        /// <param name="slot"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBeginQuery")]
        [CLSCompliant(false)]
        public static void CmdBeginQuery([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 slot, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryControlFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="queryPool"></param>
        /// <param name="slot"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBeginQuery")]
        [CLSCompliant(false)]
        public static void CmdBeginQuery([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint slot, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryControlFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pRenderPassBegin"></param>
        /// <param name="contents"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBeginRenderPass")]
        [CLSCompliant(false)]
        public static void CmdBeginRenderPas([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] ref RenderPassBeginInfo pRenderPassBegin, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.RenderPassContents contents) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pRenderPassBegin"></param>
        /// <param name="contents"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBeginRenderPass")]
        [CLSCompliant(false)]
        public static void CmdBeginRenderPas([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] RenderPassBeginInfo[] pRenderPassBegin, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.RenderPassContents contents) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pRenderPassBegin"></param>
        /// <param name="contents"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBeginRenderPass")]
        [CLSCompliant(false)]
        public static unsafe void CmdBeginRenderPas([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] RenderPassBeginInfo* pRenderPassBegin, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.RenderPassContents contents) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pipelineBindPoint"></param>
        /// <param name="layout"></param>
        /// <param name="firstSet"></param>
        /// <param name="setCount"></param>
        /// <param name="pDescriptorSets"></param>
        /// <param name="dynamicOffsetCount"></param>
        /// <param name="pDynamicOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDescriptorSets")]
        [CLSCompliant(false)]
        public static void CmdBindDescriptorSets([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineBindPoint pipelineBindPoint, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] Int32 firstSet, [InAttribute, OutAttribute] Int32 setCount, [InAttribute, OutAttribute] ref DescriptorSet pDescriptorSets, [InAttribute, OutAttribute] Int32 dynamicOffsetCount, [InAttribute, OutAttribute] ref Int32 pDynamicOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pipelineBindPoint"></param>
        /// <param name="layout"></param>
        /// <param name="firstSet"></param>
        /// <param name="setCount"></param>
        /// <param name="pDescriptorSets"></param>
        /// <param name="dynamicOffsetCount"></param>
        /// <param name="pDynamicOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDescriptorSets")]
        [CLSCompliant(false)]
        public static void CmdBindDescriptorSets([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineBindPoint pipelineBindPoint, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] Int32 firstSet, [InAttribute, OutAttribute] Int32 setCount, [InAttribute, OutAttribute] DescriptorSet[] pDescriptorSets, [InAttribute, OutAttribute] Int32 dynamicOffsetCount, [InAttribute, OutAttribute] Int32[] pDynamicOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pipelineBindPoint"></param>
        /// <param name="layout"></param>
        /// <param name="firstSet"></param>
        /// <param name="setCount"></param>
        /// <param name="pDescriptorSets"></param>
        /// <param name="dynamicOffsetCount"></param>
        /// <param name="pDynamicOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDescriptorSets")]
        [CLSCompliant(false)]
        public static unsafe void CmdBindDescriptorSets([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineBindPoint pipelineBindPoint, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] Int32 firstSet, [InAttribute, OutAttribute] Int32 setCount, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets, [InAttribute, OutAttribute] Int32 dynamicOffsetCount, [InAttribute, OutAttribute] Int32* pDynamicOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pipelineBindPoint"></param>
        /// <param name="layout"></param>
        /// <param name="firstSet"></param>
        /// <param name="setCount"></param>
        /// <param name="pDescriptorSets"></param>
        /// <param name="dynamicOffsetCount"></param>
        /// <param name="pDynamicOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDescriptorSets")]
        [CLSCompliant(false)]
        public static void CmdBindDescriptorSets([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineBindPoint pipelineBindPoint, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] uint firstSet, [InAttribute, OutAttribute] uint setCount, [InAttribute, OutAttribute] ref DescriptorSet pDescriptorSets, [InAttribute, OutAttribute] uint dynamicOffsetCount, [InAttribute, OutAttribute] ref uint pDynamicOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pipelineBindPoint"></param>
        /// <param name="layout"></param>
        /// <param name="firstSet"></param>
        /// <param name="setCount"></param>
        /// <param name="pDescriptorSets"></param>
        /// <param name="dynamicOffsetCount"></param>
        /// <param name="pDynamicOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDescriptorSets")]
        [CLSCompliant(false)]
        public static void CmdBindDescriptorSets([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineBindPoint pipelineBindPoint, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] uint firstSet, [InAttribute, OutAttribute] uint setCount, [InAttribute, OutAttribute] DescriptorSet[] pDescriptorSets, [InAttribute, OutAttribute] uint dynamicOffsetCount, [InAttribute, OutAttribute] uint[] pDynamicOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pipelineBindPoint"></param>
        /// <param name="layout"></param>
        /// <param name="firstSet"></param>
        /// <param name="setCount"></param>
        /// <param name="pDescriptorSets"></param>
        /// <param name="dynamicOffsetCount"></param>
        /// <param name="pDynamicOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDescriptorSets")]
        [CLSCompliant(false)]
        public static unsafe void CmdBindDescriptorSets([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineBindPoint pipelineBindPoint, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] uint firstSet, [InAttribute, OutAttribute] uint setCount, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets, [InAttribute, OutAttribute] uint dynamicOffsetCount, [InAttribute, OutAttribute] uint* pDynamicOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="dynamicColorBlendState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDynamicColorBlendState")]
        public static void CmdBindDynamicColorBlendState([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] DynamicColorBlendState dynamicColorBlendState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="dynamicDepthStencilState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDynamicDepthStencilState")]
        public static void CmdBindDynamicDepthStencilState([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] DynamicDepthStencilState dynamicDepthStencilState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="dynamicRasterState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDynamicRasterState")]
        public static void CmdBindDynamicRasterState([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] DynamicRasterState dynamicRasterState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="dynamicViewportState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindDynamicViewportState")]
        public static void CmdBindDynamicViewportState([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] DynamicViewportState dynamicViewportState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="indexType"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindIndexBuffer")]
        public static void CmdBindIndexBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.IndexType indexType) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="pipelineBindPoint"></param>
        /// <param name="pipeline"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindPipeline")]
        public static void CmdBindPipeline([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineBindPoint pipelineBindPoint, [InAttribute, OutAttribute] Pipeline pipeline) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="startBinding"></param>
        /// <param name="bindingCount"></param>
        /// <param name="pBuffers"></param>
        /// <param name="pOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindVertexBuffers")]
        [CLSCompliant(false)]
        public static void CmdBindVertexBuffers([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 startBinding, [InAttribute, OutAttribute] Int32 bindingCount, [InAttribute, OutAttribute] ref Buffer pBuffers, [InAttribute, OutAttribute] ref IntPtr pOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="startBinding"></param>
        /// <param name="bindingCount"></param>
        /// <param name="pBuffers"></param>
        /// <param name="pOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindVertexBuffers")]
        [CLSCompliant(false)]
        public static void CmdBindVertexBuffers([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 startBinding, [InAttribute, OutAttribute] Int32 bindingCount, [InAttribute, OutAttribute] Buffer[] pBuffers, [InAttribute, OutAttribute] IntPtr[] pOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="startBinding"></param>
        /// <param name="bindingCount"></param>
        /// <param name="pBuffers"></param>
        /// <param name="pOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindVertexBuffers")]
        [CLSCompliant(false)]
        public static unsafe void CmdBindVertexBuffers([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 startBinding, [InAttribute, OutAttribute] Int32 bindingCount, [InAttribute, OutAttribute] Buffer* pBuffers, [InAttribute, OutAttribute] IntPtr* pOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="startBinding"></param>
        /// <param name="bindingCount"></param>
        /// <param name="pBuffers"></param>
        /// <param name="pOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindVertexBuffers")]
        [CLSCompliant(false)]
        public static void CmdBindVertexBuffers([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint startBinding, [InAttribute, OutAttribute] uint bindingCount, [InAttribute, OutAttribute] ref Buffer pBuffers, [InAttribute, OutAttribute] ref IntPtr pOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="startBinding"></param>
        /// <param name="bindingCount"></param>
        /// <param name="pBuffers"></param>
        /// <param name="pOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindVertexBuffers")]
        [CLSCompliant(false)]
        public static void CmdBindVertexBuffers([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint startBinding, [InAttribute, OutAttribute] uint bindingCount, [InAttribute, OutAttribute] Buffer[] pBuffers, [InAttribute, OutAttribute] IntPtr[] pOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="startBinding"></param>
        /// <param name="bindingCount"></param>
        /// <param name="pBuffers"></param>
        /// <param name="pOffsets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBindVertexBuffers")]
        [CLSCompliant(false)]
        public static unsafe void CmdBindVertexBuffers([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint startBinding, [InAttribute, OutAttribute] uint bindingCount, [InAttribute, OutAttribute] Buffer* pBuffers, [InAttribute, OutAttribute] IntPtr* pOffsets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        /// <param name="filter"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBlitImage")]
        [CLSCompliant(false)]
        public static void CmdBlitImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ref ImageBlit pRegions, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.TexFilter filter) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        /// <param name="filter"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBlitImage")]
        [CLSCompliant(false)]
        public static void CmdBlitImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ImageBlit[] pRegions, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.TexFilter filter) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        /// <param name="filter"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBlitImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdBlitImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ImageBlit* pRegions, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.TexFilter filter) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        /// <param name="filter"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBlitImage")]
        [CLSCompliant(false)]
        public static void CmdBlitImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ref ImageBlit pRegions, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.TexFilter filter) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        /// <param name="filter"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBlitImage")]
        [CLSCompliant(false)]
        public static void CmdBlitImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageBlit[] pRegions, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.TexFilter filter) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        /// <param name="filter"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdBlitImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdBlitImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageBlit* pRegions, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.TexFilter filter) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="colorAttachment"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorAttachment")]
        [CLSCompliant(false)]
        public static void CmdClearColorAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 colorAttachment, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ref ClearColorValue pColor, [InAttribute, OutAttribute] Int32 rectCount, [InAttribute, OutAttribute] ref Rect3D pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="colorAttachment"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorAttachment")]
        [CLSCompliant(false)]
        public static void CmdClearColorAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 colorAttachment, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ClearColorValue[] pColor, [InAttribute, OutAttribute] Int32 rectCount, [InAttribute, OutAttribute] Rect3D[] pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="colorAttachment"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorAttachment")]
        [CLSCompliant(false)]
        public static unsafe void CmdClearColorAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 colorAttachment, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ClearColorValue* pColor, [InAttribute, OutAttribute] Int32 rectCount, [InAttribute, OutAttribute] Rect3D* pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="colorAttachment"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorAttachment")]
        [CLSCompliant(false)]
        public static void CmdClearColorAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint colorAttachment, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ref ClearColorValue pColor, [InAttribute, OutAttribute] uint rectCount, [InAttribute, OutAttribute] ref Rect3D pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="colorAttachment"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorAttachment")]
        [CLSCompliant(false)]
        public static void CmdClearColorAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint colorAttachment, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ClearColorValue[] pColor, [InAttribute, OutAttribute] uint rectCount, [InAttribute, OutAttribute] Rect3D[] pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="colorAttachment"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorAttachment")]
        [CLSCompliant(false)]
        public static unsafe void CmdClearColorAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint colorAttachment, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ClearColorValue* pColor, [InAttribute, OutAttribute] uint rectCount, [InAttribute, OutAttribute] Rect3D* pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorImage")]
        [CLSCompliant(false)]
        public static void CmdClearColorImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ref ClearColorValue pColor, [InAttribute, OutAttribute] Int32 rangeCount, [InAttribute, OutAttribute] ref ImageSubresourceRange pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorImage")]
        [CLSCompliant(false)]
        public static void CmdClearColorImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ref ClearColorValue pColor, [InAttribute, OutAttribute] uint rangeCount, [InAttribute, OutAttribute] ref ImageSubresourceRange pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorImage")]
        [CLSCompliant(false)]
        public static void CmdClearColorImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ClearColorValue[] pColor, [InAttribute, OutAttribute] Int32 rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange[] pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorImage")]
        [CLSCompliant(false)]
        public static void CmdClearColorImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ClearColorValue[] pColor, [InAttribute, OutAttribute] uint rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange[] pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdClearColorImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ClearColorValue* pColor, [InAttribute, OutAttribute] Int32 rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange* pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="pColor"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearColorImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdClearColorImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] ClearColorValue* pColor, [InAttribute, OutAttribute] uint rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange* pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="imageAspectMask"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilAttachment")]
        [CLSCompliant(false)]
        public static void CmdClearDepthStencilAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageAspectFlags imageAspectMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] Int32 stencil, [InAttribute, OutAttribute] Int32 rectCount, [InAttribute, OutAttribute] ref Rect3D pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="imageAspectMask"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilAttachment")]
        [CLSCompliant(false)]
        public static void CmdClearDepthStencilAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageAspectFlags imageAspectMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] Int32 stencil, [InAttribute, OutAttribute] Int32 rectCount, [InAttribute, OutAttribute] Rect3D[] pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="imageAspectMask"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilAttachment")]
        [CLSCompliant(false)]
        public static unsafe void CmdClearDepthStencilAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageAspectFlags imageAspectMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] Int32 stencil, [InAttribute, OutAttribute] Int32 rectCount, [InAttribute, OutAttribute] Rect3D* pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="imageAspectMask"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilAttachment")]
        [CLSCompliant(false)]
        public static void CmdClearDepthStencilAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageAspectFlags imageAspectMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] uint stencil, [InAttribute, OutAttribute] uint rectCount, [InAttribute, OutAttribute] ref Rect3D pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="imageAspectMask"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilAttachment")]
        [CLSCompliant(false)]
        public static void CmdClearDepthStencilAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageAspectFlags imageAspectMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] uint stencil, [InAttribute, OutAttribute] uint rectCount, [InAttribute, OutAttribute] Rect3D[] pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="imageAspectMask"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rectCount"></param>
        /// <param name="pRects"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilAttachment")]
        [CLSCompliant(false)]
        public static unsafe void CmdClearDepthStencilAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageAspectFlags imageAspectMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] uint stencil, [InAttribute, OutAttribute] uint rectCount, [InAttribute, OutAttribute] Rect3D* pRects) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilImage")]
        [CLSCompliant(false)]
        public static void CmdClearDepthStencilImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] Int32 stencil, [InAttribute, OutAttribute] Int32 rangeCount, [InAttribute, OutAttribute] ref ImageSubresourceRange pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilImage")]
        [CLSCompliant(false)]
        public static void CmdClearDepthStencilImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] Int32 stencil, [InAttribute, OutAttribute] Int32 rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange[] pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdClearDepthStencilImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] Int32 stencil, [InAttribute, OutAttribute] Int32 rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange* pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilImage")]
        [CLSCompliant(false)]
        public static void CmdClearDepthStencilImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] uint stencil, [InAttribute, OutAttribute] uint rangeCount, [InAttribute, OutAttribute] ref ImageSubresourceRange pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilImage")]
        [CLSCompliant(false)]
        public static void CmdClearDepthStencilImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] uint stencil, [InAttribute, OutAttribute] uint rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange[] pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="image"></param>
        /// <param name="imageLayout"></param>
        /// <param name="depth"></param>
        /// <param name="stencil"></param>
        /// <param name="rangeCount"></param>
        /// <param name="pRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdClearDepthStencilImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdClearDepthStencilImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] uint stencil, [InAttribute, OutAttribute] uint rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange* pRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBuffer")]
        [CLSCompliant(false)]
        public static void CmdCopyBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ref BufferCopy pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBuffer")]
        [CLSCompliant(false)]
        public static void CmdCopyBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] BufferCopy[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBuffer")]
        [CLSCompliant(false)]
        public static unsafe void CmdCopyBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] BufferCopy* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBuffer")]
        [CLSCompliant(false)]
        public static void CmdCopyBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ref BufferCopy pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBuffer")]
        [CLSCompliant(false)]
        public static void CmdCopyBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferCopy[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBuffer")]
        [CLSCompliant(false)]
        public static unsafe void CmdCopyBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferCopy* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBufferToImage")]
        [CLSCompliant(false)]
        public static void CmdCopyBufferToImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ref BufferImageCopy pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBufferToImage")]
        [CLSCompliant(false)]
        public static void CmdCopyBufferToImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] BufferImageCopy[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBufferToImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdCopyBufferToImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] BufferImageCopy* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBufferToImage")]
        [CLSCompliant(false)]
        public static void CmdCopyBufferToImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ref BufferImageCopy pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBufferToImage")]
        [CLSCompliant(false)]
        public static void CmdCopyBufferToImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferImageCopy[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcBuffer"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyBufferToImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdCopyBufferToImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferImageCopy* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImage")]
        [CLSCompliant(false)]
        public static void CmdCopyImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ref ImageCopy pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImage")]
        [CLSCompliant(false)]
        public static void CmdCopyImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ImageCopy[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdCopyImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ImageCopy* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImage")]
        [CLSCompliant(false)]
        public static void CmdCopyImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ref ImageCopy pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImage")]
        [CLSCompliant(false)]
        public static void CmdCopyImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageCopy[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdCopyImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageCopy* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImageToBuffer")]
        [CLSCompliant(false)]
        public static void CmdCopyImageToBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ref BufferImageCopy pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImageToBuffer")]
        [CLSCompliant(false)]
        public static void CmdCopyImageToBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] BufferImageCopy[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImageToBuffer")]
        [CLSCompliant(false)]
        public static unsafe void CmdCopyImageToBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] BufferImageCopy* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImageToBuffer")]
        [CLSCompliant(false)]
        public static void CmdCopyImageToBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ref BufferImageCopy pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImageToBuffer")]
        [CLSCompliant(false)]
        public static void CmdCopyImageToBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferImageCopy[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destBuffer"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyImageToBuffer")]
        [CLSCompliant(false)]
        public static unsafe void CmdCopyImageToBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferImageCopy* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="destStride"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyQueryPoolResults")]
        [CLSCompliant(false)]
        public static void CmdCopyQueryPoolResults([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr destStride, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="destStride"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdCopyQueryPoolResults")]
        [CLSCompliant(false)]
        public static void CmdCopyQueryPoolResults([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr destStride, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDispatch")]
        [CLSCompliant(false)]
        public static void CmdDispatch([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 x, [InAttribute, OutAttribute] Int32 y, [InAttribute, OutAttribute] Int32 z) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDispatch")]
        [CLSCompliant(false)]
        public static void CmdDispatch([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint x, [InAttribute, OutAttribute] uint y, [InAttribute, OutAttribute] uint z) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDispatchIndirect")]
        public static void CmdDispatchIndirect([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="firstVertex"></param>
        /// <param name="vertexCount"></param>
        /// <param name="firstInstance"></param>
        /// <param name="instanceCount"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDraw")]
        [CLSCompliant(false)]
        public static void CmdDraw([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 firstVertex, [InAttribute, OutAttribute] Int32 vertexCount, [InAttribute, OutAttribute] Int32 firstInstance, [InAttribute, OutAttribute] Int32 instanceCount) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="firstVertex"></param>
        /// <param name="vertexCount"></param>
        /// <param name="firstInstance"></param>
        /// <param name="instanceCount"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDraw")]
        [CLSCompliant(false)]
        public static void CmdDraw([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint firstVertex, [InAttribute, OutAttribute] uint vertexCount, [InAttribute, OutAttribute] uint firstInstance, [InAttribute, OutAttribute] uint instanceCount) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="firstIndex"></param>
        /// <param name="indexCount"></param>
        /// <param name="vertexOffset"></param>
        /// <param name="firstInstance"></param>
        /// <param name="instanceCount"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDrawIndexed")]
        [CLSCompliant(false)]
        public static void CmdDrawIndexed([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 firstIndex, [InAttribute, OutAttribute] Int32 indexCount, [InAttribute, OutAttribute] int vertexOffset, [InAttribute, OutAttribute] Int32 firstInstance, [InAttribute, OutAttribute] Int32 instanceCount) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="firstIndex"></param>
        /// <param name="indexCount"></param>
        /// <param name="vertexOffset"></param>
        /// <param name="firstInstance"></param>
        /// <param name="instanceCount"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDrawIndexed")]
        [CLSCompliant(false)]
        public static void CmdDrawIndexed([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint firstIndex, [InAttribute, OutAttribute] uint indexCount, [InAttribute, OutAttribute] int vertexOffset, [InAttribute, OutAttribute] uint firstInstance, [InAttribute, OutAttribute] uint instanceCount) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="stride"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDrawIndexedIndirect")]
        [CLSCompliant(false)]
        public static void CmdDrawIndexedIndirect([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] Int32 stride) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="stride"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDrawIndexedIndirect")]
        [CLSCompliant(false)]
        public static void CmdDrawIndexedIndirect([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] uint stride) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="stride"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDrawIndirect")]
        [CLSCompliant(false)]
        public static void CmdDrawIndirect([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] Int32 stride) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="buffer"></param>
        /// <param name="offset"></param>
        /// <param name="count"></param>
        /// <param name="stride"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdDrawIndirect")]
        [CLSCompliant(false)]
        public static void CmdDrawIndirect([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] uint stride) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="queryPool"></param>
        /// <param name="slot"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdEndQuery")]
        [CLSCompliant(false)]
        public static void CmdEndQuery([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 slot) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="queryPool"></param>
        /// <param name="slot"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdEndQuery")]
        [CLSCompliant(false)]
        public static void CmdEndQuery([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint slot) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdEndRenderPass")]
        public static void CmdEndRenderPas([InAttribute, OutAttribute] CmdBuffer cmdBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="cmdBuffersCount"></param>
        /// <param name="pCmdBuffers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdExecuteCommands")]
        [CLSCompliant(false)]
        public static void CmdExecuteCommands([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 cmdBuffersCount, [InAttribute, OutAttribute] ref CmdBuffer pCmdBuffers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="cmdBuffersCount"></param>
        /// <param name="pCmdBuffers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdExecuteCommands")]
        [CLSCompliant(false)]
        public static void CmdExecuteCommands([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 cmdBuffersCount, [InAttribute, OutAttribute] CmdBuffer[] pCmdBuffers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="cmdBuffersCount"></param>
        /// <param name="pCmdBuffers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdExecuteCommands")]
        [CLSCompliant(false)]
        public static unsafe void CmdExecuteCommands([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 cmdBuffersCount, [InAttribute, OutAttribute] CmdBuffer* pCmdBuffers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="cmdBuffersCount"></param>
        /// <param name="pCmdBuffers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdExecuteCommands")]
        [CLSCompliant(false)]
        public static void CmdExecuteCommands([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint cmdBuffersCount, [InAttribute, OutAttribute] ref CmdBuffer pCmdBuffers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="cmdBuffersCount"></param>
        /// <param name="pCmdBuffers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdExecuteCommands")]
        [CLSCompliant(false)]
        public static void CmdExecuteCommands([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint cmdBuffersCount, [InAttribute, OutAttribute] CmdBuffer[] pCmdBuffers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="cmdBuffersCount"></param>
        /// <param name="pCmdBuffers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdExecuteCommands")]
        [CLSCompliant(false)]
        public static unsafe void CmdExecuteCommands([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint cmdBuffersCount, [InAttribute, OutAttribute] CmdBuffer* pCmdBuffers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="fillSize"></param>
        /// <param name="data"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdFillBuffer")]
        [CLSCompliant(false)]
        public static void CmdFillBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr fillSize, [InAttribute, OutAttribute] Int32 data) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="fillSize"></param>
        /// <param name="data"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdFillBuffer")]
        [CLSCompliant(false)]
        public static void CmdFillBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr fillSize, [InAttribute, OutAttribute] uint data) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="contents"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdNextSubpass")]
        public static void CmdNextSubpas([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.RenderPassContents contents) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] ref T5 ppMemBarriers)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T5[] ppMemBarriers)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T5[,] ppMemBarriers)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T5[,,] ppMemBarriers)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] ref T5 ppMemBarriers)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T5[] ppMemBarriers)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T5[,] ppMemBarriers)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="byRegion"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPipelineBarrier")]
        [CLSCompliant(false)]
        public static void CmdPipelineBarrier<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T5[,,] ppMemBarriers)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] Int32 start, [InAttribute, OutAttribute] Int32 length, [InAttribute, OutAttribute] IntPtr values) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] Int32 start, [InAttribute, OutAttribute] Int32 length, [InAttribute, OutAttribute] ref T5 values)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] Int32 start, [InAttribute, OutAttribute] Int32 length, [InAttribute, OutAttribute] T5[] values)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] Int32 start, [InAttribute, OutAttribute] Int32 length, [InAttribute, OutAttribute] T5[,] values)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] Int32 start, [InAttribute, OutAttribute] Int32 length, [InAttribute, OutAttribute] T5[,,] values)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] uint start, [InAttribute, OutAttribute] uint length, [InAttribute, OutAttribute] IntPtr values) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] uint start, [InAttribute, OutAttribute] uint length, [InAttribute, OutAttribute] ref T5 values)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] uint start, [InAttribute, OutAttribute] uint length, [InAttribute, OutAttribute] T5[] values)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] uint start, [InAttribute, OutAttribute] uint length, [InAttribute, OutAttribute] T5[,] values)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="layout"></param>
        /// <param name="stageFlags"></param>
        /// <param name="start"></param>
        /// <param name="length"></param>
        /// <param name="values"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdPushConstants")]
        [CLSCompliant(false)]
        public static void CmdPushConstants<T5>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ShaderStageFlags stageFlags, [InAttribute, OutAttribute] uint start, [InAttribute, OutAttribute] uint length, [InAttribute, OutAttribute] T5[,,] values)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="@event"></param>
        /// <param name="stageMask"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResetEvent")]
        public static void CmdResetEvent([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Event @event, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags stageMask) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResetQueryPool")]
        [CLSCompliant(false)]
        public static void CmdResetQueryPool([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResetQueryPool")]
        [CLSCompliant(false)]
        public static void CmdResetQueryPool([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResolveImage")]
        [CLSCompliant(false)]
        public static void CmdResolveImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ref ImageResolve pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResolveImage")]
        [CLSCompliant(false)]
        public static void CmdResolveImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ImageResolve[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResolveImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdResolveImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] Int32 regionCount, [InAttribute, OutAttribute] ImageResolve* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResolveImage")]
        [CLSCompliant(false)]
        public static void CmdResolveImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ref ImageResolve pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResolveImage")]
        [CLSCompliant(false)]
        public static void CmdResolveImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageResolve[] pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="srcImage"></param>
        /// <param name="srcImageLayout"></param>
        /// <param name="destImage"></param>
        /// <param name="destImageLayout"></param>
        /// <param name="regionCount"></param>
        /// <param name="pRegions"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdResolveImage")]
        [CLSCompliant(false)]
        public static unsafe void CmdResolveImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageLayout destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageResolve* pRegions) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="@event"></param>
        /// <param name="stageMask"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdSetEvent")]
        public static void CmdSetEvent([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Event @event, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags stageMask) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="dataSize"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdUpdateBuffer")]
        [CLSCompliant(false)]
        public static void CmdUpdateBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr dataSize, [InAttribute, OutAttribute] ref Int32 pData) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="dataSize"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdUpdateBuffer")]
        [CLSCompliant(false)]
        public static void CmdUpdateBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr dataSize, [InAttribute, OutAttribute] Int32[] pData) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="dataSize"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdUpdateBuffer")]
        [CLSCompliant(false)]
        public static unsafe void CmdUpdateBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr dataSize, [InAttribute, OutAttribute] Int32* pData) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="dataSize"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdUpdateBuffer")]
        [CLSCompliant(false)]
        public static void CmdUpdateBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr dataSize, [InAttribute, OutAttribute] ref uint pData) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="dataSize"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdUpdateBuffer")]
        [CLSCompliant(false)]
        public static void CmdUpdateBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr dataSize, [InAttribute, OutAttribute] uint[] pData) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        /// <param name="dataSize"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdUpdateBuffer")]
        [CLSCompliant(false)]
        public static unsafe void CmdUpdateBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr dataSize, [InAttribute, OutAttribute] uint* pData) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] ref T6 ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[,,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] ref T6 ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[,,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] ref T6 ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Int32 eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] Int32 memBarrierCount, [InAttribute, OutAttribute] T6[,,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] ref T6 ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] ref Event pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[,,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] ref T6 ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event[] pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[,,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] ref T6 ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="eventCount"></param>
        /// <param name="pEvents"></param>
        /// <param name="srcStageMask"></param>
        /// <param name="destStageMask"></param>
        /// <param name="memBarrierCount"></param>
        /// <param name="ppMemBarriers"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWaitEvents")]
        [CLSCompliant(false)]
        public static unsafe void CmdWaitEvents<T6>([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags srcStageMask, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.PipelineStageFlags destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] T6[,,] ppMemBarriers)
            where T6 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="timestampType"></param>
        /// <param name="destBuffer"></param>
        /// <param name="destOffset"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCmdWriteTimestamp")]
        public static void CmdWriteTimestamp([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.TimestampType timestampType, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateAttachmentView")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateAttachmentView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref AttachmentViewCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref AttachmentView pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateAttachmentView")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateAttachmentView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] AttachmentViewCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] AttachmentView[] pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateAttachmentView")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateAttachmentView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] AttachmentViewCreateInfo* pCreateInfo, [InAttribute, OutAttribute] AttachmentView* pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateBuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref BufferCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Buffer pBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateBuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] BufferCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Buffer[] pBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateBuffer")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] BufferCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Buffer* pBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateBufferView")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateBufferView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref BufferViewCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref BufferView pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateBufferView")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateBufferView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] BufferViewCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] BufferView[] pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateBufferView")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateBufferView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] BufferViewCreateInfo* pCreateInfo, [InAttribute, OutAttribute] BufferView* pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pCmdBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateCommandBuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateCommandBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref CmdBufferCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref CmdBuffer pCmdBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pCmdBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateCommandBuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateCommandBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdBufferCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] CmdBuffer[] pCmdBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pCmdBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateCommandBuffer")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateCommandBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdBufferCreateInfo* pCreateInfo, [InAttribute, OutAttribute] CmdBuffer* pCmdBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pCmdPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateCommandPool")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateCommandPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref CmdPoolCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref CmdPool pCmdPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pCmdPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateCommandPool")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateCommandPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdPoolCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] CmdPool[] pCmdPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pCmdPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateCommandPool")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateCommandPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdPoolCreateInfo* pCreateInfo, [InAttribute, OutAttribute] CmdPool* pCmdPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateComputePipelines")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateComputePipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] ref ComputePipelineCreateInfo pCreateInfos, [InAttribute, OutAttribute] ref Pipeline pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateComputePipelines")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateComputePipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] ComputePipelineCreateInfo[] pCreateInfos, [InAttribute, OutAttribute] Pipeline[] pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateComputePipelines")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateComputePipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] ComputePipelineCreateInfo* pCreateInfos, [InAttribute, OutAttribute] Pipeline* pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateComputePipelines")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateComputePipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] ref ComputePipelineCreateInfo pCreateInfos, [InAttribute, OutAttribute] ref Pipeline pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateComputePipelines")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateComputePipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] ComputePipelineCreateInfo[] pCreateInfos, [InAttribute, OutAttribute] Pipeline[] pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateComputePipelines")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateComputePipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] ComputePipelineCreateInfo* pCreateInfos, [InAttribute, OutAttribute] Pipeline* pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="poolUsage"></param>
        /// <param name="maxSets"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDescriptorPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorPool")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorPoolUsage poolUsage, [InAttribute, OutAttribute] Int32 maxSets, [InAttribute, OutAttribute] ref DescriptorPoolCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref DescriptorPool pDescriptorPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="poolUsage"></param>
        /// <param name="maxSets"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDescriptorPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorPool")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorPoolUsage poolUsage, [InAttribute, OutAttribute] Int32 maxSets, [InAttribute, OutAttribute] DescriptorPoolCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] DescriptorPool[] pDescriptorPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="poolUsage"></param>
        /// <param name="maxSets"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDescriptorPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorPool")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorPoolUsage poolUsage, [InAttribute, OutAttribute] Int32 maxSets, [InAttribute, OutAttribute] DescriptorPoolCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DescriptorPool* pDescriptorPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="poolUsage"></param>
        /// <param name="maxSets"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDescriptorPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorPool")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorPoolUsage poolUsage, [InAttribute, OutAttribute] uint maxSets, [InAttribute, OutAttribute] ref DescriptorPoolCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref DescriptorPool pDescriptorPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="poolUsage"></param>
        /// <param name="maxSets"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDescriptorPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorPool")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorPoolUsage poolUsage, [InAttribute, OutAttribute] uint maxSets, [InAttribute, OutAttribute] DescriptorPoolCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] DescriptorPool[] pDescriptorPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="poolUsage"></param>
        /// <param name="maxSets"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDescriptorPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorPool")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.DescriptorPoolUsage poolUsage, [InAttribute, OutAttribute] uint maxSets, [InAttribute, OutAttribute] DescriptorPoolCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DescriptorPool* pDescriptorPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSetLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorSetLayout")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDescriptorSetLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref DescriptorSetLayoutCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref DescriptorSetLayout pSetLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSetLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorSetLayout")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDescriptorSetLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorSetLayoutCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] DescriptorSetLayout[] pSetLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSetLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDescriptorSetLayout")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateDescriptorSetLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorSetLayoutCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DescriptorSetLayout* pSetLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDevice"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDevice")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDevice([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref DeviceCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Device pDevice) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDevice"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDevice")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDevice([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] DeviceCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Device[] pDevice) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pDevice"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDevice")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateDevice([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] DeviceCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Device* pDevice) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicColorBlendState")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDynamicColorBlendState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref DynamicColorBlendStateCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref DynamicColorBlendState pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicColorBlendState")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDynamicColorBlendState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicColorBlendStateCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] DynamicColorBlendState[] pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicColorBlendState")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateDynamicColorBlendState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicColorBlendStateCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DynamicColorBlendState* pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicDepthStencilState")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDynamicDepthStencilState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref DynamicDepthStencilStateCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref DynamicDepthStencilState pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicDepthStencilState")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDynamicDepthStencilState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicDepthStencilStateCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] DynamicDepthStencilState[] pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicDepthStencilState")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateDynamicDepthStencilState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicDepthStencilStateCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DynamicDepthStencilState* pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicRasterState")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDynamicRasterState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref DynamicRasterStateCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref DynamicRasterState pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicRasterState")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDynamicRasterState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicRasterStateCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] DynamicRasterState[] pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicRasterState")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateDynamicRasterState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicRasterStateCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DynamicRasterState* pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicViewportState")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDynamicViewportState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref DynamicViewportStateCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref DynamicViewportState pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicViewportState")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateDynamicViewportState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicViewportStateCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] DynamicViewportState[] pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateDynamicViewportState")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateDynamicViewportState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicViewportStateCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DynamicViewportState* pState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pEvent"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateEvent")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref EventCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Event pEvent) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pEvent"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateEvent")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] EventCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Event[] pEvent) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pEvent"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateEvent")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] EventCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Event* pEvent) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFence")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateFence([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref FenceCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Fence pFence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFence")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateFence([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] FenceCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Fence[] pFence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFence")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateFence([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] FenceCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Fence* pFence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFramebuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFramebuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref FramebufferCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Int32 pFramebuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFramebuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFramebuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref FramebufferCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref UInt32 pFramebuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFramebuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFramebuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] FramebufferCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Int32[] pFramebuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFramebuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFramebuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] FramebufferCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] UInt32[] pFramebuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFramebuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFramebuffer")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] FramebufferCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Int32* pFramebuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pFramebuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateFramebuffer")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] FramebufferCreateInfo* pCreateInfo, [InAttribute, OutAttribute] UInt32* pFramebuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateGraphicsPipelines")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateGraphicsPipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] ref GraphicsPipelineCreateInfo pCreateInfos, [InAttribute, OutAttribute] ref Pipeline pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateGraphicsPipelines")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateGraphicsPipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] GraphicsPipelineCreateInfo[] pCreateInfos, [InAttribute, OutAttribute] Pipeline[] pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateGraphicsPipelines")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateGraphicsPipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] GraphicsPipelineCreateInfo* pCreateInfos, [InAttribute, OutAttribute] Pipeline* pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateGraphicsPipelines")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateGraphicsPipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] ref GraphicsPipelineCreateInfo pCreateInfos, [InAttribute, OutAttribute] ref Pipeline pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateGraphicsPipelines")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateGraphicsPipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] GraphicsPipelineCreateInfo[] pCreateInfos, [InAttribute, OutAttribute] Pipeline[] pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="count"></param>
        /// <param name="pCreateInfos"></param>
        /// <param name="pPipelines"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateGraphicsPipelines")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateGraphicsPipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] GraphicsPipelineCreateInfo* pCreateInfos, [InAttribute, OutAttribute] Pipeline* pPipelines) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pImage"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateImage")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateImage([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref ImageCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Image pImage) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pImage"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateImage")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateImage([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ImageCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Image[] pImage) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pImage"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateImage")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateImage([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ImageCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Image* pImage) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateImageView")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateImageView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref ImageViewCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref ImageView pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateImageView")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateImageView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ImageViewCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] ImageView[] pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateImageView")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateImageView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ImageViewCreateInfo* pCreateInfo, [InAttribute, OutAttribute] ImageView* pView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCreateInfo"></param>
        /// <param name="pInstance"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateInstance")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateInstance([InAttribute, OutAttribute] ref InstanceCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Instance pInstance) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCreateInfo"></param>
        /// <param name="pInstance"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateInstance")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateInstance([InAttribute, OutAttribute] InstanceCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Instance[] pInstance) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCreateInfo"></param>
        /// <param name="pInstance"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateInstance")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateInstance([InAttribute, OutAttribute] InstanceCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Instance* pInstance) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pPipelineCache"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreatePipelineCache")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreatePipelineCache([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref PipelineCacheCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref PipelineCache pPipelineCache) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pPipelineCache"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreatePipelineCache")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreatePipelineCache([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCacheCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] PipelineCache[] pPipelineCache) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pPipelineCache"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreatePipelineCache")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreatePipelineCache([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCacheCreateInfo* pCreateInfo, [InAttribute, OutAttribute] PipelineCache* pPipelineCache) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pPipelineLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreatePipelineLayout")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreatePipelineLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref PipelineLayoutCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref PipelineLayout pPipelineLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pPipelineLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreatePipelineLayout")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreatePipelineLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineLayoutCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] PipelineLayout[] pPipelineLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pPipelineLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreatePipelineLayout")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreatePipelineLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineLayoutCreateInfo* pCreateInfo, [InAttribute, OutAttribute] PipelineLayout* pPipelineLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pQueryPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateQueryPool")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateQueryPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref QueryPoolCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref QueryPool pQueryPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pQueryPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateQueryPool")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateQueryPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPoolCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] QueryPool[] pQueryPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pQueryPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateQueryPool")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateQueryPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPoolCreateInfo* pCreateInfo, [InAttribute, OutAttribute] QueryPool* pQueryPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pRenderPass"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateRenderPass")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateRenderPas([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref RenderPassCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref RenderPass pRenderPass) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pRenderPass"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateRenderPass")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateRenderPas([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPassCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] RenderPass[] pRenderPass) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pRenderPass"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateRenderPass")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateRenderPas([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPassCreateInfo* pCreateInfo, [InAttribute, OutAttribute] RenderPass* pRenderPass) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSampler"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateSampler")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateSampler([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref SamplerCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Sampler pSampler) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSampler"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateSampler")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateSampler([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] SamplerCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Sampler[] pSampler) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSampler"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateSampler")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateSampler([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] SamplerCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Sampler* pSampler) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSemaphore"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateSemaphore")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateSemaphore([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref SemaphoreCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Semaphore pSemaphore) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSemaphore"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateSemaphore")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateSemaphore([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] SemaphoreCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Semaphore[] pSemaphore) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pSemaphore"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateSemaphore")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateSemaphore([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] SemaphoreCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Semaphore* pSemaphore) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pShader"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateShader")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateShader([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref ShaderCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref Shader pShader) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pShader"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateShader")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateShader([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ShaderCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] Shader[] pShader) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pShader"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateShader")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateShader([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ShaderCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Shader* pShader) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pShaderModule"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateShaderModule")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateShaderModule([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ref ShaderModuleCreateInfo pCreateInfo, [InAttribute, OutAttribute] ref ShaderModule pShaderModule) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pShaderModule"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateShaderModule")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result CreateShaderModule([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ShaderModuleCreateInfo[] pCreateInfo, [InAttribute, OutAttribute] ShaderModule[] pShaderModule) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pShaderModule"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkCreateShaderModule")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result CreateShaderModule([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ShaderModuleCreateInfo* pCreateInfo, [InAttribute, OutAttribute] ShaderModule* pShaderModule) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="attachmentView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyAttachmentView")]
        public static OpenTK.Graphics.Vulkan.Result DestroyAttachmentView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] AttachmentView attachmentView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="buffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyBuffer")]
        public static OpenTK.Graphics.Vulkan.Result DestroyBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Buffer buffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="bufferView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyBufferView")]
        public static OpenTK.Graphics.Vulkan.Result DestroyBufferView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] BufferView bufferView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="commandBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyCommandBuffer")]
        public static OpenTK.Graphics.Vulkan.Result DestroyCommandBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdBuffer commandBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="cmdPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyCommandPool")]
        public static OpenTK.Graphics.Vulkan.Result DestroyCommandPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdPool cmdPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyDescriptorPool")]
        public static OpenTK.Graphics.Vulkan.Result DestroyDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorSetLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyDescriptorSetLayout")]
        public static OpenTK.Graphics.Vulkan.Result DestroyDescriptorSetLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorSetLayout descriptorSetLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyDevice")]
        public static OpenTK.Graphics.Vulkan.Result DestroyDevice([InAttribute, OutAttribute] Device device) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="dynamicColorBlendState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyDynamicColorBlendState")]
        public static OpenTK.Graphics.Vulkan.Result DestroyDynamicColorBlendState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicColorBlendState dynamicColorBlendState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="dynamicDepthStencilState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyDynamicDepthStencilState")]
        public static OpenTK.Graphics.Vulkan.Result DestroyDynamicDepthStencilState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicDepthStencilState dynamicDepthStencilState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="dynamicRasterState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyDynamicRasterState")]
        public static OpenTK.Graphics.Vulkan.Result DestroyDynamicRasterState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicRasterState dynamicRasterState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="dynamicViewportState"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyDynamicViewportState")]
        public static OpenTK.Graphics.Vulkan.Result DestroyDynamicViewportState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicViewportState dynamicViewportState) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="@event"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyEvent")]
        public static OpenTK.Graphics.Vulkan.Result DestroyEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Event @event) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyFence")]
        public static OpenTK.Graphics.Vulkan.Result DestroyFence([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Fence fence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="framebuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyFramebuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result DestroyFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 framebuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="framebuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyFramebuffer")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result DestroyFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] UInt32 framebuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyImage")]
        public static OpenTK.Graphics.Vulkan.Result DestroyImage([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="imageView"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyImageView")]
        public static OpenTK.Graphics.Vulkan.Result DestroyImageView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ImageView imageView) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="instance"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyInstance")]
        public static OpenTK.Graphics.Vulkan.Result DestroyInstance([InAttribute, OutAttribute] Instance instance) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipeline"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyPipeline")]
        public static OpenTK.Graphics.Vulkan.Result DestroyPipeline([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Pipeline pipeline) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyPipelineCache")]
        public static OpenTK.Graphics.Vulkan.Result DestroyPipelineCache([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyPipelineLayout")]
        public static OpenTK.Graphics.Vulkan.Result DestroyPipelineLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineLayout pipelineLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyQueryPool")]
        public static OpenTK.Graphics.Vulkan.Result DestroyQueryPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="renderPass"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyRenderPass")]
        public static OpenTK.Graphics.Vulkan.Result DestroyRenderPas([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPass renderPass) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="sampler"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroySampler")]
        public static OpenTK.Graphics.Vulkan.Result DestroySampler([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Sampler sampler) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="semaphore"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroySemaphore")]
        public static OpenTK.Graphics.Vulkan.Result DestroySemaphore([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Semaphore semaphore) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="shader"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyShader")]
        public static OpenTK.Graphics.Vulkan.Result DestroyShader([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Shader shader) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="shaderModule"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDestroyShaderModule")]
        public static OpenTK.Graphics.Vulkan.Result DestroyShaderModule([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ShaderModule shaderModule) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkDeviceWaitIdle")]
        public static OpenTK.Graphics.Vulkan.Result DeviceWaitIdle([InAttribute, OutAttribute] Device device) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkEndCommandBuffer")]
        public static OpenTK.Graphics.Vulkan.Result EndCommandBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="instance"></param>
        /// <param name="pPhysicalDeviceCount"></param>
        /// <param name="pPhysicalDevices"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkEnumeratePhysicalDevices")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result EnumeratePhysicalDevices([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] ref Int32 pPhysicalDeviceCount, [InAttribute, OutAttribute] ref PhysicalDevice pPhysicalDevices) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="instance"></param>
        /// <param name="pPhysicalDeviceCount"></param>
        /// <param name="pPhysicalDevices"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkEnumeratePhysicalDevices")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result EnumeratePhysicalDevices([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] Int32[] pPhysicalDeviceCount, [InAttribute, OutAttribute] PhysicalDevice[] pPhysicalDevices) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="instance"></param>
        /// <param name="pPhysicalDeviceCount"></param>
        /// <param name="pPhysicalDevices"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkEnumeratePhysicalDevices")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result EnumeratePhysicalDevices([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] Int32* pPhysicalDeviceCount, [InAttribute, OutAttribute] PhysicalDevice* pPhysicalDevices) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="instance"></param>
        /// <param name="pPhysicalDeviceCount"></param>
        /// <param name="pPhysicalDevices"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkEnumeratePhysicalDevices")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result EnumeratePhysicalDevices([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] ref uint pPhysicalDeviceCount, [InAttribute, OutAttribute] ref PhysicalDevice pPhysicalDevices) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="instance"></param>
        /// <param name="pPhysicalDeviceCount"></param>
        /// <param name="pPhysicalDevices"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkEnumeratePhysicalDevices")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result EnumeratePhysicalDevices([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] uint[] pPhysicalDeviceCount, [InAttribute, OutAttribute] PhysicalDevice[] pPhysicalDevices) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="instance"></param>
        /// <param name="pPhysicalDeviceCount"></param>
        /// <param name="pPhysicalDevices"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkEnumeratePhysicalDevices")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result EnumeratePhysicalDevices([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] uint* pPhysicalDeviceCount, [InAttribute, OutAttribute] PhysicalDevice* pPhysicalDevices) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFlushMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result FlushMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 memRangeCount, [InAttribute, OutAttribute] ref MappedMemoryRange pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFlushMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result FlushMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange[] pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFlushMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result FlushMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange* pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFlushMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result FlushMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint memRangeCount, [InAttribute, OutAttribute] ref MappedMemoryRange pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFlushMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result FlushMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange[] pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFlushMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result FlushMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange* pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="count"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFreeDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result FreeDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] ref DescriptorSet pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="count"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFreeDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result FreeDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] DescriptorSet[] pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="count"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFreeDescriptorSets")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result FreeDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] Int32 count, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="count"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFreeDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result FreeDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] ref DescriptorSet pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="count"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFreeDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result FreeDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] DescriptorSet[] pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        /// <param name="count"></param>
        /// <param name="pDescriptorSets"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFreeDescriptorSets")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result FreeDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="mem"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkFreeMemory")]
        public static OpenTK.Graphics.Vulkan.Result FreeMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="buffer"></param>
        /// <param name="pMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetBufferMemoryRequirements")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetBufferMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] ref MemoryRequirements pMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="buffer"></param>
        /// <param name="pMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetBufferMemoryRequirements")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetBufferMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] MemoryRequirements[] pMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="buffer"></param>
        /// <param name="pMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetBufferMemoryRequirements")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetBufferMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] MemoryRequirements* pMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memory"></param>
        /// <param name="pCommittedMemoryInBytes"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceMemoryCommitment")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetDeviceMemoryCommitment([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory memory, [InAttribute, OutAttribute] ref IntPtr pCommittedMemoryInBytes) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memory"></param>
        /// <param name="pCommittedMemoryInBytes"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceMemoryCommitment")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetDeviceMemoryCommitment([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory memory, [InAttribute, OutAttribute] IntPtr[] pCommittedMemoryInBytes) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memory"></param>
        /// <param name="pCommittedMemoryInBytes"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceMemoryCommitment")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetDeviceMemoryCommitment([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory memory, [InAttribute, OutAttribute] IntPtr* pCommittedMemoryInBytes) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pName"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceProcAddr")]
        public static PFN_vkVoidFunction GetDeviceProcAddr([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] String pName) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queueFamilyIndex"></param>
        /// <param name="queueIndex"></param>
        /// <param name="pQueue"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceQueue")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetDeviceQueue([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 queueFamilyIndex, [InAttribute, OutAttribute] Int32 queueIndex, [InAttribute, OutAttribute] ref Queue pQueue) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queueFamilyIndex"></param>
        /// <param name="queueIndex"></param>
        /// <param name="pQueue"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceQueue")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetDeviceQueue([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 queueFamilyIndex, [InAttribute, OutAttribute] Int32 queueIndex, [InAttribute, OutAttribute] Queue[] pQueue) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queueFamilyIndex"></param>
        /// <param name="queueIndex"></param>
        /// <param name="pQueue"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceQueue")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetDeviceQueue([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 queueFamilyIndex, [InAttribute, OutAttribute] Int32 queueIndex, [InAttribute, OutAttribute] Queue* pQueue) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queueFamilyIndex"></param>
        /// <param name="queueIndex"></param>
        /// <param name="pQueue"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceQueue")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetDeviceQueue([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint queueFamilyIndex, [InAttribute, OutAttribute] uint queueIndex, [InAttribute, OutAttribute] ref Queue pQueue) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queueFamilyIndex"></param>
        /// <param name="queueIndex"></param>
        /// <param name="pQueue"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceQueue")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetDeviceQueue([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint queueFamilyIndex, [InAttribute, OutAttribute] uint queueIndex, [InAttribute, OutAttribute] Queue[] pQueue) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queueFamilyIndex"></param>
        /// <param name="queueIndex"></param>
        /// <param name="pQueue"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetDeviceQueue")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetDeviceQueue([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint queueFamilyIndex, [InAttribute, OutAttribute] uint queueIndex, [InAttribute, OutAttribute] Queue* pQueue) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="@event"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetEventStatus")]
        public static OpenTK.Graphics.Vulkan.Result GetEventStatus([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Event @event) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetFenceStatus")]
        public static OpenTK.Graphics.Vulkan.Result GetFenceStatus([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Fence fence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalExtensionProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetGlobalExtensionProperties([InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] ref Int32 pCount, [InAttribute, OutAttribute] ref ExtensionProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalExtensionProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetGlobalExtensionProperties([InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] Int32[] pCount, [InAttribute, OutAttribute] ExtensionProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalExtensionProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetGlobalExtensionProperties([InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] Int32* pCount, [InAttribute, OutAttribute] ExtensionProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalExtensionProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetGlobalExtensionProperties([InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] ref uint pCount, [InAttribute, OutAttribute] ref ExtensionProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalExtensionProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetGlobalExtensionProperties([InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] uint[] pCount, [InAttribute, OutAttribute] ExtensionProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalExtensionProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetGlobalExtensionProperties([InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] ExtensionProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalLayerProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetGlobalLayerProperties([InAttribute, OutAttribute] ref Int32 pCount, [InAttribute, OutAttribute] ref LayerProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalLayerProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetGlobalLayerProperties([InAttribute, OutAttribute] Int32[] pCount, [InAttribute, OutAttribute] LayerProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalLayerProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetGlobalLayerProperties([InAttribute, OutAttribute] Int32* pCount, [InAttribute, OutAttribute] LayerProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalLayerProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetGlobalLayerProperties([InAttribute, OutAttribute] ref uint pCount, [InAttribute, OutAttribute] ref LayerProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalLayerProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetGlobalLayerProperties([InAttribute, OutAttribute] uint[] pCount, [InAttribute, OutAttribute] LayerProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetGlobalLayerProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetGlobalLayerProperties([InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] LayerProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageMemoryRequirements")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetImageMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] ref MemoryRequirements pMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageMemoryRequirements")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetImageMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] MemoryRequirements[] pMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageMemoryRequirements")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetImageMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] MemoryRequirements* pMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pNumRequirements"></param>
        /// <param name="pSparseMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSparseMemoryRequirements")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetImageSparseMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] ref Int32 pNumRequirements, [InAttribute, OutAttribute] ref SparseImageMemoryRequirements pSparseMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pNumRequirements"></param>
        /// <param name="pSparseMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSparseMemoryRequirements")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetImageSparseMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] Int32[] pNumRequirements, [InAttribute, OutAttribute] SparseImageMemoryRequirements[] pSparseMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pNumRequirements"></param>
        /// <param name="pSparseMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSparseMemoryRequirements")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetImageSparseMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] Int32* pNumRequirements, [InAttribute, OutAttribute] SparseImageMemoryRequirements* pSparseMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pNumRequirements"></param>
        /// <param name="pSparseMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSparseMemoryRequirements")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetImageSparseMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] ref uint pNumRequirements, [InAttribute, OutAttribute] ref SparseImageMemoryRequirements pSparseMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pNumRequirements"></param>
        /// <param name="pSparseMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSparseMemoryRequirements")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetImageSparseMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint[] pNumRequirements, [InAttribute, OutAttribute] SparseImageMemoryRequirements[] pSparseMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pNumRequirements"></param>
        /// <param name="pSparseMemoryRequirements"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSparseMemoryRequirements")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetImageSparseMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint* pNumRequirements, [InAttribute, OutAttribute] SparseImageMemoryRequirements* pSparseMemoryRequirements) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pSubresource"></param>
        /// <param name="pLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSubresourceLayout")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetImageSubresourceLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] ref ImageSubresource pSubresource, [InAttribute, OutAttribute] ref SubresourceLayout pLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pSubresource"></param>
        /// <param name="pLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSubresourceLayout")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetImageSubresourceLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] ImageSubresource[] pSubresource, [InAttribute, OutAttribute] SubresourceLayout[] pLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="image"></param>
        /// <param name="pSubresource"></param>
        /// <param name="pLayout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetImageSubresourceLayout")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetImageSubresourceLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] ImageSubresource* pSubresource, [InAttribute, OutAttribute] SubresourceLayout* pLayout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="instance"></param>
        /// <param name="pName"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetInstanceProcAddr")]
        public static PFN_vkVoidFunction GetInstanceProcAddr([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] String pName) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceExtensionProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceExtensionProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] ref Int32 pCount, [InAttribute, OutAttribute] ref ExtensionProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceExtensionProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceExtensionProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] Int32[] pCount, [InAttribute, OutAttribute] ExtensionProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceExtensionProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceExtensionProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] Int32* pCount, [InAttribute, OutAttribute] ExtensionProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceExtensionProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceExtensionProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] ref uint pCount, [InAttribute, OutAttribute] ref ExtensionProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceExtensionProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceExtensionProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] uint[] pCount, [InAttribute, OutAttribute] ExtensionProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLayerName"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceExtensionProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceExtensionProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] String pLayerName, [InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] ExtensionProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pFeatures"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceFeatures")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceFeatures([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref PhysicalDeviceFeatures pFeatures) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pFeatures"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceFeatures")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceFeatures([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceFeatures[] pFeatures) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pFeatures"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceFeatures")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceFeatures([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceFeatures* pFeatures) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="pFormatProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] ref FormatProperties pFormatProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="pFormatProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] FormatProperties[] pFormatProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="pFormatProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceFormatProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] FormatProperties* pFormatProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="tiling"></param>
        /// <param name="usage"></param>
        /// <param name="pImageFormatProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] ref ImageFormatProperties pImageFormatProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="tiling"></param>
        /// <param name="usage"></param>
        /// <param name="pImageFormatProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] ImageFormatProperties[] pImageFormatProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="tiling"></param>
        /// <param name="usage"></param>
        /// <param name="pImageFormatProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceImageFormatProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] ImageFormatProperties* pImageFormatProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLayerProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLayerProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref Int32 pCount, [InAttribute, OutAttribute] ref LayerProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLayerProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLayerProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] Int32[] pCount, [InAttribute, OutAttribute] LayerProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLayerProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLayerProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] Int32* pCount, [InAttribute, OutAttribute] LayerProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLayerProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLayerProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref uint pCount, [InAttribute, OutAttribute] ref LayerProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLayerProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLayerProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] uint[] pCount, [InAttribute, OutAttribute] LayerProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLayerProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLayerProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] LayerProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLimits"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLimits")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLimits([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref PhysicalDeviceLimits pLimits) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLimits"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLimits")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLimits([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceLimits[] pLimits) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pLimits"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceLimits")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceLimits([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceLimits* pLimits) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pMemoryProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceMemoryProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref PhysicalDeviceMemoryProperties pMemoryProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pMemoryProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceMemoryProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceMemoryProperties[] pMemoryProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pMemoryProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceMemoryProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceMemoryProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceMemoryProperties* pMemoryProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref PhysicalDeviceProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pQueueFamilyProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceQueueFamilyProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref Int32 pCount, [InAttribute, OutAttribute] ref QueueFamilyProperties pQueueFamilyProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pQueueFamilyProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceQueueFamilyProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] Int32[] pCount, [InAttribute, OutAttribute] QueueFamilyProperties[] pQueueFamilyProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pQueueFamilyProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceQueueFamilyProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] Int32* pCount, [InAttribute, OutAttribute] QueueFamilyProperties* pQueueFamilyProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pQueueFamilyProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceQueueFamilyProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] ref uint pCount, [InAttribute, OutAttribute] ref QueueFamilyProperties pQueueFamilyProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pQueueFamilyProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceQueueFamilyProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] uint[] pCount, [InAttribute, OutAttribute] QueueFamilyProperties[] pQueueFamilyProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="pCount"></param>
        /// <param name="pQueueFamilyProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceQueueFamilyProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] QueueFamilyProperties* pQueueFamilyProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="samples"></param>
        /// <param name="usage"></param>
        /// <param name="tiling"></param>
        /// <param name="pNumProperties"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceSparseImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] Int32 samples, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] ref Int32 pNumProperties, [InAttribute, OutAttribute] ref SparseImageFormatProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="samples"></param>
        /// <param name="usage"></param>
        /// <param name="tiling"></param>
        /// <param name="pNumProperties"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceSparseImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] Int32 samples, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] Int32[] pNumProperties, [InAttribute, OutAttribute] SparseImageFormatProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="samples"></param>
        /// <param name="usage"></param>
        /// <param name="tiling"></param>
        /// <param name="pNumProperties"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceSparseImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] Int32 samples, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] Int32* pNumProperties, [InAttribute, OutAttribute] SparseImageFormatProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="samples"></param>
        /// <param name="usage"></param>
        /// <param name="tiling"></param>
        /// <param name="pNumProperties"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceSparseImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] uint samples, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] ref uint pNumProperties, [InAttribute, OutAttribute] ref SparseImageFormatProperties pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="samples"></param>
        /// <param name="usage"></param>
        /// <param name="tiling"></param>
        /// <param name="pNumProperties"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceSparseImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] uint samples, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] uint[] pNumProperties, [InAttribute, OutAttribute] SparseImageFormatProperties[] pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="physicalDevice"></param>
        /// <param name="format"></param>
        /// <param name="type"></param>
        /// <param name="samples"></param>
        /// <param name="usage"></param>
        /// <param name="tiling"></param>
        /// <param name="pNumProperties"></param>
        /// <param name="pProperties"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetPhysicalDeviceSparseImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.Format format, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageType type, [InAttribute, OutAttribute] uint samples, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageUsageFlags usage, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.ImageTiling tiling, [InAttribute, OutAttribute] uint* pNumProperties, [InAttribute, OutAttribute] SparseImageFormatProperties* pProperties) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPipelineCacheData")]
        public static VkResult GetPipelineCacheData([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] IntPtr pData) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPipelineCacheData")]
        public static VkResult GetPipelineCacheData<T2>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] ref T2 pData)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPipelineCacheData")]
        [CLSCompliant(false)]
        public static VkResult GetPipelineCacheData<T2>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] T2[] pData)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPipelineCacheData")]
        [CLSCompliant(false)]
        public static VkResult GetPipelineCacheData<T2>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] T2[,] pData)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        /// <param name="pData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPipelineCacheData")]
        [CLSCompliant(false)]
        public static VkResult GetPipelineCacheData<T2>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] T2[,,] pData)
            where T2 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="pipelineCache"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetPipelineCacheSize")]
        public static IntPtr GetPipelineCacheSize([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] IntPtr pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] ref T5 pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] T5[] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] T5[,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] T5[,,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] IntPtr pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] ref T5 pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] T5[] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] T5[,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] T5[,,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] IntPtr pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] ref T5 pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] T5[] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] T5[,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] Int32 startQuery, [InAttribute, OutAttribute] Int32 queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] T5[,,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] IntPtr pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] ref T5 pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] T5[] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] T5[,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] ref IntPtr pDataSize, [InAttribute, OutAttribute] T5[,,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] IntPtr pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] ref T5 pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] T5[] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] T5[,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr[] pDataSize, [InAttribute, OutAttribute] T5[,,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] IntPtr pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] ref T5 pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] T5[] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] T5[,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="queryPool"></param>
        /// <param name="startQuery"></param>
        /// <param name="queryCount"></param>
        /// <param name="pDataSize"></param>
        /// <param name="pData"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetQueryPoolResults")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetQueryPoolResults<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] T5[,,] pData, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.QueryResultFlags flags)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="renderPass"></param>
        /// <param name="pGranularity"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetRenderAreaGranularity")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetRenderAreaGranularity([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPass renderPass, [InAttribute, OutAttribute] ref Extent2D pGranularity) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="renderPass"></param>
        /// <param name="pGranularity"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetRenderAreaGranularity")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result GetRenderAreaGranularity([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPass renderPass, [InAttribute, OutAttribute] Extent2D[] pGranularity) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="renderPass"></param>
        /// <param name="pGranularity"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkGetRenderAreaGranularity")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result GetRenderAreaGranularity([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPass renderPass, [InAttribute, OutAttribute] Extent2D* pGranularity) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkInvalidateMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result InvalidateMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 memRangeCount, [InAttribute, OutAttribute] ref MappedMemoryRange pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkInvalidateMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result InvalidateMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange[] pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkInvalidateMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result InvalidateMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange* pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkInvalidateMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result InvalidateMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint memRangeCount, [InAttribute, OutAttribute] ref MappedMemoryRange pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkInvalidateMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result InvalidateMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange[] pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="memRangeCount"></param>
        /// <param name="pMemRanges"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkInvalidateMappedMemoryRanges")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result InvalidateMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange* pMemRanges) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="mem"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <param name="flags"></param>
        /// <param name="ppData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMapMemory")]
        public static OpenTK.Graphics.Vulkan.Result MapMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] IntPtr size, [InAttribute, OutAttribute] MemoryMapFlags flags, [InAttribute, OutAttribute] IntPtr ppData) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="mem"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <param name="flags"></param>
        /// <param name="ppData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMapMemory")]
        public static OpenTK.Graphics.Vulkan.Result MapMemory<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] IntPtr size, [InAttribute, OutAttribute] MemoryMapFlags flags, [InAttribute, OutAttribute] ref T5 ppData)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="mem"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <param name="flags"></param>
        /// <param name="ppData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMapMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result MapMemory<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] IntPtr size, [InAttribute, OutAttribute] MemoryMapFlags flags, [InAttribute, OutAttribute] T5[] ppData)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="mem"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <param name="flags"></param>
        /// <param name="ppData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMapMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result MapMemory<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] IntPtr size, [InAttribute, OutAttribute] MemoryMapFlags flags, [InAttribute, OutAttribute] T5[,] ppData)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="mem"></param>
        /// <param name="offset"></param>
        /// <param name="size"></param>
        /// <param name="flags"></param>
        /// <param name="ppData"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMapMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result MapMemory<T5>([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] IntPtr size, [InAttribute, OutAttribute] MemoryMapFlags flags, [InAttribute, OutAttribute] T5[,,] ppData)
            where T5 : struct
         { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="destCache"></param>
        /// <param name="srcCacheCount"></param>
        /// <param name="pSrcCaches"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMergePipelineCaches")]
        [CLSCompliant(false)]
        public static VkResult MergePipelineCaches([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache destCache, [InAttribute, OutAttribute] Int32 srcCacheCount, [InAttribute, OutAttribute] ref PipelineCache pSrcCaches) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="destCache"></param>
        /// <param name="srcCacheCount"></param>
        /// <param name="pSrcCaches"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMergePipelineCaches")]
        [CLSCompliant(false)]
        public static VkResult MergePipelineCaches([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache destCache, [InAttribute, OutAttribute] Int32 srcCacheCount, [InAttribute, OutAttribute] PipelineCache[] pSrcCaches) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="destCache"></param>
        /// <param name="srcCacheCount"></param>
        /// <param name="pSrcCaches"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMergePipelineCaches")]
        [CLSCompliant(false)]
        public static unsafe VkResult MergePipelineCaches([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache destCache, [InAttribute, OutAttribute] Int32 srcCacheCount, [InAttribute, OutAttribute] PipelineCache* pSrcCaches) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="destCache"></param>
        /// <param name="srcCacheCount"></param>
        /// <param name="pSrcCaches"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMergePipelineCaches")]
        [CLSCompliant(false)]
        public static VkResult MergePipelineCaches([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache destCache, [InAttribute, OutAttribute] uint srcCacheCount, [InAttribute, OutAttribute] ref PipelineCache pSrcCaches) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="destCache"></param>
        /// <param name="srcCacheCount"></param>
        /// <param name="pSrcCaches"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMergePipelineCaches")]
        [CLSCompliant(false)]
        public static VkResult MergePipelineCaches([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache destCache, [InAttribute, OutAttribute] uint srcCacheCount, [InAttribute, OutAttribute] PipelineCache[] pSrcCaches) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="destCache"></param>
        /// <param name="srcCacheCount"></param>
        /// <param name="pSrcCaches"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkMergePipelineCaches")]
        [CLSCompliant(false)]
        public static unsafe VkResult MergePipelineCaches([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache destCache, [InAttribute, OutAttribute] uint srcCacheCount, [InAttribute, OutAttribute] PipelineCache* pSrcCaches) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="buffer"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseBufferMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseBufferMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] ref SparseMemoryBindInfo pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="buffer"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseBufferMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseBufferMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo[] pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="buffer"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseBufferMemory")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result QueueBindSparseBufferMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo* pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="buffer"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseBufferMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseBufferMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] ref SparseMemoryBindInfo pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="buffer"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseBufferMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseBufferMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo[] pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="buffer"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseBufferMemory")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result QueueBindSparseBufferMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo* pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseImageMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] ref SparseImageMemoryBindInfo pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseImageMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] SparseImageMemoryBindInfo[] pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageMemory")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result QueueBindSparseImageMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] SparseImageMemoryBindInfo* pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseImageMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] ref SparseImageMemoryBindInfo pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseImageMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseImageMemoryBindInfo[] pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageMemory")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result QueueBindSparseImageMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseImageMemoryBindInfo* pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageOpaqueMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseImageOpaqueMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] ref SparseMemoryBindInfo pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageOpaqueMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseImageOpaqueMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo[] pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageOpaqueMemory")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result QueueBindSparseImageOpaqueMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] Int32 numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo* pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageOpaqueMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseImageOpaqueMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] ref SparseMemoryBindInfo pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageOpaqueMemory")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueBindSparseImageOpaqueMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo[] pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="image"></param>
        /// <param name="numBindings"></param>
        /// <param name="pBindInfo"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueBindSparseImageOpaqueMemory")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result QueueBindSparseImageOpaqueMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo* pBindInfo) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="semaphore"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueSignalSemaphore")]
        public static OpenTK.Graphics.Vulkan.Result QueueSignalSemaphore([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Semaphore semaphore) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="cmdBufferCount"></param>
        /// <param name="pCmdBuffers"></param>
        /// <param name="fence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueSubmit")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueSubmit([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Int32 cmdBufferCount, [InAttribute, OutAttribute] ref CmdBuffer pCmdBuffers, [InAttribute, OutAttribute] Fence fence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="cmdBufferCount"></param>
        /// <param name="pCmdBuffers"></param>
        /// <param name="fence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueSubmit")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueSubmit([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Int32 cmdBufferCount, [InAttribute, OutAttribute] CmdBuffer[] pCmdBuffers, [InAttribute, OutAttribute] Fence fence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="cmdBufferCount"></param>
        /// <param name="pCmdBuffers"></param>
        /// <param name="fence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueSubmit")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result QueueSubmit([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Int32 cmdBufferCount, [InAttribute, OutAttribute] CmdBuffer* pCmdBuffers, [InAttribute, OutAttribute] Fence fence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="cmdBufferCount"></param>
        /// <param name="pCmdBuffers"></param>
        /// <param name="fence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueSubmit")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueSubmit([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] uint cmdBufferCount, [InAttribute, OutAttribute] ref CmdBuffer pCmdBuffers, [InAttribute, OutAttribute] Fence fence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="cmdBufferCount"></param>
        /// <param name="pCmdBuffers"></param>
        /// <param name="fence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueSubmit")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result QueueSubmit([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] uint cmdBufferCount, [InAttribute, OutAttribute] CmdBuffer[] pCmdBuffers, [InAttribute, OutAttribute] Fence fence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="cmdBufferCount"></param>
        /// <param name="pCmdBuffers"></param>
        /// <param name="fence"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueSubmit")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result QueueSubmit([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] uint cmdBufferCount, [InAttribute, OutAttribute] CmdBuffer* pCmdBuffers, [InAttribute, OutAttribute] Fence fence) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueWaitIdle")]
        public static OpenTK.Graphics.Vulkan.Result QueueWaitIdle([InAttribute, OutAttribute] Queue queue) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="queue"></param>
        /// <param name="semaphore"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkQueueWaitSemaphore")]
        public static OpenTK.Graphics.Vulkan.Result QueueWaitSemaphore([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Semaphore semaphore) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="cmdBuffer"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetCommandBuffer")]
        public static OpenTK.Graphics.Vulkan.Result ResetCommandBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.CmdBufferResetFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="cmdPool"></param>
        /// <param name="flags"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetCommandPool")]
        public static OpenTK.Graphics.Vulkan.Result ResetCommandPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdPool cmdPool, [InAttribute, OutAttribute] OpenTK.Graphics.Vulkan.CmdPoolResetFlags flags) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="descriptorPool"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetDescriptorPool")]
        public static OpenTK.Graphics.Vulkan.Result ResetDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="@event"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetEvent")]
        public static OpenTK.Graphics.Vulkan.Result ResetEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Event @event) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetFences")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result ResetFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 fenceCount, [InAttribute, OutAttribute] ref Fence pFences) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetFences")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result ResetFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 fenceCount, [InAttribute, OutAttribute] Fence[] pFences) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetFences")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result ResetFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 fenceCount, [InAttribute, OutAttribute] Fence* pFences) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetFences")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result ResetFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint fenceCount, [InAttribute, OutAttribute] ref Fence pFences) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetFences")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result ResetFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint fenceCount, [InAttribute, OutAttribute] Fence[] pFences) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkResetFences")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result ResetFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint fenceCount, [InAttribute, OutAttribute] Fence* pFences) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="@event"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkSetEvent")]
        public static OpenTK.Graphics.Vulkan.Result SetEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Event @event) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="mem"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkUnmapMemory")]
        public static OpenTK.Graphics.Vulkan.Result UnmapMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="writeCount"></param>
        /// <param name="pDescriptorWrites"></param>
        /// <param name="copyCount"></param>
        /// <param name="pDescriptorCopies"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkUpdateDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result UpdateDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 writeCount, [InAttribute, OutAttribute] ref WriteDescriptorSet pDescriptorWrites, [InAttribute, OutAttribute] Int32 copyCount, [InAttribute, OutAttribute] ref CopyDescriptorSet pDescriptorCopies) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="writeCount"></param>
        /// <param name="pDescriptorWrites"></param>
        /// <param name="copyCount"></param>
        /// <param name="pDescriptorCopies"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkUpdateDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result UpdateDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 writeCount, [InAttribute, OutAttribute] WriteDescriptorSet[] pDescriptorWrites, [InAttribute, OutAttribute] Int32 copyCount, [InAttribute, OutAttribute] CopyDescriptorSet[] pDescriptorCopies) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="writeCount"></param>
        /// <param name="pDescriptorWrites"></param>
        /// <param name="copyCount"></param>
        /// <param name="pDescriptorCopies"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkUpdateDescriptorSets")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result UpdateDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 writeCount, [InAttribute, OutAttribute] WriteDescriptorSet* pDescriptorWrites, [InAttribute, OutAttribute] Int32 copyCount, [InAttribute, OutAttribute] CopyDescriptorSet* pDescriptorCopies) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="writeCount"></param>
        /// <param name="pDescriptorWrites"></param>
        /// <param name="copyCount"></param>
        /// <param name="pDescriptorCopies"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkUpdateDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result UpdateDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint writeCount, [InAttribute, OutAttribute] ref WriteDescriptorSet pDescriptorWrites, [InAttribute, OutAttribute] uint copyCount, [InAttribute, OutAttribute] ref CopyDescriptorSet pDescriptorCopies) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="writeCount"></param>
        /// <param name="pDescriptorWrites"></param>
        /// <param name="copyCount"></param>
        /// <param name="pDescriptorCopies"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkUpdateDescriptorSets")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result UpdateDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint writeCount, [InAttribute, OutAttribute] WriteDescriptorSet[] pDescriptorWrites, [InAttribute, OutAttribute] uint copyCount, [InAttribute, OutAttribute] CopyDescriptorSet[] pDescriptorCopies) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="writeCount"></param>
        /// <param name="pDescriptorWrites"></param>
        /// <param name="copyCount"></param>
        /// <param name="pDescriptorCopies"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkUpdateDescriptorSets")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result UpdateDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint writeCount, [InAttribute, OutAttribute] WriteDescriptorSet* pDescriptorWrites, [InAttribute, OutAttribute] uint copyCount, [InAttribute, OutAttribute] CopyDescriptorSet* pDescriptorCopies) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        /// <param name="waitAll"></param>
        /// <param name="timeout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkWaitForFences")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result WaitForFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 fenceCount, [InAttribute, OutAttribute] ref Fence pFences, [InAttribute, OutAttribute] bool waitAll, [InAttribute, OutAttribute] Int64 timeout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        /// <param name="waitAll"></param>
        /// <param name="timeout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkWaitForFences")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result WaitForFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 fenceCount, [InAttribute, OutAttribute] Fence[] pFences, [InAttribute, OutAttribute] bool waitAll, [InAttribute, OutAttribute] Int64 timeout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        /// <param name="waitAll"></param>
        /// <param name="timeout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkWaitForFences")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result WaitForFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Int32 fenceCount, [InAttribute, OutAttribute] Fence* pFences, [InAttribute, OutAttribute] bool waitAll, [InAttribute, OutAttribute] Int64 timeout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        /// <param name="waitAll"></param>
        /// <param name="timeout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkWaitForFences")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result WaitForFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint fenceCount, [InAttribute, OutAttribute] ref Fence pFences, [InAttribute, OutAttribute] bool waitAll, [InAttribute, OutAttribute] ulong timeout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        /// <param name="waitAll"></param>
        /// <param name="timeout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkWaitForFences")]
        [CLSCompliant(false)]
        public static OpenTK.Graphics.Vulkan.Result WaitForFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint fenceCount, [InAttribute, OutAttribute] Fence[] pFences, [InAttribute, OutAttribute] bool waitAll, [InAttribute, OutAttribute] ulong timeout) { throw new NotImplementedException(); }

        /// <summary></summary>
        /// <param name="device"></param>
        /// <param name="fenceCount"></param>
        /// <param name="pFences"></param>
        /// <param name="waitAll"></param>
        /// <param name="timeout"></param>
        [AutoGenerated(Category = "", Version = "", EntryPoint = "vkWaitForFences")]
        [CLSCompliant(false)]
        public static unsafe OpenTK.Graphics.Vulkan.Result WaitForFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint fenceCount, [InAttribute, OutAttribute] Fence* pFences, [InAttribute, OutAttribute] bool waitAll, [InAttribute, OutAttribute] ulong timeout) { throw new NotImplementedException(); }

        [Slot(0)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkAllocDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] System.Int32 setUsage, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] DescriptorSetLayout* pSetLayouts, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets);
        [Slot(1)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkAllocMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] MemoryAllocInfo* pAllocInfo, [InAttribute, OutAttribute] DeviceMemory* pMem);
        [Slot(2)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkBeginCommandBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] CmdBufferBeginInfo* pBeginInfo);
        [Slot(3)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkBindBufferMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr memOffset);
        [Slot(4)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkBindImageMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr memOffset);
        [Slot(5)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdBeginQuery([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint slot, [InAttribute, OutAttribute] System.Int32 flags);
        [Slot(6)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdBeginRenderPass([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] RenderPassBeginInfo* pRenderPassBegin, [InAttribute, OutAttribute] System.Int32 contents);
        [Slot(7)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdBindDescriptorSets([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] System.Int32 pipelineBindPoint, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] uint firstSet, [InAttribute, OutAttribute] uint setCount, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets, [InAttribute, OutAttribute] uint dynamicOffsetCount, [InAttribute, OutAttribute] uint* pDynamicOffsets);
        [Slot(8)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdBindDynamicColorBlendState([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] DynamicColorBlendState dynamicColorBlendState);
        [Slot(9)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdBindDynamicDepthStencilState([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] DynamicDepthStencilState dynamicDepthStencilState);
        [Slot(10)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdBindDynamicRasterState([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] DynamicRasterState dynamicRasterState);
        [Slot(11)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdBindDynamicViewportState([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] DynamicViewportState dynamicViewportState);
        [Slot(12)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdBindIndexBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] System.Int32 indexType);
        [Slot(13)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdBindPipeline([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] System.Int32 pipelineBindPoint, [InAttribute, OutAttribute] Pipeline pipeline);
        [Slot(14)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdBindVertexBuffers([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint startBinding, [InAttribute, OutAttribute] uint bindingCount, [InAttribute, OutAttribute] Buffer* pBuffers, [InAttribute, OutAttribute] IntPtr* pOffsets);
        [Slot(15)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdBlitImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] System.Int32 srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] System.Int32 destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageBlit* pRegions, [InAttribute, OutAttribute] System.Int32 filter);
        [Slot(16)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdClearColorAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint colorAttachment, [InAttribute, OutAttribute] System.Int32 imageLayout, [InAttribute, OutAttribute] ClearColorValue* pColor, [InAttribute, OutAttribute] uint rectCount, [InAttribute, OutAttribute] Rect3D* pRects);
        [Slot(17)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdClearColorImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] System.Int32 imageLayout, [InAttribute, OutAttribute] ClearColorValue* pColor, [InAttribute, OutAttribute] uint rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange* pRanges);
        [Slot(18)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdClearDepthStencilAttachment([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] System.Int32 imageAspectMask, [InAttribute, OutAttribute] System.Int32 imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] uint stencil, [InAttribute, OutAttribute] uint rectCount, [InAttribute, OutAttribute] Rect3D* pRects);
        [Slot(19)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdClearDepthStencilImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] System.Int32 imageLayout, [InAttribute, OutAttribute] Single depth, [InAttribute, OutAttribute] uint stencil, [InAttribute, OutAttribute] uint rangeCount, [InAttribute, OutAttribute] ImageSubresourceRange* pRanges);
        [Slot(20)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdCopyBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferCopy* pRegions);
        [Slot(21)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdCopyBufferToImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer srcBuffer, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] System.Int32 destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferImageCopy* pRegions);
        [Slot(22)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdCopyImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] System.Int32 srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] System.Int32 destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageCopy* pRegions);
        [Slot(23)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdCopyImageToBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] System.Int32 srcImageLayout, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] BufferImageCopy* pRegions);
        [Slot(24)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdCopyQueryPoolResults([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr destStride, [InAttribute, OutAttribute] System.Int32 flags);
        [Slot(25)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdDispatch([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint x, [InAttribute, OutAttribute] uint y, [InAttribute, OutAttribute] uint z);
        [Slot(26)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdDispatchIndirect([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset);
        [Slot(27)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdDraw([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint firstVertex, [InAttribute, OutAttribute] uint vertexCount, [InAttribute, OutAttribute] uint firstInstance, [InAttribute, OutAttribute] uint instanceCount);
        [Slot(28)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdDrawIndexed([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint firstIndex, [InAttribute, OutAttribute] uint indexCount, [InAttribute, OutAttribute] int vertexOffset, [InAttribute, OutAttribute] uint firstInstance, [InAttribute, OutAttribute] uint instanceCount);
        [Slot(29)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdDrawIndexedIndirect([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] uint stride);
        [Slot(30)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdDrawIndirect([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] uint stride);
        [Slot(31)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdEndQuery([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint slot);
        [Slot(32)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdEndRenderPass([InAttribute, OutAttribute] CmdBuffer cmdBuffer);
        [Slot(33)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdExecuteCommands([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint cmdBuffersCount, [InAttribute, OutAttribute] CmdBuffer* pCmdBuffers);
        [Slot(34)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdFillBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr fillSize, [InAttribute, OutAttribute] uint data);
        [Slot(35)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdNextSubpass([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] System.Int32 contents);
        [Slot(36)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdPipelineBarrier([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] System.Int32 srcStageMask, [InAttribute, OutAttribute] System.Int32 destStageMask, [InAttribute, OutAttribute] bool byRegion, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers);
        [Slot(37)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdPushConstants([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] PipelineLayout layout, [InAttribute, OutAttribute] System.Int32 stageFlags, [InAttribute, OutAttribute] uint start, [InAttribute, OutAttribute] uint length, [InAttribute, OutAttribute] IntPtr values);
        [Slot(38)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdResetEvent([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Event @event, [InAttribute, OutAttribute] System.Int32 stageMask);
        [Slot(39)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdResetQueryPool([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount);
        [Slot(40)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdResolveImage([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Image srcImage, [InAttribute, OutAttribute] System.Int32 srcImageLayout, [InAttribute, OutAttribute] Image destImage, [InAttribute, OutAttribute] System.Int32 destImageLayout, [InAttribute, OutAttribute] uint regionCount, [InAttribute, OutAttribute] ImageResolve* pRegions);
        [Slot(41)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdSetEvent([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Event @event, [InAttribute, OutAttribute] System.Int32 stageMask);
        [Slot(42)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdUpdateBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset, [InAttribute, OutAttribute] IntPtr dataSize, [InAttribute, OutAttribute] uint* pData);
        [Slot(43)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe void vkCmdWaitEvents([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] uint eventCount, [InAttribute, OutAttribute] Event* pEvents, [InAttribute, OutAttribute] System.Int32 srcStageMask, [InAttribute, OutAttribute] System.Int32 destStageMask, [InAttribute, OutAttribute] uint memBarrierCount, [InAttribute, OutAttribute] IntPtr ppMemBarriers);
        [Slot(44)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern void vkCmdWriteTimestamp([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] System.Int32 timestampType, [InAttribute, OutAttribute] Buffer destBuffer, [InAttribute, OutAttribute] IntPtr destOffset);
        [Slot(45)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateAttachmentView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] AttachmentViewCreateInfo* pCreateInfo, [InAttribute, OutAttribute] AttachmentView* pView);
        [Slot(46)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] BufferCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Buffer* pBuffer);
        [Slot(47)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateBufferView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] BufferViewCreateInfo* pCreateInfo, [InAttribute, OutAttribute] BufferView* pView);
        [Slot(48)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateCommandBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdBufferCreateInfo* pCreateInfo, [InAttribute, OutAttribute] CmdBuffer* pCmdBuffer);
        [Slot(49)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateCommandPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdPoolCreateInfo* pCreateInfo, [InAttribute, OutAttribute] CmdPool* pCmdPool);
        [Slot(50)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateComputePipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] ComputePipelineCreateInfo* pCreateInfos, [InAttribute, OutAttribute] Pipeline* pPipelines);
        [Slot(51)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] System.Int32 poolUsage, [InAttribute, OutAttribute] uint maxSets, [InAttribute, OutAttribute] DescriptorPoolCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DescriptorPool* pDescriptorPool);
        [Slot(52)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateDescriptorSetLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorSetLayoutCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DescriptorSetLayout* pSetLayout);
        [Slot(53)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateDevice([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] DeviceCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Device* pDevice);
        [Slot(54)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateDynamicColorBlendState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicColorBlendStateCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DynamicColorBlendState* pState);
        [Slot(55)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateDynamicDepthStencilState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicDepthStencilStateCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DynamicDepthStencilState* pState);
        [Slot(56)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateDynamicRasterState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicRasterStateCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DynamicRasterState* pState);
        [Slot(57)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateDynamicViewportState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicViewportStateCreateInfo* pCreateInfo, [InAttribute, OutAttribute] DynamicViewportState* pState);
        [Slot(58)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] EventCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Event* pEvent);
        [Slot(59)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateFence([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] FenceCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Fence* pFence);
        [Slot(60)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] FramebufferCreateInfo* pCreateInfo, [InAttribute, OutAttribute] UInt32* pFramebuffer);
        [Slot(61)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateGraphicsPipelines([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] GraphicsPipelineCreateInfo* pCreateInfos, [InAttribute, OutAttribute] Pipeline* pPipelines);
        [Slot(62)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateImage([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ImageCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Image* pImage);
        [Slot(63)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateImageView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ImageViewCreateInfo* pCreateInfo, [InAttribute, OutAttribute] ImageView* pView);
        [Slot(64)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateInstance([InAttribute, OutAttribute] InstanceCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Instance* pInstance);
        [Slot(65)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreatePipelineCache([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCacheCreateInfo* pCreateInfo, [InAttribute, OutAttribute] PipelineCache* pPipelineCache);
        [Slot(66)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreatePipelineLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineLayoutCreateInfo* pCreateInfo, [InAttribute, OutAttribute] PipelineLayout* pPipelineLayout);
        [Slot(67)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateQueryPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPoolCreateInfo* pCreateInfo, [InAttribute, OutAttribute] QueryPool* pQueryPool);
        [Slot(68)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateRenderPass([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPassCreateInfo* pCreateInfo, [InAttribute, OutAttribute] RenderPass* pRenderPass);
        [Slot(69)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateSampler([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] SamplerCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Sampler* pSampler);
        [Slot(70)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateSemaphore([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] SemaphoreCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Semaphore* pSemaphore);
        [Slot(71)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateShader([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ShaderCreateInfo* pCreateInfo, [InAttribute, OutAttribute] Shader* pShader);
        [Slot(72)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkCreateShaderModule([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ShaderModuleCreateInfo* pCreateInfo, [InAttribute, OutAttribute] ShaderModule* pShaderModule);
        [Slot(73)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyAttachmentView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] AttachmentView attachmentView);
        [Slot(74)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Buffer buffer);
        [Slot(75)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyBufferView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] BufferView bufferView);
        [Slot(76)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyCommandBuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdBuffer commandBuffer);
        [Slot(77)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyCommandPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdPool cmdPool);
        [Slot(78)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool);
        [Slot(79)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyDescriptorSetLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorSetLayout descriptorSetLayout);
        [Slot(80)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyDevice([InAttribute, OutAttribute] Device device);
        [Slot(81)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyDynamicColorBlendState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicColorBlendState dynamicColorBlendState);
        [Slot(82)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyDynamicDepthStencilState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicDepthStencilState dynamicDepthStencilState);
        [Slot(83)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyDynamicRasterState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicRasterState dynamicRasterState);
        [Slot(84)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyDynamicViewportState([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DynamicViewportState dynamicViewportState);
        [Slot(85)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Event @event);
        [Slot(86)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyFence([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Fence fence);
        [Slot(87)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyFramebuffer([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] UInt32 framebuffer);
        [Slot(88)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyImage([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image);
        [Slot(89)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyImageView([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ImageView imageView);
        [Slot(90)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyInstance([InAttribute, OutAttribute] Instance instance);
        [Slot(91)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyPipeline([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Pipeline pipeline);
        [Slot(92)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyPipelineCache([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache);
        [Slot(93)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyPipelineLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineLayout pipelineLayout);
        [Slot(94)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyQueryPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool);
        [Slot(95)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyRenderPass([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPass renderPass);
        [Slot(96)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroySampler([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Sampler sampler);
        [Slot(97)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroySemaphore([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Semaphore semaphore);
        [Slot(98)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyShader([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Shader shader);
        [Slot(99)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDestroyShaderModule([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] ShaderModule shaderModule);
        [Slot(100)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkDeviceWaitIdle([InAttribute, OutAttribute] Device device);
        [Slot(101)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkEndCommandBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer);
        [Slot(102)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkEnumeratePhysicalDevices([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] uint* pPhysicalDeviceCount, [InAttribute, OutAttribute] PhysicalDevice* pPhysicalDevices);
        [Slot(103)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkFlushMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange* pMemRanges);
        [Slot(104)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkFreeDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool, [InAttribute, OutAttribute] uint count, [InAttribute, OutAttribute] DescriptorSet* pDescriptorSets);
        [Slot(105)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkFreeMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem);
        [Slot(106)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetBufferMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] MemoryRequirements* pMemoryRequirements);
        [Slot(107)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetDeviceMemoryCommitment([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory memory, [InAttribute, OutAttribute] IntPtr* pCommittedMemoryInBytes);
        [Slot(108)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern PFN_vkVoidFunction vkGetDeviceProcAddr([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] IntPtr pName);
        [Slot(109)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetDeviceQueue([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint queueFamilyIndex, [InAttribute, OutAttribute] uint queueIndex, [InAttribute, OutAttribute] Queue* pQueue);
        [Slot(110)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkGetEventStatus([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Event @event);
        [Slot(111)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkGetFenceStatus([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Fence fence);
        [Slot(112)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetGlobalExtensionProperties([InAttribute, OutAttribute] IntPtr pLayerName, [InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] ExtensionProperties* pProperties);
        [Slot(113)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetGlobalLayerProperties([InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] LayerProperties* pProperties);
        [Slot(114)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetImageMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] MemoryRequirements* pMemoryRequirements);
        [Slot(115)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetImageSparseMemoryRequirements([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint* pNumRequirements, [InAttribute, OutAttribute] SparseImageMemoryRequirements* pSparseMemoryRequirements);
        [Slot(116)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetImageSubresourceLayout([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] ImageSubresource* pSubresource, [InAttribute, OutAttribute] SubresourceLayout* pLayout);
        [Slot(117)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern PFN_vkVoidFunction vkGetInstanceProcAddr([InAttribute, OutAttribute] Instance instance, [InAttribute, OutAttribute] IntPtr pName);
        [Slot(118)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceExtensionProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] IntPtr pLayerName, [InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] ExtensionProperties* pProperties);
        [Slot(119)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceFeatures([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceFeatures* pFeatures);
        [Slot(120)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] System.Int32 format, [InAttribute, OutAttribute] FormatProperties* pFormatProperties);
        [Slot(121)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] System.Int32 format, [InAttribute, OutAttribute] System.Int32 type, [InAttribute, OutAttribute] System.Int32 tiling, [InAttribute, OutAttribute] System.Int32 usage, [InAttribute, OutAttribute] ImageFormatProperties* pImageFormatProperties);
        [Slot(122)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceLayerProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] LayerProperties* pProperties);
        [Slot(123)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceLimits([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceLimits* pLimits);
        [Slot(124)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceMemoryProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceMemoryProperties* pMemoryProperties);
        [Slot(125)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] PhysicalDeviceProperties* pProperties);
        [Slot(126)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceQueueFamilyProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] uint* pCount, [InAttribute, OutAttribute] QueueFamilyProperties* pQueueFamilyProperties);
        [Slot(127)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetPhysicalDeviceSparseImageFormatProperties([InAttribute, OutAttribute] PhysicalDevice physicalDevice, [InAttribute, OutAttribute] System.Int32 format, [InAttribute, OutAttribute] System.Int32 type, [InAttribute, OutAttribute] uint samples, [InAttribute, OutAttribute] System.Int32 usage, [InAttribute, OutAttribute] System.Int32 tiling, [InAttribute, OutAttribute] uint* pNumProperties, [InAttribute, OutAttribute] SparseImageFormatProperties* pProperties);
        [Slot(128)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern VkResult vkGetPipelineCacheData([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache, [InAttribute, OutAttribute] IntPtr pData);
        [Slot(129)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern IntPtr vkGetPipelineCacheSize([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache pipelineCache);
        [Slot(130)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetQueryPoolResults([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] QueryPool queryPool, [InAttribute, OutAttribute] uint startQuery, [InAttribute, OutAttribute] uint queryCount, [InAttribute, OutAttribute] IntPtr* pDataSize, [InAttribute, OutAttribute] IntPtr pData, [InAttribute, OutAttribute] System.Int32 flags);
        [Slot(131)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkGetRenderAreaGranularity([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] RenderPass renderPass, [InAttribute, OutAttribute] Extent2D* pGranularity);
        [Slot(132)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkInvalidateMappedMemoryRanges([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint memRangeCount, [InAttribute, OutAttribute] MappedMemoryRange* pMemRanges);
        [Slot(133)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkMapMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem, [InAttribute, OutAttribute] IntPtr offset, [InAttribute, OutAttribute] IntPtr size, [InAttribute, OutAttribute] MemoryMapFlags flags, [InAttribute, OutAttribute] IntPtr ppData);
        [Slot(134)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe VkResult vkMergePipelineCaches([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] PipelineCache destCache, [InAttribute, OutAttribute] uint srcCacheCount, [InAttribute, OutAttribute] PipelineCache* pSrcCaches);
        [Slot(135)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkQueueBindSparseBufferMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Buffer buffer, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo* pBindInfo);
        [Slot(136)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkQueueBindSparseImageMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseImageMemoryBindInfo* pBindInfo);
        [Slot(137)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkQueueBindSparseImageOpaqueMemory([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Image image, [InAttribute, OutAttribute] uint numBindings, [InAttribute, OutAttribute] SparseMemoryBindInfo* pBindInfo);
        [Slot(138)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkQueueSignalSemaphore([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Semaphore semaphore);
        [Slot(139)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkQueueSubmit([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] uint cmdBufferCount, [InAttribute, OutAttribute] CmdBuffer* pCmdBuffers, [InAttribute, OutAttribute] Fence fence);
        [Slot(140)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkQueueWaitIdle([InAttribute, OutAttribute] Queue queue);
        [Slot(141)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkQueueWaitSemaphore([InAttribute, OutAttribute] Queue queue, [InAttribute, OutAttribute] Semaphore semaphore);
        [Slot(142)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkResetCommandBuffer([InAttribute, OutAttribute] CmdBuffer cmdBuffer, [InAttribute, OutAttribute] System.Int32 flags);
        [Slot(143)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkResetCommandPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] CmdPool cmdPool, [InAttribute, OutAttribute] System.Int32 flags);
        [Slot(144)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkResetDescriptorPool([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DescriptorPool descriptorPool);
        [Slot(145)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkResetEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Event @event);
        [Slot(146)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkResetFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint fenceCount, [InAttribute, OutAttribute] Fence* pFences);
        [Slot(147)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkSetEvent([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] Event @event);
        [Slot(148)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern System.Int32 vkUnmapMemory([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] DeviceMemory mem);
        [Slot(149)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkUpdateDescriptorSets([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint writeCount, [InAttribute, OutAttribute] WriteDescriptorSet* pDescriptorWrites, [InAttribute, OutAttribute] uint copyCount, [InAttribute, OutAttribute] CopyDescriptorSet* pDescriptorCopies);
        [Slot(150)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        static extern unsafe System.Int32 vkWaitForFences([InAttribute, OutAttribute] Device device, [InAttribute, OutAttribute] uint fenceCount, [InAttribute, OutAttribute] Fence* pFences, [InAttribute, OutAttribute] bool waitAll, [InAttribute, OutAttribute] ulong timeout);
    }
}
