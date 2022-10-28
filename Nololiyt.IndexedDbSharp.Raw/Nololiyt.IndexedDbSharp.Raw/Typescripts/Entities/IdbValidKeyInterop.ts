import { DotNetByteArray } from "./DotNetByteArray.js";
import { DotNetDateTime } from "./DotNetDateTime.js";

export type IdbValidKeyInterop = number | string | DotNetDateTime | DotNetByteArray | IdbValidKeyInterop[];

export function toIdbValidKey(idbValidKey: IdbValidKeyInterop): IDBValidKey
{
    /*
    if (Array.isArray(idbValidKey))
        return idbValidKey.map((value, _index, _array) => toIdbValidKey(value));
    if (idbValidKey instanceof DotNetDateTime)
        return idbValidKey.toDate();
    return idbValidKey;
    */
    return idbValidKey;
}

export function toIdbValidKeyInterop(idbValidKey: IDBValidKey): IdbValidKeyInterop
{
    /*
    if (Array.isArray(idbValidKey))
        return idbValidKey.map((value, _index, _array) => toIdbValidKeyInterop(value));
    if (idbValidKey instanceof Date)
    {
        return new DotNetDateTime(idbValidKey.getFullYear(), idbValidKey.getMonth(),
            idbValidKey.getDate(), idbValidKey.getHours(), idbValidKey.getMinutes(),
            idbValidKey.getSeconds(), idbValidKey.getMilliseconds());
    }
    */
    return idbValidKey;
}