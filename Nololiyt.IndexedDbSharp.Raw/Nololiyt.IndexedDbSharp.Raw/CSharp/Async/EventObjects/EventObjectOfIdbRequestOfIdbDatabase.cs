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
    public sealed class EventObjectOfIdbRequestOfIdbDatabase : IDisposable
    {
        private readonly JsEventHandler<IWrappedIdbRequestOfIdbDatabase, EventObjectOfIdbRequestOfIdbDatabase> handler;

        public EventObjectOfIdbRequestOfIdbDatabase(
            JsEventHandler<IWrappedIdbRequestOfIdbDatabase, EventObjectOfIdbRequestOfIdbDatabase> handler)
        {
            this.handler = handler;
            this.Object = DotNetObjectReference.Create(this);
        }

        public DotNetObjectReference<EventObjectOfIdbRequestOfIdbDatabase> Object { get; }

        [JSInvokable("Invoke")]
        public async ValueTask Invoke(IJSObjectReference self, IJSObjectReference ev)
        {
            await using var s = new WrappedIdbRequestOfIdbDatabase(self);
            await using var e = new WrappedEvent(ev);
            await handler(s, e, this);
        }

        public void Dispose()
        {
            this.Object.Dispose();
        }
    }
}
