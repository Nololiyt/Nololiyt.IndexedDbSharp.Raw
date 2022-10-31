using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async
{
    public interface IAsyncIndexedDbSharpRawEntry
    {
        ValueTask<IWrappedIdbFactory?> NewWrappedIdbFactoryAsync();
    }
}