using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal static class ValueOrNull
    {
        public static async ValueTask<T?> GetValueOfValueOrNullAsync<T>(
            this IJSObjectReference valueOrNull) where T : class
        {
            if (!await valueOrNull.InvokeAsync<bool>("hasValue"))
                return null;
            return await valueOrNull.InvokeAsync<T>("getValue");
        }
        public static async ValueTask<T?> GetValueOfValueOrNullStructAsync<T>(
            this IJSObjectReference valueOrNull) where T : struct
        {
            if (!await valueOrNull.InvokeAsync<bool>("hasValue"))
                return null;
            return await valueOrNull.InvokeAsync<T>("getValue");
        }
        public static async ValueTask<T?> InvokeValueOrNullAsync<T>(
            this IJSObjectReference jsObject, string identifier, object?[]? args) where T : class
        {
            await using var valueOrNull =
                await jsObject.InvokeAsync<IJSObjectReference>(identifier, args);
            return await GetValueOfValueOrNullAsync<T>(valueOrNull);
        }
        public static async ValueTask<T?> InvokeValueOrNullStructAsync<T>(
            this IJSObjectReference jsObject, string identifier, object?[]? args) where T : struct
        {
            await using var valueOrNull =
                await jsObject.InvokeAsync<IJSObjectReference>(identifier, args);
            return await GetValueOfValueOrNullStructAsync<T>(valueOrNull);
        }
    }
}
