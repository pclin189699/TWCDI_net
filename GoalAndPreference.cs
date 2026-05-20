using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 目標及偏好
    /// GOALS AND PREFERENCES
    /// Desired state to be achieved by a person or a person’s elections to guide care.
    /// </summary>
    public class Goal
    {
        /// <summary>
        /// Patient Goals
        /// 患者醫療照護的預期結果。
        /// Desired outcomes of patient’s care.
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("patient")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Patient { get; set; }

        /// <summary>
        /// SDOH Goals
        /// 與健康相關的健康問題、狀況、社會決定因素等。
        /// Desired future state for an identified Social Determinants of Health-related concern, condition, or diagnosis.
        /// 例子包括但不限於糧食安全、交通安全和獲得醫療保健的能力。
        /// 詞彙標準：SNOMED CT / LOINC。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("sdoh")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SDOH { get; set; }
    }

    /// <summary>
    /// 目標及偏好
    /// GOALS AND PREFERENCES
    /// Desired state to be achieved by a person or a person’s elections to guide care.
    /// </summary>
    public class Preference
    {
        /// <summary>
        /// Care Experience Preference
        /// 個人在醫療照護和治療期間整體體驗的目標、偏好和優先事項。
        /// Person's goals, preferences, and priorities for overall experiences during their care and treatment.
        /// 例如但不限於宗教信仰、厭惡和恐懼以及需要分享的想法和感受。
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("careExperience")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CareExperience { get; set; }

        /// <summary>
        /// Treatment Intervention Preference
        /// 個人因嚴重疾病或受傷而無法做出醫療決定時的目標、偏好以及醫療照護和治療的優先順序。
        /// Person's goals, preferences, and priorities for care and treatment in case that person is unable to make medical decisions because of a serious illness or injury.
        /// 例子包括但不限於對心肺復甦術的想法、心理健康治療偏好以及對疼痛管理的想法。
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("treatmentIntervention")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? TreatmentIntervention { get; set; }

        
    }
}
