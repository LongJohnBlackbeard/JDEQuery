using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I701 - .
/// </summary>
public class F75I701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QHUKID.
        /// </summary>
        public const string QHUKID = "QHUKID";

        /// <summary>
        /// QHUK01.
        /// </summary>
        public const string QHUK01 = "QHUK01";

        /// <summary>
        /// QHUK02.
        /// </summary>
        public const string QHUK02 = "QHUK02";

        /// <summary>
        /// QHYSFX.
        /// </summary>
        public const string QHYSFX = "QHYSFX";

        /// <summary>
        /// QHYSFL.
        /// </summary>
        public const string QHYSFL = "QHYSFL";

        /// <summary>
        /// QHDOCO.
        /// </summary>
        public const string QHDOCO = "QHDOCO";

        /// <summary>
        /// QHDCTO.
        /// </summary>
        public const string QHDCTO = "QHDCTO";

        /// <summary>
        /// QHKCOO.
        /// </summary>
        public const string QHKCOO = "QHKCOO";

        /// <summary>
        /// QHSFXO.
        /// </summary>
        public const string QHSFXO = "QHSFXO";

        /// <summary>
        /// QHYBTP.
        /// </summary>
        public const string QHYBTP = "QHYBTP";

        /// <summary>
        /// QHYRTN.
        /// </summary>
        public const string QHYRTN = "QHYRTN";

        /// <summary>
        /// QHYRTD.
        /// </summary>
        public const string QHYRTD = "QHYRTD";

        /// <summary>
        /// QHYBED.
        /// </summary>
        public const string QHYBED = "QHYBED";

        /// <summary>
        /// QHYLNO.
        /// </summary>
        public const string QHYLNO = "QHYLNO";

        /// <summary>
        /// QHYREF.
        /// </summary>
        public const string QHYREF = "QHYREF";

        /// <summary>
        /// QHMCU.
        /// </summary>
        public const string QHMCU = "QHMCU";

        /// <summary>
        /// QHCO.
        /// </summary>
        public const string QHCO = "QHCO";

        /// <summary>
        /// QHMOT.
        /// </summary>
        public const string QHMOT = "QHMOT";

        /// <summary>
        /// QHYPES.
        /// </summary>
        public const string QHYPES = "QHYPES";

        /// <summary>
        /// QHYISN.
        /// </summary>
        public const string QHYISN = "QHYISN";

        /// <summary>
        /// QHYISD.
        /// </summary>
        public const string QHYISD = "QHYISD";

        /// <summary>
        /// QHYCNO.
        /// </summary>
        public const string QHYCNO = "QHYCNO";

        /// <summary>
        /// QHYICO.
        /// </summary>
        public const string QHYICO = "QHYICO";

        /// <summary>
        /// QHYVNM.
        /// </summary>
        public const string QHYVNM = "QHYVNM";

        /// <summary>
        /// QHYPOS.
        /// </summary>
        public const string QHYPOS = "QHYPOS";

        /// <summary>
        /// QHYPOD.
        /// </summary>
        public const string QHYPOD = "QHYPOD";

        /// <summary>
        /// QHYPCD.
        /// </summary>
        public const string QHYPCD = "QHYPCD";

        /// <summary>
        /// QHYBLN.
        /// </summary>
        public const string QHYBLN = "QHYBLN";

        /// <summary>
        /// QHYBLD.
        /// </summary>
        public const string QHYBLD = "QHYBLD";

        /// <summary>
        /// QHYSUM.
        /// </summary>
        public const string QHYSUM = "QHYSUM";

        /// <summary>
        /// QHYSQT.
        /// </summary>
        public const string QHYSQT = "QHYSQT";

        /// <summary>
        /// QHTMPS.
        /// </summary>
        public const string QHTMPS = "QHTMPS";

        /// <summary>
        /// QHDNST.
        /// </summary>
        public const string QHDNST = "QHDNST";

        /// <summary>
        /// QHSTPU.
        /// </summary>
        public const string QHSTPU = "QHSTPU";

        /// <summary>
        /// QHDNTP.
        /// </summary>
        public const string QHDNTP = "QHDNTP";

        /// <summary>
        /// QHYNQT.
        /// </summary>
        public const string QHYNQT = "QHYNQT";

        /// <summary>
        /// QHYNUM.
        /// </summary>
        public const string QHYNUM = "QHYNUM";

        /// <summary>
        /// QHYNTM.
        /// </summary>
        public const string QHYNTM = "QHYNTM";

        /// <summary>
        /// QHYNDN.
        /// </summary>
        public const string QHYNDN = "QHYNDN";

        /// <summary>
        /// QHYTUM.
        /// </summary>
        public const string QHYTUM = "QHYTUM";

        /// <summary>
        /// QHYTQT.
        /// </summary>
        public const string QHYTQT = "QHYTQT";

        /// <summary>
        /// QHYCC.
        /// </summary>
        public const string QHYCC = "QHYCC";

        /// <summary>
        /// QHYCCC.
        /// </summary>
        public const string QHYCCC = "QHYCCC";

        /// <summary>
        /// QHYCDT.
        /// </summary>
        public const string QHYCDT = "QHYCDT";

        /// <summary>
        /// QHYUTD.
        /// </summary>
        public const string QHYUTD = "QHYUTD";

        /// <summary>
        /// QHYASS.
        /// </summary>
        public const string QHYASS = "QHYASS";

        /// <summary>
        /// QHYUAV.
        /// </summary>
        public const string QHYUAV = "QHYUAV";

        /// <summary>
        /// QHYDTF.
        /// </summary>
        public const string QHYDTF = "QHYDTF";

        /// <summary>
        /// QHYDTT.
        /// </summary>
        public const string QHYDTT = "QHYDTT";

        /// <summary>
        /// QHVINV.
        /// </summary>
        public const string QHVINV = "QHVINV";

        /// <summary>
        /// QHDIVJ.
        /// </summary>
        public const string QHDIVJ = "QHDIVJ";

        /// <summary>
        /// QHYBID.
        /// </summary>
        public const string QHYBID = "QHYBID";

        /// <summary>
        /// QHA107.
        /// </summary>
        public const string QHA107 = "QHA107";

        /// <summary>
        /// QHA108.
        /// </summary>
        public const string QHA108 = "QHA108";

        /// <summary>
        /// QHYSNO.
        /// </summary>
        public const string QHYSNO = "QHYSNO";

        /// <summary>
        /// QHYSDT.
        /// </summary>
        public const string QHYSDT = "QHYSDT";

        /// <summary>
        /// QHYMOA.
        /// </summary>
        public const string QHYMOA = "QHYMOA";

        /// <summary>
        /// QHYCBN.
        /// </summary>
        public const string QHYCBN = "QHYCBN";

        /// <summary>
        /// QHYPDN.
        /// </summary>
        public const string QHYPDN = "QHYPDN";

        /// <summary>
        /// QHYPAC.
        /// </summary>
        public const string QHYPAC = "QHYPAC";

        /// <summary>
        /// QHYBPD.
        /// </summary>
        public const string QHYBPD = "QHYBPD";

        /// <summary>
        /// QHYBDT.
        /// </summary>
        public const string QHYBDT = "QHYBDT";

        /// <summary>
        /// QHTMCU.
        /// </summary>
        public const string QHTMCU = "QHTMCU";

        /// <summary>
        /// QHSHAN.
        /// </summary>
        public const string QHSHAN = "QHSHAN";

        /// <summary>
        /// QHRMK.
        /// </summary>
        public const string QHRMK = "QHRMK";

        /// <summary>
        /// QHPAGM.
        /// </summary>
        public const string QHPAGM = "QHPAGM";

        /// <summary>
        /// QHCNTD.
        /// </summary>
        public const string QHCNTD = "QHCNTD";

        /// <summary>
        /// QHYTRB.
        /// </summary>
        public const string QHYTRB = "QHYTRB";

        /// <summary>
        /// QHYTPN.
        /// </summary>
        public const string QHYTPN = "QHYTPN";

        /// <summary>
        /// QHYGPM.
        /// </summary>
        public const string QHYGPM = "QHYGPM";

        /// <summary>
        /// QHYIPM.
        /// </summary>
        public const string QHYIPM = "QHYIPM";

        /// <summary>
        /// QHYLPM.
        /// </summary>
        public const string QHYLPM = "QHYLPM";

        /// <summary>
        /// QHYDPM.
        /// </summary>
        public const string QHYDPM = "QHYDPM";

        /// <summary>
        /// QHYWHL.
        /// </summary>
        public const string QHYWHL = "QHYWHL";

        /// <summary>
        /// QHTHD1.
        /// </summary>
        public const string QHTHD1 = "QHTHD1";

        /// <summary>
        /// QHYPMT.
        /// </summary>
        public const string QHYPMT = "QHYPMT";

        /// <summary>
        /// QHGPSP.
        /// </summary>
        public const string QHGPSP = "QHGPSP";

        /// <summary>
        /// QHYCR.
        /// </summary>
        public const string QHYCR = "QHYCR";

        /// <summary>
        /// QHYCCN.
        /// </summary>
        public const string QHYCCN = "QHYCCN";

        /// <summary>
        /// QHYFWH.
        /// </summary>
        public const string QHYFWH = "QHYFWH";

        /// <summary>
        /// QHYTWH.
        /// </summary>
        public const string QHYTWH = "QHYTWH";

        /// <summary>
        /// QHBPFG.
        /// </summary>
        public const string QHBPFG = "QHBPFG";

        /// <summary>
        /// QHPRTF.
        /// </summary>
        public const string QHPRTF = "QHPRTF";

        /// <summary>
        /// QHRCOP.
        /// </summary>
        public const string QHRCOP = "QHRCOP";

        /// <summary>
        /// QHFLAG.
        /// </summary>
        public const string QHFLAG = "QHFLAG";

        /// <summary>
        /// QHLTTR.
        /// </summary>
        public const string QHLTTR = "QHLTTR";

        /// <summary>
        /// QHNXTR.
        /// </summary>
        public const string QHNXTR = "QHNXTR";

        /// <summary>
        /// QHSNTO.
        /// </summary>
        public const string QHSNTO = "QHSNTO";

        /// <summary>
        /// QHAPDJ.
        /// </summary>
        public const string QHAPDJ = "QHAPDJ";

        /// <summary>
        /// QHSLCR.
        /// </summary>
        public const string QHSLCR = "QHSLCR";

        /// <summary>
        /// QHRUM.
        /// </summary>
        public const string QHRUM = "QHRUM";

        /// <summary>
        /// QHQYOA.
        /// </summary>
        public const string QHQYOA = "QHQYOA";

        /// <summary>
        /// QHYQT.
        /// </summary>
        public const string QHYQT = "QHYQT";

        /// <summary>
        /// QHCRR.
        /// </summary>
        public const string QHCRR = "QHCRR";

        /// <summary>
        /// QHCHD.
        /// </summary>
        public const string QHCHD = "QHCHD";

        /// <summary>
        /// QHURAB.
        /// </summary>
        public const string QHURAB = "QHURAB";

        /// <summary>
        /// QHURAT.
        /// </summary>
        public const string QHURAT = "QHURAT";

        /// <summary>
        /// QHURCD.
        /// </summary>
        public const string QHURCD = "QHURCD";

        /// <summary>
        /// QHURDT.
        /// </summary>
        public const string QHURDT = "QHURDT";

        /// <summary>
        /// QHURRF.
        /// </summary>
        public const string QHURRF = "QHURRF";

        /// <summary>
        /// QHAUSR.
        /// </summary>
        public const string QHAUSR = "QHAUSR";

        /// <summary>
        /// QHMJOB.
        /// </summary>
        public const string QHMJOB = "QHMJOB";

        /// <summary>
        /// QHUSER.
        /// </summary>
        public const string QHUSER = "QHUSER";

        /// <summary>
        /// QHJOBN.
        /// </summary>
        public const string QHJOBN = "QHJOBN";

        /// <summary>
        /// QHUPMJ.
        /// </summary>
        public const string QHUPMJ = "QHUPMJ";

        /// <summary>
        /// QHPID.
        /// </summary>
        public const string QHPID = "QHPID";

        /// <summary>
        /// QHTDAY.
        /// </summary>
        public const string QHTDAY = "QHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QHUKID", "QHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("QHUK01", "QHUK01", JdeDataType.Numeric),
        new JdeField("QHUK02", "QHUK02", JdeDataType.Numeric),
        new JdeField("QHYSFX", "QHYSFX", JdeDataType.String, 6),
        new JdeField("QHYSFL", "QHYSFL", JdeDataType.String, 6),
        new JdeField("QHDOCO", "QHDOCO", JdeDataType.Numeric),
        new JdeField("QHDCTO", "QHDCTO", JdeDataType.String, 4),
        new JdeField("QHKCOO", "QHKCOO", JdeDataType.String, 10),
        new JdeField("QHSFXO", "QHSFXO", JdeDataType.String, 6),
        new JdeField("QHYBTP", "QHYBTP", JdeDataType.String, 4),
        new JdeField("QHYRTN", "QHYRTN", JdeDataType.String, 50),
        new JdeField("QHYRTD", "QHYRTD", JdeDataType.Numeric),
        new JdeField("QHYBED", "QHYBED", JdeDataType.Numeric),
        new JdeField("QHYLNO", "QHYLNO", JdeDataType.String, 20),
        new JdeField("QHYREF", "QHYREF", JdeDataType.String, 80),
        new JdeField("QHMCU", "QHMCU", JdeDataType.String, 24),
        new JdeField("QHCO", "QHCO", JdeDataType.String, 10),
        new JdeField("QHMOT", "QHMOT", JdeDataType.String, 6),
        new JdeField("QHYPES", "QHYPES", JdeDataType.String, 50),
        new JdeField("QHYISN", "QHYISN", JdeDataType.String, 50),
        new JdeField("QHYISD", "QHYISD", JdeDataType.Numeric),
        new JdeField("QHYCNO", "QHYCNO", JdeDataType.Numeric),
        new JdeField("QHYICO", "QHYICO", JdeDataType.Numeric),
        new JdeField("QHYVNM", "QHYVNM", JdeDataType.String, 8),
        new JdeField("QHYPOS", "QHYPOS", JdeDataType.String, 6),
        new JdeField("QHYPOD", "QHYPOD", JdeDataType.String, 6),
        new JdeField("QHYPCD", "QHYPCD", JdeDataType.String, 10),
        new JdeField("QHYBLN", "QHYBLN", JdeDataType.String, 50),
        new JdeField("QHYBLD", "QHYBLD", JdeDataType.Numeric),
        new JdeField("QHYSUM", "QHYSUM", JdeDataType.String, 4),
        new JdeField("QHYSQT", "QHYSQT", JdeDataType.Numeric),
        new JdeField("QHTMPS", "QHTMPS", JdeDataType.Numeric),
        new JdeField("QHDNST", "QHDNST", JdeDataType.Numeric),
        new JdeField("QHSTPU", "QHSTPU", JdeDataType.String, 2),
        new JdeField("QHDNTP", "QHDNTP", JdeDataType.String, 2),
        new JdeField("QHYNQT", "QHYNQT", JdeDataType.Numeric),
        new JdeField("QHYNUM", "QHYNUM", JdeDataType.String, 4),
        new JdeField("QHYNTM", "QHYNTM", JdeDataType.Numeric),
        new JdeField("QHYNDN", "QHYNDN", JdeDataType.Numeric),
        new JdeField("QHYTUM", "QHYTUM", JdeDataType.String, 4),
        new JdeField("QHYTQT", "QHYTQT", JdeDataType.Numeric),
        new JdeField("QHYCC", "QHYCC", JdeDataType.String, 6),
        new JdeField("QHYCCC", "QHYCCC", JdeDataType.String, 6),
        new JdeField("QHYCDT", "QHYCDT", JdeDataType.Numeric),
        new JdeField("QHYUTD", "QHYUTD", JdeDataType.Numeric),
        new JdeField("QHYASS", "QHYASS", JdeDataType.Numeric),
        new JdeField("QHYUAV", "QHYUAV", JdeDataType.Numeric),
        new JdeField("QHYDTF", "QHYDTF", JdeDataType.Numeric),
        new JdeField("QHYDTT", "QHYDTT", JdeDataType.Numeric),
        new JdeField("QHVINV", "QHVINV", JdeDataType.String, 50),
        new JdeField("QHDIVJ", "QHDIVJ", JdeDataType.Numeric),
        new JdeField("QHYBID", "QHYBID", JdeDataType.String, 50),
        new JdeField("QHA107", "QHA107", JdeDataType.String, 2),
        new JdeField("QHA108", "QHA108", JdeDataType.String, 2),
        new JdeField("QHYSNO", "QHYSNO", JdeDataType.String, 50),
        new JdeField("QHYSDT", "QHYSDT", JdeDataType.Numeric),
        new JdeField("QHYMOA", "QHYMOA", JdeDataType.String, 50),
        new JdeField("QHYCBN", "QHYCBN", JdeDataType.String, 44),
        new JdeField("QHYPDN", "QHYPDN", JdeDataType.String, 44),
        new JdeField("QHYPAC", "QHYPAC", JdeDataType.String, 20),
        new JdeField("QHYBPD", "QHYBPD", JdeDataType.String, 50),
        new JdeField("QHYBDT", "QHYBDT", JdeDataType.Numeric),
        new JdeField("QHTMCU", "QHTMCU", JdeDataType.String, 24),
        new JdeField("QHSHAN", "QHSHAN", JdeDataType.Numeric),
        new JdeField("QHRMK", "QHRMK", JdeDataType.String, 60),
        new JdeField("QHPAGM", "QHPAGM", JdeDataType.String, 24),
        new JdeField("QHCNTD", "QHCNTD", JdeDataType.Numeric),
        new JdeField("QHYTRB", "QHYTRB", JdeDataType.String, 44),
        new JdeField("QHYTPN", "QHYTPN", JdeDataType.String, 44),
        new JdeField("QHYGPM", "QHYGPM", JdeDataType.String, 20),
        new JdeField("QHYIPM", "QHYIPM", JdeDataType.String, 20),
        new JdeField("QHYLPM", "QHYLPM", JdeDataType.String, 20),
        new JdeField("QHYDPM", "QHYDPM", JdeDataType.String, 20),
        new JdeField("QHYWHL", "QHYWHL", JdeDataType.String, 44),
        new JdeField("QHTHD1", "QHTHD1", JdeDataType.Numeric),
        new JdeField("QHYPMT", "QHYPMT", JdeDataType.String, 6),
        new JdeField("QHGPSP", "QHGPSP", JdeDataType.String, 2),
        new JdeField("QHYCR", "QHYCR", JdeDataType.Numeric),
        new JdeField("QHYCCN", "QHYCCN", JdeDataType.Numeric),
        new JdeField("QHYFWH", "QHYFWH", JdeDataType.String, 80),
        new JdeField("QHYTWH", "QHYTWH", JdeDataType.String, 80),
        new JdeField("QHBPFG", "QHBPFG", JdeDataType.String, 2),
        new JdeField("QHPRTF", "QHPRTF", JdeDataType.String, 2),
        new JdeField("QHRCOP", "QHRCOP", JdeDataType.Numeric),
        new JdeField("QHFLAG", "QHFLAG", JdeDataType.String, 2),
        new JdeField("QHLTTR", "QHLTTR", JdeDataType.String, 6),
        new JdeField("QHNXTR", "QHNXTR", JdeDataType.String, 6),
        new JdeField("QHSNTO", "QHSNTO", JdeDataType.Numeric),
        new JdeField("QHAPDJ", "QHAPDJ", JdeDataType.Numeric),
        new JdeField("QHSLCR", "QHSLCR", JdeDataType.String, 2),
        new JdeField("QHRUM", "QHRUM", JdeDataType.String, 4),
        new JdeField("QHQYOA", "QHQYOA", JdeDataType.Numeric),
        new JdeField("QHYQT", "QHYQT", JdeDataType.Numeric),
        new JdeField("QHCRR", "QHCRR", JdeDataType.Numeric),
        new JdeField("QHCHD", "QHCHD", JdeDataType.Numeric),
        new JdeField("QHURAB", "QHURAB", JdeDataType.Numeric),
        new JdeField("QHURAT", "QHURAT", JdeDataType.Numeric),
        new JdeField("QHURCD", "QHURCD", JdeDataType.String, 4),
        new JdeField("QHURDT", "QHURDT", JdeDataType.Numeric),
        new JdeField("QHURRF", "QHURRF", JdeDataType.String, 30),
        new JdeField("QHAUSR", "QHAUSR", JdeDataType.String, 20),
        new JdeField("QHMJOB", "QHMJOB", JdeDataType.String, 20),
        new JdeField("QHUSER", "QHUSER", JdeDataType.String, 20),
        new JdeField("QHJOBN", "QHJOBN", JdeDataType.String, 20),
        new JdeField("QHUPMJ", "QHUPMJ", JdeDataType.Numeric),
        new JdeField("QHPID", "QHPID", JdeDataType.String, 20),
        new JdeField("QHTDAY", "QHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I701_0", "Primary Key on QHUKID", new[] { "QHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I701_3", "Index on QHUK02, QHYPMT", new[] { "QHUK02", "QHYPMT" }),
        new JdeIndex("F75I701_4", "Index on QHUK01", new[] { "QHUK01" }),
        new JdeIndex("F75I701_5", "Index on QHYRTN, QHGPSP", new[] { "QHYRTN", "QHGPSP" })
    };
}
