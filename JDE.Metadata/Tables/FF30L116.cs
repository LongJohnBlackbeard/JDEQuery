using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L116 - .
/// </summary>
public class FF30L116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCSOEID.
        /// </summary>
        public const string CCSOEID = "CCSOEID";

        /// <summary>
        /// CCSOELID.
        /// </summary>
        public const string CCSOELID = "CCSOELID";

        /// <summary>
        /// CCCMLNID.
        /// </summary>
        public const string CCCMLNID = "CCCMLNID";

        /// <summary>
        /// CCDFITM.
        /// </summary>
        public const string CCDFITM = "CCDFITM";

        /// <summary>
        /// CCCPNB.
        /// </summary>
        public const string CCCPNB = "CCCPNB";

        /// <summary>
        /// CCDFKIT.
        /// </summary>
        public const string CCDFKIT = "CCDFKIT";

        /// <summary>
        /// CCFSCID.
        /// </summary>
        public const string CCFSCID = "CCFSCID";

        /// <summary>
        /// CCDFCMCU.
        /// </summary>
        public const string CCDFCMCU = "CCDFCMCU";

        /// <summary>
        /// CCDFUSQT.
        /// </summary>
        public const string CCDFUSQT = "CCDFUSQT";

        /// <summary>
        /// CCUM.
        /// </summary>
        public const string CCUM = "CCUM";

        /// <summary>
        /// CCVALBOM.
        /// </summary>
        public const string CCVALBOM = "CCVALBOM";

        /// <summary>
        /// CCBOSTR.
        /// </summary>
        public const string CCBOSTR = "CCBOSTR";

        /// <summary>
        /// CCURCD.
        /// </summary>
        public const string CCURCD = "CCURCD";

        /// <summary>
        /// CCURDT.
        /// </summary>
        public const string CCURDT = "CCURDT";

        /// <summary>
        /// CCURAT.
        /// </summary>
        public const string CCURAT = "CCURAT";

        /// <summary>
        /// CCURAB.
        /// </summary>
        public const string CCURAB = "CCURAB";

        /// <summary>
        /// CCURRF.
        /// </summary>
        public const string CCURRF = "CCURRF";

        /// <summary>
        /// CCTORG.
        /// </summary>
        public const string CCTORG = "CCTORG";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCUUPMJ.
        /// </summary>
        public const string CCUUPMJ = "CCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCSOEID", "CCSOEID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCSOELID", "CCSOELID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCMLNID", "CCCMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCDFITM", "CCDFITM", JdeDataType.Numeric),
        new JdeField("CCCPNB", "CCCPNB", JdeDataType.Numeric),
        new JdeField("CCDFKIT", "CCDFKIT", JdeDataType.Numeric),
        new JdeField("CCFSCID", "CCFSCID", JdeDataType.Numeric),
        new JdeField("CCDFCMCU", "CCDFCMCU", JdeDataType.String, 24),
        new JdeField("CCDFUSQT", "CCDFUSQT", JdeDataType.Numeric),
        new JdeField("CCUM", "CCUM", JdeDataType.String, 4),
        new JdeField("CCVALBOM", "CCVALBOM", JdeDataType.String, 4),
        new JdeField("CCBOSTR", "CCBOSTR", JdeDataType.String, 8),
        new JdeField("CCURCD", "CCURCD", JdeDataType.String, 4),
        new JdeField("CCURDT", "CCURDT", JdeDataType.Numeric),
        new JdeField("CCURAT", "CCURAT", JdeDataType.Numeric),
        new JdeField("CCURAB", "CCURAB", JdeDataType.Numeric),
        new JdeField("CCURRF", "CCURRF", JdeDataType.String, 30),
        new JdeField("CCTORG", "CCTORG", JdeDataType.String, 20),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCUUPMJ", "CCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L116_0", "Primary Key on CCSOEID, CCSOELID, CCCMLNID", new[] { "CCSOEID", "CCSOELID", "CCCMLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L116_2", "Index on CCSOEID, CCSOELID, CCCPNB, CCDFITM", new[] { "CCSOEID", "CCSOELID", "CCCPNB", "CCDFITM" }),
        new JdeIndex("FF30L116_3", "Index on CCSOEID, CCDFITM, CCBOSTR", new[] { "CCSOEID", "CCDFITM", "CCBOSTR" }),
        new JdeIndex("FF30L116_4", "Index on CCSOEID, CCSOELID, CCDFITM, CCBOSTR", new[] { "CCSOEID", "CCSOELID", "CCDFITM", "CCBOSTR" }),
        new JdeIndex("FF30L116_5", "Index on CCFSCID", new[] { "CCFSCID" })
    };
}
