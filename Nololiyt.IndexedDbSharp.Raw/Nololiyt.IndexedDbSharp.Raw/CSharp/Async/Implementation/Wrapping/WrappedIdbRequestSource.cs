﻿using Microsoft.JSInterop;
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

        public ValueTask<IWrappedIdbCursor?> GetSourceAsCursorAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbIndex?> GetSourceAsIndexAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbObjectStore?> GetSourceAsObjectStoreAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IdbRequestSourceType> GetSourceTypeAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IJSObjectReference> GetWrappedWrappedObjectAsync()
        {
            throw new NotImplementedException();
        }
    }
}