using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 臨床紀錄
    /// CLINICAL NOTES
    /// 敘述性患者資料。在許多醫療照護活動中代表患者產生的各種文件。Clinical Notes資料元素與內容交換標準無關。
    /// Narrative patient data relevant to the context identified by note types.
    /// Usage note: Clinical Notes data elements are content exchange standard agnostic.
    /// They should not be interpreted or associated with the structured document templates that may share the same name.
    /// </summary>
    public class ClinicalNote
    {
        /// <summary>
        /// Consultation Note
        /// 臨床醫生向另一位臨床醫生尋求意見、建議。
        /// Narrative summary of care provided in response to a request from a clinician for an opinion, advice, or service.
        /// 詞彙標準：LOINC。(LOINC code 11488-4)
        /// At minimum：Consult Note (LOINC code 11488-4)
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("consultationNote")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ConsultationNote { get; set; }

        /// <summary>
        /// Discharge Summary Note
        /// 病患入院和在醫院或急性後醫療照護機構的病情摘要。必須包含入院和出院日期和地點、出院說明以及住院原因。
        /// Narrative summary of a patient’s admission and course in a hospital or post-acute care setting.
        /// 詞彙標準：LOINC。(LOINC code 18842-5)
        /// At minimum：Discharge Summary (LOINC code 18842-5)
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("dischargeSummaryNote")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DischargeSummaryNote { get; set; }

        /// <summary>
        /// History & Physical
        /// 用於說明醫療照護事件的當前和過去的狀況和觀察結果的摘要。
        /// Narrative summary of current and past conditions and observations used to inform an episode of care.
        /// 詞彙標準：LOINC。(LOINC code 34117-2)
        /// At minimum：History and Physical Note (LOINC code 34117-2)
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("history_physical")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? History_Physical { get; set; }

        /// <summary>
        /// Procedure Note
        /// 非手術處置概要。
        /// Narrative summary of non-operative procedure.
        /// 詞彙標準：LOINC。(LOINC code 28570-0)
        /// At minimum：Procedure Note (LOINC code 28570-0)
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("procedureNote")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ProcedureNote { get; set; }

        /// <summary>
        /// Progress Note
        /// 就診期間患者的間隔時間內狀態摘要。
        /// Narrative summary of a patient’s interval status during an encounter.
        /// 詞彙標準：LOINC。(LOINC code 11506-3)
        /// At minimum：Progress Note (LOINC code 11506-3)
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("progressNote")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ProgressNote { get; set; }
    }
}
