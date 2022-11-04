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
    internal sealed class SerializableNullableConverter : JsonConverter<object>
    {
        public override bool HandleNull => true;
        public override bool CanConvert(Type typeToConvert)
        {
            if (!typeToConvert.IsGenericType)
                return false;
            return typeToConvert.GetGenericTypeDefinition() == typeof(SerializableNullable<>);
        }
        public override object? Read(
            ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
                return Activator.CreateInstance(typeToConvert);

            var type = typeToConvert.GenericTypeArguments[0];
            var deserialized = JsonDocument.ParseValue(ref reader).Deserialize(type, options);
            return Activator.CreateInstance(typeToConvert, deserialized);
        }

        public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
        {
            var type = value.GetType();

            var hasValueProperty = type.GetProperty("HasValue")?.GetMethod;
            Debug.Assert(hasValueProperty is not null);

            var hasValuePropertyValue = hasValueProperty.Invoke(value, null);
            Debug.Assert(hasValuePropertyValue is bool);
            if(!(bool)hasValuePropertyValue)
            {
                writer.WriteNullValue();
                return;
            }

            var valueProperty = type.GetProperty("Value")?.GetMethod;
            Debug.Assert(valueProperty is not null);

            var valuePropertyValue = valueProperty.Invoke(value, null);
            var typeArgument = type.GenericTypeArguments[0];
            JsonSerializer.Serialize(writer, valuePropertyValue, typeArgument, options);
        }
    }
}
