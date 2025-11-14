using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H602 - .
/// </summary>
public class F44H602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TOHBAREA.
        /// </summary>
        public const string TOHBAREA = "TOHBAREA";

        /// <summary>
        /// TOHBPLAN.
        /// </summary>
        public const string TOHBPLAN = "TOHBPLAN";

        /// <summary>
        /// TOHBMCUS.
        /// </summary>
        public const string TOHBMCUS = "TOHBMCUS";

        /// <summary>
        /// TOCPHASE.
        /// </summary>
        public const string TOCPHASE = "TOCPHASE";

        /// <summary>
        /// TOHBELEV.
        /// </summary>
        public const string TOHBELEV = "TOHBELEV";

        /// <summary>
        /// TOSWING.
        /// </summary>
        public const string TOSWING = "TOSWING";

        /// <summary>
        /// TOOPTION.
        /// </summary>
        public const string TOOPTION = "TOOPTION";

        /// <summary>
        /// TOSUB.
        /// </summary>
        public const string TOSUB = "TOSUB";

        /// <summary>
        /// TOOBJ.
        /// </summary>
        public const string TOOBJ = "TOOBJ";

        /// <summary>
        /// TOITM.
        /// </summary>
        public const string TOITM = "TOITM";

        /// <summary>
        /// TOLITM.
        /// </summary>
        public const string TOLITM = "TOLITM";

        /// <summary>
        /// TOAITM.
        /// </summary>
        public const string TOAITM = "TOAITM";

        /// <summary>
        /// TOTORF.
        /// </summary>
        public const string TOTORF = "TOTORF";

        /// <summary>
        /// TOUORG.
        /// </summary>
        public const string TOUORG = "TOUORG";

        /// <summary>
        /// TOUOM.
        /// </summary>
        public const string TOUOM = "TOUOM";

        /// <summary>
        /// TOSUBITEM.
        /// </summary>
        public const string TOSUBITEM = "TOSUBITEM";

        /// <summary>
        /// TOSQFEET.
        /// </summary>
        public const string TOSQFEET = "TOSQFEET";

        /// <summary>
        /// TOTRC.
        /// </summary>
        public const string TOTRC = "TOTRC";

        /// <summary>
        /// TODL01.
        /// </summary>
        public const string TODL01 = "TODL01";

        /// <summary>
        /// TOITMS.
        /// </summary>
        public const string TOITMS = "TOITMS";

        /// <summary>
        /// TOETF.
        /// </summary>
        public const string TOETF = "TOETF";

        /// <summary>
        /// TOCRTU.
        /// </summary>
        public const string TOCRTU = "TOCRTU";

        /// <summary>
        /// TOCRTJ.
        /// </summary>
        public const string TOCRTJ = "TOCRTJ";

        /// <summary>
        /// TOCRTT.
        /// </summary>
        public const string TOCRTT = "TOCRTT";

        /// <summary>
        /// TOWRKSTNID.
        /// </summary>
        public const string TOWRKSTNID = "TOWRKSTNID";

        /// <summary>
        /// TOHBOPID.
        /// </summary>
        public const string TOHBOPID = "TOHBOPID";

        /// <summary>
        /// TOUPMB.
        /// </summary>
        public const string TOUPMB = "TOUPMB";

        /// <summary>
        /// TOUPMJ.
        /// </summary>
        public const string TOUPMJ = "TOUPMJ";

        /// <summary>
        /// TOUPMT.
        /// </summary>
        public const string TOUPMT = "TOUPMT";

        /// <summary>
        /// TOJOBN.
        /// </summary>
        public const string TOJOBN = "TOJOBN";

        /// <summary>
        /// TOPID.
        /// </summary>
        public const string TOPID = "TOPID";

        /// <summary>
        /// TOHBST1.
        /// </summary>
        public const string TOHBST1 = "TOHBST1";

        /// <summary>
        /// TOHBST2.
        /// </summary>
        public const string TOHBST2 = "TOHBST2";

        /// <summary>
        /// TOHBST3.
        /// </summary>
        public const string TOHBST3 = "TOHBST3";

        /// <summary>
        /// TOHBST4.
        /// </summary>
        public const string TOHBST4 = "TOHBST4";

        /// <summary>
        /// TOHBST5.
        /// </summary>
        public const string TOHBST5 = "TOHBST5";
    }

    /// <inheritdoc />
    public override string TableName => "F44H602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TOHBAREA", "TOHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("TOHBPLAN", "TOHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("TOHBMCUS", "TOHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("TOCPHASE", "TOCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("TOHBELEV", "TOHBELEV", JdeDataType.String, 6, true, true),
        new JdeField("TOSWING", "TOSWING", JdeDataType.String, 2, true, true),
        new JdeField("TOOPTION", "TOOPTION", JdeDataType.String, 16, true, true),
        new JdeField("TOSUB", "TOSUB", JdeDataType.String, 16, true, true),
        new JdeField("TOOBJ", "TOOBJ", JdeDataType.String, 12, true, true),
        new JdeField("TOITM", "TOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TOLITM", "TOLITM", JdeDataType.String, 50),
        new JdeField("TOAITM", "TOAITM", JdeDataType.String, 50),
        new JdeField("TOTORF", "TOTORF", JdeDataType.Numeric),
        new JdeField("TOUORG", "TOUORG", JdeDataType.Numeric),
        new JdeField("TOUOM", "TOUOM", JdeDataType.String, 4),
        new JdeField("TOSUBITEM", "TOSUBITEM", JdeDataType.String, 50),
        new JdeField("TOSQFEET", "TOSQFEET", JdeDataType.Numeric),
        new JdeField("TOTRC", "TOTRC", JdeDataType.String, 6),
        new JdeField("TODL01", "TODL01", JdeDataType.String, 60),
        new JdeField("TOITMS", "TOITMS", JdeDataType.String, 2),
        new JdeField("TOETF", "TOETF", JdeDataType.String, 2),
        new JdeField("TOCRTU", "TOCRTU", JdeDataType.String, 20),
        new JdeField("TOCRTJ", "TOCRTJ", JdeDataType.Numeric),
        new JdeField("TOCRTT", "TOCRTT", JdeDataType.Numeric),
        new JdeField("TOWRKSTNID", "TOWRKSTNID", JdeDataType.String, 20),
        new JdeField("TOHBOPID", "TOHBOPID", JdeDataType.String, 20),
        new JdeField("TOUPMB", "TOUPMB", JdeDataType.String, 20),
        new JdeField("TOUPMJ", "TOUPMJ", JdeDataType.Numeric),
        new JdeField("TOUPMT", "TOUPMT", JdeDataType.Numeric),
        new JdeField("TOJOBN", "TOJOBN", JdeDataType.String, 20),
        new JdeField("TOPID", "TOPID", JdeDataType.String, 20),
        new JdeField("TOHBST1", "TOHBST1", JdeDataType.String, 2),
        new JdeField("TOHBST2", "TOHBST2", JdeDataType.String, 2),
        new JdeField("TOHBST3", "TOHBST3", JdeDataType.String, 2),
        new JdeField("TOHBST4", "TOHBST4", JdeDataType.String, 2),
        new JdeField("TOHBST5", "TOHBST5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H602_0", "Primary Key on TOHBAREA, TOHBPLAN, TOHBMCUS, TOCPHASE, TOHBELEV, TOSWING, TOOPTION, TOSUB, TOOBJ, TOITM", new[] { "TOHBAREA", "TOHBPLAN", "TOHBMCUS", "TOCPHASE", "TOHBELEV", "TOSWING", "TOOPTION", "TOSUB", "TOOBJ", "TOITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H602_2", "Unique Index on TOHBAREA, TOHBPLAN, TOHBMCUS, TOCPHASE, TOHBELEV, TOSWING, TOOPTION, TOSUB, TOOBJ, TOLITM", new[] { "TOHBAREA", "TOHBPLAN", "TOHBMCUS", "TOCPHASE", "TOHBELEV", "TOSWING", "TOOPTION", "TOSUB", "TOOBJ", "TOLITM" }, isUnique: true),
        new JdeIndex("F44H602_3", "Index on TOITM, TOOPTION, TOSUB, TOOBJ, TOETF, TOHBAREA, TOHBPLAN, TOHBMCUS, TOCPHASE, TOHBELEV, TOSWING", new[] { "TOITM", "TOOPTION", "TOSUB", "TOOBJ", "TOETF", "TOHBAREA", "TOHBPLAN", "TOHBMCUS", "TOCPHASE", "TOHBELEV", "TOSWING" })
    };
}
