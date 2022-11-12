using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbOpenDbRequest : 
        WrappedIdbRequestBase<IWrappedIdbDatabase, EventObjectOfIdbRequestOfIdbDatabase>, 
        IWrappedIdbOpenDbRequest
    {
        public WrappedIdbOpenDbRequest(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public override async ValueTask<IWrappedIdbDatabase> GetResultAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("result");
            return new WrappedIdbDatabase(result);
        }

        public async ValueTask SetOnBlockedAsync(EventObjectOfIdbRequestOfIdbDatabase? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnBlocked", callbackObject);
        }

        public async ValueTask SetOnUpgradeNeededAsync(EventObjectOfIdbRequestOfIdbDatabase? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnUpgradeNeeded", callbackObject);
        }
    }
}
