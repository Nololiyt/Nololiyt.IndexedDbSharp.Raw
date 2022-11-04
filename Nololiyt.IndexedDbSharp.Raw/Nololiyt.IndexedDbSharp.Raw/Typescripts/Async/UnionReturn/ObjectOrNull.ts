export class ObjectOrNull<T>
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

    isNull(): boolean
    {
        return this.value === null;
    }
}