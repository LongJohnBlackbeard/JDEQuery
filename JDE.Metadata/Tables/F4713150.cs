using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4713150 - .
/// </summary>
public class F4713150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHDOCO.
        /// </summary>
        public const string CHDOCO = "CHDOCO";

        /// <summary>
        /// CHDCTO.
        /// </summary>
        public const string CHDCTO = "CHDCTO";

        /// <summary>
        /// CHKCOO.
        /// </summary>
        public const string CHKCOO = "CHKCOO";

        /// <summary>
        /// CHCMLN.
        /// </summary>
        public const string CHCMLN = "CHCMLN";

        /// <summary>
        /// CHSLSM.
        /// </summary>
        public const string CHSLSM = "CHSLSM";

        /// <summary>
        /// CHSLCM.
        /// </summary>
        public const string CHSLCM = "CHSLCM";

        /// <summary>
        /// CHFCA.
        /// </summary>
        public const string CHFCA = "CHFCA";

        /// <summary>
        /// CHAPUN.
        /// </summary>
        public const string CHAPUN = "CHAPUN";

        /// <summary>
        /// CHCCTY.
        /// </summary>
        public const string CHCCTY = "CHCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4713150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHDOCO", "CHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CHDCTO", "CHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CHKCOO", "CHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CHCMLN", "CHCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CHSLSM", "CHSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("CHSLCM", "CHSLCM", JdeDataType.Numeric),
        new JdeField("CHFCA", "CHFCA", JdeDataType.Numeric),
        new JdeField("CHAPUN", "CHAPUN", JdeDataType.Numeric),
        new JdeField("CHCCTY", "CHCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4713150_0", "Primary Key on CHDOCO, CHDCTO, CHKCOO, CHCMLN, CHSLSM", new[] { "CHDOCO", "CHDCTO", "CHKCOO", "CHCMLN", "CHSLSM" }, isUnique: true, isPrimaryKey: true)
    };
}
