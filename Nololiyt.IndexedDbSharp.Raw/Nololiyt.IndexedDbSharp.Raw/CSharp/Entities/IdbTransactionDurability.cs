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
    [JsonConverter(typeof(ToStringAndTryParseConverter<IdbTransactionDurability>))]
    public struct IdbTransactionDurability
    {
        private readonly int durability;
        private IdbTransactionDurability(int durability)
        {
            this.durability = durability;
        }
        public static bool TryParse(string s, out IdbTransactionDurability durability)
        {
            int value = s switch {
                "default" => 0,
                "relaxed" => 1,
                "strict" => 2,
                _ => -1
            };
            if(value < 0)
            {
                durability = default;
                return false;
            }
            durability = new IdbTransactionDurability(value);
            return true;
        }

        public static IdbTransactionDurability Default => new (0);
        public static IdbTransactionDurability Relaxed => new(1);
        public static IdbTransactionDurability Strict => new(2);
        public override string ToString()
        {
            return durability switch {
                1 => "relaxed",
                2 => "strict",
                _ => "default"
            };
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is not IdbTransactionDurability durability)
                return false;
            return this.durability == durability.durability;
        }

        public override int GetHashCode()
        {
            return durability.GetHashCode();
        }

        public static bool operator ==(IdbTransactionDurability left, IdbTransactionDurability right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IdbTransactionDurability left, IdbTransactionDurability right)
        {
            return !(left == right);
        }
    }
}
