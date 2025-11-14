using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42150 - .
/// </summary>
public class F42150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHDOCO.
        /// </summary>
        public const string SHDOCO = "SHDOCO";

        /// <summary>
        /// SHDCTO.
        /// </summary>
        public const string SHDCTO = "SHDCTO";

        /// <summary>
        /// SHKCOO.
        /// </summary>
        public const string SHKCOO = "SHKCOO";

        /// <summary>
        /// SHCMLN.
        /// </summary>
        public const string SHCMLN = "SHCMLN";

        /// <summary>
        /// SHSLSM.
        /// </summary>
        public const string SHSLSM = "SHSLSM";

        /// <summary>
        /// SHSLCM.
        /// </summary>
        public const string SHSLCM = "SHSLCM";

        /// <summary>
        /// SHFCA.
        /// </summary>
        public const string SHFCA = "SHFCA";

        /// <summary>
        /// SHAPUN.
        /// </summary>
        public const string SHAPUN = "SHAPUN";

        /// <summary>
        /// SHCCTY.
        /// </summary>
        public const string SHCCTY = "SHCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F42150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHDOCO", "SHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SHDCTO", "SHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SHKCOO", "SHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SHCMLN", "SHCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SHSLSM", "SHSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("SHSLCM", "SHSLCM", JdeDataType.Numeric),
        new JdeField("SHFCA", "SHFCA", JdeDataType.Numeric),
        new JdeField("SHAPUN", "SHAPUN", JdeDataType.Numeric),
        new JdeField("SHCCTY", "SHCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42150_0", "Primary Key on SHDOCO, SHDCTO, SHKCOO, SHSLSM, SHCMLN", new[] { "SHDOCO", "SHDCTO", "SHKCOO", "SHSLSM", "SHCMLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42150_4", "Index on SHDOCO, SHDCTO", new[] { "SHDOCO", "SHDCTO" }),
        new JdeIndex("F42150_5", "Index on SHDOCO, SHDCTO, SHKCOO", new[] { "SHDOCO", "SHDCTO", "SHKCOO" })
    };
}
