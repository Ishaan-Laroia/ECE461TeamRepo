/* 
 * ECE 461 - Fall 2021 - Project 2
 *
 * API for ECE 461/Fall 2021/Project 2: A Trustworthy Module Registry
 *
 * OpenAPI spec version: 3.0.2
 * Contact: davisjam@purdue.edu
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// This is a \&quot;union\&quot; type. - On package upload, either Content or URL should be set. - On package update, exactly one field should be set. - On download, the Content field should be set.
    /// </summary>
    [DataContract]
        public partial class PackageData :  IEquatable<PackageData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PackageData" /> class.
        /// </summary>
        /// <param name="content">Package contents. This is the zip file uploaded by the user. (Encoded as text using a Base64 encoding).  This will be a zipped version of an npm package&#x27;s GitHub repository, minus the \&quot;.git/\&quot; directory.\&quot; It will, for example, include the \&quot;package.json\&quot; file that can be used to retrieve the project homepage.  See https://docs.npmjs.com/cli/v7/configuring-npm/package-json#homepage..</param>
        /// <param name="uRL">Package URL (for use in public ingest)..</param>
        /// <param name="jSProgram">A JavaScript program (for use with sensitive modules)..</param>
        public PackageData(string content = default(string), string uRL = default(string), string jSProgram = default(string))
        {
            this.Content = content;
            this.URL = uRL;
            this.JSProgram = jSProgram;
        }
        
        /// <summary>
        /// Package contents. This is the zip file uploaded by the user. (Encoded as text using a Base64 encoding).  This will be a zipped version of an npm package&#x27;s GitHub repository, minus the \&quot;.git/\&quot; directory.\&quot; It will, for example, include the \&quot;package.json\&quot; file that can be used to retrieve the project homepage.  See https://docs.npmjs.com/cli/v7/configuring-npm/package-json#homepage.
        /// </summary>
        /// <value>Package contents. This is the zip file uploaded by the user. (Encoded as text using a Base64 encoding).  This will be a zipped version of an npm package&#x27;s GitHub repository, minus the \&quot;.git/\&quot; directory.\&quot; It will, for example, include the \&quot;package.json\&quot; file that can be used to retrieve the project homepage.  See https://docs.npmjs.com/cli/v7/configuring-npm/package-json#homepage.</value>
        [DataMember(Name="Content", EmitDefaultValue=false)]
        public string Content { get; set; }

        /// <summary>
        /// Package URL (for use in public ingest).
        /// </summary>
        /// <value>Package URL (for use in public ingest).</value>
        [DataMember(Name="URL", EmitDefaultValue=false)]
        public string URL { get; set; }

        /// <summary>
        /// A JavaScript program (for use with sensitive modules).
        /// </summary>
        /// <value>A JavaScript program (for use with sensitive modules).</value>
        [DataMember(Name="JSProgram", EmitDefaultValue=false)]
        public string JSProgram { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PackageData {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  URL: ").Append(URL).Append("\n");
            sb.Append("  JSProgram: ").Append(JSProgram).Append("\n");
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
            return this.Equals(input as PackageData);
        }

        /// <summary>
        /// Returns true if PackageData instances are equal
        /// </summary>
        /// <param name="input">Instance of PackageData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PackageData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.URL == input.URL ||
                    (this.URL != null &&
                    this.URL.Equals(input.URL))
                ) && 
                (
                    this.JSProgram == input.JSProgram ||
                    (this.JSProgram != null &&
                    this.JSProgram.Equals(input.JSProgram))
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
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.URL != null)
                    hashCode = hashCode * 59 + this.URL.GetHashCode();
                if (this.JSProgram != null)
                    hashCode = hashCode * 59 + this.JSProgram.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
