using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 過敏及不耐受
    /// ALLERGIES AND INTOLERANCES
    /// 與接觸某種物質相關的有害或不良的生理反應。
    /// Harmful or undesired physiological responses associated with exposure to a substance.
    /// </summary>
    public class Allergy
    {
        /// <summary>
        /// Reaction
        /// 接觸後會引起有害或不良生理反應的物質的藥理學類別。
        /// Harmful or undesired physiologic response following exposure to a pharmacologic agent or class of agents.
        /// 詞彙標準：SNOMED CT
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("reaction")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Reaction { get; set; }

        /// <summary>
        /// Drug Class Allergy Intolerance
        /// 接觸後會引起有害或不良生理反應的物質的藥理學類別。
        /// Pharmacologic category for an agent believed to cause a harmful or undesired physiologic response following exposure.
        /// 詞彙標準：SNOMED CT
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("drug")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Drug { get; set; }

        /// <summary>
        /// Medication Allergy Intolerance
        /// 接觸後會引起有害或不良生理反應的藥物。
        /// Pharmacologic agent believed to cause a harmful or undesired physiologic response following exposure.
        /// 詞彙標準：RxNorm
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("medication")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]

        public string? Medication { get; set; }

        /// <summary>
        /// Non-Medication Allergy Intolerance
        /// 接觸後會引起有害或不良生理反應的物質的藥理學類別。
        /// Non-pharmacologic agent believed to cause a harmful or undesired physiologic response following exposure.
        /// 詞彙標準：SNOMED CT
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("non-Medication")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Non_Medication { get; set; }
    }
}
