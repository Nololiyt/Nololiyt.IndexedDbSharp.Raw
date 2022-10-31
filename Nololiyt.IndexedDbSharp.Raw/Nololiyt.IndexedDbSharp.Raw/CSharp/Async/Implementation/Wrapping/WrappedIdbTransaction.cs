using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbTransaction :  WrappedWrappedJsObjectBase, IWrappedIdbTransaction
    {
        public WrappedIdbTransaction(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask AbortAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask CommitAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbDatabase> GetDbAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbTransactionDurability> GetDurabilityAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedDomException?> GetErrorAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbTransactionMode> GetModeAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<string[]> GetObjectStoreNamesAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbObjectStore> ObjectStoreAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnAbortAsync(EventObjectOfIdbRequestOfIdbTransaction? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnCompleteAsync(EventObjectOfIdbRequestOfIdbTransaction? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnErrorAsync(EventObjectOfIdbRequestOfIdbTransaction? callbackObject)
        {
            throw new NotImplementedException();
        }
    }
}
