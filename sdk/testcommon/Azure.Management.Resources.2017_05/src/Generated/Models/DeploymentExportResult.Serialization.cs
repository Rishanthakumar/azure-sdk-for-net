// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class DeploymentExportResult
    {
        internal static DeploymentExportResult DeserializeDeploymentExportResult(JsonElement element)
        {
            Optional<object> template = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("template"))
                {
                    template = property.Value.GetObject();
                    continue;
                }
            }
            return new DeploymentExportResult(template.Value);
        }
    }
}
