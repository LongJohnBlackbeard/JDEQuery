using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B018 - .
/// </summary>
public class F76B018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRBNNF.
        /// </summary>
        public const string IRBNNF = "IRBNNF";

        /// <summary>
        /// IRBSER.
        /// </summary>
        public const string IRBSER = "IRBSER";

        /// <summary>
        /// IRN001.
        /// </summary>
        public const string IRN001 = "IRN001";

        /// <summary>
        /// IRDCT.
        /// </summary>
        public const string IRDCT = "IRDCT";

        /// <summary>
        /// IRUKID.
        /// </summary>
        public const string IRUKID = "IRUKID";

        /// <summary>
        /// IRB76IDOC.
        /// </summary>
        public const string IRB76IDOC = "IRB76IDOC";

        /// <summary>
        /// IRB76IDCT.
        /// </summary>
        public const string IRB76IDCT = "IRB76IDCT";

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
    public override string TableName => "F76B018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRBNNF", "IRBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("IRBSER", "IRBSER", JdeDataType.String, 4, true, true),
        new JdeField("IRN001", "IRN001", JdeDataType.Numeric, null, true, true),
        new JdeField("IRDCT", "IRDCT", JdeDataType.String, 4, true, true),
        new JdeField("IRUKID", "IRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IRB76IDOC", "IRB76IDOC", JdeDataType.String, 20, true, true),
        new JdeField("IRB76IDCT", "IRB76IDCT", JdeDataType.String, 6, true, true),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRUPMT", "IRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B018_0", "Primary Key on IRBNNF, IRBSER, IRN001, IRDCT, IRUKID, IRB76IDOC, IRB76IDCT", new[] { "IRBNNF", "IRBSER", "IRN001", "IRDCT", "IRUKID", "IRB76IDOC", "IRB76IDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
