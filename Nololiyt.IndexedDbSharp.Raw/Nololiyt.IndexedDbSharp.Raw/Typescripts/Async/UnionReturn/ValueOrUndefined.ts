export class ValueOrUndefined<T>
{
    private value;
    constructor(value: T | undefined)
    {
        this.value = value;
    }

    getValue(): T | undefined
    {
        return this.value;
    }

    hasValue(): boolean
    {
        return this.value !== undefined;
    }
}