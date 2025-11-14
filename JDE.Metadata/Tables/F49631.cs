using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49631 - .
/// </summary>
public class F49631 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TODOC.
        /// </summary>
        public const string TODOC = "TODOC";

        /// <summary>
        /// TODCT.
        /// </summary>
        public const string TODCT = "TODCT";

        /// <summary>
        /// TOKCO.
        /// </summary>
        public const string TOKCO = "TOKCO";

        /// <summary>
        /// TOJELN.
        /// </summary>
        public const string TOJELN = "TOJELN";

        /// <summary>
        /// TOVMCU.
        /// </summary>
        public const string TOVMCU = "TOVMCU";

        /// <summary>
        /// TOLDNM.
        /// </summary>
        public const string TOLDNM = "TOLDNM";

        /// <summary>
        /// TOTRPL.
        /// </summary>
        public const string TOTRPL = "TOTRPL";

        /// <summary>
        /// TOSHPN.
        /// </summary>
        public const string TOSHPN = "TOSHPN";

        /// <summary>
        /// TOITLT.
        /// </summary>
        public const string TOITLT = "TOITLT";

        /// <summary>
        /// TOVEHI.
        /// </summary>
        public const string TOVEHI = "TOVEHI";

        /// <summary>
        /// TORLNO.
        /// </summary>
        public const string TORLNO = "TORLNO";

        /// <summary>
        /// TOCMPN.
        /// </summary>
        public const string TOCMPN = "TOCMPN";

        /// <summary>
        /// TOVTYP.
        /// </summary>
        public const string TOVTYP = "TOVTYP";

        /// <summary>
        /// TOCNNV.
        /// </summary>
        public const string TOCNNV = "TOCNNV";

        /// <summary>
        /// TOOSEQ.
        /// </summary>
        public const string TOOSEQ = "TOOSEQ";

        /// <summary>
        /// TOPVEH.
        /// </summary>
        public const string TOPVEH = "TOPVEH";

        /// <summary>
        /// TOPRLO.
        /// </summary>
        public const string TOPRLO = "TOPRLO";

        /// <summary>
        /// TOLCMP.
        /// </summary>
        public const string TOLCMP = "TOLCMP";

        /// <summary>
        /// TOCARS.
        /// </summary>
        public const string TOCARS = "TOCARS";

        /// <summary>
        /// TOMOT.
        /// </summary>
        public const string TOMOT = "TOMOT";

        /// <summary>
        /// TODGL.
        /// </summary>
        public const string TODGL = "TODGL";

        /// <summary>
        /// TOICU.
        /// </summary>
        public const string TOICU = "TOICU";

        /// <summary>
        /// TODOCO.
        /// </summary>
        public const string TODOCO = "TODOCO";

        /// <summary>
        /// TODCTO.
        /// </summary>
        public const string TODCTO = "TODCTO";

        /// <summary>
        /// TOKCOO.
        /// </summary>
        public const string TOKCOO = "TOKCOO";

        /// <summary>
        /// TOLNID.
        /// </summary>
        public const string TOLNID = "TOLNID";

        /// <summary>
        /// TOSRCO.
        /// </summary>
        public const string TOSRCO = "TOSRCO";

        /// <summary>
        /// TOTRDJ.
        /// </summary>
        public const string TOTRDJ = "TOTRDJ";

        /// <summary>
        /// TORCD.
        /// </summary>
        public const string TORCD = "TORCD";

        /// <summary>
        /// TOGLRS.
        /// </summary>
        public const string TOGLRS = "TOGLRS";

        /// <summary>
        /// TOMCU.
        /// </summary>
        public const string TOMCU = "TOMCU";

        /// <summary>
        /// TOITM.
        /// </summary>
        public const string TOITM = "TOITM";

        /// <summary>
        /// TOLOTN.
        /// </summary>
        public const string TOLOTN = "TOLOTN";

        /// <summary>
        /// TOAN8.
        /// </summary>
        public const string TOAN8 = "TOAN8";

        /// <summary>
        /// TOLOCN.
        /// </summary>
        public const string TOLOCN = "TOLOCN";

        /// <summary>
        /// TOLOTT.
        /// </summary>
        public const string TOLOTT = "TOLOTT";

        /// <summary>
        /// TORITM.
        /// </summary>
        public const string TORITM = "TORITM";

        /// <summary>
        /// TOKTFG.
        /// </summary>
        public const string TOKTFG = "TOKTFG";

        /// <summary>
        /// TOACLQ.
        /// </summary>
        public const string TOACLQ = "TOACLQ";

        /// <summary>
        /// TOTRUM.
        /// </summary>
        public const string TOTRUM = "TOTRUM";

        /// <summary>
        /// TOSTUM.
        /// </summary>
        public const string TOSTUM = "TOSTUM";

        /// <summary>
        /// TOBUM6.
        /// </summary>
        public const string TOBUM6 = "TOBUM6";

        /// <summary>
        /// TOTEMP.
        /// </summary>
        public const string TOTEMP = "TOTEMP";

        /// <summary>
        /// TOSTPU.
        /// </summary>
        public const string TOSTPU = "TOSTPU";

        /// <summary>
        /// TODEND.
        /// </summary>
        public const string TODEND = "TODEND";

        /// <summary>
        /// TODNTP.
        /// </summary>
        public const string TODNTP = "TODNTP";

        /// <summary>
        /// TODETP.
        /// </summary>
        public const string TODETP = "TODETP";

        /// <summary>
        /// TODTPU.
        /// </summary>
        public const string TODTPU = "TODTPU";

        /// <summary>
        /// TOAMBR.
        /// </summary>
        public const string TOAMBR = "TOAMBR";

        /// <summary>
        /// TOBUM3.
        /// </summary>
        public const string TOBUM3 = "TOBUM3";

        /// <summary>
        /// TOSTOK.
        /// </summary>
        public const string TOSTOK = "TOSTOK";

        /// <summary>
        /// TOBUM4.
        /// </summary>
        public const string TOBUM4 = "TOBUM4";

        /// <summary>
        /// TOWGTR.
        /// </summary>
        public const string TOWGTR = "TOWGTR";

        /// <summary>
        /// TOBUM5.
        /// </summary>
        public const string TOBUM5 = "TOBUM5";

        /// <summary>
        /// TOVCF.
        /// </summary>
        public const string TOVCF = "TOVCF";

        /// <summary>
        /// TOUNCS.
        /// </summary>
        public const string TOUNCS = "TOUNCS";

        /// <summary>
        /// TOECST.
        /// </summary>
        public const string TOECST = "TOECST";

        /// <summary>
        /// TODMCT.
        /// </summary>
        public const string TODMCT = "TODMCT";

        /// <summary>
        /// TODMCS.
        /// </summary>
        public const string TODMCS = "TODMCS";

        /// <summary>
        /// TOBALU.
        /// </summary>
        public const string TOBALU = "TOBALU";

        /// <summary>
        /// TOCMOO.
        /// </summary>
        public const string TOCMOO = "TOCMOO";

        /// <summary>
        /// TORDTM.
        /// </summary>
        public const string TORDTM = "TORDTM";

        /// <summary>
        /// TODTE.
        /// </summary>
        public const string TODTE = "TODTE";

        /// <summary>
        /// TOMETN.
        /// </summary>
        public const string TOMETN = "TOMETN";

        /// <summary>
        /// TOOPNR.
        /// </summary>
        public const string TOOPNR = "TOOPNR";

        /// <summary>
        /// TOPNCR.
        /// </summary>
        public const string TOPNCR = "TOPNCR";

        /// <summary>
        /// TOBFWT.
        /// </summary>
        public const string TOBFWT = "TOBFWT";

        /// <summary>
        /// TOBWTU.
        /// </summary>
        public const string TOBWTU = "TOBWTU";

        /// <summary>
        /// TOAFWT.
        /// </summary>
        public const string TOAFWT = "TOAFWT";

        /// <summary>
        /// TOAWTU.
        /// </summary>
        public const string TOAWTU = "TOAWTU";

        /// <summary>
        /// TOSVPF.
        /// </summary>
        public const string TOSVPF = "TOSVPF";

        /// <summary>
        /// TOSVPD.
        /// </summary>
        public const string TOSVPD = "TOSVPD";

        /// <summary>
        /// TOLMCU.
        /// </summary>
        public const string TOLMCU = "TOLMCU";

        /// <summary>
        /// TOLTRP.
        /// </summary>
        public const string TOLTRP = "TOLTRP";

        /// <summary>
        /// TOSHAN.
        /// </summary>
        public const string TOSHAN = "TOSHAN";

        /// <summary>
        /// TOUKID.
        /// </summary>
        public const string TOUKID = "TOUKID";

        /// <summary>
        /// TOURCD.
        /// </summary>
        public const string TOURCD = "TOURCD";

        /// <summary>
        /// TOURDT.
        /// </summary>
        public const string TOURDT = "TOURDT";

        /// <summary>
        /// TOURAT.
        /// </summary>
        public const string TOURAT = "TOURAT";

        /// <summary>
        /// TOURAB.
        /// </summary>
        public const string TOURAB = "TOURAB";

        /// <summary>
        /// TOURRF.
        /// </summary>
        public const string TOURRF = "TOURRF";

        /// <summary>
        /// TOUSER.
        /// </summary>
        public const string TOUSER = "TOUSER";

        /// <summary>
        /// TOPID.
        /// </summary>
        public const string TOPID = "TOPID";

        /// <summary>
        /// TOJOBN.
        /// </summary>
        public const string TOJOBN = "TOJOBN";

        /// <summary>
        /// TOUPMJ.
        /// </summary>
        public const string TOUPMJ = "TOUPMJ";

        /// <summary>
        /// TOTDAY.
        /// </summary>
        public const string TOTDAY = "TOTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49631";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TODOC", "TODOC", JdeDataType.Numeric),
        new JdeField("TODCT", "TODCT", JdeDataType.String, 4),
        new JdeField("TOKCO", "TOKCO", JdeDataType.String, 10),
        new JdeField("TOJELN", "TOJELN", JdeDataType.Numeric),
        new JdeField("TOVMCU", "TOVMCU", JdeDataType.String, 24),
        new JdeField("TOLDNM", "TOLDNM", JdeDataType.Numeric),
        new JdeField("TOTRPL", "TOTRPL", JdeDataType.Numeric),
        new JdeField("TOSHPN", "TOSHPN", JdeDataType.Numeric),
        new JdeField("TOITLT", "TOITLT", JdeDataType.Numeric),
        new JdeField("TOVEHI", "TOVEHI", JdeDataType.String, 24),
        new JdeField("TORLNO", "TORLNO", JdeDataType.String, 26),
        new JdeField("TOCMPN", "TOCMPN", JdeDataType.Numeric),
        new JdeField("TOVTYP", "TOVTYP", JdeDataType.String, 24),
        new JdeField("TOCNNV", "TOCNNV", JdeDataType.String, 2),
        new JdeField("TOOSEQ", "TOOSEQ", JdeDataType.Numeric),
        new JdeField("TOPVEH", "TOPVEH", JdeDataType.String, 24),
        new JdeField("TOPRLO", "TOPRLO", JdeDataType.String, 26),
        new JdeField("TOLCMP", "TOLCMP", JdeDataType.Numeric),
        new JdeField("TOCARS", "TOCARS", JdeDataType.Numeric),
        new JdeField("TOMOT", "TOMOT", JdeDataType.String, 6),
        new JdeField("TODGL", "TODGL", JdeDataType.Numeric),
        new JdeField("TOICU", "TOICU", JdeDataType.Numeric),
        new JdeField("TODOCO", "TODOCO", JdeDataType.Numeric),
        new JdeField("TODCTO", "TODCTO", JdeDataType.String, 4),
        new JdeField("TOKCOO", "TOKCOO", JdeDataType.String, 10),
        new JdeField("TOLNID", "TOLNID", JdeDataType.Numeric),
        new JdeField("TOSRCO", "TOSRCO", JdeDataType.String, 2),
        new JdeField("TOTRDJ", "TOTRDJ", JdeDataType.Numeric),
        new JdeField("TORCD", "TORCD", JdeDataType.String, 6),
        new JdeField("TOGLRS", "TOGLRS", JdeDataType.String, 4),
        new JdeField("TOMCU", "TOMCU", JdeDataType.String, 24),
        new JdeField("TOITM", "TOITM", JdeDataType.Numeric),
        new JdeField("TOLOTN", "TOLOTN", JdeDataType.String, 60),
        new JdeField("TOAN8", "TOAN8", JdeDataType.Numeric),
        new JdeField("TOLOCN", "TOLOCN", JdeDataType.String, 40),
        new JdeField("TOLOTT", "TOLOTT", JdeDataType.String, 60),
        new JdeField("TORITM", "TORITM", JdeDataType.Numeric),
        new JdeField("TOKTFG", "TOKTFG", JdeDataType.String, 2),
        new JdeField("TOACLQ", "TOACLQ", JdeDataType.Numeric),
        new JdeField("TOTRUM", "TOTRUM", JdeDataType.String, 4),
        new JdeField("TOSTUM", "TOSTUM", JdeDataType.Numeric),
        new JdeField("TOBUM6", "TOBUM6", JdeDataType.String, 4),
        new JdeField("TOTEMP", "TOTEMP", JdeDataType.Numeric),
        new JdeField("TOSTPU", "TOSTPU", JdeDataType.String, 2),
        new JdeField("TODEND", "TODEND", JdeDataType.Numeric),
        new JdeField("TODNTP", "TODNTP", JdeDataType.String, 2),
        new JdeField("TODETP", "TODETP", JdeDataType.Numeric),
        new JdeField("TODTPU", "TODTPU", JdeDataType.String, 2),
        new JdeField("TOAMBR", "TOAMBR", JdeDataType.Numeric),
        new JdeField("TOBUM3", "TOBUM3", JdeDataType.String, 4),
        new JdeField("TOSTOK", "TOSTOK", JdeDataType.Numeric),
        new JdeField("TOBUM4", "TOBUM4", JdeDataType.String, 4),
        new JdeField("TOWGTR", "TOWGTR", JdeDataType.Numeric),
        new JdeField("TOBUM5", "TOBUM5", JdeDataType.String, 4),
        new JdeField("TOVCF", "TOVCF", JdeDataType.Numeric),
        new JdeField("TOUNCS", "TOUNCS", JdeDataType.Numeric),
        new JdeField("TOECST", "TOECST", JdeDataType.Numeric),
        new JdeField("TODMCT", "TODMCT", JdeDataType.String, 24),
        new JdeField("TODMCS", "TODMCS", JdeDataType.Numeric),
        new JdeField("TOBALU", "TOBALU", JdeDataType.String, 2),
        new JdeField("TOCMOO", "TOCMOO", JdeDataType.String, 2),
        new JdeField("TORDTM", "TORDTM", JdeDataType.Numeric),
        new JdeField("TODTE", "TODTE", JdeDataType.Numeric),
        new JdeField("TOMETN", "TOMETN", JdeDataType.String, 20),
        new JdeField("TOOPNR", "TOOPNR", JdeDataType.Numeric),
        new JdeField("TOPNCR", "TOPNCR", JdeDataType.Numeric),
        new JdeField("TOBFWT", "TOBFWT", JdeDataType.Numeric),
        new JdeField("TOBWTU", "TOBWTU", JdeDataType.String, 4),
        new JdeField("TOAFWT", "TOAFWT", JdeDataType.Numeric),
        new JdeField("TOAWTU", "TOAWTU", JdeDataType.String, 4),
        new JdeField("TOSVPF", "TOSVPF", JdeDataType.String, 2),
        new JdeField("TOSVPD", "TOSVPD", JdeDataType.Numeric),
        new JdeField("TOLMCU", "TOLMCU", JdeDataType.String, 24),
        new JdeField("TOLTRP", "TOLTRP", JdeDataType.Numeric),
        new JdeField("TOSHAN", "TOSHAN", JdeDataType.Numeric),
        new JdeField("TOUKID", "TOUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TOURCD", "TOURCD", JdeDataType.String, 4),
        new JdeField("TOURDT", "TOURDT", JdeDataType.Numeric),
        new JdeField("TOURAT", "TOURAT", JdeDataType.Numeric),
        new JdeField("TOURAB", "TOURAB", JdeDataType.Numeric),
        new JdeField("TOURRF", "TOURRF", JdeDataType.String, 30),
        new JdeField("TOUSER", "TOUSER", JdeDataType.String, 20),
        new JdeField("TOPID", "TOPID", JdeDataType.String, 20),
        new JdeField("TOJOBN", "TOJOBN", JdeDataType.String, 20),
        new JdeField("TOUPMJ", "TOUPMJ", JdeDataType.Numeric),
        new JdeField("TOTDAY", "TOTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49631_0", "Primary Key on TOUKID", new[] { "TOUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49631_2", "Index on TOKCO, TODGL, TOSVPF, TOSVPD", new[] { "TOKCO", "TODGL", "TOSVPF", "TOSVPD" })
    };
}
