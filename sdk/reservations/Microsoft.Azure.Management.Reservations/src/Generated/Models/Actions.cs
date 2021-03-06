// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The actions for auto quota increase.
    /// </summary>
    public partial class Actions
    {
        /// <summary>
        /// Initializes a new instance of the Actions class.
        /// </summary>
        public Actions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Actions class.
        /// </summary>
        /// <param name="emailActions">The email actions for auto quota
        /// increase.</param>
        public Actions(EmailActions emailActions = default(EmailActions))
        {
            EmailActions = emailActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the email actions for auto quota increase.
        /// </summary>
        [JsonProperty(PropertyName = "emailActions")]
        public EmailActions EmailActions { get; set; }

    }
}
