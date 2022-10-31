using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbDatabase :  WrappedWrappedJsObjectBase, IWrappedIdbDatabase
    {
        public WrappedIdbDatabase(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask CloseAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbObjectStore> CreateObjectStoreAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbObjectStore> CreateObjectStoreAsync(string name, IdbObjectStoreParameters options)
        {
            throw new NotImplementedException();
        }

        public ValueTask DeleteObjectStoreAsync(string name)
        {
            throw new NotImplementedException();
        }

        public ValueTask<string> GetNameAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<string[]> GetObjectStoreNamesAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<int> GetVersionAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnAbortAsync(EventObjectOfIdbDatabase? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnCloseAsync(EventObjectOfIdbDatabase? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnErrorAsync(EventObjectOfIdbDatabase? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnVersionChangeAsync(EventObjectOfIdbDatabase? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask TransactionAsync(string[] storeNames)
        {
            throw new NotImplementedException();
        }

        public ValueTask TransactionAsync(string[] storeNames, IdbTransactionMode mode)
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbTransaction> TransactionAsync(string[] storeNames, IdbTransactionMode mode, IdbTransactionOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
