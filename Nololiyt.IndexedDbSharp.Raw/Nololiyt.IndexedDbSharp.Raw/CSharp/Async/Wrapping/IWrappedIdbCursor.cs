using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbCursor : IWrappedWrappedJsObject
    {
        ValueTask AdvanceAsync(int count);
        ValueTask ContinueAsync();
        ValueTask ContinueAsync(IdbValidKey key);
        ValueTask ContinuePrimaryKeyAsync(IdbValidKey key, IdbValidKey primaryKey);
        ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync();
        ValueTask<IdbCursorDirection> GetDirectionAsync();
        ValueTask<IdbValidKey> GetKeyAsync();
        ValueTask<IdbValidKey> GetPrimaryKeyAsync();
        ValueTask<IWrappedIdbRequest<TResult>> RequestAsync<TResult>();
        ValueTask<object> GetSourceAsync();
        ValueTask<dynamic> GetSourceDynamicAsync();
        ValueTask<IWrappedIdbObjectStore> GetSourceObjectStoreAsync();
        ValueTask<IWrappedIdbIndex> GetSourceIndexAsync();
    }
}
