using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation
{
    internal sealed class AsyncIndexedDbSharpRawEntry : IAsyncIndexedDbSharpRawEntry
    {
        private readonly IJSRuntime jsRuntime;

        public AsyncIndexedDbSharpRawEntry(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async ValueTask<IWrappedIdbFactory> NewWrappedIdbFactoryAsync()
        {
            await using var module = await jsRuntime.InvokeAsync<IJSObjectReference>(
                    "import",
                    "./_content/Nololiyt.IndexedDbSharp.Raw/generated/scripts/Entry.js");
            try
            {
                var result = await module.InvokeAsync<IJSObjectReference>("newWrappedIdbFactory");
                return new WrappedIdbFactory(result);
            }
            catch(JSException ex)
            {
                if(IdbException.TryFromJsException(ex, out var idbEx))
                    throw idbEx;
                throw;
            }
        }
    }
}
