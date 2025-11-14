using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B30 - .
/// </summary>
public class F76H3B30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTH76IDFR.
        /// </summary>
        public const string PTH76IDFR = "PTH76IDFR";

        /// <summary>
        /// PTDL01.
        /// </summary>
        public const string PTDL01 = "PTDL01";

        /// <summary>
        /// PTEV01.
        /// </summary>
        public const string PTEV01 = "PTEV01";

        /// <summary>
        /// PTH76NL1.
        /// </summary>
        public const string PTH76NL1 = "PTH76NL1";

        /// <summary>
        /// PTH76TNL.
        /// </summary>
        public const string PTH76TNL = "PTH76TNL";

        /// <summary>
        /// PTEV02.
        /// </summary>
        public const string PTEV02 = "PTEV02";

        /// <summary>
        /// PTH76NL2.
        /// </summary>
        public const string PTH76NL2 = "PTH76NL2";

        /// <summary>
        /// PTH76LL.
        /// </summary>
        public const string PTH76LL = "PTH76LL";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTUPMT.
        /// </summary>
        public const string PTUPMT = "PTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTH76IDFR", "PTH76IDFR", JdeDataType.String, 6, true, true),
        new JdeField("PTDL01", "PTDL01", JdeDataType.String, 60),
        new JdeField("PTEV01", "PTEV01", JdeDataType.String, 2),
        new JdeField("PTH76NL1", "PTH76NL1", JdeDataType.Numeric),
        new JdeField("PTH76TNL", "PTH76TNL", JdeDataType.Numeric),
        new JdeField("PTEV02", "PTEV02", JdeDataType.String, 2),
        new JdeField("PTH76NL2", "PTH76NL2", JdeDataType.Numeric),
        new JdeField("PTH76LL", "PTH76LL", JdeDataType.Numeric),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTUPMT", "PTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B30_0", "Primary Key on PTH76IDFR", new[] { "PTH76IDFR" }, isUnique: true, isPrimaryKey: true)
    };
}
