using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08396 - .
/// </summary>
public class F08396 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HXTSTN.
        /// </summary>
        public const string HXTSTN = "HXTSTN";

        /// <summary>
        /// HXTSTY.
        /// </summary>
        public const string HXTSTY = "HXTSTY";

        /// <summary>
        /// HXDL01.
        /// </summary>
        public const string HXDL01 = "HXDL01";

        /// <summary>
        /// HXDC.
        /// </summary>
        public const string HXDC = "HXDC";

        /// <summary>
        /// HXTYRS.
        /// </summary>
        public const string HXTYRS = "HXTYRS";

        /// <summary>
        /// HXPTRK.
        /// </summary>
        public const string HXPTRK = "HXPTRK";

        /// <summary>
        /// HXPRG6.
        /// </summary>
        public const string HXPRG6 = "HXPRG6";

        /// <summary>
        /// HXPRG7.
        /// </summary>
        public const string HXPRG7 = "HXPRG7";
    }

    /// <inheritdoc />
    public override string TableName => "F08396";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HXTSTN", "HXTSTN", JdeDataType.String, 16, true, true),
        new JdeField("HXTSTY", "HXTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("HXDL01", "HXDL01", JdeDataType.String, 60),
        new JdeField("HXDC", "HXDC", JdeDataType.String, 80),
        new JdeField("HXTYRS", "HXTYRS", JdeDataType.Numeric),
        new JdeField("HXPTRK", "HXPTRK", JdeDataType.String, 8),
        new JdeField("HXPRG6", "HXPRG6", JdeDataType.String, 20),
        new JdeField("HXPRG7", "HXPRG7", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08396_0", "Primary Key on HXTSTN, HXTSTY", new[] { "HXTSTN", "HXTSTY" }, isUnique: true, isPrimaryKey: true)
    };
}
