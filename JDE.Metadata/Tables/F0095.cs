using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0095 - .
/// </summary>
public class F0095 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITPID.
        /// </summary>
        public const string ITPID = "ITPID";

        /// <summary>
        /// ITVERS.
        /// </summary>
        public const string ITVERS = "ITVERS";

        /// <summary>
        /// ITINNE.
        /// </summary>
        public const string ITINNE = "ITINNE";

        /// <summary>
        /// ITUPMJ.
        /// </summary>
        public const string ITUPMJ = "ITUPMJ";

        /// <summary>
        /// ITTDAY.
        /// </summary>
        public const string ITTDAY = "ITTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F0095";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITPID", "ITPID", JdeDataType.String, 20, true, true),
        new JdeField("ITVERS", "ITVERS", JdeDataType.String, 20, true, true),
        new JdeField("ITINNE", "ITINNE", JdeDataType.String, 60, true, true),
        new JdeField("ITUPMJ", "ITUPMJ", JdeDataType.Numeric),
        new JdeField("ITTDAY", "ITTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0095_0", "Primary Key on ITPID, ITVERS, ITINNE", new[] { "ITPID", "ITVERS", "ITINNE" }, isUnique: true, isPrimaryKey: true)
    };
}
