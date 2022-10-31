import { WrappedIdbFactory } from "./Wrapping/WrappedIdbFactory.js"

export function newWrappedIdbFactory(): WrappedIdbFactory | null
{
    if (window.indexedDB)
        return new WrappedIdbFactory(window.indexedDB);
    else
        return null;
}