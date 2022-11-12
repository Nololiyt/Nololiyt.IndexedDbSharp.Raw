export class KnownError extends Error
{
    constructor(message: string)
    {
        super(`KnownError Of Nololiyt.IndexedDbSharp.Raw: ${message}`);
        Object.setPrototypeOf(this, KnownError.prototype);
        this.name = "KnownError";
    }
}