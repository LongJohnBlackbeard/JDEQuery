using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0902 - .
/// </summary>
public class F0902 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GBAID.
        /// </summary>
        public const string GBAID = "GBAID";

        /// <summary>
        /// GBCTRY.
        /// </summary>
        public const string GBCTRY = "GBCTRY";

        /// <summary>
        /// GBFY.
        /// </summary>
        public const string GBFY = "GBFY";

        /// <summary>
        /// GBFQ.
        /// </summary>
        public const string GBFQ = "GBFQ";

        /// <summary>
        /// GBLT.
        /// </summary>
        public const string GBLT = "GBLT";

        /// <summary>
        /// GBSBL.
        /// </summary>
        public const string GBSBL = "GBSBL";

        /// <summary>
        /// GBCO.
        /// </summary>
        public const string GBCO = "GBCO";

        /// <summary>
        /// GBAPYC.
        /// </summary>
        public const string GBAPYC = "GBAPYC";

        /// <summary>
        /// GBAN01.
        /// </summary>
        public const string GBAN01 = "GBAN01";

        /// <summary>
        /// GBAN02.
        /// </summary>
        public const string GBAN02 = "GBAN02";

        /// <summary>
        /// GBAN03.
        /// </summary>
        public const string GBAN03 = "GBAN03";

        /// <summary>
        /// GBAN04.
        /// </summary>
        public const string GBAN04 = "GBAN04";

        /// <summary>
        /// GBAN05.
        /// </summary>
        public const string GBAN05 = "GBAN05";

        /// <summary>
        /// GBAN06.
        /// </summary>
        public const string GBAN06 = "GBAN06";

        /// <summary>
        /// GBAN07.
        /// </summary>
        public const string GBAN07 = "GBAN07";

        /// <summary>
        /// GBAN08.
        /// </summary>
        public const string GBAN08 = "GBAN08";

        /// <summary>
        /// GBAN09.
        /// </summary>
        public const string GBAN09 = "GBAN09";

        /// <summary>
        /// GBAN10.
        /// </summary>
        public const string GBAN10 = "GBAN10";

        /// <summary>
        /// GBAN11.
        /// </summary>
        public const string GBAN11 = "GBAN11";

        /// <summary>
        /// GBAN12.
        /// </summary>
        public const string GBAN12 = "GBAN12";

        /// <summary>
        /// GBAN13.
        /// </summary>
        public const string GBAN13 = "GBAN13";

        /// <summary>
        /// GBAN14.
        /// </summary>
        public const string GBAN14 = "GBAN14";

        /// <summary>
        /// GBAPYN.
        /// </summary>
        public const string GBAPYN = "GBAPYN";

        /// <summary>
        /// GBAWTD.
        /// </summary>
        public const string GBAWTD = "GBAWTD";

        /// <summary>
        /// GBBORG.
        /// </summary>
        public const string GBBORG = "GBBORG";

        /// <summary>
        /// GBPOU.
        /// </summary>
        public const string GBPOU = "GBPOU";

        /// <summary>
        /// GBPC.
        /// </summary>
        public const string GBPC = "GBPC";

        /// <summary>
        /// GBTKER.
        /// </summary>
        public const string GBTKER = "GBTKER";

        /// <summary>
        /// GBBREQ.
        /// </summary>
        public const string GBBREQ = "GBBREQ";

        /// <summary>
        /// GBBAPR.
        /// </summary>
        public const string GBBAPR = "GBBAPR";

        /// <summary>
        /// GBMCU.
        /// </summary>
        public const string GBMCU = "GBMCU";

        /// <summary>
        /// GBOBJ.
        /// </summary>
        public const string GBOBJ = "GBOBJ";

        /// <summary>
        /// GBSUB.
        /// </summary>
        public const string GBSUB = "GBSUB";

        /// <summary>
        /// GBUSER.
        /// </summary>
        public const string GBUSER = "GBUSER";

        /// <summary>
        /// GBPID.
        /// </summary>
        public const string GBPID = "GBPID";

        /// <summary>
        /// GBUPMJ.
        /// </summary>
        public const string GBUPMJ = "GBUPMJ";

        /// <summary>
        /// GBJOBN.
        /// </summary>
        public const string GBJOBN = "GBJOBN";

        /// <summary>
        /// GBSBLT.
        /// </summary>
        public const string GBSBLT = "GBSBLT";

        /// <summary>
        /// GBUPMT.
        /// </summary>
        public const string GBUPMT = "GBUPMT";

        /// <summary>
        /// GBCRCD.
        /// </summary>
        public const string GBCRCD = "GBCRCD";

        /// <summary>
        /// GBCRCX.
        /// </summary>
        public const string GBCRCX = "GBCRCX";

        /// <summary>
        /// GBPRGF.
        /// </summary>
        public const string GBPRGF = "GBPRGF";

        /// <summary>
        /// GBAND01.
        /// </summary>
        public const string GBAND01 = "GBAND01";

        /// <summary>
        /// GBAND02.
        /// </summary>
        public const string GBAND02 = "GBAND02";

        /// <summary>
        /// GBAND03.
        /// </summary>
        public const string GBAND03 = "GBAND03";

        /// <summary>
        /// GBAND04.
        /// </summary>
        public const string GBAND04 = "GBAND04";

        /// <summary>
        /// GBAND05.
        /// </summary>
        public const string GBAND05 = "GBAND05";

        /// <summary>
        /// GBAND06.
        /// </summary>
        public const string GBAND06 = "GBAND06";

        /// <summary>
        /// GBAND07.
        /// </summary>
        public const string GBAND07 = "GBAND07";

        /// <summary>
        /// GBAND08.
        /// </summary>
        public const string GBAND08 = "GBAND08";

        /// <summary>
        /// GBAND09.
        /// </summary>
        public const string GBAND09 = "GBAND09";

        /// <summary>
        /// GBAND10.
        /// </summary>
        public const string GBAND10 = "GBAND10";

        /// <summary>
        /// GBAND11.
        /// </summary>
        public const string GBAND11 = "GBAND11";

        /// <summary>
        /// GBAND12.
        /// </summary>
        public const string GBAND12 = "GBAND12";

        /// <summary>
        /// GBAND13.
        /// </summary>
        public const string GBAND13 = "GBAND13";

        /// <summary>
        /// GBAND14.
        /// </summary>
        public const string GBAND14 = "GBAND14";
    }

    /// <inheritdoc />
    public override string TableName => "F0902";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GBAID", "GBAID", JdeDataType.String, 16, true, true),
        new JdeField("GBCTRY", "GBCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("GBFY", "GBFY", JdeDataType.Numeric, null, true, true),
        new JdeField("GBFQ", "GBFQ", JdeDataType.String, 8, true, true),
        new JdeField("GBLT", "GBLT", JdeDataType.String, 4, true, true),
        new JdeField("GBSBL", "GBSBL", JdeDataType.String, 16, true, true),
        new JdeField("GBCO", "GBCO", JdeDataType.String, 10),
        new JdeField("GBAPYC", "GBAPYC", JdeDataType.Numeric),
        new JdeField("GBAN01", "GBAN01", JdeDataType.Numeric),
        new JdeField("GBAN02", "GBAN02", JdeDataType.Numeric),
        new JdeField("GBAN03", "GBAN03", JdeDataType.Numeric),
        new JdeField("GBAN04", "GBAN04", JdeDataType.Numeric),
        new JdeField("GBAN05", "GBAN05", JdeDataType.Numeric),
        new JdeField("GBAN06", "GBAN06", JdeDataType.Numeric),
        new JdeField("GBAN07", "GBAN07", JdeDataType.Numeric),
        new JdeField("GBAN08", "GBAN08", JdeDataType.Numeric),
        new JdeField("GBAN09", "GBAN09", JdeDataType.Numeric),
        new JdeField("GBAN10", "GBAN10", JdeDataType.Numeric),
        new JdeField("GBAN11", "GBAN11", JdeDataType.Numeric),
        new JdeField("GBAN12", "GBAN12", JdeDataType.Numeric),
        new JdeField("GBAN13", "GBAN13", JdeDataType.Numeric),
        new JdeField("GBAN14", "GBAN14", JdeDataType.Numeric),
        new JdeField("GBAPYN", "GBAPYN", JdeDataType.Numeric),
        new JdeField("GBAWTD", "GBAWTD", JdeDataType.Numeric),
        new JdeField("GBBORG", "GBBORG", JdeDataType.Numeric),
        new JdeField("GBPOU", "GBPOU", JdeDataType.Numeric),
        new JdeField("GBPC", "GBPC", JdeDataType.Numeric),
        new JdeField("GBTKER", "GBTKER", JdeDataType.Numeric),
        new JdeField("GBBREQ", "GBBREQ", JdeDataType.Numeric),
        new JdeField("GBBAPR", "GBBAPR", JdeDataType.Numeric),
        new JdeField("GBMCU", "GBMCU", JdeDataType.String, 24),
        new JdeField("GBOBJ", "GBOBJ", JdeDataType.String, 12),
        new JdeField("GBSUB", "GBSUB", JdeDataType.String, 16),
        new JdeField("GBUSER", "GBUSER", JdeDataType.String, 20),
        new JdeField("GBPID", "GBPID", JdeDataType.String, 20),
        new JdeField("GBUPMJ", "GBUPMJ", JdeDataType.Numeric),
        new JdeField("GBJOBN", "GBJOBN", JdeDataType.String, 20),
        new JdeField("GBSBLT", "GBSBLT", JdeDataType.String, 2, true, true),
        new JdeField("GBUPMT", "GBUPMT", JdeDataType.Numeric),
        new JdeField("GBCRCD", "GBCRCD", JdeDataType.String, 6, true, true),
        new JdeField("GBCRCX", "GBCRCX", JdeDataType.String, 6),
        new JdeField("GBPRGF", "GBPRGF", JdeDataType.String, 2),
        new JdeField("GBAND01", "GBAND01", JdeDataType.Numeric),
        new JdeField("GBAND02", "GBAND02", JdeDataType.Numeric),
        new JdeField("GBAND03", "GBAND03", JdeDataType.Numeric),
        new JdeField("GBAND04", "GBAND04", JdeDataType.Numeric),
        new JdeField("GBAND05", "GBAND05", JdeDataType.Numeric),
        new JdeField("GBAND06", "GBAND06", JdeDataType.Numeric),
        new JdeField("GBAND07", "GBAND07", JdeDataType.Numeric),
        new JdeField("GBAND08", "GBAND08", JdeDataType.Numeric),
        new JdeField("GBAND09", "GBAND09", JdeDataType.Numeric),
        new JdeField("GBAND10", "GBAND10", JdeDataType.Numeric),
        new JdeField("GBAND11", "GBAND11", JdeDataType.Numeric),
        new JdeField("GBAND12", "GBAND12", JdeDataType.Numeric),
        new JdeField("GBAND13", "GBAND13", JdeDataType.Numeric),
        new JdeField("GBAND14", "GBAND14", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0902_0", "Primary Key on GBAID, GBCTRY, GBFY, GBFQ, GBLT, GBSBL, GBSBLT, GBCRCD", new[] { "GBAID", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBSBL", "GBSBLT", "GBCRCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0902_10", "Index on GBCTRY, GBFY, GBLT, GBCO, GBMCU, GBOBJ, GBSUB, GBSBLT, GBSBL, GBAID", new[] { "GBCTRY", "GBFY", "GBLT", "GBCO", "GBMCU", "GBOBJ", "GBSUB", "GBSBLT", "GBSBL", "GBAID" }),
        new JdeIndex("F0902_11", "Index on GBCTRY, GBFY, GBLT, GBCO, GBOBJ, GBMCU, GBSUB, GBSBLT, GBSBL, GBAID", new[] { "GBCTRY", "GBFY", "GBLT", "GBCO", "GBOBJ", "GBMCU", "GBSUB", "GBSBLT", "GBSBL", "GBAID" }),
        new JdeIndex("F0902_2", "Index on GBAID, GBCTRY, GBFY, GBFQ, GBLT, GBCRCD", new[] { "GBAID", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBCRCD" }),
        new JdeIndex("F0902_3", "Index on GBSBL, GBSBLT, GBLT, GBMCU, GBOBJ, GBSUB, GBCTRY, GBFY, GBFQ, GBCRCD", new[] { "GBSBL", "GBSBLT", "GBLT", "GBMCU", "GBOBJ", "GBSUB", "GBCTRY", "GBFY", "GBFQ", "GBCRCD" }),
        new JdeIndex("F0902_4", "Index on GBCO, GBMCU, GBOBJ, GBSUB, GBSBL, GBSBLT, GBCTRY, GBFY, GBFQ, GBLT, GBCRCD", new[] { "GBCO", "GBMCU", "GBOBJ", "GBSUB", "GBSBL", "GBSBLT", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBCRCD" }),
        new JdeIndex("F0902_5", "Index on GBMCU, GBOBJ, GBSUB, GBCTRY, GBFY, GBFQ, GBLT, GBSBL, GBSBLT, GBCRCX, GBCRCD", new[] { "GBMCU", "GBOBJ", "GBSUB", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBSBL", "GBSBLT", "GBCRCX", "GBCRCD" }),
        new JdeIndex("F0902_6", "Index on GBMCU, GBOBJ, GBSUB, GBCTRY, GBFY, GBFQ, GBLT, GBCRCX, GBCRCD, GBSBL, GBSBLT", new[] { "GBMCU", "GBOBJ", "GBSUB", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBCRCX", "GBCRCD", "GBSBL", "GBSBLT" }),
        new JdeIndex("F0902_7", "Index on GBCO, GBMCU, GBAID, GBLT, GBSBL, GBSBLT, GBCTRY, GBFY", new[] { "GBCO", "GBMCU", "GBAID", "GBLT", "GBSBL", "GBSBLT", "GBCTRY", "GBFY" }),
        new JdeIndex("F0902_8", "Index on GBAID, GBCTRY, GBFY, GBFQ, GBLT, GBSBLT, GBSBL, GBCRCD", new[] { "GBAID", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBSBLT", "GBSBL", "GBCRCD" }),
        new JdeIndex("F0902_9", "Index on GBAID, GBLT, GBSBLT, GBSBL", new[] { "GBAID", "GBLT", "GBSBLT", "GBSBL" })
    };
}
