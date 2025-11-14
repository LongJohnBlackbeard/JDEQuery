using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48001 - .
/// </summary>
public class F48001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WEWR01.
        /// </summary>
        public const string WEWR01 = "WEWR01";

        /// <summary>
        /// WEWR02.
        /// </summary>
        public const string WEWR02 = "WEWR02";

        /// <summary>
        /// WEWR03.
        /// </summary>
        public const string WEWR03 = "WEWR03";

        /// <summary>
        /// WEANSA.
        /// </summary>
        public const string WEANSA = "WEANSA";

        /// <summary>
        /// WEANPA.
        /// </summary>
        public const string WEANPA = "WEANPA";
    }

    /// <inheritdoc />
    public override string TableName => "F48001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WEWR01", "WEWR01", JdeDataType.String, 8, true, true),
        new JdeField("WEWR02", "WEWR02", JdeDataType.String, 6, true, true),
        new JdeField("WEWR03", "WEWR03", JdeDataType.String, 6, true, true),
        new JdeField("WEANSA", "WEANSA", JdeDataType.Numeric),
        new JdeField("WEANPA", "WEANPA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48001_0", "Primary Key on WEWR01, WEWR02, WEWR03", new[] { "WEWR01", "WEWR02", "WEWR03" }, isUnique: true, isPrimaryKey: true)
    };
}
