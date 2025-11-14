using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B030 - .
/// </summary>
public class F76B030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTBNNF.
        /// </summary>
        public const string MTBNNF = "MTBNNF";

        /// <summary>
        /// MTBSER.
        /// </summary>
        public const string MTBSER = "MTBSER";

        /// <summary>
        /// MTN001.
        /// </summary>
        public const string MTN001 = "MTN001";

        /// <summary>
        /// MTDCT.
        /// </summary>
        public const string MTDCT = "MTDCT";

        /// <summary>
        /// MTB76TPSB.
        /// </summary>
        public const string MTB76TPSB = "MTB76TPSB";

        /// <summary>
        /// MTB76TPSA.
        /// </summary>
        public const string MTB76TPSA = "MTB76TPSA";

        /// <summary>
        /// MTB76TCSB.
        /// </summary>
        public const string MTB76TCSB = "MTB76TCSB";

        /// <summary>
        /// MTB76TCFSA.
        /// </summary>
        public const string MTB76TCFSA = "MTB76TCFSA";

        /// <summary>
        /// MTB76MOTY.
        /// </summary>
        public const string MTB76MOTY = "MTB76MOTY";

        /// <summary>
        /// MTB76URAB.
        /// </summary>
        public const string MTB76URAB = "MTB76URAB";

        /// <summary>
        /// MTB76URAT.
        /// </summary>
        public const string MTB76URAT = "MTB76URAT";

        /// <summary>
        /// MTB76URRF.
        /// </summary>
        public const string MTB76URRF = "MTB76URRF";

        /// <summary>
        /// MTB76URDT.
        /// </summary>
        public const string MTB76URDT = "MTB76URDT";

        /// <summary>
        /// MTB76URCD.
        /// </summary>
        public const string MTB76URCD = "MTB76URCD";

        /// <summary>
        /// MTUSER.
        /// </summary>
        public const string MTUSER = "MTUSER";

        /// <summary>
        /// MTPID.
        /// </summary>
        public const string MTPID = "MTPID";

        /// <summary>
        /// MTJOBN.
        /// </summary>
        public const string MTJOBN = "MTJOBN";

        /// <summary>
        /// MTUPMJ.
        /// </summary>
        public const string MTUPMJ = "MTUPMJ";

        /// <summary>
        /// MTUPMT.
        /// </summary>
        public const string MTUPMT = "MTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTBNNF", "MTBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("MTBSER", "MTBSER", JdeDataType.String, 4, true, true),
        new JdeField("MTN001", "MTN001", JdeDataType.Numeric, null, true, true),
        new JdeField("MTDCT", "MTDCT", JdeDataType.String, 4, true, true),
        new JdeField("MTB76TPSB", "MTB76TPSB", JdeDataType.Numeric),
        new JdeField("MTB76TPSA", "MTB76TPSA", JdeDataType.Numeric),
        new JdeField("MTB76TCSB", "MTB76TCSB", JdeDataType.Numeric),
        new JdeField("MTB76TCFSA", "MTB76TCFSA", JdeDataType.Numeric),
        new JdeField("MTB76MOTY", "MTB76MOTY", JdeDataType.String, 4),
        new JdeField("MTB76URAB", "MTB76URAB", JdeDataType.Numeric),
        new JdeField("MTB76URAT", "MTB76URAT", JdeDataType.Numeric),
        new JdeField("MTB76URRF", "MTB76URRF", JdeDataType.String, 30),
        new JdeField("MTB76URDT", "MTB76URDT", JdeDataType.Numeric),
        new JdeField("MTB76URCD", "MTB76URCD", JdeDataType.String, 4),
        new JdeField("MTUSER", "MTUSER", JdeDataType.String, 20),
        new JdeField("MTPID", "MTPID", JdeDataType.String, 20),
        new JdeField("MTJOBN", "MTJOBN", JdeDataType.String, 20),
        new JdeField("MTUPMJ", "MTUPMJ", JdeDataType.Numeric),
        new JdeField("MTUPMT", "MTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B030_0", "Primary Key on MTBNNF, MTBSER, MTN001, MTDCT", new[] { "MTBNNF", "MTBSER", "MTN001", "MTDCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B030_2", "Index on MTB76MOTY", new[] { "MTB76MOTY" })
    };
}
