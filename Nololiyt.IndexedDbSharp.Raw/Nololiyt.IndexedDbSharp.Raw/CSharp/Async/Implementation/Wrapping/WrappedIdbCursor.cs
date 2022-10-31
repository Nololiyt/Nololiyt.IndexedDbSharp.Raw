using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbCursor :  WrappedWrappedJsObjectBase, IWrappedIdbCursor
    {
        public WrappedIdbCursor(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask AdvanceAsync(int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask ContinueAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask ContinueAsync(IdbValidKey key)
        {
            throw new NotImplementedException();
        }

        public ValueTask ContinuePrimaryKeyAsync(IdbValidKey key, IdbValidKey primaryKey)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbCursorDirection> GetDirectionAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbValidKey> GetKeyAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbValidKey> GetPrimaryKeyAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<object> GetSourceAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<dynamic> GetSourceDynamicAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbIndex> GetSourceIndexAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbObjectStore> GetSourceObjectStoreAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TResult>> RequestAsync<TResult>()
        {
            throw new NotImplementedException();
        }
    }
}
