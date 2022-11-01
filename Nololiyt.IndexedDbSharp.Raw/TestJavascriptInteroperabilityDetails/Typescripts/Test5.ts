class MaybeNull<T>
{
    private value: T | null;

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

class TestClass
{
    getValue()
    {
        return "hello";
    }
}

export function testFunction1(returnsNull: boolean): MaybeNull<TestClass>
{
    if (returnsNull)
        return new MaybeNull<TestClass>(null);
    return new MaybeNull<TestClass>(new TestClass());
}

export function testFunction2(returnsNull: boolean): MaybeNull<number>
{
    if (returnsNull)
        return new MaybeNull<number>(null);
    return new MaybeNull<number>(1);
}