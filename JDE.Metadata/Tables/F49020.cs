using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49020 - .
/// </summary>
public class F49020 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VLVEHI.
        /// </summary>
        public const string VLVEHI = "VLVEHI";

        /// <summary>
        /// VLSTFN.
        /// </summary>
        public const string VLSTFN = "VLSTFN";

        /// <summary>
        /// VLRQR.
        /// </summary>
        public const string VLRQR = "VLRQR";

        /// <summary>
        /// VLRLNO.
        /// </summary>
        public const string VLRLNO = "VLRLNO";

        /// <summary>
        /// VLRLT.
        /// </summary>
        public const string VLRLT = "VLRLT";

        /// <summary>
        /// VLLAGY.
        /// </summary>
        public const string VLLAGY = "VLLAGY";

        /// <summary>
        /// VLCTR.
        /// </summary>
        public const string VLCTR = "VLCTR";

        /// <summary>
        /// VLEFTJ.
        /// </summary>
        public const string VLEFTJ = "VLEFTJ";

        /// <summary>
        /// VLEXDJ.
        /// </summary>
        public const string VLEXDJ = "VLEXDJ";

        /// <summary>
        /// VLINMG.
        /// </summary>
        public const string VLINMG = "VLINMG";

        /// <summary>
        /// VLMEST.
        /// </summary>
        public const string VLMEST = "VLMEST";

        /// <summary>
        /// VLURCD.
        /// </summary>
        public const string VLURCD = "VLURCD";

        /// <summary>
        /// VLURDT.
        /// </summary>
        public const string VLURDT = "VLURDT";

        /// <summary>
        /// VLURAT.
        /// </summary>
        public const string VLURAT = "VLURAT";

        /// <summary>
        /// VLURAB.
        /// </summary>
        public const string VLURAB = "VLURAB";

        /// <summary>
        /// VLURRF.
        /// </summary>
        public const string VLURRF = "VLURRF";

        /// <summary>
        /// VLUSER.
        /// </summary>
        public const string VLUSER = "VLUSER";

        /// <summary>
        /// VLPID.
        /// </summary>
        public const string VLPID = "VLPID";

        /// <summary>
        /// VLJOBN.
        /// </summary>
        public const string VLJOBN = "VLJOBN";

        /// <summary>
        /// VLUPMJ.
        /// </summary>
        public const string VLUPMJ = "VLUPMJ";

        /// <summary>
        /// VLTDAY.
        /// </summary>
        public const string VLTDAY = "VLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49020";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VLVEHI", "VLVEHI", JdeDataType.String, 24, true, true),
        new JdeField("VLSTFN", "VLSTFN", JdeDataType.Numeric, null, true, true),
        new JdeField("VLRQR", "VLRQR", JdeDataType.String, 2),
        new JdeField("VLRLNO", "VLRLNO", JdeDataType.String, 26),
        new JdeField("VLRLT", "VLRLT", JdeDataType.String, 4, true, true),
        new JdeField("VLLAGY", "VLLAGY", JdeDataType.Numeric, null, true, true),
        new JdeField("VLCTR", "VLCTR", JdeDataType.String, 6),
        new JdeField("VLEFTJ", "VLEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("VLEXDJ", "VLEXDJ", JdeDataType.Numeric),
        new JdeField("VLINMG", "VLINMG", JdeDataType.String, 20),
        new JdeField("VLMEST", "VLMEST", JdeDataType.String, 2),
        new JdeField("VLURCD", "VLURCD", JdeDataType.String, 4),
        new JdeField("VLURDT", "VLURDT", JdeDataType.Numeric),
        new JdeField("VLURAT", "VLURAT", JdeDataType.Numeric),
        new JdeField("VLURAB", "VLURAB", JdeDataType.Numeric),
        new JdeField("VLURRF", "VLURRF", JdeDataType.String, 30),
        new JdeField("VLUSER", "VLUSER", JdeDataType.String, 20),
        new JdeField("VLPID", "VLPID", JdeDataType.String, 20),
        new JdeField("VLJOBN", "VLJOBN", JdeDataType.String, 20),
        new JdeField("VLUPMJ", "VLUPMJ", JdeDataType.Numeric),
        new JdeField("VLTDAY", "VLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49020_0", "Primary Key on VLVEHI, VLSTFN, VLRLT, VLLAGY, VLEFTJ", new[] { "VLVEHI", "VLSTFN", "VLRLT", "VLLAGY", "VLEFTJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49020_4", "Index on VLVEHI, VLSTFN, VLRLNO, VLRLT", new[] { "VLVEHI", "VLSTFN", "VLRLNO", "VLRLT" })
    };
}
