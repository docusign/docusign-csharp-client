/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * Contact: devcenter@docusign.com
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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Defines a billing plan update response object.
    /// </summary>
    [DataContract]
    public partial class BillingPlanUpdateResponse :  IEquatable<BillingPlanUpdateResponse>, IValidatableObject
    {
        public BillingPlanUpdateResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlanUpdateResponse" /> class.
        /// </summary>
        /// <param name="AccountPaymentMethod">.</param>
        /// <param name="BillingPlanPreview">BillingPlanPreview.</param>
        /// <param name="CurrencyCode">Specifies the ISO currency code for the account..</param>
        /// <param name="IncludedSeats">The number of seats (users) included..</param>
        /// <param name="PaymentCycle">.</param>
        /// <param name="PaymentMethod">.</param>
        /// <param name="PlanId">.</param>
        /// <param name="PlanName">.</param>
        public BillingPlanUpdateResponse(string AccountPaymentMethod = default(string), BillingPlanPreview BillingPlanPreview = default(BillingPlanPreview), string CurrencyCode = default(string), string IncludedSeats = default(string), string PaymentCycle = default(string), string PaymentMethod = default(string), string PlanId = default(string), string PlanName = default(string))
        {
            this.AccountPaymentMethod = AccountPaymentMethod;
            this.BillingPlanPreview = BillingPlanPreview;
            this.CurrencyCode = CurrencyCode;
            this.IncludedSeats = IncludedSeats;
            this.PaymentCycle = PaymentCycle;
            this.PaymentMethod = PaymentMethod;
            this.PlanId = PlanId;
            this.PlanName = PlanName;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="accountPaymentMethod", EmitDefaultValue=false)]
        public string AccountPaymentMethod { get; set; }
        /// <summary>
        /// Gets or Sets BillingPlanPreview
        /// </summary>
        [DataMember(Name="billingPlanPreview", EmitDefaultValue=false)]
        public BillingPlanPreview BillingPlanPreview { get; set; }
        /// <summary>
        /// Specifies the ISO currency code for the account.
        /// </summary>
        /// <value>Specifies the ISO currency code for the account.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// The number of seats (users) included.
        /// </summary>
        /// <value>The number of seats (users) included.</value>
        [DataMember(Name="includedSeats", EmitDefaultValue=false)]
        public string IncludedSeats { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="paymentCycle", EmitDefaultValue=false)]
        public string PaymentCycle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="planId", EmitDefaultValue=false)]
        public string PlanId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="planName", EmitDefaultValue=false)]
        public string PlanName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPlanUpdateResponse {\n");
            sb.Append("  AccountPaymentMethod: ").Append(AccountPaymentMethod).Append("\n");
            sb.Append("  BillingPlanPreview: ").Append(BillingPlanPreview).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  IncludedSeats: ").Append(IncludedSeats).Append("\n");
            sb.Append("  PaymentCycle: ").Append(PaymentCycle).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PlanName: ").Append(PlanName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as BillingPlanUpdateResponse);
        }

        /// <summary>
        /// Returns true if BillingPlanUpdateResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPlanUpdateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPlanUpdateResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountPaymentMethod == other.AccountPaymentMethod ||
                    this.AccountPaymentMethod != null &&
                    this.AccountPaymentMethod.Equals(other.AccountPaymentMethod)
                ) && 
                (
                    this.BillingPlanPreview == other.BillingPlanPreview ||
                    this.BillingPlanPreview != null &&
                    this.BillingPlanPreview.Equals(other.BillingPlanPreview)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.IncludedSeats == other.IncludedSeats ||
                    this.IncludedSeats != null &&
                    this.IncludedSeats.Equals(other.IncludedSeats)
                ) && 
                (
                    this.PaymentCycle == other.PaymentCycle ||
                    this.PaymentCycle != null &&
                    this.PaymentCycle.Equals(other.PaymentCycle)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
                ) && 
                (
                    this.PlanId == other.PlanId ||
                    this.PlanId != null &&
                    this.PlanId.Equals(other.PlanId)
                ) && 
                (
                    this.PlanName == other.PlanName ||
                    this.PlanName != null &&
                    this.PlanName.Equals(other.PlanName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AccountPaymentMethod != null)
                    hash = hash * 59 + this.AccountPaymentMethod.GetHashCode();
                if (this.BillingPlanPreview != null)
                    hash = hash * 59 + this.BillingPlanPreview.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.IncludedSeats != null)
                    hash = hash * 59 + this.IncludedSeats.GetHashCode();
                if (this.PaymentCycle != null)
                    hash = hash * 59 + this.PaymentCycle.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                if (this.PlanId != null)
                    hash = hash * 59 + this.PlanId.GetHashCode();
                if (this.PlanName != null)
                    hash = hash * 59 + this.PlanName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
