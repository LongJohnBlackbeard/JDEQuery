using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B117 - .
/// </summary>
public class F03B117 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLKCO.
        /// </summary>
        public const string RLKCO = "RLKCO";

        /// <summary>
        /// RLDCT.
        /// </summary>
        public const string RLDCT = "RLDCT";

        /// <summary>
        /// RLDOC.
        /// </summary>
        public const string RLDOC = "RLDOC";

        /// <summary>
        /// RLDGJ.
        /// </summary>
        public const string RLDGJ = "RLDGJ";

        /// <summary>
        /// RLJELN.
        /// </summary>
        public const string RLJELN = "RLJELN";

        /// <summary>
        /// RLEXTL.
        /// </summary>
        public const string RLEXTL = "RLEXTL";

        /// <summary>
        /// RLDRR.
        /// </summary>
        public const string RLDRR = "RLDRR";

        /// <summary>
        /// RLODGJ.
        /// </summary>
        public const string RLODGJ = "RLODGJ";

        /// <summary>
        /// RLOJELN.
        /// </summary>
        public const string RLOJELN = "RLOJELN";

        /// <summary>
        /// RLOEXTL.
        /// </summary>
        public const string RLOEXTL = "RLOEXTL";

        /// <summary>
        /// RLICU.
        /// </summary>
        public const string RLICU = "RLICU";

        /// <summary>
        /// RLICUT.
        /// </summary>
        public const string RLICUT = "RLICUT";

        /// <summary>
        /// RLDICJ.
        /// </summary>
        public const string RLDICJ = "RLDICJ";

        /// <summary>
        /// RLDSYJ.
        /// </summary>
        public const string RLDSYJ = "RLDSYJ";

        /// <summary>
        /// RLCO.
        /// </summary>
        public const string RLCO = "RLCO";

        /// <summary>
        /// RLMCU.
        /// </summary>
        public const string RLMCU = "RLMCU";

        /// <summary>
        /// RLOBJ.
        /// </summary>
        public const string RLOBJ = "RLOBJ";

        /// <summary>
        /// RLSUB.
        /// </summary>
        public const string RLSUB = "RLSUB";

        /// <summary>
        /// RLSBL.
        /// </summary>
        public const string RLSBL = "RLSBL";

        /// <summary>
        /// RLSBLT.
        /// </summary>
        public const string RLSBLT = "RLSBLT";

        /// <summary>
        /// RLTORG.
        /// </summary>
        public const string RLTORG = "RLTORG";

        /// <summary>
        /// RLTXA1.
        /// </summary>
        public const string RLTXA1 = "RLTXA1";

        /// <summary>
        /// RLTXITM.
        /// </summary>
        public const string RLTXITM = "RLTXITM";

        /// <summary>
        /// RLU.
        /// </summary>
        public const string RLU = "RLU";

        /// <summary>
        /// RLUM.
        /// </summary>
        public const string RLUM = "RLUM";

        /// <summary>
        /// RLVINV.
        /// </summary>
        public const string RLVINV = "RLVINV";

        /// <summary>
        /// RLWR01.
        /// </summary>
        public const string RLWR01 = "RLWR01";

        /// <summary>
        /// RLEXR1.
        /// </summary>
        public const string RLEXR1 = "RLEXR1";

        /// <summary>
        /// RLFY.
        /// </summary>
        public const string RLFY = "RLFY";

        /// <summary>
        /// RLGLC.
        /// </summary>
        public const string RLGLC = "RLGLC";

        /// <summary>
        /// RLITM.
        /// </summary>
        public const string RLITM = "RLITM";

        /// <summary>
        /// RLIVD.
        /// </summary>
        public const string RLIVD = "RLIVD";

        /// <summary>
        /// RLLNID.
        /// </summary>
        public const string RLLNID = "RLLNID";

        /// <summary>
        /// RLLT.
        /// </summary>
        public const string RLLT = "RLLT";

        /// <summary>
        /// RLPN.
        /// </summary>
        public const string RLPN = "RLPN";

        /// <summary>
        /// RLPO.
        /// </summary>
        public const string RLPO = "RLPO";

        /// <summary>
        /// RLPOST.
        /// </summary>
        public const string RLPOST = "RLPOST";

        /// <summary>
        /// RLPSFX.
        /// </summary>
        public const string RLPSFX = "RLPSFX";

        /// <summary>
        /// RLR1.
        /// </summary>
        public const string RLR1 = "RLR1";

        /// <summary>
        /// RLR2.
        /// </summary>
        public const string RLR2 = "RLR2";

        /// <summary>
        /// RLRE.
        /// </summary>
        public const string RLRE = "RLRE";

        /// <summary>
        /// RLSFX.
        /// </summary>
        public const string RLSFX = "RLSFX";

        /// <summary>
        /// RLAA.
        /// </summary>
        public const string RLAA = "RLAA";

        /// <summary>
        /// RLABR1.
        /// </summary>
        public const string RLABR1 = "RLABR1";

        /// <summary>
        /// RLABR2.
        /// </summary>
        public const string RLABR2 = "RLABR2";

        /// <summary>
        /// RLABR3.
        /// </summary>
        public const string RLABR3 = "RLABR3";

        /// <summary>
        /// RLABR4.
        /// </summary>
        public const string RLABR4 = "RLABR4";

        /// <summary>
        /// RLABT1.
        /// </summary>
        public const string RLABT1 = "RLABT1";

        /// <summary>
        /// RLABT2.
        /// </summary>
        public const string RLABT2 = "RLABT2";

        /// <summary>
        /// RLABT3.
        /// </summary>
        public const string RLABT3 = "RLABT3";

        /// <summary>
        /// RLABT4.
        /// </summary>
        public const string RLABT4 = "RLABT4";

        /// <summary>
        /// RLACR.
        /// </summary>
        public const string RLACR = "RLACR";

        /// <summary>
        /// RLAID.
        /// </summary>
        public const string RLAID = "RLAID";

        /// <summary>
        /// RLAM.
        /// </summary>
        public const string RLAM = "RLAM";

        /// <summary>
        /// RLAN8.
        /// </summary>
        public const string RLAN8 = "RLAN8";

        /// <summary>
        /// RLANI.
        /// </summary>
        public const string RLANI = "RLANI";

        /// <summary>
        /// RLASID.
        /// </summary>
        public const string RLASID = "RLASID";

        /// <summary>
        /// RLBC.
        /// </summary>
        public const string RLBC = "RLBC";

        /// <summary>
        /// RLBCRC.
        /// </summary>
        public const string RLBCRC = "RLBCRC";

        /// <summary>
        /// RLCRCD.
        /// </summary>
        public const string RLCRCD = "RLCRCD";

        /// <summary>
        /// RLCRR.
        /// </summary>
        public const string RLCRR = "RLCRR";

        /// <summary>
        /// RLCRRM.
        /// </summary>
        public const string RLCRRM = "RLCRRM";

        /// <summary>
        /// RLCTRY.
        /// </summary>
        public const string RLCTRY = "RLCTRY";

        /// <summary>
        /// RLDCTO.
        /// </summary>
        public const string RLDCTO = "RLDCTO";

        /// <summary>
        /// RLDSVJ.
        /// </summary>
        public const string RLDSVJ = "RLDSVJ";

        /// <summary>
        /// RLEXA.
        /// </summary>
        public const string RLEXA = "RLEXA";

        /// <summary>
        /// RLUPMJ.
        /// </summary>
        public const string RLUPMJ = "RLUPMJ";

        /// <summary>
        /// RLUPMT.
        /// </summary>
        public const string RLUPMT = "RLUPMT";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLJOBN.
        /// </summary>
        public const string RLJOBN = "RLJOBN";

        /// <summary>
        /// RLPID.
        /// </summary>
        public const string RLPID = "RLPID";

        /// <summary>
        /// RLAAR.
        /// </summary>
        public const string RLAAR = "RLAAR";

        /// <summary>
        /// RLAARE.
        /// </summary>
        public const string RLAARE = "RLAARE";

        /// <summary>
        /// RLAARN.
        /// </summary>
        public const string RLAARN = "RLAARN";

        /// <summary>
        /// RLRRC.
        /// </summary>
        public const string RLRRC = "RLRRC";

        /// <summary>
        /// RLFAAR.
        /// </summary>
        public const string RLFAAR = "RLFAAR";

        /// <summary>
        /// RLFAARE.
        /// </summary>
        public const string RLFAARE = "RLFAARE";

        /// <summary>
        /// RLFAARN.
        /// </summary>
        public const string RLFAARN = "RLFAARN";

        /// <summary>
        /// RLEXR.
        /// </summary>
        public const string RLEXR = "RLEXR";

        /// <summary>
        /// RLRRCOGS.
        /// </summary>
        public const string RLRRCOGS = "RLRRCOGS";

        /// <summary>
        /// RLCH7.
        /// </summary>
        public const string RLCH7 = "RLCH7";

        /// <summary>
        /// RLDJ7.
        /// </summary>
        public const string RLDJ7 = "RLDJ7";

        /// <summary>
        /// RLRRSCH.
        /// </summary>
        public const string RLRRSCH = "RLRRSCH";

        /// <summary>
        /// RLRRACT.
        /// </summary>
        public const string RLRRACT = "RLRRACT";

        /// <summary>
        /// RLRRBCH1.
        /// </summary>
        public const string RLRRBCH1 = "RLRRBCH1";

        /// <summary>
        /// RLRRBCH2.
        /// </summary>
        public const string RLRRBCH2 = "RLRRBCH2";

        /// <summary>
        /// RLRRBCH3.
        /// </summary>
        public const string RLRRBCH3 = "RLRRBCH3";

        /// <summary>
        /// RLRRBDT1.
        /// </summary>
        public const string RLRRBDT1 = "RLRRBDT1";

        /// <summary>
        /// RLRRBDT2.
        /// </summary>
        public const string RLRRBDT2 = "RLRRBDT2";

        /// <summary>
        /// RLRRBDT3.
        /// </summary>
        public const string RLRRBDT3 = "RLRRBDT3";

        /// <summary>
        /// RLRRBNU1.
        /// </summary>
        public const string RLRRBNU1 = "RLRRBNU1";

        /// <summary>
        /// RLRRBNU2.
        /// </summary>
        public const string RLRRBNU2 = "RLRRBNU2";

        /// <summary>
        /// RLRRBNU3.
        /// </summary>
        public const string RLRRBNU3 = "RLRRBNU3";

        /// <summary>
        /// RLRRBST1.
        /// </summary>
        public const string RLRRBST1 = "RLRRBST1";

        /// <summary>
        /// RLRRBST2.
        /// </summary>
        public const string RLRRBST2 = "RLRRBST2";

        /// <summary>
        /// RLRRBST3.
        /// </summary>
        public const string RLRRBST3 = "RLRRBST3";
    }

    /// <inheritdoc />
    public override string TableName => "F03B117";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLKCO", "RLKCO", JdeDataType.String, 10, true, true),
        new JdeField("RLDCT", "RLDCT", JdeDataType.String, 4, true, true),
        new JdeField("RLDOC", "RLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RLDGJ", "RLDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RLJELN", "RLJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("RLEXTL", "RLEXTL", JdeDataType.String, 4, true, true),
        new JdeField("RLDRR", "RLDRR", JdeDataType.Numeric),
        new JdeField("RLODGJ", "RLODGJ", JdeDataType.Numeric),
        new JdeField("RLOJELN", "RLOJELN", JdeDataType.Numeric),
        new JdeField("RLOEXTL", "RLOEXTL", JdeDataType.String, 4),
        new JdeField("RLICU", "RLICU", JdeDataType.Numeric),
        new JdeField("RLICUT", "RLICUT", JdeDataType.String, 4),
        new JdeField("RLDICJ", "RLDICJ", JdeDataType.Numeric),
        new JdeField("RLDSYJ", "RLDSYJ", JdeDataType.Numeric),
        new JdeField("RLCO", "RLCO", JdeDataType.String, 10),
        new JdeField("RLMCU", "RLMCU", JdeDataType.String, 24),
        new JdeField("RLOBJ", "RLOBJ", JdeDataType.String, 12),
        new JdeField("RLSUB", "RLSUB", JdeDataType.String, 16),
        new JdeField("RLSBL", "RLSBL", JdeDataType.String, 16),
        new JdeField("RLSBLT", "RLSBLT", JdeDataType.String, 2),
        new JdeField("RLTORG", "RLTORG", JdeDataType.String, 20),
        new JdeField("RLTXA1", "RLTXA1", JdeDataType.String, 20),
        new JdeField("RLTXITM", "RLTXITM", JdeDataType.Numeric),
        new JdeField("RLU", "RLU", JdeDataType.Numeric),
        new JdeField("RLUM", "RLUM", JdeDataType.String, 4),
        new JdeField("RLVINV", "RLVINV", JdeDataType.String, 50),
        new JdeField("RLWR01", "RLWR01", JdeDataType.String, 8),
        new JdeField("RLEXR1", "RLEXR1", JdeDataType.String, 4),
        new JdeField("RLFY", "RLFY", JdeDataType.Numeric),
        new JdeField("RLGLC", "RLGLC", JdeDataType.String, 8),
        new JdeField("RLITM", "RLITM", JdeDataType.Numeric),
        new JdeField("RLIVD", "RLIVD", JdeDataType.Numeric),
        new JdeField("RLLNID", "RLLNID", JdeDataType.Numeric),
        new JdeField("RLLT", "RLLT", JdeDataType.String, 4, true, true),
        new JdeField("RLPN", "RLPN", JdeDataType.Numeric),
        new JdeField("RLPO", "RLPO", JdeDataType.String, 16),
        new JdeField("RLPOST", "RLPOST", JdeDataType.String, 2),
        new JdeField("RLPSFX", "RLPSFX", JdeDataType.String, 6),
        new JdeField("RLR1", "RLR1", JdeDataType.String, 16),
        new JdeField("RLR2", "RLR2", JdeDataType.String, 16),
        new JdeField("RLRE", "RLRE", JdeDataType.String, 2),
        new JdeField("RLSFX", "RLSFX", JdeDataType.String, 6),
        new JdeField("RLAA", "RLAA", JdeDataType.Numeric),
        new JdeField("RLABR1", "RLABR1", JdeDataType.String, 24),
        new JdeField("RLABR2", "RLABR2", JdeDataType.String, 24),
        new JdeField("RLABR3", "RLABR3", JdeDataType.String, 24),
        new JdeField("RLABR4", "RLABR4", JdeDataType.String, 24),
        new JdeField("RLABT1", "RLABT1", JdeDataType.String, 2),
        new JdeField("RLABT2", "RLABT2", JdeDataType.String, 2),
        new JdeField("RLABT3", "RLABT3", JdeDataType.String, 2),
        new JdeField("RLABT4", "RLABT4", JdeDataType.String, 2),
        new JdeField("RLACR", "RLACR", JdeDataType.Numeric),
        new JdeField("RLAID", "RLAID", JdeDataType.String, 16),
        new JdeField("RLAM", "RLAM", JdeDataType.String, 2),
        new JdeField("RLAN8", "RLAN8", JdeDataType.Numeric),
        new JdeField("RLANI", "RLANI", JdeDataType.String, 58),
        new JdeField("RLASID", "RLASID", JdeDataType.String, 50),
        new JdeField("RLBC", "RLBC", JdeDataType.String, 2),
        new JdeField("RLBCRC", "RLBCRC", JdeDataType.String, 6),
        new JdeField("RLCRCD", "RLCRCD", JdeDataType.String, 6),
        new JdeField("RLCRR", "RLCRR", JdeDataType.Numeric),
        new JdeField("RLCRRM", "RLCRRM", JdeDataType.String, 2),
        new JdeField("RLCTRY", "RLCTRY", JdeDataType.Numeric),
        new JdeField("RLDCTO", "RLDCTO", JdeDataType.String, 4),
        new JdeField("RLDSVJ", "RLDSVJ", JdeDataType.Numeric),
        new JdeField("RLEXA", "RLEXA", JdeDataType.String, 60),
        new JdeField("RLUPMJ", "RLUPMJ", JdeDataType.Numeric),
        new JdeField("RLUPMT", "RLUPMT", JdeDataType.Numeric),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20),
        new JdeField("RLJOBN", "RLJOBN", JdeDataType.String, 20),
        new JdeField("RLPID", "RLPID", JdeDataType.String, 20),
        new JdeField("RLAAR", "RLAAR", JdeDataType.Numeric),
        new JdeField("RLAARE", "RLAARE", JdeDataType.Numeric),
        new JdeField("RLAARN", "RLAARN", JdeDataType.Numeric),
        new JdeField("RLRRC", "RLRRC", JdeDataType.String, 2),
        new JdeField("RLFAAR", "RLFAAR", JdeDataType.Numeric),
        new JdeField("RLFAARE", "RLFAARE", JdeDataType.Numeric),
        new JdeField("RLFAARN", "RLFAARN", JdeDataType.Numeric),
        new JdeField("RLEXR", "RLEXR", JdeDataType.String, 60),
        new JdeField("RLRRCOGS", "RLRRCOGS", JdeDataType.String, 2),
        new JdeField("RLCH7", "RLCH7", JdeDataType.String, 2),
        new JdeField("RLDJ7", "RLDJ7", JdeDataType.Numeric),
        new JdeField("RLRRSCH", "RLRRSCH", JdeDataType.String, 2),
        new JdeField("RLRRACT", "RLRRACT", JdeDataType.String, 2),
        new JdeField("RLRRBCH1", "RLRRBCH1", JdeDataType.String, 2),
        new JdeField("RLRRBCH2", "RLRRBCH2", JdeDataType.String, 2),
        new JdeField("RLRRBCH3", "RLRRBCH3", JdeDataType.String, 2),
        new JdeField("RLRRBDT1", "RLRRBDT1", JdeDataType.Numeric),
        new JdeField("RLRRBDT2", "RLRRBDT2", JdeDataType.Numeric),
        new JdeField("RLRRBDT3", "RLRRBDT3", JdeDataType.Numeric),
        new JdeField("RLRRBNU1", "RLRRBNU1", JdeDataType.Numeric),
        new JdeField("RLRRBNU2", "RLRRBNU2", JdeDataType.Numeric),
        new JdeField("RLRRBNU3", "RLRRBNU3", JdeDataType.Numeric),
        new JdeField("RLRRBST1", "RLRRBST1", JdeDataType.String, 160),
        new JdeField("RLRRBST2", "RLRRBST2", JdeDataType.String, 160),
        new JdeField("RLRRBST3", "RLRRBST3", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B117_0", "Primary Key on RLDCT, RLDOC, RLKCO, RLDGJ, RLJELN, RLLT, RLEXTL", new[] { "RLDCT", "RLDOC", "RLKCO", "RLDGJ", "RLJELN", "RLLT", "RLEXTL" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B117_2", "Index on RLKCO, RLDCT, RLDOC, RLLT", new[] { "RLKCO", "RLDCT", "RLDOC", "RLLT" }),
        new JdeIndex("F03B117_3", "Index on RLAID", new[] { "RLAID" }),
        new JdeIndex("F03B117_4", "Index on RLKCO, RLDCT, RLDOC, RLODGJ, RLOJELN, RLOEXTL", new[] { "RLKCO", "RLDCT", "RLDOC", "RLODGJ", "RLOJELN", "RLOEXTL" }),
        new JdeIndex("F03B117_5", "Index on RLKCO, RLDCT, RLDOC, RLDGJ, RLJELN, RLEXTL, RLLT, RLRRCOGS", new[] { "RLKCO", "RLDCT", "RLDOC", "RLDGJ", "RLJELN", "RLEXTL", "RLLT", "RLRRCOGS" }),
        new JdeIndex("F03B117_6", "Index on RLDCT, RLDOC, RLKCO, RLJELN, RLOJELN, RLLT, RLEXTL", new[] { "RLDCT", "RLDOC", "RLKCO", "RLJELN", "RLOJELN", "RLLT", "RLEXTL" }),
        new JdeIndex("F03B117_7", "Index on RLDCT, RLDOC, RLKCO, RLDGJ, RLJELN, RLEXTL, RLOJELN", new[] { "RLDCT", "RLDOC", "RLKCO", "RLDGJ", "RLJELN", "RLEXTL", "RLOJELN" })
    };
}
