using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R11 - .
/// </summary>
public class F40R11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DDUKID.
        /// </summary>
        public const string DDUKID = "DDUKID";

        /// <summary>
        /// DDDEID.
        /// </summary>
        public const string DDDEID = "DDDEID";

        /// <summary>
        /// DDMCU.
        /// </summary>
        public const string DDMCU = "DDMCU";

        /// <summary>
        /// DDAN8.
        /// </summary>
        public const string DDAN8 = "DDAN8";

        /// <summary>
        /// DDSHAN.
        /// </summary>
        public const string DDSHAN = "DDSHAN";

        /// <summary>
        /// DDDVAN.
        /// </summary>
        public const string DDDVAN = "DDDVAN";

        /// <summary>
        /// DDITM.
        /// </summary>
        public const string DDITM = "DDITM";

        /// <summary>
        /// DDDETYP.
        /// </summary>
        public const string DDDETYP = "DDDETYP";

        /// <summary>
        /// DDDEPER.
        /// </summary>
        public const string DDDEPER = "DDDEPER";

        /// <summary>
        /// DDCRTSOSTS.
        /// </summary>
        public const string DDCRTSOSTS = "DDCRTSOSTS";

        /// <summary>
        /// DDRLSNO.
        /// </summary>
        public const string DDRLSNO = "DDRLSNO";

        /// <summary>
        /// DDRLSDJ.
        /// </summary>
        public const string DDRLSDJ = "DDRLSDJ";

        /// <summary>
        /// DDRLSTM.
        /// </summary>
        public const string DDRLSTM = "DDRLSTM";

        /// <summary>
        /// DDRQSJ.
        /// </summary>
        public const string DDRQSJ = "DDRQSJ";

        /// <summary>
        /// DDERQSHPDJ.
        /// </summary>
        public const string DDERQSHPDJ = "DDERQSHPDJ";

        /// <summary>
        /// DDRSHT.
        /// </summary>
        public const string DDRSHT = "DDRSHT";

        /// <summary>
        /// DDRQSHPQTY.
        /// </summary>
        public const string DDRQSHPQTY = "DDRQSHPQTY";

        /// <summary>
        /// DDUOM.
        /// </summary>
        public const string DDUOM = "DDUOM";

        /// <summary>
        /// DDRSDJ.
        /// </summary>
        public const string DDRSDJ = "DDRSDJ";

        /// <summary>
        /// DDRSDT.
        /// </summary>
        public const string DDRSDT = "DDRSDT";

        /// <summary>
        /// DDHZED.
        /// </summary>
        public const string DDHZED = "DDHZED";

        /// <summary>
        /// DDHZSD.
        /// </summary>
        public const string DDHZSD = "DDHZSD";

        /// <summary>
        /// DDASBLNFD.
        /// </summary>
        public const string DDASBLNFD = "DDASBLNFD";

        /// <summary>
        /// DDASBLNLOC.
        /// </summary>
        public const string DDASBLNLOC = "DDASBLNLOC";

        /// <summary>
        /// DDASBNO.
        /// </summary>
        public const string DDASBNO = "DDASBNO";

        /// <summary>
        /// DDDMDBTHNO.
        /// </summary>
        public const string DDDMDBTHNO = "DDDMDBTHNO";

        /// <summary>
        /// DDCSGSHPNO.
        /// </summary>
        public const string DDCSGSHPNO = "DDCSGSHPNO";

        /// <summary>
        /// DDGCNT.
        /// </summary>
        public const string DDGCNT = "DDGCNT";

        /// <summary>
        /// DDCUMID.
        /// </summary>
        public const string DDCUMID = "DDCUMID";

        /// <summary>
        /// DDTXTREFNO.
        /// </summary>
        public const string DDTXTREFNO = "DDTXTREFNO";

        /// <summary>
        /// DDREQFRQ.
        /// </summary>
        public const string DDREQFRQ = "DDREQFRQ";

        /// <summary>
        /// DDCSTDMDPT.
        /// </summary>
        public const string DDCSTDMDPT = "DDCSTDMDPT";

        /// <summary>
        /// DDREQTYP.
        /// </summary>
        public const string DDREQTYP = "DDREQTYP";

        /// <summary>
        /// DDCSTORDNO.
        /// </summary>
        public const string DDCSTORDNO = "DDCSTORDNO";

        /// <summary>
        /// DDDKID.
        /// </summary>
        public const string DDDKID = "DDDKID";

        /// <summary>
        /// DDENDJOBSQ.
        /// </summary>
        public const string DDENDJOBSQ = "DDENDJOBSQ";

        /// <summary>
        /// DDPSJOBNO.
        /// </summary>
        public const string DDPSJOBNO = "DDPSJOBNO";

        /// <summary>
        /// DDHZCLSNO.
        /// </summary>
        public const string DDHZCLSNO = "DDHZCLSNO";

        /// <summary>
        /// DDJOBSQ.
        /// </summary>
        public const string DDJOBSQ = "DDJOBSQ";

        /// <summary>
        /// DDKBSNO.
        /// </summary>
        public const string DDKBSNO = "DDKBSNO";

        /// <summary>
        /// DDKBENO.
        /// </summary>
        public const string DDKBENO = "DDKBENO";

        /// <summary>
        /// DDLABORHR.
        /// </summary>
        public const string DDLABORHR = "DDLABORHR";

        /// <summary>
        /// DDCIRV.
        /// </summary>
        public const string DDCIRV = "DDCIRV";

        /// <summary>
        /// DDYEAR1.
        /// </summary>
        public const string DDYEAR1 = "DDYEAR1";

        /// <summary>
        /// DDPTRLSSTS.
        /// </summary>
        public const string DDPTRLSSTS = "DDPTRLSSTS";

        /// <summary>
        /// DDCSTPODJ.
        /// </summary>
        public const string DDCSTPODJ = "DDCSTPODJ";

        /// <summary>
        /// DDCSTPOTM.
        /// </summary>
        public const string DDCSTPOTM = "DDCSTPOTM";

        /// <summary>
        /// DDCSTPOLIN.
        /// </summary>
        public const string DDCSTPOLIN = "DDCSTPOLIN";

        /// <summary>
        /// DDCSTPO.
        /// </summary>
        public const string DDCSTPO = "DDCSTPO";

        /// <summary>
        /// DDTPUR.
        /// </summary>
        public const string DDTPUR = "DDTPUR";

        /// <summary>
        /// DDQTYBYPOS.
        /// </summary>
        public const string DDQTYBYPOS = "DDQTYBYPOS";

        /// <summary>
        /// DDSOCN.
        /// </summary>
        public const string DDSOCN = "DDSOCN";

        /// <summary>
        /// DDPSIG.
        /// </summary>
        public const string DDPSIG = "DDPSIG";

        /// <summary>
        /// DDRSVLNFD.
        /// </summary>
        public const string DDRSVLNFD = "DDRSVLNFD";

        /// <summary>
        /// DDSTSSQIND.
        /// </summary>
        public const string DDSTSSQIND = "DDSTSSQIND";

        /// <summary>
        /// DDEDTCTDJ.
        /// </summary>
        public const string DDEDTCTDJ = "DDEDTCTDJ";

        /// <summary>
        /// DDEDTCTTM.
        /// </summary>
        public const string DDEDTCTTM = "DDEDTCTTM";

        /// <summary>
        /// DDOGDMDQTY.
        /// </summary>
        public const string DDOGDMDQTY = "DDOGDMDQTY";

        /// <summary>
        /// DDEDTMSGNM.
        /// </summary>
        public const string DDEDTMSGNM = "DDEDTMSGNM";

        /// <summary>
        /// DDEDTMSGSB.
        /// </summary>
        public const string DDEDTMSGSB = "DDEDTMSGSB";

        /// <summary>
        /// DDEDTMSGTP.
        /// </summary>
        public const string DDEDTMSGTP = "DDEDTMSGTP";

        /// <summary>
        /// DDTRSRTE.
        /// </summary>
        public const string DDTRSRTE = "DDTRSRTE";

        /// <summary>
        /// DDTRSRTSFX.
        /// </summary>
        public const string DDTRSRTSFX = "DDTRSRTSFX";

        /// <summary>
        /// DDUCARTNO.
        /// </summary>
        public const string DDUCARTNO = "DDUCARTNO";

        /// <summary>
        /// DDVINNO.
        /// </summary>
        public const string DDVINNO = "DDVINNO";

        /// <summary>
        /// DDPENDDLT.
        /// </summary>
        public const string DDPENDDLT = "DDPENDDLT";

        /// <summary>
        /// DDSDID.
        /// </summary>
        public const string DDSDID = "DDSDID";

        /// <summary>
        /// DDNETVC.
        /// </summary>
        public const string DDNETVC = "DDNETVC";

        /// <summary>
        /// DDNETVCNTF.
        /// </summary>
        public const string DDNETVCNTF = "DDNETVCNTF";

        /// <summary>
        /// DDCRTCLID.
        /// </summary>
        public const string DDCRTCLID = "DDCRTCLID";

        /// <summary>
        /// DDDMD06.
        /// </summary>
        public const string DDDMD06 = "DDDMD06";

        /// <summary>
        /// DDDMD07.
        /// </summary>
        public const string DDDMD07 = "DDDMD07";

        /// <summary>
        /// DDDMD08.
        /// </summary>
        public const string DDDMD08 = "DDDMD08";

        /// <summary>
        /// DDDMD09.
        /// </summary>
        public const string DDDMD09 = "DDDMD09";

        /// <summary>
        /// DDDMD10.
        /// </summary>
        public const string DDDMD10 = "DDDMD10";

        /// <summary>
        /// DDDMDREF1.
        /// </summary>
        public const string DDDMDREF1 = "DDDMDREF1";

        /// <summary>
        /// DDDMDREF2.
        /// </summary>
        public const string DDDMDREF2 = "DDDMDREF2";

        /// <summary>
        /// DDCTLNUM.
        /// </summary>
        public const string DDCTLNUM = "DDCTLNUM";

        /// <summary>
        /// DDURCD.
        /// </summary>
        public const string DDURCD = "DDURCD";

        /// <summary>
        /// DDURDT.
        /// </summary>
        public const string DDURDT = "DDURDT";

        /// <summary>
        /// DDURAT.
        /// </summary>
        public const string DDURAT = "DDURAT";

        /// <summary>
        /// DDURAB.
        /// </summary>
        public const string DDURAB = "DDURAB";

        /// <summary>
        /// DDURRF.
        /// </summary>
        public const string DDURRF = "DDURRF";

        /// <summary>
        /// DDUSER.
        /// </summary>
        public const string DDUSER = "DDUSER";

        /// <summary>
        /// DDPID.
        /// </summary>
        public const string DDPID = "DDPID";

        /// <summary>
        /// DDJOBN.
        /// </summary>
        public const string DDJOBN = "DDJOBN";

        /// <summary>
        /// DDUPMJ.
        /// </summary>
        public const string DDUPMJ = "DDUPMJ";

        /// <summary>
        /// DDTDAY.
        /// </summary>
        public const string DDTDAY = "DDTDAY";

        /// <summary>
        /// DDCARDNO.
        /// </summary>
        public const string DDCARDNO = "DDCARDNO";

        /// <summary>
        /// DDDELBATCH.
        /// </summary>
        public const string DDDELBATCH = "DDDELBATCH";

        /// <summary>
        /// DDCIRVQ.
        /// </summary>
        public const string DDCIRVQ = "DDCIRVQ";

        /// <summary>
        /// DDPRODTYPE.
        /// </summary>
        public const string DDPRODTYPE = "DDPRODTYPE";

        /// <summary>
        /// DDRTORSQ.
        /// </summary>
        public const string DDRTORSQ = "DDRTORSQ";

        /// <summary>
        /// DDRTGDAT.
        /// </summary>
        public const string DDRTGDAT = "DDRTGDAT";

        /// <summary>
        /// DDRTGTIM.
        /// </summary>
        public const string DDRTGTIM = "DDRTGTIM";

        /// <summary>
        /// DDDMDREF3.
        /// </summary>
        public const string DDDMDREF3 = "DDDMDREF3";

        /// <summary>
        /// DDDMDREF4.
        /// </summary>
        public const string DDDMDREF4 = "DDDMDREF4";

        /// <summary>
        /// DDDMDREF5.
        /// </summary>
        public const string DDDMDREF5 = "DDDMDREF5";

        /// <summary>
        /// DDDMDREF6.
        /// </summary>
        public const string DDDMDREF6 = "DDDMDREF6";

        /// <summary>
        /// DDDMDREF7.
        /// </summary>
        public const string DDDMDREF7 = "DDDMDREF7";

        /// <summary>
        /// DDDMDREF8.
        /// </summary>
        public const string DDDMDREF8 = "DDDMDREF8";

        /// <summary>
        /// DDDMDREF9.
        /// </summary>
        public const string DDDMDREF9 = "DDDMDREF9";

        /// <summary>
        /// DDDMDREF10.
        /// </summary>
        public const string DDDMDREF10 = "DDDMDREF10";

        /// <summary>
        /// DDSCAC.
        /// </summary>
        public const string DDSCAC = "DDSCAC";

        /// <summary>
        /// DDATMCN.
        /// </summary>
        public const string DDATMCN = "DDATMCN";

        /// <summary>
        /// DDOFFLNDT.
        /// </summary>
        public const string DDOFFLNDT = "DDOFFLNDT";

        /// <summary>
        /// DDENGTAG1.
        /// </summary>
        public const string DDENGTAG1 = "DDENGTAG1";

        /// <summary>
        /// DDENGTAGR1.
        /// </summary>
        public const string DDENGTAGR1 = "DDENGTAGR1";

        /// <summary>
        /// DDENGTAG2.
        /// </summary>
        public const string DDENGTAG2 = "DDENGTAG2";

        /// <summary>
        /// DDENGTAGR2.
        /// </summary>
        public const string DDENGTAGR2 = "DDENGTAGR2";
    }

    /// <inheritdoc />
    public override string TableName => "F40R11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DDUKID", "DDUKID", JdeDataType.Numeric),
        new JdeField("DDDEID", "DDDEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DDMCU", "DDMCU", JdeDataType.String, 24),
        new JdeField("DDAN8", "DDAN8", JdeDataType.Numeric),
        new JdeField("DDSHAN", "DDSHAN", JdeDataType.Numeric),
        new JdeField("DDDVAN", "DDDVAN", JdeDataType.Numeric),
        new JdeField("DDITM", "DDITM", JdeDataType.Numeric),
        new JdeField("DDDETYP", "DDDETYP", JdeDataType.String, 4),
        new JdeField("DDDEPER", "DDDEPER", JdeDataType.String, 4),
        new JdeField("DDCRTSOSTS", "DDCRTSOSTS", JdeDataType.String, 2),
        new JdeField("DDRLSNO", "DDRLSNO", JdeDataType.String, 20),
        new JdeField("DDRLSDJ", "DDRLSDJ", JdeDataType.Numeric),
        new JdeField("DDRLSTM", "DDRLSTM", JdeDataType.Numeric),
        new JdeField("DDRQSJ", "DDRQSJ", JdeDataType.Numeric),
        new JdeField("DDERQSHPDJ", "DDERQSHPDJ", JdeDataType.Numeric),
        new JdeField("DDRSHT", "DDRSHT", JdeDataType.Numeric),
        new JdeField("DDRQSHPQTY", "DDRQSHPQTY", JdeDataType.Numeric),
        new JdeField("DDUOM", "DDUOM", JdeDataType.String, 4),
        new JdeField("DDRSDJ", "DDRSDJ", JdeDataType.Numeric),
        new JdeField("DDRSDT", "DDRSDT", JdeDataType.Numeric),
        new JdeField("DDHZED", "DDHZED", JdeDataType.Numeric),
        new JdeField("DDHZSD", "DDHZSD", JdeDataType.Numeric),
        new JdeField("DDASBLNFD", "DDASBLNFD", JdeDataType.String, 20),
        new JdeField("DDASBLNLOC", "DDASBLNLOC", JdeDataType.String, 12),
        new JdeField("DDASBNO", "DDASBNO", JdeDataType.String, 30),
        new JdeField("DDDMDBTHNO", "DDDMDBTHNO", JdeDataType.Numeric),
        new JdeField("DDCSGSHPNO", "DDCSGSHPNO", JdeDataType.String, 70),
        new JdeField("DDGCNT", "DDGCNT", JdeDataType.String, 24),
        new JdeField("DDCUMID", "DDCUMID", JdeDataType.Numeric),
        new JdeField("DDTXTREFNO", "DDTXTREFNO", JdeDataType.String, 30),
        new JdeField("DDREQFRQ", "DDREQFRQ", JdeDataType.String, 6),
        new JdeField("DDCSTDMDPT", "DDCSTDMDPT", JdeDataType.String, 6),
        new JdeField("DDREQTYP", "DDREQTYP", JdeDataType.String, 6),
        new JdeField("DDCSTORDNO", "DDCSTORDNO", JdeDataType.String, 30),
        new JdeField("DDDKID", "DDDKID", JdeDataType.String, 40),
        new JdeField("DDENDJOBSQ", "DDENDJOBSQ", JdeDataType.String, 30),
        new JdeField("DDPSJOBNO", "DDPSJOBNO", JdeDataType.String, 30),
        new JdeField("DDHZCLSNO", "DDHZCLSNO", JdeDataType.String, 30),
        new JdeField("DDJOBSQ", "DDJOBSQ", JdeDataType.String, 30),
        new JdeField("DDKBSNO", "DDKBSNO", JdeDataType.String, 30),
        new JdeField("DDKBENO", "DDKBENO", JdeDataType.String, 30),
        new JdeField("DDLABORHR", "DDLABORHR", JdeDataType.Numeric),
        new JdeField("DDCIRV", "DDCIRV", JdeDataType.String, 40),
        new JdeField("DDYEAR1", "DDYEAR1", JdeDataType.Numeric),
        new JdeField("DDPTRLSSTS", "DDPTRLSSTS", JdeDataType.String, 4),
        new JdeField("DDCSTPODJ", "DDCSTPODJ", JdeDataType.Numeric),
        new JdeField("DDCSTPOTM", "DDCSTPOTM", JdeDataType.Numeric),
        new JdeField("DDCSTPOLIN", "DDCSTPOLIN", JdeDataType.String, 10),
        new JdeField("DDCSTPO", "DDCSTPO", JdeDataType.String, 60),
        new JdeField("DDTPUR", "DDTPUR", JdeDataType.String, 4),
        new JdeField("DDQTYBYPOS", "DDQTYBYPOS", JdeDataType.Numeric),
        new JdeField("DDSOCN", "DDSOCN", JdeDataType.Numeric),
        new JdeField("DDPSIG", "DDPSIG", JdeDataType.String, 60),
        new JdeField("DDRSVLNFD", "DDRSVLNFD", JdeDataType.String, 20),
        new JdeField("DDSTSSQIND", "DDSTSSQIND", JdeDataType.String, 6),
        new JdeField("DDEDTCTDJ", "DDEDTCTDJ", JdeDataType.Numeric),
        new JdeField("DDEDTCTTM", "DDEDTCTTM", JdeDataType.Numeric),
        new JdeField("DDOGDMDQTY", "DDOGDMDQTY", JdeDataType.Numeric),
        new JdeField("DDEDTMSGNM", "DDEDTMSGNM", JdeDataType.String, 20),
        new JdeField("DDEDTMSGSB", "DDEDTMSGSB", JdeDataType.String, 6),
        new JdeField("DDEDTMSGTP", "DDEDTMSGTP", JdeDataType.String, 6),
        new JdeField("DDTRSRTE", "DDTRSRTE", JdeDataType.String, 30),
        new JdeField("DDTRSRTSFX", "DDTRSRTSFX", JdeDataType.String, 30),
        new JdeField("DDUCARTNO", "DDUCARTNO", JdeDataType.String, 30),
        new JdeField("DDVINNO", "DDVINNO", JdeDataType.String, 40),
        new JdeField("DDPENDDLT", "DDPENDDLT", JdeDataType.String, 2),
        new JdeField("DDSDID", "DDSDID", JdeDataType.Numeric),
        new JdeField("DDNETVC", "DDNETVC", JdeDataType.Numeric),
        new JdeField("DDNETVCNTF", "DDNETVCNTF", JdeDataType.String, 2),
        new JdeField("DDCRTCLID", "DDCRTCLID", JdeDataType.String, 4),
        new JdeField("DDDMD06", "DDDMD06", JdeDataType.String, 6),
        new JdeField("DDDMD07", "DDDMD07", JdeDataType.String, 6),
        new JdeField("DDDMD08", "DDDMD08", JdeDataType.String, 6),
        new JdeField("DDDMD09", "DDDMD09", JdeDataType.String, 6),
        new JdeField("DDDMD10", "DDDMD10", JdeDataType.String, 6),
        new JdeField("DDDMDREF1", "DDDMDREF1", JdeDataType.String, 70),
        new JdeField("DDDMDREF2", "DDDMDREF2", JdeDataType.String, 70),
        new JdeField("DDCTLNUM", "DDCTLNUM", JdeDataType.String, 70),
        new JdeField("DDURCD", "DDURCD", JdeDataType.String, 4),
        new JdeField("DDURDT", "DDURDT", JdeDataType.Numeric),
        new JdeField("DDURAT", "DDURAT", JdeDataType.Numeric),
        new JdeField("DDURAB", "DDURAB", JdeDataType.Numeric),
        new JdeField("DDURRF", "DDURRF", JdeDataType.String, 30),
        new JdeField("DDUSER", "DDUSER", JdeDataType.String, 20),
        new JdeField("DDPID", "DDPID", JdeDataType.String, 20),
        new JdeField("DDJOBN", "DDJOBN", JdeDataType.String, 20),
        new JdeField("DDUPMJ", "DDUPMJ", JdeDataType.Numeric),
        new JdeField("DDTDAY", "DDTDAY", JdeDataType.Numeric),
        new JdeField("DDCARDNO", "DDCARDNO", JdeDataType.String, 8),
        new JdeField("DDDELBATCH", "DDDELBATCH", JdeDataType.String, 12),
        new JdeField("DDCIRVQ", "DDCIRVQ", JdeDataType.String, 4),
        new JdeField("DDPRODTYPE", "DDPRODTYPE", JdeDataType.String, 60),
        new JdeField("DDRTORSQ", "DDRTORSQ", JdeDataType.String, 60),
        new JdeField("DDRTGDAT", "DDRTGDAT", JdeDataType.Numeric),
        new JdeField("DDRTGTIM", "DDRTGTIM", JdeDataType.Numeric),
        new JdeField("DDDMDREF3", "DDDMDREF3", JdeDataType.String, 70),
        new JdeField("DDDMDREF4", "DDDMDREF4", JdeDataType.String, 70),
        new JdeField("DDDMDREF5", "DDDMDREF5", JdeDataType.String, 70),
        new JdeField("DDDMDREF6", "DDDMDREF6", JdeDataType.String, 70),
        new JdeField("DDDMDREF7", "DDDMDREF7", JdeDataType.String, 70),
        new JdeField("DDDMDREF8", "DDDMDREF8", JdeDataType.String, 70),
        new JdeField("DDDMDREF9", "DDDMDREF9", JdeDataType.String, 70),
        new JdeField("DDDMDREF10", "DDDMDREF10", JdeDataType.String, 70),
        new JdeField("DDSCAC", "DDSCAC", JdeDataType.String, 8),
        new JdeField("DDATMCN", "DDATMCN", JdeDataType.Numeric),
        new JdeField("DDOFFLNDT", "DDOFFLNDT", JdeDataType.Numeric),
        new JdeField("DDENGTAG1", "DDENGTAG1", JdeDataType.String, 30),
        new JdeField("DDENGTAGR1", "DDENGTAGR1", JdeDataType.String, 4),
        new JdeField("DDENGTAG2", "DDENGTAG2", JdeDataType.String, 30),
        new JdeField("DDENGTAGR2", "DDENGTAGR2", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R11_0", "Primary Key on DDDEID", new[] { "DDDEID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40R11_2", "Index on DDCUMID", new[] { "DDCUMID" }),
        new JdeIndex("F40R11_3", "Unique Index on DDMCU, DDAN8, DDSHAN, DDITM, DDRQSJ, DDRSHT, DDDETYP, DDDEPER, DDCSTPO, DDPSIG, DDPSJOBNO, DDJOBSQ", new[] { "DDMCU", "DDAN8", "DDSHAN", "DDITM", "DDRQSJ", "DDRSHT", "DDDETYP", "DDDEPER", "DDCSTPO", "DDPSIG", "DDPSJOBNO", "DDJOBSQ" }, isUnique: true),
        new JdeIndex("F40R11_4", "Index on DDDMDBTHNO", new[] { "DDDMDBTHNO" }),
        new JdeIndex("F40R11_5", "Index on DDSDID", new[] { "DDSDID" }),
        new JdeIndex("F40R11_6", "Index on DDEDTMSGNM, DDMCU, DDAN8, DDSHAN, DDITM", new[] { "DDEDTMSGNM", "DDMCU", "DDAN8", "DDSHAN", "DDITM" }),
        new JdeIndex("F40R11_7", "Index on DDUKID, SYS_NC00111$, SYS_NC00112$", new[] { "DDUKID", "SYS_NC00111$", "SYS_NC00112$" }),
        new JdeIndex("F40R11_8", "Index on DDUKID", new[] { "DDUKID" }),
        new JdeIndex("F40R11_9", "Index on DDDETYP, DDAN8, DDSHAN, DDMCU, DDRQSJ, DDRSHT, DDITM", new[] { "DDDETYP", "DDAN8", "DDSHAN", "DDMCU", "DDRQSJ", "DDRSHT", "DDITM" })
    };
}
