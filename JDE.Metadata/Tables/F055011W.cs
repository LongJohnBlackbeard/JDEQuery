using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F055011W - .
/// </summary>
public class F055011W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADAN8.
        /// </summary>
        public const string ADAN8 = "ADAN8";

        /// <summary>
        /// ADSSN.
        /// </summary>
        public const string ADSSN = "ADSSN";

        /// <summary>
        /// ADALPH.
        /// </summary>
        public const string ADALPH = "ADALPH";

        /// <summary>
        /// ADHMCO.
        /// </summary>
        public const string ADHMCO = "ADHMCO";

        /// <summary>
        /// ADTAX.
        /// </summary>
        public const string ADTAX = "ADTAX";

        /// <summary>
        /// ADSEC.
        /// </summary>
        public const string ADSEC = "ADSEC";

        /// <summary>
        /// ADSCC.
        /// </summary>
        public const string ADSCC = "ADSCC";

        /// <summary>
        /// ADPSDT.
        /// </summary>
        public const string ADPSDT = "ADPSDT";

        /// <summary>
        /// ADPTDT.
        /// </summary>
        public const string ADPTDT = "ADPTDT";

        /// <summary>
        /// ADFPCD.
        /// </summary>
        public const string ADFPCD = "ADFPCD";

        /// <summary>
        /// ADPREN.
        /// </summary>
        public const string ADPREN = "ADPREN";

        /// <summary>
        /// ADDEP1.
        /// </summary>
        public const string ADDEP1 = "ADDEP1";

        /// <summary>
        /// ADDEP2.
        /// </summary>
        public const string ADDEP2 = "ADDEP2";

        /// <summary>
        /// ADDEP3.
        /// </summary>
        public const string ADDEP3 = "ADDEP3";

        /// <summary>
        /// ADDEP4.
        /// </summary>
        public const string ADDEP4 = "ADDEP4";

        /// <summary>
        /// ADDEP5.
        /// </summary>
        public const string ADDEP5 = "ADDEP5";

        /// <summary>
        /// ADDEP6.
        /// </summary>
        public const string ADDEP6 = "ADDEP6";

        /// <summary>
        /// ADUSER.
        /// </summary>
        public const string ADUSER = "ADUSER";

        /// <summary>
        /// ADPID.
        /// </summary>
        public const string ADPID = "ADPID";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADEV01.
        /// </summary>
        public const string ADEV01 = "ADEV01";

        /// <summary>
        /// ADSEQ.
        /// </summary>
        public const string ADSEQ = "ADSEQ";

        /// <summary>
        /// ADSEQN2.
        /// </summary>
        public const string ADSEQN2 = "ADSEQN2";

        /// <summary>
        /// ADBDM.
        /// </summary>
        public const string ADBDM = "ADBDM";

        /// <summary>
        /// ADBDM2.
        /// </summary>
        public const string ADBDM2 = "ADBDM2";

        /// <summary>
        /// ADFOA#.
        /// </summary>
        public const string ADFOA_ = "ADFOA#";

        /// <summary>
        /// ADFOA#2.
        /// </summary>
        public const string ADFOA_2 = "ADFOA#2";

        /// <summary>
        /// ADOFO#.
        /// </summary>
        public const string ADOFO_ = "ADOFO#";

        /// <summary>
        /// ADIFO#.
        /// </summary>
        public const string ADIFO_ = "ADIFO#";

        /// <summary>
        /// ADTCOD.
        /// </summary>
        public const string ADTCOD = "ADTCOD";

        /// <summary>
        /// ADGPAY.
        /// </summary>
        public const string ADGPAY = "ADGPAY";

        /// <summary>
        /// ADEV02.
        /// </summary>
        public const string ADEV02 = "ADEV02";

        /// <summary>
        /// ADSEQN3.
        /// </summary>
        public const string ADSEQN3 = "ADSEQN3";

        /// <summary>
        /// ADSEQN4.
        /// </summary>
        public const string ADSEQN4 = "ADSEQN4";

        /// <summary>
        /// ADBDM3.
        /// </summary>
        public const string ADBDM3 = "ADBDM3";

        /// <summary>
        /// ADBDM4.
        /// </summary>
        public const string ADBDM4 = "ADBDM4";

        /// <summary>
        /// ADFOA#3.
        /// </summary>
        public const string ADFOA_3 = "ADFOA#3";

        /// <summary>
        /// ADFOA#4.
        /// </summary>
        public const string ADFOA_4 = "ADFOA#4";

        /// <summary>
        /// ADOFO#2.
        /// </summary>
        public const string ADOFO_2 = "ADOFO#2";

        /// <summary>
        /// ADIFO#2.
        /// </summary>
        public const string ADIFO_2 = "ADIFO#2";

        /// <summary>
        /// ADTCOD2.
        /// </summary>
        public const string ADTCOD2 = "ADTCOD2";

        /// <summary>
        /// ADGPAY2.
        /// </summary>
        public const string ADGPAY2 = "ADGPAY2";

        /// <summary>
        /// ADEV03.
        /// </summary>
        public const string ADEV03 = "ADEV03";

        /// <summary>
        /// ADSEQN5.
        /// </summary>
        public const string ADSEQN5 = "ADSEQN5";

        /// <summary>
        /// ADSEQN6.
        /// </summary>
        public const string ADSEQN6 = "ADSEQN6";

        /// <summary>
        /// ADBDM5.
        /// </summary>
        public const string ADBDM5 = "ADBDM5";

        /// <summary>
        /// ADBDM6.
        /// </summary>
        public const string ADBDM6 = "ADBDM6";

        /// <summary>
        /// ADFOA#5.
        /// </summary>
        public const string ADFOA_5 = "ADFOA#5";

        /// <summary>
        /// ADFOA#6.
        /// </summary>
        public const string ADFOA_6 = "ADFOA#6";

        /// <summary>
        /// ADOFO#3.
        /// </summary>
        public const string ADOFO_3 = "ADOFO#3";

        /// <summary>
        /// ADIFO#3.
        /// </summary>
        public const string ADIFO_3 = "ADIFO#3";

        /// <summary>
        /// ADTCOD3.
        /// </summary>
        public const string ADTCOD3 = "ADTCOD3";

        /// <summary>
        /// ADGPAY3.
        /// </summary>
        public const string ADGPAY3 = "ADGPAY3";

        /// <summary>
        /// ADEV04.
        /// </summary>
        public const string ADEV04 = "ADEV04";

        /// <summary>
        /// ADSEQN7.
        /// </summary>
        public const string ADSEQN7 = "ADSEQN7";

        /// <summary>
        /// ADSEQN8.
        /// </summary>
        public const string ADSEQN8 = "ADSEQN8";

        /// <summary>
        /// ADBDM7.
        /// </summary>
        public const string ADBDM7 = "ADBDM7";

        /// <summary>
        /// ADBDM8.
        /// </summary>
        public const string ADBDM8 = "ADBDM8";

        /// <summary>
        /// ADFOA#7.
        /// </summary>
        public const string ADFOA_7 = "ADFOA#7";

        /// <summary>
        /// ADFOA#8.
        /// </summary>
        public const string ADFOA_8 = "ADFOA#8";

        /// <summary>
        /// ADOFO#4.
        /// </summary>
        public const string ADOFO_4 = "ADOFO#4";

        /// <summary>
        /// ADIFO#4.
        /// </summary>
        public const string ADIFO_4 = "ADIFO#4";

        /// <summary>
        /// ADTCOD4.
        /// </summary>
        public const string ADTCOD4 = "ADTCOD4";

        /// <summary>
        /// ADGPAY4.
        /// </summary>
        public const string ADGPAY4 = "ADGPAY4";

        /// <summary>
        /// ADDL30.
        /// </summary>
        public const string ADDL30 = "ADDL30";

        /// <summary>
        /// ADFPCD2.
        /// </summary>
        public const string ADFPCD2 = "ADFPCD2";

        /// <summary>
        /// ADFPCD3.
        /// </summary>
        public const string ADFPCD3 = "ADFPCD3";

        /// <summary>
        /// ADFPCD4.
        /// </summary>
        public const string ADFPCD4 = "ADFPCD4";

        /// <summary>
        /// ADFPCD5.
        /// </summary>
        public const string ADFPCD5 = "ADFPCD5";
    }

    /// <inheritdoc />
    public override string TableName => "F055011W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADAN8", "ADAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ADSSN", "ADSSN", JdeDataType.String, 40),
        new JdeField("ADALPH", "ADALPH", JdeDataType.String, 80, true, true),
        new JdeField("ADHMCO", "ADHMCO", JdeDataType.String, 10),
        new JdeField("ADTAX", "ADTAX", JdeDataType.String, 40),
        new JdeField("ADSEC", "ADSEC", JdeDataType.String, 6),
        new JdeField("ADSCC", "ADSCC", JdeDataType.String, 6),
        new JdeField("ADPSDT", "ADPSDT", JdeDataType.Numeric),
        new JdeField("ADPTDT", "ADPTDT", JdeDataType.Numeric),
        new JdeField("ADFPCD", "ADFPCD", JdeDataType.String, 2),
        new JdeField("ADPREN", "ADPREN", JdeDataType.String, 4),
        new JdeField("ADDEP1", "ADDEP1", JdeDataType.String, 2),
        new JdeField("ADDEP2", "ADDEP2", JdeDataType.String, 2),
        new JdeField("ADDEP3", "ADDEP3", JdeDataType.String, 2),
        new JdeField("ADDEP4", "ADDEP4", JdeDataType.String, 2),
        new JdeField("ADDEP5", "ADDEP5", JdeDataType.String, 2),
        new JdeField("ADDEP6", "ADDEP6", JdeDataType.String, 2),
        new JdeField("ADUSER", "ADUSER", JdeDataType.String, 20),
        new JdeField("ADPID", "ADPID", JdeDataType.String, 20),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADEV01", "ADEV01", JdeDataType.String, 2),
        new JdeField("ADSEQ", "ADSEQ", JdeDataType.Numeric),
        new JdeField("ADSEQN2", "ADSEQN2", JdeDataType.Numeric),
        new JdeField("ADBDM", "ADBDM", JdeDataType.String, 2),
        new JdeField("ADBDM2", "ADBDM2", JdeDataType.String, 2),
        new JdeField("ADFOA#", "ADFOA#", JdeDataType.String, 34),
        new JdeField("ADFOA#2", "ADFOA#2", JdeDataType.String, 34),
        new JdeField("ADOFO#", "ADOFO#", JdeDataType.String, 18),
        new JdeField("ADIFO#", "ADIFO#", JdeDataType.String, 18),
        new JdeField("ADTCOD", "ADTCOD", JdeDataType.String, 4),
        new JdeField("ADGPAY", "ADGPAY", JdeDataType.Numeric),
        new JdeField("ADEV02", "ADEV02", JdeDataType.String, 2),
        new JdeField("ADSEQN3", "ADSEQN3", JdeDataType.Numeric),
        new JdeField("ADSEQN4", "ADSEQN4", JdeDataType.Numeric),
        new JdeField("ADBDM3", "ADBDM3", JdeDataType.String, 2),
        new JdeField("ADBDM4", "ADBDM4", JdeDataType.String, 2),
        new JdeField("ADFOA#3", "ADFOA#3", JdeDataType.String, 34),
        new JdeField("ADFOA#4", "ADFOA#4", JdeDataType.String, 34),
        new JdeField("ADOFO#2", "ADOFO#2", JdeDataType.String, 18),
        new JdeField("ADIFO#2", "ADIFO#2", JdeDataType.String, 18),
        new JdeField("ADTCOD2", "ADTCOD2", JdeDataType.String, 4),
        new JdeField("ADGPAY2", "ADGPAY2", JdeDataType.Numeric),
        new JdeField("ADEV03", "ADEV03", JdeDataType.String, 2),
        new JdeField("ADSEQN5", "ADSEQN5", JdeDataType.Numeric),
        new JdeField("ADSEQN6", "ADSEQN6", JdeDataType.Numeric),
        new JdeField("ADBDM5", "ADBDM5", JdeDataType.String, 2),
        new JdeField("ADBDM6", "ADBDM6", JdeDataType.String, 2),
        new JdeField("ADFOA#5", "ADFOA#5", JdeDataType.String, 34),
        new JdeField("ADFOA#6", "ADFOA#6", JdeDataType.String, 34),
        new JdeField("ADOFO#3", "ADOFO#3", JdeDataType.String, 18),
        new JdeField("ADIFO#3", "ADIFO#3", JdeDataType.String, 18),
        new JdeField("ADTCOD3", "ADTCOD3", JdeDataType.String, 4),
        new JdeField("ADGPAY3", "ADGPAY3", JdeDataType.Numeric),
        new JdeField("ADEV04", "ADEV04", JdeDataType.String, 2),
        new JdeField("ADSEQN7", "ADSEQN7", JdeDataType.Numeric),
        new JdeField("ADSEQN8", "ADSEQN8", JdeDataType.Numeric),
        new JdeField("ADBDM7", "ADBDM7", JdeDataType.String, 2),
        new JdeField("ADBDM8", "ADBDM8", JdeDataType.String, 2),
        new JdeField("ADFOA#7", "ADFOA#7", JdeDataType.String, 34),
        new JdeField("ADFOA#8", "ADFOA#8", JdeDataType.String, 34),
        new JdeField("ADOFO#4", "ADOFO#4", JdeDataType.String, 18),
        new JdeField("ADIFO#4", "ADIFO#4", JdeDataType.String, 18),
        new JdeField("ADTCOD4", "ADTCOD4", JdeDataType.String, 4),
        new JdeField("ADGPAY4", "ADGPAY4", JdeDataType.Numeric),
        new JdeField("ADDL30", "ADDL30", JdeDataType.String, 60),
        new JdeField("ADFPCD2", "ADFPCD2", JdeDataType.String, 2),
        new JdeField("ADFPCD3", "ADFPCD3", JdeDataType.String, 2),
        new JdeField("ADFPCD4", "ADFPCD4", JdeDataType.String, 2),
        new JdeField("ADFPCD5", "ADFPCD5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F055011W_0", "Primary Key on ADALPH, ADAN8", new[] { "ADALPH", "ADAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F055011W_2", "Index on ADSSN, ADHMCO, ADTAX, ADSEC, ADSCC, ADPSDT, ADPTDT, ADFPCD, ADPREN, ADDEP1, ADDEP2, ADDEP3, ADDEP4, ADDEP5, ADDEP6", new[] { "ADSSN", "ADHMCO", "ADTAX", "ADSEC", "ADSCC", "ADPSDT", "ADPTDT", "ADFPCD", "ADPREN", "ADDEP1", "ADDEP2", "ADDEP3", "ADDEP4", "ADDEP5", "ADDEP6" }),
        new JdeIndex("F055011W_3", "Index on ADUSER, ADPID, ADUPMJ", new[] { "ADUSER", "ADPID", "ADUPMJ" }),
        new JdeIndex("F055011W_4", "Index on ADEV01, ADSEQ, ADSEQN2, ADBDM, ADBDM2, ADFOA#, ADFOA#2, ADOFO#, ADIFO#, ADTCOD, ADGPAY", new[] { "ADEV01", "ADSEQ", "ADSEQN2", "ADBDM", "ADBDM2", "ADFOA#", "ADFOA#2", "ADOFO#", "ADIFO#", "ADTCOD", "ADGPAY" }),
        new JdeIndex("F055011W_5", "Index on ADEV02, ADSEQN3, ADSEQN4, ADBDM3, ADBDM4, ADFOA#3, ADFOA#4, ADOFO#2, ADIFO#2, ADTCOD2, ADGPAY2", new[] { "ADEV02", "ADSEQN3", "ADSEQN4", "ADBDM3", "ADBDM4", "ADFOA#3", "ADFOA#4", "ADOFO#2", "ADIFO#2", "ADTCOD2", "ADGPAY2" }),
        new JdeIndex("F055011W_6", "Index on ADEV03, ADSEQN5, ADSEQN6, ADBDM5, ADBDM6, ADFOA#5, ADFOA#6, ADOFO#3, ADIFO#3, ADTCOD3, ADGPAY3", new[] { "ADEV03", "ADSEQN5", "ADSEQN6", "ADBDM5", "ADBDM6", "ADFOA#5", "ADFOA#6", "ADOFO#3", "ADIFO#3", "ADTCOD3", "ADGPAY3" }),
        new JdeIndex("F055011W_7", "Index on ADEV04, ADSEQN7, ADSEQN8, ADBDM7, ADBDM8, ADFOA#7, ADFOA#8, ADOFO#4, ADIFO#4, ADTCOD4, ADGPAY4", new[] { "ADEV04", "ADSEQN7", "ADSEQN8", "ADBDM7", "ADBDM8", "ADFOA#7", "ADFOA#8", "ADOFO#4", "ADIFO#4", "ADTCOD4", "ADGPAY4" }),
        new JdeIndex("F055011W_8", "Index on ADDL30, ADFPCD2, ADFPCD3, ADFPCD4, ADFPCD5", new[] { "ADDL30", "ADFPCD2", "ADFPCD3", "ADFPCD4", "ADFPCD5" })
    };
}
