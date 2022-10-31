using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbCursorWithValue : IWrappedIdbCursor
    {
        ValueTask<IWrappedIdbRequest<IdbValidKey>> UpdateAsync<TValue>(TValue value);
        ValueTask<TValue> GetValueAsync<TValue>();
    }
}
