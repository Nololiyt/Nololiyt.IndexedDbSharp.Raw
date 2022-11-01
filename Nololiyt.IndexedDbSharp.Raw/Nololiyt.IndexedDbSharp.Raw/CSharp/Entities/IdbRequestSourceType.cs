using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
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
