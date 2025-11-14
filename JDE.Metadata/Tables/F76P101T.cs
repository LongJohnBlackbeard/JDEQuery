using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P101T - .
/// </summary>
public class F76P101T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APAN8.
        /// </summary>
        public const string APAN8 = "APAN8";

        /// <summary>
        /// APH76ABDT.
        /// </summary>
        public const string APH76ABDT = "APH76ABDT";

        /// <summary>
        /// APH76PFC.
        /// </summary>
        public const string APH76PFC = "APH76PFC";

        /// <summary>
        /// APH76PFD.
        /// </summary>
        public const string APH76PFD = "APH76PFD";

        /// <summary>
        /// APP76SC.
        /// </summary>
        public const string APP76SC = "APP76SC";

        /// <summary>
        /// APP76SCD.
        /// </summary>
        public const string APP76SCD = "APP76SCD";

        /// <summary>
        /// APDSC2.
        /// </summary>
        public const string APDSC2 = "APDSC2";

        /// <summary>
        /// APDSC3.
        /// </summary>
        public const string APDSC3 = "APDSC3";

        /// <summary>
        /// APP76CC01.
        /// </summary>
        public const string APP76CC01 = "APP76CC01";

        /// <summary>
        /// APP76CC02.
        /// </summary>
        public const string APP76CC02 = "APP76CC02";

        /// <summary>
        /// APP76CC03.
        /// </summary>
        public const string APP76CC03 = "APP76CC03";

        /// <summary>
        /// APP76CC04.
        /// </summary>
        public const string APP76CC04 = "APP76CC04";

        /// <summary>
        /// APP76CC05.
        /// </summary>
        public const string APP76CC05 = "APP76CC05";

        /// <summary>
        /// APP76CC06.
        /// </summary>
        public const string APP76CC06 = "APP76CC06";

        /// <summary>
        /// APP76CC07.
        /// </summary>
        public const string APP76CC07 = "APP76CC07";

        /// <summary>
        /// APP76CC08.
        /// </summary>
        public const string APP76CC08 = "APP76CC08";

        /// <summary>
        /// APP76CC09.
        /// </summary>
        public const string APP76CC09 = "APP76CC09";

        /// <summary>
        /// APP76CC10.
        /// </summary>
        public const string APP76CC10 = "APP76CC10";

        /// <summary>
        /// APH76CC01.
        /// </summary>
        public const string APH76CC01 = "APH76CC01";

        /// <summary>
        /// APH76CC02.
        /// </summary>
        public const string APH76CC02 = "APH76CC02";

        /// <summary>
        /// APH76CC03.
        /// </summary>
        public const string APH76CC03 = "APH76CC03";

        /// <summary>
        /// APH76FUA.
        /// </summary>
        public const string APH76FUA = "APH76FUA";

        /// <summary>
        /// APH76FUC.
        /// </summary>
        public const string APH76FUC = "APH76FUC";

        /// <summary>
        /// APH76FUD.
        /// </summary>
        public const string APH76FUD = "APH76FUD";

        /// <summary>
        /// APH76FUR.
        /// </summary>
        public const string APH76FUR = "APH76FUR";

        /// <summary>
        /// APH76FUF.
        /// </summary>
        public const string APH76FUF = "APH76FUF";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76P101T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APAN8", "APAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("APH76ABDT", "APH76ABDT", JdeDataType.String, 6),
        new JdeField("APH76PFC", "APH76PFC", JdeDataType.String, 2),
        new JdeField("APH76PFD", "APH76PFD", JdeDataType.Numeric),
        new JdeField("APP76SC", "APP76SC", JdeDataType.String, 2),
        new JdeField("APP76SCD", "APP76SCD", JdeDataType.Numeric),
        new JdeField("APDSC2", "APDSC2", JdeDataType.String, 60),
        new JdeField("APDSC3", "APDSC3", JdeDataType.String, 60),
        new JdeField("APP76CC01", "APP76CC01", JdeDataType.String, 6),
        new JdeField("APP76CC02", "APP76CC02", JdeDataType.String, 6),
        new JdeField("APP76CC03", "APP76CC03", JdeDataType.String, 6),
        new JdeField("APP76CC04", "APP76CC04", JdeDataType.String, 6),
        new JdeField("APP76CC05", "APP76CC05", JdeDataType.String, 6),
        new JdeField("APP76CC06", "APP76CC06", JdeDataType.String, 6),
        new JdeField("APP76CC07", "APP76CC07", JdeDataType.String, 6),
        new JdeField("APP76CC08", "APP76CC08", JdeDataType.String, 6),
        new JdeField("APP76CC09", "APP76CC09", JdeDataType.String, 6),
        new JdeField("APP76CC10", "APP76CC10", JdeDataType.String, 6),
        new JdeField("APH76CC01", "APH76CC01", JdeDataType.String, 6),
        new JdeField("APH76CC02", "APH76CC02", JdeDataType.String, 6),
        new JdeField("APH76CC03", "APH76CC03", JdeDataType.String, 6),
        new JdeField("APH76FUA", "APH76FUA", JdeDataType.Numeric),
        new JdeField("APH76FUC", "APH76FUC", JdeDataType.String, 20),
        new JdeField("APH76FUD", "APH76FUD", JdeDataType.Numeric),
        new JdeField("APH76FUR", "APH76FUR", JdeDataType.String, 30),
        new JdeField("APH76FUF", "APH76FUF", JdeDataType.String, 2),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P101T_0", "Primary Key on APAN8", new[] { "APAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
