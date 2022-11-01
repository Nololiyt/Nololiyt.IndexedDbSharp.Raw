using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal static class AnyReturn
    {
        public static async ValueTask<T?> GetValueOfAnyReturnAsync<T>(
            this IJSObjectReference anyReturn) where T : class
        {
            if (await anyReturn.InvokeAsync<bool>("isNullOrUndefined"))
                return null;
            return await anyReturn.InvokeAsync<T>("getValue");
        }
        public static async ValueTask<T?> GetValueOfAnyReturnStructAsync<T>(
            this IJSObjectReference anyReturn) where T : struct
        {
            if (await anyReturn.InvokeAsync<bool>("isNullOrUndefined"))
                return null;
            return await anyReturn.InvokeAsync<T>("getValue");
        }
        public static async ValueTask<T?> InvokeAnyReturnAsync<T>(
            this IJSObjectReference jsObject, string identifier, object?[]? args) where T : class
        {
            await using var anyReturn =
                await jsObject.InvokeAsync<IJSObjectReference>(identifier, args);
            return await GetValueOfAnyReturnAsync<T>(anyReturn);
        }
        public static async ValueTask<T?> InvokeValueOrNullStructAsync<T>(
            this IJSObjectReference jsObject, string identifier, object?[]? args) where T : struct
        {
            await using var anyReturn =
                await jsObject.InvokeAsync<IJSObjectReference>(identifier, args);
            return await GetValueOfAnyReturnStructAsync<T>(anyReturn);
        }
    }
}
