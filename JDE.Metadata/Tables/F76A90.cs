using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A90 - .
/// </summary>
public class F76A90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R0ASMV.
        /// </summary>
        public const string R0ASMV = "R0ASMV";

        /// <summary>
        /// R0DOC.
        /// </summary>
        public const string R0DOC = "R0DOC";
    }

    /// <inheritdoc />
    public override string TableName => "F76A90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R0ASMV", "R0ASMV", JdeDataType.String, 440),
        new JdeField("R0DOC", "R0DOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A90_0", "Primary Key on R0DOC", new[] { "R0DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
