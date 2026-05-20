using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 患者 人口統計/資訊
    /// Patient Demographics/Information
    /// 用於對個人進行分類用以識別、記錄匹配和其他目的的資料。
    /// Data used to categorize individuals for identification, records matching, and other purposes.
    /// </summary>
    public class Patient
    {
        /// <summary>
        /// Current Address
        /// 台灣中華郵政郵遞區號
        /// Place where a person is located or may be contacted.
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("currentAddress")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? CurrentAddress { get; set; }

        /// <summary>
        /// Date of Birth
        /// 生日
        /// Known or estimated year, month, and day of the patient's birth.
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("dateOfBirth")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DateOfBirth { get; set; }

        /// <summary>
        /// Date of Death
        /// 死亡日期
        /// 是否過世
        /// Known or estimated year, month, and day of the patient's death.
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("dateOfDeath")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DateOfDeath { get; set; }

        /// <summary>
        /// Email Address
        /// 電子郵件
        /// Unique identifier of an individual's email account that is used to send and receive email messages.
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("emailAddress")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? EmailAddress { get; set; }

        /// <summary>
        /// First Name
        /// 護照英文名
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("firstName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FirstName { get; set; }

        /// <summary>
        /// IdCardNumber
        /// 身分證字號
        /// </summary>
        [JsonPropertyOrder(6)]
        [JsonPropertyName("idCardNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? IdCardNumber { get; set; }

        /// <summary>
        /// Last Name
        /// 護照英文姓
        /// </summary>
        [JsonPropertyOrder(7)]
        [JsonPropertyName("lastName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? LastName { get; set; }

        /// <summary>
        /// Name
        /// 中文名
        /// </summary>
        [JsonPropertyOrder(8)]
        [JsonPropertyName("name")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Name { get; set; }

        /// <summary>
        /// Occupation
        /// 職業
        /// Type of work of a person
        /// 個人工作類型。
        /// 例如但不限於軍人、商業分析師和社會工作者。
        /// </summary>
        [JsonPropertyOrder(9)]
        [JsonPropertyName("occupation")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Occupation { get; set; }

        /// <summary>
        /// Occupation Industry
        /// 職業別
        /// Type of business that compensates for work or assigns work to an unpaid worker or volunteer.
        /// 例如但不限於陸軍、水泥製造以及兒童和青少年服務。
        /// </summary>
        [JsonPropertyOrder(10)]
        [JsonPropertyName("occupationIndustry")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? OccupationIndustry { get; set; }

        /// <summary>
        /// Phone Number
        /// 電話號碼
        /// Numbers and symbols to contact an individual when using a phone.
        /// 詞彙標準：ITU-T E.123, Series E / ITU-T E.164, Series E
        /// </summary>
        [JsonPropertyOrder(11)]
        [JsonPropertyName("phoneNumber")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// Phone Number Type
        /// 電話類別
        /// Contact point when using a phone.
        /// 例如但不限於家庭、工作和行動電話。
        /// </summary>
        [JsonPropertyOrder(12)]
        [JsonPropertyName("phoneNumberType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PhoneNumberType { get; set; }

        /// <summary>
        /// Previous Address
        /// 過去住地
        /// Prior place where a person may have been located or could have been contacted.
        /// </summary>
        [JsonPropertyOrder(13)]
        [JsonPropertyName("previousAddress")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PreviousAddress { get; set; }

        /// <summary>
        /// Previous Name
        /// Patient.name.use/office
        /// </summary>
        [JsonPropertyOrder(14)]
        [JsonPropertyName("previousName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PreviousName { get; set; }

        /// <summary>
        /// Race
        /// 內政部戶政司
        /// 原意:指人種，但在台灣的戶政司定義為「族群」，包含原住民、外籍配偶、外籍移工
        /// </summary>
        [JsonPropertyOrder(15)]
        [JsonPropertyName("race")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Race { get; set; }

        /// <summary>
        /// Related Person's Name
        /// 關係人姓名
        /// Name of a person with a legal or familial relationship to a patient.
        /// </summary>
        [JsonPropertyOrder(16)]
        [JsonPropertyName("relatedName")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RelatedName { get; set; }

        /// <summary>
        /// Relationship Type
        /// 與病人的關係。
        /// Relationship of a person to a patient.
        /// 例如但不限於父母、近親、監護人和監護人。
        /// </summary>
        [JsonPropertyOrder(17)]
        [JsonPropertyName("relationshipType")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RelationshipType { get; set; }

        /// <summary>
        /// 性別
        /// Sex
        /// 詞彙標準：SNOMED CT
        /// </summary>
        [JsonPropertyOrder(18)]
        [JsonPropertyName("sex")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Sex { get; set; }        
    }
}
