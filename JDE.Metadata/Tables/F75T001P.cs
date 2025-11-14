using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T001P - .
/// </summary>
public class F75T001P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPCO.
        /// </summary>
        public const string DPCO = "DPCO";

        /// <summary>
        /// DP75TDSI.
        /// </summary>
        public const string DP75TDSI = "DP75TDSI";

        /// <summary>
        /// DP75TYMD.
        /// </summary>
        public const string DP75TYMD = "DP75TYMD";

        /// <summary>
        /// DP75TYMP.
        /// </summary>
        public const string DP75TYMP = "DP75TYMP";

        /// <summary>
        /// DP75TYMS.
        /// </summary>
        public const string DP75TYMS = "DP75TYMS";

        /// <summary>
        /// DP75TYMT.
        /// </summary>
        public const string DP75TYMT = "DP75TYMT";

        /// <summary>
        /// DP75TYMPR.
        /// </summary>
        public const string DP75TYMPR = "DP75TYMPR";

        /// <summary>
        /// DP75TYMSR.
        /// </summary>
        public const string DP75TYMSR = "DP75TYMSR";

        /// <summary>
        /// DP75TYMX.
        /// </summary>
        public const string DP75TYMX = "DP75TYMX";

        /// <summary>
        /// DPURC1.
        /// </summary>
        public const string DPURC1 = "DPURC1";

        /// <summary>
        /// DPURDT.
        /// </summary>
        public const string DPURDT = "DPURDT";

        /// <summary>
        /// DPURAT.
        /// </summary>
        public const string DPURAT = "DPURAT";

        /// <summary>
        /// DPURAB.
        /// </summary>
        public const string DPURAB = "DPURAB";

        /// <summary>
        /// DPURRF.
        /// </summary>
        public const string DPURRF = "DPURRF";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPJOBN.
        /// </summary>
        public const string DPJOBN = "DPJOBN";

        /// <summary>
        /// DPUPMJ.
        /// </summary>
        public const string DPUPMJ = "DPUPMJ";

        /// <summary>
        /// DPTDAY.
        /// </summary>
        public const string DPTDAY = "DPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75T001P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPCO", "DPCO", JdeDataType.String, 10, true, true),
        new JdeField("DP75TDSI", "DP75TDSI", JdeDataType.String, 10, true, true),
        new JdeField("DP75TYMD", "DP75TYMD", JdeDataType.Numeric, null, true, true),
        new JdeField("DP75TYMP", "DP75TYMP", JdeDataType.Numeric),
        new JdeField("DP75TYMS", "DP75TYMS", JdeDataType.Numeric),
        new JdeField("DP75TYMT", "DP75TYMT", JdeDataType.Numeric),
        new JdeField("DP75TYMPR", "DP75TYMPR", JdeDataType.Numeric),
        new JdeField("DP75TYMSR", "DP75TYMSR", JdeDataType.Numeric),
        new JdeField("DP75TYMX", "DP75TYMX", JdeDataType.Numeric),
        new JdeField("DPURC1", "DPURC1", JdeDataType.String, 6),
        new JdeField("DPURDT", "DPURDT", JdeDataType.Numeric),
        new JdeField("DPURAT", "DPURAT", JdeDataType.Numeric),
        new JdeField("DPURAB", "DPURAB", JdeDataType.Numeric),
        new JdeField("DPURRF", "DPURRF", JdeDataType.String, 30),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPJOBN", "DPJOBN", JdeDataType.String, 20),
        new JdeField("DPUPMJ", "DPUPMJ", JdeDataType.Numeric),
        new JdeField("DPTDAY", "DPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T001P_0", "Primary Key on DPCO, DP75TDSI, DP75TYMD", new[] { "DPCO", "DP75TDSI", "DP75TYMD" }, isUnique: true, isPrimaryKey: true)
    };
}
