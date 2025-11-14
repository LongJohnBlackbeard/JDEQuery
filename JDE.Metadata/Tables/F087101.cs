using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F087101 - .
/// </summary>
public class F087101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTJBCD.
        /// </summary>
        public const string DTJBCD = "DTJBCD";

        /// <summary>
        /// DTJBST.
        /// </summary>
        public const string DTJBST = "DTJBST";

        /// <summary>
        /// DTTSKCD.
        /// </summary>
        public const string DTTSKCD = "DTTSKCD";

        /// <summary>
        /// DTLCKCD.
        /// </summary>
        public const string DTLCKCD = "DTLCKCD";
    }

    /// <inheritdoc />
    public override string TableName => "F087101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTJBCD", "DTJBCD", JdeDataType.String, 12, true, true),
        new JdeField("DTJBST", "DTJBST", JdeDataType.String, 8, true, true),
        new JdeField("DTTSKCD", "DTTSKCD", JdeDataType.Numeric, null, true, true),
        new JdeField("DTLCKCD", "DTLCKCD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F087101_0", "Primary Key on DTJBCD, DTJBST, DTTSKCD", new[] { "DTJBCD", "DTJBST", "DTTSKCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F087101_2", "Index on DTTSKCD, DTJBCD, DTJBST", new[] { "DTTSKCD", "DTJBCD", "DTJBST" })
    };
}
