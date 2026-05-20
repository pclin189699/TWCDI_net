using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 設施資訊
    /// FACILITY INFORMATION
    /// 可用服務或資源的實體位置。
    /// Physical place of available services or resources.
    /// </summary>
    public class Facility
    {
        /// <summary>
        /// Facility Identifier
        /// 表示可用服務或資源的實體位置。
        /// Sequence of characters representing a physical place of available services or resources.
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("identifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Identifier { get; set; }

        /// <summary>
        /// Facility Name
        /// 設施廣為人知的一個或多個字詞。
        /// Word or words by which a facility is known.
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        /// <summary>
        /// Facility Type
        /// 某個位置可用的服務或資源的類別。
        /// Category of service or resource available in a location.
        /// 例如但不限於醫院、實驗室、藥房、門診診所、長期和急性期後醫療照護機構以及食品儲藏室。
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("type")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Type { get; set; }
    }
}
