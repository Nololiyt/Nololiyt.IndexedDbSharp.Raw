import { WrappedIdbOpenDbRequest } from "./WrappedIdbOpenDbRequest.js";

export class WrappedIdbFactory
{
    private wrapped;
    constructor(wrapped: IDBFactory)
    {
        this.wrapped = wrapped;
    }

    wrappedObject()
    {
        return this.wrapped;
    }

    open(name: string, version: number): WrappedIdbOpenDbRequest
    {
        const request = this.wrapped.open(name, version);
        return new WrappedIdbOpenDbRequest(request);
    }

    cmp(first: any, second: any): number
    {
        return this.wrapped.cmp(first, second);
    }

    async databases(): Promise<IDBDatabaseInfo[]>
    {
        const result = await this.wrapped.databases();
        return result;
    }

    deleteDatabase(name: string): WrappedIdbOpenDbRequest
    {
        const request = this.wrapped.deleteDatabase(name);
        return new WrappedIdbOpenDbRequest(request);
    }
}