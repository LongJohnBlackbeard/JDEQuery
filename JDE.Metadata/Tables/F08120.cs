using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08120 - .
/// </summary>
public class F08120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AHACAR.
        /// </summary>
        public const string AHACAR = "AHACAR";

        /// <summary>
        /// AHRPYR.
        /// </summary>
        public const string AHRPYR = "AHRPYR";

        /// <summary>
        /// AHTAXX.
        /// </summary>
        public const string AHTAXX = "AHTAXX";

        /// <summary>
        /// AHAN8.
        /// </summary>
        public const string AHAN8 = "AHAN8";

        /// <summary>
        /// AHLNNO.
        /// </summary>
        public const string AHLNNO = "AHLNNO";

        /// <summary>
        /// AHARCC.
        /// </summary>
        public const string AHARCC = "AHARCC";

        /// <summary>
        /// AHRCK5.
        /// </summary>
        public const string AHRCK5 = "AHRCK5";

        /// <summary>
        /// AHHMCO.
        /// </summary>
        public const string AHHMCO = "AHHMCO";

        /// <summary>
        /// AHPLAN.
        /// </summary>
        public const string AHPLAN = "AHPLAN";

        /// <summary>
        /// AHAOPT.
        /// </summary>
        public const string AHAOPT = "AHAOPT";

        /// <summary>
        /// AHPAN8.
        /// </summary>
        public const string AHPAN8 = "AHPAN8";

        /// <summary>
        /// AHEFT.
        /// </summary>
        public const string AHEFT = "AHEFT";

        /// <summary>
        /// AHAIRI.
        /// </summary>
        public const string AHAIRI = "AHAIRI";

        /// <summary>
        /// AHUKID.
        /// </summary>
        public const string AHUKID = "AHUKID";

        /// <summary>
        /// AHRECP.
        /// </summary>
        public const string AHRECP = "AHRECP";

        /// <summary>
        /// AHEFTE.
        /// </summary>
        public const string AHEFTE = "AHEFTE";

        /// <summary>
        /// AHPRRF.
        /// </summary>
        public const string AHPRRF = "AHPRRF";

        /// <summary>
        /// AHTAX.
        /// </summary>
        public const string AHTAX = "AHTAX";

        /// <summary>
        /// AHAGNM.
        /// </summary>
        public const string AHAGNM = "AHAGNM";

        /// <summary>
        /// AHAMDN.
        /// </summary>
        public const string AHAMDN = "AHAMDN";

        /// <summary>
        /// AHASRN.
        /// </summary>
        public const string AHASRN = "AHASRN";

        /// <summary>
        /// AHADOB.
        /// </summary>
        public const string AHADOB = "AHADOB";

        /// <summary>
        /// AHRELA.
        /// </summary>
        public const string AHRELA = "AHRELA";

        /// <summary>
        /// AHDI00.
        /// </summary>
        public const string AHDI00 = "AHDI00";

        /// <summary>
        /// AHDI01.
        /// </summary>
        public const string AHDI01 = "AHDI01";

        /// <summary>
        /// AHDI02.
        /// </summary>
        public const string AHDI02 = "AHDI02";

        /// <summary>
        /// AHDI03.
        /// </summary>
        public const string AHDI03 = "AHDI03";

        /// <summary>
        /// AHDI04.
        /// </summary>
        public const string AHDI04 = "AHDI04";

        /// <summary>
        /// AHDI05.
        /// </summary>
        public const string AHDI05 = "AHDI05";

        /// <summary>
        /// AHDI06.
        /// </summary>
        public const string AHDI06 = "AHDI06";

        /// <summary>
        /// AHDI07.
        /// </summary>
        public const string AHDI07 = "AHDI07";

        /// <summary>
        /// AHDI08.
        /// </summary>
        public const string AHDI08 = "AHDI08";

        /// <summary>
        /// AHDI09.
        /// </summary>
        public const string AHDI09 = "AHDI09";

        /// <summary>
        /// AHDI10.
        /// </summary>
        public const string AHDI10 = "AHDI10";

        /// <summary>
        /// AHDI11.
        /// </summary>
        public const string AHDI11 = "AHDI11";

        /// <summary>
        /// AHDI12.
        /// </summary>
        public const string AHDI12 = "AHDI12";

        /// <summary>
        /// AHSPASUSJ1.
        /// </summary>
        public const string AHSPASUSJ1 = "AHSPASUSJ1";

        /// <summary>
        /// AHSPASUSJ2.
        /// </summary>
        public const string AHSPASUSJ2 = "AHSPASUSJ2";

        /// <summary>
        /// AHSPASUSJ3.
        /// </summary>
        public const string AHSPASUSJ3 = "AHSPASUSJ3";

        /// <summary>
        /// AHSPASUSJ4.
        /// </summary>
        public const string AHSPASUSJ4 = "AHSPASUSJ4";

        /// <summary>
        /// AHSPANUSJ1.
        /// </summary>
        public const string AHSPANUSJ1 = "AHSPANUSJ1";

        /// <summary>
        /// AHSPANUSJ2.
        /// </summary>
        public const string AHSPANUSJ2 = "AHSPANUSJ2";

        /// <summary>
        /// AHSPANUSJ3.
        /// </summary>
        public const string AHSPANUSJ3 = "AHSPANUSJ3";

        /// <summary>
        /// AHSPANUSJ4.
        /// </summary>
        public const string AHSPANUSJ4 = "AHSPANUSJ4";

        /// <summary>
        /// AHSPADUSJ1.
        /// </summary>
        public const string AHSPADUSJ1 = "AHSPADUSJ1";

        /// <summary>
        /// AHSPADUSJ2.
        /// </summary>
        public const string AHSPADUSJ2 = "AHSPADUSJ2";

        /// <summary>
        /// AHSPADUSJ3.
        /// </summary>
        public const string AHSPADUSJ3 = "AHSPADUSJ3";

        /// <summary>
        /// AHSPADUSJ4.
        /// </summary>
        public const string AHSPADUSJ4 = "AHSPADUSJ4";

        /// <summary>
        /// AHSPACUSJ1.
        /// </summary>
        public const string AHSPACUSJ1 = "AHSPACUSJ1";

        /// <summary>
        /// AHSPACUSJ2.
        /// </summary>
        public const string AHSPACUSJ2 = "AHSPACUSJ2";

        /// <summary>
        /// AHSPACUSJ3.
        /// </summary>
        public const string AHSPACUSJ3 = "AHSPACUSJ3";

        /// <summary>
        /// AHSPACUSJ4.
        /// </summary>
        public const string AHSPACUSJ4 = "AHSPACUSJ4";

        /// <summary>
        /// AHBTPG.
        /// </summary>
        public const string AHBTPG = "AHBTPG";

        /// <summary>
        /// AHBTVR.
        /// </summary>
        public const string AHBTVR = "AHBTVR";

        /// <summary>
        /// AHRVST.
        /// </summary>
        public const string AHRVST = "AHRVST";

        /// <summary>
        /// AHPID.
        /// </summary>
        public const string AHPID = "AHPID";

        /// <summary>
        /// AHUSER.
        /// </summary>
        public const string AHUSER = "AHUSER";

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
    }

    /// <inheritdoc />
    public override string TableName => "F08120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AHACAR", "AHACAR", JdeDataType.String, 2, true, true),
        new JdeField("AHRPYR", "AHRPYR", JdeDataType.Numeric, null, true, true),
        new JdeField("AHTAXX", "AHTAXX", JdeDataType.String, 40, true, true),
        new JdeField("AHAN8", "AHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AHLNNO", "AHLNNO", JdeDataType.Numeric, null, true, true),
        new JdeField("AHARCC", "AHARCC", JdeDataType.String, 2),
        new JdeField("AHRCK5", "AHRCK5", JdeDataType.Numeric, null, true, true),
        new JdeField("AHHMCO", "AHHMCO", JdeDataType.String, 10, true, true),
        new JdeField("AHPLAN", "AHPLAN", JdeDataType.String, 16, true, true),
        new JdeField("AHAOPT", "AHAOPT", JdeDataType.String, 6, true, true),
        new JdeField("AHPAN8", "AHPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AHEFT", "AHEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("AHAIRI", "AHAIRI", JdeDataType.String, 20),
        new JdeField("AHUKID", "AHUKID", JdeDataType.Numeric),
        new JdeField("AHRECP", "AHRECP", JdeDataType.String, 10),
        new JdeField("AHEFTE", "AHEFTE", JdeDataType.Numeric),
        new JdeField("AHPRRF", "AHPRRF", JdeDataType.String, 2),
        new JdeField("AHTAX", "AHTAX", JdeDataType.String, 40),
        new JdeField("AHAGNM", "AHAGNM", JdeDataType.String, 50),
        new JdeField("AHAMDN", "AHAMDN", JdeDataType.String, 50),
        new JdeField("AHASRN", "AHASRN", JdeDataType.String, 50),
        new JdeField("AHADOB", "AHADOB", JdeDataType.Numeric),
        new JdeField("AHRELA", "AHRELA", JdeDataType.String, 2),
        new JdeField("AHDI00", "AHDI00", JdeDataType.String, 2),
        new JdeField("AHDI01", "AHDI01", JdeDataType.String, 2),
        new JdeField("AHDI02", "AHDI02", JdeDataType.String, 2),
        new JdeField("AHDI03", "AHDI03", JdeDataType.String, 2),
        new JdeField("AHDI04", "AHDI04", JdeDataType.String, 2),
        new JdeField("AHDI05", "AHDI05", JdeDataType.String, 2),
        new JdeField("AHDI06", "AHDI06", JdeDataType.String, 2),
        new JdeField("AHDI07", "AHDI07", JdeDataType.String, 2),
        new JdeField("AHDI08", "AHDI08", JdeDataType.String, 2),
        new JdeField("AHDI09", "AHDI09", JdeDataType.String, 2),
        new JdeField("AHDI10", "AHDI10", JdeDataType.String, 2),
        new JdeField("AHDI11", "AHDI11", JdeDataType.String, 2),
        new JdeField("AHDI12", "AHDI12", JdeDataType.String, 2),
        new JdeField("AHSPASUSJ1", "AHSPASUSJ1", JdeDataType.String, 60),
        new JdeField("AHSPASUSJ2", "AHSPASUSJ2", JdeDataType.String, 60),
        new JdeField("AHSPASUSJ3", "AHSPASUSJ3", JdeDataType.String, 60),
        new JdeField("AHSPASUSJ4", "AHSPASUSJ4", JdeDataType.String, 60),
        new JdeField("AHSPANUSJ1", "AHSPANUSJ1", JdeDataType.Numeric),
        new JdeField("AHSPANUSJ2", "AHSPANUSJ2", JdeDataType.Numeric),
        new JdeField("AHSPANUSJ3", "AHSPANUSJ3", JdeDataType.Numeric),
        new JdeField("AHSPANUSJ4", "AHSPANUSJ4", JdeDataType.Numeric),
        new JdeField("AHSPADUSJ1", "AHSPADUSJ1", JdeDataType.Numeric),
        new JdeField("AHSPADUSJ2", "AHSPADUSJ2", JdeDataType.Numeric),
        new JdeField("AHSPADUSJ3", "AHSPADUSJ3", JdeDataType.Numeric),
        new JdeField("AHSPADUSJ4", "AHSPADUSJ4", JdeDataType.Numeric),
        new JdeField("AHSPACUSJ1", "AHSPACUSJ1", JdeDataType.String, 2),
        new JdeField("AHSPACUSJ2", "AHSPACUSJ2", JdeDataType.String, 2),
        new JdeField("AHSPACUSJ3", "AHSPACUSJ3", JdeDataType.Numeric),
        new JdeField("AHSPACUSJ4", "AHSPACUSJ4", JdeDataType.String, 2),
        new JdeField("AHBTPG", "AHBTPG", JdeDataType.String, 20),
        new JdeField("AHBTVR", "AHBTVR", JdeDataType.String, 20),
        new JdeField("AHRVST", "AHRVST", JdeDataType.String, 6),
        new JdeField("AHPID", "AHPID", JdeDataType.String, 20),
        new JdeField("AHUSER", "AHUSER", JdeDataType.String, 20),
        new JdeField("AHJOBN", "AHJOBN", JdeDataType.String, 20),
        new JdeField("AHUPMJ", "AHUPMJ", JdeDataType.Numeric),
        new JdeField("AHUPMT", "AHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08120_0", "Primary Key on AHACAR, AHRPYR, AHTAXX, AHAN8, AHLNNO, AHHMCO, AHRCK5, AHPLAN, AHAOPT, AHPAN8, AHEFT", new[] { "AHACAR", "AHRPYR", "AHTAXX", "AHAN8", "AHLNNO", "AHHMCO", "AHRCK5", "AHPLAN", "AHAOPT", "AHPAN8", "AHEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08120_2", "Index on AHACAR, AHRPYR, AHTAXX, AHAN8, AHPAN8, AHLNNO", new[] { "AHACAR", "AHRPYR", "AHTAXX", "AHAN8", "AHPAN8", "AHLNNO" }),
        new JdeIndex("F08120_3", "Index on AHACAR, AHRPYR, AHTAXX, AHAN8, AHPAN8, AHHMCO, AHPLAN, AHAOPT", new[] { "AHACAR", "AHRPYR", "AHTAXX", "AHAN8", "AHPAN8", "AHHMCO", "AHPLAN", "AHAOPT" }),
        new JdeIndex("F08120_4", "Index on AHACAR, AHRPYR, AHTAXX, AHAN8, AHPAN8", new[] { "AHACAR", "AHRPYR", "AHTAXX", "AHAN8", "AHPAN8" }),
        new JdeIndex("F08120_5", "Index on AHAN8, AHUKID", new[] { "AHAN8", "AHUKID" }),
        new JdeIndex("F08120_6", "Index on AHRCK5, AHUKID", new[] { "AHRCK5", "AHUKID" })
    };
}
