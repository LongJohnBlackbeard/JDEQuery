using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07880 - .
/// </summary>
public class F07880 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YWAN8.
        /// </summary>
        public const string YWAN8 = "YWAN8";

        /// <summary>
        /// YWHMCO.
        /// </summary>
        public const string YWHMCO = "YWHMCO";

        /// <summary>
        /// YWTARA.
        /// </summary>
        public const string YWTARA = "YWTARA";

        /// <summary>
        /// YWDTEY.
        /// </summary>
        public const string YWDTEY = "YWDTEY";

        /// <summary>
        /// YWPQTR.
        /// </summary>
        public const string YWPQTR = "YWPQTR";

        /// <summary>
        /// YWTAXX.
        /// </summary>
        public const string YWTAXX = "YWTAXX";

        /// <summary>
        /// YWALPH3.
        /// </summary>
        public const string YWALPH3 = "YWALPH3";

        /// <summary>
        /// YWADD1.
        /// </summary>
        public const string YWADD1 = "YWADD1";

        /// <summary>
        /// YWADD2.
        /// </summary>
        public const string YWADD2 = "YWADD2";

        /// <summary>
        /// YWADD3.
        /// </summary>
        public const string YWADD3 = "YWADD3";

        /// <summary>
        /// YWCTY1.
        /// </summary>
        public const string YWCTY1 = "YWCTY1";

        /// <summary>
        /// YWADDS.
        /// </summary>
        public const string YWADDS = "YWADDS";

        /// <summary>
        /// YWADDZ.
        /// </summary>
        public const string YWADDZ = "YWADDZ";

        /// <summary>
        /// YWCNT2.
        /// </summary>
        public const string YWCNT2 = "YWCNT2";

        /// <summary>
        /// YWCTR2.
        /// </summary>
        public const string YWCTR2 = "YWCTR2";

        /// <summary>
        /// YWFPC2.
        /// </summary>
        public const string YWFPC2 = "YWFPC2";

        /// <summary>
        /// YWSEAN.
        /// </summary>
        public const string YWSEAN = "YWSEAN";

        /// <summary>
        /// YWWKSE.
        /// </summary>
        public const string YWWKSE = "YWWKSE";

        /// <summary>
        /// YWSCOD.
        /// </summary>
        public const string YWSCOD = "YWSCOD";

        /// <summary>
        /// YWTYPEEMPLOY.
        /// </summary>
        public const string YWTYPEEMPLOY = "YWTYPEEMPLOY";

        /// <summary>
        /// YWTAXTYPECD.
        /// </summary>
        public const string YWTAXTYPECD = "YWTAXTYPECD";

        /// <summary>
        /// YWSSN.
        /// </summary>
        public const string YWSSN = "YWSSN";

        /// <summary>
        /// YWNAMECODE.
        /// </summary>
        public const string YWNAMECODE = "YWNAMECODE";

        /// <summary>
        /// YWALPH.
        /// </summary>
        public const string YWALPH = "YWALPH";

        /// <summary>
        /// YWEMPLNAME.
        /// </summary>
        public const string YWEMPLNAME = "YWEMPLNAME";

        /// <summary>
        /// YWEMPFNAME.
        /// </summary>
        public const string YWEMPFNAME = "YWEMPFNAME";

        /// <summary>
        /// YWEMPMI.
        /// </summary>
        public const string YWEMPMI = "YWEMPMI";

        /// <summary>
        /// YWADD4.
        /// </summary>
        public const string YWADD4 = "YWADD4";

        /// <summary>
        /// YWADD5.
        /// </summary>
        public const string YWADD5 = "YWADD5";

        /// <summary>
        /// YWADD6.
        /// </summary>
        public const string YWADD6 = "YWADD6";

        /// <summary>
        /// YWMSCY.
        /// </summary>
        public const string YWMSCY = "YWMSCY";

        /// <summary>
        /// YWADDO.
        /// </summary>
        public const string YWADDO = "YWADDO";

        /// <summary>
        /// YWCRTE.
        /// </summary>
        public const string YWCRTE = "YWCRTE";

        /// <summary>
        /// YWSTCD.
        /// </summary>
        public const string YWSTCD = "YWSTCD";

        /// <summary>
        /// YWCTR.
        /// </summary>
        public const string YWCTR = "YWCTR";

        /// <summary>
        /// YWCOUN.
        /// </summary>
        public const string YWCOUN = "YWCOUN";

        /// <summary>
        /// YWFPC1.
        /// </summary>
        public const string YWFPC1 = "YWFPC1";

        /// <summary>
        /// YWSEX.
        /// </summary>
        public const string YWSEX = "YWSEX";

        /// <summary>
        /// YWDSI.
        /// </summary>
        public const string YWDSI = "YWDSI";

        /// <summary>
        /// YWDT.
        /// </summary>
        public const string YWDT = "YWDT";

        /// <summary>
        /// YWJBCD.
        /// </summary>
        public const string YWJBCD = "YWJBCD";

        /// <summary>
        /// YWWCMP.
        /// </summary>
        public const string YWWCMP = "YWWCMP";

        /// <summary>
        /// YWGPAY.
        /// </summary>
        public const string YWGPAY = "YWGPAY";

        /// <summary>
        /// YWG301.
        /// </summary>
        public const string YWG301 = "YWG301";

        /// <summary>
        /// YWWE01.
        /// </summary>
        public const string YWWE01 = "YWWE01";

        /// <summary>
        /// YWWX01.
        /// </summary>
        public const string YWWX01 = "YWWX01";

        /// <summary>
        /// YWG101.
        /// </summary>
        public const string YWG101 = "YWG101";

        /// <summary>
        /// YWG201.
        /// </summary>
        public const string YWG201 = "YWG201";

        /// <summary>
        /// YWBW01.
        /// </summary>
        public const string YWBW01 = "YWBW01";

        /// <summary>
        /// YWBY01.
        /// </summary>
        public const string YWBY01 = "YWBY01";

        /// <summary>
        /// YWHOURS.
        /// </summary>
        public const string YWHOURS = "YWHOURS";

        /// <summary>
        /// YWMTH1.
        /// </summary>
        public const string YWMTH1 = "YWMTH1";

        /// <summary>
        /// YWMTH2.
        /// </summary>
        public const string YWMTH2 = "YWMTH2";

        /// <summary>
        /// YWMTH3.
        /// </summary>
        public const string YWMTH3 = "YWMTH3";

        /// <summary>
        /// YWAG.
        /// </summary>
        public const string YWAG = "YWAG";

        /// <summary>
        /// YWSTAM.
        /// </summary>
        public const string YWSTAM = "YWSTAM";

        /// <summary>
        /// YWAN8T.
        /// </summary>
        public const string YWAN8T = "YWAN8T";

        /// <summary>
        /// YWTAXX2.
        /// </summary>
        public const string YWTAXX2 = "YWTAXX2";

        /// <summary>
        /// YWALPH5.
        /// </summary>
        public const string YWALPH5 = "YWALPH5";

        /// <summary>
        /// YWADD13.
        /// </summary>
        public const string YWADD13 = "YWADD13";

        /// <summary>
        /// YWADD14.
        /// </summary>
        public const string YWADD14 = "YWADD14";

        /// <summary>
        /// YWADD15.
        /// </summary>
        public const string YWADD15 = "YWADD15";

        /// <summary>
        /// YWCTYNH3.
        /// </summary>
        public const string YWCTYNH3 = "YWCTYNH3";

        /// <summary>
        /// YWADDSNH3.
        /// </summary>
        public const string YWADDSNH3 = "YWADDSNH3";

        /// <summary>
        /// YWADDZNH3.
        /// </summary>
        public const string YWADDZNH3 = "YWADDZNH3";

        /// <summary>
        /// YWCRTENH3.
        /// </summary>
        public const string YWCRTENH3 = "YWCRTENH3";

        /// <summary>
        /// YWCTR6.
        /// </summary>
        public const string YWCTR6 = "YWCTR6";

        /// <summary>
        /// YWCOUNNH3.
        /// </summary>
        public const string YWCOUNNH3 = "YWCOUNNH3";

        /// <summary>
        /// YWFPC5.
        /// </summary>
        public const string YWFPC5 = "YWFPC5";

        /// <summary>
        /// YWAN8D.
        /// </summary>
        public const string YWAN8D = "YWAN8D";

        /// <summary>
        /// YWALPH4.
        /// </summary>
        public const string YWALPH4 = "YWALPH4";

        /// <summary>
        /// YWADD10.
        /// </summary>
        public const string YWADD10 = "YWADD10";

        /// <summary>
        /// YWADD11.
        /// </summary>
        public const string YWADD11 = "YWADD11";

        /// <summary>
        /// YWADD12.
        /// </summary>
        public const string YWADD12 = "YWADD12";

        /// <summary>
        /// YWCTYNH2.
        /// </summary>
        public const string YWCTYNH2 = "YWCTYNH2";

        /// <summary>
        /// YWADDSNH2.
        /// </summary>
        public const string YWADDSNH2 = "YWADDSNH2";

        /// <summary>
        /// YWTAXENTCODE.
        /// </summary>
        public const string YWTAXENTCODE = "YWTAXENTCODE";

        /// <summary>
        /// YWADDZNH2.
        /// </summary>
        public const string YWADDZNH2 = "YWADDZNH2";

        /// <summary>
        /// YWCRTENH2.
        /// </summary>
        public const string YWCRTENH2 = "YWCRTENH2";

        /// <summary>
        /// YWCTR5.
        /// </summary>
        public const string YWCTR5 = "YWCTR5";

        /// <summary>
        /// YWCOUNNH2.
        /// </summary>
        public const string YWCOUNNH2 = "YWCOUNNH2";

        /// <summary>
        /// YWFPC4.
        /// </summary>
        public const string YWFPC4 = "YWFPC4";

        /// <summary>
        /// YWAR3.
        /// </summary>
        public const string YWAR3 = "YWAR3";

        /// <summary>
        /// YWPH3.
        /// </summary>
        public const string YWPH3 = "YWPH3";

        /// <summary>
        /// YWUNITCODE.
        /// </summary>
        public const string YWUNITCODE = "YWUNITCODE";

        /// <summary>
        /// YWCTRY.
        /// </summary>
        public const string YWCTRY = "YWCTRY";

        /// <summary>
        /// YWUPMJ.
        /// </summary>
        public const string YWUPMJ = "YWUPMJ";

        /// <summary>
        /// YWUPMT.
        /// </summary>
        public const string YWUPMT = "YWUPMT";

        /// <summary>
        /// YWPID.
        /// </summary>
        public const string YWPID = "YWPID";

        /// <summary>
        /// YWJOBN.
        /// </summary>
        public const string YWJOBN = "YWJOBN";

        /// <summary>
        /// YWUSER.
        /// </summary>
        public const string YWUSER = "YWUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07880";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YWAN8", "YWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YWHMCO", "YWHMCO", JdeDataType.String, 10, true, true),
        new JdeField("YWTARA", "YWTARA", JdeDataType.String, 20, true, true),
        new JdeField("YWDTEY", "YWDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("YWPQTR", "YWPQTR", JdeDataType.String, 2, true, true),
        new JdeField("YWTAXX", "YWTAXX", JdeDataType.String, 40),
        new JdeField("YWALPH3", "YWALPH3", JdeDataType.String, 80),
        new JdeField("YWADD1", "YWADD1", JdeDataType.String, 80),
        new JdeField("YWADD2", "YWADD2", JdeDataType.String, 80),
        new JdeField("YWADD3", "YWADD3", JdeDataType.String, 80),
        new JdeField("YWCTY1", "YWCTY1", JdeDataType.String, 50),
        new JdeField("YWADDS", "YWADDS", JdeDataType.String, 6),
        new JdeField("YWADDZ", "YWADDZ", JdeDataType.String, 24),
        new JdeField("YWCNT2", "YWCNT2", JdeDataType.String, 50),
        new JdeField("YWCTR2", "YWCTR2", JdeDataType.String, 6),
        new JdeField("YWFPC2", "YWFPC2", JdeDataType.String, 30),
        new JdeField("YWSEAN", "YWSEAN", JdeDataType.String, 24),
        new JdeField("YWWKSE", "YWWKSE", JdeDataType.String, 6),
        new JdeField("YWSCOD", "YWSCOD", JdeDataType.String, 6),
        new JdeField("YWTYPEEMPLOY", "YWTYPEEMPLOY", JdeDataType.String, 2),
        new JdeField("YWTAXTYPECD", "YWTAXTYPECD", JdeDataType.String, 2),
        new JdeField("YWSSN", "YWSSN", JdeDataType.String, 40),
        new JdeField("YWNAMECODE", "YWNAMECODE", JdeDataType.String, 2),
        new JdeField("YWALPH", "YWALPH", JdeDataType.String, 80),
        new JdeField("YWEMPLNAME", "YWEMPLNAME", JdeDataType.String, 60),
        new JdeField("YWEMPFNAME", "YWEMPFNAME", JdeDataType.String, 24),
        new JdeField("YWEMPMI", "YWEMPMI", JdeDataType.String, 2),
        new JdeField("YWADD4", "YWADD4", JdeDataType.String, 80),
        new JdeField("YWADD5", "YWADD5", JdeDataType.String, 80),
        new JdeField("YWADD6", "YWADD6", JdeDataType.String, 80),
        new JdeField("YWMSCY", "YWMSCY", JdeDataType.String, 50),
        new JdeField("YWADDO", "YWADDO", JdeDataType.String, 24),
        new JdeField("YWCRTE", "YWCRTE", JdeDataType.String, 8),
        new JdeField("YWSTCD", "YWSTCD", JdeDataType.String, 6),
        new JdeField("YWCTR", "YWCTR", JdeDataType.String, 6),
        new JdeField("YWCOUN", "YWCOUN", JdeDataType.String, 50),
        new JdeField("YWFPC1", "YWFPC1", JdeDataType.String, 30),
        new JdeField("YWSEX", "YWSEX", JdeDataType.String, 2),
        new JdeField("YWDSI", "YWDSI", JdeDataType.Numeric),
        new JdeField("YWDT", "YWDT", JdeDataType.Numeric),
        new JdeField("YWJBCD", "YWJBCD", JdeDataType.String, 12),
        new JdeField("YWWCMP", "YWWCMP", JdeDataType.String, 8),
        new JdeField("YWGPAY", "YWGPAY", JdeDataType.Numeric),
        new JdeField("YWG301", "YWG301", JdeDataType.Numeric),
        new JdeField("YWWE01", "YWWE01", JdeDataType.Numeric),
        new JdeField("YWWX01", "YWWX01", JdeDataType.Numeric),
        new JdeField("YWG101", "YWG101", JdeDataType.Numeric),
        new JdeField("YWG201", "YWG201", JdeDataType.Numeric),
        new JdeField("YWBW01", "YWBW01", JdeDataType.Numeric),
        new JdeField("YWBY01", "YWBY01", JdeDataType.Numeric),
        new JdeField("YWHOURS", "YWHOURS", JdeDataType.Numeric),
        new JdeField("YWMTH1", "YWMTH1", JdeDataType.Numeric),
        new JdeField("YWMTH2", "YWMTH2", JdeDataType.Numeric),
        new JdeField("YWMTH3", "YWMTH3", JdeDataType.Numeric),
        new JdeField("YWAG", "YWAG", JdeDataType.Numeric),
        new JdeField("YWSTAM", "YWSTAM", JdeDataType.Numeric),
        new JdeField("YWAN8T", "YWAN8T", JdeDataType.Numeric),
        new JdeField("YWTAXX2", "YWTAXX2", JdeDataType.String, 40),
        new JdeField("YWALPH5", "YWALPH5", JdeDataType.String, 80),
        new JdeField("YWADD13", "YWADD13", JdeDataType.String, 80),
        new JdeField("YWADD14", "YWADD14", JdeDataType.String, 80),
        new JdeField("YWADD15", "YWADD15", JdeDataType.String, 80),
        new JdeField("YWCTYNH3", "YWCTYNH3", JdeDataType.String, 50),
        new JdeField("YWADDSNH3", "YWADDSNH3", JdeDataType.String, 6),
        new JdeField("YWADDZNH3", "YWADDZNH3", JdeDataType.String, 24),
        new JdeField("YWCRTENH3", "YWCRTENH3", JdeDataType.String, 8),
        new JdeField("YWCTR6", "YWCTR6", JdeDataType.String, 6),
        new JdeField("YWCOUNNH3", "YWCOUNNH3", JdeDataType.String, 50),
        new JdeField("YWFPC5", "YWFPC5", JdeDataType.String, 30),
        new JdeField("YWAN8D", "YWAN8D", JdeDataType.Numeric),
        new JdeField("YWALPH4", "YWALPH4", JdeDataType.String, 80),
        new JdeField("YWADD10", "YWADD10", JdeDataType.String, 80),
        new JdeField("YWADD11", "YWADD11", JdeDataType.String, 80),
        new JdeField("YWADD12", "YWADD12", JdeDataType.String, 80),
        new JdeField("YWCTYNH2", "YWCTYNH2", JdeDataType.String, 50),
        new JdeField("YWADDSNH2", "YWADDSNH2", JdeDataType.String, 6),
        new JdeField("YWTAXENTCODE", "YWTAXENTCODE", JdeDataType.String, 12),
        new JdeField("YWADDZNH2", "YWADDZNH2", JdeDataType.String, 24),
        new JdeField("YWCRTENH2", "YWCRTENH2", JdeDataType.String, 8),
        new JdeField("YWCTR5", "YWCTR5", JdeDataType.String, 6),
        new JdeField("YWCOUNNH2", "YWCOUNNH2", JdeDataType.String, 50),
        new JdeField("YWFPC4", "YWFPC4", JdeDataType.String, 30),
        new JdeField("YWAR3", "YWAR3", JdeDataType.String, 12),
        new JdeField("YWPH3", "YWPH3", JdeDataType.String, 40),
        new JdeField("YWUNITCODE", "YWUNITCODE", JdeDataType.String, 6),
        new JdeField("YWCTRY", "YWCTRY", JdeDataType.Numeric),
        new JdeField("YWUPMJ", "YWUPMJ", JdeDataType.Numeric),
        new JdeField("YWUPMT", "YWUPMT", JdeDataType.Numeric),
        new JdeField("YWPID", "YWPID", JdeDataType.String, 20),
        new JdeField("YWJOBN", "YWJOBN", JdeDataType.String, 20),
        new JdeField("YWUSER", "YWUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07880_0", "Primary Key on YWHMCO, YWTARA, YWAN8, YWDTEY, YWPQTR", new[] { "YWHMCO", "YWTARA", "YWAN8", "YWDTEY", "YWPQTR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07880_2", "Index on YWTARA, YWSEAN, YWAN8", new[] { "YWTARA", "YWSEAN", "YWAN8" })
    };
}
