using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43092Z1 - .
/// </summary>
public class F43092Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZKCOO.
        /// </summary>
        public const string SZKCOO = "SZKCOO";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZNLIN.
        /// </summary>
        public const string SZNLIN = "SZNLIN";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZNROU.
        /// </summary>
        public const string SZNROU = "SZNROU";

        /// <summary>
        /// SZOPRS.
        /// </summary>
        public const string SZOPRS = "SZOPRS";

        /// <summary>
        /// SZOPRC.
        /// </summary>
        public const string SZOPRC = "SZOPRC";

        /// <summary>
        /// SZTRTY.
        /// </summary>
        public const string SZTRTY = "SZTRTY";

        /// <summary>
        /// SZPDAY.
        /// </summary>
        public const string SZPDAY = "SZPDAY";

        /// <summary>
        /// SZADAY.
        /// </summary>
        public const string SZADAY = "SZADAY";

        /// <summary>
        /// SZUPIB.
        /// </summary>
        public const string SZUPIB = "SZUPIB";

        /// <summary>
        /// SZUPGL.
        /// </summary>
        public const string SZUPGL = "SZUPGL";

        /// <summary>
        /// SZGLPT.
        /// </summary>
        public const string SZGLPT = "SZGLPT";

        /// <summary>
        /// SZRCPT.
        /// </summary>
        public const string SZRCPT = "SZRCPT";

        /// <summary>
        /// SZPMTE.
        /// </summary>
        public const string SZPMTE = "SZPMTE";

        /// <summary>
        /// SZACTO.
        /// </summary>
        public const string SZACTO = "SZACTO";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZQTYO.
        /// </summary>
        public const string SZQTYO = "SZQTYO";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZCNID.
        /// </summary>
        public const string SZCNID = "SZCNID";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZDGL.
        /// </summary>
        public const string SZDGL = "SZDGL";

        /// <summary>
        /// SZQTYM.
        /// </summary>
        public const string SZQTYM = "SZQTYM";

        /// <summary>
        /// SZRCD1.
        /// </summary>
        public const string SZRCD1 = "SZRCD1";

        /// <summary>
        /// SZRCD2.
        /// </summary>
        public const string SZRCD2 = "SZRCD2";

        /// <summary>
        /// SZRCD3.
        /// </summary>
        public const string SZRCD3 = "SZRCD3";

        /// <summary>
        /// SZRCD4.
        /// </summary>
        public const string SZRCD4 = "SZRCD4";

        /// <summary>
        /// SZRCD5.
        /// </summary>
        public const string SZRCD5 = "SZRCD5";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

        /// <summary>
        /// SZTRDJ.
        /// </summary>
        public const string SZTRDJ = "SZTRDJ";

        /// <summary>
        /// SZDRQJ.
        /// </summary>
        public const string SZDRQJ = "SZDRQJ";

        /// <summary>
        /// SZPDDJ.
        /// </summary>
        public const string SZPDDJ = "SZPDDJ";

        /// <summary>
        /// SZLTTR.
        /// </summary>
        public const string SZLTTR = "SZLTTR";

        /// <summary>
        /// SZNXTR.
        /// </summary>
        public const string SZNXTR = "SZNXTR";

        /// <summary>
        /// SZDL01.
        /// </summary>
        public const string SZDL01 = "SZDL01";

        /// <summary>
        /// SZDL02.
        /// </summary>
        public const string SZDL02 = "SZDL02";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

        /// <summary>
        /// SZOPRT.
        /// </summary>
        public const string SZOPRT = "SZOPRT";

        /// <summary>
        /// SZQTYR.
        /// </summary>
        public const string SZQTYR = "SZQTYR";

        /// <summary>
        /// SZQTYW.
        /// </summary>
        public const string SZQTYW = "SZQTYW";

        /// <summary>
        /// SZQTYC.
        /// </summary>
        public const string SZQTYC = "SZQTYC";

        /// <summary>
        /// SZQTYJ.
        /// </summary>
        public const string SZQTYJ = "SZQTYJ";

        /// <summary>
        /// SZQTYA.
        /// </summary>
        public const string SZQTYA = "SZQTYA";

        /// <summary>
        /// SZRPL.
        /// </summary>
        public const string SZRPL = "SZRPL";

        /// <summary>
        /// SZRPLOW1.
        /// </summary>
        public const string SZRPLOW1 = "SZRPLOW1";

        /// <summary>
        /// SZRPLOW2.
        /// </summary>
        public const string SZRPLOW2 = "SZRPLOW2";

        /// <summary>
        /// SZRPLOW3.
        /// </summary>
        public const string SZRPLOW3 = "SZRPLOW3";

        /// <summary>
        /// SZRPLOW4.
        /// </summary>
        public const string SZRPLOW4 = "SZRPLOW4";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43092Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZNLIN", "SZNLIN", JdeDataType.Numeric),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZNROU", "SZNROU", JdeDataType.String, 8),
        new JdeField("SZOPRS", "SZOPRS", JdeDataType.Numeric),
        new JdeField("SZOPRC", "SZOPRC", JdeDataType.String, 8),
        new JdeField("SZTRTY", "SZTRTY", JdeDataType.String, 6),
        new JdeField("SZPDAY", "SZPDAY", JdeDataType.Numeric),
        new JdeField("SZADAY", "SZADAY", JdeDataType.Numeric),
        new JdeField("SZUPIB", "SZUPIB", JdeDataType.String, 8),
        new JdeField("SZUPGL", "SZUPGL", JdeDataType.String, 2),
        new JdeField("SZGLPT", "SZGLPT", JdeDataType.String, 8),
        new JdeField("SZRCPT", "SZRCPT", JdeDataType.String, 2),
        new JdeField("SZPMTE", "SZPMTE", JdeDataType.String, 2),
        new JdeField("SZACTO", "SZACTO", JdeDataType.String, 2),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZQTYO", "SZQTYO", JdeDataType.Numeric),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZCNID", "SZCNID", JdeDataType.String, 40),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZDGL", "SZDGL", JdeDataType.Numeric),
        new JdeField("SZQTYM", "SZQTYM", JdeDataType.Numeric),
        new JdeField("SZRCD1", "SZRCD1", JdeDataType.String, 6),
        new JdeField("SZRCD2", "SZRCD2", JdeDataType.String, 6),
        new JdeField("SZRCD3", "SZRCD3", JdeDataType.String, 6),
        new JdeField("SZRCD4", "SZRCD4", JdeDataType.String, 6),
        new JdeField("SZRCD5", "SZRCD5", JdeDataType.String, 6),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZDRQJ", "SZDRQJ", JdeDataType.Numeric),
        new JdeField("SZPDDJ", "SZPDDJ", JdeDataType.Numeric),
        new JdeField("SZLTTR", "SZLTTR", JdeDataType.String, 6),
        new JdeField("SZNXTR", "SZNXTR", JdeDataType.String, 6),
        new JdeField("SZDL01", "SZDL01", JdeDataType.String, 60),
        new JdeField("SZDL02", "SZDL02", JdeDataType.String, 60),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZOPRT", "SZOPRT", JdeDataType.String, 8),
        new JdeField("SZQTYR", "SZQTYR", JdeDataType.Numeric),
        new JdeField("SZQTYW", "SZQTYW", JdeDataType.Numeric),
        new JdeField("SZQTYC", "SZQTYC", JdeDataType.Numeric),
        new JdeField("SZQTYJ", "SZQTYJ", JdeDataType.Numeric),
        new JdeField("SZQTYA", "SZQTYA", JdeDataType.Numeric),
        new JdeField("SZRPL", "SZRPL", JdeDataType.String, 2),
        new JdeField("SZRPLOW1", "SZRPLOW1", JdeDataType.String, 2),
        new JdeField("SZRPLOW2", "SZRPLOW2", JdeDataType.String, 2),
        new JdeField("SZRPLOW3", "SZRPLOW3", JdeDataType.String, 2),
        new JdeField("SZRPLOW4", "SZRPLOW4", JdeDataType.String, 2),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43092Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
