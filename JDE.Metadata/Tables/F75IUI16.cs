using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI16 - .
/// </summary>
public class F75IUI16 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFPRNB.
        /// </summary>
        public const string WFPRNB = "WFPRNB";

        /// <summary>
        /// WFLNMB.
        /// </summary>
        public const string WFLNMB = "WFLNMB";

        /// <summary>
        /// WFEFTJ.
        /// </summary>
        public const string WFEFTJ = "WFEFTJ";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFI75CGSTR.
        /// </summary>
        public const string WFI75CGSTR = "WFI75CGSTR";

        /// <summary>
        /// WFI75SGSTR.
        /// </summary>
        public const string WFI75SGSTR = "WFI75SGSTR";

        /// <summary>
        /// WFI75IGSTR.
        /// </summary>
        public const string WFI75IGSTR = "WFI75IGSTR";

        /// <summary>
        /// WFI75CESSR.
        /// </summary>
        public const string WFI75CESSR = "WFI75CESSR";

        /// <summary>
        /// WFI75CATTY.
        /// </summary>
        public const string WFI75CATTY = "WFI75CATTY";

        /// <summary>
        /// WFI75CATVL.
        /// </summary>
        public const string WFI75CATVL = "WFI75CATVL";

        /// <summary>
        /// WFI75CATDS.
        /// </summary>
        public const string WFI75CATDS = "WFI75CATDS";

        /// <summary>
        /// WFI75CATCO.
        /// </summary>
        public const string WFI75CATCO = "WFI75CATCO";

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
    public override string TableName => "F75IUI16";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFPRNB", "WFPRNB", JdeDataType.Numeric, null, true, true),
        new JdeField("WFLNMB", "WFLNMB", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEFTJ", "WFEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFI75CGSTR", "WFI75CGSTR", JdeDataType.Numeric),
        new JdeField("WFI75SGSTR", "WFI75SGSTR", JdeDataType.Numeric),
        new JdeField("WFI75IGSTR", "WFI75IGSTR", JdeDataType.Numeric),
        new JdeField("WFI75CESSR", "WFI75CESSR", JdeDataType.Numeric),
        new JdeField("WFI75CATTY", "WFI75CATTY", JdeDataType.String, 6),
        new JdeField("WFI75CATVL", "WFI75CATVL", JdeDataType.String, 40),
        new JdeField("WFI75CATDS", "WFI75CATDS", JdeDataType.String, 60),
        new JdeField("WFI75CATCO", "WFI75CATCO", JdeDataType.Numeric),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20, true, true),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI16_0", "Primary Key on WFPRNB, WFLNMB, WFEFTJ, WFJOBS, WFUSER", new[] { "WFPRNB", "WFLNMB", "WFEFTJ", "WFJOBS", "WFUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75IUI16_2", "Index on WFJOBS, WFUSER", new[] { "WFJOBS", "WFUSER" })
    };
}
