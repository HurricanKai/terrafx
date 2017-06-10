// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Unknown;

namespace TerraFX.Interop.DXGI
{
    [Guid("00CDDEA8-939B-4B83-A340-A685226666CC")]
    unsafe public struct IDXGIOutput1
    {
        #region Fields
        public void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        public /* static */ delegate HRESULT GetDisplayModeList1(
            [In] IDXGIOutput1* This,
            [In] DXGI_FORMAT EnumFormat,
            [In] DXGI_ENUM_MODES Flags,
            [In, Out] uint* pNumModes,
            [Out, Optional] DXGI_MODE_DESC1* pDesc
        );

        public /* static */ delegate HRESULT FindClosestMatchingMode1(
            [In] IDXGIOutput1* This,
            [In] DXGI_MODE_DESC1* pModeToMatch,
            [Out] DXGI_MODE_DESC1* pClosestMatch,
            [In, Optional] IUnknown* pConcernedDevice
        );

        public /* static */ delegate HRESULT GetDisplaySurfaceData1(
            [In] IDXGIOutput1* This,
            [In] IDXGIResource* pDestination
        );

        public /* static */ delegate HRESULT DuplicateOutput(
            [In] IDXGIOutput1* This,
            [In] IUnknown* pDevice,
            [Out] IDXGIOutputDuplication** ppOutputDuplication
        );
        #endregion

        #region Structs
        public struct Vtbl
        {
            #region Fields
            public IUnknown.QueryInterface QueryInterface;

            public IUnknown.AddRef AddRef;

            public IUnknown.Release Release;

            public IDXGIObject.SetPrivateData SetPrivateData;

            public IDXGIObject.SetPrivateDataInterface SetPrivateDataInterface;

            public IDXGIObject.GetPrivateData GetPrivateData;

            public IDXGIObject.GetParent GetParent;

            public IDXGIOutput.GetDesc GetDesc;

            public IDXGIOutput.GetDisplayModeList GetDisplayModeList;

            public IDXGIOutput.FindClosestMatchingMode FindClosestMatchingMode;

            public IDXGIOutput.WaitForVBlank WaitForVBlank;

            public IDXGIOutput.TakeOwnership TakeOwnership;

            public IDXGIOutput.ReleaseOwnership ReleaseOwnership;

            public IDXGIOutput.GetGammaControlCapabilities GetGammaControlCapabilities;

            public IDXGIOutput.SetGammaControl SetGammaControl;

            public IDXGIOutput.GetGammaControl GetGammaControl;

            public IDXGIOutput.SetDisplaySurface SetDisplaySurface;

            public IDXGIOutput.GetDisplaySurfaceData GetDisplaySurfaceData;

            public IDXGIOutput.GetFrameStatistics GetFrameStatistics;

            public GetDisplayModeList1 GetDisplayModeList1;

            public FindClosestMatchingMode1 FindClosestMatchingMode1;

            public GetDisplaySurfaceData1 GetDisplaySurfaceData1;

            public DuplicateOutput DuplicateOutput;
            #endregion
        }
        #endregion
    }
}