using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430015 - .
/// </summary>
public class F7430015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DRKCO.
        /// </summary>
        public const string DRKCO = "DRKCO";

        /// <summary>
        /// DRDCT.
        /// </summary>
        public const string DRDCT = "DRDCT";

        /// <summary>
        /// DRDOC.
        /// </summary>
        public const string DRDOC = "DRDOC";

        /// <summary>
        /// DROKCO.
        /// </summary>
        public const string DROKCO = "DROKCO";

        /// <summary>
        /// DRODCT.
        /// </summary>
        public const string DRODCT = "DRODCT";

        /// <summary>
        /// DRODOC.
        /// </summary>
        public const string DRODOC = "DRODOC";
    }

    /// <inheritdoc />
    public override string TableName => "F7430015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DRKCO", "DRKCO", JdeDataType.String, 10, true, true),
        new JdeField("DRDCT", "DRDCT", JdeDataType.String, 4, true, true),
        new JdeField("DRDOC", "DRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DROKCO", "DROKCO", JdeDataType.String, 10, true, true),
        new JdeField("DRODCT", "DRODCT", JdeDataType.String, 4, true, true),
        new JdeField("DRODOC", "DRODOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430015_0", "Primary Key on DRKCO, DRDCT, DRDOC, DROKCO, DRODCT, DRODOC", new[] { "DRKCO", "DRDCT", "DRDOC", "DROKCO", "DRODCT", "DRODOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7430015_2", "Index on DROKCO, DRODCT, DRODOC", new[] { "DROKCO", "DRODCT", "DRODOC" }),
        new JdeIndex("F7430015_3", "Index on DRKCO, DRDCT, DRDOC", new[] { "DRKCO", "DRDCT", "DRDOC" })
    };
}
