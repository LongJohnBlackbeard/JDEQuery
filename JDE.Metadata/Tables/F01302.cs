using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01302 - .
/// </summary>
public class F01302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADACTIVID.
        /// </summary>
        public const string ADACTIVID = "ADACTIVID";

        /// <summary>
        /// ADINDID.
        /// </summary>
        public const string ADINDID = "ADINDID";

        /// <summary>
        /// ADINDIDTY.
        /// </summary>
        public const string ADINDIDTY = "ADINDIDTY";

        /// <summary>
        /// ADISTODO.
        /// </summary>
        public const string ADISTODO = "ADISTODO";
    }

    /// <inheritdoc />
    public override string TableName => "F01302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADACTIVID", "ADACTIVID", JdeDataType.String, 72, true, true),
        new JdeField("ADINDID", "ADINDID", JdeDataType.String, 32),
        new JdeField("ADINDIDTY", "ADINDIDTY", JdeDataType.String, 100),
        new JdeField("ADISTODO", "ADISTODO", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01302_0", "Primary Key on ADACTIVID", new[] { "ADACTIVID" }, isUnique: true, isPrimaryKey: true)
    };
}
