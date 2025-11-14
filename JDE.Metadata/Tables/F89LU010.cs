using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F89LU010 - .
/// </summary>
public class F89LU010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ISGENCRMID.
        /// </summary>
        public const string ISGENCRMID = "ISGENCRMID";

        /// <summary>
        /// ISDOCO.
        /// </summary>
        public const string ISDOCO = "ISDOCO";
    }

    /// <inheritdoc />
    public override string TableName => "F89LU010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ISGENCRMID", "ISGENCRMID", JdeDataType.Numeric, null, true, true),
        new JdeField("ISDOCO", "ISDOCO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F89LU010_0", "Primary Key on ISGENCRMID", new[] { "ISGENCRMID" }, isUnique: true, isPrimaryKey: true)
    };
}
