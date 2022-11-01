using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal abstract class WrappedWrappedJsObjectBase : WrappedJsObjectBase
    {
        protected WrappedWrappedJsObjectBase(IJSObjectReference wrappedObject)
            : base(wrappedObject)
        { }
        public async ValueTask<IJSObjectReference> GetWrappedWrappedObjectAsync()
        {
            return await this.WrappedObject.InvokeAsync<IJSObjectReference>("wrappedObject");
        }
    }
}
