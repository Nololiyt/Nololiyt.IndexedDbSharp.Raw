import { KnownError } from "./Entities/KnownError.js";
import { WrappedIdbFactory } from "./Wrapping/WrappedIdbFactory.js"

export function newWrappedIdbFactory(): WrappedIdbFactory
{
    if (window.indexedDB)
        return new WrappedIdbFactory(window.indexedDB);
    else
        throw new KnownError("The browser doesn't support IndexedDB.");
}