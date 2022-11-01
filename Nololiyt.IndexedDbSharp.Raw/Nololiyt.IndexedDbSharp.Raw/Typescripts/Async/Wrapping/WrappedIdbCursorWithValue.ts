import { WrappedIdbRequestOfUndefined, WrappedIdbRequestOfAny, WrappedIdbRequestOfIdbValidKey } from "./WrappedIdbRequests.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";
import { IdbCursorSource } from "../UnionReturn/IdbCursorSource.js";
import { AnyReturn } from "../UnionReturn/AnyReturn.js";

export class WrappedIdbCursorWithValue
{
    private wrapped;
    constructor(wrapped: IDBCursorWithValue)
    {
        this.wrapped = wrapped;
    }

    wrappedObject()
    {
        return this.wrapped;
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

    source(): IdbCursorSource
    {
        const result = this.wrapped.source;
        if (result instanceof IDBObjectStore)
        {
            return new IdbCursorSource(new WrappedIdbObjectStore(result));
        }
        return new IdbCursorSource(new WrappedIdbIndex(result));
    }

    update(value: any): WrappedIdbRequestOfIdbValidKey
    {
        const result = this.wrapped.update(value);
        return new WrappedIdbRequestOfIdbValidKey(result);
    }

    value(): AnyReturn
    {
        return new AnyReturn(this.wrapped.value);
    }
}