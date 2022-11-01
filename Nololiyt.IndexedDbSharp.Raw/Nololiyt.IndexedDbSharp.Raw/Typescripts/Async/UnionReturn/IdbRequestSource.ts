import { WrappedIdbCursor } from "../Wrapping/WrappedIdbCursor";
import { WrappedIdbIndex } from "../Wrapping/WrappedIdbIndex";
import { WrappedIdbObjectStore } from "../Wrapping/WrappedIdbObjectStore";

export type IdbRequestSourceType = "objectStore" | "index" | "cursor";

export class IdbRequestSource
{
    private source;
    constructor(source: WrappedIdbObjectStore | WrappedIdbIndex | WrappedIdbCursor)
    {
        this.source = source;
    }

    getValue(): WrappedIdbObjectStore | WrappedIdbIndex | WrappedIdbCursor
    {
        return this.source;
    }

    getType(): IdbRequestSourceType
    {
        if (this.source instanceof WrappedIdbObjectStore)
            return "objectStore";
        if (this.source instanceof WrappedIdbIndex)
            return "index";
        return "cursor";
    }
}