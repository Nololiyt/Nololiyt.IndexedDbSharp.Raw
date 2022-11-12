using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping
{
    internal sealed class WrappedIdbRequestOfIdbCursorWithValueOrNull :
        WrappedIdbRequestBase<IWrappedIdbCursorWithValue?, EventObjectOfIdbRequestOfIdbCursorWithValue>,
        IWrappedIdbRequestOfIdbCursorWithValueOrNull
    {
        public WrappedIdbRequestOfIdbCursorWithValueOrNull(IJSObjectReference wrappedObject) : base(wrappedObject)
        {
        }

        public override async ValueTask<IWrappedIdbCursorWithValue?> GetResultAsync()
        {
            var result = await this.WrappedObject.InvokeObjectOrNullAsync<IJSObjectReference>("result");
            if (result is null)
                return null;
            return new WrappedIdbCursorWithValue(result);
        }
    }
}
