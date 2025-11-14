using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74412 - .
/// </summary>
public class F74412 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPDTFR.
        /// </summary>
        public const string RPDTFR = "RPDTFR";

        /// <summary>
        /// RPDAG.
        /// </summary>
        public const string RPDAG = "RPDAG";

        /// <summary>
        /// RPCO.
        /// </summary>
        public const string RPCO = "RPCO";

        /// <summary>
        /// RPSY.
        /// </summary>
        public const string RPSY = "RPSY";

        /// <summary>
        /// RPAID.
        /// </summary>
        public const string RPAID = "RPAID";

        /// <summary>
        /// RPGLC.
        /// </summary>
        public const string RPGLC = "RPGLC";

        /// <summary>
        /// RPPA8.
        /// </summary>
        public const string RPPA8 = "RPPA8";

        /// <summary>
        /// RPAN8.
        /// </summary>
        public const string RPAN8 = "RPAN8";

        /// <summary>
        /// RPDGJ.
        /// </summary>
        public const string RPDGJ = "RPDGJ";

        /// <summary>
        /// RPCKNU.
        /// </summary>
        public const string RPCKNU = "RPCKNU";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPVINV.
        /// </summary>
        public const string RPVINV = "RPVINV";

        /// <summary>
        /// RPDCTM.
        /// </summary>
        public const string RPDCTM = "RPDCTM";

        /// <summary>
        /// RPPOST.
        /// </summary>
        public const string RPPOST = "RPPOST";

        /// <summary>
        /// RPDIVJ.
        /// </summary>
        public const string RPDIVJ = "RPDIVJ";

        /// <summary>
        /// RPCRCD.
        /// </summary>
        public const string RPCRCD = "RPCRCD";

        /// <summary>
        /// RPCRR.
        /// </summary>
        public const string RPCRR = "RPCRR";

        /// <summary>
        /// RPAG.
        /// </summary>
        public const string RPAG = "RPAG";

        /// <summary>
        /// RPACR.
        /// </summary>
        public const string RPACR = "RPACR";

        /// <summary>
        /// RPAAP.
        /// </summary>
        public const string RPAAP = "RPAAP";

        /// <summary>
        /// RPFAP.
        /// </summary>
        public const string RPFAP = "RPFAP";

        /// <summary>
        /// RPADSA.
        /// </summary>
        public const string RPADSA = "RPADSA";

        /// <summary>
        /// RPCDSA.
        /// </summary>
        public const string RPCDSA = "RPCDSA";

        /// <summary>
        /// RPDDST.
        /// </summary>
        public const string RPDDST = "RPDDST";

        /// <summary>
        /// RPGFL1.
        /// </summary>
        public const string RPGFL1 = "RPGFL1";
    }

    /// <inheritdoc />
    public override string TableName => "F74412";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPDTFR", "RPDTFR", JdeDataType.Numeric),
        new JdeField("RPDAG", "RPDAG", JdeDataType.Numeric),
        new JdeField("RPCO", "RPCO", JdeDataType.String, 10),
        new JdeField("RPSY", "RPSY", JdeDataType.String, 8, true, true),
        new JdeField("RPAID", "RPAID", JdeDataType.String, 16, true, true),
        new JdeField("RPGLC", "RPGLC", JdeDataType.String, 8, true, true),
        new JdeField("RPPA8", "RPPA8", JdeDataType.Numeric, null, true, true),
        new JdeField("RPAN8", "RPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDGJ", "RPDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RPCKNU", "RPCKNU", JdeDataType.String, 50, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPVINV", "RPVINV", JdeDataType.String, 50, true, true),
        new JdeField("RPDCTM", "RPDCTM", JdeDataType.String, 4, true, true),
        new JdeField("RPPOST", "RPPOST", JdeDataType.String, 2),
        new JdeField("RPDIVJ", "RPDIVJ", JdeDataType.Numeric),
        new JdeField("RPCRCD", "RPCRCD", JdeDataType.String, 6),
        new JdeField("RPCRR", "RPCRR", JdeDataType.Numeric),
        new JdeField("RPAG", "RPAG", JdeDataType.Numeric),
        new JdeField("RPACR", "RPACR", JdeDataType.Numeric),
        new JdeField("RPAAP", "RPAAP", JdeDataType.Numeric),
        new JdeField("RPFAP", "RPFAP", JdeDataType.Numeric),
        new JdeField("RPADSA", "RPADSA", JdeDataType.Numeric),
        new JdeField("RPCDSA", "RPCDSA", JdeDataType.Numeric),
        new JdeField("RPDDST", "RPDDST", JdeDataType.String, 2),
        new JdeField("RPGFL1", "RPGFL1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74412_0", "Primary Key on RPSY, RPAID, RPGLC, RPPA8, RPAN8, RPDGJ, RPCKNU, RPDCT, RPKCO, RPVINV, RPDCTM", new[] { "RPSY", "RPAID", "RPGLC", "RPPA8", "RPAN8", "RPDGJ", "RPCKNU", "RPDCT", "RPKCO", "RPVINV", "RPDCTM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74412_2", "Index on RPSY, RPDCT, RPAID, RPGLC, RPAN8, RPDGJ", new[] { "RPSY", "RPDCT", "RPAID", "RPGLC", "RPAN8", "RPDGJ" }),
        new JdeIndex("F74412_3", "Index on RPSY, RPAID, RPGLC, RPPA8, RPAN8, RPCKNU, RPDCT, RPVINV", new[] { "RPSY", "RPAID", "RPGLC", "RPPA8", "RPAN8", "RPCKNU", "RPDCT", "RPVINV" })
    };
}
