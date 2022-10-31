using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbDatabase : IWrappedWrappedJsObject
    {
        ValueTask CloseAsync();
        ValueTask<IWrappedIdbObjectStore> CreateObjectStoreAsync(string name);
        ValueTask<IWrappedIdbObjectStore> CreateObjectStoreAsync(string name, IdbObjectStoreParameters options);
        ValueTask DeleteObjectStoreAsync(string name);
        ValueTask<string> GetNameAsync();
        ValueTask<string[]> GetObjectStoreNamesAsync();
        ValueTask SetOnAbortAsync(
            CallbackObject<IWrappedIdbDatabase, IWrappedEvent>? callbackObject);
        ValueTask SetOnCloseAsync(
            CallbackObject<IWrappedIdbDatabase, IWrappedEvent>? callbackObject);
        ValueTask SetOnErrorAsync(
            CallbackObject<IWrappedIdbDatabase, IWrappedEvent>? callbackObject);
        ValueTask SetOnVersionChangeAsync(
            CallbackObject<IWrappedIdbDatabase, IWrappedEvent>? callbackObject);
        ValueTask TransactionAsync(string[] storeNames);
        ValueTask TransactionAsync(string[] storeNames, IdbTransactionMode mode);
        ValueTask<IWrappedIdbTransaction> TransactionAsync(
            string[] storeNames, IdbTransactionMode mode, IdbTransactionOptions options);
        ValueTask<int> GetVersionAsync();
    }
}
