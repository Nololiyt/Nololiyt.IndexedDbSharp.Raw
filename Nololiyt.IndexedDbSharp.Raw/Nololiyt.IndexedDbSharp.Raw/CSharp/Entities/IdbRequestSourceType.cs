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
    [JsonConverter(typeof(ToStringAndTryParseConverter<IdbRequestSourceType>))]
    public struct IdbRequestSourceType
    {
        private readonly int type;
        private IdbRequestSourceType(int type)
        {
            this.type = type;
        }
        public static bool TryParse(string s, out IdbRequestSourceType type)
        {
            int value = s switch {
                "objectStore" => 0,
                "index" => 1,
                "cursor" => 2,
                _ => -1
            };
            if(value < 0)
            {
                type = default;
                return false;
            }
            type = new IdbRequestSourceType(value);
            return true;
        }

        public static IdbRequestSourceType ObjectStore => new(0);
        public static IdbRequestSourceType Index => new(1);
        public static IdbRequestSourceType Cursor => new(2);

        public override string ToString()
        {
            return type switch {
                1 => "index",
                2 => "cursor",
                _ => "objectStore"
            };
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is not IdbRequestSourceType type)
                return false;
            return this.type == type.type;
        }

        public override int GetHashCode()
        {
            return type.GetHashCode();
        }

        public static bool operator ==(IdbRequestSourceType left, IdbRequestSourceType right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IdbRequestSourceType left, IdbRequestSourceType right)
        {
            return !(left == right);
        }
    }
}
