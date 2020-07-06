/* 
 * FIWARE-NGSI v2 Specification
 *
 * TODO: Add a description
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace ContextBrokerLibrary.Model
{
    /// <summary>
    /// CreateEntityRequest
    /// </summary>
    [DataContract]
    public partial class CreateEntityRequest : IEquatable<CreateEntityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEntityRequest" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="temperature">temperature (required).</param>
        /// <param name="humidity">humidity (required).</param>
        /// <param name="location">location (required).</param>
        public CreateEntityRequest(string type = default(string), string id = default(string),
            Object temperature = default(Object), Object humidity = default(Object), Object location = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException(
                    "type is a required property for CreateEntityRequest and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for CreateEntityRequest and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "temperature" is required (not null)
            if (temperature == null)
            {
                throw new InvalidDataException(
                    "temperature is a required property for CreateEntityRequest and cannot be null");
            }
            else
            {
                this.Temperature = temperature;
            }

            // to ensure "humidity" is required (not null)
            if (humidity == null)
            {
                throw new InvalidDataException(
                    "humidity is a required property for CreateEntityRequest and cannot be null");
            }
            else
            {
                this.Humidity = humidity;
            }

            // to ensure "location" is required (not null)
            if (location == null)
            {
                throw new InvalidDataException(
                    "location is a required property for CreateEntityRequest and cannot be null");
            }
            else
            {
                this.Location = location;
            }
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Temperature
        /// </summary>
        [DataMember(Name = "temperature", EmitDefaultValue = false)]
        public Object Temperature { get; set; }

        /// <summary>
        /// Gets or Sets Humidity
        /// </summary>
        [DataMember(Name = "humidity", EmitDefaultValue = false)]
        public Object Humidity { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public Object Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateEntityRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Temperature: ").Append(Temperature).Append("\n");
            sb.Append("  Humidity: ").Append(Humidity).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateEntityRequest);
        }

        /// <summary>
        /// Returns true if CreateEntityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateEntityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateEntityRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                     this.Type.Equals(input.Type))
                ) &&
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                     this.Id.Equals(input.Id))
                ) &&
                (
                    this.Temperature == input.Temperature ||
                    (this.Temperature != null &&
                     this.Temperature.Equals(input.Temperature))
                ) &&
                (
                    this.Humidity == input.Humidity ||
                    (this.Humidity != null &&
                     this.Humidity.Equals(input.Humidity))
                ) &&
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                     this.Location.Equals(input.Location))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Temperature != null)
                    hashCode = hashCode * 59 + this.Temperature.GetHashCode();
                if (this.Humidity != null)
                    hashCode = hashCode * 59 + this.Humidity.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext)
        {
            yield break;
        }
    }
}