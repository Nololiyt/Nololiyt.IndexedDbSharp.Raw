import { WrappedIdbDatabase } from "./WrappedIDbDatabase.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";
import { WrappedIdbCursor } from "./WrappedIdbCursor.js";
import { WrappedIdbRequestOfIdbDatabase } from "./WrappedIdbRequests.js";
import { WrappedEvent } from "./WrappedEvent.js";
import { WrappedIdbTransaction } from "./WrappedIdbTransaction.js";
import { DotNetCallbackObject, invokeDotNetCallback } from "../Entities/DotNetCallbackObject.js";

export class WrappedIdbOpenDbRequest
{
    private wrapped;
    constructor(wrapped: IDBOpenDBRequest)
    {
        this.wrapped = wrapped;
    }

    setOnError(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onerror = function (this: IDBRequest<IDBDatabase>, ev: Event)
            {
                const wrappedThis = new WrappedIdbRequestOfIdbDatabase(this);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onerror = null;
    }

    setOnSuccess(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onsuccess = function (this: IDBRequest<IDBDatabase>, ev: Event)
            {
                const wrappedThis = new WrappedIdbRequestOfIdbDatabase(this);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onsuccess = null;
    }

    setOnBlocked(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onblocked = function (this: IDBRequest<IDBDatabase>, ev: Event)
            {
                const wrappedThis = new WrappedIdbRequestOfIdbDatabase(this);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onblocked = null;
    }

    setOnUpgradeNeeded(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onupgradeneeded = function (this: IDBRequest<IDBDatabase>, ev: Event)
            {
                const wrappedThis = new WrappedIdbRequestOfIdbDatabase(this);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onupgradeneeded = null;
    }

    result(): WrappedIdbDatabase
    {
        return new WrappedIdbDatabase(this.wrapped.result);
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