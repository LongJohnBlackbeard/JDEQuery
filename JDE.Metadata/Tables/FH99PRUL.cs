using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FH99PRUL - .
/// </summary>
public class FH99PRUL : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PROMWOT.
        /// </summary>
        public const string PROMWOT = "PROMWOT";
    }

    /// <inheritdoc />
    public override string TableName => "FH99PRUL";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PROMWOT", "PROMWOT", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FH99PRUL_0", "Primary Key on PROMWOT", new[] { "PROMWOT" }, isUnique: true, isPrimaryKey: true)
    };
}
