using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H101T - .
/// </summary>
public class F76H101T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHAN8.
        /// </summary>
        public const string AHAN8 = "AHAN8";

        /// <summary>
        /// AHH76ABDT.
        /// </summary>
        public const string AHH76ABDT = "AHH76ABDT";

        /// <summary>
        /// AHH76PFC.
        /// </summary>
        public const string AHH76PFC = "AHH76PFC";

        /// <summary>
        /// AHH76PFD.
        /// </summary>
        public const string AHH76PFD = "AHH76PFD";

        /// <summary>
        /// AHDSC2.
        /// </summary>
        public const string AHDSC2 = "AHDSC2";

        /// <summary>
        /// AHDSC3.
        /// </summary>
        public const string AHDSC3 = "AHDSC3";

        /// <summary>
        /// AHH76CC01.
        /// </summary>
        public const string AHH76CC01 = "AHH76CC01";

        /// <summary>
        /// AHH76CC02.
        /// </summary>
        public const string AHH76CC02 = "AHH76CC02";

        /// <summary>
        /// AHH76CC03.
        /// </summary>
        public const string AHH76CC03 = "AHH76CC03";

        /// <summary>
        /// AHH76CC04.
        /// </summary>
        public const string AHH76CC04 = "AHH76CC04";

        /// <summary>
        /// AHH76CC05.
        /// </summary>
        public const string AHH76CC05 = "AHH76CC05";

        /// <summary>
        /// AHH76CC06.
        /// </summary>
        public const string AHH76CC06 = "AHH76CC06";

        /// <summary>
        /// AHH76CC07.
        /// </summary>
        public const string AHH76CC07 = "AHH76CC07";

        /// <summary>
        /// AHH76CC08.
        /// </summary>
        public const string AHH76CC08 = "AHH76CC08";

        /// <summary>
        /// AHH76CC09.
        /// </summary>
        public const string AHH76CC09 = "AHH76CC09";

        /// <summary>
        /// AHH76CC10.
        /// </summary>
        public const string AHH76CC10 = "AHH76CC10";

        /// <summary>
        /// AHH76FUA.
        /// </summary>
        public const string AHH76FUA = "AHH76FUA";

        /// <summary>
        /// AHH76FUC.
        /// </summary>
        public const string AHH76FUC = "AHH76FUC";

        /// <summary>
        /// AHH76FUD.
        /// </summary>
        public const string AHH76FUD = "AHH76FUD";

        /// <summary>
        /// AHH76FUR.
        /// </summary>
        public const string AHH76FUR = "AHH76FUR";

        /// <summary>
        /// AHH76FUF.
        /// </summary>
        public const string AHH76FUF = "AHH76FUF";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHJOBN.
        /// </summary>
        public const string AHJOBN = "AHJOBN";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHUPMT.
        /// </summary>
        public const string AHUPMT = "AHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H101T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHAN8", "AHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AHH76ABDT", "AHH76ABDT", JdeDataType.String, 6),
        new JdeField("AHH76PFC", "AHH76PFC", JdeDataType.String, 2),
        new JdeField("AHH76PFD", "AHH76PFD", JdeDataType.Numeric),
        new JdeField("AHDSC2", "AHDSC2", JdeDataType.String, 60),
        new JdeField("AHDSC3", "AHDSC3", JdeDataType.String, 60),
        new JdeField("AHH76CC01", "AHH76CC01", JdeDataType.String, 6),
        new JdeField("AHH76CC02", "AHH76CC02", JdeDataType.String, 6),
        new JdeField("AHH76CC03", "AHH76CC03", JdeDataType.String, 6),
        new JdeField("AHH76CC04", "AHH76CC04", JdeDataType.String, 6),
        new JdeField("AHH76CC05", "AHH76CC05", JdeDataType.String, 6),
        new JdeField("AHH76CC06", "AHH76CC06", JdeDataType.String, 6),
        new JdeField("AHH76CC07", "AHH76CC07", JdeDataType.String, 6),
        new JdeField("AHH76CC08", "AHH76CC08", JdeDataType.String, 6),
        new JdeField("AHH76CC09", "AHH76CC09", JdeDataType.String, 6),
        new JdeField("AHH76CC10", "AHH76CC10", JdeDataType.String, 6),
        new JdeField("AHH76FUA", "AHH76FUA", JdeDataType.Numeric),
        new JdeField("AHH76FUC", "AHH76FUC", JdeDataType.String, 20),
        new JdeField("AHH76FUD", "AHH76FUD", JdeDataType.Numeric),
        new JdeField("AHH76FUR", "AHH76FUR", JdeDataType.String, 30),
        new JdeField("AHH76FUF", "AHH76FUF", JdeDataType.String, 2),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHUPMT", "AHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H101T_0", "Primary Key on AHAN8", new[] { "AHAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
