using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T42W - .
/// </summary>
public class F75T42W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// SWLNID.
        /// </summary>
        public const string SWLNID = "SWLNID";

        /// <summary>
        /// SWCO.
        /// </summary>
        public const string SWCO = "SWCO";

        /// <summary>
        /// SWMCU.
        /// </summary>
        public const string SWMCU = "SWMCU";

        /// <summary>
        /// SWAN8.
        /// </summary>
        public const string SWAN8 = "SWAN8";

        /// <summary>
        /// SWSHAN.
        /// </summary>
        public const string SWSHAN = "SWSHAN";

        /// <summary>
        /// SWPA8.
        /// </summary>
        public const string SWPA8 = "SWPA8";

        /// <summary>
        /// SWDRQJ.
        /// </summary>
        public const string SWDRQJ = "SWDRQJ";

        /// <summary>
        /// SWTRDJ.
        /// </summary>
        public const string SWTRDJ = "SWTRDJ";

        /// <summary>
        /// SWIVD.
        /// </summary>
        public const string SWIVD = "SWIVD";

        /// <summary>
        /// SWDGL.
        /// </summary>
        public const string SWDGL = "SWDGL";

        /// <summary>
        /// SWITM.
        /// </summary>
        public const string SWITM = "SWITM";

        /// <summary>
        /// SWLITM.
        /// </summary>
        public const string SWLITM = "SWLITM";

        /// <summary>
        /// SWAITM.
        /// </summary>
        public const string SWAITM = "SWAITM";

        /// <summary>
        /// SWLNTY.
        /// </summary>
        public const string SWLNTY = "SWLNTY";

        /// <summary>
        /// SWDSC1.
        /// </summary>
        public const string SWDSC1 = "SWDSC1";

        /// <summary>
        /// SWDSC2.
        /// </summary>
        public const string SWDSC2 = "SWDSC2";

        /// <summary>
        /// SWLTTR.
        /// </summary>
        public const string SWLTTR = "SWLTTR";

        /// <summary>
        /// SWNXTR.
        /// </summary>
        public const string SWNXTR = "SWNXTR";

        /// <summary>
        /// SWUORG.
        /// </summary>
        public const string SWUORG = "SWUORG";

        /// <summary>
        /// SWUOM.
        /// </summary>
        public const string SWUOM = "SWUOM";

        /// <summary>
        /// SWUPRC.
        /// </summary>
        public const string SWUPRC = "SWUPRC";

        /// <summary>
        /// SWAEXP.
        /// </summary>
        public const string SWAEXP = "SWAEXP";

        /// <summary>
        /// SWKCO.
        /// </summary>
        public const string SWKCO = "SWKCO";

        /// <summary>
        /// SWDOC.
        /// </summary>
        public const string SWDOC = "SWDOC";

        /// <summary>
        /// SWDCT.
        /// </summary>
        public const string SWDCT = "SWDCT";

        /// <summary>
        /// SWTAX1.
        /// </summary>
        public const string SWTAX1 = "SWTAX1";

        /// <summary>
        /// SWTXA1.
        /// </summary>
        public const string SWTXA1 = "SWTXA1";

        /// <summary>
        /// SWEXR1.
        /// </summary>
        public const string SWEXR1 = "SWEXR1";

        /// <summary>
        /// SWGLC.
        /// </summary>
        public const string SWGLC = "SWGLC";

        /// <summary>
        /// SWURRF.
        /// </summary>
        public const string SWURRF = "SWURRF";

        /// <summary>
        /// SWUSER.
        /// </summary>
        public const string SWUSER = "SWUSER";

        /// <summary>
        /// SWSOQS.
        /// </summary>
        public const string SWSOQS = "SWSOQS";

        /// <summary>
        /// SWUOM4.
        /// </summary>
        public const string SWUOM4 = "SWUOM4";

        /// <summary>
        /// SWCRCD.
        /// </summary>
        public const string SWCRCD = "SWCRCD";

        /// <summary>
        /// SWCRR.
        /// </summary>
        public const string SWCRR = "SWCRR";

        /// <summary>
        /// SWFUP.
        /// </summary>
        public const string SWFUP = "SWFUP";

        /// <summary>
        /// SWFEA.
        /// </summary>
        public const string SWFEA = "SWFEA";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWTDAY.
        /// </summary>
        public const string SWTDAY = "SWTDAY";

        /// <summary>
        /// SWJOBN.
        /// </summary>
        public const string SWJOBN = "SWJOBN";

        /// <summary>
        /// SWUSR0.
        /// </summary>
        public const string SWUSR0 = "SWUSR0";
    }

    /// <inheritdoc />
    public override string TableName => "F75T42W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWKCOO", "SWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SWDOCO", "SWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SWDCTO", "SWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SWLNID", "SWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SWCO", "SWCO", JdeDataType.String, 10),
        new JdeField("SWMCU", "SWMCU", JdeDataType.String, 24),
        new JdeField("SWAN8", "SWAN8", JdeDataType.Numeric),
        new JdeField("SWSHAN", "SWSHAN", JdeDataType.Numeric),
        new JdeField("SWPA8", "SWPA8", JdeDataType.Numeric),
        new JdeField("SWDRQJ", "SWDRQJ", JdeDataType.Numeric),
        new JdeField("SWTRDJ", "SWTRDJ", JdeDataType.Numeric),
        new JdeField("SWIVD", "SWIVD", JdeDataType.Numeric),
        new JdeField("SWDGL", "SWDGL", JdeDataType.Numeric),
        new JdeField("SWITM", "SWITM", JdeDataType.Numeric),
        new JdeField("SWLITM", "SWLITM", JdeDataType.String, 50),
        new JdeField("SWAITM", "SWAITM", JdeDataType.String, 50),
        new JdeField("SWLNTY", "SWLNTY", JdeDataType.String, 4),
        new JdeField("SWDSC1", "SWDSC1", JdeDataType.String, 60),
        new JdeField("SWDSC2", "SWDSC2", JdeDataType.String, 60),
        new JdeField("SWLTTR", "SWLTTR", JdeDataType.String, 6),
        new JdeField("SWNXTR", "SWNXTR", JdeDataType.String, 6),
        new JdeField("SWUORG", "SWUORG", JdeDataType.Numeric),
        new JdeField("SWUOM", "SWUOM", JdeDataType.String, 4),
        new JdeField("SWUPRC", "SWUPRC", JdeDataType.Numeric),
        new JdeField("SWAEXP", "SWAEXP", JdeDataType.Numeric),
        new JdeField("SWKCO", "SWKCO", JdeDataType.String, 10),
        new JdeField("SWDOC", "SWDOC", JdeDataType.Numeric),
        new JdeField("SWDCT", "SWDCT", JdeDataType.String, 4),
        new JdeField("SWTAX1", "SWTAX1", JdeDataType.String, 2),
        new JdeField("SWTXA1", "SWTXA1", JdeDataType.String, 20),
        new JdeField("SWEXR1", "SWEXR1", JdeDataType.String, 4),
        new JdeField("SWGLC", "SWGLC", JdeDataType.String, 8),
        new JdeField("SWURRF", "SWURRF", JdeDataType.String, 30),
        new JdeField("SWUSER", "SWUSER", JdeDataType.String, 20),
        new JdeField("SWSOQS", "SWSOQS", JdeDataType.Numeric),
        new JdeField("SWUOM4", "SWUOM4", JdeDataType.String, 4),
        new JdeField("SWCRCD", "SWCRCD", JdeDataType.String, 6),
        new JdeField("SWCRR", "SWCRR", JdeDataType.Numeric),
        new JdeField("SWFUP", "SWFUP", JdeDataType.Numeric),
        new JdeField("SWFEA", "SWFEA", JdeDataType.Numeric),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWTDAY", "SWTDAY", JdeDataType.Numeric),
        new JdeField("SWJOBN", "SWJOBN", JdeDataType.String, 20),
        new JdeField("SWUSR0", "SWUSR0", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T42W_0", "Primary Key on SWKCOO, SWDOCO, SWDCTO, SWLNID", new[] { "SWKCOO", "SWDOCO", "SWDCTO", "SWLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
