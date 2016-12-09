﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using gShell.dotNet.Utilities.OAuth2;

namespace gShell.Cmdlets.Utilities.OAuth2
{
    public abstract class ServiceAccountCmdletBase : AuthenticatedCmdletBase
    {
        /// <summary>Gets or sets the email account the gShell Service Account should impersonate.</summary>
        protected static string gShellServiceAccount { get; set; }

        #region Properties

        /// <summary>
        /// <para type="description">The email account to be targeted by the service account.</para>
        /// </summary>
        [Alias("ServiceAccountTarget")]
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public string TargetUserEmail { get; set; }

        #endregion

        protected override void BeginProcessing()
        {
            var secrets = CheckForClientSecrets();
            if (secrets != null)
            {
                //TODO: figure out the correct ordering of these requests, and add the service account email to the build service
                IEnumerable<string> scopes = EnsureScopesExist(GAuthId);
                //need the gauthID first anyways to ensure that they have permissions, and to look up the service account
                GAuthId = ServiceWrapperDictionary[mainBaseType].BuildService(Authenticate(scopes, secrets, GAuthId)).domain;

                if (!string.IsNullOrWhiteSpace(TargetUserEmail))
                {
                    if (!OAuth2Base.infoConsumer.ServiceAccountExists(GAuthId))
                    {
                        WriteWarning("No service account was found for domain " + GAuthId + ". Please set a service" +
                            " account with Set-GShellServiceAccount, or see https://github.com/squid808/gShell/wiki/Service-Accounts" +
                            " for more information.");
                    }

                    gShellServiceAccount = GetFullEmailAddress(TargetUserEmail, GAuthId);

                    GAuthId = ServiceWrapperDictionary[mainBaseType].BuildService(Authenticate(scopes, secrets, GAuthId),TargetUserEmail).domain;
                }

                GWriteProgress = new gWriteProgress(WriteProgress);
            }
            else
            {
                WriteError(new ErrorRecord(null, (new Exception(
                    "Client Secrets must be set before running cmdlets. Run 'Get-Help "
                    + "Set-gShellClientSecrets -online' for more information."))));
            }
        }

        /// <summary>The gShell base implementation of the PowerShell EndProcessing method.</summary>
        /// <remarks>We need to reset the service account after every Cmdlet call to prevent the next
        /// Cmdlet from inheriting it as well.</remarks>
        protected override void EndProcessing()
        {
            gShellServiceAccount = string.Empty;
        }

        /// <summary>The gShell base implementation of the PowerShell StopProcessing method.</summary>
        /// <remarks>We need to reset the service account after every Cmdlet call to prevent the next
        /// Cmdlet from inheriting it as well.</remarks>
        protected override void StopProcessing()
        {
            gShellServiceAccount = string.Empty;
        }

    }
}