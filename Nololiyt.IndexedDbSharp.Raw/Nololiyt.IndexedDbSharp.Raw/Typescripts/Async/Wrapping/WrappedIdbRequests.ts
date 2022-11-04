import { WrappedIdbTransaction } from "./WrappedIdbTransaction.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";
import { WrappedIdbCursor } from "./WrappedIdbCursor.js";
import { WrappedEvent } from "./WrappedEvent.js";
import { WrappedIdbCursorWithValue } from "./WrappedIdbCursorWithValue.js";
import { WrappedIdbDatabase } from "./WrappedIDbDatabase.js";
import { DotNetCallbackObject, invokeDotNetCallbackAsync } from "../Entities/DotNetCallbackObject.js";
import { IdbRequestSource } from "../UnionReturn/IdbRequestSource.js";
import { ObjectOrNull } from "../UnionReturn/ObjectOrNull.js";

export class WrappedIdbRequest<TWrapped, T>
{
    private wrapped;
    private conversion;
    constructor(wrapped: IDBRequest<TWrapped>, conversion: (result: TWrapped) => T)
    {
        this.wrapped = wrapped;
        this.conversion = conversion;
    }

    wrappedObject()
    {
        return this.wrapped;
    }

    setOnError(callbackObject: DotNetCallbackObject | null): void
    {
        let conversion = this.conversion;
        if (callbackObject)
            this.wrapped.onerror = async function (this: IDBRequest<TWrapped>, ev: Event)
            {
                const wrappedThis = new WrappedIdbRequest<TWrapped, T>(this, conversion);
                const wrappedEv = new WrappedEvent(ev);
                await invokeDotNetCallbackAsync(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onerror = null;
    }

    setOnSuccess(callbackObject: DotNetCallbackObject | null): void
    {
        let conversion = this.conversion;
        if (callbackObject)
            this.wrapped.onsuccess = async function (this: IDBRequest<TWrapped>, ev: Event)
            {
                const wrappedThis = new WrappedIdbRequest<TWrapped, T>(this, conversion);
                const wrappedEv = new WrappedEvent(ev);
                await invokeDotNetCallbackAsync(callbackObject, wrappedThis, wrappedEv);
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

    source(): IdbRequestSource
    {
        const source = this.wrapped.source;
        if (source instanceof IDBObjectStore)
        {
            return new IdbRequestSource(new WrappedIdbObjectStore(source));
        }
        if (source instanceof IDBIndex)
        {
            return new IdbRequestSource(new WrappedIdbIndex(source));
        }
        return new IdbRequestSource(new WrappedIdbCursor(source));
    }

    transaction(): ObjectOrNull<WrappedIdbTransaction>
    {
        const transaction = this.wrapped.transaction;
        if (transaction)
            return new ObjectOrNull(new WrappedIdbTransaction(transaction));
        else
            return new ObjectOrNull<WrappedIdbTransaction>(null);
    }

    // Methods addEventListener, removeEventListener and dispatchEvent are currently not provided.
    // The properties like onsuccess, onerror, ... are currently unreadable.
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
    extends WrappedIdbRequest<IDBCursor | null, ObjectOrNull<WrappedIdbCursor>>
{
    constructor(wrapped: IDBRequest<IDBCursor | null>)
    {
        super(wrapped, (result) =>
        {
            if (result === null)
                return new ObjectOrNull<WrappedIdbCursor>(null);
            return new ObjectOrNull(new WrappedIdbCursor(result));
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