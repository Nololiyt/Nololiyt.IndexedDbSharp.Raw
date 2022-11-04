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
    internal sealed class ToStringAndTryParseConverter<T> : JsonConverter<T>
    {
        public override bool CanConvert(Type typeToConvert)
        {
            var method = typeToConvert.GetMethod("TryParse",
                new Type[] { typeof(string), typeToConvert });
            if (method is null || method.ReturnType != typeof(bool))
                return false;
            return true;
        }
        public override T? Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            var method = typeToConvert.GetMethod("TryParse",
                new Type[] { typeof(string), typeToConvert });
            Debug.Assert(method is not null);

            var str = reader.GetString();
            var p = new object?[] { str, default(T) };

            var result = method.Invoke(null, p);
            Debug.Assert(result is bool);
            if (!(bool)result)
                throw new JsonException();

            return (T?)p[1];
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            var str = value?.ToString();
            writer.WriteStringValue(str);
        }
    }
}
