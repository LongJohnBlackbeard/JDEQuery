using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H71W1 - .
/// </summary>
public class F44H71W1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GWGENJOB.
        /// </summary>
        public const string GWGENJOB = "GWGENJOB";

        /// <summary>
        /// GWMCU.
        /// </summary>
        public const string GWMCU = "GWMCU";

        /// <summary>
        /// GWOBJ.
        /// </summary>
        public const string GWOBJ = "GWOBJ";

        /// <summary>
        /// GWSUB.
        /// </summary>
        public const string GWSUB = "GWSUB";

        /// <summary>
        /// GWOPTION.
        /// </summary>
        public const string GWOPTION = "GWOPTION";

        /// <summary>
        /// GWAN8.
        /// </summary>
        public const string GWAN8 = "GWAN8";

        /// <summary>
        /// GWITM.
        /// </summary>
        public const string GWITM = "GWITM";

        /// <summary>
        /// GWSEQ.
        /// </summary>
        public const string GWSEQ = "GWSEQ";

        /// <summary>
        /// GWLITM.
        /// </summary>
        public const string GWLITM = "GWLITM";

        /// <summary>
        /// GWAITM.
        /// </summary>
        public const string GWAITM = "GWAITM";

        /// <summary>
        /// GWMCUTJ.
        /// </summary>
        public const string GWMCUTJ = "GWMCUTJ";

        /// <summary>
        /// GWERRF.
        /// </summary>
        public const string GWERRF = "GWERRF";

        /// <summary>
        /// GWOPKID.
        /// </summary>
        public const string GWOPKID = "GWOPKID";

        /// <summary>
        /// GWAVEL.
        /// </summary>
        public const string GWAVEL = "GWAVEL";

        /// <summary>
        /// GWLSWVER.
        /// </summary>
        public const string GWLSWVER = "GWLSWVER";

        /// <summary>
        /// GWBUDONLY.
        /// </summary>
        public const string GWBUDONLY = "GWBUDONLY";

        /// <summary>
        /// GWLSWPOSTB.
        /// </summary>
        public const string GWLSWPOSTB = "GWLSWPOSTB";

        /// <summary>
        /// GWHBPFLG1.
        /// </summary>
        public const string GWHBPFLG1 = "GWHBPFLG1";

        /// <summary>
        /// GWLSWPOSTC.
        /// </summary>
        public const string GWLSWPOSTC = "GWLSWPOSTC";

        /// <summary>
        /// GWOKCO.
        /// </summary>
        public const string GWOKCO = "GWOKCO";

        /// <summary>
        /// GWOORN.
        /// </summary>
        public const string GWOORN = "GWOORN";

        /// <summary>
        /// GWOCTO.
        /// </summary>
        public const string GWOCTO = "GWOCTO";

        /// <summary>
        /// GWOSFX.
        /// </summary>
        public const string GWOSFX = "GWOSFX";

        /// <summary>
        /// GWOGNO.
        /// </summary>
        public const string GWOGNO = "GWOGNO";

        /// <summary>
        /// GWKCOO.
        /// </summary>
        public const string GWKCOO = "GWKCOO";

        /// <summary>
        /// GWDOCO.
        /// </summary>
        public const string GWDOCO = "GWDOCO";

        /// <summary>
        /// GWDCTO.
        /// </summary>
        public const string GWDCTO = "GWDCTO";

        /// <summary>
        /// GWSFXO.
        /// </summary>
        public const string GWSFXO = "GWSFXO";

        /// <summary>
        /// GWLNID.
        /// </summary>
        public const string GWLNID = "GWLNID";

        /// <summary>
        /// GWHBMCUS.
        /// </summary>
        public const string GWHBMCUS = "GWHBMCUS";

        /// <summary>
        /// GWHBLOT.
        /// </summary>
        public const string GWHBLOT = "GWHBLOT";

        /// <summary>
        /// GWCPHASE.
        /// </summary>
        public const string GWCPHASE = "GWCPHASE";

        /// <summary>
        /// GWHBAREA.
        /// </summary>
        public const string GWHBAREA = "GWHBAREA";

        /// <summary>
        /// GWSHAN.
        /// </summary>
        public const string GWSHAN = "GWSHAN";

        /// <summary>
        /// GWDGL.
        /// </summary>
        public const string GWDGL = "GWDGL";

        /// <summary>
        /// GWOPDJ.
        /// </summary>
        public const string GWOPDJ = "GWOPDJ";

        /// <summary>
        /// GWTRDJ.
        /// </summary>
        public const string GWTRDJ = "GWTRDJ";

        /// <summary>
        /// GWPN.
        /// </summary>
        public const string GWPN = "GWPN";

        /// <summary>
        /// GWDESC.
        /// </summary>
        public const string GWDESC = "GWDESC";

        /// <summary>
        /// GWVR01.
        /// </summary>
        public const string GWVR01 = "GWVR01";

        /// <summary>
        /// GWVR02.
        /// </summary>
        public const string GWVR02 = "GWVR02";

        /// <summary>
        /// GWDSC1.
        /// </summary>
        public const string GWDSC1 = "GWDSC1";

        /// <summary>
        /// GWDSC2.
        /// </summary>
        public const string GWDSC2 = "GWDSC2";

        /// <summary>
        /// GWRMK.
        /// </summary>
        public const string GWRMK = "GWRMK";

        /// <summary>
        /// GWVNDTBD.
        /// </summary>
        public const string GWVNDTBD = "GWVNDTBD";

        /// <summary>
        /// GWLNTY.
        /// </summary>
        public const string GWLNTY = "GWLNTY";

        /// <summary>
        /// GWPDP1.
        /// </summary>
        public const string GWPDP1 = "GWPDP1";

        /// <summary>
        /// GWPDP2.
        /// </summary>
        public const string GWPDP2 = "GWPDP2";

        /// <summary>
        /// GWPDP3.
        /// </summary>
        public const string GWPDP3 = "GWPDP3";

        /// <summary>
        /// GWPDP4.
        /// </summary>
        public const string GWPDP4 = "GWPDP4";

        /// <summary>
        /// GWPDP5.
        /// </summary>
        public const string GWPDP5 = "GWPDP5";

        /// <summary>
        /// GWOSCQTY.
        /// </summary>
        public const string GWOSCQTY = "GWOSCQTY";

        /// <summary>
        /// GWUOM.
        /// </summary>
        public const string GWUOM = "GWUOM";

        /// <summary>
        /// GWUORG.
        /// </summary>
        public const string GWUORG = "GWUORG";

        /// <summary>
        /// GWPRRC.
        /// </summary>
        public const string GWPRRC = "GWPRRC";

        /// <summary>
        /// GWAEXP.
        /// </summary>
        public const string GWAEXP = "GWAEXP";

        /// <summary>
        /// GWFTN1.
        /// </summary>
        public const string GWFTN1 = "GWFTN1";

        /// <summary>
        /// GWLSWOGBA.
        /// </summary>
        public const string GWLSWOGBA = "GWLSWOGBA";

        /// <summary>
        /// GWPTC.
        /// </summary>
        public const string GWPTC = "GWPTC";

        /// <summary>
        /// GWTX.
        /// </summary>
        public const string GWTX = "GWTX";

        /// <summary>
        /// GWEXR1.
        /// </summary>
        public const string GWEXR1 = "GWEXR1";

        /// <summary>
        /// GWTXA1.
        /// </summary>
        public const string GWTXA1 = "GWTXA1";

        /// <summary>
        /// GWATXT.
        /// </summary>
        public const string GWATXT = "GWATXT";

        /// <summary>
        /// GWANBY.
        /// </summary>
        public const string GWANBY = "GWANBY";

        /// <summary>
        /// GWGLC.
        /// </summary>
        public const string GWGLC = "GWGLC";

        /// <summary>
        /// GWCTRY.
        /// </summary>
        public const string GWCTRY = "GWCTRY";

        /// <summary>
        /// GWFY.
        /// </summary>
        public const string GWFY = "GWFY";

        /// <summary>
        /// GWSTTS.
        /// </summary>
        public const string GWSTTS = "GWSTTS";

        /// <summary>
        /// GWRCD.
        /// </summary>
        public const string GWRCD = "GWRCD";

        /// <summary>
        /// GWFUF1.
        /// </summary>
        public const string GWFUF1 = "GWFUF1";

        /// <summary>
        /// GWFUF2.
        /// </summary>
        public const string GWFUF2 = "GWFUF2";

        /// <summary>
        /// GWANI.
        /// </summary>
        public const string GWANI = "GWANI";

        /// <summary>
        /// GWAID.
        /// </summary>
        public const string GWAID = "GWAID";

        /// <summary>
        /// GWLT.
        /// </summary>
        public const string GWLT = "GWLT";

        /// <summary>
        /// GWHBPLAN.
        /// </summary>
        public const string GWHBPLAN = "GWHBPLAN";

        /// <summary>
        /// GWHBELEV.
        /// </summary>
        public const string GWHBELEV = "GWHBELEV";

        /// <summary>
        /// GWR001.
        /// </summary>
        public const string GWR001 = "GWR001";

        /// <summary>
        /// GWPCRT.
        /// </summary>
        public const string GWPCRT = "GWPCRT";

        /// <summary>
        /// GWRTNR.
        /// </summary>
        public const string GWRTNR = "GWRTNR";

        /// <summary>
        /// GWPURG.
        /// </summary>
        public const string GWPURG = "GWPURG";

        /// <summary>
        /// GWCRCD.
        /// </summary>
        public const string GWCRCD = "GWCRCD";

        /// <summary>
        /// GWCRCF.
        /// </summary>
        public const string GWCRCF = "GWCRCF";

        /// <summary>
        /// GWCRRM.
        /// </summary>
        public const string GWCRRM = "GWCRRM";

        /// <summary>
        /// GWCRR.
        /// </summary>
        public const string GWCRR = "GWCRR";

        /// <summary>
        /// GWFRRC.
        /// </summary>
        public const string GWFRRC = "GWFRRC";

        /// <summary>
        /// GWFEA.
        /// </summary>
        public const string GWFEA = "GWFEA";

        /// <summary>
        /// GWFUC.
        /// </summary>
        public const string GWFUC = "GWFUC";

        /// <summary>
        /// GWFEC.
        /// </summary>
        public const string GWFEC = "GWFEC";

        /// <summary>
        /// GWURRF.
        /// </summary>
        public const string GWURRF = "GWURRF";

        /// <summary>
        /// GWHBST1.
        /// </summary>
        public const string GWHBST1 = "GWHBST1";

        /// <summary>
        /// GWHBST2.
        /// </summary>
        public const string GWHBST2 = "GWHBST2";

        /// <summary>
        /// GWHBST3.
        /// </summary>
        public const string GWHBST3 = "GWHBST3";

        /// <summary>
        /// GWHBST4.
        /// </summary>
        public const string GWHBST4 = "GWHBST4";

        /// <summary>
        /// GWHBST5.
        /// </summary>
        public const string GWHBST5 = "GWHBST5";

        /// <summary>
        /// GWCRTU.
        /// </summary>
        public const string GWCRTU = "GWCRTU";

        /// <summary>
        /// GWCRTJ.
        /// </summary>
        public const string GWCRTJ = "GWCRTJ";

        /// <summary>
        /// GWCRTT.
        /// </summary>
        public const string GWCRTT = "GWCRTT";

        /// <summary>
        /// GWWRKSTNID.
        /// </summary>
        public const string GWWRKSTNID = "GWWRKSTNID";

        /// <summary>
        /// GWHBOPID.
        /// </summary>
        public const string GWHBOPID = "GWHBOPID";

        /// <summary>
        /// GWUPMB.
        /// </summary>
        public const string GWUPMB = "GWUPMB";

        /// <summary>
        /// GWUPMJ.
        /// </summary>
        public const string GWUPMJ = "GWUPMJ";

        /// <summary>
        /// GWUPMT.
        /// </summary>
        public const string GWUPMT = "GWUPMT";

        /// <summary>
        /// GWJOBN.
        /// </summary>
        public const string GWJOBN = "GWJOBN";

        /// <summary>
        /// GWPID.
        /// </summary>
        public const string GWPID = "GWPID";

        /// <summary>
        /// GWNPF.
        /// </summary>
        public const string GWNPF = "GWNPF";
    }

    /// <inheritdoc />
    public override string TableName => "F44H71W1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GWGENJOB", "GWGENJOB", JdeDataType.Numeric, null, true, true),
        new JdeField("GWMCU", "GWMCU", JdeDataType.String, 24, true, true),
        new JdeField("GWOBJ", "GWOBJ", JdeDataType.String, 12, true, true),
        new JdeField("GWSUB", "GWSUB", JdeDataType.String, 16, true, true),
        new JdeField("GWOPTION", "GWOPTION", JdeDataType.String, 16, true, true),
        new JdeField("GWAN8", "GWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("GWITM", "GWITM", JdeDataType.Numeric, null, true, true),
        new JdeField("GWSEQ", "GWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("GWLITM", "GWLITM", JdeDataType.String, 50),
        new JdeField("GWAITM", "GWAITM", JdeDataType.String, 50),
        new JdeField("GWMCUTJ", "GWMCUTJ", JdeDataType.String, 24),
        new JdeField("GWERRF", "GWERRF", JdeDataType.String, 20),
        new JdeField("GWOPKID", "GWOPKID", JdeDataType.String, 16),
        new JdeField("GWAVEL", "GWAVEL", JdeDataType.String, 2),
        new JdeField("GWLSWVER", "GWLSWVER", JdeDataType.String, 20),
        new JdeField("GWBUDONLY", "GWBUDONLY", JdeDataType.String, 2),
        new JdeField("GWLSWPOSTB", "GWLSWPOSTB", JdeDataType.String, 2),
        new JdeField("GWHBPFLG1", "GWHBPFLG1", JdeDataType.String, 2),
        new JdeField("GWLSWPOSTC", "GWLSWPOSTC", JdeDataType.String, 2),
        new JdeField("GWOKCO", "GWOKCO", JdeDataType.String, 10),
        new JdeField("GWOORN", "GWOORN", JdeDataType.String, 16),
        new JdeField("GWOCTO", "GWOCTO", JdeDataType.String, 4),
        new JdeField("GWOSFX", "GWOSFX", JdeDataType.String, 6),
        new JdeField("GWOGNO", "GWOGNO", JdeDataType.Numeric),
        new JdeField("GWKCOO", "GWKCOO", JdeDataType.String, 10),
        new JdeField("GWDOCO", "GWDOCO", JdeDataType.Numeric),
        new JdeField("GWDCTO", "GWDCTO", JdeDataType.String, 4),
        new JdeField("GWSFXO", "GWSFXO", JdeDataType.String, 6),
        new JdeField("GWLNID", "GWLNID", JdeDataType.Numeric),
        new JdeField("GWHBMCUS", "GWHBMCUS", JdeDataType.String, 24),
        new JdeField("GWHBLOT", "GWHBLOT", JdeDataType.String, 8),
        new JdeField("GWCPHASE", "GWCPHASE", JdeDataType.String, 6),
        new JdeField("GWHBAREA", "GWHBAREA", JdeDataType.String, 6),
        new JdeField("GWSHAN", "GWSHAN", JdeDataType.Numeric),
        new JdeField("GWDGL", "GWDGL", JdeDataType.Numeric),
        new JdeField("GWOPDJ", "GWOPDJ", JdeDataType.Numeric),
        new JdeField("GWTRDJ", "GWTRDJ", JdeDataType.Numeric),
        new JdeField("GWPN", "GWPN", JdeDataType.Numeric),
        new JdeField("GWDESC", "GWDESC", JdeDataType.String, 60),
        new JdeField("GWVR01", "GWVR01", JdeDataType.String, 50),
        new JdeField("GWVR02", "GWVR02", JdeDataType.String, 50),
        new JdeField("GWDSC1", "GWDSC1", JdeDataType.String, 60),
        new JdeField("GWDSC2", "GWDSC2", JdeDataType.String, 60),
        new JdeField("GWRMK", "GWRMK", JdeDataType.String, 60),
        new JdeField("GWVNDTBD", "GWVNDTBD", JdeDataType.String, 2),
        new JdeField("GWLNTY", "GWLNTY", JdeDataType.String, 4),
        new JdeField("GWPDP1", "GWPDP1", JdeDataType.String, 6),
        new JdeField("GWPDP2", "GWPDP2", JdeDataType.String, 6),
        new JdeField("GWPDP3", "GWPDP3", JdeDataType.String, 6),
        new JdeField("GWPDP4", "GWPDP4", JdeDataType.String, 6),
        new JdeField("GWPDP5", "GWPDP5", JdeDataType.String, 6),
        new JdeField("GWOSCQTY", "GWOSCQTY", JdeDataType.Numeric),
        new JdeField("GWUOM", "GWUOM", JdeDataType.String, 4),
        new JdeField("GWUORG", "GWUORG", JdeDataType.Numeric),
        new JdeField("GWPRRC", "GWPRRC", JdeDataType.Numeric),
        new JdeField("GWAEXP", "GWAEXP", JdeDataType.Numeric),
        new JdeField("GWFTN1", "GWFTN1", JdeDataType.Numeric),
        new JdeField("GWLSWOGBA", "GWLSWOGBA", JdeDataType.Numeric),
        new JdeField("GWPTC", "GWPTC", JdeDataType.String, 6),
        new JdeField("GWTX", "GWTX", JdeDataType.String, 2),
        new JdeField("GWEXR1", "GWEXR1", JdeDataType.String, 4),
        new JdeField("GWTXA1", "GWTXA1", JdeDataType.String, 20),
        new JdeField("GWATXT", "GWATXT", JdeDataType.String, 2),
        new JdeField("GWANBY", "GWANBY", JdeDataType.Numeric),
        new JdeField("GWGLC", "GWGLC", JdeDataType.String, 8),
        new JdeField("GWCTRY", "GWCTRY", JdeDataType.Numeric),
        new JdeField("GWFY", "GWFY", JdeDataType.Numeric),
        new JdeField("GWSTTS", "GWSTTS", JdeDataType.String, 4),
        new JdeField("GWRCD", "GWRCD", JdeDataType.String, 6),
        new JdeField("GWFUF1", "GWFUF1", JdeDataType.String, 2),
        new JdeField("GWFUF2", "GWFUF2", JdeDataType.String, 2),
        new JdeField("GWANI", "GWANI", JdeDataType.String, 58),
        new JdeField("GWAID", "GWAID", JdeDataType.String, 16),
        new JdeField("GWLT", "GWLT", JdeDataType.String, 4),
        new JdeField("GWHBPLAN", "GWHBPLAN", JdeDataType.String, 8),
        new JdeField("GWHBELEV", "GWHBELEV", JdeDataType.String, 6),
        new JdeField("GWR001", "GWR001", JdeDataType.String, 6),
        new JdeField("GWPCRT", "GWPCRT", JdeDataType.Numeric),
        new JdeField("GWRTNR", "GWRTNR", JdeDataType.String, 6),
        new JdeField("GWPURG", "GWPURG", JdeDataType.String, 2),
        new JdeField("GWCRCD", "GWCRCD", JdeDataType.String, 6),
        new JdeField("GWCRCF", "GWCRCF", JdeDataType.String, 6),
        new JdeField("GWCRRM", "GWCRRM", JdeDataType.String, 2),
        new JdeField("GWCRR", "GWCRR", JdeDataType.Numeric),
        new JdeField("GWFRRC", "GWFRRC", JdeDataType.Numeric),
        new JdeField("GWFEA", "GWFEA", JdeDataType.Numeric),
        new JdeField("GWFUC", "GWFUC", JdeDataType.Numeric),
        new JdeField("GWFEC", "GWFEC", JdeDataType.Numeric),
        new JdeField("GWURRF", "GWURRF", JdeDataType.String, 30),
        new JdeField("GWHBST1", "GWHBST1", JdeDataType.String, 2),
        new JdeField("GWHBST2", "GWHBST2", JdeDataType.String, 2),
        new JdeField("GWHBST3", "GWHBST3", JdeDataType.String, 2),
        new JdeField("GWHBST4", "GWHBST4", JdeDataType.String, 2),
        new JdeField("GWHBST5", "GWHBST5", JdeDataType.String, 2),
        new JdeField("GWCRTU", "GWCRTU", JdeDataType.String, 20),
        new JdeField("GWCRTJ", "GWCRTJ", JdeDataType.Numeric),
        new JdeField("GWCRTT", "GWCRTT", JdeDataType.Numeric),
        new JdeField("GWWRKSTNID", "GWWRKSTNID", JdeDataType.String, 20),
        new JdeField("GWHBOPID", "GWHBOPID", JdeDataType.String, 20),
        new JdeField("GWUPMB", "GWUPMB", JdeDataType.String, 20),
        new JdeField("GWUPMJ", "GWUPMJ", JdeDataType.Numeric),
        new JdeField("GWUPMT", "GWUPMT", JdeDataType.Numeric),
        new JdeField("GWJOBN", "GWJOBN", JdeDataType.String, 20),
        new JdeField("GWPID", "GWPID", JdeDataType.String, 20),
        new JdeField("GWNPF", "GWNPF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H71W1_0", "Primary Key on GWGENJOB, GWMCU, GWOBJ, GWSUB, GWOPTION, GWAN8, GWITM, GWSEQ", new[] { "GWGENJOB", "GWMCU", "GWOBJ", "GWSUB", "GWOPTION", "GWAN8", "GWITM", "GWSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H71W1_3", "Index on GWGENJOB, GWMCU, GWOPTION, GWOBJ, GWSUB, GWAN8, GWITM, SYS_NC00106$", new[] { "GWGENJOB", "GWMCU", "GWOPTION", "GWOBJ", "GWSUB", "GWAN8", "GWITM", "SYS_NC00106$" })
    };
}
