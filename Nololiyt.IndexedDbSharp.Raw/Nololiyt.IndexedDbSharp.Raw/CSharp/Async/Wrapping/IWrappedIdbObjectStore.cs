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
        ValueTask<IWrappedIdbRequest<IdbValidKey>> AddAsync<TValue>(
            TValue value);
        ValueTask<IWrappedIdbRequest<IdbValidKey>> AddAsync<TValue>(
            TValue value, IdbValidKey key);

        ValueTask<bool> GetAutoIncrementAsync();
        ValueTask<IWrappedIdbRequestOfUndefined> ClearAsync();
        ValueTask<IWrappedIdbRequest<long>> CountAsync();
        ValueTask<IWrappedIdbRequest<long>> CountAsync(IdbValidKey query);
        ValueTask<IWrappedIdbRequest<long>> CountAsync(IdbKeyRangeInfo query);
        ValueTask<IWrappedIdbIndex> CreateIndexAsync(
            string name, IdbKeyPath keyPath);
        ValueTask<IWrappedIdbIndex> CreateIndexAsync(
            string name, IdbKeyPath keyPath, IdbIndexParameters options);
        ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync(IdbValidKey query);
        ValueTask<IWrappedIdbRequestOfUndefined> DeleteAsync(IdbKeyRangeInfo query);
        ValueTask DeleteIndexAsync(string name);

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

        ValueTask<IWrappedIdbIndex> IndexAsync(string name);
        ValueTask<string[]> GetIndexNamesAsync();
        ValueTask<IdbKeyPath> GetKeyPathAsync();

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

        ValueTask<IWrappedIdbRequest<IdbValidKey>> PutAsync<TValue>(TValue value);
        ValueTask<IWrappedIdbRequest<IdbValidKey>> PutAsync<TValue>(TValue value, IdbValidKey key);

        ValueTask<IWrappedIdbTransaction> GetTransactionAsync();
    }
}
