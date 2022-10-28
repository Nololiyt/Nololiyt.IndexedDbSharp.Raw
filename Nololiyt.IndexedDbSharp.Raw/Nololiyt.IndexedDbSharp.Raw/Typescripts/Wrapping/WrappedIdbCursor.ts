import { WrappedIdbRequestOfUndefined, WrappedIdbRequestOfAny } from "./WrappedIdbRequests.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";
import { IdbValidKeyInterop, toIdbValidKey, toIdbValidKeyInterop } from "../Entities/IdbValidKeyInterop.js";
import { DotNetDateTime } from "../Entities/DotNetDateTime.js";
import { DotNetByteArray } from "../Entities/DotNetByteArray.js";

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
    
    continue(key?: number | string | DotNetDateTime | DotNetByteArray | undefined): void
    {
        if (key === undefined)
            this.wrapped.continue();
        else
            this.wrapped.continue(toIdbValidKey(key));
    }

    continuePrimaryKey(
        key: IdbValidKeyInterop,
        primaryKey: IdbValidKeyInterop
    ): void
    {
        this.wrapped.continuePrimaryKey(toIdbValidKey(key), toIdbValidKey(primaryKey));
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

    key(): IdbValidKeyInterop
    {
        const result = this.wrapped.key;
        return toIdbValidKeyInterop(result);
    }

    primaryKey(): IdbValidKeyInterop
    {
        const result = this.wrapped.primaryKey;
        return toIdbValidKeyInterop(result);
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