using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbCursorSource : WrappedJsObjectBase, IWrappedIdbCursorSource
    {
        public WrappedIdbCursorSource(IJSObjectReference wrappedObject)
            : base(wrappedObject)
        {
        }

        public async ValueTask<IWrappedIdbIndex?> GetSourceAsIndexAsync()
        {
            var type = await this.GetSourceTypeAsync();
            if(type != IdbCursorSourceType.Index)
                return null;
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getValue");
            return new WrappedIdbIndex(result);
        }

        public async ValueTask<IWrappedIdbObjectStore?> GetSourceAsObjectStoreAsync()
        {
            var type = await this.GetSourceTypeAsync();
            if (type != IdbCursorSourceType.ObjectStore)
                return null;
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getValue");
            return new WrappedIdbObjectStore(result);
        }

        private IdbCursorSourceType? type = null;
        public async ValueTask<IdbCursorSourceType> GetSourceTypeAsync()
        {
            if (!type.HasValue)
                type = await this.WrappedObject.InvokeAsync<IdbCursorSourceType>("getType");
            return type.Value;
        }
    }
}
