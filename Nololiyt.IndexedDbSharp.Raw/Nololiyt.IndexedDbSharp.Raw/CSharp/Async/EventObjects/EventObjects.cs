using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects
{
    public sealed class EventObjectOfIdbDatabase
        : EventObject<IWrappedIdbDatabase>
    {
        private static readonly SelfConversion conversion = (s) => new WrappedIdbDatabase(s);
        public EventObjectOfIdbDatabase(
            JsEventHandler<IWrappedIdbDatabase> handler)
            : base(conversion, handler)
        { }
    }
    public sealed class EventObjectOfIdbRequestOfIdbDatabase
        : EventObject<IWrappedIdbRequest<IWrappedIdbDatabase>>
    {
        private static readonly SelfConversion conversion 
            = (s) => new WrappedIdbRequest<IWrappedIdbDatabase>(s);

        public EventObjectOfIdbRequestOfIdbDatabase(
            JsEventHandler<IWrappedIdbRequest<IWrappedIdbDatabase>> handler)
            : base(conversion, handler)
        { }
    }
    public sealed class EventObjectOfIdbRequestOfIdbTransaction
        : EventObject<IWrappedIdbRequest<IWrappedIdbTransaction>>
    {
        private static readonly SelfConversion conversion = (s) => {
            throw new NotImplementedException();
        };

        public EventObjectOfIdbRequestOfIdbTransaction(
            JsEventHandler<IWrappedIdbRequest<IWrappedIdbTransaction>> handler)
            : base(conversion, handler)
        { }
    }
    public sealed class EventObjectOfIdbRequest<T>
        : EventObject<IWrappedIdbRequest<T>>
    {
        private static readonly SelfConversion conversion = (s) => {
            throw new NotImplementedException();
        };

        public EventObjectOfIdbRequest(
            JsEventHandler<IWrappedIdbRequest<T>> handler)
            : base(conversion, handler)
        { }
    }
    public sealed class EventObjectOfIdbRequestOfUndefined
        : EventObject<IWrappedIdbRequestOfUndefined>
    {
        private static readonly SelfConversion conversion = (s) => {
            throw new NotImplementedException();
        };

        public EventObjectOfIdbRequestOfUndefined(
            JsEventHandler<IWrappedIdbRequestOfUndefined> handler)
            : base(conversion, handler)
        { }
    }
}
