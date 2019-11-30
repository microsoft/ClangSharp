// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

namespace ClangSharp
{
    public partial class PInvokeGenerator
    {
        private void VisitRef(Ref @ref)
        {
            AddDiagnostic(DiagnosticLevel.Error, $"Unsupported reference: '{@ref.CursorKindSpelling}'. Generated bindings may be incomplete.", @ref);
        }
    }
}