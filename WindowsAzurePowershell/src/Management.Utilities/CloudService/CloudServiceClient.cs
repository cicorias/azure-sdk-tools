﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.Utilities.CloudService
{
    using System;
    using System.Linq;
    using Microsoft.WindowsAzure.Management.Utilities.Common;
    using Microsoft.WindowsAzure.Management.Utilities.Properties;
    using Microsoft.WindowsAzure.ServiceManagement;

    public class CloudServiceClient : ICloudServiceClient
    {
        public IServiceManagement ServiceManagementChannel { get; set; }

        public SubscriptionData Subscription { get; set; }

        public Action<string> DebugStream { get; set; }

        public Action<string> VerboseStream { get; set; }

        public Action<string> WarningeStream { get; set; }

        private string subscriptionId;

        enum CloudServiceState
        {
            Start,
            Stop
        }

        private void VerifyDeploymentExists(HostedService cloudService, string slot)
        {
            bool exists = false;

            if (cloudService.Deployments != null)
            {
                exists = cloudService.Deployments.Exists(d => d.DeploymentSlot == slot);
            }

            if (!exists)
            {
                throw new Exception(string.Format(Resources.CannotFindDeployment, cloudService.ServiceName, slot));
            }
        }

        private string GetSlot(string slot)
        {
            return string.IsNullOrEmpty(slot) ? DeploymentSlotType.Production : slot;
        }

        private void SetCloudServiceState(string name, string slot, CloudServiceState state)
        {
            slot = GetSlot(slot);
            HostedService cloudService = GetCloudService(name);
            VerifyDeploymentExists(cloudService, slot);
            ServiceManagementChannel.UpdateDeploymentStatusBySlot(
                subscriptionId,
                cloudService.ServiceName,
                slot,
                new UpdateDeploymentStatusInput()
                {
                    Status = state == CloudServiceState.Start ? DeploymentStatus.Running : DeploymentStatus.Suspended
                }
            );
        }

        private HostedService GetCloudService(string name)
        {
            try
            {
                return ServiceManagementChannel.GetHostedServiceWithDetails(subscriptionId, name, true);
            }
            catch (Exception)
            {
                throw new Exception(string.Format(Resources.ServiceDoesNotExist, name));
            }
        }

        private void WriteToStream(Action<string> stream, string format, params object[] args)
        {
            if (stream != null)
            {
                stream(string.Format(format, args));
            }
        }

        private void WriteWarning(string format, params object[] args)
        {
            WriteToStream(WarningeStream, format, args);
        }

        private void WriteVerbose(string format, params object[] args)
        {
            WriteToStream(VerboseStream, format, args);
        }

        /// <summary>
        /// Creates new instance from CloudServiceClient.
        /// </summary>
        /// <param name="subscription">The subscription data</param>
        /// <param name="debugStream">Action used to log http requests/responses</param>
        /// <param name="verboseStream">Action used to log detailed client progress</param>
        /// <param name="warningStream">Action used to log warning messages</param>
        public CloudServiceClient(
            SubscriptionData subscription,
            Action<string> debugStream = null,
            Action<string> verboseStream = null,
            Action<string> warningStream = null)
        {
            Subscription = subscription;
            subscriptionId = subscription.SubscriptionId;
            DebugStream = debugStream;
            VerboseStream = verboseStream;
            WarningeStream = warningStream;

            ServiceManagementChannel = ServiceManagementHelper.CreateServiceManagementChannel<IServiceManagement>(
                ConfigurationConstants.WebHttpBinding(),
                new Uri(subscription.ServiceEndpoint),
                subscription.Certificate,
                new HttpRestMessageInspector(DebugStream));
        }

        /// <summary>
        /// Starts a cloud service.
        /// </summary>
        /// <param name="name">The cloud service name</param>
        /// <param name="slot">The deployment slot</param>
        public void StartCloudService(string name, string slot)
        {
            SetCloudServiceState(name, slot, CloudServiceState.Start);
        }

        /// <summary>
        /// Stops a cloud service.
        /// </summary>
        /// <param name="name">The cloud service name</param>
        /// <param name="slot">The deployment slot</param>
        public void StopCloudService(string name, string slot)
        {
            SetCloudServiceState(name, slot, CloudServiceState.Stop);
        }

        /// <summary>
        /// Check if the deployment exists for given cloud service.
        /// </summary>
        /// <param name="name">The cloud service name</param>
        /// <param name="slot">The deployment slot name</param>
        /// <returns>Flag indicating the deployment exists or not</returns>
        public bool DeploymentExists(string name, string slot)
        {
            HostedService cloudService = GetCloudService(name);
            try
            {
                VerifyDeploymentExists(cloudService, slot);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
