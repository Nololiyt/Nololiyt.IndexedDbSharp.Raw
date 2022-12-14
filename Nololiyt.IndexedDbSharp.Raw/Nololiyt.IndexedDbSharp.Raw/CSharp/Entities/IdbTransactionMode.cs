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
    [JsonConverter(typeof(ToStringAndTryParseConverter<IdbTransactionMode>))]
    public struct IdbTransactionMode
    {
        private readonly int mode;
        private IdbTransactionMode(int mode)
        {
            this.mode = mode;
        }
        public static bool TryParse(string s, out IdbTransactionMode mode)
        {
            int value = s switch {
                "readonly" => 0,
                "readwrite" => 1,
                "versionchange" => 2,
                _ => -1
            };
            if(value < 0)
            {
                mode = default;
                return false;
            }
            mode = new IdbTransactionMode(value);
            return true;
        }

        public static IdbTransactionMode ReadOnly => new (0);
        public static IdbTransactionMode ReadWrite => new(1);
        public static IdbTransactionMode VersionChange => new(2);
        public override string ToString()
        {
            return mode switch {
                1 => "readwrite",
                2 => "versionchange",
                _ => "readonly"
            };
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is not IdbTransactionMode mode)
                return false;
            return this.mode == mode.mode;
        }

        public override int GetHashCode()
        {
            return mode.GetHashCode();
        }

        public static bool operator ==(IdbTransactionMode left, IdbTransactionMode right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IdbTransactionMode left, IdbTransactionMode right)
        {
            return !(left == right);
        }
    }
}
