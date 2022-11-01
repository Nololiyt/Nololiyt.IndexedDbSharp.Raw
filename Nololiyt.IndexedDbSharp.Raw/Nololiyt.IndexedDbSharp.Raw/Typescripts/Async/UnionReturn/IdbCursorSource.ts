import { WrappedIdbIndex } from "../Wrapping/WrappedIdbIndex";
import { WrappedIdbObjectStore } from "../Wrapping/WrappedIdbObjectStore";

export type IdbCursorSourceType = "objectStore" | "index";

export class IdbCursorSource
{
    private source;
    constructor(source: WrappedIdbObjectStore | WrappedIdbIndex)
    {
        this.source = source;
    }

    getValue(): WrappedIdbObjectStore | WrappedIdbIndex
    {
        return this.source;
    }

    getType(): IdbCursorSourceType
    {
        if (this.source instanceof WrappedIdbObjectStore)
            return "objectStore";
        return "index";
    }
}