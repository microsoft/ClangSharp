// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using ClangSharp.Interop;

namespace ClangSharp
{
    public sealed class CXXBoolLiteralExpr : Expr
    {
        internal CXXBoolLiteralExpr(CXCursor handle) : base(handle, CXCursorKind.CXCursor_CXXBoolLiteralExpr, CX_StmtClass.CX_StmtClass_CXXBoolLiteralExpr)
        {
        }

        public bool Value => Handle.CXXBoolLiteralExprValue;
    }
}
