using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42420 - .
/// </summary>
public class F42420 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ALKCOO.
        /// </summary>
        public const string ALKCOO = "ALKCOO";

        /// <summary>
        /// ALDOCO.
        /// </summary>
        public const string ALDOCO = "ALDOCO";

        /// <summary>
        /// ALDCTO.
        /// </summary>
        public const string ALDCTO = "ALDCTO";

        /// <summary>
        /// ALLNID.
        /// </summary>
        public const string ALLNID = "ALLNID";

        /// <summary>
        /// ALCORD.
        /// </summary>
        public const string ALCORD = "ALCORD";

        /// <summary>
        /// ALUPMJ.
        /// </summary>
        public const string ALUPMJ = "ALUPMJ";

        /// <summary>
        /// ALTDAY.
        /// </summary>
        public const string ALTDAY = "ALTDAY";

        /// <summary>
        /// ALUSER.
        /// </summary>
        public const string ALUSER = "ALUSER";

        /// <summary>
        /// ALRFRV.
        /// </summary>
        public const string ALRFRV = "ALRFRV";

        /// <summary>
        /// ALAPSR.
        /// </summary>
        public const string ALAPSR = "ALAPSR";

        /// <summary>
        /// ALAPPV.
        /// </summary>
        public const string ALAPPV = "ALAPPV";

        /// <summary>
        /// ALAPPJ.
        /// </summary>
        public const string ALAPPJ = "ALAPPJ";

        /// <summary>
        /// ALATIM.
        /// </summary>
        public const string ALATIM = "ALATIM";

        /// <summary>
        /// ALSFXO.
        /// </summary>
        public const string ALSFXO = "ALSFXO";

        /// <summary>
        /// ALMCU.
        /// </summary>
        public const string ALMCU = "ALMCU";

        /// <summary>
        /// ALLITM.
        /// </summary>
        public const string ALLITM = "ALLITM";

        /// <summary>
        /// ALUORG.
        /// </summary>
        public const string ALUORG = "ALUORG";

        /// <summary>
        /// ALUOM.
        /// </summary>
        public const string ALUOM = "ALUOM";

        /// <summary>
        /// ALUPRC.
        /// </summary>
        public const string ALUPRC = "ALUPRC";

        /// <summary>
        /// ALAEXP.
        /// </summary>
        public const string ALAEXP = "ALAEXP";

        /// <summary>
        /// ALFUP.
        /// </summary>
        public const string ALFUP = "ALFUP";

        /// <summary>
        /// ALFEA.
        /// </summary>
        public const string ALFEA = "ALFEA";

        /// <summary>
        /// ALLOCN.
        /// </summary>
        public const string ALLOCN = "ALLOCN";

        /// <summary>
        /// ALLOTN.
        /// </summary>
        public const string ALLOTN = "ALLOTN";

        /// <summary>
        /// ALDRQJ.
        /// </summary>
        public const string ALDRQJ = "ALDRQJ";

        /// <summary>
        /// ALDSC1.
        /// </summary>
        public const string ALDSC1 = "ALDSC1";

        /// <summary>
        /// ALLTTR.
        /// </summary>
        public const string ALLTTR = "ALLTTR";

        /// <summary>
        /// ALNXTR.
        /// </summary>
        public const string ALNXTR = "ALNXTR";

        /// <summary>
        /// ALUOM4.
        /// </summary>
        public const string ALUOM4 = "ALUOM4";

        /// <summary>
        /// ALSOQS.
        /// </summary>
        public const string ALSOQS = "ALSOQS";

        /// <summary>
        /// ALSOBK.
        /// </summary>
        public const string ALSOBK = "ALSOBK";

        /// <summary>
        /// ALSOCN.
        /// </summary>
        public const string ALSOCN = "ALSOCN";

        /// <summary>
        /// ALPDDJ.
        /// </summary>
        public const string ALPDDJ = "ALPDDJ";

        /// <summary>
        /// ALPPDJ.
        /// </summary>
        public const string ALPPDJ = "ALPPDJ";

        /// <summary>
        /// ALCNDJ.
        /// </summary>
        public const string ALCNDJ = "ALCNDJ";

        /// <summary>
        /// ALRSDJ.
        /// </summary>
        public const string ALRSDJ = "ALRSDJ";

        /// <summary>
        /// ALUNCS.
        /// </summary>
        public const string ALUNCS = "ALUNCS";

        /// <summary>
        /// ALECST.
        /// </summary>
        public const string ALECST = "ALECST";

        /// <summary>
        /// ALFUC.
        /// </summary>
        public const string ALFUC = "ALFUC";

        /// <summary>
        /// ALFEC.
        /// </summary>
        public const string ALFEC = "ALFEC";

        /// <summary>
        /// ALPRP5.
        /// </summary>
        public const string ALPRP5 = "ALPRP5";

        /// <summary>
        /// ALVEND.
        /// </summary>
        public const string ALVEND = "ALVEND";

        /// <summary>
        /// ALSHAN.
        /// </summary>
        public const string ALSHAN = "ALSHAN";

        /// <summary>
        /// ALDSC2.
        /// </summary>
        public const string ALDSC2 = "ALDSC2";

        /// <summary>
        /// ALTAX1.
        /// </summary>
        public const string ALTAX1 = "ALTAX1";

        /// <summary>
        /// ALWTUM.
        /// </summary>
        public const string ALWTUM = "ALWTUM";

        /// <summary>
        /// ALITWT.
        /// </summary>
        public const string ALITWT = "ALITWT";

        /// <summary>
        /// ALRYIN.
        /// </summary>
        public const string ALRYIN = "ALRYIN";

        /// <summary>
        /// ALINMG.
        /// </summary>
        public const string ALINMG = "ALINMG";

        /// <summary>
        /// ALMOT.
        /// </summary>
        public const string ALMOT = "ALMOT";

        /// <summary>
        /// ALDTYS.
        /// </summary>
        public const string ALDTYS = "ALDTYS";

        /// <summary>
        /// ALCARS.
        /// </summary>
        public const string ALCARS = "ALCARS";

        /// <summary>
        /// ALLOB.
        /// </summary>
        public const string ALLOB = "ALLOB";

        /// <summary>
        /// ALEUSE.
        /// </summary>
        public const string ALEUSE = "ALEUSE";

        /// <summary>
        /// ALEMCU.
        /// </summary>
        public const string ALEMCU = "ALEMCU";

        /// <summary>
        /// ALUPC1.
        /// </summary>
        public const string ALUPC1 = "ALUPC1";

        /// <summary>
        /// ALUPC2.
        /// </summary>
        public const string ALUPC2 = "ALUPC2";

        /// <summary>
        /// ALUPC3.
        /// </summary>
        public const string ALUPC3 = "ALUPC3";

        /// <summary>
        /// ALASN.
        /// </summary>
        public const string ALASN = "ALASN";

        /// <summary>
        /// ALPRGR.
        /// </summary>
        public const string ALPRGR = "ALPRGR";

        /// <summary>
        /// ALPTC.
        /// </summary>
        public const string ALPTC = "ALPTC";

        /// <summary>
        /// ALPRIO.
        /// </summary>
        public const string ALPRIO = "ALPRIO";

        /// <summary>
        /// ALRCD.
        /// </summary>
        public const string ALRCD = "ALRCD";

        /// <summary>
        /// ALCADC.
        /// </summary>
        public const string ALCADC = "ALCADC";

        /// <summary>
        /// ALGLPT.
        /// </summary>
        public const string ALGLPT = "ALGLPT";

        /// <summary>
        /// ALSBL.
        /// </summary>
        public const string ALSBL = "ALSBL";

        /// <summary>
        /// ALSBLT.
        /// </summary>
        public const string ALSBLT = "ALSBLT";

        /// <summary>
        /// ALSRP1.
        /// </summary>
        public const string ALSRP1 = "ALSRP1";

        /// <summary>
        /// ALSRP2.
        /// </summary>
        public const string ALSRP2 = "ALSRP2";

        /// <summary>
        /// ALSRP3.
        /// </summary>
        public const string ALSRP3 = "ALSRP3";

        /// <summary>
        /// ALSRP4.
        /// </summary>
        public const string ALSRP4 = "ALSRP4";

        /// <summary>
        /// ALSRP5.
        /// </summary>
        public const string ALSRP5 = "ALSRP5";

        /// <summary>
        /// ALAFT.
        /// </summary>
        public const string ALAFT = "ALAFT";

        /// <summary>
        /// ALSHCM.
        /// </summary>
        public const string ALSHCM = "ALSHCM";

        /// <summary>
        /// ALSHCN.
        /// </summary>
        public const string ALSHCN = "ALSHCN";

        /// <summary>
        /// ALFRAT.
        /// </summary>
        public const string ALFRAT = "ALFRAT";

        /// <summary>
        /// ALROUT.
        /// </summary>
        public const string ALROUT = "ALROUT";

        /// <summary>
        /// ALSTOP.
        /// </summary>
        public const string ALSTOP = "ALSTOP";

        /// <summary>
        /// ALZON.
        /// </summary>
        public const string ALZON = "ALZON";

        /// <summary>
        /// ALITVL.
        /// </summary>
        public const string ALITVL = "ALITVL";

        /// <summary>
        /// ALVLUM.
        /// </summary>
        public const string ALVLUM = "ALVLUM";

        /// <summary>
        /// ALACOM.
        /// </summary>
        public const string ALACOM = "ALACOM";

        /// <summary>
        /// ALEXR1.
        /// </summary>
        public const string ALEXR1 = "ALEXR1";

        /// <summary>
        /// ALTXA1.
        /// </summary>
        public const string ALTXA1 = "ALTXA1";

        /// <summary>
        /// ALSQOR.
        /// </summary>
        public const string ALSQOR = "ALSQOR";

        /// <summary>
        /// ALUOM2.
        /// </summary>
        public const string ALUOM2 = "ALUOM2";

        /// <summary>
        /// ALMCLN.
        /// </summary>
        public const string ALMCLN = "ALMCLN";

        /// <summary>
        /// ALXDCK.
        /// </summary>
        public const string ALXDCK = "ALXDCK";

        /// <summary>
        /// ALXPTY.
        /// </summary>
        public const string ALXPTY = "ALXPTY";

        /// <summary>
        /// ALDRQT.
        /// </summary>
        public const string ALDRQT = "ALDRQT";

        /// <summary>
        /// ALPDTT.
        /// </summary>
        public const string ALPDTT = "ALPDTT";

        /// <summary>
        /// ALOPTT.
        /// </summary>
        public const string ALOPTT = "ALOPTT";

        /// <summary>
        /// ALADTM.
        /// </summary>
        public const string ALADTM = "ALADTM";

        /// <summary>
        /// ALPMDT.
        /// </summary>
        public const string ALPMDT = "ALPMDT";

        /// <summary>
        /// ALPSTM.
        /// </summary>
        public const string ALPSTM = "ALPSTM";

        /// <summary>
        /// ALRLNU.
        /// </summary>
        public const string ALRLNU = "ALRLNU";

        /// <summary>
        /// ALPSIG.
        /// </summary>
        public const string ALPSIG = "ALPSIG";

        /// <summary>
        /// ALRLDJ.
        /// </summary>
        public const string ALRLDJ = "ALRLDJ";

        /// <summary>
        /// ALRLTM.
        /// </summary>
        public const string ALRLTM = "ALRLTM";

        /// <summary>
        /// ALXKCO.
        /// </summary>
        public const string ALXKCO = "ALXKCO";

        /// <summary>
        /// ALXORN.
        /// </summary>
        public const string ALXORN = "ALXORN";

        /// <summary>
        /// ALXCTO.
        /// </summary>
        public const string ALXCTO = "ALXCTO";

        /// <summary>
        /// ALXLLN.
        /// </summary>
        public const string ALXLLN = "ALXLLN";

        /// <summary>
        /// ALXSFX.
        /// </summary>
        public const string ALXSFX = "ALXSFX";

        /// <summary>
        /// ALPID.
        /// </summary>
        public const string ALPID = "ALPID";

        /// <summary>
        /// ALSPATTN.
        /// </summary>
        public const string ALSPATTN = "ALSPATTN";

        /// <summary>
        /// ALPRAN8.
        /// </summary>
        public const string ALPRAN8 = "ALPRAN8";

        /// <summary>
        /// ALPRCIDLN.
        /// </summary>
        public const string ALPRCIDLN = "ALPRCIDLN";

        /// <summary>
        /// ALCCIDLN.
        /// </summary>
        public const string ALCCIDLN = "ALCCIDLN";

        /// <summary>
        /// ALSHCCIDLN.
        /// </summary>
        public const string ALSHCCIDLN = "ALSHCCIDLN";

        /// <summary>
        /// ALOPPID.
        /// </summary>
        public const string ALOPPID = "ALOPPID";

        /// <summary>
        /// ALOSTP.
        /// </summary>
        public const string ALOSTP = "ALOSTP";

        /// <summary>
        /// ALUKID.
        /// </summary>
        public const string ALUKID = "ALUKID";

        /// <summary>
        /// ALCATNM.
        /// </summary>
        public const string ALCATNM = "ALCATNM";

        /// <summary>
        /// ALOSCORE.
        /// </summary>
        public const string ALOSCORE = "ALOSCORE";
    }

    /// <inheritdoc />
    public override string TableName => "F42420";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ALKCOO", "ALKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ALDOCO", "ALDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ALDCTO", "ALDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ALLNID", "ALLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ALCORD", "ALCORD", JdeDataType.Numeric, null, true, true),
        new JdeField("ALUPMJ", "ALUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("ALTDAY", "ALTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("ALUSER", "ALUSER", JdeDataType.String, 20, true, true),
        new JdeField("ALRFRV", "ALRFRV", JdeDataType.String, 6),
        new JdeField("ALAPSR", "ALAPSR", JdeDataType.String, 2),
        new JdeField("ALAPPV", "ALAPPV", JdeDataType.String, 20),
        new JdeField("ALAPPJ", "ALAPPJ", JdeDataType.Numeric),
        new JdeField("ALATIM", "ALATIM", JdeDataType.Numeric),
        new JdeField("ALSFXO", "ALSFXO", JdeDataType.String, 6),
        new JdeField("ALMCU", "ALMCU", JdeDataType.String, 24),
        new JdeField("ALLITM", "ALLITM", JdeDataType.String, 50),
        new JdeField("ALUORG", "ALUORG", JdeDataType.Numeric),
        new JdeField("ALUOM", "ALUOM", JdeDataType.String, 4),
        new JdeField("ALUPRC", "ALUPRC", JdeDataType.Numeric),
        new JdeField("ALAEXP", "ALAEXP", JdeDataType.Numeric),
        new JdeField("ALFUP", "ALFUP", JdeDataType.Numeric),
        new JdeField("ALFEA", "ALFEA", JdeDataType.Numeric),
        new JdeField("ALLOCN", "ALLOCN", JdeDataType.String, 40),
        new JdeField("ALLOTN", "ALLOTN", JdeDataType.String, 60),
        new JdeField("ALDRQJ", "ALDRQJ", JdeDataType.Numeric),
        new JdeField("ALDSC1", "ALDSC1", JdeDataType.String, 60),
        new JdeField("ALLTTR", "ALLTTR", JdeDataType.String, 6),
        new JdeField("ALNXTR", "ALNXTR", JdeDataType.String, 6),
        new JdeField("ALUOM4", "ALUOM4", JdeDataType.String, 4),
        new JdeField("ALSOQS", "ALSOQS", JdeDataType.Numeric),
        new JdeField("ALSOBK", "ALSOBK", JdeDataType.Numeric),
        new JdeField("ALSOCN", "ALSOCN", JdeDataType.Numeric),
        new JdeField("ALPDDJ", "ALPDDJ", JdeDataType.Numeric),
        new JdeField("ALPPDJ", "ALPPDJ", JdeDataType.Numeric),
        new JdeField("ALCNDJ", "ALCNDJ", JdeDataType.Numeric),
        new JdeField("ALRSDJ", "ALRSDJ", JdeDataType.Numeric),
        new JdeField("ALUNCS", "ALUNCS", JdeDataType.Numeric),
        new JdeField("ALECST", "ALECST", JdeDataType.Numeric),
        new JdeField("ALFUC", "ALFUC", JdeDataType.Numeric),
        new JdeField("ALFEC", "ALFEC", JdeDataType.Numeric),
        new JdeField("ALPRP5", "ALPRP5", JdeDataType.String, 6),
        new JdeField("ALVEND", "ALVEND", JdeDataType.Numeric),
        new JdeField("ALSHAN", "ALSHAN", JdeDataType.Numeric),
        new JdeField("ALDSC2", "ALDSC2", JdeDataType.String, 60),
        new JdeField("ALTAX1", "ALTAX1", JdeDataType.String, 2),
        new JdeField("ALWTUM", "ALWTUM", JdeDataType.String, 4),
        new JdeField("ALITWT", "ALITWT", JdeDataType.Numeric),
        new JdeField("ALRYIN", "ALRYIN", JdeDataType.String, 2),
        new JdeField("ALINMG", "ALINMG", JdeDataType.String, 20),
        new JdeField("ALMOT", "ALMOT", JdeDataType.String, 6),
        new JdeField("ALDTYS", "ALDTYS", JdeDataType.String, 4),
        new JdeField("ALCARS", "ALCARS", JdeDataType.Numeric),
        new JdeField("ALLOB", "ALLOB", JdeDataType.String, 6),
        new JdeField("ALEUSE", "ALEUSE", JdeDataType.String, 6),
        new JdeField("ALEMCU", "ALEMCU", JdeDataType.String, 24),
        new JdeField("ALUPC1", "ALUPC1", JdeDataType.String, 4),
        new JdeField("ALUPC2", "ALUPC2", JdeDataType.String, 4),
        new JdeField("ALUPC3", "ALUPC3", JdeDataType.String, 4),
        new JdeField("ALASN", "ALASN", JdeDataType.String, 16),
        new JdeField("ALPRGR", "ALPRGR", JdeDataType.String, 16),
        new JdeField("ALPTC", "ALPTC", JdeDataType.String, 6),
        new JdeField("ALPRIO", "ALPRIO", JdeDataType.String, 2),
        new JdeField("ALRCD", "ALRCD", JdeDataType.String, 6),
        new JdeField("ALCADC", "ALCADC", JdeDataType.Numeric),
        new JdeField("ALGLPT", "ALGLPT", JdeDataType.String, 8),
        new JdeField("ALSBL", "ALSBL", JdeDataType.String, 16),
        new JdeField("ALSBLT", "ALSBLT", JdeDataType.String, 2),
        new JdeField("ALSRP1", "ALSRP1", JdeDataType.String, 6),
        new JdeField("ALSRP2", "ALSRP2", JdeDataType.String, 6),
        new JdeField("ALSRP3", "ALSRP3", JdeDataType.String, 6),
        new JdeField("ALSRP4", "ALSRP4", JdeDataType.String, 6),
        new JdeField("ALSRP5", "ALSRP5", JdeDataType.String, 6),
        new JdeField("ALAFT", "ALAFT", JdeDataType.String, 2),
        new JdeField("ALSHCM", "ALSHCM", JdeDataType.String, 6),
        new JdeField("ALSHCN", "ALSHCN", JdeDataType.String, 6),
        new JdeField("ALFRAT", "ALFRAT", JdeDataType.String, 20),
        new JdeField("ALROUT", "ALROUT", JdeDataType.String, 6),
        new JdeField("ALSTOP", "ALSTOP", JdeDataType.String, 6),
        new JdeField("ALZON", "ALZON", JdeDataType.String, 6),
        new JdeField("ALITVL", "ALITVL", JdeDataType.Numeric),
        new JdeField("ALVLUM", "ALVLUM", JdeDataType.String, 4),
        new JdeField("ALACOM", "ALACOM", JdeDataType.String, 2),
        new JdeField("ALEXR1", "ALEXR1", JdeDataType.String, 4),
        new JdeField("ALTXA1", "ALTXA1", JdeDataType.String, 20),
        new JdeField("ALSQOR", "ALSQOR", JdeDataType.Numeric),
        new JdeField("ALUOM2", "ALUOM2", JdeDataType.String, 4),
        new JdeField("ALMCLN", "ALMCLN", JdeDataType.Numeric),
        new JdeField("ALXDCK", "ALXDCK", JdeDataType.String, 2),
        new JdeField("ALXPTY", "ALXPTY", JdeDataType.Numeric),
        new JdeField("ALDRQT", "ALDRQT", JdeDataType.Numeric),
        new JdeField("ALPDTT", "ALPDTT", JdeDataType.Numeric),
        new JdeField("ALOPTT", "ALOPTT", JdeDataType.Numeric),
        new JdeField("ALADTM", "ALADTM", JdeDataType.Numeric),
        new JdeField("ALPMDT", "ALPMDT", JdeDataType.Numeric),
        new JdeField("ALPSTM", "ALPSTM", JdeDataType.Numeric),
        new JdeField("ALRLNU", "ALRLNU", JdeDataType.String, 20),
        new JdeField("ALPSIG", "ALPSIG", JdeDataType.String, 60),
        new JdeField("ALRLDJ", "ALRLDJ", JdeDataType.Numeric),
        new JdeField("ALRLTM", "ALRLTM", JdeDataType.Numeric),
        new JdeField("ALXKCO", "ALXKCO", JdeDataType.String, 10),
        new JdeField("ALXORN", "ALXORN", JdeDataType.Numeric),
        new JdeField("ALXCTO", "ALXCTO", JdeDataType.String, 4),
        new JdeField("ALXLLN", "ALXLLN", JdeDataType.Numeric),
        new JdeField("ALXSFX", "ALXSFX", JdeDataType.String, 6),
        new JdeField("ALPID", "ALPID", JdeDataType.String, 20),
        new JdeField("ALSPATTN", "ALSPATTN", JdeDataType.String, 100),
        new JdeField("ALPRAN8", "ALPRAN8", JdeDataType.Numeric),
        new JdeField("ALPRCIDLN", "ALPRCIDLN", JdeDataType.Numeric),
        new JdeField("ALCCIDLN", "ALCCIDLN", JdeDataType.Numeric),
        new JdeField("ALSHCCIDLN", "ALSHCCIDLN", JdeDataType.Numeric),
        new JdeField("ALOPPID", "ALOPPID", JdeDataType.Numeric),
        new JdeField("ALOSTP", "ALOSTP", JdeDataType.String, 6),
        new JdeField("ALUKID", "ALUKID", JdeDataType.Numeric),
        new JdeField("ALCATNM", "ALCATNM", JdeDataType.String, 60),
        new JdeField("ALOSCORE", "ALOSCORE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42420_0", "Primary Key on ALKCOO, ALDOCO, ALDCTO, ALLNID, ALCORD, ALUPMJ, ALTDAY, ALUSER", new[] { "ALKCOO", "ALDOCO", "ALDCTO", "ALLNID", "ALCORD", "ALUPMJ", "ALTDAY", "ALUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F42420_2", "Index on ALKCOO, ALDOCO, ALDCTO, SYS_NC00116$", new[] { "ALKCOO", "ALDOCO", "ALDCTO", "SYS_NC00116$" })
    };
}
