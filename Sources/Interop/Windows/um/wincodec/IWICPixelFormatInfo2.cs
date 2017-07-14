// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("A9DB33A2-AF5F-43C7-B679-74F5984B5AA4")]
    unsafe public /* blittable */ struct IWICPixelFormatInfo2
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SupportsTransparency(
            [In] IWICPixelFormatInfo2* This,
            [Out] BOOL* pfSupportsTransparency
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT GetNumericRepresentation(
            [In] IWICPixelFormatInfo2* This,
            [Out] WICPixelFormatNumericRepresentation* pNumericRepresentation
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public IWICPixelFormatInfo.Vtbl BaseVtbl;

            public SupportsTransparency SupportsTransparency;

            public GetNumericRepresentation GetNumericRepresentation;
            #endregion
        }
        #endregion
    }
}