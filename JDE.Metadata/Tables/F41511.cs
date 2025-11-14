using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41511 - .
/// </summary>
public class F41511 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PADOC.
        /// </summary>
        public const string PADOC = "PADOC";

        /// <summary>
        /// PADCT.
        /// </summary>
        public const string PADCT = "PADCT";

        /// <summary>
        /// PAKCO.
        /// </summary>
        public const string PAKCO = "PAKCO";

        /// <summary>
        /// PAJELN.
        /// </summary>
        public const string PAJELN = "PAJELN";

        /// <summary>
        /// PADOCO.
        /// </summary>
        public const string PADOCO = "PADOCO";

        /// <summary>
        /// PADCTO.
        /// </summary>
        public const string PADCTO = "PADCTO";

        /// <summary>
        /// PAKCOO.
        /// </summary>
        public const string PAKCOO = "PAKCOO";

        /// <summary>
        /// PALNID.
        /// </summary>
        public const string PALNID = "PALNID";

        /// <summary>
        /// PANLIN.
        /// </summary>
        public const string PANLIN = "PANLIN";

        /// <summary>
        /// PADGL.
        /// </summary>
        public const string PADGL = "PADGL";

        /// <summary>
        /// PATRDJ.
        /// </summary>
        public const string PATRDJ = "PATRDJ";

        /// <summary>
        /// PAICU.
        /// </summary>
        public const string PAICU = "PAICU";

        /// <summary>
        /// PATRCD.
        /// </summary>
        public const string PATRCD = "PATRCD";

        /// <summary>
        /// PAMCU.
        /// </summary>
        public const string PAMCU = "PAMCU";

        /// <summary>
        /// PATKID.
        /// </summary>
        public const string PATKID = "PATKID";

        /// <summary>
        /// PAITM.
        /// </summary>
        public const string PAITM = "PAITM";

        /// <summary>
        /// PATRNO.
        /// </summary>
        public const string PATRNO = "PATRNO";

        /// <summary>
        /// PATEMP.
        /// </summary>
        public const string PATEMP = "PATEMP";

        /// <summary>
        /// PASTPU.
        /// </summary>
        public const string PASTPU = "PASTPU";

        /// <summary>
        /// PADNTY.
        /// </summary>
        public const string PADNTY = "PADNTY";

        /// <summary>
        /// PADNTP.
        /// </summary>
        public const string PADNTP = "PADNTP";

        /// <summary>
        /// PADETP.
        /// </summary>
        public const string PADETP = "PADETP";

        /// <summary>
        /// PADTPU.
        /// </summary>
        public const string PADTPU = "PADTPU";

        /// <summary>
        /// PAAMBR.
        /// </summary>
        public const string PAAMBR = "PAAMBR";

        /// <summary>
        /// PABUM3.
        /// </summary>
        public const string PABUM3 = "PABUM3";

        /// <summary>
        /// PAAMBI.
        /// </summary>
        public const string PAAMBI = "PAAMBI";

        /// <summary>
        /// PAAMBU.
        /// </summary>
        public const string PAAMBU = "PAAMBU";

        /// <summary>
        /// PAVCF.
        /// </summary>
        public const string PAVCF = "PAVCF";

        /// <summary>
        /// PASTOK.
        /// </summary>
        public const string PASTOK = "PASTOK";

        /// <summary>
        /// PABUM4.
        /// </summary>
        public const string PABUM4 = "PABUM4";

        /// <summary>
        /// PAWGTR.
        /// </summary>
        public const string PAWGTR = "PAWGTR";

        /// <summary>
        /// PABUM5.
        /// </summary>
        public const string PABUM5 = "PABUM5";

        /// <summary>
        /// PASTUM.
        /// </summary>
        public const string PASTUM = "PASTUM";

        /// <summary>
        /// PABUM6.
        /// </summary>
        public const string PABUM6 = "PABUM6";

        /// <summary>
        /// PARCD.
        /// </summary>
        public const string PARCD = "PARCD";

        /// <summary>
        /// PAUPCF.
        /// </summary>
        public const string PAUPCF = "PAUPCF";

        /// <summary>
        /// PALOTN.
        /// </summary>
        public const string PALOTN = "PALOTN";

        /// <summary>
        /// PALOTS.
        /// </summary>
        public const string PALOTS = "PALOTS";

        /// <summary>
        /// PAMMEJ.
        /// </summary>
        public const string PAMMEJ = "PAMMEJ";

        /// <summary>
        /// PAUNCS.
        /// </summary>
        public const string PAUNCS = "PAUNCS";

        /// <summary>
        /// PAECST.
        /// </summary>
        public const string PAECST = "PAECST";

        /// <summary>
        /// PATREX.
        /// </summary>
        public const string PATREX = "PATREX";

        /// <summary>
        /// PAAN8.
        /// </summary>
        public const string PAAN8 = "PAAN8";

        /// <summary>
        /// PADMCT.
        /// </summary>
        public const string PADMCT = "PADMCT";

        /// <summary>
        /// PADMCS.
        /// </summary>
        public const string PADMCS = "PADMCS";

        /// <summary>
        /// PAACOR.
        /// </summary>
        public const string PAACOR = "PAACOR";

        /// <summary>
        /// PAHCOR.
        /// </summary>
        public const string PAHCOR = "PAHCOR";

        /// <summary>
        /// PADIPT.
        /// </summary>
        public const string PADIPT = "PADIPT";

        /// <summary>
        /// PAGDIP.
        /// </summary>
        public const string PAGDIP = "PAGDIP";

        /// <summary>
        /// PAWDIP.
        /// </summary>
        public const string PAWDIP = "PAWDIP";

        /// <summary>
        /// PAVAPP.
        /// </summary>
        public const string PAVAPP = "PAVAPP";

        /// <summary>
        /// PAPREU.
        /// </summary>
        public const string PAPREU = "PAPREU";

        /// <summary>
        /// PALPGV.
        /// </summary>
        public const string PALPGV = "PALPGV";

        /// <summary>
        /// PATPU1.
        /// </summary>
        public const string PATPU1 = "PATPU1";

        /// <summary>
        /// PASLIP.
        /// </summary>
        public const string PASLIP = "PASLIP";

        /// <summary>
        /// PAVAPW.
        /// </summary>
        public const string PAVAPW = "PAVAPW";

        /// <summary>
        /// PABUM0.
        /// </summary>
        public const string PABUM0 = "PABUM0";

        /// <summary>
        /// PAVAPV.
        /// </summary>
        public const string PAVAPV = "PAVAPV";

        /// <summary>
        /// PABUM9.
        /// </summary>
        public const string PABUM9 = "PABUM9";

        /// <summary>
        /// PALIQW.
        /// </summary>
        public const string PALIQW = "PALIQW";

        /// <summary>
        /// PABUM7.
        /// </summary>
        public const string PABUM7 = "PABUM7";

        /// <summary>
        /// PALIQV.
        /// </summary>
        public const string PALIQV = "PALIQV";

        /// <summary>
        /// PABUM8.
        /// </summary>
        public const string PABUM8 = "PABUM8";

        /// <summary>
        /// PAOVOL.
        /// </summary>
        public const string PAOVOL = "PAOVOL";

        /// <summary>
        /// PABUM2.
        /// </summary>
        public const string PABUM2 = "PABUM2";

        /// <summary>
        /// PARDTM.
        /// </summary>
        public const string PARDTM = "PARDTM";

        /// <summary>
        /// PADTE.
        /// </summary>
        public const string PADTE = "PADTE";

        /// <summary>
        /// PAMETN.
        /// </summary>
        public const string PAMETN = "PAMETN";

        /// <summary>
        /// PAOPNR.
        /// </summary>
        public const string PAOPNR = "PAOPNR";

        /// <summary>
        /// PAPNCR.
        /// </summary>
        public const string PAPNCR = "PAPNCR";

        /// <summary>
        /// PAVEHI.
        /// </summary>
        public const string PAVEHI = "PAVEHI";

        /// <summary>
        /// PAVMCU.
        /// </summary>
        public const string PAVMCU = "PAVMCU";

        /// <summary>
        /// PATRP.
        /// </summary>
        public const string PATRP = "PATRP";

        /// <summary>
        /// PACMPN.
        /// </summary>
        public const string PACMPN = "PACMPN";

        /// <summary>
        /// PABFWT.
        /// </summary>
        public const string PABFWT = "PABFWT";

        /// <summary>
        /// PABWTU.
        /// </summary>
        public const string PABWTU = "PABWTU";

        /// <summary>
        /// PAAFWT.
        /// </summary>
        public const string PAAFWT = "PAAFWT";

        /// <summary>
        /// PAAWTU.
        /// </summary>
        public const string PAAWTU = "PAAWTU";

        /// <summary>
        /// PATHDT.
        /// </summary>
        public const string PATHDT = "PATHDT";

        /// <summary>
        /// PAOPDT.
        /// </summary>
        public const string PAOPDT = "PAOPDT";

        /// <summary>
        /// PALRST.
        /// </summary>
        public const string PALRST = "PALRST";

        /// <summary>
        /// PARECS.
        /// </summary>
        public const string PARECS = "PARECS";

        /// <summary>
        /// PAPGMS.
        /// </summary>
        public const string PAPGMS = "PAPGMS";

        /// <summary>
        /// PAGLRN.
        /// </summary>
        public const string PAGLRN = "PAGLRN";

        /// <summary>
        /// PAPTNR.
        /// </summary>
        public const string PAPTNR = "PAPTNR";

        /// <summary>
        /// PAURCD.
        /// </summary>
        public const string PAURCD = "PAURCD";

        /// <summary>
        /// PAURAT.
        /// </summary>
        public const string PAURAT = "PAURAT";

        /// <summary>
        /// PAURAB.
        /// </summary>
        public const string PAURAB = "PAURAB";

        /// <summary>
        /// PAURRF.
        /// </summary>
        public const string PAURRF = "PAURRF";

        /// <summary>
        /// PAURDT.
        /// </summary>
        public const string PAURDT = "PAURDT";

        /// <summary>
        /// PAUSER.
        /// </summary>
        public const string PAUSER = "PAUSER";

        /// <summary>
        /// PAPID.
        /// </summary>
        public const string PAPID = "PAPID";

        /// <summary>
        /// PAJOBN.
        /// </summary>
        public const string PAJOBN = "PAJOBN";

        /// <summary>
        /// PAUPMJ.
        /// </summary>
        public const string PAUPMJ = "PAUPMJ";

        /// <summary>
        /// PATDAY.
        /// </summary>
        public const string PATDAY = "PATDAY";

        /// <summary>
        /// PAUKID.
        /// </summary>
        public const string PAUKID = "PAUKID";

        /// <summary>
        /// PABPAS.
        /// </summary>
        public const string PABPAS = "PABPAS";

        /// <summary>
        /// PALOTC.
        /// </summary>
        public const string PALOTC = "PALOTC";
    }

    /// <inheritdoc />
    public override string TableName => "F41511";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PADOC", "PADOC", JdeDataType.Numeric),
        new JdeField("PADCT", "PADCT", JdeDataType.String, 4),
        new JdeField("PAKCO", "PAKCO", JdeDataType.String, 10),
        new JdeField("PAJELN", "PAJELN", JdeDataType.Numeric),
        new JdeField("PADOCO", "PADOCO", JdeDataType.Numeric),
        new JdeField("PADCTO", "PADCTO", JdeDataType.String, 4),
        new JdeField("PAKCOO", "PAKCOO", JdeDataType.String, 10),
        new JdeField("PALNID", "PALNID", JdeDataType.Numeric),
        new JdeField("PANLIN", "PANLIN", JdeDataType.Numeric),
        new JdeField("PADGL", "PADGL", JdeDataType.Numeric),
        new JdeField("PATRDJ", "PATRDJ", JdeDataType.Numeric),
        new JdeField("PAICU", "PAICU", JdeDataType.Numeric),
        new JdeField("PATRCD", "PATRCD", JdeDataType.String, 2),
        new JdeField("PAMCU", "PAMCU", JdeDataType.String, 24),
        new JdeField("PATKID", "PATKID", JdeDataType.String, 16),
        new JdeField("PAITM", "PAITM", JdeDataType.Numeric),
        new JdeField("PATRNO", "PATRNO", JdeDataType.Numeric),
        new JdeField("PATEMP", "PATEMP", JdeDataType.Numeric),
        new JdeField("PASTPU", "PASTPU", JdeDataType.String, 2),
        new JdeField("PADNTY", "PADNTY", JdeDataType.Numeric),
        new JdeField("PADNTP", "PADNTP", JdeDataType.String, 2),
        new JdeField("PADETP", "PADETP", JdeDataType.Numeric),
        new JdeField("PADTPU", "PADTPU", JdeDataType.String, 2),
        new JdeField("PAAMBR", "PAAMBR", JdeDataType.Numeric),
        new JdeField("PABUM3", "PABUM3", JdeDataType.String, 4),
        new JdeField("PAAMBI", "PAAMBI", JdeDataType.Numeric),
        new JdeField("PAAMBU", "PAAMBU", JdeDataType.String, 4),
        new JdeField("PAVCF", "PAVCF", JdeDataType.Numeric),
        new JdeField("PASTOK", "PASTOK", JdeDataType.Numeric),
        new JdeField("PABUM4", "PABUM4", JdeDataType.String, 4),
        new JdeField("PAWGTR", "PAWGTR", JdeDataType.Numeric),
        new JdeField("PABUM5", "PABUM5", JdeDataType.String, 4),
        new JdeField("PASTUM", "PASTUM", JdeDataType.Numeric),
        new JdeField("PABUM6", "PABUM6", JdeDataType.String, 4),
        new JdeField("PARCD", "PARCD", JdeDataType.String, 6),
        new JdeField("PAUPCF", "PAUPCF", JdeDataType.String, 2),
        new JdeField("PALOTN", "PALOTN", JdeDataType.String, 60),
        new JdeField("PALOTS", "PALOTS", JdeDataType.String, 2),
        new JdeField("PAMMEJ", "PAMMEJ", JdeDataType.Numeric),
        new JdeField("PAUNCS", "PAUNCS", JdeDataType.Numeric),
        new JdeField("PAECST", "PAECST", JdeDataType.Numeric),
        new JdeField("PATREX", "PATREX", JdeDataType.String, 60),
        new JdeField("PAAN8", "PAAN8", JdeDataType.Numeric),
        new JdeField("PADMCT", "PADMCT", JdeDataType.String, 24),
        new JdeField("PADMCS", "PADMCS", JdeDataType.Numeric),
        new JdeField("PAACOR", "PAACOR", JdeDataType.String, 2),
        new JdeField("PAHCOR", "PAHCOR", JdeDataType.String, 2),
        new JdeField("PADIPT", "PADIPT", JdeDataType.String, 2),
        new JdeField("PAGDIP", "PAGDIP", JdeDataType.Numeric),
        new JdeField("PAWDIP", "PAWDIP", JdeDataType.Numeric),
        new JdeField("PAVAPP", "PAVAPP", JdeDataType.Numeric),
        new JdeField("PAPREU", "PAPREU", JdeDataType.String, 4),
        new JdeField("PALPGV", "PALPGV", JdeDataType.Numeric),
        new JdeField("PATPU1", "PATPU1", JdeDataType.String, 2),
        new JdeField("PASLIP", "PASLIP", JdeDataType.String, 2),
        new JdeField("PAVAPW", "PAVAPW", JdeDataType.Numeric),
        new JdeField("PABUM0", "PABUM0", JdeDataType.String, 4),
        new JdeField("PAVAPV", "PAVAPV", JdeDataType.Numeric),
        new JdeField("PABUM9", "PABUM9", JdeDataType.String, 4),
        new JdeField("PALIQW", "PALIQW", JdeDataType.Numeric),
        new JdeField("PABUM7", "PABUM7", JdeDataType.String, 4),
        new JdeField("PALIQV", "PALIQV", JdeDataType.Numeric),
        new JdeField("PABUM8", "PABUM8", JdeDataType.String, 4),
        new JdeField("PAOVOL", "PAOVOL", JdeDataType.Numeric),
        new JdeField("PABUM2", "PABUM2", JdeDataType.String, 4),
        new JdeField("PARDTM", "PARDTM", JdeDataType.Numeric),
        new JdeField("PADTE", "PADTE", JdeDataType.Numeric),
        new JdeField("PAMETN", "PAMETN", JdeDataType.String, 20),
        new JdeField("PAOPNR", "PAOPNR", JdeDataType.Numeric),
        new JdeField("PAPNCR", "PAPNCR", JdeDataType.Numeric),
        new JdeField("PAVEHI", "PAVEHI", JdeDataType.String, 24),
        new JdeField("PAVMCU", "PAVMCU", JdeDataType.String, 24),
        new JdeField("PATRP", "PATRP", JdeDataType.Numeric),
        new JdeField("PACMPN", "PACMPN", JdeDataType.Numeric),
        new JdeField("PABFWT", "PABFWT", JdeDataType.Numeric),
        new JdeField("PABWTU", "PABWTU", JdeDataType.String, 4),
        new JdeField("PAAFWT", "PAAFWT", JdeDataType.Numeric),
        new JdeField("PAAWTU", "PAAWTU", JdeDataType.String, 4),
        new JdeField("PATHDT", "PATHDT", JdeDataType.Numeric),
        new JdeField("PAOPDT", "PAOPDT", JdeDataType.Numeric),
        new JdeField("PALRST", "PALRST", JdeDataType.Numeric),
        new JdeField("PARECS", "PARECS", JdeDataType.String, 2),
        new JdeField("PAPGMS", "PAPGMS", JdeDataType.String, 2),
        new JdeField("PAGLRN", "PAGLRN", JdeDataType.Numeric),
        new JdeField("PAPTNR", "PAPTNR", JdeDataType.Numeric),
        new JdeField("PAURCD", "PAURCD", JdeDataType.String, 4),
        new JdeField("PAURAT", "PAURAT", JdeDataType.Numeric),
        new JdeField("PAURAB", "PAURAB", JdeDataType.Numeric),
        new JdeField("PAURRF", "PAURRF", JdeDataType.String, 30),
        new JdeField("PAURDT", "PAURDT", JdeDataType.Numeric),
        new JdeField("PAUSER", "PAUSER", JdeDataType.String, 20),
        new JdeField("PAPID", "PAPID", JdeDataType.String, 20),
        new JdeField("PAJOBN", "PAJOBN", JdeDataType.String, 20),
        new JdeField("PAUPMJ", "PAUPMJ", JdeDataType.Numeric),
        new JdeField("PATDAY", "PATDAY", JdeDataType.Numeric),
        new JdeField("PAUKID", "PAUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PABPAS", "PABPAS", JdeDataType.String, 2),
        new JdeField("PALOTC", "PALOTC", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41511_0", "Primary Key on PAUKID", new[] { "PAUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41511_2", "Index on PADOC, PADCT, PAKCO, PATRNO, PATRCD, PATKID, PAMETN", new[] { "PADOC", "PADCT", "PAKCO", "PATRNO", "PATRCD", "PATKID", "PAMETN" }),
        new JdeIndex("F41511_3", "Index on PATRCD, PAMCU, PATKID, PAITM, PADTE, PARDTM", new[] { "PATRCD", "PAMCU", "PATKID", "PAITM", "PADTE", "PARDTM" }),
        new JdeIndex("F41511_4", "Index on SYS_NC00099$, SYS_NC00100$, SYS_NC00101$", new[] { "SYS_NC00099$", "SYS_NC00100$", "SYS_NC00101$" }),
        new JdeIndex("F41511_5", "Index on PAMCU, PAITM, PATKID, PATRCD, SYS_NC00102$, SYS_NC00103$", new[] { "PAMCU", "PAITM", "PATKID", "PATRCD", "SYS_NC00102$", "SYS_NC00103$" }),
        new JdeIndex("F41511_6", "Index on PAMCU, PATKID, PATRCD, SYS_NC00101$, PARECS, SYS_NC00103$", new[] { "PAMCU", "PATKID", "PATRCD", "SYS_NC00101$", "PARECS", "SYS_NC00103$" })
    };
}
