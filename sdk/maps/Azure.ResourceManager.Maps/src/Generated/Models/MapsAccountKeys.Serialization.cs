// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    public partial class MapsAccountKeys
    {
        internal static MapsAccountKeys DeserializeMapsAccountKeys(JsonElement element)
        {
            Optional<DateTimeOffset> primaryKeyLastUpdated = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<DateTimeOffset> secondaryKeyLastUpdated = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKeyLastUpdated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    primaryKeyLastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("primaryKey"))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKeyLastUpdated"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    secondaryKeyLastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new MapsAccountKeys(Optional.ToNullable(primaryKeyLastUpdated), primaryKey.Value, secondaryKey.Value, Optional.ToNullable(secondaryKeyLastUpdated));
        }
    }
}
