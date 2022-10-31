using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbFactory : IWrappedWrappedJsObject
    {
        ValueTask<IWrappedIdbOpenDbRequest> OpenAsync(string name);
        ValueTask<IWrappedIdbOpenDbRequest> OpenAsync(string name, int version);
        ValueTask<int> CmpAsync<T1, T2>(T1 first, T2 second);
        ValueTask<IdbDatabaseInfo[]> GetDatabasesAsync();
        ValueTask<IWrappedIdbOpenDbRequest> DeleteDatabaseAsync(string name);
    }
}
