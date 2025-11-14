using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H611 - .
/// </summary>
public class F44H611 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDKCOO.
        /// </summary>
        public const string BDKCOO = "BDKCOO";

        /// <summary>
        /// BDDOCO.
        /// </summary>
        public const string BDDOCO = "BDDOCO";

        /// <summary>
        /// BDDCTO.
        /// </summary>
        public const string BDDCTO = "BDDCTO";

        /// <summary>
        /// BDSFXO.
        /// </summary>
        public const string BDSFXO = "BDSFXO";

        /// <summary>
        /// BDLNID.
        /// </summary>
        public const string BDLNID = "BDLNID";

        /// <summary>
        /// BDHBAREA.
        /// </summary>
        public const string BDHBAREA = "BDHBAREA";

        /// <summary>
        /// BDMCU.
        /// </summary>
        public const string BDMCU = "BDMCU";

        /// <summary>
        /// BDANI.
        /// </summary>
        public const string BDANI = "BDANI";

        /// <summary>
        /// BDAID.
        /// </summary>
        public const string BDAID = "BDAID";

        /// <summary>
        /// BDCPHASE.
        /// </summary>
        public const string BDCPHASE = "BDCPHASE";

        /// <summary>
        /// BDOBJ.
        /// </summary>
        public const string BDOBJ = "BDOBJ";

        /// <summary>
        /// BDSUB.
        /// </summary>
        public const string BDSUB = "BDSUB";

        /// <summary>
        /// BDOPTION.
        /// </summary>
        public const string BDOPTION = "BDOPTION";

        /// <summary>
        /// BDHBPLAN.
        /// </summary>
        public const string BDHBPLAN = "BDHBPLAN";

        /// <summary>
        /// BDHBELEV.
        /// </summary>
        public const string BDHBELEV = "BDHBELEV";

        /// <summary>
        /// BDR001.
        /// </summary>
        public const string BDR001 = "BDR001";

        /// <summary>
        /// BDBIDTYPE.
        /// </summary>
        public const string BDBIDTYPE = "BDBIDTYPE";

        /// <summary>
        /// BDVNDAOVR.
        /// </summary>
        public const string BDVNDAOVR = "BDVNDAOVR";

        /// <summary>
        /// BDUNIDOC.
        /// </summary>
        public const string BDUNIDOC = "BDUNIDOC";

        /// <summary>
        /// BDBUDONLY.
        /// </summary>
        public const string BDBUDONLY = "BDBUDONLY";

        /// <summary>
        /// BDVNDTBD.
        /// </summary>
        public const string BDVNDTBD = "BDVNDTBD";

        /// <summary>
        /// BDAVEL.
        /// </summary>
        public const string BDAVEL = "BDAVEL";

        /// <summary>
        /// BDAN8.
        /// </summary>
        public const string BDAN8 = "BDAN8";

        /// <summary>
        /// BDSHAN.
        /// </summary>
        public const string BDSHAN = "BDSHAN";

        /// <summary>
        /// BDDGL.
        /// </summary>
        public const string BDDGL = "BDDGL";

        /// <summary>
        /// BDBDEFDT.
        /// </summary>
        public const string BDBDEFDT = "BDBDEFDT";

        /// <summary>
        /// BDBDCLDT.
        /// </summary>
        public const string BDBDCLDT = "BDBDCLDT";

        /// <summary>
        /// BDPDDJ.
        /// </summary>
        public const string BDPDDJ = "BDPDDJ";

        /// <summary>
        /// BDOPDJ.
        /// </summary>
        public const string BDOPDJ = "BDOPDJ";

        /// <summary>
        /// BDTRDJ.
        /// </summary>
        public const string BDTRDJ = "BDTRDJ";

        /// <summary>
        /// BDPN.
        /// </summary>
        public const string BDPN = "BDPN";

        /// <summary>
        /// BDVR01.
        /// </summary>
        public const string BDVR01 = "BDVR01";

        /// <summary>
        /// BDVR02.
        /// </summary>
        public const string BDVR02 = "BDVR02";

        /// <summary>
        /// BDITM.
        /// </summary>
        public const string BDITM = "BDITM";

        /// <summary>
        /// BDLITM.
        /// </summary>
        public const string BDLITM = "BDLITM";

        /// <summary>
        /// BDDSC1.
        /// </summary>
        public const string BDDSC1 = "BDDSC1";

        /// <summary>
        /// BDDSC2.
        /// </summary>
        public const string BDDSC2 = "BDDSC2";

        /// <summary>
        /// BDLNTY.
        /// </summary>
        public const string BDLNTY = "BDLNTY";

        /// <summary>
        /// BDNXTR.
        /// </summary>
        public const string BDNXTR = "BDNXTR";

        /// <summary>
        /// BDLTTR.
        /// </summary>
        public const string BDLTTR = "BDLTTR";

        /// <summary>
        /// BDPDP1.
        /// </summary>
        public const string BDPDP1 = "BDPDP1";

        /// <summary>
        /// BDPDP2.
        /// </summary>
        public const string BDPDP2 = "BDPDP2";

        /// <summary>
        /// BDPDP3.
        /// </summary>
        public const string BDPDP3 = "BDPDP3";

        /// <summary>
        /// BDPDP4.
        /// </summary>
        public const string BDPDP4 = "BDPDP4";

        /// <summary>
        /// BDPDP5.
        /// </summary>
        public const string BDPDP5 = "BDPDP5";

        /// <summary>
        /// BDUOM.
        /// </summary>
        public const string BDUOM = "BDUOM";

        /// <summary>
        /// BDPRRC.
        /// </summary>
        public const string BDPRRC = "BDPRRC";

        /// <summary>
        /// BDUORG.
        /// </summary>
        public const string BDUORG = "BDUORG";

        /// <summary>
        /// BDAEXP.
        /// </summary>
        public const string BDAEXP = "BDAEXP";

        /// <summary>
        /// BDPERFCTR.
        /// </summary>
        public const string BDPERFCTR = "BDPERFCTR";

        /// <summary>
        /// BDFTN1.
        /// </summary>
        public const string BDFTN1 = "BDFTN1";

        /// <summary>
        /// BDPTC.
        /// </summary>
        public const string BDPTC = "BDPTC";

        /// <summary>
        /// BDTX.
        /// </summary>
        public const string BDTX = "BDTX";

        /// <summary>
        /// BDEXR1.
        /// </summary>
        public const string BDEXR1 = "BDEXR1";

        /// <summary>
        /// BDTXA1.
        /// </summary>
        public const string BDTXA1 = "BDTXA1";

        /// <summary>
        /// BDANBY.
        /// </summary>
        public const string BDANBY = "BDANBY";

        /// <summary>
        /// BDGLC.
        /// </summary>
        public const string BDGLC = "BDGLC";

        /// <summary>
        /// BDCTRY.
        /// </summary>
        public const string BDCTRY = "BDCTRY";

        /// <summary>
        /// BDFY.
        /// </summary>
        public const string BDFY = "BDFY";

        /// <summary>
        /// BDRCD.
        /// </summary>
        public const string BDRCD = "BDRCD";

        /// <summary>
        /// BDFUF1.
        /// </summary>
        public const string BDFUF1 = "BDFUF1";

        /// <summary>
        /// BDFUF2.
        /// </summary>
        public const string BDFUF2 = "BDFUF2";

        /// <summary>
        /// BDLT.
        /// </summary>
        public const string BDLT = "BDLT";

        /// <summary>
        /// BDPCRT.
        /// </summary>
        public const string BDPCRT = "BDPCRT";

        /// <summary>
        /// BDRTNR.
        /// </summary>
        public const string BDRTNR = "BDRTNR";

        /// <summary>
        /// BDPURG.
        /// </summary>
        public const string BDPURG = "BDPURG";

        /// <summary>
        /// BDCRRM.
        /// </summary>
        public const string BDCRRM = "BDCRRM";

        /// <summary>
        /// BDCRCD.
        /// </summary>
        public const string BDCRCD = "BDCRCD";

        /// <summary>
        /// BDCRR.
        /// </summary>
        public const string BDCRR = "BDCRR";

        /// <summary>
        /// BDFRRC.
        /// </summary>
        public const string BDFRRC = "BDFRRC";

        /// <summary>
        /// BDFEA.
        /// </summary>
        public const string BDFEA = "BDFEA";

        /// <summary>
        /// BDFUC.
        /// </summary>
        public const string BDFUC = "BDFUC";

        /// <summary>
        /// BDFEC.
        /// </summary>
        public const string BDFEC = "BDFEC";

        /// <summary>
        /// BDHBST1.
        /// </summary>
        public const string BDHBST1 = "BDHBST1";

        /// <summary>
        /// BDHBST2.
        /// </summary>
        public const string BDHBST2 = "BDHBST2";

        /// <summary>
        /// BDHBST3.
        /// </summary>
        public const string BDHBST3 = "BDHBST3";

        /// <summary>
        /// BDHBST4.
        /// </summary>
        public const string BDHBST4 = "BDHBST4";

        /// <summary>
        /// BDHBST5.
        /// </summary>
        public const string BDHBST5 = "BDHBST5";

        /// <summary>
        /// BDURRF.
        /// </summary>
        public const string BDURRF = "BDURRF";

        /// <summary>
        /// BDCRTU.
        /// </summary>
        public const string BDCRTU = "BDCRTU";

        /// <summary>
        /// BDCRTJ.
        /// </summary>
        public const string BDCRTJ = "BDCRTJ";

        /// <summary>
        /// BDCRTT.
        /// </summary>
        public const string BDCRTT = "BDCRTT";

        /// <summary>
        /// BDWRKSTNID.
        /// </summary>
        public const string BDWRKSTNID = "BDWRKSTNID";

        /// <summary>
        /// BDHBOPID.
        /// </summary>
        public const string BDHBOPID = "BDHBOPID";

        /// <summary>
        /// BDUPMB.
        /// </summary>
        public const string BDUPMB = "BDUPMB";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H611";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDKCOO", "BDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("BDDOCO", "BDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("BDDCTO", "BDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("BDSFXO", "BDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("BDLNID", "BDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BDHBAREA", "BDHBAREA", JdeDataType.String, 6),
        new JdeField("BDMCU", "BDMCU", JdeDataType.String, 24),
        new JdeField("BDANI", "BDANI", JdeDataType.String, 58),
        new JdeField("BDAID", "BDAID", JdeDataType.String, 16),
        new JdeField("BDCPHASE", "BDCPHASE", JdeDataType.String, 6),
        new JdeField("BDOBJ", "BDOBJ", JdeDataType.String, 12),
        new JdeField("BDSUB", "BDSUB", JdeDataType.String, 16),
        new JdeField("BDOPTION", "BDOPTION", JdeDataType.String, 16),
        new JdeField("BDHBPLAN", "BDHBPLAN", JdeDataType.String, 8),
        new JdeField("BDHBELEV", "BDHBELEV", JdeDataType.String, 6),
        new JdeField("BDR001", "BDR001", JdeDataType.String, 6),
        new JdeField("BDBIDTYPE", "BDBIDTYPE", JdeDataType.String, 4),
        new JdeField("BDVNDAOVR", "BDVNDAOVR", JdeDataType.String, 2),
        new JdeField("BDUNIDOC", "BDUNIDOC", JdeDataType.String, 2),
        new JdeField("BDBUDONLY", "BDBUDONLY", JdeDataType.String, 2),
        new JdeField("BDVNDTBD", "BDVNDTBD", JdeDataType.String, 2),
        new JdeField("BDAVEL", "BDAVEL", JdeDataType.String, 2),
        new JdeField("BDAN8", "BDAN8", JdeDataType.Numeric),
        new JdeField("BDSHAN", "BDSHAN", JdeDataType.Numeric),
        new JdeField("BDDGL", "BDDGL", JdeDataType.Numeric),
        new JdeField("BDBDEFDT", "BDBDEFDT", JdeDataType.Numeric),
        new JdeField("BDBDCLDT", "BDBDCLDT", JdeDataType.Numeric),
        new JdeField("BDPDDJ", "BDPDDJ", JdeDataType.Numeric),
        new JdeField("BDOPDJ", "BDOPDJ", JdeDataType.Numeric),
        new JdeField("BDTRDJ", "BDTRDJ", JdeDataType.Numeric),
        new JdeField("BDPN", "BDPN", JdeDataType.Numeric),
        new JdeField("BDVR01", "BDVR01", JdeDataType.String, 50),
        new JdeField("BDVR02", "BDVR02", JdeDataType.String, 50),
        new JdeField("BDITM", "BDITM", JdeDataType.Numeric),
        new JdeField("BDLITM", "BDLITM", JdeDataType.String, 50),
        new JdeField("BDDSC1", "BDDSC1", JdeDataType.String, 60),
        new JdeField("BDDSC2", "BDDSC2", JdeDataType.String, 60),
        new JdeField("BDLNTY", "BDLNTY", JdeDataType.String, 4),
        new JdeField("BDNXTR", "BDNXTR", JdeDataType.String, 6),
        new JdeField("BDLTTR", "BDLTTR", JdeDataType.String, 6),
        new JdeField("BDPDP1", "BDPDP1", JdeDataType.String, 6),
        new JdeField("BDPDP2", "BDPDP2", JdeDataType.String, 6),
        new JdeField("BDPDP3", "BDPDP3", JdeDataType.String, 6),
        new JdeField("BDPDP4", "BDPDP4", JdeDataType.String, 6),
        new JdeField("BDPDP5", "BDPDP5", JdeDataType.String, 6),
        new JdeField("BDUOM", "BDUOM", JdeDataType.String, 4),
        new JdeField("BDPRRC", "BDPRRC", JdeDataType.Numeric),
        new JdeField("BDUORG", "BDUORG", JdeDataType.Numeric),
        new JdeField("BDAEXP", "BDAEXP", JdeDataType.Numeric),
        new JdeField("BDPERFCTR", "BDPERFCTR", JdeDataType.Numeric),
        new JdeField("BDFTN1", "BDFTN1", JdeDataType.Numeric),
        new JdeField("BDPTC", "BDPTC", JdeDataType.String, 6),
        new JdeField("BDTX", "BDTX", JdeDataType.String, 2),
        new JdeField("BDEXR1", "BDEXR1", JdeDataType.String, 4),
        new JdeField("BDTXA1", "BDTXA1", JdeDataType.String, 20),
        new JdeField("BDANBY", "BDANBY", JdeDataType.Numeric),
        new JdeField("BDGLC", "BDGLC", JdeDataType.String, 8),
        new JdeField("BDCTRY", "BDCTRY", JdeDataType.Numeric),
        new JdeField("BDFY", "BDFY", JdeDataType.Numeric),
        new JdeField("BDRCD", "BDRCD", JdeDataType.String, 6),
        new JdeField("BDFUF1", "BDFUF1", JdeDataType.String, 2),
        new JdeField("BDFUF2", "BDFUF2", JdeDataType.String, 2),
        new JdeField("BDLT", "BDLT", JdeDataType.String, 4),
        new JdeField("BDPCRT", "BDPCRT", JdeDataType.Numeric),
        new JdeField("BDRTNR", "BDRTNR", JdeDataType.String, 6),
        new JdeField("BDPURG", "BDPURG", JdeDataType.String, 2),
        new JdeField("BDCRRM", "BDCRRM", JdeDataType.String, 2),
        new JdeField("BDCRCD", "BDCRCD", JdeDataType.String, 6),
        new JdeField("BDCRR", "BDCRR", JdeDataType.Numeric),
        new JdeField("BDFRRC", "BDFRRC", JdeDataType.Numeric),
        new JdeField("BDFEA", "BDFEA", JdeDataType.Numeric),
        new JdeField("BDFUC", "BDFUC", JdeDataType.Numeric),
        new JdeField("BDFEC", "BDFEC", JdeDataType.Numeric),
        new JdeField("BDHBST1", "BDHBST1", JdeDataType.String, 2),
        new JdeField("BDHBST2", "BDHBST2", JdeDataType.String, 2),
        new JdeField("BDHBST3", "BDHBST3", JdeDataType.String, 2),
        new JdeField("BDHBST4", "BDHBST4", JdeDataType.String, 2),
        new JdeField("BDHBST5", "BDHBST5", JdeDataType.String, 2),
        new JdeField("BDURRF", "BDURRF", JdeDataType.String, 30),
        new JdeField("BDCRTU", "BDCRTU", JdeDataType.String, 20),
        new JdeField("BDCRTJ", "BDCRTJ", JdeDataType.Numeric),
        new JdeField("BDCRTT", "BDCRTT", JdeDataType.Numeric),
        new JdeField("BDWRKSTNID", "BDWRKSTNID", JdeDataType.String, 20),
        new JdeField("BDHBOPID", "BDHBOPID", JdeDataType.String, 20),
        new JdeField("BDUPMB", "BDUPMB", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H611_0", "Primary Key on BDDOCO, BDDCTO, BDKCOO, BDSFXO, BDLNID", new[] { "BDDOCO", "BDDCTO", "BDKCOO", "BDSFXO", "BDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H611_2", "Index on BDDOCO, BDDCTO, BDKCOO, SYS_NC00090$, SYS_NC00091$", new[] { "BDDOCO", "BDDCTO", "BDKCOO", "SYS_NC00090$", "SYS_NC00091$" }),
        new JdeIndex("F44H611_3", "Index on BDHBAREA, BDVNDAOVR, BDOPTION, BDSUB, BDOBJ, SYS_NC00092$, SYS_NC00093$, SYS_NC00094$, SYS_NC00095$", new[] { "BDHBAREA", "BDVNDAOVR", "BDOPTION", "BDSUB", "BDOBJ", "SYS_NC00092$", "SYS_NC00093$", "SYS_NC00094$", "SYS_NC00095$" }),
        new JdeIndex("F44H611_5", "Index on BDSUB, BDOBJ, BDOPTION, BDCPHASE, BDHBPLAN, BDHBELEV, BDAN8, BDMCU, BDBDEFDT, BDBDCLDT", new[] { "BDSUB", "BDOBJ", "BDOPTION", "BDCPHASE", "BDHBPLAN", "BDHBELEV", "BDAN8", "BDMCU", "BDBDEFDT", "BDBDCLDT" }),
        new JdeIndex("F44H611_6", "Index on BDHBAREA, BDSUB, BDOBJ, BDOPTION", new[] { "BDHBAREA", "BDSUB", "BDOBJ", "BDOPTION" }),
        new JdeIndex("F44H611_7", "Index on BDDOCO, BDDCTO, BDKCOO, SYS_NC00091$", new[] { "BDDOCO", "BDDCTO", "BDKCOO", "SYS_NC00091$" }),
        new JdeIndex("F44H611_8", "Index on BDHBAREA, BDMCU, BDCPHASE, BDOBJ, BDSUB, BDOPTION, BDHBPLAN, BDHBELEV, BDVNDAOVR, BDBUDONLY, BDAN8, BDBDEFDT, BDBDCLDT", new[] { "BDHBAREA", "BDMCU", "BDCPHASE", "BDOBJ", "BDSUB", "BDOPTION", "BDHBPLAN", "BDHBELEV", "BDVNDAOVR", "BDBUDONLY", "BDAN8", "BDBDEFDT", "BDBDCLDT" })
    };
}
