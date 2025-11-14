using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A700 - .
/// </summary>
public class F75A700 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SRTAXX.
        /// </summary>
        public const string SRTAXX = "SRTAXX";

        /// <summary>
        /// SRGRPNO.
        /// </summary>
        public const string SRGRPNO = "SRGRPNO";

        /// <summary>
        /// SRASSPD.
        /// </summary>
        public const string SRASSPD = "SRASSPD";

        /// <summary>
        /// SRASSQ.
        /// </summary>
        public const string SRASSQ = "SRASSQ";

        /// <summary>
        /// SRASPAIN.
        /// </summary>
        public const string SRASPAIN = "SRASPAIN";

        /// <summary>
        /// SRASSID.
        /// </summary>
        public const string SRASSID = "SRASSID";

        /// <summary>
        /// SRHMCO.
        /// </summary>
        public const string SRHMCO = "SRHMCO";

        /// <summary>
        /// SRPAYD.
        /// </summary>
        public const string SRPAYD = "SRPAYD";

        /// <summary>
        /// SRASPSS.
        /// </summary>
        public const string SRASPSS = "SRASPSS";

        /// <summary>
        /// SRASPMT.
        /// </summary>
        public const string SRASPMT = "SRASPMT";

        /// <summary>
        /// SRASPJD.
        /// </summary>
        public const string SRASPJD = "SRASPJD";

        /// <summary>
        /// SRASPPN.
        /// </summary>
        public const string SRASPPN = "SRASPPN";

        /// <summary>
        /// SRASPRC.
        /// </summary>
        public const string SRASPRC = "SRASPRC";

        /// <summary>
        /// SRASPPG.
        /// </summary>
        public const string SRASPPG = "SRASPPG";

        /// <summary>
        /// SRASPTG.
        /// </summary>
        public const string SRASPTG = "SRASPTG";

        /// <summary>
        /// SRASPST.
        /// </summary>
        public const string SRASPST = "SRASPST";

        /// <summary>
        /// SRASPSD.
        /// </summary>
        public const string SRASPSD = "SRASPSD";

        /// <summary>
        /// SRASPAI.
        /// </summary>
        public const string SRASPAI = "SRASPAI";

        /// <summary>
        /// SRTAXX1.
        /// </summary>
        public const string SRTAXX1 = "SRTAXX1";

        /// <summary>
        /// SRASPAN.
        /// </summary>
        public const string SRASPAN = "SRASPAN";

        /// <summary>
        /// SRASPAD.
        /// </summary>
        public const string SRASPAD = "SRASPAD";

        /// <summary>
        /// SRASPSA.
        /// </summary>
        public const string SRASPSA = "SRASPSA";

        /// <summary>
        /// SRUPMJ.
        /// </summary>
        public const string SRUPMJ = "SRUPMJ";

        /// <summary>
        /// SRUPMT.
        /// </summary>
        public const string SRUPMT = "SRUPMT";

        /// <summary>
        /// SRPID.
        /// </summary>
        public const string SRPID = "SRPID";

        /// <summary>
        /// SRUSER.
        /// </summary>
        public const string SRUSER = "SRUSER";

        /// <summary>
        /// SRJOBN.
        /// </summary>
        public const string SRJOBN = "SRJOBN";

        /// <summary>
        /// SRSPACAUV1.
        /// </summary>
        public const string SRSPACAUV1 = "SRSPACAUV1";

        /// <summary>
        /// SRSPACAUV2.
        /// </summary>
        public const string SRSPACAUV2 = "SRSPACAUV2";

        /// <summary>
        /// SRSPACAUV3.
        /// </summary>
        public const string SRSPACAUV3 = "SRSPACAUV3";

        /// <summary>
        /// SRSPACAUV4.
        /// </summary>
        public const string SRSPACAUV4 = "SRSPACAUV4";

        /// <summary>
        /// SRSPADAUV1.
        /// </summary>
        public const string SRSPADAUV1 = "SRSPADAUV1";

        /// <summary>
        /// SRSPADAUV2.
        /// </summary>
        public const string SRSPADAUV2 = "SRSPADAUV2";

        /// <summary>
        /// SRSPADAUV3.
        /// </summary>
        public const string SRSPADAUV3 = "SRSPADAUV3";

        /// <summary>
        /// SRSPADAUV4.
        /// </summary>
        public const string SRSPADAUV4 = "SRSPADAUV4";

        /// <summary>
        /// SRSPANAUV1.
        /// </summary>
        public const string SRSPANAUV1 = "SRSPANAUV1";

        /// <summary>
        /// SRSPANAUV2.
        /// </summary>
        public const string SRSPANAUV2 = "SRSPANAUV2";

        /// <summary>
        /// SRSPANAUV3.
        /// </summary>
        public const string SRSPANAUV3 = "SRSPANAUV3";

        /// <summary>
        /// SRSPANAUV4.
        /// </summary>
        public const string SRSPANAUV4 = "SRSPANAUV4";

        /// <summary>
        /// SRSPASAUV1.
        /// </summary>
        public const string SRSPASAUV1 = "SRSPASAUV1";

        /// <summary>
        /// SRSPASAUV2.
        /// </summary>
        public const string SRSPASAUV2 = "SRSPASAUV2";

        /// <summary>
        /// SRSPASAUV3.
        /// </summary>
        public const string SRSPASAUV3 = "SRSPASAUV3";

        /// <summary>
        /// SRSPASAUV4.
        /// </summary>
        public const string SRSPASAUV4 = "SRSPASAUV4";

        /// <summary>
        /// SRPBID.
        /// </summary>
        public const string SRPBID = "SRPBID";

        /// <summary>
        /// SRCHSP.
        /// </summary>
        public const string SRCHSP = "SRCHSP";

        /// <summary>
        /// SRGAAM.
        /// </summary>
        public const string SRGAAM = "SRGAAM";
    }

    /// <inheritdoc />
    public override string TableName => "F75A700";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SRTAXX", "SRTAXX", JdeDataType.String, 40, true, true),
        new JdeField("SRGRPNO", "SRGRPNO", JdeDataType.String, 22, true, true),
        new JdeField("SRASSPD", "SRASSPD", JdeDataType.Numeric, null, true, true),
        new JdeField("SRASSQ", "SRASSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SRASPAIN", "SRASPAIN", JdeDataType.String, 2),
        new JdeField("SRASSID", "SRASSID", JdeDataType.String, 400),
        new JdeField("SRHMCO", "SRHMCO", JdeDataType.String, 10),
        new JdeField("SRPAYD", "SRPAYD", JdeDataType.String, 20),
        new JdeField("SRASPSS", "SRASPSS", JdeDataType.String, 2),
        new JdeField("SRASPMT", "SRASPMT", JdeDataType.Numeric),
        new JdeField("SRASPJD", "SRASPJD", JdeDataType.String, 400),
        new JdeField("SRASPPN", "SRASPPN", JdeDataType.String, 400),
        new JdeField("SRASPRC", "SRASPRC", JdeDataType.Numeric),
        new JdeField("SRASPPG", "SRASPPG", JdeDataType.Numeric),
        new JdeField("SRASPTG", "SRASPTG", JdeDataType.Numeric),
        new JdeField("SRASPST", "SRASPST", JdeDataType.String, 400),
        new JdeField("SRASPSD", "SRASPSD", JdeDataType.Numeric),
        new JdeField("SRASPAI", "SRASPAI", JdeDataType.String, 2),
        new JdeField("SRTAXX1", "SRTAXX1", JdeDataType.String, 40),
        new JdeField("SRASPAN", "SRASPAN", JdeDataType.String, 40),
        new JdeField("SRASPAD", "SRASPAD", JdeDataType.Numeric),
        new JdeField("SRASPSA", "SRASPSA", JdeDataType.String, 2),
        new JdeField("SRUPMJ", "SRUPMJ", JdeDataType.Numeric),
        new JdeField("SRUPMT", "SRUPMT", JdeDataType.Numeric),
        new JdeField("SRPID", "SRPID", JdeDataType.String, 20),
        new JdeField("SRUSER", "SRUSER", JdeDataType.String, 20),
        new JdeField("SRJOBN", "SRJOBN", JdeDataType.String, 20),
        new JdeField("SRSPACAUV1", "SRSPACAUV1", JdeDataType.String, 2),
        new JdeField("SRSPACAUV2", "SRSPACAUV2", JdeDataType.String, 2),
        new JdeField("SRSPACAUV3", "SRSPACAUV3", JdeDataType.String, 2),
        new JdeField("SRSPACAUV4", "SRSPACAUV4", JdeDataType.String, 2),
        new JdeField("SRSPADAUV1", "SRSPADAUV1", JdeDataType.Numeric),
        new JdeField("SRSPADAUV2", "SRSPADAUV2", JdeDataType.Numeric),
        new JdeField("SRSPADAUV3", "SRSPADAUV3", JdeDataType.Numeric),
        new JdeField("SRSPADAUV4", "SRSPADAUV4", JdeDataType.Numeric),
        new JdeField("SRSPANAUV1", "SRSPANAUV1", JdeDataType.Numeric),
        new JdeField("SRSPANAUV2", "SRSPANAUV2", JdeDataType.Numeric),
        new JdeField("SRSPANAUV3", "SRSPANAUV3", JdeDataType.Numeric),
        new JdeField("SRSPANAUV4", "SRSPANAUV4", JdeDataType.Numeric),
        new JdeField("SRSPASAUV1", "SRSPASAUV1", JdeDataType.String, 60),
        new JdeField("SRSPASAUV2", "SRSPASAUV2", JdeDataType.String, 60),
        new JdeField("SRSPASAUV3", "SRSPASAUV3", JdeDataType.String, 60),
        new JdeField("SRSPASAUV4", "SRSPASAUV4", JdeDataType.String, 60),
        new JdeField("SRPBID", "SRPBID", JdeDataType.String, 400),
        new JdeField("SRCHSP", "SRCHSP", JdeDataType.Numeric),
        new JdeField("SRGAAM", "SRGAAM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A700_0", "Primary Key on SRTAXX, SRGRPNO, SRASSPD, SRASSQ", new[] { "SRTAXX", "SRGRPNO", "SRASSPD", "SRASSQ" }, isUnique: true, isPrimaryKey: true)
    };
}
