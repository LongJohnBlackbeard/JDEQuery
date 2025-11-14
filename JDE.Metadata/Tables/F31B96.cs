using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B96 - .
/// </summary>
public class F31B96 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDWVID.
        /// </summary>
        public const string BDWVID = "BDWVID";

        /// <summary>
        /// BDUKID.
        /// </summary>
        public const string BDUKID = "BDUKID";

        /// <summary>
        /// BDBOLN.
        /// </summary>
        public const string BDBOLN = "BDBOLN";

        /// <summary>
        /// BDBSNN.
        /// </summary>
        public const string BDBSNN = "BDBSNN";

        /// <summary>
        /// BDCARS.
        /// </summary>
        public const string BDCARS = "BDCARS";

        /// <summary>
        /// BDVEHS.
        /// </summary>
        public const string BDVEHS = "BDVEHS";

        /// <summary>
        /// BDDRVR.
        /// </summary>
        public const string BDDRVR = "BDDRVR";

        /// <summary>
        /// BDVEHI.
        /// </summary>
        public const string BDVEHI = "BDVEHI";

        /// <summary>
        /// BDWAVL.
        /// </summary>
        public const string BDWAVL = "BDWAVL";

        /// <summary>
        /// BDWVUM.
        /// </summary>
        public const string BDWVUM = "BDWVUM";

        /// <summary>
        /// BDABOLN.
        /// </summary>
        public const string BDABOLN = "BDABOLN";

        /// <summary>
        /// BDURCD.
        /// </summary>
        public const string BDURCD = "BDURCD";

        /// <summary>
        /// BDURDT.
        /// </summary>
        public const string BDURDT = "BDURDT";

        /// <summary>
        /// BDURAT.
        /// </summary>
        public const string BDURAT = "BDURAT";

        /// <summary>
        /// BDURRF.
        /// </summary>
        public const string BDURRF = "BDURRF";

        /// <summary>
        /// BDURAB.
        /// </summary>
        public const string BDURAB = "BDURAB";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B96";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDWVID", "BDWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("BDUKID", "BDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BDBOLN", "BDBOLN", JdeDataType.Numeric),
        new JdeField("BDBSNN", "BDBSNN", JdeDataType.Numeric),
        new JdeField("BDCARS", "BDCARS", JdeDataType.Numeric),
        new JdeField("BDVEHS", "BDVEHS", JdeDataType.String, 50),
        new JdeField("BDDRVR", "BDDRVR", JdeDataType.Numeric),
        new JdeField("BDVEHI", "BDVEHI", JdeDataType.String, 24),
        new JdeField("BDWAVL", "BDWAVL", JdeDataType.Numeric),
        new JdeField("BDWVUM", "BDWVUM", JdeDataType.String, 6),
        new JdeField("BDABOLN", "BDABOLN", JdeDataType.String, 60),
        new JdeField("BDURCD", "BDURCD", JdeDataType.String, 4),
        new JdeField("BDURDT", "BDURDT", JdeDataType.Numeric),
        new JdeField("BDURAT", "BDURAT", JdeDataType.Numeric),
        new JdeField("BDURRF", "BDURRF", JdeDataType.String, 30),
        new JdeField("BDURAB", "BDURAB", JdeDataType.Numeric),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B96_0", "Primary Key on BDWVID, BDUKID", new[] { "BDWVID", "BDUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
