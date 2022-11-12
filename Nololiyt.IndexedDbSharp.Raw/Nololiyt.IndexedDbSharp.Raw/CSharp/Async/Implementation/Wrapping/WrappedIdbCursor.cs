﻿using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbCursor :  WrappedWrappedJsObjectBase, IWrappedIdbCursor
    {
        public WrappedIdbCursor(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public async ValueTask AdvanceAsync(int count)
        {
            await this.WrappedObject.InvokeVoidAsync("advance", count);
        }

        public async ValueTask ContinueAsync()
        {
            await this.WrappedObject.InvokeVoidAsync("continue");
        }

        public async ValueTask ContinueAsync<TKey>(TKey key)
        {
            await this.WrappedObject.InvokeVoidAsync("continue", key);
        }

        public async ValueTask ContinuePrimaryKeyAsync<TKey, TPrimaryKey>(TKey key, TPrimaryKey primaryKey)
        {
            await this.WrappedObject.InvokeVoidAsync("continuePrimaryKey", key, primaryKey);
        }

        public async ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("delete");
            return new WrappedIdbRequestOfUndefined(result);
        }

        public async ValueTask<IdbCursorDirection> GetDirectionAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IdbCursorDirection>("direction");
            return result;
        }

        public async ValueTask<TResultKey> GetKeyAsync<TResultKey>()
        {
            var result = await this.WrappedObject.InvokeAsync<TResultKey>("key");
            return result;
        }

        public async ValueTask<TResultKey> GetPrimaryKeyAsync<TResultKey>()
        {
            var result = await this.WrappedObject.InvokeAsync<TResultKey>("primaryKey");
            return result;
        }

        public async ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> GetRequestAsync<TResult>()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("request");
            return new WrappedIdbRequestOfIdbCursorOrNull(result);
        }

        public async ValueTask<IWrappedIdbCursorSource> GetSourceAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("source");
            return new WrappedIdbCursorSource(result);
        }
    }
}
