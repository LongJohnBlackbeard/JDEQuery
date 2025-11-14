using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470372 - .
/// </summary>
public class F470372 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIEDTY.
        /// </summary>
        public const string AIEDTY = "AIEDTY";

        /// <summary>
        /// AIEDSQ.
        /// </summary>
        public const string AIEDSQ = "AIEDSQ";

        /// <summary>
        /// AIEKCO.
        /// </summary>
        public const string AIEKCO = "AIEKCO";

        /// <summary>
        /// AIEDOC.
        /// </summary>
        public const string AIEDOC = "AIEDOC";

        /// <summary>
        /// AIEDCT.
        /// </summary>
        public const string AIEDCT = "AIEDCT";

        /// <summary>
        /// AIEDLN.
        /// </summary>
        public const string AIEDLN = "AIEDLN";

        /// <summary>
        /// AIEDST.
        /// </summary>
        public const string AIEDST = "AIEDST";

        /// <summary>
        /// AIEDFT.
        /// </summary>
        public const string AIEDFT = "AIEDFT";

        /// <summary>
        /// AIEDDT.
        /// </summary>
        public const string AIEDDT = "AIEDDT";

        /// <summary>
        /// AIEDER.
        /// </summary>
        public const string AIEDER = "AIEDER";

        /// <summary>
        /// AIEDDL.
        /// </summary>
        public const string AIEDDL = "AIEDDL";

        /// <summary>
        /// AIEDSP.
        /// </summary>
        public const string AIEDSP = "AIEDSP";

        /// <summary>
        /// AIEDBT.
        /// </summary>
        public const string AIEDBT = "AIEDBT";

        /// <summary>
        /// AISTPC.
        /// </summary>
        public const string AISTPC = "AISTPC";

        /// <summary>
        /// AIANTY.
        /// </summary>
        public const string AIANTY = "AIANTY";

        /// <summary>
        /// AILINS.
        /// </summary>
        public const string AILINS = "AILINS";

        /// <summary>
        /// AICFGPID.
        /// </summary>
        public const string AICFGPID = "AICFGPID";

        /// <summary>
        /// AIASNRECID.
        /// </summary>
        public const string AIASNRECID = "AIASNRECID";

        /// <summary>
        /// AITHEOWT.
        /// </summary>
        public const string AITHEOWT = "AITHEOWT";

        /// <summary>
        /// AITHEOUOM.
        /// </summary>
        public const string AITHEOUOM = "AITHEOUOM";

        /// <summary>
        /// AICUMS.
        /// </summary>
        public const string AICUMS = "AICUMS";

        /// <summary>
        /// AIUOM.
        /// </summary>
        public const string AIUOM = "AIUOM";

        /// <summary>
        /// AIDKID.
        /// </summary>
        public const string AIDKID = "AIDKID";

        /// <summary>
        /// AIYEAR1.
        /// </summary>
        public const string AIYEAR1 = "AIYEAR1";

        /// <summary>
        /// AIUCARTNO.
        /// </summary>
        public const string AIUCARTNO = "AIUCARTNO";

        /// <summary>
        /// AIMFGORDNO.
        /// </summary>
        public const string AIMFGORDNO = "AIMFGORDNO";

        /// <summary>
        /// AICIRV.
        /// </summary>
        public const string AICIRV = "AICIRV";

        /// <summary>
        /// AIVINNO.
        /// </summary>
        public const string AIVINNO = "AIVINNO";

        /// <summary>
        /// AIVNPART.
        /// </summary>
        public const string AIVNPART = "AIVNPART";

        /// <summary>
        /// AIGCNT.
        /// </summary>
        public const string AIGCNT = "AIGCNT";

        /// <summary>
        /// AICSTORDNO.
        /// </summary>
        public const string AICSTORDNO = "AICSTORDNO";

        /// <summary>
        /// AISTLRELNO.
        /// </summary>
        public const string AISTLRELNO = "AISTLRELNO";

        /// <summary>
        /// AIVNORDNO.
        /// </summary>
        public const string AIVNORDNO = "AIVNORDNO";

        /// <summary>
        /// AIENGCTL.
        /// </summary>
        public const string AIENGCTL = "AIENGCTL";

        /// <summary>
        /// AIASBLNLOC.
        /// </summary>
        public const string AIASBLNLOC = "AIASBLNLOC";

        /// <summary>
        /// AIJOBSQ.
        /// </summary>
        public const string AIJOBSQ = "AIJOBSQ";

        /// <summary>
        /// AIENDJOBSQ.
        /// </summary>
        public const string AIENDJOBSQ = "AIENDJOBSQ";

        /// <summary>
        /// AIENGTAG1.
        /// </summary>
        public const string AIENGTAG1 = "AIENGTAG1";

        /// <summary>
        /// AIENGTAGR1.
        /// </summary>
        public const string AIENGTAGR1 = "AIENGTAGR1";

        /// <summary>
        /// AIENGTAG2.
        /// </summary>
        public const string AIENGTAG2 = "AIENGTAG2";

        /// <summary>
        /// AIENGTAGR2.
        /// </summary>
        public const string AIENGTAGR2 = "AIENGTAGR2";

        /// <summary>
        /// AIHZCLSNO.
        /// </summary>
        public const string AIHZCLSNO = "AIHZCLSNO";

        /// <summary>
        /// AIHEATNO.
        /// </summary>
        public const string AIHEATNO = "AIHEATNO";

        /// <summary>
        /// AIHL03.
        /// </summary>
        public const string AIHL03 = "AIHL03";

        /// <summary>
        /// AIHLVL.
        /// </summary>
        public const string AIHLVL = "AIHLVL";

        /// <summary>
        /// AIDMD06.
        /// </summary>
        public const string AIDMD06 = "AIDMD06";

        /// <summary>
        /// AIDMD07.
        /// </summary>
        public const string AIDMD07 = "AIDMD07";

        /// <summary>
        /// AIDMD08.
        /// </summary>
        public const string AIDMD08 = "AIDMD08";

        /// <summary>
        /// AIDMD09.
        /// </summary>
        public const string AIDMD09 = "AIDMD09";

        /// <summary>
        /// AIDMD10.
        /// </summary>
        public const string AIDMD10 = "AIDMD10";

        /// <summary>
        /// AIDMDREF1.
        /// </summary>
        public const string AIDMDREF1 = "AIDMDREF1";

        /// <summary>
        /// AIDMDREF2.
        /// </summary>
        public const string AIDMDREF2 = "AIDMDREF2";

        /// <summary>
        /// AIURCD.
        /// </summary>
        public const string AIURCD = "AIURCD";

        /// <summary>
        /// AIURDT.
        /// </summary>
        public const string AIURDT = "AIURDT";

        /// <summary>
        /// AIURAT.
        /// </summary>
        public const string AIURAT = "AIURAT";

        /// <summary>
        /// AIURAB.
        /// </summary>
        public const string AIURAB = "AIURAB";

        /// <summary>
        /// AIURRF.
        /// </summary>
        public const string AIURRF = "AIURRF";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AITDAY.
        /// </summary>
        public const string AITDAY = "AITDAY";

        /// <summary>
        /// AIPSJOBNO.
        /// </summary>
        public const string AIPSJOBNO = "AIPSJOBNO";

        /// <summary>
        /// AICIRVQ.
        /// </summary>
        public const string AICIRVQ = "AICIRVQ";

        /// <summary>
        /// AIDMDREF3.
        /// </summary>
        public const string AIDMDREF3 = "AIDMDREF3";

        /// <summary>
        /// AIDMDREF4.
        /// </summary>
        public const string AIDMDREF4 = "AIDMDREF4";

        /// <summary>
        /// AIDMDREF5.
        /// </summary>
        public const string AIDMDREF5 = "AIDMDREF5";

        /// <summary>
        /// AIDMDREF6.
        /// </summary>
        public const string AIDMDREF6 = "AIDMDREF6";

        /// <summary>
        /// AIDMDREF7.
        /// </summary>
        public const string AIDMDREF7 = "AIDMDREF7";

        /// <summary>
        /// AIDMDREF8.
        /// </summary>
        public const string AIDMDREF8 = "AIDMDREF8";

        /// <summary>
        /// AIDMDREF9.
        /// </summary>
        public const string AIDMDREF9 = "AIDMDREF9";

        /// <summary>
        /// AIDMDREF10.
        /// </summary>
        public const string AIDMDREF10 = "AIDMDREF10";

        /// <summary>
        /// AIASBNO.
        /// </summary>
        public const string AIASBNO = "AIASBNO";

        /// <summary>
        /// AIATMCN.
        /// </summary>
        public const string AIATMCN = "AIATMCN";

        /// <summary>
        /// AIRTORSQ.
        /// </summary>
        public const string AIRTORSQ = "AIRTORSQ";

        /// <summary>
        /// AIRTGDAT.
        /// </summary>
        public const string AIRTGDAT = "AIRTGDAT";

        /// <summary>
        /// AIRTGTIM.
        /// </summary>
        public const string AIRTGTIM = "AIRTGTIM";

        /// <summary>
        /// AIKBSNO.
        /// </summary>
        public const string AIKBSNO = "AIKBSNO";

        /// <summary>
        /// AIKBENO.
        /// </summary>
        public const string AIKBENO = "AIKBENO";
    }

    /// <inheritdoc />
    public override string TableName => "F470372";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIEDTY", "AIEDTY", JdeDataType.String, 2),
        new JdeField("AIEDSQ", "AIEDSQ", JdeDataType.Numeric),
        new JdeField("AIEKCO", "AIEKCO", JdeDataType.String, 10, true, true),
        new JdeField("AIEDOC", "AIEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AIEDCT", "AIEDCT", JdeDataType.String, 4, true, true),
        new JdeField("AIEDLN", "AIEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("AIEDST", "AIEDST", JdeDataType.String, 12),
        new JdeField("AIEDFT", "AIEDFT", JdeDataType.String, 20),
        new JdeField("AIEDDT", "AIEDDT", JdeDataType.Numeric),
        new JdeField("AIEDER", "AIEDER", JdeDataType.String, 2),
        new JdeField("AIEDDL", "AIEDDL", JdeDataType.Numeric),
        new JdeField("AIEDSP", "AIEDSP", JdeDataType.String, 2),
        new JdeField("AIEDBT", "AIEDBT", JdeDataType.String, 30),
        new JdeField("AISTPC", "AISTPC", JdeDataType.String, 2, true, true),
        new JdeField("AIANTY", "AIANTY", JdeDataType.String, 2, true, true),
        new JdeField("AILINS", "AILINS", JdeDataType.Numeric, null, true, true),
        new JdeField("AICFGPID", "AICFGPID", JdeDataType.Numeric),
        new JdeField("AIASNRECID", "AIASNRECID", JdeDataType.Numeric),
        new JdeField("AITHEOWT", "AITHEOWT", JdeDataType.Numeric),
        new JdeField("AITHEOUOM", "AITHEOUOM", JdeDataType.String, 4),
        new JdeField("AICUMS", "AICUMS", JdeDataType.Numeric),
        new JdeField("AIUOM", "AIUOM", JdeDataType.String, 4),
        new JdeField("AIDKID", "AIDKID", JdeDataType.String, 40),
        new JdeField("AIYEAR1", "AIYEAR1", JdeDataType.Numeric),
        new JdeField("AIUCARTNO", "AIUCARTNO", JdeDataType.String, 30),
        new JdeField("AIMFGORDNO", "AIMFGORDNO", JdeDataType.String, 60),
        new JdeField("AICIRV", "AICIRV", JdeDataType.String, 40),
        new JdeField("AIVINNO", "AIVINNO", JdeDataType.String, 40),
        new JdeField("AIVNPART", "AIVNPART", JdeDataType.String, 60),
        new JdeField("AIGCNT", "AIGCNT", JdeDataType.String, 24),
        new JdeField("AICSTORDNO", "AICSTORDNO", JdeDataType.String, 30),
        new JdeField("AISTLRELNO", "AISTLRELNO", JdeDataType.String, 60),
        new JdeField("AIVNORDNO", "AIVNORDNO", JdeDataType.String, 60),
        new JdeField("AIENGCTL", "AIENGCTL", JdeDataType.String, 60),
        new JdeField("AIASBLNLOC", "AIASBLNLOC", JdeDataType.String, 12),
        new JdeField("AIJOBSQ", "AIJOBSQ", JdeDataType.String, 30),
        new JdeField("AIENDJOBSQ", "AIENDJOBSQ", JdeDataType.String, 30),
        new JdeField("AIENGTAG1", "AIENGTAG1", JdeDataType.String, 30),
        new JdeField("AIENGTAGR1", "AIENGTAGR1", JdeDataType.String, 4),
        new JdeField("AIENGTAG2", "AIENGTAG2", JdeDataType.String, 30),
        new JdeField("AIENGTAGR2", "AIENGTAGR2", JdeDataType.String, 4),
        new JdeField("AIHZCLSNO", "AIHZCLSNO", JdeDataType.String, 30),
        new JdeField("AIHEATNO", "AIHEATNO", JdeDataType.String, 32),
        new JdeField("AIHL03", "AIHL03", JdeDataType.String, 4),
        new JdeField("AIHLVL", "AIHLVL", JdeDataType.Numeric),
        new JdeField("AIDMD06", "AIDMD06", JdeDataType.String, 6),
        new JdeField("AIDMD07", "AIDMD07", JdeDataType.String, 6),
        new JdeField("AIDMD08", "AIDMD08", JdeDataType.String, 6),
        new JdeField("AIDMD09", "AIDMD09", JdeDataType.String, 6),
        new JdeField("AIDMD10", "AIDMD10", JdeDataType.String, 6),
        new JdeField("AIDMDREF1", "AIDMDREF1", JdeDataType.String, 70),
        new JdeField("AIDMDREF2", "AIDMDREF2", JdeDataType.String, 70),
        new JdeField("AIURCD", "AIURCD", JdeDataType.String, 4),
        new JdeField("AIURDT", "AIURDT", JdeDataType.Numeric),
        new JdeField("AIURAT", "AIURAT", JdeDataType.Numeric),
        new JdeField("AIURAB", "AIURAB", JdeDataType.Numeric),
        new JdeField("AIURRF", "AIURRF", JdeDataType.String, 30),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AITDAY", "AITDAY", JdeDataType.Numeric),
        new JdeField("AIPSJOBNO", "AIPSJOBNO", JdeDataType.String, 30),
        new JdeField("AICIRVQ", "AICIRVQ", JdeDataType.String, 4),
        new JdeField("AIDMDREF3", "AIDMDREF3", JdeDataType.String, 70),
        new JdeField("AIDMDREF4", "AIDMDREF4", JdeDataType.String, 70),
        new JdeField("AIDMDREF5", "AIDMDREF5", JdeDataType.String, 70),
        new JdeField("AIDMDREF6", "AIDMDREF6", JdeDataType.String, 70),
        new JdeField("AIDMDREF7", "AIDMDREF7", JdeDataType.String, 70),
        new JdeField("AIDMDREF8", "AIDMDREF8", JdeDataType.String, 70),
        new JdeField("AIDMDREF9", "AIDMDREF9", JdeDataType.String, 70),
        new JdeField("AIDMDREF10", "AIDMDREF10", JdeDataType.String, 70),
        new JdeField("AIASBNO", "AIASBNO", JdeDataType.String, 30),
        new JdeField("AIATMCN", "AIATMCN", JdeDataType.Numeric),
        new JdeField("AIRTORSQ", "AIRTORSQ", JdeDataType.String, 60),
        new JdeField("AIRTGDAT", "AIRTGDAT", JdeDataType.Numeric),
        new JdeField("AIRTGTIM", "AIRTGTIM", JdeDataType.Numeric),
        new JdeField("AIKBSNO", "AIKBSNO", JdeDataType.String, 30),
        new JdeField("AIKBENO", "AIKBENO", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470372_0", "Primary Key on AIEDOC, AIEDCT, AIEKCO, AISTPC, AIANTY, AILINS, AIEDLN", new[] { "AIEDOC", "AIEDCT", "AIEKCO", "AISTPC", "AIANTY", "AILINS", "AIEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F470372_2", "Index on AIEDOC, AIEDCT, AIEKCO, SYS_NC00080$", new[] { "AIEDOC", "AIEDCT", "AIEKCO", "SYS_NC00080$" }),
        new JdeIndex("F470372_3", "Index on AIEDOC, AIEDCT, AIEKCO, SYS_NC00081$", new[] { "AIEDOC", "AIEDCT", "AIEKCO", "SYS_NC00081$" })
    };
}
