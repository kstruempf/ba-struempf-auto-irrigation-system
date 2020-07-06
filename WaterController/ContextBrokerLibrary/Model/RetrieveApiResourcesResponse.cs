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
    /// RetrieveApiResourcesResponse
    /// </summary>
    [DataContract]
    public partial class RetrieveApiResourcesResponse : IEquatable<RetrieveApiResourcesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetrieveApiResourcesResponse" /> class.
        /// </summary>
        /// <param name="entitiesUrl">URL which points to the entities resource (required).</param>
        /// <param name="typesUrl">URL which points to the types resource (required).</param>
        /// <param name="subscriptionsUrl">URL which points to the subscriptions resource (required).</param>
        /// <param name="registrationsUrl">URL which points to the registrations resource (required).</param>
        public RetrieveApiResourcesResponse(string entitiesUrl = default(string), string typesUrl = default(string),
            string subscriptionsUrl = default(string), string registrationsUrl = default(string))
        {
            // to ensure "entitiesUrl" is required (not null)
            if (entitiesUrl == null)
            {
                throw new InvalidDataException(
                    "entitiesUrl is a required property for RetrieveApiResourcesResponse and cannot be null");
            }
            else
            {
                this.EntitiesUrl = entitiesUrl;
            }

            // to ensure "typesUrl" is required (not null)
            if (typesUrl == null)
            {
                throw new InvalidDataException(
                    "typesUrl is a required property for RetrieveApiResourcesResponse and cannot be null");
            }
            else
            {
                this.TypesUrl = typesUrl;
            }

            // to ensure "subscriptionsUrl" is required (not null)
            if (subscriptionsUrl == null)
            {
                throw new InvalidDataException(
                    "subscriptionsUrl is a required property for RetrieveApiResourcesResponse and cannot be null");
            }
            else
            {
                this.SubscriptionsUrl = subscriptionsUrl;
            }

            // to ensure "registrationsUrl" is required (not null)
            if (registrationsUrl == null)
            {
                throw new InvalidDataException(
                    "registrationsUrl is a required property for RetrieveApiResourcesResponse and cannot be null");
            }
            else
            {
                this.RegistrationsUrl = registrationsUrl;
            }
        }

        /// <summary>
        /// URL which points to the entities resource
        /// </summary>
        /// <value>URL which points to the entities resource</value>
        [DataMember(Name = "entities_url", EmitDefaultValue = false)]
        public string EntitiesUrl { get; set; }

        /// <summary>
        /// URL which points to the types resource
        /// </summary>
        /// <value>URL which points to the types resource</value>
        [DataMember(Name = "types_url", EmitDefaultValue = false)]
        public string TypesUrl { get; set; }

        /// <summary>
        /// URL which points to the subscriptions resource
        /// </summary>
        /// <value>URL which points to the subscriptions resource</value>
        [DataMember(Name = "subscriptions_url", EmitDefaultValue = false)]
        public string SubscriptionsUrl { get; set; }

        /// <summary>
        /// URL which points to the registrations resource
        /// </summary>
        /// <value>URL which points to the registrations resource</value>
        [DataMember(Name = "registrations_url", EmitDefaultValue = false)]
        public string RegistrationsUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrieveApiResourcesResponse {\n");
            sb.Append("  EntitiesUrl: ").Append(EntitiesUrl).Append("\n");
            sb.Append("  TypesUrl: ").Append(TypesUrl).Append("\n");
            sb.Append("  SubscriptionsUrl: ").Append(SubscriptionsUrl).Append("\n");
            sb.Append("  RegistrationsUrl: ").Append(RegistrationsUrl).Append("\n");
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
            return this.Equals(input as RetrieveApiResourcesResponse);
        }

        /// <summary>
        /// Returns true if RetrieveApiResourcesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RetrieveApiResourcesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetrieveApiResourcesResponse input)
        {
            if (input == null)
                return false;

            return
                (
                    this.EntitiesUrl == input.EntitiesUrl ||
                    (this.EntitiesUrl != null &&
                     this.EntitiesUrl.Equals(input.EntitiesUrl))
                ) &&
                (
                    this.TypesUrl == input.TypesUrl ||
                    (this.TypesUrl != null &&
                     this.TypesUrl.Equals(input.TypesUrl))
                ) &&
                (
                    this.SubscriptionsUrl == input.SubscriptionsUrl ||
                    (this.SubscriptionsUrl != null &&
                     this.SubscriptionsUrl.Equals(input.SubscriptionsUrl))
                ) &&
                (
                    this.RegistrationsUrl == input.RegistrationsUrl ||
                    (this.RegistrationsUrl != null &&
                     this.RegistrationsUrl.Equals(input.RegistrationsUrl))
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
                if (this.EntitiesUrl != null)
                    hashCode = hashCode * 59 + this.EntitiesUrl.GetHashCode();
                if (this.TypesUrl != null)
                    hashCode = hashCode * 59 + this.TypesUrl.GetHashCode();
                if (this.SubscriptionsUrl != null)
                    hashCode = hashCode * 59 + this.SubscriptionsUrl.GetHashCode();
                if (this.RegistrationsUrl != null)
                    hashCode = hashCode * 59 + this.RegistrationsUrl.GetHashCode();
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