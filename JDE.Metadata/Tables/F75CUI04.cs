using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75CUI04 - .
/// </summary>
public class F75CUI04 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFCO.
        /// </summary>
        public const string WFCO = "WFCO";

        /// <summary>
        /// WFC75NAC.
        /// </summary>
        public const string WFC75NAC = "WFC75NAC";

        /// <summary>
        /// WFDL01.
        /// </summary>
        public const string WFDL01 = "WFDL01";

        /// <summary>
        /// WFDL02.
        /// </summary>
        public const string WFDL02 = "WFDL02";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75CUI04";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFCO", "WFCO", JdeDataType.String, 10, true, true),
        new JdeField("WFC75NAC", "WFC75NAC", JdeDataType.String, 60, true, true),
        new JdeField("WFDL01", "WFDL01", JdeDataType.String, 60, true, true),
        new JdeField("WFDL02", "WFDL02", JdeDataType.String, 60, true, true),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75CUI04_0", "Primary Key on WFCO, WFC75NAC, WFDL01, WFDL02", new[] { "WFCO", "WFC75NAC", "WFDL01", "WFDL02" }, isUnique: true, isPrimaryKey: true)
    };
}
