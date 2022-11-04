using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedDomException :  WrappedWrappedJsObjectBase, IWrappedDomException
    {
        public WrappedDomException(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public async ValueTask<int> GetCodeAsync()
        {
            return await this.WrappedObject.InvokeAsync<int>("code");
        }

        public async ValueTask<string> GetMessageAsync()
        {
            return await this.WrappedObject.InvokeAsync<string>("message");
        }

        public async ValueTask<string> GetNameAsync()
        {
            return await this.WrappedObject.InvokeAsync<string>("name");
        }

        public async ValueTask<string?> GetStackAsync()
        {
            return await this.WrappedObject.InvokeAsync<string?>("stack");
        }
    }
}
