using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15014B - .
/// </summary>
public class F15014B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NPDOCO.
        /// </summary>
        public const string NPDOCO = "NPDOCO";

        /// <summary>
        /// NPLSVR.
        /// </summary>
        public const string NPLSVR = "NPLSVR";

        /// <summary>
        /// NPYEOV.
        /// </summary>
        public const string NPYEOV = "NPYEOV";

        /// <summary>
        /// NPMCU.
        /// </summary>
        public const string NPMCU = "NPMCU";

        /// <summary>
        /// NPUNIT.
        /// </summary>
        public const string NPUNIT = "NPUNIT";

        /// <summary>
        /// NPDBAN.
        /// </summary>
        public const string NPDBAN = "NPDBAN";

        /// <summary>
        /// NPPRDC.
        /// </summary>
        public const string NPPRDC = "NPPRDC";

        /// <summary>
        /// NPEFTB.
        /// </summary>
        public const string NPEFTB = "NPEFTB";

        /// <summary>
        /// NPBKPT.
        /// </summary>
        public const string NPBKPT = "NPBKPT";

        /// <summary>
        /// NPBCI.
        /// </summary>
        public const string NPBCI = "NPBCI";

        /// <summary>
        /// NPDCTO.
        /// </summary>
        public const string NPDCTO = "NPDCTO";

        /// <summary>
        /// NPSTNR.
        /// </summary>
        public const string NPSTNR = "NPSTNR";

        /// <summary>
        /// NPULI.
        /// </summary>
        public const string NPULI = "NPULI";

        /// <summary>
        /// NPULI2.
        /// </summary>
        public const string NPULI2 = "NPULI2";

        /// <summary>
        /// NPSET.
        /// </summary>
        public const string NPSET = "NPSET";

        /// <summary>
        /// NPCMPM.
        /// </summary>
        public const string NPCMPM = "NPCMPM";

        /// <summary>
        /// NPPDUE.
        /// </summary>
        public const string NPPDUE = "NPPDUE";

        /// <summary>
        /// NPEFTE.
        /// </summary>
        public const string NPEFTE = "NPEFTE";

        /// <summary>
        /// NPSUDT.
        /// </summary>
        public const string NPSUDT = "NPSUDT";

        /// <summary>
        /// NPBCI3.
        /// </summary>
        public const string NPBCI3 = "NPBCI3";

        /// <summary>
        /// NPVRSC.
        /// </summary>
        public const string NPVRSC = "NPVRSC";

        /// <summary>
        /// NPSUSP.
        /// </summary>
        public const string NPSUSP = "NPSUSP";

        /// <summary>
        /// NPSBJR.
        /// </summary>
        public const string NPSBJR = "NPSBJR";

        /// <summary>
        /// NPPRRO.
        /// </summary>
        public const string NPPRRO = "NPPRRO";

        /// <summary>
        /// NPGLC.
        /// </summary>
        public const string NPGLC = "NPGLC";

        /// <summary>
        /// NPLRYF.
        /// </summary>
        public const string NPLRYF = "NPLRYF";

        /// <summary>
        /// NPLRYT.
        /// </summary>
        public const string NPLRYT = "NPLRYT";

        /// <summary>
        /// NPYT.
        /// </summary>
        public const string NPYT = "NPYT";

        /// <summary>
        /// NPSUSA.
        /// </summary>
        public const string NPSUSA = "NPSUSA";

        /// <summary>
        /// NPMCUS.
        /// </summary>
        public const string NPMCUS = "NPMCUS";

        /// <summary>
        /// NPDEAL.
        /// </summary>
        public const string NPDEAL = "NPDEAL";

        /// <summary>
        /// NPSOPC.
        /// </summary>
        public const string NPSOPC = "NPSOPC";

        /// <summary>
        /// NPSRLS.
        /// </summary>
        public const string NPSRLS = "NPSRLS";

        /// <summary>
        /// NPRM13.
        /// </summary>
        public const string NPRM13 = "NPRM13";

        /// <summary>
        /// NPRM14.
        /// </summary>
        public const string NPRM14 = "NPRM14";

        /// <summary>
        /// NPRM15.
        /// </summary>
        public const string NPRM15 = "NPRM15";

        /// <summary>
        /// NPRM24.
        /// </summary>
        public const string NPRM24 = "NPRM24";

        /// <summary>
        /// NPRM25.
        /// </summary>
        public const string NPRM25 = "NPRM25";

        /// <summary>
        /// NPURCD.
        /// </summary>
        public const string NPURCD = "NPURCD";

        /// <summary>
        /// NPURDT.
        /// </summary>
        public const string NPURDT = "NPURDT";

        /// <summary>
        /// NPURAT.
        /// </summary>
        public const string NPURAT = "NPURAT";

        /// <summary>
        /// NPURAB.
        /// </summary>
        public const string NPURAB = "NPURAB";

        /// <summary>
        /// NPURRF.
        /// </summary>
        public const string NPURRF = "NPURRF";

        /// <summary>
        /// NPUSER.
        /// </summary>
        public const string NPUSER = "NPUSER";

        /// <summary>
        /// NPPID.
        /// </summary>
        public const string NPPID = "NPPID";

        /// <summary>
        /// NPUPMJ.
        /// </summary>
        public const string NPUPMJ = "NPUPMJ";

        /// <summary>
        /// NPUPMT.
        /// </summary>
        public const string NPUPMT = "NPUPMT";

        /// <summary>
        /// NPJOBN.
        /// </summary>
        public const string NPJOBN = "NPJOBN";

        /// <summary>
        /// NPENTJ.
        /// </summary>
        public const string NPENTJ = "NPENTJ";

        /// <summary>
        /// NPTORG.
        /// </summary>
        public const string NPTORG = "NPTORG";

        /// <summary>
        /// NPCRR.
        /// </summary>
        public const string NPCRR = "NPCRR";

        /// <summary>
        /// NPCRRM.
        /// </summary>
        public const string NPCRRM = "NPCRRM";

        /// <summary>
        /// NPCRCD.
        /// </summary>
        public const string NPCRCD = "NPCRCD";

        /// <summary>
        /// NPACRL.
        /// </summary>
        public const string NPACRL = "NPACRL";

        /// <summary>
        /// NPARMT.
        /// </summary>
        public const string NPARMT = "NPARMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15014B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NPDOCO", "NPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NPLSVR", "NPLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NPYEOV", "NPYEOV", JdeDataType.String, 2, true, true),
        new JdeField("NPMCU", "NPMCU", JdeDataType.String, 24),
        new JdeField("NPUNIT", "NPUNIT", JdeDataType.String, 16),
        new JdeField("NPDBAN", "NPDBAN", JdeDataType.Numeric),
        new JdeField("NPPRDC", "NPPRDC", JdeDataType.String, 8),
        new JdeField("NPEFTB", "NPEFTB", JdeDataType.Numeric),
        new JdeField("NPBKPT", "NPBKPT", JdeDataType.Numeric),
        new JdeField("NPBCI", "NPBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NPDCTO", "NPDCTO", JdeDataType.String, 4),
        new JdeField("NPSTNR", "NPSTNR", JdeDataType.String, 20),
        new JdeField("NPULI", "NPULI", JdeDataType.String, 16),
        new JdeField("NPULI2", "NPULI2", JdeDataType.String, 16),
        new JdeField("NPSET", "NPSET", JdeDataType.String, 6),
        new JdeField("NPCMPM", "NPCMPM", JdeDataType.String, 2),
        new JdeField("NPPDUE", "NPPDUE", JdeDataType.Numeric),
        new JdeField("NPEFTE", "NPEFTE", JdeDataType.Numeric),
        new JdeField("NPSUDT", "NPSUDT", JdeDataType.Numeric),
        new JdeField("NPBCI3", "NPBCI3", JdeDataType.Numeric),
        new JdeField("NPVRSC", "NPVRSC", JdeDataType.String, 2),
        new JdeField("NPSUSP", "NPSUSP", JdeDataType.String, 2),
        new JdeField("NPSBJR", "NPSBJR", JdeDataType.String, 2),
        new JdeField("NPPRRO", "NPPRRO", JdeDataType.String, 2),
        new JdeField("NPGLC", "NPGLC", JdeDataType.String, 8),
        new JdeField("NPLRYF", "NPLRYF", JdeDataType.Numeric),
        new JdeField("NPLRYT", "NPLRYT", JdeDataType.Numeric),
        new JdeField("NPYT", "NPYT", JdeDataType.String, 2),
        new JdeField("NPSUSA", "NPSUSA", JdeDataType.Numeric),
        new JdeField("NPMCUS", "NPMCUS", JdeDataType.String, 24),
        new JdeField("NPDEAL", "NPDEAL", JdeDataType.String, 16),
        new JdeField("NPSOPC", "NPSOPC", JdeDataType.String, 2),
        new JdeField("NPSRLS", "NPSRLS", JdeDataType.Numeric),
        new JdeField("NPRM13", "NPRM13", JdeDataType.String, 8),
        new JdeField("NPRM14", "NPRM14", JdeDataType.String, 8),
        new JdeField("NPRM15", "NPRM15", JdeDataType.String, 8),
        new JdeField("NPRM24", "NPRM24", JdeDataType.String, 8),
        new JdeField("NPRM25", "NPRM25", JdeDataType.String, 8),
        new JdeField("NPURCD", "NPURCD", JdeDataType.String, 4),
        new JdeField("NPURDT", "NPURDT", JdeDataType.Numeric),
        new JdeField("NPURAT", "NPURAT", JdeDataType.Numeric),
        new JdeField("NPURAB", "NPURAB", JdeDataType.Numeric),
        new JdeField("NPURRF", "NPURRF", JdeDataType.String, 30),
        new JdeField("NPUSER", "NPUSER", JdeDataType.String, 20),
        new JdeField("NPPID", "NPPID", JdeDataType.String, 20),
        new JdeField("NPUPMJ", "NPUPMJ", JdeDataType.Numeric),
        new JdeField("NPUPMT", "NPUPMT", JdeDataType.Numeric),
        new JdeField("NPJOBN", "NPJOBN", JdeDataType.String, 20),
        new JdeField("NPENTJ", "NPENTJ", JdeDataType.Numeric),
        new JdeField("NPTORG", "NPTORG", JdeDataType.String, 20),
        new JdeField("NPCRR", "NPCRR", JdeDataType.Numeric),
        new JdeField("NPCRRM", "NPCRRM", JdeDataType.String, 2),
        new JdeField("NPCRCD", "NPCRCD", JdeDataType.String, 6),
        new JdeField("NPACRL", "NPACRL", JdeDataType.String, 2),
        new JdeField("NPARMT", "NPARMT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15014B_0", "Primary Key on NPDOCO, NPYEOV, NPLSVR, NPBCI", new[] { "NPDOCO", "NPYEOV", "NPLSVR", "NPBCI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15014B_10", "Index on NPDOCO, NPPRDC, NPDBAN", new[] { "NPDOCO", "NPPRDC", "NPDBAN" }),
        new JdeIndex("F15014B_11", "Index on NPDOCO, NPMCU, NPUNIT, NPDBAN, NPPRDC, NPSTNR", new[] { "NPDOCO", "NPMCU", "NPUNIT", "NPDBAN", "NPPRDC", "NPSTNR" }),
        new JdeIndex("F15014B_4", "Index on NPDOCO, NPSET, NPPRDC, NPBKPT", new[] { "NPDOCO", "NPSET", "NPPRDC", "NPBKPT" }),
        new JdeIndex("F15014B_5", "Index on NPDOCO, NPYEOV, NPBCI", new[] { "NPDOCO", "NPYEOV", "NPBCI" }),
        new JdeIndex("F15014B_6", "Index on NPDOCO, NPBCI", new[] { "NPDOCO", "NPBCI" }),
        new JdeIndex("F15014B_7", "Index on NPDOCO, NPMCU, NPUNIT, NPDBAN, NPBKPT, NPEFTB", new[] { "NPDOCO", "NPMCU", "NPUNIT", "NPDBAN", "NPBKPT", "NPEFTB" }),
        new JdeIndex("F15014B_8", "Index on NPDOCO, NPMCU, NPRM15, NPBKPT, NPUNIT, NPPRDC", new[] { "NPDOCO", "NPMCU", "NPRM15", "NPBKPT", "NPUNIT", "NPPRDC" }),
        new JdeIndex("F15014B_9", "Index on NPDOCO, NPLSVR, NPYEOV, NPMCU, NPUNIT, NPDBAN, NPPRDC, NPBKPT, NPEFTB, NPBCI", new[] { "NPDOCO", "NPLSVR", "NPYEOV", "NPMCU", "NPUNIT", "NPDBAN", "NPPRDC", "NPBKPT", "NPEFTB", "NPBCI" })
    };
}
