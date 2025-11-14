using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0902B - .
/// </summary>
public class F0902B : JdeTable
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
        /// GBAN15.
        /// </summary>
        public const string GBAN15 = "GBAN15";

        /// <summary>
        /// GBAN16.
        /// </summary>
        public const string GBAN16 = "GBAN16";

        /// <summary>
        /// GBAN17.
        /// </summary>
        public const string GBAN17 = "GBAN17";

        /// <summary>
        /// GBAN18.
        /// </summary>
        public const string GBAN18 = "GBAN18";

        /// <summary>
        /// GBAN19.
        /// </summary>
        public const string GBAN19 = "GBAN19";

        /// <summary>
        /// GBAN20.
        /// </summary>
        public const string GBAN20 = "GBAN20";

        /// <summary>
        /// GBAN21.
        /// </summary>
        public const string GBAN21 = "GBAN21";

        /// <summary>
        /// GBAN22.
        /// </summary>
        public const string GBAN22 = "GBAN22";

        /// <summary>
        /// GBAN23.
        /// </summary>
        public const string GBAN23 = "GBAN23";

        /// <summary>
        /// GBAN24.
        /// </summary>
        public const string GBAN24 = "GBAN24";

        /// <summary>
        /// GBAN25.
        /// </summary>
        public const string GBAN25 = "GBAN25";

        /// <summary>
        /// GBAN26.
        /// </summary>
        public const string GBAN26 = "GBAN26";

        /// <summary>
        /// GBAN27.
        /// </summary>
        public const string GBAN27 = "GBAN27";

        /// <summary>
        /// GBAN28.
        /// </summary>
        public const string GBAN28 = "GBAN28";

        /// <summary>
        /// GBAN29.
        /// </summary>
        public const string GBAN29 = "GBAN29";

        /// <summary>
        /// GBAN30.
        /// </summary>
        public const string GBAN30 = "GBAN30";

        /// <summary>
        /// GBAN31.
        /// </summary>
        public const string GBAN31 = "GBAN31";

        /// <summary>
        /// GBAN32.
        /// </summary>
        public const string GBAN32 = "GBAN32";

        /// <summary>
        /// GBAN33.
        /// </summary>
        public const string GBAN33 = "GBAN33";

        /// <summary>
        /// GBAN34.
        /// </summary>
        public const string GBAN34 = "GBAN34";

        /// <summary>
        /// GBAN35.
        /// </summary>
        public const string GBAN35 = "GBAN35";

        /// <summary>
        /// GBAN36.
        /// </summary>
        public const string GBAN36 = "GBAN36";

        /// <summary>
        /// GBAN37.
        /// </summary>
        public const string GBAN37 = "GBAN37";

        /// <summary>
        /// GBAN38.
        /// </summary>
        public const string GBAN38 = "GBAN38";

        /// <summary>
        /// GBAN39.
        /// </summary>
        public const string GBAN39 = "GBAN39";

        /// <summary>
        /// GBAN40.
        /// </summary>
        public const string GBAN40 = "GBAN40";

        /// <summary>
        /// GBAN41.
        /// </summary>
        public const string GBAN41 = "GBAN41";

        /// <summary>
        /// GBAN42.
        /// </summary>
        public const string GBAN42 = "GBAN42";

        /// <summary>
        /// GBAN43.
        /// </summary>
        public const string GBAN43 = "GBAN43";

        /// <summary>
        /// GBAN44.
        /// </summary>
        public const string GBAN44 = "GBAN44";

        /// <summary>
        /// GBAN45.
        /// </summary>
        public const string GBAN45 = "GBAN45";

        /// <summary>
        /// GBAN46.
        /// </summary>
        public const string GBAN46 = "GBAN46";

        /// <summary>
        /// GBAN47.
        /// </summary>
        public const string GBAN47 = "GBAN47";

        /// <summary>
        /// GBAN48.
        /// </summary>
        public const string GBAN48 = "GBAN48";

        /// <summary>
        /// GBAN49.
        /// </summary>
        public const string GBAN49 = "GBAN49";

        /// <summary>
        /// GBAN50.
        /// </summary>
        public const string GBAN50 = "GBAN50";

        /// <summary>
        /// GBAN51.
        /// </summary>
        public const string GBAN51 = "GBAN51";

        /// <summary>
        /// GBAN52.
        /// </summary>
        public const string GBAN52 = "GBAN52";

        /// <summary>
        /// GBAN53.
        /// </summary>
        public const string GBAN53 = "GBAN53";

        /// <summary>
        /// GBAN54.
        /// </summary>
        public const string GBAN54 = "GBAN54";

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
    }

    /// <inheritdoc />
    public override string TableName => "F0902B";

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
        new JdeField("GBAN15", "GBAN15", JdeDataType.Numeric),
        new JdeField("GBAN16", "GBAN16", JdeDataType.Numeric),
        new JdeField("GBAN17", "GBAN17", JdeDataType.Numeric),
        new JdeField("GBAN18", "GBAN18", JdeDataType.Numeric),
        new JdeField("GBAN19", "GBAN19", JdeDataType.Numeric),
        new JdeField("GBAN20", "GBAN20", JdeDataType.Numeric),
        new JdeField("GBAN21", "GBAN21", JdeDataType.Numeric),
        new JdeField("GBAN22", "GBAN22", JdeDataType.Numeric),
        new JdeField("GBAN23", "GBAN23", JdeDataType.Numeric),
        new JdeField("GBAN24", "GBAN24", JdeDataType.Numeric),
        new JdeField("GBAN25", "GBAN25", JdeDataType.Numeric),
        new JdeField("GBAN26", "GBAN26", JdeDataType.Numeric),
        new JdeField("GBAN27", "GBAN27", JdeDataType.Numeric),
        new JdeField("GBAN28", "GBAN28", JdeDataType.Numeric),
        new JdeField("GBAN29", "GBAN29", JdeDataType.Numeric),
        new JdeField("GBAN30", "GBAN30", JdeDataType.Numeric),
        new JdeField("GBAN31", "GBAN31", JdeDataType.Numeric),
        new JdeField("GBAN32", "GBAN32", JdeDataType.Numeric),
        new JdeField("GBAN33", "GBAN33", JdeDataType.Numeric),
        new JdeField("GBAN34", "GBAN34", JdeDataType.Numeric),
        new JdeField("GBAN35", "GBAN35", JdeDataType.Numeric),
        new JdeField("GBAN36", "GBAN36", JdeDataType.Numeric),
        new JdeField("GBAN37", "GBAN37", JdeDataType.Numeric),
        new JdeField("GBAN38", "GBAN38", JdeDataType.Numeric),
        new JdeField("GBAN39", "GBAN39", JdeDataType.Numeric),
        new JdeField("GBAN40", "GBAN40", JdeDataType.Numeric),
        new JdeField("GBAN41", "GBAN41", JdeDataType.Numeric),
        new JdeField("GBAN42", "GBAN42", JdeDataType.Numeric),
        new JdeField("GBAN43", "GBAN43", JdeDataType.Numeric),
        new JdeField("GBAN44", "GBAN44", JdeDataType.Numeric),
        new JdeField("GBAN45", "GBAN45", JdeDataType.Numeric),
        new JdeField("GBAN46", "GBAN46", JdeDataType.Numeric),
        new JdeField("GBAN47", "GBAN47", JdeDataType.Numeric),
        new JdeField("GBAN48", "GBAN48", JdeDataType.Numeric),
        new JdeField("GBAN49", "GBAN49", JdeDataType.Numeric),
        new JdeField("GBAN50", "GBAN50", JdeDataType.Numeric),
        new JdeField("GBAN51", "GBAN51", JdeDataType.Numeric),
        new JdeField("GBAN52", "GBAN52", JdeDataType.Numeric),
        new JdeField("GBAN53", "GBAN53", JdeDataType.Numeric),
        new JdeField("GBAN54", "GBAN54", JdeDataType.Numeric),
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
        new JdeField("GBPRGF", "GBPRGF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0902B_0", "Primary Key on GBAID, GBCTRY, GBFY, GBFQ, GBLT, GBSBLT, GBSBL, GBCRCD", new[] { "GBAID", "GBCTRY", "GBFY", "GBFQ", "GBLT", "GBSBLT", "GBSBL", "GBCRCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0902B_2", "Index on GBMCU, GBOBJ, GBSUB", new[] { "GBMCU", "GBOBJ", "GBSUB" })
    };
}
