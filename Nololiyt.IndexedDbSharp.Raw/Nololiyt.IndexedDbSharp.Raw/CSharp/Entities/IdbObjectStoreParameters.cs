using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
    public sealed record IdbObjectStoreParameters(
        SerializableNullable<bool> AutoIncrement,
        IdbKeyPath? KeyPath)
    { }
}
