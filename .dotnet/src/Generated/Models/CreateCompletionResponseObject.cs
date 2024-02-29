// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The CreateCompletionResponse_object. </summary>
    internal readonly partial struct CreateCompletionResponseObject : IEquatable<CreateCompletionResponseObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateCompletionResponseObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateCompletionResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextCompletionValue = "text_completion";

        /// <summary> text_completion. </summary>
        public static CreateCompletionResponseObject TextCompletion { get; } = new CreateCompletionResponseObject(TextCompletionValue);
        /// <summary> Determines if two <see cref="CreateCompletionResponseObject"/> values are the same. </summary>
        public static bool operator ==(CreateCompletionResponseObject left, CreateCompletionResponseObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateCompletionResponseObject"/> values are not the same. </summary>
        public static bool operator !=(CreateCompletionResponseObject left, CreateCompletionResponseObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateCompletionResponseObject"/>. </summary>
        public static implicit operator CreateCompletionResponseObject(string value) => new CreateCompletionResponseObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateCompletionResponseObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateCompletionResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}