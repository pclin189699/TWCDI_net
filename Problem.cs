using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 問題
    /// Problems
    /// 病情、診斷或就醫的原因。
    /// Condition, diagnosis, or reason for seeking medical attention.
    /// </summary>
    public class Problem
    {
        /// <summary>
        /// Problems
        /// 病情、診斷或就醫的原因。
        /// Condition, diagnosis, or reason for seeking medical attention.
        /// 詞彙標準：SNOMED CT / ICD-10-CM (2023)。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("problems")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Problems { get; set; }

        /// <summary>
        /// SDOH Problems/Health Concerns
        /// 與健康相關的健康問題、狀況或診斷的社會決定因素。
        /// Social Determinants of Health-related concerns, conditions, or diagnoses.
        /// 例如但不限於無家可歸和糧食不安全。
        /// 詞彙標準：SNOMED CT / ICD-10-CM (2023)。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("sdoh_or_healthConcern")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SDOH_Or_HealthConcern { get; set; }

        /// <summary>
        /// Date of Diagnosis
        /// 了解患者患某種疾病的時間也可以支持臨床醫生和人群健康管理人員預測併發和/或疾病進展的發生時間/速率。
        /// Date of first determination by a qualified professional of the presence of a problem or condition affecting a patient.
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("dateOfDiagnosis")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DateOfDiagnosis { get; set; }

        /// <summary>
        /// Date of Resolution
        /// 症狀、問題或狀況消退或終止的日期。
        /// Date of subsiding or termination of a symptom, problem, or condition.
        /// 允許記錄先前活躍問題得到解決的日期，無論該問題是否存在將作為顯示在既往病史的一部分進行維護。
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("dateOfResolution")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DateOfResolution { get; set; }
    }
}
