using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I813 - .
/// </summary>
public class F75I813 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRDOC.
        /// </summary>
        public const string PRDOC = "PRDOC";

        /// <summary>
        /// PRDCT.
        /// </summary>
        public const string PRDCT = "PRDCT";

        /// <summary>
        /// PRKCO.
        /// </summary>
        public const string PRKCO = "PRKCO";

        /// <summary>
        /// PRI75GSTU.
        /// </summary>
        public const string PRI75GSTU = "PRI75GSTU";

        /// <summary>
        /// PRI75REVBN.
        /// </summary>
        public const string PRI75REVBN = "PRI75REVBN";

        /// <summary>
        /// PRDICJ.
        /// </summary>
        public const string PRDICJ = "PRDICJ";

        /// <summary>
        /// PRDTFR.
        /// </summary>
        public const string PRDTFR = "PRDTFR";

        /// <summary>
        /// PRDTTO.
        /// </summary>
        public const string PRDTTO = "PRDTTO";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRYFUTDT1.
        /// </summary>
        public const string PRYFUTDT1 = "PRYFUTDT1";

        /// <summary>
        /// PRFUT6.
        /// </summary>
        public const string PRFUT6 = "PRFUT6";

        /// <summary>
        /// PRYT04.
        /// </summary>
        public const string PRYT04 = "PRYT04";

        /// <summary>
        /// PRYFLAG.
        /// </summary>
        public const string PRYFLAG = "PRYFLAG";

        /// <summary>
        /// PRICUT.
        /// </summary>
        public const string PRICUT = "PRICUT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I813";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRDOC", "PRDOC", JdeDataType.Numeric),
        new JdeField("PRDCT", "PRDCT", JdeDataType.String, 4),
        new JdeField("PRKCO", "PRKCO", JdeDataType.String, 10),
        new JdeField("PRI75GSTU", "PRI75GSTU", JdeDataType.Numeric),
        new JdeField("PRI75REVBN", "PRI75REVBN", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDICJ", "PRDICJ", JdeDataType.Numeric),
        new JdeField("PRDTFR", "PRDTFR", JdeDataType.Numeric),
        new JdeField("PRDTTO", "PRDTTO", JdeDataType.Numeric),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRYFUTDT1", "PRYFUTDT1", JdeDataType.Numeric),
        new JdeField("PRFUT6", "PRFUT6", JdeDataType.String, 60),
        new JdeField("PRYT04", "PRYT04", JdeDataType.String, 2),
        new JdeField("PRYFLAG", "PRYFLAG", JdeDataType.String, 2),
        new JdeField("PRICUT", "PRICUT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I813_0", "Primary Key on PRI75REVBN", new[] { "PRI75REVBN" }, isUnique: true, isPrimaryKey: true)
    };
}
