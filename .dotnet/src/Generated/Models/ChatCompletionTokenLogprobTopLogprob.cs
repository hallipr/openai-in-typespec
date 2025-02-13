// <auto-generated/>

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Internal.Models
{
    /// <summary> The ChatCompletionTokenLogprobTopLogprob. </summary>
    internal partial class ChatCompletionTokenLogprobTopLogprob
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ChatCompletionTokenLogprobTopLogprob"/>. </summary>
        /// <param name="token"> The token. </param>
        /// <param name="logprob"> The log probability of this token. </param>
        /// <param name="bytes">
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in
        /// instances where characters are represented by multiple tokens and their byte representations
        /// must be combined to generate the correct text representation. Can be `null` if there is no
        /// bytes representation for the token.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="token"/> is null. </exception>
        internal ChatCompletionTokenLogprobTopLogprob(string token, double logprob, IEnumerable<long> bytes)
        {
            Argument.AssertNotNull(token, nameof(token));

            Token = token;
            Logprob = logprob;
            Bytes = bytes?.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionTokenLogprobTopLogprob"/>. </summary>
        /// <param name="token"> The token. </param>
        /// <param name="logprob"> The log probability of this token. </param>
        /// <param name="bytes">
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in
        /// instances where characters are represented by multiple tokens and their byte representations
        /// must be combined to generate the correct text representation. Can be `null` if there is no
        /// bytes representation for the token.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionTokenLogprobTopLogprob(string token, double logprob, IReadOnlyList<long> bytes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Token = token;
            Logprob = logprob;
            Bytes = bytes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionTokenLogprobTopLogprob"/> for deserialization. </summary>
        internal ChatCompletionTokenLogprobTopLogprob()
        {
        }

        /// <summary> The token. </summary>
        public string Token { get; }
        /// <summary> The log probability of this token. </summary>
        public double Logprob { get; }
        /// <summary>
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in
        /// instances where characters are represented by multiple tokens and their byte representations
        /// must be combined to generate the correct text representation. Can be `null` if there is no
        /// bytes representation for the token.
        /// </summary>
        public IReadOnlyList<long> Bytes { get; }
    }
}
