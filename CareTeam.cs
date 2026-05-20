using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 醫療照護團隊成員
    /// CARE TEAM MEMBERS
    /// 有關參與或預計參與患者醫療照護的人員的資訊。
    /// Information about a person who participates or is expected to participate in the care of a patient.
    /// </summary>
    public class CareTeam
    {
        /// <summary>
        /// Care Team Member Identifier
        /// 用於唯一對應醫療照護團隊成員的字元序列。
        /// Sequence of characters used to uniquely refer to a member of the care team.
        /// 例如但不限於醫事人員卡號或醫院員工識別證碼。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("identifier")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Identifier { get; set; }

        /// <summary>
        /// Care Team Member Location
        /// 由醫療照護團隊成員提供醫療照護的地方。
        /// Place where care is delivered by a care team member.
        /// 例如但不限於診所地址和位置描述。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("location")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Location { get; set; }

        /// <summary>
        /// Care Team Member Name
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        /// <summary>
        /// Care Team Member Organization
        /// 護理團隊成員所屬或來自於的醫療機構
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("organization")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Organization { get; set; }

        /// <summary>
        /// Care Team Member Role
        /// 說明醫療照護團隊中每個人的角色與責任。
        /// Responsibility of an individual within the care team.
        /// 例如但不限於醫生、醫療照護人員。
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("role")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Role { get; set; }

        /// <summary>
        /// Care Team Member Telecom
        /// 醫療照護團隊成員的電話或電子郵件聯絡資訊。
        /// Phone or email contact information for a care team member.
        /// </summary>
        [JsonPropertyOrder(6)]
        [JsonPropertyName("telecom")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Telecom { get; set; }
    }
}
