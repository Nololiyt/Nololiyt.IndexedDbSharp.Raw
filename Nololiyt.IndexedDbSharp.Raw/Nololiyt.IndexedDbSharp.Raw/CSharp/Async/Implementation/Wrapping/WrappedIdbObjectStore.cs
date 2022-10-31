using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbObjectStore :  WrappedWrappedJsObjectBase, IWrappedIdbObjectStore
    {
        public WrappedIdbObjectStore(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey>> AddAsync<TValue>(TValue value)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey>> AddAsync<TValue>(TValue value, IdbValidKey key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfUndefined> ClearAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<long>> CountAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<long>> CountAsync(IdbValidKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<long>> CountAsync(IdbKeyRangeInfo query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbIndex> CreateIndexAsync(string name, IdbKeyPath keyPath)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbIndex> CreateIndexAsync(string name, IdbKeyPath keyPath, IdbIndexParameters options)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync(IdbValidKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync(IdbKeyRangeInfo query)
        {
            throw new NotImplementedException();
        }

        public ValueTask DeleteIndexAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(IdbValidKey? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(IdbKeyRangeInfo? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(IdbValidKey? query, int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(IdbKeyRangeInfo? query, int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(IdbValidKey? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(IdbKeyRangeInfo? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(IdbValidKey? query, int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(IdbKeyRangeInfo? query, int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TValue>> GetAsync<TValue>(IdbValidKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<TValue>> GetAsync<TValue>(IdbKeyRangeInfo query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> GetAutoIncrementAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<string[]> GetIndexNamesAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey?>> GetKeyAsync(IdbValidKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey?>> GetKeyAsync(IdbKeyRangeInfo query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbKeyPath> GetKeyPathAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbTransaction> GetTransactionAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbIndex> IndexAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(IdbValidKey? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(IdbKeyRangeInfo? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(IdbValidKey? query, IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(IdbKeyRangeInfo? query, IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(IdbValidKey? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(IdbKeyRangeInfo? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(IdbValidKey? query, IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(IdbKeyRangeInfo? query, IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey>> PutAsync<TValue>(TValue value)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequest<IdbValidKey>> PutAsync<TValue>(TValue value, IdbValidKey key)
        {
            throw new NotImplementedException();
        }
    }
}
