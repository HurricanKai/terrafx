// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    unsafe public /* blittable */ struct FUNCDESC
    {
        #region Fields
        public MEMBERID memid;

        public SCODE* lprgscode;

        public ELEMDESC* lprgelemdescParam;

        public FUNCKIND funckind;

        public INVOKEKIND invkind;

        public CALLCONV callconv;

        public SHORT cParams;

        public SHORT cParamsOpt;

        public SHORT oVft;

        public SHORT cScodes;

        public ELEMDESC elemdescFunc;

        public WORD wFuncFlags;
        #endregion
    }
}