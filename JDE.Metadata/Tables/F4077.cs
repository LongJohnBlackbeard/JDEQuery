using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4077 - .
/// </summary>
public class F4077 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTAST.
        /// </summary>
        public const string RTAST = "RTAST";

        /// <summary>
        /// RTAN8.
        /// </summary>
        public const string RTAN8 = "RTAN8";

        /// <summary>
        /// RTITM.
        /// </summary>
        public const string RTITM = "RTITM";

        /// <summary>
        /// RTIGID.
        /// </summary>
        public const string RTIGID = "RTIGID";

        /// <summary>
        /// RTCGID.
        /// </summary>
        public const string RTCGID = "RTCGID";

        /// <summary>
        /// RTLITM.
        /// </summary>
        public const string RTLITM = "RTLITM";

        /// <summary>
        /// RTAITM.
        /// </summary>
        public const string RTAITM = "RTAITM";

        /// <summary>
        /// RTEFTJ.
        /// </summary>
        public const string RTEFTJ = "RTEFTJ";

        /// <summary>
        /// RTEXDJ.
        /// </summary>
        public const string RTEXDJ = "RTEXDJ";

        /// <summary>
        /// RTCRCD.
        /// </summary>
        public const string RTCRCD = "RTCRCD";

        /// <summary>
        /// RTUOM.
        /// </summary>
        public const string RTUOM = "RTUOM";

        /// <summary>
        /// RTTHRV.
        /// </summary>
        public const string RTTHRV = "RTTHRV";

        /// <summary>
        /// RTMCU.
        /// </summary>
        public const string RTMCU = "RTMCU";

        /// <summary>
        /// RTRSTH.
        /// </summary>
        public const string RTRSTH = "RTRSTH";

        /// <summary>
        /// RTRBTF.
        /// </summary>
        public const string RTRBTF = "RTRBTF";

        /// <summary>
        /// RTREBN.
        /// </summary>
        public const string RTREBN = "RTREBN";

        /// <summary>
        /// RTRBRM.
        /// </summary>
        public const string RTRBRM = "RTRBRM";

        /// <summary>
        /// RTRTF1.
        /// </summary>
        public const string RTRTF1 = "RTRTF1";

        /// <summary>
        /// RTRTF2.
        /// </summary>
        public const string RTRTF2 = "RTRTF2";

        /// <summary>
        /// RTRTF3.
        /// </summary>
        public const string RTRTF3 = "RTRTF3";

        /// <summary>
        /// RTRTF4.
        /// </summary>
        public const string RTRTF4 = "RTRTF4";

        /// <summary>
        /// RTRTF5.
        /// </summary>
        public const string RTRTF5 = "RTRTF5";

        /// <summary>
        /// RTURDT.
        /// </summary>
        public const string RTURDT = "RTURDT";

        /// <summary>
        /// RTURAT.
        /// </summary>
        public const string RTURAT = "RTURAT";

        /// <summary>
        /// RTURC1.
        /// </summary>
        public const string RTURC1 = "RTURC1";

        /// <summary>
        /// RTAPRS.
        /// </summary>
        public const string RTAPRS = "RTAPRS";

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
    }

    /// <inheritdoc />
    public override string TableName => "F4077";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTAST", "RTAST", JdeDataType.String, 16, true, true),
        new JdeField("RTAN8", "RTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RTITM", "RTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RTIGID", "RTIGID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTCGID", "RTCGID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTLITM", "RTLITM", JdeDataType.String, 50),
        new JdeField("RTAITM", "RTAITM", JdeDataType.String, 50),
        new JdeField("RTEFTJ", "RTEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RTEXDJ", "RTEXDJ", JdeDataType.Numeric),
        new JdeField("RTCRCD", "RTCRCD", JdeDataType.String, 6),
        new JdeField("RTUOM", "RTUOM", JdeDataType.String, 4),
        new JdeField("RTTHRV", "RTTHRV", JdeDataType.Numeric, null, true, true),
        new JdeField("RTMCU", "RTMCU", JdeDataType.String, 24),
        new JdeField("RTRSTH", "RTRSTH", JdeDataType.String, 2),
        new JdeField("RTRBTF", "RTRBTF", JdeDataType.Numeric),
        new JdeField("RTREBN", "RTREBN", JdeDataType.String, 2),
        new JdeField("RTRBRM", "RTRBRM", JdeDataType.String, 2),
        new JdeField("RTRTF1", "RTRTF1", JdeDataType.String, 2),
        new JdeField("RTRTF2", "RTRTF2", JdeDataType.Numeric),
        new JdeField("RTRTF3", "RTRTF3", JdeDataType.Numeric),
        new JdeField("RTRTF4", "RTRTF4", JdeDataType.String, 16),
        new JdeField("RTRTF5", "RTRTF5", JdeDataType.String, 6),
        new JdeField("RTURDT", "RTURDT", JdeDataType.Numeric),
        new JdeField("RTURAT", "RTURAT", JdeDataType.Numeric),
        new JdeField("RTURC1", "RTURC1", JdeDataType.String, 6),
        new JdeField("RTAPRS", "RTAPRS", JdeDataType.String, 2),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RTTDAY", "RTTDAY", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4077_0", "Primary Key on RTAST, RTAN8, RTITM, RTIGID, RTCGID, RTEFTJ, RTTHRV, RTUPMJ, RTTDAY", new[] { "RTAST", "RTAN8", "RTITM", "RTIGID", "RTCGID", "RTEFTJ", "RTTHRV", "RTUPMJ", "RTTDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4077_2", "Index on RTAST, RTAN8, RTITM, RTIGID, RTCGID, SYS_NC00032$", new[] { "RTAST", "RTAN8", "RTITM", "RTIGID", "RTCGID", "SYS_NC00032$" }),
        new JdeIndex("F4077_3", "Index on RTAST, RTAN8, RTITM, RTMCU, RTIGID, RTCGID", new[] { "RTAST", "RTAN8", "RTITM", "RTMCU", "RTIGID", "RTCGID" }),
        new JdeIndex("F4077_4", "Index on RTAST, RTAN8, RTITM, RTTHRV, RTMCU, RTIGID, RTCGID", new[] { "RTAST", "RTAN8", "RTITM", "RTTHRV", "RTMCU", "RTIGID", "RTCGID" }),
        new JdeIndex("F4077_6", "Index on RTAST, RTAN8, RTITM, RTEFTJ, RTTHRV, RTPID, RTIGID, RTCGID", new[] { "RTAST", "RTAN8", "RTITM", "RTEFTJ", "RTTHRV", "RTPID", "RTIGID", "RTCGID" })
    };
}
