using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbCursorSource : WrappedJsObjectBase, IWrappedIdbCursorSource
    {
        public WrappedIdbCursorSource(IJSObjectReference wrappedObject)
            : base(wrappedObject)
        {
        }

        public ValueTask<IWrappedIdbIndex?> GetSourceAsIndexAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbObjectStore?> GetSourceAsObjectStoreAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbCursorSourceType> GetSourceTypeAsync()
        {
            throw new NotImplementedException();
        }
    }
}
