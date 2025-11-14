using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1502B - .
/// </summary>
public class F1502B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NFDOCO.
        /// </summary>
        public const string NFDOCO = "NFDOCO";

        /// <summary>
        /// NFLSET.
        /// </summary>
        public const string NFLSET = "NFLSET";

        /// <summary>
        /// NFLNID.
        /// </summary>
        public const string NFLNID = "NFLNID";

        /// <summary>
        /// NFBLGR.
        /// </summary>
        public const string NFBLGR = "NFBLGR";

        /// <summary>
        /// NFTRAN.
        /// </summary>
        public const string NFTRAN = "NFTRAN";

        /// <summary>
        /// NFGLC.
        /// </summary>
        public const string NFGLC = "NFGLC";

        /// <summary>
        /// NFRMK.
        /// </summary>
        public const string NFRMK = "NFRMK";

        /// <summary>
        /// NFAG.
        /// </summary>
        public const string NFAG = "NFAG";

        /// <summary>
        /// NFEFTB.
        /// </summary>
        public const string NFEFTB = "NFEFTB";

        /// <summary>
        /// NFEFTE.
        /// </summary>
        public const string NFEFTE = "NFEFTE";

        /// <summary>
        /// NFBLFC.
        /// </summary>
        public const string NFBLFC = "NFBLFC";

        /// <summary>
        /// NFBF01.
        /// </summary>
        public const string NFBF01 = "NFBF01";

        /// <summary>
        /// NFBF02.
        /// </summary>
        public const string NFBF02 = "NFBF02";

        /// <summary>
        /// NFBF03.
        /// </summary>
        public const string NFBF03 = "NFBF03";

        /// <summary>
        /// NFBF04.
        /// </summary>
        public const string NFBF04 = "NFBF04";

        /// <summary>
        /// NFBF05.
        /// </summary>
        public const string NFBF05 = "NFBF05";

        /// <summary>
        /// NFBF06.
        /// </summary>
        public const string NFBF06 = "NFBF06";

        /// <summary>
        /// NFBF07.
        /// </summary>
        public const string NFBF07 = "NFBF07";

        /// <summary>
        /// NFBF08.
        /// </summary>
        public const string NFBF08 = "NFBF08";

        /// <summary>
        /// NFBF09.
        /// </summary>
        public const string NFBF09 = "NFBF09";

        /// <summary>
        /// NFBF10.
        /// </summary>
        public const string NFBF10 = "NFBF10";

        /// <summary>
        /// NFBF11.
        /// </summary>
        public const string NFBF11 = "NFBF11";

        /// <summary>
        /// NFBF12.
        /// </summary>
        public const string NFBF12 = "NFBF12";

        /// <summary>
        /// NFBF13.
        /// </summary>
        public const string NFBF13 = "NFBF13";

        /// <summary>
        /// NFMCU.
        /// </summary>
        public const string NFMCU = "NFMCU";

        /// <summary>
        /// NFSBL.
        /// </summary>
        public const string NFSBL = "NFSBL";

        /// <summary>
        /// NFAN8J.
        /// </summary>
        public const string NFAN8J = "NFAN8J";

        /// <summary>
        /// NFUNIT.
        /// </summary>
        public const string NFUNIT = "NFUNIT";

        /// <summary>
        /// NFSMCU.
        /// </summary>
        public const string NFSMCU = "NFSMCU";

        /// <summary>
        /// NFTRAR.
        /// </summary>
        public const string NFTRAR = "NFTRAR";

        /// <summary>
        /// NFSEPI.
        /// </summary>
        public const string NFSEPI = "NFSEPI";

        /// <summary>
        /// NFITMG.
        /// </summary>
        public const string NFITMG = "NFITMG";

        /// <summary>
        /// NFSUSP.
        /// </summary>
        public const string NFSUSP = "NFSUSP";

        /// <summary>
        /// NFDEAL.
        /// </summary>
        public const string NFDEAL = "NFDEAL";

        /// <summary>
        /// NFRN01.
        /// </summary>
        public const string NFRN01 = "NFRN01";

        /// <summary>
        /// NFRN02.
        /// </summary>
        public const string NFRN02 = "NFRN02";

        /// <summary>
        /// NFRN03.
        /// </summary>
        public const string NFRN03 = "NFRN03";

        /// <summary>
        /// NFRN04.
        /// </summary>
        public const string NFRN04 = "NFRN04";

        /// <summary>
        /// NFRN05.
        /// </summary>
        public const string NFRN05 = "NFRN05";

        /// <summary>
        /// NFAGSN.
        /// </summary>
        public const string NFAGSN = "NFAGSN";

        /// <summary>
        /// NFGENT.
        /// </summary>
        public const string NFGENT = "NFGENT";

        /// <summary>
        /// NFBCI.
        /// </summary>
        public const string NFBCI = "NFBCI";

        /// <summary>
        /// NFCRCD.
        /// </summary>
        public const string NFCRCD = "NFCRCD";

        /// <summary>
        /// NFACR.
        /// </summary>
        public const string NFACR = "NFACR";

        /// <summary>
        /// NFTXA1.
        /// </summary>
        public const string NFTXA1 = "NFTXA1";

        /// <summary>
        /// NFEXR1.
        /// </summary>
        public const string NFEXR1 = "NFEXR1";

        /// <summary>
        /// NFSTAM.
        /// </summary>
        public const string NFSTAM = "NFSTAM";

        /// <summary>
        /// NFATXN.
        /// </summary>
        public const string NFATXN = "NFATXN";

        /// <summary>
        /// NFATXA.
        /// </summary>
        public const string NFATXA = "NFATXA";

        /// <summary>
        /// NFSBLT.
        /// </summary>
        public const string NFSBLT = "NFSBLT";

        /// <summary>
        /// NFCRRM.
        /// </summary>
        public const string NFCRRM = "NFCRRM";

        /// <summary>
        /// NFCTAM.
        /// </summary>
        public const string NFCTAM = "NFCTAM";

        /// <summary>
        /// NFCTXA.
        /// </summary>
        public const string NFCTXA = "NFCTXA";

        /// <summary>
        /// NFCTXN.
        /// </summary>
        public const string NFCTXN = "NFCTXN";

        /// <summary>
        /// NFYT.
        /// </summary>
        public const string NFYT = "NFYT";

        /// <summary>
        /// NFLRYF.
        /// </summary>
        public const string NFLRYF = "NFLRYF";

        /// <summary>
        /// NFLRYT.
        /// </summary>
        public const string NFLRYT = "NFLRYT";

        /// <summary>
        /// NFINVP.
        /// </summary>
        public const string NFINVP = "NFINVP";

        /// <summary>
        /// NFDBAN.
        /// </summary>
        public const string NFDBAN = "NFDBAN";

        /// <summary>
        /// NFSUDT.
        /// </summary>
        public const string NFSUDT = "NFSUDT";

        /// <summary>
        /// NFPPNM.
        /// </summary>
        public const string NFPPNM = "NFPPNM";

        /// <summary>
        /// NFALTB.
        /// </summary>
        public const string NFALTB = "NFALTB";

        /// <summary>
        /// NFAPSF.
        /// </summary>
        public const string NFAPSF = "NFAPSF";

        /// <summary>
        /// NFBTDT.
        /// </summary>
        public const string NFBTDT = "NFBTDT";

        /// <summary>
        /// NFRNTA.
        /// </summary>
        public const string NFRNTA = "NFRNTA";

        /// <summary>
        /// NFUNGR.
        /// </summary>
        public const string NFUNGR = "NFUNGR";

        /// <summary>
        /// NFLSVR.
        /// </summary>
        public const string NFLSVR = "NFLSVR";

        /// <summary>
        /// NFBCI3.
        /// </summary>
        public const string NFBCI3 = "NFBCI3";

        /// <summary>
        /// NFVRSC.
        /// </summary>
        public const string NFVRSC = "NFVRSC";

        /// <summary>
        /// NFURCD.
        /// </summary>
        public const string NFURCD = "NFURCD";

        /// <summary>
        /// NFURDT.
        /// </summary>
        public const string NFURDT = "NFURDT";

        /// <summary>
        /// NFURAT.
        /// </summary>
        public const string NFURAT = "NFURAT";

        /// <summary>
        /// NFURAB.
        /// </summary>
        public const string NFURAB = "NFURAB";

        /// <summary>
        /// NFURRF.
        /// </summary>
        public const string NFURRF = "NFURRF";

        /// <summary>
        /// NFUSER.
        /// </summary>
        public const string NFUSER = "NFUSER";

        /// <summary>
        /// NFPID.
        /// </summary>
        public const string NFPID = "NFPID";

        /// <summary>
        /// NFUPMJ.
        /// </summary>
        public const string NFUPMJ = "NFUPMJ";

        /// <summary>
        /// NFUPMT.
        /// </summary>
        public const string NFUPMT = "NFUPMT";

        /// <summary>
        /// NFJOBN.
        /// </summary>
        public const string NFJOBN = "NFJOBN";

        /// <summary>
        /// NFENTJ.
        /// </summary>
        public const string NFENTJ = "NFENTJ";

        /// <summary>
        /// NFTORG.
        /// </summary>
        public const string NFTORG = "NFTORG";

        /// <summary>
        /// NFCRR.
        /// </summary>
        public const string NFCRR = "NFCRR";

        /// <summary>
        /// NFLAFF.
        /// </summary>
        public const string NFLAFF = "NFLAFF";

        /// <summary>
        /// NFLELL.
        /// </summary>
        public const string NFLELL = "NFLELL";

        /// <summary>
        /// NFLEPM.
        /// </summary>
        public const string NFLEPM = "NFLEPM";

        /// <summary>
        /// NFNUMB.
        /// </summary>
        public const string NFNUMB = "NFNUMB";

        /// <summary>
        /// NFLZNPA.
        /// </summary>
        public const string NFLZNPA = "NFLZNPA";
    }

    /// <inheritdoc />
    public override string TableName => "F1502B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NFDOCO", "NFDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NFLSET", "NFLSET", JdeDataType.String, 4),
        new JdeField("NFLNID", "NFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("NFBLGR", "NFBLGR", JdeDataType.String, 24),
        new JdeField("NFTRAN", "NFTRAN", JdeDataType.String, 2),
        new JdeField("NFGLC", "NFGLC", JdeDataType.String, 8),
        new JdeField("NFRMK", "NFRMK", JdeDataType.String, 60),
        new JdeField("NFAG", "NFAG", JdeDataType.Numeric),
        new JdeField("NFEFTB", "NFEFTB", JdeDataType.Numeric),
        new JdeField("NFEFTE", "NFEFTE", JdeDataType.Numeric),
        new JdeField("NFBLFC", "NFBLFC", JdeDataType.String, 2),
        new JdeField("NFBF01", "NFBF01", JdeDataType.String, 2),
        new JdeField("NFBF02", "NFBF02", JdeDataType.String, 2),
        new JdeField("NFBF03", "NFBF03", JdeDataType.String, 2),
        new JdeField("NFBF04", "NFBF04", JdeDataType.String, 2),
        new JdeField("NFBF05", "NFBF05", JdeDataType.String, 2),
        new JdeField("NFBF06", "NFBF06", JdeDataType.String, 2),
        new JdeField("NFBF07", "NFBF07", JdeDataType.String, 2),
        new JdeField("NFBF08", "NFBF08", JdeDataType.String, 2),
        new JdeField("NFBF09", "NFBF09", JdeDataType.String, 2),
        new JdeField("NFBF10", "NFBF10", JdeDataType.String, 2),
        new JdeField("NFBF11", "NFBF11", JdeDataType.String, 2),
        new JdeField("NFBF12", "NFBF12", JdeDataType.String, 2),
        new JdeField("NFBF13", "NFBF13", JdeDataType.String, 2),
        new JdeField("NFMCU", "NFMCU", JdeDataType.String, 24),
        new JdeField("NFSBL", "NFSBL", JdeDataType.String, 16),
        new JdeField("NFAN8J", "NFAN8J", JdeDataType.Numeric),
        new JdeField("NFUNIT", "NFUNIT", JdeDataType.String, 16),
        new JdeField("NFSMCU", "NFSMCU", JdeDataType.String, 24),
        new JdeField("NFTRAR", "NFTRAR", JdeDataType.String, 6),
        new JdeField("NFSEPI", "NFSEPI", JdeDataType.String, 2),
        new JdeField("NFITMG", "NFITMG", JdeDataType.String, 6),
        new JdeField("NFSUSP", "NFSUSP", JdeDataType.String, 2),
        new JdeField("NFDEAL", "NFDEAL", JdeDataType.String, 16),
        new JdeField("NFRN01", "NFRN01", JdeDataType.String, 6),
        new JdeField("NFRN02", "NFRN02", JdeDataType.String, 6),
        new JdeField("NFRN03", "NFRN03", JdeDataType.String, 6),
        new JdeField("NFRN04", "NFRN04", JdeDataType.String, 6),
        new JdeField("NFRN05", "NFRN05", JdeDataType.String, 6),
        new JdeField("NFAGSN", "NFAGSN", JdeDataType.Numeric),
        new JdeField("NFGENT", "NFGENT", JdeDataType.String, 2),
        new JdeField("NFBCI", "NFBCI", JdeDataType.Numeric),
        new JdeField("NFCRCD", "NFCRCD", JdeDataType.String, 6),
        new JdeField("NFACR", "NFACR", JdeDataType.Numeric),
        new JdeField("NFTXA1", "NFTXA1", JdeDataType.String, 20),
        new JdeField("NFEXR1", "NFEXR1", JdeDataType.String, 4),
        new JdeField("NFSTAM", "NFSTAM", JdeDataType.Numeric),
        new JdeField("NFATXN", "NFATXN", JdeDataType.Numeric),
        new JdeField("NFATXA", "NFATXA", JdeDataType.Numeric),
        new JdeField("NFSBLT", "NFSBLT", JdeDataType.String, 2),
        new JdeField("NFCRRM", "NFCRRM", JdeDataType.String, 2),
        new JdeField("NFCTAM", "NFCTAM", JdeDataType.Numeric),
        new JdeField("NFCTXA", "NFCTXA", JdeDataType.Numeric),
        new JdeField("NFCTXN", "NFCTXN", JdeDataType.Numeric),
        new JdeField("NFYT", "NFYT", JdeDataType.String, 2),
        new JdeField("NFLRYF", "NFLRYF", JdeDataType.Numeric),
        new JdeField("NFLRYT", "NFLRYT", JdeDataType.Numeric),
        new JdeField("NFINVP", "NFINVP", JdeDataType.String, 2),
        new JdeField("NFDBAN", "NFDBAN", JdeDataType.Numeric),
        new JdeField("NFSUDT", "NFSUDT", JdeDataType.Numeric),
        new JdeField("NFPPNM", "NFPPNM", JdeDataType.Numeric),
        new JdeField("NFALTB", "NFALTB", JdeDataType.String, 2),
        new JdeField("NFAPSF", "NFAPSF", JdeDataType.Numeric),
        new JdeField("NFBTDT", "NFBTDT", JdeDataType.Numeric),
        new JdeField("NFRNTA", "NFRNTA", JdeDataType.Numeric),
        new JdeField("NFUNGR", "NFUNGR", JdeDataType.String, 2),
        new JdeField("NFLSVR", "NFLSVR", JdeDataType.Numeric),
        new JdeField("NFBCI3", "NFBCI3", JdeDataType.Numeric),
        new JdeField("NFVRSC", "NFVRSC", JdeDataType.String, 2),
        new JdeField("NFURCD", "NFURCD", JdeDataType.String, 4),
        new JdeField("NFURDT", "NFURDT", JdeDataType.Numeric),
        new JdeField("NFURAT", "NFURAT", JdeDataType.Numeric),
        new JdeField("NFURAB", "NFURAB", JdeDataType.Numeric),
        new JdeField("NFURRF", "NFURRF", JdeDataType.String, 30),
        new JdeField("NFUSER", "NFUSER", JdeDataType.String, 20),
        new JdeField("NFPID", "NFPID", JdeDataType.String, 20),
        new JdeField("NFUPMJ", "NFUPMJ", JdeDataType.Numeric),
        new JdeField("NFUPMT", "NFUPMT", JdeDataType.Numeric),
        new JdeField("NFJOBN", "NFJOBN", JdeDataType.String, 20),
        new JdeField("NFENTJ", "NFENTJ", JdeDataType.Numeric),
        new JdeField("NFTORG", "NFTORG", JdeDataType.String, 20),
        new JdeField("NFCRR", "NFCRR", JdeDataType.Numeric),
        new JdeField("NFLAFF", "NFLAFF", JdeDataType.String, 2),
        new JdeField("NFLELL", "NFLELL", JdeDataType.String, 2),
        new JdeField("NFLEPM", "NFLEPM", JdeDataType.String, 2),
        new JdeField("NFNUMB", "NFNUMB", JdeDataType.Numeric),
        new JdeField("NFLZNPA", "NFLZNPA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1502B_0", "Primary Key on NFDOCO, NFLNID", new[] { "NFDOCO", "NFLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1502B_10", "Index on NFBCI", new[] { "NFBCI" }),
        new JdeIndex("F1502B_11", "Index on NFBCI3", new[] { "NFBCI3" }),
        new JdeIndex("F1502B_12", "Index on NFDOCO, SYS_NC00088$, NFMCU, NFUNIT", new[] { "NFDOCO", "SYS_NC00088$", "NFMCU", "NFUNIT" }),
        new JdeIndex("F1502B_13", "Index on NFDOCO, NFMCU, NFUNIT, NFNUMB, NFGLC, NFEFTB", new[] { "NFDOCO", "NFMCU", "NFUNIT", "NFNUMB", "NFGLC", "NFEFTB" }),
        new JdeIndex("F1502B_2", "Index on NFDOCO, SYS_NC00088$", new[] { "NFDOCO", "SYS_NC00088$" }),
        new JdeIndex("F1502B_3", "Index on NFDOCO, NFGLC, NFMCU, NFUNIT, NFAGSN", new[] { "NFDOCO", "NFGLC", "NFMCU", "NFUNIT", "NFAGSN" }),
        new JdeIndex("F1502B_4", "Index on NFDOCO, NFUNIT, NFEFTB, NFGLC", new[] { "NFDOCO", "NFUNIT", "NFEFTB", "NFGLC" }),
        new JdeIndex("F1502B_5", "Index on NFMCU, NFUNIT", new[] { "NFMCU", "NFUNIT" }),
        new JdeIndex("F1502B_6", "Index on NFBLFC", new[] { "NFBLFC" }),
        new JdeIndex("F1502B_7", "Index on NFMCU, NFUNIT, NFDOCO, NFGLC, NFEFTB", new[] { "NFMCU", "NFUNIT", "NFDOCO", "NFGLC", "NFEFTB" }),
        new JdeIndex("F1502B_8", "Index on NFDOCO, NFMCU, NFUNIT, NFGLC, NFEFTB", new[] { "NFDOCO", "NFMCU", "NFUNIT", "NFGLC", "NFEFTB" }),
        new JdeIndex("F1502B_9", "Index on NFDOCO, NFGLC, NFMCU, NFUNGR, NFAGSN", new[] { "NFDOCO", "NFGLC", "NFMCU", "NFUNGR", "NFAGSN" })
    };
}
