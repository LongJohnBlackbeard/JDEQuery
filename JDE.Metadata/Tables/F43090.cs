using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43090 - .
/// </summary>
public class F43090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCITM.
        /// </summary>
        public const string PCITM = "PCITM";

        /// <summary>
        /// PCLITM.
        /// </summary>
        public const string PCLITM = "PCLITM";

        /// <summary>
        /// PCAITM.
        /// </summary>
        public const string PCAITM = "PCAITM";

        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCCEFJ.
        /// </summary>
        public const string PCCEFJ = "PCCEFJ";

        /// <summary>
        /// PCCXPJ.
        /// </summary>
        public const string PCCXPJ = "PCCXPJ";

        /// <summary>
        /// PCCERS.
        /// </summary>
        public const string PCCERS = "PCCERS";

        /// <summary>
        /// PCNROU.
        /// </summary>
        public const string PCNROU = "PCNROU";

        /// <summary>
        /// PCTROU.
        /// </summary>
        public const string PCTROU = "PCTROU";

        /// <summary>
        /// PCTFRQ.
        /// </summary>
        public const string PCTFRQ = "PCTFRQ";

        /// <summary>
        /// PCORDS.
        /// </summary>
        public const string PCORDS = "PCORDS";

        /// <summary>
        /// PCTFRD.
        /// </summary>
        public const string PCTFRD = "PCTFRD";

        /// <summary>
        /// PCLTDJ.
        /// </summary>
        public const string PCLTDJ = "PCLTDJ";

        /// <summary>
        /// PCDAYE.
        /// </summary>
        public const string PCDAYE = "PCDAYE";

        /// <summary>
        /// PCDAYL.
        /// </summary>
        public const string PCDAYL = "PCDAYL";

        /// <summary>
        /// PCLTQP.
        /// </summary>
        public const string PCLTQP = "PCLTQP";

        /// <summary>
        /// PCLTNM.
        /// </summary>
        public const string PCLTNM = "PCLTNM";

        /// <summary>
        /// PCLTTS.
        /// </summary>
        public const string PCLTTS = "PCLTTS";

        /// <summary>
        /// PCALTD.
        /// </summary>
        public const string PCALTD = "PCALTD";

        /// <summary>
        /// PCLLTD.
        /// </summary>
        public const string PCLLTD = "PCLLTD";

        /// <summary>
        /// PCACST.
        /// </summary>
        public const string PCACST = "PCACST";

        /// <summary>
        /// PCLCST.
        /// </summary>
        public const string PCLCST = "PCLCST";

        /// <summary>
        /// PCNOOD.
        /// </summary>
        public const string PCNOOD = "PCNOOD";

        /// <summary>
        /// PCQTYS.
        /// </summary>
        public const string PCQTYS = "PCQTYS";

        /// <summary>
        /// PCQTYR.
        /// </summary>
        public const string PCQTYR = "PCQTYR";

        /// <summary>
        /// PCQTYC.
        /// </summary>
        public const string PCQTYC = "PCQTYC";

        /// <summary>
        /// PCQTYW.
        /// </summary>
        public const string PCQTYW = "PCQTYW";

        /// <summary>
        /// PCQTYJ.
        /// </summary>
        public const string PCQTYJ = "PCQTYJ";

        /// <summary>
        /// PCQTYA.
        /// </summary>
        public const string PCQTYA = "PCQTYA";

        /// <summary>
        /// PCUODR.
        /// </summary>
        public const string PCUODR = "PCUODR";

        /// <summary>
        /// PCUREC.
        /// </summary>
        public const string PCUREC = "PCUREC";

        /// <summary>
        /// PCUPTD.
        /// </summary>
        public const string PCUPTD = "PCUPTD";

        /// <summary>
        /// PCUONT.
        /// </summary>
        public const string PCUONT = "PCUONT";

        /// <summary>
        /// PCUEAR.
        /// </summary>
        public const string PCUEAR = "PCUEAR";

        /// <summary>
        /// PCULAT.
        /// </summary>
        public const string PCULAT = "PCULAT";

        /// <summary>
        /// PCAODR.
        /// </summary>
        public const string PCAODR = "PCAODR";

        /// <summary>
        /// PCAREC.
        /// </summary>
        public const string PCAREC = "PCAREC";

        /// <summary>
        /// PCAPTD.
        /// </summary>
        public const string PCAPTD = "PCAPTD";

        /// <summary>
        /// PCAONT.
        /// </summary>
        public const string PCAONT = "PCAONT";

        /// <summary>
        /// PCAEAR.
        /// </summary>
        public const string PCAEAR = "PCAEAR";

        /// <summary>
        /// PCALAT.
        /// </summary>
        public const string PCALAT = "PCALAT";

        /// <summary>
        /// PCRONT.
        /// </summary>
        public const string PCRONT = "PCRONT";

        /// <summary>
        /// PCREAR.
        /// </summary>
        public const string PCREAR = "PCREAR";

        /// <summary>
        /// PCRLAT.
        /// </summary>
        public const string PCRLAT = "PCRLAT";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCROTP.
        /// </summary>
        public const string PCROTP = "PCROTP";

        /// <summary>
        /// PCPOC.
        /// </summary>
        public const string PCPOC = "PCPOC";
    }

    /// <inheritdoc />
    public override string TableName => "F43090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PCITM", "PCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PCLITM", "PCLITM", JdeDataType.String, 50),
        new JdeField("PCAITM", "PCAITM", JdeDataType.String, 50),
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCCEFJ", "PCCEFJ", JdeDataType.Numeric),
        new JdeField("PCCXPJ", "PCCXPJ", JdeDataType.Numeric),
        new JdeField("PCCERS", "PCCERS", JdeDataType.String, 4),
        new JdeField("PCNROU", "PCNROU", JdeDataType.String, 8),
        new JdeField("PCTROU", "PCTROU", JdeDataType.String, 8),
        new JdeField("PCTFRQ", "PCTFRQ", JdeDataType.Numeric),
        new JdeField("PCORDS", "PCORDS", JdeDataType.Numeric),
        new JdeField("PCTFRD", "PCTFRD", JdeDataType.Numeric),
        new JdeField("PCLTDJ", "PCLTDJ", JdeDataType.Numeric),
        new JdeField("PCDAYE", "PCDAYE", JdeDataType.Numeric),
        new JdeField("PCDAYL", "PCDAYL", JdeDataType.Numeric),
        new JdeField("PCLTQP", "PCLTQP", JdeDataType.Numeric),
        new JdeField("PCLTNM", "PCLTNM", JdeDataType.Numeric),
        new JdeField("PCLTTS", "PCLTTS", JdeDataType.Numeric),
        new JdeField("PCALTD", "PCALTD", JdeDataType.Numeric),
        new JdeField("PCLLTD", "PCLLTD", JdeDataType.Numeric),
        new JdeField("PCACST", "PCACST", JdeDataType.Numeric),
        new JdeField("PCLCST", "PCLCST", JdeDataType.Numeric),
        new JdeField("PCNOOD", "PCNOOD", JdeDataType.Numeric),
        new JdeField("PCQTYS", "PCQTYS", JdeDataType.Numeric),
        new JdeField("PCQTYR", "PCQTYR", JdeDataType.Numeric),
        new JdeField("PCQTYC", "PCQTYC", JdeDataType.Numeric),
        new JdeField("PCQTYW", "PCQTYW", JdeDataType.Numeric),
        new JdeField("PCQTYJ", "PCQTYJ", JdeDataType.Numeric),
        new JdeField("PCQTYA", "PCQTYA", JdeDataType.Numeric),
        new JdeField("PCUODR", "PCUODR", JdeDataType.Numeric),
        new JdeField("PCUREC", "PCUREC", JdeDataType.Numeric),
        new JdeField("PCUPTD", "PCUPTD", JdeDataType.Numeric),
        new JdeField("PCUONT", "PCUONT", JdeDataType.Numeric),
        new JdeField("PCUEAR", "PCUEAR", JdeDataType.Numeric),
        new JdeField("PCULAT", "PCULAT", JdeDataType.Numeric),
        new JdeField("PCAODR", "PCAODR", JdeDataType.Numeric),
        new JdeField("PCAREC", "PCAREC", JdeDataType.Numeric),
        new JdeField("PCAPTD", "PCAPTD", JdeDataType.Numeric),
        new JdeField("PCAONT", "PCAONT", JdeDataType.Numeric),
        new JdeField("PCAEAR", "PCAEAR", JdeDataType.Numeric),
        new JdeField("PCALAT", "PCALAT", JdeDataType.Numeric),
        new JdeField("PCRONT", "PCRONT", JdeDataType.Numeric),
        new JdeField("PCREAR", "PCREAR", JdeDataType.Numeric),
        new JdeField("PCRLAT", "PCRLAT", JdeDataType.Numeric),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCROTP", "PCROTP", JdeDataType.String, 2),
        new JdeField("PCPOC", "PCPOC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43090_0", "Primary Key on PCAN8, PCMCU, PCITM", new[] { "PCAN8", "PCMCU", "PCITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43090_2", "Index on PCMCU, PCAN8, PCLITM", new[] { "PCMCU", "PCAN8", "PCLITM" }),
        new JdeIndex("F43090_3", "Index on PCMCU, PCLITM, PCAN8", new[] { "PCMCU", "PCLITM", "PCAN8" }),
        new JdeIndex("F43090_4", "Index on PCITM, PCMCU, PCAN8", new[] { "PCITM", "PCMCU", "PCAN8" }),
        new JdeIndex("F43090_5", "Index on PCAN8, PCLITM", new[] { "PCAN8", "PCLITM" })
    };
}
