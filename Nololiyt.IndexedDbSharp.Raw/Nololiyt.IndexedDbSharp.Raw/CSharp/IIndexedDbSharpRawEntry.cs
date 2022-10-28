using Nololiyt.IndexedDbSharp.Raw.CSharp.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp
{
    public interface IIndexedDbSharpRawEntry
    {
        ValueTask<WrappedIdbFactory?> NewWrappedIdbFactory();
    }
}