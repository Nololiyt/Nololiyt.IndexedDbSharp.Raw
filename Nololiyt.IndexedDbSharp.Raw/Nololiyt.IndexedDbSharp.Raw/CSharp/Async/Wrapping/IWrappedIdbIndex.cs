using Microsoft.JSInterop;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Async.Wrapping
{
    public interface IWrappedIdbIndex : IWrappedWrappedJsObject
    {
        ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync();
        ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync<TKey>(TKey query);
        ValueTask<IWrappedIdbRequestOfValue<long>> CountAsync(IdbKeyRangeInfo query);
        ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TKey, TValue>(TKey query);
        ValueTask<IWrappedIdbRequestOfValue<TValue>> GetAsync<TValue>(IdbKeyRangeInfo query);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>();
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TKey, TResultElement>(
            TKey? query);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(
            int count);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TKey, TResultElement>(
            TKey? query, int count);
        ValueTask<IWrappedIdbRequestOfValue<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbKeyRangeInfo? query, int count);

        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>();
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TKey, TResultKeyElement>(
            TKey? query);
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(
            int count);
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TKey, TResultKeyElement>(
            TKey? query, int count);
        ValueTask<IWrappedIdbRequestOfValue<TResultKeyElement[]>> GetAllKeysAsync<TResultKeyElement>(
            IdbKeyRangeInfo? query, int count);

        ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TKey, TResultKey>(TKey query);
        ValueTask<IWrappedIdbRequestOfValue<TResultKey?>> GetKeyAsync<TResultKey>(
            IdbKeyRangeInfo query);
        ValueTask<IdbKeyPath> GetKeyPathAsync();
        ValueTask<bool> GetMultiEntryAsync();
        ValueTask<string> GetNameAsync();
        ValueTask<IWrappedIdbObjectStore> GetObjectStoreAsync();
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync();
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync<TKey>(
            TKey? query);
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync(
            IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync<TKey>(
            TKey? query, IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequestOfIdbCursorWithValue> OpenCursorAsync(
            IdbKeyRangeInfo? query, IdbCursorDirection direction);

        ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync();
        ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync<TKey>(
            TKey? query);
        ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync(
            IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync<TKey>(
            TKey? query, IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequestOfIdbCursor> OpenKeyCursorAsync(
            IdbKeyRangeInfo? query, IdbCursorDirection direction);

        ValueTask<bool> GetUniqueAsync();
    }
}
