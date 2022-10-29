import { DotNetCallbackObject, invokeDotNetCallback } from "../Entities/DotNetCallbackObject.js";
import { WrappedEvent } from "./WrappedEvent.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbTransaction } from "./WrappedIdbTransaction.js";

export class WrappedIdbDatabase
{
    private wrapped;
    constructor(wrapped: IDBDatabase)
    {
        this.wrapped = wrapped;
    }

    close(): void
    {
        this.wrapped.close();
    }

    createObjectStore(name: string, options?: IDBObjectStoreParameters | undefined): WrappedIdbObjectStore
    {
        const result = this.wrapped.createObjectStore(name, options);
        return new WrappedIdbObjectStore(result);
    }

    deleteObjectStore(name: string): void
    {
        this.wrapped.deleteObjectStore(name);
    }

    name(): string
    {
        return this.wrapped.name;
    }

    objectStoreNames(): string[]
    {
        const result = this.wrapped.objectStoreNames;
        const array: string[] = [];
        for (const item of result)
        {
            array.push(item);
        }
        return array;
    }

    setOnAbort(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onabort = function (this: IDBDatabase, ev: Event)
            {
                const wrappedThis = new WrappedIdbDatabase(this);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onabort = null;
    }

    setOnClose(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onclose = function (this: IDBDatabase, ev: Event)
            {
                const wrappedThis = new WrappedIdbDatabase(this);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onclose = null;
    }

    setOnError(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onerror = function (this: IDBDatabase, ev: Event)
            {
                const wrappedThis = new WrappedIdbDatabase(this);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onerror = null;
    }

    setOnVersionChange(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrapped.onversionchange = function (this: IDBDatabase, ev: Event)
            {
                const wrappedThis = new WrappedIdbDatabase(this);
                const wrappedEv = new WrappedEvent(ev);
                invokeDotNetCallback(callbackObject, wrappedThis, wrappedEv);
            };
        else
            this.wrapped.onversionchange = null;
    }

    transaction(
        storeNames: string[],
        mode?: IDBTransactionMode | undefined,
        options?: IDBTransactionOptions | undefined): WrappedIdbTransaction
    {
        const result = this.wrapped.transaction(storeNames, mode, options);
        return new WrappedIdbTransaction(result);
    }

    version(): number
    {
        return this.wrapped.version;
    }
}