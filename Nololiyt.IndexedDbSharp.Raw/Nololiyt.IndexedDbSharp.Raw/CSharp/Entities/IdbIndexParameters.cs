using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
    public sealed record IdbIndexParameters(
        SerializableNullable<bool> MultiEntry, 
        SerializableNullable<bool> Unique);
}
