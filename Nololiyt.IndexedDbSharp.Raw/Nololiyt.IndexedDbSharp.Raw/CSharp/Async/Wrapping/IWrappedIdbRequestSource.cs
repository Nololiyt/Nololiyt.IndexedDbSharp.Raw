using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbRequestSource : IWrappedJsObject
    {
        ValueTask<IdbRequestSourceType> GetSourceTypeAsync();
        ValueTask<IWrappedIdbIndex?> GetSourceAsIndexAsync();
        ValueTask<IWrappedIdbObjectStore?> GetSourceAsObjectStoreAsync();
        ValueTask<IWrappedIdbCursor?> GetSourceAsCursorAsync();
    }
}
