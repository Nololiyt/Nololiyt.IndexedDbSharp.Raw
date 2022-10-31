using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequest<T> : WrappedWrappedJsObjectBase, IWrappedIdbRequest<T>
    {
        public delegate T Conversion(IJSObjectReference obj);

        private readonly Conversion? conversion;
        public WrappedIdbRequest(
            IJSObjectReference wrappedObject, Conversion? conversionIfRequired = null)
            : base(wrappedObject)
        {
            this.conversion = conversionIfRequired;
        }

        public async ValueTask<IdbRequestReadyState> GetReadyStateAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<string>("readyState");
            _ = IdbRequestReadyState.TryParse(result, out var readyState);
            return readyState;
        }

        public async ValueTask<T> GetResultAsync()
        {
            if (conversion is null)
                return await this.WrappedObject.InvokeAsync<T>("result");
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("result");
            return conversion(result);
        }

        public async ValueTask<IWrappedIdbRequestSource> GetSourceAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("source");
            return new WrappedIdbRequestSource(result);
        }

        public ValueTask<IWrappedIdbTransaction?> GetTransactionAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnErrorAsync(EventObjectOfIdbRequest<T>? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnSuccessAsync(EventObjectOfIdbRequest<T>? callbackObject)
        {
            throw new NotImplementedException();
        }
    }
}
