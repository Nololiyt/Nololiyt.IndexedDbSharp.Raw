using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedEvent :  WrappedWrappedJsObjectBase, IWrappedEvent
    {
        public WrappedEvent(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }
    }
}
