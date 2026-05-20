using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 診斷影像
    /// DIAGNOSTIC IMAGING
    /// 產生需要由具備資格的專業人士解讀之醫學影像。
    /// Tests that result in visual images requiring interpretation by a credentialed professional.
    /// </summary>
    public class DiagnosticImaging
    {
        /// <summary>
        /// Clinical Test Result/Report
        /// 影像學檢查結果的解釋。包括結構化和非結構化(敘事)組件。
        /// Interpreted results of imaging tests.
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("report")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Report { get; set; }

        /// <summary>
        /// Clinical Test Result/Report
        /// 產生醫學影像並需要合格專業人員進行解讀的測試。
        /// Tests that generate visual images and require interpretation by qualified professionals.
        /// 詞彙標準：LOINC。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("test")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Test { get; set; }

        
    }
}
