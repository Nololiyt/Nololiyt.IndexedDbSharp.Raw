using Microsoft.JSInterop;
using Microsoft.JSInterop.Implementation;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp
{
    internal sealed class IndexedDbSharpRawEntry : IIndexedDbSharpRawEntry
    {
        private readonly IJSRuntime jsRuntime;

        public IndexedDbSharpRawEntry(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async ValueTask<WrappedIdbFactory?> NewWrappedIdbFactory()
        {
            await using var module = await jsRuntime.InvokeAsync<IJSObjectReference>(
                    "import",
                    "./_content/Nololiyt.IndexedDbSharp.Raw/generated/scripts/Entry.js");

            var result = await module.InvokeAsync<IJSObjectReference>("newWrappedIdbFactory");

            if (result is null)
                return null;

            return new WrappedIdbFactory(result);
        }
    }
}
