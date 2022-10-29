import { convertToIdbKeyRange, IdbKeyRangeInfo, isIdbKeyRangeInfo } from "../Entities/IdbKeyRangeInfo.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbRequestOfAny, WrappedIdbRequestOfAnyArray, WrappedIdbRequestOfIdbCursorOrNull, WrappedIdbRequestOfIdbCursorWithValueOrNull, WrappedIdbRequestOfIdbValidKeyArray, WrappedIdbRequestOfIdbValidKeyOrUndefined, WrappedIdbRequestOfNumber } from "./WrappedIdbRequests.js";

export class WrappedIdbIndex
{
    private wrapped;
    constructor(wrapped: IDBIndex)
    {
        this.wrapped = wrapped;
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

    get(query: IDBValidKey | IdbKeyRangeInfo): WrappedIdbRequestOfAny
    {
        let result: IDBRequest<number>;
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

    getKey(query: IDBValidKey | IdbKeyRangeInfo): WrappedIdbRequestOfIdbValidKeyOrUndefined
    {
        let result: IDBRequest<IDBValidKey | undefined>;
        if (isIdbKeyRangeInfo(query))
            result = this.wrapped.getKey(convertToIdbKeyRange(query));
        else
            result = this.wrapped.getKey(query);
        return new WrappedIdbRequestOfIdbValidKeyOrUndefined(result);
    }

    keyPath(): string[]
    {
        const result = this.wrapped.keyPath;
        if (Array.isArray(result))
            return result;
        return [result];
    }

    multiEntry(): boolean
    {
        return this.wrapped.multiEntry;
    }

    name(): string
    {
        return this.wrapped.name;
    }

    objectStore(): WrappedIdbObjectStore
    {
        const result = this.wrapped.objectStore;
        return new WrappedIdbObjectStore(result);
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

    unique(): boolean
    {
        return this.wrapped.unique;
    }
}