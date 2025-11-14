using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1565 - .
/// </summary>
public class F1565 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JFDOCO.
        /// </summary>
        public const string JFDOCO = "JFDOCO";

        /// <summary>
        /// JFLSVR.
        /// </summary>
        public const string JFLSVR = "JFLSVR";

        /// <summary>
        /// JFCO.
        /// </summary>
        public const string JFCO = "JFCO";

        /// <summary>
        /// JFMCU.
        /// </summary>
        public const string JFMCU = "JFMCU";

        /// <summary>
        /// JFUNIT.
        /// </summary>
        public const string JFUNIT = "JFUNIT";

        /// <summary>
        /// JFGLC.
        /// </summary>
        public const string JFGLC = "JFGLC";

        /// <summary>
        /// JFEFTB.
        /// </summary>
        public const string JFEFTB = "JFEFTB";

        /// <summary>
        /// JFEFTE.
        /// </summary>
        public const string JFEFTE = "JFEFTE";

        /// <summary>
        /// JFSUDT.
        /// </summary>
        public const string JFSUDT = "JFSUDT";

        /// <summary>
        /// JFSUSP.
        /// </summary>
        public const string JFSUSP = "JFSUSP";

        /// <summary>
        /// JFVRSC.
        /// </summary>
        public const string JFVRSC = "JFVRSC";

        /// <summary>
        /// JFEDT.
        /// </summary>
        public const string JFEDT = "JFEDT";

        /// <summary>
        /// JFSDAP.
        /// </summary>
        public const string JFSDAP = "JFSDAP";

        /// <summary>
        /// JFAG.
        /// </summary>
        public const string JFAG = "JFAG";

        /// <summary>
        /// JFTKDT.
        /// </summary>
        public const string JFTKDT = "JFTKDT";

        /// <summary>
        /// JFBLMN.
        /// </summary>
        public const string JFBLMN = "JFBLMN";

        /// <summary>
        /// JFEXR.
        /// </summary>
        public const string JFEXR = "JFEXR";

        /// <summary>
        /// JFBCI.
        /// </summary>
        public const string JFBCI = "JFBCI";

        /// <summary>
        /// JFBCI3.
        /// </summary>
        public const string JFBCI3 = "JFBCI3";

        /// <summary>
        /// JFLNID.
        /// </summary>
        public const string JFLNID = "JFLNID";

        /// <summary>
        /// JFAN8.
        /// </summary>
        public const string JFAN8 = "JFAN8";

        /// <summary>
        /// JFAN8J.
        /// </summary>
        public const string JFAN8J = "JFAN8J";

        /// <summary>
        /// JFCRYR.
        /// </summary>
        public const string JFCRYR = "JFCRYR";

        /// <summary>
        /// JFCRRM.
        /// </summary>
        public const string JFCRRM = "JFCRRM";

        /// <summary>
        /// JFCRCD.
        /// </summary>
        public const string JFCRCD = "JFCRCD";

        /// <summary>
        /// JFCRCX.
        /// </summary>
        public const string JFCRCX = "JFCRCX";

        /// <summary>
        /// JFCRR.
        /// </summary>
        public const string JFCRR = "JFCRR";

        /// <summary>
        /// JFCTXA.
        /// </summary>
        public const string JFCTXA = "JFCTXA";

        /// <summary>
        /// JFCTXN.
        /// </summary>
        public const string JFCTXN = "JFCTXN";

        /// <summary>
        /// JFCTAM.
        /// </summary>
        public const string JFCTAM = "JFCTAM";

        /// <summary>
        /// JFURCD.
        /// </summary>
        public const string JFURCD = "JFURCD";

        /// <summary>
        /// JFURDT.
        /// </summary>
        public const string JFURDT = "JFURDT";

        /// <summary>
        /// JFURAT.
        /// </summary>
        public const string JFURAT = "JFURAT";

        /// <summary>
        /// JFURAB.
        /// </summary>
        public const string JFURAB = "JFURAB";

        /// <summary>
        /// JFURRF.
        /// </summary>
        public const string JFURRF = "JFURRF";

        /// <summary>
        /// JFUSER.
        /// </summary>
        public const string JFUSER = "JFUSER";

        /// <summary>
        /// JFPID.
        /// </summary>
        public const string JFPID = "JFPID";

        /// <summary>
        /// JFUPMJ.
        /// </summary>
        public const string JFUPMJ = "JFUPMJ";

        /// <summary>
        /// JFUPMT.
        /// </summary>
        public const string JFUPMT = "JFUPMT";

        /// <summary>
        /// JFJOBN.
        /// </summary>
        public const string JFJOBN = "JFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1565";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JFDOCO", "JFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("JFLSVR", "JFLSVR", JdeDataType.Numeric),
        new JdeField("JFCO", "JFCO", JdeDataType.String, 10),
        new JdeField("JFMCU", "JFMCU", JdeDataType.String, 24),
        new JdeField("JFUNIT", "JFUNIT", JdeDataType.String, 16),
        new JdeField("JFGLC", "JFGLC", JdeDataType.String, 8),
        new JdeField("JFEFTB", "JFEFTB", JdeDataType.Numeric),
        new JdeField("JFEFTE", "JFEFTE", JdeDataType.Numeric),
        new JdeField("JFSUDT", "JFSUDT", JdeDataType.Numeric),
        new JdeField("JFSUSP", "JFSUSP", JdeDataType.String, 2),
        new JdeField("JFVRSC", "JFVRSC", JdeDataType.String, 2),
        new JdeField("JFEDT", "JFEDT", JdeDataType.String, 6),
        new JdeField("JFSDAP", "JFSDAP", JdeDataType.String, 2),
        new JdeField("JFAG", "JFAG", JdeDataType.Numeric),
        new JdeField("JFTKDT", "JFTKDT", JdeDataType.Numeric),
        new JdeField("JFBLMN", "JFBLMN", JdeDataType.String, 2),
        new JdeField("JFEXR", "JFEXR", JdeDataType.String, 60),
        new JdeField("JFBCI", "JFBCI", JdeDataType.Numeric),
        new JdeField("JFBCI3", "JFBCI3", JdeDataType.Numeric),
        new JdeField("JFLNID", "JFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("JFAN8", "JFAN8", JdeDataType.Numeric),
        new JdeField("JFAN8J", "JFAN8J", JdeDataType.Numeric),
        new JdeField("JFCRYR", "JFCRYR", JdeDataType.String, 2),
        new JdeField("JFCRRM", "JFCRRM", JdeDataType.String, 2),
        new JdeField("JFCRCD", "JFCRCD", JdeDataType.String, 6),
        new JdeField("JFCRCX", "JFCRCX", JdeDataType.String, 6),
        new JdeField("JFCRR", "JFCRR", JdeDataType.Numeric),
        new JdeField("JFCTXA", "JFCTXA", JdeDataType.Numeric),
        new JdeField("JFCTXN", "JFCTXN", JdeDataType.Numeric),
        new JdeField("JFCTAM", "JFCTAM", JdeDataType.Numeric),
        new JdeField("JFURCD", "JFURCD", JdeDataType.String, 4),
        new JdeField("JFURDT", "JFURDT", JdeDataType.Numeric),
        new JdeField("JFURAT", "JFURAT", JdeDataType.Numeric),
        new JdeField("JFURAB", "JFURAB", JdeDataType.Numeric),
        new JdeField("JFURRF", "JFURRF", JdeDataType.String, 30),
        new JdeField("JFUSER", "JFUSER", JdeDataType.String, 20),
        new JdeField("JFPID", "JFPID", JdeDataType.String, 20),
        new JdeField("JFUPMJ", "JFUPMJ", JdeDataType.Numeric),
        new JdeField("JFUPMT", "JFUPMT", JdeDataType.Numeric),
        new JdeField("JFJOBN", "JFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1565_0", "Primary Key on JFDOCO, JFLNID", new[] { "JFDOCO", "JFLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1565_4", "Index on JFDOCO, JFMCU, JFUNIT, JFGLC", new[] { "JFDOCO", "JFMCU", "JFUNIT", "JFGLC" }),
        new JdeIndex("F1565_5", "Index on JFCO, JFMCU, JFUNIT, JFDOCO", new[] { "JFCO", "JFMCU", "JFUNIT", "JFDOCO" }),
        new JdeIndex("F1565_6", "Index on JFDOCO, JFMCU, JFUNIT", new[] { "JFDOCO", "JFMCU", "JFUNIT" }),
        new JdeIndex("F1565_8", "Index on JFBCI", new[] { "JFBCI" })
    };
}
