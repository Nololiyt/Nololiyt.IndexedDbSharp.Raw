using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects
{
    public sealed class EventObjectOfIdbTransaction : IDisposable
    {
        private readonly JsEventHandler<IWrappedIdbTransaction, EventObjectOfIdbTransaction> handler;

        public EventObjectOfIdbTransaction(
            JsEventHandler<IWrappedIdbTransaction, EventObjectOfIdbTransaction> handler)
        {
            this.handler = handler;
            this.Object = DotNetObjectReference.Create(this);
        }

        public DotNetObjectReference<EventObjectOfIdbTransaction> Object { get; }

        [JSInvokable("Invoke")]
        public async ValueTask Invoke(IJSObjectReference self, IJSObjectReference ev)
        {
            await using var s = new WrappedIdbTransaction(self);
            await using var e = new WrappedEvent(ev);
            await handler(s, e, this);
        }

        public void Dispose()
        {
            this.Object.Dispose();
        }
    }
}
