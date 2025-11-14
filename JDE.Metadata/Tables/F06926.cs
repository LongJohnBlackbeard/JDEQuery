using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06926 - .
/// </summary>
public class F06926 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y#TARA.
        /// </summary>
        public const string Y_TARA = "Y#TARA";

        /// <summary>
        /// Y#PTAX.
        /// </summary>
        public const string Y_PTAX = "Y#PTAX";

        /// <summary>
        /// Y#HMCO.
        /// </summary>
        public const string Y_HMCO = "Y#HMCO";

        /// <summary>
        /// Y#ANN8.
        /// </summary>
        public const string Y_ANN8 = "Y#ANN8";
    }

    /// <inheritdoc />
    public override string TableName => "F06926";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y#TARA", "Y#TARA", JdeDataType.String, 20, true, true),
        new JdeField("Y#PTAX", "Y#PTAX", JdeDataType.String, 4, true, true),
        new JdeField("Y#HMCO", "Y#HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y#ANN8", "Y#ANN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06926_0", "Primary Key on Y#TARA, Y#PTAX, Y#HMCO", new[] { "Y#TARA", "Y#PTAX", "Y#HMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
