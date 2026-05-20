using System.Text.Json.Serialization;

namespace TWCDI_net
{
    /// <summary>
    /// 藥物
    /// Medications
    /// 用於診斷、治癒、緩解、治療或預防疾病的藥物。
    /// Pharmacologic agents used in the diagnosis, cure, mitigation, treatment, or prevention of disease.
    /// </summary>
    public class Medication
    {
        /// <summary>
        /// Dose Unit of Measure
        /// 藥物的計量單位。例如但不限於毫克(mg)和毫升(mL)。
        /// Units of measure of a medication.
        /// 詞彙標準：The Unified Code for Units of Measure(UCUM), Revision 2.1。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("unit")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Dose_Unit_Measure { get; set; }

        /// <summary>
        /// Dose
        /// 每次給藥的藥物量。
        /// Amount of a medication for each administration.
        /// </summary>
        [JsonPropertyOrder(2)]
        [JsonPropertyName("dose")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Dose { get; set; }

        /// <summary>
        /// Fill Status
        /// 與配藥或其他活動有關的藥物狀態。
        /// State of a medication with regards to dispensing or other activity.
        /// 例如但不限於分配、部分分配和未分配。
        /// </summary>
        [JsonPropertyOrder(3)]
        [JsonPropertyName("fillStatus")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? FillStatus { get; set; }

        /// <summary>
        /// Indication
        /// 導致給予或服用藥物的徵兆、症狀或醫療狀況。
        /// Sign, symptom, or medical condition that is the reason for giving or taking a medication.
        /// 詞彙標準：SNOMED CT / ICD-10-CM。
        /// </summary>
        [JsonPropertyOrder(4)]
        [JsonPropertyName("indication")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Indication { get; set; }

        /// <summary>
        /// Medication Adherence
        /// 是否按照說明服用藥物的聲明。
        /// Statement of whether a medication has been consumed according to instructions.
        /// 例如但不限於依指示服用、低於指示服用和不服用。
        /// 詞彙標準：SNOMED CT。
        /// </summary>
        [JsonPropertyOrder(5)]
        [JsonPropertyName("adherence")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Adherence { get; set; }

        /// <summary>
        /// Medication Instructions
        /// 給藥或服用藥物的說明。
        /// Directions for administering or taking a medication.
        /// Usage note: May include route, quantity, timing/frequency, and special instructions (PRN, sliding scale, taper).
        /// 例如但不限於服用藥物的處方說明以及非處方藥的包裝說明。
        /// </summary>
        [JsonPropertyOrder(6)]
        [JsonPropertyName("instructions")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Instructions { get; set; }

        /// <summary>
        /// Medications
        /// 用於診斷、治癒、緩解、治療或預防疾病的藥劑。
        /// Pharmacologic agent used in the diagnosis, cure, mitigation, treatment, or prevention of disease.
        /// 詞彙標準：RxNorm / NDC(選用)。
        /// </summary>
        [JsonPropertyOrder(1)]
        [JsonPropertyName("medications")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string? Medications { get; set; }
    }
}
