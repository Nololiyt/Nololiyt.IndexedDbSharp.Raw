using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
    [JsonConverter(typeof(ToStringAndTryParseConverter<IdbKeyRangeBoundMode>))]
    public struct IdbKeyRangeBoundMode
    {
        private readonly int mode;
        private IdbKeyRangeBoundMode(int mode)
        {
            this.mode = mode;
        }
        public static bool TryParse(string s, out IdbKeyRangeBoundMode type)
        {
            int value = s switch {
                "bound" => 0,
                "lowerBound" => 1,
                "upperBound" => 2,
                _ => -1
            };
            if(value < 0)
            {
                type = default;
                return false;
            }
            type = new IdbKeyRangeBoundMode(value);
            return true;
        }

        public override string ToString()
        {
            return mode switch {
                1 => "lowerBound",
                2 => "upperBound",
                _ => "bound"
            };
        }

        public static IdbKeyRangeBoundMode Bound => new(0);
        public static IdbKeyRangeBoundMode LowerBound => new(1);
        public static IdbKeyRangeBoundMode UpperBound => new(2);

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is not IdbKeyRangeBoundMode mode)
                return false;
            return this.mode == mode.mode;
        }

        public override int GetHashCode()
        {
            return mode.GetHashCode();
        }

        public static bool operator ==(IdbKeyRangeBoundMode left, IdbKeyRangeBoundMode right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IdbKeyRangeBoundMode left, IdbKeyRangeBoundMode right)
        {
            return !(left == right);
        }
    }
}
