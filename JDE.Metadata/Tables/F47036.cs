using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47036 - .
/// </summary>
public class F47036 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDTY.
        /// </summary>
        public const string SYEDTY = "SYEDTY";

        /// <summary>
        /// SYEDSQ.
        /// </summary>
        public const string SYEDSQ = "SYEDSQ";

        /// <summary>
        /// SYEKCO.
        /// </summary>
        public const string SYEKCO = "SYEKCO";

        /// <summary>
        /// SYEDOC.
        /// </summary>
        public const string SYEDOC = "SYEDOC";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDST.
        /// </summary>
        public const string SYEDST = "SYEDST";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYEDER.
        /// </summary>
        public const string SYEDER = "SYEDER";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYTPUR.
        /// </summary>
        public const string SYTPUR = "SYTPUR";

        /// <summary>
        /// SYSPID.
        /// </summary>
        public const string SYSPID = "SYSPID";

        /// <summary>
        /// SYVERS.
        /// </summary>
        public const string SYVERS = "SYVERS";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";

        /// <summary>
        /// SYACKCD.
        /// </summary>
        public const string SYACKCD = "SYACKCD";

        /// <summary>
        /// SYACKDJ.
        /// </summary>
        public const string SYACKDJ = "SYACKDJ";

        /// <summary>
        /// SYACKRC.
        /// </summary>
        public const string SYACKRC = "SYACKRC";

        /// <summary>
        /// SYACKT.
        /// </summary>
        public const string SYACKT = "SYACKT";

        /// <summary>
        /// SYACKTM.
        /// </summary>
        public const string SYACKTM = "SYACKTM";

        /// <summary>
        /// SYADLJ.
        /// </summary>
        public const string SYADLJ = "SYADLJ";

        /// <summary>
        /// SYADTM.
        /// </summary>
        public const string SYADTM = "SYADTM";

        /// <summary>
        /// SYASNDJ.
        /// </summary>
        public const string SYASNDJ = "SYASNDJ";

        /// <summary>
        /// SYASNTM.
        /// </summary>
        public const string SYASNTM = "SYASNTM";

        /// <summary>
        /// SYAUFI.
        /// </summary>
        public const string SYAUFI = "SYAUFI";

        /// <summary>
        /// SYAUFT.
        /// </summary>
        public const string SYAUFT = "SYAUFT";

        /// <summary>
        /// SYBCRC.
        /// </summary>
        public const string SYBCRC = "SYBCRC";

        /// <summary>
        /// SYBSC.
        /// </summary>
        public const string SYBSC = "SYBSC";

        /// <summary>
        /// SYCORD.
        /// </summary>
        public const string SYCORD = "SYCORD";

        /// <summary>
        /// SYDCT4.
        /// </summary>
        public const string SYDCT4 = "SYDCT4";

        /// <summary>
        /// SYDOC1.
        /// </summary>
        public const string SYDOC1 = "SYDOC1";

        /// <summary>
        /// SYDRQT.
        /// </summary>
        public const string SYDRQT = "SYDRQT";

        /// <summary>
        /// SYDVAN.
        /// </summary>
        public const string SYDVAN = "SYDVAN";

        /// <summary>
        /// SYEDITM.
        /// </summary>
        public const string SYEDITM = "SYEDITM";

        /// <summary>
        /// SYFTAN.
        /// </summary>
        public const string SYFTAN = "SYFTAN";

        /// <summary>
        /// SYFUF1.
        /// </summary>
        public const string SYFUF1 = "SYFUF1";

        /// <summary>
        /// SYFUF2.
        /// </summary>
        public const string SYFUF2 = "SYFUF2";

        /// <summary>
        /// SYHOLD.
        /// </summary>
        public const string SYHOLD = "SYHOLD";

        /// <summary>
        /// SYINVC.
        /// </summary>
        public const string SYINVC = "SYINVC";

        /// <summary>
        /// SYIR01.
        /// </summary>
        public const string SYIR01 = "SYIR01";

        /// <summary>
        /// SYIR02.
        /// </summary>
        public const string SYIR02 = "SYIR02";

        /// <summary>
        /// SYIR03.
        /// </summary>
        public const string SYIR03 = "SYIR03";

        /// <summary>
        /// SYIR04.
        /// </summary>
        public const string SYIR04 = "SYIR04";

        /// <summary>
        /// SYIR05.
        /// </summary>
        public const string SYIR05 = "SYIR05";

        /// <summary>
        /// SYITAN.
        /// </summary>
        public const string SYITAN = "SYITAN";

        /// <summary>
        /// SYMORD.
        /// </summary>
        public const string SYMORD = "SYMORD";

        /// <summary>
        /// SYOPBA.
        /// </summary>
        public const string SYOPBA = "SYOPBA";

        /// <summary>
        /// SYOPBK.
        /// </summary>
        public const string SYOPBK = "SYOPBK";

        /// <summary>
        /// SYOPBO.
        /// </summary>
        public const string SYOPBO = "SYOPBO";

        /// <summary>
        /// SYOPLD.
        /// </summary>
        public const string SYOPLD = "SYOPLD";

        /// <summary>
        /// SYOPLL.
        /// </summary>
        public const string SYOPLL = "SYOPLL";

        /// <summary>
        /// SYOPMS.
        /// </summary>
        public const string SYOPMS = "SYOPMS";

        /// <summary>
        /// SYOPPL.
        /// </summary>
        public const string SYOPPL = "SYOPPL";

        /// <summary>
        /// SYOPPS.
        /// </summary>
        public const string SYOPPS = "SYOPPS";

        /// <summary>
        /// SYOPSB.
        /// </summary>
        public const string SYOPSB = "SYOPSB";

        /// <summary>
        /// SYOPSS.
        /// </summary>
        public const string SYOPSS = "SYOPSS";

        /// <summary>
        /// SYOPTC.
        /// </summary>
        public const string SYOPTC = "SYOPTC";

        /// <summary>
        /// SYOPTT.
        /// </summary>
        public const string SYOPTT = "SYOPTT";

        /// <summary>
        /// SYPBAN.
        /// </summary>
        public const string SYPBAN = "SYPBAN";

        /// <summary>
        /// SYPDTT.
        /// </summary>
        public const string SYPDTT = "SYPDTT";

        /// <summary>
        /// SYPLST.
        /// </summary>
        public const string SYPLST = "SYPLST";

        /// <summary>
        /// SYPMDT.
        /// </summary>
        public const string SYPMDT = "SYPMDT";

        /// <summary>
        /// SYPSTM.
        /// </summary>
        public const string SYPSTM = "SYPSTM";

        /// <summary>
        /// SYRQSJ.
        /// </summary>
        public const string SYRQSJ = "SYRQSJ";

        /// <summary>
        /// SYRSDT.
        /// </summary>
        public const string SYRSDT = "SYRSDT";

        /// <summary>
        /// SYRSHT.
        /// </summary>
        public const string SYRSHT = "SYRSHT";

        /// <summary>
        /// SYSOOR.
        /// </summary>
        public const string SYSOOR = "SYSOOR";

        /// <summary>
        /// SYVR03.
        /// </summary>
        public const string SYVR03 = "SYVR03";

        /// <summary>
        /// SYGAUFI.
        /// </summary>
        public const string SYGAUFI = "SYGAUFI";

        /// <summary>
        /// SYGAUFT.
        /// </summary>
        public const string SYGAUFT = "SYGAUFT";

        /// <summary>
        /// SYGDVAN.
        /// </summary>
        public const string SYGDVAN = "SYGDVAN";

        /// <summary>
        /// SYGFTAN.
        /// </summary>
        public const string SYGFTAN = "SYGFTAN";

        /// <summary>
        /// SYGPBAN.
        /// </summary>
        public const string SYGPBAN = "SYGPBAN";
    }

    /// <inheritdoc />
    public override string TableName => "F47036";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDTY", "SYEDTY", JdeDataType.String, 2),
        new JdeField("SYEDSQ", "SYEDSQ", JdeDataType.Numeric),
        new JdeField("SYEKCO", "SYEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SYEDOC", "SYEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric),
        new JdeField("SYEDST", "SYEDST", JdeDataType.String, 12),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYEDER", "SYEDER", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTPUR", "SYTPUR", JdeDataType.String, 4),
        new JdeField("SYSPID", "SYSPID", JdeDataType.String, 40),
        new JdeField("SYVERS", "SYVERS", JdeDataType.String, 20),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric),
        new JdeField("SYACKCD", "SYACKCD", JdeDataType.String, 6),
        new JdeField("SYACKDJ", "SYACKDJ", JdeDataType.Numeric),
        new JdeField("SYACKRC", "SYACKRC", JdeDataType.String, 2),
        new JdeField("SYACKT", "SYACKT", JdeDataType.String, 4),
        new JdeField("SYACKTM", "SYACKTM", JdeDataType.Numeric),
        new JdeField("SYADLJ", "SYADLJ", JdeDataType.Numeric),
        new JdeField("SYADTM", "SYADTM", JdeDataType.Numeric),
        new JdeField("SYASNDJ", "SYASNDJ", JdeDataType.Numeric),
        new JdeField("SYASNTM", "SYASNTM", JdeDataType.Numeric),
        new JdeField("SYAUFI", "SYAUFI", JdeDataType.String, 2),
        new JdeField("SYAUFT", "SYAUFT", JdeDataType.String, 2),
        new JdeField("SYBCRC", "SYBCRC", JdeDataType.String, 6),
        new JdeField("SYBSC", "SYBSC", JdeDataType.String, 20),
        new JdeField("SYCORD", "SYCORD", JdeDataType.Numeric),
        new JdeField("SYDCT4", "SYDCT4", JdeDataType.String, 4),
        new JdeField("SYDOC1", "SYDOC1", JdeDataType.Numeric),
        new JdeField("SYDRQT", "SYDRQT", JdeDataType.Numeric),
        new JdeField("SYDVAN", "SYDVAN", JdeDataType.Numeric),
        new JdeField("SYEDITM", "SYEDITM", JdeDataType.Numeric),
        new JdeField("SYFTAN", "SYFTAN", JdeDataType.Numeric),
        new JdeField("SYFUF1", "SYFUF1", JdeDataType.String, 2),
        new JdeField("SYFUF2", "SYFUF2", JdeDataType.String, 2),
        new JdeField("SYHOLD", "SYHOLD", JdeDataType.String, 4),
        new JdeField("SYINVC", "SYINVC", JdeDataType.Numeric),
        new JdeField("SYIR01", "SYIR01", JdeDataType.String, 60),
        new JdeField("SYIR02", "SYIR02", JdeDataType.String, 60),
        new JdeField("SYIR03", "SYIR03", JdeDataType.String, 60),
        new JdeField("SYIR04", "SYIR04", JdeDataType.String, 60),
        new JdeField("SYIR05", "SYIR05", JdeDataType.String, 60),
        new JdeField("SYITAN", "SYITAN", JdeDataType.Numeric),
        new JdeField("SYMORD", "SYMORD", JdeDataType.String, 2),
        new JdeField("SYOPBA", "SYOPBA", JdeDataType.String, 2),
        new JdeField("SYOPBK", "SYOPBK", JdeDataType.Numeric),
        new JdeField("SYOPBO", "SYOPBO", JdeDataType.String, 60),
        new JdeField("SYOPLD", "SYOPLD", JdeDataType.Numeric),
        new JdeField("SYOPLL", "SYOPLL", JdeDataType.String, 2),
        new JdeField("SYOPMS", "SYOPMS", JdeDataType.String, 2),
        new JdeField("SYOPPL", "SYOPPL", JdeDataType.String, 2),
        new JdeField("SYOPPS", "SYOPPS", JdeDataType.String, 60),
        new JdeField("SYOPSB", "SYOPSB", JdeDataType.Numeric),
        new JdeField("SYOPSS", "SYOPSS", JdeDataType.String, 2),
        new JdeField("SYOPTC", "SYOPTC", JdeDataType.Numeric),
        new JdeField("SYOPTT", "SYOPTT", JdeDataType.Numeric),
        new JdeField("SYPBAN", "SYPBAN", JdeDataType.Numeric),
        new JdeField("SYPDTT", "SYPDTT", JdeDataType.Numeric),
        new JdeField("SYPLST", "SYPLST", JdeDataType.String, 2),
        new JdeField("SYPMDT", "SYPMDT", JdeDataType.Numeric),
        new JdeField("SYPSTM", "SYPSTM", JdeDataType.Numeric),
        new JdeField("SYRQSJ", "SYRQSJ", JdeDataType.Numeric),
        new JdeField("SYRSDT", "SYRSDT", JdeDataType.Numeric),
        new JdeField("SYRSHT", "SYRSHT", JdeDataType.Numeric),
        new JdeField("SYSOOR", "SYSOOR", JdeDataType.Numeric),
        new JdeField("SYVR03", "SYVR03", JdeDataType.String, 50),
        new JdeField("SYGAUFI", "SYGAUFI", JdeDataType.Numeric),
        new JdeField("SYGAUFT", "SYGAUFT", JdeDataType.Numeric),
        new JdeField("SYGDVAN", "SYGDVAN", JdeDataType.Numeric),
        new JdeField("SYGFTAN", "SYGFTAN", JdeDataType.Numeric),
        new JdeField("SYGPBAN", "SYGPBAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47036_0", "Primary Key on SYEDOC, SYEDCT, SYEKCO", new[] { "SYEDOC", "SYEDCT", "SYEKCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F47036_2", "Index on SYEDBT", new[] { "SYEDBT" })
    };
}
