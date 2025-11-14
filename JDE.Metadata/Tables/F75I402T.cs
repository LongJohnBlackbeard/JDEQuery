using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I402T - .
/// </summary>
public class F75I402T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTKCOO.
        /// </summary>
        public const string PTKCOO = "PTKCOO";

        /// <summary>
        /// PTDOCO.
        /// </summary>
        public const string PTDOCO = "PTDOCO";

        /// <summary>
        /// PTDCTO.
        /// </summary>
        public const string PTDCTO = "PTDCTO";

        /// <summary>
        /// PTLNID.
        /// </summary>
        public const string PTLNID = "PTLNID";

        /// <summary>
        /// PTNLIN.
        /// </summary>
        public const string PTNLIN = "PTNLIN";

        /// <summary>
        /// PTDOC.
        /// </summary>
        public const string PTDOC = "PTDOC";

        /// <summary>
        /// PTDCT.
        /// </summary>
        public const string PTDCT = "PTDCT";

        /// <summary>
        /// PTTRDJ.
        /// </summary>
        public const string PTTRDJ = "PTTRDJ";

        /// <summary>
        /// PTDGL.
        /// </summary>
        public const string PTDGL = "PTDGL";

        /// <summary>
        /// PTMCU.
        /// </summary>
        public const string PTMCU = "PTMCU";

        /// <summary>
        /// PTLITM.
        /// </summary>
        public const string PTLITM = "PTLITM";

        /// <summary>
        /// PTPRRC.
        /// </summary>
        public const string PTPRRC = "PTPRRC";

        /// <summary>
        /// PTQTYS.
        /// </summary>
        public const string PTQTYS = "PTQTYS";

        /// <summary>
        /// PTAN8.
        /// </summary>
        public const string PTAN8 = "PTAN8";

        /// <summary>
        /// PTLAND.
        /// </summary>
        public const string PTLAND = "PTLAND";

        /// <summary>
        /// PTPRP5.
        /// </summary>
        public const string PTPRP5 = "PTPRP5";

        /// <summary>
        /// PTLVLA.
        /// </summary>
        public const string PTLVLA = "PTLVLA";

        /// <summary>
        /// PTDESC.
        /// </summary>
        public const string PTDESC = "PTDESC";

        /// <summary>
        /// PTPCST.
        /// </summary>
        public const string PTPCST = "PTPCST";

        /// <summary>
        /// PTAREC.
        /// </summary>
        public const string PTAREC = "PTAREC";

        /// <summary>
        /// PTALIN.
        /// </summary>
        public const string PTALIN = "PTALIN";

        /// <summary>
        /// PTPARCNGRP.
        /// </summary>
        public const string PTPARCNGRP = "PTPARCNGRP";

        /// <summary>
        /// PTYFRMTY.
        /// </summary>
        public const string PTYFRMTY = "PTYFRMTY";

        /// <summary>
        /// PTFDNM.
        /// </summary>
        public const string PTFDNM = "PTFDNM";

        /// <summary>
        /// PTADSO.
        /// </summary>
        public const string PTADSO = "PTADSO";

        /// <summary>
        /// PTDATESUB.
        /// </summary>
        public const string PTDATESUB = "PTDATESUB";

        /// <summary>
        /// PTASHD.
        /// </summary>
        public const string PTASHD = "PTASHD";

        /// <summary>
        /// PTREM1.
        /// </summary>
        public const string PTREM1 = "PTREM1";

        /// <summary>
        /// PTPOST.
        /// </summary>
        public const string PTPOST = "PTPOST";

        /// <summary>
        /// PTKCO.
        /// </summary>
        public const string PTKCO = "PTKCO";

        /// <summary>
        /// PTCO.
        /// </summary>
        public const string PTCO = "PTCO";

        /// <summary>
        /// PTASID.
        /// </summary>
        public const string PTASID = "PTASID";

        /// <summary>
        /// PTAFA1.
        /// </summary>
        public const string PTAFA1 = "PTAFA1";

        /// <summary>
        /// PTAFA2.
        /// </summary>
        public const string PTAFA2 = "PTAFA2";

        /// <summary>
        /// PTAFA3.
        /// </summary>
        public const string PTAFA3 = "PTAFA3";

        /// <summary>
        /// PTAFA4.
        /// </summary>
        public const string PTAFA4 = "PTAFA4";

        /// <summary>
        /// PTAFA5.
        /// </summary>
        public const string PTAFA5 = "PTAFA5";

        /// <summary>
        /// PTSRDS.
        /// </summary>
        public const string PTSRDS = "PTSRDS";

        /// <summary>
        /// PTSRDS1.
        /// </summary>
        public const string PTSRDS1 = "PTSRDS1";

        /// <summary>
        /// PTSRDS2.
        /// </summary>
        public const string PTSRDS2 = "PTSRDS2";

        /// <summary>
        /// PTSRDS3.
        /// </summary>
        public const string PTSRDS3 = "PTSRDS3";

        /// <summary>
        /// PTSRDS4.
        /// </summary>
        public const string PTSRDS4 = "PTSRDS4";

        /// <summary>
        /// PTOPT.
        /// </summary>
        public const string PTOPT = "PTOPT";

        /// <summary>
        /// PTOPTF.
        /// </summary>
        public const string PTOPTF = "PTOPTF";

        /// <summary>
        /// PTOPTI.
        /// </summary>
        public const string PTOPTI = "PTOPTI";

        /// <summary>
        /// PTOPTOW.
        /// </summary>
        public const string PTOPTOW = "PTOPTOW";

        /// <summary>
        /// PTOPTD.
        /// </summary>
        public const string PTOPTD = "PTOPTD";

        /// <summary>
        /// PTDT1.
        /// </summary>
        public const string PTDT1 = "PTDT1";

        /// <summary>
        /// PTADTJ.
        /// </summary>
        public const string PTADTJ = "PTADTJ";

        /// <summary>
        /// PTAPVDTE.
        /// </summary>
        public const string PTAPVDTE = "PTAPVDTE";

        /// <summary>
        /// PTAPDT.
        /// </summary>
        public const string PTAPDT = "PTAPDT";

        /// <summary>
        /// PTDT.
        /// </summary>
        public const string PTDT = "PTDT";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTTDAY.
        /// </summary>
        public const string PTTDAY = "PTTDAY";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTEF01.
        /// </summary>
        public const string PTEF01 = "PTEF01";
    }

    /// <inheritdoc />
    public override string TableName => "F75I402T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTKCOO", "PTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PTDOCO", "PTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PTDCTO", "PTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PTLNID", "PTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PTNLIN", "PTNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PTDOC", "PTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PTDCT", "PTDCT", JdeDataType.String, 4),
        new JdeField("PTTRDJ", "PTTRDJ", JdeDataType.Numeric),
        new JdeField("PTDGL", "PTDGL", JdeDataType.Numeric),
        new JdeField("PTMCU", "PTMCU", JdeDataType.String, 24),
        new JdeField("PTLITM", "PTLITM", JdeDataType.String, 50),
        new JdeField("PTPRRC", "PTPRRC", JdeDataType.Numeric),
        new JdeField("PTQTYS", "PTQTYS", JdeDataType.Numeric),
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric),
        new JdeField("PTLAND", "PTLAND", JdeDataType.String, 2),
        new JdeField("PTPRP5", "PTPRP5", JdeDataType.String, 6),
        new JdeField("PTLVLA", "PTLVLA", JdeDataType.String, 6),
        new JdeField("PTDESC", "PTDESC", JdeDataType.String, 60),
        new JdeField("PTPCST", "PTPCST", JdeDataType.Numeric),
        new JdeField("PTAREC", "PTAREC", JdeDataType.Numeric),
        new JdeField("PTALIN", "PTALIN", JdeDataType.Numeric),
        new JdeField("PTPARCNGRP", "PTPARCNGRP", JdeDataType.Numeric),
        new JdeField("PTYFRMTY", "PTYFRMTY", JdeDataType.String, 20),
        new JdeField("PTFDNM", "PTFDNM", JdeDataType.String, 60),
        new JdeField("PTADSO", "PTADSO", JdeDataType.String, 6),
        new JdeField("PTDATESUB", "PTDATESUB", JdeDataType.Numeric),
        new JdeField("PTASHD", "PTASHD", JdeDataType.Numeric),
        new JdeField("PTREM1", "PTREM1", JdeDataType.String, 80),
        new JdeField("PTPOST", "PTPOST", JdeDataType.String, 2),
        new JdeField("PTKCO", "PTKCO", JdeDataType.String, 10),
        new JdeField("PTCO", "PTCO", JdeDataType.String, 10),
        new JdeField("PTASID", "PTASID", JdeDataType.String, 50),
        new JdeField("PTAFA1", "PTAFA1", JdeDataType.Numeric),
        new JdeField("PTAFA2", "PTAFA2", JdeDataType.Numeric),
        new JdeField("PTAFA3", "PTAFA3", JdeDataType.Numeric),
        new JdeField("PTAFA4", "PTAFA4", JdeDataType.Numeric),
        new JdeField("PTAFA5", "PTAFA5", JdeDataType.Numeric),
        new JdeField("PTSRDS", "PTSRDS", JdeDataType.String, 120),
        new JdeField("PTSRDS1", "PTSRDS1", JdeDataType.String, 120),
        new JdeField("PTSRDS2", "PTSRDS2", JdeDataType.String, 120),
        new JdeField("PTSRDS3", "PTSRDS3", JdeDataType.String, 120),
        new JdeField("PTSRDS4", "PTSRDS4", JdeDataType.String, 120),
        new JdeField("PTOPT", "PTOPT", JdeDataType.String, 2),
        new JdeField("PTOPTF", "PTOPTF", JdeDataType.String, 2),
        new JdeField("PTOPTI", "PTOPTI", JdeDataType.String, 2),
        new JdeField("PTOPTOW", "PTOPTOW", JdeDataType.String, 2),
        new JdeField("PTOPTD", "PTOPTD", JdeDataType.String, 2),
        new JdeField("PTDT1", "PTDT1", JdeDataType.Numeric),
        new JdeField("PTADTJ", "PTADTJ", JdeDataType.Numeric),
        new JdeField("PTAPVDTE", "PTAPVDTE", JdeDataType.Numeric),
        new JdeField("PTAPDT", "PTAPDT", JdeDataType.Numeric),
        new JdeField("PTDT", "PTDT", JdeDataType.Numeric),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20, true, true),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20, true, true),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTTDAY", "PTTDAY", JdeDataType.Numeric),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTEF01", "PTEF01", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I402T_0", "Primary Key on PTKCOO, PTDOCO, PTDCTO, PTLNID, PTNLIN, PTDOC, PTUSER, PTJOBN, PTEF01", new[] { "PTKCOO", "PTDOCO", "PTDCTO", "PTLNID", "PTNLIN", "PTDOC", "PTUSER", "PTJOBN", "PTEF01" }, isUnique: true, isPrimaryKey: true)
    };
}
