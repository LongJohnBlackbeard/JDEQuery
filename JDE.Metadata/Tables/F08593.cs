using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08593 - .
/// </summary>
public class F08593 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H7RETR.
        /// </summary>
        public const string H7RETR = "H7RETR";

        /// <summary>
        /// H7DL01.
        /// </summary>
        public const string H7DL01 = "H7DL01";

        /// <summary>
        /// H7LIN.
        /// </summary>
        public const string H7LIN = "H7LIN";

        /// <summary>
        /// H7DL02.
        /// </summary>
        public const string H7DL02 = "H7DL02";

        /// <summary>
        /// H7RAGE.
        /// </summary>
        public const string H7RAGE = "H7RAGE";

        /// <summary>
        /// H7YVS.
        /// </summary>
        public const string H7YVS = "H7YVS";

        /// <summary>
        /// H7RPTS.
        /// </summary>
        public const string H7RPTS = "H7RPTS";
    }

    /// <inheritdoc />
    public override string TableName => "F08593";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H7RETR", "H7RETR", JdeDataType.String, 8, true, true),
        new JdeField("H7DL01", "H7DL01", JdeDataType.String, 60),
        new JdeField("H7LIN", "H7LIN", JdeDataType.Numeric, null, true, true),
        new JdeField("H7DL02", "H7DL02", JdeDataType.String, 60),
        new JdeField("H7RAGE", "H7RAGE", JdeDataType.Numeric),
        new JdeField("H7YVS", "H7YVS", JdeDataType.Numeric),
        new JdeField("H7RPTS", "H7RPTS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08593_0", "Primary Key on H7RETR, H7LIN", new[] { "H7RETR", "H7LIN" }, isUnique: true, isPrimaryKey: true)
    };
}
