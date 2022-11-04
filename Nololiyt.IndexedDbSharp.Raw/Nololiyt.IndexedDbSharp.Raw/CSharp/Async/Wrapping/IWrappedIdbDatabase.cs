using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.EventObjects;
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
        ValueTask<IWrappedIdbObjectStore> CreateObjectStoreAsync(
            string name, IdbObjectStoreParameters options);
        ValueTask DeleteObjectStoreAsync(string name);
        ValueTask<string> GetNameAsync();
        ValueTask<string[]> GetObjectStoreNamesAsync();
        ValueTask SetOnAbortAsync(EventObjectOfIdbDatabase? callbackObject);
        ValueTask SetOnCloseAsync(EventObjectOfIdbDatabase? callbackObject);
        ValueTask SetOnErrorAsync(EventObjectOfIdbDatabase? callbackObject);
        ValueTask SetOnVersionChangeAsync(EventObjectOfIdbDatabase? callbackObject);
        ValueTask<IWrappedIdbTransaction> TransactionAsync(string[] storeNames);
        ValueTask<IWrappedIdbTransaction> TransactionAsync(string[] storeNames, IdbTransactionMode mode);
        ValueTask<IWrappedIdbTransaction> TransactionAsync(string[] storeNames, IdbTransactionOptions options);
        ValueTask<IWrappedIdbTransaction> TransactionAsync(
            string[] storeNames, IdbTransactionMode mode, IdbTransactionOptions options);
        ValueTask<int> GetVersionAsync();
    }
}
