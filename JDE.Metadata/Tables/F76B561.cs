using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B561 - .
/// </summary>
public class F76B561 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFUKID.
        /// </summary>
        public const string WFUKID = "WFUKID";

        /// <summary>
        /// WFBNNF.
        /// </summary>
        public const string WFBNNF = "WFBNNF";

        /// <summary>
        /// WFBSER.
        /// </summary>
        public const string WFBSER = "WFBSER";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFN001.
        /// </summary>
        public const string WFN001 = "WFN001";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B561";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFUKID", "WFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFBNNF", "WFBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("WFBSER", "WFBSER", JdeDataType.String, 4, true, true),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4, true, true),
        new JdeField("WFN001", "WFN001", JdeDataType.Numeric, null, true, true),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B561_0", "Primary Key on WFUKID, WFBNNF, WFBSER, WFDCT, WFN001", new[] { "WFUKID", "WFBNNF", "WFBSER", "WFDCT", "WFN001" }, isUnique: true, isPrimaryKey: true)
    };
}
