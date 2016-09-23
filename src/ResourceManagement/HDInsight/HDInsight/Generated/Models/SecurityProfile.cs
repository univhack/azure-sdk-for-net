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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.HDInsight.Models;

namespace Microsoft.Azure.Management.HDInsight.Models
{
    public partial class SecurityProfile
    {
        private ActiveDirectoryConfiguration _activeDirectoryConfiguration;
        
        /// <summary>
        /// Optional. Gets or sets the active directory configuration.
        /// </summary>
        public ActiveDirectoryConfiguration ActiveDirectoryConfiguration
        {
            get { return this._activeDirectoryConfiguration; }
            set { this._activeDirectoryConfiguration = value; }
        }
        
        private string _roleAdminGroupDN;
        
        /// <summary>
        /// Optional. Gets or sets the Distinguished Name for role
        /// admin group.
        /// </summary>
        public string RoleAdminGroupDN
        {
            get { return this._roleAdminGroupDN; }
            set { this._roleAdminGroupDN = value; }
        }
        
        private IList<string> _roleUsersGroupDNs;
        
        /// <summary>
        /// Optional. Optional. Gets or sets the Distinguished Names for user
        /// groups
        /// </summary>
        public IList<string> RoleUsersGroupDNs
        {
            get { return this._roleUsersGroupDNs; }
            set { this._roleUsersGroupDNs = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SecurityProfile class.
        /// </summary>
        public SecurityProfile()
        {
            this.RoleUsersGroupDNs = new LazyList<string>();
        }
    }
}