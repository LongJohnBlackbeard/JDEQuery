using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S83 - .
/// </summary>
public class F48S83 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDSEGMID.
        /// </summary>
        public const string PDSEGMID = "PDSEGMID";

        /// <summary>
        /// PDEFTB.
        /// </summary>
        public const string PDEFTB = "PDEFTB";

        /// <summary>
        /// PDEFTE.
        /// </summary>
        public const string PDEFTE = "PDEFTE";

        /// <summary>
        /// PDBUCA.
        /// </summary>
        public const string PDBUCA = "PDBUCA";

        /// <summary>
        /// PDPOOLID.
        /// </summary>
        public const string PDPOOLID = "PDPOOLID";

        /// <summary>
        /// PDDL01.
        /// </summary>
        public const string PDDL01 = "PDDL01";

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
        /// PDAID5.
        /// </summary>
        public const string PDAID5 = "PDAID5";

        /// <summary>
        /// PDAID6.
        /// </summary>
        public const string PDAID6 = "PDAID6";
    }

    /// <inheritdoc />
    public override string TableName => "F48S83";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDSEGMID", "PDSEGMID", JdeDataType.String, 6, true, true),
        new JdeField("PDEFTB", "PDEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("PDEFTE", "PDEFTE", JdeDataType.Numeric),
        new JdeField("PDBUCA", "PDBUCA", JdeDataType.String, 10, true, true),
        new JdeField("PDPOOLID", "PDPOOLID", JdeDataType.String, 8, true, true),
        new JdeField("PDDL01", "PDDL01", JdeDataType.String, 60),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric),
        new JdeField("PDAID5", "PDAID5", JdeDataType.String, 16),
        new JdeField("PDAID6", "PDAID6", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S83_0", "Primary Key on PDSEGMID, PDEFTB, PDBUCA, PDPOOLID", new[] { "PDSEGMID", "PDEFTB", "PDBUCA", "PDPOOLID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S83_2", "Index on PDSEGMID, SYS_NC00014$, PDBUCA, PDPOOLID", new[] { "PDSEGMID", "SYS_NC00014$", "PDBUCA", "PDPOOLID" })
    };
}
