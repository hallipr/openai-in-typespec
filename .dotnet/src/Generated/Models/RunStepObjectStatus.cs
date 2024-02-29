// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> Enum for status in RunStepObject. </summary>
    internal readonly partial struct RunStepObjectStatus : IEquatable<RunStepObjectStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunStepObjectStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunStepObjectStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InProgressValue = "in_progress";
        private const string CancelledValue = "cancelled";
        private const string FailedValue = "failed";
        private const string CompletedValue = "completed";
        private const string ExpiredValue = "expired";

        /// <summary> in_progress. </summary>
        public static RunStepObjectStatus InProgress { get; } = new RunStepObjectStatus(InProgressValue);
        /// <summary> cancelled. </summary>
        public static RunStepObjectStatus Cancelled { get; } = new RunStepObjectStatus(CancelledValue);
        /// <summary> failed. </summary>
        public static RunStepObjectStatus Failed { get; } = new RunStepObjectStatus(FailedValue);
        /// <summary> completed. </summary>
        public static RunStepObjectStatus Completed { get; } = new RunStepObjectStatus(CompletedValue);
        /// <summary> expired. </summary>
        public static RunStepObjectStatus Expired { get; } = new RunStepObjectStatus(ExpiredValue);
        /// <summary> Determines if two <see cref="RunStepObjectStatus"/> values are the same. </summary>
        public static bool operator ==(RunStepObjectStatus left, RunStepObjectStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunStepObjectStatus"/> values are not the same. </summary>
        public static bool operator !=(RunStepObjectStatus left, RunStepObjectStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunStepObjectStatus"/>. </summary>
        public static implicit operator RunStepObjectStatus(string value) => new RunStepObjectStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunStepObjectStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunStepObjectStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}