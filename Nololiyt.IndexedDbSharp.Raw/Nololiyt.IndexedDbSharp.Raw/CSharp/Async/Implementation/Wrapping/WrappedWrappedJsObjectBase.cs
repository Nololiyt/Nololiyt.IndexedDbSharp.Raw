using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal abstract class WrappedWrappedJsObjectBase : IWrappedWrappedJsObject
    {
        public IJSObjectReference WrappedObject { get; }
        protected WrappedWrappedJsObjectBase(IJSObjectReference wrappedObject)
        {
            this.WrappedObject = wrappedObject;
        }
        public async ValueTask DisposeAsync()
        {
            await WrappedObject.DisposeAsync();
        }
        public async ValueTask<IJSObjectReference> GetWrappedWrappedObjectAsync()
        {
            return await this.WrappedObject.InvokeAsync<IJSObjectReference>("wrappedObject");
        }
    }
}
