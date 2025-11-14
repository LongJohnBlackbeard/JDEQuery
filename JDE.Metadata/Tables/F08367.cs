using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08367 - .
/// </summary>
public class F08367 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HZTSTN.
        /// </summary>
        public const string HZTSTN = "HZTSTN";

        /// <summary>
        /// HZTSTY.
        /// </summary>
        public const string HZTSTY = "HZTSTY";

        /// <summary>
        /// HZHMCO.
        /// </summary>
        public const string HZHMCO = "HZHMCO";
    }

    /// <inheritdoc />
    public override string TableName => "F08367";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HZTSTN", "HZTSTN", JdeDataType.String, 16, true, true),
        new JdeField("HZTSTY", "HZTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("HZHMCO", "HZHMCO", JdeDataType.String, 10, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08367_0", "Primary Key on HZTSTN, HZTSTY, HZHMCO", new[] { "HZTSTN", "HZTSTY", "HZHMCO" }, isUnique: true, isPrimaryKey: true)
    };
}
