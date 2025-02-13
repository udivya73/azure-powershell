// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System.Linq;

    /// <summary>
    /// Properties of a cost target.
    /// </summary>
    public partial class TargetCostProperties
    {
        /// <summary>
        /// Initializes a new instance of the TargetCostProperties class.
        /// </summary>
        public TargetCostProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TargetCostProperties class.
        /// </summary>

        /// <param name="status">Target cost status
        /// Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;</param>

        /// <param name="target">Lab target cost
        /// </param>

        /// <param name="costThresholds">Cost thresholds.
        /// </param>

        /// <param name="cycleStartDateTime">Reporting cycle start date.
        /// </param>

        /// <param name="cycleEndDateTime">Reporting cycle end date.
        /// </param>

        /// <param name="cycleType">Reporting cycle type.
        /// Possible values include: &#39;CalendarMonth&#39;, &#39;Custom&#39;</param>
        public TargetCostProperties(string status = default(string), int? target = default(int?), System.Collections.Generic.IList<CostThresholdProperties> costThresholds = default(System.Collections.Generic.IList<CostThresholdProperties>), System.DateTime? cycleStartDateTime = default(System.DateTime?), System.DateTime? cycleEndDateTime = default(System.DateTime?), string cycleType = default(string))

        {
            this.Status = status;
            this.Target = target;
            this.CostThresholds = costThresholds;
            this.CycleStartDateTime = cycleStartDateTime;
            this.CycleEndDateTime = cycleEndDateTime;
            this.CycleType = cycleType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets target cost status Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; set; }

        /// <summary>
        /// Gets or sets lab target cost
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "target")]
        public int? Target {get; set; }

        /// <summary>
        /// Gets or sets cost thresholds.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "costThresholds")]
        public System.Collections.Generic.IList<CostThresholdProperties> CostThresholds {get; set; }

        /// <summary>
        /// Gets or sets reporting cycle start date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "cycleStartDateTime")]
        public System.DateTime? CycleStartDateTime {get; set; }

        /// <summary>
        /// Gets or sets reporting cycle end date.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "cycleEndDateTime")]
        public System.DateTime? CycleEndDateTime {get; set; }

        /// <summary>
        /// Gets or sets reporting cycle type. Possible values include: &#39;CalendarMonth&#39;, &#39;Custom&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "cycleType")]
        public string CycleType {get; set; }
    }
}