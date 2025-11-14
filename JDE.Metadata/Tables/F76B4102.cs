using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4102 - .
/// </summary>
public class F76B4102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBITM.
        /// </summary>
        public const string IBITM = "IBITM";

        /// <summary>
        /// IBMCU.
        /// </summary>
        public const string IBMCU = "IBMCU";

        /// <summary>
        /// IBLOCN.
        /// </summary>
        public const string IBLOCN = "IBLOCN";

        /// <summary>
        /// IBLOTN.
        /// </summary>
        public const string IBLOTN = "IBLOTN";

        /// <summary>
        /// IBB76CI.
        /// </summary>
        public const string IBB76CI = "IBB76CI";

        /// <summary>
        /// IBB76FCI.
        /// </summary>
        public const string IBB76FCI = "IBB76FCI";

        /// <summary>
        /// IBB76VPA.
        /// </summary>
        public const string IBB76VPA = "IBB76VPA";

        /// <summary>
        /// IBB76TVIO.
        /// </summary>
        public const string IBB76TVIO = "IBB76TVIO";

        /// <summary>
        /// IBB76TIPI.
        /// </summary>
        public const string IBB76TIPI = "IBB76TIPI";

        /// <summary>
        /// IBCRCD.
        /// </summary>
        public const string IBCRCD = "IBCRCD";

        /// <summary>
        /// IBB76NUM.
        /// </summary>
        public const string IBB76NUM = "IBB76NUM";

        /// <summary>
        /// IBB76AA.
        /// </summary>
        public const string IBB76AA = "IBB76AA";

        /// <summary>
        /// IBB76REF.
        /// </summary>
        public const string IBB76REF = "IBB76REF";

        /// <summary>
        /// IBB76COD.
        /// </summary>
        public const string IBB76COD = "IBB76COD";

        /// <summary>
        /// IBB76DATE.
        /// </summary>
        public const string IBB76DATE = "IBB76DATE";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBUPMJ.
        /// </summary>
        public const string IBUPMJ = "IBUPMJ";

        /// <summary>
        /// IBUPMT.
        /// </summary>
        public const string IBUPMT = "IBUPMT";

        /// <summary>
        /// IBJOBN.
        /// </summary>
        public const string IBJOBN = "IBJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBITM", "IBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IBMCU", "IBMCU", JdeDataType.String, 24, true, true),
        new JdeField("IBLOCN", "IBLOCN", JdeDataType.String, 40, true, true),
        new JdeField("IBLOTN", "IBLOTN", JdeDataType.String, 60, true, true),
        new JdeField("IBB76CI", "IBB76CI", JdeDataType.Numeric),
        new JdeField("IBB76FCI", "IBB76FCI", JdeDataType.String, 100),
        new JdeField("IBB76VPA", "IBB76VPA", JdeDataType.Numeric),
        new JdeField("IBB76TVIO", "IBB76TVIO", JdeDataType.Numeric),
        new JdeField("IBB76TIPI", "IBB76TIPI", JdeDataType.String, 6),
        new JdeField("IBCRCD", "IBCRCD", JdeDataType.String, 6),
        new JdeField("IBB76NUM", "IBB76NUM", JdeDataType.Numeric),
        new JdeField("IBB76AA", "IBB76AA", JdeDataType.Numeric),
        new JdeField("IBB76REF", "IBB76REF", JdeDataType.String, 30),
        new JdeField("IBB76COD", "IBB76COD", JdeDataType.String, 4),
        new JdeField("IBB76DATE", "IBB76DATE", JdeDataType.Numeric),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBUPMJ", "IBUPMJ", JdeDataType.Numeric),
        new JdeField("IBUPMT", "IBUPMT", JdeDataType.Numeric),
        new JdeField("IBJOBN", "IBJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4102_0", "Primary Key on IBITM, IBMCU, IBLOCN, IBLOTN", new[] { "IBITM", "IBMCU", "IBLOCN", "IBLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
