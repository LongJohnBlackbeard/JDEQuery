using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49595 - .
/// </summary>
public class F49595 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DKBN01.
        /// </summary>
        public const string DKBN01 = "DKBN01";

        /// <summary>
        /// DKDCCD.
        /// </summary>
        public const string DKDCCD = "DKDCCD";

        /// <summary>
        /// DKCO.
        /// </summary>
        public const string DKCO = "DKCO";

        /// <summary>
        /// DKEMCU.
        /// </summary>
        public const string DKEMCU = "DKEMCU";

        /// <summary>
        /// DKMCU.
        /// </summary>
        public const string DKMCU = "DKMCU";

        /// <summary>
        /// DKDCT.
        /// </summary>
        public const string DKDCT = "DKDCT";

        /// <summary>
        /// DKDOC.
        /// </summary>
        public const string DKDOC = "DKDOC";

        /// <summary>
        /// DKKCO.
        /// </summary>
        public const string DKKCO = "DKKCO";

        /// <summary>
        /// DKSDPC.
        /// </summary>
        public const string DKSDPC = "DKSDPC";

        /// <summary>
        /// DKDTDO.
        /// </summary>
        public const string DKDTDO = "DKDTDO";

        /// <summary>
        /// DKMCUZ.
        /// </summary>
        public const string DKMCUZ = "DKMCUZ";

        /// <summary>
        /// DKDPCR.
        /// </summary>
        public const string DKDPCR = "DKDPCR";

        /// <summary>
        /// DKDL01.
        /// </summary>
        public const string DKDL01 = "DKDL01";

        /// <summary>
        /// DKAA.
        /// </summary>
        public const string DKAA = "DKAA";

        /// <summary>
        /// DKCDEC.
        /// </summary>
        public const string DKCDEC = "DKCDEC";

        /// <summary>
        /// DKCRCD.
        /// </summary>
        public const string DKCRCD = "DKCRCD";

        /// <summary>
        /// DKMDTY.
        /// </summary>
        public const string DKMDTY = "DKMDTY";

        /// <summary>
        /// DKDOST.
        /// </summary>
        public const string DKDOST = "DKDOST";

        /// <summary>
        /// DKDCRS.
        /// </summary>
        public const string DKDCRS = "DKDCRS";

        /// <summary>
        /// DKDOCM.
        /// </summary>
        public const string DKDOCM = "DKDOCM";

        /// <summary>
        /// DKDCTM.
        /// </summary>
        public const string DKDCTM = "DKDCTM";

        /// <summary>
        /// DKSFXM.
        /// </summary>
        public const string DKSFXM = "DKSFXM";

        /// <summary>
        /// DKCARS.
        /// </summary>
        public const string DKCARS = "DKCARS";

        /// <summary>
        /// DKREFQ.
        /// </summary>
        public const string DKREFQ = "DKREFQ";

        /// <summary>
        /// DKREFN.
        /// </summary>
        public const string DKREFN = "DKREFN";

        /// <summary>
        /// DKURCD.
        /// </summary>
        public const string DKURCD = "DKURCD";

        /// <summary>
        /// DKURDT.
        /// </summary>
        public const string DKURDT = "DKURDT";

        /// <summary>
        /// DKURAT.
        /// </summary>
        public const string DKURAT = "DKURAT";

        /// <summary>
        /// DKURAB.
        /// </summary>
        public const string DKURAB = "DKURAB";

        /// <summary>
        /// DKURRF.
        /// </summary>
        public const string DKURRF = "DKURRF";

        /// <summary>
        /// DKUSER.
        /// </summary>
        public const string DKUSER = "DKUSER";

        /// <summary>
        /// DKPID.
        /// </summary>
        public const string DKPID = "DKPID";

        /// <summary>
        /// DKJOBN.
        /// </summary>
        public const string DKJOBN = "DKJOBN";

        /// <summary>
        /// DKUPMJ.
        /// </summary>
        public const string DKUPMJ = "DKUPMJ";

        /// <summary>
        /// DKTDAY.
        /// </summary>
        public const string DKTDAY = "DKTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49595";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DKBN01", "DKBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("DKDCCD", "DKDCCD", JdeDataType.String, 8, true, true),
        new JdeField("DKCO", "DKCO", JdeDataType.String, 10, true, true),
        new JdeField("DKEMCU", "DKEMCU", JdeDataType.String, 24, true, true),
        new JdeField("DKMCU", "DKMCU", JdeDataType.String, 24, true, true),
        new JdeField("DKDCT", "DKDCT", JdeDataType.String, 4, true, true),
        new JdeField("DKDOC", "DKDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DKKCO", "DKKCO", JdeDataType.String, 10),
        new JdeField("DKSDPC", "DKSDPC", JdeDataType.String, 2),
        new JdeField("DKDTDO", "DKDTDO", JdeDataType.Numeric),
        new JdeField("DKMCUZ", "DKMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("DKDPCR", "DKDPCR", JdeDataType.String, 2),
        new JdeField("DKDL01", "DKDL01", JdeDataType.String, 60),
        new JdeField("DKAA", "DKAA", JdeDataType.Numeric),
        new JdeField("DKCDEC", "DKCDEC", JdeDataType.String, 2),
        new JdeField("DKCRCD", "DKCRCD", JdeDataType.String, 6),
        new JdeField("DKMDTY", "DKMDTY", JdeDataType.String, 2),
        new JdeField("DKDOST", "DKDOST", JdeDataType.String, 4),
        new JdeField("DKDCRS", "DKDCRS", JdeDataType.String, 4),
        new JdeField("DKDOCM", "DKDOCM", JdeDataType.Numeric),
        new JdeField("DKDCTM", "DKDCTM", JdeDataType.String, 4),
        new JdeField("DKSFXM", "DKSFXM", JdeDataType.String, 6),
        new JdeField("DKCARS", "DKCARS", JdeDataType.Numeric),
        new JdeField("DKREFQ", "DKREFQ", JdeDataType.String, 4),
        new JdeField("DKREFN", "DKREFN", JdeDataType.String, 60),
        new JdeField("DKURCD", "DKURCD", JdeDataType.String, 4),
        new JdeField("DKURDT", "DKURDT", JdeDataType.Numeric),
        new JdeField("DKURAT", "DKURAT", JdeDataType.Numeric),
        new JdeField("DKURAB", "DKURAB", JdeDataType.Numeric),
        new JdeField("DKURRF", "DKURRF", JdeDataType.String, 30),
        new JdeField("DKUSER", "DKUSER", JdeDataType.String, 20),
        new JdeField("DKPID", "DKPID", JdeDataType.String, 20),
        new JdeField("DKJOBN", "DKJOBN", JdeDataType.String, 20),
        new JdeField("DKUPMJ", "DKUPMJ", JdeDataType.Numeric),
        new JdeField("DKTDAY", "DKTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49595_0", "Primary Key on DKBN01, DKMCUZ, DKDCCD, DKCO, DKEMCU, DKMCU, DKDCT, DKDOC", new[] { "DKBN01", "DKMCUZ", "DKDCCD", "DKCO", "DKEMCU", "DKMCU", "DKDCT", "DKDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49595_2", "Index on DKBN01, DKMCUZ, DKDCCD, DKCO, DKEMCU, DKMCU, DKDCT, SYS_NC00036$", new[] { "DKBN01", "DKMCUZ", "DKDCCD", "DKCO", "DKEMCU", "DKMCU", "DKDCT", "SYS_NC00036$" }),
        new JdeIndex("F49595_3", "Index on DKBN01, DKMCUZ, DKDCCD, DKCO, DKEMCU, DKMCU, DKDCTM, DKDOCM", new[] { "DKBN01", "DKMCUZ", "DKDCCD", "DKCO", "DKEMCU", "DKMCU", "DKDCTM", "DKDOCM" })
    };
}
