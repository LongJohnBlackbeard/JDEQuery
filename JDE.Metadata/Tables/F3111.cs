using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3111 - .
/// </summary>
public class F3111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMDOCO.
        /// </summary>
        public const string WMDOCO = "WMDOCO";

        /// <summary>
        /// WMDCTO.
        /// </summary>
        public const string WMDCTO = "WMDCTO";

        /// <summary>
        /// WMSFXO.
        /// </summary>
        public const string WMSFXO = "WMSFXO";

        /// <summary>
        /// WMTBM.
        /// </summary>
        public const string WMTBM = "WMTBM";

        /// <summary>
        /// WMFORQ.
        /// </summary>
        public const string WMFORQ = "WMFORQ";

        /// <summary>
        /// WMITC.
        /// </summary>
        public const string WMITC = "WMITC";

        /// <summary>
        /// WMCOBY.
        /// </summary>
        public const string WMCOBY = "WMCOBY";

        /// <summary>
        /// WMCOTY.
        /// </summary>
        public const string WMCOTY = "WMCOTY";

        /// <summary>
        /// WMCPNT.
        /// </summary>
        public const string WMCPNT = "WMCPNT";

        /// <summary>
        /// WMFRMP.
        /// </summary>
        public const string WMFRMP = "WMFRMP";

        /// <summary>
        /// WMTHRP.
        /// </summary>
        public const string WMTHRP = "WMTHRP";

        /// <summary>
        /// WMFRGD.
        /// </summary>
        public const string WMFRGD = "WMFRGD";

        /// <summary>
        /// WMTHGD.
        /// </summary>
        public const string WMTHGD = "WMTHGD";

        /// <summary>
        /// WMRKCO.
        /// </summary>
        public const string WMRKCO = "WMRKCO";

        /// <summary>
        /// WMRORN.
        /// </summary>
        public const string WMRORN = "WMRORN";

        /// <summary>
        /// WMRCTO.
        /// </summary>
        public const string WMRCTO = "WMRCTO";

        /// <summary>
        /// WMRLLN.
        /// </summary>
        public const string WMRLLN = "WMRLLN";

        /// <summary>
        /// WMOPSQ.
        /// </summary>
        public const string WMOPSQ = "WMOPSQ";

        /// <summary>
        /// WMBSEQ.
        /// </summary>
        public const string WMBSEQ = "WMBSEQ";

        /// <summary>
        /// WMRSCP.
        /// </summary>
        public const string WMRSCP = "WMRSCP";

        /// <summary>
        /// WMSCRP.
        /// </summary>
        public const string WMSCRP = "WMSCRP";

        /// <summary>
        /// WMREWP.
        /// </summary>
        public const string WMREWP = "WMREWP";

        /// <summary>
        /// WMASIP.
        /// </summary>
        public const string WMASIP = "WMASIP";

        /// <summary>
        /// WMCPYP.
        /// </summary>
        public const string WMCPYP = "WMCPYP";

        /// <summary>
        /// WMSTPP.
        /// </summary>
        public const string WMSTPP = "WMSTPP";

        /// <summary>
        /// WMLOVD.
        /// </summary>
        public const string WMLOVD = "WMLOVD";

        /// <summary>
        /// WMCPIT.
        /// </summary>
        public const string WMCPIT = "WMCPIT";

        /// <summary>
        /// WMCPIL.
        /// </summary>
        public const string WMCPIL = "WMCPIL";

        /// <summary>
        /// WMCPIA.
        /// </summary>
        public const string WMCPIA = "WMCPIA";

        /// <summary>
        /// WMCMCU.
        /// </summary>
        public const string WMCMCU = "WMCMCU";

        /// <summary>
        /// WMDSC1.
        /// </summary>
        public const string WMDSC1 = "WMDSC1";

        /// <summary>
        /// WMDSC2.
        /// </summary>
        public const string WMDSC2 = "WMDSC2";

        /// <summary>
        /// WMLOCN.
        /// </summary>
        public const string WMLOCN = "WMLOCN";

        /// <summary>
        /// WMLOTN.
        /// </summary>
        public const string WMLOTN = "WMLOTN";

        /// <summary>
        /// WMAN8.
        /// </summary>
        public const string WMAN8 = "WMAN8";

        /// <summary>
        /// WMLNTY.
        /// </summary>
        public const string WMLNTY = "WMLNTY";

        /// <summary>
        /// WMSERN.
        /// </summary>
        public const string WMSERN = "WMSERN";

        /// <summary>
        /// WMTRDJ.
        /// </summary>
        public const string WMTRDJ = "WMTRDJ";

        /// <summary>
        /// WMDRQJ.
        /// </summary>
        public const string WMDRQJ = "WMDRQJ";

        /// <summary>
        /// WMUORG.
        /// </summary>
        public const string WMUORG = "WMUORG";

        /// <summary>
        /// WMTRQT.
        /// </summary>
        public const string WMTRQT = "WMTRQT";

        /// <summary>
        /// WMSOCN.
        /// </summary>
        public const string WMSOCN = "WMSOCN";

        /// <summary>
        /// WMSOBK.
        /// </summary>
        public const string WMSOBK = "WMSOBK";

        /// <summary>
        /// WMCTS1.
        /// </summary>
        public const string WMCTS1 = "WMCTS1";

        /// <summary>
        /// WMQNTA.
        /// </summary>
        public const string WMQNTA = "WMQNTA";

        /// <summary>
        /// WMUM.
        /// </summary>
        public const string WMUM = "WMUM";

        /// <summary>
        /// WMEA.
        /// </summary>
        public const string WMEA = "WMEA";

        /// <summary>
        /// WMRTG.
        /// </summary>
        public const string WMRTG = "WMRTG";

        /// <summary>
        /// WMMTST.
        /// </summary>
        public const string WMMTST = "WMMTST";

        /// <summary>
        /// WMDCT.
        /// </summary>
        public const string WMDCT = "WMDCT";

        /// <summary>
        /// WMSHNO.
        /// </summary>
        public const string WMSHNO = "WMSHNO";

        /// <summary>
        /// WMMCU.
        /// </summary>
        public const string WMMCU = "WMMCU";

        /// <summary>
        /// WMOMCU.
        /// </summary>
        public const string WMOMCU = "WMOMCU";

        /// <summary>
        /// WMOBJ.
        /// </summary>
        public const string WMOBJ = "WMOBJ";

        /// <summary>
        /// WMSUB.
        /// </summary>
        public const string WMSUB = "WMSUB";

        /// <summary>
        /// WMCMRV.
        /// </summary>
        public const string WMCMRV = "WMCMRV";

        /// <summary>
        /// WMSTRX.
        /// </summary>
        public const string WMSTRX = "WMSTRX";

        /// <summary>
        /// WMPARS.
        /// </summary>
        public const string WMPARS = "WMPARS";

        /// <summary>
        /// WMCOMM.
        /// </summary>
        public const string WMCOMM = "WMCOMM";

        /// <summary>
        /// WMURCD.
        /// </summary>
        public const string WMURCD = "WMURCD";

        /// <summary>
        /// WMURDT.
        /// </summary>
        public const string WMURDT = "WMURDT";

        /// <summary>
        /// WMURAT.
        /// </summary>
        public const string WMURAT = "WMURAT";

        /// <summary>
        /// WMURRF.
        /// </summary>
        public const string WMURRF = "WMURRF";

        /// <summary>
        /// WMURAB.
        /// </summary>
        public const string WMURAB = "WMURAB";

        /// <summary>
        /// WMUSER.
        /// </summary>
        public const string WMUSER = "WMUSER";

        /// <summary>
        /// WMPID.
        /// </summary>
        public const string WMPID = "WMPID";

        /// <summary>
        /// WMJOBN.
        /// </summary>
        public const string WMJOBN = "WMJOBN";

        /// <summary>
        /// WMUPMJ.
        /// </summary>
        public const string WMUPMJ = "WMUPMJ";

        /// <summary>
        /// WMTDAY.
        /// </summary>
        public const string WMTDAY = "WMTDAY";

        /// <summary>
        /// WMUKID.
        /// </summary>
        public const string WMUKID = "WMUKID";

        /// <summary>
        /// WMVEND.
        /// </summary>
        public const string WMVEND = "WMVEND";

        /// <summary>
        /// WMPOC.
        /// </summary>
        public const string WMPOC = "WMPOC";

        /// <summary>
        /// WMCTS4.
        /// </summary>
        public const string WMCTS4 = "WMCTS4";

        /// <summary>
        /// WMCTS7.
        /// </summary>
        public const string WMCTS7 = "WMCTS7";

        /// <summary>
        /// WMCTS8.
        /// </summary>
        public const string WMCTS8 = "WMCTS8";

        /// <summary>
        /// WMGLD.
        /// </summary>
        public const string WMGLD = "WMGLD";

        /// <summary>
        /// WMSBFL.
        /// </summary>
        public const string WMSBFL = "WMSBFL";

        /// <summary>
        /// WMAING.
        /// </summary>
        public const string WMAING = "WMAING";

        /// <summary>
        /// WMSSTQ.
        /// </summary>
        public const string WMSSTQ = "WMSSTQ";

        /// <summary>
        /// WMUOM2.
        /// </summary>
        public const string WMUOM2 = "WMUOM2";

        /// <summary>
        /// WMAPSC.
        /// </summary>
        public const string WMAPSC = "WMAPSC";

        /// <summary>
        /// WMPSN.
        /// </summary>
        public const string WMPSN = "WMPSN";

        /// <summary>
        /// WMDLEJ.
        /// </summary>
        public const string WMDLEJ = "WMDLEJ";

        /// <summary>
        /// WMCOST.
        /// </summary>
        public const string WMCOST = "WMCOST";

        /// <summary>
        /// WMCHPP.
        /// </summary>
        public const string WMCHPP = "WMCHPP";

        /// <summary>
        /// WMCPNB.
        /// </summary>
        public const string WMCPNB = "WMCPNB";

        /// <summary>
        /// WMBSEQAN.
        /// </summary>
        public const string WMBSEQAN = "WMBSEQAN";
    }

    /// <inheritdoc />
    public override string TableName => "F3111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMDOCO", "WMDOCO", JdeDataType.Numeric),
        new JdeField("WMDCTO", "WMDCTO", JdeDataType.String, 4),
        new JdeField("WMSFXO", "WMSFXO", JdeDataType.String, 6),
        new JdeField("WMTBM", "WMTBM", JdeDataType.String, 6),
        new JdeField("WMFORQ", "WMFORQ", JdeDataType.String, 2),
        new JdeField("WMITC", "WMITC", JdeDataType.String, 2),
        new JdeField("WMCOBY", "WMCOBY", JdeDataType.String, 2),
        new JdeField("WMCOTY", "WMCOTY", JdeDataType.String, 2),
        new JdeField("WMCPNT", "WMCPNT", JdeDataType.Numeric),
        new JdeField("WMFRMP", "WMFRMP", JdeDataType.Numeric),
        new JdeField("WMTHRP", "WMTHRP", JdeDataType.Numeric),
        new JdeField("WMFRGD", "WMFRGD", JdeDataType.String, 6),
        new JdeField("WMTHGD", "WMTHGD", JdeDataType.String, 6),
        new JdeField("WMRKCO", "WMRKCO", JdeDataType.String, 10),
        new JdeField("WMRORN", "WMRORN", JdeDataType.String, 16),
        new JdeField("WMRCTO", "WMRCTO", JdeDataType.String, 4),
        new JdeField("WMRLLN", "WMRLLN", JdeDataType.Numeric),
        new JdeField("WMOPSQ", "WMOPSQ", JdeDataType.Numeric),
        new JdeField("WMBSEQ", "WMBSEQ", JdeDataType.Numeric),
        new JdeField("WMRSCP", "WMRSCP", JdeDataType.Numeric),
        new JdeField("WMSCRP", "WMSCRP", JdeDataType.Numeric),
        new JdeField("WMREWP", "WMREWP", JdeDataType.Numeric),
        new JdeField("WMASIP", "WMASIP", JdeDataType.Numeric),
        new JdeField("WMCPYP", "WMCPYP", JdeDataType.Numeric),
        new JdeField("WMSTPP", "WMSTPP", JdeDataType.Numeric),
        new JdeField("WMLOVD", "WMLOVD", JdeDataType.Numeric),
        new JdeField("WMCPIT", "WMCPIT", JdeDataType.Numeric),
        new JdeField("WMCPIL", "WMCPIL", JdeDataType.String, 50),
        new JdeField("WMCPIA", "WMCPIA", JdeDataType.String, 50),
        new JdeField("WMCMCU", "WMCMCU", JdeDataType.String, 24),
        new JdeField("WMDSC1", "WMDSC1", JdeDataType.String, 60),
        new JdeField("WMDSC2", "WMDSC2", JdeDataType.String, 60),
        new JdeField("WMLOCN", "WMLOCN", JdeDataType.String, 40),
        new JdeField("WMLOTN", "WMLOTN", JdeDataType.String, 60),
        new JdeField("WMAN8", "WMAN8", JdeDataType.Numeric),
        new JdeField("WMLNTY", "WMLNTY", JdeDataType.String, 4),
        new JdeField("WMSERN", "WMSERN", JdeDataType.String, 60),
        new JdeField("WMTRDJ", "WMTRDJ", JdeDataType.Numeric),
        new JdeField("WMDRQJ", "WMDRQJ", JdeDataType.Numeric),
        new JdeField("WMUORG", "WMUORG", JdeDataType.Numeric),
        new JdeField("WMTRQT", "WMTRQT", JdeDataType.Numeric),
        new JdeField("WMSOCN", "WMSOCN", JdeDataType.Numeric),
        new JdeField("WMSOBK", "WMSOBK", JdeDataType.Numeric),
        new JdeField("WMCTS1", "WMCTS1", JdeDataType.Numeric),
        new JdeField("WMQNTA", "WMQNTA", JdeDataType.Numeric),
        new JdeField("WMUM", "WMUM", JdeDataType.String, 4),
        new JdeField("WMEA", "WMEA", JdeDataType.Numeric),
        new JdeField("WMRTG", "WMRTG", JdeDataType.String, 2),
        new JdeField("WMMTST", "WMMTST", JdeDataType.String, 4),
        new JdeField("WMDCT", "WMDCT", JdeDataType.String, 4),
        new JdeField("WMSHNO", "WMSHNO", JdeDataType.String, 20),
        new JdeField("WMMCU", "WMMCU", JdeDataType.String, 24),
        new JdeField("WMOMCU", "WMOMCU", JdeDataType.String, 24),
        new JdeField("WMOBJ", "WMOBJ", JdeDataType.String, 12),
        new JdeField("WMSUB", "WMSUB", JdeDataType.String, 16),
        new JdeField("WMCMRV", "WMCMRV", JdeDataType.String, 6),
        new JdeField("WMSTRX", "WMSTRX", JdeDataType.Numeric),
        new JdeField("WMPARS", "WMPARS", JdeDataType.String, 16),
        new JdeField("WMCOMM", "WMCOMM", JdeDataType.String, 2),
        new JdeField("WMURCD", "WMURCD", JdeDataType.String, 4),
        new JdeField("WMURDT", "WMURDT", JdeDataType.Numeric),
        new JdeField("WMURAT", "WMURAT", JdeDataType.Numeric),
        new JdeField("WMURRF", "WMURRF", JdeDataType.String, 30),
        new JdeField("WMURAB", "WMURAB", JdeDataType.Numeric),
        new JdeField("WMUSER", "WMUSER", JdeDataType.String, 20),
        new JdeField("WMPID", "WMPID", JdeDataType.String, 20),
        new JdeField("WMJOBN", "WMJOBN", JdeDataType.String, 20),
        new JdeField("WMUPMJ", "WMUPMJ", JdeDataType.Numeric),
        new JdeField("WMTDAY", "WMTDAY", JdeDataType.Numeric),
        new JdeField("WMUKID", "WMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WMVEND", "WMVEND", JdeDataType.Numeric),
        new JdeField("WMPOC", "WMPOC", JdeDataType.String, 2),
        new JdeField("WMCTS4", "WMCTS4", JdeDataType.Numeric),
        new JdeField("WMCTS7", "WMCTS7", JdeDataType.Numeric),
        new JdeField("WMCTS8", "WMCTS8", JdeDataType.Numeric),
        new JdeField("WMGLD", "WMGLD", JdeDataType.Numeric),
        new JdeField("WMSBFL", "WMSBFL", JdeDataType.String, 2),
        new JdeField("WMAING", "WMAING", JdeDataType.String, 2),
        new JdeField("WMSSTQ", "WMSSTQ", JdeDataType.Numeric),
        new JdeField("WMUOM2", "WMUOM2", JdeDataType.String, 4),
        new JdeField("WMAPSC", "WMAPSC", JdeDataType.String, 2),
        new JdeField("WMPSN", "WMPSN", JdeDataType.Numeric),
        new JdeField("WMDLEJ", "WMDLEJ", JdeDataType.Numeric),
        new JdeField("WMCOST", "WMCOST", JdeDataType.String, 6),
        new JdeField("WMCHPP", "WMCHPP", JdeDataType.String, 2),
        new JdeField("WMCPNB", "WMCPNB", JdeDataType.Numeric),
        new JdeField("WMBSEQAN", "WMBSEQAN", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3111_0", "Primary Key on WMUKID", new[] { "WMUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3111_1", "Index on WMDOCO, WMOPSQ, WMBSEQ", new[] { "WMDOCO", "WMOPSQ", "WMBSEQ" }),
        new JdeIndex("F3111_11", "Index on WMCPIT, WMCMCU, WMLOCN, WMLOTN, WMDOCO", new[] { "WMCPIT", "WMCMCU", "WMLOCN", "WMLOTN", "WMDOCO" }),
        new JdeIndex("F3111_12", "Index on WMDOCO, WMOPSQ, WMCPNB", new[] { "WMDOCO", "WMOPSQ", "WMCPNB" }),
        new JdeIndex("F3111_13", "Index on WMDOCO, WMDCTO, WMCPNB", new[] { "WMDOCO", "WMDCTO", "WMCPNB" }),
        new JdeIndex("F3111_14", "Index on WMDOCO, WMRKCO, WMRORN, WMRCTO, WMRLLN, WMCPIT", new[] { "WMDOCO", "WMRKCO", "WMRORN", "WMRCTO", "WMRLLN", "WMCPIT" }),
        new JdeIndex("F3111_15", "Index on WMCOBY, WMDOCO, WMAING, WMOPSQ", new[] { "WMCOBY", "WMDOCO", "WMAING", "WMOPSQ" }),
        new JdeIndex("F3111_16", "Index on WMCPIT, WMCMCU, WMDOCO, SYS_NC00088$", new[] { "WMCPIT", "WMCMCU", "WMDOCO", "SYS_NC00088$" }),
        new JdeIndex("F3111_17", "Index on WMCMCU, WMCPIT", new[] { "WMCMCU", "WMCPIT" }),
        new JdeIndex("F3111_18", "Index on WMDOCO, WMOPSQ, WMLOTN", new[] { "WMDOCO", "WMOPSQ", "WMLOTN" }),
        new JdeIndex("F3111_19", "Index on WMITC", new[] { "WMITC" }),
        new JdeIndex("F3111_2", "Index on WMCPIT, WMCMCU, WMDRQJ", new[] { "WMCPIT", "WMCMCU", "WMDRQJ" }),
        new JdeIndex("F3111_20", "Index on WMLOTN", new[] { "WMLOTN" }),
        new JdeIndex("F3111_21", "Index on WMDOCO, SYS_NC00089$", new[] { "WMDOCO", "SYS_NC00089$" }),
        new JdeIndex("F3111_3", "Index on WMMCU, WMCPIT, WMCOBY, WMDOCO", new[] { "WMMCU", "WMCPIT", "WMCOBY", "WMDOCO" }),
        new JdeIndex("F3111_4", "Index on WMDOCO, WMOPSQ, WMDRQJ, WMCMCU, WMLOCN, WMLOTN, WMCPIT", new[] { "WMDOCO", "WMOPSQ", "WMDRQJ", "WMCMCU", "WMLOCN", "WMLOTN", "WMCPIT" }),
        new JdeIndex("F3111_5", "Index on WMDOCO, WMCPIT, WMCMCU, WMDRQJ", new[] { "WMDOCO", "WMCPIT", "WMCMCU", "WMDRQJ" }),
        new JdeIndex("F3111_6", "Index on WMCOBY, WMDOCO, WMOPSQ", new[] { "WMCOBY", "WMDOCO", "WMOPSQ" }),
        new JdeIndex("F3111_7", "Index on WMCOBY, WMCPIT, WMCMCU, WMDRQJ", new[] { "WMCOBY", "WMCPIT", "WMCMCU", "WMDRQJ" })
    };
}
