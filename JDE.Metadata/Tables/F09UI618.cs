using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI618 - .
/// </summary>
public class F09UI618 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NBBSTN.
        /// </summary>
        public const string NBBSTN = "NBBSTN";

        /// <summary>
        /// NBGLBA.
        /// </summary>
        public const string NBGLBA = "NBGLBA";

        /// <summary>
        /// NBSTMD.
        /// </summary>
        public const string NBSTMD = "NBSTMD";

        /// <summary>
        /// NBLIN.
        /// </summary>
        public const string NBLIN = "NBLIN";

        /// <summary>
        /// NBSTRN.
        /// </summary>
        public const string NBSTRN = "NBSTRN";

        /// <summary>
        /// NBSTLIN.
        /// </summary>
        public const string NBSTLIN = "NBSTLIN";

        /// <summary>
        /// NBBSSEQ.
        /// </summary>
        public const string NBBSSEQ = "NBBSSEQ";

        /// <summary>
        /// NBBAN.
        /// </summary>
        public const string NBBAN = "NBBAN";

        /// <summary>
        /// NBAN8.
        /// </summary>
        public const string NBAN8 = "NBAN8";

        /// <summary>
        /// NBCONSOL.
        /// </summary>
        public const string NBCONSOL = "NBCONSOL";

        /// <summary>
        /// NBBCAA.
        /// </summary>
        public const string NBBCAA = "NBBCAA";

        /// <summary>
        /// NBGLIAA.
        /// </summary>
        public const string NBGLIAA = "NBGLIAA";

        /// <summary>
        /// NBDIFFAA.
        /// </summary>
        public const string NBDIFFAA = "NBDIFFAA";

        /// <summary>
        /// NBBCDT.
        /// </summary>
        public const string NBBCDT = "NBBCDT";

        /// <summary>
        /// NBGLIDT.
        /// </summary>
        public const string NBGLIDT = "NBGLIDT";

        /// <summary>
        /// NBDESC.
        /// </summary>
        public const string NBDESC = "NBDESC";

        /// <summary>
        /// NBTRANT.
        /// </summary>
        public const string NBTRANT = "NBTRANT";

        /// <summary>
        /// NBRCUC.
        /// </summary>
        public const string NBRCUC = "NBRCUC";

        /// <summary>
        /// NBICU.
        /// </summary>
        public const string NBICU = "NBICU";

        /// <summary>
        /// NBICUT.
        /// </summary>
        public const string NBICUT = "NBICUT";

        /// <summary>
        /// NBNBF.
        /// </summary>
        public const string NBNBF = "NBNBF";

        /// <summary>
        /// NBAA.
        /// </summary>
        public const string NBAA = "NBAA";

        /// <summary>
        /// NBCSTSPFLG.
        /// </summary>
        public const string NBCSTSPFLG = "NBCSTSPFLG";

        /// <summary>
        /// NBBACRCD.
        /// </summary>
        public const string NBBACRCD = "NBBACRCD";

        /// <summary>
        /// NBR1.
        /// </summary>
        public const string NBR1 = "NBR1";

        /// <summary>
        /// NBR3.
        /// </summary>
        public const string NBR3 = "NBR3";

        /// <summary>
        /// NB09DCF.
        /// </summary>
        public const string NB09DCF = "NB09DCF";

        /// <summary>
        /// NBADCC.
        /// </summary>
        public const string NBADCC = "NBADCC";

        /// <summary>
        /// NBABRF.
        /// </summary>
        public const string NBABRF = "NBABRF";

        /// <summary>
        /// NBCAPFLG.
        /// </summary>
        public const string NBCAPFLG = "NBCAPFLG";

        /// <summary>
        /// NBRCPTFLG.
        /// </summary>
        public const string NBRCPTFLG = "NBRCPTFLG";

        /// <summary>
        /// NBRECCODE.
        /// </summary>
        public const string NBRECCODE = "NBRECCODE";

        /// <summary>
        /// NBREASCODE.
        /// </summary>
        public const string NBREASCODE = "NBREASCODE";

        /// <summary>
        /// NBCUSTSUP.
        /// </summary>
        public const string NBCUSTSUP = "NBCUSTSUP";

        /// <summary>
        /// NBFLG01.
        /// </summary>
        public const string NBFLG01 = "NBFLG01";

        /// <summary>
        /// NBFLG02.
        /// </summary>
        public const string NBFLG02 = "NBFLG02";

        /// <summary>
        /// NBRCOUNT.
        /// </summary>
        public const string NBRCOUNT = "NBRCOUNT";

        /// <summary>
        /// NBJOBS.
        /// </summary>
        public const string NBJOBS = "NBJOBS";

        /// <summary>
        /// NBUCOUNT.
        /// </summary>
        public const string NBUCOUNT = "NBUCOUNT";

        /// <summary>
        /// NBUSER.
        /// </summary>
        public const string NBUSER = "NBUSER";

        /// <summary>
        /// NBPID.
        /// </summary>
        public const string NBPID = "NBPID";

        /// <summary>
        /// NBJOBN.
        /// </summary>
        public const string NBJOBN = "NBJOBN";

        /// <summary>
        /// NBUPMT.
        /// </summary>
        public const string NBUPMT = "NBUPMT";

        /// <summary>
        /// NBUPMJ.
        /// </summary>
        public const string NBUPMJ = "NBUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI618";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NBBSTN", "NBBSTN", JdeDataType.Numeric, null, true, true),
        new JdeField("NBGLBA", "NBGLBA", JdeDataType.String, 16, true, true),
        new JdeField("NBSTMD", "NBSTMD", JdeDataType.Numeric, null, true, true),
        new JdeField("NBLIN", "NBLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("NBSTRN", "NBSTRN", JdeDataType.String, 6),
        new JdeField("NBSTLIN", "NBSTLIN", JdeDataType.Numeric),
        new JdeField("NBBSSEQ", "NBBSSEQ", JdeDataType.Numeric),
        new JdeField("NBBAN", "NBBAN", JdeDataType.String, 58),
        new JdeField("NBAN8", "NBAN8", JdeDataType.Numeric),
        new JdeField("NBCONSOL", "NBCONSOL", JdeDataType.String, 2),
        new JdeField("NBBCAA", "NBBCAA", JdeDataType.Numeric),
        new JdeField("NBGLIAA", "NBGLIAA", JdeDataType.Numeric),
        new JdeField("NBDIFFAA", "NBDIFFAA", JdeDataType.Numeric),
        new JdeField("NBBCDT", "NBBCDT", JdeDataType.Numeric),
        new JdeField("NBGLIDT", "NBGLIDT", JdeDataType.Numeric),
        new JdeField("NBDESC", "NBDESC", JdeDataType.String, 60),
        new JdeField("NBTRANT", "NBTRANT", JdeDataType.String, 8),
        new JdeField("NBRCUC", "NBRCUC", JdeDataType.String, 2),
        new JdeField("NBICU", "NBICU", JdeDataType.Numeric),
        new JdeField("NBICUT", "NBICUT", JdeDataType.String, 4),
        new JdeField("NBNBF", "NBNBF", JdeDataType.String, 2),
        new JdeField("NBAA", "NBAA", JdeDataType.Numeric),
        new JdeField("NBCSTSPFLG", "NBCSTSPFLG", JdeDataType.String, 2),
        new JdeField("NBBACRCD", "NBBACRCD", JdeDataType.String, 6),
        new JdeField("NBR1", "NBR1", JdeDataType.String, 16),
        new JdeField("NBR3", "NBR3", JdeDataType.String, 16),
        new JdeField("NB09DCF", "NB09DCF", JdeDataType.String, 2),
        new JdeField("NBADCC", "NBADCC", JdeDataType.String, 2),
        new JdeField("NBABRF", "NBABRF", JdeDataType.String, 2),
        new JdeField("NBCAPFLG", "NBCAPFLG", JdeDataType.String, 2),
        new JdeField("NBRCPTFLG", "NBRCPTFLG", JdeDataType.String, 2),
        new JdeField("NBRECCODE", "NBRECCODE", JdeDataType.String, 2),
        new JdeField("NBREASCODE", "NBREASCODE", JdeDataType.String, 6),
        new JdeField("NBCUSTSUP", "NBCUSTSUP", JdeDataType.Numeric),
        new JdeField("NBFLG01", "NBFLG01", JdeDataType.String, 2),
        new JdeField("NBFLG02", "NBFLG02", JdeDataType.String, 2),
        new JdeField("NBRCOUNT", "NBRCOUNT", JdeDataType.Numeric),
        new JdeField("NBJOBS", "NBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("NBUCOUNT", "NBUCOUNT", JdeDataType.Numeric),
        new JdeField("NBUSER", "NBUSER", JdeDataType.String, 20, true, true),
        new JdeField("NBPID", "NBPID", JdeDataType.String, 20),
        new JdeField("NBJOBN", "NBJOBN", JdeDataType.String, 20),
        new JdeField("NBUPMT", "NBUPMT", JdeDataType.Numeric),
        new JdeField("NBUPMJ", "NBUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI618_0", "Primary Key on NBBSTN, NBGLBA, NBSTMD, NBLIN, NBUSER, NBJOBS", new[] { "NBBSTN", "NBGLBA", "NBSTMD", "NBLIN", "NBUSER", "NBJOBS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09UI618_2", "Index on NBBSTN, NBGLBA, NBJOBS, NBUSER, SYS_NC00045$", new[] { "NBBSTN", "NBGLBA", "NBJOBS", "NBUSER", "SYS_NC00045$" }),
        new JdeIndex("F09UI618_3", "Index on NBBSTN, NBGLBA, NBSTMD, NBUSER, NBJOBS, NBRCUC", new[] { "NBBSTN", "NBGLBA", "NBSTMD", "NBUSER", "NBJOBS", "NBRCUC" }),
        new JdeIndex("F09UI618_4", "Index on NBBSTN, NBGLBA, NBSTMD, NBICUT, NBICU, NBUSER, NBJOBS", new[] { "NBBSTN", "NBGLBA", "NBSTMD", "NBICUT", "NBICU", "NBUSER", "NBJOBS" }),
        new JdeIndex("F09UI618_5", "Index on NBBSTN, NBGLBA, NBSTMD, NBUSER, NBJOBS, NBABRF", new[] { "NBBSTN", "NBGLBA", "NBSTMD", "NBUSER", "NBJOBS", "NBABRF" })
    };
}
