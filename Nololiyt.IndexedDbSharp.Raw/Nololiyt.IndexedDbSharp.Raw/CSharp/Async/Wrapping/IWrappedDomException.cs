using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedDomException : IWrappedWrappedJsObject
    {
        ValueTask<string> GetMessageAsync();
        ValueTask<string> GetNameAsync();
        ValueTask<string?> GetStackAsync();
        ValueTask<int> GetCodeAsync();
    }
}
