using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04572OW - .
/// </summary>
public class F04572OW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KNMID.
        /// </summary>
        public const string KNMID = "KNMID";

        /// <summary>
        /// KNLNID.
        /// </summary>
        public const string KNLNID = "KNLNID";

        /// <summary>
        /// KNFNAM.
        /// </summary>
        public const string KNFNAM = "KNFNAM";

        /// <summary>
        /// KNAPTA.
        /// </summary>
        public const string KNAPTA = "KNAPTA";
    }

    /// <inheritdoc />
    public override string TableName => "F04572OW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KNMID", "KNMID", JdeDataType.String, 20, true, true),
        new JdeField("KNLNID", "KNLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("KNFNAM", "KNFNAM", JdeDataType.String, 20),
        new JdeField("KNAPTA", "KNAPTA", JdeDataType.String, 3000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04572OW_0", "Primary Key on KNMID, KNLNID", new[] { "KNMID", "KNLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
