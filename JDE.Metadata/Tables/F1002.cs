using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1002 - .
/// </summary>
public class F1002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GQEDBT.
        /// </summary>
        public const string GQEDBT = "GQEDBT";

        /// <summary>
        /// GQEDUS.
        /// </summary>
        public const string GQEDUS = "GQEDUS";

        /// <summary>
        /// GQEDTN.
        /// </summary>
        public const string GQEDTN = "GQEDTN";

        /// <summary>
        /// GQRC5.
        /// </summary>
        public const string GQRC5 = "GQRC5";

        /// <summary>
        /// GQSERK.
        /// </summary>
        public const string GQSERK = "GQSERK";

        /// <summary>
        /// GQTRFG.
        /// </summary>
        public const string GQTRFG = "GQTRFG";

        /// <summary>
        /// GQMCU.
        /// </summary>
        public const string GQMCU = "GQMCU";

        /// <summary>
        /// GQOBJ.
        /// </summary>
        public const string GQOBJ = "GQOBJ";

        /// <summary>
        /// GQSUB.
        /// </summary>
        public const string GQSUB = "GQSUB";

        /// <summary>
        /// GQDL01.
        /// </summary>
        public const string GQDL01 = "GQDL01";

        /// <summary>
        /// GQSBL.
        /// </summary>
        public const string GQSBL = "GQSBL";

        /// <summary>
        /// GQSBLT.
        /// </summary>
        public const string GQSBLT = "GQSBLT";

        /// <summary>
        /// GQCRCD.
        /// </summary>
        public const string GQCRCD = "GQCRCD";

        /// <summary>
        /// GQCRCX.
        /// </summary>
        public const string GQCRCX = "GQCRCX";

        /// <summary>
        /// GQAPYC.
        /// </summary>
        public const string GQAPYC = "GQAPYC";

        /// <summary>
        /// GQAN01.
        /// </summary>
        public const string GQAN01 = "GQAN01";

        /// <summary>
        /// GQAN02.
        /// </summary>
        public const string GQAN02 = "GQAN02";

        /// <summary>
        /// GQAN03.
        /// </summary>
        public const string GQAN03 = "GQAN03";

        /// <summary>
        /// GQAN04.
        /// </summary>
        public const string GQAN04 = "GQAN04";

        /// <summary>
        /// GQAN05.
        /// </summary>
        public const string GQAN05 = "GQAN05";

        /// <summary>
        /// GQAN06.
        /// </summary>
        public const string GQAN06 = "GQAN06";

        /// <summary>
        /// GQAN07.
        /// </summary>
        public const string GQAN07 = "GQAN07";

        /// <summary>
        /// GQAN08.
        /// </summary>
        public const string GQAN08 = "GQAN08";

        /// <summary>
        /// GQAN09.
        /// </summary>
        public const string GQAN09 = "GQAN09";

        /// <summary>
        /// GQAN10.
        /// </summary>
        public const string GQAN10 = "GQAN10";

        /// <summary>
        /// GQAN11.
        /// </summary>
        public const string GQAN11 = "GQAN11";

        /// <summary>
        /// GQAN12.
        /// </summary>
        public const string GQAN12 = "GQAN12";

        /// <summary>
        /// GQAN13.
        /// </summary>
        public const string GQAN13 = "GQAN13";

        /// <summary>
        /// GQAN14.
        /// </summary>
        public const string GQAN14 = "GQAN14";

        /// <summary>
        /// GQAPYN.
        /// </summary>
        public const string GQAPYN = "GQAPYN";

        /// <summary>
        /// GQAWTD.
        /// </summary>
        public const string GQAWTD = "GQAWTD";

        /// <summary>
        /// GQBORG.
        /// </summary>
        public const string GQBORG = "GQBORG";

        /// <summary>
        /// GQBREQ.
        /// </summary>
        public const string GQBREQ = "GQBREQ";

        /// <summary>
        /// GQBAPR.
        /// </summary>
        public const string GQBAPR = "GQBAPR";

        /// <summary>
        /// GQURDT.
        /// </summary>
        public const string GQURDT = "GQURDT";

        /// <summary>
        /// GQURRF.
        /// </summary>
        public const string GQURRF = "GQURRF";

        /// <summary>
        /// GQURCD.
        /// </summary>
        public const string GQURCD = "GQURCD";

        /// <summary>
        /// GQURC1.
        /// </summary>
        public const string GQURC1 = "GQURC1";

        /// <summary>
        /// GQURC2.
        /// </summary>
        public const string GQURC2 = "GQURC2";

        /// <summary>
        /// GQUSER.
        /// </summary>
        public const string GQUSER = "GQUSER";

        /// <summary>
        /// GQPID.
        /// </summary>
        public const string GQPID = "GQPID";

        /// <summary>
        /// GQVERS.
        /// </summary>
        public const string GQVERS = "GQVERS";

        /// <summary>
        /// GQUPMJ.
        /// </summary>
        public const string GQUPMJ = "GQUPMJ";

        /// <summary>
        /// GQUPMT.
        /// </summary>
        public const string GQUPMT = "GQUPMT";

        /// <summary>
        /// GQJOBN.
        /// </summary>
        public const string GQJOBN = "GQJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GQEDBT", "GQEDBT", JdeDataType.String, 30, true, true),
        new JdeField("GQEDUS", "GQEDUS", JdeDataType.String, 20, true, true),
        new JdeField("GQEDTN", "GQEDTN", JdeDataType.String, 44, true, true),
        new JdeField("GQRC5", "GQRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("GQSERK", "GQSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("GQTRFG", "GQTRFG", JdeDataType.String, 2),
        new JdeField("GQMCU", "GQMCU", JdeDataType.String, 24),
        new JdeField("GQOBJ", "GQOBJ", JdeDataType.String, 12),
        new JdeField("GQSUB", "GQSUB", JdeDataType.String, 16),
        new JdeField("GQDL01", "GQDL01", JdeDataType.String, 60),
        new JdeField("GQSBL", "GQSBL", JdeDataType.String, 16),
        new JdeField("GQSBLT", "GQSBLT", JdeDataType.String, 2),
        new JdeField("GQCRCD", "GQCRCD", JdeDataType.String, 6),
        new JdeField("GQCRCX", "GQCRCX", JdeDataType.String, 6),
        new JdeField("GQAPYC", "GQAPYC", JdeDataType.Numeric),
        new JdeField("GQAN01", "GQAN01", JdeDataType.Numeric),
        new JdeField("GQAN02", "GQAN02", JdeDataType.Numeric),
        new JdeField("GQAN03", "GQAN03", JdeDataType.Numeric),
        new JdeField("GQAN04", "GQAN04", JdeDataType.Numeric),
        new JdeField("GQAN05", "GQAN05", JdeDataType.Numeric),
        new JdeField("GQAN06", "GQAN06", JdeDataType.Numeric),
        new JdeField("GQAN07", "GQAN07", JdeDataType.Numeric),
        new JdeField("GQAN08", "GQAN08", JdeDataType.Numeric),
        new JdeField("GQAN09", "GQAN09", JdeDataType.Numeric),
        new JdeField("GQAN10", "GQAN10", JdeDataType.Numeric),
        new JdeField("GQAN11", "GQAN11", JdeDataType.Numeric),
        new JdeField("GQAN12", "GQAN12", JdeDataType.Numeric),
        new JdeField("GQAN13", "GQAN13", JdeDataType.Numeric),
        new JdeField("GQAN14", "GQAN14", JdeDataType.Numeric),
        new JdeField("GQAPYN", "GQAPYN", JdeDataType.Numeric),
        new JdeField("GQAWTD", "GQAWTD", JdeDataType.Numeric),
        new JdeField("GQBORG", "GQBORG", JdeDataType.Numeric),
        new JdeField("GQBREQ", "GQBREQ", JdeDataType.Numeric),
        new JdeField("GQBAPR", "GQBAPR", JdeDataType.Numeric),
        new JdeField("GQURDT", "GQURDT", JdeDataType.Numeric),
        new JdeField("GQURRF", "GQURRF", JdeDataType.String, 30),
        new JdeField("GQURCD", "GQURCD", JdeDataType.String, 4),
        new JdeField("GQURC1", "GQURC1", JdeDataType.String, 6),
        new JdeField("GQURC2", "GQURC2", JdeDataType.String, 20),
        new JdeField("GQUSER", "GQUSER", JdeDataType.String, 20),
        new JdeField("GQPID", "GQPID", JdeDataType.String, 20),
        new JdeField("GQVERS", "GQVERS", JdeDataType.String, 20),
        new JdeField("GQUPMJ", "GQUPMJ", JdeDataType.Numeric),
        new JdeField("GQUPMT", "GQUPMT", JdeDataType.Numeric),
        new JdeField("GQJOBN", "GQJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1002_0", "Primary Key on GQEDBT, GQEDUS, GQEDTN, GQSERK, GQRC5", new[] { "GQEDBT", "GQEDUS", "GQEDTN", "GQSERK", "GQRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1002_2", "Index on GQEDBT, GQEDUS, GQEDTN, GQSERK, GQMCU, GQOBJ, GQSUB, GQSBL, GQSBLT, GQCRCD, GQCRCX", new[] { "GQEDBT", "GQEDUS", "GQEDTN", "GQSERK", "GQMCU", "GQOBJ", "GQSUB", "GQSBL", "GQSBLT", "GQCRCD", "GQCRCX" }),
        new JdeIndex("F1002_3", "Index on GQEDUS, GQEDTN, GQSERK, GQTRFG, GQMCU, GQOBJ, GQSUB, GQSBL, GQSBLT", new[] { "GQEDUS", "GQEDTN", "GQSERK", "GQTRFG", "GQMCU", "GQOBJ", "GQSUB", "GQSBL", "GQSBLT" }),
        new JdeIndex("F1002_4", "Index on GQEDBT, GQEDUS, GQEDTN, GQOBJ, GQSUB", new[] { "GQEDBT", "GQEDUS", "GQEDTN", "GQOBJ", "GQSUB" }),
        new JdeIndex("F1002_5", "Index on GQEDBT, GQEDUS, GQEDTN, GQTRFG", new[] { "GQEDBT", "GQEDUS", "GQEDTN", "GQTRFG" })
    };
}
