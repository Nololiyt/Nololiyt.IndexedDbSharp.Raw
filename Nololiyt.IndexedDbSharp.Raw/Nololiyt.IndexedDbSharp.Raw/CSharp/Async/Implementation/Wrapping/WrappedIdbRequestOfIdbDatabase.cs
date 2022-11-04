using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequestOfIdbDatabase : WrappedWrappedJsObjectBase, IWrappedIdbRequestOfIdbDatabase
    {
        public WrappedIdbRequestOfIdbDatabase(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public ValueTask<IdbRequestReadyState> GetReadyStateAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbDatabase> GetResultAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbRequestSource> GetSourceAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask<IWrappedIdbTransaction?> GetTransactionAsync()
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnErrorAsync(EventObjectOfIdbRequestOfIdbDatabase? callbackObject)
        {
            throw new NotImplementedException();
        }

        public ValueTask SetOnSuccessAsync(EventObjectOfIdbRequestOfIdbDatabase? callbackObject)
        {
            throw new NotImplementedException();
        }
    }
}
