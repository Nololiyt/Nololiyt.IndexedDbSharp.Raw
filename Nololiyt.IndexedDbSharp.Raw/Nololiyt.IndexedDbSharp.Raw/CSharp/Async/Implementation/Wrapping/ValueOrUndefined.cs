using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal static class ValueOrUndefined
    {
        public static async ValueTask<T?> GetValueOfValueOrUndefinedAsync<T>(
            this IJSObjectReference valueOrUndefined) where T : class
        {
            if (!await valueOrUndefined.InvokeAsync<bool>("hasValue"))
                return null;
            return await valueOrUndefined.InvokeAsync<T>("getValue");
        }
        public static async ValueTask<T?> GetValueOfValueOrUndefinedStructAsync<T>(
            this IJSObjectReference valueOrUndefined) where T : struct
        {
            if (!await valueOrUndefined.InvokeAsync<bool>("hasValue"))
                return null;
            return await valueOrUndefined.InvokeAsync<T>("getValue");
        }
        public static async ValueTask<T?> InvokeValueOrUndefinedAsync<T>(
            this IJSObjectReference jsObject, string identifier, object?[]? args) where T : class
        {
            await using var valueOrUndefined =
                await jsObject.InvokeAsync<IJSObjectReference>(identifier, args);
            return await GetValueOfValueOrUndefinedAsync<T>(valueOrUndefined);
        }
        public static async ValueTask<T?> InvokeValueOrUndefinedStructAsync<T>(
            this IJSObjectReference jsObject, string identifier, object?[]? args) where T : struct
        {
            await using var valueOrUndefined =
                await jsObject.InvokeAsync<IJSObjectReference>(identifier, args);
            return await GetValueOfValueOrUndefinedStructAsync<T>(valueOrUndefined);
        }
    }
}
