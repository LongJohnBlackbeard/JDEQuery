using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q62 - .
/// </summary>
public class F43Q62 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCBIDCODE.
        /// </summary>
        public const string BCBIDCODE = "BCBIDCODE";

        /// <summary>
        /// BCCMDCDE.
        /// </summary>
        public const string BCCMDCDE = "BCCMDCDE";

        /// <summary>
        /// BCITM.
        /// </summary>
        public const string BCITM = "BCITM";

        /// <summary>
        /// BCPCPTN.
        /// </summary>
        public const string BCPCPTN = "BCPCPTN";

        /// <summary>
        /// BCPCPD.
        /// </summary>
        public const string BCPCPD = "BCPCPD";

        /// <summary>
        /// BCUOM.
        /// </summary>
        public const string BCUOM = "BCUOM";

        /// <summary>
        /// BCWHTG.
        /// </summary>
        public const string BCWHTG = "BCWHTG";

        /// <summary>
        /// BCURCD.
        /// </summary>
        public const string BCURCD = "BCURCD";

        /// <summary>
        /// BCURDT.
        /// </summary>
        public const string BCURDT = "BCURDT";

        /// <summary>
        /// BCURAT.
        /// </summary>
        public const string BCURAT = "BCURAT";

        /// <summary>
        /// BCURAB.
        /// </summary>
        public const string BCURAB = "BCURAB";

        /// <summary>
        /// BCURRF.
        /// </summary>
        public const string BCURRF = "BCURRF";

        /// <summary>
        /// BCTORG.
        /// </summary>
        public const string BCTORG = "BCTORG";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCTDAY.
        /// </summary>
        public const string BCTDAY = "BCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q62";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCBIDCODE", "BCBIDCODE", JdeDataType.String, 36, true, true),
        new JdeField("BCCMDCDE", "BCCMDCDE", JdeDataType.String, 30, true, true),
        new JdeField("BCITM", "BCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BCPCPTN", "BCPCPTN", JdeDataType.Numeric, null, true, true),
        new JdeField("BCPCPD", "BCPCPD", JdeDataType.String, 80),
        new JdeField("BCUOM", "BCUOM", JdeDataType.String, 4),
        new JdeField("BCWHTG", "BCWHTG", JdeDataType.Numeric),
        new JdeField("BCURCD", "BCURCD", JdeDataType.String, 4),
        new JdeField("BCURDT", "BCURDT", JdeDataType.Numeric),
        new JdeField("BCURAT", "BCURAT", JdeDataType.Numeric),
        new JdeField("BCURAB", "BCURAB", JdeDataType.Numeric),
        new JdeField("BCURRF", "BCURRF", JdeDataType.String, 30),
        new JdeField("BCTORG", "BCTORG", JdeDataType.String, 20),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCTDAY", "BCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q62_0", "Primary Key on BCBIDCODE, BCCMDCDE, BCITM, BCPCPTN", new[] { "BCBIDCODE", "BCCMDCDE", "BCITM", "BCPCPTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q62_2", "Index on BCBIDCODE, BCCMDCDE, BCITM", new[] { "BCBIDCODE", "BCCMDCDE", "BCITM" })
    };
}
