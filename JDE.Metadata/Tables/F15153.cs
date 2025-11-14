using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15153 - .
/// </summary>
public class F15153 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCICU.
        /// </summary>
        public const string LCICU = "LCICU";

        /// <summary>
        /// LCDOCO.
        /// </summary>
        public const string LCDOCO = "LCDOCO";

        /// <summary>
        /// LCLSVR.
        /// </summary>
        public const string LCLSVR = "LCLSVR";

        /// <summary>
        /// LCBCI.
        /// </summary>
        public const string LCBCI = "LCBCI";

        /// <summary>
        /// LCCAPID.
        /// </summary>
        public const string LCCAPID = "LCCAPID";

        /// <summary>
        /// LCCAPLVL.
        /// </summary>
        public const string LCCAPLVL = "LCCAPLVL";

        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCOBJ.
        /// </summary>
        public const string LCOBJ = "LCOBJ";

        /// <summary>
        /// LCSUB.
        /// </summary>
        public const string LCSUB = "LCSUB";

        /// <summary>
        /// LCSBL.
        /// </summary>
        public const string LCSBL = "LCSBL";

        /// <summary>
        /// LCSBLT.
        /// </summary>
        public const string LCSBLT = "LCSBLT";

        /// <summary>
        /// LCGENT.
        /// </summary>
        public const string LCGENT = "LCGENT";

        /// <summary>
        /// LCCENTYR.
        /// </summary>
        public const string LCCENTYR = "LCCENTYR";

        /// <summary>
        /// LCUNIT.
        /// </summary>
        public const string LCUNIT = "LCUNIT";

        /// <summary>
        /// LCEPCL.
        /// </summary>
        public const string LCEPCL = "LCEPCL";

        /// <summary>
        /// LCCAPBASA.
        /// </summary>
        public const string LCCAPBASA = "LCCAPBASA";

        /// <summary>
        /// LCEXSTCAP.
        /// </summary>
        public const string LCEXSTCAP = "LCEXSTCAP";

        /// <summary>
        /// LCCAPAMT.
        /// </summary>
        public const string LCCAPAMT = "LCCAPAMT";

        /// <summary>
        /// LCFNLAMT.
        /// </summary>
        public const string LCFNLAMT = "LCFNLAMT";

        /// <summary>
        /// LCCAPADJ.
        /// </summary>
        public const string LCCAPADJ = "LCCAPADJ";

        /// <summary>
        /// LCPRCAPAMT.
        /// </summary>
        public const string LCPRCAPAMT = "LCPRCAPAMT";

        /// <summary>
        /// LCCAPPROF.
        /// </summary>
        public const string LCCAPPROF = "LCCAPPROF";

        /// <summary>
        /// LCCAPRAT.
        /// </summary>
        public const string LCCAPRAT = "LCCAPRAT";

        /// <summary>
        /// LCCAPAREA.
        /// </summary>
        public const string LCCAPAREA = "LCCAPAREA";

        /// <summary>
        /// LCCAPPCT.
        /// </summary>
        public const string LCCAPPCT = "LCCAPPCT";

        /// <summary>
        /// LCEPGR.
        /// </summary>
        public const string LCEPGR = "LCEPGR";

        /// <summary>
        /// LCBSEXG.
        /// </summary>
        public const string LCBSEXG = "LCBSEXG";

        /// <summary>
        /// LCECMP.
        /// </summary>
        public const string LCECMP = "LCECMP";

        /// <summary>
        /// LCRFREC.
        /// </summary>
        public const string LCRFREC = "LCRFREC";

        /// <summary>
        /// LCRFRECB.
        /// </summary>
        public const string LCRFRECB = "LCRFRECB";

        /// <summary>
        /// LCCRCD.
        /// </summary>
        public const string LCCRCD = "LCCRCD";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURAT.
        /// </summary>
        public const string LCURAT = "LCURAT";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCMKEY.
        /// </summary>
        public const string LCMKEY = "LCMKEY";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCUPMT.
        /// </summary>
        public const string LCUPMT = "LCUPMT";

        /// <summary>
        /// LCTORG.
        /// </summary>
        public const string LCTORG = "LCTORG";

        /// <summary>
        /// LCENTJ.
        /// </summary>
        public const string LCENTJ = "LCENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15153";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCICU", "LCICU", JdeDataType.Numeric, null, true, true),
        new JdeField("LCDOCO", "LCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LCLSVR", "LCLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("LCBCI", "LCBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("LCCAPID", "LCCAPID", JdeDataType.String, 20, true, true),
        new JdeField("LCCAPLVL", "LCCAPLVL", JdeDataType.String, 2, true, true),
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24, true, true),
        new JdeField("LCOBJ", "LCOBJ", JdeDataType.String, 12, true, true),
        new JdeField("LCSUB", "LCSUB", JdeDataType.String, 16, true, true),
        new JdeField("LCSBL", "LCSBL", JdeDataType.String, 16, true, true),
        new JdeField("LCSBLT", "LCSBLT", JdeDataType.String, 2, true, true),
        new JdeField("LCGENT", "LCGENT", JdeDataType.String, 2),
        new JdeField("LCCENTYR", "LCCENTYR", JdeDataType.Numeric),
        new JdeField("LCUNIT", "LCUNIT", JdeDataType.String, 16),
        new JdeField("LCEPCL", "LCEPCL", JdeDataType.String, 8),
        new JdeField("LCCAPBASA", "LCCAPBASA", JdeDataType.Numeric),
        new JdeField("LCEXSTCAP", "LCEXSTCAP", JdeDataType.Numeric),
        new JdeField("LCCAPAMT", "LCCAPAMT", JdeDataType.Numeric),
        new JdeField("LCFNLAMT", "LCFNLAMT", JdeDataType.Numeric),
        new JdeField("LCCAPADJ", "LCCAPADJ", JdeDataType.Numeric),
        new JdeField("LCPRCAPAMT", "LCPRCAPAMT", JdeDataType.Numeric),
        new JdeField("LCCAPPROF", "LCCAPPROF", JdeDataType.Numeric),
        new JdeField("LCCAPRAT", "LCCAPRAT", JdeDataType.Numeric),
        new JdeField("LCCAPAREA", "LCCAPAREA", JdeDataType.Numeric),
        new JdeField("LCCAPPCT", "LCCAPPCT", JdeDataType.Numeric),
        new JdeField("LCEPGR", "LCEPGR", JdeDataType.String, 6),
        new JdeField("LCBSEXG", "LCBSEXG", JdeDataType.String, 20),
        new JdeField("LCECMP", "LCECMP", JdeDataType.String, 2),
        new JdeField("LCRFREC", "LCRFREC", JdeDataType.Numeric),
        new JdeField("LCRFRECB", "LCRFRECB", JdeDataType.Numeric),
        new JdeField("LCCRCD", "LCCRCD", JdeDataType.String, 6),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCMKEY", "LCMKEY", JdeDataType.String, 30),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCUPMT", "LCUPMT", JdeDataType.Numeric),
        new JdeField("LCTORG", "LCTORG", JdeDataType.String, 20),
        new JdeField("LCENTJ", "LCENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15153_0", "Primary Key on LCICU, LCDOCO, LCLSVR, LCBCI, LCCAPID, LCCAPLVL, LCMCU, LCOBJ, LCSUB, LCSBL, LCSBLT", new[] { "LCICU", "LCDOCO", "LCLSVR", "LCBCI", "LCCAPID", "LCCAPLVL", "LCMCU", "LCOBJ", "LCSUB", "LCSBL", "LCSBLT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15153_2", "Index on LCDOCO, LCLSVR, LCBCI, LCCAPID, LCCAPLVL, LCMCU, LCOBJ, LCSUB, LCSBL, LCSBLT", new[] { "LCDOCO", "LCLSVR", "LCBCI", "LCCAPID", "LCCAPLVL", "LCMCU", "LCOBJ", "LCSUB", "LCSBL", "LCSBLT" }),
        new JdeIndex("F15153_3", "Index on LCCAPID, LCCAPLVL, LCGENT, LCCENTYR", new[] { "LCCAPID", "LCCAPLVL", "LCGENT", "LCCENTYR" }),
        new JdeIndex("F15153_4", "Index on LCDOCO, LCLSVR, LCBCI, LCCAPID, LCCAPLVL, LCGENT, LCCENTYR, LCICU", new[] { "LCDOCO", "LCLSVR", "LCBCI", "LCCAPID", "LCCAPLVL", "LCGENT", "LCCENTYR", "LCICU" })
    };
}
