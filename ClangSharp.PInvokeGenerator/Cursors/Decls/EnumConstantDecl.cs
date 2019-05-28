﻿using System.Diagnostics;

namespace ClangSharp
{
    internal sealed class EnumConstantDecl : ValueDecl
    {
        private Expr _initExpr;

        public EnumConstantDecl(CXCursor handle, Cursor parent) : base(handle, parent)
        {
            Debug.Assert(handle.Kind == CXCursorKind.CXCursor_EnumConstantDecl);
        }

        public Expr InitExpr => _initExpr;

        public long InitVal => Handle.EnumConstantDeclValue;

        public ulong UnsignedInitVal => Handle.EnumConstantDeclUnsignedValue;

        protected override CXChildVisitResult VisitChildren(CXCursor childHandle, CXCursor handle, CXClientData clientData)
        {
            ValidateVisit(ref handle);

            if (childHandle.IsExpression)
            {
                var expr = GetOrAddChild<Expr>(childHandle);

                Debug.Assert(_initExpr is null);
                _initExpr = expr;

                return expr.Visit(clientData);
            }

            return base.VisitChildren(childHandle, handle, clientData);
        }
    }
}
