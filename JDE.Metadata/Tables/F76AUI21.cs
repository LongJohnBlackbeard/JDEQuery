using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI21 - .
/// </summary>
public class F76AUI21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DLJOBS.
        /// </summary>
        public const string DLJOBS = "DLJOBS";

        /// <summary>
        /// DLCTID.
        /// </summary>
        public const string DLCTID = "DLCTID";

        /// <summary>
        /// DLDOC.
        /// </summary>
        public const string DLDOC = "DLDOC";

        /// <summary>
        /// DLDCT.
        /// </summary>
        public const string DLDCT = "DLDCT";

        /// <summary>
        /// DLKCO.
        /// </summary>
        public const string DLKCO = "DLKCO";

        /// <summary>
        /// DLSEQ.
        /// </summary>
        public const string DLSEQ = "DLSEQ";

        /// <summary>
        /// DLEV03.
        /// </summary>
        public const string DLEV03 = "DLEV03";

        /// <summary>
        /// DLDSC1.
        /// </summary>
        public const string DLDSC1 = "DLDSC1";

        /// <summary>
        /// DLDSC2.
        /// </summary>
        public const string DLDSC2 = "DLDSC2";

        /// <summary>
        /// DLUITM.
        /// </summary>
        public const string DLUITM = "DLUITM";

        /// <summary>
        /// DLUM.
        /// </summary>
        public const string DLUM = "DLUM";

        /// <summary>
        /// DLSOQS.
        /// </summary>
        public const string DLSOQS = "DLSOQS";

        /// <summary>
        /// DLUPRC.
        /// </summary>
        public const string DLUPRC = "DLUPRC";

        /// <summary>
        /// DLAEXP.
        /// </summary>
        public const string DLAEXP = "DLAEXP";

        /// <summary>
        /// DLAG.
        /// </summary>
        public const string DLAG = "DLAG";

        /// <summary>
        /// DLTX.
        /// </summary>
        public const string DLTX = "DLTX";

        /// <summary>
        /// DLURRF.
        /// </summary>
        public const string DLURRF = "DLURRF";

        /// <summary>
        /// DLUOM4.
        /// </summary>
        public const string DLUOM4 = "DLUOM4";

        /// <summary>
        /// DLITWT.
        /// </summary>
        public const string DLITWT = "DLITWT";

        /// <summary>
        /// DLITVL.
        /// </summary>
        public const string DLITVL = "DLITVL";

        /// <summary>
        /// DLRMK.
        /// </summary>
        public const string DLRMK = "DLRMK";

        /// <summary>
        /// DLATXA.
        /// </summary>
        public const string DLATXA = "DLATXA";

        /// <summary>
        /// DLTXLN.
        /// </summary>
        public const string DLTXLN = "DLTXLN";

        /// <summary>
        /// DLLOTN.
        /// </summary>
        public const string DLLOTN = "DLLOTN";

        /// <summary>
        /// DLEFDJ.
        /// </summary>
        public const string DLEFDJ = "DLEFDJ";

        /// <summary>
        /// DLUA02.
        /// </summary>
        public const string DLUA02 = "DLUA02";

        /// <summary>
        /// DLDL01.
        /// </summary>
        public const string DLDL01 = "DLDL01";

        /// <summary>
        /// DLDL02.
        /// </summary>
        public const string DLDL02 = "DLDL02";

        /// <summary>
        /// DLLOT3.
        /// </summary>
        public const string DLLOT3 = "DLLOT3";

        /// <summary>
        /// DLPGNF.
        /// </summary>
        public const string DLPGNF = "DLPGNF";

        /// <summary>
        /// DLTEMP.
        /// </summary>
        public const string DLTEMP = "DLTEMP";

        /// <summary>
        /// DLSTPU.
        /// </summary>
        public const string DLSTPU = "DLSTPU";

        /// <summary>
        /// DLDNTY.
        /// </summary>
        public const string DLDNTY = "DLDNTY";

        /// <summary>
        /// DLDNTP.
        /// </summary>
        public const string DLDNTP = "DLDNTP";

        /// <summary>
        /// DLDETP.
        /// </summary>
        public const string DLDETP = "DLDETP";

        /// <summary>
        /// DLDTPU.
        /// </summary>
        public const string DLDTPU = "DLDTPU";

        /// <summary>
        /// DLSTUM.
        /// </summary>
        public const string DLSTUM = "DLSTUM";

        /// <summary>
        /// DLBUM3.
        /// </summary>
        public const string DLBUM3 = "DLBUM3";

        /// <summary>
        /// DLBUM5.
        /// </summary>
        public const string DLBUM5 = "DLBUM5";

        /// <summary>
        /// DLBPFG.
        /// </summary>
        public const string DLBPFG = "DLBPFG";

        /// <summary>
        /// DLPRAS.
        /// </summary>
        public const string DLPRAS = "DLPRAS";

        /// <summary>
        /// DLITM.
        /// </summary>
        public const string DLITM = "DLITM";

        /// <summary>
        /// DLPTNR.
        /// </summary>
        public const string DLPTNR = "DLPTNR";

        /// <summary>
        /// DLKCOO.
        /// </summary>
        public const string DLKCOO = "DLKCOO";

        /// <summary>
        /// DLDCTO.
        /// </summary>
        public const string DLDCTO = "DLDCTO";

        /// <summary>
        /// DLDOCO.
        /// </summary>
        public const string DLDOCO = "DLDOCO";

        /// <summary>
        /// DLLNID.
        /// </summary>
        public const string DLLNID = "DLLNID";

        /// <summary>
        /// DLCITM.
        /// </summary>
        public const string DLCITM = "DLCITM";

        /// <summary>
        /// DLURAB.
        /// </summary>
        public const string DLURAB = "DLURAB";

        /// <summary>
        /// DLURAT.
        /// </summary>
        public const string DLURAT = "DLURAT";

        /// <summary>
        /// DLURC1.
        /// </summary>
        public const string DLURC1 = "DLURC1";

        /// <summary>
        /// DLURC2.
        /// </summary>
        public const string DLURC2 = "DLURC2";

        /// <summary>
        /// DLURCD.
        /// </summary>
        public const string DLURCD = "DLURCD";

        /// <summary>
        /// DLURDD.
        /// </summary>
        public const string DLURDD = "DLURDD";

        /// <summary>
        /// DLURDT.
        /// </summary>
        public const string DLURDT = "DLURDT";

        /// <summary>
        /// DLURNUM01.
        /// </summary>
        public const string DLURNUM01 = "DLURNUM01";

        /// <summary>
        /// DLURNUM02.
        /// </summary>
        public const string DLURNUM02 = "DLURNUM02";

        /// <summary>
        /// DLURNUM03.
        /// </summary>
        public const string DLURNUM03 = "DLURNUM03";

        /// <summary>
        /// DLSNLN.
        /// </summary>
        public const string DLSNLN = "DLSNLN";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DLJOBS", "DLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DLCTID", "DLCTID", JdeDataType.String, 30, true, true),
        new JdeField("DLDOC", "DLDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DLDCT", "DLDCT", JdeDataType.String, 4, true, true),
        new JdeField("DLKCO", "DLKCO", JdeDataType.String, 10, true, true),
        new JdeField("DLSEQ", "DLSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DLEV03", "DLEV03", JdeDataType.String, 2),
        new JdeField("DLDSC1", "DLDSC1", JdeDataType.String, 60),
        new JdeField("DLDSC2", "DLDSC2", JdeDataType.String, 60),
        new JdeField("DLUITM", "DLUITM", JdeDataType.String, 52),
        new JdeField("DLUM", "DLUM", JdeDataType.String, 4),
        new JdeField("DLSOQS", "DLSOQS", JdeDataType.Numeric),
        new JdeField("DLUPRC", "DLUPRC", JdeDataType.Numeric),
        new JdeField("DLAEXP", "DLAEXP", JdeDataType.Numeric),
        new JdeField("DLAG", "DLAG", JdeDataType.Numeric),
        new JdeField("DLTX", "DLTX", JdeDataType.String, 2),
        new JdeField("DLURRF", "DLURRF", JdeDataType.String, 30),
        new JdeField("DLUOM4", "DLUOM4", JdeDataType.String, 4),
        new JdeField("DLITWT", "DLITWT", JdeDataType.Numeric),
        new JdeField("DLITVL", "DLITVL", JdeDataType.Numeric),
        new JdeField("DLRMK", "DLRMK", JdeDataType.String, 60),
        new JdeField("DLATXA", "DLATXA", JdeDataType.Numeric),
        new JdeField("DLTXLN", "DLTXLN", JdeDataType.String, 120),
        new JdeField("DLLOTN", "DLLOTN", JdeDataType.String, 60),
        new JdeField("DLEFDJ", "DLEFDJ", JdeDataType.Numeric),
        new JdeField("DLUA02", "DLUA02", JdeDataType.Numeric),
        new JdeField("DLDL01", "DLDL01", JdeDataType.String, 60),
        new JdeField("DLDL02", "DLDL02", JdeDataType.String, 60),
        new JdeField("DLLOT3", "DLLOT3", JdeDataType.String, 60),
        new JdeField("DLPGNF", "DLPGNF", JdeDataType.Numeric),
        new JdeField("DLTEMP", "DLTEMP", JdeDataType.Numeric),
        new JdeField("DLSTPU", "DLSTPU", JdeDataType.String, 2),
        new JdeField("DLDNTY", "DLDNTY", JdeDataType.Numeric),
        new JdeField("DLDNTP", "DLDNTP", JdeDataType.String, 2),
        new JdeField("DLDETP", "DLDETP", JdeDataType.Numeric),
        new JdeField("DLDTPU", "DLDTPU", JdeDataType.String, 2),
        new JdeField("DLSTUM", "DLSTUM", JdeDataType.Numeric),
        new JdeField("DLBUM3", "DLBUM3", JdeDataType.String, 4),
        new JdeField("DLBUM5", "DLBUM5", JdeDataType.String, 4),
        new JdeField("DLBPFG", "DLBPFG", JdeDataType.String, 2),
        new JdeField("DLPRAS", "DLPRAS", JdeDataType.String, 2),
        new JdeField("DLITM", "DLITM", JdeDataType.Numeric),
        new JdeField("DLPTNR", "DLPTNR", JdeDataType.Numeric),
        new JdeField("DLKCOO", "DLKCOO", JdeDataType.String, 10),
        new JdeField("DLDCTO", "DLDCTO", JdeDataType.String, 4),
        new JdeField("DLDOCO", "DLDOCO", JdeDataType.Numeric),
        new JdeField("DLLNID", "DLLNID", JdeDataType.Numeric),
        new JdeField("DLCITM", "DLCITM", JdeDataType.String, 50),
        new JdeField("DLURAB", "DLURAB", JdeDataType.Numeric),
        new JdeField("DLURAT", "DLURAT", JdeDataType.Numeric),
        new JdeField("DLURC1", "DLURC1", JdeDataType.String, 6),
        new JdeField("DLURC2", "DLURC2", JdeDataType.String, 20),
        new JdeField("DLURCD", "DLURCD", JdeDataType.String, 4),
        new JdeField("DLURDD", "DLURDD", JdeDataType.Numeric),
        new JdeField("DLURDT", "DLURDT", JdeDataType.Numeric),
        new JdeField("DLURNUM01", "DLURNUM01", JdeDataType.Numeric),
        new JdeField("DLURNUM02", "DLURNUM02", JdeDataType.Numeric),
        new JdeField("DLURNUM03", "DLURNUM03", JdeDataType.Numeric),
        new JdeField("DLSNLN", "DLSNLN", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI21_0", "Primary Key on DLJOBS, DLCTID, DLDOC, DLDCT, DLKCO, DLSEQ", new[] { "DLJOBS", "DLCTID", "DLDOC", "DLDCT", "DLKCO", "DLSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
