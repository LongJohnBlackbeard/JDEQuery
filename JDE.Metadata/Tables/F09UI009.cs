using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI009 - .
/// </summary>
public class F09UI009 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GBJOBS.
        /// </summary>
        public const string GBJOBS = "GBJOBS";

        /// <summary>
        /// GBCTID.
        /// </summary>
        public const string GBCTID = "GBCTID";

        /// <summary>
        /// GBLT.
        /// </summary>
        public const string GBLT = "GBLT";

        /// <summary>
        /// GBCRCD.
        /// </summary>
        public const string GBCRCD = "GBCRCD";

        /// <summary>
        /// GBDESC.
        /// </summary>
        public const string GBDESC = "GBDESC";

        /// <summary>
        /// GBCRCX.
        /// </summary>
        public const string GBCRCX = "GBCRCX";

        /// <summary>
        /// GBDL01.
        /// </summary>
        public const string GBDL01 = "GBDL01";

        /// <summary>
        /// GBDL02.
        /// </summary>
        public const string GBDL02 = "GBDL02";

        /// <summary>
        /// GBDL03.
        /// </summary>
        public const string GBDL03 = "GBDL03";

        /// <summary>
        /// GBDL04.
        /// </summary>
        public const string GBDL04 = "GBDL04";

        /// <summary>
        /// GBDL05.
        /// </summary>
        public const string GBDL05 = "GBDL05";

        /// <summary>
        /// GBDL06.
        /// </summary>
        public const string GBDL06 = "GBDL06";

        /// <summary>
        /// GBDL07.
        /// </summary>
        public const string GBDL07 = "GBDL07";

        /// <summary>
        /// GBDL08.
        /// </summary>
        public const string GBDL08 = "GBDL08";

        /// <summary>
        /// GBDL09.
        /// </summary>
        public const string GBDL09 = "GBDL09";

        /// <summary>
        /// GBDL10.
        /// </summary>
        public const string GBDL10 = "GBDL10";

        /// <summary>
        /// GBDL11.
        /// </summary>
        public const string GBDL11 = "GBDL11";

        /// <summary>
        /// GBDL12.
        /// </summary>
        public const string GBDL12 = "GBDL12";

        /// <summary>
        /// GBDL13.
        /// </summary>
        public const string GBDL13 = "GBDL13";

        /// <summary>
        /// GBDL14.
        /// </summary>
        public const string GBDL14 = "GBDL14";

        /// <summary>
        /// GBDL15.
        /// </summary>
        public const string GBDL15 = "GBDL15";

        /// <summary>
        /// GBDL16.
        /// </summary>
        public const string GBDL16 = "GBDL16";

        /// <summary>
        /// GBDL17.
        /// </summary>
        public const string GBDL17 = "GBDL17";

        /// <summary>
        /// GBDL18.
        /// </summary>
        public const string GBDL18 = "GBDL18";

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
    }

    /// <inheritdoc />
    public override string TableName => "F09UI009";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GBJOBS", "GBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GBCTID", "GBCTID", JdeDataType.String, 30, true, true),
        new JdeField("GBLT", "GBLT", JdeDataType.String, 4, true, true),
        new JdeField("GBCRCD", "GBCRCD", JdeDataType.String, 6, true, true),
        new JdeField("GBDESC", "GBDESC", JdeDataType.String, 60, true, true),
        new JdeField("GBCRCX", "GBCRCX", JdeDataType.String, 6),
        new JdeField("GBDL01", "GBDL01", JdeDataType.String, 60),
        new JdeField("GBDL02", "GBDL02", JdeDataType.String, 60),
        new JdeField("GBDL03", "GBDL03", JdeDataType.String, 60),
        new JdeField("GBDL04", "GBDL04", JdeDataType.String, 60),
        new JdeField("GBDL05", "GBDL05", JdeDataType.String, 60),
        new JdeField("GBDL06", "GBDL06", JdeDataType.String, 60),
        new JdeField("GBDL07", "GBDL07", JdeDataType.String, 60),
        new JdeField("GBDL08", "GBDL08", JdeDataType.String, 60),
        new JdeField("GBDL09", "GBDL09", JdeDataType.String, 60),
        new JdeField("GBDL10", "GBDL10", JdeDataType.String, 60),
        new JdeField("GBDL11", "GBDL11", JdeDataType.String, 60),
        new JdeField("GBDL12", "GBDL12", JdeDataType.String, 60),
        new JdeField("GBDL13", "GBDL13", JdeDataType.String, 60),
        new JdeField("GBDL14", "GBDL14", JdeDataType.String, 60),
        new JdeField("GBDL15", "GBDL15", JdeDataType.String, 60),
        new JdeField("GBDL16", "GBDL16", JdeDataType.String, 60),
        new JdeField("GBDL17", "GBDL17", JdeDataType.String, 60),
        new JdeField("GBDL18", "GBDL18", JdeDataType.String, 60),
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
        new JdeField("GBAN45", "GBAN45", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI009_0", "Primary Key on GBJOBS, GBCTID, GBLT, GBCRCD, GBDESC", new[] { "GBJOBS", "GBCTID", "GBLT", "GBCRCD", "GBDESC" }, isUnique: true, isPrimaryKey: true)
    };
}
