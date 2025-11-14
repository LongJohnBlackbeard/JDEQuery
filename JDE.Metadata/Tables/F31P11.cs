using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31P11 - .
/// </summary>
public class F31P11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QPPRJM.
        /// </summary>
        public const string QPPRJM = "QPPRJM";

        /// <summary>
        /// QPQVER.
        /// </summary>
        public const string QPQVER = "QPQVER";

        /// <summary>
        /// QPSEQN.
        /// </summary>
        public const string QPSEQN = "QPSEQN";

        /// <summary>
        /// QPDCTO.
        /// </summary>
        public const string QPDCTO = "QPDCTO";

        /// <summary>
        /// QPDOCO.
        /// </summary>
        public const string QPDOCO = "QPDOCO";

        /// <summary>
        /// QPPARS.
        /// </summary>
        public const string QPPARS = "QPPARS";

        /// <summary>
        /// QPDL01.
        /// </summary>
        public const string QPDL01 = "QPDL01";

        /// <summary>
        /// QPCOST.
        /// </summary>
        public const string QPCOST = "QPCOST";

        /// <summary>
        /// QPESSA.
        /// </summary>
        public const string QPESSA = "QPESSA";

        /// <summary>
        /// QPESSU.
        /// </summary>
        public const string QPESSU = "QPESSU";

        /// <summary>
        /// QPEAQT.
        /// </summary>
        public const string QPEAQT = "QPEAQT";

        /// <summary>
        /// QPEOQT.
        /// </summary>
        public const string QPEOQT = "QPEOQT";

        /// <summary>
        /// QPMRG3.
        /// </summary>
        public const string QPMRG3 = "QPMRG3";

        /// <summary>
        /// QPQAMT.
        /// </summary>
        public const string QPQAMT = "QPQAMT";

        /// <summary>
        /// QPESFA.
        /// </summary>
        public const string QPESFA = "QPESFA";

        /// <summary>
        /// QPEFAM.
        /// </summary>
        public const string QPEFAM = "QPEFAM";

        /// <summary>
        /// QPEFAO.
        /// </summary>
        public const string QPEFAO = "QPEFAO";

        /// <summary>
        /// QPEFQA.
        /// </summary>
        public const string QPEFQA = "QPEFQA";

        /// <summary>
        /// QPFEC.
        /// </summary>
        public const string QPFEC = "QPFEC";

        /// <summary>
        /// QPLDM.
        /// </summary>
        public const string QPLDM = "QPLDM";

        /// <summary>
        /// QPITM.
        /// </summary>
        public const string QPITM = "QPITM";

        /// <summary>
        /// QPLITM.
        /// </summary>
        public const string QPLITM = "QPLITM";

        /// <summary>
        /// QPAITM.
        /// </summary>
        public const string QPAITM = "QPAITM";

        /// <summary>
        /// QPUORG.
        /// </summary>
        public const string QPUORG = "QPUORG";

        /// <summary>
        /// QPMMCU.
        /// </summary>
        public const string QPMMCU = "QPMMCU";

        /// <summary>
        /// QPUOM.
        /// </summary>
        public const string QPUOM = "QPUOM";

        /// <summary>
        /// QPSHPP.
        /// </summary>
        public const string QPSHPP = "QPSHPP";

        /// <summary>
        /// QPSQCF.
        /// </summary>
        public const string QPSQCF = "QPSQCF";

        /// <summary>
        /// QPSQDF.
        /// </summary>
        public const string QPSQDF = "QPSQDF";

        /// <summary>
        /// QPRORN.
        /// </summary>
        public const string QPRORN = "QPRORN";

        /// <summary>
        /// QPRCTO.
        /// </summary>
        public const string QPRCTO = "QPRCTO";

        /// <summary>
        /// QPRKCO.
        /// </summary>
        public const string QPRKCO = "QPRKCO";

        /// <summary>
        /// QPRLLN.
        /// </summary>
        public const string QPRLLN = "QPRLLN";

        /// <summary>
        /// QPSTRT.
        /// </summary>
        public const string QPSTRT = "QPSTRT";

        /// <summary>
        /// QPDRQJ.
        /// </summary>
        public const string QPDRQJ = "QPDRQJ";

        /// <summary>
        /// QPURCD.
        /// </summary>
        public const string QPURCD = "QPURCD";

        /// <summary>
        /// QPURDT.
        /// </summary>
        public const string QPURDT = "QPURDT";

        /// <summary>
        /// QPURAT.
        /// </summary>
        public const string QPURAT = "QPURAT";

        /// <summary>
        /// QPURAB.
        /// </summary>
        public const string QPURAB = "QPURAB";

        /// <summary>
        /// QPURRF.
        /// </summary>
        public const string QPURRF = "QPURRF";

        /// <summary>
        /// QPUSER.
        /// </summary>
        public const string QPUSER = "QPUSER";

        /// <summary>
        /// QPJOBN.
        /// </summary>
        public const string QPJOBN = "QPJOBN";

        /// <summary>
        /// QPPID.
        /// </summary>
        public const string QPPID = "QPPID";

        /// <summary>
        /// QPUPMJ.
        /// </summary>
        public const string QPUPMJ = "QPUPMJ";

        /// <summary>
        /// QPTDAY.
        /// </summary>
        public const string QPTDAY = "QPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31P11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QPPRJM", "QPPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("QPQVER", "QPQVER", JdeDataType.String, 20, true, true),
        new JdeField("QPSEQN", "QPSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("QPDCTO", "QPDCTO", JdeDataType.String, 4),
        new JdeField("QPDOCO", "QPDOCO", JdeDataType.Numeric),
        new JdeField("QPPARS", "QPPARS", JdeDataType.String, 16),
        new JdeField("QPDL01", "QPDL01", JdeDataType.String, 60),
        new JdeField("QPCOST", "QPCOST", JdeDataType.String, 6),
        new JdeField("QPESSA", "QPESSA", JdeDataType.Numeric),
        new JdeField("QPESSU", "QPESSU", JdeDataType.Numeric),
        new JdeField("QPEAQT", "QPEAQT", JdeDataType.Numeric),
        new JdeField("QPEOQT", "QPEOQT", JdeDataType.Numeric),
        new JdeField("QPMRG3", "QPMRG3", JdeDataType.Numeric),
        new JdeField("QPQAMT", "QPQAMT", JdeDataType.Numeric),
        new JdeField("QPESFA", "QPESFA", JdeDataType.Numeric),
        new JdeField("QPEFAM", "QPEFAM", JdeDataType.Numeric),
        new JdeField("QPEFAO", "QPEFAO", JdeDataType.Numeric),
        new JdeField("QPEFQA", "QPEFQA", JdeDataType.Numeric),
        new JdeField("QPFEC", "QPFEC", JdeDataType.Numeric),
        new JdeField("QPLDM", "QPLDM", JdeDataType.String, 2),
        new JdeField("QPITM", "QPITM", JdeDataType.Numeric),
        new JdeField("QPLITM", "QPLITM", JdeDataType.String, 50),
        new JdeField("QPAITM", "QPAITM", JdeDataType.String, 50),
        new JdeField("QPUORG", "QPUORG", JdeDataType.Numeric),
        new JdeField("QPMMCU", "QPMMCU", JdeDataType.String, 24),
        new JdeField("QPUOM", "QPUOM", JdeDataType.String, 4),
        new JdeField("QPSHPP", "QPSHPP", JdeDataType.String, 2),
        new JdeField("QPSQCF", "QPSQCF", JdeDataType.String, 2),
        new JdeField("QPSQDF", "QPSQDF", JdeDataType.String, 2),
        new JdeField("QPRORN", "QPRORN", JdeDataType.String, 16),
        new JdeField("QPRCTO", "QPRCTO", JdeDataType.String, 4),
        new JdeField("QPRKCO", "QPRKCO", JdeDataType.String, 10),
        new JdeField("QPRLLN", "QPRLLN", JdeDataType.Numeric),
        new JdeField("QPSTRT", "QPSTRT", JdeDataType.Numeric),
        new JdeField("QPDRQJ", "QPDRQJ", JdeDataType.Numeric),
        new JdeField("QPURCD", "QPURCD", JdeDataType.String, 4),
        new JdeField("QPURDT", "QPURDT", JdeDataType.Numeric),
        new JdeField("QPURAT", "QPURAT", JdeDataType.Numeric),
        new JdeField("QPURAB", "QPURAB", JdeDataType.Numeric),
        new JdeField("QPURRF", "QPURRF", JdeDataType.String, 30),
        new JdeField("QPUSER", "QPUSER", JdeDataType.String, 20),
        new JdeField("QPJOBN", "QPJOBN", JdeDataType.String, 20),
        new JdeField("QPPID", "QPPID", JdeDataType.String, 20),
        new JdeField("QPUPMJ", "QPUPMJ", JdeDataType.Numeric),
        new JdeField("QPTDAY", "QPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31P11_0", "Primary Key on QPPRJM, QPQVER, QPSEQN", new[] { "QPPRJM", "QPQVER", "QPSEQN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31P11_2", "Index on QPPRJM, QPQVER", new[] { "QPPRJM", "QPQVER" }),
        new JdeIndex("F31P11_3", "Index on QPRORN, QPRCTO, QPRKCO", new[] { "QPRORN", "QPRCTO", "QPRKCO" })
    };
}
