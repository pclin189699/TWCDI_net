using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 生命徵象
    /// Vital Signs
    /// 患者的生理測量，顯示身體維持生命功能的狀態。
    /// Physiologic measurements of a patient that indicate the status of the body’s life sustaining functions.
    /// </summary>
    public class VitalSign
    {
        /// <summary>
        /// Average Blood Pressure
        /// 在指定時間段內或根據指定演算法或方案，對兩個或多個血壓讀數的收縮壓和舒張壓分量進行算術平均。
        /// Arithmetic average of systolic and diastolic components of two of more blood pressure readings in a specified time period or according to a specified algorithm or protocol.
        /// 例如但不限於3天早晚家庭監測、臨床病例重複平均值以及24小時動態測量。
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("averageBlood")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? AverageBlood { get; set; }

        /// <summary>
        /// BMI Percentile (2 - 20 years) 
        /// 身體質量指數 - 2-20歲,兒童及青少年身體質量指數
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("bmiPercentile")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BMIPercentile { get; set; }

        /// <summary>
        /// Body Height
        /// 身高
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("bodyHeight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BodyHeight { get; set; }

        /// <summary>
        /// Body Temperature
        /// 體溫
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("bodyTemperature")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BodyTemperature { get; set; }

        /// <summary>
        /// Body Weight
        /// 體重
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("bodyWeight")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? BodyWeight { get; set; }

        /// <summary>
        /// Diastolic Blood Pressure
        /// 舒張壓。
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(6)]
        [JsonPropertyName("diastolicBlood")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? DiastolicBlood { get; set; }

        /// <summary>
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(7)]
        [JsonPropertyName("ecg")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? ECG { get; set; }

        /// <summary>
        /// Head Occipital-frontal Circumference Percentile (Birth - 36 Months)
        /// 頭枕額葉週長百分位數 - 兒童頭圍百分位數
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(8)]
        [JsonPropertyName("headCircumference")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? HeadCircumference { get; set; }

        /// <summary>
        /// Heart Rate
        /// 心率
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(9)]
        [JsonPropertyName("heartRate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? HeartRate { get; set; }

        /// <summary>
        /// Inhaled Oxygen Concentration
        /// 吸入氧氣濃度
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(10)]
        [JsonPropertyName("inhaledOxygen")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? InhaledOxygen { get; set; }

        /// <summary>
        /// Pulse Oximetry
        /// 脈衝式血氧濃度
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(11)]
        [JsonPropertyName("pulseOximetry")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? PulseOximetry { get; set; }

        /// <summary>
        /// Respiratory Rate
        /// 呼吸頻率。
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(12)]
        [JsonPropertyName("respiratoryRate")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? RespiratoryRate { get; set; }

        /// <summary>
        /// Systolic Blood Pressure
        /// 收縮壓。
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(13)]
        [JsonPropertyName("systolicBlood")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? SystolicBlood { get; set; }

        /// <summary>
        /// Weight-for-length Percentile (Birth - 24 Months)
        /// 體重身長百分位數 - 兒童生長曲線
        /// 詞彙標準：LOINC、The Unified Code of Units for Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(14)]
        [JsonPropertyName("weight_for_length")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Weight_For_Length { get; set; }
    }
}
