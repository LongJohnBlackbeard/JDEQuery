using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083203 - .
/// </summary>
public class F083203 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BGPLAN.
        /// </summary>
        public const string BGPLAN = "BGPLAN";

        /// <summary>
        /// BGAOPT.
        /// </summary>
        public const string BGAOPT = "BGAOPT";

        /// <summary>
        /// BGPDBA.
        /// </summary>
        public const string BGPDBA = "BGPDBA";

        /// <summary>
        /// BGPLNT.
        /// </summary>
        public const string BGPLNT = "BGPLNT";

        /// <summary>
        /// BGEFTB.
        /// </summary>
        public const string BGEFTB = "BGEFTB";

        /// <summary>
        /// BGEFTE.
        /// </summary>
        public const string BGEFTE = "BGEFTE";

        /// <summary>
        /// BGRTAM.
        /// </summary>
        public const string BGRTAM = "BGRTAM";

        /// <summary>
        /// BGHRST.
        /// </summary>
        public const string BGHRST = "BGHRST";

        /// <summary>
        /// BGUSER.
        /// </summary>
        public const string BGUSER = "BGUSER";

        /// <summary>
        /// BGPID.
        /// </summary>
        public const string BGPID = "BGPID";

        /// <summary>
        /// BGUPMJ.
        /// </summary>
        public const string BGUPMJ = "BGUPMJ";

        /// <summary>
        /// BGDTAE.
        /// </summary>
        public const string BGDTAE = "BGDTAE";
    }

    /// <inheritdoc />
    public override string TableName => "F083203";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BGPLAN", "BGPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BGAOPT", "BGAOPT", JdeDataType.String, 6, true, true),
        new JdeField("BGPDBA", "BGPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("BGPLNT", "BGPLNT", JdeDataType.String, 2, true, true),
        new JdeField("BGEFTB", "BGEFTB", JdeDataType.Numeric),
        new JdeField("BGEFTE", "BGEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("BGRTAM", "BGRTAM", JdeDataType.Numeric),
        new JdeField("BGHRST", "BGHRST", JdeDataType.String, 4),
        new JdeField("BGUSER", "BGUSER", JdeDataType.String, 20),
        new JdeField("BGPID", "BGPID", JdeDataType.String, 20),
        new JdeField("BGUPMJ", "BGUPMJ", JdeDataType.Numeric),
        new JdeField("BGDTAE", "BGDTAE", JdeDataType.String, 8, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083203_0", "Primary Key on BGPLAN, BGAOPT, BGPDBA, BGDTAE, BGPLNT, BGEFTE", new[] { "BGPLAN", "BGAOPT", "BGPDBA", "BGDTAE", "BGPLNT", "BGEFTE" }, isUnique: true, isPrimaryKey: true)
    };
}
