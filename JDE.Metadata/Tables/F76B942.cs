using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B942 - .
/// </summary>
public class F76B942 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBJOBS.
        /// </summary>
        public const string DBJOBS = "DBJOBS";

        /// <summary>
        /// DBB76BLCK.
        /// </summary>
        public const string DBB76BLCK = "DBB76BLCK";

        /// <summary>
        /// DBB76RESQ.
        /// </summary>
        public const string DBB76RESQ = "DBB76RESQ";

        /// <summary>
        /// DBB76SHDE.
        /// </summary>
        public const string DBB76SHDE = "DBB76SHDE";

        /// <summary>
        /// DBMPID.
        /// </summary>
        public const string DBMPID = "DBMPID";

        /// <summary>
        /// DBVERS.
        /// </summary>
        public const string DBVERS = "DBVERS";

        /// <summary>
        /// DBB76REST.
        /// </summary>
        public const string DBB76REST = "DBB76REST";

        /// <summary>
        /// DBB76LUOB.
        /// </summary>
        public const string DBB76LUOB = "DBB76LUOB";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBJOBN.
        /// </summary>
        public const string DBJOBN = "DBJOBN";

        /// <summary>
        /// DBUPMJ.
        /// </summary>
        public const string DBUPMJ = "DBUPMJ";

        /// <summary>
        /// DBUPMT.
        /// </summary>
        public const string DBUPMT = "DBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B942";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBJOBS", "DBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DBB76BLCK", "DBB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("DBB76RESQ", "DBB76RESQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DBB76SHDE", "DBB76SHDE", JdeDataType.String, 2),
        new JdeField("DBMPID", "DBMPID", JdeDataType.String, 20),
        new JdeField("DBVERS", "DBVERS", JdeDataType.String, 20),
        new JdeField("DBB76REST", "DBB76REST", JdeDataType.String, 2),
        new JdeField("DBB76LUOB", "DBB76LUOB", JdeDataType.Numeric),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBUPMT", "DBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B942_0", "Primary Key on DBJOBS, DBB76BLCK, DBB76RESQ", new[] { "DBJOBS", "DBB76BLCK", "DBB76RESQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B942_2", "Index on DBJOBS, DBB76BLCK, DBMPID, DBVERS", new[] { "DBJOBS", "DBB76BLCK", "DBMPID", "DBVERS" })
    };
}
