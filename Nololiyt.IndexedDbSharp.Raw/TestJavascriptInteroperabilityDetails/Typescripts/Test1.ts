import { DotNetCallbackObject, InvokeDotNetCallback } from "./Entities/DotNetCallbackObject.js"

export function testFunction(result: string, callback: DotNetCallbackObject)
{
    InvokeDotNetCallback(callback, result);
}