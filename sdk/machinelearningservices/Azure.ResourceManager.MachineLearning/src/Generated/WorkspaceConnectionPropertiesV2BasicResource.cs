// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing a WorkspaceConnectionPropertiesV2BasicResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WorkspaceConnectionPropertiesV2BasicResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWorkspaceConnectionPropertiesV2BasicResource method.
    /// Otherwise you can get one from its parent resource <see cref="MachineLearningWorkspaceResource" /> using the GetWorkspaceConnectionPropertiesV2BasicResource method.
    /// </summary>
    public partial class WorkspaceConnectionPropertiesV2BasicResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WorkspaceConnectionPropertiesV2BasicResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string connectionName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsClientDiagnostics;
        private readonly WorkspaceConnectionsRestOperations _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsRestClient;
        private readonly WorkspaceConnectionPropertiesV2BasicResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="WorkspaceConnectionPropertiesV2BasicResource"/> class for mocking. </summary>
        protected WorkspaceConnectionPropertiesV2BasicResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WorkspaceConnectionPropertiesV2BasicResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WorkspaceConnectionPropertiesV2BasicResource(ArmClient client, WorkspaceConnectionPropertiesV2BasicResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="WorkspaceConnectionPropertiesV2BasicResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WorkspaceConnectionPropertiesV2BasicResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsApiVersion);
            _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsRestClient = new WorkspaceConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/connections";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual WorkspaceConnectionPropertiesV2BasicResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WorkspaceConnectionPropertiesV2BasicResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsClientDiagnostics.CreateScope("WorkspaceConnectionPropertiesV2BasicResource.Get");
            scope.Start();
            try
            {
                var response = await _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspaceConnectionPropertiesV2BasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WorkspaceConnectionPropertiesV2BasicResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsClientDiagnostics.CreateScope("WorkspaceConnectionPropertiesV2BasicResource.Get");
            scope.Start();
            try
            {
                var response = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkspaceConnectionPropertiesV2BasicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsClientDiagnostics.CreateScope("WorkspaceConnectionPropertiesV2BasicResource.Delete");
            scope.Start();
            try
            {
                var response = await _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Delete
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsClientDiagnostics.CreateScope("WorkspaceConnectionPropertiesV2BasicResource.Delete");
            scope.Start();
            try
            {
                var response = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The object for creating or updating a new workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkspaceConnectionPropertiesV2BasicResource>> UpdateAsync(WaitUntil waitUntil, WorkspaceConnectionPropertiesV2BasicResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsClientDiagnostics.CreateScope("WorkspaceConnectionPropertiesV2BasicResource.Update");
            scope.Start();
            try
            {
                var response = await _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<WorkspaceConnectionPropertiesV2BasicResource>(Response.FromValue(new WorkspaceConnectionPropertiesV2BasicResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/connections/{connectionName}
        /// Operation Id: WorkspaceConnections_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> The object for creating or updating a new workspace connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkspaceConnectionPropertiesV2BasicResource> Update(WaitUntil waitUntil, WorkspaceConnectionPropertiesV2BasicResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsClientDiagnostics.CreateScope("WorkspaceConnectionPropertiesV2BasicResource.Update");
            scope.Start();
            try
            {
                var response = _workspaceConnectionPropertiesV2BasicResourceWorkspaceConnectionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<WorkspaceConnectionPropertiesV2BasicResource>(Response.FromValue(new WorkspaceConnectionPropertiesV2BasicResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
