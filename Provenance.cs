using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 出處
    /// Provenance
    /// 元資料或有關資料的額外信息，涉及資料的創建者和創建時間(可包含電子簽章等)。
    /// The metadata, or extra information about data, regarding who created the data and when it was created.
    /// </summary>
    public class Provenance
    {
        /// <summary>
        /// Author Organization
        /// 與作者相關的組織。
        /// Organization associated with author.
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("authorOrganization")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AuthorOrganization { get; set; }
        /// <summary>
        /// Author Time Stamp
        /// 資料的創建者和創建時間
        /// Date and time of author action.
        /// 作者採取行動的日期和時間。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("authorTimeStamp")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AuthorTimeStamp { get; set; }

        
    }
}
