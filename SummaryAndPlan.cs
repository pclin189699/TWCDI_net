using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 患者 摘要/計畫
    /// Patient Summary and Plan
    /// 患者治療的結論以及未來治療的建議。
    /// Conclusions and working assumptions that will guide treatment of the patient, and recommendations for future treatment.
    /// </summary>
    public class SummaryAndPlan
    {
        /// <summary>
        /// Assessment and Plan of Treatment
        /// 衛生專業人員對於患者進行的評估及治療計畫
        /// Health professional's conclusions and working assumptions that will guide treatment of the patient.
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("assess_and_plan")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Assess_And_Plan { get; set; }
    }
}
