using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B85 - .
/// </summary>
public class F31B85 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTWVID.
        /// </summary>
        public const string WTWVID = "WTWVID";

        /// <summary>
        /// WTWTNUM.
        /// </summary>
        public const string WTWTNUM = "WTWTNUM";

        /// <summary>
        /// WTBLUID.
        /// </summary>
        public const string WTBLUID = "WTBLUID";

        /// <summary>
        /// WTMCU.
        /// </summary>
        public const string WTMCU = "WTMCU";

        /// <summary>
        /// WTUMWG1.
        /// </summary>
        public const string WTUMWG1 = "WTUMWG1";

        /// <summary>
        /// WTQTRC.
        /// </summary>
        public const string WTQTRC = "WTQTRC";

        /// <summary>
        /// WTGRSWTIN.
        /// </summary>
        public const string WTGRSWTIN = "WTGRSWTIN";

        /// <summary>
        /// WTTRWTOUT.
        /// </summary>
        public const string WTTRWTOUT = "WTTRWTOUT";

        /// <summary>
        /// WTTBMETH.
        /// </summary>
        public const string WTTBMETH = "WTTBMETH";

        /// <summary>
        /// WTBINWGHT.
        /// </summary>
        public const string WTBINWGHT = "WTBINWGHT";

        /// <summary>
        /// WTNBIN.
        /// </summary>
        public const string WTNBIN = "WTNBIN";

        /// <summary>
        /// WTNBOUT.
        /// </summary>
        public const string WTNBOUT = "WTNBOUT";

        /// <summary>
        /// WTMACHHAR.
        /// </summary>
        public const string WTMACHHAR = "WTMACHHAR";

        /// <summary>
        /// WTLSTLOAD.
        /// </summary>
        public const string WTLSTLOAD = "WTLSTLOAD";

        /// <summary>
        /// WTINSPID.
        /// </summary>
        public const string WTINSPID = "WTINSPID";

        /// <summary>
        /// WTWGHMID.
        /// </summary>
        public const string WTWGHMID = "WTWGHMID";

        /// <summary>
        /// WTCARNAME.
        /// </summary>
        public const string WTCARNAME = "WTCARNAME";

        /// <summary>
        /// WTURAT.
        /// </summary>
        public const string WTURAT = "WTURAT";

        /// <summary>
        /// WTURCD.
        /// </summary>
        public const string WTURCD = "WTURCD";

        /// <summary>
        /// WTURDT.
        /// </summary>
        public const string WTURDT = "WTURDT";

        /// <summary>
        /// WTURAB.
        /// </summary>
        public const string WTURAB = "WTURAB";

        /// <summary>
        /// WTURRF.
        /// </summary>
        public const string WTURRF = "WTURRF";

        /// <summary>
        /// WTUSER.
        /// </summary>
        public const string WTUSER = "WTUSER";

        /// <summary>
        /// WTPID.
        /// </summary>
        public const string WTPID = "WTPID";

        /// <summary>
        /// WTMKEY.
        /// </summary>
        public const string WTMKEY = "WTMKEY";

        /// <summary>
        /// WTUPMJ.
        /// </summary>
        public const string WTUPMJ = "WTUPMJ";

        /// <summary>
        /// WTUPMT.
        /// </summary>
        public const string WTUPMT = "WTUPMT";

        /// <summary>
        /// WTDOCO.
        /// </summary>
        public const string WTDOCO = "WTDOCO";

        /// <summary>
        /// WTDCTO.
        /// </summary>
        public const string WTDCTO = "WTDCTO";

        /// <summary>
        /// WTKCOO.
        /// </summary>
        public const string WTKCOO = "WTKCOO";

        /// <summary>
        /// WTSFXO.
        /// </summary>
        public const string WTSFXO = "WTSFXO";

        /// <summary>
        /// WTLNID.
        /// </summary>
        public const string WTLNID = "WTLNID";

        /// <summary>
        /// WTNLIN.
        /// </summary>
        public const string WTNLIN = "WTNLIN";

        /// <summary>
        /// WTWTDOCNUM.
        /// </summary>
        public const string WTWTDOCNUM = "WTWTDOCNUM";

        /// <summary>
        /// WTAWTDOC.
        /// </summary>
        public const string WTAWTDOC = "WTAWTDOC";

        /// <summary>
        /// WTITM.
        /// </summary>
        public const string WTITM = "WTITM";

        /// <summary>
        /// WTMCU2.
        /// </summary>
        public const string WTMCU2 = "WTMCU2";

        /// <summary>
        /// WTLOCN.
        /// </summary>
        public const string WTLOCN = "WTLOCN";

        /// <summary>
        /// WTLOTN.
        /// </summary>
        public const string WTLOTN = "WTLOTN";

        /// <summary>
        /// WTWCOST.
        /// </summary>
        public const string WTWCOST = "WTWCOST";

        /// <summary>
        /// WTCRPINSP.
        /// </summary>
        public const string WTCRPINSP = "WTCRPINSP";

        /// <summary>
        /// WTDIRH.
        /// </summary>
        public const string WTDIRH = "WTDIRH";

        /// <summary>
        /// WTCNTWGT.
        /// </summary>
        public const string WTCNTWGT = "WTCNTWGT";

        /// <summary>
        /// WTMISCWGT.
        /// </summary>
        public const string WTMISCWGT = "WTMISCWGT";

        /// <summary>
        /// WTBINWOUT.
        /// </summary>
        public const string WTBINWOUT = "WTBINWOUT";

        /// <summary>
        /// WTOWNFG.
        /// </summary>
        public const string WTOWNFG = "WTOWNFG";

        /// <summary>
        /// WTBLACT.
        /// </summary>
        public const string WTBLACT = "WTBLACT";

        /// <summary>
        /// WTMATYP.
        /// </summary>
        public const string WTMATYP = "WTMATYP";

        /// <summary>
        /// WTSQOR.
        /// </summary>
        public const string WTSQOR = "WTSQOR";

        /// <summary>
        /// WTUOM2.
        /// </summary>
        public const string WTUOM2 = "WTUOM2";

        /// <summary>
        /// WTVARID.
        /// </summary>
        public const string WTVARID = "WTVARID";

        /// <summary>
        /// WTAPPID.
        /// </summary>
        public const string WTAPPID = "WTAPPID";

        /// <summary>
        /// WTGREGION.
        /// </summary>
        public const string WTGREGION = "WTGREGION";

        /// <summary>
        /// WTGDISTR.
        /// </summary>
        public const string WTGDISTR = "WTGDISTR";

        /// <summary>
        /// WTTLNUM.
        /// </summary>
        public const string WTTLNUM = "WTTLNUM";

        /// <summary>
        /// WTVLNUM.
        /// </summary>
        public const string WTVLNUM = "WTVLNUM";

        /// <summary>
        /// WTLOOPNUM.
        /// </summary>
        public const string WTLOOPNUM = "WTLOOPNUM";

        /// <summary>
        /// WTWVUM.
        /// </summary>
        public const string WTWVUM = "WTWVUM";

        /// <summary>
        /// WTGRECID.
        /// </summary>
        public const string WTGRECID = "WTGRECID";

        /// <summary>
        /// WTWOPID.
        /// </summary>
        public const string WTWOPID = "WTWOPID";

        /// <summary>
        /// WTTLNUM1.
        /// </summary>
        public const string WTTLNUM1 = "WTTLNUM1";

        /// <summary>
        /// WTCMDCDE.
        /// </summary>
        public const string WTCMDCDE = "WTCMDCDE";

        /// <summary>
        /// WTDOC.
        /// </summary>
        public const string WTDOC = "WTDOC";

        /// <summary>
        /// WTBINTIN.
        /// </summary>
        public const string WTBINTIN = "WTBINTIN";

        /// <summary>
        /// WTBINTOUT.
        /// </summary>
        public const string WTBINTOUT = "WTBINTOUT";

        /// <summary>
        /// WTWLOTN.
        /// </summary>
        public const string WTWLOTN = "WTWLOTN";

        /// <summary>
        /// WTLOT1.
        /// </summary>
        public const string WTLOT1 = "WTLOT1";

        /// <summary>
        /// WTLOT2.
        /// </summary>
        public const string WTLOT2 = "WTLOT2";

        /// <summary>
        /// WTLOT3.
        /// </summary>
        public const string WTLOT3 = "WTLOT3";

        /// <summary>
        /// WTRLOT.
        /// </summary>
        public const string WTRLOT = "WTRLOT";

        /// <summary>
        /// WTDRNAME.
        /// </summary>
        public const string WTDRNAME = "WTDRNAME";

        /// <summary>
        /// WTDLNUM.
        /// </summary>
        public const string WTDLNUM = "WTDLNUM";

        /// <summary>
        /// WTMIC.
        /// </summary>
        public const string WTMIC = "WTMIC";

        /// <summary>
        /// WTORIG.
        /// </summary>
        public const string WTORIG = "WTORIG";

        /// <summary>
        /// WTPRCPTF.
        /// </summary>
        public const string WTPRCPTF = "WTPRCPTF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B85";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTWVID", "WTWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("WTWTNUM", "WTWTNUM", JdeDataType.String, 60),
        new JdeField("WTBLUID", "WTBLUID", JdeDataType.Numeric),
        new JdeField("WTMCU", "WTMCU", JdeDataType.String, 24),
        new JdeField("WTUMWG1", "WTUMWG1", JdeDataType.String, 4),
        new JdeField("WTQTRC", "WTQTRC", JdeDataType.Numeric),
        new JdeField("WTGRSWTIN", "WTGRSWTIN", JdeDataType.Numeric),
        new JdeField("WTTRWTOUT", "WTTRWTOUT", JdeDataType.Numeric),
        new JdeField("WTTBMETH", "WTTBMETH", JdeDataType.String, 2),
        new JdeField("WTBINWGHT", "WTBINWGHT", JdeDataType.Numeric),
        new JdeField("WTNBIN", "WTNBIN", JdeDataType.Numeric),
        new JdeField("WTNBOUT", "WTNBOUT", JdeDataType.Numeric),
        new JdeField("WTMACHHAR", "WTMACHHAR", JdeDataType.String, 2),
        new JdeField("WTLSTLOAD", "WTLSTLOAD", JdeDataType.String, 2),
        new JdeField("WTINSPID", "WTINSPID", JdeDataType.Numeric),
        new JdeField("WTWGHMID", "WTWGHMID", JdeDataType.Numeric),
        new JdeField("WTCARNAME", "WTCARNAME", JdeDataType.String, 60),
        new JdeField("WTURAT", "WTURAT", JdeDataType.Numeric),
        new JdeField("WTURCD", "WTURCD", JdeDataType.String, 4),
        new JdeField("WTURDT", "WTURDT", JdeDataType.Numeric),
        new JdeField("WTURAB", "WTURAB", JdeDataType.Numeric),
        new JdeField("WTURRF", "WTURRF", JdeDataType.String, 30),
        new JdeField("WTUSER", "WTUSER", JdeDataType.String, 20),
        new JdeField("WTPID", "WTPID", JdeDataType.String, 20),
        new JdeField("WTMKEY", "WTMKEY", JdeDataType.String, 30),
        new JdeField("WTUPMJ", "WTUPMJ", JdeDataType.Numeric),
        new JdeField("WTUPMT", "WTUPMT", JdeDataType.Numeric),
        new JdeField("WTDOCO", "WTDOCO", JdeDataType.Numeric),
        new JdeField("WTDCTO", "WTDCTO", JdeDataType.String, 4),
        new JdeField("WTKCOO", "WTKCOO", JdeDataType.String, 10),
        new JdeField("WTSFXO", "WTSFXO", JdeDataType.String, 6),
        new JdeField("WTLNID", "WTLNID", JdeDataType.Numeric),
        new JdeField("WTNLIN", "WTNLIN", JdeDataType.Numeric),
        new JdeField("WTWTDOCNUM", "WTWTDOCNUM", JdeDataType.Numeric),
        new JdeField("WTAWTDOC", "WTAWTDOC", JdeDataType.String, 60),
        new JdeField("WTITM", "WTITM", JdeDataType.Numeric),
        new JdeField("WTMCU2", "WTMCU2", JdeDataType.String, 24),
        new JdeField("WTLOCN", "WTLOCN", JdeDataType.String, 40),
        new JdeField("WTLOTN", "WTLOTN", JdeDataType.String, 60),
        new JdeField("WTWCOST", "WTWCOST", JdeDataType.String, 24),
        new JdeField("WTCRPINSP", "WTCRPINSP", JdeDataType.String, 2),
        new JdeField("WTDIRH", "WTDIRH", JdeDataType.String, 2),
        new JdeField("WTCNTWGT", "WTCNTWGT", JdeDataType.Numeric),
        new JdeField("WTMISCWGT", "WTMISCWGT", JdeDataType.Numeric),
        new JdeField("WTBINWOUT", "WTBINWOUT", JdeDataType.Numeric),
        new JdeField("WTOWNFG", "WTOWNFG", JdeDataType.String, 2),
        new JdeField("WTBLACT", "WTBLACT", JdeDataType.String, 2),
        new JdeField("WTMATYP", "WTMATYP", JdeDataType.String, 8),
        new JdeField("WTSQOR", "WTSQOR", JdeDataType.Numeric),
        new JdeField("WTUOM2", "WTUOM2", JdeDataType.String, 4),
        new JdeField("WTVARID", "WTVARID", JdeDataType.Numeric),
        new JdeField("WTAPPID", "WTAPPID", JdeDataType.Numeric),
        new JdeField("WTGREGION", "WTGREGION", JdeDataType.String, 20),
        new JdeField("WTGDISTR", "WTGDISTR", JdeDataType.String, 20),
        new JdeField("WTTLNUM", "WTTLNUM", JdeDataType.String, 24),
        new JdeField("WTVLNUM", "WTVLNUM", JdeDataType.String, 24),
        new JdeField("WTLOOPNUM", "WTLOOPNUM", JdeDataType.Numeric),
        new JdeField("WTWVUM", "WTWVUM", JdeDataType.String, 6),
        new JdeField("WTGRECID", "WTGRECID", JdeDataType.Numeric),
        new JdeField("WTWOPID", "WTWOPID", JdeDataType.Numeric),
        new JdeField("WTTLNUM1", "WTTLNUM1", JdeDataType.String, 24),
        new JdeField("WTCMDCDE", "WTCMDCDE", JdeDataType.String, 30),
        new JdeField("WTDOC", "WTDOC", JdeDataType.Numeric),
        new JdeField("WTBINTIN", "WTBINTIN", JdeDataType.String, 2),
        new JdeField("WTBINTOUT", "WTBINTOUT", JdeDataType.String, 2),
        new JdeField("WTWLOTN", "WTWLOTN", JdeDataType.String, 60),
        new JdeField("WTLOT1", "WTLOT1", JdeDataType.String, 60),
        new JdeField("WTLOT2", "WTLOT2", JdeDataType.String, 60),
        new JdeField("WTLOT3", "WTLOT3", JdeDataType.String, 60),
        new JdeField("WTRLOT", "WTRLOT", JdeDataType.String, 60),
        new JdeField("WTDRNAME", "WTDRNAME", JdeDataType.String, 80),
        new JdeField("WTDLNUM", "WTDLNUM", JdeDataType.String, 40),
        new JdeField("WTMIC", "WTMIC", JdeDataType.String, 2),
        new JdeField("WTORIG", "WTORIG", JdeDataType.String, 6),
        new JdeField("WTPRCPTF", "WTPRCPTF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B85_0", "Primary Key on WTWVID", new[] { "WTWVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B85_2", "Index on WTWTNUM", new[] { "WTWTNUM" }),
        new JdeIndex("F31B85_3", "Index on WTBLUID", new[] { "WTBLUID" }),
        new JdeIndex("F31B85_4", "Index on WTGRECID", new[] { "WTGRECID" })
    };
}
