using Microsoft.JSInterop;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedWrappedJsObject : IWrappedJsObject
    {
        ValueTask<IJSObjectReference> GetWrappedWrappedObjectAsync();
    }
}
