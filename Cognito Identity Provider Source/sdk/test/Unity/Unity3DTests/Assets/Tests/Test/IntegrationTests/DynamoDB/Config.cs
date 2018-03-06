﻿using UnityEngine;
using System.Collections;
using AWSSDK.Tests.Framework;
using Amazon.Util;
using Amazon.DynamoDBv2;
using Amazon;

namespace AWSSDK.IntegrationTests.DynamoDB
{
    public partial class DynamoDBTests : TestBase<AmazonDynamoDBClient, AmazonDynamoDBConfig>
    {
        private static void ConfigureContext()
        {
            var currentStatusPropertyConfig = new PropertyConfig("CurrentStatus")
            {
                Converter = typeof(StatusConverter)
            };

            var employeeMapping = new TypeMapping(typeof(Employee), "HashRangeTable");
            employeeMapping.AddProperty(new PropertyConfig("ManagerName") { Attribute = "Manager" });
            employeeMapping.AddProperty(new PropertyConfig("CompanyName") { Attribute = "Company" });
            employeeMapping.AddProperty(new PropertyConfig("InternalId") { Ignore = true });
            employeeMapping.AddProperty(currentStatusPropertyConfig);

            var employee2Mapping = new TypeMapping(typeof(Employee2), "HashRangeTable");
            employee2Mapping.AddProperty(currentStatusPropertyConfig);

            var employee3Mapping = new TypeMapping(typeof(Employee3), "HashRangeTable");
            employee3Mapping.AddProperty(currentStatusPropertyConfig);

            var versionedEmployeeMapping = new TypeMapping(typeof(VersionedEmployee), "FakeTable");
            versionedEmployeeMapping.AddProperty(new PropertyConfig("Version") { Ignore = true });

            var context = AWSConfigsDynamoDB.Context;
            context.TableAliases["FakeTable"] = "HashRangeTable";


            //to save retries
            if (!context.TypeMappings.ContainsKey(typeof(VersionedEmployee)))
            {
                context.AddMapping(versionedEmployeeMapping);
            }
            if (!context.TypeMappings.ContainsKey(typeof(Employee3)))
            {
                context.AddMapping(employee3Mapping);
            }

            if (!context.TypeMappings.ContainsKey(typeof(Employee2)))
            {
                context.AddMapping(employee2Mapping);
            }
            if (!context.TypeMappings.ContainsKey(typeof(Employee)))
            {
                context.AddMapping(employeeMapping);
            }
        }
    }
}