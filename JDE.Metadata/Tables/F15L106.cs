using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L106 - .
/// </summary>
public class F15L106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RBMCU.
        /// </summary>
        public const string RBMCU = "RBMCU";

        /// <summary>
        /// RBRVNB.
        /// </summary>
        public const string RBRVNB = "RBRVNB";

        /// <summary>
        /// RBBCRI.
        /// </summary>
        public const string RBBCRI = "RBBCRI";

        /// <summary>
        /// RBDL01.
        /// </summary>
        public const string RBDL01 = "RBDL01";

        /// <summary>
        /// RBUR01.
        /// </summary>
        public const string RBUR01 = "RBUR01";

        /// <summary>
        /// RBUR02.
        /// </summary>
        public const string RBUR02 = "RBUR02";

        /// <summary>
        /// RBUR03.
        /// </summary>
        public const string RBUR03 = "RBUR03";

        /// <summary>
        /// RBUR04.
        /// </summary>
        public const string RBUR04 = "RBUR04";

        /// <summary>
        /// RBUR05.
        /// </summary>
        public const string RBUR05 = "RBUR05";

        /// <summary>
        /// RBURCD.
        /// </summary>
        public const string RBURCD = "RBURCD";

        /// <summary>
        /// RBURDT.
        /// </summary>
        public const string RBURDT = "RBURDT";

        /// <summary>
        /// RBURAT.
        /// </summary>
        public const string RBURAT = "RBURAT";

        /// <summary>
        /// RBURAB.
        /// </summary>
        public const string RBURAB = "RBURAB";

        /// <summary>
        /// RBURRF.
        /// </summary>
        public const string RBURRF = "RBURRF";

        /// <summary>
        /// RBTORG.
        /// </summary>
        public const string RBTORG = "RBTORG";

        /// <summary>
        /// RBENTJ.
        /// </summary>
        public const string RBENTJ = "RBENTJ";

        /// <summary>
        /// RBJOBN.
        /// </summary>
        public const string RBJOBN = "RBJOBN";

        /// <summary>
        /// RBUSER.
        /// </summary>
        public const string RBUSER = "RBUSER";

        /// <summary>
        /// RBPID.
        /// </summary>
        public const string RBPID = "RBPID";

        /// <summary>
        /// RBUPMJ.
        /// </summary>
        public const string RBUPMJ = "RBUPMJ";

        /// <summary>
        /// RBUPMT.
        /// </summary>
        public const string RBUPMT = "RBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15L106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RBMCU", "RBMCU", JdeDataType.String, 24, true, true),
        new JdeField("RBRVNB", "RBRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("RBBCRI", "RBBCRI", JdeDataType.String, 20, true, true),
        new JdeField("RBDL01", "RBDL01", JdeDataType.String, 60),
        new JdeField("RBUR01", "RBUR01", JdeDataType.String, 6),
        new JdeField("RBUR02", "RBUR02", JdeDataType.String, 6),
        new JdeField("RBUR03", "RBUR03", JdeDataType.String, 6),
        new JdeField("RBUR04", "RBUR04", JdeDataType.String, 6),
        new JdeField("RBUR05", "RBUR05", JdeDataType.String, 6),
        new JdeField("RBURCD", "RBURCD", JdeDataType.String, 4),
        new JdeField("RBURDT", "RBURDT", JdeDataType.Numeric),
        new JdeField("RBURAT", "RBURAT", JdeDataType.Numeric),
        new JdeField("RBURAB", "RBURAB", JdeDataType.Numeric),
        new JdeField("RBURRF", "RBURRF", JdeDataType.String, 30),
        new JdeField("RBTORG", "RBTORG", JdeDataType.String, 20),
        new JdeField("RBENTJ", "RBENTJ", JdeDataType.Numeric),
        new JdeField("RBJOBN", "RBJOBN", JdeDataType.String, 20),
        new JdeField("RBUSER", "RBUSER", JdeDataType.String, 20),
        new JdeField("RBPID", "RBPID", JdeDataType.String, 20),
        new JdeField("RBUPMJ", "RBUPMJ", JdeDataType.Numeric),
        new JdeField("RBUPMT", "RBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L106_0", "Primary Key on RBMCU, RBRVNB, RBBCRI", new[] { "RBMCU", "RBRVNB", "RBBCRI" }, isUnique: true, isPrimaryKey: true)
    };
}
