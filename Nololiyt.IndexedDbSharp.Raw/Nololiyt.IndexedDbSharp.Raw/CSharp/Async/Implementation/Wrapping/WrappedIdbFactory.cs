using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbFactory :  WrappedWrappedJsObjectBase, IWrappedIdbFactory
    {
        public WrappedIdbFactory(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public async ValueTask<int> CmpAsync<T1, T2>(T1 first, T2 second)
        {
            return await this.WrappedObject.InvokeAsync<int>("cmp", first, second);
        }

        public async ValueTask<IWrappedIdbOpenDbRequest> DeleteDatabaseAsync(string name)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "deleteDatabase", name);
            return new WrappedIdbOpenDbRequest(result);
        }

        public async ValueTask<IdbDatabaseInfo[]> GetDatabasesAsync()
        {
            var result = await this.WrappedObject.InvokeAsync<IdbDatabaseInfo[]>("databases");
            return result;
        }

        public async ValueTask<IWrappedIdbOpenDbRequest> OpenAsync(string name)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("open", name);
            return new WrappedIdbOpenDbRequest(result);
        }

        public async ValueTask<IWrappedIdbOpenDbRequest> OpenAsync(string name, int version)
        {
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>(
                "open", name, version);
            return new WrappedIdbOpenDbRequest(result);
        }
    }
}
