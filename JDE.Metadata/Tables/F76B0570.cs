using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0570 - .
/// </summary>
public class F76B0570 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFBRANFK.
        /// </summary>
        public const string WFBRANFK = "WFBRANFK";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFBNNF.
        /// </summary>
        public const string WFBNNF = "WFBNNF";

        /// <summary>
        /// WFBSER.
        /// </summary>
        public const string WFBSER = "WFBSER";

        /// <summary>
        /// WFN001.
        /// </summary>
        public const string WFN001 = "WFN001";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFUKID.
        /// </summary>
        public const string WFUKID = "WFUKID";

        /// <summary>
        /// WFBRAOB2.
        /// </summary>
        public const string WFBRAOB2 = "WFBRAOB2";

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
    public override string TableName => "F76B0570";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFBRANFK", "WFBRANFK", JdeDataType.Numeric, null, true, true),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFBNNF", "WFBNNF", JdeDataType.Numeric),
        new JdeField("WFBSER", "WFBSER", JdeDataType.String, 4),
        new JdeField("WFN001", "WFN001", JdeDataType.Numeric),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4),
        new JdeField("WFUKID", "WFUKID", JdeDataType.Numeric),
        new JdeField("WFBRAOB2", "WFBRAOB2", JdeDataType.String, 2),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0570_0", "Primary Key on WFJOBS, WFCTID, WFBRANFK, WFLNID", new[] { "WFJOBS", "WFCTID", "WFBRANFK", "WFLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B0570_2", "Index on WFCTID, WFJOBS, WFBNNF, WFBSER, WFN001, WFDCT, WFUKID", new[] { "WFCTID", "WFJOBS", "WFBNNF", "WFBSER", "WFN001", "WFDCT", "WFUKID" }),
        new JdeIndex("F76B0570_3", "Index on WFJOBS, WFCTID, WFBRANFK, WFLNID, WFBRAOB2", new[] { "WFJOBS", "WFCTID", "WFBRANFK", "WFLNID", "WFBRAOB2" })
    };
}
