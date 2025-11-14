using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B119 - .
/// </summary>
public class F03B119 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RNKCO.
        /// </summary>
        public const string RNKCO = "RNKCO";

        /// <summary>
        /// RNDCT.
        /// </summary>
        public const string RNDCT = "RNDCT";

        /// <summary>
        /// RNDOC.
        /// </summary>
        public const string RNDOC = "RNDOC";

        /// <summary>
        /// RNDGJ.
        /// </summary>
        public const string RNDGJ = "RNDGJ";

        /// <summary>
        /// RNJELN.
        /// </summary>
        public const string RNJELN = "RNJELN";

        /// <summary>
        /// RNEXTL.
        /// </summary>
        public const string RNEXTL = "RNEXTL";

        /// <summary>
        /// RNLT.
        /// </summary>
        public const string RNLT = "RNLT";

        /// <summary>
        /// RNSLNE.
        /// </summary>
        public const string RNSLNE = "RNSLNE";

        /// <summary>
        /// RNTORG.
        /// </summary>
        public const string RNTORG = "RNTORG";

        /// <summary>
        /// RNTXA1.
        /// </summary>
        public const string RNTXA1 = "RNTXA1";

        /// <summary>
        /// RNTXITM.
        /// </summary>
        public const string RNTXITM = "RNTXITM";

        /// <summary>
        /// RNU.
        /// </summary>
        public const string RNU = "RNU";

        /// <summary>
        /// RNUM.
        /// </summary>
        public const string RNUM = "RNUM";

        /// <summary>
        /// RNVINV.
        /// </summary>
        public const string RNVINV = "RNVINV";

        /// <summary>
        /// RNWR01.
        /// </summary>
        public const string RNWR01 = "RNWR01";

        /// <summary>
        /// RNEXR1.
        /// </summary>
        public const string RNEXR1 = "RNEXR1";

        /// <summary>
        /// RNFY.
        /// </summary>
        public const string RNFY = "RNFY";

        /// <summary>
        /// RNGLC.
        /// </summary>
        public const string RNGLC = "RNGLC";

        /// <summary>
        /// RNDRR.
        /// </summary>
        public const string RNDRR = "RNDRR";

        /// <summary>
        /// RNODGJ.
        /// </summary>
        public const string RNODGJ = "RNODGJ";

        /// <summary>
        /// RNOJELN.
        /// </summary>
        public const string RNOJELN = "RNOJELN";

        /// <summary>
        /// RNOEXTL.
        /// </summary>
        public const string RNOEXTL = "RNOEXTL";

        /// <summary>
        /// RNICU.
        /// </summary>
        public const string RNICU = "RNICU";

        /// <summary>
        /// RNICUT.
        /// </summary>
        public const string RNICUT = "RNICUT";

        /// <summary>
        /// RNITM.
        /// </summary>
        public const string RNITM = "RNITM";

        /// <summary>
        /// RNIVD.
        /// </summary>
        public const string RNIVD = "RNIVD";

        /// <summary>
        /// RNLNID.
        /// </summary>
        public const string RNLNID = "RNLNID";

        /// <summary>
        /// RNMCU.
        /// </summary>
        public const string RNMCU = "RNMCU";

        /// <summary>
        /// RNOBJ.
        /// </summary>
        public const string RNOBJ = "RNOBJ";

        /// <summary>
        /// RNPN.
        /// </summary>
        public const string RNPN = "RNPN";

        /// <summary>
        /// RNPO.
        /// </summary>
        public const string RNPO = "RNPO";

        /// <summary>
        /// RNPSFX.
        /// </summary>
        public const string RNPSFX = "RNPSFX";

        /// <summary>
        /// RNPOST.
        /// </summary>
        public const string RNPOST = "RNPOST";

        /// <summary>
        /// RNR1.
        /// </summary>
        public const string RNR1 = "RNR1";

        /// <summary>
        /// RNR2.
        /// </summary>
        public const string RNR2 = "RNR2";

        /// <summary>
        /// RNRE.
        /// </summary>
        public const string RNRE = "RNRE";

        /// <summary>
        /// RNSBL.
        /// </summary>
        public const string RNSBL = "RNSBL";

        /// <summary>
        /// RNSBLT.
        /// </summary>
        public const string RNSBLT = "RNSBLT";

        /// <summary>
        /// RNSFX.
        /// </summary>
        public const string RNSFX = "RNSFX";

        /// <summary>
        /// RNSUB.
        /// </summary>
        public const string RNSUB = "RNSUB";

        /// <summary>
        /// RNAA.
        /// </summary>
        public const string RNAA = "RNAA";

        /// <summary>
        /// RNABR1.
        /// </summary>
        public const string RNABR1 = "RNABR1";

        /// <summary>
        /// RNABR2.
        /// </summary>
        public const string RNABR2 = "RNABR2";

        /// <summary>
        /// RNABR3.
        /// </summary>
        public const string RNABR3 = "RNABR3";

        /// <summary>
        /// RNABR4.
        /// </summary>
        public const string RNABR4 = "RNABR4";

        /// <summary>
        /// RNABT1.
        /// </summary>
        public const string RNABT1 = "RNABT1";

        /// <summary>
        /// RNABT2.
        /// </summary>
        public const string RNABT2 = "RNABT2";

        /// <summary>
        /// RNABT3.
        /// </summary>
        public const string RNABT3 = "RNABT3";

        /// <summary>
        /// RNABT4.
        /// </summary>
        public const string RNABT4 = "RNABT4";

        /// <summary>
        /// RNACR.
        /// </summary>
        public const string RNACR = "RNACR";

        /// <summary>
        /// RNAID.
        /// </summary>
        public const string RNAID = "RNAID";

        /// <summary>
        /// RNAM.
        /// </summary>
        public const string RNAM = "RNAM";

        /// <summary>
        /// RNAN8.
        /// </summary>
        public const string RNAN8 = "RNAN8";

        /// <summary>
        /// RNANI.
        /// </summary>
        public const string RNANI = "RNANI";

        /// <summary>
        /// RNASID.
        /// </summary>
        public const string RNASID = "RNASID";

        /// <summary>
        /// RNBC.
        /// </summary>
        public const string RNBC = "RNBC";

        /// <summary>
        /// RNBCRC.
        /// </summary>
        public const string RNBCRC = "RNBCRC";

        /// <summary>
        /// RNCO.
        /// </summary>
        public const string RNCO = "RNCO";

        /// <summary>
        /// RNCRCD.
        /// </summary>
        public const string RNCRCD = "RNCRCD";

        /// <summary>
        /// RNCRR.
        /// </summary>
        public const string RNCRR = "RNCRR";

        /// <summary>
        /// RNCRRM.
        /// </summary>
        public const string RNCRRM = "RNCRRM";

        /// <summary>
        /// RNCTRY.
        /// </summary>
        public const string RNCTRY = "RNCTRY";

        /// <summary>
        /// RNDCTO.
        /// </summary>
        public const string RNDCTO = "RNDCTO";

        /// <summary>
        /// RNDICJ.
        /// </summary>
        public const string RNDICJ = "RNDICJ";

        /// <summary>
        /// RNDSVJ.
        /// </summary>
        public const string RNDSVJ = "RNDSVJ";

        /// <summary>
        /// RNDSYJ.
        /// </summary>
        public const string RNDSYJ = "RNDSYJ";

        /// <summary>
        /// RNEXA.
        /// </summary>
        public const string RNEXA = "RNEXA";

        /// <summary>
        /// RNUPMJ.
        /// </summary>
        public const string RNUPMJ = "RNUPMJ";

        /// <summary>
        /// RNUPMT.
        /// </summary>
        public const string RNUPMT = "RNUPMT";

        /// <summary>
        /// RNUSER.
        /// </summary>
        public const string RNUSER = "RNUSER";

        /// <summary>
        /// RNJOBN.
        /// </summary>
        public const string RNJOBN = "RNJOBN";

        /// <summary>
        /// RNPID.
        /// </summary>
        public const string RNPID = "RNPID";

        /// <summary>
        /// RNAAR.
        /// </summary>
        public const string RNAAR = "RNAAR";

        /// <summary>
        /// RNAARE.
        /// </summary>
        public const string RNAARE = "RNAARE";

        /// <summary>
        /// RNAARN.
        /// </summary>
        public const string RNAARN = "RNAARN";

        /// <summary>
        /// RNRRC.
        /// </summary>
        public const string RNRRC = "RNRRC";

        /// <summary>
        /// RNFAAR.
        /// </summary>
        public const string RNFAAR = "RNFAAR";

        /// <summary>
        /// RNFAARE.
        /// </summary>
        public const string RNFAARE = "RNFAARE";

        /// <summary>
        /// RNCH7.
        /// </summary>
        public const string RNCH7 = "RNCH7";

        /// <summary>
        /// RNFAARN.
        /// </summary>
        public const string RNFAARN = "RNFAARN";

        /// <summary>
        /// RNRRCOGS.
        /// </summary>
        public const string RNRRCOGS = "RNRRCOGS";

        /// <summary>
        /// RNDJ7.
        /// </summary>
        public const string RNDJ7 = "RNDJ7";

        /// <summary>
        /// RNEXR.
        /// </summary>
        public const string RNEXR = "RNEXR";

        /// <summary>
        /// RNRRSCH.
        /// </summary>
        public const string RNRRSCH = "RNRRSCH";

        /// <summary>
        /// RNRRACT.
        /// </summary>
        public const string RNRRACT = "RNRRACT";

        /// <summary>
        /// RNRRBCH1.
        /// </summary>
        public const string RNRRBCH1 = "RNRRBCH1";

        /// <summary>
        /// RNRRBCH2.
        /// </summary>
        public const string RNRRBCH2 = "RNRRBCH2";

        /// <summary>
        /// RNRRBCH3.
        /// </summary>
        public const string RNRRBCH3 = "RNRRBCH3";

        /// <summary>
        /// RNRRBDT1.
        /// </summary>
        public const string RNRRBDT1 = "RNRRBDT1";

        /// <summary>
        /// RNRRBDT2.
        /// </summary>
        public const string RNRRBDT2 = "RNRRBDT2";

        /// <summary>
        /// RNRRBDT3.
        /// </summary>
        public const string RNRRBDT3 = "RNRRBDT3";

        /// <summary>
        /// RNRRBNU1.
        /// </summary>
        public const string RNRRBNU1 = "RNRRBNU1";

        /// <summary>
        /// RNRRBNU2.
        /// </summary>
        public const string RNRRBNU2 = "RNRRBNU2";

        /// <summary>
        /// RNRRBNU3.
        /// </summary>
        public const string RNRRBNU3 = "RNRRBNU3";

        /// <summary>
        /// RNRRBST1.
        /// </summary>
        public const string RNRRBST1 = "RNRRBST1";

        /// <summary>
        /// RNRRBST2.
        /// </summary>
        public const string RNRRBST2 = "RNRRBST2";

        /// <summary>
        /// RNRRBST3.
        /// </summary>
        public const string RNRRBST3 = "RNRRBST3";
    }

    /// <inheritdoc />
    public override string TableName => "F03B119";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RNKCO", "RNKCO", JdeDataType.String, 10, true, true),
        new JdeField("RNDCT", "RNDCT", JdeDataType.String, 4, true, true),
        new JdeField("RNDOC", "RNDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RNDGJ", "RNDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RNJELN", "RNJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("RNEXTL", "RNEXTL", JdeDataType.String, 4, true, true),
        new JdeField("RNLT", "RNLT", JdeDataType.String, 4, true, true),
        new JdeField("RNSLNE", "RNSLNE", JdeDataType.Numeric, null, true, true),
        new JdeField("RNTORG", "RNTORG", JdeDataType.String, 20),
        new JdeField("RNTXA1", "RNTXA1", JdeDataType.String, 20),
        new JdeField("RNTXITM", "RNTXITM", JdeDataType.Numeric),
        new JdeField("RNU", "RNU", JdeDataType.Numeric),
        new JdeField("RNUM", "RNUM", JdeDataType.String, 4),
        new JdeField("RNVINV", "RNVINV", JdeDataType.String, 50),
        new JdeField("RNWR01", "RNWR01", JdeDataType.String, 8),
        new JdeField("RNEXR1", "RNEXR1", JdeDataType.String, 4),
        new JdeField("RNFY", "RNFY", JdeDataType.Numeric),
        new JdeField("RNGLC", "RNGLC", JdeDataType.String, 8),
        new JdeField("RNDRR", "RNDRR", JdeDataType.Numeric),
        new JdeField("RNODGJ", "RNODGJ", JdeDataType.Numeric),
        new JdeField("RNOJELN", "RNOJELN", JdeDataType.Numeric),
        new JdeField("RNOEXTL", "RNOEXTL", JdeDataType.String, 4),
        new JdeField("RNICU", "RNICU", JdeDataType.Numeric),
        new JdeField("RNICUT", "RNICUT", JdeDataType.String, 4),
        new JdeField("RNITM", "RNITM", JdeDataType.Numeric),
        new JdeField("RNIVD", "RNIVD", JdeDataType.Numeric),
        new JdeField("RNLNID", "RNLNID", JdeDataType.Numeric),
        new JdeField("RNMCU", "RNMCU", JdeDataType.String, 24),
        new JdeField("RNOBJ", "RNOBJ", JdeDataType.String, 12),
        new JdeField("RNPN", "RNPN", JdeDataType.Numeric),
        new JdeField("RNPO", "RNPO", JdeDataType.String, 16),
        new JdeField("RNPSFX", "RNPSFX", JdeDataType.String, 6),
        new JdeField("RNPOST", "RNPOST", JdeDataType.String, 2),
        new JdeField("RNR1", "RNR1", JdeDataType.String, 16),
        new JdeField("RNR2", "RNR2", JdeDataType.String, 16),
        new JdeField("RNRE", "RNRE", JdeDataType.String, 2),
        new JdeField("RNSBL", "RNSBL", JdeDataType.String, 16),
        new JdeField("RNSBLT", "RNSBLT", JdeDataType.String, 2),
        new JdeField("RNSFX", "RNSFX", JdeDataType.String, 6),
        new JdeField("RNSUB", "RNSUB", JdeDataType.String, 16),
        new JdeField("RNAA", "RNAA", JdeDataType.Numeric),
        new JdeField("RNABR1", "RNABR1", JdeDataType.String, 24),
        new JdeField("RNABR2", "RNABR2", JdeDataType.String, 24),
        new JdeField("RNABR3", "RNABR3", JdeDataType.String, 24),
        new JdeField("RNABR4", "RNABR4", JdeDataType.String, 24),
        new JdeField("RNABT1", "RNABT1", JdeDataType.String, 2),
        new JdeField("RNABT2", "RNABT2", JdeDataType.String, 2),
        new JdeField("RNABT3", "RNABT3", JdeDataType.String, 2),
        new JdeField("RNABT4", "RNABT4", JdeDataType.String, 2),
        new JdeField("RNACR", "RNACR", JdeDataType.Numeric),
        new JdeField("RNAID", "RNAID", JdeDataType.String, 16),
        new JdeField("RNAM", "RNAM", JdeDataType.String, 2),
        new JdeField("RNAN8", "RNAN8", JdeDataType.Numeric),
        new JdeField("RNANI", "RNANI", JdeDataType.String, 58),
        new JdeField("RNASID", "RNASID", JdeDataType.String, 50),
        new JdeField("RNBC", "RNBC", JdeDataType.String, 2),
        new JdeField("RNBCRC", "RNBCRC", JdeDataType.String, 6),
        new JdeField("RNCO", "RNCO", JdeDataType.String, 10),
        new JdeField("RNCRCD", "RNCRCD", JdeDataType.String, 6),
        new JdeField("RNCRR", "RNCRR", JdeDataType.Numeric),
        new JdeField("RNCRRM", "RNCRRM", JdeDataType.String, 2),
        new JdeField("RNCTRY", "RNCTRY", JdeDataType.Numeric),
        new JdeField("RNDCTO", "RNDCTO", JdeDataType.String, 4),
        new JdeField("RNDICJ", "RNDICJ", JdeDataType.Numeric),
        new JdeField("RNDSVJ", "RNDSVJ", JdeDataType.Numeric),
        new JdeField("RNDSYJ", "RNDSYJ", JdeDataType.Numeric),
        new JdeField("RNEXA", "RNEXA", JdeDataType.String, 60),
        new JdeField("RNUPMJ", "RNUPMJ", JdeDataType.Numeric),
        new JdeField("RNUPMT", "RNUPMT", JdeDataType.Numeric),
        new JdeField("RNUSER", "RNUSER", JdeDataType.String, 20),
        new JdeField("RNJOBN", "RNJOBN", JdeDataType.String, 20),
        new JdeField("RNPID", "RNPID", JdeDataType.String, 20),
        new JdeField("RNAAR", "RNAAR", JdeDataType.Numeric),
        new JdeField("RNAARE", "RNAARE", JdeDataType.Numeric),
        new JdeField("RNAARN", "RNAARN", JdeDataType.Numeric),
        new JdeField("RNRRC", "RNRRC", JdeDataType.String, 2),
        new JdeField("RNFAAR", "RNFAAR", JdeDataType.Numeric),
        new JdeField("RNFAARE", "RNFAARE", JdeDataType.Numeric),
        new JdeField("RNCH7", "RNCH7", JdeDataType.String, 2),
        new JdeField("RNFAARN", "RNFAARN", JdeDataType.Numeric),
        new JdeField("RNRRCOGS", "RNRRCOGS", JdeDataType.String, 2),
        new JdeField("RNDJ7", "RNDJ7", JdeDataType.Numeric),
        new JdeField("RNEXR", "RNEXR", JdeDataType.String, 60),
        new JdeField("RNRRSCH", "RNRRSCH", JdeDataType.String, 2),
        new JdeField("RNRRACT", "RNRRACT", JdeDataType.String, 2),
        new JdeField("RNRRBCH1", "RNRRBCH1", JdeDataType.String, 2),
        new JdeField("RNRRBCH2", "RNRRBCH2", JdeDataType.String, 2),
        new JdeField("RNRRBCH3", "RNRRBCH3", JdeDataType.String, 2),
        new JdeField("RNRRBDT1", "RNRRBDT1", JdeDataType.Numeric),
        new JdeField("RNRRBDT2", "RNRRBDT2", JdeDataType.Numeric),
        new JdeField("RNRRBDT3", "RNRRBDT3", JdeDataType.Numeric),
        new JdeField("RNRRBNU1", "RNRRBNU1", JdeDataType.Numeric),
        new JdeField("RNRRBNU2", "RNRRBNU2", JdeDataType.Numeric),
        new JdeField("RNRRBNU3", "RNRRBNU3", JdeDataType.Numeric),
        new JdeField("RNRRBST1", "RNRRBST1", JdeDataType.String, 160),
        new JdeField("RNRRBST2", "RNRRBST2", JdeDataType.String, 160),
        new JdeField("RNRRBST3", "RNRRBST3", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B119_0", "Primary Key on RNKCO, RNDCT, RNDOC, RNDGJ, RNJELN, RNEXTL, RNLT, RNSLNE", new[] { "RNKCO", "RNDCT", "RNDOC", "RNDGJ", "RNJELN", "RNEXTL", "RNLT", "RNSLNE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B119_2", "Index on RNKCO, RNDCT, RNDOC, RNDGJ, RNJELN, RNEXTL, RNLT, SYS_NC00098$", new[] { "RNKCO", "RNDCT", "RNDOC", "RNDGJ", "RNJELN", "RNEXTL", "RNLT", "SYS_NC00098$" })
    };
}
