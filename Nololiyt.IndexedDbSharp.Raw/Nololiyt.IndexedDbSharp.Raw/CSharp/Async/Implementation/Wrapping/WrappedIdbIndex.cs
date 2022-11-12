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

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>>
            GetAllKeysAsync<TKey, TResultKeyElement>(TKey? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getAllKeys", query);
            return new WrappedIdbRequestOfValue<TResultKeyElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> 
            GetAllKeysAsync<TResultKeyElement>(IdbKeyRangeInfo? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getAllKeys", query);
            return new WrappedIdbRequestOfValue<TResultKeyElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>>
            GetAllKeysAsync<TResultKeyElement>(int count)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getAllKeysSkipQuery", count);
            return new WrappedIdbRequestOfValue<TResultKeyElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>>
            GetAllKeysAsync<TKey, TResultKeyElement>(TKey? query, int count)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getAllKeys", query, count);
            return new WrappedIdbRequestOfValue<TResultKeyElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> 
            GetAllKeysAsync<TResultKeyElement>(IdbKeyRangeInfo? query, int count)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getAllKeys", query, count);
            return new WrappedIdbRequestOfValue<TResultKeyElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TKey, TValue>(TKey query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "get", query);
            return new WrappedIdbRequestOfValue<TValue>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue>(IdbKeyRangeInfo query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "get", query);
            return new WrappedIdbRequestOfValue<TValue>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKey?>>
            GetKeyAsync<TKey, TResultKey>(TKey query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getKey", query);
            return new WrappedIdbRequestOfValue<TResultKey?>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKey?>>
            GetKeyAsync<TResultKey>(IdbKeyRangeInfo query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "getKey", query);
            return new WrappedIdbRequestOfValue<TResultKey?>(result);
        }

        public async ValueTask<IdbKeyPath> GetKeyPathAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IdbKeyPath>("keyPath");
            return result;
        }

        public async ValueTask<bool> GetMultiEntryAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<bool>("multiEntry");
            return result;
        }

        public async ValueTask<string> GetNameAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<string>("name");
            return result;
        }

        public async ValueTask<IWrappedIdbObjectStore> GetObjectStoreAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("objectStore");
            return new WrappedIdbObjectStore(result);
        }

        public async ValueTask<bool> GetUniqueAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<bool>("unique");
            return result;
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> OpenCursorAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("openCursor");
            return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull>
            OpenCursorAsync<TKey>(TKey? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("openCursor", query);
            return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull>
            OpenCursorAsync(IdbKeyRangeInfo? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("openCursor", query);
            return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull>
            OpenCursorAsync(IdbCursorDirection direction)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openCursorSkipQuery", direction);
            return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> 
            OpenCursorAsync<TKey>(TKey? query, IdbCursorDirection direction)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openCursor", query, direction);
            return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> OpenCursorAsync(
            IdbKeyRangeInfo? query, IdbCursorDirection direction)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openCursor", query, direction);
            return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openKeyCursor");
            return new WrappedIdbRequestOfIdbCursorOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync<TKey>(TKey? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openKeyCursor", query);
            return new WrappedIdbRequestOfIdbCursorOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync(IdbKeyRangeInfo? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openKeyCursor", query);
            return new WrappedIdbRequestOfIdbCursorOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync(IdbCursorDirection direction)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openKeyCursorSkipQuery", direction);
            return new WrappedIdbRequestOfIdbCursorOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync<TKey>(TKey? query, IdbCursorDirection direction)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openKeyCursor", query, direction);
            return new WrappedIdbRequestOfIdbCursorOrNull(result);
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync(IdbKeyRangeInfo? query, IdbCursorDirection direction)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "openKeyCursor", query, direction);
            return new WrappedIdbRequestOfIdbCursorOrNull(result);
        }
    }
}
