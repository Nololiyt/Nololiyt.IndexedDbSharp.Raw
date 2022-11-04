using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
    public sealed record IdbKeyRangeInfo(
        IdbKeyRangeBoundMode BoundMode, 
        object? Lower, bool LowerOpen,
        object? Upper, bool UpperOpen)
    {
        public static IdbKeyRangeInfo LowerBound<T>(T lower, bool open = false)
        {
            return new IdbKeyRangeInfo(
                IdbKeyRangeBoundMode.LowerBound,
                lower, open,
                default, false);
        }
        public static IdbKeyRangeInfo UpperBound<T>(T upper, bool open = false)
        {
            return new IdbKeyRangeInfo(
                IdbKeyRangeBoundMode.UpperBound,
                default, false,
                upper, open);
        }
        public static IdbKeyRangeInfo Bound<TLower, TUpper>(
            TLower lower, TUpper upper, bool lowerOpen = false, bool upperOpen = false)
        {
            return new IdbKeyRangeInfo(
                IdbKeyRangeBoundMode.Bound,
                lower, lowerOpen,
                upper, upperOpen);
        }
        public static IdbKeyRangeInfo Only<T>(T value)
        {
            return new IdbKeyRangeInfo(
                IdbKeyRangeBoundMode.Bound,
                value, false,
                value, false);
        }
    }
}
