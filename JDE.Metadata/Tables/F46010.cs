using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46010 - .
/// </summary>
public class F46010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IPMCU.
        /// </summary>
        public const string IPMCU = "IPMCU";

        /// <summary>
        /// IPITM.
        /// </summary>
        public const string IPITM = "IPITM";

        /// <summary>
        /// IPMLIT.
        /// </summary>
        public const string IPMLIT = "IPMLIT";

        /// <summary>
        /// IPMLOT.
        /// </summary>
        public const string IPMLOT = "IPMLOT";

        /// <summary>
        /// IPSPLP.
        /// </summary>
        public const string IPSPLP = "IPSPLP";

        /// <summary>
        /// IPPTPH.
        /// </summary>
        public const string IPPTPH = "IPPTPH";

        /// <summary>
        /// IPPKPH.
        /// </summary>
        public const string IPPKPH = "IPPKPH";

        /// <summary>
        /// IPRPPH.
        /// </summary>
        public const string IPRPPH = "IPRPPH";

        /// <summary>
        /// IPLCOD.
        /// </summary>
        public const string IPLCOD = "IPLCOD";

        /// <summary>
        /// IPDLTN.
        /// </summary>
        public const string IPDLTN = "IPDLTN";

        /// <summary>
        /// IPDEFI.
        /// </summary>
        public const string IPDEFI = "IPDEFI";

        /// <summary>
        /// IPVLOC.
        /// </summary>
        public const string IPVLOC = "IPVLOC";

        /// <summary>
        /// IPHLOC.
        /// </summary>
        public const string IPHLOC = "IPHLOC";

        /// <summary>
        /// IPPPUT.
        /// </summary>
        public const string IPPPUT = "IPPPUT";

        /// <summary>
        /// IPPPIK.
        /// </summary>
        public const string IPPPIK = "IPPPIK";

        /// <summary>
        /// IPPRLC.
        /// </summary>
        public const string IPPRLC = "IPPRLC";

        /// <summary>
        /// IPURCD.
        /// </summary>
        public const string IPURCD = "IPURCD";

        /// <summary>
        /// IPURDT.
        /// </summary>
        public const string IPURDT = "IPURDT";

        /// <summary>
        /// IPURAT.
        /// </summary>
        public const string IPURAT = "IPURAT";

        /// <summary>
        /// IPURAB.
        /// </summary>
        public const string IPURAB = "IPURAB";

        /// <summary>
        /// IPURRF.
        /// </summary>
        public const string IPURRF = "IPURRF";

        /// <summary>
        /// IPUSER.
        /// </summary>
        public const string IPUSER = "IPUSER";

        /// <summary>
        /// IPPID.
        /// </summary>
        public const string IPPID = "IPPID";

        /// <summary>
        /// IPJOBN.
        /// </summary>
        public const string IPJOBN = "IPJOBN";

        /// <summary>
        /// IPTDAY.
        /// </summary>
        public const string IPTDAY = "IPTDAY";

        /// <summary>
        /// IPUPMJ.
        /// </summary>
        public const string IPUPMJ = "IPUPMJ";

        /// <summary>
        /// IPMPTL.
        /// </summary>
        public const string IPMPTL = "IPMPTL";

        /// <summary>
        /// IPMUMS.
        /// </summary>
        public const string IPMUMS = "IPMUMS";

        /// <summary>
        /// IPFIFR.
        /// </summary>
        public const string IPFIFR = "IPFIFR";
    }

    /// <inheritdoc />
    public override string TableName => "F46010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IPMCU", "IPMCU", JdeDataType.String, 24, true, true),
        new JdeField("IPITM", "IPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IPMLIT", "IPMLIT", JdeDataType.String, 2),
        new JdeField("IPMLOT", "IPMLOT", JdeDataType.String, 2),
        new JdeField("IPSPLP", "IPSPLP", JdeDataType.String, 2),
        new JdeField("IPPTPH", "IPPTPH", JdeDataType.String, 2),
        new JdeField("IPPKPH", "IPPKPH", JdeDataType.String, 2),
        new JdeField("IPRPPH", "IPRPPH", JdeDataType.String, 2),
        new JdeField("IPLCOD", "IPLCOD", JdeDataType.String, 4),
        new JdeField("IPDLTN", "IPDLTN", JdeDataType.String, 40),
        new JdeField("IPDEFI", "IPDEFI", JdeDataType.String, 20),
        new JdeField("IPVLOC", "IPVLOC", JdeDataType.String, 40),
        new JdeField("IPHLOC", "IPHLOC", JdeDataType.String, 40),
        new JdeField("IPPPUT", "IPPPUT", JdeDataType.String, 40),
        new JdeField("IPPPIK", "IPPPIK", JdeDataType.String, 40),
        new JdeField("IPPRLC", "IPPRLC", JdeDataType.String, 40),
        new JdeField("IPURCD", "IPURCD", JdeDataType.String, 4),
        new JdeField("IPURDT", "IPURDT", JdeDataType.Numeric),
        new JdeField("IPURAT", "IPURAT", JdeDataType.Numeric),
        new JdeField("IPURAB", "IPURAB", JdeDataType.Numeric),
        new JdeField("IPURRF", "IPURRF", JdeDataType.String, 30),
        new JdeField("IPUSER", "IPUSER", JdeDataType.String, 20),
        new JdeField("IPPID", "IPPID", JdeDataType.String, 20),
        new JdeField("IPJOBN", "IPJOBN", JdeDataType.String, 20),
        new JdeField("IPTDAY", "IPTDAY", JdeDataType.Numeric),
        new JdeField("IPUPMJ", "IPUPMJ", JdeDataType.Numeric),
        new JdeField("IPMPTL", "IPMPTL", JdeDataType.String, 2),
        new JdeField("IPMUMS", "IPMUMS", JdeDataType.String, 2),
        new JdeField("IPFIFR", "IPFIFR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46010_0", "Primary Key on IPMCU, IPITM", new[] { "IPMCU", "IPITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46010_2", "Index on IPMCU, IPPPUT, IPPPIK", new[] { "IPMCU", "IPPPUT", "IPPPIK" })
    };
}
