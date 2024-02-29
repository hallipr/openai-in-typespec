// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Internal.Models
{
    internal partial class ImagesResponse : IJsonModel<ImagesResponse>
    {
        void IJsonModel<ImagesResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImagesResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImagesResponse)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("created"u8);
            writer.WriteNumberValue(Created, "U");
            writer.WritePropertyName("data"u8);
            writer.WriteStartArray();
            foreach (var item in Data)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ImagesResponse IJsonModel<ImagesResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImagesResponse>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ImagesResponse)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImagesResponse(document.RootElement, options);
        }

        internal static ImagesResponse DeserializeImagesResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset created = default;
            IReadOnlyList<Image> data = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("created"u8))
                {
                    created = DateTimeOffset.FromUnixTimeSeconds(property.Value.GetInt64());
                    continue;
                }
                if (property.NameEquals("data"u8))
                {
                    List<Image> array = new List<Image>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Image.DeserializeImage(item));
                    }
                    data = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImagesResponse(created, data, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImagesResponse>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImagesResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ImagesResponse)} does not support '{options.Format}' format.");
            }
        }

        ImagesResponse IPersistableModel<ImagesResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ImagesResponse>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeImagesResponse(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ImagesResponse)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ImagesResponse>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ImagesResponse FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeImagesResponse(document.RootElement);
        }
    }
}