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
    public abstract class EventObject<TSelf> : IDisposable where TSelf : IWrappedWrappedJsObject
    {
        private readonly SelfConversion conversion;
        private readonly JsEventHandler<TSelf> handler;

        protected delegate TSelf SelfConversion(IJSObjectReference self);
        protected EventObject(SelfConversion conversion, JsEventHandler<TSelf> handler)
        {
            this.conversion = conversion;
            this.handler = handler;
            this.Object = DotNetObjectReference.Create(this);
        }

        public DotNetObjectReference<EventObject<TSelf>> Object { get; }

        [JSInvokable("Invoke")]
        public async ValueTask Invoke(IJSObjectReference self, IJSObjectReference ev)
        {
            await using var s = conversion(self);
            await using var e = new WrappedEvent(ev);
            await handler(s, e);
        }

#pragma warning disable CA1816 
        public void Dispose()
        {
            this.Object.Dispose();
        }
#pragma warning restore CA1816 
    }
}
