using Nololiyt.IndexedDbSharp.Raw.CSharp.Entities.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nololiyt.IndexedDbSharp.Raw.CSharp.Entities
{
    [JsonConverter(typeof(SerializableNullableConverter))]
    public sealed class SerializableNullable<T> where T : struct
    {
        private readonly T value;
        public T Value =>
            HasValue ? 
            value :
            throw new InvalidOperationException("Value is null.");
        public bool HasValue { get; }
        public SerializableNullable()
        {
            value = default;
            HasValue = false;
        }
        public SerializableNullable(T value)
        {
            this.value = value;
            HasValue = true;
        }
        public override bool Equals(object? other)
        {
            if (!this.HasValue)
                return other is null;
            if (other is null)
                return false;
            return this.value.Equals(other);
        }
        public override int GetHashCode()
        {
            if (this.HasValue)
                return this.value.GetHashCode();
            return 0;
        }
        public T GetValueOrDefault(T defaultValue = default(T))
        {
            return this.HasValue ? this.value : defaultValue;
        }
        public override string? ToString()
        {
            return this.HasValue ? this.value.ToString() : "";
        }
        public static implicit operator SerializableNullable<T>(T value)
        {
            return new SerializableNullable<T>(value);
        }
        public static explicit operator T(SerializableNullable<T> value)
        {
            return value.Value;
        }
    }
}
