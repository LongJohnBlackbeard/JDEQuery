using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0531 - .
/// </summary>
public class F76B0531 : JdeTable
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
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBVERS.
        /// </summary>
        public const string DBVERS = "DBVERS";

        /// <summary>
        /// DBB76BSTB9.
        /// </summary>
        public const string DBB76BSTB9 = "DBB76BSTB9";

        /// <summary>
        /// DBURCD.
        /// </summary>
        public const string DBURCD = "DBURCD";

        /// <summary>
        /// DBURDT.
        /// </summary>
        public const string DBURDT = "DBURDT";

        /// <summary>
        /// DBURAT.
        /// </summary>
        public const string DBURAT = "DBURAT";

        /// <summary>
        /// DBURRF.
        /// </summary>
        public const string DBURRF = "DBURRF";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

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
    public override string TableName => "F76B0531";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBJOBS", "DBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DBB76BLCK", "DBB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("DBB76RESQ", "DBB76RESQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBVERS", "DBVERS", JdeDataType.String, 20),
        new JdeField("DBB76BSTB9", "DBB76BSTB9", JdeDataType.String, 2),
        new JdeField("DBURCD", "DBURCD", JdeDataType.String, 4),
        new JdeField("DBURDT", "DBURDT", JdeDataType.Numeric),
        new JdeField("DBURAT", "DBURAT", JdeDataType.Numeric),
        new JdeField("DBURRF", "DBURRF", JdeDataType.String, 30),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBUPMT", "DBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0531_0", "Primary Key on DBJOBS, DBB76BLCK, DBB76RESQ", new[] { "DBJOBS", "DBB76BLCK", "DBB76RESQ" }, isUnique: true, isPrimaryKey: true)
    };
}
