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
        ValueTask<IWrappedIdbRequest<long>> CountAsync();
        ValueTask<IWrappedIdbRequest<long>> CountAsync(IdbValidKey query);
        ValueTask<IWrappedIdbRequest<long>> CountAsync(IdbKeyRangeInfo query);
        ValueTask<IWrappedIdbRequest<TValue>> GetAsync<TValue>(IdbValidKey query);
        ValueTask<IWrappedIdbRequest<TValue>> GetAsync<TValue>(IdbKeyRangeInfo query);
        ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>();
        ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbValidKey? query);
        ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(
            int count);
        ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbValidKey? query, int count);
        ValueTask<IWrappedIdbRequest<TResultElement[]>> GetAllAsync<TResultElement>(
            IdbKeyRangeInfo? query, int count);

        ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync();
        ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(
            IdbValidKey? query);
        ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(
            int count);
        ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(
            IdbValidKey? query, int count);
        ValueTask<IWrappedIdbRequest<IdbValidKey[]>> GetAllKeysAsync(
            IdbKeyRangeInfo? query, int count);

        ValueTask<IWrappedIdbRequest<IdbValidKey?>> GetKeyAsync(IdbValidKey query);
        ValueTask<IWrappedIdbRequest<IdbValidKey?>> GetKeyAsync(IdbKeyRangeInfo query);
        ValueTask<IdbKeyPath> GetKeyPathAsync();
        ValueTask<bool> GetMultiEntryAsync();
        ValueTask<string> GetNameAsync();
        ValueTask<IWrappedIdbObjectStore> GetObjectStoreAsync();
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync();
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(
            IdbValidKey? query);
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(
            IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(
            IdbValidKey? query, IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursorWithValue?>> OpenCursorAsync(
            IdbKeyRangeInfo? query, IdbCursorDirection direction);

        ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync();
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(
            IdbValidKey? query);
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(
            IdbKeyRangeInfo? query);
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(
            IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(
            IdbValidKey? query, IdbCursorDirection direction);
        ValueTask<IWrappedIdbRequest<IWrappedIdbCursor?>> OpenKeyCursorAsync(
            IdbKeyRangeInfo? query, IdbCursorDirection direction);

        ValueTask<bool> GetUniqueAsync();
    }
}
