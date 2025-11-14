using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H602H - .
/// </summary>
public class F44H602H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// THHBAREA.
        /// </summary>
        public const string THHBAREA = "THHBAREA";

        /// <summary>
        /// THHBPLAN.
        /// </summary>
        public const string THHBPLAN = "THHBPLAN";

        /// <summary>
        /// THHBMCUS.
        /// </summary>
        public const string THHBMCUS = "THHBMCUS";

        /// <summary>
        /// THCPHASE.
        /// </summary>
        public const string THCPHASE = "THCPHASE";

        /// <summary>
        /// THHBELEV.
        /// </summary>
        public const string THHBELEV = "THHBELEV";

        /// <summary>
        /// THSWING.
        /// </summary>
        public const string THSWING = "THSWING";

        /// <summary>
        /// THOPTION.
        /// </summary>
        public const string THOPTION = "THOPTION";

        /// <summary>
        /// THITM.
        /// </summary>
        public const string THITM = "THITM";

        /// <summary>
        /// THSUB.
        /// </summary>
        public const string THSUB = "THSUB";

        /// <summary>
        /// THOBJ.
        /// </summary>
        public const string THOBJ = "THOBJ";

        /// <summary>
        /// THTORF.
        /// </summary>
        public const string THTORF = "THTORF";

        /// <summary>
        /// THREFDATE.
        /// </summary>
        public const string THREFDATE = "THREFDATE";

        /// <summary>
        /// THLITM.
        /// </summary>
        public const string THLITM = "THLITM";

        /// <summary>
        /// THAITM.
        /// </summary>
        public const string THAITM = "THAITM";

        /// <summary>
        /// THUORG.
        /// </summary>
        public const string THUORG = "THUORG";

        /// <summary>
        /// THUOM.
        /// </summary>
        public const string THUOM = "THUOM";

        /// <summary>
        /// THSITM.
        /// </summary>
        public const string THSITM = "THSITM";

        /// <summary>
        /// THSQFEET.
        /// </summary>
        public const string THSQFEET = "THSQFEET";

        /// <summary>
        /// THTRC.
        /// </summary>
        public const string THTRC = "THTRC";

        /// <summary>
        /// THDL01.
        /// </summary>
        public const string THDL01 = "THDL01";

        /// <summary>
        /// THITMS.
        /// </summary>
        public const string THITMS = "THITMS";

        /// <summary>
        /// THETF.
        /// </summary>
        public const string THETF = "THETF";

        /// <summary>
        /// THCRTU.
        /// </summary>
        public const string THCRTU = "THCRTU";

        /// <summary>
        /// THCRTJ.
        /// </summary>
        public const string THCRTJ = "THCRTJ";

        /// <summary>
        /// THCRTT.
        /// </summary>
        public const string THCRTT = "THCRTT";

        /// <summary>
        /// THWRKSTNID.
        /// </summary>
        public const string THWRKSTNID = "THWRKSTNID";

        /// <summary>
        /// THHBOPID.
        /// </summary>
        public const string THHBOPID = "THHBOPID";

        /// <summary>
        /// THUPMB.
        /// </summary>
        public const string THUPMB = "THUPMB";

        /// <summary>
        /// THUPMJ.
        /// </summary>
        public const string THUPMJ = "THUPMJ";

        /// <summary>
        /// THUPMT.
        /// </summary>
        public const string THUPMT = "THUPMT";

        /// <summary>
        /// THJOBN.
        /// </summary>
        public const string THJOBN = "THJOBN";

        /// <summary>
        /// THPID.
        /// </summary>
        public const string THPID = "THPID";

        /// <summary>
        /// THHBST1.
        /// </summary>
        public const string THHBST1 = "THHBST1";

        /// <summary>
        /// THHBST2.
        /// </summary>
        public const string THHBST2 = "THHBST2";

        /// <summary>
        /// THHBST3.
        /// </summary>
        public const string THHBST3 = "THHBST3";

        /// <summary>
        /// THHBST4.
        /// </summary>
        public const string THHBST4 = "THHBST4";

        /// <summary>
        /// THHBST5.
        /// </summary>
        public const string THHBST5 = "THHBST5";
    }

    /// <inheritdoc />
    public override string TableName => "F44H602H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("THHBAREA", "THHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("THHBPLAN", "THHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("THHBMCUS", "THHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("THCPHASE", "THCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("THHBELEV", "THHBELEV", JdeDataType.String, 6, true, true),
        new JdeField("THSWING", "THSWING", JdeDataType.String, 2, true, true),
        new JdeField("THOPTION", "THOPTION", JdeDataType.String, 16, true, true),
        new JdeField("THITM", "THITM", JdeDataType.Numeric, null, true, true),
        new JdeField("THSUB", "THSUB", JdeDataType.String, 16, true, true),
        new JdeField("THOBJ", "THOBJ", JdeDataType.String, 12, true, true),
        new JdeField("THTORF", "THTORF", JdeDataType.Numeric, null, true, true),
        new JdeField("THREFDATE", "THREFDATE", JdeDataType.Numeric),
        new JdeField("THLITM", "THLITM", JdeDataType.String, 50),
        new JdeField("THAITM", "THAITM", JdeDataType.String, 50),
        new JdeField("THUORG", "THUORG", JdeDataType.Numeric),
        new JdeField("THUOM", "THUOM", JdeDataType.String, 4),
        new JdeField("THSITM", "THSITM", JdeDataType.String, 16),
        new JdeField("THSQFEET", "THSQFEET", JdeDataType.Numeric),
        new JdeField("THTRC", "THTRC", JdeDataType.String, 6),
        new JdeField("THDL01", "THDL01", JdeDataType.String, 60),
        new JdeField("THITMS", "THITMS", JdeDataType.String, 2),
        new JdeField("THETF", "THETF", JdeDataType.String, 2),
        new JdeField("THCRTU", "THCRTU", JdeDataType.String, 20),
        new JdeField("THCRTJ", "THCRTJ", JdeDataType.Numeric),
        new JdeField("THCRTT", "THCRTT", JdeDataType.Numeric),
        new JdeField("THWRKSTNID", "THWRKSTNID", JdeDataType.String, 20),
        new JdeField("THHBOPID", "THHBOPID", JdeDataType.String, 20),
        new JdeField("THUPMB", "THUPMB", JdeDataType.String, 20),
        new JdeField("THUPMJ", "THUPMJ", JdeDataType.Numeric),
        new JdeField("THUPMT", "THUPMT", JdeDataType.Numeric),
        new JdeField("THJOBN", "THJOBN", JdeDataType.String, 20),
        new JdeField("THPID", "THPID", JdeDataType.String, 20),
        new JdeField("THHBST1", "THHBST1", JdeDataType.String, 2),
        new JdeField("THHBST2", "THHBST2", JdeDataType.String, 2),
        new JdeField("THHBST3", "THHBST3", JdeDataType.String, 2),
        new JdeField("THHBST4", "THHBST4", JdeDataType.String, 2),
        new JdeField("THHBST5", "THHBST5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H602H_0", "Primary Key on THHBAREA, THHBPLAN, THHBMCUS, THCPHASE, THHBELEV, THSWING, THOPTION, THITM, THSUB, THOBJ, THTORF", new[] { "THHBAREA", "THHBPLAN", "THHBMCUS", "THCPHASE", "THHBELEV", "THSWING", "THOPTION", "THITM", "THSUB", "THOBJ", "THTORF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H602H_2", "Index on THHBAREA, THHBPLAN, THHBMCUS, THCPHASE, THHBELEV, THSWING, THOPTION, THLITM, THSUB, THOBJ, THTORF", new[] { "THHBAREA", "THHBPLAN", "THHBMCUS", "THCPHASE", "THHBELEV", "THSWING", "THOPTION", "THLITM", "THSUB", "THOBJ", "THTORF" })
    };
}
