import { convertToIdbKeyRange, IdbKeyRangeInfo, isIdbKeyRangeInfo } from "../Entities/IdbKeyRangeInfo.js";
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

    wrappedObject()
    {
        return this.wrapped;
    }

    add(value: any, key?: IDBValidKey | undefined): WrappedIdbRequestOfIdbValidKey
    {
        const result = this.wrapped.add(value, key);
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

    count(query?: IDBValidKey | IdbKeyRangeInfo | undefined): WrappedIdbRequestOfNumber
    {
        let result: IDBRequest<number>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.count(convertToIdbKeyRange(query));
        else
            result = this.wrapped.count(query);
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

    delete(query: IDBValidKey | IdbKeyRangeInfo): WrappedIdbRequestOfUndefined
    {
        let result: IDBRequest<undefined>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.delete(convertToIdbKeyRange(query));
        else
            result = this.wrapped.delete(query);
        return new WrappedIdbRequestOfUndefined(result);
    }

    deleteIndex(name: string): void
    {
        this.wrapped.deleteIndex(name);
    }

    get(query: IDBValidKey | IdbKeyRangeInfo): WrappedIdbRequestOfAny
    {
        let result: IDBRequest<any>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.get(convertToIdbKeyRange(query));
        else
            result = this.wrapped.get(query);
        return new WrappedIdbRequestOfAny(result);
    }

    getAll(
        query?: IDBValidKey | IdbKeyRangeInfo | null | undefined,
        count?: number | undefined): WrappedIdbRequestOfAnyArray
    {
        let result: IDBRequest<any[]>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.getAll(convertToIdbKeyRange(query), count);
        else
            result = this.wrapped.getAll(query, count);
        return new WrappedIdbRequestOfAnyArray(result);
    }
    getAllSkipQuery(count?: number | undefined): WrappedIdbRequestOfAnyArray
    {
        let result: IDBRequest<any[]>;
        result = this.wrapped.getAll(undefined, count);
        return new WrappedIdbRequestOfAnyArray(result);
    }

    getAllKeys(
        query?: IDBValidKey | IdbKeyRangeInfo | null | undefined,
        count?: number | undefined): WrappedIdbRequestOfIdbValidKeyArray
    {
        let result: IDBRequest<IDBValidKey[]>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.getAllKeys(convertToIdbKeyRange(query), count);
        else
            result = this.wrapped.getAllKeys(query, count);
        return new WrappedIdbRequestOfIdbValidKeyArray(result);
    }
    getAllKeysSkipQuery(count?: number | undefined): WrappedIdbRequestOfIdbValidKeyArray
    {
        let result: IDBRequest<IDBValidKey[]>;
        result = this.wrapped.getAllKeys(undefined, count);
        return new WrappedIdbRequestOfIdbValidKeyArray(result);
    }

    getKey(query: IDBValidKey | IdbKeyRangeInfo): WrappedIdbRequestOfIdbValidKeyOrUndefined
    {
        let result: IDBRequest<IDBValidKey | undefined>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.getKey(convertToIdbKeyRange(query));
        else
            result = this.wrapped.getKey(query);
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

    keyPath(): string | string[]
    {
        return this.wrapped.keyPath;
    }

    openCursor(
        query?: IDBValidKey | IdbKeyRangeInfo | null | undefined,
        direction?: IDBCursorDirection | undefined): WrappedIdbRequestOfIdbCursorWithValueOrNull
    {
        let result: IDBRequest<IDBCursorWithValue | null>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.openCursor(convertToIdbKeyRange(query), direction);
        else
            result = this.wrapped.openCursor(query, direction);
        return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
    }
    openCursorSkipQuery(direction?: IDBCursorDirection | undefined): WrappedIdbRequestOfIdbCursorWithValueOrNull
    {
        let result: IDBRequest<IDBCursorWithValue | null>;
        result = this.wrapped.openCursor(undefined, direction);
        return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
    }

    openKeyCursor(
        query?: IDBValidKey | IdbKeyRangeInfo | null | undefined,
        direction?: IDBCursorDirection | undefined): WrappedIdbRequestOfIdbCursorOrNull
    {
        let result: IDBRequest<IDBCursor | null>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.openKeyCursor(convertToIdbKeyRange(query), direction);
        else
            result = this.wrapped.openKeyCursor(query, direction);
        return new WrappedIdbRequestOfIdbCursorOrNull(result);
    }
    openKeyCursorSkipQuery(direction?: IDBCursorDirection | undefined): WrappedIdbRequestOfIdbCursorOrNull
    {
        let result: IDBRequest<IDBCursor | null>;
        result = this.wrapped.openKeyCursor(undefined, direction);
        return new WrappedIdbRequestOfIdbCursorOrNull(result);
    }

    put(value: any, key?: IDBValidKey | undefined): WrappedIdbRequestOfIdbValidKey
    {
        const result = this.wrapped.put(value, key);
        return new WrappedIdbRequestOfIdbValidKey(result);
    }

    transaction(): WrappedIdbTransaction
    {
        const result = this.wrapped.transaction;
        return new WrappedIdbTransaction(result);
    }
}