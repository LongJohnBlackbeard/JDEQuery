using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15017Z1 - .
/// </summary>
public class F15017Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LDEDUS.
        /// </summary>
        public const string LDEDUS = "LDEDUS";

        /// <summary>
        /// LDEDBT.
        /// </summary>
        public const string LDEDBT = "LDEDBT";

        /// <summary>
        /// LDEDTN.
        /// </summary>
        public const string LDEDTN = "LDEDTN";

        /// <summary>
        /// LDEDLN.
        /// </summary>
        public const string LDEDLN = "LDEDLN";

        /// <summary>
        /// LDEDCT.
        /// </summary>
        public const string LDEDCT = "LDEDCT";

        /// <summary>
        /// LDTYTN.
        /// </summary>
        public const string LDTYTN = "LDTYTN";

        /// <summary>
        /// LDEDFT.
        /// </summary>
        public const string LDEDFT = "LDEDFT";

        /// <summary>
        /// LDEDDT.
        /// </summary>
        public const string LDEDDT = "LDEDDT";

        /// <summary>
        /// LDDRIN.
        /// </summary>
        public const string LDDRIN = "LDDRIN";

        /// <summary>
        /// LDEDDL.
        /// </summary>
        public const string LDEDDL = "LDEDDL";

        /// <summary>
        /// LDEDSP.
        /// </summary>
        public const string LDEDSP = "LDEDSP";

        /// <summary>
        /// LDPNID.
        /// </summary>
        public const string LDPNID = "LDPNID";

        /// <summary>
        /// LDTNAC.
        /// </summary>
        public const string LDTNAC = "LDTNAC";

        /// <summary>
        /// LDUSER.
        /// </summary>
        public const string LDUSER = "LDUSER";

        /// <summary>
        /// LDPID.
        /// </summary>
        public const string LDPID = "LDPID";

        /// <summary>
        /// LDJOBN.
        /// </summary>
        public const string LDJOBN = "LDJOBN";

        /// <summary>
        /// LDUPMJ.
        /// </summary>
        public const string LDUPMJ = "LDUPMJ";

        /// <summary>
        /// LDTDAY.
        /// </summary>
        public const string LDTDAY = "LDTDAY";

        /// <summary>
        /// LDDOCO.
        /// </summary>
        public const string LDDOCO = "LDDOCO";

        /// <summary>
        /// LDLSVR.
        /// </summary>
        public const string LDLSVR = "LDLSVR";

        /// <summary>
        /// LDMCU.
        /// </summary>
        public const string LDMCU = "LDMCU";

        /// <summary>
        /// LDUNIT.
        /// </summary>
        public const string LDUNIT = "LDUNIT";

        /// <summary>
        /// LDAN8A.
        /// </summary>
        public const string LDAN8A = "LDAN8A";

        /// <summary>
        /// LDAN8S.
        /// </summary>
        public const string LDAN8S = "LDAN8S";

        /// <summary>
        /// LDMCUS.
        /// </summary>
        public const string LDMCUS = "LDMCUS";

        /// <summary>
        /// LDSIC2.
        /// </summary>
        public const string LDSIC2 = "LDSIC2";

        /// <summary>
        /// LDMIDT.
        /// </summary>
        public const string LDMIDT = "LDMIDT";

        /// <summary>
        /// LDSPAD.
        /// </summary>
        public const string LDSPAD = "LDSPAD";

        /// <summary>
        /// LDMODT.
        /// </summary>
        public const string LDMODT = "LDMODT";

        /// <summary>
        /// LDSBDT.
        /// </summary>
        public const string LDSBDT = "LDSBDT";

        /// <summary>
        /// LDRNTA.
        /// </summary>
        public const string LDRNTA = "LDRNTA";

        /// <summary>
        /// LDUSEA.
        /// </summary>
        public const string LDUSEA = "LDUSEA";

        /// <summary>
        /// LDRM01.
        /// </summary>
        public const string LDRM01 = "LDRM01";

        /// <summary>
        /// LDRM02.
        /// </summary>
        public const string LDRM02 = "LDRM02";

        /// <summary>
        /// LDRM03.
        /// </summary>
        public const string LDRM03 = "LDRM03";

        /// <summary>
        /// LDRM04.
        /// </summary>
        public const string LDRM04 = "LDRM04";

        /// <summary>
        /// LDRM05.
        /// </summary>
        public const string LDRM05 = "LDRM05";

        /// <summary>
        /// LDRM06.
        /// </summary>
        public const string LDRM06 = "LDRM06";

        /// <summary>
        /// LDRM07.
        /// </summary>
        public const string LDRM07 = "LDRM07";

        /// <summary>
        /// LDRM08.
        /// </summary>
        public const string LDRM08 = "LDRM08";

        /// <summary>
        /// LDRM09.
        /// </summary>
        public const string LDRM09 = "LDRM09";

        /// <summary>
        /// LDRM10.
        /// </summary>
        public const string LDRM10 = "LDRM10";

        /// <summary>
        /// LDUNGP.
        /// </summary>
        public const string LDUNGP = "LDUNGP";

        /// <summary>
        /// LDUTTY.
        /// </summary>
        public const string LDUTTY = "LDUTTY";

        /// <summary>
        /// LDUTUS.
        /// </summary>
        public const string LDUTUS = "LDUTUS";

        /// <summary>
        /// LDWTDL.
        /// </summary>
        public const string LDWTDL = "LDWTDL";

        /// <summary>
        /// LDCO.
        /// </summary>
        public const string LDCO = "LDCO";

        /// <summary>
        /// LDSMCU.
        /// </summary>
        public const string LDSMCU = "LDSMCU";

        /// <summary>
        /// LDDBUI.
        /// </summary>
        public const string LDDBUI = "LDDBUI";

        /// <summary>
        /// LDSPND.
        /// </summary>
        public const string LDSPND = "LDSPND";

        /// <summary>
        /// LDDBAN.
        /// </summary>
        public const string LDDBAN = "LDDBAN";

        /// <summary>
        /// LDARA1.
        /// </summary>
        public const string LDARA1 = "LDARA1";

        /// <summary>
        /// LDAAT1.
        /// </summary>
        public const string LDAAT1 = "LDAAT1";

        /// <summary>
        /// LDARA2.
        /// </summary>
        public const string LDARA2 = "LDARA2";

        /// <summary>
        /// LDAAT2.
        /// </summary>
        public const string LDAAT2 = "LDAAT2";

        /// <summary>
        /// LDARA3.
        /// </summary>
        public const string LDARA3 = "LDARA3";

        /// <summary>
        /// LDAAT3.
        /// </summary>
        public const string LDAAT3 = "LDAAT3";

        /// <summary>
        /// LDCMTB.
        /// </summary>
        public const string LDCMTB = "LDCMTB";

        /// <summary>
        /// LDCMTE.
        /// </summary>
        public const string LDCMTE = "LDCMTE";

        /// <summary>
        /// LDDEAL.
        /// </summary>
        public const string LDDEAL = "LDDEAL";

        /// <summary>
        /// LDURCD.
        /// </summary>
        public const string LDURCD = "LDURCD";

        /// <summary>
        /// LDURDT.
        /// </summary>
        public const string LDURDT = "LDURDT";

        /// <summary>
        /// LDURAT.
        /// </summary>
        public const string LDURAT = "LDURAT";

        /// <summary>
        /// LDURAB.
        /// </summary>
        public const string LDURAB = "LDURAB";

        /// <summary>
        /// LDURRF.
        /// </summary>
        public const string LDURRF = "LDURRF";

        /// <summary>
        /// LDENTJ.
        /// </summary>
        public const string LDENTJ = "LDENTJ";

        /// <summary>
        /// LDTORG.
        /// </summary>
        public const string LDTORG = "LDTORG";

        /// <summary>
        /// LDCRR.
        /// </summary>
        public const string LDCRR = "LDCRR";

        /// <summary>
        /// LDCRCD.
        /// </summary>
        public const string LDCRCD = "LDCRCD";

        /// <summary>
        /// LDCRRM.
        /// </summary>
        public const string LDCRRM = "LDCRRM";

        /// <summary>
        /// LDLELC.
        /// </summary>
        public const string LDLELC = "LDLELC";

        /// <summary>
        /// LDLERCEO.
        /// </summary>
        public const string LDLERCEO = "LDLERCEO";

        /// <summary>
        /// LDLESPA.
        /// </summary>
        public const string LDLESPA = "LDLESPA";

        /// <summary>
        /// LDLETO.
        /// </summary>
        public const string LDLETO = "LDLETO";

        /// <summary>
        /// LDLEFVBD.
        /// </summary>
        public const string LDLEFVBD = "LDLEFVBD";

        /// <summary>
        /// LDLEFVED.
        /// </summary>
        public const string LDLEFVED = "LDLEFVED";

        /// <summary>
        /// LDLEPGRV.
        /// </summary>
        public const string LDLEPGRV = "LDLEPGRV";

        /// <summary>
        /// LDLEFGRV.
        /// </summary>
        public const string LDLEFGRV = "LDLEFGRV";

        /// <summary>
        /// LDLEGRP.
        /// </summary>
        public const string LDLEGRP = "LDLEGRP";

        /// <summary>
        /// LDLEPOA.
        /// </summary>
        public const string LDLEPOA = "LDLEPOA";

        /// <summary>
        /// LDLEOP.
        /// </summary>
        public const string LDLEOP = "LDLEOP";

        /// <summary>
        /// LDLERLL.
        /// </summary>
        public const string LDLERLL = "LDLERLL";

        /// <summary>
        /// LDLEDC11.
        /// </summary>
        public const string LDLEDC11 = "LDLEDC11";

        /// <summary>
        /// LDLEDC12.
        /// </summary>
        public const string LDLEDC12 = "LDLEDC12";

        /// <summary>
        /// LDLEDC13.
        /// </summary>
        public const string LDLEDC13 = "LDLEDC13";

        /// <summary>
        /// LDLEDC14.
        /// </summary>
        public const string LDLEDC14 = "LDLEDC14";

        /// <summary>
        /// LDLEDC15.
        /// </summary>
        public const string LDLEDC15 = "LDLEDC15";

        /// <summary>
        /// LDICU.
        /// </summary>
        public const string LDICU = "LDICU";

        /// <summary>
        /// LDLELLS.
        /// </summary>
        public const string LDLELLS = "LDLELLS";

        /// <summary>
        /// LDLELCD.
        /// </summary>
        public const string LDLELCD = "LDLELCD";

        /// <summary>
        /// LDLESIR.
        /// </summary>
        public const string LDLESIR = "LDLESIR";

        /// <summary>
        /// LDLEJTD.
        /// </summary>
        public const string LDLEJTD = "LDLEJTD";

        /// <summary>
        /// LDOLSE.
        /// </summary>
        public const string LDOLSE = "LDOLSE";

        /// <summary>
        /// LDLZNPA.
        /// </summary>
        public const string LDLZNPA = "LDLZNPA";

        /// <summary>
        /// LDNUMB.
        /// </summary>
        public const string LDNUMB = "LDNUMB";

        /// <summary>
        /// LDLEBR.
        /// </summary>
        public const string LDLEBR = "LDLEBR";

        /// <summary>
        /// LDLZRED.
        /// </summary>
        public const string LDLZRED = "LDLZRED";
    }

    /// <inheritdoc />
    public override string TableName => "F15017Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LDEDUS", "LDEDUS", JdeDataType.String, 20, true, true),
        new JdeField("LDEDBT", "LDEDBT", JdeDataType.String, 30, true, true),
        new JdeField("LDEDTN", "LDEDTN", JdeDataType.String, 44, true, true),
        new JdeField("LDEDLN", "LDEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("LDEDCT", "LDEDCT", JdeDataType.String, 4),
        new JdeField("LDTYTN", "LDTYTN", JdeDataType.String, 16),
        new JdeField("LDEDFT", "LDEDFT", JdeDataType.String, 20),
        new JdeField("LDEDDT", "LDEDDT", JdeDataType.Numeric),
        new JdeField("LDDRIN", "LDDRIN", JdeDataType.String, 2),
        new JdeField("LDEDDL", "LDEDDL", JdeDataType.Numeric),
        new JdeField("LDEDSP", "LDEDSP", JdeDataType.String, 2),
        new JdeField("LDPNID", "LDPNID", JdeDataType.String, 30),
        new JdeField("LDTNAC", "LDTNAC", JdeDataType.String, 4),
        new JdeField("LDUSER", "LDUSER", JdeDataType.String, 20),
        new JdeField("LDPID", "LDPID", JdeDataType.String, 20),
        new JdeField("LDJOBN", "LDJOBN", JdeDataType.String, 20),
        new JdeField("LDUPMJ", "LDUPMJ", JdeDataType.Numeric),
        new JdeField("LDTDAY", "LDTDAY", JdeDataType.Numeric),
        new JdeField("LDDOCO", "LDDOCO", JdeDataType.Numeric),
        new JdeField("LDLSVR", "LDLSVR", JdeDataType.Numeric),
        new JdeField("LDMCU", "LDMCU", JdeDataType.String, 24),
        new JdeField("LDUNIT", "LDUNIT", JdeDataType.String, 16),
        new JdeField("LDAN8A", "LDAN8A", JdeDataType.Numeric),
        new JdeField("LDAN8S", "LDAN8S", JdeDataType.Numeric),
        new JdeField("LDMCUS", "LDMCUS", JdeDataType.String, 24),
        new JdeField("LDSIC2", "LDSIC2", JdeDataType.String, 20),
        new JdeField("LDMIDT", "LDMIDT", JdeDataType.Numeric),
        new JdeField("LDSPAD", "LDSPAD", JdeDataType.Numeric),
        new JdeField("LDMODT", "LDMODT", JdeDataType.Numeric),
        new JdeField("LDSBDT", "LDSBDT", JdeDataType.Numeric),
        new JdeField("LDRNTA", "LDRNTA", JdeDataType.Numeric),
        new JdeField("LDUSEA", "LDUSEA", JdeDataType.Numeric),
        new JdeField("LDRM01", "LDRM01", JdeDataType.String, 6),
        new JdeField("LDRM02", "LDRM02", JdeDataType.String, 6),
        new JdeField("LDRM03", "LDRM03", JdeDataType.String, 6),
        new JdeField("LDRM04", "LDRM04", JdeDataType.String, 6),
        new JdeField("LDRM05", "LDRM05", JdeDataType.String, 6),
        new JdeField("LDRM06", "LDRM06", JdeDataType.String, 6),
        new JdeField("LDRM07", "LDRM07", JdeDataType.String, 6),
        new JdeField("LDRM08", "LDRM08", JdeDataType.String, 6),
        new JdeField("LDRM09", "LDRM09", JdeDataType.String, 6),
        new JdeField("LDRM10", "LDRM10", JdeDataType.String, 6),
        new JdeField("LDUNGP", "LDUNGP", JdeDataType.String, 6),
        new JdeField("LDUTTY", "LDUTTY", JdeDataType.String, 10),
        new JdeField("LDUTUS", "LDUTUS", JdeDataType.String, 2),
        new JdeField("LDWTDL", "LDWTDL", JdeDataType.Numeric),
        new JdeField("LDCO", "LDCO", JdeDataType.String, 10),
        new JdeField("LDSMCU", "LDSMCU", JdeDataType.String, 24),
        new JdeField("LDDBUI", "LDDBUI", JdeDataType.String, 2),
        new JdeField("LDSPND", "LDSPND", JdeDataType.Numeric),
        new JdeField("LDDBAN", "LDDBAN", JdeDataType.Numeric),
        new JdeField("LDARA1", "LDARA1", JdeDataType.Numeric),
        new JdeField("LDAAT1", "LDAAT1", JdeDataType.String, 6),
        new JdeField("LDARA2", "LDARA2", JdeDataType.Numeric),
        new JdeField("LDAAT2", "LDAAT2", JdeDataType.String, 6),
        new JdeField("LDARA3", "LDARA3", JdeDataType.Numeric),
        new JdeField("LDAAT3", "LDAAT3", JdeDataType.String, 6),
        new JdeField("LDCMTB", "LDCMTB", JdeDataType.Numeric),
        new JdeField("LDCMTE", "LDCMTE", JdeDataType.Numeric),
        new JdeField("LDDEAL", "LDDEAL", JdeDataType.String, 16),
        new JdeField("LDURCD", "LDURCD", JdeDataType.String, 4),
        new JdeField("LDURDT", "LDURDT", JdeDataType.Numeric),
        new JdeField("LDURAT", "LDURAT", JdeDataType.Numeric),
        new JdeField("LDURAB", "LDURAB", JdeDataType.Numeric),
        new JdeField("LDURRF", "LDURRF", JdeDataType.String, 30),
        new JdeField("LDENTJ", "LDENTJ", JdeDataType.Numeric),
        new JdeField("LDTORG", "LDTORG", JdeDataType.String, 20),
        new JdeField("LDCRR", "LDCRR", JdeDataType.Numeric),
        new JdeField("LDCRCD", "LDCRCD", JdeDataType.String, 6),
        new JdeField("LDCRRM", "LDCRRM", JdeDataType.String, 2),
        new JdeField("LDLELC", "LDLELC", JdeDataType.String, 2),
        new JdeField("LDLERCEO", "LDLERCEO", JdeDataType.String, 2),
        new JdeField("LDLESPA", "LDLESPA", JdeDataType.String, 2),
        new JdeField("LDLETO", "LDLETO", JdeDataType.String, 2),
        new JdeField("LDLEFVBD", "LDLEFVBD", JdeDataType.Numeric),
        new JdeField("LDLEFVED", "LDLEFVED", JdeDataType.Numeric),
        new JdeField("LDLEPGRV", "LDLEPGRV", JdeDataType.Numeric),
        new JdeField("LDLEFGRV", "LDLEFGRV", JdeDataType.Numeric),
        new JdeField("LDLEGRP", "LDLEGRP", JdeDataType.Numeric),
        new JdeField("LDLEPOA", "LDLEPOA", JdeDataType.Numeric),
        new JdeField("LDLEOP", "LDLEOP", JdeDataType.Numeric),
        new JdeField("LDLERLL", "LDLERLL", JdeDataType.String, 2),
        new JdeField("LDLEDC11", "LDLEDC11", JdeDataType.String, 20),
        new JdeField("LDLEDC12", "LDLEDC12", JdeDataType.String, 20),
        new JdeField("LDLEDC13", "LDLEDC13", JdeDataType.String, 20),
        new JdeField("LDLEDC14", "LDLEDC14", JdeDataType.String, 20),
        new JdeField("LDLEDC15", "LDLEDC15", JdeDataType.String, 20),
        new JdeField("LDICU", "LDICU", JdeDataType.Numeric),
        new JdeField("LDLELLS", "LDLELLS", JdeDataType.String, 4),
        new JdeField("LDLELCD", "LDLELCD", JdeDataType.Numeric),
        new JdeField("LDLESIR", "LDLESIR", JdeDataType.String, 2),
        new JdeField("LDLEJTD", "LDLEJTD", JdeDataType.Numeric),
        new JdeField("LDOLSE", "LDOLSE", JdeDataType.String, 50),
        new JdeField("LDLZNPA", "LDLZNPA", JdeDataType.String, 2),
        new JdeField("LDNUMB", "LDNUMB", JdeDataType.Numeric),
        new JdeField("LDLEBR", "LDLEBR", JdeDataType.Numeric),
        new JdeField("LDLZRED", "LDLZRED", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15017Z1_0", "Primary Key on LDEDUS, LDEDBT, LDEDTN, LDEDLN", new[] { "LDEDUS", "LDEDBT", "LDEDTN", "LDEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
