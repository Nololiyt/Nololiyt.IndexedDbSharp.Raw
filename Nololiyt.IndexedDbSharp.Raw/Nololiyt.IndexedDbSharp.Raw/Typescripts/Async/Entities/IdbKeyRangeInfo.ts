export type IdbKeyRangeBoundMode = "bound" | "lowerBound" | "upperBound";

export interface IdbKeyRangeInfo
{
    lower: any;
    lowerOpen: boolean;
    upper: any;
    upperOpen: boolean;
    boundMode: IdbKeyRangeBoundMode;
}

export function isIdbKeyRangeInfo(obj: any): obj is IdbKeyRangeInfo
{
    const converted = <IdbKeyRangeInfo>obj;
    return converted.boundMode !== undefined &&
        converted.lowerOpen !== undefined &&
        converted.upperOpen !== undefined;
}

export function convertToIdbKeyRange(info: IdbKeyRangeInfo): IDBKeyRange
{
    switch (info.boundMode)
    {
        case "lowerBound":
            return IDBKeyRange.lowerBound(info.lower, info.lowerOpen);
        case "upperBound":
            return IDBKeyRange.upperBound(info.upper, info.upperOpen);
        default:
            return IDBKeyRange.bound(info.lower, info.upper, info.lowerOpen, info.upperOpen);
    }
}