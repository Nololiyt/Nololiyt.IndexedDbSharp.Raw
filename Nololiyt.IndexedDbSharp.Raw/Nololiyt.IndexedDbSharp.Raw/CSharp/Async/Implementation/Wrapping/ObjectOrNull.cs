using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal static class ObjectOrNull
    {
        public static async ValueTask<T?> InvokeObjectOrNullAsync<T>(
            this IJSObjectReference jsObject, string identifier, object?[]? args) where T : class
        {
            await using var valueOrNull =
                await jsObject.InvokeAsync<IJSObjectReference>(identifier, args);
            if (await valueOrNull.InvokeAsync<bool>("isNull"))
                return null;
            return await valueOrNull.InvokeAsync<T>("getValue");
        }
    }
}
