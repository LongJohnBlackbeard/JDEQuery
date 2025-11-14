using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08365 - .
/// </summary>
public class F08365 : JdeTable
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
        /// HXTSTT.
        /// </summary>
        public const string HXTSTT = "HXTSTT";

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
        /// HXPTPY.
        /// </summary>
        public const string HXPTPY = "HXPTPY";

        /// <summary>
        /// HXHCEB.
        /// </summary>
        public const string HXHCEB = "HXHCEB";

        /// <summary>
        /// HXHCEE.
        /// </summary>
        public const string HXHCEE = "HXHCEE";

        /// <summary>
        /// HXNHCE.
        /// </summary>
        public const string HXNHCE = "HXNHCE";

        /// <summary>
        /// HXADPH.
        /// </summary>
        public const string HXADPH = "HXADPH";

        /// <summary>
        /// HXADP.
        /// </summary>
        public const string HXADP = "HXADP";

        /// <summary>
        /// HXACPH.
        /// </summary>
        public const string HXACPH = "HXACPH";

        /// <summary>
        /// HXACP.
        /// </summary>
        public const string HXACP = "HXACP";

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
    public override string TableName => "F08365";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HXTSTN", "HXTSTN", JdeDataType.String, 16, true, true),
        new JdeField("HXTSTY", "HXTSTY", JdeDataType.Numeric, null, true, true),
        new JdeField("HXTSTT", "HXTSTT", JdeDataType.String, 2),
        new JdeField("HXDL01", "HXDL01", JdeDataType.String, 60),
        new JdeField("HXDC", "HXDC", JdeDataType.String, 80),
        new JdeField("HXTYRS", "HXTYRS", JdeDataType.Numeric),
        new JdeField("HXPTRK", "HXPTRK", JdeDataType.String, 8),
        new JdeField("HXPTPY", "HXPTPY", JdeDataType.String, 8),
        new JdeField("HXHCEB", "HXHCEB", JdeDataType.String, 2),
        new JdeField("HXHCEE", "HXHCEE", JdeDataType.Numeric),
        new JdeField("HXNHCE", "HXNHCE", JdeDataType.Numeric),
        new JdeField("HXADPH", "HXADPH", JdeDataType.Numeric),
        new JdeField("HXADP", "HXADP", JdeDataType.Numeric),
        new JdeField("HXACPH", "HXACPH", JdeDataType.Numeric),
        new JdeField("HXACP", "HXACP", JdeDataType.Numeric),
        new JdeField("HXPRG6", "HXPRG6", JdeDataType.String, 20),
        new JdeField("HXPRG7", "HXPRG7", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08365_0", "Primary Key on HXTSTN, HXTSTY", new[] { "HXTSTN", "HXTSTY" }, isUnique: true, isPrimaryKey: true)
    };
}
