using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H711 - .
/// </summary>
public class F44H711 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWMCU.
        /// </summary>
        public const string SWMCU = "SWMCU";

        /// <summary>
        /// SWOBJ.
        /// </summary>
        public const string SWOBJ = "SWOBJ";

        /// <summary>
        /// SWSUB.
        /// </summary>
        public const string SWSUB = "SWSUB";

        /// <summary>
        /// SWOPTION.
        /// </summary>
        public const string SWOPTION = "SWOPTION";

        /// <summary>
        /// SWAN8.
        /// </summary>
        public const string SWAN8 = "SWAN8";

        /// <summary>
        /// SWITM.
        /// </summary>
        public const string SWITM = "SWITM";

        /// <summary>
        /// SWSEQ.
        /// </summary>
        public const string SWSEQ = "SWSEQ";

        /// <summary>
        /// SWLITM.
        /// </summary>
        public const string SWLITM = "SWLITM";

        /// <summary>
        /// SWAITM.
        /// </summary>
        public const string SWAITM = "SWAITM";

        /// <summary>
        /// SWMCUTJ.
        /// </summary>
        public const string SWMCUTJ = "SWMCUTJ";

        /// <summary>
        /// SWGENJOB.
        /// </summary>
        public const string SWGENJOB = "SWGENJOB";

        /// <summary>
        /// SWJOBS.
        /// </summary>
        public const string SWJOBS = "SWJOBS";

        /// <summary>
        /// SWAVEL.
        /// </summary>
        public const string SWAVEL = "SWAVEL";

        /// <summary>
        /// SWLSWVER.
        /// </summary>
        public const string SWLSWVER = "SWLSWVER";

        /// <summary>
        /// SWBUDONLY.
        /// </summary>
        public const string SWBUDONLY = "SWBUDONLY";

        /// <summary>
        /// SWLSWPOSTB.
        /// </summary>
        public const string SWLSWPOSTB = "SWLSWPOSTB";

        /// <summary>
        /// SWHBPFLG1.
        /// </summary>
        public const string SWHBPFLG1 = "SWHBPFLG1";

        /// <summary>
        /// SWLSWPOSTC.
        /// </summary>
        public const string SWLSWPOSTC = "SWLSWPOSTC";

        /// <summary>
        /// SWOPKID.
        /// </summary>
        public const string SWOPKID = "SWOPKID";

        /// <summary>
        /// SWOKCO.
        /// </summary>
        public const string SWOKCO = "SWOKCO";

        /// <summary>
        /// SWOORN.
        /// </summary>
        public const string SWOORN = "SWOORN";

        /// <summary>
        /// SWOCTO.
        /// </summary>
        public const string SWOCTO = "SWOCTO";

        /// <summary>
        /// SWOSFX.
        /// </summary>
        public const string SWOSFX = "SWOSFX";

        /// <summary>
        /// SWOGNO.
        /// </summary>
        public const string SWOGNO = "SWOGNO";

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
        /// SWSFXO.
        /// </summary>
        public const string SWSFXO = "SWSFXO";

        /// <summary>
        /// SWLNID.
        /// </summary>
        public const string SWLNID = "SWLNID";

        /// <summary>
        /// SWHBMCUS.
        /// </summary>
        public const string SWHBMCUS = "SWHBMCUS";

        /// <summary>
        /// SWHBLOT.
        /// </summary>
        public const string SWHBLOT = "SWHBLOT";

        /// <summary>
        /// SWCPHASE.
        /// </summary>
        public const string SWCPHASE = "SWCPHASE";

        /// <summary>
        /// SWHBAREA.
        /// </summary>
        public const string SWHBAREA = "SWHBAREA";

        /// <summary>
        /// SWSHAN.
        /// </summary>
        public const string SWSHAN = "SWSHAN";

        /// <summary>
        /// SWDGL.
        /// </summary>
        public const string SWDGL = "SWDGL";

        /// <summary>
        /// SWOPDJ.
        /// </summary>
        public const string SWOPDJ = "SWOPDJ";

        /// <summary>
        /// SWTRDJ.
        /// </summary>
        public const string SWTRDJ = "SWTRDJ";

        /// <summary>
        /// SWPN.
        /// </summary>
        public const string SWPN = "SWPN";

        /// <summary>
        /// SWDESC.
        /// </summary>
        public const string SWDESC = "SWDESC";

        /// <summary>
        /// SWVR01.
        /// </summary>
        public const string SWVR01 = "SWVR01";

        /// <summary>
        /// SWVR02.
        /// </summary>
        public const string SWVR02 = "SWVR02";

        /// <summary>
        /// SWDSC1.
        /// </summary>
        public const string SWDSC1 = "SWDSC1";

        /// <summary>
        /// SWDSC2.
        /// </summary>
        public const string SWDSC2 = "SWDSC2";

        /// <summary>
        /// SWRMK.
        /// </summary>
        public const string SWRMK = "SWRMK";

        /// <summary>
        /// SWVNDTBD.
        /// </summary>
        public const string SWVNDTBD = "SWVNDTBD";

        /// <summary>
        /// SWLNTY.
        /// </summary>
        public const string SWLNTY = "SWLNTY";

        /// <summary>
        /// SWPDP1.
        /// </summary>
        public const string SWPDP1 = "SWPDP1";

        /// <summary>
        /// SWPDP2.
        /// </summary>
        public const string SWPDP2 = "SWPDP2";

        /// <summary>
        /// SWPDP3.
        /// </summary>
        public const string SWPDP3 = "SWPDP3";

        /// <summary>
        /// SWPDP4.
        /// </summary>
        public const string SWPDP4 = "SWPDP4";

        /// <summary>
        /// SWPDP5.
        /// </summary>
        public const string SWPDP5 = "SWPDP5";

        /// <summary>
        /// SWOSCQTY.
        /// </summary>
        public const string SWOSCQTY = "SWOSCQTY";

        /// <summary>
        /// SWUOM.
        /// </summary>
        public const string SWUOM = "SWUOM";

        /// <summary>
        /// SWUORG.
        /// </summary>
        public const string SWUORG = "SWUORG";

        /// <summary>
        /// SWPRRC.
        /// </summary>
        public const string SWPRRC = "SWPRRC";

        /// <summary>
        /// SWAEXP.
        /// </summary>
        public const string SWAEXP = "SWAEXP";

        /// <summary>
        /// SWFTN1.
        /// </summary>
        public const string SWFTN1 = "SWFTN1";

        /// <summary>
        /// SWLSWOGBA.
        /// </summary>
        public const string SWLSWOGBA = "SWLSWOGBA";

        /// <summary>
        /// SWPTC.
        /// </summary>
        public const string SWPTC = "SWPTC";

        /// <summary>
        /// SWTX.
        /// </summary>
        public const string SWTX = "SWTX";

        /// <summary>
        /// SWEXR1.
        /// </summary>
        public const string SWEXR1 = "SWEXR1";

        /// <summary>
        /// SWTXA1.
        /// </summary>
        public const string SWTXA1 = "SWTXA1";

        /// <summary>
        /// SWATXT.
        /// </summary>
        public const string SWATXT = "SWATXT";

        /// <summary>
        /// SWANBY.
        /// </summary>
        public const string SWANBY = "SWANBY";

        /// <summary>
        /// SWGLC.
        /// </summary>
        public const string SWGLC = "SWGLC";

        /// <summary>
        /// SWCTRY.
        /// </summary>
        public const string SWCTRY = "SWCTRY";

        /// <summary>
        /// SWFY.
        /// </summary>
        public const string SWFY = "SWFY";

        /// <summary>
        /// SWSTTS.
        /// </summary>
        public const string SWSTTS = "SWSTTS";

        /// <summary>
        /// SWRCD.
        /// </summary>
        public const string SWRCD = "SWRCD";

        /// <summary>
        /// SWFUF1.
        /// </summary>
        public const string SWFUF1 = "SWFUF1";

        /// <summary>
        /// SWFUF2.
        /// </summary>
        public const string SWFUF2 = "SWFUF2";

        /// <summary>
        /// SWANI.
        /// </summary>
        public const string SWANI = "SWANI";

        /// <summary>
        /// SWAID.
        /// </summary>
        public const string SWAID = "SWAID";

        /// <summary>
        /// SWLT.
        /// </summary>
        public const string SWLT = "SWLT";

        /// <summary>
        /// SWHBPLAN.
        /// </summary>
        public const string SWHBPLAN = "SWHBPLAN";

        /// <summary>
        /// SWHBELEV.
        /// </summary>
        public const string SWHBELEV = "SWHBELEV";

        /// <summary>
        /// SWR001.
        /// </summary>
        public const string SWR001 = "SWR001";

        /// <summary>
        /// SWPCRT.
        /// </summary>
        public const string SWPCRT = "SWPCRT";

        /// <summary>
        /// SWRTNR.
        /// </summary>
        public const string SWRTNR = "SWRTNR";

        /// <summary>
        /// SWPURG.
        /// </summary>
        public const string SWPURG = "SWPURG";

        /// <summary>
        /// SWCRCD.
        /// </summary>
        public const string SWCRCD = "SWCRCD";

        /// <summary>
        /// SWCRCF.
        /// </summary>
        public const string SWCRCF = "SWCRCF";

        /// <summary>
        /// SWCRRM.
        /// </summary>
        public const string SWCRRM = "SWCRRM";

        /// <summary>
        /// SWCRR.
        /// </summary>
        public const string SWCRR = "SWCRR";

        /// <summary>
        /// SWFRRC.
        /// </summary>
        public const string SWFRRC = "SWFRRC";

        /// <summary>
        /// SWFEA.
        /// </summary>
        public const string SWFEA = "SWFEA";

        /// <summary>
        /// SWFUC.
        /// </summary>
        public const string SWFUC = "SWFUC";

        /// <summary>
        /// SWFEC.
        /// </summary>
        public const string SWFEC = "SWFEC";

        /// <summary>
        /// SWURRF.
        /// </summary>
        public const string SWURRF = "SWURRF";

        /// <summary>
        /// SWHBST1.
        /// </summary>
        public const string SWHBST1 = "SWHBST1";

        /// <summary>
        /// SWHBST2.
        /// </summary>
        public const string SWHBST2 = "SWHBST2";

        /// <summary>
        /// SWHBST3.
        /// </summary>
        public const string SWHBST3 = "SWHBST3";

        /// <summary>
        /// SWHBST4.
        /// </summary>
        public const string SWHBST4 = "SWHBST4";

        /// <summary>
        /// SWHBST5.
        /// </summary>
        public const string SWHBST5 = "SWHBST5";

        /// <summary>
        /// SWLSWLRK.
        /// </summary>
        public const string SWLSWLRK = "SWLSWLRK";

        /// <summary>
        /// SWCRTU.
        /// </summary>
        public const string SWCRTU = "SWCRTU";

        /// <summary>
        /// SWCRTJ.
        /// </summary>
        public const string SWCRTJ = "SWCRTJ";

        /// <summary>
        /// SWCRTT.
        /// </summary>
        public const string SWCRTT = "SWCRTT";

        /// <summary>
        /// SWWRKSTNID.
        /// </summary>
        public const string SWWRKSTNID = "SWWRKSTNID";

        /// <summary>
        /// SWHBOPID.
        /// </summary>
        public const string SWHBOPID = "SWHBOPID";

        /// <summary>
        /// SWUPMB.
        /// </summary>
        public const string SWUPMB = "SWUPMB";

        /// <summary>
        /// SWUPMJ.
        /// </summary>
        public const string SWUPMJ = "SWUPMJ";

        /// <summary>
        /// SWUPMT.
        /// </summary>
        public const string SWUPMT = "SWUPMT";

        /// <summary>
        /// SWJOBN.
        /// </summary>
        public const string SWJOBN = "SWJOBN";

        /// <summary>
        /// SWPID.
        /// </summary>
        public const string SWPID = "SWPID";

        /// <summary>
        /// SWNPF.
        /// </summary>
        public const string SWNPF = "SWNPF";
    }

    /// <inheritdoc />
    public override string TableName => "F44H711";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWMCU", "SWMCU", JdeDataType.String, 24, true, true),
        new JdeField("SWOBJ", "SWOBJ", JdeDataType.String, 12, true, true),
        new JdeField("SWSUB", "SWSUB", JdeDataType.String, 16, true, true),
        new JdeField("SWOPTION", "SWOPTION", JdeDataType.String, 16, true, true),
        new JdeField("SWAN8", "SWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SWITM", "SWITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SWSEQ", "SWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SWLITM", "SWLITM", JdeDataType.String, 50),
        new JdeField("SWAITM", "SWAITM", JdeDataType.String, 50),
        new JdeField("SWMCUTJ", "SWMCUTJ", JdeDataType.String, 24),
        new JdeField("SWGENJOB", "SWGENJOB", JdeDataType.Numeric),
        new JdeField("SWJOBS", "SWJOBS", JdeDataType.Numeric),
        new JdeField("SWAVEL", "SWAVEL", JdeDataType.String, 2),
        new JdeField("SWLSWVER", "SWLSWVER", JdeDataType.String, 20),
        new JdeField("SWBUDONLY", "SWBUDONLY", JdeDataType.String, 2),
        new JdeField("SWLSWPOSTB", "SWLSWPOSTB", JdeDataType.String, 2),
        new JdeField("SWHBPFLG1", "SWHBPFLG1", JdeDataType.String, 2),
        new JdeField("SWLSWPOSTC", "SWLSWPOSTC", JdeDataType.String, 2),
        new JdeField("SWOPKID", "SWOPKID", JdeDataType.String, 16),
        new JdeField("SWOKCO", "SWOKCO", JdeDataType.String, 10),
        new JdeField("SWOORN", "SWOORN", JdeDataType.String, 16),
        new JdeField("SWOCTO", "SWOCTO", JdeDataType.String, 4),
        new JdeField("SWOSFX", "SWOSFX", JdeDataType.String, 6),
        new JdeField("SWOGNO", "SWOGNO", JdeDataType.Numeric),
        new JdeField("SWKCOO", "SWKCOO", JdeDataType.String, 10),
        new JdeField("SWDOCO", "SWDOCO", JdeDataType.Numeric),
        new JdeField("SWDCTO", "SWDCTO", JdeDataType.String, 4),
        new JdeField("SWSFXO", "SWSFXO", JdeDataType.String, 6),
        new JdeField("SWLNID", "SWLNID", JdeDataType.Numeric),
        new JdeField("SWHBMCUS", "SWHBMCUS", JdeDataType.String, 24),
        new JdeField("SWHBLOT", "SWHBLOT", JdeDataType.String, 8),
        new JdeField("SWCPHASE", "SWCPHASE", JdeDataType.String, 6),
        new JdeField("SWHBAREA", "SWHBAREA", JdeDataType.String, 6),
        new JdeField("SWSHAN", "SWSHAN", JdeDataType.Numeric),
        new JdeField("SWDGL", "SWDGL", JdeDataType.Numeric),
        new JdeField("SWOPDJ", "SWOPDJ", JdeDataType.Numeric),
        new JdeField("SWTRDJ", "SWTRDJ", JdeDataType.Numeric),
        new JdeField("SWPN", "SWPN", JdeDataType.Numeric),
        new JdeField("SWDESC", "SWDESC", JdeDataType.String, 60),
        new JdeField("SWVR01", "SWVR01", JdeDataType.String, 50),
        new JdeField("SWVR02", "SWVR02", JdeDataType.String, 50),
        new JdeField("SWDSC1", "SWDSC1", JdeDataType.String, 60),
        new JdeField("SWDSC2", "SWDSC2", JdeDataType.String, 60),
        new JdeField("SWRMK", "SWRMK", JdeDataType.String, 60),
        new JdeField("SWVNDTBD", "SWVNDTBD", JdeDataType.String, 2),
        new JdeField("SWLNTY", "SWLNTY", JdeDataType.String, 4),
        new JdeField("SWPDP1", "SWPDP1", JdeDataType.String, 6),
        new JdeField("SWPDP2", "SWPDP2", JdeDataType.String, 6),
        new JdeField("SWPDP3", "SWPDP3", JdeDataType.String, 6),
        new JdeField("SWPDP4", "SWPDP4", JdeDataType.String, 6),
        new JdeField("SWPDP5", "SWPDP5", JdeDataType.String, 6),
        new JdeField("SWOSCQTY", "SWOSCQTY", JdeDataType.Numeric),
        new JdeField("SWUOM", "SWUOM", JdeDataType.String, 4),
        new JdeField("SWUORG", "SWUORG", JdeDataType.Numeric),
        new JdeField("SWPRRC", "SWPRRC", JdeDataType.Numeric),
        new JdeField("SWAEXP", "SWAEXP", JdeDataType.Numeric),
        new JdeField("SWFTN1", "SWFTN1", JdeDataType.Numeric),
        new JdeField("SWLSWOGBA", "SWLSWOGBA", JdeDataType.Numeric),
        new JdeField("SWPTC", "SWPTC", JdeDataType.String, 6),
        new JdeField("SWTX", "SWTX", JdeDataType.String, 2),
        new JdeField("SWEXR1", "SWEXR1", JdeDataType.String, 4),
        new JdeField("SWTXA1", "SWTXA1", JdeDataType.String, 20),
        new JdeField("SWATXT", "SWATXT", JdeDataType.String, 2),
        new JdeField("SWANBY", "SWANBY", JdeDataType.Numeric),
        new JdeField("SWGLC", "SWGLC", JdeDataType.String, 8),
        new JdeField("SWCTRY", "SWCTRY", JdeDataType.Numeric),
        new JdeField("SWFY", "SWFY", JdeDataType.Numeric),
        new JdeField("SWSTTS", "SWSTTS", JdeDataType.String, 4),
        new JdeField("SWRCD", "SWRCD", JdeDataType.String, 6),
        new JdeField("SWFUF1", "SWFUF1", JdeDataType.String, 2),
        new JdeField("SWFUF2", "SWFUF2", JdeDataType.String, 2),
        new JdeField("SWANI", "SWANI", JdeDataType.String, 58),
        new JdeField("SWAID", "SWAID", JdeDataType.String, 16),
        new JdeField("SWLT", "SWLT", JdeDataType.String, 4),
        new JdeField("SWHBPLAN", "SWHBPLAN", JdeDataType.String, 8),
        new JdeField("SWHBELEV", "SWHBELEV", JdeDataType.String, 6),
        new JdeField("SWR001", "SWR001", JdeDataType.String, 6),
        new JdeField("SWPCRT", "SWPCRT", JdeDataType.Numeric),
        new JdeField("SWRTNR", "SWRTNR", JdeDataType.String, 6),
        new JdeField("SWPURG", "SWPURG", JdeDataType.String, 2),
        new JdeField("SWCRCD", "SWCRCD", JdeDataType.String, 6),
        new JdeField("SWCRCF", "SWCRCF", JdeDataType.String, 6),
        new JdeField("SWCRRM", "SWCRRM", JdeDataType.String, 2),
        new JdeField("SWCRR", "SWCRR", JdeDataType.Numeric),
        new JdeField("SWFRRC", "SWFRRC", JdeDataType.Numeric),
        new JdeField("SWFEA", "SWFEA", JdeDataType.Numeric),
        new JdeField("SWFUC", "SWFUC", JdeDataType.Numeric),
        new JdeField("SWFEC", "SWFEC", JdeDataType.Numeric),
        new JdeField("SWURRF", "SWURRF", JdeDataType.String, 30),
        new JdeField("SWHBST1", "SWHBST1", JdeDataType.String, 2),
        new JdeField("SWHBST2", "SWHBST2", JdeDataType.String, 2),
        new JdeField("SWHBST3", "SWHBST3", JdeDataType.String, 2),
        new JdeField("SWHBST4", "SWHBST4", JdeDataType.String, 2),
        new JdeField("SWHBST5", "SWHBST5", JdeDataType.String, 2),
        new JdeField("SWLSWLRK", "SWLSWLRK", JdeDataType.Numeric),
        new JdeField("SWCRTU", "SWCRTU", JdeDataType.String, 20),
        new JdeField("SWCRTJ", "SWCRTJ", JdeDataType.Numeric),
        new JdeField("SWCRTT", "SWCRTT", JdeDataType.Numeric),
        new JdeField("SWWRKSTNID", "SWWRKSTNID", JdeDataType.String, 20),
        new JdeField("SWHBOPID", "SWHBOPID", JdeDataType.String, 20),
        new JdeField("SWUPMB", "SWUPMB", JdeDataType.String, 20),
        new JdeField("SWUPMJ", "SWUPMJ", JdeDataType.Numeric),
        new JdeField("SWUPMT", "SWUPMT", JdeDataType.Numeric),
        new JdeField("SWJOBN", "SWJOBN", JdeDataType.String, 20),
        new JdeField("SWPID", "SWPID", JdeDataType.String, 20),
        new JdeField("SWNPF", "SWNPF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H711_0", "Primary Key on SWMCU, SWOBJ, SWSUB, SWOPTION, SWAN8, SWITM, SWSEQ", new[] { "SWMCU", "SWOBJ", "SWSUB", "SWOPTION", "SWAN8", "SWITM", "SWSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H711_10", "Index on SWMCU, SWOBJ, SWSUB, SWOPTION, SWAN8, SWITM, SYS_NC00107$", new[] { "SWMCU", "SWOBJ", "SWSUB", "SWOPTION", "SWAN8", "SWITM", "SYS_NC00107$" }),
        new JdeIndex("F44H711_11", "Index on SWOPTION, SWOPKID, SWMCU, SWOBJ, SWSUB, SWAN8, SWITM", new[] { "SWOPTION", "SWOPKID", "SWMCU", "SWOBJ", "SWSUB", "SWAN8", "SWITM" }),
        new JdeIndex("F44H711_12", "Index on SWMCU, SWOPTION, SYS_NC00107$, SWLSWLRK", new[] { "SWMCU", "SWOPTION", "SYS_NC00107$", "SWLSWLRK" }),
        new JdeIndex("F44H711_13", "Index on SWOKCO, SWOORN, SWOCTO, SWOSFX, SWHBMCUS, SWHBLOT, SWGENJOB", new[] { "SWOKCO", "SWOORN", "SWOCTO", "SWOSFX", "SWHBMCUS", "SWHBLOT", "SWGENJOB" }),
        new JdeIndex("F44H711_15", "Index on SWMCU, SWOBJ, SWSUB, SWOPTION, SWAN8, SWHBPFLG1, SWOPKID, SWITM", new[] { "SWMCU", "SWOBJ", "SWSUB", "SWOPTION", "SWAN8", "SWHBPFLG1", "SWOPKID", "SWITM" }),
        new JdeIndex("F44H711_16", "Index on SWHBAREA, SWHBMCUS, SWCPHASE, SWMCU, SWOBJ, SWSUB, SWOPTION, SWAN8, SWITM", new[] { "SWHBAREA", "SWHBMCUS", "SWCPHASE", "SWMCU", "SWOBJ", "SWSUB", "SWOPTION", "SWAN8", "SWITM" }),
        new JdeIndex("F44H711_2", "Index on SWGENJOB", new[] { "SWGENJOB" }),
        new JdeIndex("F44H711_3", "Index on SWJOBS", new[] { "SWJOBS" }),
        new JdeIndex("F44H711_4", "Index on SWMCU, SWHBPFLG1, SWOKCO, SWOCTO, SWOORN, SWOGNO", new[] { "SWMCU", "SWHBPFLG1", "SWOKCO", "SWOCTO", "SWOORN", "SWOGNO" }),
        new JdeIndex("F44H711_5", "Index on SWMCU, SWHBPFLG1, SWAN8, SWSUB, SWOBJ", new[] { "SWMCU", "SWHBPFLG1", "SWAN8", "SWSUB", "SWOBJ" }),
        new JdeIndex("F44H711_6", "Index on SWJOBS, SWMCU, SWOBJ, SWSUB, SWOPTION", new[] { "SWJOBS", "SWMCU", "SWOBJ", "SWSUB", "SWOPTION" }),
        new JdeIndex("F44H711_7", "Index on SWLSWVER, SWMCU, SWOBJ, SWSUB, SWOPTION, SWAN8, SWITM, SWSEQ", new[] { "SWLSWVER", "SWMCU", "SWOBJ", "SWSUB", "SWOPTION", "SWAN8", "SWITM", "SWSEQ" }),
        new JdeIndex("F44H711_8", "Index on SWLSWLRK, SWMCU, SWOBJ, SWSUB, SWOPTION, SWAN8, SWITM, SWSEQ", new[] { "SWLSWLRK", "SWMCU", "SWOBJ", "SWSUB", "SWOPTION", "SWAN8", "SWITM", "SWSEQ" }),
        new JdeIndex("F44H711_9", "Index on SWMCU, SWOBJ, SWSUB, SWOPTION, SWKCOO, SWDOCO, SWDCTO", new[] { "SWMCU", "SWOBJ", "SWSUB", "SWOPTION", "SWKCOO", "SWDOCO", "SWDCTO" })
    };
}
