// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    public partial class MongoDBRoleDefinitionData : IUtf8JsonSerializable
    {
        internal static MongoDBRoleDefinitionData DeserializeMongoDBRoleDefinitionData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<ResourceManager.Models.SystemData> systemData = default;
            Optional<string> roleName = default;
            Optional<MongoDBRoleDefinitionType> type0 = default;
            Optional<string> databaseName = default;
            Optional<IList<MongoDBPrivilege>> privileges = default;
            Optional<IList<MongoDBRole>> roles = default;
            foreach (var property in element.EnumerateObject())
            {
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
                    systemData = JsonSerializer.Deserialize<ResourceManager.Models.SystemData>(property.Value.ToString());
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
                        if (property0.NameEquals("roleName"))
                        {
                            roleName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            type0 = property0.Value.GetInt32().ToMongoDBRoleDefinitionType();
                            continue;
                        }
                        if (property0.NameEquals("databaseName"))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privileges"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<MongoDBPrivilege> array = new List<MongoDBPrivilege>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MongoDBPrivilege.DeserializeMongoDBPrivilege(item));
                            }
                            privileges = array;
                            continue;
                        }
                        if (property0.NameEquals("roles"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<MongoDBRole> array = new List<MongoDBRole>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MongoDBRole.DeserializeMongoDBRole(item));
                            }
                            roles = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MongoDBRoleDefinitionData(id, name, type, systemData.Value, roleName.Value, Optional.ToNullable(type0), databaseName.Value, Optional.ToList(privileges), Optional.ToList(roles));
        }
    }
}
