using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 臨床測試
    /// CLINICAL TESTS
    /// 進行非影像和非實驗室測試，得出針對患者的結構化或非結構化結果，以促進病情的診斷和管理。
    /// Non-imaging and non-laboratory tests performed that result in structured or unstructured findings specific to the patient to facilitate the diagnosis and management of conditions.
    /// </summary>
    public class ClinicalTest
    {
        /// <summary>
        /// Clinical Test
        /// 非影像或非實驗室測試。例如但不限於心電圖 (ECG)、視力檢查、黃斑檢查或分級運動測試(GXT)。
        /// Non-imaging or non-laboratory test.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("test")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Test { get; set; }

        /// <summary>
        /// Clinical Test Result/Report
        /// 臨床測試結果。
        /// Findings of clinical tests.
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("result_report")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Result_Report { get; set; }
    }
}
