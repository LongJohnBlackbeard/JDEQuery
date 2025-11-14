using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3111Z1 - .
/// </summary>
public class F3111Z1 : JdeTable
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
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

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
        /// SZTBM.
        /// </summary>
        public const string SZTBM = "SZTBM";

        /// <summary>
        /// SZFORQ.
        /// </summary>
        public const string SZFORQ = "SZFORQ";

        /// <summary>
        /// SZITC.
        /// </summary>
        public const string SZITC = "SZITC";

        /// <summary>
        /// SZCOBY.
        /// </summary>
        public const string SZCOBY = "SZCOBY";

        /// <summary>
        /// SZCOTY.
        /// </summary>
        public const string SZCOTY = "SZCOTY";

        /// <summary>
        /// SZCPNT.
        /// </summary>
        public const string SZCPNT = "SZCPNT";

        /// <summary>
        /// SZFRMP.
        /// </summary>
        public const string SZFRMP = "SZFRMP";

        /// <summary>
        /// SZTHRP.
        /// </summary>
        public const string SZTHRP = "SZTHRP";

        /// <summary>
        /// SZFRGD.
        /// </summary>
        public const string SZFRGD = "SZFRGD";

        /// <summary>
        /// SZTHGD.
        /// </summary>
        public const string SZTHGD = "SZTHGD";

        /// <summary>
        /// SZRKCO.
        /// </summary>
        public const string SZRKCO = "SZRKCO";

        /// <summary>
        /// SZRORN.
        /// </summary>
        public const string SZRORN = "SZRORN";

        /// <summary>
        /// SZRCTO.
        /// </summary>
        public const string SZRCTO = "SZRCTO";

        /// <summary>
        /// SZRLLN.
        /// </summary>
        public const string SZRLLN = "SZRLLN";

        /// <summary>
        /// SZOPSQ.
        /// </summary>
        public const string SZOPSQ = "SZOPSQ";

        /// <summary>
        /// SZBSEQ.
        /// </summary>
        public const string SZBSEQ = "SZBSEQ";

        /// <summary>
        /// SZRSCP.
        /// </summary>
        public const string SZRSCP = "SZRSCP";

        /// <summary>
        /// SZSCRP.
        /// </summary>
        public const string SZSCRP = "SZSCRP";

        /// <summary>
        /// SZREWP.
        /// </summary>
        public const string SZREWP = "SZREWP";

        /// <summary>
        /// SZASIP.
        /// </summary>
        public const string SZASIP = "SZASIP";

        /// <summary>
        /// SZCPYP.
        /// </summary>
        public const string SZCPYP = "SZCPYP";

        /// <summary>
        /// SZSTPP.
        /// </summary>
        public const string SZSTPP = "SZSTPP";

        /// <summary>
        /// SZLOVD.
        /// </summary>
        public const string SZLOVD = "SZLOVD";

        /// <summary>
        /// SZCPIT.
        /// </summary>
        public const string SZCPIT = "SZCPIT";

        /// <summary>
        /// SZCPIL.
        /// </summary>
        public const string SZCPIL = "SZCPIL";

        /// <summary>
        /// SZCPIA.
        /// </summary>
        public const string SZCPIA = "SZCPIA";

        /// <summary>
        /// SZCMCU.
        /// </summary>
        public const string SZCMCU = "SZCMCU";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZDSC2.
        /// </summary>
        public const string SZDSC2 = "SZDSC2";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZLOTN.
        /// </summary>
        public const string SZLOTN = "SZLOTN";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZLNTY.
        /// </summary>
        public const string SZLNTY = "SZLNTY";

        /// <summary>
        /// SZSERN.
        /// </summary>
        public const string SZSERN = "SZSERN";

        /// <summary>
        /// SZTRDJ.
        /// </summary>
        public const string SZTRDJ = "SZTRDJ";

        /// <summary>
        /// SZDRQJ.
        /// </summary>
        public const string SZDRQJ = "SZDRQJ";

        /// <summary>
        /// SZUORG.
        /// </summary>
        public const string SZUORG = "SZUORG";

        /// <summary>
        /// SZTRQT.
        /// </summary>
        public const string SZTRQT = "SZTRQT";

        /// <summary>
        /// SZSOCN.
        /// </summary>
        public const string SZSOCN = "SZSOCN";

        /// <summary>
        /// SZSOBK.
        /// </summary>
        public const string SZSOBK = "SZSOBK";

        /// <summary>
        /// SZCTS1.
        /// </summary>
        public const string SZCTS1 = "SZCTS1";

        /// <summary>
        /// SZQNTA.
        /// </summary>
        public const string SZQNTA = "SZQNTA";

        /// <summary>
        /// SZUM.
        /// </summary>
        public const string SZUM = "SZUM";

        /// <summary>
        /// SZEA.
        /// </summary>
        public const string SZEA = "SZEA";

        /// <summary>
        /// SZRTG.
        /// </summary>
        public const string SZRTG = "SZRTG";

        /// <summary>
        /// SZMTST.
        /// </summary>
        public const string SZMTST = "SZMTST";

        /// <summary>
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

        /// <summary>
        /// SZSHNO.
        /// </summary>
        public const string SZSHNO = "SZSHNO";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZOMCU.
        /// </summary>
        public const string SZOMCU = "SZOMCU";

        /// <summary>
        /// SZOBJ.
        /// </summary>
        public const string SZOBJ = "SZOBJ";

        /// <summary>
        /// SZSUB.
        /// </summary>
        public const string SZSUB = "SZSUB";

        /// <summary>
        /// SZCMRV.
        /// </summary>
        public const string SZCMRV = "SZCMRV";

        /// <summary>
        /// SZSTRX.
        /// </summary>
        public const string SZSTRX = "SZSTRX";

        /// <summary>
        /// SZPARS.
        /// </summary>
        public const string SZPARS = "SZPARS";

        /// <summary>
        /// SZCOMM.
        /// </summary>
        public const string SZCOMM = "SZCOMM";

        /// <summary>
        /// SZUKID.
        /// </summary>
        public const string SZUKID = "SZUKID";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

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
        /// SZPOC.
        /// </summary>
        public const string SZPOC = "SZPOC";

        /// <summary>
        /// SZVEND.
        /// </summary>
        public const string SZVEND = "SZVEND";

        /// <summary>
        /// SZCTS4.
        /// </summary>
        public const string SZCTS4 = "SZCTS4";

        /// <summary>
        /// SZCTS7.
        /// </summary>
        public const string SZCTS7 = "SZCTS7";

        /// <summary>
        /// SZCTS8.
        /// </summary>
        public const string SZCTS8 = "SZCTS8";

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

        /// <summary>
        /// SZGLD.
        /// </summary>
        public const string SZGLD = "SZGLD";

        /// <summary>
        /// SZSBFL.
        /// </summary>
        public const string SZSBFL = "SZSBFL";

        /// <summary>
        /// SZAING.
        /// </summary>
        public const string SZAING = "SZAING";

        /// <summary>
        /// SZSSTQ.
        /// </summary>
        public const string SZSSTQ = "SZSSTQ";

        /// <summary>
        /// SZUOM2.
        /// </summary>
        public const string SZUOM2 = "SZUOM2";

        /// <summary>
        /// SZAPSC.
        /// </summary>
        public const string SZAPSC = "SZAPSC";

        /// <summary>
        /// SZPSN.
        /// </summary>
        public const string SZPSN = "SZPSN";

        /// <summary>
        /// SZDLEJ.
        /// </summary>
        public const string SZDLEJ = "SZDLEJ";

        /// <summary>
        /// SZCOST.
        /// </summary>
        public const string SZCOST = "SZCOST";

        /// <summary>
        /// SZCHPP.
        /// </summary>
        public const string SZCHPP = "SZCHPP";

        /// <summary>
        /// SZCPNB.
        /// </summary>
        public const string SZCPNB = "SZCPNB";

        /// <summary>
        /// SZBSEQAN.
        /// </summary>
        public const string SZBSEQAN = "SZBSEQAN";
    }

    /// <inheritdoc />
    public override string TableName => "F3111Z1";

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
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZTBM", "SZTBM", JdeDataType.String, 6),
        new JdeField("SZFORQ", "SZFORQ", JdeDataType.String, 2),
        new JdeField("SZITC", "SZITC", JdeDataType.String, 2),
        new JdeField("SZCOBY", "SZCOBY", JdeDataType.String, 2),
        new JdeField("SZCOTY", "SZCOTY", JdeDataType.String, 2),
        new JdeField("SZCPNT", "SZCPNT", JdeDataType.Numeric),
        new JdeField("SZFRMP", "SZFRMP", JdeDataType.Numeric),
        new JdeField("SZTHRP", "SZTHRP", JdeDataType.Numeric),
        new JdeField("SZFRGD", "SZFRGD", JdeDataType.String, 6),
        new JdeField("SZTHGD", "SZTHGD", JdeDataType.String, 6),
        new JdeField("SZRKCO", "SZRKCO", JdeDataType.String, 10),
        new JdeField("SZRORN", "SZRORN", JdeDataType.String, 16),
        new JdeField("SZRCTO", "SZRCTO", JdeDataType.String, 4),
        new JdeField("SZRLLN", "SZRLLN", JdeDataType.Numeric),
        new JdeField("SZOPSQ", "SZOPSQ", JdeDataType.Numeric),
        new JdeField("SZBSEQ", "SZBSEQ", JdeDataType.Numeric),
        new JdeField("SZRSCP", "SZRSCP", JdeDataType.Numeric),
        new JdeField("SZSCRP", "SZSCRP", JdeDataType.Numeric),
        new JdeField("SZREWP", "SZREWP", JdeDataType.Numeric),
        new JdeField("SZASIP", "SZASIP", JdeDataType.Numeric),
        new JdeField("SZCPYP", "SZCPYP", JdeDataType.Numeric),
        new JdeField("SZSTPP", "SZSTPP", JdeDataType.Numeric),
        new JdeField("SZLOVD", "SZLOVD", JdeDataType.Numeric),
        new JdeField("SZCPIT", "SZCPIT", JdeDataType.Numeric),
        new JdeField("SZCPIL", "SZCPIL", JdeDataType.String, 50),
        new JdeField("SZCPIA", "SZCPIA", JdeDataType.String, 50),
        new JdeField("SZCMCU", "SZCMCU", JdeDataType.String, 24),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZLOTN", "SZLOTN", JdeDataType.String, 60),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZSERN", "SZSERN", JdeDataType.String, 60),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZDRQJ", "SZDRQJ", JdeDataType.Numeric),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZTRQT", "SZTRQT", JdeDataType.Numeric),
        new JdeField("SZSOCN", "SZSOCN", JdeDataType.Numeric),
        new JdeField("SZSOBK", "SZSOBK", JdeDataType.Numeric),
        new JdeField("SZCTS1", "SZCTS1", JdeDataType.Numeric),
        new JdeField("SZQNTA", "SZQNTA", JdeDataType.Numeric),
        new JdeField("SZUM", "SZUM", JdeDataType.String, 4),
        new JdeField("SZEA", "SZEA", JdeDataType.Numeric),
        new JdeField("SZRTG", "SZRTG", JdeDataType.String, 2),
        new JdeField("SZMTST", "SZMTST", JdeDataType.String, 4),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZSHNO", "SZSHNO", JdeDataType.String, 20),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZOMCU", "SZOMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZCMRV", "SZCMRV", JdeDataType.String, 6),
        new JdeField("SZSTRX", "SZSTRX", JdeDataType.Numeric),
        new JdeField("SZPARS", "SZPARS", JdeDataType.String, 16),
        new JdeField("SZCOMM", "SZCOMM", JdeDataType.String, 2),
        new JdeField("SZUKID", "SZUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZPOC", "SZPOC", JdeDataType.String, 2),
        new JdeField("SZVEND", "SZVEND", JdeDataType.Numeric),
        new JdeField("SZCTS4", "SZCTS4", JdeDataType.Numeric),
        new JdeField("SZCTS7", "SZCTS7", JdeDataType.Numeric),
        new JdeField("SZCTS8", "SZCTS8", JdeDataType.Numeric),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZGLD", "SZGLD", JdeDataType.Numeric),
        new JdeField("SZSBFL", "SZSBFL", JdeDataType.String, 2),
        new JdeField("SZAING", "SZAING", JdeDataType.String, 2),
        new JdeField("SZSSTQ", "SZSSTQ", JdeDataType.Numeric),
        new JdeField("SZUOM2", "SZUOM2", JdeDataType.String, 4),
        new JdeField("SZAPSC", "SZAPSC", JdeDataType.String, 2),
        new JdeField("SZPSN", "SZPSN", JdeDataType.Numeric),
        new JdeField("SZDLEJ", "SZDLEJ", JdeDataType.Numeric),
        new JdeField("SZCOST", "SZCOST", JdeDataType.String, 6),
        new JdeField("SZCHPP", "SZCHPP", JdeDataType.String, 2),
        new JdeField("SZCPNB", "SZCPNB", JdeDataType.Numeric),
        new JdeField("SZBSEQAN", "SZBSEQAN", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3111Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN, SZUKID", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN", "SZUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3111Z1_2", "Index on SZEDUS, SZEDBT, SZEDTN, SZEDLN, SZOPSQ", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN", "SZOPSQ" })
    };
}
