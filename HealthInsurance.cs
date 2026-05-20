using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 健康保險資訊
    /// HEALTH INSURANCE INFORMATION
    /// 與個人醫療保險範圍相關的數據。
    /// Data related to an individual’s insurance coverage for healthcare.
    /// </summary>
    public class HealthInsurance
    {
        /// <summary>
        /// Coverage Status
        /// 是否有醫療保險。
        /// Presence or absence of healthcare insurance.
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("coverageStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CoverageStatus { get; set; }

        /// <summary>
        /// Coverage Type
        /// 醫療保健支付者、保險產品或福利的類別。
        /// Category of healthcare payers, insurance products, or benefits.
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("coverageType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CoverageType { get; set; }

        /// <summary>
        /// Group Identifier
        /// 提供者和醫療保險公司需要支援和交換共享患者/會員的通用標識符，以確保識別唯一的個人，並交換適當的信息，並由醫療保險公司提供適當的醫療照護和支付費用。
        /// Sequence of characters used to uniquely refer to a specific health insurance plan.
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("groupIdentifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? GroupIdentifier { get; set; }

        /// <summary>
        /// Member Identifier
        /// 提供者和醫療保險公司需要支援和交換共享患者/會員的通用標識符，以確保識別唯一的個人，並交換適當的信息，並由醫療保險公司提供適當的醫療照護和支付費用。
        /// Sequence of characters used to uniquely refer to an individual with respect to their insurance.
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("memberIdentifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? MemberIdentifier { get; set; }

        /// <summary>
        /// Payer Identifier
        /// 保險機構(支付費用方)識別
        /// 提供者和醫療保險公司需要支援和交換共享患者/會員的通用標識符，以確保識別唯一的個人，並交換適當的信息，並由醫療保險公司提供適當的醫療照護和支付費用。
        /// Sequence of characters used to uniquely refer to an insurance payer.
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("payerIdentifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PayerIdentifier { get; set; }

        /// <summary>
        /// Relationship to Subscriber
        /// 患者與主要被保險人的關係。
        /// Relationship to Subscriber
        /// Relationship of a patient to the primary insured person.
        /// </summary>
        [JsonPropertyOrder(6)]
        [JsonPropertyName("relationship")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Relationship { get; set; }

        /// <summary>
        /// Subscriber Identifier
        /// 提供者和醫療保險公司需要支援和交換共享患者/會員的通用標識符，以確保識別唯一的個人，並交換適當的信息，並由醫療保險公司提供適當的醫療照護和支付費用。
        /// Sequence of characters used to uniquely refer to the individual that selects insurance benefits.
        /// </summary>
        [JsonPropertyOrder(7)]
        [JsonPropertyName("subscriberIdentifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubscriberIdentifier { get; set; }

    }
}
