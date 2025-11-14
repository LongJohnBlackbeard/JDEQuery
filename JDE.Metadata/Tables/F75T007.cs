using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T007 - .
/// </summary>
public class F75T007 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MDCO.
        /// </summary>
        public const string MDCO = "MDCO";

        /// <summary>
        /// MD75TDSI.
        /// </summary>
        public const string MD75TDSI = "MD75TDSI";

        /// <summary>
        /// MD75TYMD.
        /// </summary>
        public const string MD75TYMD = "MD75TYMD";

        /// <summary>
        /// MD75TGFC.
        /// </summary>
        public const string MD75TGFC = "MD75TGFC";

        /// <summary>
        /// MD75TTID.
        /// </summary>
        public const string MD75TTID = "MD75TTID";

        /// <summary>
        /// MD75TFSN.
        /// </summary>
        public const string MD75TFSN = "MD75TFSN";

        /// <summary>
        /// MD75TFYM.
        /// </summary>
        public const string MD75TFYM = "MD75TFYM";

        /// <summary>
        /// MD75TSUN.
        /// </summary>
        public const string MD75TSUN = "MD75TSUN";

        /// <summary>
        /// MD75TVUN.
        /// </summary>
        public const string MD75TVUN = "MD75TVUN";

        /// <summary>
        /// MD75TTNF.
        /// </summary>
        public const string MD75TTNF = "MD75TTNF";

        /// <summary>
        /// MD75TFSA.
        /// </summary>
        public const string MD75TFSA = "MD75TFSA";

        /// <summary>
        /// MD75TTXT.
        /// </summary>
        public const string MD75TTXT = "MD75TTXT";

        /// <summary>
        /// MD75TFTX.
        /// </summary>
        public const string MD75TFTX = "MD75TFTX";

        /// <summary>
        /// MD75TDDC.
        /// </summary>
        public const string MD75TDDC = "MD75TDDC";

        /// <summary>
        /// MD75TFRM.
        /// </summary>
        public const string MD75TFRM = "MD75TFRM";

        /// <summary>
        /// MD75TSMN.
        /// </summary>
        public const string MD75TSMN = "MD75TSMN";

        /// <summary>
        /// MD75TFCW.
        /// </summary>
        public const string MD75TFCW = "MD75TFCW";

        /// <summary>
        /// MDUSER.
        /// </summary>
        public const string MDUSER = "MDUSER";

        /// <summary>
        /// MDPID.
        /// </summary>
        public const string MDPID = "MDPID";

        /// <summary>
        /// MDJOBN.
        /// </summary>
        public const string MDJOBN = "MDJOBN";

        /// <summary>
        /// MDUPMJ.
        /// </summary>
        public const string MDUPMJ = "MDUPMJ";

        /// <summary>
        /// MDTDAY.
        /// </summary>
        public const string MDTDAY = "MDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T007";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MDCO", "MDCO", JdeDataType.String, 10, true, true),
        new JdeField("MD75TDSI", "MD75TDSI", JdeDataType.String, 10, true, true),
        new JdeField("MD75TYMD", "MD75TYMD", JdeDataType.Numeric, null, true, true),
        new JdeField("MD75TGFC", "MD75TGFC", JdeDataType.String, 4),
        new JdeField("MD75TTID", "MD75TTID", JdeDataType.String, 18),
        new JdeField("MD75TFSN", "MD75TFSN", JdeDataType.String, 14, true, true),
        new JdeField("MD75TFYM", "MD75TFYM", JdeDataType.String, 12),
        new JdeField("MD75TSUN", "MD75TSUN", JdeDataType.String, 16),
        new JdeField("MD75TVUN", "MD75TVUN", JdeDataType.String, 16),
        new JdeField("MD75TTNF", "MD75TTNF", JdeDataType.String, 40),
        new JdeField("MD75TFSA", "MD75TFSA", JdeDataType.String, 24),
        new JdeField("MD75TTXT", "MD75TTXT", JdeDataType.String, 2),
        new JdeField("MD75TFTX", "MD75TFTX", JdeDataType.String, 20),
        new JdeField("MD75TDDC", "MD75TDDC", JdeDataType.String, 2),
        new JdeField("MD75TFRM", "MD75TFRM", JdeDataType.String, 12),
        new JdeField("MD75TSMN", "MD75TSMN", JdeDataType.String, 2),
        new JdeField("MD75TFCW", "MD75TFCW", JdeDataType.String, 2),
        new JdeField("MDUSER", "MDUSER", JdeDataType.String, 20),
        new JdeField("MDPID", "MDPID", JdeDataType.String, 20),
        new JdeField("MDJOBN", "MDJOBN", JdeDataType.String, 20),
        new JdeField("MDUPMJ", "MDUPMJ", JdeDataType.Numeric),
        new JdeField("MDTDAY", "MDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T007_0", "Primary Key on MDCO, MD75TDSI, MD75TYMD, MD75TFSN", new[] { "MDCO", "MD75TDSI", "MD75TYMD", "MD75TFSN" }, isUnique: true, isPrimaryKey: true)
    };
}
