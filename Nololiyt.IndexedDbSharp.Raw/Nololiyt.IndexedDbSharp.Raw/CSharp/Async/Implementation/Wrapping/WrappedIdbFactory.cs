using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbFactory :  WrappedWrappedJsObjectBase, IWrappedIdbFactory
    {
        public WrappedIdbFactory(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask<int> CmpAsync<T1, T2>(T1 first, T2 second)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbOpenDbRequest> DeleteDatabaseAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbDatabaseInfo[]> GetDatabasesAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbOpenDbRequest> OpenAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbOpenDbRequest> OpenAsync(string name, int version)
        {
            throw new NotImplementedException();
        }
    }
}
