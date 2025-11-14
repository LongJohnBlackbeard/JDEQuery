using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1602Z1 - .
/// </summary>
public class F1602Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZEDUS.
        /// </summary>
        public const string CZEDUS = "CZEDUS";

        /// <summary>
        /// CZEDBT.
        /// </summary>
        public const string CZEDBT = "CZEDBT";

        /// <summary>
        /// CZEDTN.
        /// </summary>
        public const string CZEDTN = "CZEDTN";

        /// <summary>
        /// CZEDLN.
        /// </summary>
        public const string CZEDLN = "CZEDLN";

        /// <summary>
        /// CZEDCT.
        /// </summary>
        public const string CZEDCT = "CZEDCT";

        /// <summary>
        /// CZTYTN.
        /// </summary>
        public const string CZTYTN = "CZTYTN";

        /// <summary>
        /// CZEDFT.
        /// </summary>
        public const string CZEDFT = "CZEDFT";

        /// <summary>
        /// CZEDDT.
        /// </summary>
        public const string CZEDDT = "CZEDDT";

        /// <summary>
        /// CZDRIN.
        /// </summary>
        public const string CZDRIN = "CZDRIN";

        /// <summary>
        /// CZEDDL.
        /// </summary>
        public const string CZEDDL = "CZEDDL";

        /// <summary>
        /// CZEDSP.
        /// </summary>
        public const string CZEDSP = "CZEDSP";

        /// <summary>
        /// CZPNID.
        /// </summary>
        public const string CZPNID = "CZPNID";

        /// <summary>
        /// CZTNAC.
        /// </summary>
        public const string CZTNAC = "CZTNAC";

        /// <summary>
        /// CZEDTY.
        /// </summary>
        public const string CZEDTY = "CZEDTY";

        /// <summary>
        /// CZEDSQ.
        /// </summary>
        public const string CZEDSQ = "CZEDSQ";

        /// <summary>
        /// CZEDTS.
        /// </summary>
        public const string CZEDTS = "CZEDTS";

        /// <summary>
        /// CZEDER.
        /// </summary>
        public const string CZEDER = "CZEDER";

        /// <summary>
        /// CZEDTC.
        /// </summary>
        public const string CZEDTC = "CZEDTC";

        /// <summary>
        /// CZEDTR.
        /// </summary>
        public const string CZEDTR = "CZEDTR";

        /// <summary>
        /// CZEDGL.
        /// </summary>
        public const string CZEDGL = "CZEDGL";

        /// <summary>
        /// CZEDDH.
        /// </summary>
        public const string CZEDDH = "CZEDDH";

        /// <summary>
        /// CZEDAN.
        /// </summary>
        public const string CZEDAN = "CZEDAN";

        /// <summary>
        /// CZVWNM.
        /// </summary>
        public const string CZVWNM = "CZVWNM";

        /// <summary>
        /// CZACTB.
        /// </summary>
        public const string CZACTB = "CZACTB";

        /// <summary>
        /// CZAID.
        /// </summary>
        public const string CZAID = "CZAID";

        /// <summary>
        /// CZCFY.
        /// </summary>
        public const string CZCFY = "CZCFY";

        /// <summary>
        /// CZLT.
        /// </summary>
        public const string CZLT = "CZLT";

        /// <summary>
        /// CZSBL.
        /// </summary>
        public const string CZSBL = "CZSBL";

        /// <summary>
        /// CZSBLT.
        /// </summary>
        public const string CZSBLT = "CZSBLT";

        /// <summary>
        /// CZABR1.
        /// </summary>
        public const string CZABR1 = "CZABR1";

        /// <summary>
        /// CZABT1.
        /// </summary>
        public const string CZABT1 = "CZABT1";

        /// <summary>
        /// CZABR2.
        /// </summary>
        public const string CZABR2 = "CZABR2";

        /// <summary>
        /// CZABT2.
        /// </summary>
        public const string CZABT2 = "CZABT2";

        /// <summary>
        /// CZABR3.
        /// </summary>
        public const string CZABR3 = "CZABR3";

        /// <summary>
        /// CZABT3.
        /// </summary>
        public const string CZABT3 = "CZABT3";

        /// <summary>
        /// CZABR4.
        /// </summary>
        public const string CZABR4 = "CZABR4";

        /// <summary>
        /// CZABT4.
        /// </summary>
        public const string CZABT4 = "CZABT4";

        /// <summary>
        /// CZITM.
        /// </summary>
        public const string CZITM = "CZITM";

        /// <summary>
        /// CZCO.
        /// </summary>
        public const string CZCO = "CZCO";

        /// <summary>
        /// CZAPYC.
        /// </summary>
        public const string CZAPYC = "CZAPYC";

        /// <summary>
        /// CZAN01.
        /// </summary>
        public const string CZAN01 = "CZAN01";

        /// <summary>
        /// CZAN02.
        /// </summary>
        public const string CZAN02 = "CZAN02";

        /// <summary>
        /// CZAN03.
        /// </summary>
        public const string CZAN03 = "CZAN03";

        /// <summary>
        /// CZAN04.
        /// </summary>
        public const string CZAN04 = "CZAN04";

        /// <summary>
        /// CZAN05.
        /// </summary>
        public const string CZAN05 = "CZAN05";

        /// <summary>
        /// CZAN06.
        /// </summary>
        public const string CZAN06 = "CZAN06";

        /// <summary>
        /// CZAN07.
        /// </summary>
        public const string CZAN07 = "CZAN07";

        /// <summary>
        /// CZAN08.
        /// </summary>
        public const string CZAN08 = "CZAN08";

        /// <summary>
        /// CZAN09.
        /// </summary>
        public const string CZAN09 = "CZAN09";

        /// <summary>
        /// CZAN10.
        /// </summary>
        public const string CZAN10 = "CZAN10";

        /// <summary>
        /// CZAN11.
        /// </summary>
        public const string CZAN11 = "CZAN11";

        /// <summary>
        /// CZAN12.
        /// </summary>
        public const string CZAN12 = "CZAN12";

        /// <summary>
        /// CZAN13.
        /// </summary>
        public const string CZAN13 = "CZAN13";

        /// <summary>
        /// CZAN14.
        /// </summary>
        public const string CZAN14 = "CZAN14";

        /// <summary>
        /// CZNB01.
        /// </summary>
        public const string CZNB01 = "CZNB01";

        /// <summary>
        /// CZNB02.
        /// </summary>
        public const string CZNB02 = "CZNB02";

        /// <summary>
        /// CZNB03.
        /// </summary>
        public const string CZNB03 = "CZNB03";

        /// <summary>
        /// CZNB04.
        /// </summary>
        public const string CZNB04 = "CZNB04";

        /// <summary>
        /// CZNB05.
        /// </summary>
        public const string CZNB05 = "CZNB05";

        /// <summary>
        /// CZNB06.
        /// </summary>
        public const string CZNB06 = "CZNB06";

        /// <summary>
        /// CZNB07.
        /// </summary>
        public const string CZNB07 = "CZNB07";

        /// <summary>
        /// CZNB08.
        /// </summary>
        public const string CZNB08 = "CZNB08";

        /// <summary>
        /// CZNB09.
        /// </summary>
        public const string CZNB09 = "CZNB09";

        /// <summary>
        /// CZNB10.
        /// </summary>
        public const string CZNB10 = "CZNB10";

        /// <summary>
        /// CZNB11.
        /// </summary>
        public const string CZNB11 = "CZNB11";

        /// <summary>
        /// CZNB12.
        /// </summary>
        public const string CZNB12 = "CZNB12";

        /// <summary>
        /// CZNB13.
        /// </summary>
        public const string CZNB13 = "CZNB13";

        /// <summary>
        /// CZNB14.
        /// </summary>
        public const string CZNB14 = "CZNB14";

        /// <summary>
        /// CZASMF.
        /// </summary>
        public const string CZASMF = "CZASMF";

        /// <summary>
        /// CZAWTD.
        /// </summary>
        public const string CZAWTD = "CZAWTD";

        /// <summary>
        /// CZBORG.
        /// </summary>
        public const string CZBORG = "CZBORG";

        /// <summary>
        /// CZBREQ.
        /// </summary>
        public const string CZBREQ = "CZBREQ";

        /// <summary>
        /// CZBAPR.
        /// </summary>
        public const string CZBAPR = "CZBAPR";

        /// <summary>
        /// CZMCU.
        /// </summary>
        public const string CZMCU = "CZMCU";

        /// <summary>
        /// CZOBJ.
        /// </summary>
        public const string CZOBJ = "CZOBJ";

        /// <summary>
        /// CZSUB.
        /// </summary>
        public const string CZSUB = "CZSUB";

        /// <summary>
        /// CZCRCD.
        /// </summary>
        public const string CZCRCD = "CZCRCD";

        /// <summary>
        /// CZCRCX.
        /// </summary>
        public const string CZCRCX = "CZCRCX";

        /// <summary>
        /// CZPM01.
        /// </summary>
        public const string CZPM01 = "CZPM01";

        /// <summary>
        /// CZPM02.
        /// </summary>
        public const string CZPM02 = "CZPM02";

        /// <summary>
        /// CZPM03.
        /// </summary>
        public const string CZPM03 = "CZPM03";

        /// <summary>
        /// CZPM04.
        /// </summary>
        public const string CZPM04 = "CZPM04";

        /// <summary>
        /// CZPM05.
        /// </summary>
        public const string CZPM05 = "CZPM05";

        /// <summary>
        /// CZPM06.
        /// </summary>
        public const string CZPM06 = "CZPM06";

        /// <summary>
        /// CZPM07.
        /// </summary>
        public const string CZPM07 = "CZPM07";

        /// <summary>
        /// CZPM08.
        /// </summary>
        public const string CZPM08 = "CZPM08";

        /// <summary>
        /// CZPM09.
        /// </summary>
        public const string CZPM09 = "CZPM09";

        /// <summary>
        /// CZPM10.
        /// </summary>
        public const string CZPM10 = "CZPM10";

        /// <summary>
        /// CZUSER.
        /// </summary>
        public const string CZUSER = "CZUSER";

        /// <summary>
        /// CZPID.
        /// </summary>
        public const string CZPID = "CZPID";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZUPMT.
        /// </summary>
        public const string CZUPMT = "CZUPMT";

        /// <summary>
        /// CZJOBN.
        /// </summary>
        public const string CZJOBN = "CZJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1602Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZEDUS", "CZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("CZEDBT", "CZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("CZEDTN", "CZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("CZEDLN", "CZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CZEDCT", "CZEDCT", JdeDataType.String, 4),
        new JdeField("CZTYTN", "CZTYTN", JdeDataType.String, 16),
        new JdeField("CZEDFT", "CZEDFT", JdeDataType.String, 20),
        new JdeField("CZEDDT", "CZEDDT", JdeDataType.Numeric),
        new JdeField("CZDRIN", "CZDRIN", JdeDataType.String, 2),
        new JdeField("CZEDDL", "CZEDDL", JdeDataType.Numeric),
        new JdeField("CZEDSP", "CZEDSP", JdeDataType.String, 2),
        new JdeField("CZPNID", "CZPNID", JdeDataType.String, 30),
        new JdeField("CZTNAC", "CZTNAC", JdeDataType.String, 4),
        new JdeField("CZEDTY", "CZEDTY", JdeDataType.String, 2),
        new JdeField("CZEDSQ", "CZEDSQ", JdeDataType.Numeric),
        new JdeField("CZEDTS", "CZEDTS", JdeDataType.String, 12),
        new JdeField("CZEDER", "CZEDER", JdeDataType.String, 2),
        new JdeField("CZEDTC", "CZEDTC", JdeDataType.String, 2),
        new JdeField("CZEDTR", "CZEDTR", JdeDataType.String, 2),
        new JdeField("CZEDGL", "CZEDGL", JdeDataType.String, 2),
        new JdeField("CZEDDH", "CZEDDH", JdeDataType.String, 2),
        new JdeField("CZEDAN", "CZEDAN", JdeDataType.Numeric),
        new JdeField("CZVWNM", "CZVWNM", JdeDataType.Numeric),
        new JdeField("CZACTB", "CZACTB", JdeDataType.String, 20),
        new JdeField("CZAID", "CZAID", JdeDataType.String, 16),
        new JdeField("CZCFY", "CZCFY", JdeDataType.Numeric),
        new JdeField("CZLT", "CZLT", JdeDataType.String, 4),
        new JdeField("CZSBL", "CZSBL", JdeDataType.String, 16),
        new JdeField("CZSBLT", "CZSBLT", JdeDataType.String, 2),
        new JdeField("CZABR1", "CZABR1", JdeDataType.String, 24),
        new JdeField("CZABT1", "CZABT1", JdeDataType.String, 2),
        new JdeField("CZABR2", "CZABR2", JdeDataType.String, 24),
        new JdeField("CZABT2", "CZABT2", JdeDataType.String, 2),
        new JdeField("CZABR3", "CZABR3", JdeDataType.String, 24),
        new JdeField("CZABT3", "CZABT3", JdeDataType.String, 2),
        new JdeField("CZABR4", "CZABR4", JdeDataType.String, 24),
        new JdeField("CZABT4", "CZABT4", JdeDataType.String, 2),
        new JdeField("CZITM", "CZITM", JdeDataType.Numeric),
        new JdeField("CZCO", "CZCO", JdeDataType.String, 10),
        new JdeField("CZAPYC", "CZAPYC", JdeDataType.Numeric),
        new JdeField("CZAN01", "CZAN01", JdeDataType.Numeric),
        new JdeField("CZAN02", "CZAN02", JdeDataType.Numeric),
        new JdeField("CZAN03", "CZAN03", JdeDataType.Numeric),
        new JdeField("CZAN04", "CZAN04", JdeDataType.Numeric),
        new JdeField("CZAN05", "CZAN05", JdeDataType.Numeric),
        new JdeField("CZAN06", "CZAN06", JdeDataType.Numeric),
        new JdeField("CZAN07", "CZAN07", JdeDataType.Numeric),
        new JdeField("CZAN08", "CZAN08", JdeDataType.Numeric),
        new JdeField("CZAN09", "CZAN09", JdeDataType.Numeric),
        new JdeField("CZAN10", "CZAN10", JdeDataType.Numeric),
        new JdeField("CZAN11", "CZAN11", JdeDataType.Numeric),
        new JdeField("CZAN12", "CZAN12", JdeDataType.Numeric),
        new JdeField("CZAN13", "CZAN13", JdeDataType.Numeric),
        new JdeField("CZAN14", "CZAN14", JdeDataType.Numeric),
        new JdeField("CZNB01", "CZNB01", JdeDataType.Numeric),
        new JdeField("CZNB02", "CZNB02", JdeDataType.Numeric),
        new JdeField("CZNB03", "CZNB03", JdeDataType.Numeric),
        new JdeField("CZNB04", "CZNB04", JdeDataType.Numeric),
        new JdeField("CZNB05", "CZNB05", JdeDataType.Numeric),
        new JdeField("CZNB06", "CZNB06", JdeDataType.Numeric),
        new JdeField("CZNB07", "CZNB07", JdeDataType.Numeric),
        new JdeField("CZNB08", "CZNB08", JdeDataType.Numeric),
        new JdeField("CZNB09", "CZNB09", JdeDataType.Numeric),
        new JdeField("CZNB10", "CZNB10", JdeDataType.Numeric),
        new JdeField("CZNB11", "CZNB11", JdeDataType.Numeric),
        new JdeField("CZNB12", "CZNB12", JdeDataType.Numeric),
        new JdeField("CZNB13", "CZNB13", JdeDataType.Numeric),
        new JdeField("CZNB14", "CZNB14", JdeDataType.Numeric),
        new JdeField("CZASMF", "CZASMF", JdeDataType.String, 2),
        new JdeField("CZAWTD", "CZAWTD", JdeDataType.Numeric),
        new JdeField("CZBORG", "CZBORG", JdeDataType.Numeric),
        new JdeField("CZBREQ", "CZBREQ", JdeDataType.Numeric),
        new JdeField("CZBAPR", "CZBAPR", JdeDataType.Numeric),
        new JdeField("CZMCU", "CZMCU", JdeDataType.String, 24),
        new JdeField("CZOBJ", "CZOBJ", JdeDataType.String, 12),
        new JdeField("CZSUB", "CZSUB", JdeDataType.String, 16),
        new JdeField("CZCRCD", "CZCRCD", JdeDataType.String, 6),
        new JdeField("CZCRCX", "CZCRCX", JdeDataType.String, 6),
        new JdeField("CZPM01", "CZPM01", JdeDataType.String, 2),
        new JdeField("CZPM02", "CZPM02", JdeDataType.String, 2),
        new JdeField("CZPM03", "CZPM03", JdeDataType.String, 2),
        new JdeField("CZPM04", "CZPM04", JdeDataType.String, 2),
        new JdeField("CZPM05", "CZPM05", JdeDataType.String, 2),
        new JdeField("CZPM06", "CZPM06", JdeDataType.String, 2),
        new JdeField("CZPM07", "CZPM07", JdeDataType.String, 2),
        new JdeField("CZPM08", "CZPM08", JdeDataType.String, 2),
        new JdeField("CZPM09", "CZPM09", JdeDataType.String, 2),
        new JdeField("CZPM10", "CZPM10", JdeDataType.String, 2),
        new JdeField("CZUSER", "CZUSER", JdeDataType.String, 20),
        new JdeField("CZPID", "CZPID", JdeDataType.String, 20),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric),
        new JdeField("CZUPMT", "CZUPMT", JdeDataType.Numeric),
        new JdeField("CZJOBN", "CZJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1602Z1_0", "Primary Key on CZEDUS, CZEDBT, CZEDTN, CZEDLN", new[] { "CZEDUS", "CZEDBT", "CZEDTN", "CZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1602Z1_2", "Index on CZEDUS, CZEDBT, SYS_NC00094$", new[] { "CZEDUS", "CZEDBT", "SYS_NC00094$" })
    };
}
