using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08320D - .
/// </summary>
public class F08320D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDPLAN.
        /// </summary>
        public const string PDPLAN = "PDPLAN";

        /// <summary>
        /// PDAOPT.
        /// </summary>
        public const string PDAOPT = "PDAOPT";

        /// <summary>
        /// PDCOVA.
        /// </summary>
        public const string PDCOVA = "PDCOVA";

        /// <summary>
        /// PDINSMUL.
        /// </summary>
        public const string PDINSMUL = "PDINSMUL";

        /// <summary>
        /// PDDTAI.
        /// </summary>
        public const string PDDTAI = "PDDTAI";

        /// <summary>
        /// PDMORFR.
        /// </summary>
        public const string PDMORFR = "PDMORFR";

        /// <summary>
        /// PDRNDA.
        /// </summary>
        public const string PDRNDA = "PDRNDA";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";

        /// <summary>
        /// PDDL01.
        /// </summary>
        public const string PDDL01 = "PDDL01";

        /// <summary>
        /// PDDL02.
        /// </summary>
        public const string PDDL02 = "PDDL02";

        /// <summary>
        /// PDMATH01.
        /// </summary>
        public const string PDMATH01 = "PDMATH01";

        /// <summary>
        /// PDMATH02.
        /// </summary>
        public const string PDMATH02 = "PDMATH02";

        /// <summary>
        /// PDEV01.
        /// </summary>
        public const string PDEV01 = "PDEV01";

        /// <summary>
        /// PDEV02.
        /// </summary>
        public const string PDEV02 = "PDEV02";

        /// <summary>
        /// PDDATE01.
        /// </summary>
        public const string PDDATE01 = "PDDATE01";

        /// <summary>
        /// PDDATE02.
        /// </summary>
        public const string PDDATE02 = "PDDATE02";
    }

    /// <inheritdoc />
    public override string TableName => "F08320D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDPLAN", "PDPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PDAOPT", "PDAOPT", JdeDataType.String, 6, true, true),
        new JdeField("PDCOVA", "PDCOVA", JdeDataType.Numeric),
        new JdeField("PDINSMUL", "PDINSMUL", JdeDataType.Numeric),
        new JdeField("PDDTAI", "PDDTAI", JdeDataType.String, 20),
        new JdeField("PDMORFR", "PDMORFR", JdeDataType.String, 2),
        new JdeField("PDRNDA", "PDRNDA", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric),
        new JdeField("PDDL01", "PDDL01", JdeDataType.String, 60),
        new JdeField("PDDL02", "PDDL02", JdeDataType.String, 60),
        new JdeField("PDMATH01", "PDMATH01", JdeDataType.Numeric),
        new JdeField("PDMATH02", "PDMATH02", JdeDataType.Numeric),
        new JdeField("PDEV01", "PDEV01", JdeDataType.String, 2),
        new JdeField("PDEV02", "PDEV02", JdeDataType.String, 2),
        new JdeField("PDDATE01", "PDDATE01", JdeDataType.Numeric),
        new JdeField("PDDATE02", "PDDATE02", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08320D_0", "Primary Key on PDPLAN, PDAOPT", new[] { "PDPLAN", "PDAOPT" }, isUnique: true, isPrimaryKey: true)
    };
}
