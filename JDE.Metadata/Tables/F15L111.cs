using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L111 - .
/// </summary>
public class F15L111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADMCU.
        /// </summary>
        public const string ADMCU = "ADMCU";

        /// <summary>
        /// ADRVNB.
        /// </summary>
        public const string ADRVNB = "ADRVNB";

        /// <summary>
        /// ADAID.
        /// </summary>
        public const string ADAID = "ADAID";

        /// <summary>
        /// ADCTRY.
        /// </summary>
        public const string ADCTRY = "ADCTRY";

        /// <summary>
        /// ADFY.
        /// </summary>
        public const string ADFY = "ADFY";

        /// <summary>
        /// ADSBL.
        /// </summary>
        public const string ADSBL = "ADSBL";

        /// <summary>
        /// ADSBLT.
        /// </summary>
        public const string ADSBLT = "ADSBLT";

        /// <summary>
        /// ADLNID.
        /// </summary>
        public const string ADLNID = "ADLNID";

        /// <summary>
        /// ADAN01.
        /// </summary>
        public const string ADAN01 = "ADAN01";

        /// <summary>
        /// ADAN02.
        /// </summary>
        public const string ADAN02 = "ADAN02";

        /// <summary>
        /// ADAN03.
        /// </summary>
        public const string ADAN03 = "ADAN03";

        /// <summary>
        /// ADAN04.
        /// </summary>
        public const string ADAN04 = "ADAN04";

        /// <summary>
        /// ADAN05.
        /// </summary>
        public const string ADAN05 = "ADAN05";

        /// <summary>
        /// ADAN06.
        /// </summary>
        public const string ADAN06 = "ADAN06";

        /// <summary>
        /// ADAN07.
        /// </summary>
        public const string ADAN07 = "ADAN07";

        /// <summary>
        /// ADAN08.
        /// </summary>
        public const string ADAN08 = "ADAN08";

        /// <summary>
        /// ADAN09.
        /// </summary>
        public const string ADAN09 = "ADAN09";

        /// <summary>
        /// ADAN10.
        /// </summary>
        public const string ADAN10 = "ADAN10";

        /// <summary>
        /// ADAN11.
        /// </summary>
        public const string ADAN11 = "ADAN11";

        /// <summary>
        /// ADAN12.
        /// </summary>
        public const string ADAN12 = "ADAN12";

        /// <summary>
        /// ADDL01.
        /// </summary>
        public const string ADDL01 = "ADDL01";

        /// <summary>
        /// ADAA2.
        /// </summary>
        public const string ADAA2 = "ADAA2";

        /// <summary>
        /// ADBPC.
        /// </summary>
        public const string ADBPC = "ADBPC";

        /// <summary>
        /// ADURAB.
        /// </summary>
        public const string ADURAB = "ADURAB";

        /// <summary>
        /// ADURAT.
        /// </summary>
        public const string ADURAT = "ADURAT";

        /// <summary>
        /// ADURCD.
        /// </summary>
        public const string ADURCD = "ADURCD";

        /// <summary>
        /// ADURDT.
        /// </summary>
        public const string ADURDT = "ADURDT";

        /// <summary>
        /// ADURRF.
        /// </summary>
        public const string ADURRF = "ADURRF";

        /// <summary>
        /// ADMKEY.
        /// </summary>
        public const string ADMKEY = "ADMKEY";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADUPMT.
        /// </summary>
        public const string ADUPMT = "ADUPMT";

        /// <summary>
        /// ADTORG.
        /// </summary>
        public const string ADTORG = "ADTORG";

        /// <summary>
        /// ADENTJ.
        /// </summary>
        public const string ADENTJ = "ADENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADMCU", "ADMCU", JdeDataType.String, 24, true, true),
        new JdeField("ADRVNB", "ADRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("ADAID", "ADAID", JdeDataType.String, 16, true, true),
        new JdeField("ADCTRY", "ADCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("ADFY", "ADFY", JdeDataType.Numeric, null, true, true),
        new JdeField("ADSBL", "ADSBL", JdeDataType.String, 16, true, true),
        new JdeField("ADSBLT", "ADSBLT", JdeDataType.String, 2, true, true),
        new JdeField("ADLNID", "ADLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ADAN01", "ADAN01", JdeDataType.Numeric),
        new JdeField("ADAN02", "ADAN02", JdeDataType.Numeric),
        new JdeField("ADAN03", "ADAN03", JdeDataType.Numeric),
        new JdeField("ADAN04", "ADAN04", JdeDataType.Numeric),
        new JdeField("ADAN05", "ADAN05", JdeDataType.Numeric),
        new JdeField("ADAN06", "ADAN06", JdeDataType.Numeric),
        new JdeField("ADAN07", "ADAN07", JdeDataType.Numeric),
        new JdeField("ADAN08", "ADAN08", JdeDataType.Numeric),
        new JdeField("ADAN09", "ADAN09", JdeDataType.Numeric),
        new JdeField("ADAN10", "ADAN10", JdeDataType.Numeric),
        new JdeField("ADAN11", "ADAN11", JdeDataType.Numeric),
        new JdeField("ADAN12", "ADAN12", JdeDataType.Numeric),
        new JdeField("ADDL01", "ADDL01", JdeDataType.String, 60),
        new JdeField("ADAA2", "ADAA2", JdeDataType.Numeric),
        new JdeField("ADBPC", "ADBPC", JdeDataType.String, 6),
        new JdeField("ADURAB", "ADURAB", JdeDataType.Numeric),
        new JdeField("ADURAT", "ADURAT", JdeDataType.Numeric),
        new JdeField("ADURCD", "ADURCD", JdeDataType.String, 4),
        new JdeField("ADURDT", "ADURDT", JdeDataType.Numeric),
        new JdeField("ADURRF", "ADURRF", JdeDataType.String, 30),
        new JdeField("ADMKEY", "ADMKEY", JdeDataType.String, 30),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADUPMT", "ADUPMT", JdeDataType.Numeric),
        new JdeField("ADTORG", "ADTORG", JdeDataType.String, 20),
        new JdeField("ADENTJ", "ADENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L111_0", "Primary Key on ADMCU, ADRVNB, ADAID, ADCTRY, ADFY, ADSBL, ADSBLT, ADLNID", new[] { "ADMCU", "ADRVNB", "ADAID", "ADCTRY", "ADFY", "ADSBL", "ADSBLT", "ADLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
