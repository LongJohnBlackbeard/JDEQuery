using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45521TX - .
/// </summary>
public class F45521TX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LTDOCO.
        /// </summary>
        public const string LTDOCO = "LTDOCO";

        /// <summary>
        /// LTDCTO.
        /// </summary>
        public const string LTDCTO = "LTDCTO";

        /// <summary>
        /// LTLNID.
        /// </summary>
        public const string LTLNID = "LTLNID";

        /// <summary>
        /// LTTUPRC.
        /// </summary>
        public const string LTTUPRC = "LTTUPRC";

        /// <summary>
        /// LTUTA.
        /// </summary>
        public const string LTUTA = "LTUTA";

        /// <summary>
        /// LTUSER.
        /// </summary>
        public const string LTUSER = "LTUSER";

        /// <summary>
        /// LTPID.
        /// </summary>
        public const string LTPID = "LTPID";

        /// <summary>
        /// LTJOBN.
        /// </summary>
        public const string LTJOBN = "LTJOBN";

        /// <summary>
        /// LTUPMJ.
        /// </summary>
        public const string LTUPMJ = "LTUPMJ";

        /// <summary>
        /// LTUPMT.
        /// </summary>
        public const string LTUPMT = "LTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F45521TX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LTDOCO", "LTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LTDCTO", "LTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LTLNID", "LTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LTTUPRC", "LTTUPRC", JdeDataType.Numeric),
        new JdeField("LTUTA", "LTUTA", JdeDataType.Numeric),
        new JdeField("LTUSER", "LTUSER", JdeDataType.String, 20),
        new JdeField("LTPID", "LTPID", JdeDataType.String, 20),
        new JdeField("LTJOBN", "LTJOBN", JdeDataType.String, 20),
        new JdeField("LTUPMJ", "LTUPMJ", JdeDataType.Numeric),
        new JdeField("LTUPMT", "LTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45521TX_0", "Primary Key on LTDOCO, LTDCTO, LTLNID", new[] { "LTDOCO", "LTDCTO", "LTLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
