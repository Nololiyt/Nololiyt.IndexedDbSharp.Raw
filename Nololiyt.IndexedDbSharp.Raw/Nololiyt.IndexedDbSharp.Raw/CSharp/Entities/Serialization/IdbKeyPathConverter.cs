using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities.Serialization
{
    internal sealed class IdbKeyPathConverter : JsonConverter<IdbKeyPath>
    {
        public override IdbKeyPath? Read(
            ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var element = JsonDocument.ParseValue(ref reader).RootElement;
            if (element.ValueKind == JsonValueKind.Array)
            {
                var deserialized = element.Deserialize<string[]>(options);
                Debug.Assert(deserialized is not null);
                return new(deserialized);
            }
            else if(element.ValueKind == JsonValueKind.String)
            {
                var deserialized = element.Deserialize<string>(options);
                Debug.Assert(deserialized is not null);
                return new(deserialized);
            }
            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, IdbKeyPath value, JsonSerializerOptions options)
        {
            if (value.TryGetSingleOrArray(out var s, out var ss))
                JsonSerializer.Serialize(writer, s, options);
            else
                JsonSerializer.Serialize(writer, ss, options);
        }
    }
}
