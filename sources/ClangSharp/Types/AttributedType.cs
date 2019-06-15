using System.Diagnostics;
using ClangSharp.Interop;

namespace ClangSharp
{
    public sealed class AttributedType : Type
    {
        public AttributedType(CXType handle, TranslationUnitDecl translationUnit) : base(handle, translationUnit)
        {
            Debug.Assert(handle.kind == CXTypeKind.CXType_Attributed);
            ModifiedType = TranslationUnit.GetOrCreateType(Handle.ModifiedType, () => Create(Handle.ModifiedType, TranslationUnit));
        }

        public Type ModifiedType { get; }
    }
}
