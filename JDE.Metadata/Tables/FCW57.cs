using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW57 - .
/// </summary>
public class FCW57 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFOPC.
        /// </summary>
        public const string WFOPC = "WFOPC";

        /// <summary>
        /// WFOPV.
        /// </summary>
        public const string WFOPV = "WFOPV";

        /// <summary>
        /// WFMPST.
        /// </summary>
        public const string WFMPST = "WFMPST";

        /// <summary>
        /// WFMPSP.
        /// </summary>
        public const string WFMPSP = "WFMPSP";

        /// <summary>
        /// WFMTF1.
        /// </summary>
        public const string WFMTF1 = "WFMTF1";

        /// <summary>
        /// WFMTF2.
        /// </summary>
        public const string WFMTF2 = "WFMTF2";

        /// <summary>
        /// WFMTF3.
        /// </summary>
        public const string WFMTF3 = "WFMTF3";

        /// <summary>
        /// WFACQ.
        /// </summary>
        public const string WFACQ = "WFACQ";

        /// <summary>
        /// WFITC.
        /// </summary>
        public const string WFITC = "WFITC";

        /// <summary>
        /// WFSNS.
        /// </summary>
        public const string WFSNS = "WFSNS";

        /// <summary>
        /// WFDSZE.
        /// </summary>
        public const string WFDSZE = "WFDSZE";

        /// <summary>
        /// WFRVNO.
        /// </summary>
        public const string WFRVNO = "WFRVNO";

        /// <summary>
        /// WFDRAW.
        /// </summary>
        public const string WFDRAW = "WFDRAW";

        /// <summary>
        /// WFMLQ.
        /// </summary>
        public const string WFMLQ = "WFMLQ";

        /// <summary>
        /// WFLTLV.
        /// </summary>
        public const string WFLTLV = "WFLTLV";

        /// <summary>
        /// WFKBIT.
        /// </summary>
        public const string WFKBIT = "WFKBIT";

        /// <summary>
        /// WFLTMF.
        /// </summary>
        public const string WFLTMF = "WFLTMF";

        /// <summary>
        /// WFLTPU.
        /// </summary>
        public const string WFLTPU = "WFLTPU";

        /// <summary>
        /// WFAING.
        /// </summary>
        public const string WFAING = "WFAING";

        /// <summary>
        /// WFLTCM.
        /// </summary>
        public const string WFLTCM = "WFLTCM";

        /// <summary>
        /// WFMRPP.
        /// </summary>
        public const string WFMRPP = "WFMRPP";

        /// <summary>
        /// WFPTSC.
        /// </summary>
        public const string WFPTSC = "WFPTSC";

        /// <summary>
        /// WFPRPO.
        /// </summary>
        public const string WFPRPO = "WFPRPO";

        /// <summary>
        /// WFOT1Y.
        /// </summary>
        public const string WFOT1Y = "WFOT1Y";

        /// <summary>
        /// WFSTDP.
        /// </summary>
        public const string WFSTDP = "WFSTDP";

        /// <summary>
        /// WFFRMP.
        /// </summary>
        public const string WFFRMP = "WFFRMP";

        /// <summary>
        /// WFTHRP.
        /// </summary>
        public const string WFTHRP = "WFTHRP";

        /// <summary>
        /// WFOT2Y.
        /// </summary>
        public const string WFOT2Y = "WFOT2Y";

        /// <summary>
        /// WFSTDG.
        /// </summary>
        public const string WFSTDG = "WFSTDG";

        /// <summary>
        /// WFFRGD.
        /// </summary>
        public const string WFFRGD = "WFFRGD";

        /// <summary>
        /// WFTHGD.
        /// </summary>
        public const string WFTHGD = "WFTHGD";

        /// <summary>
        /// WFAPSC.
        /// </summary>
        public const string WFAPSC = "WFAPSC";

        /// <summary>
        /// WFCONB.
        /// </summary>
        public const string WFCONB = "WFCONB";

        /// <summary>
        /// WFPRI1.
        /// </summary>
        public const string WFPRI1 = "WFPRI1";

        /// <summary>
        /// WFPRI2.
        /// </summary>
        public const string WFPRI2 = "WFPRI2";

        /// <summary>
        /// WFGCMP.
        /// </summary>
        public const string WFGCMP = "WFGCMP";

        /// <summary>
        /// WFAVRT.
        /// </summary>
        public const string WFAVRT = "WFAVRT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW57";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFOPC", "WFOPC", JdeDataType.String, 2),
        new JdeField("WFOPV", "WFOPV", JdeDataType.Numeric),
        new JdeField("WFMPST", "WFMPST", JdeDataType.String, 2),
        new JdeField("WFMPSP", "WFMPSP", JdeDataType.String, 2),
        new JdeField("WFMTF1", "WFMTF1", JdeDataType.Numeric),
        new JdeField("WFMTF2", "WFMTF2", JdeDataType.Numeric),
        new JdeField("WFMTF3", "WFMTF3", JdeDataType.Numeric),
        new JdeField("WFACQ", "WFACQ", JdeDataType.Numeric),
        new JdeField("WFITC", "WFITC", JdeDataType.String, 2),
        new JdeField("WFSNS", "WFSNS", JdeDataType.String, 2),
        new JdeField("WFDSZE", "WFDSZE", JdeDataType.String, 2),
        new JdeField("WFRVNO", "WFRVNO", JdeDataType.String, 4),
        new JdeField("WFDRAW", "WFDRAW", JdeDataType.String, 40),
        new JdeField("WFMLQ", "WFMLQ", JdeDataType.Numeric),
        new JdeField("WFLTLV", "WFLTLV", JdeDataType.Numeric),
        new JdeField("WFKBIT", "WFKBIT", JdeDataType.String, 2),
        new JdeField("WFLTMF", "WFLTMF", JdeDataType.Numeric),
        new JdeField("WFLTPU", "WFLTPU", JdeDataType.Numeric),
        new JdeField("WFAING", "WFAING", JdeDataType.String, 2),
        new JdeField("WFLTCM", "WFLTCM", JdeDataType.Numeric),
        new JdeField("WFMRPP", "WFMRPP", JdeDataType.String, 2),
        new JdeField("WFPTSC", "WFPTSC", JdeDataType.String, 4),
        new JdeField("WFPRPO", "WFPRPO", JdeDataType.String, 2),
        new JdeField("WFOT1Y", "WFOT1Y", JdeDataType.String, 2),
        new JdeField("WFSTDP", "WFSTDP", JdeDataType.Numeric),
        new JdeField("WFFRMP", "WFFRMP", JdeDataType.Numeric),
        new JdeField("WFTHRP", "WFTHRP", JdeDataType.Numeric),
        new JdeField("WFOT2Y", "WFOT2Y", JdeDataType.String, 2),
        new JdeField("WFSTDG", "WFSTDG", JdeDataType.String, 6),
        new JdeField("WFFRGD", "WFFRGD", JdeDataType.String, 6),
        new JdeField("WFTHGD", "WFTHGD", JdeDataType.String, 6),
        new JdeField("WFAPSC", "WFAPSC", JdeDataType.String, 2),
        new JdeField("WFCONB", "WFCONB", JdeDataType.String, 2),
        new JdeField("WFPRI1", "WFPRI1", JdeDataType.Numeric),
        new JdeField("WFPRI2", "WFPRI2", JdeDataType.Numeric),
        new JdeField("WFGCMP", "WFGCMP", JdeDataType.String, 2),
        new JdeField("WFAVRT", "WFAVRT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW57_0", "Primary Key on WFITM, WFEV01", new[] { "WFITM", "WFEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
