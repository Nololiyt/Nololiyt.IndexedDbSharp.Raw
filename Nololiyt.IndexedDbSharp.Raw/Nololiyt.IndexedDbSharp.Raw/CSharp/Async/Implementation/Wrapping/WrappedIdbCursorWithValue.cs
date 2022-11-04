using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbCursorWithValue :  WrappedWrappedJsObjectBase, IWrappedIdbCursorWithValue
    {
        public WrappedIdbCursorWithValue(IJSObjectReference wrappedObject) : base(wrappedObject)
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

        public ValueTask ContinueAsync<TKey>(TKey key)
        {
            throw new NotImplementedException();
        }

        public ValueTask ContinuePrimaryKeyAsync<TKey, TPrimaryKey>(TKey key, TPrimaryKey primaryKey)
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

        public ValueTask<TResultKey> GetKeyAsync<TResultKey>()
        {
            throw new NotImplementedException();
        }

        public ValueTask<TResultKey> GetPrimaryKeyAsync<TResultKey>()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> GetRequestAsync<TResult>()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbCursorSource> GetSourceAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<TValue> GetValueAsync<TValue>()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKey>> UpdateAsync<TValue, TResultKey>(TValue value)
        {
            throw new NotImplementedException();
        }
    }
}
