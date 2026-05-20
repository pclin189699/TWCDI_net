using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 實驗室
    /// Laboratory
    /// 分析臨床標本以獲得有關患者健康的資訊。
    /// Analysis of clinical specimens to obtain information about the health of a patient.
    /// </summary>
    public class Laboratory
    {
        /// <summary>
        /// Result Interpretation
        /// 實驗室值的分類評估，通常與測試的參考範圍相關。例如但不限於高、低、臨界高和正常。
        /// Categorical  assessment  of a laboratory  value, often in relation to a test's reference range.
        /// 詞彙標準：SNOMED CT / HL7 Code System ObservationInterpretation。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("resultInterpretation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ResultInterpretation { get; set; }

        /// <summary>
        /// Result Reference Range
        /// 指定人群預期的定量測試值的上限和下限。參考範圍值可能因患者特徵、實驗室測試製造商和實驗室測試執行者而異。
        /// Upper  and lower  limit of quantitative test values expected  for a designated population of individuals.
        /// 詞彙標準：The Unified Code of Units for Measure(CUCM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("referenceRange")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ReferenceRange { get; set; }

        /// <summary>
        /// Result Status
        /// 實驗室測試的狀態或條件。
        /// State or condition of a laboratory test.
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("resultstatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ResultStatus { get; set; }

        /// <summary>
        /// Result Unit of Measure
        /// 報告定量實驗室測試結果的測量單位。
        /// Unit of measurement to report quantitative values.
        /// 詞彙標準：The Unified Code of Units for Measure(CUCM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("resultUnit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ResultUnit { get; set; }

        /// <summary>
        /// Specimen Condition Acceptability
        /// 有關不符合實驗室可接受標準的樣本(包括容器)的資訊。
        /// Information regarding a specimen, including the container, that does not meet a laboratory's criteria for acceptability.
        /// 例如但不限於溶血、凝結、容器洩漏和病患姓名缺失。
        /// 詞彙標準 SNOMED CT / HL7 Code System SpecimenCondition。
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("specimenAcceptability")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SpecimenAcceptability { get; set; }

        /// <summary>
        /// Specimen Identifier
        /// 實驗室為單一樣本分配的字元序列。
        /// Sequence of characters assigned by a laboratory for an individual specimen.
        /// 範例包括但不限於登錄號。
        /// </summary>
        [JsonPropertyOrder(6)]
        [JsonPropertyName("specimenIdentifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SpecimenIdentifier { get; set; }

        /// <summary>
        /// Specimen Source Site
        /// 樣本取得位置。
        /// Body  location  from where  a specimen  was obtained.
        /// 例如但不限於右頸內靜脈、左臂和右眼。
        /// 詞彙標準：SNOMED CT。
        /// </summary>
        [JsonPropertyOrder(7)]
        [JsonPropertyName("specimenSite")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SpecimenSite { get; set; }

        /// <summary>
        /// SpecimenType
        /// 正在取樣或測試的物質。例如但不限於鼻咽拭子、全血、血清、尿液和傷口拭子。
        /// Substance being sampled or tested.
        /// 詞彙標準：SNOMED CT。
        /// </summary>
        [JsonPropertyOrder(8)]
        [JsonPropertyName("specimenType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SpecimenType { get; set; }

        /// <summary>
        /// Test
        /// 人類樣本的分析，為疾病的診斷、預防、治療或健康評估提供資訊。
        /// Analysis of specimens derived from humans which provide information for the diagnosis, prevention, treatment of disease, or assessment of health.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(9)]
        [JsonPropertyName("test")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Test { get; set; }

        /// <summary>
        /// Values/Results
        /// 記錄測試樣本的結果，包括結構化和非結構化組件。
        /// Documented  findings  of a tested  specimen including structured and unstructured components.
        /// 詞彙標準：SNOMED CT
        /// </summary>
        [JsonPropertyOrder(10)]
        [JsonPropertyName("values_results")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Values_Results { get; set; }
    }
}
