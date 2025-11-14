using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B1001 - .
/// </summary>
public class F76B1001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THBNNF.
        /// </summary>
        public const string THBNNF = "THBNNF";

        /// <summary>
        /// THBSER.
        /// </summary>
        public const string THBSER = "THBSER";

        /// <summary>
        /// THN001.
        /// </summary>
        public const string THN001 = "THN001";

        /// <summary>
        /// THDCT.
        /// </summary>
        public const string THDCT = "THDCT";

        /// <summary>
        /// THB76BICC.
        /// </summary>
        public const string THB76BICC = "THB76BICC";

        /// <summary>
        /// THB76SRCE.
        /// </summary>
        public const string THB76SRCE = "THB76SRCE";

        /// <summary>
        /// THTXR1.
        /// </summary>
        public const string THTXR1 = "THTXR1";

        /// <summary>
        /// THCRCD.
        /// </summary>
        public const string THCRCD = "THCRCD";

        /// <summary>
        /// THB76TAH.
        /// </summary>
        public const string THB76TAH = "THB76TAH";

        /// <summary>
        /// THB76TABH.
        /// </summary>
        public const string THB76TABH = "THB76TABH";

        /// <summary>
        /// THB76NUM.
        /// </summary>
        public const string THB76NUM = "THB76NUM";

        /// <summary>
        /// THB76AA.
        /// </summary>
        public const string THB76AA = "THB76AA";

        /// <summary>
        /// THB76REF.
        /// </summary>
        public const string THB76REF = "THB76REF";

        /// <summary>
        /// THB76COD.
        /// </summary>
        public const string THB76COD = "THB76COD";

        /// <summary>
        /// THB76DATE.
        /// </summary>
        public const string THB76DATE = "THB76DATE";

        /// <summary>
        /// THUSER.
        /// </summary>
        public const string THUSER = "THUSER";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THB76PPI.
        /// </summary>
        public const string THB76PPI = "THB76PPI";

        /// <summary>
        /// THB76INTRM.
        /// </summary>
        public const string THB76INTRM = "THB76INTRM";

        /// <summary>
        /// THB76CNPJ.
        /// </summary>
        public const string THB76CNPJ = "THB76CNPJ";

        /// <summary>
        /// THB76INTDC.
        /// </summary>
        public const string THB76INTDC = "THB76INTDC";

        /// <summary>
        /// THB76NUM1.
        /// </summary>
        public const string THB76NUM1 = "THB76NUM1";

        /// <summary>
        /// THB76STR1.
        /// </summary>
        public const string THB76STR1 = "THB76STR1";

        /// <summary>
        /// THB76DATE1.
        /// </summary>
        public const string THB76DATE1 = "THB76DATE1";
    }

    /// <inheritdoc />
    public override string TableName => "F76B1001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THBNNF", "THBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("THBSER", "THBSER", JdeDataType.String, 4, true, true),
        new JdeField("THN001", "THN001", JdeDataType.Numeric, null, true, true),
        new JdeField("THDCT", "THDCT", JdeDataType.String, 4, true, true),
        new JdeField("THB76BICC", "THB76BICC", JdeDataType.String, 2),
        new JdeField("THB76SRCE", "THB76SRCE", JdeDataType.String, 200),
        new JdeField("THTXR1", "THTXR1", JdeDataType.Numeric),
        new JdeField("THCRCD", "THCRCD", JdeDataType.String, 6),
        new JdeField("THB76TAH", "THB76TAH", JdeDataType.Numeric),
        new JdeField("THB76TABH", "THB76TABH", JdeDataType.Numeric),
        new JdeField("THB76NUM", "THB76NUM", JdeDataType.Numeric),
        new JdeField("THB76AA", "THB76AA", JdeDataType.Numeric),
        new JdeField("THB76REF", "THB76REF", JdeDataType.String, 30),
        new JdeField("THB76COD", "THB76COD", JdeDataType.String, 4),
        new JdeField("THB76DATE", "THB76DATE", JdeDataType.Numeric),
        new JdeField("THUSER", "THUSER", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THB76PPI", "THB76PPI", JdeDataType.String, 4),
        new JdeField("THB76INTRM", "THB76INTRM", JdeDataType.String, 2),
        new JdeField("THB76CNPJ", "THB76CNPJ", JdeDataType.Numeric),
        new JdeField("THB76INTDC", "THB76INTDC", JdeDataType.String, 120),
        new JdeField("THB76NUM1", "THB76NUM1", JdeDataType.Numeric),
        new JdeField("THB76STR1", "THB76STR1", JdeDataType.String, 30),
        new JdeField("THB76DATE1", "THB76DATE1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B1001_0", "Primary Key on THBNNF, THBSER, THN001, THDCT", new[] { "THBNNF", "THBSER", "THN001", "THDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
