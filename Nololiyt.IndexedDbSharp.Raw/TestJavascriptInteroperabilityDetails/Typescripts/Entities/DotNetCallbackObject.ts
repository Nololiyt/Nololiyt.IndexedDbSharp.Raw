import { DotNetObjectReference } from "./DotNetObjectReference.js";

export interface DotNetCallbackObject
{
    object: DotNetObjectReference;
    callbackMethod: string;
}

export function InvokeDotNetCallback(callbackObject: DotNetCallbackObject, ...args: any[])
{
    callbackObject.object.invokeMethodAsync(callbackObject.callbackMethod, ...args);
}