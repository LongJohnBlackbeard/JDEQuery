using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186301 - .
/// </summary>
public class F186301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTLRSTTID.
        /// </summary>
        public const string TTLRSTTID = "TTLRSTTID";

        /// <summary>
        /// TTLRSTTN.
        /// </summary>
        public const string TTLRSTTN = "TTLRSTTN";

        /// <summary>
        /// TTLRSEGID.
        /// </summary>
        public const string TTLRSEGID = "TTLRSEGID";

        /// <summary>
        /// TTLRSTEMV.
        /// </summary>
        public const string TTLRSTEMV = "TTLRSTEMV";

        /// <summary>
        /// TTPDBA.
        /// </summary>
        public const string TTPDBA = "TTPDBA";

        /// <summary>
        /// TTLRSNHWZ.
        /// </summary>
        public const string TTLRSNHWZ = "TTLRSNHWZ";

        /// <summary>
        /// TTEPA.
        /// </summary>
        public const string TTEPA = "TTEPA";

        /// <summary>
        /// TTANI.
        /// </summary>
        public const string TTANI = "TTANI";

        /// <summary>
        /// TTLRSDWKF.
        /// </summary>
        public const string TTLRSDWKF = "TTLRSDWKF";

        /// <summary>
        /// TTDWK.
        /// </summary>
        public const string TTDWK = "TTDWK";

        /// <summary>
        /// TTP001.
        /// </summary>
        public const string TTP001 = "TTP001";

        /// <summary>
        /// TTP002.
        /// </summary>
        public const string TTP002 = "TTP002";

        /// <summary>
        /// TTP003.
        /// </summary>
        public const string TTP003 = "TTP003";

        /// <summary>
        /// TTP004.
        /// </summary>
        public const string TTP004 = "TTP004";

        /// <summary>
        /// TTMCUO.
        /// </summary>
        public const string TTMCUO = "TTMCUO";

        /// <summary>
        /// TTMAIL.
        /// </summary>
        public const string TTMAIL = "TTMAIL";

        /// <summary>
        /// TTSHFT.
        /// </summary>
        public const string TTSHFT = "TTSHFT";

        /// <summary>
        /// TTSBL.
        /// </summary>
        public const string TTSBL = "TTSBL";

        /// <summary>
        /// TTSBLT.
        /// </summary>
        public const string TTSBLT = "TTSBLT";

        /// <summary>
        /// TTDOCO.
        /// </summary>
        public const string TTDOCO = "TTDOCO";

        /// <summary>
        /// TTLRSHRFF.
        /// </summary>
        public const string TTLRSHRFF = "TTLRSHRFF";

        /// <summary>
        /// TTLRSNHRZ.
        /// </summary>
        public const string TTLRSNHRZ = "TTLRSNHRZ";

        /// <summary>
        /// TTLRSJTFF.
        /// </summary>
        public const string TTLRSJTFF = "TTLRSJTFF";

        /// <summary>
        /// TTJBCD.
        /// </summary>
        public const string TTJBCD = "TTJBCD";

        /// <summary>
        /// TTLRSJSFF.
        /// </summary>
        public const string TTLRSJSFF = "TTLRSJSFF";

        /// <summary>
        /// TTJBST.
        /// </summary>
        public const string TTJBST = "TTJBST";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTTDAY.
        /// </summary>
        public const string TTTDAY = "TTTDAY";

        /// <summary>
        /// TTRCCD.
        /// </summary>
        public const string TTRCCD = "TTRCCD";
    }

    /// <inheritdoc />
    public override string TableName => "F186301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTLRSTTID", "TTLRSTTID", JdeDataType.Numeric, null, true, true),
        new JdeField("TTLRSTTN", "TTLRSTTN", JdeDataType.String, 60),
        new JdeField("TTLRSEGID", "TTLRSEGID", JdeDataType.Numeric),
        new JdeField("TTLRSTEMV", "TTLRSTEMV", JdeDataType.String, 20),
        new JdeField("TTPDBA", "TTPDBA", JdeDataType.Numeric),
        new JdeField("TTLRSNHWZ", "TTLRSNHWZ", JdeDataType.String, 510),
        new JdeField("TTEPA", "TTEPA", JdeDataType.Numeric),
        new JdeField("TTANI", "TTANI", JdeDataType.String, 58),
        new JdeField("TTLRSDWKF", "TTLRSDWKF", JdeDataType.String, 2),
        new JdeField("TTDWK", "TTDWK", JdeDataType.Numeric),
        new JdeField("TTP001", "TTP001", JdeDataType.String, 6),
        new JdeField("TTP002", "TTP002", JdeDataType.String, 6),
        new JdeField("TTP003", "TTP003", JdeDataType.String, 6),
        new JdeField("TTP004", "TTP004", JdeDataType.String, 6),
        new JdeField("TTMCUO", "TTMCUO", JdeDataType.String, 24),
        new JdeField("TTMAIL", "TTMAIL", JdeDataType.String, 20),
        new JdeField("TTSHFT", "TTSHFT", JdeDataType.String, 2),
        new JdeField("TTSBL", "TTSBL", JdeDataType.String, 16),
        new JdeField("TTSBLT", "TTSBLT", JdeDataType.String, 2),
        new JdeField("TTDOCO", "TTDOCO", JdeDataType.Numeric),
        new JdeField("TTLRSHRFF", "TTLRSHRFF", JdeDataType.String, 2),
        new JdeField("TTLRSNHRZ", "TTLRSNHRZ", JdeDataType.String, 510),
        new JdeField("TTLRSJTFF", "TTLRSJTFF", JdeDataType.String, 2),
        new JdeField("TTJBCD", "TTJBCD", JdeDataType.String, 12),
        new JdeField("TTLRSJSFF", "TTLRSJSFF", JdeDataType.String, 2),
        new JdeField("TTJBST", "TTJBST", JdeDataType.String, 8),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTTDAY", "TTTDAY", JdeDataType.Numeric),
        new JdeField("TTRCCD", "TTRCCD", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186301_0", "Primary Key on TTLRSTTID", new[] { "TTLRSTTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186301_2", "Index on TTLRSEGID", new[] { "TTLRSEGID" }),
        new JdeIndex("F186301_3", "Unique Index on TTLRSTTN", new[] { "TTLRSTTN" }, isUnique: true)
    };
}
