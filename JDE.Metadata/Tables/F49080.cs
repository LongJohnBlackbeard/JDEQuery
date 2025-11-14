using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49080 - .
/// </summary>
public class F49080 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICINCY.
        /// </summary>
        public const string ICINCY = "ICINCY";

        /// <summary>
        /// ICCLCD.
        /// </summary>
        public const string ICCLCD = "ICCLCD";

        /// <summary>
        /// ICNODI.
        /// </summary>
        public const string ICNODI = "ICNODI";

        /// <summary>
        /// ICBODN.
        /// </summary>
        public const string ICBODN = "ICBODN";

        /// <summary>
        /// ICDOW.
        /// </summary>
        public const string ICDOW = "ICDOW";
    }

    /// <inheritdoc />
    public override string TableName => "F49080";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICINCY", "ICINCY", JdeDataType.String, 6, true, true),
        new JdeField("ICCLCD", "ICCLCD", JdeDataType.String, 2),
        new JdeField("ICNODI", "ICNODI", JdeDataType.Numeric),
        new JdeField("ICBODN", "ICBODN", JdeDataType.Numeric),
        new JdeField("ICDOW", "ICDOW", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49080_0", "Primary Key on ICINCY", new[] { "ICINCY" }, isUnique: true, isPrimaryKey: true)
    };
}
