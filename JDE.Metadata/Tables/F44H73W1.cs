using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H73W1 - .
/// </summary>
public class F44H73W1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CGJOBS.
        /// </summary>
        public const string CGJOBS = "CGJOBS";

        /// <summary>
        /// CGMCU.
        /// </summary>
        public const string CGMCU = "CGMCU";

        /// <summary>
        /// CGOBJ.
        /// </summary>
        public const string CGOBJ = "CGOBJ";

        /// <summary>
        /// CGSUB.
        /// </summary>
        public const string CGSUB = "CGSUB";

        /// <summary>
        /// CGOPTION.
        /// </summary>
        public const string CGOPTION = "CGOPTION";

        /// <summary>
        /// CGAN8.
        /// </summary>
        public const string CGAN8 = "CGAN8";

        /// <summary>
        /// CGITM.
        /// </summary>
        public const string CGITM = "CGITM";

        /// <summary>
        /// CGSEQ.
        /// </summary>
        public const string CGSEQ = "CGSEQ";

        /// <summary>
        /// CGHBLOT.
        /// </summary>
        public const string CGHBLOT = "CGHBLOT";

        /// <summary>
        /// CGKCOO.
        /// </summary>
        public const string CGKCOO = "CGKCOO";

        /// <summary>
        /// CGDOCO.
        /// </summary>
        public const string CGDOCO = "CGDOCO";

        /// <summary>
        /// CGDCTO.
        /// </summary>
        public const string CGDCTO = "CGDCTO";

        /// <summary>
        /// CGSFXO.
        /// </summary>
        public const string CGSFXO = "CGSFXO";

        /// <summary>
        /// CGLNID.
        /// </summary>
        public const string CGLNID = "CGLNID";

        /// <summary>
        /// CGLSWERR.
        /// </summary>
        public const string CGLSWERR = "CGLSWERR";

        /// <summary>
        /// CGHBAREA.
        /// </summary>
        public const string CGHBAREA = "CGHBAREA";

        /// <summary>
        /// CGHBMCUS.
        /// </summary>
        public const string CGHBMCUS = "CGHBMCUS";

        /// <summary>
        /// CGHBPFLG1.
        /// </summary>
        public const string CGHBPFLG1 = "CGHBPFLG1";

        /// <summary>
        /// CGCPHASE.
        /// </summary>
        public const string CGCPHASE = "CGCPHASE";

        /// <summary>
        /// CGHBPLAN.
        /// </summary>
        public const string CGHBPLAN = "CGHBPLAN";

        /// <summary>
        /// CGHBELEV.
        /// </summary>
        public const string CGHBELEV = "CGHBELEV";

        /// <summary>
        /// CGOKCO.
        /// </summary>
        public const string CGOKCO = "CGOKCO";

        /// <summary>
        /// CGOCTO.
        /// </summary>
        public const string CGOCTO = "CGOCTO";

        /// <summary>
        /// CGOORN.
        /// </summary>
        public const string CGOORN = "CGOORN";

        /// <summary>
        /// CGOGNO.
        /// </summary>
        public const string CGOGNO = "CGOGNO";

        /// <summary>
        /// CGLITM.
        /// </summary>
        public const string CGLITM = "CGLITM";

        /// <summary>
        /// CGUORG.
        /// </summary>
        public const string CGUORG = "CGUORG";

        /// <summary>
        /// CGPRRC.
        /// </summary>
        public const string CGPRRC = "CGPRRC";

        /// <summary>
        /// CGPROV.
        /// </summary>
        public const string CGPROV = "CGPROV";

        /// <summary>
        /// CGAEXP.
        /// </summary>
        public const string CGAEXP = "CGAEXP";

        /// <summary>
        /// CGFTN1.
        /// </summary>
        public const string CGFTN1 = "CGFTN1";

        /// <summary>
        /// CGPTC.
        /// </summary>
        public const string CGPTC = "CGPTC";

        /// <summary>
        /// CGLNTY.
        /// </summary>
        public const string CGLNTY = "CGLNTY";

        /// <summary>
        /// CGUOM.
        /// </summary>
        public const string CGUOM = "CGUOM";

        /// <summary>
        /// CGVR01.
        /// </summary>
        public const string CGVR01 = "CGVR01";

        /// <summary>
        /// CGVR02.
        /// </summary>
        public const string CGVR02 = "CGVR02";

        /// <summary>
        /// CGDSC1.
        /// </summary>
        public const string CGDSC1 = "CGDSC1";

        /// <summary>
        /// CGDSC2.
        /// </summary>
        public const string CGDSC2 = "CGDSC2";

        /// <summary>
        /// CGASID.
        /// </summary>
        public const string CGASID = "CGASID";

        /// <summary>
        /// CGLTTR.
        /// </summary>
        public const string CGLTTR = "CGLTTR";

        /// <summary>
        /// CGNXTR.
        /// </summary>
        public const string CGNXTR = "CGNXTR";

        /// <summary>
        /// CGGLC.
        /// </summary>
        public const string CGGLC = "CGGLC";

        /// <summary>
        /// CGAID.
        /// </summary>
        public const string CGAID = "CGAID";

        /// <summary>
        /// CGANI.
        /// </summary>
        public const string CGANI = "CGANI";

        /// <summary>
        /// CGSBL.
        /// </summary>
        public const string CGSBL = "CGSBL";

        /// <summary>
        /// CGSBLT.
        /// </summary>
        public const string CGSBLT = "CGSBLT";

        /// <summary>
        /// CGDSPR.
        /// </summary>
        public const string CGDSPR = "CGDSPR";

        /// <summary>
        /// CGTX.
        /// </summary>
        public const string CGTX = "CGTX";

        /// <summary>
        /// CGEXR1.
        /// </summary>
        public const string CGEXR1 = "CGEXR1";

        /// <summary>
        /// CGTXA1.
        /// </summary>
        public const string CGTXA1 = "CGTXA1";

        /// <summary>
        /// CGCRCD.
        /// </summary>
        public const string CGCRCD = "CGCRCD";

        /// <summary>
        /// CGCRCF.
        /// </summary>
        public const string CGCRCF = "CGCRCF";

        /// <summary>
        /// CGCRRM.
        /// </summary>
        public const string CGCRRM = "CGCRRM";

        /// <summary>
        /// CGCRR.
        /// </summary>
        public const string CGCRR = "CGCRR";

        /// <summary>
        /// CGFRRC.
        /// </summary>
        public const string CGFRRC = "CGFRRC";

        /// <summary>
        /// CGFEA.
        /// </summary>
        public const string CGFEA = "CGFEA";

        /// <summary>
        /// CGFUC.
        /// </summary>
        public const string CGFUC = "CGFUC";

        /// <summary>
        /// CGFEC.
        /// </summary>
        public const string CGFEC = "CGFEC";

        /// <summary>
        /// CGURRF.
        /// </summary>
        public const string CGURRF = "CGURRF";

        /// <summary>
        /// CGPCRT.
        /// </summary>
        public const string CGPCRT = "CGPCRT";

        /// <summary>
        /// CGRTNR.
        /// </summary>
        public const string CGRTNR = "CGRTNR";

        /// <summary>
        /// CGGLPT.
        /// </summary>
        public const string CGGLPT = "CGGLPT";

        /// <summary>
        /// CGPURG.
        /// </summary>
        public const string CGPURG = "CGPURG";

        /// <summary>
        /// CGR001.
        /// </summary>
        public const string CGR001 = "CGR001";

        /// <summary>
        /// CGIVI.
        /// </summary>
        public const string CGIVI = "CGIVI";

        /// <summary>
        /// CGDGL.
        /// </summary>
        public const string CGDGL = "CGDGL";

        /// <summary>
        /// CGOPDJ.
        /// </summary>
        public const string CGOPDJ = "CGOPDJ";

        /// <summary>
        /// CGTRDJ.
        /// </summary>
        public const string CGTRDJ = "CGTRDJ";

        /// <summary>
        /// CGSHAN.
        /// </summary>
        public const string CGSHAN = "CGSHAN";

        /// <summary>
        /// CGAVEL.
        /// </summary>
        public const string CGAVEL = "CGAVEL";

        /// <summary>
        /// CGDESC.
        /// </summary>
        public const string CGDESC = "CGDESC";

        /// <summary>
        /// CGRMK.
        /// </summary>
        public const string CGRMK = "CGRMK";

        /// <summary>
        /// CGPDP1.
        /// </summary>
        public const string CGPDP1 = "CGPDP1";

        /// <summary>
        /// CGPDP2.
        /// </summary>
        public const string CGPDP2 = "CGPDP2";

        /// <summary>
        /// CGPDP3.
        /// </summary>
        public const string CGPDP3 = "CGPDP3";

        /// <summary>
        /// CGPDP4.
        /// </summary>
        public const string CGPDP4 = "CGPDP4";

        /// <summary>
        /// CGPDP5.
        /// </summary>
        public const string CGPDP5 = "CGPDP5";

        /// <summary>
        /// CGANBY.
        /// </summary>
        public const string CGANBY = "CGANBY";

        /// <summary>
        /// CGFUF1.
        /// </summary>
        public const string CGFUF1 = "CGFUF1";

        /// <summary>
        /// CGFUF2.
        /// </summary>
        public const string CGFUF2 = "CGFUF2";

        /// <summary>
        /// CGRCD.
        /// </summary>
        public const string CGRCD = "CGRCD";

        /// <summary>
        /// CGSTTS.
        /// </summary>
        public const string CGSTTS = "CGSTTS";

        /// <summary>
        /// CGTCID.
        /// </summary>
        public const string CGTCID = "CGTCID";

        /// <summary>
        /// CGUKID.
        /// </summary>
        public const string CGUKID = "CGUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H73W1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CGJOBS", "CGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CGMCU", "CGMCU", JdeDataType.String, 24, true, true),
        new JdeField("CGOBJ", "CGOBJ", JdeDataType.String, 12, true, true),
        new JdeField("CGSUB", "CGSUB", JdeDataType.String, 16, true, true),
        new JdeField("CGOPTION", "CGOPTION", JdeDataType.String, 16, true, true),
        new JdeField("CGAN8", "CGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CGITM", "CGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CGSEQ", "CGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CGHBLOT", "CGHBLOT", JdeDataType.String, 8),
        new JdeField("CGKCOO", "CGKCOO", JdeDataType.String, 10),
        new JdeField("CGDOCO", "CGDOCO", JdeDataType.Numeric),
        new JdeField("CGDCTO", "CGDCTO", JdeDataType.String, 4),
        new JdeField("CGSFXO", "CGSFXO", JdeDataType.String, 6),
        new JdeField("CGLNID", "CGLNID", JdeDataType.Numeric),
        new JdeField("CGLSWERR", "CGLSWERR", JdeDataType.String, 20),
        new JdeField("CGHBAREA", "CGHBAREA", JdeDataType.String, 6),
        new JdeField("CGHBMCUS", "CGHBMCUS", JdeDataType.String, 24),
        new JdeField("CGHBPFLG1", "CGHBPFLG1", JdeDataType.String, 2),
        new JdeField("CGCPHASE", "CGCPHASE", JdeDataType.String, 6),
        new JdeField("CGHBPLAN", "CGHBPLAN", JdeDataType.String, 8),
        new JdeField("CGHBELEV", "CGHBELEV", JdeDataType.String, 6),
        new JdeField("CGOKCO", "CGOKCO", JdeDataType.String, 10),
        new JdeField("CGOCTO", "CGOCTO", JdeDataType.String, 4),
        new JdeField("CGOORN", "CGOORN", JdeDataType.String, 16),
        new JdeField("CGOGNO", "CGOGNO", JdeDataType.Numeric),
        new JdeField("CGLITM", "CGLITM", JdeDataType.String, 50),
        new JdeField("CGUORG", "CGUORG", JdeDataType.Numeric),
        new JdeField("CGPRRC", "CGPRRC", JdeDataType.Numeric),
        new JdeField("CGPROV", "CGPROV", JdeDataType.String, 2),
        new JdeField("CGAEXP", "CGAEXP", JdeDataType.Numeric),
        new JdeField("CGFTN1", "CGFTN1", JdeDataType.Numeric),
        new JdeField("CGPTC", "CGPTC", JdeDataType.String, 6),
        new JdeField("CGLNTY", "CGLNTY", JdeDataType.String, 4),
        new JdeField("CGUOM", "CGUOM", JdeDataType.String, 4),
        new JdeField("CGVR01", "CGVR01", JdeDataType.String, 50),
        new JdeField("CGVR02", "CGVR02", JdeDataType.String, 50),
        new JdeField("CGDSC1", "CGDSC1", JdeDataType.String, 60),
        new JdeField("CGDSC2", "CGDSC2", JdeDataType.String, 60),
        new JdeField("CGASID", "CGASID", JdeDataType.String, 50),
        new JdeField("CGLTTR", "CGLTTR", JdeDataType.String, 6),
        new JdeField("CGNXTR", "CGNXTR", JdeDataType.String, 6),
        new JdeField("CGGLC", "CGGLC", JdeDataType.String, 8),
        new JdeField("CGAID", "CGAID", JdeDataType.String, 16),
        new JdeField("CGANI", "CGANI", JdeDataType.String, 58),
        new JdeField("CGSBL", "CGSBL", JdeDataType.String, 16),
        new JdeField("CGSBLT", "CGSBLT", JdeDataType.String, 2),
        new JdeField("CGDSPR", "CGDSPR", JdeDataType.Numeric),
        new JdeField("CGTX", "CGTX", JdeDataType.String, 2),
        new JdeField("CGEXR1", "CGEXR1", JdeDataType.String, 4),
        new JdeField("CGTXA1", "CGTXA1", JdeDataType.String, 20),
        new JdeField("CGCRCD", "CGCRCD", JdeDataType.String, 6),
        new JdeField("CGCRCF", "CGCRCF", JdeDataType.String, 6),
        new JdeField("CGCRRM", "CGCRRM", JdeDataType.String, 2),
        new JdeField("CGCRR", "CGCRR", JdeDataType.Numeric),
        new JdeField("CGFRRC", "CGFRRC", JdeDataType.Numeric),
        new JdeField("CGFEA", "CGFEA", JdeDataType.Numeric),
        new JdeField("CGFUC", "CGFUC", JdeDataType.Numeric),
        new JdeField("CGFEC", "CGFEC", JdeDataType.Numeric),
        new JdeField("CGURRF", "CGURRF", JdeDataType.String, 30),
        new JdeField("CGPCRT", "CGPCRT", JdeDataType.Numeric),
        new JdeField("CGRTNR", "CGRTNR", JdeDataType.String, 6),
        new JdeField("CGGLPT", "CGGLPT", JdeDataType.String, 8),
        new JdeField("CGPURG", "CGPURG", JdeDataType.String, 2),
        new JdeField("CGR001", "CGR001", JdeDataType.String, 6),
        new JdeField("CGIVI", "CGIVI", JdeDataType.String, 2),
        new JdeField("CGDGL", "CGDGL", JdeDataType.Numeric),
        new JdeField("CGOPDJ", "CGOPDJ", JdeDataType.Numeric),
        new JdeField("CGTRDJ", "CGTRDJ", JdeDataType.Numeric),
        new JdeField("CGSHAN", "CGSHAN", JdeDataType.Numeric),
        new JdeField("CGAVEL", "CGAVEL", JdeDataType.String, 2),
        new JdeField("CGDESC", "CGDESC", JdeDataType.String, 60),
        new JdeField("CGRMK", "CGRMK", JdeDataType.String, 60),
        new JdeField("CGPDP1", "CGPDP1", JdeDataType.String, 6),
        new JdeField("CGPDP2", "CGPDP2", JdeDataType.String, 6),
        new JdeField("CGPDP3", "CGPDP3", JdeDataType.String, 6),
        new JdeField("CGPDP4", "CGPDP4", JdeDataType.String, 6),
        new JdeField("CGPDP5", "CGPDP5", JdeDataType.String, 6),
        new JdeField("CGANBY", "CGANBY", JdeDataType.Numeric),
        new JdeField("CGFUF1", "CGFUF1", JdeDataType.String, 2),
        new JdeField("CGFUF2", "CGFUF2", JdeDataType.String, 2),
        new JdeField("CGRCD", "CGRCD", JdeDataType.String, 6),
        new JdeField("CGSTTS", "CGSTTS", JdeDataType.String, 4),
        new JdeField("CGTCID", "CGTCID", JdeDataType.Numeric),
        new JdeField("CGUKID", "CGUKID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H73W1_0", "Primary Key on CGJOBS, CGMCU, CGOBJ, CGSUB, CGOPTION, CGAN8, CGITM, CGSEQ", new[] { "CGJOBS", "CGMCU", "CGOBJ", "CGSUB", "CGOPTION", "CGAN8", "CGITM", "CGSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H73W1_2", "Index on CGJOBS, CGMCU, CGHBPFLG1, CGOKCO, CGOCTO, CGOORN, CGOGNO", new[] { "CGJOBS", "CGMCU", "CGHBPFLG1", "CGOKCO", "CGOCTO", "CGOORN", "CGOGNO" }),
        new JdeIndex("F44H73W1_3", "Index on CGJOBS, CGMCU, CGHBPFLG1, CGAN8, CGSUB, CGOBJ, CGOPTION, CGITM", new[] { "CGJOBS", "CGMCU", "CGHBPFLG1", "CGAN8", "CGSUB", "CGOBJ", "CGOPTION", "CGITM" }),
        new JdeIndex("F44H73W1_4", "Index on CGJOBS, CGHBMCUS, CGHBLOT", new[] { "CGJOBS", "CGHBMCUS", "CGHBLOT" }),
        new JdeIndex("F44H73W1_5", "Index on CGJOBS, CGMCU, CGHBPFLG1, CGKCOO, CGDOCO, CGDCTO, CGSFXO, CGLNID", new[] { "CGJOBS", "CGMCU", "CGHBPFLG1", "CGKCOO", "CGDOCO", "CGDCTO", "CGSFXO", "CGLNID" }),
        new JdeIndex("F44H73W1_6", "Index on CGJOBS, CGMCU, CGKCOO, CGDOCO, CGDCTO, CGSFXO, CGHBPFLG1", new[] { "CGJOBS", "CGMCU", "CGKCOO", "CGDOCO", "CGDCTO", "CGSFXO", "CGHBPFLG1" })
    };
}
