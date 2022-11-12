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
        ValueTask ContinueAsync<TKey>(TKey key);
        ValueTask ContinuePrimaryKeyAsync<TKey, TPrimaryKey>(TKey key, TPrimaryKey primaryKey);
        ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync();
        ValueTask<IdbCursorDirection> GetDirectionAsync();
        ValueTask<TResultKey> GetKeyAsync<TResultKey>();
        ValueTask<TResultKey> GetPrimaryKeyAsync<TResultKey>();

#warning The return type in Typescript is 'WrappedIdbRequest<any>'
        ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> GetRequestAsync<TResult>();
        ValueTask<IWrappedIdbCursorSource> GetSourceAsync();
    }
}
