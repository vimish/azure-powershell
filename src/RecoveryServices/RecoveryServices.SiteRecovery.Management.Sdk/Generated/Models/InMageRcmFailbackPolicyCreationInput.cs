// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using System.Linq;

    /// <summary>
    /// InMageRcmFailback policy creation input.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageRcmFailback")]
    public partial class InMageRcmFailbackPolicyCreationInput : PolicyProviderSpecificInput
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmFailbackPolicyCreationInput class.
        /// </summary>
        public InMageRcmFailbackPolicyCreationInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmFailbackPolicyCreationInput class.
        /// </summary>

        /// <param name="crashConsistentFrequencyInMinutes">The crash consistent snapshot frequency (in minutes).
        /// </param>

        /// <param name="appConsistentFrequencyInMinutes">The app consistent snapshot frequency (in minutes).
        /// </param>
        public InMageRcmFailbackPolicyCreationInput(int? crashConsistentFrequencyInMinutes = default(int?), int? appConsistentFrequencyInMinutes = default(int?))

        {
            this.CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            this.AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the crash consistent snapshot frequency (in minutes).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "crashConsistentFrequencyInMinutes")]
        public int? CrashConsistentFrequencyInMinutes {get; set; }

        /// <summary>
        /// Gets or sets the app consistent snapshot frequency (in minutes).
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "appConsistentFrequencyInMinutes")]
        public int? AppConsistentFrequencyInMinutes {get; set; }
    }
}