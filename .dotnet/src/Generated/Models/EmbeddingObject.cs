// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The Embedding_object. </summary>
    internal readonly partial struct EmbeddingObject : IEquatable<EmbeddingObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EmbeddingObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EmbeddingObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EmbeddingValue = "embedding";

        /// <summary> embedding. </summary>
        public static EmbeddingObject Embedding { get; } = new EmbeddingObject(EmbeddingValue);
        /// <summary> Determines if two <see cref="EmbeddingObject"/> values are the same. </summary>
        public static bool operator ==(EmbeddingObject left, EmbeddingObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EmbeddingObject"/> values are not the same. </summary>
        public static bool operator !=(EmbeddingObject left, EmbeddingObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EmbeddingObject"/>. </summary>
        public static implicit operator EmbeddingObject(string value) => new EmbeddingObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EmbeddingObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EmbeddingObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
