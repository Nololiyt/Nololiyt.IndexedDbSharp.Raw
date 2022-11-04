using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbIndex :  WrappedWrappedJsObjectBase, IWrappedIdbIndex
    {
        public WrappedIdbIndex(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public async ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("count");
            return new WrappedIdbRequestOfValue<long>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync<TKey>(TKey query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("count", query);
            return new WrappedIdbRequestOfValue<long>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync(IdbKeyRangeInfo query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("count", query);
            return new WrappedIdbRequestOfValue<long>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>>
            GetAllAsync<TResultElement>()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getAll");
            return new WrappedIdbRequestOfValue<TResultElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> 
            GetAllAsync<TKey, TResultElement>(TKey? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getAll", query);
            return new WrappedIdbRequestOfValue<TResultElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbKeyRangeInfo? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getAll", query);
            return new WrappedIdbRequestOfValue<TResultElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(
            int count)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getAllSkipQuery", count);
            return new WrappedIdbRequestOfValue<TResultElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>>
            GetAllAsync<TKey, TResultElement>(TKey? query, int count)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getAll", query, count);
            return new WrappedIdbRequestOfValue<TResultElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>>
            GetAllAsync<TResultElement>(IdbKeyRangeInfo? query, int count)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getAll", query, count);
            return new WrappedIdbRequestOfValue<TResultElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getAllKeys");
            return new WrappedIdbRequestOfValue<TResultKeyElement[]>(result);
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

        public ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TKey, TValue>(TKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue>(IdbKeyRangeInfo query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TKey, TResultKey>(TKey query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TResultKey>(IdbKeyRangeInfo query)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbKeyPath> GetKeyPathAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> GetMultiEntryAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> GetNameAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbObjectStore> GetObjectStoreAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<bool> GetUniqueAsync()
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
    }
}
