using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01161 - .
/// </summary>
public class F01161 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLAN8.
        /// </summary>
        public const string WLAN8 = "WLAN8";

        /// <summary>
        /// WLIDLN.
        /// </summary>
        public const string WLIDLN = "WLIDLN";

        /// <summary>
        /// WLEFTB.
        /// </summary>
        public const string WLEFTB = "WLEFTB";

        /// <summary>
        /// WLATYPE.
        /// </summary>
        public const string WLATYPE = "WLATYPE";

        /// <summary>
        /// WLADD1.
        /// </summary>
        public const string WLADD1 = "WLADD1";

        /// <summary>
        /// WLADD2.
        /// </summary>
        public const string WLADD2 = "WLADD2";

        /// <summary>
        /// WLADD3.
        /// </summary>
        public const string WLADD3 = "WLADD3";

        /// <summary>
        /// WLADD4.
        /// </summary>
        public const string WLADD4 = "WLADD4";

        /// <summary>
        /// WLADDZ.
        /// </summary>
        public const string WLADDZ = "WLADDZ";

        /// <summary>
        /// WLCTY1.
        /// </summary>
        public const string WLCTY1 = "WLCTY1";

        /// <summary>
        /// WLCOUN.
        /// </summary>
        public const string WLCOUN = "WLCOUN";

        /// <summary>
        /// WLADDS.
        /// </summary>
        public const string WLADDS = "WLADDS";

        /// <summary>
        /// WLCTR.
        /// </summary>
        public const string WLCTR = "WLCTR";

        /// <summary>
        /// WLEFTF.
        /// </summary>
        public const string WLEFTF = "WLEFTF";

        /// <summary>
        /// WLUSER.
        /// </summary>
        public const string WLUSER = "WLUSER";

        /// <summary>
        /// WLPID.
        /// </summary>
        public const string WLPID = "WLPID";

        /// <summary>
        /// WLUPMJ.
        /// </summary>
        public const string WLUPMJ = "WLUPMJ";

        /// <summary>
        /// WLJOBN.
        /// </summary>
        public const string WLJOBN = "WLJOBN";

        /// <summary>
        /// WLUPMT.
        /// </summary>
        public const string WLUPMT = "WLUPMT";

        /// <summary>
        /// WLMAINA.
        /// </summary>
        public const string WLMAINA = "WLMAINA";

        /// <summary>
        /// WLSYNCS.
        /// </summary>
        public const string WLSYNCS = "WLSYNCS";

        /// <summary>
        /// WLCAAD.
        /// </summary>
        public const string WLCAAD = "WLCAAD";
    }

    /// <inheritdoc />
    public override string TableName => "F01161";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLAN8", "WLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WLIDLN", "WLIDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("WLEFTB", "WLEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("WLATYPE", "WLATYPE", JdeDataType.String, 10, true, true),
        new JdeField("WLADD1", "WLADD1", JdeDataType.String, 80),
        new JdeField("WLADD2", "WLADD2", JdeDataType.String, 80),
        new JdeField("WLADD3", "WLADD3", JdeDataType.String, 80),
        new JdeField("WLADD4", "WLADD4", JdeDataType.String, 80),
        new JdeField("WLADDZ", "WLADDZ", JdeDataType.String, 24),
        new JdeField("WLCTY1", "WLCTY1", JdeDataType.String, 50),
        new JdeField("WLCOUN", "WLCOUN", JdeDataType.String, 50),
        new JdeField("WLADDS", "WLADDS", JdeDataType.String, 6),
        new JdeField("WLCTR", "WLCTR", JdeDataType.String, 6),
        new JdeField("WLEFTF", "WLEFTF", JdeDataType.String, 2),
        new JdeField("WLUSER", "WLUSER", JdeDataType.String, 20),
        new JdeField("WLPID", "WLPID", JdeDataType.String, 20),
        new JdeField("WLUPMJ", "WLUPMJ", JdeDataType.Numeric),
        new JdeField("WLJOBN", "WLJOBN", JdeDataType.String, 20),
        new JdeField("WLUPMT", "WLUPMT", JdeDataType.Numeric),
        new JdeField("WLMAINA", "WLMAINA", JdeDataType.String, 2),
        new JdeField("WLSYNCS", "WLSYNCS", JdeDataType.Numeric),
        new JdeField("WLCAAD", "WLCAAD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01161_0", "Primary Key on WLAN8, WLIDLN, WLATYPE, WLEFTB", new[] { "WLAN8", "WLIDLN", "WLATYPE", "WLEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
