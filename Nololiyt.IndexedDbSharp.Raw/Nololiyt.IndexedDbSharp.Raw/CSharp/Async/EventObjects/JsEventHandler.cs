using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects
{
    public delegate ValueTask JsEventHandler<TThis, TEventObject>(
        TThis @this,
        IWrappedEvent ev,
        TEventObject eventObject);
}
