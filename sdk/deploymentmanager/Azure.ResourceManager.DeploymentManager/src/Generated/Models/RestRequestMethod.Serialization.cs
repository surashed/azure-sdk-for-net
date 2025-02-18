// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    internal static partial class RestRequestMethodExtensions
    {
        public static string ToSerialString(this RestRequestMethod value) => value switch
        {
            RestRequestMethod.GET => "GET",
            RestRequestMethod.Post => "POST",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RestRequestMethod value.")
        };

        public static RestRequestMethod ToRestRequestMethod(this string value)
        {
            if (string.Equals(value, "GET", StringComparison.InvariantCultureIgnoreCase)) return RestRequestMethod.GET;
            if (string.Equals(value, "POST", StringComparison.InvariantCultureIgnoreCase)) return RestRequestMethod.Post;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RestRequestMethod value.");
        }
    }
}
