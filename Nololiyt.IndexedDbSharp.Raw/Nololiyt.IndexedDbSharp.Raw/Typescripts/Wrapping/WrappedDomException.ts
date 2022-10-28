export class WrappedDomException
{
    private wrapped;
    constructor(wrapped: DOMException)
    {
        this.wrapped = wrapped;
    }

    message(): string
    {
        return this.wrapped.message;
    }

    name(): string
    {
        return this.wrapped.name;
    }

    stack(): string | null
    {
        const result = this.wrapped.stack;
        if (result)
            return result;
        else
            return null;
    }
    
    code(): number
    {
        return this.wrapped.code;
    }
}