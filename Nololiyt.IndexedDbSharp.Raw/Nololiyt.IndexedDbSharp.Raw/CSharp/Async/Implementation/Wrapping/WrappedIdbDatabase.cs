using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System.Xml.Linq;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbDatabase :  WrappedWrappedJsObjectBase, IWrappedIdbDatabase
    {
        public WrappedIdbDatabase(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public async ValueTask CloseAsync()
        {
            await this.WrappedObject.InvokeVoidAsync("close");
        }

        public async ValueTask<IWrappedIdbObjectStore> CreateObjectStoreAsync(string name)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "createObjectStore", name);
            return new WrappedIdbObjectStore(result);
        }

        public async ValueTask<IWrappedIdbObjectStore> CreateObjectStoreAsync(
            string name, IdbObjectStoreParameters options)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "createObjectStore", name, options);
            return new WrappedIdbObjectStore(result);
        }

        public async ValueTask DeleteObjectStoreAsync(string name)
        {
            await this.WrappedObject.InvokeVoidAsync("delete", name);
        }

        public async ValueTask<string> GetNameAsync()
        {
            return await this.WrappedObject.InvokeAsync<string>("name");
        }

        public async ValueTask<string[]> GetObjectStoreNamesAsync()
        {
            return await this.WrappedObject.InvokeAsync<string[]>("objectStoreNames");
        }

        public async ValueTask<int> GetVersionAsync()
        {
            return await this.WrappedObject.InvokeAsync<int>("version");
        }

        public async ValueTask SetOnAbortAsync(EventObjectOfIdbDatabase? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnAbort", callbackObject);
        }

        public async ValueTask SetOnCloseAsync(EventObjectOfIdbDatabase? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnClose", callbackObject);
        }

        public async ValueTask SetOnErrorAsync(EventObjectOfIdbDatabase? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnError", callbackObject);
        }

        public async ValueTask SetOnVersionChangeAsync(EventObjectOfIdbDatabase? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnVersionChange", callbackObject);
        }

        public async ValueTask<IWrappedIdbTransaction> TransactionAsync(string[] storeNames)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "transaction", storeNames);
            return new WrappedIdbTransaction(result);
        }

        public async ValueTask<IWrappedIdbTransaction> TransactionAsync(
            string[] storeNames, IdbTransactionMode mode)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "transaction", storeNames, mode);
            return new WrappedIdbTransaction(result);
        }
        public async ValueTask<IWrappedIdbTransaction> TransactionAsync(
            string[] storeNames, IdbTransactionOptions options)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "transactionSkipMode", storeNames, options);
            return new WrappedIdbTransaction(result);
        }

        public async ValueTask<IWrappedIdbTransaction> TransactionAsync(
            string[] storeNames, IdbTransactionMode mode, IdbTransactionOptions options)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "transaction", storeNames, mode, options);
            return new WrappedIdbTransaction(result);
        }
    }
}
