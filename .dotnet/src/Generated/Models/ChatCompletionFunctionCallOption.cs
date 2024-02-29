// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;

namespace OpenAI.Internal.Models
{
    /// <summary>
    /// Specifying a particular function via `{"name": "my_function"}` forces the model to call that
    /// function.
    /// </summary>
    internal partial class ChatCompletionFunctionCallOption
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

        /// <summary> Initializes a new instance of <see cref="ChatCompletionFunctionCallOption"/>. </summary>
        /// <param name="name"> The name of the function to call. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ChatCompletionFunctionCallOption(string name)
        {
            if (name is null) throw new ArgumentNullException(nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionFunctionCallOption"/>. </summary>
        /// <param name="name"> The name of the function to call. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ChatCompletionFunctionCallOption(string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ChatCompletionFunctionCallOption"/> for deserialization. </summary>
        internal ChatCompletionFunctionCallOption()
        {
        }

        /// <summary> The name of the function to call. </summary>
        public string Name { get; }
    }
}