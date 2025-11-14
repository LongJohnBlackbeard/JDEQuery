using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F99HDR - .
/// </summary>
public class F99HDR : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WHDOCO.
        /// </summary>
        public const string WHDOCO = "WHDOCO";

        /// <summary>
        /// WHAN8.
        /// </summary>
        public const string WHAN8 = "WHAN8";

        /// <summary>
        /// WHAN80.
        /// </summary>
        public const string WHAN80 = "WHAN80";

        /// <summary>
        /// WHUPMJ.
        /// </summary>
        public const string WHUPMJ = "WHUPMJ";

        /// <summary>
        /// WHWFDSST.
        /// </summary>
        public const string WHWFDSST = "WHWFDSST";
    }

    /// <inheritdoc />
    public override string TableName => "F99HDR";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WHDOCO", "WHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WHAN8", "WHAN8", JdeDataType.Numeric),
        new JdeField("WHAN80", "WHAN80", JdeDataType.Numeric),
        new JdeField("WHUPMJ", "WHUPMJ", JdeDataType.Numeric),
        new JdeField("WHWFDSST", "WHWFDSST", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F99HDR_0", "Primary Key on WHDOCO", new[] { "WHDOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
