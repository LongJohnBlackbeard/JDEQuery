using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47044 - .
/// </summary>
public class F47044 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWEDTY.
        /// </summary>
        public const string SWEDTY = "SWEDTY";

        /// <summary>
        /// SWEDSQ.
        /// </summary>
        public const string SWEDSQ = "SWEDSQ";

        /// <summary>
        /// SWEKCO.
        /// </summary>
        public const string SWEKCO = "SWEKCO";

        /// <summary>
        /// SWEDOC.
        /// </summary>
        public const string SWEDOC = "SWEDOC";

        /// <summary>
        /// SWEDCT.
        /// </summary>
        public const string SWEDCT = "SWEDCT";

        /// <summary>
        /// SWEDLN.
        /// </summary>
        public const string SWEDLN = "SWEDLN";

        /// <summary>
        /// SWEDST.
        /// </summary>
        public const string SWEDST = "SWEDST";

        /// <summary>
        /// SWEDFT.
        /// </summary>
        public const string SWEDFT = "SWEDFT";

        /// <summary>
        /// SWEDDT.
        /// </summary>
        public const string SWEDDT = "SWEDDT";

        /// <summary>
        /// SWEDER.
        /// </summary>
        public const string SWEDER = "SWEDER";

        /// <summary>
        /// SWEDDL.
        /// </summary>
        public const string SWEDDL = "SWEDDL";

        /// <summary>
        /// SWEDSP.
        /// </summary>
        public const string SWEDSP = "SWEDSP";

        /// <summary>
        /// SWEDBT.
        /// </summary>
        public const string SWEDBT = "SWEDBT";

        /// <summary>
        /// SWPNID.
        /// </summary>
        public const string SWPNID = "SWPNID";

        /// <summary>
        /// SWCO.
        /// </summary>
        public const string SWCO = "SWCO";

        /// <summary>
        /// SWKCOO.
        /// </summary>
        public const string SWKCOO = "SWKCOO";

        /// <summary>
        /// SWDOCO.
        /// </summary>
        public const string SWDOCO = "SWDOCO";

        /// <summary>
        /// SWDCTO.
        /// </summary>
        public const string SWDCTO = "SWDCTO";

        /// <summary>
        /// SWSFXO.
        /// </summary>
        public const string SWSFXO = "SWSFXO";

        /// <summary>
        /// SWKCO.
        /// </summary>
        public const string SWKCO = "SWKCO";

        /// <summary>
        /// SWDOC.
        /// </summary>
        public const string SWDOC = "SWDOC";

        /// <summary>
        /// SWDCTV.
        /// </summary>
        public const string SWDCTV = "SWDCTV";

        /// <summary>
        /// SWAN8.
        /// </summary>
        public const string SWAN8 = "SWAN8";

        /// <summary>
        /// SWVINV.
        /// </summary>
        public const string SWVINV = "SWVINV";

        /// <summary>
        /// SWUOPN.
        /// </summary>
        public const string SWUOPN = "SWUOPN";

        /// <summary>
        /// SWAEXP.
        /// </summary>
        public const string SWAEXP = "SWAEXP";

        /// <summary>
        /// SWAG.
        /// </summary>
        public const string SWAG = "SWAG";

        /// <summary>
        /// SWAAP.
        /// </summary>
        public const string SWAAP = "SWAAP";

        /// <summary>
        /// SWADSC.
        /// </summary>
        public const string SWADSC = "SWADSC";

        /// <summary>
        /// SWADSA.
        /// </summary>
        public const string SWADSA = "SWADSA";

        /// <summary>
        /// SWATXA.
        /// </summary>
        public const string SWATXA = "SWATXA";

        /// <summary>
        /// SWATXN.
        /// </summary>
        public const string SWATXN = "SWATXN";

        /// <summary>
        /// SWSTAM.
        /// </summary>
        public const string SWSTAM = "SWSTAM";

        /// <summary>
        /// SWCRRM.
        /// </summary>
        public const string SWCRRM = "SWCRRM";

        /// <summary>
        /// SWCRCD.
        /// </summary>
        public const string SWCRCD = "SWCRCD";

        /// <summary>
        /// SWCRR.
        /// </summary>
        public const string SWCRR = "SWCRR";

        /// <summary>
        /// SWFEA.
        /// </summary>
        public const string SWFEA = "SWFEA";

        /// <summary>
        /// SWACR.
        /// </summary>
        public const string SWACR = "SWACR";

        /// <summary>
        /// SWFAP.
        /// </summary>
        public const string SWFAP = "SWFAP";

        /// <summary>
        /// SWCDS.
        /// </summary>
        public const string SWCDS = "SWCDS";

        /// <summary>
        /// SWCDSA.
        /// </summary>
        public const string SWCDSA = "SWCDSA";

        /// <summary>
        /// SWCTAM.
        /// </summary>
        public const string SWCTAM = "SWCTAM";

        /// <summary>
        /// SWCTXN.
        /// </summary>
        public const string SWCTXN = "SWCTXN";

        /// <summary>
        /// SWCTXA.
        /// </summary>
        public const string SWCTXA = "SWCTXA";

        /// <summary>
        /// SWURCD.
        /// </summary>
        public const string SWURCD = "SWURCD";

        /// <summary>
        /// SWURDT.
        /// </summary>
        public const string SWURDT = "SWURDT";

        /// <summary>
        /// SWURAT.
        /// </summary>
        public const string SWURAT = "SWURAT";

        /// <summary>
        /// SWURAB.
        /// </summary>
        public const string SWURAB = "SWURAB";

        /// <summary>
        /// SWURRF.
        /// </summary>
        public const string SWURRF = "SWURRF";

        /// <summary>
        /// SWTORG.
        /// </summary>
        public const string SWTORG = "SWTORG";

        /// <summary>
        /// SWUSER.
        /// </summary>
        public const string SWUSER = "SWUSER";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWJOBN.
        /// </summary>
        public const string SWJOBN = "SWJOBN";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWTDAY.
        /// </summary>
        public const string SWTDAY = "SWTDAY";

        /// <summary>
        /// SWGAN8.
        /// </summary>
        public const string SWGAN8 = "SWGAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F47044";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWEDTY", "SWEDTY", JdeDataType.String, 2),
        new JdeField("SWEDSQ", "SWEDSQ", JdeDataType.Numeric),
        new JdeField("SWEKCO", "SWEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SWEDOC", "SWEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SWEDCT", "SWEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SWEDLN", "SWEDLN", JdeDataType.Numeric),
        new JdeField("SWEDST", "SWEDST", JdeDataType.String, 12),
        new JdeField("SWEDFT", "SWEDFT", JdeDataType.String, 20),
        new JdeField("SWEDDT", "SWEDDT", JdeDataType.Numeric),
        new JdeField("SWEDER", "SWEDER", JdeDataType.String, 2),
        new JdeField("SWEDDL", "SWEDDL", JdeDataType.Numeric),
        new JdeField("SWEDSP", "SWEDSP", JdeDataType.String, 2),
        new JdeField("SWEDBT", "SWEDBT", JdeDataType.String, 30),
        new JdeField("SWPNID", "SWPNID", JdeDataType.String, 30),
        new JdeField("SWCO", "SWCO", JdeDataType.String, 10),
        new JdeField("SWKCOO", "SWKCOO", JdeDataType.String, 10),
        new JdeField("SWDOCO", "SWDOCO", JdeDataType.Numeric),
        new JdeField("SWDCTO", "SWDCTO", JdeDataType.String, 4),
        new JdeField("SWSFXO", "SWSFXO", JdeDataType.String, 6),
        new JdeField("SWKCO", "SWKCO", JdeDataType.String, 10),
        new JdeField("SWDOC", "SWDOC", JdeDataType.Numeric),
        new JdeField("SWDCTV", "SWDCTV", JdeDataType.String, 4),
        new JdeField("SWAN8", "SWAN8", JdeDataType.Numeric),
        new JdeField("SWVINV", "SWVINV", JdeDataType.String, 50),
        new JdeField("SWUOPN", "SWUOPN", JdeDataType.Numeric),
        new JdeField("SWAEXP", "SWAEXP", JdeDataType.Numeric),
        new JdeField("SWAG", "SWAG", JdeDataType.Numeric),
        new JdeField("SWAAP", "SWAAP", JdeDataType.Numeric),
        new JdeField("SWADSC", "SWADSC", JdeDataType.Numeric),
        new JdeField("SWADSA", "SWADSA", JdeDataType.Numeric),
        new JdeField("SWATXA", "SWATXA", JdeDataType.Numeric),
        new JdeField("SWATXN", "SWATXN", JdeDataType.Numeric),
        new JdeField("SWSTAM", "SWSTAM", JdeDataType.Numeric),
        new JdeField("SWCRRM", "SWCRRM", JdeDataType.String, 2),
        new JdeField("SWCRCD", "SWCRCD", JdeDataType.String, 6),
        new JdeField("SWCRR", "SWCRR", JdeDataType.Numeric),
        new JdeField("SWFEA", "SWFEA", JdeDataType.Numeric),
        new JdeField("SWACR", "SWACR", JdeDataType.Numeric),
        new JdeField("SWFAP", "SWFAP", JdeDataType.Numeric),
        new JdeField("SWCDS", "SWCDS", JdeDataType.Numeric),
        new JdeField("SWCDSA", "SWCDSA", JdeDataType.Numeric),
        new JdeField("SWCTAM", "SWCTAM", JdeDataType.Numeric),
        new JdeField("SWCTXN", "SWCTXN", JdeDataType.Numeric),
        new JdeField("SWCTXA", "SWCTXA", JdeDataType.Numeric),
        new JdeField("SWURCD", "SWURCD", JdeDataType.String, 4),
        new JdeField("SWURDT", "SWURDT", JdeDataType.Numeric),
        new JdeField("SWURAT", "SWURAT", JdeDataType.Numeric),
        new JdeField("SWURAB", "SWURAB", JdeDataType.Numeric),
        new JdeField("SWURRF", "SWURRF", JdeDataType.String, 30),
        new JdeField("SWTORG", "SWTORG", JdeDataType.String, 20),
        new JdeField("SWUSER", "SWUSER", JdeDataType.String, 20),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWJOBN", "SWJOBN", JdeDataType.String, 20),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWTDAY", "SWTDAY", JdeDataType.Numeric),
        new JdeField("SWGAN8", "SWGAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47044_0", "Primary Key on SWEDOC, SWEDCT, SWEKCO", new[] { "SWEDOC", "SWEDCT", "SWEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
