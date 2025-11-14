using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05100Z1 - .
/// </summary>
public class F05100Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CUEDUS.
        /// </summary>
        public const string CUEDUS = "CUEDUS";

        /// <summary>
        /// CUEDBT.
        /// </summary>
        public const string CUEDBT = "CUEDBT";

        /// <summary>
        /// CUEDTN.
        /// </summary>
        public const string CUEDTN = "CUEDTN";

        /// <summary>
        /// CUEDLN.
        /// </summary>
        public const string CUEDLN = "CUEDLN";

        /// <summary>
        /// CUEDDT.
        /// </summary>
        public const string CUEDDT = "CUEDDT";

        /// <summary>
        /// CUEDITIME.
        /// </summary>
        public const string CUEDITIME = "CUEDITIME";

        /// <summary>
        /// CUEDSP.
        /// </summary>
        public const string CUEDSP = "CUEDSP";

        /// <summary>
        /// CURRTY.
        /// </summary>
        public const string CURRTY = "CURRTY";

        /// <summary>
        /// CUAN8.
        /// </summary>
        public const string CUAN8 = "CUAN8";

        /// <summary>
        /// CUCMPE.
        /// </summary>
        public const string CUCMPE = "CUCMPE";

        /// <summary>
        /// CUCMPC.
        /// </summary>
        public const string CUCMPC = "CUCMPC";

        /// <summary>
        /// CUCMPV.
        /// </summary>
        public const string CUCMPV = "CUCMPV";

        /// <summary>
        /// CUCMPX.
        /// </summary>
        public const string CUCMPX = "CUCMPX";

        /// <summary>
        /// CUUSER.
        /// </summary>
        public const string CUUSER = "CUUSER";

        /// <summary>
        /// CUPID.
        /// </summary>
        public const string CUPID = "CUPID";

        /// <summary>
        /// CUJOBN.
        /// </summary>
        public const string CUJOBN = "CUJOBN";

        /// <summary>
        /// CUUPMJ.
        /// </summary>
        public const string CUUPMJ = "CUUPMJ";

        /// <summary>
        /// CUUPMT.
        /// </summary>
        public const string CUUPMT = "CUUPMT";

        /// <summary>
        /// CUPROSTA.
        /// </summary>
        public const string CUPROSTA = "CUPROSTA";

        /// <summary>
        /// CUEDAN.
        /// </summary>
        public const string CUEDAN = "CUEDAN";

        /// <summary>
        /// CUEDDL.
        /// </summary>
        public const string CUEDDL = "CUEDDL";

        /// <summary>
        /// CUEDER.
        /// </summary>
        public const string CUEDER = "CUEDER";

        /// <summary>
        /// CUEDFT.
        /// </summary>
        public const string CUEDFT = "CUEDFT";

        /// <summary>
        /// CUEDSQ.
        /// </summary>
        public const string CUEDSQ = "CUEDSQ";

        /// <summary>
        /// CUEDTC.
        /// </summary>
        public const string CUEDTC = "CUEDTC";

        /// <summary>
        /// CUEDTR.
        /// </summary>
        public const string CUEDTR = "CUEDTR";

        /// <summary>
        /// CUEDTS.
        /// </summary>
        public const string CUEDTS = "CUEDTS";

        /// <summary>
        /// CUEDTY.
        /// </summary>
        public const string CUEDTY = "CUEDTY";
    }

    /// <inheritdoc />
    public override string TableName => "F05100Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CUEDUS", "CUEDUS", JdeDataType.String, 20, true, true),
        new JdeField("CUEDBT", "CUEDBT", JdeDataType.String, 30, true, true),
        new JdeField("CUEDTN", "CUEDTN", JdeDataType.String, 44, true, true),
        new JdeField("CUEDLN", "CUEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CUEDDT", "CUEDDT", JdeDataType.Numeric),
        new JdeField("CUEDITIME", "CUEDITIME", JdeDataType.Numeric),
        new JdeField("CUEDSP", "CUEDSP", JdeDataType.String, 2),
        new JdeField("CURRTY", "CURRTY", JdeDataType.String, 4),
        new JdeField("CUAN8", "CUAN8", JdeDataType.Numeric),
        new JdeField("CUCMPE", "CUCMPE", JdeDataType.String, 6),
        new JdeField("CUCMPC", "CUCMPC", JdeDataType.String, 20),
        new JdeField("CUCMPV", "CUCMPV", JdeDataType.Numeric),
        new JdeField("CUCMPX", "CUCMPX", JdeDataType.Numeric),
        new JdeField("CUUSER", "CUUSER", JdeDataType.String, 20),
        new JdeField("CUPID", "CUPID", JdeDataType.String, 20),
        new JdeField("CUJOBN", "CUJOBN", JdeDataType.String, 20),
        new JdeField("CUUPMJ", "CUUPMJ", JdeDataType.Numeric),
        new JdeField("CUUPMT", "CUUPMT", JdeDataType.Numeric),
        new JdeField("CUPROSTA", "CUPROSTA", JdeDataType.String, 100),
        new JdeField("CUEDAN", "CUEDAN", JdeDataType.Numeric),
        new JdeField("CUEDDL", "CUEDDL", JdeDataType.Numeric),
        new JdeField("CUEDER", "CUEDER", JdeDataType.String, 2),
        new JdeField("CUEDFT", "CUEDFT", JdeDataType.String, 20),
        new JdeField("CUEDSQ", "CUEDSQ", JdeDataType.Numeric),
        new JdeField("CUEDTC", "CUEDTC", JdeDataType.String, 2),
        new JdeField("CUEDTR", "CUEDTR", JdeDataType.String, 2),
        new JdeField("CUEDTS", "CUEDTS", JdeDataType.String, 12),
        new JdeField("CUEDTY", "CUEDTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05100Z1_0", "Primary Key on CUEDUS, CUEDBT, CUEDTN, CUEDLN", new[] { "CUEDUS", "CUEDBT", "CUEDTN", "CUEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05100Z1_2", "Index on SYS_NC00029$, SYS_NC00030$", new[] { "SYS_NC00029$", "SYS_NC00030$" })
    };
}
