// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations.Tests.Helper
{
    public static class TestHelpers
    {
        public static ReservationPurchaseContent CreatePurchaseRequestContent(string scope, string billingPlan)
        {
            var request = new ReservationPurchaseContent
            {
                Sku = new ReservationsSkuName("Standard_B1ls"),
                Location = new Core.AzureLocation("westeurope"),
                ReservedResourceType = new ReservedResourceType("VirtualMachines"),
                BillingScopeId = new Core.ResourceIdentifier("/subscriptions/fed2a274-8787-4a13-8371-f5282597b779"),
                Term = new ReservationTerm("P1Y"),
                BillingPlan = new ReservationBillingPlan(billingPlan),
                Quantity = 3,
                DisplayName = "testVM",
                AppliedScopeType = new AppliedScopeType(scope),
                IsRenewEnabled = false,
                ReservedResourceProperties = new PurchaseRequestPropertiesReservedResourceProperties(new InstanceFlexibility("On")),
            };

            if (scope.Equals("Single"))
            {
                request.AppliedScopes.Add("/subscriptions/fed2a274-8787-4a13-8371-f5282597b779");
            }

            return request;
        }
    }
}
