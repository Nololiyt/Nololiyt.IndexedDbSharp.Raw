import { WrappedIdbTransaction } from "./WrappedIdbTransaction.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";
import { WrappedIdbCursor } from "./WrappedIdbCursor.js";
import { WrappedEvent } from "./WrappedEvent.js";
import { WrappedIdbCursorWithValue } from "./WrappedIdbCursorWithValue.js";
import { WrappedIdbDatabase } from "./WrappedIDbDatabase.js";
import { DotNetCallbackObject, invokeDotNetCallback } from "../Entities/DotNetCallbackObject.js";

export class WrappedIdbRequest<TWrapped, T>
{
    private wrapped;
    private conversion;
    constructor(wrapped: IDBRequest<TWrapped>, conversion: (result: TWrapped) => T)
    {
        this.wrapped = wrapped;
        this.conversion = conversion;
    }

    setOnError(callbackObject: DotNetCallbackObject | null): void
    {
        let conversion = this.conversion;
        if (callbackObject)
            this.wrapped.onerror = function (this: IDBRequest<TWrapped>, ev: Event)
            {
                const wrappedThis = new WrappedIdbRequest<TWrapped, T>(this, conversion);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onerror = null;
    }

    setOnSuccess(callbackObject: DotNetCallbackObject | null): void
    {
        let conversion = this.conversion;
        if (callbackObject)
            this.wrapped.onsuccess = function (this: IDBRequest<any>, ev: Event)
            {
                const wrappedThis = new WrappedIdbRequest<TWrapped, T>(this, conversion);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onsuccess = null;
    }

    result(): T
    {
        return this.conversion(this.wrapped.result);
    }

    readyState(): IDBRequestReadyState
    {
        return this.wrapped.readyState;
    }

    source(): WrappedIdbObjectStore | WrappedIdbIndex | WrappedIdbCursor
    {
        const source = this.wrapped.source;
        if (source instanceof IDBObjectStore)
        {
            return new WrappedIdbObjectStore(source);
        }
        if (source instanceof IDBIndex)
        {
            return new WrappedIdbIndex(source);
        }
        return new WrappedIdbCursor(source);
    }

    transaction(): WrappedIdbTransaction | null
    {
        const transaction = this.wrapped.transaction;
        if (transaction)
            return new WrappedIdbTransaction(transaction);
        else
            return null;
    }
}

export class WrappedIdbRequestOfAny extends WrappedIdbRequest<any, any>
{
    constructor(wrapped: IDBRequest<any>)
    {
        super(wrapped, (result) =>
        {
            return result;
        });
    }
}

export class WrappedIdbRequestOfAnyArray extends WrappedIdbRequest<any[], any[]>
{
    constructor(wrapped: IDBRequest<any[]>)
    {
        super(wrapped, (result) =>
        {
            return result;
        });
    }
}

export class WrappedIdbRequestOfIdbCursorOrNull
    extends WrappedIdbRequest<IDBCursor | null, WrappedIdbCursor | null>
{
    constructor(wrapped: IDBRequest<IDBCursor | null>)
    {
        super(wrapped, (result) =>
        {
            if (result === null)
                return null;
            return new WrappedIdbCursor(result);
        });
    }
}

export class WrappedIdbRequestOfIdbCursorWithValueOrNull
    extends WrappedIdbRequest<IDBCursorWithValue | null, WrappedIdbCursorWithValue | null>
{
    constructor(wrapped: IDBRequest<IDBCursorWithValue | null>)
    {
        super(wrapped, (result) =>
        {
            if (result === null)
                return null;
            return new WrappedIdbCursorWithValue(result);
        });
    }
}

export class WrappedIdbRequestOfIdbDatabase
    extends WrappedIdbRequest<IDBDatabase, WrappedIdbDatabase>
{
    constructor(wrapped: IDBRequest<IDBDatabase>)
    {
        super(wrapped, (result) =>
        {
            return new WrappedIdbDatabase(result);
        });
    }
}

export class WrappedIdbRequestOfIdbValidKey
    extends WrappedIdbRequest<IDBValidKey, IDBValidKey>
{
    constructor(wrapped: IDBRequest<IDBValidKey>)
    {
        super(wrapped, (result) =>
        {
            return result;
        });
    }
}

export class WrappedIdbRequestOfIdbValidKeyArray
    extends WrappedIdbRequest<IDBValidKey[], IDBValidKey[]>
{
    constructor(wrapped: IDBRequest<IDBValidKey[]>)
    {
        super(wrapped, (result) =>
        {
            return result;
        });
    }
}

export class WrappedIdbRequestOfIdbValidKeyOrUndefined
    extends WrappedIdbRequest<IDBValidKey | undefined, IDBValidKey | undefined>
{
    constructor(wrapped: IDBRequest<IDBValidKey | undefined>)
    {
        super(wrapped, (result) =>
        {
            return result;
        });
    }
}

export class WrappedIdbRequestOfNumber
    extends WrappedIdbRequest<number, number>
{
    constructor(wrapped: IDBRequest<number>)
    {
        super(wrapped, (result) =>
        {
            return result;
        });
    }
}

export class WrappedIdbRequestOfUndefined
    extends WrappedIdbRequest<undefined, undefined>
{
    constructor(wrapped: IDBRequest<undefined>)
    {
        super(wrapped, (result) =>
        {
            return result;
        });
    }
}