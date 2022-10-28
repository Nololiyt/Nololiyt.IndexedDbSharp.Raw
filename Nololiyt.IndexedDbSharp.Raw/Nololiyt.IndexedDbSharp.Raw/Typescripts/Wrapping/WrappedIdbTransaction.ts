import { DotNetCallbackObject } from "../Entities/DotNetCallbackObject.js";
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

    error(): WrappedDomException | null
    {
        const result = this.wrapped.error;
        if (result)
            return new WrappedDomException(result);
        return null;
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
            this.wrapped.onabort = function (this: IDBTransaction, ev: Event)
            {
                const wrappedThis = new WrappedIdbTransaction(this);
                const wrappedEv = new WrappedEvent(ev);
                callbackObject.InvokeCallback(wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onabort = null;
    }

    setOnComplete(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.oncomplete = function (this: IDBTransaction, ev: Event)
            {
                const wrappedThis = new WrappedIdbTransaction(this);
                const wrappedEv = new WrappedEvent(ev);
                callbackObject.InvokeCallback(wrappedThis, wrappedEv);
            };
        else
            this.wrapped.oncomplete = null;
    }

    setOnError(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onerror = function (this: IDBTransaction, ev: Event)
            {
                const wrappedThis = new WrappedIdbTransaction(this);
                const wrappedEv = new WrappedEvent(ev);
                callbackObject.InvokeCallback(wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onerror = null;
    }
}