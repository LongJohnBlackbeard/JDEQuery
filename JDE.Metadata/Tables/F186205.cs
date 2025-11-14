using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186205 - .
/// </summary>
public class F186205 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCICU.
        /// </summary>
        public const string TCICU = "TCICU";

        /// <summary>
        /// TCAN8.
        /// </summary>
        public const string TCAN8 = "TCAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F186205";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCICU", "TCICU", JdeDataType.Numeric, null, true, true),
        new JdeField("TCAN8", "TCAN8", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186205_0", "Primary Key on TCICU, TCAN8", new[] { "TCICU", "TCAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
