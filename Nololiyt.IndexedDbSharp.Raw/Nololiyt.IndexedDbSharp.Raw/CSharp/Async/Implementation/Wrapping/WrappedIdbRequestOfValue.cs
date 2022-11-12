using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequestOfValue<T> :
        WrappedIdbRequestBase<T, EventObjectOfIdbRequestOfValue<T>>,
        IWrappedIdbRequestOfValue<T>
    {
        public WrappedIdbRequestOfValue(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public override async ValueTask<T> GetResultAsync()
        {
            return await this.WrappedObject.InvokeAsync<T>("result");
        }
    }
}
