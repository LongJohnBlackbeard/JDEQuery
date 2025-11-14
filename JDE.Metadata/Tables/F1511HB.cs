using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1511HB - .
/// </summary>
public class F1511HB : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NCGENT.
        /// </summary>
        public const string NCGENT = "NCGENT";

        /// <summary>
        /// NCICU.
        /// </summary>
        public const string NCICU = "NCICU";

        /// <summary>
        /// NCDOC.
        /// </summary>
        public const string NCDOC = "NCDOC";

        /// <summary>
        /// NCSFX.
        /// </summary>
        public const string NCSFX = "NCSFX";

        /// <summary>
        /// NCDOCO.
        /// </summary>
        public const string NCDOCO = "NCDOCO";

        /// <summary>
        /// NCDCTO.
        /// </summary>
        public const string NCDCTO = "NCDCTO";

        /// <summary>
        /// NCSOSQ.
        /// </summary>
        public const string NCSOSQ = "NCSOSQ";

        /// <summary>
        /// NCMCUS.
        /// </summary>
        public const string NCMCUS = "NCMCUS";

        /// <summary>
        /// NCAN8.
        /// </summary>
        public const string NCAN8 = "NCAN8";

        /// <summary>
        /// NCAN8J.
        /// </summary>
        public const string NCAN8J = "NCAN8J";

        /// <summary>
        /// NCDL01.
        /// </summary>
        public const string NCDL01 = "NCDL01";

        /// <summary>
        /// NCMCU.
        /// </summary>
        public const string NCMCU = "NCMCU";

        /// <summary>
        /// NCOBJ.
        /// </summary>
        public const string NCOBJ = "NCOBJ";

        /// <summary>
        /// NCSUB.
        /// </summary>
        public const string NCSUB = "NCSUB";

        /// <summary>
        /// NCSBL.
        /// </summary>
        public const string NCSBL = "NCSBL";

        /// <summary>
        /// NCAID.
        /// </summary>
        public const string NCAID = "NCAID";

        /// <summary>
        /// NCCO.
        /// </summary>
        public const string NCCO = "NCCO";

        /// <summary>
        /// NCDG.
        /// </summary>
        public const string NCDG = "NCDG";

        /// <summary>
        /// NCDSV.
        /// </summary>
        public const string NCDSV = "NCDSV";

        /// <summary>
        /// NCGLC.
        /// </summary>
        public const string NCGLC = "NCGLC";

        /// <summary>
        /// NCBPN.
        /// </summary>
        public const string NCBPN = "NCBPN";

        /// <summary>
        /// NCYR.
        /// </summary>
        public const string NCYR = "NCYR";

        /// <summary>
        /// NCAG.
        /// </summary>
        public const string NCAG = "NCAG";

        /// <summary>
        /// NCAN01.
        /// </summary>
        public const string NCAN01 = "NCAN01";

        /// <summary>
        /// NCDI.
        /// </summary>
        public const string NCDI = "NCDI";

        /// <summary>
        /// NCDD.
        /// </summary>
        public const string NCDD = "NCDD";

        /// <summary>
        /// NCPTC.
        /// </summary>
        public const string NCPTC = "NCPTC";

        /// <summary>
        /// NCTRAN.
        /// </summary>
        public const string NCTRAN = "NCTRAN";

        /// <summary>
        /// NCSEPI.
        /// </summary>
        public const string NCSEPI = "NCSEPI";

        /// <summary>
        /// NCITMG.
        /// </summary>
        public const string NCITMG = "NCITMG";

        /// <summary>
        /// NCLNID.
        /// </summary>
        public const string NCLNID = "NCLNID";

        /// <summary>
        /// NCDIC.
        /// </summary>
        public const string NCDIC = "NCDIC";

        /// <summary>
        /// NCPDUE.
        /// </summary>
        public const string NCPDUE = "NCPDUE";

        /// <summary>
        /// NCEPCL.
        /// </summary>
        public const string NCEPCL = "NCEPCL";

        /// <summary>
        /// NCDPER.
        /// </summary>
        public const string NCDPER = "NCDPER";

        /// <summary>
        /// NCDPAR.
        /// </summary>
        public const string NCDPAR = "NCDPAR";

        /// <summary>
        /// NCEXCD.
        /// </summary>
        public const string NCEXCD = "NCEXCD";

        /// <summary>
        /// NCBCI.
        /// </summary>
        public const string NCBCI = "NCBCI";

        /// <summary>
        /// NCPRDC.
        /// </summary>
        public const string NCPRDC = "NCPRDC";

        /// <summary>
        /// NCYRO.
        /// </summary>
        public const string NCYRO = "NCYRO";

        /// <summary>
        /// NCCTRY.
        /// </summary>
        public const string NCCTRY = "NCCTRY";

        /// <summary>
        /// NCRPRD.
        /// </summary>
        public const string NCRPRD = "NCRPRD";

        /// <summary>
        /// NCCRCD.
        /// </summary>
        public const string NCCRCD = "NCCRCD";

        /// <summary>
        /// NCCRR.
        /// </summary>
        public const string NCCRR = "NCCRR";

        /// <summary>
        /// NCACR.
        /// </summary>
        public const string NCACR = "NCACR";

        /// <summary>
        /// NCTXA1.
        /// </summary>
        public const string NCTXA1 = "NCTXA1";

        /// <summary>
        /// NCEXR1.
        /// </summary>
        public const string NCEXR1 = "NCEXR1";

        /// <summary>
        /// NCSTAM.
        /// </summary>
        public const string NCSTAM = "NCSTAM";

        /// <summary>
        /// NCATXN.
        /// </summary>
        public const string NCATXN = "NCATXN";

        /// <summary>
        /// NCATXA.
        /// </summary>
        public const string NCATXA = "NCATXA";

        /// <summary>
        /// NCSBLT.
        /// </summary>
        public const string NCSBLT = "NCSBLT";

        /// <summary>
        /// NCCRRM.
        /// </summary>
        public const string NCCRRM = "NCCRRM";

        /// <summary>
        /// NCFAP.
        /// </summary>
        public const string NCFAP = "NCFAP";

        /// <summary>
        /// NCCDS.
        /// </summary>
        public const string NCCDS = "NCCDS";

        /// <summary>
        /// NCCDSA.
        /// </summary>
        public const string NCCDSA = "NCCDSA";

        /// <summary>
        /// NCCTAM.
        /// </summary>
        public const string NCCTAM = "NCCTAM";

        /// <summary>
        /// NCCTXA.
        /// </summary>
        public const string NCCTXA = "NCCTXA";

        /// <summary>
        /// NCCTXN.
        /// </summary>
        public const string NCCTXN = "NCCTXN";

        /// <summary>
        /// NCMI.
        /// </summary>
        public const string NCMI = "NCMI";

        /// <summary>
        /// NCDBAN.
        /// </summary>
        public const string NCDBAN = "NCDBAN";

        /// <summary>
        /// NCUNIT.
        /// </summary>
        public const string NCUNIT = "NCUNIT";

        /// <summary>
        /// NCBLMR.
        /// </summary>
        public const string NCBLMR = "NCBLMR";

        /// <summary>
        /// NCEFFC.
        /// </summary>
        public const string NCEFFC = "NCEFFC";

        /// <summary>
        /// NCSOBT.
        /// </summary>
        public const string NCSOBT = "NCSOBT";

        /// <summary>
        /// NCSBJR.
        /// </summary>
        public const string NCSBJR = "NCSBJR";

        /// <summary>
        /// NCICB1.
        /// </summary>
        public const string NCICB1 = "NCICB1";

        /// <summary>
        /// NCICB2.
        /// </summary>
        public const string NCICB2 = "NCICB2";

        /// <summary>
        /// NCICB3.
        /// </summary>
        public const string NCICB3 = "NCICB3";

        /// <summary>
        /// NCICB4.
        /// </summary>
        public const string NCICB4 = "NCICB4";

        /// <summary>
        /// NCICB5.
        /// </summary>
        public const string NCICB5 = "NCICB5";

        /// <summary>
        /// NCINVP.
        /// </summary>
        public const string NCINVP = "NCINVP";

        /// <summary>
        /// NCPRRB.
        /// </summary>
        public const string NCPRRB = "NCPRRB";

        /// <summary>
        /// NCBCIR.
        /// </summary>
        public const string NCBCIR = "NCBCIR";

        /// <summary>
        /// NCICBC.
        /// </summary>
        public const string NCICBC = "NCICBC";

        /// <summary>
        /// NCIST.
        /// </summary>
        public const string NCIST = "NCIST";

        /// <summary>
        /// NCSOTY.
        /// </summary>
        public const string NCSOTY = "NCSOTY";

        /// <summary>
        /// NCODOC.
        /// </summary>
        public const string NCODOC = "NCODOC";

        /// <summary>
        /// NCODCT.
        /// </summary>
        public const string NCODCT = "NCODCT";

        /// <summary>
        /// NCOSFX.
        /// </summary>
        public const string NCOSFX = "NCOSFX";

        /// <summary>
        /// NCKCO.
        /// </summary>
        public const string NCKCO = "NCKCO";

        /// <summary>
        /// NCOKCO.
        /// </summary>
        public const string NCOKCO = "NCOKCO";

        /// <summary>
        /// NCLSVR.
        /// </summary>
        public const string NCLSVR = "NCLSVR";

        /// <summary>
        /// NCBCI3.
        /// </summary>
        public const string NCBCI3 = "NCBCI3";

        /// <summary>
        /// NCURCD.
        /// </summary>
        public const string NCURCD = "NCURCD";

        /// <summary>
        /// NCURDT.
        /// </summary>
        public const string NCURDT = "NCURDT";

        /// <summary>
        /// NCURAT.
        /// </summary>
        public const string NCURAT = "NCURAT";

        /// <summary>
        /// NCURAB.
        /// </summary>
        public const string NCURAB = "NCURAB";

        /// <summary>
        /// NCURRF.
        /// </summary>
        public const string NCURRF = "NCURRF";

        /// <summary>
        /// NCUSER.
        /// </summary>
        public const string NCUSER = "NCUSER";

        /// <summary>
        /// NCPID.
        /// </summary>
        public const string NCPID = "NCPID";

        /// <summary>
        /// NCUPMJ.
        /// </summary>
        public const string NCUPMJ = "NCUPMJ";

        /// <summary>
        /// NCUPMT.
        /// </summary>
        public const string NCUPMT = "NCUPMT";

        /// <summary>
        /// NCJOBN.
        /// </summary>
        public const string NCJOBN = "NCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1511HB";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NCGENT", "NCGENT", JdeDataType.String, 2, true, true),
        new JdeField("NCICU", "NCICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NCDOC", "NCDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("NCSFX", "NCSFX", JdeDataType.String, 6, true, true),
        new JdeField("NCDOCO", "NCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NCDCTO", "NCDCTO", JdeDataType.String, 4),
        new JdeField("NCSOSQ", "NCSOSQ", JdeDataType.Numeric),
        new JdeField("NCMCUS", "NCMCUS", JdeDataType.String, 24),
        new JdeField("NCAN8", "NCAN8", JdeDataType.Numeric),
        new JdeField("NCAN8J", "NCAN8J", JdeDataType.Numeric),
        new JdeField("NCDL01", "NCDL01", JdeDataType.String, 60),
        new JdeField("NCMCU", "NCMCU", JdeDataType.String, 24),
        new JdeField("NCOBJ", "NCOBJ", JdeDataType.String, 12),
        new JdeField("NCSUB", "NCSUB", JdeDataType.String, 16),
        new JdeField("NCSBL", "NCSBL", JdeDataType.String, 16),
        new JdeField("NCAID", "NCAID", JdeDataType.String, 16),
        new JdeField("NCCO", "NCCO", JdeDataType.String, 10),
        new JdeField("NCDG", "NCDG", JdeDataType.Numeric),
        new JdeField("NCDSV", "NCDSV", JdeDataType.Numeric),
        new JdeField("NCGLC", "NCGLC", JdeDataType.String, 8),
        new JdeField("NCBPN", "NCBPN", JdeDataType.Numeric, null, true, true),
        new JdeField("NCYR", "NCYR", JdeDataType.Numeric, null, true, true),
        new JdeField("NCAG", "NCAG", JdeDataType.Numeric),
        new JdeField("NCAN01", "NCAN01", JdeDataType.Numeric),
        new JdeField("NCDI", "NCDI", JdeDataType.Numeric),
        new JdeField("NCDD", "NCDD", JdeDataType.Numeric),
        new JdeField("NCPTC", "NCPTC", JdeDataType.String, 6),
        new JdeField("NCTRAN", "NCTRAN", JdeDataType.String, 2),
        new JdeField("NCSEPI", "NCSEPI", JdeDataType.String, 2),
        new JdeField("NCITMG", "NCITMG", JdeDataType.String, 6),
        new JdeField("NCLNID", "NCLNID", JdeDataType.Numeric),
        new JdeField("NCDIC", "NCDIC", JdeDataType.Numeric),
        new JdeField("NCPDUE", "NCPDUE", JdeDataType.Numeric),
        new JdeField("NCEPCL", "NCEPCL", JdeDataType.String, 8),
        new JdeField("NCDPER", "NCDPER", JdeDataType.Numeric),
        new JdeField("NCDPAR", "NCDPAR", JdeDataType.Numeric),
        new JdeField("NCEXCD", "NCEXCD", JdeDataType.String, 2),
        new JdeField("NCBCI", "NCBCI", JdeDataType.Numeric),
        new JdeField("NCPRDC", "NCPRDC", JdeDataType.String, 8),
        new JdeField("NCYRO", "NCYRO", JdeDataType.Numeric),
        new JdeField("NCCTRY", "NCCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("NCRPRD", "NCRPRD", JdeDataType.Numeric),
        new JdeField("NCCRCD", "NCCRCD", JdeDataType.String, 6),
        new JdeField("NCCRR", "NCCRR", JdeDataType.Numeric),
        new JdeField("NCACR", "NCACR", JdeDataType.Numeric),
        new JdeField("NCTXA1", "NCTXA1", JdeDataType.String, 20),
        new JdeField("NCEXR1", "NCEXR1", JdeDataType.String, 4),
        new JdeField("NCSTAM", "NCSTAM", JdeDataType.Numeric),
        new JdeField("NCATXN", "NCATXN", JdeDataType.Numeric),
        new JdeField("NCATXA", "NCATXA", JdeDataType.Numeric),
        new JdeField("NCSBLT", "NCSBLT", JdeDataType.String, 2),
        new JdeField("NCCRRM", "NCCRRM", JdeDataType.String, 2),
        new JdeField("NCFAP", "NCFAP", JdeDataType.Numeric),
        new JdeField("NCCDS", "NCCDS", JdeDataType.Numeric),
        new JdeField("NCCDSA", "NCCDSA", JdeDataType.Numeric),
        new JdeField("NCCTAM", "NCCTAM", JdeDataType.Numeric),
        new JdeField("NCCTXA", "NCCTXA", JdeDataType.Numeric),
        new JdeField("NCCTXN", "NCCTXN", JdeDataType.Numeric),
        new JdeField("NCMI", "NCMI", JdeDataType.String, 2),
        new JdeField("NCDBAN", "NCDBAN", JdeDataType.Numeric),
        new JdeField("NCUNIT", "NCUNIT", JdeDataType.String, 16),
        new JdeField("NCBLMR", "NCBLMR", JdeDataType.String, 2),
        new JdeField("NCEFFC", "NCEFFC", JdeDataType.String, 2),
        new JdeField("NCSOBT", "NCSOBT", JdeDataType.String, 4, true, true),
        new JdeField("NCSBJR", "NCSBJR", JdeDataType.String, 2),
        new JdeField("NCICB1", "NCICB1", JdeDataType.String, 24),
        new JdeField("NCICB2", "NCICB2", JdeDataType.String, 24),
        new JdeField("NCICB3", "NCICB3", JdeDataType.String, 24),
        new JdeField("NCICB4", "NCICB4", JdeDataType.String, 24),
        new JdeField("NCICB5", "NCICB5", JdeDataType.String, 24),
        new JdeField("NCINVP", "NCINVP", JdeDataType.String, 2),
        new JdeField("NCPRRB", "NCPRRB", JdeDataType.String, 2),
        new JdeField("NCBCIR", "NCBCIR", JdeDataType.Numeric),
        new JdeField("NCICBC", "NCICBC", JdeDataType.String, 4),
        new JdeField("NCIST", "NCIST", JdeDataType.String, 2),
        new JdeField("NCSOTY", "NCSOTY", JdeDataType.String, 4),
        new JdeField("NCODOC", "NCODOC", JdeDataType.Numeric),
        new JdeField("NCODCT", "NCODCT", JdeDataType.String, 4),
        new JdeField("NCOSFX", "NCOSFX", JdeDataType.String, 6),
        new JdeField("NCKCO", "NCKCO", JdeDataType.String, 10, true, true),
        new JdeField("NCOKCO", "NCOKCO", JdeDataType.String, 10),
        new JdeField("NCLSVR", "NCLSVR", JdeDataType.Numeric),
        new JdeField("NCBCI3", "NCBCI3", JdeDataType.Numeric),
        new JdeField("NCURCD", "NCURCD", JdeDataType.String, 4),
        new JdeField("NCURDT", "NCURDT", JdeDataType.Numeric),
        new JdeField("NCURAT", "NCURAT", JdeDataType.Numeric),
        new JdeField("NCURAB", "NCURAB", JdeDataType.Numeric),
        new JdeField("NCURRF", "NCURRF", JdeDataType.String, 30),
        new JdeField("NCUSER", "NCUSER", JdeDataType.String, 20),
        new JdeField("NCPID", "NCPID", JdeDataType.String, 20),
        new JdeField("NCUPMJ", "NCUPMJ", JdeDataType.Numeric),
        new JdeField("NCUPMT", "NCUPMT", JdeDataType.Numeric),
        new JdeField("NCJOBN", "NCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1511HB_0", "Primary Key on NCDOCO, NCGENT, NCCTRY, NCYR, NCBPN, NCSOBT, NCICU, NCDOC, NCKCO, NCSFX", new[] { "NCDOCO", "NCGENT", "NCCTRY", "NCYR", "NCBPN", "NCSOBT", "NCICU", "NCDOC", "NCKCO", "NCSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1511HB_2", "Index on NCDOCO, NCBCIR", new[] { "NCDOCO", "NCBCIR" }),
        new JdeIndex("F1511HB_3", "Index on NCICU, NCDOC, NCKCO, NCSFX", new[] { "NCICU", "NCDOC", "NCKCO", "NCSFX" }),
        new JdeIndex("F1511HB_4", "Index on NCODOC, NCOKCO, NCODCT, NCOSFX", new[] { "NCODOC", "NCOKCO", "NCODCT", "NCOSFX" }),
        new JdeIndex("F1511HB_5", "Index on NCDOCO, NCLSVR, NCBCIR", new[] { "NCDOCO", "NCLSVR", "NCBCIR" }),
        new JdeIndex("F1511HB_6", "Index on NCDOCO, NCBCI, NCLSVR", new[] { "NCDOCO", "NCBCI", "NCLSVR" })
    };
}
