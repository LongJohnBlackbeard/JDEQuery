using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H603 - .
/// </summary>
public class F44H603 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MPHBAREA.
        /// </summary>
        public const string MPHBAREA = "MPHBAREA";

        /// <summary>
        /// MPITM.
        /// </summary>
        public const string MPITM = "MPITM";

        /// <summary>
        /// MPAN8.
        /// </summary>
        public const string MPAN8 = "MPAN8";

        /// <summary>
        /// MPHBMCUS.
        /// </summary>
        public const string MPHBMCUS = "MPHBMCUS";

        /// <summary>
        /// MPCPHASE.
        /// </summary>
        public const string MPCPHASE = "MPCPHASE";

        /// <summary>
        /// MPEFFF.
        /// </summary>
        public const string MPEFFF = "MPEFFF";

        /// <summary>
        /// MPUOM3.
        /// </summary>
        public const string MPUOM3 = "MPUOM3";

        /// <summary>
        /// MPLITM.
        /// </summary>
        public const string MPLITM = "MPLITM";

        /// <summary>
        /// MPAITM.
        /// </summary>
        public const string MPAITM = "MPAITM";

        /// <summary>
        /// MPEXPR.
        /// </summary>
        public const string MPEXPR = "MPEXPR";

        /// <summary>
        /// MPPRN.
        /// </summary>
        public const string MPPRN = "MPPRN";

        /// <summary>
        /// MPUPRC.
        /// </summary>
        public const string MPUPRC = "MPUPRC";

        /// <summary>
        /// MPPRS.
        /// </summary>
        public const string MPPRS = "MPPRS";

        /// <summary>
        /// MPPFR.
        /// </summary>
        public const string MPPFR = "MPPFR";

        /// <summary>
        /// MPPCRT.
        /// </summary>
        public const string MPPCRT = "MPPCRT";

        /// <summary>
        /// MPPOA.
        /// </summary>
        public const string MPPOA = "MPPOA";

        /// <summary>
        /// MPTX.
        /// </summary>
        public const string MPTX = "MPTX";

        /// <summary>
        /// MPTXA1.
        /// </summary>
        public const string MPTXA1 = "MPTXA1";

        /// <summary>
        /// MPEXR1.
        /// </summary>
        public const string MPEXR1 = "MPEXR1";

        /// <summary>
        /// MPLDT.
        /// </summary>
        public const string MPLDT = "MPLDT";

        /// <summary>
        /// MPELDT.
        /// </summary>
        public const string MPELDT = "MPELDT";

        /// <summary>
        /// MPESQ.
        /// </summary>
        public const string MPESQ = "MPESQ";

        /// <summary>
        /// MPXSQ.
        /// </summary>
        public const string MPXSQ = "MPXSQ";

        /// <summary>
        /// MPLTN.
        /// </summary>
        public const string MPLTN = "MPLTN";

        /// <summary>
        /// MPONR.
        /// </summary>
        public const string MPONR = "MPONR";

        /// <summary>
        /// MPDSCT.
        /// </summary>
        public const string MPDSCT = "MPDSCT";

        /// <summary>
        /// MPDSPC.
        /// </summary>
        public const string MPDSPC = "MPDSPC";

        /// <summary>
        /// MPDSQT.
        /// </summary>
        public const string MPDSQT = "MPDSQT";

        /// <summary>
        /// MPMDF.
        /// </summary>
        public const string MPMDF = "MPMDF";

        /// <summary>
        /// MPMDA.
        /// </summary>
        public const string MPMDA = "MPMDA";

        /// <summary>
        /// MPMDP.
        /// </summary>
        public const string MPMDP = "MPMDP";

        /// <summary>
        /// MPMDQ.
        /// </summary>
        public const string MPMDQ = "MPMDQ";

        /// <summary>
        /// MPDDC.
        /// </summary>
        public const string MPDDC = "MPDDC";

        /// <summary>
        /// MPBDS.
        /// </summary>
        public const string MPBDS = "MPBDS";

        /// <summary>
        /// MPBDF.
        /// </summary>
        public const string MPBDF = "MPBDF";

        /// <summary>
        /// MPCTN.
        /// </summary>
        public const string MPCTN = "MPCTN";

        /// <summary>
        /// MPSDS1.
        /// </summary>
        public const string MPSDS1 = "MPSDS1";

        /// <summary>
        /// MPHBST1.
        /// </summary>
        public const string MPHBST1 = "MPHBST1";

        /// <summary>
        /// MPHBST2.
        /// </summary>
        public const string MPHBST2 = "MPHBST2";

        /// <summary>
        /// MPHBST3.
        /// </summary>
        public const string MPHBST3 = "MPHBST3";

        /// <summary>
        /// MPHBST4.
        /// </summary>
        public const string MPHBST4 = "MPHBST4";

        /// <summary>
        /// MPHBST5.
        /// </summary>
        public const string MPHBST5 = "MPHBST5";

        /// <summary>
        /// MPCRTU.
        /// </summary>
        public const string MPCRTU = "MPCRTU";

        /// <summary>
        /// MPCRTJ.
        /// </summary>
        public const string MPCRTJ = "MPCRTJ";

        /// <summary>
        /// MPCRTT.
        /// </summary>
        public const string MPCRTT = "MPCRTT";

        /// <summary>
        /// MPWRKSTNID.
        /// </summary>
        public const string MPWRKSTNID = "MPWRKSTNID";

        /// <summary>
        /// MPHBOPID.
        /// </summary>
        public const string MPHBOPID = "MPHBOPID";

        /// <summary>
        /// MPUPMB.
        /// </summary>
        public const string MPUPMB = "MPUPMB";

        /// <summary>
        /// MPUPMJ.
        /// </summary>
        public const string MPUPMJ = "MPUPMJ";

        /// <summary>
        /// MPUPMT.
        /// </summary>
        public const string MPUPMT = "MPUPMT";

        /// <summary>
        /// MPJOBN.
        /// </summary>
        public const string MPJOBN = "MPJOBN";

        /// <summary>
        /// MPPID.
        /// </summary>
        public const string MPPID = "MPPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H603";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MPHBAREA", "MPHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("MPITM", "MPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MPAN8", "MPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MPHBMCUS", "MPHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("MPCPHASE", "MPCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("MPEFFF", "MPEFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("MPUOM3", "MPUOM3", JdeDataType.String, 4),
        new JdeField("MPLITM", "MPLITM", JdeDataType.String, 50),
        new JdeField("MPAITM", "MPAITM", JdeDataType.String, 50),
        new JdeField("MPEXPR", "MPEXPR", JdeDataType.Numeric),
        new JdeField("MPPRN", "MPPRN", JdeDataType.Numeric),
        new JdeField("MPUPRC", "MPUPRC", JdeDataType.Numeric),
        new JdeField("MPPRS", "MPPRS", JdeDataType.String, 2),
        new JdeField("MPPFR", "MPPFR", JdeDataType.Numeric),
        new JdeField("MPPCRT", "MPPCRT", JdeDataType.Numeric),
        new JdeField("MPPOA", "MPPOA", JdeDataType.Numeric),
        new JdeField("MPTX", "MPTX", JdeDataType.String, 2),
        new JdeField("MPTXA1", "MPTXA1", JdeDataType.String, 20),
        new JdeField("MPEXR1", "MPEXR1", JdeDataType.String, 4),
        new JdeField("MPLDT", "MPLDT", JdeDataType.Numeric),
        new JdeField("MPELDT", "MPELDT", JdeDataType.Numeric),
        new JdeField("MPESQ", "MPESQ", JdeDataType.String, 6),
        new JdeField("MPXSQ", "MPXSQ", JdeDataType.String, 6),
        new JdeField("MPLTN", "MPLTN", JdeDataType.String, 50),
        new JdeField("MPONR", "MPONR", JdeDataType.String, 2),
        new JdeField("MPDSCT", "MPDSCT", JdeDataType.Numeric),
        new JdeField("MPDSPC", "MPDSPC", JdeDataType.Numeric),
        new JdeField("MPDSQT", "MPDSQT", JdeDataType.Numeric),
        new JdeField("MPMDF", "MPMDF", JdeDataType.String, 2),
        new JdeField("MPMDA", "MPMDA", JdeDataType.Numeric),
        new JdeField("MPMDP", "MPMDP", JdeDataType.Numeric),
        new JdeField("MPMDQ", "MPMDQ", JdeDataType.Numeric),
        new JdeField("MPDDC", "MPDDC", JdeDataType.String, 50),
        new JdeField("MPBDS", "MPBDS", JdeDataType.String, 2),
        new JdeField("MPBDF", "MPBDF", JdeDataType.String, 2),
        new JdeField("MPCTN", "MPCTN", JdeDataType.String, 30),
        new JdeField("MPSDS1", "MPSDS1", JdeDataType.String, 100),
        new JdeField("MPHBST1", "MPHBST1", JdeDataType.String, 2),
        new JdeField("MPHBST2", "MPHBST2", JdeDataType.String, 2),
        new JdeField("MPHBST3", "MPHBST3", JdeDataType.String, 2),
        new JdeField("MPHBST4", "MPHBST4", JdeDataType.String, 2),
        new JdeField("MPHBST5", "MPHBST5", JdeDataType.String, 2),
        new JdeField("MPCRTU", "MPCRTU", JdeDataType.String, 20),
        new JdeField("MPCRTJ", "MPCRTJ", JdeDataType.Numeric),
        new JdeField("MPCRTT", "MPCRTT", JdeDataType.Numeric),
        new JdeField("MPWRKSTNID", "MPWRKSTNID", JdeDataType.String, 20),
        new JdeField("MPHBOPID", "MPHBOPID", JdeDataType.String, 20),
        new JdeField("MPUPMB", "MPUPMB", JdeDataType.String, 20),
        new JdeField("MPUPMJ", "MPUPMJ", JdeDataType.Numeric),
        new JdeField("MPUPMT", "MPUPMT", JdeDataType.Numeric),
        new JdeField("MPJOBN", "MPJOBN", JdeDataType.String, 20),
        new JdeField("MPPID", "MPPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H603_0", "Primary Key on MPHBAREA, MPITM, MPAN8, MPHBMCUS, MPCPHASE, MPEFFF", new[] { "MPHBAREA", "MPITM", "MPAN8", "MPHBMCUS", "MPCPHASE", "MPEFFF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H603_2", "Index on MPHBAREA, MPITM, MPAN8, SYS_NC00053$, SYS_NC00054$, MPEFFF", new[] { "MPHBAREA", "MPITM", "MPAN8", "SYS_NC00053$", "SYS_NC00054$", "MPEFFF" }),
        new JdeIndex("F44H603_3", "Index on MPHBAREA, MPITM, MPAN8, MPHBMCUS, MPCPHASE, MPEFFF, MPEXPR", new[] { "MPHBAREA", "MPITM", "MPAN8", "MPHBMCUS", "MPCPHASE", "MPEFFF", "MPEXPR" })
    };
}
