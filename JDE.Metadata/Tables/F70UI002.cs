using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70UI002 - .
/// </summary>
public class F70UI002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSJOBS.
        /// </summary>
        public const string CSJOBS = "CSJOBS";

        /// <summary>
        /// CSAID.
        /// </summary>
        public const string CSAID = "CSAID";

        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSAT1.
        /// </summary>
        public const string CSAT1 = "CSAT1";

        /// <summary>
        /// CSTAX.
        /// </summary>
        public const string CSTAX = "CSTAX";

        /// <summary>
        /// CSALPH.
        /// </summary>
        public const string CSALPH = "CSALPH";

        /// <summary>
        /// CSK70ACIR.
        /// </summary>
        public const string CSK70ACIR = "CSK70ACIR";

        /// <summary>
        /// CSK70REFA.
        /// </summary>
        public const string CSK70REFA = "CSK70REFA";

        /// <summary>
        /// CSK70READ.
        /// </summary>
        public const string CSK70READ = "CSK70READ";

        /// <summary>
        /// CSK70SBI.
        /// </summary>
        public const string CSK70SBI = "CSK70SBI";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";

        /// <summary>
        /// CSK70ACT.
        /// </summary>
        public const string CSK70ACT = "CSK70ACT";
    }

    /// <inheritdoc />
    public override string TableName => "F70UI002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSJOBS", "CSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CSAID", "CSAID", JdeDataType.String, 16, true, true),
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CSAT1", "CSAT1", JdeDataType.String, 6, true, true),
        new JdeField("CSTAX", "CSTAX", JdeDataType.String, 40),
        new JdeField("CSALPH", "CSALPH", JdeDataType.String, 80),
        new JdeField("CSK70ACIR", "CSK70ACIR", JdeDataType.String, 4),
        new JdeField("CSK70REFA", "CSK70REFA", JdeDataType.String, 60),
        new JdeField("CSK70READ", "CSK70READ", JdeDataType.String, 160),
        new JdeField("CSK70SBI", "CSK70SBI", JdeDataType.String, 2),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20, true, true),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric),
        new JdeField("CSK70ACT", "CSK70ACT", JdeDataType.String, 36)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70UI002_0", "Primary Key on CSJOBS, CSAID, CSAN8, CSUSER, CSAT1", new[] { "CSJOBS", "CSAID", "CSAN8", "CSUSER", "CSAT1" }, isUnique: true, isPrimaryKey: true)
    };
}
