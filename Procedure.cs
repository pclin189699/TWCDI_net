using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 處置
    /// Procedures
    /// 作為提供醫療照護的一部分，為患者或在患者身上進行的活動。
    /// Activity performed for or on a patient as part of the provision of care.
    /// </summary>
    public class Procedure
    {
        /// <summary>
        /// Performance Time
        /// 執行處置的時間和/或日期。
        /// Time and/or date a procedure is performed.
        /// 例如但不限於疫苗或藥物給藥時間、手術開始時間和超音波檢查時間。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("performanceTime")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PerformanceTime { get; set; }

        /// <summary>
        /// Procedures
        /// 病情、診斷或就醫的原因。
        /// Activity performed for or on a patient as part of the provision of care.
        /// 詞彙標準：SNOMED CT / ICD-10-PCS (2023)。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("Procedures")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Procedures { get; set; }

        /// <summary>
        /// Reason for Referral
        /// 轉介或諮詢的解釋或理由。
        /// Explanation or justification for a referral or consultation.
        /// 詞彙標準：SNOMED CT / ICD-10-CM (2023)。
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("reasonforReferral")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReasonforReferral { get; set; }

        /// <summary>
        /// SDOH Interventions
        /// 解決已確定的與健康相關的健康問題、狀況或診斷的社會決定因素的行動或服務。
        /// Actions or services to address an identified Social Determinants of Health-related concern, condition, or diagnosis.
        /// 例子包括但不限於有關食品儲藏室計劃的教育和轉介至非緊急醫療運輸計劃。
        /// 詞彙標準：SNOMED CT。
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("sdohInterventions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SDOHInterventions { get; set; }
    }
}
