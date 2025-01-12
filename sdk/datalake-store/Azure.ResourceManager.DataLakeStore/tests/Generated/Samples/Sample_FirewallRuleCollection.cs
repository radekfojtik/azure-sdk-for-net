// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.DataLakeStore.Models;

namespace Azure.ResourceManager.DataLakeStore
{
    public partial class Sample_FirewallRuleCollection
    {
        // Lists the Data Lake Store firewall rules within the specified Data Lake Store account.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsTheDataLakeStoreFirewallRulesWithinTheSpecifiedDataLakeStoreAccount()
        {
            // Generated from example definition: specification/datalake-store/resource-manager/Microsoft.DataLakeStore/stable/2016-11-01/examples/FirewallRules_ListByAccount.json
            // this example is just showing the usage of "FirewallRules_ListByAccount" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DataLakeStoreAccountResource created on azure
            // for more information of creating DataLakeStoreAccountResource, please refer to the document of DataLakeStoreAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeStoreAccountResourceId = DataLakeStoreAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeStoreAccountResource dataLakeStoreAccount = client.GetDataLakeStoreAccountResource(dataLakeStoreAccountResourceId);

            // get the collection of this FirewallRuleResource
            FirewallRuleCollection collection = dataLakeStoreAccount.GetFirewallRules();

            // invoke the operation and iterate over the result
            await foreach (FirewallRuleResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirewallRuleData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Creates or updates the specified firewall rule. During update, the firewall rule with the specified name will be replaced with this new firewall rule
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreatesOrUpdatesTheSpecifiedFirewallRuleDuringUpdateTheFirewallRuleWithTheSpecifiedNameWillBeReplacedWithThisNewFirewallRule()
        {
            // Generated from example definition: specification/datalake-store/resource-manager/Microsoft.DataLakeStore/stable/2016-11-01/examples/FirewallRules_CreateOrUpdate.json
            // this example is just showing the usage of "FirewallRules_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DataLakeStoreAccountResource created on azure
            // for more information of creating DataLakeStoreAccountResource, please refer to the document of DataLakeStoreAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeStoreAccountResourceId = DataLakeStoreAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeStoreAccountResource dataLakeStoreAccount = client.GetDataLakeStoreAccountResource(dataLakeStoreAccountResourceId);

            // get the collection of this FirewallRuleResource
            FirewallRuleCollection collection = dataLakeStoreAccount.GetFirewallRules();

            // invoke the operation
            string firewallRuleName = "test_rule";
            FirewallRuleCreateOrUpdateContent content = new FirewallRuleCreateOrUpdateContent("1.1.1.1", "2.2.2.2");
            ArmOperation<FirewallRuleResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firewallRuleName, content);
            FirewallRuleResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the specified Data Lake Store firewall rule.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetsTheSpecifiedDataLakeStoreFirewallRule()
        {
            // Generated from example definition: specification/datalake-store/resource-manager/Microsoft.DataLakeStore/stable/2016-11-01/examples/FirewallRules_Get.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DataLakeStoreAccountResource created on azure
            // for more information of creating DataLakeStoreAccountResource, please refer to the document of DataLakeStoreAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeStoreAccountResourceId = DataLakeStoreAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeStoreAccountResource dataLakeStoreAccount = client.GetDataLakeStoreAccountResource(dataLakeStoreAccountResourceId);

            // get the collection of this FirewallRuleResource
            FirewallRuleCollection collection = dataLakeStoreAccount.GetFirewallRules();

            // invoke the operation
            string firewallRuleName = "test_rule";
            FirewallRuleResource result = await collection.GetAsync(firewallRuleName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallRuleData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Gets the specified Data Lake Store firewall rule.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetsTheSpecifiedDataLakeStoreFirewallRule()
        {
            // Generated from example definition: specification/datalake-store/resource-manager/Microsoft.DataLakeStore/stable/2016-11-01/examples/FirewallRules_Get.json
            // this example is just showing the usage of "FirewallRules_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this DataLakeStoreAccountResource created on azure
            // for more information of creating DataLakeStoreAccountResource, please refer to the document of DataLakeStoreAccountResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "contosorg";
            string accountName = "contosoadla";
            ResourceIdentifier dataLakeStoreAccountResourceId = DataLakeStoreAccountResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName);
            DataLakeStoreAccountResource dataLakeStoreAccount = client.GetDataLakeStoreAccountResource(dataLakeStoreAccountResourceId);

            // get the collection of this FirewallRuleResource
            FirewallRuleCollection collection = dataLakeStoreAccount.GetFirewallRules();

            // invoke the operation
            string firewallRuleName = "test_rule";
            bool result = await collection.ExistsAsync(firewallRuleName);

            Console.WriteLine($"Succeeded: {result}");
        }
    }
}
