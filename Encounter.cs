using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 就診資訊
    /// ENCOUNTER INFORMATION
    /// 醫療保健提供者和患者之間的互動相關的資訊。
    /// Information related to interactions between healthcare providers and patients.
    /// </summary>
    public class Encounter
    {
        /// <summary>
        /// Encounter Diagnosis
        /// 與醫療照護事件相關的診斷編碼。
        /// Coded diagnoses associated with an episode of care.
        /// 詞彙標準：SNOMED CT / ICD-10-CM(2023)。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("diagnosis")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Diagnosis { get; set; }

        /// <summary>
        /// Encounter Disposition
        /// 患者離開醫院或就診的地點或環境。
        /// Place or setting where the patient went after a hospital stay or encounter.
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("disposition")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Disposition { get; set; }

        /// <summary>
        /// Encounter Identifier
        /// 就醫事件識別碼
        /// Sequence of characters by which an encounter is known.
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("identifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Identifier { get; set; }

        /// <summary>
        /// Encounter Location
        /// 提供患者照護的地方。
        /// Place where a patient’s care is delivered.
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("location")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Location { get; set; }

        /// <summary>
        /// Encounter Time
        /// 就診相關的日期/時間。例如但不限於預定的預約時間、入住時間、開始和停止時間。
        /// Date/times related to an encounter.
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("time")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Time { get; set; }

        /// <summary>
        /// Encounter Type
        /// 醫療保健服務類別。
        /// Category of healthcare service.
        /// 例如但不限於辦公室訪問、電話評估和家訪。
        /// </summary>
        [JsonPropertyOrder(6)]
        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
    }
}
