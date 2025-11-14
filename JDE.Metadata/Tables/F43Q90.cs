using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q90 - .
/// </summary>
public class F43Q90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCUKID.
        /// </summary>
        public const string SCUKID = "SCUKID";

        /// <summary>
        /// SCRFXDT.
        /// </summary>
        public const string SCRFXDT = "SCRFXDT";

        /// <summary>
        /// SCRFIDT.
        /// </summary>
        public const string SCRFIDT = "SCRFIDT";

        /// <summary>
        /// SCAT1.
        /// </summary>
        public const string SCAT1 = "SCAT1";

        /// <summary>
        /// SCAT6.
        /// </summary>
        public const string SCAT6 = "SCAT6";

        /// <summary>
        /// SCNTYP.
        /// </summary>
        public const string SCNTYP = "SCNTYP";

        /// <summary>
        /// SCLOCN.
        /// </summary>
        public const string SCLOCN = "SCLOCN";

        /// <summary>
        /// SCSLNT.
        /// </summary>
        public const string SCSLNT = "SCSLNT";

        /// <summary>
        /// SCSTLT.
        /// </summary>
        public const string SCSTLT = "SCSTLT";

        /// <summary>
        /// SCNSLT.
        /// </summary>
        public const string SCNSLT = "SCNSLT";

        /// <summary>
        /// SCDEFTIME.
        /// </summary>
        public const string SCDEFTIME = "SCDEFTIME";

        /// <summary>
        /// SCDEFMSRE.
        /// </summary>
        public const string SCDEFMSRE = "SCDEFMSRE";

        /// <summary>
        /// SCEVTDEF.
        /// </summary>
        public const string SCEVTDEF = "SCEVTDEF";

        /// <summary>
        /// SCEVTMSRE.
        /// </summary>
        public const string SCEVTMSRE = "SCEVTMSRE";

        /// <summary>
        /// SCEVTEND.
        /// </summary>
        public const string SCEVTEND = "SCEVTEND";

        /// <summary>
        /// SCENDMSRE.
        /// </summary>
        public const string SCENDMSRE = "SCENDMSRE";

        /// <summary>
        /// SCBIDQNIF.
        /// </summary>
        public const string SCBIDQNIF = "SCBIDQNIF";

        /// <summary>
        /// SCEDITRESP.
        /// </summary>
        public const string SCEDITRESP = "SCEDITRESP";

        /// <summary>
        /// SCEDITXTS.
        /// </summary>
        public const string SCEDITXTS = "SCEDITXTS";

        /// <summary>
        /// SCBROAL.
        /// </summary>
        public const string SCBROAL = "SCBROAL";

        /// <summary>
        /// SCBMBSP.
        /// </summary>
        public const string SCBMBSP = "SCBMBSP";

        /// <summary>
        /// SCCBORPO.
        /// </summary>
        public const string SCCBORPO = "SCCBORPO";

        /// <summary>
        /// SCDISBDHP.
        /// </summary>
        public const string SCDISBDHP = "SCDISBDHP";

        /// <summary>
        /// SCDBQW.
        /// </summary>
        public const string SCDBQW = "SCDBQW";

        /// <summary>
        /// SCDSPB.
        /// </summary>
        public const string SCDSPB = "SCDSPB";

        /// <summary>
        /// SCMBDA.
        /// </summary>
        public const string SCMBDA = "SCMBDA";

        /// <summary>
        /// SCRLQR.
        /// </summary>
        public const string SCRLQR = "SCRLQR";

        /// <summary>
        /// SCSEVT.
        /// </summary>
        public const string SCSEVT = "SCSEVT";

        /// <summary>
        /// SCSIOB.
        /// </summary>
        public const string SCSIOB = "SCSIOB";

        /// <summary>
        /// SCBROALRFI.
        /// </summary>
        public const string SCBROALRFI = "SCBROALRFI";

        /// <summary>
        /// SCDBQWRFI.
        /// </summary>
        public const string SCDBQWRFI = "SCDBQWRFI";

        /// <summary>
        /// SCDBHPRFI.
        /// </summary>
        public const string SCDBHPRFI = "SCDBHPRFI";

        /// <summary>
        /// SCEDTRSRFI.
        /// </summary>
        public const string SCEDTRSRFI = "SCEDTRSRFI";

        /// <summary>
        /// SCEDTXTRFI.
        /// </summary>
        public const string SCEDTXTRFI = "SCEDTXTRFI";

        /// <summary>
        /// SCSCREVENT.
        /// </summary>
        public const string SCSCREVENT = "SCSCREVENT";

        /// <summary>
        /// SCCDTYLS.
        /// </summary>
        public const string SCCDTYLS = "SCCDTYLS";

        /// <summary>
        /// SCSYSEEDA.
        /// </summary>
        public const string SCSYSEEDA = "SCSYSEEDA";

        /// <summary>
        /// SCPBIDCOD.
        /// </summary>
        public const string SCPBIDCOD = "SCPBIDCOD";

        /// <summary>
        /// SCDISABDS.
        /// </summary>
        public const string SCDISABDS = "SCDISABDS";

        /// <summary>
        /// SCSHOWDTLS.
        /// </summary>
        public const string SCSHOWDTLS = "SCSHOWDTLS";

        /// <summary>
        /// SCDISPBID.
        /// </summary>
        public const string SCDISPBID = "SCDISPBID";

        /// <summary>
        /// SCDISPTOTL.
        /// </summary>
        public const string SCDISPTOTL = "SCDISPTOTL";

        /// <summary>
        /// SCDISPQUES.
        /// </summary>
        public const string SCDISPQUES = "SCDISPQUES";

        /// <summary>
        /// SCBIDURL.
        /// </summary>
        public const string SCBIDURL = "SCBIDURL";

        /// <summary>
        /// SCINVTCS.
        /// </summary>
        public const string SCINVTCS = "SCINVTCS";

        /// <summary>
        /// SCCRESMSG.
        /// </summary>
        public const string SCCRESMSG = "SCCRESMSG";

        /// <summary>
        /// SCCLESMSG.
        /// </summary>
        public const string SCCLESMSG = "SCCLESMSG";

        /// <summary>
        /// SCPESMSG.
        /// </summary>
        public const string SCPESMSG = "SCPESMSG";

        /// <summary>
        /// SCRESMSG.
        /// </summary>
        public const string SCRESMSG = "SCRESMSG";

        /// <summary>
        /// SCEESMSG.
        /// </summary>
        public const string SCEESMSG = "SCEESMSG";

        /// <summary>
        /// SCAESMSG.
        /// </summary>
        public const string SCAESMSG = "SCAESMSG";

        /// <summary>
        /// SCXESMSG.
        /// </summary>
        public const string SCXESMSG = "SCXESMSG";

        /// <summary>
        /// SCUBSMSG.
        /// </summary>
        public const string SCUBSMSG = "SCUBSMSG";

        /// <summary>
        /// SCPSMSG.
        /// </summary>
        public const string SCPSMSG = "SCPSMSG";

        /// <summary>
        /// SCBROLE.
        /// </summary>
        public const string SCBROLE = "SCBROLE";

        /// <summary>
        /// SCSROLE.
        /// </summary>
        public const string SCSROLE = "SCSROLE";

        /// <summary>
        /// SCURCD.
        /// </summary>
        public const string SCURCD = "SCURCD";

        /// <summary>
        /// SCURDT.
        /// </summary>
        public const string SCURDT = "SCURDT";

        /// <summary>
        /// SCURAT.
        /// </summary>
        public const string SCURAT = "SCURAT";

        /// <summary>
        /// SCURAB.
        /// </summary>
        public const string SCURAB = "SCURAB";

        /// <summary>
        /// SCURRF.
        /// </summary>
        public const string SCURRF = "SCURRF";

        /// <summary>
        /// SCTORG.
        /// </summary>
        public const string SCTORG = "SCTORG";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCTDAY.
        /// </summary>
        public const string SCTDAY = "SCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCUKID", "SCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCRFXDT", "SCRFXDT", JdeDataType.String, 4),
        new JdeField("SCRFIDT", "SCRFIDT", JdeDataType.String, 4),
        new JdeField("SCAT1", "SCAT1", JdeDataType.String, 6),
        new JdeField("SCAT6", "SCAT6", JdeDataType.String, 6),
        new JdeField("SCNTYP", "SCNTYP", JdeDataType.String, 6),
        new JdeField("SCLOCN", "SCLOCN", JdeDataType.String, 40),
        new JdeField("SCSLNT", "SCSLNT", JdeDataType.String, 4),
        new JdeField("SCSTLT", "SCSTLT", JdeDataType.String, 4),
        new JdeField("SCNSLT", "SCNSLT", JdeDataType.String, 4),
        new JdeField("SCDEFTIME", "SCDEFTIME", JdeDataType.Numeric),
        new JdeField("SCDEFMSRE", "SCDEFMSRE", JdeDataType.String, 4),
        new JdeField("SCEVTDEF", "SCEVTDEF", JdeDataType.Numeric),
        new JdeField("SCEVTMSRE", "SCEVTMSRE", JdeDataType.String, 4),
        new JdeField("SCEVTEND", "SCEVTEND", JdeDataType.Numeric),
        new JdeField("SCENDMSRE", "SCENDMSRE", JdeDataType.String, 4),
        new JdeField("SCBIDQNIF", "SCBIDQNIF", JdeDataType.Numeric),
        new JdeField("SCEDITRESP", "SCEDITRESP", JdeDataType.String, 2),
        new JdeField("SCEDITXTS", "SCEDITXTS", JdeDataType.String, 2),
        new JdeField("SCBROAL", "SCBROAL", JdeDataType.String, 2),
        new JdeField("SCBMBSP", "SCBMBSP", JdeDataType.String, 2),
        new JdeField("SCCBORPO", "SCCBORPO", JdeDataType.String, 4),
        new JdeField("SCDISBDHP", "SCDISBDHP", JdeDataType.String, 2),
        new JdeField("SCDBQW", "SCDBQW", JdeDataType.String, 2),
        new JdeField("SCDSPB", "SCDSPB", JdeDataType.String, 2),
        new JdeField("SCMBDA", "SCMBDA", JdeDataType.String, 2),
        new JdeField("SCRLQR", "SCRLQR", JdeDataType.String, 2),
        new JdeField("SCSEVT", "SCSEVT", JdeDataType.String, 2),
        new JdeField("SCSIOB", "SCSIOB", JdeDataType.String, 2),
        new JdeField("SCBROALRFI", "SCBROALRFI", JdeDataType.String, 2),
        new JdeField("SCDBQWRFI", "SCDBQWRFI", JdeDataType.String, 2),
        new JdeField("SCDBHPRFI", "SCDBHPRFI", JdeDataType.String, 2),
        new JdeField("SCEDTRSRFI", "SCEDTRSRFI", JdeDataType.String, 2),
        new JdeField("SCEDTXTRFI", "SCEDTXTRFI", JdeDataType.String, 2),
        new JdeField("SCSCREVENT", "SCSCREVENT", JdeDataType.String, 2),
        new JdeField("SCCDTYLS", "SCCDTYLS", JdeDataType.String, 4),
        new JdeField("SCSYSEEDA", "SCSYSEEDA", JdeDataType.Date),
        new JdeField("SCPBIDCOD", "SCPBIDCOD", JdeDataType.String, 36),
        new JdeField("SCDISABDS", "SCDISABDS", JdeDataType.String, 2),
        new JdeField("SCSHOWDTLS", "SCSHOWDTLS", JdeDataType.String, 2),
        new JdeField("SCDISPBID", "SCDISPBID", JdeDataType.String, 2),
        new JdeField("SCDISPTOTL", "SCDISPTOTL", JdeDataType.String, 2),
        new JdeField("SCDISPQUES", "SCDISPQUES", JdeDataType.String, 2),
        new JdeField("SCBIDURL", "SCBIDURL", JdeDataType.String, 512),
        new JdeField("SCINVTCS", "SCINVTCS", JdeDataType.String, 20),
        new JdeField("SCCRESMSG", "SCCRESMSG", JdeDataType.String, 20),
        new JdeField("SCCLESMSG", "SCCLESMSG", JdeDataType.String, 20),
        new JdeField("SCPESMSG", "SCPESMSG", JdeDataType.String, 20),
        new JdeField("SCRESMSG", "SCRESMSG", JdeDataType.String, 20),
        new JdeField("SCEESMSG", "SCEESMSG", JdeDataType.String, 20),
        new JdeField("SCAESMSG", "SCAESMSG", JdeDataType.String, 20),
        new JdeField("SCXESMSG", "SCXESMSG", JdeDataType.String, 20),
        new JdeField("SCUBSMSG", "SCUBSMSG", JdeDataType.String, 20),
        new JdeField("SCPSMSG", "SCPSMSG", JdeDataType.String, 20),
        new JdeField("SCBROLE", "SCBROLE", JdeDataType.String, 30),
        new JdeField("SCSROLE", "SCSROLE", JdeDataType.String, 30),
        new JdeField("SCURCD", "SCURCD", JdeDataType.String, 4),
        new JdeField("SCURDT", "SCURDT", JdeDataType.Numeric),
        new JdeField("SCURAT", "SCURAT", JdeDataType.Numeric),
        new JdeField("SCURAB", "SCURAB", JdeDataType.Numeric),
        new JdeField("SCURRF", "SCURRF", JdeDataType.String, 30),
        new JdeField("SCTORG", "SCTORG", JdeDataType.String, 20),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCTDAY", "SCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q90_0", "Primary Key on SCUKID", new[] { "SCUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
