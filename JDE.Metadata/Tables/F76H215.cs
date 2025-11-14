using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H215 - .
/// </summary>
public class F76H215 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRKCOO.
        /// </summary>
        public const string IRKCOO = "IRKCOO";

        /// <summary>
        /// IRDCTO.
        /// </summary>
        public const string IRDCTO = "IRDCTO";

        /// <summary>
        /// IRDOCO.
        /// </summary>
        public const string IRDOCO = "IRDOCO";

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
        /// IRUSER.
        /// </summary>
        public const string IRUSER = "IRUSER";

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

        /// <summary>
        /// IRPID.
        /// </summary>
        public const string IRPID = "IRPID";
    }

    /// <inheritdoc />
    public override string TableName => "F76H215";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRKCOO", "IRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("IRDCTO", "IRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("IRDOCO", "IRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IRKCO", "IRKCO", JdeDataType.String, 10, true, true),
        new JdeField("IRDCT", "IRDCT", JdeDataType.String, 4, true, true),
        new JdeField("IRDOC", "IRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRUPMT", "IRUPMT", JdeDataType.Numeric),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H215_0", "Primary Key on IRKCOO, IRDCTO, IRDOCO, IRKCO, IRDCT, IRDOC", new[] { "IRKCOO", "IRDCTO", "IRDOCO", "IRKCO", "IRDCT", "IRDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
