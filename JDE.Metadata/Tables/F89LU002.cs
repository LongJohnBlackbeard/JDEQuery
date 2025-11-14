using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F89LU002 - .
/// </summary>
public class F89LU002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CYTCCITYCD.
        /// </summary>
        public const string CYTCCITYCD = "CYTCCITYCD";

        /// <summary>
        /// CYTCCITYNM.
        /// </summary>
        public const string CYTCCITYNM = "CYTCCITYNM";
    }

    /// <inheritdoc />
    public override string TableName => "F89LU002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CYTCCITYCD", "CYTCCITYCD", JdeDataType.String, 18, true, true),
        new JdeField("CYTCCITYNM", "CYTCCITYNM", JdeDataType.String, 150)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F89LU002_0", "Primary Key on CYTCCITYCD", new[] { "CYTCCITYCD" }, isUnique: true, isPrimaryKey: true)
    };
}
