// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* blittable */ unsafe struct D3D12_INPUT_LAYOUT_DESC
    {
        #region Fields
        [ComAliasName("D3D12_INPUT_ELEMENT_DESC[]")]
        public D3D12_INPUT_ELEMENT_DESC* pInputElementDescs;

        [ComAliasName("UINT")]
        public uint NumElements;
        #endregion
    }
}