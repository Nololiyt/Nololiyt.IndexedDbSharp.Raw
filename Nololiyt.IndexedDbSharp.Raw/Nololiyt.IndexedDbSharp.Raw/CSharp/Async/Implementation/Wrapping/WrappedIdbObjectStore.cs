using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbObjectStore :  WrappedWrappedJsObjectBase, IWrappedIdbObjectStore
    {
        public WrappedIdbObjectStore(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKey>> AddAsync<TValue, TResultKey>(TValue value)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKey>> AddAsync<TValue, TKey, TResultKey>(TValue value, TKey key)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfUndefined> ClearAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync<TKey>(TKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync(IdbKeyRangeInfo query)
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

        public ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync<TKey>(TKey query)
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

        public ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement, TKey>(TKey? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(IdbKeyRangeInfo? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement, TKey>(TKey? query, int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(IdbKeyRangeInfo? query, int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TKey, TResultKeyElement>(TKey? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(IdbKeyRangeInfo? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TKey, TResultKeyElement>(TKey? query, int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(IdbKeyRangeInfo? query, int count)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue, TKey>(TKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue>(IdbKeyRangeInfo query)
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

        public ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TKey, TResultKey>(TKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TKey?>> GetKeyAsync<TKey>(IdbKeyRangeInfo query)
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

        public ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync<TKey>(TKey? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync(IdbKeyRangeInfo? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync(IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync<TKey>(TKey? query, IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync(IdbKeyRangeInfo? query, IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync<TKey>(TKey? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync(IdbKeyRangeInfo? query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync(IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync<TKey>(TKey? query, IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync(IdbKeyRangeInfo? query, IdbCursorDirection direction)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKey>> PutAsync<TValue, TResultKey>(TValue value)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKey>> PutAsync<TValue, TKey, TResultKey>(TValue value, TKey key)
        {
            throw new NotImplementedException();
        }
    }
}
