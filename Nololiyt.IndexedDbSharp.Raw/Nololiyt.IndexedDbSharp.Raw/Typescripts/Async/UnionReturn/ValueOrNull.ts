export class ValueOrNull<T>
{
    private value;
    constructor(value: T | null)
    {
        this.value = value;
    }

    getValue(): T | null
    {
        return this.value;
    }

    hasValue(): boolean
    {
        return this.value !== null;
    }
}