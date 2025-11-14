using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43UI50D - .
/// </summary>
public class F43UI50D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PWSEQ.
        /// </summary>
        public const string PWSEQ = "PWSEQ";

        /// <summary>
        /// PWSEQ1.
        /// </summary>
        public const string PWSEQ1 = "PWSEQ1";

        /// <summary>
        /// PWDOCO.
        /// </summary>
        public const string PWDOCO = "PWDOCO";

        /// <summary>
        /// PWDCTO.
        /// </summary>
        public const string PWDCTO = "PWDCTO";

        /// <summary>
        /// PWKCOO.
        /// </summary>
        public const string PWKCOO = "PWKCOO";

        /// <summary>
        /// PWSFXO.
        /// </summary>
        public const string PWSFXO = "PWSFXO";

        /// <summary>
        /// PWLNID.
        /// </summary>
        public const string PWLNID = "PWLNID";

        /// <summary>
        /// PWCORD.
        /// </summary>
        public const string PWCORD = "PWCORD";

        /// <summary>
        /// PWDSC1.
        /// </summary>
        public const string PWDSC1 = "PWDSC1";

        /// <summary>
        /// PWUORG.
        /// </summary>
        public const string PWUORG = "PWUORG";

        /// <summary>
        /// PWUOM.
        /// </summary>
        public const string PWUOM = "PWUOM";

        /// <summary>
        /// PWPRRC.
        /// </summary>
        public const string PWPRRC = "PWPRRC";

        /// <summary>
        /// PWUOM3.
        /// </summary>
        public const string PWUOM3 = "PWUOM3";

        /// <summary>
        /// PWANCR.
        /// </summary>
        public const string PWANCR = "PWANCR";

        /// <summary>
        /// PWMOT.
        /// </summary>
        public const string PWMOT = "PWMOT";

        /// <summary>
        /// PWAEXP.
        /// </summary>
        public const string PWAEXP = "PWAEXP";

        /// <summary>
        /// PWTRDJ.
        /// </summary>
        public const string PWTRDJ = "PWTRDJ";

        /// <summary>
        /// PWPDDJ.
        /// </summary>
        public const string PWPDDJ = "PWPDDJ";

        /// <summary>
        /// PWCNDJ.
        /// </summary>
        public const string PWCNDJ = "PWCNDJ";

        /// <summary>
        /// PWDRQJ.
        /// </summary>
        public const string PWDRQJ = "PWDRQJ";

        /// <summary>
        /// PWOKCO.
        /// </summary>
        public const string PWOKCO = "PWOKCO";

        /// <summary>
        /// PWOORN.
        /// </summary>
        public const string PWOORN = "PWOORN";

        /// <summary>
        /// PWOCTO.
        /// </summary>
        public const string PWOCTO = "PWOCTO";

        /// <summary>
        /// PWDSC2.
        /// </summary>
        public const string PWDSC2 = "PWDSC2";

        /// <summary>
        /// PWITM.
        /// </summary>
        public const string PWITM = "PWITM";

        /// <summary>
        /// PWLITM.
        /// </summary>
        public const string PWLITM = "PWLITM";

        /// <summary>
        /// PWAITM.
        /// </summary>
        public const string PWAITM = "PWAITM";

        /// <summary>
        /// PWCITM.
        /// </summary>
        public const string PWCITM = "PWCITM";

        /// <summary>
        /// PWUITM.
        /// </summary>
        public const string PWUITM = "PWUITM";

        /// <summary>
        /// PWFRGD.
        /// </summary>
        public const string PWFRGD = "PWFRGD";

        /// <summary>
        /// PWTHGD.
        /// </summary>
        public const string PWTHGD = "PWTHGD";

        /// <summary>
        /// PWFRMP.
        /// </summary>
        public const string PWFRMP = "PWFRMP";

        /// <summary>
        /// PWTHRP.
        /// </summary>
        public const string PWTHRP = "PWTHRP";

        /// <summary>
        /// PWLNTY.
        /// </summary>
        public const string PWLNTY = "PWLNTY";

        /// <summary>
        /// PWMCU.
        /// </summary>
        public const string PWMCU = "PWMCU";

        /// <summary>
        /// PWANI.
        /// </summary>
        public const string PWANI = "PWANI";

        /// <summary>
        /// PWOMCU.
        /// </summary>
        public const string PWOMCU = "PWOMCU";

        /// <summary>
        /// PWOBJ.
        /// </summary>
        public const string PWOBJ = "PWOBJ";

        /// <summary>
        /// PWSUB.
        /// </summary>
        public const string PWSUB = "PWSUB";

        /// <summary>
        /// PWSBL.
        /// </summary>
        public const string PWSBL = "PWSBL";

        /// <summary>
        /// PWSBLT.
        /// </summary>
        public const string PWSBLT = "PWSBLT";

        /// <summary>
        /// PWFRRC.
        /// </summary>
        public const string PWFRRC = "PWFRRC";

        /// <summary>
        /// PWFEA.
        /// </summary>
        public const string PWFEA = "PWFEA";

        /// <summary>
        /// PWRKCO.
        /// </summary>
        public const string PWRKCO = "PWRKCO";

        /// <summary>
        /// PWRORN.
        /// </summary>
        public const string PWRORN = "PWRORN";

        /// <summary>
        /// PWRCTO.
        /// </summary>
        public const string PWRCTO = "PWRCTO";

        /// <summary>
        /// PWRLLN.
        /// </summary>
        public const string PWRLLN = "PWRLLN";

        /// <summary>
        /// PWDMCT.
        /// </summary>
        public const string PWDMCT = "PWDMCT";

        /// <summary>
        /// PWDMCS.
        /// </summary>
        public const string PWDMCS = "PWDMCS";

        /// <summary>
        /// PWSHAN.
        /// </summary>
        public const string PWSHAN = "PWSHAN";

        /// <summary>
        /// PWVR01.
        /// </summary>
        public const string PWVR01 = "PWVR01";

        /// <summary>
        /// PWVR02.
        /// </summary>
        public const string PWVR02 = "PWVR02";

        /// <summary>
        /// PWDSC3.
        /// </summary>
        public const string PWDSC3 = "PWDSC3";

        /// <summary>
        /// PWINMG.
        /// </summary>
        public const string PWINMG = "PWINMG";

        /// <summary>
        /// PWPTC.
        /// </summary>
        public const string PWPTC = "PWPTC";

        /// <summary>
        /// PWPTD.
        /// </summary>
        public const string PWPTD = "PWPTD";

        /// <summary>
        /// PWURCD.
        /// </summary>
        public const string PWURCD = "PWURCD";

        /// <summary>
        /// PWURDT.
        /// </summary>
        public const string PWURDT = "PWURDT";

        /// <summary>
        /// PWURAT.
        /// </summary>
        public const string PWURAT = "PWURAT";

        /// <summary>
        /// PWURAB.
        /// </summary>
        public const string PWURAB = "PWURAB";

        /// <summary>
        /// PWURRF.
        /// </summary>
        public const string PWURRF = "PWURRF";

        /// <summary>
        /// PWTORG.
        /// </summary>
        public const string PWTORG = "PWTORG";

        /// <summary>
        /// PWUSER.
        /// </summary>
        public const string PWUSER = "PWUSER";

        /// <summary>
        /// PWPID.
        /// </summary>
        public const string PWPID = "PWPID";

        /// <summary>
        /// PWJOBN.
        /// </summary>
        public const string PWJOBN = "PWJOBN";

        /// <summary>
        /// PWUPMJ.
        /// </summary>
        public const string PWUPMJ = "PWUPMJ";

        /// <summary>
        /// PWTDAY.
        /// </summary>
        public const string PWTDAY = "PWTDAY";

        /// <summary>
        /// PWCTID.
        /// </summary>
        public const string PWCTID = "PWCTID";

        /// <summary>
        /// PWPODC01.
        /// </summary>
        public const string PWPODC01 = "PWPODC01";

        /// <summary>
        /// PWPODC02.
        /// </summary>
        public const string PWPODC02 = "PWPODC02";

        /// <summary>
        /// PWPODC03.
        /// </summary>
        public const string PWPODC03 = "PWPODC03";

        /// <summary>
        /// PWPODC04.
        /// </summary>
        public const string PWPODC04 = "PWPODC04";

        /// <summary>
        /// PWJBCD.
        /// </summary>
        public const string PWJBCD = "PWJBCD";

        /// <summary>
        /// PWCLNU.
        /// </summary>
        public const string PWCLNU = "PWCLNU";

        /// <summary>
        /// PWDL01.
        /// </summary>
        public const string PWDL01 = "PWDL01";

        /// <summary>
        /// PWODCM.
        /// </summary>
        public const string PWODCM = "PWODCM";

        /// <summary>
        /// PWGOVPR.
        /// </summary>
        public const string PWGOVPR = "PWGOVPR";

        /// <summary>
        /// PWFDCL.
        /// </summary>
        public const string PWFDCL = "PWFDCL";

        /// <summary>
        /// PWSRQTY.
        /// </summary>
        public const string PWSRQTY = "PWSRQTY";

        /// <summary>
        /// PWSRUOM.
        /// </summary>
        public const string PWSRUOM = "PWSRUOM";
    }

    /// <inheritdoc />
    public override string TableName => "F43UI50D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PWSEQ", "PWSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PWSEQ1", "PWSEQ1", JdeDataType.Numeric, null, true, true),
        new JdeField("PWDOCO", "PWDOCO", JdeDataType.Numeric),
        new JdeField("PWDCTO", "PWDCTO", JdeDataType.String, 4),
        new JdeField("PWKCOO", "PWKCOO", JdeDataType.String, 10),
        new JdeField("PWSFXO", "PWSFXO", JdeDataType.String, 6),
        new JdeField("PWLNID", "PWLNID", JdeDataType.Numeric),
        new JdeField("PWCORD", "PWCORD", JdeDataType.Numeric),
        new JdeField("PWDSC1", "PWDSC1", JdeDataType.String, 60),
        new JdeField("PWUORG", "PWUORG", JdeDataType.Numeric),
        new JdeField("PWUOM", "PWUOM", JdeDataType.String, 4),
        new JdeField("PWPRRC", "PWPRRC", JdeDataType.Numeric),
        new JdeField("PWUOM3", "PWUOM3", JdeDataType.String, 4),
        new JdeField("PWANCR", "PWANCR", JdeDataType.Numeric),
        new JdeField("PWMOT", "PWMOT", JdeDataType.String, 6),
        new JdeField("PWAEXP", "PWAEXP", JdeDataType.Numeric),
        new JdeField("PWTRDJ", "PWTRDJ", JdeDataType.Numeric),
        new JdeField("PWPDDJ", "PWPDDJ", JdeDataType.Numeric),
        new JdeField("PWCNDJ", "PWCNDJ", JdeDataType.Numeric),
        new JdeField("PWDRQJ", "PWDRQJ", JdeDataType.Numeric),
        new JdeField("PWOKCO", "PWOKCO", JdeDataType.String, 10),
        new JdeField("PWOORN", "PWOORN", JdeDataType.String, 16),
        new JdeField("PWOCTO", "PWOCTO", JdeDataType.String, 4),
        new JdeField("PWDSC2", "PWDSC2", JdeDataType.String, 60),
        new JdeField("PWITM", "PWITM", JdeDataType.Numeric),
        new JdeField("PWLITM", "PWLITM", JdeDataType.String, 50),
        new JdeField("PWAITM", "PWAITM", JdeDataType.String, 50),
        new JdeField("PWCITM", "PWCITM", JdeDataType.String, 50),
        new JdeField("PWUITM", "PWUITM", JdeDataType.String, 52),
        new JdeField("PWFRGD", "PWFRGD", JdeDataType.String, 6),
        new JdeField("PWTHGD", "PWTHGD", JdeDataType.String, 6),
        new JdeField("PWFRMP", "PWFRMP", JdeDataType.Numeric),
        new JdeField("PWTHRP", "PWTHRP", JdeDataType.Numeric),
        new JdeField("PWLNTY", "PWLNTY", JdeDataType.String, 4),
        new JdeField("PWMCU", "PWMCU", JdeDataType.String, 24),
        new JdeField("PWANI", "PWANI", JdeDataType.String, 58),
        new JdeField("PWOMCU", "PWOMCU", JdeDataType.String, 24),
        new JdeField("PWOBJ", "PWOBJ", JdeDataType.String, 12),
        new JdeField("PWSUB", "PWSUB", JdeDataType.String, 16),
        new JdeField("PWSBL", "PWSBL", JdeDataType.String, 16),
        new JdeField("PWSBLT", "PWSBLT", JdeDataType.String, 2),
        new JdeField("PWFRRC", "PWFRRC", JdeDataType.Numeric),
        new JdeField("PWFEA", "PWFEA", JdeDataType.Numeric),
        new JdeField("PWRKCO", "PWRKCO", JdeDataType.String, 10),
        new JdeField("PWRORN", "PWRORN", JdeDataType.String, 16),
        new JdeField("PWRCTO", "PWRCTO", JdeDataType.String, 4),
        new JdeField("PWRLLN", "PWRLLN", JdeDataType.Numeric),
        new JdeField("PWDMCT", "PWDMCT", JdeDataType.String, 24),
        new JdeField("PWDMCS", "PWDMCS", JdeDataType.Numeric),
        new JdeField("PWSHAN", "PWSHAN", JdeDataType.Numeric),
        new JdeField("PWVR01", "PWVR01", JdeDataType.String, 50),
        new JdeField("PWVR02", "PWVR02", JdeDataType.String, 50),
        new JdeField("PWDSC3", "PWDSC3", JdeDataType.String, 60),
        new JdeField("PWINMG", "PWINMG", JdeDataType.String, 20),
        new JdeField("PWPTC", "PWPTC", JdeDataType.String, 6),
        new JdeField("PWPTD", "PWPTD", JdeDataType.String, 60),
        new JdeField("PWURCD", "PWURCD", JdeDataType.String, 4),
        new JdeField("PWURDT", "PWURDT", JdeDataType.Numeric),
        new JdeField("PWURAT", "PWURAT", JdeDataType.Numeric),
        new JdeField("PWURAB", "PWURAB", JdeDataType.Numeric),
        new JdeField("PWURRF", "PWURRF", JdeDataType.String, 30),
        new JdeField("PWTORG", "PWTORG", JdeDataType.String, 20),
        new JdeField("PWUSER", "PWUSER", JdeDataType.String, 20),
        new JdeField("PWPID", "PWPID", JdeDataType.String, 20),
        new JdeField("PWJOBN", "PWJOBN", JdeDataType.String, 20, true, true),
        new JdeField("PWUPMJ", "PWUPMJ", JdeDataType.Numeric),
        new JdeField("PWTDAY", "PWTDAY", JdeDataType.Numeric),
        new JdeField("PWCTID", "PWCTID", JdeDataType.String, 30, true, true),
        new JdeField("PWPODC01", "PWPODC01", JdeDataType.String, 6),
        new JdeField("PWPODC02", "PWPODC02", JdeDataType.String, 6),
        new JdeField("PWPODC03", "PWPODC03", JdeDataType.String, 20),
        new JdeField("PWPODC04", "PWPODC04", JdeDataType.String, 20),
        new JdeField("PWJBCD", "PWJBCD", JdeDataType.String, 12),
        new JdeField("PWCLNU", "PWCLNU", JdeDataType.Numeric),
        new JdeField("PWDL01", "PWDL01", JdeDataType.String, 60),
        new JdeField("PWODCM", "PWODCM", JdeDataType.String, 50),
        new JdeField("PWGOVPR", "PWGOVPR", JdeDataType.String, 20),
        new JdeField("PWFDCL", "PWFDCL", JdeDataType.String, 2),
        new JdeField("PWSRQTY", "PWSRQTY", JdeDataType.Numeric),
        new JdeField("PWSRUOM", "PWSRUOM", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43UI50D_0", "Primary Key on PWJOBN, PWCTID, PWSEQ, PWSEQ1", new[] { "PWJOBN", "PWCTID", "PWSEQ", "PWSEQ1" }, isUnique: true, isPrimaryKey: true)
    };
}
