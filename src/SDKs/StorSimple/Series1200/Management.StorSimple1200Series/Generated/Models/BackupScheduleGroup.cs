// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Backup Schedule Group
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BackupScheduleGroup : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the BackupScheduleGroup class.
        /// </summary>
        public BackupScheduleGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupScheduleGroup class.
        /// </summary>
        /// <param name="startTime">The start time. When this field is
        /// specified we will generate Default GrandFather Father Son Backup
        /// Schedules.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        public BackupScheduleGroup(Time startTime, string id = default(string), string name = default(string), string type = default(string))
            : base(id, name, type)
        {
            StartTime = startTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the start time. When this field is specified we will
        /// generate Default GrandFather Father Son Backup Schedules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public Time StartTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StartTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartTime");
            }
            if (StartTime != null)
            {
                StartTime.Validate();
            }
        }
    }
}
