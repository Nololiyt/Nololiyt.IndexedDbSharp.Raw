using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequestSource : WrappedJsObjectBase, IWrappedIdbRequestSource
    {
        public WrappedIdbRequestSource(IJSObjectReference wrappedObject)
            : base(wrappedObject)
        {
        }

        public async ValueTask<IWrappedIdbCursor?> GetSourceAsCursorAsync()
        {
            var type = await this.GetSourceTypeAsync();
            if (type != IdbRequestSourceType.Cursor)
                return null;
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getValue");
            return new WrappedIdbCursor(result);
        }

        public async ValueTask<IWrappedIdbIndex?> GetSourceAsIndexAsync()
        {
            var type = await this.GetSourceTypeAsync();
            if (type != IdbRequestSourceType.Index)
                return null;
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getValue");
            return new WrappedIdbIndex(result);
        }

        public async ValueTask<IWrappedIdbObjectStore?> GetSourceAsObjectStoreAsync()
        {
            var type = await this.GetSourceTypeAsync();
            if (type != IdbRequestSourceType.ObjectStore)
                return null;
            var result = await this.WrappedObject.InvokeAsync<IJSObjectReference>("getValue");
            return new WrappedIdbObjectStore(result);
        }

        private IdbRequestSourceType? type = null;
        public async ValueTask<IdbRequestSourceType> GetSourceTypeAsync()
        {
            if (!type.HasValue)
                type = await this.WrappedObject.InvokeAsync<IdbRequestSourceType>("getType");
            return type.Value;
        }
    }
}
