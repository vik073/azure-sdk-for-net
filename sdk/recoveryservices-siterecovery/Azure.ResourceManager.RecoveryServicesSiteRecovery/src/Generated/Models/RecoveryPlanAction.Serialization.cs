// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanAction : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("actionName");
            writer.WriteStringValue(ActionName);
            writer.WritePropertyName("failoverTypes");
            writer.WriteStartArray();
            foreach (var item in FailoverTypes)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("failoverDirections");
            writer.WriteStartArray();
            foreach (var item in FailoverDirections)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("customDetails");
            writer.WriteObjectValue(CustomDetails);
            writer.WriteEndObject();
        }

        internal static RecoveryPlanAction DeserializeRecoveryPlanAction(JsonElement element)
        {
            string actionName = default;
            IList<ReplicationProtectedItemOperation> failoverTypes = default;
            IList<PossibleOperationsDirection> failoverDirections = default;
            RecoveryPlanActionDetails customDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionName"))
                {
                    actionName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("failoverTypes"))
                {
                    List<ReplicationProtectedItemOperation> array = new List<ReplicationProtectedItemOperation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ReplicationProtectedItemOperation(item.GetString()));
                    }
                    failoverTypes = array;
                    continue;
                }
                if (property.NameEquals("failoverDirections"))
                {
                    List<PossibleOperationsDirection> array = new List<PossibleOperationsDirection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PossibleOperationsDirection(item.GetString()));
                    }
                    failoverDirections = array;
                    continue;
                }
                if (property.NameEquals("customDetails"))
                {
                    customDetails = RecoveryPlanActionDetails.DeserializeRecoveryPlanActionDetails(property.Value);
                    continue;
                }
            }
            return new RecoveryPlanAction(actionName, failoverTypes, failoverDirections, customDetails);
        }
    }
}
