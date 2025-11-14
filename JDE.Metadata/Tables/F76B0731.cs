using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0731 - .
/// </summary>
public class F76B0731 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBB76ATCT.
        /// </summary>
        public const string DBB76ATCT = "DBB76ATCT";

        /// <summary>
        /// DBB76BLCK.
        /// </summary>
        public const string DBB76BLCK = "DBB76BLCK";

        /// <summary>
        /// DBB76RESQ.
        /// </summary>
        public const string DBB76RESQ = "DBB76RESQ";

        /// <summary>
        /// DBMPID.
        /// </summary>
        public const string DBMPID = "DBMPID";

        /// <summary>
        /// DBVERS.
        /// </summary>
        public const string DBVERS = "DBVERS";

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
        /// DBURAB.
        /// </summary>
        public const string DBURAB = "DBURAB";

        /// <summary>
        /// DBURRF.
        /// </summary>
        public const string DBURRF = "DBURRF";

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
    public override string TableName => "F76B0731";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBB76ATCT", "DBB76ATCT", JdeDataType.String, 4, true, true),
        new JdeField("DBB76BLCK", "DBB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("DBB76RESQ", "DBB76RESQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DBMPID", "DBMPID", JdeDataType.String, 20),
        new JdeField("DBVERS", "DBVERS", JdeDataType.String, 20),
        new JdeField("DBURCD", "DBURCD", JdeDataType.String, 4),
        new JdeField("DBURDT", "DBURDT", JdeDataType.Numeric),
        new JdeField("DBURAT", "DBURAT", JdeDataType.Numeric),
        new JdeField("DBURAB", "DBURAB", JdeDataType.Numeric),
        new JdeField("DBURRF", "DBURRF", JdeDataType.String, 30),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBUPMT", "DBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0731_0", "Primary Key on DBB76ATCT, DBB76BLCK, DBB76RESQ", new[] { "DBB76ATCT", "DBB76BLCK", "DBB76RESQ" }, isUnique: true, isPrimaryKey: true)
    };
}
