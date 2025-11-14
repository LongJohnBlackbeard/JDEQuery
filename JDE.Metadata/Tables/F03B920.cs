using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B920 - .
/// </summary>
public class F03B920 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZCCRTF.
        /// </summary>
        public const string ZCCRTF = "ZCCRTF";

        /// <summary>
        /// ZCUKID.
        /// </summary>
        public const string ZCUKID = "ZCUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F03B920";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZCCRTF", "ZCCRTF", JdeDataType.String, 700),
        new JdeField("ZCUKID", "ZCUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B920_0", "Primary Key on ZCUKID", new[] { "ZCUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
