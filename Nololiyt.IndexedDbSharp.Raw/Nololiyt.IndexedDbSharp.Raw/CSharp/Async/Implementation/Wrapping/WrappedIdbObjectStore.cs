using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Xml.Linq;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbObjectStore :  WrappedWrappedJsObjectBase, IWrappedIdbObjectStore
    {
        public WrappedIdbObjectStore(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKey>> AddAsync<TValue, TResultKey>(TValue value)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("add", value);
            return new WrappedIdbRequestOfValue<TResultKey>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKey>> AddAsync<TValue, TKey, TResultKey>(TValue value, TKey key)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("add", value, key);
            return new WrappedIdbRequestOfValue<TResultKey>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfUndefined> ClearAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("clear");
            return new WrappedIdbRequestOfUndefined(result);
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

        public async ValueTask<IWrappedIdbIndex> CreateIndexAsync(string name, IdbKeyPath keyPath)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "createIndex", name, keyPath);
            return new WrappedIdbIndex(result);
        }

        public async ValueTask<IWrappedIdbIndex> CreateIndexAsync(
            string name, IdbKeyPath keyPath, IdbIndexParameters options)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "createIndex", name, keyPath, options);
            return new WrappedIdbIndex(result);
        }

        public async ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync<TKey>(TKey query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "delete", query);
            return new WrappedIdbRequestOfUndefined(result);
        }

        public async ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync(IdbKeyRangeInfo query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "delete", query);
            return new WrappedIdbRequestOfUndefined(result);
        }

        public async ValueTask DeleteIndexAsync(string name)
        {
            await this.WrappedObject.InvokeVoidAsync("deleteIndex", name);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getAll");
            return new WrappedIdbRequestOfValue<TResultElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>>
            GetAllAsync<TResultElement, TKey>(TKey? query)
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
            GetAllAsync<TResultElement, TKey>(TKey? query, int count)
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

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>>
            GetAllKeysAsync<TResultKeyElement>()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getAllKeys");
            return new WrappedIdbRequestOfValue<TResultKeyElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>>
            GetAllKeysAsync<TKey, TResultKeyElement>(TKey? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getAllKeys", query);
            return new WrappedIdbRequestOfValue<TResultKeyElement[]>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>>
            GetAllKeysAsync<TResultKeyElement>(IdbKeyRangeInfo? query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getAllKeys", query);
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

        public async ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue, TKey>(TKey query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("get", query);
            return new WrappedIdbRequestOfValue<TValue>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue>(IdbKeyRangeInfo query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("get", query);
            return new WrappedIdbRequestOfValue<TValue>(result);
        }

        public async ValueTask<bool> GetAutoIncrementAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<bool>("autoIncrement");
            return result;
        }

        public async ValueTask<string[]> GetIndexNamesAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<string[]>("indexNames");
            return result;
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TKey, TResultKey>(
            TKey query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getKey", query);
            return new WrappedIdbRequestOfValue<TResultKey?>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TResultKey>(IdbKeyRangeInfo query)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getKey", query);
            return new WrappedIdbRequestOfValue<TResultKey?>(result);
        }

        public async ValueTask<IdbKeyPath> GetKeyPathAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IdbKeyPath>("keyPath");
            return result;
        }

        public async ValueTask<IWrappedIdbTransaction> GetTransactionAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("transaction");
            return new WrappedIdbTransaction(result);
        }

        public async ValueTask<IWrappedIdbIndex> IndexAsync(string name)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("index", name);
            return new WrappedIdbIndex(result);
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

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKey>>
            PutAsync<TValue, TResultKey>(TValue value)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "put", value);
            return new WrappedIdbRequestOfValue<TResultKey>(result);
        }

        public async ValueTask<IWrappedIdbRequestOfValue<TResultKey>>
            PutAsync<TValue, TKey, TResultKey>(TValue value, TKey key)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "put", value, key);
            return new WrappedIdbRequestOfValue<TResultKey>(result);
        }
    }
}
