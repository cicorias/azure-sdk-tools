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

namespace Microsoft.WindowsAzure.Commands.Utilities.Common
{
    using Microsoft.WindowsAzure.Commands.Common;
    using Microsoft.WindowsAzure.Commands.Common.Models;
    using System.Net.Http.Headers;

    public static class ApiConstants
    {
        public const string LatestApiVersion = ServiceManagement.Constants.VersionHeaderContentLatest;
        public const string VersionHeaderName = ServiceManagement.Constants.VersionHeaderName;

        public const string AuthorizationHeaderName = "Authorization";

        public const string BasicAuthorization = "Basic";

        public const string TracingEventResponseHeaderPrefix = "TracingEvent_";

        public const string RunningState = "Running";
        public const string StoppedState = "Stopped";

        public const string CustomDomainsEnabledSettingsName = "CustomDomainsEnabled";
        public const string SslSupportSettingsName = "SslSupport";

        public const string UserAgentHeaderName = "User-Agent";
        public const string UserAgentHeaderValue = "AzurePowershell/v" + AzurePowerShell.AssemblyVersion;
        public static ProductInfoHeaderValue UserAgentValue = new ProductInfoHeaderValue(
            "AzurePowershell",
            string.Format("v{0}", AzurePowerShell.AssemblyVersion));

        public const string VSDebuggerCausalityDataHeaderName = "VSDebuggerCausalityData";
        
    }

    public class SDKVersion
    {
        public const string Version180 = "1.8.0";

        public const string Version200 = "2.0.0";

        public const string Version220 = "2.2.0";

        public const string Version230 = "2.3.0";

        public const string Version240 = "2.4.0";
    }

    public enum DevEnv
    {
        Local,
        Cloud
    }

    public enum RoleType
    {
        WebRole,
        WorkerRole
    }

    public enum RuntimeType
    {
        IISNode,
        Node,
        PHP,
        Cache,
        Null
    }

    public static class EnvironmentName
    {
        public const string AzureCloud = "AzureCloud";

        public const string AzureChinaCloud = "AzureChinaCloud";
    }

    public static class WindowsAzureEnvironmentConstants
    {
        public const string AzureServiceEndpoint = "https://management.core.windows.net/";

        public const string ChinaServiceEndpoint = "https://management.core.chinacloudapi.cn/";

        public const string AzureResourceManagerEndpoint = "https://management.azure.com/";

        public const string GalleryEndpoint = "https://gallery.azure.com/";

        public const string AzurePublishSettingsFileUrl = "http://go.microsoft.com/fwlink/?LinkID=301775";

        public const string ChinaPublishSettingsFileUrl = "http://go.microsoft.com/fwlink/?LinkID=301776";

        public const string AzureManagementPortalUrl = "http://go.microsoft.com/fwlink/?LinkId=254433";

        public const string ChinaManagementPortalUrl = "http://go.microsoft.com/fwlink/?LinkId=301902";

        public const string AzureStorageEndpointSuffix = "core.windows.net";

        public const string ChinaStorageEndpointSuffix = "core.chinacloudapi.cn";

        public const string AzureStorageBlobEndpointFormat = "{0}://{1}.blob.core.windows.net/";

        public const string AzureStorageQueueEndpointFormat = "{0}://{1}.queue.core.windows.net/";

        public const string AzureStorageTableEndpointFormat = "{0}://{1}.table.core.windows.net/";

        public const string ChinaStorageBlobEndpointFormat = "{0}://{1}.blob.core.chinacloudapi.cn/";

        public const string ChinaStorageQueueEndpointFormat = "{0}://{1}.queue.core.chinacloudapi.cn/";

        public const string ChinaStorageTableEndpointFormat = "{0}://{1}.table.core.chinacloudapi.cn/";

        public const string AzureSqlDatabaseDnsSuffix = ".database.windows.net";

        public const string ChinaSqlDatabaseDnsSuffix = ".database.chinacloudapi.cn";

        public const string AzureActiveDirectoryEndpoint = "https://login.windows.net/";

        public const string ChinaActiveDirectoryEndpoint = "https://login.chinacloudapi.cn/";
    }
}