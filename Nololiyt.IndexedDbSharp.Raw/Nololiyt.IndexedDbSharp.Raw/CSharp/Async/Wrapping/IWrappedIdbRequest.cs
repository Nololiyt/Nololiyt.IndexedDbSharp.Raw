using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbRequestOfUndefined : IWrappedWrappedJsObject
    {
        ValueTask SetOnErrorAsync(
            CallbackObject<IWrappedIdbRequestOfUndefined, IWrappedEvent>? callbackObject);
        ValueTask SetOnSuccessAsync(
            CallbackObject<IWrappedIdbRequestOfUndefined, IWrappedEvent>? callbackObject);
        ValueTask GetResultAsync();
        ValueTask<IdbRequestReadyState> GetReadyStateAsync();
        ValueTask<IWrappedIdbRequestSource> GetSourceAsync();
        ValueTask<IWrappedIdbTransaction?> GetTransactionAsync();
    }
    public interface IWrappedIdbRequest<T> : IWrappedWrappedJsObject
    {
        ValueTask SetOnErrorAsync(
            CallbackObject<IWrappedIdbRequest<T>, IWrappedEvent>? callbackObject);
        ValueTask SetOnSuccessAsync(
            CallbackObject<IWrappedIdbRequest<T>, IWrappedEvent>? callbackObject);
        ValueTask<T> GetResultAsync();
        ValueTask<IdbRequestReadyState> GetReadyStateAsync();
        ValueTask<IWrappedIdbRequestSource> GetSourceAsync();
        ValueTask<IWrappedIdbTransaction?> GetTransactionAsync();
    }
}
