export interface IdbKeyRangeInfo
{
    lower: any;
    lowerOpen: boolean;
    upper: any;
    upperOpen: boolean;
}

export function isIdbKeyRangeInfo(obj: any): obj is IdbKeyRangeInfo
{
    const converted = <IdbKeyRangeInfo>obj;
    return converted.lowerOpen !== undefined &&
        converted.upperOpen !== undefined;
}

export function convertToIdbKeyRange(info: IdbKeyRangeInfo): IDBKeyRange
{
    if (info.lower === undefined)
    {
        if (info.upper === undefined)
            throw new RangeError(
                `Cannot resolve the IdbKeyRangeInfo { upper=${info.upper}, upper=${info.lower} } .`);

        return IDBKeyRange.lowerBound(info.lower, info.lowerOpen);
    }

    if (info.upper === undefined)
    {
        return IDBKeyRange.upperBound(info.upper, info.upperOpen);
    }

    return IDBKeyRange.bound(info.lower, info.upper, info.lowerOpen, info.upperOpen);
}