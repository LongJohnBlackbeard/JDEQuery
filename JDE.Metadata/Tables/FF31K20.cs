using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K20 - .
/// </summary>
public class FF31K20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KCFSCID.
        /// </summary>
        public const string KCFSCID = "KCFSCID";

        /// <summary>
        /// KCDFMCU.
        /// </summary>
        public const string KCDFMCU = "KCDFMCU";

        /// <summary>
        /// KCPMAPID.
        /// </summary>
        public const string KCPMAPID = "KCPMAPID";

        /// <summary>
        /// KCCMITM.
        /// </summary>
        public const string KCCMITM = "KCCMITM";

        /// <summary>
        /// KCBOSTR.
        /// </summary>
        public const string KCBOSTR = "KCBOSTR";

        /// <summary>
        /// KCPCODE.
        /// </summary>
        public const string KCPCODE = "KCPCODE";

        /// <summary>
        /// KCBOMQTY.
        /// </summary>
        public const string KCBOMQTY = "KCBOMQTY";

        /// <summary>
        /// KCUOM.
        /// </summary>
        public const string KCUOM = "KCUOM";

        /// <summary>
        /// KCDFEFDT.
        /// </summary>
        public const string KCDFEFDT = "KCDFEFDT";

        /// <summary>
        /// KCDFANPL.
        /// </summary>
        public const string KCDFANPL = "KCDFANPL";

        /// <summary>
        /// KCKNOREP.
        /// </summary>
        public const string KCKNOREP = "KCKNOREP";

        /// <summary>
        /// KCURAB.
        /// </summary>
        public const string KCURAB = "KCURAB";

        /// <summary>
        /// KCURDT.
        /// </summary>
        public const string KCURDT = "KCURDT";

        /// <summary>
        /// KCURRF.
        /// </summary>
        public const string KCURRF = "KCURRF";

        /// <summary>
        /// KCURAT.
        /// </summary>
        public const string KCURAT = "KCURAT";

        /// <summary>
        /// KCURCD.
        /// </summary>
        public const string KCURCD = "KCURCD";

        /// <summary>
        /// KCTORG.
        /// </summary>
        public const string KCTORG = "KCTORG";

        /// <summary>
        /// KCUSER.
        /// </summary>
        public const string KCUSER = "KCUSER";

        /// <summary>
        /// KCJOBN.
        /// </summary>
        public const string KCJOBN = "KCJOBN";

        /// <summary>
        /// KCPID.
        /// </summary>
        public const string KCPID = "KCPID";

        /// <summary>
        /// KCUUPMJ.
        /// </summary>
        public const string KCUUPMJ = "KCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KCFSCID", "KCFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("KCDFMCU", "KCDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("KCPMAPID", "KCPMAPID", JdeDataType.Numeric, null, true, true),
        new JdeField("KCCMITM", "KCCMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("KCBOSTR", "KCBOSTR", JdeDataType.String, 8, true, true),
        new JdeField("KCPCODE", "KCPCODE", JdeDataType.String, 4),
        new JdeField("KCBOMQTY", "KCBOMQTY", JdeDataType.Numeric),
        new JdeField("KCUOM", "KCUOM", JdeDataType.String, 4),
        new JdeField("KCDFEFDT", "KCDFEFDT", JdeDataType.Numeric),
        new JdeField("KCDFANPL", "KCDFANPL", JdeDataType.Numeric),
        new JdeField("KCKNOREP", "KCKNOREP", JdeDataType.String, 2),
        new JdeField("KCURAB", "KCURAB", JdeDataType.Numeric),
        new JdeField("KCURDT", "KCURDT", JdeDataType.Numeric),
        new JdeField("KCURRF", "KCURRF", JdeDataType.String, 30),
        new JdeField("KCURAT", "KCURAT", JdeDataType.Numeric),
        new JdeField("KCURCD", "KCURCD", JdeDataType.String, 4),
        new JdeField("KCTORG", "KCTORG", JdeDataType.String, 20),
        new JdeField("KCUSER", "KCUSER", JdeDataType.String, 20),
        new JdeField("KCJOBN", "KCJOBN", JdeDataType.String, 20),
        new JdeField("KCPID", "KCPID", JdeDataType.String, 20),
        new JdeField("KCUUPMJ", "KCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K20_0", "Primary Key on KCFSCID, KCDFMCU, KCPMAPID, KCCMITM, KCBOSTR", new[] { "KCFSCID", "KCDFMCU", "KCPMAPID", "KCCMITM", "KCBOSTR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF31K20_2", "Index on KCFSCID, KCDFMCU, KCCMITM", new[] { "KCFSCID", "KCDFMCU", "KCCMITM" })
    };
}
