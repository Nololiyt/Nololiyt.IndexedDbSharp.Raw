import { DotNetCallbackObject, InvokeDotNetCallback } from "./Entities/DotNetCallbackObject.js"

export function testFunction(result: string, callback: DotNetCallbackObject)
{
    console.log(callback);
    console.log(result);
    InvokeDotNetCallback(callback, result);
}