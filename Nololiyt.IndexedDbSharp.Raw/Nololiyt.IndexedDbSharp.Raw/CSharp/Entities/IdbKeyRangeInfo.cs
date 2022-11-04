using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
    public sealed class IdbKeyRangeInfo
    {
        public object? Lower { get; }
        public bool LowerOpen { get; }
        public object? Upper { get; }
        public bool UpperOpen { get; }
        public IdbKeyRangeBoundMode BoundMode { get; }
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
        internal IdbKeyRangeInfo(
            IdbKeyRangeBoundMode boundMode,
            object? lower, 
            bool lowerOpen,
            object? upper, 
            bool upperOpen)
        {
            this.Lower = lower;
            this.LowerOpen = lowerOpen;
            this.Upper = upper;
            this.UpperOpen = upperOpen;
            this.BoundMode = boundMode;
        }
        public override bool Equals(object? obj)
        {
            if (obj is not IdbKeyRangeInfo other)
                return false;
            return
                this.UpperOpen == other.UpperOpen &&
                this.LowerOpen == other.LowerOpen &&
                this.BoundMode.Equals(other.BoundMode) &&
                object.Equals(this.Lower, other.Lower) &&
                object.Equals(this.Upper, other.Upper);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(
                this.BoundMode, this.Lower, this.LowerOpen, this.Upper, this.UpperOpen);
        }

        public override string ToString()
        {
            var left = this.LowerOpen ? "(" : "[";
            var right = this.UpperOpen ? ")" : "]";

            string? lower;
            string? upper;

            if (this.BoundMode == IdbKeyRangeBoundMode.LowerBound)
            {
                lower = this.Lower?.ToString();
                upper = "Infinity";
            }
            else if (this.BoundMode == IdbKeyRangeBoundMode.UpperBound)
            {
                upper = this.Upper?.ToString();
                lower = "Infinity";
            }
            else
            {
                lower = this.Lower?.ToString();
                upper = this.Upper?.ToString();
            }

            return $"{left}{lower}, {upper}{right}";
        }
    }
}
