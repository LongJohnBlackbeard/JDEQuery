using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4709260 - .
/// </summary>
public class F4709260 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QDDOCO.
        /// </summary>
        public const string QDDOCO = "QDDOCO";

        /// <summary>
        /// QDDCTO.
        /// </summary>
        public const string QDDCTO = "QDDCTO";

        /// <summary>
        /// QDKCOO.
        /// </summary>
        public const string QDKCOO = "QDKCOO";

        /// <summary>
        /// QDSFXO.
        /// </summary>
        public const string QDSFXO = "QDSFXO";

        /// <summary>
        /// QDLNID.
        /// </summary>
        public const string QDLNID = "QDLNID";

        /// <summary>
        /// QDCMLN.
        /// </summary>
        public const string QDCMLN = "QDCMLN";

        /// <summary>
        /// QDSLSM.
        /// </summary>
        public const string QDSLSM = "QDSLSM";

        /// <summary>
        /// QDSLCM.
        /// </summary>
        public const string QDSLCM = "QDSLCM";

        /// <summary>
        /// QDFCA.
        /// </summary>
        public const string QDFCA = "QDFCA";

        /// <summary>
        /// QDAPUN.
        /// </summary>
        public const string QDAPUN = "QDAPUN";

        /// <summary>
        /// QDCCTY.
        /// </summary>
        public const string QDCCTY = "QDCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4709260";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QDDOCO", "QDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("QDDCTO", "QDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("QDKCOO", "QDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("QDSFXO", "QDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("QDLNID", "QDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QDCMLN", "QDCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("QDSLSM", "QDSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("QDSLCM", "QDSLCM", JdeDataType.Numeric),
        new JdeField("QDFCA", "QDFCA", JdeDataType.Numeric),
        new JdeField("QDAPUN", "QDAPUN", JdeDataType.Numeric),
        new JdeField("QDCCTY", "QDCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4709260_0", "Primary Key on QDDOCO, QDDCTO, QDKCOO, QDSFXO, QDLNID, QDCMLN, QDSLSM", new[] { "QDDOCO", "QDDCTO", "QDKCOO", "QDSFXO", "QDLNID", "QDCMLN", "QDSLSM" }, isUnique: true, isPrimaryKey: true)
    };
}
