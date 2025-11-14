using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B1010 - .
/// </summary>
public class F76B1010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDBNNF.
        /// </summary>
        public const string TDBNNF = "TDBNNF";

        /// <summary>
        /// TDBSER.
        /// </summary>
        public const string TDBSER = "TDBSER";

        /// <summary>
        /// TDN001.
        /// </summary>
        public const string TDN001 = "TDN001";

        /// <summary>
        /// TDDCT.
        /// </summary>
        public const string TDDCT = "TDDCT";

        /// <summary>
        /// TDUKID.
        /// </summary>
        public const string TDUKID = "TDUKID";

        /// <summary>
        /// TDB76CI.
        /// </summary>
        public const string TDB76CI = "TDB76CI";

        /// <summary>
        /// TDB76FCI.
        /// </summary>
        public const string TDB76FCI = "TDB76FCI";

        /// <summary>
        /// TDB76TIPI.
        /// </summary>
        public const string TDB76TIPI = "TDB76TIPI";

        /// <summary>
        /// TDB76SRCE.
        /// </summary>
        public const string TDB76SRCE = "TDB76SRCE";

        /// <summary>
        /// TDTXR1.
        /// </summary>
        public const string TDTXR1 = "TDTXR1";

        /// <summary>
        /// TDCRCD.
        /// </summary>
        public const string TDCRCD = "TDCRCD";

        /// <summary>
        /// TDB76TAL.
        /// </summary>
        public const string TDB76TAL = "TDB76TAL";

        /// <summary>
        /// TDB76TABL.
        /// </summary>
        public const string TDB76TABL = "TDB76TABL";

        /// <summary>
        /// TDB76NUM.
        /// </summary>
        public const string TDB76NUM = "TDB76NUM";

        /// <summary>
        /// TDB76AA.
        /// </summary>
        public const string TDB76AA = "TDB76AA";

        /// <summary>
        /// TDB76REF.
        /// </summary>
        public const string TDB76REF = "TDB76REF";

        /// <summary>
        /// TDB76COD.
        /// </summary>
        public const string TDB76COD = "TDB76COD";

        /// <summary>
        /// TDB76DATE.
        /// </summary>
        public const string TDB76DATE = "TDB76DATE";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B1010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDBNNF", "TDBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("TDBSER", "TDBSER", JdeDataType.String, 4, true, true),
        new JdeField("TDN001", "TDN001", JdeDataType.Numeric, null, true, true),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4, true, true),
        new JdeField("TDUKID", "TDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDB76CI", "TDB76CI", JdeDataType.Numeric),
        new JdeField("TDB76FCI", "TDB76FCI", JdeDataType.String, 100),
        new JdeField("TDB76TIPI", "TDB76TIPI", JdeDataType.String, 6),
        new JdeField("TDB76SRCE", "TDB76SRCE", JdeDataType.String, 200),
        new JdeField("TDTXR1", "TDTXR1", JdeDataType.Numeric),
        new JdeField("TDCRCD", "TDCRCD", JdeDataType.String, 6),
        new JdeField("TDB76TAL", "TDB76TAL", JdeDataType.Numeric),
        new JdeField("TDB76TABL", "TDB76TABL", JdeDataType.Numeric),
        new JdeField("TDB76NUM", "TDB76NUM", JdeDataType.Numeric),
        new JdeField("TDB76AA", "TDB76AA", JdeDataType.Numeric),
        new JdeField("TDB76REF", "TDB76REF", JdeDataType.String, 30),
        new JdeField("TDB76COD", "TDB76COD", JdeDataType.String, 4),
        new JdeField("TDB76DATE", "TDB76DATE", JdeDataType.Numeric),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B1010_0", "Primary Key on TDBNNF, TDBSER, TDN001, TDDCT, TDUKID", new[] { "TDBNNF", "TDBSER", "TDN001", "TDDCT", "TDUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
