export function testFunction1()
{
    throw new DOMException("mes", "nam");
}

export function testFunction2()
{
    throw new RangeError("mes");
}

class KnownError extends Error
{
    constructor(message: string)
    {
        super(message);
        Object.setPrototypeOf(this, KnownError.prototype);
        this.name = "KnownError";
    }
}


export function testFunction3()
{
    throw new KnownError("mes");
}