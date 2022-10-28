import { DotNetObjectReference } from "./DotNetObjectReference.js";

export class DotNetCallbackObject
{
    object: DotNetObjectReference | undefined;
    callbackMethod: string | undefined;

    constructor(object?: DotNetObjectReference | undefined, callbackMethod?: string | undefined)
    {
        this.object = object;
        this.callbackMethod = callbackMethod;
    }

    InvokeCallback(...args: any[])
    {
        if (this.object && this.callbackMethod)
            this.object.invokeMethodAsync(this.callbackMethod, ...args);
    }
}