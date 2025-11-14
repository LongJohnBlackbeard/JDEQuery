using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F081012 - .
/// </summary>
public class F081012 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HCFY.
        /// </summary>
        public const string HCFY = "HCFY";

        /// <summary>
        /// HCHMCU.
        /// </summary>
        public const string HCHMCU = "HCHMCU";

        /// <summary>
        /// HCPOS.
        /// </summary>
        public const string HCPOS = "HCPOS";

        /// <summary>
        /// HCSBL.
        /// </summary>
        public const string HCSBL = "HCSBL";

        /// <summary>
        /// HCSBLT.
        /// </summary>
        public const string HCSBLT = "HCSBLT";

        /// <summary>
        /// HCAID.
        /// </summary>
        public const string HCAID = "HCAID";

        /// <summary>
        /// HCPAPC.
        /// </summary>
        public const string HCPAPC = "HCPAPC";
    }

    /// <inheritdoc />
    public override string TableName => "F081012";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HCFY", "HCFY", JdeDataType.Numeric, null, true, true),
        new JdeField("HCHMCU", "HCHMCU", JdeDataType.String, 24, true, true),
        new JdeField("HCPOS", "HCPOS", JdeDataType.String, 16, true, true),
        new JdeField("HCSBL", "HCSBL", JdeDataType.String, 16),
        new JdeField("HCSBLT", "HCSBLT", JdeDataType.String, 2),
        new JdeField("HCAID", "HCAID", JdeDataType.String, 16, true, true),
        new JdeField("HCPAPC", "HCPAPC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F081012_0", "Primary Key on HCFY, HCHMCU, HCPOS, HCAID", new[] { "HCFY", "HCHMCU", "HCPOS", "HCAID" }, isUnique: true, isPrimaryKey: true)
    };
}
