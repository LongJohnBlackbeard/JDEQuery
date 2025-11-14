using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F38111 - .
/// </summary>
public class F38111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DZDMCT.
        /// </summary>
        public const string DZDMCT = "DZDMCT";

        /// <summary>
        /// DZDMCS.
        /// </summary>
        public const string DZDMCS = "DZDMCS";

        /// <summary>
        /// DZDMTC.
        /// </summary>
        public const string DZDMTC = "DZDMTC";

        /// <summary>
        /// DZAN8.
        /// </summary>
        public const string DZAN8 = "DZAN8";

        /// <summary>
        /// DZAN8R.
        /// </summary>
        public const string DZAN8R = "DZAN8R";

        /// <summary>
        /// DZITM.
        /// </summary>
        public const string DZITM = "DZITM";

        /// <summary>
        /// DZMCU.
        /// </summary>
        public const string DZMCU = "DZMCU";

        /// <summary>
        /// DZCO.
        /// </summary>
        public const string DZCO = "DZCO";

        /// <summary>
        /// DZLOCN.
        /// </summary>
        public const string DZLOCN = "DZLOCN";

        /// <summary>
        /// DZLOT.
        /// </summary>
        public const string DZLOT = "DZLOT";

        /// <summary>
        /// DZTCAJ.
        /// </summary>
        public const string DZTCAJ = "DZTCAJ";

        /// <summary>
        /// DZTRDJ.
        /// </summary>
        public const string DZTRDJ = "DZTRDJ";

        /// <summary>
        /// DZADJJ.
        /// </summary>
        public const string DZADJJ = "DZADJJ";

        /// <summary>
        /// DZDCT.
        /// </summary>
        public const string DZDCT = "DZDCT";

        /// <summary>
        /// DZDOC.
        /// </summary>
        public const string DZDOC = "DZDOC";

        /// <summary>
        /// DZKCO.
        /// </summary>
        public const string DZKCO = "DZKCO";

        /// <summary>
        /// DZJELN.
        /// </summary>
        public const string DZJELN = "DZJELN";

        /// <summary>
        /// DZDOCO.
        /// </summary>
        public const string DZDOCO = "DZDOCO";

        /// <summary>
        /// DZDCTO.
        /// </summary>
        public const string DZDCTO = "DZDCTO";

        /// <summary>
        /// DZKCOO.
        /// </summary>
        public const string DZKCOO = "DZKCOO";

        /// <summary>
        /// DZLNID.
        /// </summary>
        public const string DZLNID = "DZLNID";

        /// <summary>
        /// DZVEHI.
        /// </summary>
        public const string DZVEHI = "DZVEHI";

        /// <summary>
        /// DZVMCU.
        /// </summary>
        public const string DZVMCU = "DZVMCU";

        /// <summary>
        /// DZTRP.
        /// </summary>
        public const string DZTRP = "DZTRP";

        /// <summary>
        /// DZCMPN.
        /// </summary>
        public const string DZCMPN = "DZCMPN";

        /// <summary>
        /// DZDTO.
        /// </summary>
        public const string DZDTO = "DZDTO";

        /// <summary>
        /// DZDES.
        /// </summary>
        public const string DZDES = "DZDES";

        /// <summary>
        /// DZDESY.
        /// </summary>
        public const string DZDESY = "DZDESY";

        /// <summary>
        /// DZPSR.
        /// </summary>
        public const string DZPSR = "DZPSR";

        /// <summary>
        /// DZPSRY.
        /// </summary>
        public const string DZPSRY = "DZPSRY";

        /// <summary>
        /// DZSEQ.
        /// </summary>
        public const string DZSEQ = "DZSEQ";

        /// <summary>
        /// DZTREX.
        /// </summary>
        public const string DZTREX = "DZTREX";

        /// <summary>
        /// DZTRQT.
        /// </summary>
        public const string DZTRQT = "DZTRQT";

        /// <summary>
        /// DZUOM.
        /// </summary>
        public const string DZUOM = "DZUOM";

        /// <summary>
        /// DZTEMP.
        /// </summary>
        public const string DZTEMP = "DZTEMP";

        /// <summary>
        /// DZSTPU.
        /// </summary>
        public const string DZSTPU = "DZSTPU";

        /// <summary>
        /// DZDNTY.
        /// </summary>
        public const string DZDNTY = "DZDNTY";

        /// <summary>
        /// DZDNTP.
        /// </summary>
        public const string DZDNTP = "DZDNTP";

        /// <summary>
        /// DZDETP.
        /// </summary>
        public const string DZDETP = "DZDETP";

        /// <summary>
        /// DZDTPU.
        /// </summary>
        public const string DZDTPU = "DZDTPU";

        /// <summary>
        /// DZAMBR.
        /// </summary>
        public const string DZAMBR = "DZAMBR";

        /// <summary>
        /// DZAMBU.
        /// </summary>
        public const string DZAMBU = "DZAMBU";

        /// <summary>
        /// DZVCF.
        /// </summary>
        public const string DZVCF = "DZVCF";

        /// <summary>
        /// DZSTOK.
        /// </summary>
        public const string DZSTOK = "DZSTOK";

        /// <summary>
        /// DZBUM4.
        /// </summary>
        public const string DZBUM4 = "DZBUM4";

        /// <summary>
        /// DZWGTR.
        /// </summary>
        public const string DZWGTR = "DZWGTR";

        /// <summary>
        /// DZBUM5.
        /// </summary>
        public const string DZBUM5 = "DZBUM5";

        /// <summary>
        /// DZSTUM.
        /// </summary>
        public const string DZSTUM = "DZSTUM";

        /// <summary>
        /// DZBUM6.
        /// </summary>
        public const string DZBUM6 = "DZBUM6";

        /// <summary>
        /// DZPRAS.
        /// </summary>
        public const string DZPRAS = "DZPRAS";

        /// <summary>
        /// DZAA.
        /// </summary>
        public const string DZAA = "DZAA";

        /// <summary>
        /// DZCRCD.
        /// </summary>
        public const string DZCRCD = "DZCRCD";

        /// <summary>
        /// DZUNCS.
        /// </summary>
        public const string DZUNCS = "DZUNCS";

        /// <summary>
        /// DZPAID.
        /// </summary>
        public const string DZPAID = "DZPAID";

        /// <summary>
        /// DZDGL.
        /// </summary>
        public const string DZDGL = "DZDGL";

        /// <summary>
        /// DZICU.
        /// </summary>
        public const string DZICU = "DZICU";

        /// <summary>
        /// DZICUT.
        /// </summary>
        public const string DZICUT = "DZICUT";

        /// <summary>
        /// DZGLPT.
        /// </summary>
        public const string DZGLPT = "DZGLPT";

        /// <summary>
        /// DZADZR.
        /// </summary>
        public const string DZADZR = "DZADZR";

        /// <summary>
        /// DZRCD.
        /// </summary>
        public const string DZRCD = "DZRCD";

        /// <summary>
        /// DZRECS.
        /// </summary>
        public const string DZRECS = "DZRECS";

        /// <summary>
        /// DZCRDJ.
        /// </summary>
        public const string DZCRDJ = "DZCRDJ";

        /// <summary>
        /// DZUKID.
        /// </summary>
        public const string DZUKID = "DZUKID";

        /// <summary>
        /// DZUPGL.
        /// </summary>
        public const string DZUPGL = "DZUPGL";

        /// <summary>
        /// DZSVPF.
        /// </summary>
        public const string DZSVPF = "DZSVPF";

        /// <summary>
        /// DZSVPD.
        /// </summary>
        public const string DZSVPD = "DZSVPD";

        /// <summary>
        /// DZPRTF.
        /// </summary>
        public const string DZPRTF = "DZPRTF";

        /// <summary>
        /// DZCRPO.
        /// </summary>
        public const string DZCRPO = "DZCRPO";

        /// <summary>
        /// DZCRSO.
        /// </summary>
        public const string DZCRSO = "DZCRSO";

        /// <summary>
        /// DZCDMC.
        /// </summary>
        public const string DZCDMC = "DZCDMC";

        /// <summary>
        /// DZCAND.
        /// </summary>
        public const string DZCAND = "DZCAND";

        /// <summary>
        /// DZCANR.
        /// </summary>
        public const string DZCANR = "DZCANR";

        /// <summary>
        /// DZTV01.
        /// </summary>
        public const string DZTV01 = "DZTV01";

        /// <summary>
        /// DZTV02.
        /// </summary>
        public const string DZTV02 = "DZTV02";

        /// <summary>
        /// DZTV03.
        /// </summary>
        public const string DZTV03 = "DZTV03";

        /// <summary>
        /// DZURCD.
        /// </summary>
        public const string DZURCD = "DZURCD";

        /// <summary>
        /// DZURDT.
        /// </summary>
        public const string DZURDT = "DZURDT";

        /// <summary>
        /// DZURAT.
        /// </summary>
        public const string DZURAT = "DZURAT";

        /// <summary>
        /// DZURAB.
        /// </summary>
        public const string DZURAB = "DZURAB";

        /// <summary>
        /// DZURRF.
        /// </summary>
        public const string DZURRF = "DZURRF";

        /// <summary>
        /// DZUSER.
        /// </summary>
        public const string DZUSER = "DZUSER";

        /// <summary>
        /// DZPID.
        /// </summary>
        public const string DZPID = "DZPID";

        /// <summary>
        /// DZJOBN.
        /// </summary>
        public const string DZJOBN = "DZJOBN";

        /// <summary>
        /// DZUPMJ.
        /// </summary>
        public const string DZUPMJ = "DZUPMJ";

        /// <summary>
        /// DZTDAY.
        /// </summary>
        public const string DZTDAY = "DZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F38111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DZDMCT", "DZDMCT", JdeDataType.String, 24),
        new JdeField("DZDMCS", "DZDMCS", JdeDataType.Numeric),
        new JdeField("DZDMTC", "DZDMTC", JdeDataType.String, 2),
        new JdeField("DZAN8", "DZAN8", JdeDataType.Numeric),
        new JdeField("DZAN8R", "DZAN8R", JdeDataType.Numeric),
        new JdeField("DZITM", "DZITM", JdeDataType.Numeric),
        new JdeField("DZMCU", "DZMCU", JdeDataType.String, 24),
        new JdeField("DZCO", "DZCO", JdeDataType.String, 10),
        new JdeField("DZLOCN", "DZLOCN", JdeDataType.String, 40),
        new JdeField("DZLOT", "DZLOT", JdeDataType.String, 60),
        new JdeField("DZTCAJ", "DZTCAJ", JdeDataType.String, 2),
        new JdeField("DZTRDJ", "DZTRDJ", JdeDataType.Numeric),
        new JdeField("DZADJJ", "DZADJJ", JdeDataType.Numeric),
        new JdeField("DZDCT", "DZDCT", JdeDataType.String, 4),
        new JdeField("DZDOC", "DZDOC", JdeDataType.Numeric),
        new JdeField("DZKCO", "DZKCO", JdeDataType.String, 10),
        new JdeField("DZJELN", "DZJELN", JdeDataType.Numeric),
        new JdeField("DZDOCO", "DZDOCO", JdeDataType.Numeric),
        new JdeField("DZDCTO", "DZDCTO", JdeDataType.String, 4),
        new JdeField("DZKCOO", "DZKCOO", JdeDataType.String, 10),
        new JdeField("DZLNID", "DZLNID", JdeDataType.Numeric),
        new JdeField("DZVEHI", "DZVEHI", JdeDataType.String, 24),
        new JdeField("DZVMCU", "DZVMCU", JdeDataType.String, 24),
        new JdeField("DZTRP", "DZTRP", JdeDataType.Numeric),
        new JdeField("DZCMPN", "DZCMPN", JdeDataType.Numeric),
        new JdeField("DZDTO", "DZDTO", JdeDataType.String, 2),
        new JdeField("DZDES", "DZDES", JdeDataType.String, 24),
        new JdeField("DZDESY", "DZDESY", JdeDataType.String, 4),
        new JdeField("DZPSR", "DZPSR", JdeDataType.String, 24),
        new JdeField("DZPSRY", "DZPSRY", JdeDataType.String, 4),
        new JdeField("DZSEQ", "DZSEQ", JdeDataType.Numeric),
        new JdeField("DZTREX", "DZTREX", JdeDataType.String, 60),
        new JdeField("DZTRQT", "DZTRQT", JdeDataType.Numeric),
        new JdeField("DZUOM", "DZUOM", JdeDataType.String, 4),
        new JdeField("DZTEMP", "DZTEMP", JdeDataType.Numeric),
        new JdeField("DZSTPU", "DZSTPU", JdeDataType.String, 2),
        new JdeField("DZDNTY", "DZDNTY", JdeDataType.Numeric),
        new JdeField("DZDNTP", "DZDNTP", JdeDataType.String, 2),
        new JdeField("DZDETP", "DZDETP", JdeDataType.Numeric),
        new JdeField("DZDTPU", "DZDTPU", JdeDataType.String, 2),
        new JdeField("DZAMBR", "DZAMBR", JdeDataType.Numeric),
        new JdeField("DZAMBU", "DZAMBU", JdeDataType.String, 4),
        new JdeField("DZVCF", "DZVCF", JdeDataType.Numeric),
        new JdeField("DZSTOK", "DZSTOK", JdeDataType.Numeric),
        new JdeField("DZBUM4", "DZBUM4", JdeDataType.String, 4),
        new JdeField("DZWGTR", "DZWGTR", JdeDataType.Numeric),
        new JdeField("DZBUM5", "DZBUM5", JdeDataType.String, 4),
        new JdeField("DZSTUM", "DZSTUM", JdeDataType.Numeric),
        new JdeField("DZBUM6", "DZBUM6", JdeDataType.String, 4),
        new JdeField("DZPRAS", "DZPRAS", JdeDataType.String, 2),
        new JdeField("DZAA", "DZAA", JdeDataType.Numeric),
        new JdeField("DZCRCD", "DZCRCD", JdeDataType.String, 6),
        new JdeField("DZUNCS", "DZUNCS", JdeDataType.Numeric),
        new JdeField("DZPAID", "DZPAID", JdeDataType.Numeric),
        new JdeField("DZDGL", "DZDGL", JdeDataType.Numeric),
        new JdeField("DZICU", "DZICU", JdeDataType.Numeric),
        new JdeField("DZICUT", "DZICUT", JdeDataType.String, 4),
        new JdeField("DZGLPT", "DZGLPT", JdeDataType.String, 8),
        new JdeField("DZADZR", "DZADZR", JdeDataType.String, 2),
        new JdeField("DZRCD", "DZRCD", JdeDataType.String, 6),
        new JdeField("DZRECS", "DZRECS", JdeDataType.String, 2),
        new JdeField("DZCRDJ", "DZCRDJ", JdeDataType.Numeric),
        new JdeField("DZUKID", "DZUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DZUPGL", "DZUPGL", JdeDataType.String, 2),
        new JdeField("DZSVPF", "DZSVPF", JdeDataType.String, 2),
        new JdeField("DZSVPD", "DZSVPD", JdeDataType.Numeric),
        new JdeField("DZPRTF", "DZPRTF", JdeDataType.String, 2),
        new JdeField("DZCRPO", "DZCRPO", JdeDataType.String, 2),
        new JdeField("DZCRSO", "DZCRSO", JdeDataType.String, 2),
        new JdeField("DZCDMC", "DZCDMC", JdeDataType.String, 2),
        new JdeField("DZCAND", "DZCAND", JdeDataType.Numeric),
        new JdeField("DZCANR", "DZCANR", JdeDataType.String, 6),
        new JdeField("DZTV01", "DZTV01", JdeDataType.String, 2),
        new JdeField("DZTV02", "DZTV02", JdeDataType.String, 2),
        new JdeField("DZTV03", "DZTV03", JdeDataType.String, 2),
        new JdeField("DZURCD", "DZURCD", JdeDataType.String, 4),
        new JdeField("DZURDT", "DZURDT", JdeDataType.Numeric),
        new JdeField("DZURAT", "DZURAT", JdeDataType.Numeric),
        new JdeField("DZURAB", "DZURAB", JdeDataType.Numeric),
        new JdeField("DZURRF", "DZURRF", JdeDataType.String, 30),
        new JdeField("DZUSER", "DZUSER", JdeDataType.String, 20),
        new JdeField("DZPID", "DZPID", JdeDataType.String, 20),
        new JdeField("DZJOBN", "DZJOBN", JdeDataType.String, 20),
        new JdeField("DZUPMJ", "DZUPMJ", JdeDataType.Numeric),
        new JdeField("DZTDAY", "DZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F38111_0", "Primary Key on DZUKID", new[] { "DZUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F38111_2", "Index on DZDMCT, DZDMCS, DZSEQ, DZPSR, DZPSRY, DZTRDJ", new[] { "DZDMCT", "DZDMCS", "DZSEQ", "DZPSR", "DZPSRY", "DZTRDJ" }),
        new JdeIndex("F38111_3", "Index on DZMCU, DZITM, DZTRDJ", new[] { "DZMCU", "DZITM", "DZTRDJ" }),
        new JdeIndex("F38111_4", "Index on DZDOC, DZDCT, DZKCO, DZJELN", new[] { "DZDOC", "DZDCT", "DZKCO", "DZJELN" }),
        new JdeIndex("F38111_5", "Index on DZCO, DZDGL, DZSVPF, DZSVPD, DZUPGL", new[] { "DZCO", "DZDGL", "DZSVPF", "DZSVPD", "DZUPGL" })
    };
}
