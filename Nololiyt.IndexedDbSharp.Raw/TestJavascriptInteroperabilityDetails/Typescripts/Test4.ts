export function testFunction(date: Date): Date
{
    console.warn("Date got in js: ", date.toString());
    return new Date();
}