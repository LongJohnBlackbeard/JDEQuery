using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1540B - .
/// </summary>
public class F1540B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NRDOCO.
        /// </summary>
        public const string NRDOCO = "NRDOCO";

        /// <summary>
        /// NRMCU.
        /// </summary>
        public const string NRMCU = "NRMCU";

        /// <summary>
        /// NRUNIT.
        /// </summary>
        public const string NRUNIT = "NRUNIT";

        /// <summary>
        /// NRDBAN.
        /// </summary>
        public const string NRDBAN = "NRDBAN";

        /// <summary>
        /// NRSTNR.
        /// </summary>
        public const string NRSTNR = "NRSTNR";

        /// <summary>
        /// NRAN8.
        /// </summary>
        public const string NRAN8 = "NRAN8";

        /// <summary>
        /// NRPRDC.
        /// </summary>
        public const string NRPRDC = "NRPRDC";

        /// <summary>
        /// NRLIN.
        /// </summary>
        public const string NRLIN = "NRLIN";

        /// <summary>
        /// NRRPRD.
        /// </summary>
        public const string NRRPRD = "NRRPRD";

        /// <summary>
        /// NRYR.
        /// </summary>
        public const string NRYR = "NRYR";

        /// <summary>
        /// NRCTRY.
        /// </summary>
        public const string NRCTRY = "NRCTRY";

        /// <summary>
        /// NRRPFC.
        /// </summary>
        public const string NRRPFC = "NRRPFC";

        /// <summary>
        /// NRSOSS.
        /// </summary>
        public const string NRSOSS = "NRSOSS";

        /// <summary>
        /// NRULI.
        /// </summary>
        public const string NRULI = "NRULI";

        /// <summary>
        /// NRPSLS.
        /// </summary>
        public const string NRPSLS = "NRPSLS";

        /// <summary>
        /// NRULI2.
        /// </summary>
        public const string NRULI2 = "NRULI2";

        /// <summary>
        /// NRSUSA.
        /// </summary>
        public const string NRSUSA = "NRSUSA";

        /// <summary>
        /// NRDTRT.
        /// </summary>
        public const string NRDTRT = "NRDTRT";

        /// <summary>
        /// NRDCTO.
        /// </summary>
        public const string NRDCTO = "NRDCTO";

        /// <summary>
        /// NRDTSR.
        /// </summary>
        public const string NRDTSR = "NRDTSR";

        /// <summary>
        /// NRICU.
        /// </summary>
        public const string NRICU = "NRICU";

        /// <summary>
        /// NRICUT.
        /// </summary>
        public const string NRICUT = "NRICUT";

        /// <summary>
        /// NRDIC.
        /// </summary>
        public const string NRDIC = "NRDIC";

        /// <summary>
        /// NRANRP.
        /// </summary>
        public const string NRANRP = "NRANRP";

        /// <summary>
        /// NRSOIC.
        /// </summary>
        public const string NRSOIC = "NRSOIC";

        /// <summary>
        /// NRSRTY.
        /// </summary>
        public const string NRSRTY = "NRSRTY";

        /// <summary>
        /// NRPROL.
        /// </summary>
        public const string NRPROL = "NRPROL";

        /// <summary>
        /// NRU.
        /// </summary>
        public const string NRU = "NRU";

        /// <summary>
        /// NRDL01.
        /// </summary>
        public const string NRDL01 = "NRDL01";

        /// <summary>
        /// NRSADJ.
        /// </summary>
        public const string NRSADJ = "NRSADJ";

        /// <summary>
        /// NRSATY.
        /// </summary>
        public const string NRSATY = "NRSATY";

        /// <summary>
        /// NRMCUS.
        /// </summary>
        public const string NRMCUS = "NRMCUS";

        /// <summary>
        /// NRDSLD.
        /// </summary>
        public const string NRDSLD = "NRDSLD";

        /// <summary>
        /// NRLTRC.
        /// </summary>
        public const string NRLTRC = "NRLTRC";

        /// <summary>
        /// NRDLTR.
        /// </summary>
        public const string NRDLTR = "NRDLTR";

        /// <summary>
        /// NRRM11.
        /// </summary>
        public const string NRRM11 = "NRRM11";

        /// <summary>
        /// NRRM12.
        /// </summary>
        public const string NRRM12 = "NRRM12";

        /// <summary>
        /// NRRM13.
        /// </summary>
        public const string NRRM13 = "NRRM13";

        /// <summary>
        /// NRRM14.
        /// </summary>
        public const string NRRM14 = "NRRM14";

        /// <summary>
        /// NRRM15.
        /// </summary>
        public const string NRRM15 = "NRRM15";

        /// <summary>
        /// NRRM21.
        /// </summary>
        public const string NRRM21 = "NRRM21";

        /// <summary>
        /// NRRM22.
        /// </summary>
        public const string NRRM22 = "NRRM22";

        /// <summary>
        /// NRRM23.
        /// </summary>
        public const string NRRM23 = "NRRM23";

        /// <summary>
        /// NRRM24.
        /// </summary>
        public const string NRRM24 = "NRRM24";

        /// <summary>
        /// NRRM25.
        /// </summary>
        public const string NRRM25 = "NRRM25";

        /// <summary>
        /// NRBCRC.
        /// </summary>
        public const string NRBCRC = "NRBCRC";

        /// <summary>
        /// NRCRRM.
        /// </summary>
        public const string NRCRRM = "NRCRRM";

        /// <summary>
        /// NRACR.
        /// </summary>
        public const string NRACR = "NRACR";

        /// <summary>
        /// NRCRR.
        /// </summary>
        public const string NRCRR = "NRCRR";

        /// <summary>
        /// NRDMCD.
        /// </summary>
        public const string NRDMCD = "NRDMCD";

        /// <summary>
        /// NRCRCD.
        /// </summary>
        public const string NRCRCD = "NRCRCD";

        /// <summary>
        /// NRCTXA.
        /// </summary>
        public const string NRCTXA = "NRCTXA";

        /// <summary>
        /// NRCTXN.
        /// </summary>
        public const string NRCTXN = "NRCTXN";

        /// <summary>
        /// NRCTAM.
        /// </summary>
        public const string NRCTAM = "NRCTAM";

        /// <summary>
        /// NRCRCX.
        /// </summary>
        public const string NRCRCX = "NRCRCX";

        /// <summary>
        /// NRCRYR.
        /// </summary>
        public const string NRCRYR = "NRCRYR";

        /// <summary>
        /// NRURCD.
        /// </summary>
        public const string NRURCD = "NRURCD";

        /// <summary>
        /// NRURDT.
        /// </summary>
        public const string NRURDT = "NRURDT";

        /// <summary>
        /// NRURAT.
        /// </summary>
        public const string NRURAT = "NRURAT";

        /// <summary>
        /// NRURRF.
        /// </summary>
        public const string NRURRF = "NRURRF";

        /// <summary>
        /// NRUSER.
        /// </summary>
        public const string NRUSER = "NRUSER";

        /// <summary>
        /// NRPID.
        /// </summary>
        public const string NRPID = "NRPID";

        /// <summary>
        /// NRUPMJ.
        /// </summary>
        public const string NRUPMJ = "NRUPMJ";

        /// <summary>
        /// NRUPMT.
        /// </summary>
        public const string NRUPMT = "NRUPMT";

        /// <summary>
        /// NRJOBN.
        /// </summary>
        public const string NRJOBN = "NRJOBN";

        /// <summary>
        /// NRENTJ.
        /// </summary>
        public const string NRENTJ = "NRENTJ";

        /// <summary>
        /// NRTORG.
        /// </summary>
        public const string NRTORG = "NRTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F1540B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NRDOCO", "NRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NRMCU", "NRMCU", JdeDataType.String, 24, true, true),
        new JdeField("NRUNIT", "NRUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NRDBAN", "NRDBAN", JdeDataType.Numeric, null, true, true),
        new JdeField("NRSTNR", "NRSTNR", JdeDataType.String, 20, true, true),
        new JdeField("NRAN8", "NRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NRPRDC", "NRPRDC", JdeDataType.String, 8, true, true),
        new JdeField("NRLIN", "NRLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("NRRPRD", "NRRPRD", JdeDataType.Numeric, null, true, true),
        new JdeField("NRYR", "NRYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NRCTRY", "NRCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("NRRPFC", "NRRPFC", JdeDataType.String, 2),
        new JdeField("NRSOSS", "NRSOSS", JdeDataType.String, 2),
        new JdeField("NRULI", "NRULI", JdeDataType.String, 16),
        new JdeField("NRPSLS", "NRPSLS", JdeDataType.Numeric),
        new JdeField("NRULI2", "NRULI2", JdeDataType.String, 16),
        new JdeField("NRSUSA", "NRSUSA", JdeDataType.Numeric),
        new JdeField("NRDTRT", "NRDTRT", JdeDataType.Numeric),
        new JdeField("NRDCTO", "NRDCTO", JdeDataType.String, 4),
        new JdeField("NRDTSR", "NRDTSR", JdeDataType.Numeric),
        new JdeField("NRICU", "NRICU", JdeDataType.Numeric),
        new JdeField("NRICUT", "NRICUT", JdeDataType.String, 4),
        new JdeField("NRDIC", "NRDIC", JdeDataType.Numeric),
        new JdeField("NRANRP", "NRANRP", JdeDataType.String, 2),
        new JdeField("NRSOIC", "NRSOIC", JdeDataType.String, 2),
        new JdeField("NRSRTY", "NRSRTY", JdeDataType.String, 2),
        new JdeField("NRPROL", "NRPROL", JdeDataType.String, 2),
        new JdeField("NRU", "NRU", JdeDataType.Numeric),
        new JdeField("NRDL01", "NRDL01", JdeDataType.String, 60),
        new JdeField("NRSADJ", "NRSADJ", JdeDataType.String, 2),
        new JdeField("NRSATY", "NRSATY", JdeDataType.String, 2),
        new JdeField("NRMCUS", "NRMCUS", JdeDataType.String, 24),
        new JdeField("NRDSLD", "NRDSLD", JdeDataType.Numeric),
        new JdeField("NRLTRC", "NRLTRC", JdeDataType.String, 4),
        new JdeField("NRDLTR", "NRDLTR", JdeDataType.Numeric),
        new JdeField("NRRM11", "NRRM11", JdeDataType.String, 8),
        new JdeField("NRRM12", "NRRM12", JdeDataType.String, 8),
        new JdeField("NRRM13", "NRRM13", JdeDataType.String, 8),
        new JdeField("NRRM14", "NRRM14", JdeDataType.String, 8),
        new JdeField("NRRM15", "NRRM15", JdeDataType.String, 8),
        new JdeField("NRRM21", "NRRM21", JdeDataType.String, 8),
        new JdeField("NRRM22", "NRRM22", JdeDataType.String, 8),
        new JdeField("NRRM23", "NRRM23", JdeDataType.String, 8),
        new JdeField("NRRM24", "NRRM24", JdeDataType.String, 8),
        new JdeField("NRRM25", "NRRM25", JdeDataType.String, 8),
        new JdeField("NRBCRC", "NRBCRC", JdeDataType.String, 6),
        new JdeField("NRCRRM", "NRCRRM", JdeDataType.String, 2),
        new JdeField("NRACR", "NRACR", JdeDataType.Numeric),
        new JdeField("NRCRR", "NRCRR", JdeDataType.Numeric),
        new JdeField("NRDMCD", "NRDMCD", JdeDataType.String, 2),
        new JdeField("NRCRCD", "NRCRCD", JdeDataType.String, 6),
        new JdeField("NRCTXA", "NRCTXA", JdeDataType.Numeric),
        new JdeField("NRCTXN", "NRCTXN", JdeDataType.Numeric),
        new JdeField("NRCTAM", "NRCTAM", JdeDataType.Numeric),
        new JdeField("NRCRCX", "NRCRCX", JdeDataType.String, 6),
        new JdeField("NRCRYR", "NRCRYR", JdeDataType.String, 2),
        new JdeField("NRURCD", "NRURCD", JdeDataType.String, 4),
        new JdeField("NRURDT", "NRURDT", JdeDataType.Numeric),
        new JdeField("NRURAT", "NRURAT", JdeDataType.Numeric),
        new JdeField("NRURRF", "NRURRF", JdeDataType.String, 30),
        new JdeField("NRUSER", "NRUSER", JdeDataType.String, 20),
        new JdeField("NRPID", "NRPID", JdeDataType.String, 20),
        new JdeField("NRUPMJ", "NRUPMJ", JdeDataType.Numeric),
        new JdeField("NRUPMT", "NRUPMT", JdeDataType.Numeric),
        new JdeField("NRJOBN", "NRJOBN", JdeDataType.String, 20),
        new JdeField("NRENTJ", "NRENTJ", JdeDataType.Numeric),
        new JdeField("NRTORG", "NRTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1540B_0", "Primary Key on NRDOCO, NRMCU, NRUNIT, NRAN8, NRDBAN, NRPRDC, NRLIN, NRSTNR, NRCTRY, NRYR, NRRPRD", new[] { "NRDOCO", "NRMCU", "NRUNIT", "NRAN8", "NRDBAN", "NRPRDC", "NRLIN", "NRSTNR", "NRCTRY", "NRYR", "NRRPRD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1540B_10", "Index on NRDOCO, NRMCU, NRPRDC, NRCTRY, NRYR, NRRPRD, NRUNIT, NRDBAN, NRSTNR", new[] { "NRDOCO", "NRMCU", "NRPRDC", "NRCTRY", "NRYR", "NRRPRD", "NRUNIT", "NRDBAN", "NRSTNR" }),
        new JdeIndex("F1540B_4", "Index on NRICU, NRDOCO", new[] { "NRICU", "NRDOCO" }),
        new JdeIndex("F1540B_5", "Index on NRICU, NRDOCO, NRMCU, NRPRDC", new[] { "NRICU", "NRDOCO", "NRMCU", "NRPRDC" }),
        new JdeIndex("F1540B_7", "Index on NRDOCO, NRMCU, NRPRDC", new[] { "NRDOCO", "NRMCU", "NRPRDC" }),
        new JdeIndex("F1540B_8", "Index on NRDOCO, NRPRDC, NRMCU, NRUNIT, NRDBAN, NRSTNR", new[] { "NRDOCO", "NRPRDC", "NRMCU", "NRUNIT", "NRDBAN", "NRSTNR" }),
        new JdeIndex("F1540B_9", "Index on NRDOCO, NRDBAN, NRSTNR, NRPRDC, NRMCU", new[] { "NRDOCO", "NRDBAN", "NRSTNR", "NRPRDC", "NRMCU" })
    };
}
