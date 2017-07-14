// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Paints an area with a radial gradient.</summary>
    [Guid("2CD906AC-12E2-11DC-9FED-001143A055F9")]
    unsafe public /* blittable */ struct ID2D1RadialGradientBrush
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        /// <summary>Sets the center of the radial gradient. This will be in local coordinates and will not depend on the geometry being filled.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void SetCenter(
            [In] ID2D1RadialGradientBrush* This,
            [In] D2D1_POINT_2F center
        );

        /// <summary>Sets offset of the origin relative to the radial gradient center.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void SetGradientOriginOffset(
            [In] ID2D1RadialGradientBrush* This,
            [In] D2D1_POINT_2F gradientOriginOffset
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void SetRadiusX(
            [In] ID2D1RadialGradientBrush* This,
            [In] FLOAT radiusX
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void SetRadiusY(
            [In] ID2D1RadialGradientBrush* This,
            [In] FLOAT radiusY
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_POINT_2F GetCenter(
            [In] ID2D1RadialGradientBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_POINT_2F GetGradientOriginOffset(
            [In] ID2D1RadialGradientBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate FLOAT GetRadiusX(
            [In] ID2D1RadialGradientBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate FLOAT GetRadiusY(
            [In] ID2D1RadialGradientBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void GetGradientStopCollection(
            [In] ID2D1RadialGradientBrush* This,
            [Out] ID2D1GradientStopCollection** gradientStopCollection
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public ID2D1Brush.Vtbl BaseVtbl;

            public SetCenter SetCenter;

            public SetGradientOriginOffset SetGradientOriginOffset;

            public SetRadiusX SetRadiusX;

            public SetRadiusY SetRadiusY;

            public GetCenter GetCenter;

            public GetGradientOriginOffset GetGradientOriginOffset;

            public GetRadiusX GetRadiusX;

            public GetRadiusY GetRadiusY;

            public GetGradientStopCollection GetGradientStopCollection;
            #endregion
        }
        #endregion
    }
}