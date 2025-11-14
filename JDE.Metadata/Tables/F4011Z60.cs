using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4011Z60 - .
/// </summary>
public class F4011Z60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DCDOCO.
        /// </summary>
        public const string DCDOCO = "DCDOCO";

        /// <summary>
        /// DCDCTO.
        /// </summary>
        public const string DCDCTO = "DCDCTO";

        /// <summary>
        /// DCKCOO.
        /// </summary>
        public const string DCKCOO = "DCKCOO";

        /// <summary>
        /// DCSFXO.
        /// </summary>
        public const string DCSFXO = "DCSFXO";

        /// <summary>
        /// DCLNID.
        /// </summary>
        public const string DCLNID = "DCLNID";

        /// <summary>
        /// DCCMLN.
        /// </summary>
        public const string DCCMLN = "DCCMLN";

        /// <summary>
        /// DCSLSM.
        /// </summary>
        public const string DCSLSM = "DCSLSM";

        /// <summary>
        /// DCSLCM.
        /// </summary>
        public const string DCSLCM = "DCSLCM";

        /// <summary>
        /// DCFCA.
        /// </summary>
        public const string DCFCA = "DCFCA";

        /// <summary>
        /// DCAPUN.
        /// </summary>
        public const string DCAPUN = "DCAPUN";

        /// <summary>
        /// DCCCTY.
        /// </summary>
        public const string DCCCTY = "DCCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4011Z60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DCDOCO", "DCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DCDCTO", "DCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DCKCOO", "DCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DCSFXO", "DCSFXO", JdeDataType.String, 6, true, true),
        new JdeField("DCLNID", "DCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DCCMLN", "DCCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("DCSLSM", "DCSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("DCSLCM", "DCSLCM", JdeDataType.Numeric),
        new JdeField("DCFCA", "DCFCA", JdeDataType.Numeric),
        new JdeField("DCAPUN", "DCAPUN", JdeDataType.Numeric),
        new JdeField("DCCCTY", "DCCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4011Z60_0", "Primary Key on DCDOCO, DCDCTO, DCKCOO, DCSFXO, DCLNID, DCCMLN, DCSLSM", new[] { "DCDOCO", "DCDCTO", "DCKCOO", "DCSFXO", "DCLNID", "DCCMLN", "DCSLSM" }, isUnique: true, isPrimaryKey: true)
    };
}
