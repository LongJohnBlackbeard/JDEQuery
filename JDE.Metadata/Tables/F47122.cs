using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47122 - .
/// </summary>
public class F47122 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MJEDTY.
        /// </summary>
        public const string MJEDTY = "MJEDTY";

        /// <summary>
        /// MJEDSQ.
        /// </summary>
        public const string MJEDSQ = "MJEDSQ";

        /// <summary>
        /// MJEKCO.
        /// </summary>
        public const string MJEKCO = "MJEKCO";

        /// <summary>
        /// MJEDOC.
        /// </summary>
        public const string MJEDOC = "MJEDOC";

        /// <summary>
        /// MJEDCT.
        /// </summary>
        public const string MJEDCT = "MJEDCT";

        /// <summary>
        /// MJEDLN.
        /// </summary>
        public const string MJEDLN = "MJEDLN";

        /// <summary>
        /// MJEDST.
        /// </summary>
        public const string MJEDST = "MJEDST";

        /// <summary>
        /// MJEDFT.
        /// </summary>
        public const string MJEDFT = "MJEDFT";

        /// <summary>
        /// MJEDDT.
        /// </summary>
        public const string MJEDDT = "MJEDDT";

        /// <summary>
        /// MJEDER.
        /// </summary>
        public const string MJEDER = "MJEDER";

        /// <summary>
        /// MJEDDL.
        /// </summary>
        public const string MJEDDL = "MJEDDL";

        /// <summary>
        /// MJEDSP.
        /// </summary>
        public const string MJEDSP = "MJEDSP";

        /// <summary>
        /// MJEDBT.
        /// </summary>
        public const string MJEDBT = "MJEDBT";

        /// <summary>
        /// MJPNID.
        /// </summary>
        public const string MJPNID = "MJPNID";

        /// <summary>
        /// MJPACD.
        /// </summary>
        public const string MJPACD = "MJPACD";

        /// <summary>
        /// MJKSEQ.
        /// </summary>
        public const string MJKSEQ = "MJKSEQ";

        /// <summary>
        /// MJCITM.
        /// </summary>
        public const string MJCITM = "MJCITM";

        /// <summary>
        /// MJXRT.
        /// </summary>
        public const string MJXRT = "MJXRT";

        /// <summary>
        /// MJAN8.
        /// </summary>
        public const string MJAN8 = "MJAN8";

        /// <summary>
        /// MJVR01.
        /// </summary>
        public const string MJVR01 = "MJVR01";

        /// <summary>
        /// MJMCU.
        /// </summary>
        public const string MJMCU = "MJMCU";

        /// <summary>
        /// MJITM.
        /// </summary>
        public const string MJITM = "MJITM";

        /// <summary>
        /// MJLITM.
        /// </summary>
        public const string MJLITM = "MJLITM";

        /// <summary>
        /// MJAITM.
        /// </summary>
        public const string MJAITM = "MJAITM";

        /// <summary>
        /// MJLOCN.
        /// </summary>
        public const string MJLOCN = "MJLOCN";

        /// <summary>
        /// MJLOTN.
        /// </summary>
        public const string MJLOTN = "MJLOTN";

        /// <summary>
        /// MJPLOT.
        /// </summary>
        public const string MJPLOT = "MJPLOT";

        /// <summary>
        /// MJSTUN.
        /// </summary>
        public const string MJSTUN = "MJSTUN";

        /// <summary>
        /// MJLDSQ.
        /// </summary>
        public const string MJLDSQ = "MJLDSQ";

        /// <summary>
        /// MJTRNO.
        /// </summary>
        public const string MJTRNO = "MJTRNO";

        /// <summary>
        /// MJFRTO.
        /// </summary>
        public const string MJFRTO = "MJFRTO";

        /// <summary>
        /// MJLMCX.
        /// </summary>
        public const string MJLMCX = "MJLMCX";

        /// <summary>
        /// MJLOTS.
        /// </summary>
        public const string MJLOTS = "MJLOTS";

        /// <summary>
        /// MJLOTP.
        /// </summary>
        public const string MJLOTP = "MJLOTP";

        /// <summary>
        /// MJLOTG.
        /// </summary>
        public const string MJLOTG = "MJLOTG";

        /// <summary>
        /// MJLDSC.
        /// </summary>
        public const string MJLDSC = "MJLDSC";

        /// <summary>
        /// MJMMEJ.
        /// </summary>
        public const string MJMMEJ = "MJMMEJ";

        /// <summary>
        /// MJDSC1.
        /// </summary>
        public const string MJDSC1 = "MJDSC1";

        /// <summary>
        /// MJDSC2.
        /// </summary>
        public const string MJDSC2 = "MJDSC2";

        /// <summary>
        /// MJTRDJ.
        /// </summary>
        public const string MJTRDJ = "MJTRDJ";

        /// <summary>
        /// MJTRUM.
        /// </summary>
        public const string MJTRUM = "MJTRUM";

        /// <summary>
        /// MJTRQT.
        /// </summary>
        public const string MJTRQT = "MJTRQT";

        /// <summary>
        /// MJUNCS.
        /// </summary>
        public const string MJUNCS = "MJUNCS";

        /// <summary>
        /// MJPAID.
        /// </summary>
        public const string MJPAID = "MJPAID";

        /// <summary>
        /// MJMMCU.
        /// </summary>
        public const string MJMMCU = "MJMMCU";

        /// <summary>
        /// MJDMCT.
        /// </summary>
        public const string MJDMCT = "MJDMCT";

        /// <summary>
        /// MJDMCS.
        /// </summary>
        public const string MJDMCS = "MJDMCS";

        /// <summary>
        /// MJBALU.
        /// </summary>
        public const string MJBALU = "MJBALU";

        /// <summary>
        /// MJKCO.
        /// </summary>
        public const string MJKCO = "MJKCO";

        /// <summary>
        /// MJDOC.
        /// </summary>
        public const string MJDOC = "MJDOC";

        /// <summary>
        /// MJDCT.
        /// </summary>
        public const string MJDCT = "MJDCT";

        /// <summary>
        /// MJSFX.
        /// </summary>
        public const string MJSFX = "MJSFX";

        /// <summary>
        /// MJJELN.
        /// </summary>
        public const string MJJELN = "MJJELN";

        /// <summary>
        /// MJICU.
        /// </summary>
        public const string MJICU = "MJICU";

        /// <summary>
        /// MJDGL.
        /// </summary>
        public const string MJDGL = "MJDGL";

        /// <summary>
        /// MJGLPT.
        /// </summary>
        public const string MJGLPT = "MJGLPT";

        /// <summary>
        /// MJDCTO.
        /// </summary>
        public const string MJDCTO = "MJDCTO";

        /// <summary>
        /// MJDOCO.
        /// </summary>
        public const string MJDOCO = "MJDOCO";

        /// <summary>
        /// MJKCOO.
        /// </summary>
        public const string MJKCOO = "MJKCOO";

        /// <summary>
        /// MJLNID.
        /// </summary>
        public const string MJLNID = "MJLNID";

        /// <summary>
        /// MJNLIN.
        /// </summary>
        public const string MJNLIN = "MJNLIN";

        /// <summary>
        /// MJTREX.
        /// </summary>
        public const string MJTREX = "MJTREX";

        /// <summary>
        /// MJTREF.
        /// </summary>
        public const string MJTREF = "MJTREF";

        /// <summary>
        /// MJRCD.
        /// </summary>
        public const string MJRCD = "MJRCD";

        /// <summary>
        /// MJCRCD.
        /// </summary>
        public const string MJCRCD = "MJCRCD";

        /// <summary>
        /// MJCRR.
        /// </summary>
        public const string MJCRR = "MJCRR";

        /// <summary>
        /// MJCDEC.
        /// </summary>
        public const string MJCDEC = "MJCDEC";

        /// <summary>
        /// MJANI.
        /// </summary>
        public const string MJANI = "MJANI";

        /// <summary>
        /// MJASII.
        /// </summary>
        public const string MJASII = "MJASII";

        /// <summary>
        /// MJSBL.
        /// </summary>
        public const string MJSBL = "MJSBL";

        /// <summary>
        /// MJSBLT.
        /// </summary>
        public const string MJSBLT = "MJSBLT";

        /// <summary>
        /// MJWR01.
        /// </summary>
        public const string MJWR01 = "MJWR01";

        /// <summary>
        /// MJURCD.
        /// </summary>
        public const string MJURCD = "MJURCD";

        /// <summary>
        /// MJURDT.
        /// </summary>
        public const string MJURDT = "MJURDT";

        /// <summary>
        /// MJURAT.
        /// </summary>
        public const string MJURAT = "MJURAT";

        /// <summary>
        /// MJURAB.
        /// </summary>
        public const string MJURAB = "MJURAB";

        /// <summary>
        /// MJURRF.
        /// </summary>
        public const string MJURRF = "MJURRF";

        /// <summary>
        /// MJTORG.
        /// </summary>
        public const string MJTORG = "MJTORG";

        /// <summary>
        /// MJUSER.
        /// </summary>
        public const string MJUSER = "MJUSER";

        /// <summary>
        /// MJPID.
        /// </summary>
        public const string MJPID = "MJPID";

        /// <summary>
        /// MJJOBN.
        /// </summary>
        public const string MJJOBN = "MJJOBN";

        /// <summary>
        /// MJUPMJ.
        /// </summary>
        public const string MJUPMJ = "MJUPMJ";

        /// <summary>
        /// MJTDAY.
        /// </summary>
        public const string MJTDAY = "MJTDAY";

        /// <summary>
        /// MJSQOR.
        /// </summary>
        public const string MJSQOR = "MJSQOR";

        /// <summary>
        /// MJUOM2.
        /// </summary>
        public const string MJUOM2 = "MJUOM2";

        /// <summary>
        /// MJLOTC.
        /// </summary>
        public const string MJLOTC = "MJLOTC";

        /// <summary>
        /// MJGAN8.
        /// </summary>
        public const string MJGAN8 = "MJGAN8";

        /// <summary>
        /// MJPMPN.
        /// </summary>
        public const string MJPMPN = "MJPMPN";

        /// <summary>
        /// MJPNS.
        /// </summary>
        public const string MJPNS = "MJPNS";

        /// <summary>
        /// MJORIG.
        /// </summary>
        public const string MJORIG = "MJORIG";
    }

    /// <inheritdoc />
    public override string TableName => "F47122";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MJEDTY", "MJEDTY", JdeDataType.String, 2),
        new JdeField("MJEDSQ", "MJEDSQ", JdeDataType.Numeric),
        new JdeField("MJEKCO", "MJEKCO", JdeDataType.String, 10, true, true),
        new JdeField("MJEDOC", "MJEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("MJEDCT", "MJEDCT", JdeDataType.String, 4, true, true),
        new JdeField("MJEDLN", "MJEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("MJEDST", "MJEDST", JdeDataType.String, 12),
        new JdeField("MJEDFT", "MJEDFT", JdeDataType.String, 20),
        new JdeField("MJEDDT", "MJEDDT", JdeDataType.Numeric),
        new JdeField("MJEDER", "MJEDER", JdeDataType.String, 2),
        new JdeField("MJEDDL", "MJEDDL", JdeDataType.Numeric),
        new JdeField("MJEDSP", "MJEDSP", JdeDataType.String, 2),
        new JdeField("MJEDBT", "MJEDBT", JdeDataType.String, 30),
        new JdeField("MJPNID", "MJPNID", JdeDataType.String, 30),
        new JdeField("MJPACD", "MJPACD", JdeDataType.String, 4),
        new JdeField("MJKSEQ", "MJKSEQ", JdeDataType.Numeric),
        new JdeField("MJCITM", "MJCITM", JdeDataType.String, 50),
        new JdeField("MJXRT", "MJXRT", JdeDataType.String, 4),
        new JdeField("MJAN8", "MJAN8", JdeDataType.Numeric),
        new JdeField("MJVR01", "MJVR01", JdeDataType.String, 50),
        new JdeField("MJMCU", "MJMCU", JdeDataType.String, 24),
        new JdeField("MJITM", "MJITM", JdeDataType.Numeric),
        new JdeField("MJLITM", "MJLITM", JdeDataType.String, 50),
        new JdeField("MJAITM", "MJAITM", JdeDataType.String, 50),
        new JdeField("MJLOCN", "MJLOCN", JdeDataType.String, 40),
        new JdeField("MJLOTN", "MJLOTN", JdeDataType.String, 60),
        new JdeField("MJPLOT", "MJPLOT", JdeDataType.String, 60),
        new JdeField("MJSTUN", "MJSTUN", JdeDataType.Numeric),
        new JdeField("MJLDSQ", "MJLDSQ", JdeDataType.Numeric),
        new JdeField("MJTRNO", "MJTRNO", JdeDataType.Numeric),
        new JdeField("MJFRTO", "MJFRTO", JdeDataType.String, 2),
        new JdeField("MJLMCX", "MJLMCX", JdeDataType.String, 2),
        new JdeField("MJLOTS", "MJLOTS", JdeDataType.String, 2),
        new JdeField("MJLOTP", "MJLOTP", JdeDataType.Numeric),
        new JdeField("MJLOTG", "MJLOTG", JdeDataType.String, 6),
        new JdeField("MJLDSC", "MJLDSC", JdeDataType.String, 60),
        new JdeField("MJMMEJ", "MJMMEJ", JdeDataType.Numeric),
        new JdeField("MJDSC1", "MJDSC1", JdeDataType.String, 60),
        new JdeField("MJDSC2", "MJDSC2", JdeDataType.String, 60),
        new JdeField("MJTRDJ", "MJTRDJ", JdeDataType.Numeric),
        new JdeField("MJTRUM", "MJTRUM", JdeDataType.String, 4),
        new JdeField("MJTRQT", "MJTRQT", JdeDataType.Numeric),
        new JdeField("MJUNCS", "MJUNCS", JdeDataType.Numeric),
        new JdeField("MJPAID", "MJPAID", JdeDataType.Numeric),
        new JdeField("MJMMCU", "MJMMCU", JdeDataType.String, 24),
        new JdeField("MJDMCT", "MJDMCT", JdeDataType.String, 24),
        new JdeField("MJDMCS", "MJDMCS", JdeDataType.Numeric),
        new JdeField("MJBALU", "MJBALU", JdeDataType.String, 2),
        new JdeField("MJKCO", "MJKCO", JdeDataType.String, 10),
        new JdeField("MJDOC", "MJDOC", JdeDataType.Numeric),
        new JdeField("MJDCT", "MJDCT", JdeDataType.String, 4),
        new JdeField("MJSFX", "MJSFX", JdeDataType.String, 6),
        new JdeField("MJJELN", "MJJELN", JdeDataType.Numeric),
        new JdeField("MJICU", "MJICU", JdeDataType.Numeric),
        new JdeField("MJDGL", "MJDGL", JdeDataType.Numeric),
        new JdeField("MJGLPT", "MJGLPT", JdeDataType.String, 8),
        new JdeField("MJDCTO", "MJDCTO", JdeDataType.String, 4),
        new JdeField("MJDOCO", "MJDOCO", JdeDataType.Numeric),
        new JdeField("MJKCOO", "MJKCOO", JdeDataType.String, 10),
        new JdeField("MJLNID", "MJLNID", JdeDataType.Numeric),
        new JdeField("MJNLIN", "MJNLIN", JdeDataType.Numeric),
        new JdeField("MJTREX", "MJTREX", JdeDataType.String, 60),
        new JdeField("MJTREF", "MJTREF", JdeDataType.String, 16),
        new JdeField("MJRCD", "MJRCD", JdeDataType.String, 6),
        new JdeField("MJCRCD", "MJCRCD", JdeDataType.String, 6),
        new JdeField("MJCRR", "MJCRR", JdeDataType.Numeric),
        new JdeField("MJCDEC", "MJCDEC", JdeDataType.String, 2),
        new JdeField("MJANI", "MJANI", JdeDataType.String, 58),
        new JdeField("MJASII", "MJASII", JdeDataType.String, 52),
        new JdeField("MJSBL", "MJSBL", JdeDataType.String, 16),
        new JdeField("MJSBLT", "MJSBLT", JdeDataType.String, 2),
        new JdeField("MJWR01", "MJWR01", JdeDataType.String, 8),
        new JdeField("MJURCD", "MJURCD", JdeDataType.String, 4),
        new JdeField("MJURDT", "MJURDT", JdeDataType.Numeric),
        new JdeField("MJURAT", "MJURAT", JdeDataType.Numeric),
        new JdeField("MJURAB", "MJURAB", JdeDataType.Numeric),
        new JdeField("MJURRF", "MJURRF", JdeDataType.String, 30),
        new JdeField("MJTORG", "MJTORG", JdeDataType.String, 20),
        new JdeField("MJUSER", "MJUSER", JdeDataType.String, 20),
        new JdeField("MJPID", "MJPID", JdeDataType.String, 20),
        new JdeField("MJJOBN", "MJJOBN", JdeDataType.String, 20),
        new JdeField("MJUPMJ", "MJUPMJ", JdeDataType.Numeric),
        new JdeField("MJTDAY", "MJTDAY", JdeDataType.Numeric),
        new JdeField("MJSQOR", "MJSQOR", JdeDataType.Numeric),
        new JdeField("MJUOM2", "MJUOM2", JdeDataType.String, 4),
        new JdeField("MJLOTC", "MJLOTC", JdeDataType.String, 6),
        new JdeField("MJGAN8", "MJGAN8", JdeDataType.Numeric),
        new JdeField("MJPMPN", "MJPMPN", JdeDataType.String, 60),
        new JdeField("MJPNS", "MJPNS", JdeDataType.Numeric),
        new JdeField("MJORIG", "MJORIG", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47122_0", "Primary Key on MJEDOC, MJEDCT, MJEKCO, MJEDLN", new[] { "MJEDOC", "MJEDCT", "MJEKCO", "MJEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
