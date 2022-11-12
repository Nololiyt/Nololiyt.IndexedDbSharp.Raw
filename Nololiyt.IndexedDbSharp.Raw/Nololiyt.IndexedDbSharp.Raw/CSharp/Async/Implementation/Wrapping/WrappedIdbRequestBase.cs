using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal abstract class WrappedIdbRequestBase<T, TCallback> : WrappedWrappedJsObjectBase, IWrappedIdbRequestBase<T>
    {
        public WrappedIdbRequestBase(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public async ValueTask<IdbRequestReadyState> GetReadyStateAsync()
        {
            return await this.WrappedObject.InvokeAsync<IdbRequestReadyState>("readyState");
        }

        public abstract ValueTask<T> GetResultAsync();

        public async ValueTask<IWrappedIdbRequestSource> GetSourceAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("source");
            return new WrappedIdbRequestSource(result);
        }

        public async ValueTask<IWrappedIdbTransaction?> GetTransactionAsync()
        {
            var result = await this.WrappedObject.InvokeObjectOrNullAsync<IJSObjectReference>(
                "transaction");
            if (result is null)
                return null;
            return new WrappedIdbTransaction(result);
        }

        public async ValueTask SetOnErrorAsync(TCallback? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnError", callbackObject);
        }
        public async ValueTask SetOnSuccessAsync(TCallback? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnSuccess", callbackObject);
        }
    }
}
