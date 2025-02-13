// <auto-generated/>

using System;
using System.Collections.Generic;
using System.Linq;
using OpenAI;

namespace OpenAI.Internal.Models
{
    /// <summary> The ChatCompletionTokenLogprob. </summary>
    internal partial class ChatCompletionTokenLogprob
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

        /// <summary> Initializes a new instance of <see cref="ChatCompletionTokenLogprob"/>. </summary>
        /// <param name="token"> The token. </param>
        /// <param name="logprob"> The log probability of this token. </param>
        /// <param name="bytes">
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in
        /// instances where characters are represented by multiple tokens and their byte representations
        /// must be combined to generate the correct text representation. Can be `null` if there is no
        /// bytes representation for the token.
        /// </param>
        /// <param name="topLogprobs">
        /// List of the most likely tokens and their log probability, at this token position. In rare
        /// cases, there may be fewer than the number of requested `top_logprobs` returned.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="token"/> or <paramref name="topLogprobs"/> is null. </exception>
        internal ChatCompletionTokenLogprob(string token, double logprob, IEnumerable<long> bytes, IEnumerable<ChatCompletionTokenLogprobTopLogprob> topLogprobs)
        {
            Argument.AssertNotNull(token, nameof(token));
            Argument.AssertNotNull(topLogprobs, nameof(topLogprobs));

            Token = token;
            Logprob = logprob;
            Bytes = bytes?.ToList();
            TopLogprobs = topLogprobs.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionTokenLogprob"/>. </summary>
        /// <param name="token"> The token. </param>
        /// <param name="logprob"> The log probability of this token. </param>
        /// <param name="bytes">
        /// A list of integers representing the UTF-8 bytes representation of the token. Useful in
        /// instances where characters are represented by multiple tokens and their byte representations
        /// must be combined to generate the correct text representation. Can be `null` if there is no
        /// bytes representation for the token.
        /// </param>
        /// <param name="topLogprobs">
        /// List of the most likely tokens and their log probability, at this token position. In rare
        /// cases, there may be fewer than the number of requested `top_logprobs` returned.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionTokenLogprob(string token, double logprob, IReadOnlyList<long> bytes, IReadOnlyList<ChatCompletionTokenLogprobTopLogprob> topLogprobs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Token = token;
            Logprob = logprob;
            Bytes = bytes;
            TopLogprobs = topLogprobs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionTokenLogprob"/> for deserialization. </summary>
        internal ChatCompletionTokenLogprob()
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
        /// <summary>
        /// List of the most likely tokens and their log probability, at this token position. In rare
        /// cases, there may be fewer than the number of requested `top_logprobs` returned.
        /// </summary>
        public IReadOnlyList<ChatCompletionTokenLogprobTopLogprob> TopLogprobs { get; }
    }
}
