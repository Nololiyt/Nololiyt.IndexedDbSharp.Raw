using Microsoft.Extensions.Options;
using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbObjectStore : IWrappedWrappedJsObject
    {
        ValueTask<IWrappedIdbRequestOfValue<TResultKey>> AddAsync<TValue, TResultKey>(
            TValue value);
        ValueTask<IWrappedIdbRequestOfValue<TResultKey>> AddAsync<TValue, TKey, TResultKey>(
            TValue value, TKey key);

        ValueTask<bool> GetAutoIncrementAsync();
        ValueTask<IWrappedIdbRequestOfUndefined> ClearAsync();
        ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync();
        ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync<TKey>(TKey query);
        ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync(IdbKeyRangeInfo query);
        ValueTask<IWrappedIdbIndex> CreateIndexAsync(
            string name, IdbKeyPath keyPath);
        ValueTask<IWrappedIdbIndex> CreateIndexAsync(
            string name, IdbKeyPath keyPath, IdbIndexParameters options);
        ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync<TKey>(TKey query);
        ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync(IdbKeyRangeInfo query);
        ValueTask DeleteIndexAsync(string name);

        ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue, TKey>(TKey query);
        ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue>(IdbKeyRangeInfo query);


        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>();
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement, TKey>(
            TKey? query);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(
            int count);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement, TKey>(
            TKey? query, int count);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbKeyRangeInfo? query, int count);


        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>();
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>>
            GetAllKeysAsync<TKey, TResultKeyElement>(TKey? query);
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(
            int count);
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>>
            GetAllKeysAsync<TKey, TResultKeyElement>(TKey? query, int count);
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(
            IdbKeyRangeInfo? query, int count);

        ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TKey, TResultKey>(TKey query);
        ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TResultKey>(IdbKeyRangeInfo query);

        ValueTask<IWrappedIdbIndex> IndexAsync(string name);
        ValueTask<string[]> GetIndexNamesAsync();
        ValueTask<IdbKeyPath> GetKeyPathAsync();

        ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> OpenCursorAsync();
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> OpenCursorAsync<TKey>(
            TKey? query);
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> OpenCursorAsync(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> OpenCursorAsync(
            IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> OpenCursorAsync<TKey>(
            TKey? query, IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValueOrNull> OpenCursorAsync(
            IdbKeyRangeInfo? query, IdbCursorDirection direction);

        ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync();
        ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync<TKey>(TKey? query);
        ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync(
            IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync<TKey>(
            TKey? query, IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequestOfIdbCursorOrNull> OpenKeyCursorAsync(
            IdbKeyRangeInfo? query, IdbCursorDirection direction);

        ValueTask<IWrappedIdbRequestOfValue<TResultKey>> PutAsync<TValue, TResultKey>(TValue value);
        ValueTask<IWrappedIdbRequestOfValue<TResultKey>> PutAsync<TValue, TKey, TResultKey>(TValue value, TKey key);

        ValueTask<IWrappedIdbTransaction> GetTransactionAsync();
    }
}
