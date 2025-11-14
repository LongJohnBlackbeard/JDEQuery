using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01501 - .
/// </summary>
public class F01501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PROSTP.
        /// </summary>
        public const string PROSTP = "PROSTP";

        /// <summary>
        /// PRALKY.
        /// </summary>
        public const string PRALKY = "PRALKY";

        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRIDLN.
        /// </summary>
        public const string PRIDLN = "PRIDLN";

        /// <summary>
        /// PRRELY.
        /// </summary>
        public const string PRRELY = "PRRELY";

        /// <summary>
        /// PRDSS7.
        /// </summary>
        public const string PRDSS7 = "PRDSS7";

        /// <summary>
        /// PRBEFD.
        /// </summary>
        public const string PRBEFD = "PRBEFD";

        /// <summary>
        /// PREEFD.
        /// </summary>
        public const string PREEFD = "PREEFD";

        /// <summary>
        /// PRRMK.
        /// </summary>
        public const string PRRMK = "PRRMK";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F01501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PROSTP", "PROSTP", JdeDataType.String, 6, true, true),
        new JdeField("PRALKY", "PRALKY", JdeDataType.String, 40, true, true),
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PRIDLN", "PRIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PRRELY", "PRRELY", JdeDataType.String, 10),
        new JdeField("PRDSS7", "PRDSS7", JdeDataType.Numeric),
        new JdeField("PRBEFD", "PRBEFD", JdeDataType.Numeric),
        new JdeField("PREEFD", "PREEFD", JdeDataType.Numeric),
        new JdeField("PRRMK", "PRRMK", JdeDataType.String, 60),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01501_0", "Primary Key on PROSTP, PRALKY, PRAN8, PRIDLN", new[] { "PROSTP", "PRALKY", "PRAN8", "PRIDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01501_2", "Index on PROSTP, PRAN8, PRIDLN", new[] { "PROSTP", "PRAN8", "PRIDLN" }),
        new JdeIndex("F01501_3", "Index on PROSTP, PRAN8, PRIDLN, PRALKY", new[] { "PROSTP", "PRAN8", "PRIDLN", "PRALKY" })
    };
}
