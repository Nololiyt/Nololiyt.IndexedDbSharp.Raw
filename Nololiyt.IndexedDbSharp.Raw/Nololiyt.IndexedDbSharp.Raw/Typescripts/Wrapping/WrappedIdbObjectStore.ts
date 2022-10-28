import { IdbKeyRangeInfo } from "../Entities/IdbKeyRangeInfo.js";
import { IdbValidKeyInterop, toIdbValidKey } from "../Entities/IdbValidKeyInterop.js";
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
            result = this.wrapped.add(value, toIdbValidKey(key));
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
        else if (query instanceof IdbKeyRangeInfo)
            result = this.wrapped.count(query.toIdbKeyRange());
        else
            result = this.wrapped.count(toIdbValidKey(query));
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
        if (query instanceof IdbKeyRangeInfo)
            result = this.wrapped.delete(query.toIdbKeyRange());
        else
            result = this.wrapped.delete(toIdbValidKey(query));
        return new WrappedIdbRequestOfUndefined(result);
    }

    deleteIndex(name: string): void
    {
        this.wrapped.deleteIndex(name);
    }

    get(query: IdbValidKeyInterop | IdbKeyRangeInfo): WrappedIdbRequestOfAny
    {
        let result: IDBRequest<any>;
        if (query instanceof IdbKeyRangeInfo)
            result = this.wrapped.get(query.toIdbKeyRange());
        else
            result = this.wrapped.get(toIdbValidKey(query));
        return new WrappedIdbRequestOfAny(result);
    }

    getAll(
        query?: IdbValidKeyInterop | IdbKeyRangeInfo | null | undefined,
        count?: number | undefined): WrappedIdbRequestOfAnyArray
    {
        let result: IDBRequest<any[]>;
        if (query === undefined || query === null)
            result = this.wrapped.getAll(query, count);
        else if (query instanceof IdbKeyRangeInfo)
            result = this.wrapped.getAll(query.toIdbKeyRange(), count);
        else
            result = this.wrapped.getAll(toIdbValidKey(query), count);
        return new WrappedIdbRequestOfAnyArray(result);
    }

    getAllKeys(
        query?: IdbValidKeyInterop | IdbKeyRangeInfo | null | undefined,
        count?: number | undefined): WrappedIdbRequestOfIdbValidKeyArray
    {
        let result: IDBRequest<IDBValidKey[]>;
        if (query === undefined || query === null)
            result = this.wrapped.getAllKeys(query, count);
        else if (query instanceof IdbKeyRangeInfo)
            result = this.wrapped.getAll(query.toIdbKeyRange(), count);
        else
            result = this.wrapped.getAll(toIdbValidKey(query), count);
        return new WrappedIdbRequestOfIdbValidKeyArray(result);
    }

    getKey(query: IdbValidKeyInterop | IdbKeyRangeInfo): WrappedIdbRequestOfIdbValidKeyOrUndefined
    {
        let result: IDBRequest<IDBValidKey | undefined>;
        if (query instanceof IdbKeyRangeInfo)
            result = this.wrapped.getKey(query.toIdbKeyRange());
        else
            result = this.wrapped.getKey(toIdbValidKey(query));
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
        else if (query instanceof IdbKeyRangeInfo)
            result = this.wrapped.openCursor(query.toIdbKeyRange(), direction);
        else
            result = this.wrapped.openCursor(toIdbValidKey(query), direction);
        return new WrappedIdbRequestOfIdbCursorWithValueOrNull(result);
    }

    openKeyCursor(
        query?: IdbValidKeyInterop | IdbKeyRangeInfo | null | undefined,
        direction?: IDBCursorDirection | undefined): WrappedIdbRequestOfIdbCursorOrNull
    {
        let result: IDBRequest<IDBCursor | null>;
        if (query === undefined || query === null)
            result = this.wrapped.openKeyCursor(query, direction);
        else if (query instanceof IdbKeyRangeInfo)
            result = this.wrapped.openKeyCursor(query.toIdbKeyRange(), direction);
        else
            result = this.wrapped.openKeyCursor(toIdbValidKey(query), direction);
        return new WrappedIdbRequestOfIdbCursorOrNull(result);
    }

    put(value: any, key?: IdbValidKeyInterop | undefined): WrappedIdbRequestOfIdbValidKey
    {
        let result: IDBRequest<IDBValidKey>;
        if (key === undefined)
            result = this.wrapped.put(value, key);
        else
            result = this.wrapped.put(value, toIdbValidKey(key));
        return new WrappedIdbRequestOfIdbValidKey(result);
    }

    transaction(): WrappedIdbTransaction
    {
        const result = this.wrapped.transaction;
        return new WrappedIdbTransaction(result);
    }
}