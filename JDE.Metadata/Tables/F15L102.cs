using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L102 - .
/// </summary>
public class F15L102 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHMCU.
        /// </summary>
        public const string AHMCU = "AHMCU";

        /// <summary>
        /// AHASSD.
        /// </summary>
        public const string AHASSD = "AHASSD";

        /// <summary>
        /// AHRVNB.
        /// </summary>
        public const string AHRVNB = "AHRVNB";

        /// <summary>
        /// AHDS50.
        /// </summary>
        public const string AHDS50 = "AHDS50";

        /// <summary>
        /// AHNWMK.
        /// </summary>
        public const string AHNWMK = "AHNWMK";

        /// <summary>
        /// AHRNMK.
        /// </summary>
        public const string AHRNMK = "AHRNMK";

        /// <summary>
        /// AHMBCD.
        /// </summary>
        public const string AHMBCD = "AHMBCD";

        /// <summary>
        /// AHGRPA.
        /// </summary>
        public const string AHGRPA = "AHGRPA";

        /// <summary>
        /// AHCPIP.
        /// </summary>
        public const string AHCPIP = "AHCPIP";

        /// <summary>
        /// AHCGLC.
        /// </summary>
        public const string AHCGLC = "AHCGLC";

        /// <summary>
        /// AHPMTC.
        /// </summary>
        public const string AHPMTC = "AHPMTC";

        /// <summary>
        /// AHLSTT.
        /// </summary>
        public const string AHLSTT = "AHLSTT";

        /// <summary>
        /// AHRCTP.
        /// </summary>
        public const string AHRCTP = "AHRCTP";

        /// <summary>
        /// AHRSGP.
        /// </summary>
        public const string AHRSGP = "AHRSGP";

        /// <summary>
        /// AHDOWT.
        /// </summary>
        public const string AHDOWT = "AHDOWT";

        /// <summary>
        /// AHRPPC.
        /// </summary>
        public const string AHRPPC = "AHRPPC";

        /// <summary>
        /// AHFREN.
        /// </summary>
        public const string AHFREN = "AHFREN";

        /// <summary>
        /// AHFMN.
        /// </summary>
        public const string AHFMN = "AHFMN";

        /// <summary>
        /// AHUR01.
        /// </summary>
        public const string AHUR01 = "AHUR01";

        /// <summary>
        /// AHUR02.
        /// </summary>
        public const string AHUR02 = "AHUR02";

        /// <summary>
        /// AHUR03.
        /// </summary>
        public const string AHUR03 = "AHUR03";

        /// <summary>
        /// AHUR04.
        /// </summary>
        public const string AHUR04 = "AHUR04";

        /// <summary>
        /// AHUR05.
        /// </summary>
        public const string AHUR05 = "AHUR05";

        /// <summary>
        /// AHURCD.
        /// </summary>
        public const string AHURCD = "AHURCD";

        /// <summary>
        /// AHURDT.
        /// </summary>
        public const string AHURDT = "AHURDT";

        /// <summary>
        /// AHURAT.
        /// </summary>
        public const string AHURAT = "AHURAT";

        /// <summary>
        /// AHURAB.
        /// </summary>
        public const string AHURAB = "AHURAB";

        /// <summary>
        /// AHURRF.
        /// </summary>
        public const string AHURRF = "AHURRF";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHJOBN.
        /// </summary>
        public const string AHJOBN = "AHJOBN";

        /// <summary>
        /// AHUPMJ.
        /// </summary>
        public const string AHUPMJ = "AHUPMJ";

        /// <summary>
        /// AHUPMT.
        /// </summary>
        public const string AHUPMT = "AHUPMT";

        /// <summary>
        /// AHTORG.
        /// </summary>
        public const string AHTORG = "AHTORG";

        /// <summary>
        /// AHENTJ.
        /// </summary>
        public const string AHENTJ = "AHENTJ";

        /// <summary>
        /// AHTOLA.
        /// </summary>
        public const string AHTOLA = "AHTOLA";

        /// <summary>
        /// AHLSTR.
        /// </summary>
        public const string AHLSTR = "AHLSTR";

        /// <summary>
        /// AHRSYO.
        /// </summary>
        public const string AHRSYO = "AHRSYO";
    }

    /// <inheritdoc />
    public override string TableName => "F15L102";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHMCU", "AHMCU", JdeDataType.String, 24, true, true),
        new JdeField("AHASSD", "AHASSD", JdeDataType.String, 20, true, true),
        new JdeField("AHRVNB", "AHRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("AHDS50", "AHDS50", JdeDataType.String, 100),
        new JdeField("AHNWMK", "AHNWMK", JdeDataType.Numeric),
        new JdeField("AHRNMK", "AHRNMK", JdeDataType.Numeric),
        new JdeField("AHMBCD", "AHMBCD", JdeDataType.String, 8),
        new JdeField("AHGRPA", "AHGRPA", JdeDataType.String, 20),
        new JdeField("AHCPIP", "AHCPIP", JdeDataType.String, 20),
        new JdeField("AHCGLC", "AHCGLC", JdeDataType.String, 8),
        new JdeField("AHPMTC", "AHPMTC", JdeDataType.Numeric),
        new JdeField("AHLSTT", "AHLSTT", JdeDataType.String, 20),
        new JdeField("AHRCTP", "AHRCTP", JdeDataType.String, 2),
        new JdeField("AHRSGP", "AHRSGP", JdeDataType.String, 20),
        new JdeField("AHDOWT", "AHDOWT", JdeDataType.Numeric),
        new JdeField("AHRPPC", "AHRPPC", JdeDataType.Numeric),
        new JdeField("AHFREN", "AHFREN", JdeDataType.String, 8),
        new JdeField("AHFMN", "AHFMN", JdeDataType.Numeric),
        new JdeField("AHUR01", "AHUR01", JdeDataType.String, 6),
        new JdeField("AHUR02", "AHUR02", JdeDataType.String, 6),
        new JdeField("AHUR03", "AHUR03", JdeDataType.String, 6),
        new JdeField("AHUR04", "AHUR04", JdeDataType.String, 6),
        new JdeField("AHUR05", "AHUR05", JdeDataType.String, 6),
        new JdeField("AHURCD", "AHURCD", JdeDataType.String, 4),
        new JdeField("AHURDT", "AHURDT", JdeDataType.Numeric),
        new JdeField("AHURAT", "AHURAT", JdeDataType.Numeric),
        new JdeField("AHURAB", "AHURAB", JdeDataType.Numeric),
        new JdeField("AHURRF", "AHURRF", JdeDataType.String, 30),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHUPMT", "AHUPMT", JdeDataType.Numeric),
        new JdeField("AHTORG", "AHTORG", JdeDataType.String, 20),
        new JdeField("AHENTJ", "AHENTJ", JdeDataType.Numeric),
        new JdeField("AHTOLA", "AHTOLA", JdeDataType.Numeric),
        new JdeField("AHLSTR", "AHLSTR", JdeDataType.String, 20),
        new JdeField("AHRSYO", "AHRSYO", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L102_0", "Primary Key on AHMCU, AHASSD, AHRVNB", new[] { "AHMCU", "AHASSD", "AHRVNB" }, isUnique: true, isPrimaryKey: true)
    };
}
