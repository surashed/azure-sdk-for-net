// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class JitRequestData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ApplicationResourceId))
            {
                writer.WritePropertyName("applicationResourceId");
                writer.WriteStringValue(ApplicationResourceId);
            }
            if (Optional.IsCollectionDefined(JitAuthorizationPolicies))
            {
                writer.WritePropertyName("jitAuthorizationPolicies");
                writer.WriteStartArray();
                foreach (var item in JitAuthorizationPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(JitSchedulingPolicy))
            {
                writer.WritePropertyName("jitSchedulingPolicy");
                writer.WriteObjectValue(JitSchedulingPolicy);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static JitRequestData DeserializeJitRequestData(JsonElement element)
        {
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> applicationResourceId = default;
            Optional<Guid> publisherTenantId = default;
            Optional<IList<JitAuthorizationPolicies>> jitAuthorizationPolicies = default;
            Optional<JitSchedulingPolicy> jitSchedulingPolicy = default;
            Optional<ResourcesProvisioningState> provisioningState = default;
            Optional<JitRequestState> jitRequestState = default;
            Optional<ArmApplicationDetails> createdBy = default;
            Optional<ArmApplicationDetails> updatedBy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("applicationResourceId"))
                        {
                            applicationResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisherTenantId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publisherTenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("jitAuthorizationPolicies"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<JitAuthorizationPolicies> array = new List<JitAuthorizationPolicies>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.JitAuthorizationPolicies.DeserializeJitAuthorizationPolicies(item));
                            }
                            jitAuthorizationPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("jitSchedulingPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            jitSchedulingPolicy = JitSchedulingPolicy.DeserializeJitSchedulingPolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ResourcesProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("jitRequestState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            jitRequestState = new JitRequestState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createdBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            createdBy = ArmApplicationDetails.DeserializeArmApplicationDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("updatedBy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            updatedBy = ArmApplicationDetails.DeserializeArmApplicationDetails(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new JitRequestData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, applicationResourceId.Value, Optional.ToNullable(publisherTenantId), Optional.ToList(jitAuthorizationPolicies), jitSchedulingPolicy.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(jitRequestState), createdBy.Value, updatedBy.Value);
        }
    }
}
