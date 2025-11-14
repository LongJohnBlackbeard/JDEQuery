using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S76 - .
/// </summary>
public class F74S76 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q6SYEA.
        /// </summary>
        public const string Q6SYEA = "Q6SYEA";

        /// <summary>
        /// Q6STID.
        /// </summary>
        public const string Q6STID = "Q6STID";

        /// <summary>
        /// Q6SSTA.
        /// </summary>
        public const string Q6SSTA = "Q6SSTA";

        /// <summary>
        /// Q6SFLO.
        /// </summary>
        public const string Q6SFLO = "Q6SFLO";

        /// <summary>
        /// Q6SDOO.
        /// </summary>
        public const string Q6SDOO = "Q6SDOO";

        /// <summary>
        /// Q6DS40.
        /// </summary>
        public const string Q6DS40 = "Q6DS40";

        /// <summary>
        /// Q6SACO.
        /// </summary>
        public const string Q6SACO = "Q6SACO";

        /// <summary>
        /// Q6SPNU.
        /// </summary>
        public const string Q6SPNU = "Q6SPNU";
    }

    /// <inheritdoc />
    public override string TableName => "F74S76";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q6SYEA", "Q6SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q6STID", "Q6STID", JdeDataType.String, 18, true, true),
        new JdeField("Q6SSTA", "Q6SSTA", JdeDataType.String, 4),
        new JdeField("Q6SFLO", "Q6SFLO", JdeDataType.String, 4),
        new JdeField("Q6SDOO", "Q6SDOO", JdeDataType.String, 4),
        new JdeField("Q6DS40", "Q6DS40", JdeDataType.String, 80),
        new JdeField("Q6SACO", "Q6SACO", JdeDataType.String, 6),
        new JdeField("Q6SPNU", "Q6SPNU", JdeDataType.String, 14)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S76_0", "Primary Key on Q6SYEA, Q6STID", new[] { "Q6SYEA", "Q6STID" }, isUnique: true, isPrimaryKey: true)
    };
}
