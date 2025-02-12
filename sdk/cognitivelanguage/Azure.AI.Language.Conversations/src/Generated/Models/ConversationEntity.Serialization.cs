// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    public partial class ConversationEntity
    {
        internal static ConversationEntity DeserializeConversationEntity(JsonElement element)
        {
            string category = default;
            string text = default;
            int offset = default;
            int length = default;
            float confidenceScore = default;
            Optional<IReadOnlyList<string>> listKeys = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("listKeys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    listKeys = array;
                    continue;
                }
            }
            return new ConversationEntity(category, text, offset, length, confidenceScore, Optional.ToList(listKeys));
        }
    }
}
