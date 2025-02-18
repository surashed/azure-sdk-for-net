// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class SimNameAndEncryptedProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WritePropertyName("internationalMobileSubscriberIdentity");
            writer.WriteStringValue(InternationalMobileSubscriberIdentity);
            if (Optional.IsDefined(IntegratedCircuitCardIdentifier))
            {
                writer.WritePropertyName("integratedCircuitCardIdentifier");
                writer.WriteStringValue(IntegratedCircuitCardIdentifier);
            }
            if (Optional.IsDefined(DeviceType))
            {
                writer.WritePropertyName("deviceType");
                writer.WriteStringValue(DeviceType);
            }
            if (Optional.IsDefined(SimPolicy))
            {
                writer.WritePropertyName("simPolicy");
                JsonSerializer.Serialize(writer, SimPolicy);
            }
            if (Optional.IsCollectionDefined(StaticIPConfiguration))
            {
                writer.WritePropertyName("staticIpConfiguration");
                writer.WriteStartArray();
                foreach (var item in StaticIPConfiguration)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EncryptedCredentials))
            {
                writer.WritePropertyName("encryptedCredentials");
                writer.WriteStringValue(EncryptedCredentials);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
