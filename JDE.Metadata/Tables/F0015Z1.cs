using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0015Z1 - .
/// </summary>
public class F0015Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZEEDUS.
        /// </summary>
        public const string ZEEDUS = "ZEEDUS";

        /// <summary>
        /// ZEEDBT.
        /// </summary>
        public const string ZEEDBT = "ZEEDBT";

        /// <summary>
        /// ZEEDTN.
        /// </summary>
        public const string ZEEDTN = "ZEEDTN";

        /// <summary>
        /// ZEEDLN.
        /// </summary>
        public const string ZEEDLN = "ZEEDLN";

        /// <summary>
        /// ZEEDCT.
        /// </summary>
        public const string ZEEDCT = "ZEEDCT";

        /// <summary>
        /// ZETYTN.
        /// </summary>
        public const string ZETYTN = "ZETYTN";

        /// <summary>
        /// ZEEDFT.
        /// </summary>
        public const string ZEEDFT = "ZEEDFT";

        /// <summary>
        /// ZEEDDT.
        /// </summary>
        public const string ZEEDDT = "ZEEDDT";

        /// <summary>
        /// ZEDRIN.
        /// </summary>
        public const string ZEDRIN = "ZEDRIN";

        /// <summary>
        /// ZEEDDL.
        /// </summary>
        public const string ZEEDDL = "ZEEDDL";

        /// <summary>
        /// ZEEDSP.
        /// </summary>
        public const string ZEEDSP = "ZEEDSP";

        /// <summary>
        /// ZEPNID.
        /// </summary>
        public const string ZEPNID = "ZEPNID";

        /// <summary>
        /// ZETNAC.
        /// </summary>
        public const string ZETNAC = "ZETNAC";

        /// <summary>
        /// ZEEDTY.
        /// </summary>
        public const string ZEEDTY = "ZEEDTY";

        /// <summary>
        /// ZEEDSQ.
        /// </summary>
        public const string ZEEDSQ = "ZEEDSQ";

        /// <summary>
        /// ZEEDTS.
        /// </summary>
        public const string ZEEDTS = "ZEEDTS";

        /// <summary>
        /// ZEEDER.
        /// </summary>
        public const string ZEEDER = "ZEEDER";

        /// <summary>
        /// ZEEDTC.
        /// </summary>
        public const string ZEEDTC = "ZEEDTC";

        /// <summary>
        /// ZEEDTR.
        /// </summary>
        public const string ZEEDTR = "ZEEDTR";

        /// <summary>
        /// ZEEDGL.
        /// </summary>
        public const string ZEEDGL = "ZEEDGL";

        /// <summary>
        /// ZEEDDH.
        /// </summary>
        public const string ZEEDDH = "ZEEDDH";

        /// <summary>
        /// ZEEDAN.
        /// </summary>
        public const string ZEEDAN = "ZEEDAN";

        /// <summary>
        /// ZECRCD.
        /// </summary>
        public const string ZECRCD = "ZECRCD";

        /// <summary>
        /// ZECRDC.
        /// </summary>
        public const string ZECRDC = "ZECRDC";

        /// <summary>
        /// ZEAN8.
        /// </summary>
        public const string ZEAN8 = "ZEAN8";

        /// <summary>
        /// ZERTTYP.
        /// </summary>
        public const string ZERTTYP = "ZERTTYP";

        /// <summary>
        /// ZEEFT.
        /// </summary>
        public const string ZEEFT = "ZEEFT";

        /// <summary>
        /// ZECLMETH.
        /// </summary>
        public const string ZECLMETH = "ZECLMETH";

        /// <summary>
        /// ZECRCM.
        /// </summary>
        public const string ZECRCM = "ZECRCM";

        /// <summary>
        /// ZETRCR.
        /// </summary>
        public const string ZETRCR = "ZETRCR";

        /// <summary>
        /// ZECRR.
        /// </summary>
        public const string ZECRR = "ZECRR";

        /// <summary>
        /// ZECRRD.
        /// </summary>
        public const string ZECRRD = "ZECRRD";

        /// <summary>
        /// ZECSR.
        /// </summary>
        public const string ZECSR = "ZECSR";

        /// <summary>
        /// ZEUSER.
        /// </summary>
        public const string ZEUSER = "ZEUSER";

        /// <summary>
        /// ZEPID.
        /// </summary>
        public const string ZEPID = "ZEPID";

        /// <summary>
        /// ZEUPMJ.
        /// </summary>
        public const string ZEUPMJ = "ZEUPMJ";

        /// <summary>
        /// ZEUPMT.
        /// </summary>
        public const string ZEUPMT = "ZEUPMT";

        /// <summary>
        /// ZEJOBN.
        /// </summary>
        public const string ZEJOBN = "ZEJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0015Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZEEDUS", "ZEEDUS", JdeDataType.String, 20, true, true),
        new JdeField("ZEEDBT", "ZEEDBT", JdeDataType.String, 30, true, true),
        new JdeField("ZEEDTN", "ZEEDTN", JdeDataType.String, 44, true, true),
        new JdeField("ZEEDLN", "ZEEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZEEDCT", "ZEEDCT", JdeDataType.String, 4),
        new JdeField("ZETYTN", "ZETYTN", JdeDataType.String, 16),
        new JdeField("ZEEDFT", "ZEEDFT", JdeDataType.String, 20),
        new JdeField("ZEEDDT", "ZEEDDT", JdeDataType.Numeric),
        new JdeField("ZEDRIN", "ZEDRIN", JdeDataType.String, 2),
        new JdeField("ZEEDDL", "ZEEDDL", JdeDataType.Numeric),
        new JdeField("ZEEDSP", "ZEEDSP", JdeDataType.String, 2),
        new JdeField("ZEPNID", "ZEPNID", JdeDataType.String, 30),
        new JdeField("ZETNAC", "ZETNAC", JdeDataType.String, 4),
        new JdeField("ZEEDTY", "ZEEDTY", JdeDataType.String, 2),
        new JdeField("ZEEDSQ", "ZEEDSQ", JdeDataType.Numeric),
        new JdeField("ZEEDTS", "ZEEDTS", JdeDataType.String, 12),
        new JdeField("ZEEDER", "ZEEDER", JdeDataType.String, 2),
        new JdeField("ZEEDTC", "ZEEDTC", JdeDataType.String, 2),
        new JdeField("ZEEDTR", "ZEEDTR", JdeDataType.String, 2),
        new JdeField("ZEEDGL", "ZEEDGL", JdeDataType.String, 2),
        new JdeField("ZEEDDH", "ZEEDDH", JdeDataType.String, 2),
        new JdeField("ZEEDAN", "ZEEDAN", JdeDataType.Numeric),
        new JdeField("ZECRCD", "ZECRCD", JdeDataType.String, 6),
        new JdeField("ZECRDC", "ZECRDC", JdeDataType.String, 6),
        new JdeField("ZEAN8", "ZEAN8", JdeDataType.Numeric),
        new JdeField("ZERTTYP", "ZERTTYP", JdeDataType.String, 4),
        new JdeField("ZEEFT", "ZEEFT", JdeDataType.Numeric),
        new JdeField("ZECLMETH", "ZECLMETH", JdeDataType.String, 2),
        new JdeField("ZECRCM", "ZECRCM", JdeDataType.String, 2),
        new JdeField("ZETRCR", "ZETRCR", JdeDataType.String, 6),
        new JdeField("ZECRR", "ZECRR", JdeDataType.Numeric),
        new JdeField("ZECRRD", "ZECRRD", JdeDataType.Numeric),
        new JdeField("ZECSR", "ZECSR", JdeDataType.String, 2),
        new JdeField("ZEUSER", "ZEUSER", JdeDataType.String, 20),
        new JdeField("ZEPID", "ZEPID", JdeDataType.String, 20),
        new JdeField("ZEUPMJ", "ZEUPMJ", JdeDataType.Numeric),
        new JdeField("ZEUPMT", "ZEUPMT", JdeDataType.Numeric),
        new JdeField("ZEJOBN", "ZEJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0015Z1_0", "Primary Key on ZEEDUS, ZEEDBT, ZEEDTN, ZEEDLN", new[] { "ZEEDUS", "ZEEDBT", "ZEEDTN", "ZEEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
