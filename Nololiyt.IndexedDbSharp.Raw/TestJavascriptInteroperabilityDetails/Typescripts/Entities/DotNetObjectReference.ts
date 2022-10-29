export interface DotNetObjectReference
{
    invokeMethodAsync(methodName: string, ...args: any[]): any;
}