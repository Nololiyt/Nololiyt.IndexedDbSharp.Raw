using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequestSource : WrappedWrappedJsObjectBase, IWrappedIdbRequestSource
    {
        public WrappedIdbRequestSource(IWrappedIdbCursor cursor)
            : base(cursor.WrappedObject)
        {
            this.cursor = cursor;
        }
        public WrappedIdbRequestSource(IWrappedIdbIndex index)
            : base(index.WrappedObject)
        {
            this.index = index;
        }
        public WrappedIdbRequestSource(IWrappedIdbObjectStore objectStore) 
            : base(objectStore.WrappedObject)
        {
            this.objectStore = objectStore;
        }

        private readonly IWrappedIdbCursor? cursor;
        private readonly IWrappedIdbIndex? index;
        private readonly IWrappedIdbObjectStore? objectStore;

        public bool IsIdbObjectStore => objectStore is not null;
        public bool IsIdbIndex => index is not null;
        public bool IsIdbCursor => cursor is not null;

        public IWrappedIdbCursor? AsIdbCursor()
        {
            return cursor;
        }

        public IWrappedIdbIndex? AsIdbIndex()
        {
            return index;
        }

        public IWrappedIdbObjectStore? AsIdbObjectStore()
        {
            return objectStore;
        }
    }
}
