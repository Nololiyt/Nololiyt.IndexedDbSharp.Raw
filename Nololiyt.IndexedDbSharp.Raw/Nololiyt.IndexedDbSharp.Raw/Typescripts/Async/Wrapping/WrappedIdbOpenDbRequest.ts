import { WrappedIdbDatabase } from "./WrappedIDbDatabase.js";
import { WrappedIdbObjectStore } from "./WrappedIdbObjectStore.js";
import { WrappedIdbIndex } from "./WrappedIdbIndex.js";
import { WrappedIdbRequest, WrappedIdbRequestOfIdbDatabase } from "./WrappedIdbRequests.js";
import { WrappedEvent } from "./WrappedEvent.js";
import { DotNetCallbackObject, invokeDotNetCallbackAsync } from "../Entities/DotNetCallbackObject.js";

export class WrappedIdbOpenDbRequest extends WrappedIdbRequest<IDBDatabase, WrappedIdbDatabase>
{
    private wrappedIDBOpenDBRequest;
    constructor(wrapped: IDBOpenDBRequest)
    {
        super(wrapped, (result) => new WrappedIdbDatabase(result));
        this.wrappedIDBOpenDBRequest = wrapped;
    }

    override wrappedObject(): IDBOpenDBRequest
    {
        return this.wrappedIDBOpenDBRequest;
    }

    setOnBlocked(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrappedIDBOpenDBRequest.onblocked =
                async function (this: IDBRequest<IDBDatabase>, ev: Event)
                {
                    const wrappedThis = new WrappedIdbRequestOfIdbDatabase(this);
                    const wrappedEv = new WrappedEvent(ev);
                    await invokeDotNetCallbackAsync(callbackObject, wrappedThis, wrappedEv);
                };
        else
            this.wrappedIDBOpenDBRequest.onblocked = null;
    }

    setOnUpgradeNeeded(callbackObject: DotNetCallbackObject | null): void
    {
        if (callbackObject)
            this.wrappedIDBOpenDBRequest.onupgradeneeded =
                async function (this: IDBRequest<IDBDatabase>, ev: Event)
                {
                    const wrappedThis = new WrappedIdbRequestOfIdbDatabase(this);
                    const wrappedEv = new WrappedEvent(ev);
                    await invokeDotNetCallbackAsync(callbackObject, wrappedThis, wrappedEv);
                };
        else
            this.wrappedIDBOpenDBRequest.onupgradeneeded = null;
    }
}