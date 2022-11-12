using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequestOfIdbCursorOrNull : 
        WrappedIdbRequestBase<IWrappedIdbCursor?, EventObjectOfIdbRequestOfIdbCursor>,
        IWrappedIdbRequestOfIdbCursorOrNull
    {
        public WrappedIdbRequestOfIdbCursorOrNull(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public override async ValueTask<IWrappedIdbCursor?> GetResultAsync()
        {
            var result = await this.WrappedObject.InvokeObjectOrNullAsync<IJSObjectReference>("result");
            if (result is null)
                return null;
            return new WrappedIdbCursor(result);
        }
    }
}
