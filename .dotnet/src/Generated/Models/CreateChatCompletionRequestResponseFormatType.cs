// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> Enum for type in CreateChatCompletionRequestResponseFormat. </summary>
    internal readonly partial struct CreateChatCompletionRequestResponseFormatType : IEquatable<CreateChatCompletionRequestResponseFormatType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionRequestResponseFormatType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateChatCompletionRequestResponseFormatType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";
        private const string JsonObjectValue = "json_object";

        /// <summary> text. </summary>
        public static CreateChatCompletionRequestResponseFormatType Text { get; } = new CreateChatCompletionRequestResponseFormatType(TextValue);
        /// <summary> json_object. </summary>
        public static CreateChatCompletionRequestResponseFormatType JsonObject { get; } = new CreateChatCompletionRequestResponseFormatType(JsonObjectValue);
        /// <summary> Determines if two <see cref="CreateChatCompletionRequestResponseFormatType"/> values are the same. </summary>
        public static bool operator ==(CreateChatCompletionRequestResponseFormatType left, CreateChatCompletionRequestResponseFormatType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateChatCompletionRequestResponseFormatType"/> values are not the same. </summary>
        public static bool operator !=(CreateChatCompletionRequestResponseFormatType left, CreateChatCompletionRequestResponseFormatType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateChatCompletionRequestResponseFormatType"/>. </summary>
        public static implicit operator CreateChatCompletionRequestResponseFormatType(string value) => new CreateChatCompletionRequestResponseFormatType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateChatCompletionRequestResponseFormatType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateChatCompletionRequestResponseFormatType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
