export class IdbKeyRangeInfo
{
    lower: any;
    lowerOpen: boolean | undefined;
    upper: any;
    upperOpen: boolean | undefined;

    constructor(
        lower?: any | undefined,
        lowerOpen?: boolean | undefined,
        upper?: any | undefined,
        upperOpen?: boolean | undefined)
    {
        this.lower = lower;
        this.lowerOpen = lowerOpen;
        this.upper = upper;
        this.upperOpen = upperOpen;
    }

    toIdbKeyRange(): IDBKeyRange
    {
        if (this.lower === undefined)
        {
            if (this.upper === undefined)
                throw new RangeError(
                    `Cannot resolve the IdbKeyRangeInfo { upper=${this.upper}, upper=${this.lower} } .`);

            return IDBKeyRange.lowerBound(this.lower, this.lowerOpen);
        }

        if (this.upper === undefined)
        {
            return IDBKeyRange.upperBound(this.upper, this.upperOpen);
        }
        
        return IDBKeyRange.bound(this.lower, this.upper, this.lowerOpen, this.upperOpen);
    }
}