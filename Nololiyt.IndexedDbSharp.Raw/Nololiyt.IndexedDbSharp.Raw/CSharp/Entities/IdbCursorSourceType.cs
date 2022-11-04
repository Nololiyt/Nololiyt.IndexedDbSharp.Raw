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
    [JsonConverter(typeof(ToStringAndTryParseConverter<IdbCursorSourceType>))]
    public struct IdbCursorSourceType
    {
        private readonly int type;
        private IdbCursorSourceType(int type)
        {
            this.type = type;
        }
        public static bool TryParse(string s, out IdbCursorSourceType type)
        {
            int value = s switch {
                "objectStore" => 0,
                "index" => 1,
                _ => -1
            };
            if(value < 0)
            {
                type = default;
                return false;
            }
            type = new IdbCursorSourceType(value);
            return true;
        }

        public override string ToString()
        {
            return type switch {
                1 => "index",
                _ => "objectStore"
            };
        }
        public static IdbCursorSourceType Index => new(0);
        public static IdbCursorSourceType ObjectStore => new(1);

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is not IdbCursorSourceType type)
                return false;
            return this.type == type.type;
        }

        public override int GetHashCode()
        {
            return type.GetHashCode();
        }

        public static bool operator ==(IdbCursorSourceType left, IdbCursorSourceType right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IdbCursorSourceType left, IdbCursorSourceType right)
        {
            return !(left == right);
        }
    }
}
