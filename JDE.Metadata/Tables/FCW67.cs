using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW67 - .
/// </summary>
public class FCW67 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMJOBS.
        /// </summary>
        public const string WMJOBS = "WMJOBS";

        /// <summary>
        /// WMC9LANC.
        /// </summary>
        public const string WMC9LANC = "WMC9LANC";

        /// <summary>
        /// WMC9LVL0.
        /// </summary>
        public const string WMC9LVL0 = "WMC9LVL0";

        /// <summary>
        /// WMC9LVL1.
        /// </summary>
        public const string WMC9LVL1 = "WMC9LVL1";

        /// <summary>
        /// WMC9LVL2.
        /// </summary>
        public const string WMC9LVL2 = "WMC9LVL2";

        /// <summary>
        /// WMC9LVL3.
        /// </summary>
        public const string WMC9LVL3 = "WMC9LVL3";

        /// <summary>
        /// WMC9LVL4.
        /// </summary>
        public const string WMC9LVL4 = "WMC9LVL4";

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
        /// WMPBTM.
        /// </summary>
        public const string WMPBTM = "WMPBTM";

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
        /// WMC9UORG.
        /// </summary>
        public const string WMC9UORG = "WMC9UORG";

        /// <summary>
        /// WMC9TRQT.
        /// </summary>
        public const string WMC9TRQT = "WMC9TRQT";

        /// <summary>
        /// WMC9SOCN.
        /// </summary>
        public const string WMC9SOCN = "WMC9SOCN";

        /// <summary>
        /// WMC9SOBK.
        /// </summary>
        public const string WMC9SOBK = "WMC9SOBK";

        /// <summary>
        /// WMC9QNTA.
        /// </summary>
        public const string WMC9QNTA = "WMC9QNTA";

        /// <summary>
        /// WMC9ITM.
        /// </summary>
        public const string WMC9ITM = "WMC9ITM";

        /// <summary>
        /// WMMMCU.
        /// </summary>
        public const string WMMMCU = "WMMMCU";

        /// <summary>
        /// WMC9LOCN.
        /// </summary>
        public const string WMC9LOCN = "WMC9LOCN";

        /// <summary>
        /// WMC9LOTN.
        /// </summary>
        public const string WMC9LOTN = "WMC9LOTN";

        /// <summary>
        /// WMLNID.
        /// </summary>
        public const string WMLNID = "WMLNID";

        /// <summary>
        /// WMC9LVNM.
        /// </summary>
        public const string WMC9LVNM = "WMC9LVNM";
    }

    /// <inheritdoc />
    public override string TableName => "FCW67";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMJOBS", "WMJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WMC9LANC", "WMC9LANC", JdeDataType.Numeric),
        new JdeField("WMC9LVL0", "WMC9LVL0", JdeDataType.String, 50),
        new JdeField("WMC9LVL1", "WMC9LVL1", JdeDataType.String, 12),
        new JdeField("WMC9LVL2", "WMC9LVL2", JdeDataType.String, 12),
        new JdeField("WMC9LVL3", "WMC9LVL3", JdeDataType.String, 12),
        new JdeField("WMC9LVL4", "WMC9LVL4", JdeDataType.String, 12),
        new JdeField("WMDCTO", "WMDCTO", JdeDataType.String, 4),
        new JdeField("WMSFXO", "WMSFXO", JdeDataType.String, 6),
        new JdeField("WMTBM", "WMTBM", JdeDataType.String, 6),
        new JdeField("WMFORQ", "WMFORQ", JdeDataType.String, 2),
        new JdeField("WMITC", "WMITC", JdeDataType.String, 2),
        new JdeField("WMCOBY", "WMCOBY", JdeDataType.String, 2),
        new JdeField("WMCOTY", "WMCOTY", JdeDataType.String, 2),
        new JdeField("WMCPNT", "WMCPNT", JdeDataType.Numeric, null, true, true),
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
        new JdeField("WMPBTM", "WMPBTM", JdeDataType.Numeric),
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
        new JdeField("WMC9UORG", "WMC9UORG", JdeDataType.Numeric),
        new JdeField("WMC9TRQT", "WMC9TRQT", JdeDataType.Numeric),
        new JdeField("WMC9SOCN", "WMC9SOCN", JdeDataType.Numeric),
        new JdeField("WMC9SOBK", "WMC9SOBK", JdeDataType.Numeric),
        new JdeField("WMC9QNTA", "WMC9QNTA", JdeDataType.Numeric),
        new JdeField("WMC9ITM", "WMC9ITM", JdeDataType.Numeric),
        new JdeField("WMMMCU", "WMMMCU", JdeDataType.String, 24),
        new JdeField("WMC9LOCN", "WMC9LOCN", JdeDataType.String, 40),
        new JdeField("WMC9LOTN", "WMC9LOTN", JdeDataType.String, 60),
        new JdeField("WMLNID", "WMLNID", JdeDataType.Numeric),
        new JdeField("WMC9LVNM", "WMC9LVNM", JdeDataType.String, 100)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW67_0", "Primary Key on WMJOBS, WMCPNT", new[] { "WMJOBS", "WMCPNT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW67_8", "Unique Index on WMJOBS, WMC9LANC, WMCPIT, WMMMCU, WMLOCN, WMLOTN, WMQNTA, WMCPNT", new[] { "WMJOBS", "WMC9LANC", "WMCPIT", "WMMMCU", "WMLOCN", "WMLOTN", "WMQNTA", "WMCPNT" }, isUnique: true)
    };
}
