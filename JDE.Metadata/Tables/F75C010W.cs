using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75C010W - .
/// </summary>
public class F75C010W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AACO.
        /// </summary>
        public const string AACO = "AACO";

        /// <summary>
        /// AAAN8.
        /// </summary>
        public const string AAAN8 = "AAAN8";

        /// <summary>
        /// AAC75NAC.
        /// </summary>
        public const string AAC75NAC = "AAC75NAC";

        /// <summary>
        /// AAAID.
        /// </summary>
        public const string AAAID = "AAAID";

        /// <summary>
        /// AADIVJ.
        /// </summary>
        public const string AADIVJ = "AADIVJ";

        /// <summary>
        /// AADGJ.
        /// </summary>
        public const string AADGJ = "AADGJ";

        /// <summary>
        /// AAC75ACCYR.
        /// </summary>
        public const string AAC75ACCYR = "AAC75ACCYR";

        /// <summary>
        /// AAPN.
        /// </summary>
        public const string AAPN = "AAPN";

        /// <summary>
        /// AADCT.
        /// </summary>
        public const string AADCT = "AADCT";

        /// <summary>
        /// AADOC.
        /// </summary>
        public const string AADOC = "AADOC";

        /// <summary>
        /// AASFX.
        /// </summary>
        public const string AASFX = "AASFX";

        /// <summary>
        /// AADL01.
        /// </summary>
        public const string AADL01 = "AADL01";

        /// <summary>
        /// AABCRC.
        /// </summary>
        public const string AABCRC = "AABCRC";

        /// <summary>
        /// AACRR.
        /// </summary>
        public const string AACRR = "AACRR";

        /// <summary>
        /// AAC75BLAC.
        /// </summary>
        public const string AAC75BLAC = "AAC75BLAC";

        /// <summary>
        /// AAAAP.
        /// </summary>
        public const string AAAAP = "AAAAP";

        /// <summary>
        /// AAFAP.
        /// </summary>
        public const string AAFAP = "AAFAP";

        /// <summary>
        /// AAAG.
        /// </summary>
        public const string AAAG = "AAAG";

        /// <summary>
        /// AACRCD.
        /// </summary>
        public const string AACRCD = "AACRCD";

        /// <summary>
        /// AAACR.
        /// </summary>
        public const string AAACR = "AAACR";

        /// <summary>
        /// AARMK.
        /// </summary>
        public const string AARMK = "AARMK";

        /// <summary>
        /// AADDJ.
        /// </summary>
        public const string AADDJ = "AADDJ";

        /// <summary>
        /// AACKNU.
        /// </summary>
        public const string AACKNU = "AACKNU";

        /// <summary>
        /// AADMTJ.
        /// </summary>
        public const string AADMTJ = "AADMTJ";

        /// <summary>
        /// AADCTO.
        /// </summary>
        public const string AADCTO = "AADCTO";

        /// <summary>
        /// AADL03.
        /// </summary>
        public const string AADL03 = "AADL03";

        /// <summary>
        /// AADL02.
        /// </summary>
        public const string AADL02 = "AADL02";

        /// <summary>
        /// AAC75INNO.
        /// </summary>
        public const string AAC75INNO = "AAC75INNO";

        /// <summary>
        /// AAC75CNNO.
        /// </summary>
        public const string AAC75CNNO = "AAC75CNNO";

        /// <summary>
        /// AAC75PRNO.
        /// </summary>
        public const string AAC75PRNO = "AAC75PRNO";

        /// <summary>
        /// AAPYIN.
        /// </summary>
        public const string AAPYIN = "AAPYIN";

        /// <summary>
        /// AADSVJ.
        /// </summary>
        public const string AADSVJ = "AADSVJ";

        /// <summary>
        /// AAFLAG.
        /// </summary>
        public const string AAFLAG = "AAFLAG";

        /// <summary>
        /// AAC75BINO.
        /// </summary>
        public const string AAC75BINO = "AAC75BINO";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAFUT1.
        /// </summary>
        public const string AAFUT1 = "AAFUT1";

        /// <summary>
        /// AAFUT3.
        /// </summary>
        public const string AAFUT3 = "AAFUT3";

        /// <summary>
        /// AAFUT4.
        /// </summary>
        public const string AAFUT4 = "AAFUT4";

        /// <summary>
        /// AAFUTMATH1.
        /// </summary>
        public const string AAFUTMATH1 = "AAFUTMATH1";

        /// <summary>
        /// AAFUTMATH2.
        /// </summary>
        public const string AAFUTMATH2 = "AAFUTMATH2";

        /// <summary>
        /// AAFUTDATE1.
        /// </summary>
        public const string AAFUTDATE1 = "AAFUTDATE1";

        /// <summary>
        /// AAFUTDATE2.
        /// </summary>
        public const string AAFUTDATE2 = "AAFUTDATE2";

        /// <summary>
        /// AAFUTTRANS.
        /// </summary>
        public const string AAFUTTRANS = "AAFUTTRANS";
    }

    /// <inheritdoc />
    public override string TableName => "F75C010W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AACO", "AACO", JdeDataType.String, 10, true, true),
        new JdeField("AAAN8", "AAAN8", JdeDataType.Numeric),
        new JdeField("AAC75NAC", "AAC75NAC", JdeDataType.String, 60),
        new JdeField("AAAID", "AAAID", JdeDataType.String, 16),
        new JdeField("AADIVJ", "AADIVJ", JdeDataType.Numeric),
        new JdeField("AADGJ", "AADGJ", JdeDataType.Numeric),
        new JdeField("AAC75ACCYR", "AAC75ACCYR", JdeDataType.Numeric),
        new JdeField("AAPN", "AAPN", JdeDataType.Numeric),
        new JdeField("AADCT", "AADCT", JdeDataType.String, 4, true, true),
        new JdeField("AADOC", "AADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AASFX", "AASFX", JdeDataType.String, 6, true, true),
        new JdeField("AADL01", "AADL01", JdeDataType.String, 60),
        new JdeField("AABCRC", "AABCRC", JdeDataType.String, 6),
        new JdeField("AACRR", "AACRR", JdeDataType.Numeric),
        new JdeField("AAC75BLAC", "AAC75BLAC", JdeDataType.String, 8),
        new JdeField("AAAAP", "AAAAP", JdeDataType.Numeric),
        new JdeField("AAFAP", "AAFAP", JdeDataType.Numeric),
        new JdeField("AAAG", "AAAG", JdeDataType.Numeric),
        new JdeField("AACRCD", "AACRCD", JdeDataType.String, 6),
        new JdeField("AAACR", "AAACR", JdeDataType.Numeric),
        new JdeField("AARMK", "AARMK", JdeDataType.String, 60),
        new JdeField("AADDJ", "AADDJ", JdeDataType.Numeric),
        new JdeField("AACKNU", "AACKNU", JdeDataType.String, 50),
        new JdeField("AADMTJ", "AADMTJ", JdeDataType.Numeric),
        new JdeField("AADCTO", "AADCTO", JdeDataType.String, 4),
        new JdeField("AADL03", "AADL03", JdeDataType.String, 60),
        new JdeField("AADL02", "AADL02", JdeDataType.String, 60, true, true),
        new JdeField("AAC75INNO", "AAC75INNO", JdeDataType.String, 120),
        new JdeField("AAC75CNNO", "AAC75CNNO", JdeDataType.String, 120),
        new JdeField("AAC75PRNO", "AAC75PRNO", JdeDataType.String, 120),
        new JdeField("AAPYIN", "AAPYIN", JdeDataType.String, 2),
        new JdeField("AADSVJ", "AADSVJ", JdeDataType.Numeric),
        new JdeField("AAFLAG", "AAFLAG", JdeDataType.String, 2),
        new JdeField("AAC75BINO", "AAC75BINO", JdeDataType.String, 120),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20, true, true),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAFUT1", "AAFUT1", JdeDataType.Numeric),
        new JdeField("AAFUT3", "AAFUT3", JdeDataType.String, 60),
        new JdeField("AAFUT4", "AAFUT4", JdeDataType.String, 50),
        new JdeField("AAFUTMATH1", "AAFUTMATH1", JdeDataType.Numeric),
        new JdeField("AAFUTMATH2", "AAFUTMATH2", JdeDataType.Numeric),
        new JdeField("AAFUTDATE1", "AAFUTDATE1", JdeDataType.Numeric),
        new JdeField("AAFUTDATE2", "AAFUTDATE2", JdeDataType.Numeric),
        new JdeField("AAFUTTRANS", "AAFUTTRANS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75C010W_0", "Primary Key on AADCT, AADOC, AASFX, AACO, AADL02, AAUSER", new[] { "AADCT", "AADOC", "AASFX", "AACO", "AADL02", "AAUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
