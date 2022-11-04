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
    [JsonConverter(typeof(ToStringAndTryParseConverter<IdbCursorDirection>))]
    public struct IdbCursorDirection
    {
        private readonly int direction;
        private IdbCursorDirection(int direction)
        {
            this.direction = direction;
        }
        public static bool TryParse(string s, out IdbCursorDirection direction)
        {
            int value = s switch {
                "next" => 0,
                "nextunique" => 1,
                "prev" => 2,
                "prevunique" => 3,
                _ => -1
            };
            if(value < 0)
            {
                direction = default;
                return false;
            }
            direction = new IdbCursorDirection(value);
            return true;
        }

        public override string ToString()
        {
            return direction switch {
                1 => "nextunique",
                2 => "prev",
                3 => "prevunique",
                _ => "next"
            };
        }

        public static IdbCursorDirection NextUnique => new(0);
        public static IdbCursorDirection Prev => new(1);
        public static IdbCursorDirection PrevUnique => new(2);
        public static IdbCursorDirection Next => new(3);

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is not IdbCursorDirection direction)
                return false;
            return this.direction == direction.direction;
        }

        public override int GetHashCode()
        {
            return direction.GetHashCode();
        }

        public static bool operator ==(IdbCursorDirection left, IdbCursorDirection right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IdbCursorDirection left, IdbCursorDirection right)
        {
            return !(left == right);
        }
    }
}
