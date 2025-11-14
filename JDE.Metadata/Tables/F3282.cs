using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3282 - .
/// </summary>
public class F3282 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RKMCU.
        /// </summary>
        public const string RKMCU = "RKMCU";

        /// <summary>
        /// RKTBLC.
        /// </summary>
        public const string RKTBLC = "RKTBLC";

        /// <summary>
        /// RKRTBT.
        /// </summary>
        public const string RKRTBT = "RKRTBT";

        /// <summary>
        /// RKKIT.
        /// </summary>
        public const string RKKIT = "RKKIT";

        /// <summary>
        /// RKEFFF.
        /// </summary>
        public const string RKEFFF = "RKEFFF";

        /// <summary>
        /// RKEFFT.
        /// </summary>
        public const string RKEFFT = "RKEFFT";

        /// <summary>
        /// RKPEL1.
        /// </summary>
        public const string RKPEL1 = "RKPEL1";

        /// <summary>
        /// RKSIT1.
        /// </summary>
        public const string RKSIT1 = "RKSIT1";

        /// <summary>
        /// RKTMC1.
        /// </summary>
        public const string RKTMC1 = "RKTMC1";

        /// <summary>
        /// RKPEL2.
        /// </summary>
        public const string RKPEL2 = "RKPEL2";

        /// <summary>
        /// RKSIT2.
        /// </summary>
        public const string RKSIT2 = "RKSIT2";

        /// <summary>
        /// RKTMC2.
        /// </summary>
        public const string RKTMC2 = "RKTMC2";

        /// <summary>
        /// RKPEL3.
        /// </summary>
        public const string RKPEL3 = "RKPEL3";

        /// <summary>
        /// RKSIT3.
        /// </summary>
        public const string RKSIT3 = "RKSIT3";

        /// <summary>
        /// RKTMC3.
        /// </summary>
        public const string RKTMC3 = "RKTMC3";

        /// <summary>
        /// RKPEL4.
        /// </summary>
        public const string RKPEL4 = "RKPEL4";

        /// <summary>
        /// RKSIT4.
        /// </summary>
        public const string RKSIT4 = "RKSIT4";

        /// <summary>
        /// RKTMC4.
        /// </summary>
        public const string RKTMC4 = "RKTMC4";

        /// <summary>
        /// RKPEL5.
        /// </summary>
        public const string RKPEL5 = "RKPEL5";

        /// <summary>
        /// RKSIT5.
        /// </summary>
        public const string RKSIT5 = "RKSIT5";

        /// <summary>
        /// RKTMC5.
        /// </summary>
        public const string RKTMC5 = "RKTMC5";

        /// <summary>
        /// RKPEL6.
        /// </summary>
        public const string RKPEL6 = "RKPEL6";

        /// <summary>
        /// RKSIT6.
        /// </summary>
        public const string RKSIT6 = "RKSIT6";

        /// <summary>
        /// RKTMC6.
        /// </summary>
        public const string RKTMC6 = "RKTMC6";

        /// <summary>
        /// RKPEL7.
        /// </summary>
        public const string RKPEL7 = "RKPEL7";

        /// <summary>
        /// RKSIT7.
        /// </summary>
        public const string RKSIT7 = "RKSIT7";

        /// <summary>
        /// RKTMC7.
        /// </summary>
        public const string RKTMC7 = "RKTMC7";

        /// <summary>
        /// RKPEL8.
        /// </summary>
        public const string RKPEL8 = "RKPEL8";

        /// <summary>
        /// RKSIT8.
        /// </summary>
        public const string RKSIT8 = "RKSIT8";

        /// <summary>
        /// RKTMC8.
        /// </summary>
        public const string RKTMC8 = "RKTMC8";

        /// <summary>
        /// RKPEL9.
        /// </summary>
        public const string RKPEL9 = "RKPEL9";

        /// <summary>
        /// RKSIT9.
        /// </summary>
        public const string RKSIT9 = "RKSIT9";

        /// <summary>
        /// RKTMC9.
        /// </summary>
        public const string RKTMC9 = "RKTMC9";

        /// <summary>
        /// RKPEL0.
        /// </summary>
        public const string RKPEL0 = "RKPEL0";

        /// <summary>
        /// RKSIT0.
        /// </summary>
        public const string RKSIT0 = "RKSIT0";

        /// <summary>
        /// RKTMC0.
        /// </summary>
        public const string RKTMC0 = "RKTMC0";

        /// <summary>
        /// RKPEL11.
        /// </summary>
        public const string RKPEL11 = "RKPEL11";

        /// <summary>
        /// RKSIT11.
        /// </summary>
        public const string RKSIT11 = "RKSIT11";

        /// <summary>
        /// RKTMC11.
        /// </summary>
        public const string RKTMC11 = "RKTMC11";

        /// <summary>
        /// RKPEL12.
        /// </summary>
        public const string RKPEL12 = "RKPEL12";

        /// <summary>
        /// RKSIT12.
        /// </summary>
        public const string RKSIT12 = "RKSIT12";

        /// <summary>
        /// RKTMC12.
        /// </summary>
        public const string RKTMC12 = "RKTMC12";

        /// <summary>
        /// RKPEL13.
        /// </summary>
        public const string RKPEL13 = "RKPEL13";

        /// <summary>
        /// RKSIT13.
        /// </summary>
        public const string RKSIT13 = "RKSIT13";

        /// <summary>
        /// RKTMC13.
        /// </summary>
        public const string RKTMC13 = "RKTMC13";

        /// <summary>
        /// RKPEL14.
        /// </summary>
        public const string RKPEL14 = "RKPEL14";

        /// <summary>
        /// RKSIT14.
        /// </summary>
        public const string RKSIT14 = "RKSIT14";

        /// <summary>
        /// RKTMC14.
        /// </summary>
        public const string RKTMC14 = "RKTMC14";

        /// <summary>
        /// RKPEL15.
        /// </summary>
        public const string RKPEL15 = "RKPEL15";

        /// <summary>
        /// RKSIT15.
        /// </summary>
        public const string RKSIT15 = "RKSIT15";

        /// <summary>
        /// RKTMC15.
        /// </summary>
        public const string RKTMC15 = "RKTMC15";

        /// <summary>
        /// RKPEL16.
        /// </summary>
        public const string RKPEL16 = "RKPEL16";

        /// <summary>
        /// RKSIT16.
        /// </summary>
        public const string RKSIT16 = "RKSIT16";

        /// <summary>
        /// RKTMC16.
        /// </summary>
        public const string RKTMC16 = "RKTMC16";

        /// <summary>
        /// RKPEL17.
        /// </summary>
        public const string RKPEL17 = "RKPEL17";

        /// <summary>
        /// RKSIT17.
        /// </summary>
        public const string RKSIT17 = "RKSIT17";

        /// <summary>
        /// RKTMC17.
        /// </summary>
        public const string RKTMC17 = "RKTMC17";

        /// <summary>
        /// RKPEL18.
        /// </summary>
        public const string RKPEL18 = "RKPEL18";

        /// <summary>
        /// RKSIT18.
        /// </summary>
        public const string RKSIT18 = "RKSIT18";

        /// <summary>
        /// RKTMC18.
        /// </summary>
        public const string RKTMC18 = "RKTMC18";

        /// <summary>
        /// RKPEL19.
        /// </summary>
        public const string RKPEL19 = "RKPEL19";

        /// <summary>
        /// RKSIT19.
        /// </summary>
        public const string RKSIT19 = "RKSIT19";

        /// <summary>
        /// RKTMC19.
        /// </summary>
        public const string RKTMC19 = "RKTMC19";

        /// <summary>
        /// RKPEL20.
        /// </summary>
        public const string RKPEL20 = "RKPEL20";

        /// <summary>
        /// RKSIT20.
        /// </summary>
        public const string RKSIT20 = "RKSIT20";

        /// <summary>
        /// RKTMC20.
        /// </summary>
        public const string RKTMC20 = "RKTMC20";

        /// <summary>
        /// RKURCD.
        /// </summary>
        public const string RKURCD = "RKURCD";

        /// <summary>
        /// RKURDT.
        /// </summary>
        public const string RKURDT = "RKURDT";

        /// <summary>
        /// RKURAT.
        /// </summary>
        public const string RKURAT = "RKURAT";

        /// <summary>
        /// RKURAB.
        /// </summary>
        public const string RKURAB = "RKURAB";

        /// <summary>
        /// RKURRF.
        /// </summary>
        public const string RKURRF = "RKURRF";

        /// <summary>
        /// RKUSER.
        /// </summary>
        public const string RKUSER = "RKUSER";

        /// <summary>
        /// RKPID.
        /// </summary>
        public const string RKPID = "RKPID";

        /// <summary>
        /// RKJOBN.
        /// </summary>
        public const string RKJOBN = "RKJOBN";

        /// <summary>
        /// RKUPMJ.
        /// </summary>
        public const string RKUPMJ = "RKUPMJ";

        /// <summary>
        /// RKTDAY.
        /// </summary>
        public const string RKTDAY = "RKTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3282";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RKMCU", "RKMCU", JdeDataType.String, 24, true, true),
        new JdeField("RKTBLC", "RKTBLC", JdeDataType.String, 20, true, true),
        new JdeField("RKRTBT", "RKRTBT", JdeDataType.String, 2, true, true),
        new JdeField("RKKIT", "RKKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("RKEFFF", "RKEFFF", JdeDataType.Numeric),
        new JdeField("RKEFFT", "RKEFFT", JdeDataType.Numeric),
        new JdeField("RKPEL1", "RKPEL1", JdeDataType.Numeric),
        new JdeField("RKSIT1", "RKSIT1", JdeDataType.Numeric),
        new JdeField("RKTMC1", "RKTMC1", JdeDataType.String, 24),
        new JdeField("RKPEL2", "RKPEL2", JdeDataType.Numeric),
        new JdeField("RKSIT2", "RKSIT2", JdeDataType.Numeric),
        new JdeField("RKTMC2", "RKTMC2", JdeDataType.String, 24),
        new JdeField("RKPEL3", "RKPEL3", JdeDataType.Numeric),
        new JdeField("RKSIT3", "RKSIT3", JdeDataType.Numeric),
        new JdeField("RKTMC3", "RKTMC3", JdeDataType.String, 24),
        new JdeField("RKPEL4", "RKPEL4", JdeDataType.Numeric),
        new JdeField("RKSIT4", "RKSIT4", JdeDataType.Numeric),
        new JdeField("RKTMC4", "RKTMC4", JdeDataType.String, 24),
        new JdeField("RKPEL5", "RKPEL5", JdeDataType.Numeric),
        new JdeField("RKSIT5", "RKSIT5", JdeDataType.Numeric),
        new JdeField("RKTMC5", "RKTMC5", JdeDataType.String, 24),
        new JdeField("RKPEL6", "RKPEL6", JdeDataType.Numeric),
        new JdeField("RKSIT6", "RKSIT6", JdeDataType.Numeric),
        new JdeField("RKTMC6", "RKTMC6", JdeDataType.String, 24),
        new JdeField("RKPEL7", "RKPEL7", JdeDataType.Numeric),
        new JdeField("RKSIT7", "RKSIT7", JdeDataType.Numeric),
        new JdeField("RKTMC7", "RKTMC7", JdeDataType.String, 24),
        new JdeField("RKPEL8", "RKPEL8", JdeDataType.Numeric),
        new JdeField("RKSIT8", "RKSIT8", JdeDataType.Numeric),
        new JdeField("RKTMC8", "RKTMC8", JdeDataType.String, 24),
        new JdeField("RKPEL9", "RKPEL9", JdeDataType.Numeric),
        new JdeField("RKSIT9", "RKSIT9", JdeDataType.Numeric),
        new JdeField("RKTMC9", "RKTMC9", JdeDataType.String, 24),
        new JdeField("RKPEL0", "RKPEL0", JdeDataType.Numeric),
        new JdeField("RKSIT0", "RKSIT0", JdeDataType.Numeric),
        new JdeField("RKTMC0", "RKTMC0", JdeDataType.String, 24),
        new JdeField("RKPEL11", "RKPEL11", JdeDataType.Numeric),
        new JdeField("RKSIT11", "RKSIT11", JdeDataType.Numeric),
        new JdeField("RKTMC11", "RKTMC11", JdeDataType.String, 24),
        new JdeField("RKPEL12", "RKPEL12", JdeDataType.Numeric),
        new JdeField("RKSIT12", "RKSIT12", JdeDataType.Numeric),
        new JdeField("RKTMC12", "RKTMC12", JdeDataType.String, 24),
        new JdeField("RKPEL13", "RKPEL13", JdeDataType.Numeric),
        new JdeField("RKSIT13", "RKSIT13", JdeDataType.Numeric),
        new JdeField("RKTMC13", "RKTMC13", JdeDataType.String, 24),
        new JdeField("RKPEL14", "RKPEL14", JdeDataType.Numeric),
        new JdeField("RKSIT14", "RKSIT14", JdeDataType.Numeric),
        new JdeField("RKTMC14", "RKTMC14", JdeDataType.String, 24),
        new JdeField("RKPEL15", "RKPEL15", JdeDataType.Numeric),
        new JdeField("RKSIT15", "RKSIT15", JdeDataType.Numeric),
        new JdeField("RKTMC15", "RKTMC15", JdeDataType.String, 24),
        new JdeField("RKPEL16", "RKPEL16", JdeDataType.Numeric),
        new JdeField("RKSIT16", "RKSIT16", JdeDataType.Numeric),
        new JdeField("RKTMC16", "RKTMC16", JdeDataType.String, 24),
        new JdeField("RKPEL17", "RKPEL17", JdeDataType.Numeric),
        new JdeField("RKSIT17", "RKSIT17", JdeDataType.Numeric),
        new JdeField("RKTMC17", "RKTMC17", JdeDataType.String, 24),
        new JdeField("RKPEL18", "RKPEL18", JdeDataType.Numeric),
        new JdeField("RKSIT18", "RKSIT18", JdeDataType.Numeric),
        new JdeField("RKTMC18", "RKTMC18", JdeDataType.String, 24),
        new JdeField("RKPEL19", "RKPEL19", JdeDataType.Numeric),
        new JdeField("RKSIT19", "RKSIT19", JdeDataType.Numeric),
        new JdeField("RKTMC19", "RKTMC19", JdeDataType.String, 24),
        new JdeField("RKPEL20", "RKPEL20", JdeDataType.Numeric),
        new JdeField("RKSIT20", "RKSIT20", JdeDataType.Numeric),
        new JdeField("RKTMC20", "RKTMC20", JdeDataType.String, 24),
        new JdeField("RKURCD", "RKURCD", JdeDataType.String, 4),
        new JdeField("RKURDT", "RKURDT", JdeDataType.Numeric),
        new JdeField("RKURAT", "RKURAT", JdeDataType.Numeric),
        new JdeField("RKURAB", "RKURAB", JdeDataType.Numeric),
        new JdeField("RKURRF", "RKURRF", JdeDataType.String, 30),
        new JdeField("RKUSER", "RKUSER", JdeDataType.String, 20),
        new JdeField("RKPID", "RKPID", JdeDataType.String, 20),
        new JdeField("RKJOBN", "RKJOBN", JdeDataType.String, 20),
        new JdeField("RKUPMJ", "RKUPMJ", JdeDataType.Numeric),
        new JdeField("RKTDAY", "RKTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3282_0", "Primary Key on RKTBLC, RKMCU, RKRTBT, RKKIT", new[] { "RKTBLC", "RKMCU", "RKRTBT", "RKKIT" }, isUnique: true, isPrimaryKey: true)
    };
}
