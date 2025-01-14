// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> Enum for response_format in CreateTranslationRequest. </summary>
    internal readonly partial struct CreateTranslationRequestResponseFormat : IEquatable<CreateTranslationRequestResponseFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateTranslationRequestResponseFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateTranslationRequestResponseFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string JsonValue = "json";
        private const string TextValue = "text";
        private const string SrtValue = "srt";
        private const string VerboseJsonValue = "verbose_json";
        private const string VttValue = "vtt";

        /// <summary> json. </summary>
        public static CreateTranslationRequestResponseFormat Json { get; } = new CreateTranslationRequestResponseFormat(JsonValue);
        /// <summary> text. </summary>
        public static CreateTranslationRequestResponseFormat Text { get; } = new CreateTranslationRequestResponseFormat(TextValue);
        /// <summary> srt. </summary>
        public static CreateTranslationRequestResponseFormat Srt { get; } = new CreateTranslationRequestResponseFormat(SrtValue);
        /// <summary> verbose_json. </summary>
        public static CreateTranslationRequestResponseFormat VerboseJson { get; } = new CreateTranslationRequestResponseFormat(VerboseJsonValue);
        /// <summary> vtt. </summary>
        public static CreateTranslationRequestResponseFormat Vtt { get; } = new CreateTranslationRequestResponseFormat(VttValue);
        /// <summary> Determines if two <see cref="CreateTranslationRequestResponseFormat"/> values are the same. </summary>
        public static bool operator ==(CreateTranslationRequestResponseFormat left, CreateTranslationRequestResponseFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateTranslationRequestResponseFormat"/> values are not the same. </summary>
        public static bool operator !=(CreateTranslationRequestResponseFormat left, CreateTranslationRequestResponseFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateTranslationRequestResponseFormat"/>. </summary>
        public static implicit operator CreateTranslationRequestResponseFormat(string value) => new CreateTranslationRequestResponseFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateTranslationRequestResponseFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateTranslationRequestResponseFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
