import { WrappedIdbRequestOfUndefined, WrappedIdbRequestOfAny } from "./WrappedIdbRequests.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";


export class WrappedIdbCursor
{
    private wrapped;
    constructor(wrapped: IDBCursor)
    {
        this.wrapped = wrapped;
    }

    advance(count: number): void
    {
        this.wrapped.advance(count);
    }
    
    continue(key?: IDBValidKey | undefined): void
    {
        this.wrapped.continue(key);
    }

    continuePrimaryKey(
        key: IDBValidKey,
        primaryKey: IDBValidKey
    ): void
    {
        this.wrapped.continuePrimaryKey(key, primaryKey);
    }

    delete(): WrappedIdbRequestOfUndefined
    {
        const result = this.wrapped.delete();
        return new WrappedIdbRequestOfUndefined(result);
    }

    direction(): IDBCursorDirection
    {
        const result = this.wrapped.direction;
        return result;
    }

    key(): IDBValidKey
    {
        return this.wrapped.key;
    }

    primaryKey(): IDBValidKey
    {
        return this.wrapped.primaryKey;
    }

    request(): WrappedIdbRequestOfAny
    {
        const result = this.wrapped.request;
        return new WrappedIdbRequestOfAny(result);
    }

    source(): WrappedIdbObjectStore | WrappedIdbIndex
    {
        const result = this.wrapped.source;
        if (result instanceof IDBObjectStore)
        {
            return new WrappedIdbObjectStore(result);
        }
        return new WrappedIdbIndex(result);
    }
}