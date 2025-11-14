using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4950 - .
/// </summary>
public class F4950 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTORGN.
        /// </summary>
        public const string RTORGN = "RTORGN";

        /// <summary>
        /// RTADDO.
        /// </summary>
        public const string RTADDO = "RTADDO";

        /// <summary>
        /// RTCTRO.
        /// </summary>
        public const string RTCTRO = "RTCTRO";

        /// <summary>
        /// RTCARS.
        /// </summary>
        public const string RTCARS = "RTCARS";

        /// <summary>
        /// RTNMCU.
        /// </summary>
        public const string RTNMCU = "RTNMCU";

        /// <summary>
        /// RTRTN.
        /// </summary>
        public const string RTRTN = "RTRTN";

        /// <summary>
        /// RTMOT.
        /// </summary>
        public const string RTMOT = "RTMOT";

        /// <summary>
        /// RTCTY1.
        /// </summary>
        public const string RTCTY1 = "RTCTY1";

        /// <summary>
        /// RTCOUN.
        /// </summary>
        public const string RTCOUN = "RTCOUN";

        /// <summary>
        /// RTADDS.
        /// </summary>
        public const string RTADDS = "RTADDS";

        /// <summary>
        /// RTADDZ.
        /// </summary>
        public const string RTADDZ = "RTADDZ";

        /// <summary>
        /// RTZON.
        /// </summary>
        public const string RTZON = "RTZON";

        /// <summary>
        /// RTCTR.
        /// </summary>
        public const string RTCTR = "RTCTR";

        /// <summary>
        /// RTCZON.
        /// </summary>
        public const string RTCZON = "RTCZON";

        /// <summary>
        /// RTSHAN.
        /// </summary>
        public const string RTSHAN = "RTSHAN";

        /// <summary>
        /// RTROUT.
        /// </summary>
        public const string RTROUT = "RTROUT";

        /// <summary>
        /// RTRSLA.
        /// </summary>
        public const string RTRSLA = "RTRSLA";

        /// <summary>
        /// RTDESC.
        /// </summary>
        public const string RTDESC = "RTDESC";

        /// <summary>
        /// RTFRSI.
        /// </summary>
        public const string RTFRSI = "RTFRSI";

        /// <summary>
        /// RTFRSC.
        /// </summary>
        public const string RTFRSC = "RTFRSC";

        /// <summary>
        /// RTFRCI.
        /// </summary>
        public const string RTFRCI = "RTFRCI";

        /// <summary>
        /// RTFRCG.
        /// </summary>
        public const string RTFRCG = "RTFRCG";

        /// <summary>
        /// RTCRCD.
        /// </summary>
        public const string RTCRCD = "RTCRCD";

        /// <summary>
        /// RTFRTP.
        /// </summary>
        public const string RTFRTP = "RTFRTP";

        /// <summary>
        /// RTRTGB.
        /// </summary>
        public const string RTRTGB = "RTRTGB";

        /// <summary>
        /// RTRTUM.
        /// </summary>
        public const string RTRTUM = "RTRTUM";

        /// <summary>
        /// RTDSTN.
        /// </summary>
        public const string RTDSTN = "RTDSTN";

        /// <summary>
        /// RTUMD1.
        /// </summary>
        public const string RTUMD1 = "RTUMD1";

        /// <summary>
        /// RTLTDL.
        /// </summary>
        public const string RTLTDL = "RTLTDL";

        /// <summary>
        /// RTLTDT.
        /// </summary>
        public const string RTLTDT = "RTLTDT";

        /// <summary>
        /// RTPRFM.
        /// </summary>
        public const string RTPRFM = "RTPRFM";

        /// <summary>
        /// RTEFTJ.
        /// </summary>
        public const string RTEFTJ = "RTEFTJ";

        /// <summary>
        /// RTEXDJ.
        /// </summary>
        public const string RTEXDJ = "RTEXDJ";

        /// <summary>
        /// RTMCU.
        /// </summary>
        public const string RTMCU = "RTMCU";

        /// <summary>
        /// RTFCNM.
        /// </summary>
        public const string RTFCNM = "RTFCNM";

        /// <summary>
        /// RTURCD.
        /// </summary>
        public const string RTURCD = "RTURCD";

        /// <summary>
        /// RTURDT.
        /// </summary>
        public const string RTURDT = "RTURDT";

        /// <summary>
        /// RTURAT.
        /// </summary>
        public const string RTURAT = "RTURAT";

        /// <summary>
        /// RTURAB.
        /// </summary>
        public const string RTURAB = "RTURAB";

        /// <summary>
        /// RTURRF.
        /// </summary>
        public const string RTURRF = "RTURRF";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTTDAY.
        /// </summary>
        public const string RTTDAY = "RTTDAY";

        /// <summary>
        /// RTPRTE.
        /// </summary>
        public const string RTPRTE = "RTPRTE";

        /// <summary>
        /// RTCNMR.
        /// </summary>
        public const string RTCNMR = "RTCNMR";

        /// <summary>
        /// RTTX.
        /// </summary>
        public const string RTTX = "RTTX";

        /// <summary>
        /// RTTXA1.
        /// </summary>
        public const string RTTXA1 = "RTTXA1";

        /// <summary>
        /// RTEXR1.
        /// </summary>
        public const string RTEXR1 = "RTEXR1";

        /// <summary>
        /// RTTAX1.
        /// </summary>
        public const string RTTAX1 = "RTTAX1";

        /// <summary>
        /// RTTXA2.
        /// </summary>
        public const string RTTXA2 = "RTTXA2";

        /// <summary>
        /// RTEXR2.
        /// </summary>
        public const string RTEXR2 = "RTEXR2";
    }

    /// <inheritdoc />
    public override string TableName => "F4950";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTORGN", "RTORGN", JdeDataType.Numeric),
        new JdeField("RTADDO", "RTADDO", JdeDataType.String, 24),
        new JdeField("RTCTRO", "RTCTRO", JdeDataType.String, 6),
        new JdeField("RTCARS", "RTCARS", JdeDataType.Numeric),
        new JdeField("RTNMCU", "RTNMCU", JdeDataType.String, 24),
        new JdeField("RTRTN", "RTRTN", JdeDataType.Numeric, null, true, true),
        new JdeField("RTMOT", "RTMOT", JdeDataType.String, 6),
        new JdeField("RTCTY1", "RTCTY1", JdeDataType.String, 50),
        new JdeField("RTCOUN", "RTCOUN", JdeDataType.String, 50),
        new JdeField("RTADDS", "RTADDS", JdeDataType.String, 6),
        new JdeField("RTADDZ", "RTADDZ", JdeDataType.String, 24),
        new JdeField("RTZON", "RTZON", JdeDataType.String, 6),
        new JdeField("RTCTR", "RTCTR", JdeDataType.String, 6),
        new JdeField("RTCZON", "RTCZON", JdeDataType.String, 20),
        new JdeField("RTSHAN", "RTSHAN", JdeDataType.Numeric),
        new JdeField("RTROUT", "RTROUT", JdeDataType.String, 6),
        new JdeField("RTRSLA", "RTRSLA", JdeDataType.String, 2),
        new JdeField("RTDESC", "RTDESC", JdeDataType.String, 60),
        new JdeField("RTFRSI", "RTFRSI", JdeDataType.String, 16),
        new JdeField("RTFRSC", "RTFRSC", JdeDataType.String, 16),
        new JdeField("RTFRCI", "RTFRCI", JdeDataType.Numeric),
        new JdeField("RTFRCG", "RTFRCG", JdeDataType.Numeric),
        new JdeField("RTCRCD", "RTCRCD", JdeDataType.String, 6),
        new JdeField("RTFRTP", "RTFRTP", JdeDataType.String, 2),
        new JdeField("RTRTGB", "RTRTGB", JdeDataType.String, 2),
        new JdeField("RTRTUM", "RTRTUM", JdeDataType.String, 4),
        new JdeField("RTDSTN", "RTDSTN", JdeDataType.Numeric),
        new JdeField("RTUMD1", "RTUMD1", JdeDataType.String, 4),
        new JdeField("RTLTDL", "RTLTDL", JdeDataType.Numeric),
        new JdeField("RTLTDT", "RTLTDT", JdeDataType.Numeric),
        new JdeField("RTPRFM", "RTPRFM", JdeDataType.Numeric),
        new JdeField("RTEFTJ", "RTEFTJ", JdeDataType.Numeric),
        new JdeField("RTEXDJ", "RTEXDJ", JdeDataType.Numeric),
        new JdeField("RTMCU", "RTMCU", JdeDataType.String, 24),
        new JdeField("RTFCNM", "RTFCNM", JdeDataType.String, 64),
        new JdeField("RTURCD", "RTURCD", JdeDataType.String, 4),
        new JdeField("RTURDT", "RTURDT", JdeDataType.Numeric),
        new JdeField("RTURAT", "RTURAT", JdeDataType.Numeric),
        new JdeField("RTURAB", "RTURAB", JdeDataType.Numeric),
        new JdeField("RTURRF", "RTURRF", JdeDataType.String, 30),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTTDAY", "RTTDAY", JdeDataType.Numeric),
        new JdeField("RTPRTE", "RTPRTE", JdeDataType.String, 2),
        new JdeField("RTCNMR", "RTCNMR", JdeDataType.String, 48),
        new JdeField("RTTX", "RTTX", JdeDataType.String, 2),
        new JdeField("RTTXA1", "RTTXA1", JdeDataType.String, 20),
        new JdeField("RTEXR1", "RTEXR1", JdeDataType.String, 4),
        new JdeField("RTTAX1", "RTTAX1", JdeDataType.String, 2),
        new JdeField("RTTXA2", "RTTXA2", JdeDataType.String, 20),
        new JdeField("RTEXR2", "RTEXR2", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4950_0", "Primary Key on RTRTN", new[] { "RTRTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4950_10", "Index on RTSHAN", new[] { "RTSHAN" }),
        new JdeIndex("F4950_11", "Index on RTCZON", new[] { "RTCZON" }),
        new JdeIndex("F4950_12", "Index on RTCTY1, RTADDS, RTCTR", new[] { "RTCTY1", "RTADDS", "RTCTR" }),
        new JdeIndex("F4950_13", "Index on RTCOUN, RTADDS, RTCTR", new[] { "RTCOUN", "RTADDS", "RTCTR" }),
        new JdeIndex("F4950_14", "Index on RTADDS, RTCTR", new[] { "RTADDS", "RTCTR" }),
        new JdeIndex("F4950_15", "Index on RTZON", new[] { "RTZON" }),
        new JdeIndex("F4950_16", "Index on RTCTR", new[] { "RTCTR" }),
        new JdeIndex("F4950_17", "Index on RTCTY1, RTCOUN, RTADDS, RTCTR, RTADDZ, RTZON, RTCZON, RTSHAN, RTROUT", new[] { "RTCTY1", "RTCOUN", "RTADDS", "RTCTR", "RTADDZ", "RTZON", "RTCZON", "RTSHAN", "RTROUT" }),
        new JdeIndex("F4950_18", "Index on RTORGN", new[] { "RTORGN" }),
        new JdeIndex("F4950_19", "Index on RTNMCU", new[] { "RTNMCU" }),
        new JdeIndex("F4950_20", "Index on RTADDO", new[] { "RTADDO" }),
        new JdeIndex("F4950_6", "Index on RTROUT", new[] { "RTROUT" }),
        new JdeIndex("F4950_9", "Index on RTADDZ, RTCTR", new[] { "RTADDZ", "RTCTR" })
    };
}
