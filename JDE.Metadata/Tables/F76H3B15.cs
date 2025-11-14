using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B15 - .
/// </summary>
public class F76H3B15 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRKCO.
        /// </summary>
        public const string IRKCO = "IRKCO";

        /// <summary>
        /// IRDCT.
        /// </summary>
        public const string IRDCT = "IRDCT";

        /// <summary>
        /// IRDOC.
        /// </summary>
        public const string IRDOC = "IRDOC";

        /// <summary>
        /// IROKCO.
        /// </summary>
        public const string IROKCO = "IROKCO";

        /// <summary>
        /// IRODCT.
        /// </summary>
        public const string IRODCT = "IRODCT";

        /// <summary>
        /// IRODOC.
        /// </summary>
        public const string IRODOC = "IRODOC";

        /// <summary>
        /// IRH76FUC.
        /// </summary>
        public const string IRH76FUC = "IRH76FUC";

        /// <summary>
        /// IRH76FUD.
        /// </summary>
        public const string IRH76FUD = "IRH76FUD";

        /// <summary>
        /// IRH76FUR.
        /// </summary>
        public const string IRH76FUR = "IRH76FUR";

        /// <summary>
        /// IRH76FUA.
        /// </summary>
        public const string IRH76FUA = "IRH76FUA";

        /// <summary>
        /// IRH76FUF.
        /// </summary>
        public const string IRH76FUF = "IRH76FUF";

        /// <summary>
        /// IRUSER.
        /// </summary>
        public const string IRUSER = "IRUSER";

        /// <summary>
        /// IRPID.
        /// </summary>
        public const string IRPID = "IRPID";

        /// <summary>
        /// IRJOBN.
        /// </summary>
        public const string IRJOBN = "IRJOBN";

        /// <summary>
        /// IRUPMJ.
        /// </summary>
        public const string IRUPMJ = "IRUPMJ";

        /// <summary>
        /// IRUPMT.
        /// </summary>
        public const string IRUPMT = "IRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRKCO", "IRKCO", JdeDataType.String, 10, true, true),
        new JdeField("IRDCT", "IRDCT", JdeDataType.String, 4, true, true),
        new JdeField("IRDOC", "IRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IROKCO", "IROKCO", JdeDataType.String, 10, true, true),
        new JdeField("IRODCT", "IRODCT", JdeDataType.String, 4, true, true),
        new JdeField("IRODOC", "IRODOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IRH76FUC", "IRH76FUC", JdeDataType.String, 20),
        new JdeField("IRH76FUD", "IRH76FUD", JdeDataType.Numeric),
        new JdeField("IRH76FUR", "IRH76FUR", JdeDataType.String, 30),
        new JdeField("IRH76FUA", "IRH76FUA", JdeDataType.Numeric),
        new JdeField("IRH76FUF", "IRH76FUF", JdeDataType.String, 2),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRUPMT", "IRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B15_0", "Primary Key on IRKCO, IRDCT, IRDOC, IROKCO, IRODCT, IRODOC", new[] { "IRKCO", "IRDCT", "IRDOC", "IROKCO", "IRODCT", "IRODOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H3B15_2", "Index on IROKCO, IRODCT, IRODOC", new[] { "IROKCO", "IRODCT", "IRODOC" })
    };
}
