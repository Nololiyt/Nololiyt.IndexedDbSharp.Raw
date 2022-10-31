﻿using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbTransaction : IWrappedWrappedJsObject
    {
        ValueTask AbortAsync();
        ValueTask CommitAsync();
        ValueTask<IWrappedIdbDatabase> GetDbAsync();
        ValueTask<IdbTransactionDurability> GetDurabilityAsync();
        ValueTask<IWrappedDomException?> GetErrorAsync();
        ValueTask<IdbTransactionMode> GetModeAsync();
        ValueTask<IWrappedIdbObjectStore> ObjectStoreAsync(string name);
        ValueTask<string[]> GetObjectStoreNamesAsync();
        ValueTask SetOnAbortAsync(EventObjectOfIdbRequestOfIdbTransaction? callbackObject);
        ValueTask SetOnCompleteAsync(EventObjectOfIdbRequestOfIdbTransaction? callbackObject);
        ValueTask SetOnErrorAsync(EventObjectOfIdbRequestOfIdbTransaction? callbackObject);
    }
}
