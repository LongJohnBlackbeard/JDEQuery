using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI86 - .
/// </summary>
public class F75IUI86 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFSFX.
        /// </summary>
        public const string WFSFX = "WFSFX";

        /// <summary>
        /// WFI75CATCO.
        /// </summary>
        public const string WFI75CATCO = "WFI75CATCO";

        /// <summary>
        /// WFI75CATTY.
        /// </summary>
        public const string WFI75CATTY = "WFI75CATTY";

        /// <summary>
        /// WFI75CATVL.
        /// </summary>
        public const string WFI75CATVL = "WFI75CATVL";

        /// <summary>
        /// WFI75TXRL.
        /// </summary>
        public const string WFI75TXRL = "WFI75TXRL";

        /// <summary>
        /// WFAG.
        /// </summary>
        public const string WFAG = "WFAG";

        /// <summary>
        /// WFDDJ.
        /// </summary>
        public const string WFDDJ = "WFDDJ";

        /// <summary>
        /// WFRMK.
        /// </summary>
        public const string WFRMK = "WFRMK";

        /// <summary>
        /// WFPST.
        /// </summary>
        public const string WFPST = "WFPST";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

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

        /// <summary>
        /// WFYFUTDT1.
        /// </summary>
        public const string WFYFUTDT1 = "WFYFUTDT1";

        /// <summary>
        /// WFFUT6.
        /// </summary>
        public const string WFFUT6 = "WFFUT6";

        /// <summary>
        /// WFYT04.
        /// </summary>
        public const string WFYT04 = "WFYT04";

        /// <summary>
        /// WFYFLAG.
        /// </summary>
        public const string WFYFLAG = "WFYFLAG";

        /// <summary>
        /// WFYNUM1.
        /// </summary>
        public const string WFYNUM1 = "WFYNUM1";

        /// <summary>
        /// WFODOC.
        /// </summary>
        public const string WFODOC = "WFODOC";

        /// <summary>
        /// WFODCT.
        /// </summary>
        public const string WFODCT = "WFODCT";

        /// <summary>
        /// WFOKCO.
        /// </summary>
        public const string WFOKCO = "WFOKCO";

        /// <summary>
        /// WFI75RSMT.
        /// </summary>
        public const string WFI75RSMT = "WFI75RSMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI86";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10, true, true),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4, true, true),
        new JdeField("WFSFX", "WFSFX", JdeDataType.String, 6, true, true),
        new JdeField("WFI75CATCO", "WFI75CATCO", JdeDataType.Numeric),
        new JdeField("WFI75CATTY", "WFI75CATTY", JdeDataType.String, 6),
        new JdeField("WFI75CATVL", "WFI75CATVL", JdeDataType.String, 40),
        new JdeField("WFI75TXRL", "WFI75TXRL", JdeDataType.String, 12),
        new JdeField("WFAG", "WFAG", JdeDataType.Numeric),
        new JdeField("WFDDJ", "WFDDJ", JdeDataType.Numeric),
        new JdeField("WFRMK", "WFRMK", JdeDataType.String, 60),
        new JdeField("WFPST", "WFPST", JdeDataType.String, 2),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20, true, true),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFYFUTDT1", "WFYFUTDT1", JdeDataType.Numeric),
        new JdeField("WFFUT6", "WFFUT6", JdeDataType.String, 60),
        new JdeField("WFYT04", "WFYT04", JdeDataType.String, 2),
        new JdeField("WFYFLAG", "WFYFLAG", JdeDataType.String, 2),
        new JdeField("WFYNUM1", "WFYNUM1", JdeDataType.Numeric),
        new JdeField("WFODOC", "WFODOC", JdeDataType.Numeric),
        new JdeField("WFODCT", "WFODCT", JdeDataType.String, 4),
        new JdeField("WFOKCO", "WFOKCO", JdeDataType.String, 10),
        new JdeField("WFI75RSMT", "WFI75RSMT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI86_0", "Primary Key on WFKCO, WFDOC, WFDCT, WFSFX, WFUSER, WFJOBS", new[] { "WFKCO", "WFDOC", "WFDCT", "WFSFX", "WFUSER", "WFJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
