﻿// <auto-generated>
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
// 
// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.
// 
// For documentation on code generator please visit
//   https://aka.ms/nrp-code-generation
// Please contact wanrpdev@microsoft.com if you need to make changes to this file.
// </auto-generated>

using Microsoft.Azure.Management.Network.Models;
using Microsoft.WindowsAzure.Commands.Common.Attributes;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Network.Models
{
    public partial class PSProbe : PSChildResource
    {
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public string Protocol { get; set; }
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public int Port { get; set; }
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public int IntervalInSeconds { get; set; }
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public int NumberOfProbes { get; set; }
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public int? ProbeThreshold { get; set; }
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public string RequestPath { get; set; }
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public string NoHealthyBackendsBehavior { get; set; }
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public string ProvisioningState { get; set; }
        [JsonProperty(Order = 1)]
        public List<PSResourceId> LoadBalancingRules { get; set; }

        [JsonIgnore]
        public string LoadBalancingRulesText
        {
            get { return JsonConvert.SerializeObject(LoadBalancingRules, Formatting.Indented, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore }); }
        }

        public bool ShouldSerializePort()
        {
            return !string.IsNullOrEmpty(this.Name);
        }

        public bool ShouldSerializeIntervalInSeconds()
        {
            return !string.IsNullOrEmpty(this.Name);
        }

        public bool ShouldSerializeNumberOfProbes()
        {
            return !string.IsNullOrEmpty(this.Name);
        }

        public bool ShouldSerializeProbeThreshold()
        {
            return !string.IsNullOrEmpty(this.Name);
        }

        public bool ShouldSerializeLoadBalancingRules()
        {
            return !string.IsNullOrEmpty(this.Name);
        }
    }
}
