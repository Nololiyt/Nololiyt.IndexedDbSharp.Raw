export type DotNetDateTime = Date;

/*
export class DotNetDateTime
{
    year: number | undefined;
    month: number | undefined;
    date: number | undefined;
    hours: number | undefined;
    minutes: number | undefined;
    seconds: number | undefined;
    ms: number | undefined;
    constructor(year?: number | undefined,
        month?: number | undefined,
        date?: number | undefined,
        hours?: number | undefined,
        minutes?: number | undefined,
        seconds?: number | undefined,
        ms?: number | undefined)
    {
        this.year = year;
        this.month = month;
        this.date = date;
        this.hours = hours;
        this.minutes = minutes;
        this.seconds = seconds;
        this.ms = ms;
    }

    toDate(): Date
    {
        if (this.year && this.month)
            return new Date(this.year, this.month,
                this.date, this.hours,
                this.minutes, this.seconds, this.ms);
        else
            return new Date(0);
    }
}
*/