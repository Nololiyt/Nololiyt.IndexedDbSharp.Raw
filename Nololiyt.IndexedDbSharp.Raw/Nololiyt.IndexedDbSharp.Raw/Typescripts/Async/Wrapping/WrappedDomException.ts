import { ValueOrUndefined } from "../UnionReturn/ValueOrUndefined";

export class WrappedDomException
{
    private wrapped;
    constructor(wrapped: DOMException)
    {
        this.wrapped = wrapped;
    }

    wrappedObject()
    {
        return this.wrapped;
    }

    message(): string
    {
        return this.wrapped.message;
    }

    name(): string
    {
        return this.wrapped.name;
    }

    stack(): ValueOrUndefined<string>
    {
        return new ValueOrUndefined(this.wrapped.stack);
    }
    
    code(): number
    {
        return this.wrapped.code;
    }

    // Properties like ABORT_ERR, DATA_CLONE_ERR, ... are currently not provided.
}