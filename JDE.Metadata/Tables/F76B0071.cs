using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0071 - .
/// </summary>
public class F76B0071 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBGPBT.
        /// </summary>
        public const string DBGPBT = "DBGPBT";

        /// <summary>
        /// DBGPTN.
        /// </summary>
        public const string DBGPTN = "DBGPTN";

        /// <summary>
        /// DBLIN.
        /// </summary>
        public const string DBLIN = "DBLIN";

        /// <summary>
        /// DBGPSP.
        /// </summary>
        public const string DBGPSP = "DBGPSP";

        /// <summary>
        /// DBB76FCI.
        /// </summary>
        public const string DBB76FCI = "DBB76FCI";

        /// <summary>
        /// DBB76VAIND.
        /// </summary>
        public const string DBB76VAIND = "DBB76VAIND";

        /// <summary>
        /// DBGPTX.
        /// </summary>
        public const string DBGPTX = "DBGPTX";

        /// <summary>
        /// DBB76NUM.
        /// </summary>
        public const string DBB76NUM = "DBB76NUM";

        /// <summary>
        /// DBB76AA.
        /// </summary>
        public const string DBB76AA = "DBB76AA";

        /// <summary>
        /// DBB76REF.
        /// </summary>
        public const string DBB76REF = "DBB76REF";

        /// <summary>
        /// DBB76COD.
        /// </summary>
        public const string DBB76COD = "DBB76COD";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBJOBN.
        /// </summary>
        public const string DBJOBN = "DBJOBN";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

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
    public override string TableName => "F76B0071";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBGPBT", "DBGPBT", JdeDataType.Numeric, null, true, true),
        new JdeField("DBGPTN", "DBGPTN", JdeDataType.String, 28, true, true),
        new JdeField("DBLIN", "DBLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("DBGPSP", "DBGPSP", JdeDataType.String, 2),
        new JdeField("DBB76FCI", "DBB76FCI", JdeDataType.String, 100),
        new JdeField("DBB76VAIND", "DBB76VAIND", JdeDataType.String, 40),
        new JdeField("DBGPTX", "DBGPTX", JdeDataType.String, 3000),
        new JdeField("DBB76NUM", "DBB76NUM", JdeDataType.Numeric),
        new JdeField("DBB76AA", "DBB76AA", JdeDataType.Numeric),
        new JdeField("DBB76REF", "DBB76REF", JdeDataType.String, 30),
        new JdeField("DBB76COD", "DBB76COD", JdeDataType.String, 4),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBUPMT", "DBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0071_0", "Primary Key on DBGPBT, DBGPTN, DBLIN", new[] { "DBGPBT", "DBGPTN", "DBLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
