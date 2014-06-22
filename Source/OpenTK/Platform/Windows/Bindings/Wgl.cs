#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2013 Stefanos Apostolopoulos
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
using System.Runtime.InteropServices;
using System.Security;

namespace OpenTK.Platform.Windows
{
#pragma warning disable 3019
#pragma warning disable 1591

    partial class Wgl
    {
        static Wgl()
        {
            EntryPointNames = new string[]
            {
                "wglCreateContextAttribsARB",
                "wglGetExtensionsStringARB",
                "wglGetPixelFormatAttribivARB",
                "wglGetPixelFormatAttribfvARB",
                "wglChoosePixelFormatARB",
                "wglMakeContextCurrentARB",
                "wglGetCurrentReadDCARB",
                "wglCreatePbufferARB",
                "wglGetPbufferDCARB",
                "wglReleasePbufferDCARB",
                "wglDestroyPbufferARB",
                "wglQueryPbufferARB",
                "wglBindTexImageARB",
                "wglReleaseTexImageARB",
                "wglSetPbufferAttribARB",
                "wglGetExtensionsStringEXT",
                "wglSwapIntervalEXT",
                "wglGetSwapIntervalEXT",
            };
            EntryPoints = new IntPtr[EntryPointNames.Length];
        }

        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglCreateContext", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr CreateContext(IntPtr hDc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglDeleteContext", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean DeleteContext(IntPtr oldContext);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetCurrentContext", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr GetCurrentContext();
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglMakeCurrent", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglChoosePixelFormat", ExactSpelling = true, SetLastError = true)]
        internal extern static unsafe int ChoosePixelFormat(IntPtr hDc, ref PixelFormatDescriptor pPfd);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglDescribePixelFormat", ExactSpelling = true, SetLastError = true)]
        internal extern static unsafe int DescribePixelFormat(IntPtr hdc, int ipfd, int cjpfd, ref PixelFormatDescriptor ppfd);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetCurrentDC", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr GetCurrentDC();
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr GetProcAddress(String lpszProc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetProcAddress", ExactSpelling = true, SetLastError = true)]
        internal extern static IntPtr GetProcAddress(IntPtr lpszProc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglGetPixelFormat", ExactSpelling = true, SetLastError = true)]
        internal extern static int GetPixelFormat(IntPtr hdc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglSetPixelFormat", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean SetPixelFormat(IntPtr hdc, int ipfd, ref PixelFormatDescriptor ppfd);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglSwapBuffers", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean SwapBuffers(IntPtr hdc);
        [SuppressUnmanagedCodeSecurity]
        [DllImport(Wgl.Library, EntryPoint = "wglShareLists", ExactSpelling = true, SetLastError = true)]
        internal extern static Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);

        public static partial class Arb
        {
            [AutoGenerated(EntryPoint = "wglCreateContextAttribsARB")]
            public static
            IntPtr CreateContextAttribs(IntPtr hDC, IntPtr hShareContext, int[] attribList)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.DeclareLocal("System.Int32& pinned", "attribList_pinned");
                if (attribList != null && attribList.Length != 0)
                {
                    Silk.Cil.Load(attribList);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("attribList_pinned");
                }
                Silk.Cil.LoadByName("attribList_pinned");
                Silk.Cil.Conv_I();
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(0);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglGetExtensionsStringARB")]
            public static
            string GetExtensionsString(IntPtr hdc)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(1);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(IntPtr), typeof(IntPtr));
                return Marshal.PtrToStringAnsi(Silk.Cil.Peek<IntPtr>());
            }

            [AutoGenerated(EntryPoint = "wglGetPixelFormatAttribivARB")]
            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, int[] piAttributes, [Out] int[] piValues)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttributes_pinned");
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piValues_pinned");
                if (piAttributes != null && piAttributes.Length != 0)
                {
                    Silk.Cil.Load(piAttributes);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("piAttributes_pinned");

                    piValues = new int[piAttributes.Length];
                    Silk.Cil.Load(piValues);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("piValues_pinned");
                }

                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Ldarg(2);
                Silk.Cil.Ldarg(3);
                Silk.Cil.LoadByName("piAttributes_pinned");
                Silk.Cil.Conv_I();
                Silk.Cil.LoadByName("piValues_pinned");
                Silk.Cil.Conv_I();
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(2);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int), typeof(int), typeof(Int32), typeof(int*), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglGetPixelFormatAttribivARB")]
            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] out int piValues)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttributes_pinned");
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piValues_pinned");
                if (piAttributes != null)
                {
                    Silk.Cil.LoadByName("piAttributes");
                    Silk.Cil.StoreByName("piAttributes_pinned");

                    Silk.Cil.LoadByName("piValues");
                    Silk.Cil.StoreByName("piValues_pinned");
                }

                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Ldarg(2);
                Silk.Cil.Ldarg(3);
                Silk.Cil.LoadByName("piAttributes_pinned");
                Silk.Cil.Conv_I();
                Silk.Cil.LoadByName("piValues_pinned");
                Silk.Cil.Conv_I();
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(2);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int), typeof(int), typeof(Int32), typeof(int*), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglGetPixelFormatAttribfvARB")]
            [System.CLSCompliant(false)]
            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes, int[] piAttributes, [Out] Single[] pfValues)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttributes_pinned");
                Silk.Cil.DeclareLocal("System.Int32& pinned", "pfValues_pinned");
                if (piAttributes != null && piAttributes.Length != 0)
                {
                    Silk.Cil.Load(piAttributes);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("piAttributes_pinned");

                    pfValues = new float[piAttributes.Length];
                    Silk.Cil.Load(pfValues);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("pfValues_pinned");
                }

                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Ldarg(2);
                Silk.Cil.Ldarg(3);
                Silk.Cil.LoadByName("piAttributes_pinned");
                Silk.Cil.Conv_I();
                Silk.Cil.LoadByName("pfValues_pinned");
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(3);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int), typeof(int), typeof(Int32), typeof(int*), typeof(float*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglGetPixelFormatAttribfvARB")]
            public static
            Boolean GetPixelFormatAttrib(IntPtr hdc, int iPixelFormat, int iLayerPlane, Int32 nAttributes, ref int piAttributes, [Out] out Single pfValues)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttributes_pinned");
                Silk.Cil.DeclareLocal("System.Int32& pinned", "pfValues_pinned");

                Silk.Cil.LoadByName("piAttributes");
                Silk.Cil.StoreByName("piAttributes_pinned");

                Silk.Cil.LoadByName("pfValues");
                Silk.Cil.StoreByName("pfValues_pinned");

                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Ldarg(2);
                Silk.Cil.Ldarg(3);
                Silk.Cil.LoadByName("piAttributes_pinned");
                Silk.Cil.Conv_I();
                Silk.Cil.LoadByName("pfValues_pinned");
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(3);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int), typeof(int), typeof(Int32), typeof(int*), typeof(float*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglChoosePixelFormatARB")]
            public static
            Boolean ChoosePixelFormat(IntPtr hdc, int[] piAttribIList, Single[] pfAttribFList, Int32 nMaxFormats, [Out] int[] piFormats, out int nNumFormats)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttribIList_pinned");
                Silk.Cil.DeclareLocal("System.Single& pinned", "pfAttribFList_pinned");
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piFormats_pinned");
                Silk.Cil.DeclareLocal("System.Int32& pinned", "nNumFormats_pinned");

                if (piAttribIList != null && piAttribIList.Length != 0)
                {
                    Silk.Cil.Load(piAttribIList);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("piAttribIList_pinned");
                }

                if (pfAttribFList != null && pfAttribFList.Length != 0)
                {
                    Silk.Cil.Load(pfAttribFList);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("pfAttribFList_pinned");
                }

                if (piFormats != null && piFormats.Length != 0)
                {
                    Silk.Cil.Load(piFormats);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("piFormats_pinned");
                }

                Silk.Cil.LoadByName("nNumFormats");
                Silk.Cil.StoreByName("nNumFormats_pinned");

                Silk.Cil.Ldarg(0);
                Silk.Cil.LoadByName("piAttribIList_pinned");
                Silk.Cil.LoadByName("pfAttribFList_pinned");
                Silk.Cil.Ldarg(3);
                Silk.Cil.LoadByName("piFormats_pinned");
                Silk.Cil.LoadByName("nNumFormats_pinned");

                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(4);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int*), typeof(Single*), typeof(UInt32), typeof(int*), typeof(UInt32*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglChoosePixelFormatARB")]
            public static
            Boolean ChoosePixelFormat(IntPtr hdc, ref int piAttribIList, ref Single pfAttribFList, Int32 nMaxFormats, [Out] out int piFormats, [Out] out Int32 nNumFormats)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttribIList_pinned");
                Silk.Cil.DeclareLocal("System.Single& pinned", "pfAttribFList_pinned");
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piFormats_pinned");
                Silk.Cil.DeclareLocal("System.Int32& pinned", "nNumFormats_pinned");


                Silk.Cil.LoadByName("piAttribIList");
                Silk.Cil.StoreByName("piAttribIList_pinned");

                Silk.Cil.LoadByName("pfAttribFList");
                Silk.Cil.StoreByName("pfAttribFList_pinned");

                Silk.Cil.LoadByName("piFormats");
                Silk.Cil.StoreByName("piFormats_pinned");

                Silk.Cil.LoadByName("nNumFormats");
                Silk.Cil.StoreByName("nNumFormats_pinned");

                Silk.Cil.Ldarg(0);
                Silk.Cil.LoadByName("piAttribIList_pinned");
                Silk.Cil.LoadByName("pfAttribFList_pinned");
                Silk.Cil.Ldarg(3);
                Silk.Cil.LoadByName("piFormats_pinned");
                Silk.Cil.LoadByName("nNumFormats_pinned");

                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(4);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int*), typeof(Single*), typeof(UInt32), typeof(int*), typeof(UInt32*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglMakeContextCurrentARB")]
            public static
            Boolean MakeContextCurrent(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Ldarg(2);
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(5);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglGetCurrentReadDCARB")]
            public static
            IntPtr GetCurrentReadDC()
            {
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(6);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(IntPtr));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglCreatePbufferARB")]
            public static
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttribList_pinned");

                if (piAttribList != null && piAttribList.Length != 0)
                {
                    Silk.Cil.Load(piAttribList);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("piAttribList_pinned");
                }

                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Ldarg(2);
                Silk.Cil.Ldarg(3);
                Silk.Cil.LoadByName("piAttribList_pinned");

                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(7);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(IntPtr), typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglCreatePbufferARB")]
            public static
            IntPtr CreatePbuffer(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttribList_pinned");

                Silk.Cil.LoadByName("piAttribList");
                Silk.Cil.StoreByName("piAttribList_pinned");

                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Ldarg(2);
                Silk.Cil.Ldarg(3);
                Silk.Cil.LoadByName("piAttribList_pinned");

                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(7);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(IntPtr), typeof(IntPtr), typeof(int), typeof(int), typeof(int), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglGetPbufferDCARB")]
            public static
            IntPtr GetPbufferDC(IntPtr hPbuffer)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(8);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(IntPtr), typeof(IntPtr));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglReleasePbufferDCARB")]
            public static
            int ReleasePbufferDC(IntPtr hPbuffer, IntPtr hDC)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(9);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(int), typeof(IntPtr), typeof(IntPtr));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglDestroyPbufferARB")]
            public static
            Boolean DestroyPbuffer(IntPtr hPbuffer)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(10);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglQueryPbufferARB")]
            public static
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] int[] piValue)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piValue_pinned");

                if (piValue != null && piValue.Length != 0)
                {
                    Silk.Cil.Load(piValue);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("piValue_pinned");
                }

                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.LoadByName("piValue_pinned");
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(11);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglQueryPbufferARB")]
            public static
            Boolean QueryPbuffer(IntPtr hPbuffer, int iAttribute, [Out] out int piValue)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piValue_pinned");

                Silk.Cil.LoadByName("piValue");
                Silk.Cil.StoreByName("piValue_pinned");

                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.LoadByName("piValue_pinned");
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(11);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglBindTexImageARB")]
            public static
            Boolean BindTexImage(IntPtr hPbuffer, int iBuffer)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(12);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglReleaseTexImageARB")]
            public static
            Boolean ReleaseTexImage(IntPtr hPbuffer, int iBuffer)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Ldarg(1);
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(13);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglSetPbufferAttribARB")]
            public static
            Boolean SetPbufferAttrib(IntPtr hPbuffer, int[] piAttribList)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttribList_pinned");

                if (piAttribList != null && piAttribList.Length != 0)
                {
                    Silk.Cil.Load(piAttribList);
                    Silk.Cil.Ldc_I4(0);
                    Silk.Cil.Ldelema<int>();
                    Silk.Cil.StoreByName("piAttribList_pinned");
                }

                Silk.Cil.Ldarg(0);
                Silk.Cil.LoadByName("piAttribList_pinned");
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(14);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }

            [AutoGenerated(EntryPoint = "wglSetPbufferAttribARB")]
            public static
            Boolean SetPbufferAttrib(IntPtr hPbuffer, ref int piAttribList)
            {
                Silk.Cil.DeclareLocal("System.Int32& pinned", "piAttribList_pinned");

                Silk.Cil.LoadByName("piAttribList");
                Silk.Cil.StoreByName("piAttribList_pinned");

                Silk.Cil.Ldarg(0);
                Silk.Cil.LoadByName("piAttribList_pinned");
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(14);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(IntPtr), typeof(int*));
                Silk.Cil.Ret();
                throw new NotImplementedException();
            }
        }

        public static partial class Ext
        {
            [AutoGenerated(EntryPoint = "wglGetExtensionsStringEXT")]
            public static
            string GetExtensionsString()
            {
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(15);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(IntPtr));
                return Marshal.PtrToStringAnsi(Silk.Cil.Peek<IntPtr>());
            }

            [AutoGenerated(EntryPoint = "wglSwapIntervalEXT")]
            public static
            Boolean SwapInterval(int interval)
            {
                Silk.Cil.Ldarg(0);
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(16);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(Boolean), typeof(int));
                return Silk.Cil.Peek<Boolean>();
            }

            [AutoGenerated(EntryPoint = "wglGetSwapIntervalEXT")]
            public static
            int GetSwapInterval()
            {
                Silk.Cil.Load(EntryPoints);
                Silk.Cil.Ldc_I4(17);
                Silk.Cil.Ldelem_I();
                Silk.Cil.Calli(CallingConvention.Winapi, typeof(int));
                return Silk.Cil.Peek<int>();
            }
        }
    }
}
