using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Wrapping
{
    public sealed class WrappedIdbFactory : IAsyncDisposable
    {
        private IJSObjectReference wrapped;
        internal WrappedIdbFactory(IJSObjectReference wrapped)
        {
            this.wrapped = wrapped;
        }

        public ValueTask DisposeAsync()
        {
            return this.wrapped.DisposeAsync();
        }
    }
}
