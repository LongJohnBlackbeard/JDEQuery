using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4550 - .
/// </summary>
public class F4550 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BHPRGR.
        /// </summary>
        public const string BHPRGR = "BHPRGR";

        /// <summary>
        /// BHDL01.
        /// </summary>
        public const string BHDL01 = "BHDL01";

        /// <summary>
        /// BHUOM.
        /// </summary>
        public const string BHUOM = "BHUOM";

        /// <summary>
        /// BHURCD.
        /// </summary>
        public const string BHURCD = "BHURCD";

        /// <summary>
        /// BHURDT.
        /// </summary>
        public const string BHURDT = "BHURDT";

        /// <summary>
        /// BHURAT.
        /// </summary>
        public const string BHURAT = "BHURAT";

        /// <summary>
        /// BHURAB.
        /// </summary>
        public const string BHURAB = "BHURAB";

        /// <summary>
        /// BHURRF.
        /// </summary>
        public const string BHURRF = "BHURRF";

        /// <summary>
        /// BHUSER.
        /// </summary>
        public const string BHUSER = "BHUSER";

        /// <summary>
        /// BHPID.
        /// </summary>
        public const string BHPID = "BHPID";

        /// <summary>
        /// BHJOBN.
        /// </summary>
        public const string BHJOBN = "BHJOBN";

        /// <summary>
        /// BHUPMJ.
        /// </summary>
        public const string BHUPMJ = "BHUPMJ";

        /// <summary>
        /// BHTDAY.
        /// </summary>
        public const string BHTDAY = "BHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4550";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHPRGR", "BHPRGR", JdeDataType.String, 16, true, true),
        new JdeField("BHDL01", "BHDL01", JdeDataType.String, 60),
        new JdeField("BHUOM", "BHUOM", JdeDataType.String, 4),
        new JdeField("BHURCD", "BHURCD", JdeDataType.String, 4),
        new JdeField("BHURDT", "BHURDT", JdeDataType.Numeric),
        new JdeField("BHURAT", "BHURAT", JdeDataType.Numeric),
        new JdeField("BHURAB", "BHURAB", JdeDataType.Numeric),
        new JdeField("BHURRF", "BHURRF", JdeDataType.String, 30),
        new JdeField("BHUSER", "BHUSER", JdeDataType.String, 20),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20),
        new JdeField("BHJOBN", "BHJOBN", JdeDataType.String, 20),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHTDAY", "BHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4550_0", "Primary Key on BHPRGR", new[] { "BHPRGR" }, isUnique: true, isPrimaryKey: true)
    };
}
