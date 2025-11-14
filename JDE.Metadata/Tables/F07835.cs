using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07835 - .
/// </summary>
public class F07835 : JdeTable
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
        /// JEW2RF.
        /// </summary>
        public const string JEW2RF = "JEW2RF";
    }

    /// <inheritdoc />
    public override string TableName => "F07835";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEIDYE", "JEIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JEDTEY", "JEDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JELNID", "JELNID", JdeDataType.Numeric, null, true, true),
        new JdeField("JEW2RF", "JEW2RF", JdeDataType.String, 550)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07835_0", "Primary Key on JEIDYE, JEDTEY, JELNID", new[] { "JEIDYE", "JEDTEY", "JELNID" }, isUnique: true, isPrimaryKey: true)
    };
}
