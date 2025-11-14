using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S74 - .
/// </summary>
public class F74S74 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q4AN8.
        /// </summary>
        public const string Q4AN8 = "Q4AN8";

        /// <summary>
        /// Q4SCNA.
        /// </summary>
        public const string Q4SCNA = "Q4SCNA";

        /// <summary>
        /// Q4SGRE.
        /// </summary>
        public const string Q4SGRE = "Q4SGRE";

        /// <summary>
        /// Q4SAAB.
        /// </summary>
        public const string Q4SAAB = "Q4SAAB";

        /// <summary>
        /// Q4SCSA.
        /// </summary>
        public const string Q4SCSA = "Q4SCSA";

        /// <summary>
        /// Q4SFAN.
        /// </summary>
        public const string Q4SFAN = "Q4SFAN";

        /// <summary>
        /// Q4SSTA.
        /// </summary>
        public const string Q4SSTA = "Q4SSTA";

        /// <summary>
        /// Q4SFLO.
        /// </summary>
        public const string Q4SFLO = "Q4SFLO";

        /// <summary>
        /// Q4SDOO.
        /// </summary>
        public const string Q4SDOO = "Q4SDOO";

        /// <summary>
        /// Q4SPCO.
        /// </summary>
        public const string Q4SPCO = "Q4SPCO";

        /// <summary>
        /// Q4SZCO.
        /// </summary>
        public const string Q4SZCO = "Q4SZCO";

        /// <summary>
        /// Q4SACO.
        /// </summary>
        public const string Q4SACO = "Q4SACO";

        /// <summary>
        /// Q4SPNU.
        /// </summary>
        public const string Q4SPNU = "Q4SPNU";
    }

    /// <inheritdoc />
    public override string TableName => "F74S74";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q4AN8", "Q4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Q4SCNA", "Q4SCNA", JdeDataType.String, 80),
        new JdeField("Q4SGRE", "Q4SGRE", JdeDataType.String, 50),
        new JdeField("Q4SAAB", "Q4SAAB", JdeDataType.String, 4),
        new JdeField("Q4SCSA", "Q4SCSA", JdeDataType.String, 50),
        new JdeField("Q4SFAN", "Q4SFAN", JdeDataType.Numeric),
        new JdeField("Q4SSTA", "Q4SSTA", JdeDataType.String, 4),
        new JdeField("Q4SFLO", "Q4SFLO", JdeDataType.String, 4),
        new JdeField("Q4SDOO", "Q4SDOO", JdeDataType.String, 4),
        new JdeField("Q4SPCO", "Q4SPCO", JdeDataType.String, 48),
        new JdeField("Q4SZCO", "Q4SZCO", JdeDataType.Numeric),
        new JdeField("Q4SACO", "Q4SACO", JdeDataType.String, 6),
        new JdeField("Q4SPNU", "Q4SPNU", JdeDataType.String, 14)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S74_0", "Primary Key on Q4AN8", new[] { "Q4AN8" }, isUnique: true, isPrimaryKey: true)
    };
}
