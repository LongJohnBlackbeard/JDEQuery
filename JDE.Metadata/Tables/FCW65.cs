using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW65 - .
/// </summary>
public class FCW65 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OFC9LANC.
        /// </summary>
        public const string OFC9LANC = "OFC9LANC";

        /// <summary>
        /// OFDCTO.
        /// </summary>
        public const string OFDCTO = "OFDCTO";

        /// <summary>
        /// OFDOCO.
        /// </summary>
        public const string OFDOCO = "OFDOCO";

        /// <summary>
        /// OFSFXO.
        /// </summary>
        public const string OFSFXO = "OFSFXO";

        /// <summary>
        /// OFRCTO.
        /// </summary>
        public const string OFRCTO = "OFRCTO";

        /// <summary>
        /// OFRORN.
        /// </summary>
        public const string OFRORN = "OFRORN";

        /// <summary>
        /// OFLNID.
        /// </summary>
        public const string OFLNID = "OFLNID";

        /// <summary>
        /// OFPTWO.
        /// </summary>
        public const string OFPTWO = "OFPTWO";

        /// <summary>
        /// OFPARS.
        /// </summary>
        public const string OFPARS = "OFPARS";

        /// <summary>
        /// OFTYPS.
        /// </summary>
        public const string OFTYPS = "OFTYPS";

        /// <summary>
        /// OFPRTS.
        /// </summary>
        public const string OFPRTS = "OFPRTS";

        /// <summary>
        /// OFDL01.
        /// </summary>
        public const string OFDL01 = "OFDL01";

        /// <summary>
        /// OFSTCM.
        /// </summary>
        public const string OFSTCM = "OFSTCM";

        /// <summary>
        /// OFCO.
        /// </summary>
        public const string OFCO = "OFCO";

        /// <summary>
        /// OFMCU.
        /// </summary>
        public const string OFMCU = "OFMCU";

        /// <summary>
        /// OFMMCU.
        /// </summary>
        public const string OFMMCU = "OFMMCU";

        /// <summary>
        /// OFLOCN.
        /// </summary>
        public const string OFLOCN = "OFLOCN";

        /// <summary>
        /// OFAISL.
        /// </summary>
        public const string OFAISL = "OFAISL";

        /// <summary>
        /// OFBIN.
        /// </summary>
        public const string OFBIN = "OFBIN";

        /// <summary>
        /// OFSRST.
        /// </summary>
        public const string OFSRST = "OFSRST";

        /// <summary>
        /// OFDCG.
        /// </summary>
        public const string OFDCG = "OFDCG";

        /// <summary>
        /// OFSUB.
        /// </summary>
        public const string OFSUB = "OFSUB";

        /// <summary>
        /// OFAN8.
        /// </summary>
        public const string OFAN8 = "OFAN8";

        /// <summary>
        /// OFANO.
        /// </summary>
        public const string OFANO = "OFANO";

        /// <summary>
        /// OFANSA.
        /// </summary>
        public const string OFANSA = "OFANSA";

        /// <summary>
        /// OFANPA.
        /// </summary>
        public const string OFANPA = "OFANPA";

        /// <summary>
        /// OFANP.
        /// </summary>
        public const string OFANP = "OFANP";

        /// <summary>
        /// OFDPL.
        /// </summary>
        public const string OFDPL = "OFDPL";

        /// <summary>
        /// OFANT.
        /// </summary>
        public const string OFANT = "OFANT";

        /// <summary>
        /// OFNAN8.
        /// </summary>
        public const string OFNAN8 = "OFNAN8";

        /// <summary>
        /// OFTRDJ.
        /// </summary>
        public const string OFTRDJ = "OFTRDJ";

        /// <summary>
        /// OFSTRT.
        /// </summary>
        public const string OFSTRT = "OFSTRT";

        /// <summary>
        /// OFDRQJ.
        /// </summary>
        public const string OFDRQJ = "OFDRQJ";

        /// <summary>
        /// OFSTRX.
        /// </summary>
        public const string OFSTRX = "OFSTRX";

        /// <summary>
        /// OFDAP.
        /// </summary>
        public const string OFDAP = "OFDAP";

        /// <summary>
        /// OFDAT.
        /// </summary>
        public const string OFDAT = "OFDAT";

        /// <summary>
        /// OFPPDT.
        /// </summary>
        public const string OFPPDT = "OFPPDT";

        /// <summary>
        /// OFWR01.
        /// </summary>
        public const string OFWR01 = "OFWR01";

        /// <summary>
        /// OFWR02.
        /// </summary>
        public const string OFWR02 = "OFWR02";

        /// <summary>
        /// OFWR03.
        /// </summary>
        public const string OFWR03 = "OFWR03";

        /// <summary>
        /// OFWR04.
        /// </summary>
        public const string OFWR04 = "OFWR04";

        /// <summary>
        /// OFWR05.
        /// </summary>
        public const string OFWR05 = "OFWR05";

        /// <summary>
        /// OFWR06.
        /// </summary>
        public const string OFWR06 = "OFWR06";

        /// <summary>
        /// OFWR07.
        /// </summary>
        public const string OFWR07 = "OFWR07";

        /// <summary>
        /// OFWR08.
        /// </summary>
        public const string OFWR08 = "OFWR08";

        /// <summary>
        /// OFWR09.
        /// </summary>
        public const string OFWR09 = "OFWR09";

        /// <summary>
        /// OFWR10.
        /// </summary>
        public const string OFWR10 = "OFWR10";

        /// <summary>
        /// OFVR01.
        /// </summary>
        public const string OFVR01 = "OFVR01";

        /// <summary>
        /// OFVR02.
        /// </summary>
        public const string OFVR02 = "OFVR02";

        /// <summary>
        /// OFAMTO.
        /// </summary>
        public const string OFAMTO = "OFAMTO";

        /// <summary>
        /// OFSETC.
        /// </summary>
        public const string OFSETC = "OFSETC";

        /// <summary>
        /// OFBRT.
        /// </summary>
        public const string OFBRT = "OFBRT";

        /// <summary>
        /// OFPAYT.
        /// </summary>
        public const string OFPAYT = "OFPAYT";

        /// <summary>
        /// OFAMTC.
        /// </summary>
        public const string OFAMTC = "OFAMTC";

        /// <summary>
        /// OFHRSO.
        /// </summary>
        public const string OFHRSO = "OFHRSO";

        /// <summary>
        /// OFHRSC.
        /// </summary>
        public const string OFHRSC = "OFHRSC";

        /// <summary>
        /// OFAMTA.
        /// </summary>
        public const string OFAMTA = "OFAMTA";

        /// <summary>
        /// OFHRSA.
        /// </summary>
        public const string OFHRSA = "OFHRSA";

        /// <summary>
        /// OFSHNO.
        /// </summary>
        public const string OFSHNO = "OFSHNO";

        /// <summary>
        /// OFPBTM.
        /// </summary>
        public const string OFPBTM = "OFPBTM";

        /// <summary>
        /// OFTBM.
        /// </summary>
        public const string OFTBM = "OFTBM";

        /// <summary>
        /// OFTRT.
        /// </summary>
        public const string OFTRT = "OFTRT";

        /// <summary>
        /// OFSHTY.
        /// </summary>
        public const string OFSHTY = "OFSHTY";

        /// <summary>
        /// OFPEC.
        /// </summary>
        public const string OFPEC = "OFPEC";

        /// <summary>
        /// OFPPFG.
        /// </summary>
        public const string OFPPFG = "OFPPFG";

        /// <summary>
        /// OFBM.
        /// </summary>
        public const string OFBM = "OFBM";

        /// <summary>
        /// OFRTG.
        /// </summary>
        public const string OFRTG = "OFRTG";

        /// <summary>
        /// OFSPRT.
        /// </summary>
        public const string OFSPRT = "OFSPRT";

        /// <summary>
        /// OFUNCD.
        /// </summary>
        public const string OFUNCD = "OFUNCD";

        /// <summary>
        /// OFINDC.
        /// </summary>
        public const string OFINDC = "OFINDC";

        /// <summary>
        /// OFRESC.
        /// </summary>
        public const string OFRESC = "OFRESC";

        /// <summary>
        /// OFMOH.
        /// </summary>
        public const string OFMOH = "OFMOH";

        /// <summary>
        /// OFTDT.
        /// </summary>
        public const string OFTDT = "OFTDT";

        /// <summary>
        /// OFPOU.
        /// </summary>
        public const string OFPOU = "OFPOU";

        /// <summary>
        /// OFPC.
        /// </summary>
        public const string OFPC = "OFPC";

        /// <summary>
        /// OFLTLV.
        /// </summary>
        public const string OFLTLV = "OFLTLV";

        /// <summary>
        /// OFLTCM.
        /// </summary>
        public const string OFLTCM = "OFLTCM";

        /// <summary>
        /// OFCTS1.
        /// </summary>
        public const string OFCTS1 = "OFCTS1";

        /// <summary>
        /// OFLOTN.
        /// </summary>
        public const string OFLOTN = "OFLOTN";

        /// <summary>
        /// OFLOTP.
        /// </summary>
        public const string OFLOTP = "OFLOTP";

        /// <summary>
        /// OFLOTG.
        /// </summary>
        public const string OFLOTG = "OFLOTG";

        /// <summary>
        /// OFRAT1.
        /// </summary>
        public const string OFRAT1 = "OFRAT1";

        /// <summary>
        /// OFRAT2.
        /// </summary>
        public const string OFRAT2 = "OFRAT2";

        /// <summary>
        /// OFDCT.
        /// </summary>
        public const string OFDCT = "OFDCT";

        /// <summary>
        /// OFSBLI.
        /// </summary>
        public const string OFSBLI = "OFSBLI";

        /// <summary>
        /// OFRKCO.
        /// </summary>
        public const string OFRKCO = "OFRKCO";

        /// <summary>
        /// OFBREV.
        /// </summary>
        public const string OFBREV = "OFBREV";

        /// <summary>
        /// OFRREV.
        /// </summary>
        public const string OFRREV = "OFRREV";

        /// <summary>
        /// OFDRWC.
        /// </summary>
        public const string OFDRWC = "OFDRWC";

        /// <summary>
        /// OFRTCH.
        /// </summary>
        public const string OFRTCH = "OFRTCH";

        /// <summary>
        /// OFPNRQ.
        /// </summary>
        public const string OFPNRQ = "OFPNRQ";

        /// <summary>
        /// OFREAS.
        /// </summary>
        public const string OFREAS = "OFREAS";

        /// <summary>
        /// OFPHSE.
        /// </summary>
        public const string OFPHSE = "OFPHSE";

        /// <summary>
        /// OFXDSP.
        /// </summary>
        public const string OFXDSP = "OFXDSP";

        /// <summary>
        /// OFBOMC.
        /// </summary>
        public const string OFBOMC = "OFBOMC";

        /// <summary>
        /// OFURCD.
        /// </summary>
        public const string OFURCD = "OFURCD";

        /// <summary>
        /// OFURDT.
        /// </summary>
        public const string OFURDT = "OFURDT";

        /// <summary>
        /// OFURAT.
        /// </summary>
        public const string OFURAT = "OFURAT";

        /// <summary>
        /// OFURAB.
        /// </summary>
        public const string OFURAB = "OFURAB";

        /// <summary>
        /// OFURRF.
        /// </summary>
        public const string OFURRF = "OFURRF";

        /// <summary>
        /// OFUSER.
        /// </summary>
        public const string OFUSER = "OFUSER";

        /// <summary>
        /// OFPID.
        /// </summary>
        public const string OFPID = "OFPID";

        /// <summary>
        /// OFJOBN.
        /// </summary>
        public const string OFJOBN = "OFJOBN";

        /// <summary>
        /// OFUPMJ.
        /// </summary>
        public const string OFUPMJ = "OFUPMJ";

        /// <summary>
        /// OFTDAY.
        /// </summary>
        public const string OFTDAY = "OFTDAY";

        /// <summary>
        /// OFAAID.
        /// </summary>
        public const string OFAAID = "OFAAID";

        /// <summary>
        /// OFNTST.
        /// </summary>
        public const string OFNTST = "OFNTST";

        /// <summary>
        /// OFXRTO.
        /// </summary>
        public const string OFXRTO = "OFXRTO";

        /// <summary>
        /// OFESDN.
        /// </summary>
        public const string OFESDN = "OFESDN";

        /// <summary>
        /// OFACDN.
        /// </summary>
        public const string OFACDN = "OFACDN";

        /// <summary>
        /// OFSAID.
        /// </summary>
        public const string OFSAID = "OFSAID";

        /// <summary>
        /// OFMPOS.
        /// </summary>
        public const string OFMPOS = "OFMPOS";

        /// <summary>
        /// OFAPRT.
        /// </summary>
        public const string OFAPRT = "OFAPRT";

        /// <summary>
        /// OFAMLC.
        /// </summary>
        public const string OFAMLC = "OFAMLC";

        /// <summary>
        /// OFAMMC.
        /// </summary>
        public const string OFAMMC = "OFAMMC";

        /// <summary>
        /// OFAMOT.
        /// </summary>
        public const string OFAMOT = "OFAMOT";

        /// <summary>
        /// OFLBAM.
        /// </summary>
        public const string OFLBAM = "OFLBAM";

        /// <summary>
        /// OFMTAM.
        /// </summary>
        public const string OFMTAM = "OFMTAM";

        /// <summary>
        /// OFC9COLL.
        /// </summary>
        public const string OFC9COLL = "OFC9COLL";

        /// <summary>
        /// OFC9SEAC.
        /// </summary>
        public const string OFC9SEAC = "OFC9SEAC";

        /// <summary>
        /// OFC9SEAY.
        /// </summary>
        public const string OFC9SEAY = "OFC9SEAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW65";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OFC9LANC", "OFC9LANC", JdeDataType.Numeric, null, true, true),
        new JdeField("OFDCTO", "OFDCTO", JdeDataType.String, 4),
        new JdeField("OFDOCO", "OFDOCO", JdeDataType.Numeric),
        new JdeField("OFSFXO", "OFSFXO", JdeDataType.String, 6),
        new JdeField("OFRCTO", "OFRCTO", JdeDataType.String, 4),
        new JdeField("OFRORN", "OFRORN", JdeDataType.String, 16),
        new JdeField("OFLNID", "OFLNID", JdeDataType.Numeric),
        new JdeField("OFPTWO", "OFPTWO", JdeDataType.Numeric),
        new JdeField("OFPARS", "OFPARS", JdeDataType.String, 16),
        new JdeField("OFTYPS", "OFTYPS", JdeDataType.String, 2),
        new JdeField("OFPRTS", "OFPRTS", JdeDataType.String, 2),
        new JdeField("OFDL01", "OFDL01", JdeDataType.String, 60),
        new JdeField("OFSTCM", "OFSTCM", JdeDataType.String, 60),
        new JdeField("OFCO", "OFCO", JdeDataType.String, 10),
        new JdeField("OFMCU", "OFMCU", JdeDataType.String, 24),
        new JdeField("OFMMCU", "OFMMCU", JdeDataType.String, 24),
        new JdeField("OFLOCN", "OFLOCN", JdeDataType.String, 40),
        new JdeField("OFAISL", "OFAISL", JdeDataType.String, 16),
        new JdeField("OFBIN", "OFBIN", JdeDataType.String, 16),
        new JdeField("OFSRST", "OFSRST", JdeDataType.String, 4),
        new JdeField("OFDCG", "OFDCG", JdeDataType.Numeric),
        new JdeField("OFSUB", "OFSUB", JdeDataType.String, 16),
        new JdeField("OFAN8", "OFAN8", JdeDataType.Numeric),
        new JdeField("OFANO", "OFANO", JdeDataType.Numeric),
        new JdeField("OFANSA", "OFANSA", JdeDataType.Numeric),
        new JdeField("OFANPA", "OFANPA", JdeDataType.Numeric),
        new JdeField("OFANP", "OFANP", JdeDataType.Numeric),
        new JdeField("OFDPL", "OFDPL", JdeDataType.Numeric),
        new JdeField("OFANT", "OFANT", JdeDataType.Numeric),
        new JdeField("OFNAN8", "OFNAN8", JdeDataType.Numeric),
        new JdeField("OFTRDJ", "OFTRDJ", JdeDataType.Numeric),
        new JdeField("OFSTRT", "OFSTRT", JdeDataType.Numeric),
        new JdeField("OFDRQJ", "OFDRQJ", JdeDataType.Numeric),
        new JdeField("OFSTRX", "OFSTRX", JdeDataType.Numeric),
        new JdeField("OFDAP", "OFDAP", JdeDataType.Numeric),
        new JdeField("OFDAT", "OFDAT", JdeDataType.Numeric),
        new JdeField("OFPPDT", "OFPPDT", JdeDataType.Numeric),
        new JdeField("OFWR01", "OFWR01", JdeDataType.String, 8),
        new JdeField("OFWR02", "OFWR02", JdeDataType.String, 6),
        new JdeField("OFWR03", "OFWR03", JdeDataType.String, 6),
        new JdeField("OFWR04", "OFWR04", JdeDataType.String, 6),
        new JdeField("OFWR05", "OFWR05", JdeDataType.String, 6),
        new JdeField("OFWR06", "OFWR06", JdeDataType.String, 6),
        new JdeField("OFWR07", "OFWR07", JdeDataType.String, 6),
        new JdeField("OFWR08", "OFWR08", JdeDataType.String, 6),
        new JdeField("OFWR09", "OFWR09", JdeDataType.String, 6),
        new JdeField("OFWR10", "OFWR10", JdeDataType.String, 6),
        new JdeField("OFVR01", "OFVR01", JdeDataType.String, 50),
        new JdeField("OFVR02", "OFVR02", JdeDataType.String, 50),
        new JdeField("OFAMTO", "OFAMTO", JdeDataType.Numeric),
        new JdeField("OFSETC", "OFSETC", JdeDataType.Numeric),
        new JdeField("OFBRT", "OFBRT", JdeDataType.Numeric),
        new JdeField("OFPAYT", "OFPAYT", JdeDataType.String, 10),
        new JdeField("OFAMTC", "OFAMTC", JdeDataType.Numeric),
        new JdeField("OFHRSO", "OFHRSO", JdeDataType.Numeric),
        new JdeField("OFHRSC", "OFHRSC", JdeDataType.Numeric),
        new JdeField("OFAMTA", "OFAMTA", JdeDataType.Numeric),
        new JdeField("OFHRSA", "OFHRSA", JdeDataType.Numeric),
        new JdeField("OFSHNO", "OFSHNO", JdeDataType.String, 20),
        new JdeField("OFPBTM", "OFPBTM", JdeDataType.Numeric),
        new JdeField("OFTBM", "OFTBM", JdeDataType.String, 6),
        new JdeField("OFTRT", "OFTRT", JdeDataType.String, 6),
        new JdeField("OFSHTY", "OFSHTY", JdeDataType.String, 2),
        new JdeField("OFPEC", "OFPEC", JdeDataType.String, 2),
        new JdeField("OFPPFG", "OFPPFG", JdeDataType.String, 2),
        new JdeField("OFBM", "OFBM", JdeDataType.String, 2),
        new JdeField("OFRTG", "OFRTG", JdeDataType.String, 2),
        new JdeField("OFSPRT", "OFSPRT", JdeDataType.String, 2),
        new JdeField("OFUNCD", "OFUNCD", JdeDataType.String, 2),
        new JdeField("OFINDC", "OFINDC", JdeDataType.String, 2),
        new JdeField("OFRESC", "OFRESC", JdeDataType.Numeric),
        new JdeField("OFMOH", "OFMOH", JdeDataType.Numeric),
        new JdeField("OFTDT", "OFTDT", JdeDataType.Numeric),
        new JdeField("OFPOU", "OFPOU", JdeDataType.Numeric),
        new JdeField("OFPC", "OFPC", JdeDataType.Numeric),
        new JdeField("OFLTLV", "OFLTLV", JdeDataType.Numeric),
        new JdeField("OFLTCM", "OFLTCM", JdeDataType.Numeric),
        new JdeField("OFCTS1", "OFCTS1", JdeDataType.Numeric),
        new JdeField("OFLOTN", "OFLOTN", JdeDataType.String, 60),
        new JdeField("OFLOTP", "OFLOTP", JdeDataType.Numeric),
        new JdeField("OFLOTG", "OFLOTG", JdeDataType.String, 6),
        new JdeField("OFRAT1", "OFRAT1", JdeDataType.Numeric),
        new JdeField("OFRAT2", "OFRAT2", JdeDataType.Numeric),
        new JdeField("OFDCT", "OFDCT", JdeDataType.String, 4),
        new JdeField("OFSBLI", "OFSBLI", JdeDataType.String, 2),
        new JdeField("OFRKCO", "OFRKCO", JdeDataType.String, 10),
        new JdeField("OFBREV", "OFBREV", JdeDataType.String, 6),
        new JdeField("OFRREV", "OFRREV", JdeDataType.String, 6),
        new JdeField("OFDRWC", "OFDRWC", JdeDataType.String, 2),
        new JdeField("OFRTCH", "OFRTCH", JdeDataType.String, 2),
        new JdeField("OFPNRQ", "OFPNRQ", JdeDataType.String, 2),
        new JdeField("OFREAS", "OFREAS", JdeDataType.String, 4),
        new JdeField("OFPHSE", "OFPHSE", JdeDataType.String, 6),
        new JdeField("OFXDSP", "OFXDSP", JdeDataType.String, 6),
        new JdeField("OFBOMC", "OFBOMC", JdeDataType.String, 2),
        new JdeField("OFURCD", "OFURCD", JdeDataType.String, 4),
        new JdeField("OFURDT", "OFURDT", JdeDataType.Numeric),
        new JdeField("OFURAT", "OFURAT", JdeDataType.Numeric),
        new JdeField("OFURAB", "OFURAB", JdeDataType.Numeric),
        new JdeField("OFURRF", "OFURRF", JdeDataType.String, 30),
        new JdeField("OFUSER", "OFUSER", JdeDataType.String, 20),
        new JdeField("OFPID", "OFPID", JdeDataType.String, 20),
        new JdeField("OFJOBN", "OFJOBN", JdeDataType.String, 20),
        new JdeField("OFUPMJ", "OFUPMJ", JdeDataType.Numeric),
        new JdeField("OFTDAY", "OFTDAY", JdeDataType.Numeric),
        new JdeField("OFAAID", "OFAAID", JdeDataType.Numeric),
        new JdeField("OFNTST", "OFNTST", JdeDataType.String, 4),
        new JdeField("OFXRTO", "OFXRTO", JdeDataType.Numeric),
        new JdeField("OFESDN", "OFESDN", JdeDataType.Numeric),
        new JdeField("OFACDN", "OFACDN", JdeDataType.Numeric),
        new JdeField("OFSAID", "OFSAID", JdeDataType.Numeric),
        new JdeField("OFMPOS", "OFMPOS", JdeDataType.Numeric),
        new JdeField("OFAPRT", "OFAPRT", JdeDataType.String, 6),
        new JdeField("OFAMLC", "OFAMLC", JdeDataType.Numeric),
        new JdeField("OFAMMC", "OFAMMC", JdeDataType.Numeric),
        new JdeField("OFAMOT", "OFAMOT", JdeDataType.Numeric),
        new JdeField("OFLBAM", "OFLBAM", JdeDataType.Numeric),
        new JdeField("OFMTAM", "OFMTAM", JdeDataType.Numeric),
        new JdeField("OFC9COLL", "OFC9COLL", JdeDataType.String, 20),
        new JdeField("OFC9SEAC", "OFC9SEAC", JdeDataType.String, 4),
        new JdeField("OFC9SEAY", "OFC9SEAY", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW65_0", "Primary Key on OFC9LANC", new[] { "OFC9LANC" }, isUnique: true, isPrimaryKey: true)
    };
}
