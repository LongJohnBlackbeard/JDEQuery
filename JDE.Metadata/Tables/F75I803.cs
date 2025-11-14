using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I803 - .
/// </summary>
public class F75I803 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRI75GSTU.
        /// </summary>
        public const string CRI75GSTU = "CRI75GSTU";

        /// <summary>
        /// CRMCU.
        /// </summary>
        public const string CRMCU = "CRMCU";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRDATF01.
        /// </summary>
        public const string CRDATF01 = "CRDATF01";

        /// <summary>
        /// CRDEPFUT2.
        /// </summary>
        public const string CRDEPFUT2 = "CRDEPFUT2";

        /// <summary>
        /// CRACTFU1.
        /// </summary>
        public const string CRACTFU1 = "CRACTFU1";

        /// <summary>
        /// CRFLAG.
        /// </summary>
        public const string CRFLAG = "CRFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I803";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRI75GSTU", "CRI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("CRMCU", "CRMCU", JdeDataType.String, 24, true, true),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRDATF01", "CRDATF01", JdeDataType.Numeric),
        new JdeField("CRDEPFUT2", "CRDEPFUT2", JdeDataType.String, 60),
        new JdeField("CRACTFU1", "CRACTFU1", JdeDataType.String, 2),
        new JdeField("CRFLAG", "CRFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I803_0", "Primary Key on CRI75GSTU, CRMCU", new[] { "CRI75GSTU", "CRMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I803_2", "Index on CRMCU", new[] { "CRMCU" })
    };
}
