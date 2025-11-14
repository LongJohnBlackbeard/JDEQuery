using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UCW01 - .
/// </summary>
public class F74UCW01 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWJOBS.
        /// </summary>
        public const string CWJOBS = "CWJOBS";

        /// <summary>
        /// CWSPHD.
        /// </summary>
        public const string CWSPHD = "CWSPHD";
    }

    /// <inheritdoc />
    public override string TableName => "F74UCW01";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWJOBS", "CWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CWSPHD", "CWSPHD", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UCW01_0", "Primary Key on CWJOBS", new[] { "CWJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
