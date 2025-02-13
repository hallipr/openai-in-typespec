// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> The MessageFileObject_object. </summary>
    internal readonly partial struct MessageFileObjectObject : IEquatable<MessageFileObjectObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageFileObjectObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageFileObjectObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ThreadMessageFileValue = "thread.message.file";

        /// <summary> thread.message.file. </summary>
        public static MessageFileObjectObject ThreadMessageFile { get; } = new MessageFileObjectObject(ThreadMessageFileValue);
        /// <summary> Determines if two <see cref="MessageFileObjectObject"/> values are the same. </summary>
        public static bool operator ==(MessageFileObjectObject left, MessageFileObjectObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageFileObjectObject"/> values are not the same. </summary>
        public static bool operator !=(MessageFileObjectObject left, MessageFileObjectObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageFileObjectObject"/>. </summary>
        public static implicit operator MessageFileObjectObject(string value) => new MessageFileObjectObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageFileObjectObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageFileObjectObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
