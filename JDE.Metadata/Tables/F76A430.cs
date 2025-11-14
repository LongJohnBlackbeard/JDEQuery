using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A430 - .
/// </summary>
public class F76A430 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDCO.
        /// </summary>
        public const string PDCO = "PDCO";

        /// <summary>
        /// PDAN8.
        /// </summary>
        public const string PDAN8 = "PDAN8";

        /// <summary>
        /// PDDG#.
        /// </summary>
        public const string PDDG_ = "PDDG#";

        /// <summary>
        /// PDDGY.
        /// </summary>
        public const string PDDGY = "PDDGY";

        /// <summary>
        /// PDA007.
        /// </summary>
        public const string PDA007 = "PDA007";

        /// <summary>
        /// PDATXA.
        /// </summary>
        public const string PDATXA = "PDATXA";

        /// <summary>
        /// PDAG1.
        /// </summary>
        public const string PDAG1 = "PDAG1";

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
    }

    /// <inheritdoc />
    public override string TableName => "F76A430";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDCO", "PDCO", JdeDataType.String, 10, true, true),
        new JdeField("PDAN8", "PDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDG#", "PDDG#", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDGY", "PDDGY", JdeDataType.Numeric, null, true, true),
        new JdeField("PDA007", "PDA007", JdeDataType.String, 6, true, true),
        new JdeField("PDATXA", "PDATXA", JdeDataType.Numeric),
        new JdeField("PDAG1", "PDAG1", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A430_0", "Primary Key on PDCO, PDAN8, PDDG#, PDDGY, PDA007", new[] { "PDCO", "PDAN8", "PDDG#", "PDDGY", "PDA007" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A430_2", "Index on PDCO, PDDG#, PDDGY, PDA007", new[] { "PDCO", "PDDG#", "PDDGY", "PDA007" })
    };
}
