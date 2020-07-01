// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using ClangSharp.Interop;

namespace ClangSharp
{
    public sealed class CharacterLiteral : Expr
    {
        internal CharacterLiteral(CXCursor handle) : base(handle, CXCursorKind.CXCursor_CharacterLiteral, CX_StmtClass.CX_StmtClass_CharacterLiteral)
        {
        }

        public CX_CharacterKind Kind => Handle.CharacterLiteralKind;

        public uint Value => Handle.CharacterLiteralValue;
    }
}
