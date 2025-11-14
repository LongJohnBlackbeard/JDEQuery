using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI93 - .
/// </summary>
public class F75IUI93 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFDOCO.
        /// </summary>
        public const string WFDOCO = "WFDOCO";

        /// <summary>
        /// WFDCTO.
        /// </summary>
        public const string WFDCTO = "WFDCTO";

        /// <summary>
        /// WFKCOO.
        /// </summary>
        public const string WFKCOO = "WFKCOO";

        /// <summary>
        /// WFSFXO.
        /// </summary>
        public const string WFSFXO = "WFSFXO";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFUITM.
        /// </summary>
        public const string WFUITM = "WFUITM";

        /// <summary>
        /// WFI75ITTY.
        /// </summary>
        public const string WFI75ITTY = "WFI75ITTY";

        /// <summary>
        /// WFI75CATTY.
        /// </summary>
        public const string WFI75CATTY = "WFI75CATTY";

        /// <summary>
        /// WFI75CATVL.
        /// </summary>
        public const string WFI75CATVL = "WFI75CATVL";

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
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

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
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI93";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFDOCO", "WFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WFDCTO", "WFDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WFKCOO", "WFKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WFSFXO", "WFSFXO", JdeDataType.String, 6, true, true),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFUITM", "WFUITM", JdeDataType.String, 52),
        new JdeField("WFI75ITTY", "WFI75ITTY", JdeDataType.String, 12),
        new JdeField("WFI75CATTY", "WFI75CATTY", JdeDataType.String, 6),
        new JdeField("WFI75CATVL", "WFI75CATVL", JdeDataType.String, 40),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20, true, true),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFYFUTDT1", "WFYFUTDT1", JdeDataType.Numeric),
        new JdeField("WFFUT6", "WFFUT6", JdeDataType.String, 60),
        new JdeField("WFYT04", "WFYT04", JdeDataType.String, 2),
        new JdeField("WFYFLAG", "WFYFLAG", JdeDataType.String, 2),
        new JdeField("WFYNUM1", "WFYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI93_0", "Primary Key on WFDOCO, WFDCTO, WFKCOO, WFSFXO, WFLNID, WFJOBS, WFUSER", new[] { "WFDOCO", "WFDCTO", "WFKCOO", "WFSFXO", "WFLNID", "WFJOBS", "WFUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
