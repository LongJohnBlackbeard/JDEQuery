using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B011 - .
/// </summary>
public class F76B011 : JdeTable
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
        /// TDBRTX.
        /// </summary>
        public const string TDBRTX = "TDBRTX";

        /// <summary>
        /// TDBRTX2.
        /// </summary>
        public const string TDBRTX2 = "TDBRTX2";

        /// <summary>
        /// TDBRTXB.
        /// </summary>
        public const string TDBRTXB = "TDBRTXB";

        /// <summary>
        /// TDBRTXA.
        /// </summary>
        public const string TDBRTXA = "TDBRTXA";

        /// <summary>
        /// TDBRTXR.
        /// </summary>
        public const string TDBRTXR = "TDBRTXR";

        /// <summary>
        /// TDBRPF.
        /// </summary>
        public const string TDBRPF = "TDBRPF";

        /// <summary>
        /// TDC1FU.
        /// </summary>
        public const string TDC1FU = "TDC1FU";

        /// <summary>
        /// TDC2FU.
        /// </summary>
        public const string TDC2FU = "TDC2FU";

        /// <summary>
        /// TDD1FU.
        /// </summary>
        public const string TDD1FU = "TDD1FU";

        /// <summary>
        /// TDD2FU.
        /// </summary>
        public const string TDD2FU = "TDD2FU";

        /// <summary>
        /// TDR1FU.
        /// </summary>
        public const string TDR1FU = "TDR1FU";

        /// <summary>
        /// TDN1FU.
        /// </summary>
        public const string TDN1FU = "TDN1FU";

        /// <summary>
        /// TDN8FU.
        /// </summary>
        public const string TDN8FU = "TDN8FU";

        /// <summary>
        /// TDN9FU.
        /// </summary>
        public const string TDN9FU = "TDN9FU";

        /// <summary>
        /// TDN10FU.
        /// </summary>
        public const string TDN10FU = "TDN10FU";

        /// <summary>
        /// TDN4FU.
        /// </summary>
        public const string TDN4FU = "TDN4FU";

        /// <summary>
        /// TDS1FU.
        /// </summary>
        public const string TDS1FU = "TDS1FU";

        /// <summary>
        /// TDS3FU.
        /// </summary>
        public const string TDS3FU = "TDS3FU";

        /// <summary>
        /// TDGENLNG.
        /// </summary>
        public const string TDGENLNG = "TDGENLNG";

        /// <summary>
        /// TDTORG.
        /// </summary>
        public const string TDTORG = "TDTORG";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDBN01.
        /// </summary>
        public const string TDBN01 = "TDBN01";

        /// <summary>
        /// TDICUT.
        /// </summary>
        public const string TDICUT = "TDICUT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B011";

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
        new JdeField("TDBRTX", "TDBRTX", JdeDataType.String, 4, true, true),
        new JdeField("TDBRTX2", "TDBRTX2", JdeDataType.String, 16),
        new JdeField("TDBRTXB", "TDBRTXB", JdeDataType.Numeric),
        new JdeField("TDBRTXA", "TDBRTXA", JdeDataType.Numeric),
        new JdeField("TDBRTXR", "TDBRTXR", JdeDataType.Numeric),
        new JdeField("TDBRPF", "TDBRPF", JdeDataType.String, 2),
        new JdeField("TDC1FU", "TDC1FU", JdeDataType.String, 2),
        new JdeField("TDC2FU", "TDC2FU", JdeDataType.String, 2),
        new JdeField("TDD1FU", "TDD1FU", JdeDataType.Numeric),
        new JdeField("TDD2FU", "TDD2FU", JdeDataType.Numeric),
        new JdeField("TDR1FU", "TDR1FU", JdeDataType.Numeric),
        new JdeField("TDN1FU", "TDN1FU", JdeDataType.Numeric),
        new JdeField("TDN8FU", "TDN8FU", JdeDataType.Numeric),
        new JdeField("TDN9FU", "TDN9FU", JdeDataType.Numeric),
        new JdeField("TDN10FU", "TDN10FU", JdeDataType.Numeric),
        new JdeField("TDN4FU", "TDN4FU", JdeDataType.Numeric),
        new JdeField("TDS1FU", "TDS1FU", JdeDataType.String, 60),
        new JdeField("TDS3FU", "TDS3FU", JdeDataType.String, 6),
        new JdeField("TDGENLNG", "TDGENLNG", JdeDataType.Numeric),
        new JdeField("TDTORG", "TDTORG", JdeDataType.String, 20),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDBN01", "TDBN01", JdeDataType.Numeric),
        new JdeField("TDICUT", "TDICUT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B011_0", "Primary Key on TDBNNF, TDBSER, TDN001, TDDCT, TDUKID, TDBRTX", new[] { "TDBNNF", "TDBSER", "TDN001", "TDDCT", "TDUKID", "TDBRTX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B011_2", "Index on TDBN01, TDICUT", new[] { "TDBN01", "TDICUT" })
    };
}
