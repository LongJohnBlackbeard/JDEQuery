using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R3038 - .
/// </summary>
public class F74R3038 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIKCO.
        /// </summary>
        public const string AIKCO = "AIKCO";

        /// <summary>
        /// AIDCT.
        /// </summary>
        public const string AIDCT = "AIDCT";

        /// <summary>
        /// AIDOC.
        /// </summary>
        public const string AIDOC = "AIDOC";

        /// <summary>
        /// AIR74ADNU.
        /// </summary>
        public const string AIR74ADNU = "AIR74ADNU";

        /// <summary>
        /// AIR74ADDT.
        /// </summary>
        public const string AIR74ADDT = "AIR74ADDT";

        /// <summary>
        /// AINHRN.
        /// </summary>
        public const string AINHRN = "AINHRN";

        /// <summary>
        /// AIR74LMN.
        /// </summary>
        public const string AIR74LMN = "AIR74LMN";

        /// <summary>
        /// AIR74ADDS.
        /// </summary>
        public const string AIR74ADDS = "AIR74ADDS";

        /// <summary>
        /// AIR74CTYS.
        /// </summary>
        public const string AIR74CTYS = "AIR74CTYS";

        /// <summary>
        /// AIR74ADL1S.
        /// </summary>
        public const string AIR74ADL1S = "AIR74ADL1S";

        /// <summary>
        /// AIR74ADL2S.
        /// </summary>
        public const string AIR74ADL2S = "AIR74ADL2S";

        /// <summary>
        /// AIR74ARS.
        /// </summary>
        public const string AIR74ARS = "AIR74ARS";

        /// <summary>
        /// AIR74PHS.
        /// </summary>
        public const string AIR74PHS = "AIR74PHS";

        /// <summary>
        /// AIR74TAXS.
        /// </summary>
        public const string AIR74TAXS = "AIR74TAXS";

        /// <summary>
        /// AIR74MCU.
        /// </summary>
        public const string AIR74MCU = "AIR74MCU";

        /// <summary>
        /// AIR74DESC.
        /// </summary>
        public const string AIR74DESC = "AIR74DESC";

        /// <summary>
        /// AIR74ADDI.
        /// </summary>
        public const string AIR74ADDI = "AIR74ADDI";

        /// <summary>
        /// AIR74CITYI.
        /// </summary>
        public const string AIR74CITYI = "AIR74CITYI";

        /// <summary>
        /// AIR74ADS1.
        /// </summary>
        public const string AIR74ADS1 = "AIR74ADS1";

        /// <summary>
        /// AIR74ADS2.
        /// </summary>
        public const string AIR74ADS2 = "AIR74ADS2";

        /// <summary>
        /// AISHAN.
        /// </summary>
        public const string AISHAN = "AISHAN";

        /// <summary>
        /// AIR74ADDO.
        /// </summary>
        public const string AIR74ADDO = "AIR74ADDO";

        /// <summary>
        /// AIR74CTYC.
        /// </summary>
        public const string AIR74CTYC = "AIR74CTYC";

        /// <summary>
        /// AIR74ADL1O.
        /// </summary>
        public const string AIR74ADL1O = "AIR74ADL1O";

        /// <summary>
        /// AIR74ADL2O.
        /// </summary>
        public const string AIR74ADL2O = "AIR74ADL2O";

        /// <summary>
        /// AIR74ARO.
        /// </summary>
        public const string AIR74ARO = "AIR74ARO";

        /// <summary>
        /// AIR74PHO.
        /// </summary>
        public const string AIR74PHO = "AIR74PHO";

        /// <summary>
        /// AIAN8.
        /// </summary>
        public const string AIAN8 = "AIAN8";

        /// <summary>
        /// AIR74LMC.
        /// </summary>
        public const string AIR74LMC = "AIR74LMC";

        /// <summary>
        /// AIR74ADDU.
        /// </summary>
        public const string AIR74ADDU = "AIR74ADDU";

        /// <summary>
        /// AIR74CTYU.
        /// </summary>
        public const string AIR74CTYU = "AIR74CTYU";

        /// <summary>
        /// AIR74ADL1U.
        /// </summary>
        public const string AIR74ADL1U = "AIR74ADL1U";

        /// <summary>
        /// AIR74ADL2U.
        /// </summary>
        public const string AIR74ADL2U = "AIR74ADL2U";

        /// <summary>
        /// AIR74ARC.
        /// </summary>
        public const string AIR74ARC = "AIR74ARC";

        /// <summary>
        /// AIR74PHC.
        /// </summary>
        public const string AIR74PHC = "AIR74PHC";

        /// <summary>
        /// AIR74TAXC.
        /// </summary>
        public const string AIR74TAXC = "AIR74TAXC";

        /// <summary>
        /// AIURRF.
        /// </summary>
        public const string AIURRF = "AIURRF";

        /// <summary>
        /// AIURDT.
        /// </summary>
        public const string AIURDT = "AIURDT";

        /// <summary>
        /// AIURC1.
        /// </summary>
        public const string AIURC1 = "AIURC1";

        /// <summary>
        /// AIURAT.
        /// </summary>
        public const string AIURAT = "AIURAT";

        /// <summary>
        /// AIURAB.
        /// </summary>
        public const string AIURAB = "AIURAB";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AIUPMT.
        /// </summary>
        public const string AIUPMT = "AIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R3038";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIKCO", "AIKCO", JdeDataType.String, 10, true, true),
        new JdeField("AIDCT", "AIDCT", JdeDataType.String, 4, true, true),
        new JdeField("AIDOC", "AIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AIR74ADNU", "AIR74ADNU", JdeDataType.String, 50),
        new JdeField("AIR74ADDT", "AIR74ADDT", JdeDataType.Numeric),
        new JdeField("AINHRN", "AINHRN", JdeDataType.Numeric),
        new JdeField("AIR74LMN", "AIR74LMN", JdeDataType.String, 200),
        new JdeField("AIR74ADDS", "AIR74ADDS", JdeDataType.String, 24),
        new JdeField("AIR74CTYS", "AIR74CTYS", JdeDataType.String, 50),
        new JdeField("AIR74ADL1S", "AIR74ADL1S", JdeDataType.String, 200),
        new JdeField("AIR74ADL2S", "AIR74ADL2S", JdeDataType.String, 200),
        new JdeField("AIR74ARS", "AIR74ARS", JdeDataType.String, 12),
        new JdeField("AIR74PHS", "AIR74PHS", JdeDataType.String, 40),
        new JdeField("AIR74TAXS", "AIR74TAXS", JdeDataType.String, 40),
        new JdeField("AIR74MCU", "AIR74MCU", JdeDataType.String, 24),
        new JdeField("AIR74DESC", "AIR74DESC", JdeDataType.String, 60),
        new JdeField("AIR74ADDI", "AIR74ADDI", JdeDataType.String, 24),
        new JdeField("AIR74CITYI", "AIR74CITYI", JdeDataType.String, 50),
        new JdeField("AIR74ADS1", "AIR74ADS1", JdeDataType.String, 80),
        new JdeField("AIR74ADS2", "AIR74ADS2", JdeDataType.String, 80),
        new JdeField("AISHAN", "AISHAN", JdeDataType.Numeric),
        new JdeField("AIR74ADDO", "AIR74ADDO", JdeDataType.String, 24),
        new JdeField("AIR74CTYC", "AIR74CTYC", JdeDataType.String, 50),
        new JdeField("AIR74ADL1O", "AIR74ADL1O", JdeDataType.String, 200),
        new JdeField("AIR74ADL2O", "AIR74ADL2O", JdeDataType.String, 200),
        new JdeField("AIR74ARO", "AIR74ARO", JdeDataType.String, 12),
        new JdeField("AIR74PHO", "AIR74PHO", JdeDataType.String, 40),
        new JdeField("AIAN8", "AIAN8", JdeDataType.Numeric),
        new JdeField("AIR74LMC", "AIR74LMC", JdeDataType.String, 200),
        new JdeField("AIR74ADDU", "AIR74ADDU", JdeDataType.String, 24),
        new JdeField("AIR74CTYU", "AIR74CTYU", JdeDataType.String, 50),
        new JdeField("AIR74ADL1U", "AIR74ADL1U", JdeDataType.String, 200),
        new JdeField("AIR74ADL2U", "AIR74ADL2U", JdeDataType.String, 200),
        new JdeField("AIR74ARC", "AIR74ARC", JdeDataType.String, 12),
        new JdeField("AIR74PHC", "AIR74PHC", JdeDataType.String, 40),
        new JdeField("AIR74TAXC", "AIR74TAXC", JdeDataType.String, 40),
        new JdeField("AIURRF", "AIURRF", JdeDataType.String, 30),
        new JdeField("AIURDT", "AIURDT", JdeDataType.Numeric),
        new JdeField("AIURC1", "AIURC1", JdeDataType.String, 6),
        new JdeField("AIURAT", "AIURAT", JdeDataType.Numeric),
        new JdeField("AIURAB", "AIURAB", JdeDataType.Numeric),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AIUPMT", "AIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R3038_0", "Primary Key on AIKCO, AIDCT, AIDOC", new[] { "AIKCO", "AIDCT", "AIDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
