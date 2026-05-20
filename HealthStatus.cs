using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 健康狀況評估
    /// Health Status Assessments
    /// 對患者、患者家屬或患者的醫療保健提供者感興趣、重要性或擔憂的健康相關問題進行評估，以識別需求、問題或狀況。
    /// Assessments of a health-related matter of interest, importance, or worry to a patient, patient's authorized representative, or patient’s healthcare provider that could identify a need, problem, or condition.
    /// </summary>
    public class HealthStatus
    {
        /// <summary>
        /// Alcohol Use
        /// 評估患者的飲酒情況。 例如但不限於飲酒史、酒精使用障礙識別測試和酒精攝取評估。
        /// Evaluation of a patient's consumption of alcohol.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("alcoholUse")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AlcoholUse { get; set; }

        /// <summary>
        /// Disability Status
        /// 患者身體、認知、智力或精神障礙的評估。
        /// Assessment of a patient’s physical, cognitive, or psychiatric disabilities.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("disabilityStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DisabilityStatus { get; set; }

        /// <summary>
        /// Functional Status
        /// 評估一個人進行日常生活活動以及在其他情況和環境下進行活動的能力。例如但不限於洗澡、走路和準備便餐。
        /// Assessment of a person’s ability to perform activities of daily living and activities across other situations and settings.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("functionalStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FunctionalStatus { get; set; }

        /// <summary>
        /// Health Concerns
        /// 與健康相關的問題或擔憂。例子包括但不限於體重增加和癌症風險。
        /// Health-related issue or worry.
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("healthConcerns")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? HealthConcerns { get; set; }

        /// <summary>
        /// Mental/Cognitive Status
        /// 評估或篩檢是否有精神或行為問題。
        /// Assessment or screening for the presence of a mental or behavioral problem.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("mental_cognitiveStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Mental_CognitiveStatus { get; set; }

        /// <summary>
        /// Physical Activity
        /// 評估患者目前或平時的運動情況。
        /// Evaluation of a patient's current or usual exercise.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(6)]
        [JsonPropertyName("physicalActivity")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PhysicalActivity { get; set; }

        /// <summary>
        /// Pregnancy Status
        /// 懷孕或預計懷孕的狀態或狀況。
        /// State or condition of being pregnant or intent to become pregnant.
        /// </summary>
        [JsonPropertyOrder(7)]
        [JsonPropertyName("pregnancyStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PregnancyStatus { get; set; }

        /// <summary>
        /// SDOH Assessment
        /// 對健康相關風險的社會決定因素進行基於問卷調查的結構化評估。
        /// Screening questionnaire-based, structured evaluation for a Social Determinants of Healthrelated risk.
        /// 例如但不限於食品、住房和交通安全。
        /// 詞彙標準：LOINC / SNOMED CT。
        /// </summary>
        [JsonPropertyOrder(8)]
        [JsonPropertyName("sdohAssessment")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SDOHAssessment { get; set; }

        /// <summary>
        /// Smoking Status
        /// 評估患者的吸菸行為。
        /// Assessment of a patient’s smoking behaviors.
        /// 詞彙標準：SNOMED CT。
        /// </summary>
        [JsonPropertyOrder(9)]
        [JsonPropertyName("smokingStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SmokingStatus { get; set; }

        /// <summary>
        /// Substance Use
        /// 對患者報告的非醫療目的或超出有效處方的藥物或其他物質使用情況的評估。
        /// Evaluation of a patient's reported use of drugs or other substances for non-medical purposes or in excess of a valid prescription.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(10)]
        [JsonPropertyName("substanceUse")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SubstanceUse { get; set; }
    }
}
