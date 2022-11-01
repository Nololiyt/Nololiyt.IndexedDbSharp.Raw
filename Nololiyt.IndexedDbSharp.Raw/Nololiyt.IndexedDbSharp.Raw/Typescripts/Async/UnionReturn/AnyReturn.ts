export class AnyReturn
{
    private value;
    constructor(value: any)
    {
        this.value = value;
    }

    getValue(): any
    {
        return this.value;
    }

    isNull(): boolean
    {
        return this.value === null;
    }

    isUndefined(): boolean
    {
        return this.value === undefined;
    }

    isNullOrUndefined(): boolean
    {
        return this.value === null || this.value === undefined;
    }
}