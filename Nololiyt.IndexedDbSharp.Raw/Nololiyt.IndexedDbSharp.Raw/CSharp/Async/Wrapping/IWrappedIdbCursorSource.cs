using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Implementation.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbCursorSource : IWrappedJsObject
    {
        ValueTask<IdbCursorSourceType> GetSourceTypeAsync();
        ValueTask<IWrappedIdbIndex?> GetSourceAsIndexAsync();
        ValueTask<IWrappedIdbObjectStore?> GetSourceAsObjectStoreAsync();
    }
}
