// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("2411E7E1-12AC-4CCF-BD14-9798E8534DC0")]
    unsafe public /* blittable */ struct IDXGIAdapter
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT EnumOutputs(
            [In] IDXGIAdapter* This,
            [In] UINT Output,
            [In, Out] IDXGIOutput** ppOutput
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT GetDesc(
            [In] IDXGIAdapter* This,
            [Out] DXGI_ADAPTER_DESC* pDesc
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CheckInterfaceSupport(
            [In] IDXGIAdapter* This,
            [In] REFGUID InterfaceName,
            [Out] LARGE_INTEGER* pUMDVersion
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public IDXGIObject.Vtbl BaseVtbl;

            public EnumOutputs EnumOutputs;

            public GetDesc GetDesc;

            public CheckInterfaceSupport CheckInterfaceSupport;
            #endregion
        }
        #endregion
    }
}