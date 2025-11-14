using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15014 - .
/// </summary>
public class F15014 : JdeTable
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
        /// NPDCTO.
        /// </summary>
        public const string NPDCTO = "NPDCTO";

        /// <summary>
        /// NPPRDC.
        /// </summary>
        public const string NPPRDC = "NPPRDC";

        /// <summary>
        /// NPSET.
        /// </summary>
        public const string NPSET = "NPSET";

        /// <summary>
        /// NPBKPT.
        /// </summary>
        public const string NPBKPT = "NPBKPT";

        /// <summary>
        /// NPEFTB.
        /// </summary>
        public const string NPEFTB = "NPEFTB";

        /// <summary>
        /// NPEFTE.
        /// </summary>
        public const string NPEFTE = "NPEFTE";

        /// <summary>
        /// NPMCUS.
        /// </summary>
        public const string NPMCUS = "NPMCUS";

        /// <summary>
        /// NPCMPM.
        /// </summary>
        public const string NPCMPM = "NPCMPM";

        /// <summary>
        /// NPPDUE.
        /// </summary>
        public const string NPPDUE = "NPPDUE";

        /// <summary>
        /// NPSBJR.
        /// </summary>
        public const string NPSBJR = "NPSBJR";

        /// <summary>
        /// NPGLC.
        /// </summary>
        public const string NPGLC = "NPGLC";

        /// <summary>
        /// NPMCU.
        /// </summary>
        public const string NPMCU = "NPMCU";

        /// <summary>
        /// NPUNIT.
        /// </summary>
        public const string NPUNIT = "NPUNIT";

        /// <summary>
        /// NPUSER.
        /// </summary>
        public const string NPUSER = "NPUSER";

        /// <summary>
        /// NPUPMJ.
        /// </summary>
        public const string NPUPMJ = "NPUPMJ";

        /// <summary>
        /// NPPID.
        /// </summary>
        public const string NPPID = "NPPID";

        /// <summary>
        /// NPJOBN.
        /// </summary>
        public const string NPJOBN = "NPJOBN";

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
        /// NPPRRO.
        /// </summary>
        public const string NPPRRO = "NPPRRO";

        /// <summary>
        /// NPULI.
        /// </summary>
        public const string NPULI = "NPULI";

        /// <summary>
        /// NPSUSA.
        /// </summary>
        public const string NPSUSA = "NPSUSA";

        /// <summary>
        /// NPBCI.
        /// </summary>
        public const string NPBCI = "NPBCI";

        /// <summary>
        /// NPYEOV.
        /// </summary>
        public const string NPYEOV = "NPYEOV";

        /// <summary>
        /// NPDBAN.
        /// </summary>
        public const string NPDBAN = "NPDBAN";

        /// <summary>
        /// NPDEAL.
        /// </summary>
        public const string NPDEAL = "NPDEAL";

        /// <summary>
        /// NPSOPC.
        /// </summary>
        public const string NPSOPC = "NPSOPC";

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
        /// NPSRLS.
        /// </summary>
        public const string NPSRLS = "NPSRLS";

        /// <summary>
        /// NPSUSP.
        /// </summary>
        public const string NPSUSP = "NPSUSP";

        /// <summary>
        /// NPSUDT.
        /// </summary>
        public const string NPSUDT = "NPSUDT";

        /// <summary>
        /// NPUPMT.
        /// </summary>
        public const string NPUPMT = "NPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NPDOCO", "NPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NPDCTO", "NPDCTO", JdeDataType.String, 4),
        new JdeField("NPPRDC", "NPPRDC", JdeDataType.String, 8, true, true),
        new JdeField("NPSET", "NPSET", JdeDataType.String, 6),
        new JdeField("NPBKPT", "NPBKPT", JdeDataType.Numeric, null, true, true),
        new JdeField("NPEFTB", "NPEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("NPEFTE", "NPEFTE", JdeDataType.Numeric),
        new JdeField("NPMCUS", "NPMCUS", JdeDataType.String, 24),
        new JdeField("NPCMPM", "NPCMPM", JdeDataType.String, 2),
        new JdeField("NPPDUE", "NPPDUE", JdeDataType.Numeric),
        new JdeField("NPSBJR", "NPSBJR", JdeDataType.String, 2),
        new JdeField("NPGLC", "NPGLC", JdeDataType.String, 8),
        new JdeField("NPMCU", "NPMCU", JdeDataType.String, 24, true, true),
        new JdeField("NPUNIT", "NPUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NPUSER", "NPUSER", JdeDataType.String, 20),
        new JdeField("NPUPMJ", "NPUPMJ", JdeDataType.Numeric),
        new JdeField("NPPID", "NPPID", JdeDataType.String, 20),
        new JdeField("NPJOBN", "NPJOBN", JdeDataType.String, 20),
        new JdeField("NPLRYF", "NPLRYF", JdeDataType.Numeric),
        new JdeField("NPLRYT", "NPLRYT", JdeDataType.Numeric),
        new JdeField("NPYT", "NPYT", JdeDataType.String, 2),
        new JdeField("NPPRRO", "NPPRRO", JdeDataType.String, 2),
        new JdeField("NPULI", "NPULI", JdeDataType.String, 16),
        new JdeField("NPSUSA", "NPSUSA", JdeDataType.Numeric),
        new JdeField("NPBCI", "NPBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NPYEOV", "NPYEOV", JdeDataType.String, 2, true, true),
        new JdeField("NPDBAN", "NPDBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("NPDEAL", "NPDEAL", JdeDataType.String, 16),
        new JdeField("NPSOPC", "NPSOPC", JdeDataType.String, 2),
        new JdeField("NPRM13", "NPRM13", JdeDataType.String, 8),
        new JdeField("NPRM14", "NPRM14", JdeDataType.String, 8),
        new JdeField("NPRM15", "NPRM15", JdeDataType.String, 8),
        new JdeField("NPSRLS", "NPSRLS", JdeDataType.Numeric),
        new JdeField("NPSUSP", "NPSUSP", JdeDataType.String, 2),
        new JdeField("NPSUDT", "NPSUDT", JdeDataType.Numeric),
        new JdeField("NPUPMT", "NPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15014_0", "Primary Key on NPDOCO, NPYEOV, NPMCU, NPUNIT, NPDBAN, NPPRDC, NPEFTB, NPBKPT, NPBCI", new[] { "NPDOCO", "NPYEOV", "NPMCU", "NPUNIT", "NPDBAN", "NPPRDC", "NPEFTB", "NPBKPT", "NPBCI" }, isUnique: true, isPrimaryKey: true)
    };
}
