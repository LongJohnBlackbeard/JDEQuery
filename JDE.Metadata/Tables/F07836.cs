using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07836 - .
/// </summary>
public class F07836 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEIDYE.
        /// </summary>
        public const string JEIDYE = "JEIDYE";

        /// <summary>
        /// JEDTEY.
        /// </summary>
        public const string JEDTEY = "JEDTEY";

        /// <summary>
        /// JELNID.
        /// </summary>
        public const string JELNID = "JELNID";

        /// <summary>
        /// JETNRF.
        /// </summary>
        public const string JETNRF = "JETNRF";
    }

    /// <inheritdoc />
    public override string TableName => "F07836";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEIDYE", "JEIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JEDTEY", "JEDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JELNID", "JELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("JETNRF", "JETNRF", JdeDataType.String, 1500)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07836_0", "Primary Key on JEIDYE, JEDTEY, JELNID", new[] { "JEIDYE", "JEDTEY", "JELNID" }, isUnique: true, isPrimaryKey: true)
    };
}
