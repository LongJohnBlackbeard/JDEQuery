using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08350C - .
/// </summary>
public class F08350C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BXDIVC.
        /// </summary>
        public const string BXDIVC = "BXDIVC";

        /// <summary>
        /// BXSBGR.
        /// </summary>
        public const string BXSBGR = "BXSBGR";

        /// <summary>
        /// BXBCATCL.
        /// </summary>
        public const string BXBCATCL = "BXBCATCL";

        /// <summary>
        /// BXSCTDES.
        /// </summary>
        public const string BXSCTDES = "BXSCTDES";

        /// <summary>
        /// BXDCNF.
        /// </summary>
        public const string BXDCNF = "BXDCNF";

        /// <summary>
        /// BXSIPG.
        /// </summary>
        public const string BXSIPG = "BXSIPG";

        /// <summary>
        /// BXUSER.
        /// </summary>
        public const string BXUSER = "BXUSER";

        /// <summary>
        /// BXPID.
        /// </summary>
        public const string BXPID = "BXPID";

        /// <summary>
        /// BXJOBN.
        /// </summary>
        public const string BXJOBN = "BXJOBN";

        /// <summary>
        /// BXUPMJ.
        /// </summary>
        public const string BXUPMJ = "BXUPMJ";

        /// <summary>
        /// BXUPMT.
        /// </summary>
        public const string BXUPMT = "BXUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08350C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BXDIVC", "BXDIVC", JdeDataType.String, 12, true, true),
        new JdeField("BXSBGR", "BXSBGR", JdeDataType.String, 20, true, true),
        new JdeField("BXBCATCL", "BXBCATCL", JdeDataType.String, 6),
        new JdeField("BXSCTDES", "BXSCTDES", JdeDataType.String, 30),
        new JdeField("BXDCNF", "BXDCNF", JdeDataType.String, 2),
        new JdeField("BXSIPG", "BXSIPG", JdeDataType.String, 2),
        new JdeField("BXUSER", "BXUSER", JdeDataType.String, 20),
        new JdeField("BXPID", "BXPID", JdeDataType.String, 20),
        new JdeField("BXJOBN", "BXJOBN", JdeDataType.String, 20),
        new JdeField("BXUPMJ", "BXUPMJ", JdeDataType.Numeric),
        new JdeField("BXUPMT", "BXUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08350C_0", "Primary Key on BXDIVC, BXSBGR", new[] { "BXDIVC", "BXSBGR" }, isUnique: true, isPrimaryKey: true)
    };
}
