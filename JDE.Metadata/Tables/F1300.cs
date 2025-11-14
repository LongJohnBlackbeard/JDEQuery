using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1300 - .
/// </summary>
public class F1300 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F9MVER.
        /// </summary>
        public const string F9MVER = "F9MVER";

        /// <summary>
        /// F9EQF1.
        /// </summary>
        public const string F9EQF1 = "F9EQF1";

        /// <summary>
        /// F9EQF2.
        /// </summary>
        public const string F9EQF2 = "F9EQF2";

        /// <summary>
        /// F9EQF3.
        /// </summary>
        public const string F9EQF3 = "F9EQF3";

        /// <summary>
        /// F9EQF4.
        /// </summary>
        public const string F9EQF4 = "F9EQF4";

        /// <summary>
        /// F9EQF5.
        /// </summary>
        public const string F9EQF5 = "F9EQF5";

        /// <summary>
        /// F9EQF6.
        /// </summary>
        public const string F9EQF6 = "F9EQF6";

        /// <summary>
        /// F9EQF7.
        /// </summary>
        public const string F9EQF7 = "F9EQF7";

        /// <summary>
        /// F9EQF8.
        /// </summary>
        public const string F9EQF8 = "F9EQF8";

        /// <summary>
        /// F9TYPR.
        /// </summary>
        public const string F9TYPR = "F9TYPR";
    }

    /// <inheritdoc />
    public override string TableName => "F1300";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F9MVER", "F9MVER", JdeDataType.String, 6, true, true),
        new JdeField("F9EQF1", "F9EQF1", JdeDataType.String, 2, true, true),
        new JdeField("F9EQF2", "F9EQF2", JdeDataType.String, 2, true, true),
        new JdeField("F9EQF3", "F9EQF3", JdeDataType.String, 2, true, true),
        new JdeField("F9EQF4", "F9EQF4", JdeDataType.String, 2, true, true),
        new JdeField("F9EQF5", "F9EQF5", JdeDataType.String, 2, true, true),
        new JdeField("F9EQF6", "F9EQF6", JdeDataType.Numeric, null, true, true),
        new JdeField("F9EQF7", "F9EQF7", JdeDataType.Numeric, null, true, true),
        new JdeField("F9EQF8", "F9EQF8", JdeDataType.Numeric, null, true, true),
        new JdeField("F9TYPR", "F9TYPR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1300_0", "Primary Key on F9MVER, F9EQF1, F9EQF2, F9EQF3, F9EQF4, F9EQF5, F9EQF6, F9EQF7, F9EQF8", new[] { "F9MVER", "F9EQF1", "F9EQF2", "F9EQF3", "F9EQF4", "F9EQF5", "F9EQF6", "F9EQF7", "F9EQF8" }, isUnique: true, isPrimaryKey: true)
    };
}
