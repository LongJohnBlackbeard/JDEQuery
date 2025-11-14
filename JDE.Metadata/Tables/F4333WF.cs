using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4333WF - .
/// </summary>
public class F4333WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// POUKID.
        /// </summary>
        public const string POUKID = "POUKID";

        /// <summary>
        /// PODOCO.
        /// </summary>
        public const string PODOCO = "PODOCO";

        /// <summary>
        /// PODCTO.
        /// </summary>
        public const string PODCTO = "PODCTO";

        /// <summary>
        /// POKCOO.
        /// </summary>
        public const string POKCOO = "POKCOO";

        /// <summary>
        /// POSFXO.
        /// </summary>
        public const string POSFXO = "POSFXO";

        /// <summary>
        /// POUSER.
        /// </summary>
        public const string POUSER = "POUSER";

        /// <summary>
        /// POPID.
        /// </summary>
        public const string POPID = "POPID";

        /// <summary>
        /// POJOBN.
        /// </summary>
        public const string POJOBN = "POJOBN";

        /// <summary>
        /// POUPMJ.
        /// </summary>
        public const string POUPMJ = "POUPMJ";

        /// <summary>
        /// POUPMT.
        /// </summary>
        public const string POUPMT = "POUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4333WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("POUKID", "POUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PODOCO", "PODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PODCTO", "PODCTO", JdeDataType.String, 4, true, true),
        new JdeField("POKCOO", "POKCOO", JdeDataType.String, 10, true, true),
        new JdeField("POSFXO", "POSFXO", JdeDataType.String, 6, true, true),
        new JdeField("POUSER", "POUSER", JdeDataType.String, 20),
        new JdeField("POPID", "POPID", JdeDataType.String, 20),
        new JdeField("POJOBN", "POJOBN", JdeDataType.String, 20),
        new JdeField("POUPMJ", "POUPMJ", JdeDataType.Numeric),
        new JdeField("POUPMT", "POUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4333WF_0", "Primary Key on POUKID, PODOCO, PODCTO, POKCOO, POSFXO", new[] { "POUKID", "PODOCO", "PODCTO", "POKCOO", "POSFXO" }, isUnique: true, isPrimaryKey: true)
    };
}
