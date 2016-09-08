// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.Sql.Models
{
    /// <summary>
    /// Represents the properties of an Azure SQL Security alert policy.
    /// </summary>
    public partial class BaseSecurityAlertPolicyProperties
    {
        private string _disabledAlerts;
        
        /// <summary>
        /// Optional. Gets the disable alerts of the Azure SQL Security alert
        /// policy.
        /// </summary>
        public string DisabledAlerts
        {
            get { return this._disabledAlerts; }
            set { this._disabledAlerts = value; }
        }
        
        private string _emailAccountAdmins;
        
        /// <summary>
        /// Optional. Gets whether to email the azure account admins.
        /// </summary>
        public string EmailAccountAdmins
        {
            get { return this._emailAccountAdmins; }
            set { this._emailAccountAdmins = value; }
        }
        
        private string _emailAddresses;
        
        /// <summary>
        /// Optional. Gets the list of email addresses to send the alert.
        /// </summary>
        public string EmailAddresses
        {
            get { return this._emailAddresses; }
            set { this._emailAddresses = value; }
        }
        
        private int _retentionDays;
        
        /// <summary>
        /// Optional. Specifies the number of days to keep in the audit logs.
        /// </summary>
        public int RetentionDays
        {
            get { return this._retentionDays; }
            set { this._retentionDays = value; }
        }
        
        private string _state;
        
        /// <summary>
        /// Optional. Gets the state of the Azure SQL Security alert policy.
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }
        
        private string _storageAccountAccessKey;
        
        /// <summary>
        /// Optional. Specifies the identifier key of the auditing storage
        /// account.
        /// </summary>
        public string StorageAccountAccessKey
        {
            get { return this._storageAccountAccessKey; }
            set { this._storageAccountAccessKey = value; }
        }
        
        private string _storageEndpoint;
        
        /// <summary>
        /// Optional. Specifies the blob storage endpoint (e.g.
        /// https://MyAccount.blob.core.windows.net).
        /// </summary>
        public string StorageEndpoint
        {
            get { return this._storageEndpoint; }
            set { this._storageEndpoint = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the BaseSecurityAlertPolicyProperties
        /// class.
        /// </summary>
        public BaseSecurityAlertPolicyProperties()
        {
        }
    }
}