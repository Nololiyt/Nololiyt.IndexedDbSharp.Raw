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

    stack(): string | undefined
    {
        return this.wrapped.stack;
    }
    
    code(): number
    {
        return this.wrapped.code;
    }
}