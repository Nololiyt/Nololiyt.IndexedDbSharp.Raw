import { IdbKeyRangeInfo } from "../Entities/IdbKeyRangeInfo.js";
import { IdbValidKeyInterop, toIdbValidKey } from "../Entities/IdbValidKeyInterop.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbRequestOfAny, WrappedIdbRequestOfAnyArray, WrappedIdbRequestOfIdbCursorOrNull, WrappedIdbRequestOfIdbCursorWithValueOrNull, WrappedIdbRequestOfIdbValidKeyArray, WrappedIdbRequestOfIdbValidKeyOrUndefined, WrappedIdbRequestOfNumber } from "./WrappedIdbRequests.js";

export class WrappedIdbIndex
{
    private wrapped;
    constructor(wrapped: IDBIndex)
    {
        this.wrapped = wrapped;
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

    get(query: IdbValidKeyInterop | IdbKeyRangeInfo): WrappedIdbRequestOfAny
    {
        let result: IDBRequest<number>;
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
            result = this.wrapped.getAllKeys(query.toIdbKeyRange(), count);
        else
            result = this.wrapped.getAllKeys(toIdbValidKey(query), count);
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

    unique(): boolean
    {
        return this.wrapped.unique;
    }
}