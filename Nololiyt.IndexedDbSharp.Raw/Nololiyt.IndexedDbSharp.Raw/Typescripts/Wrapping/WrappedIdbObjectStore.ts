import { convertToIdbKeyRange, IdbKeyRangeInfo, isIdbKeyRangeInfo } from "../Entities/IdbKeyRangeInfo.js";
import { IdbValidKeyInterop, convertToIdbValidKey } from "../Entities/IdbValidKeyInterop.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";
import { WrappedIdbRequest, WrappedIdbRequestOfAny, WrappedIdbRequestOfAnyArray, WrappedIdbRequestOfIdbCursorOrNull, WrappedIdbRequestOfIdbCursorWithValueOrNull, WrappedIdbRequestOfIdbValidKey, WrappedIdbRequestOfIdbValidKeyArray, WrappedIdbRequestOfIdbValidKeyOrUndefined, WrappedIdbRequestOfNumber, WrappedIdbRequestOfUndefined } from "./WrappedIdbRequests.js";
import { WrappedIdbTransaction } from "./WrappedIdbTransaction.js";

export class WrappedIdbObjectStore
{
    private wrapped;
    constructor(wrapped: IDBObjectStore)
    {
        this.wrapped = wrapped;
    }

    add(value: any, key?: IdbValidKeyInterop | undefined): WrappedIdbRequestOfIdbValidKey
    {
        let result: IDBRequest<IDBValidKey>;
        if (key === undefined)
           result = this.wrapped.add(value, key);
        else
            result = this.wrapped.add(value, convertToIdbValidKey(key));
        return new WrappedIdbRequestOfIdbValidKey(result);
    }

    autoIncrement(): boolean
    {
        return this.wrapped.autoIncrement;
    }

    clear(): WrappedIdbRequestOfUndefined
    {
        const result = this.wrapped.clear();
        return new WrappedIdbRequestOfUndefined(result);
    }

    count(query?: IdbValidKeyInterop | IdbKeyRangeInfo | undefined): WrappedIdbRequestOfNumber
    {
        let result: IDBRequest<number>;
        if (query === undefined)
            result = this.wrapped.count(query);
        else if (isIdbKeyRangeInfo(query))
            result = this.wrapped.count(convertToIdbKeyRange(query));
        else
            result = this.wrapped.count(convertToIdbValidKey(query));
        return new WrappedIdbRequestOfNumber(result);
    }

    createIndex(
        name: string,
        keyPath: string | string[],
        options?: IDBIndexParameters | undefined): WrappedIdbIndex
    {
        const result = this.wrapped.createIndex(name, keyPath, options);
        return new WrappedIdbIndex(result);
    }

    delete(query: IdbValidKeyInterop | IdbKeyRangeInfo): WrappedIdbRequestOfUndefined
    {
        let result: IDBRequest<undefined>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.delete(convertToIdbKeyRange(query));
        else
            result = this.wrapped.delete(convertToIdbValidKey(query));
        return new WrappedIdbRequestOfUndefined(result);
    }

    deleteIndex(name: string): void
    {
        this.wrapped.deleteIndex(name);
    }

    get(query: IdbValidKeyInterop | IdbKeyRangeInfo): WrappedIdbRequestOfAny
    {
        let result: IDBRequest<any>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.get(convertToIdbKeyRange(query));
        else
            result = this.wrapped.get(convertToIdbValidKey(query));
        return new WrappedIdbRequestOfAny(result);
    }

    getAll(
        query?: IdbValidKeyInterop | IdbKeyRangeInfo | null | undefined,
        count?: number | undefined): WrappedIdbRequestOfAnyArray
    {
        let result: IDBRequest<any[]>;
        if (query === undefined || query === null)
            result = this.wrapped.getAll(query, count);
        else if (isIdbKeyRangeInfo(query))
            result = this.wrapped.getAll(convertToIdbKeyRange(query), count);
        else
            result = this.wrapped.getAll(convertToIdbValidKey(query), count);
        return new WrappedIdbRequestOfAnyArray(result);
    }

    getAllKeys(
        query?: IdbValidKeyInterop | IdbKeyRangeInfo | null | undefined,
        count?: number | undefined): WrappedIdbRequestOfIdbValidKeyArray
    {
        let result: IDBRequest<IDBValidKey[]>;
        if (query === undefined || query === null)
            result = this.wrapped.getAllKeys(query, count);
        else if (isIdbKeyRangeInfo(query))
            result = this.wrapped.getAllKeys(convertToIdbKeyRange(query), count);
        else
            result = this.wrapped.getAllKeys(convertToIdbValidKey(query), count);
        return new WrappedIdbRequestOfIdbValidKeyArray(result);
    }

    getKey(query: IdbValidKeyInterop | IdbKeyRangeInfo): WrappedIdbRequestOfIdbValidKeyOrUndefined
    {
        let result: IDBRequest<IDBValidKey | undefined>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.getKey(convertToIdbKeyRange(query),);
        else
            result = this.wrapped.getKey(convertToIdbValidKey(query));
        return new WrappedIdbRequestOfIdbValidKeyOrUndefined(result);
    }

    index(name: string): WrappedIdbIndex
    {
        const result = this.wrapped.index(name);
        return new WrappedIdbIndex(result);
    }

    indexNames(): string[]
    {
        const names = this.wrapped.indexNames;
        const result: string[] = [];
        for (const name in names)
            result.push(name);
        return result;
    }

    keyPath(): string[]
    {
        const result = this.wrapped.keyPath;
        if (Array.isArray(result))
            return result;
        return [result];
    }

    openCursor(
        query?: IdbValidKeyInterop | IdbKeyRangeInfo | null | undefined,
        direction?: IDBCursorDirection | undefined): WrappedIdbRequestOfIdbCursorWithValueOrNull
    {
        let result: IDBRequest<IDBCursorWithValue | null>;
        if (query === undefined || query === null)
            result = this.wrapped.openCursor(query, direction);
        else if (isIdbKeyRangeInfo(query))
            result = this.wrapped.openCursor(convertToIdbKeyRange(query), direction);
        else
            result = this.wrapped.openCursor(convertToIdbValidKey(query), direction);
        return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
    }

    openKeyCursor(
        query?: IdbValidKeyInterop | IdbKeyRangeInfo | null | undefined,
        direction?: IDBCursorDirection | undefined): WrappedIdbRequestOfIdbCursorOrNull
    {
        let result: IDBRequest<IDBCursor | null>;
        if (query === undefined || query === null)
            result = this.wrapped.openKeyCursor(query, direction);
        else if (isIdbKeyRangeInfo(query))
            result = this.wrapped.openKeyCursor(convertToIdbKeyRange(query), direction);
        else
            result = this.wrapped.openKeyCursor(convertToIdbValidKey(query), direction);
        return new WrappedIdbRequestOfIdbCursorOrNull(result);
    }

    put(value: any, key?: IdbValidKeyInterop | undefined): WrappedIdbRequestOfIdbValidKey
    {
        let result: IDBRequest<IDBValidKey>;
        if (key === undefined)
            result = this.wrapped.put(value, key);
        else
            result = this.wrapped.put(value, convertToIdbValidKey(key));
        return new WrappedIdbRequestOfIdbValidKey(result);
    }

    transaction(): WrappedIdbTransaction
    {
        const result = this.wrapped.transaction;
        return new WrappedIdbTransaction(result);
    }
}