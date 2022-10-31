using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbOpenDbRequest : IWrappedIdbRequest<IWrappedIdbDatabase>
    {
        ValueTask SetOnBlockedAsync(
            CallbackObject<IWrappedIdbRequest<IWrappedIdbDatabase>, IWrappedEvent>? callbackObject);
        ValueTask SetOnUpgradeNeededAsync(
            CallbackObject<IWrappedIdbRequest<IWrappedIdbDatabase>, IWrappedEvent>? callbackObject);
    }
}
