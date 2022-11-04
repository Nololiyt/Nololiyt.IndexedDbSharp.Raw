interface AnObject
{
    obj: any;
}

export function testFunction1(obj: any):
    "string" | "number" | "bigint" | "boolean" | "symbol" | "undefined" | "object" | "function"
{
    return typeof (obj);
}

export function testFunction2(obj: AnObject):
    "string" | "number" | "bigint" | "boolean" | "symbol" | "undefined" | "object" | "function"
{
    return typeof (obj.obj);
}