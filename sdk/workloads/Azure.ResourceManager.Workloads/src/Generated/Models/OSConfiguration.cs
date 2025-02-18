// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary>
    /// Defines the OS configuration.
    /// Please note <see cref="OSConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="LinuxConfiguration"/> and <see cref="WindowsConfiguration"/>.
    /// </summary>
    public abstract partial class OSConfiguration
    {
        /// <summary> Initializes a new instance of OSConfiguration. </summary>
        protected OSConfiguration()
        {
        }

        /// <summary> Initializes a new instance of OSConfiguration. </summary>
        /// <param name="osType"> The OS Type. </param>
        internal OSConfiguration(OSType osType)
        {
            OSType = osType;
        }

        /// <summary> The OS Type. </summary>
        internal OSType OSType { get; set; }
    }
}
