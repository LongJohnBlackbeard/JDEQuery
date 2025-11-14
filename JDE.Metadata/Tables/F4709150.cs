using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4709150 - .
/// </summary>
public class F4709150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QHDOCO.
        /// </summary>
        public const string QHDOCO = "QHDOCO";

        /// <summary>
        /// QHDCTO.
        /// </summary>
        public const string QHDCTO = "QHDCTO";

        /// <summary>
        /// QHKCOO.
        /// </summary>
        public const string QHKCOO = "QHKCOO";

        /// <summary>
        /// QHCMLN.
        /// </summary>
        public const string QHCMLN = "QHCMLN";

        /// <summary>
        /// QHSLSM.
        /// </summary>
        public const string QHSLSM = "QHSLSM";

        /// <summary>
        /// QHSLCM.
        /// </summary>
        public const string QHSLCM = "QHSLCM";

        /// <summary>
        /// QHFCA.
        /// </summary>
        public const string QHFCA = "QHFCA";

        /// <summary>
        /// QHAPUN.
        /// </summary>
        public const string QHAPUN = "QHAPUN";

        /// <summary>
        /// QHCCTY.
        /// </summary>
        public const string QHCCTY = "QHCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4709150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QHDOCO", "QHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("QHDCTO", "QHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("QHKCOO", "QHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("QHCMLN", "QHCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("QHSLSM", "QHSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("QHSLCM", "QHSLCM", JdeDataType.Numeric),
        new JdeField("QHFCA", "QHFCA", JdeDataType.Numeric),
        new JdeField("QHAPUN", "QHAPUN", JdeDataType.Numeric),
        new JdeField("QHCCTY", "QHCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4709150_0", "Primary Key on QHDOCO, QHDCTO, QHKCOO, QHCMLN, QHSLSM", new[] { "QHDOCO", "QHDCTO", "QHKCOO", "QHCMLN", "QHSLSM" }, isUnique: true, isPrimaryKey: true)
    };
}
