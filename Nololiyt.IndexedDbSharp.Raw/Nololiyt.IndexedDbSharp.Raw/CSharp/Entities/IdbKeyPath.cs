using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities.Serialization;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
    [JsonConverter(typeof(IdbKeyPathConverter))]
    public sealed class IdbKeyPath
    {
        public string? PathSingle { get; }
        public IReadOnlyList<string>? PathArray { get; }
        public bool TryGetSingleOrArray(
            [MaybeNullWhen(false)] out string singleString,
            [MaybeNullWhen(true)] out IReadOnlyList<string> stringArray)
        {
            singleString = PathSingle;
            stringArray = PathArray;
            return PathSingle is not null;
        }
        public IdbKeyPath(string path)
        {
            this.PathSingle = path;
        }
        public IdbKeyPath(IEnumerable<string> path)
        {
            this.PathArray = Array.AsReadOnly(path.ToArray());
        }

        public override int GetHashCode()
        {
            var h = new HashCode();
            h.Add(PathSingle);
            if (PathArray is not null)
            {
                foreach (var item in PathArray)
                    h.Add(item);
            }
            return h.ToHashCode();
        }

        public override string ToString()
        {
            if (TryGetSingleOrArray(out var single, out var array))
                return single;
            else
            {
                var j = string.Join(", ", array);
                return $"[{j}]";
            }
        }
    }
}
