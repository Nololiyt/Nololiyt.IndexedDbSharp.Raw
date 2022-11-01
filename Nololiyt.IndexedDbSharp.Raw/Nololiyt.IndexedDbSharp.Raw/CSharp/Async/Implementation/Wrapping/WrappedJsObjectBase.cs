using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal abstract class WrappedJsObjectBase : IWrappedJsObject
    {
        public IJSObjectReference WrappedObject { get; }
        protected WrappedJsObjectBase(IJSObjectReference wrappedObject)
        {
            this.WrappedObject = wrappedObject;
        }
        public async ValueTask DisposeAsync()
        {
            await WrappedObject.DisposeAsync();
        }
    }
}
