import { DotNetObjectReference } from "./DotNetObjectReference.js";

export interface DotNetCallbackObject
{
    object: DotNetObjectReference;
    // callbackMethod: string;
}

export async function invokeDotNetCallbackAsync(callbackObject: DotNetCallbackObject, ...args: any[])
{
    // const callbackMethod = callbackObject.callbackMethod;
    const callbackMethod = "Invoke";
    await callbackObject.object.invokeMethodAsync(callbackMethod, ...args);
}
