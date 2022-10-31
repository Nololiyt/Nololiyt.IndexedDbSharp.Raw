using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedDomException :  WrappedWrappedJsObjectBase, IWrappedDomException
    {
        public WrappedDomException(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask<int> GetCodeAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> GetMessageAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> GetNameAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<string?> GetStackAsync()
        {
            throw new NotImplementedException();
        }
    }
}
