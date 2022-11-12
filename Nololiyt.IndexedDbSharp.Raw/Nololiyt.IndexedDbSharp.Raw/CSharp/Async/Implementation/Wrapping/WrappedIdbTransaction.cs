using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System.Xml.Linq;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbTransaction :  WrappedWrappedJsObjectBase, IWrappedIdbTransaction
    {
        public WrappedIdbTransaction(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public async ValueTask AbortAsync()
        {
            await this.WrappedObject.InvokeVoidAsync("abort");
        }

        public async ValueTask CommitAsync()
        {
            await this.WrappedObject.InvokeVoidAsync("commit");
        }

        public async ValueTask<IWrappedIdbDatabase> GetDbAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("db");
            return new WrappedIdbDatabase(result);
        }

        public async ValueTask<IdbTransactionDurability> GetDurabilityAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IdbTransactionDurability>("durability");
            return result;
        }

        public async ValueTask<IWrappedDomException?> GetErrorAsync()
        {
            var result = await this.WrappedObject.InvokeObjectOrNullAsync<IJSObjectReference>("error");
            if (result is null)
                return null;
            return new WrappedDomException(result);
        }

        public async ValueTask<IdbTransactionMode> GetModeAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IdbTransactionMode>("mode");
            return result;
        }

        public async ValueTask<string[]> GetObjectStoreNamesAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<string[]>("objectStoreNames");
            return result;
        }

        public async ValueTask<IWrappedIdbObjectStore> ObjectStoreAsync(string name)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("objectStore", name);
            return new WrappedIdbObjectStore(result);
        }

        public async ValueTask SetOnAbortAsync(EventObjectOfIdbTransaction? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnAbort", callbackObject);
        }

        public async ValueTask SetOnCompleteAsync(EventObjectOfIdbTransaction? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnComplete", callbackObject);
        }

        public async ValueTask SetOnErrorAsync(EventObjectOfIdbTransaction? callbackObject)
        {
            await this.WrappedObject.InvokeVoidAsync("setOnError", callbackObject);
        }
    }
}
