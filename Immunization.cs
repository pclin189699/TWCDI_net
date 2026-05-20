using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 免疫接種
    /// Immunizations
    /// 疫苗接種記錄。
    /// Record of vaccine administration.
    /// </summary>
    public class Immunization
    {
        /// <summary>
        /// Immunizations
        /// 施用、計劃或報告的疫苗產品。
        /// Vaccine product administered, planned, or reported.
        /// 詞彙標準：IIS：目前HL7標準碼集
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("immunizations")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Immunizations { get; set; }
    }
}
