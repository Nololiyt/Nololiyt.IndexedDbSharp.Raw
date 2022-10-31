using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation
{
    internal sealed class AsyncIndexedDbSharpRawEntry : IAsyncIndexedDbSharpRawEntry
    {
        private readonly IJSRuntime jsRuntime;

        public AsyncIndexedDbSharpRawEntry(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async ValueTask<IWrappedDomException?> NewWrappedIdbFactoryAsync()
        {
            await using var module = await jsRuntime.InvokeAsync<IJSObjectReference>(
                    "import",
                    "./_content/Nololiyt.IndexedDbSharp.Raw/generated/scripts/Entry.js");
            var result = await module.InvokeAsync<IJSObjectReference?>("newWrappedIdbFactory");
            throw new NotImplementedException();
        }
    }
}
