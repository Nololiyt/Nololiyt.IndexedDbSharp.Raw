using Microsoft.JSInterop;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedJsObject : IAsyncDisposable
    {
        IJSObjectReference WrappedObject { get; }
    }
}
