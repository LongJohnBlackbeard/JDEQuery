using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4106 - .
/// </summary>
public class F4106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPITM.
        /// </summary>
        public const string BPITM = "BPITM";

        /// <summary>
        /// BPLITM.
        /// </summary>
        public const string BPLITM = "BPLITM";

        /// <summary>
        /// BPAITM.
        /// </summary>
        public const string BPAITM = "BPAITM";

        /// <summary>
        /// BPMCU.
        /// </summary>
        public const string BPMCU = "BPMCU";

        /// <summary>
        /// BPLOCN.
        /// </summary>
        public const string BPLOCN = "BPLOCN";

        /// <summary>
        /// BPLOTN.
        /// </summary>
        public const string BPLOTN = "BPLOTN";

        /// <summary>
        /// BPAN8.
        /// </summary>
        public const string BPAN8 = "BPAN8";

        /// <summary>
        /// BPIGID.
        /// </summary>
        public const string BPIGID = "BPIGID";

        /// <summary>
        /// BPCGID.
        /// </summary>
        public const string BPCGID = "BPCGID";

        /// <summary>
        /// BPLOTG.
        /// </summary>
        public const string BPLOTG = "BPLOTG";

        /// <summary>
        /// BPFRMP.
        /// </summary>
        public const string BPFRMP = "BPFRMP";

        /// <summary>
        /// BPCRCD.
        /// </summary>
        public const string BPCRCD = "BPCRCD";

        /// <summary>
        /// BPUOM.
        /// </summary>
        public const string BPUOM = "BPUOM";

        /// <summary>
        /// BPEFTJ.
        /// </summary>
        public const string BPEFTJ = "BPEFTJ";

        /// <summary>
        /// BPEXDJ.
        /// </summary>
        public const string BPEXDJ = "BPEXDJ";

        /// <summary>
        /// BPUPRC.
        /// </summary>
        public const string BPUPRC = "BPUPRC";

        /// <summary>
        /// BPACRD.
        /// </summary>
        public const string BPACRD = "BPACRD";

        /// <summary>
        /// BPBSCD.
        /// </summary>
        public const string BPBSCD = "BPBSCD";

        /// <summary>
        /// BPLEDG.
        /// </summary>
        public const string BPLEDG = "BPLEDG";

        /// <summary>
        /// BPFVTR.
        /// </summary>
        public const string BPFVTR = "BPFVTR";

        /// <summary>
        /// BPFRMN.
        /// </summary>
        public const string BPFRMN = "BPFRMN";

        /// <summary>
        /// BPURCD.
        /// </summary>
        public const string BPURCD = "BPURCD";

        /// <summary>
        /// BPURDT.
        /// </summary>
        public const string BPURDT = "BPURDT";

        /// <summary>
        /// BPURAT.
        /// </summary>
        public const string BPURAT = "BPURAT";

        /// <summary>
        /// BPURAB.
        /// </summary>
        public const string BPURAB = "BPURAB";

        /// <summary>
        /// BPURRF.
        /// </summary>
        public const string BPURRF = "BPURRF";

        /// <summary>
        /// BPAPRS.
        /// </summary>
        public const string BPAPRS = "BPAPRS";

        /// <summary>
        /// BPUSER.
        /// </summary>
        public const string BPUSER = "BPUSER";

        /// <summary>
        /// BPPID.
        /// </summary>
        public const string BPPID = "BPPID";

        /// <summary>
        /// BPJOBN.
        /// </summary>
        public const string BPJOBN = "BPJOBN";

        /// <summary>
        /// BPUPMJ.
        /// </summary>
        public const string BPUPMJ = "BPUPMJ";

        /// <summary>
        /// BPTDAY.
        /// </summary>
        public const string BPTDAY = "BPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPITM", "BPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("BPLITM", "BPLITM", JdeDataType.String, 50),
        new JdeField("BPAITM", "BPAITM", JdeDataType.String, 50),
        new JdeField("BPMCU", "BPMCU", JdeDataType.String, 24, true, true),
        new JdeField("BPLOCN", "BPLOCN", JdeDataType.String, 40, true, true),
        new JdeField("BPLOTN", "BPLOTN", JdeDataType.String, 60, true, true),
        new JdeField("BPAN8", "BPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BPIGID", "BPIGID", JdeDataType.Numeric, null, true, true),
        new JdeField("BPCGID", "BPCGID", JdeDataType.Numeric, null, true, true),
        new JdeField("BPLOTG", "BPLOTG", JdeDataType.String, 6, true, true),
        new JdeField("BPFRMP", "BPFRMP", JdeDataType.Numeric, null, true, true),
        new JdeField("BPCRCD", "BPCRCD", JdeDataType.String, 6, true, true),
        new JdeField("BPUOM", "BPUOM", JdeDataType.String, 4, true, true),
        new JdeField("BPEFTJ", "BPEFTJ", JdeDataType.Numeric),
        new JdeField("BPEXDJ", "BPEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BPUPRC", "BPUPRC", JdeDataType.Numeric),
        new JdeField("BPACRD", "BPACRD", JdeDataType.Numeric),
        new JdeField("BPBSCD", "BPBSCD", JdeDataType.String, 2),
        new JdeField("BPLEDG", "BPLEDG", JdeDataType.String, 4),
        new JdeField("BPFVTR", "BPFVTR", JdeDataType.Numeric),
        new JdeField("BPFRMN", "BPFRMN", JdeDataType.String, 20),
        new JdeField("BPURCD", "BPURCD", JdeDataType.String, 4),
        new JdeField("BPURDT", "BPURDT", JdeDataType.Numeric),
        new JdeField("BPURAT", "BPURAT", JdeDataType.Numeric),
        new JdeField("BPURAB", "BPURAB", JdeDataType.Numeric),
        new JdeField("BPURRF", "BPURRF", JdeDataType.String, 30),
        new JdeField("BPAPRS", "BPAPRS", JdeDataType.String, 2),
        new JdeField("BPUSER", "BPUSER", JdeDataType.String, 20),
        new JdeField("BPPID", "BPPID", JdeDataType.String, 20),
        new JdeField("BPJOBN", "BPJOBN", JdeDataType.String, 20),
        new JdeField("BPUPMJ", "BPUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("BPTDAY", "BPTDAY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4106_0", "Primary Key on BPITM, BPMCU, BPLOCN, BPLOTN, BPAN8, BPIGID, BPCGID, BPLOTG, BPFRMP, BPCRCD, BPUOM, BPEXDJ, BPUPMJ, BPTDAY", new[] { "BPITM", "BPMCU", "BPLOCN", "BPLOTN", "BPAN8", "BPIGID", "BPCGID", "BPLOTG", "BPFRMP", "BPCRCD", "BPUOM", "BPEXDJ", "BPUPMJ", "BPTDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4106_1", "Index on BPITM, BPMCU, BPLOCN, BPLOTN, BPAN8, BPLOTG, BPFRMP, BPCRCD, BPUOM, BPEXDJ", new[] { "BPITM", "BPMCU", "BPLOCN", "BPLOTN", "BPAN8", "BPLOTG", "BPFRMP", "BPCRCD", "BPUOM", "BPEXDJ" }),
        new JdeIndex("F4106_3", "Index on BPITM, BPMCU, BPLOCN, BPLOTN, BPAN8, BPIGID, BPCGID, BPUOM, BPEXDJ", new[] { "BPITM", "BPMCU", "BPLOCN", "BPLOTN", "BPAN8", "BPIGID", "BPCGID", "BPUOM", "BPEXDJ" }),
        new JdeIndex("F4106_4", "Index on BPITM, BPMCU, BPLOCN, BPLOTN, BPAN8, BPIGID, BPCGID, BPCRCD, BPUOM", new[] { "BPITM", "BPMCU", "BPLOCN", "BPLOTN", "BPAN8", "BPIGID", "BPCGID", "BPCRCD", "BPUOM" }),
        new JdeIndex("F4106_6", "Index on BPFRMN", new[] { "BPFRMN" }),
        new JdeIndex("F4106_7", "Index on BPITM, BPMCU, BPLOCN, BPLOTN, BPAN8, BPIGID, BPCGID, BPLOTG, BPFRMP, BPCRCD, BPUOM, BPEXDJ, BPBSCD", new[] { "BPITM", "BPMCU", "BPLOCN", "BPLOTN", "BPAN8", "BPIGID", "BPCGID", "BPLOTG", "BPFRMP", "BPCRCD", "BPUOM", "BPEXDJ", "BPBSCD" }),
        new JdeIndex("F4106_8", "Index on BPAN8", new[] { "BPAN8" })
    };
}
