using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4013 - .
/// </summary>
public class F76B4013 : JdeTable
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
        /// IRB76IR.
        /// </summary>
        public const string IRB76IR = "IRB76IR";

        /// <summary>
        /// IRB76MIR.
        /// </summary>
        public const string IRB76MIR = "IRB76MIR";

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
    public override string TableName => "F76B4013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRKCO", "IRKCO", JdeDataType.String, 10, true, true),
        new JdeField("IRDCT", "IRDCT", JdeDataType.String, 4, true, true),
        new JdeField("IRDOC", "IRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IRB76IR", "IRB76IR", JdeDataType.String, 2),
        new JdeField("IRB76MIR", "IRB76MIR", JdeDataType.String, 2),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRUPMT", "IRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4013_0", "Primary Key on IRKCO, IRDCT, IRDOC", new[] { "IRKCO", "IRDCT", "IRDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
