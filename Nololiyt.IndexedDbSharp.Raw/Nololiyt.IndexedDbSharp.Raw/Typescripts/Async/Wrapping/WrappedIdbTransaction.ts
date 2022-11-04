import { DotNetCallbackObject, invokeDotNetCallbackAsync } from "../Entities/DotNetCallbackObject.js";
import { ObjectOrNull } from "../UnionReturn/ObjectOrNull.js";
import { WrappedDomException } from "./WrappedDomException.js";
import { WrappedEvent } from "./WrappedEvent.js";
import { WrappedIdbDatabase } from "./WrappedIDbDatabase.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";

export class WrappedIdbTransaction
{
    private wrapped;
    constructor(wrapped: IDBTransaction)
    {
        this.wrapped = wrapped;
    }

    wrappedObject()
    {
        return this.wrapped;
    }

    abort(): void
    {
        this.wrapped.abort();
    }

    commit(): void
    {
        this.wrapped.commit();
    }

    db(): WrappedIdbDatabase
    {
        const result = this.wrapped.db;
        return new WrappedIdbDatabase(result);
    }

    durability(): IDBTransactionDurability
    {
        return this.wrapped.durability;
    }

    error(): ObjectOrNull<WrappedDomException>
    {
        const result = this.wrapped.error;
        if (result)
            return new ObjectOrNull(new WrappedDomException(result));
        return new ObjectOrNull<WrappedDomException>(null);
    }

    mode(): IDBTransactionMode
    {
        return this.wrapped.mode;
    }

    objectStore(name: string): WrappedIdbObjectStore
    {
        const result = this.wrapped.objectStore(name);
        return new WrappedIdbObjectStore(result);
    }

    objectStoreNames(): string[]
    {
        const names = this.wrapped.objectStoreNames;
        const result = [];
        for (const name of names)
            result.push(name);
        return result;
    }

    setOnAbort(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onabort = async function (this: IDBTransaction, ev: Event)
            {
                const wrappedThis = new WrappedIdbTransaction(this);
                const wrappedEv = new WrappedEvent(ev);
                await invokeDotNetCallbackAsync(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onabort = null;
    }

    setOnComplete(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.oncomplete = async function (this: IDBTransaction, ev: Event)
            {
                const wrappedThis = new WrappedIdbTransaction(this);
                const wrappedEv = new WrappedEvent(ev);
                await invokeDotNetCallbackAsync(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.oncomplete = null;
    }

    setOnError(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onerror = async function (this: IDBTransaction, ev: Event)
            {
                const wrappedThis = new WrappedIdbTransaction(this);
                const wrappedEv = new WrappedEvent(ev);
                await invokeDotNetCallbackAsync(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onerror = null;
    }

    // Methods addEventListener, removeEventListener and dispatchEvent are currently not provided.
    // The properties like oncomplete, onerror, ... are currently unreadable.
}