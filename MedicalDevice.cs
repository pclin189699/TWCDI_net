using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 醫療器材
    /// Medical Devices
    /// 用於醫療目的的儀器、機器、器具、植入物、軟體或其他物品。
    /// An instrument,  machine,  appliance,  implant,  software,  or other  article  intended  to be used  for a medical purpose.
    /// </summary>
    public class MedicalDevice
    {
        /// <summary>
        /// Unique Device Identifier - Implantable
        /// 唯一標識植入式裝置的數字或字母數字代碼。
        /// 包含一個裝置識別碼(DI)和一個或多個生產識別碼 (PI)。
        /// Numeric or alphanumeric code that uniquely identifies an implantable device.
        /// 詞彙標準：FDA 唯一裝置辨識系統(UDI系統)。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("identifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Identifier { get; set; }
    }
}
