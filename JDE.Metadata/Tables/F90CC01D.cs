using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CC01D - .
/// </summary>
public class F90CC01D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRCEAID.
        /// </summary>
        public const string CRCEAID = "CRCEAID";

        /// <summary>
        /// CRCEAEID.
        /// </summary>
        public const string CRCEAEID = "CRCEAEID";

        /// <summary>
        /// CRSTSUDT.
        /// </summary>
        public const string CRSTSUDT = "CRSTSUDT";

        /// <summary>
        /// CRACTIND.
        /// </summary>
        public const string CRACTIND = "CRACTIND";
    }

    /// <inheritdoc />
    public override string TableName => "F90CC01D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRCEAID", "CRCEAID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRCEAEID", "CRCEAEID", JdeDataType.Numeric, null, true, true),
        new JdeField("CRSTSUDT", "CRSTSUDT", JdeDataType.Date),
        new JdeField("CRACTIND", "CRACTIND", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CC01D_0", "Primary Key on CRCEAID, CRCEAEID", new[] { "CRCEAID", "CRCEAEID" }, isUnique: true, isPrimaryKey: true)
    };
}
