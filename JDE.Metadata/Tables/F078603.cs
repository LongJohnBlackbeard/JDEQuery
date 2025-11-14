using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078603 - .
/// </summary>
public class F078603 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R9APMM.
        /// </summary>
        public const string R9APMM = "R9APMM";

        /// <summary>
        /// R9IDYE.
        /// </summary>
        public const string R9IDYE = "R9IDYE";

        /// <summary>
        /// R9DTEY.
        /// </summary>
        public const string R9DTEY = "R9DTEY";

        /// <summary>
        /// R9UKID.
        /// </summary>
        public const string R9UKID = "R9UKID";
    }

    /// <inheritdoc />
    public override string TableName => "F078603";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R9APMM", "R9APMM", JdeDataType.String, 1500),
        new JdeField("R9IDYE", "R9IDYE", JdeDataType.String, 20, true, true),
        new JdeField("R9DTEY", "R9DTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("R9UKID", "R9UKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078603_0", "Primary Key on R9IDYE, R9DTEY, R9UKID", new[] { "R9IDYE", "R9DTEY", "R9UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
