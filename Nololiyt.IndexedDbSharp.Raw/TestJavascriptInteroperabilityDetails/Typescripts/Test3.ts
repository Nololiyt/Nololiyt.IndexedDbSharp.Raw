class TestClass
{
    testProperty: number;

    testMethod(): number
    {
        return this.testProperty;
    }

    constructor()
    {
        this.testProperty = Math.random();
    }
}

export function newInstance()
{
    return new TestClass();
}