using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9002 - .
/// </summary>
public class F74R9002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GBR74DAID.
        /// </summary>
        public const string GBR74DAID = "GBR74DAID";

        /// <summary>
        /// GBR74CAID.
        /// </summary>
        public const string GBR74CAID = "GBR74CAID";

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
        /// GBR74DMCU.
        /// </summary>
        public const string GBR74DMCU = "GBR74DMCU";

        /// <summary>
        /// GBR74DOBJ.
        /// </summary>
        public const string GBR74DOBJ = "GBR74DOBJ";

        /// <summary>
        /// GBR74DSUB.
        /// </summary>
        public const string GBR74DSUB = "GBR74DSUB";

        /// <summary>
        /// GBR74CMCU.
        /// </summary>
        public const string GBR74CMCU = "GBR74CMCU";

        /// <summary>
        /// GBR74COBJ.
        /// </summary>
        public const string GBR74COBJ = "GBR74COBJ";

        /// <summary>
        /// GBR74CSUB.
        /// </summary>
        public const string GBR74CSUB = "GBR74CSUB";

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
    }

    /// <inheritdoc />
    public override string TableName => "F74R9002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GBR74DAID", "GBR74DAID", JdeDataType.String, 16, true, true),
        new JdeField("GBR74CAID", "GBR74CAID", JdeDataType.String, 16, true, true),
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
        new JdeField("GBR74DMCU", "GBR74DMCU", JdeDataType.String, 24),
        new JdeField("GBR74DOBJ", "GBR74DOBJ", JdeDataType.String, 12),
        new JdeField("GBR74DSUB", "GBR74DSUB", JdeDataType.String, 16),
        new JdeField("GBR74CMCU", "GBR74CMCU", JdeDataType.String, 24),
        new JdeField("GBR74COBJ", "GBR74COBJ", JdeDataType.String, 12),
        new JdeField("GBR74CSUB", "GBR74CSUB", JdeDataType.String, 16),
        new JdeField("GBUSER", "GBUSER", JdeDataType.String, 20),
        new JdeField("GBPID", "GBPID", JdeDataType.String, 20),
        new JdeField("GBUPMJ", "GBUPMJ", JdeDataType.Numeric),
        new JdeField("GBJOBN", "GBJOBN", JdeDataType.String, 20),
        new JdeField("GBSBLT", "GBSBLT", JdeDataType.String, 2, true, true),
        new JdeField("GBUPMT", "GBUPMT", JdeDataType.Numeric),
        new JdeField("GBCRCD", "GBCRCD", JdeDataType.String, 6, true, true),
        new JdeField("GBCRCX", "GBCRCX", JdeDataType.String, 6),
        new JdeField("GBPRGF", "GBPRGF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9002_0", "Primary Key on GBR74DAID, GBR74CAID, GBCTRY, GBFY, GBFQ, GBLT, GBSBL, GBSBLT, GBCRCD", new[] { "GBR74DAID", "GBR74CAID", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBSBL", "GBSBLT", "GBCRCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9002_2", "Index on GBR74DAID, GBR74CAID, GBCTRY, GBFY, GBFQ, GBLT, GBCRCD", new[] { "GBR74DAID", "GBR74CAID", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBCRCD" }),
        new JdeIndex("F74R9002_3", "Index on GBSBL, GBSBLT, GBLT, GBR74DMCU, GBR74DOBJ, GBR74DSUB, GBR74CMCU, GBR74COBJ, GBR74CSUB, GBCTRY, GBFY, GBFQ, GBCRCD", new[] { "GBSBL", "GBSBLT", "GBLT", "GBR74DMCU", "GBR74DOBJ", "GBR74DSUB", "GBR74CMCU", "GBR74COBJ", "GBR74CSUB", "GBCTRY", "GBFY", "GBFQ", "GBCRCD" }),
        new JdeIndex("F74R9002_4", "Index on GBCO, GBR74DMCU, GBR74DOBJ, GBR74DSUB, GBR74CMCU, GBR74COBJ, GBR74CSUB, GBSBL, GBSBLT, GBCTRY, GBFY, GBFQ, GBLT, GBCRCD", new[] { "GBCO", "GBR74DMCU", "GBR74DOBJ", "GBR74DSUB", "GBR74CMCU", "GBR74COBJ", "GBR74CSUB", "GBSBL", "GBSBLT", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBCRCD" }),
        new JdeIndex("F74R9002_5", "Index on GBR74DMCU, GBR74DOBJ, GBR74DSUB, GBR74CMCU, GBR74COBJ, GBR74CSUB, GBCTRY, GBFY, GBFQ, GBLT, GBSBL, GBSBLT, GBCRCX, GBCRCD", new[] { "GBR74DMCU", "GBR74DOBJ", "GBR74DSUB", "GBR74CMCU", "GBR74COBJ", "GBR74CSUB", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBSBL", "GBSBLT", "GBCRCX", "GBCRCD" }),
        new JdeIndex("F74R9002_6", "Index on GBR74DMCU, GBR74DOBJ, GBR74DSUB, GBR74CMCU, GBR74COBJ, GBR74CSUB, GBCTRY, GBFY, GBFQ, GBLT, GBCRCX, GBCRCD, GBSBL, GBSBLT", new[] { "GBR74DMCU", "GBR74DOBJ", "GBR74DSUB", "GBR74CMCU", "GBR74COBJ", "GBR74CSUB", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBCRCX", "GBCRCD", "GBSBL", "GBSBLT" }),
        new JdeIndex("F74R9002_7", "Index on GBCO, GBR74CMCU, GBR74DMCU, GBR74DAID, GBR74CAID, GBLT, GBSBL, GBSBLT, GBCTRY, GBFY", new[] { "GBCO", "GBR74CMCU", "GBR74DMCU", "GBR74DAID", "GBR74CAID", "GBLT", "GBSBL", "GBSBLT", "GBCTRY", "GBFY" }),
        new JdeIndex("F74R9002_8", "Index on GBR74DAID, GBR74CAID, GBCTRY, GBFY, GBFQ, GBLT, GBSBLT, GBCRCD, GBSBL", new[] { "GBR74DAID", "GBR74CAID", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBSBLT", "GBCRCD", "GBSBL" }),
        new JdeIndex("F74R9002_9", "Index on GBR74DAID, GBR74CAID, GBLT, GBSBLT, GBSBL", new[] { "GBR74DAID", "GBR74CAID", "GBLT", "GBSBLT", "GBSBL" })
    };
}
