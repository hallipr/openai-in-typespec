// <auto-generated/>

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Internal.Models
{
    /// <summary>
    /// The parameters the functions accepts, described as a JSON Schema object. See the
    /// [guide](/docs/guides/gpt/function-calling) for examples, and the
    /// [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation
    /// about the format.\n\nTo describe a function that accepts no parameters, provide the value
    /// `{\"type\": \"object\", \"properties\": {}}`.
    /// </summary>
    internal partial class FunctionParameters
    {
        /// <summary> Initializes a new instance of <see cref="FunctionParameters"/>. </summary>
        public FunctionParameters()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="FunctionParameters"/>. </summary>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal FunctionParameters(IDictionary<string, BinaryData> additionalProperties)
        {
            AdditionalProperties = additionalProperties;
        }

        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
