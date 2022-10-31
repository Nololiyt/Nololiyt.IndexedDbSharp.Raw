export class WrappedEvent
{
    private wrapped;
    constructor(wrapped: Event)
    {
        this.wrapped = wrapped;
    }

    wrappedObject()
    {
        return this.wrapped;
    }

    // Nothing is currently provided here.
}