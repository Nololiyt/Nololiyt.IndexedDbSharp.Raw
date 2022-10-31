using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
    public struct IdbRequestReadyState
    {
        private readonly int state;
        private IdbRequestReadyState(int state)
        {
            this.state = state;
        }
        public static bool TryParse(string s, out IdbRequestReadyState state)
        {
            int value = s switch {
                "done" => 0,
                "pending" => 1,
                _ => -1
            };
            if(value < 0)
            {
                state = default;
                return false;
            }
            state = new IdbRequestReadyState(value);
            return true;
        }

        public override string ToString()
        {
            return state switch {
                1 => "pending",
                _ => "done"
            };
        }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            if(obj is not IdbRequestReadyState state)
                return false;
            return this.state == state.state;
        }

        public override int GetHashCode()
        {
            return state.GetHashCode();
        }

        public static bool operator ==(IdbRequestReadyState left, IdbRequestReadyState right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(IdbRequestReadyState left, IdbRequestReadyState right)
        {
            return !(left == right);
        }
    }
}
