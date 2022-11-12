using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequestOfIdbDatabase :
        WrappedIdbRequestBase<IWrappedIdbDatabase, EventObjectOfIdbRequestOfIdbDatabase>,
        IWrappedIdbRequestOfIdbDatabase
    {
        public WrappedIdbRequestOfIdbDatabase(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public override async ValueTask<IWrappedIdbDatabase> GetResultAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("result");
            return new WrappedIdbDatabase(result);
        }
    }
}
