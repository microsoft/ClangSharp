﻿namespace ClangSharp
{
    internal class TemplateDecl : NamedDecl
    {
        protected TemplateDecl(CXCursor handle, Cursor parent) : base(handle, parent)
        {
        }
    }
}
