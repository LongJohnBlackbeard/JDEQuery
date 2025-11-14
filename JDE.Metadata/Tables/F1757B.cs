using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1757B - .
/// </summary>
public class F1757B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JLCALLQ.
        /// </summary>
        public const string JLCALLQ = "JLCALLQ";
    }

    /// <inheritdoc />
    public override string TableName => "F1757B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JLCALLQ", "JLCALLQ", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1757B_0", "Primary Key on JLCALLQ", new[] { "JLCALLQ" }, isUnique: true, isPrimaryKey: true)
    };
}
