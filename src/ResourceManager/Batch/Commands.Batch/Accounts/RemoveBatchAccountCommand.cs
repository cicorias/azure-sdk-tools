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

namespace Microsoft.Azure.Commands.Batch
{
    using System;
    using System.Collections.Generic;
    using System.Management.Automation;
    using Microsoft.Azure.Management.Batch.Models;
    using Microsoft.Azure.Commands.Batch.Properties;

    [Cmdlet(VerbsCommon.Remove, "AzureBatchAccount")]
    public class RemoveBatchAccountCommand : BatchCmdletBase
    {
        private static string mamlCall = "RemoveAccount";

        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The name of the Batch service account to remove.")]
        [Alias("Name")]
        [ValidateNotNullOrEmpty]
        public string AccountName { get; set; }

        [Parameter(Position = 1, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group of the account being removed.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Do not ask for confirmation.")]
        public SwitchParameter Force { get; set; }

        public override void ExecuteCmdlet()
        {
            var resourceGroupName = this.ResourceGroupName;

            if (string.IsNullOrEmpty(resourceGroupName))
            {
                // use resource mgr to see if account exists and then use resource group name to do the actual lookup
                WriteVerboseWithTimestamp(Resources.ResGroupLookup, this.AccountName);
                resourceGroupName = BatchClient.GetGroupForAccount(this.AccountName);
            }

            ConfirmAction(
                Force.IsPresent,
                string.Format(Resources.RBA_RemoveConfirm, this.AccountName),
                Resources.RBA_RemoveResource,
                this.AccountName,
                () => DeleteAction(resourceGroupName, this.AccountName));
        }

        private void DeleteAction(string resGroupName, string accountName)
        {
            WriteVerboseWithTimestamp(Resources.BeginMAMLCall, mamlCall);
            BatchClient.DeleteAccount(resGroupName, accountName);
            WriteVerboseWithTimestamp(Resources.EndMAMLCall, mamlCall);
        }
    }
}
