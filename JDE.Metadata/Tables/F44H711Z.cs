using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H711Z - .
/// </summary>
public class F44H711Z : JdeTable
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
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZOBJ.
        /// </summary>
        public const string SZOBJ = "SZOBJ";

        /// <summary>
        /// SZSUB.
        /// </summary>
        public const string SZSUB = "SZSUB";

        /// <summary>
        /// SZOPTION.
        /// </summary>
        public const string SZOPTION = "SZOPTION";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZITM.
        /// </summary>
        public const string SZITM = "SZITM";

        /// <summary>
        /// SZSEQ.
        /// </summary>
        public const string SZSEQ = "SZSEQ";

        /// <summary>
        /// SZLITM.
        /// </summary>
        public const string SZLITM = "SZLITM";

        /// <summary>
        /// SZAITM.
        /// </summary>
        public const string SZAITM = "SZAITM";

        /// <summary>
        /// SZMCUTJ.
        /// </summary>
        public const string SZMCUTJ = "SZMCUTJ";

        /// <summary>
        /// SZGENJOB.
        /// </summary>
        public const string SZGENJOB = "SZGENJOB";

        /// <summary>
        /// SZJOBS.
        /// </summary>
        public const string SZJOBS = "SZJOBS";

        /// <summary>
        /// SZAVEL.
        /// </summary>
        public const string SZAVEL = "SZAVEL";

        /// <summary>
        /// SZLSWVER.
        /// </summary>
        public const string SZLSWVER = "SZLSWVER";

        /// <summary>
        /// SZBUDONLY.
        /// </summary>
        public const string SZBUDONLY = "SZBUDONLY";

        /// <summary>
        /// SZLSWPOSTB.
        /// </summary>
        public const string SZLSWPOSTB = "SZLSWPOSTB";

        /// <summary>
        /// SZHBPFLG1.
        /// </summary>
        public const string SZHBPFLG1 = "SZHBPFLG1";

        /// <summary>
        /// SZLSWPOSTC.
        /// </summary>
        public const string SZLSWPOSTC = "SZLSWPOSTC";

        /// <summary>
        /// SZOPKID.
        /// </summary>
        public const string SZOPKID = "SZOPKID";

        /// <summary>
        /// SZOKCO.
        /// </summary>
        public const string SZOKCO = "SZOKCO";

        /// <summary>
        /// SZOORN.
        /// </summary>
        public const string SZOORN = "SZOORN";

        /// <summary>
        /// SZOCTO.
        /// </summary>
        public const string SZOCTO = "SZOCTO";

        /// <summary>
        /// SZOSFX.
        /// </summary>
        public const string SZOSFX = "SZOSFX";

        /// <summary>
        /// SZOGNO.
        /// </summary>
        public const string SZOGNO = "SZOGNO";

        /// <summary>
        /// SZKCOO.
        /// </summary>
        public const string SZKCOO = "SZKCOO";

        /// <summary>
        /// SZDCTO.
        /// </summary>
        public const string SZDCTO = "SZDCTO";

        /// <summary>
        /// SZDOCO.
        /// </summary>
        public const string SZDOCO = "SZDOCO";

        /// <summary>
        /// SZSFXO.
        /// </summary>
        public const string SZSFXO = "SZSFXO";

        /// <summary>
        /// SZLNID.
        /// </summary>
        public const string SZLNID = "SZLNID";

        /// <summary>
        /// SZHBMCUS.
        /// </summary>
        public const string SZHBMCUS = "SZHBMCUS";

        /// <summary>
        /// SZHBLOT.
        /// </summary>
        public const string SZHBLOT = "SZHBLOT";

        /// <summary>
        /// SZCPHASE.
        /// </summary>
        public const string SZCPHASE = "SZCPHASE";

        /// <summary>
        /// SZHBAREA.
        /// </summary>
        public const string SZHBAREA = "SZHBAREA";

        /// <summary>
        /// SZSHAN.
        /// </summary>
        public const string SZSHAN = "SZSHAN";

        /// <summary>
        /// SZDGL.
        /// </summary>
        public const string SZDGL = "SZDGL";

        /// <summary>
        /// SZOPDJ.
        /// </summary>
        public const string SZOPDJ = "SZOPDJ";

        /// <summary>
        /// SZTRDJ.
        /// </summary>
        public const string SZTRDJ = "SZTRDJ";

        /// <summary>
        /// SZPN.
        /// </summary>
        public const string SZPN = "SZPN";

        /// <summary>
        /// SZDESC.
        /// </summary>
        public const string SZDESC = "SZDESC";

        /// <summary>
        /// SZVR01.
        /// </summary>
        public const string SZVR01 = "SZVR01";

        /// <summary>
        /// SZVR02.
        /// </summary>
        public const string SZVR02 = "SZVR02";

        /// <summary>
        /// SZDSC1.
        /// </summary>
        public const string SZDSC1 = "SZDSC1";

        /// <summary>
        /// SZDSC2.
        /// </summary>
        public const string SZDSC2 = "SZDSC2";

        /// <summary>
        /// SZRMK.
        /// </summary>
        public const string SZRMK = "SZRMK";

        /// <summary>
        /// SZVNDTBD.
        /// </summary>
        public const string SZVNDTBD = "SZVNDTBD";

        /// <summary>
        /// SZLNTY.
        /// </summary>
        public const string SZLNTY = "SZLNTY";

        /// <summary>
        /// SZPDP1.
        /// </summary>
        public const string SZPDP1 = "SZPDP1";

        /// <summary>
        /// SZPDP2.
        /// </summary>
        public const string SZPDP2 = "SZPDP2";

        /// <summary>
        /// SZPDP3.
        /// </summary>
        public const string SZPDP3 = "SZPDP3";

        /// <summary>
        /// SZPDP4.
        /// </summary>
        public const string SZPDP4 = "SZPDP4";

        /// <summary>
        /// SZPDP5.
        /// </summary>
        public const string SZPDP5 = "SZPDP5";

        /// <summary>
        /// SZOSCQTY.
        /// </summary>
        public const string SZOSCQTY = "SZOSCQTY";

        /// <summary>
        /// SZUOM.
        /// </summary>
        public const string SZUOM = "SZUOM";

        /// <summary>
        /// SZUORG.
        /// </summary>
        public const string SZUORG = "SZUORG";

        /// <summary>
        /// SZPRRC.
        /// </summary>
        public const string SZPRRC = "SZPRRC";

        /// <summary>
        /// SZAEXP.
        /// </summary>
        public const string SZAEXP = "SZAEXP";

        /// <summary>
        /// SZFTN1.
        /// </summary>
        public const string SZFTN1 = "SZFTN1";

        /// <summary>
        /// SZLSWOGBA.
        /// </summary>
        public const string SZLSWOGBA = "SZLSWOGBA";

        /// <summary>
        /// SZPTC.
        /// </summary>
        public const string SZPTC = "SZPTC";

        /// <summary>
        /// SZTX.
        /// </summary>
        public const string SZTX = "SZTX";

        /// <summary>
        /// SZEXR1.
        /// </summary>
        public const string SZEXR1 = "SZEXR1";

        /// <summary>
        /// SZTXA1.
        /// </summary>
        public const string SZTXA1 = "SZTXA1";

        /// <summary>
        /// SZATXT.
        /// </summary>
        public const string SZATXT = "SZATXT";

        /// <summary>
        /// SZANBY.
        /// </summary>
        public const string SZANBY = "SZANBY";

        /// <summary>
        /// SZGLC.
        /// </summary>
        public const string SZGLC = "SZGLC";

        /// <summary>
        /// SZCTRY.
        /// </summary>
        public const string SZCTRY = "SZCTRY";

        /// <summary>
        /// SZFY.
        /// </summary>
        public const string SZFY = "SZFY";

        /// <summary>
        /// SZSTTS.
        /// </summary>
        public const string SZSTTS = "SZSTTS";

        /// <summary>
        /// SZRCD.
        /// </summary>
        public const string SZRCD = "SZRCD";

        /// <summary>
        /// SZFUF1.
        /// </summary>
        public const string SZFUF1 = "SZFUF1";

        /// <summary>
        /// SZFUF2.
        /// </summary>
        public const string SZFUF2 = "SZFUF2";

        /// <summary>
        /// SZANI.
        /// </summary>
        public const string SZANI = "SZANI";

        /// <summary>
        /// SZAID.
        /// </summary>
        public const string SZAID = "SZAID";

        /// <summary>
        /// SZLT.
        /// </summary>
        public const string SZLT = "SZLT";

        /// <summary>
        /// SZHBPLAN.
        /// </summary>
        public const string SZHBPLAN = "SZHBPLAN";

        /// <summary>
        /// SZHBELEV.
        /// </summary>
        public const string SZHBELEV = "SZHBELEV";

        /// <summary>
        /// SZR001.
        /// </summary>
        public const string SZR001 = "SZR001";

        /// <summary>
        /// SZPCRT.
        /// </summary>
        public const string SZPCRT = "SZPCRT";

        /// <summary>
        /// SZRTNR.
        /// </summary>
        public const string SZRTNR = "SZRTNR";

        /// <summary>
        /// SZPURG.
        /// </summary>
        public const string SZPURG = "SZPURG";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZCRCF.
        /// </summary>
        public const string SZCRCF = "SZCRCF";

        /// <summary>
        /// SZCRRM.
        /// </summary>
        public const string SZCRRM = "SZCRRM";

        /// <summary>
        /// SZCRR.
        /// </summary>
        public const string SZCRR = "SZCRR";

        /// <summary>
        /// SZFRRC.
        /// </summary>
        public const string SZFRRC = "SZFRRC";

        /// <summary>
        /// SZFEA.
        /// </summary>
        public const string SZFEA = "SZFEA";

        /// <summary>
        /// SZFUC.
        /// </summary>
        public const string SZFUC = "SZFUC";

        /// <summary>
        /// SZFEC.
        /// </summary>
        public const string SZFEC = "SZFEC";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZHBST1.
        /// </summary>
        public const string SZHBST1 = "SZHBST1";

        /// <summary>
        /// SZHBST2.
        /// </summary>
        public const string SZHBST2 = "SZHBST2";

        /// <summary>
        /// SZHBST3.
        /// </summary>
        public const string SZHBST3 = "SZHBST3";

        /// <summary>
        /// SZHBST4.
        /// </summary>
        public const string SZHBST4 = "SZHBST4";

        /// <summary>
        /// SZHBST5.
        /// </summary>
        public const string SZHBST5 = "SZHBST5";

        /// <summary>
        /// SZCRTU.
        /// </summary>
        public const string SZCRTU = "SZCRTU";

        /// <summary>
        /// SZCRTJ.
        /// </summary>
        public const string SZCRTJ = "SZCRTJ";

        /// <summary>
        /// SZCRTT.
        /// </summary>
        public const string SZCRTT = "SZCRTT";

        /// <summary>
        /// SZWRKSTNID.
        /// </summary>
        public const string SZWRKSTNID = "SZWRKSTNID";

        /// <summary>
        /// SZHBOPID.
        /// </summary>
        public const string SZHBOPID = "SZHBOPID";

        /// <summary>
        /// SZUPMB.
        /// </summary>
        public const string SZUPMB = "SZUPMB";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZNPF.
        /// </summary>
        public const string SZNPF = "SZNPF";
    }

    /// <inheritdoc />
    public override string TableName => "F44H711Z";

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
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZOPTION", "SZOPTION", JdeDataType.String, 16),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZITM", "SZITM", JdeDataType.Numeric),
        new JdeField("SZSEQ", "SZSEQ", JdeDataType.Numeric),
        new JdeField("SZLITM", "SZLITM", JdeDataType.String, 50),
        new JdeField("SZAITM", "SZAITM", JdeDataType.String, 50),
        new JdeField("SZMCUTJ", "SZMCUTJ", JdeDataType.String, 24),
        new JdeField("SZGENJOB", "SZGENJOB", JdeDataType.Numeric),
        new JdeField("SZJOBS", "SZJOBS", JdeDataType.Numeric),
        new JdeField("SZAVEL", "SZAVEL", JdeDataType.String, 2),
        new JdeField("SZLSWVER", "SZLSWVER", JdeDataType.String, 20),
        new JdeField("SZBUDONLY", "SZBUDONLY", JdeDataType.String, 2),
        new JdeField("SZLSWPOSTB", "SZLSWPOSTB", JdeDataType.String, 2),
        new JdeField("SZHBPFLG1", "SZHBPFLG1", JdeDataType.String, 2),
        new JdeField("SZLSWPOSTC", "SZLSWPOSTC", JdeDataType.String, 2),
        new JdeField("SZOPKID", "SZOPKID", JdeDataType.String, 16),
        new JdeField("SZOKCO", "SZOKCO", JdeDataType.String, 10),
        new JdeField("SZOORN", "SZOORN", JdeDataType.String, 16),
        new JdeField("SZOCTO", "SZOCTO", JdeDataType.String, 4),
        new JdeField("SZOSFX", "SZOSFX", JdeDataType.String, 6),
        new JdeField("SZOGNO", "SZOGNO", JdeDataType.Numeric),
        new JdeField("SZKCOO", "SZKCOO", JdeDataType.String, 10),
        new JdeField("SZDCTO", "SZDCTO", JdeDataType.String, 4),
        new JdeField("SZDOCO", "SZDOCO", JdeDataType.Numeric),
        new JdeField("SZSFXO", "SZSFXO", JdeDataType.String, 6),
        new JdeField("SZLNID", "SZLNID", JdeDataType.Numeric),
        new JdeField("SZHBMCUS", "SZHBMCUS", JdeDataType.String, 24),
        new JdeField("SZHBLOT", "SZHBLOT", JdeDataType.String, 8),
        new JdeField("SZCPHASE", "SZCPHASE", JdeDataType.String, 6),
        new JdeField("SZHBAREA", "SZHBAREA", JdeDataType.String, 6),
        new JdeField("SZSHAN", "SZSHAN", JdeDataType.Numeric),
        new JdeField("SZDGL", "SZDGL", JdeDataType.Numeric),
        new JdeField("SZOPDJ", "SZOPDJ", JdeDataType.Numeric),
        new JdeField("SZTRDJ", "SZTRDJ", JdeDataType.Numeric),
        new JdeField("SZPN", "SZPN", JdeDataType.Numeric),
        new JdeField("SZDESC", "SZDESC", JdeDataType.String, 60),
        new JdeField("SZVR01", "SZVR01", JdeDataType.String, 50),
        new JdeField("SZVR02", "SZVR02", JdeDataType.String, 50),
        new JdeField("SZDSC1", "SZDSC1", JdeDataType.String, 60),
        new JdeField("SZDSC2", "SZDSC2", JdeDataType.String, 60),
        new JdeField("SZRMK", "SZRMK", JdeDataType.String, 60),
        new JdeField("SZVNDTBD", "SZVNDTBD", JdeDataType.String, 2),
        new JdeField("SZLNTY", "SZLNTY", JdeDataType.String, 4),
        new JdeField("SZPDP1", "SZPDP1", JdeDataType.String, 6),
        new JdeField("SZPDP2", "SZPDP2", JdeDataType.String, 6),
        new JdeField("SZPDP3", "SZPDP3", JdeDataType.String, 6),
        new JdeField("SZPDP4", "SZPDP4", JdeDataType.String, 6),
        new JdeField("SZPDP5", "SZPDP5", JdeDataType.String, 6),
        new JdeField("SZOSCQTY", "SZOSCQTY", JdeDataType.Numeric),
        new JdeField("SZUOM", "SZUOM", JdeDataType.String, 4),
        new JdeField("SZUORG", "SZUORG", JdeDataType.Numeric),
        new JdeField("SZPRRC", "SZPRRC", JdeDataType.Numeric),
        new JdeField("SZAEXP", "SZAEXP", JdeDataType.Numeric),
        new JdeField("SZFTN1", "SZFTN1", JdeDataType.Numeric),
        new JdeField("SZLSWOGBA", "SZLSWOGBA", JdeDataType.Numeric),
        new JdeField("SZPTC", "SZPTC", JdeDataType.String, 6),
        new JdeField("SZTX", "SZTX", JdeDataType.String, 2),
        new JdeField("SZEXR1", "SZEXR1", JdeDataType.String, 4),
        new JdeField("SZTXA1", "SZTXA1", JdeDataType.String, 20),
        new JdeField("SZATXT", "SZATXT", JdeDataType.String, 2),
        new JdeField("SZANBY", "SZANBY", JdeDataType.Numeric),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZSTTS", "SZSTTS", JdeDataType.String, 4),
        new JdeField("SZRCD", "SZRCD", JdeDataType.String, 6),
        new JdeField("SZFUF1", "SZFUF1", JdeDataType.String, 2),
        new JdeField("SZFUF2", "SZFUF2", JdeDataType.String, 2),
        new JdeField("SZANI", "SZANI", JdeDataType.String, 58),
        new JdeField("SZAID", "SZAID", JdeDataType.String, 16),
        new JdeField("SZLT", "SZLT", JdeDataType.String, 4),
        new JdeField("SZHBPLAN", "SZHBPLAN", JdeDataType.String, 8),
        new JdeField("SZHBELEV", "SZHBELEV", JdeDataType.String, 6),
        new JdeField("SZR001", "SZR001", JdeDataType.String, 6),
        new JdeField("SZPCRT", "SZPCRT", JdeDataType.Numeric),
        new JdeField("SZRTNR", "SZRTNR", JdeDataType.String, 6),
        new JdeField("SZPURG", "SZPURG", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRCF", "SZCRCF", JdeDataType.String, 6),
        new JdeField("SZCRRM", "SZCRRM", JdeDataType.String, 2),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZFRRC", "SZFRRC", JdeDataType.Numeric),
        new JdeField("SZFEA", "SZFEA", JdeDataType.Numeric),
        new JdeField("SZFUC", "SZFUC", JdeDataType.Numeric),
        new JdeField("SZFEC", "SZFEC", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZHBST1", "SZHBST1", JdeDataType.String, 2),
        new JdeField("SZHBST2", "SZHBST2", JdeDataType.String, 2),
        new JdeField("SZHBST3", "SZHBST3", JdeDataType.String, 2),
        new JdeField("SZHBST4", "SZHBST4", JdeDataType.String, 2),
        new JdeField("SZHBST5", "SZHBST5", JdeDataType.String, 2),
        new JdeField("SZCRTU", "SZCRTU", JdeDataType.String, 20),
        new JdeField("SZCRTJ", "SZCRTJ", JdeDataType.Numeric),
        new JdeField("SZCRTT", "SZCRTT", JdeDataType.Numeric),
        new JdeField("SZWRKSTNID", "SZWRKSTNID", JdeDataType.String, 20),
        new JdeField("SZHBOPID", "SZHBOPID", JdeDataType.String, 20),
        new JdeField("SZUPMB", "SZUPMB", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZNPF", "SZNPF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H711Z_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H711Z_2", "Index on SZMCU, SZOBJ, SZSUB, SZOPTION, SZAN8, SZITM, SZSEQ", new[] { "SZMCU", "SZOBJ", "SZSUB", "SZOPTION", "SZAN8", "SZITM", "SZSEQ" })
    };
}
