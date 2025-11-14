using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S77 - .
/// </summary>
public class F74S77 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q7SYEA.
        /// </summary>
        public const string Q7SYEA = "Q7SYEA";

        /// <summary>
        /// Q7STID.
        /// </summary>
        public const string Q7STID = "Q7STID";

        /// <summary>
        /// Q7DS40.
        /// </summary>
        public const string Q7DS40 = "Q7DS40";

        /// <summary>
        /// Q7SACO.
        /// </summary>
        public const string Q7SACO = "Q7SACO";

        /// <summary>
        /// Q7SPNU.
        /// </summary>
        public const string Q7SPNU = "Q7SPNU";

        /// <summary>
        /// Q7GFL1.
        /// </summary>
        public const string Q7GFL1 = "Q7GFL1";

        /// <summary>
        /// Q7SDNU.
        /// </summary>
        public const string Q7SDNU = "Q7SDNU";
    }

    /// <inheritdoc />
    public override string TableName => "F74S77";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q7SYEA", "Q7SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q7STID", "Q7STID", JdeDataType.String, 18, true, true),
        new JdeField("Q7DS40", "Q7DS40", JdeDataType.String, 80),
        new JdeField("Q7SACO", "Q7SACO", JdeDataType.String, 6),
        new JdeField("Q7SPNU", "Q7SPNU", JdeDataType.String, 14),
        new JdeField("Q7GFL1", "Q7GFL1", JdeDataType.String, 2),
        new JdeField("Q7SDNU", "Q7SDNU", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S77_0", "Primary Key on Q7SYEA, Q7STID", new[] { "Q7SYEA", "Q7STID" }, isUnique: true, isPrimaryKey: true)
    };
}
