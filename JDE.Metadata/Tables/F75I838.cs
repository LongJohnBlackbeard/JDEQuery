using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I838 - .
/// </summary>
public class F75I838 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHPYID.
        /// </summary>
        public const string RHPYID = "RHPYID";

        /// <summary>
        /// RHCO.
        /// </summary>
        public const string RHCO = "RHCO";

        /// <summary>
        /// RHDGJ.
        /// </summary>
        public const string RHDGJ = "RHDGJ";

        /// <summary>
        /// RHMCU.
        /// </summary>
        public const string RHMCU = "RHMCU";

        /// <summary>
        /// RHBCRC.
        /// </summary>
        public const string RHBCRC = "RHBCRC";

        /// <summary>
        /// RHPAAP.
        /// </summary>
        public const string RHPAAP = "RHPAAP";

        /// <summary>
        /// RHI75REVBN.
        /// </summary>
        public const string RHI75REVBN = "RHI75REVBN";

        /// <summary>
        /// RHICUT.
        /// </summary>
        public const string RHICUT = "RHICUT";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHUPMT.
        /// </summary>
        public const string RHUPMT = "RHUPMT";

        /// <summary>
        /// RHYFUTDT1.
        /// </summary>
        public const string RHYFUTDT1 = "RHYFUTDT1";

        /// <summary>
        /// RHFUT6.
        /// </summary>
        public const string RHFUT6 = "RHFUT6";

        /// <summary>
        /// RHYT04.
        /// </summary>
        public const string RHYT04 = "RHYT04";

        /// <summary>
        /// RHYFLAG.
        /// </summary>
        public const string RHYFLAG = "RHYFLAG";

        /// <summary>
        /// RHYNUM1.
        /// </summary>
        public const string RHYNUM1 = "RHYNUM1";

        /// <summary>
        /// RHI75INVNO.
        /// </summary>
        public const string RHI75INVNO = "RHI75INVNO";

        /// <summary>
        /// RHI75TRCAT.
        /// </summary>
        public const string RHI75TRCAT = "RHI75TRCAT";

        /// <summary>
        /// RHI75IPOS.
        /// </summary>
        public const string RHI75IPOS = "RHI75IPOS";

        /// <summary>
        /// RHPYE.
        /// </summary>
        public const string RHPYE = "RHPYE";

        /// <summary>
        /// RHAN8.
        /// </summary>
        public const string RHAN8 = "RHAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F75I838";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHPYID", "RHPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RHCO", "RHCO", JdeDataType.String, 10),
        new JdeField("RHDGJ", "RHDGJ", JdeDataType.Numeric),
        new JdeField("RHMCU", "RHMCU", JdeDataType.String, 24),
        new JdeField("RHBCRC", "RHBCRC", JdeDataType.String, 6),
        new JdeField("RHPAAP", "RHPAAP", JdeDataType.Numeric),
        new JdeField("RHI75REVBN", "RHI75REVBN", JdeDataType.Numeric),
        new JdeField("RHICUT", "RHICUT", JdeDataType.String, 4),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHUPMT", "RHUPMT", JdeDataType.Numeric),
        new JdeField("RHYFUTDT1", "RHYFUTDT1", JdeDataType.Numeric),
        new JdeField("RHFUT6", "RHFUT6", JdeDataType.String, 60),
        new JdeField("RHYT04", "RHYT04", JdeDataType.String, 2),
        new JdeField("RHYFLAG", "RHYFLAG", JdeDataType.String, 2),
        new JdeField("RHYNUM1", "RHYNUM1", JdeDataType.Numeric),
        new JdeField("RHI75INVNO", "RHI75INVNO", JdeDataType.String, 50),
        new JdeField("RHI75TRCAT", "RHI75TRCAT", JdeDataType.String, 4),
        new JdeField("RHI75IPOS", "RHI75IPOS", JdeDataType.String, 4),
        new JdeField("RHPYE", "RHPYE", JdeDataType.Numeric),
        new JdeField("RHAN8", "RHAN8", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I838_0", "Primary Key on RHPYID, RHAN8", new[] { "RHPYID", "RHAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
