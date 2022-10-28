using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp
{
    public sealed class Alerter
    {
        private readonly IJSRuntime jsRuntime;
        public Alerter(IJSRuntime jsRuntime)
        {
            this.jsRuntime = jsRuntime;
        }

        public async ValueTask Alert(string message)
        {
            await using var entry = await jsRuntime.InvokeAsync<IJSObjectReference>(
                "import",
                "./_content/Nololiyt.IndexedDbSharp.Raw/generated/scripts/Entry.js");
            await entry.InvokeVoidAsync("alert", message);
        }
    }
}
