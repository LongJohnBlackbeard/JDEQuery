using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I215 - .
/// </summary>
public class F75I215 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRI75PRNB.
        /// </summary>
        public const string PRI75PRNB = "PRI75PRNB";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I215";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PRI75PRNB", "PRI75PRNB", JdeDataType.String, 20),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I215_0", "Primary Key on PRAN8", new[] { "PRAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
