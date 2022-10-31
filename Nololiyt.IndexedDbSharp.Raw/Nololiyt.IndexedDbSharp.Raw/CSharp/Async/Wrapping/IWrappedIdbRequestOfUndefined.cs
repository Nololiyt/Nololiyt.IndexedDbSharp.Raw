using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
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
        ValueTask SetOnErrorAsync(EventObjectOfIdbRequestOfUndefined? callbackObject);
        ValueTask SetOnSuccessAsync(EventObjectOfIdbRequestOfUndefined? callbackObject);
        ValueTask GetResultAsync();
        ValueTask<IdbRequestReadyState> GetReadyStateAsync();
        ValueTask<IWrappedIdbRequestSource> GetSourceAsync();
        ValueTask<IWrappedIdbTransaction?> GetTransactionAsync();
    }
}
