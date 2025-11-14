using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48002 - .
/// </summary>
public class F48002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFTYPR.
        /// </summary>
        public const string WFTYPR = "WFTYPR";

        /// <summary>
        /// WFDL01.
        /// </summary>
        public const string WFDL01 = "WFDL01";

        /// <summary>
        /// WFST01.
        /// </summary>
        public const string WFST01 = "WFST01";

        /// <summary>
        /// WFST02.
        /// </summary>
        public const string WFST02 = "WFST02";

        /// <summary>
        /// WFST03.
        /// </summary>
        public const string WFST03 = "WFST03";

        /// <summary>
        /// WFST04.
        /// </summary>
        public const string WFST04 = "WFST04";

        /// <summary>
        /// WFST05.
        /// </summary>
        public const string WFST05 = "WFST05";

        /// <summary>
        /// WFST06.
        /// </summary>
        public const string WFST06 = "WFST06";

        /// <summary>
        /// WFIES1.
        /// </summary>
        public const string WFIES1 = "WFIES1";

        /// <summary>
        /// WFIEC1.
        /// </summary>
        public const string WFIEC1 = "WFIEC1";

        /// <summary>
        /// WFIES2.
        /// </summary>
        public const string WFIES2 = "WFIES2";

        /// <summary>
        /// WFIEC2.
        /// </summary>
        public const string WFIEC2 = "WFIEC2";

        /// <summary>
        /// WFIES3.
        /// </summary>
        public const string WFIES3 = "WFIES3";

        /// <summary>
        /// WFIEC3.
        /// </summary>
        public const string WFIEC3 = "WFIEC3";
    }

    /// <inheritdoc />
    public override string TableName => "F48002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFTYPR", "WFTYPR", JdeDataType.String, 2, true, true),
        new JdeField("WFDL01", "WFDL01", JdeDataType.String, 60),
        new JdeField("WFST01", "WFST01", JdeDataType.String, 20),
        new JdeField("WFST02", "WFST02", JdeDataType.String, 20),
        new JdeField("WFST03", "WFST03", JdeDataType.String, 20),
        new JdeField("WFST04", "WFST04", JdeDataType.String, 20),
        new JdeField("WFST05", "WFST05", JdeDataType.String, 20),
        new JdeField("WFST06", "WFST06", JdeDataType.String, 20),
        new JdeField("WFIES1", "WFIES1", JdeDataType.String, 8),
        new JdeField("WFIEC1", "WFIEC1", JdeDataType.String, 4),
        new JdeField("WFIES2", "WFIES2", JdeDataType.String, 8),
        new JdeField("WFIEC2", "WFIEC2", JdeDataType.String, 4),
        new JdeField("WFIES3", "WFIES3", JdeDataType.String, 8),
        new JdeField("WFIEC3", "WFIEC3", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48002_0", "Primary Key on WFTYPR", new[] { "WFTYPR" }, isUnique: true, isPrimaryKey: true)
    };
}
