using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F39120W - .
/// </summary>
public class F39120W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TWITM.
        /// </summary>
        public const string TWITM = "TWITM";

        /// <summary>
        /// TWCO.
        /// </summary>
        public const string TWCO = "TWCO";

        /// <summary>
        /// TWMCU.
        /// </summary>
        public const string TWMCU = "TWMCU";

        /// <summary>
        /// TWDCT.
        /// </summary>
        public const string TWDCT = "TWDCT";

        /// <summary>
        /// TWTRUM.
        /// </summary>
        public const string TWTRUM = "TWTRUM";

        /// <summary>
        /// TWTRDJ.
        /// </summary>
        public const string TWTRDJ = "TWTRDJ";

        /// <summary>
        /// TWTRQT.
        /// </summary>
        public const string TWTRQT = "TWTRQT";

        /// <summary>
        /// TWUNCS.
        /// </summary>
        public const string TWUNCS = "TWUNCS";

        /// <summary>
        /// TWPAID.
        /// </summary>
        public const string TWPAID = "TWPAID";

        /// <summary>
        /// TWSVYR.
        /// </summary>
        public const string TWSVYR = "TWSVYR";

        /// <summary>
        /// TWPNC.
        /// </summary>
        public const string TWPNC = "TWPNC";

        /// <summary>
        /// TWDOCO.
        /// </summary>
        public const string TWDOCO = "TWDOCO";

        /// <summary>
        /// TWDCTO.
        /// </summary>
        public const string TWDCTO = "TWDCTO";

        /// <summary>
        /// TWKCOO.
        /// </summary>
        public const string TWKCOO = "TWKCOO";

        /// <summary>
        /// TWLNID.
        /// </summary>
        public const string TWLNID = "TWLNID";

        /// <summary>
        /// TWNLIN.
        /// </summary>
        public const string TWNLIN = "TWNLIN";

        /// <summary>
        /// TWOITM.
        /// </summary>
        public const string TWOITM = "TWOITM";

        /// <summary>
        /// TWDGJ.
        /// </summary>
        public const string TWDGJ = "TWDGJ";

        /// <summary>
        /// TWTNTP.
        /// </summary>
        public const string TWTNTP = "TWTNTP";

        /// <summary>
        /// TWUKID.
        /// </summary>
        public const string TWUKID = "TWUKID";

        /// <summary>
        /// TWDTE.
        /// </summary>
        public const string TWDTE = "TWDTE";
    }

    /// <inheritdoc />
    public override string TableName => "F39120W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TWITM", "TWITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TWCO", "TWCO", JdeDataType.String, 10, true, true),
        new JdeField("TWMCU", "TWMCU", JdeDataType.String, 24, true, true),
        new JdeField("TWDCT", "TWDCT", JdeDataType.String, 4),
        new JdeField("TWTRUM", "TWTRUM", JdeDataType.String, 4),
        new JdeField("TWTRDJ", "TWTRDJ", JdeDataType.Numeric),
        new JdeField("TWTRQT", "TWTRQT", JdeDataType.Numeric),
        new JdeField("TWUNCS", "TWUNCS", JdeDataType.Numeric),
        new JdeField("TWPAID", "TWPAID", JdeDataType.Numeric),
        new JdeField("TWSVYR", "TWSVYR", JdeDataType.Numeric),
        new JdeField("TWPNC", "TWPNC", JdeDataType.Numeric),
        new JdeField("TWDOCO", "TWDOCO", JdeDataType.Numeric),
        new JdeField("TWDCTO", "TWDCTO", JdeDataType.String, 4),
        new JdeField("TWKCOO", "TWKCOO", JdeDataType.String, 10),
        new JdeField("TWLNID", "TWLNID", JdeDataType.Numeric),
        new JdeField("TWNLIN", "TWNLIN", JdeDataType.Numeric),
        new JdeField("TWOITM", "TWOITM", JdeDataType.Numeric),
        new JdeField("TWDGJ", "TWDGJ", JdeDataType.Numeric),
        new JdeField("TWTNTP", "TWTNTP", JdeDataType.String, 2),
        new JdeField("TWUKID", "TWUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("TWDTE", "TWDTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F39120W_0", "Primary Key on TWCO, TWMCU, TWITM, TWUKID", new[] { "TWCO", "TWMCU", "TWITM", "TWUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F39120W_2", "Index on TWCO", new[] { "TWCO" }),
        new JdeIndex("F39120W_3", "Unique Index on TWUKID", new[] { "TWUKID" }, isUnique: true),
        new JdeIndex("F39120W_4", "Index on SYS_NC00022$", new[] { "SYS_NC00022$" })
    };
}
