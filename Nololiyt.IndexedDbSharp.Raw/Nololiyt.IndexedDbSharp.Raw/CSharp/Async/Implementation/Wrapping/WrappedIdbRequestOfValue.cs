using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequestOfValue<T> : WrappedWrappedJsObjectBase, IWrappedIdbRequestOfValue<T>
    {
        public WrappedIdbRequestOfValue(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask<IdbRequestReadyState> GetReadyStateAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<T> GetResultAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestSource> GetSourceAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbTransaction?> GetTransactionAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnErrorAsync(EventObjectOfIdbRequestOfValue<T>? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnSuccessAsync(EventObjectOfIdbRequestOfValue<T>? callbackObject)
        {
            throw new NotImplementedException();
        }
    }
}
