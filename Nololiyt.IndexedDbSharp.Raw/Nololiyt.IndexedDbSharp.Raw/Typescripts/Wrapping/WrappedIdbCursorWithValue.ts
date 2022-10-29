import { WrappedIdbRequestOfUndefined, WrappedIdbRequestOfAny, WrappedIdbRequestOfIdbValidKey } from "./WrappedIdbRequests.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";
import { IdbValidKeyInterop, convertToIdbValidKey, convertToIdbValidKeyInterop } from "../Entities/IdbValidKeyInterop.js";
import { DotNetDateTime } from "../Entities/DotNetDateTime.js";
import { DotNetByteArray } from "../Entities/DotNetByteArray.js";

export class WrappedIdbCursorWithValue
{
    private wrapped;
    constructor(wrapped: IDBCursorWithValue)
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
            this.wrapped.continue(convertToIdbValidKey(key));
    }

    continuePrimaryKey(
        key: IdbValidKeyInterop,
        primaryKey: IdbValidKeyInterop
    ): void
    {
        this.wrapped.continuePrimaryKey(convertToIdbValidKey(key), convertToIdbValidKey(primaryKey));
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
        return convertToIdbValidKeyInterop(result);
    }

    primaryKey(): IdbValidKeyInterop
    {
        const result = this.wrapped.primaryKey;
        return convertToIdbValidKeyInterop(result);
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

    update(value: any): WrappedIdbRequestOfIdbValidKey
    {
        const result = this.wrapped.update(value);
        return new WrappedIdbRequestOfIdbValidKey(result);
    }

    value(): any
    {
        return this.wrapped.value;
    }
}