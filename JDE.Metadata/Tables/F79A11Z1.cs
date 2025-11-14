using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A11Z1 - .
/// </summary>
public class F79A11Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLEDUS.
        /// </summary>
        public const string GLEDUS = "GLEDUS";

        /// <summary>
        /// GLEDTY.
        /// </summary>
        public const string GLEDTY = "GLEDTY";

        /// <summary>
        /// GLEDSQ.
        /// </summary>
        public const string GLEDSQ = "GLEDSQ";

        /// <summary>
        /// GLEDTN.
        /// </summary>
        public const string GLEDTN = "GLEDTN";

        /// <summary>
        /// GLEDCT.
        /// </summary>
        public const string GLEDCT = "GLEDCT";

        /// <summary>
        /// GLEDTS.
        /// </summary>
        public const string GLEDTS = "GLEDTS";

        /// <summary>
        /// GLEDLN.
        /// </summary>
        public const string GLEDLN = "GLEDLN";

        /// <summary>
        /// GLEDFT.
        /// </summary>
        public const string GLEDFT = "GLEDFT";

        /// <summary>
        /// GLEDDT.
        /// </summary>
        public const string GLEDDT = "GLEDDT";

        /// <summary>
        /// GLEDER.
        /// </summary>
        public const string GLEDER = "GLEDER";

        /// <summary>
        /// GLEDDL.
        /// </summary>
        public const string GLEDDL = "GLEDDL";

        /// <summary>
        /// GLEDSP.
        /// </summary>
        public const string GLEDSP = "GLEDSP";

        /// <summary>
        /// GLEDTC.
        /// </summary>
        public const string GLEDTC = "GLEDTC";

        /// <summary>
        /// GLEDTR.
        /// </summary>
        public const string GLEDTR = "GLEDTR";

        /// <summary>
        /// GLEDBT.
        /// </summary>
        public const string GLEDBT = "GLEDBT";

        /// <summary>
        /// GLEDGL.
        /// </summary>
        public const string GLEDGL = "GLEDGL";

        /// <summary>
        /// GLEDDH.
        /// </summary>
        public const string GLEDDH = "GLEDDH";

        /// <summary>
        /// GLEDAN.
        /// </summary>
        public const string GLEDAN = "GLEDAN";

        /// <summary>
        /// GLUKID.
        /// </summary>
        public const string GLUKID = "GLUKID";

        /// <summary>
        /// GLKCO.
        /// </summary>
        public const string GLKCO = "GLKCO";

        /// <summary>
        /// GLDCT.
        /// </summary>
        public const string GLDCT = "GLDCT";

        /// <summary>
        /// GLDOC.
        /// </summary>
        public const string GLDOC = "GLDOC";

        /// <summary>
        /// GLSFX.
        /// </summary>
        public const string GLSFX = "GLSFX";

        /// <summary>
        /// GLSFXE.
        /// </summary>
        public const string GLSFXE = "GLSFXE";

        /// <summary>
        /// GLLNID.
        /// </summary>
        public const string GLLNID = "GLLNID";

        /// <summary>
        /// GLAN8.
        /// </summary>
        public const string GLAN8 = "GLAN8";

        /// <summary>
        /// GLMMCU.
        /// </summary>
        public const string GLMMCU = "GLMMCU";

        /// <summary>
        /// GLITM.
        /// </summary>
        public const string GLITM = "GLITM";

        /// <summary>
        /// GLLITM.
        /// </summary>
        public const string GLLITM = "GLLITM";

        /// <summary>
        /// GLAITM.
        /// </summary>
        public const string GLAITM = "GLAITM";

        /// <summary>
        /// GLTRQT.
        /// </summary>
        public const string GLTRQT = "GLTRQT";

        /// <summary>
        /// GLUOM1.
        /// </summary>
        public const string GLUOM1 = "GLUOM1";

        /// <summary>
        /// GLTREX.
        /// </summary>
        public const string GLTREX = "GLTREX";

        /// <summary>
        /// GLTRDJ.
        /// </summary>
        public const string GLTRDJ = "GLTRDJ";

        /// <summary>
        /// GL79ADGHG.
        /// </summary>
        public const string GL79ADGHG = "GL79ADGHG";

        /// <summary>
        /// GLCTRY.
        /// </summary>
        public const string GLCTRY = "GLCTRY";

        /// <summary>
        /// GLFY.
        /// </summary>
        public const string GLFY = "GLFY";

        /// <summary>
        /// GLPN.
        /// </summary>
        public const string GLPN = "GLPN";

        /// <summary>
        /// GL79AGESID.
        /// </summary>
        public const string GL79AGESID = "GL79AGESID";

        /// <summary>
        /// GL79ASRC.
        /// </summary>
        public const string GL79ASRC = "GL79ASRC";

        /// <summary>
        /// GL79AEMSC.
        /// </summary>
        public const string GL79AEMSC = "GL79AEMSC";

        /// <summary>
        /// GL79AGCUM.
        /// </summary>
        public const string GL79AGCUM = "GL79AGCUM";

        /// <summary>
        /// GL79AEUQTY.
        /// </summary>
        public const string GL79AEUQTY = "GL79AEUQTY";

        /// <summary>
        /// GL79AEGJ.
        /// </summary>
        public const string GL79AEGJ = "GL79AEGJ";

        /// <summary>
        /// GL79ACO2Q.
        /// </summary>
        public const string GL79ACO2Q = "GL79ACO2Q";

        /// <summary>
        /// GLRE.
        /// </summary>
        public const string GLRE = "GLRE";

        /// <summary>
        /// GL79AGRCD.
        /// </summary>
        public const string GL79AGRCD = "GL79AGRCD";

        /// <summary>
        /// GL79AGS01.
        /// </summary>
        public const string GL79AGS01 = "GL79AGS01";

        /// <summary>
        /// GL79AGS02.
        /// </summary>
        public const string GL79AGS02 = "GL79AGS02";

        /// <summary>
        /// GLCOUN.
        /// </summary>
        public const string GLCOUN = "GLCOUN";

        /// <summary>
        /// GLADDS.
        /// </summary>
        public const string GLADDS = "GLADDS";

        /// <summary>
        /// GLCTR.
        /// </summary>
        public const string GLCTR = "GLCTR";

        /// <summary>
        /// GLNUMB.
        /// </summary>
        public const string GLNUMB = "GLNUMB";

        /// <summary>
        /// GLASII.
        /// </summary>
        public const string GLASII = "GLASII";

        /// <summary>
        /// GL79AGELT.
        /// </summary>
        public const string GL79AGELT = "GL79AGELT";

        /// <summary>
        /// GL79AVN01.
        /// </summary>
        public const string GL79AVN01 = "GL79AVN01";

        /// <summary>
        /// GLCRCD.
        /// </summary>
        public const string GLCRCD = "GLCRCD";

        /// <summary>
        /// GLCRR.
        /// </summary>
        public const string GLCRR = "GLCRR";

        /// <summary>
        /// GLBCRC.
        /// </summary>
        public const string GLBCRC = "GLBCRC";

        /// <summary>
        /// GL79ABV01.
        /// </summary>
        public const string GL79ABV01 = "GL79ABV01";

        /// <summary>
        /// GL79AGCRIT.
        /// </summary>
        public const string GL79AGCRIT = "GL79AGCRIT";

        /// <summary>
        /// GLMCU.
        /// </summary>
        public const string GLMCU = "GLMCU";

        /// <summary>
        /// GL79AGBNO.
        /// </summary>
        public const string GL79AGBNO = "GL79AGBNO";

        /// <summary>
        /// GL79AGCM.
        /// </summary>
        public const string GL79AGCM = "GL79AGCM";

        /// <summary>
        /// GL79AGZYN.
        /// </summary>
        public const string GL79AGZYN = "GL79AGZYN";

        /// <summary>
        /// GL79AAPDF.
        /// </summary>
        public const string GL79AAPDF = "GL79AAPDF";

        /// <summary>
        /// GL79AAPDT.
        /// </summary>
        public const string GL79AAPDT = "GL79AAPDT";

        /// <summary>
        /// GLURCD.
        /// </summary>
        public const string GLURCD = "GLURCD";

        /// <summary>
        /// GLURRF.
        /// </summary>
        public const string GLURRF = "GLURRF";

        /// <summary>
        /// GLURAB.
        /// </summary>
        public const string GLURAB = "GLURAB";

        /// <summary>
        /// GLURAT.
        /// </summary>
        public const string GLURAT = "GLURAT";

        /// <summary>
        /// GLURDT.
        /// </summary>
        public const string GLURDT = "GLURDT";

        /// <summary>
        /// GLPID.
        /// </summary>
        public const string GLPID = "GLPID";

        /// <summary>
        /// GLUSER.
        /// </summary>
        public const string GLUSER = "GLUSER";

        /// <summary>
        /// GLJOBN.
        /// </summary>
        public const string GLJOBN = "GLJOBN";

        /// <summary>
        /// GLUPMJ.
        /// </summary>
        public const string GLUPMJ = "GLUPMJ";

        /// <summary>
        /// GLTDAY.
        /// </summary>
        public const string GLTDAY = "GLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A11Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLEDUS", "GLEDUS", JdeDataType.String, 20, true, true),
        new JdeField("GLEDTY", "GLEDTY", JdeDataType.String, 2),
        new JdeField("GLEDSQ", "GLEDSQ", JdeDataType.Numeric),
        new JdeField("GLEDTN", "GLEDTN", JdeDataType.String, 44, true, true),
        new JdeField("GLEDCT", "GLEDCT", JdeDataType.String, 4),
        new JdeField("GLEDTS", "GLEDTS", JdeDataType.String, 12),
        new JdeField("GLEDLN", "GLEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("GLEDFT", "GLEDFT", JdeDataType.String, 20),
        new JdeField("GLEDDT", "GLEDDT", JdeDataType.Numeric),
        new JdeField("GLEDER", "GLEDER", JdeDataType.String, 2),
        new JdeField("GLEDDL", "GLEDDL", JdeDataType.Numeric),
        new JdeField("GLEDSP", "GLEDSP", JdeDataType.String, 2),
        new JdeField("GLEDTC", "GLEDTC", JdeDataType.String, 2),
        new JdeField("GLEDTR", "GLEDTR", JdeDataType.String, 2),
        new JdeField("GLEDBT", "GLEDBT", JdeDataType.String, 30, true, true),
        new JdeField("GLEDGL", "GLEDGL", JdeDataType.String, 2),
        new JdeField("GLEDDH", "GLEDDH", JdeDataType.String, 2),
        new JdeField("GLEDAN", "GLEDAN", JdeDataType.Numeric),
        new JdeField("GLUKID", "GLUKID", JdeDataType.Numeric),
        new JdeField("GLKCO", "GLKCO", JdeDataType.String, 10),
        new JdeField("GLDCT", "GLDCT", JdeDataType.String, 4),
        new JdeField("GLDOC", "GLDOC", JdeDataType.Numeric),
        new JdeField("GLSFX", "GLSFX", JdeDataType.String, 6),
        new JdeField("GLSFXE", "GLSFXE", JdeDataType.Numeric),
        new JdeField("GLLNID", "GLLNID", JdeDataType.Numeric),
        new JdeField("GLAN8", "GLAN8", JdeDataType.Numeric),
        new JdeField("GLMMCU", "GLMMCU", JdeDataType.String, 24),
        new JdeField("GLITM", "GLITM", JdeDataType.Numeric),
        new JdeField("GLLITM", "GLLITM", JdeDataType.String, 50),
        new JdeField("GLAITM", "GLAITM", JdeDataType.String, 50),
        new JdeField("GLTRQT", "GLTRQT", JdeDataType.Numeric),
        new JdeField("GLUOM1", "GLUOM1", JdeDataType.String, 4),
        new JdeField("GLTREX", "GLTREX", JdeDataType.String, 60),
        new JdeField("GLTRDJ", "GLTRDJ", JdeDataType.Numeric),
        new JdeField("GL79ADGHG", "GL79ADGHG", JdeDataType.Numeric),
        new JdeField("GLCTRY", "GLCTRY", JdeDataType.Numeric),
        new JdeField("GLFY", "GLFY", JdeDataType.Numeric),
        new JdeField("GLPN", "GLPN", JdeDataType.Numeric),
        new JdeField("GL79AGESID", "GL79AGESID", JdeDataType.Numeric),
        new JdeField("GL79ASRC", "GL79ASRC", JdeDataType.String, 50),
        new JdeField("GL79AEMSC", "GL79AEMSC", JdeDataType.String, 20),
        new JdeField("GL79AGCUM", "GL79AGCUM", JdeDataType.String, 4),
        new JdeField("GL79AEUQTY", "GL79AEUQTY", JdeDataType.Numeric),
        new JdeField("GL79AEGJ", "GL79AEGJ", JdeDataType.Numeric),
        new JdeField("GL79ACO2Q", "GL79ACO2Q", JdeDataType.Numeric),
        new JdeField("GLRE", "GLRE", JdeDataType.String, 2),
        new JdeField("GL79AGRCD", "GL79AGRCD", JdeDataType.String, 6),
        new JdeField("GL79AGS01", "GL79AGS01", JdeDataType.String, 4),
        new JdeField("GL79AGS02", "GL79AGS02", JdeDataType.String, 4),
        new JdeField("GLCOUN", "GLCOUN", JdeDataType.String, 50),
        new JdeField("GLADDS", "GLADDS", JdeDataType.String, 6),
        new JdeField("GLCTR", "GLCTR", JdeDataType.String, 6),
        new JdeField("GLNUMB", "GLNUMB", JdeDataType.Numeric),
        new JdeField("GLASII", "GLASII", JdeDataType.String, 52),
        new JdeField("GL79AGELT", "GL79AGELT", JdeDataType.String, 4),
        new JdeField("GL79AVN01", "GL79AVN01", JdeDataType.Numeric),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6),
        new JdeField("GLCRR", "GLCRR", JdeDataType.Numeric),
        new JdeField("GLBCRC", "GLBCRC", JdeDataType.String, 6),
        new JdeField("GL79ABV01", "GL79ABV01", JdeDataType.Numeric),
        new JdeField("GL79AGCRIT", "GL79AGCRIT", JdeDataType.String, 20),
        new JdeField("GLMCU", "GLMCU", JdeDataType.String, 24),
        new JdeField("GL79AGBNO", "GL79AGBNO", JdeDataType.Numeric),
        new JdeField("GL79AGCM", "GL79AGCM", JdeDataType.String, 4),
        new JdeField("GL79AGZYN", "GL79AGZYN", JdeDataType.String, 2),
        new JdeField("GL79AAPDF", "GL79AAPDF", JdeDataType.Numeric),
        new JdeField("GL79AAPDT", "GL79AAPDT", JdeDataType.Numeric),
        new JdeField("GLURCD", "GLURCD", JdeDataType.String, 4),
        new JdeField("GLURRF", "GLURRF", JdeDataType.String, 30),
        new JdeField("GLURAB", "GLURAB", JdeDataType.Numeric),
        new JdeField("GLURAT", "GLURAT", JdeDataType.Numeric),
        new JdeField("GLURDT", "GLURDT", JdeDataType.Numeric),
        new JdeField("GLPID", "GLPID", JdeDataType.String, 20),
        new JdeField("GLUSER", "GLUSER", JdeDataType.String, 20),
        new JdeField("GLJOBN", "GLJOBN", JdeDataType.String, 20),
        new JdeField("GLUPMJ", "GLUPMJ", JdeDataType.Numeric),
        new JdeField("GLTDAY", "GLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A11Z1_0", "Primary Key on GLEDUS, GLEDBT, GLEDTN, GLEDLN", new[] { "GLEDUS", "GLEDBT", "GLEDTN", "GLEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A11Z1_2", "Index on GLEDBT, GLEDTN, GLEDSP", new[] { "GLEDBT", "GLEDTN", "GLEDSP" }),
        new JdeIndex("F79A11Z1_3", "Index on GLEDUS, GLEDBT, GLEDTN, SYS_NC00078$", new[] { "GLEDUS", "GLEDBT", "GLEDTN", "SYS_NC00078$" })
    };
}
