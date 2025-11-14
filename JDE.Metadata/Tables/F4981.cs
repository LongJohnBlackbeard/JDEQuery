using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4981 - .
/// </summary>
public class F4981 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHUK01.
        /// </summary>
        public const string FHUK01 = "FHUK01";

        /// <summary>
        /// FHSHPN.
        /// </summary>
        public const string FHSHPN = "FHSHPN";

        /// <summary>
        /// FHRSSN.
        /// </summary>
        public const string FHRSSN = "FHRSSN";

        /// <summary>
        /// FHVMCU.
        /// </summary>
        public const string FHVMCU = "FHVMCU";

        /// <summary>
        /// FHLDNM.
        /// </summary>
        public const string FHLDNM = "FHLDNM";

        /// <summary>
        /// FHDLNO.
        /// </summary>
        public const string FHDLNO = "FHDLNO";

        /// <summary>
        /// FHOSEQ.
        /// </summary>
        public const string FHOSEQ = "FHOSEQ";

        /// <summary>
        /// FHNMFC.
        /// </summary>
        public const string FHNMFC = "FHNMFC";

        /// <summary>
        /// FHDSGP.
        /// </summary>
        public const string FHDSGP = "FHDSGP";

        /// <summary>
        /// FHFRT1.
        /// </summary>
        public const string FHFRT1 = "FHFRT1";

        /// <summary>
        /// FHFRT2.
        /// </summary>
        public const string FHFRT2 = "FHFRT2";

        /// <summary>
        /// FHORGN.
        /// </summary>
        public const string FHORGN = "FHORGN";

        /// <summary>
        /// FHNMCU.
        /// </summary>
        public const string FHNMCU = "FHNMCU";

        /// <summary>
        /// FHBLPB.
        /// </summary>
        public const string FHBLPB = "FHBLPB";

        /// <summary>
        /// FHOVFG.
        /// </summary>
        public const string FHOVFG = "FHOVFG";

        /// <summary>
        /// FHOVFH.
        /// </summary>
        public const string FHOVFH = "FHOVFH";

        /// <summary>
        /// FHMOT.
        /// </summary>
        public const string FHMOT = "FHMOT";

        /// <summary>
        /// FHCARS.
        /// </summary>
        public const string FHCARS = "FHCARS";

        /// <summary>
        /// FHCAMD.
        /// </summary>
        public const string FHCAMD = "FHCAMD";

        /// <summary>
        /// FHWGTS.
        /// </summary>
        public const string FHWGTS = "FHWGTS";

        /// <summary>
        /// FHWTUM.
        /// </summary>
        public const string FHWTUM = "FHWTUM";

        /// <summary>
        /// FHSCVL.
        /// </summary>
        public const string FHSCVL = "FHSCVL";

        /// <summary>
        /// FHVLUM.
        /// </summary>
        public const string FHVLUM = "FHVLUM";

        /// <summary>
        /// FHFRSC.
        /// </summary>
        public const string FHFRSC = "FHFRSC";

        /// <summary>
        /// FHRTNM.
        /// </summary>
        public const string FHRTNM = "FHRTNM";

        /// <summary>
        /// FHSDSQ.
        /// </summary>
        public const string FHSDSQ = "FHSDSQ";

        /// <summary>
        /// FHSCSN.
        /// </summary>
        public const string FHSCSN = "FHSCSN";

        /// <summary>
        /// FHRTGB.
        /// </summary>
        public const string FHRTGB = "FHRTGB";

        /// <summary>
        /// FHRTDQ.
        /// </summary>
        public const string FHRTDQ = "FHRTDQ";

        /// <summary>
        /// FHUOM.
        /// </summary>
        public const string FHUOM = "FHUOM";

        /// <summary>
        /// FHCGC1.
        /// </summary>
        public const string FHCGC1 = "FHCGC1";

        /// <summary>
        /// FHAG.
        /// </summary>
        public const string FHAG = "FHAG";

        /// <summary>
        /// FHFAA.
        /// </summary>
        public const string FHFAA = "FHFAA";

        /// <summary>
        /// FHNAMT.
        /// </summary>
        public const string FHNAMT = "FHNAMT";

        /// <summary>
        /// FHCRDC.
        /// </summary>
        public const string FHCRDC = "FHCRDC";

        /// <summary>
        /// FHNAMF.
        /// </summary>
        public const string FHNAMF = "FHNAMF";

        /// <summary>
        /// FHCRCD.
        /// </summary>
        public const string FHCRCD = "FHCRCD";

        /// <summary>
        /// FHDOCO.
        /// </summary>
        public const string FHDOCO = "FHDOCO";

        /// <summary>
        /// FHDCTO.
        /// </summary>
        public const string FHDCTO = "FHDCTO";

        /// <summary>
        /// FHKCOO.
        /// </summary>
        public const string FHKCOO = "FHKCOO";

        /// <summary>
        /// FHLNID.
        /// </summary>
        public const string FHLNID = "FHLNID";

        /// <summary>
        /// FHODOC.
        /// </summary>
        public const string FHODOC = "FHODOC";

        /// <summary>
        /// FHODCT.
        /// </summary>
        public const string FHODCT = "FHODCT";

        /// <summary>
        /// FHOKCO.
        /// </summary>
        public const string FHOKCO = "FHOKCO";

        /// <summary>
        /// FHJELN.
        /// </summary>
        public const string FHJELN = "FHJELN";

        /// <summary>
        /// FHDOC.
        /// </summary>
        public const string FHDOC = "FHDOC";

        /// <summary>
        /// FHDCT.
        /// </summary>
        public const string FHDCT = "FHDCT";

        /// <summary>
        /// FHKCO.
        /// </summary>
        public const string FHKCO = "FHKCO";

        /// <summary>
        /// FHDGJ.
        /// </summary>
        public const string FHDGJ = "FHDGJ";

        /// <summary>
        /// FHVINV.
        /// </summary>
        public const string FHVINV = "FHVINV";

        /// <summary>
        /// FHREFQ.
        /// </summary>
        public const string FHREFQ = "FHREFQ";

        /// <summary>
        /// FHREFN.
        /// </summary>
        public const string FHREFN = "FHREFN";

        /// <summary>
        /// FHSHAN.
        /// </summary>
        public const string FHSHAN = "FHSHAN";

        /// <summary>
        /// FHCTY1.
        /// </summary>
        public const string FHCTY1 = "FHCTY1";

        /// <summary>
        /// FHADDS.
        /// </summary>
        public const string FHADDS = "FHADDS";

        /// <summary>
        /// FHADDZ.
        /// </summary>
        public const string FHADDZ = "FHADDZ";

        /// <summary>
        /// FHZON.
        /// </summary>
        public const string FHZON = "FHZON";

        /// <summary>
        /// FHCZON.
        /// </summary>
        public const string FHCZON = "FHCZON";

        /// <summary>
        /// FHFRTH.
        /// </summary>
        public const string FHFRTH = "FHFRTH";

        /// <summary>
        /// FHRTN.
        /// </summary>
        public const string FHRTN = "FHRTN";

        /// <summary>
        /// FHADDJ.
        /// </summary>
        public const string FHADDJ = "FHADDJ";

        /// <summary>
        /// FHUKID.
        /// </summary>
        public const string FHUKID = "FHUKID";

        /// <summary>
        /// FHURCD.
        /// </summary>
        public const string FHURCD = "FHURCD";

        /// <summary>
        /// FHURDT.
        /// </summary>
        public const string FHURDT = "FHURDT";

        /// <summary>
        /// FHURAT.
        /// </summary>
        public const string FHURAT = "FHURAT";

        /// <summary>
        /// FHURAB.
        /// </summary>
        public const string FHURAB = "FHURAB";

        /// <summary>
        /// FHURRF.
        /// </summary>
        public const string FHURRF = "FHURRF";

        /// <summary>
        /// FHUSER.
        /// </summary>
        public const string FHUSER = "FHUSER";

        /// <summary>
        /// FHPID.
        /// </summary>
        public const string FHPID = "FHPID";

        /// <summary>
        /// FHJOBN.
        /// </summary>
        public const string FHJOBN = "FHJOBN";

        /// <summary>
        /// FHUPMJ.
        /// </summary>
        public const string FHUPMJ = "FHUPMJ";

        /// <summary>
        /// FHTDAY.
        /// </summary>
        public const string FHTDAY = "FHTDAY";

        /// <summary>
        /// FHFRSN.
        /// </summary>
        public const string FHFRSN = "FHFRSN";

        /// <summary>
        /// FHANI.
        /// </summary>
        public const string FHANI = "FHANI";

        /// <summary>
        /// FHTXA1.
        /// </summary>
        public const string FHTXA1 = "FHTXA1";

        /// <summary>
        /// FHEXR1.
        /// </summary>
        public const string FHEXR1 = "FHEXR1";

        /// <summary>
        /// FHCTYO.
        /// </summary>
        public const string FHCTYO = "FHCTYO";

        /// <summary>
        /// FHADSO.
        /// </summary>
        public const string FHADSO = "FHADSO";

        /// <summary>
        /// FHADZO.
        /// </summary>
        public const string FHADZO = "FHADZO";

        /// <summary>
        /// FHCTRO.
        /// </summary>
        public const string FHCTRO = "FHCTRO";

        /// <summary>
        /// FHSCT1.
        /// </summary>
        public const string FHSCT1 = "FHSCT1";

        /// <summary>
        /// FHSCT2.
        /// </summary>
        public const string FHSCT2 = "FHSCT2";

        /// <summary>
        /// FHSCT3.
        /// </summary>
        public const string FHSCT3 = "FHSCT3";

        /// <summary>
        /// FHSC1O.
        /// </summary>
        public const string FHSC1O = "FHSC1O";

        /// <summary>
        /// FHSC2O.
        /// </summary>
        public const string FHSC2O = "FHSC2O";

        /// <summary>
        /// FHSC3O.
        /// </summary>
        public const string FHSC3O = "FHSC3O";

        /// <summary>
        /// FHLNMB.
        /// </summary>
        public const string FHLNMB = "FHLNMB";

        /// <summary>
        /// FHCNMR.
        /// </summary>
        public const string FHCNMR = "FHCNMR";

        /// <summary>
        /// FHSTAM.
        /// </summary>
        public const string FHSTAM = "FHSTAM";

        /// <summary>
        /// FHCTAM.
        /// </summary>
        public const string FHCTAM = "FHCTAM";

        /// <summary>
        /// FHTX.
        /// </summary>
        public const string FHTX = "FHTX";

        /// <summary>
        /// FHOVRTAX.
        /// </summary>
        public const string FHOVRTAX = "FHOVRTAX";

        /// <summary>
        /// FHATXA.
        /// </summary>
        public const string FHATXA = "FHATXA";

        /// <summary>
        /// FHCTXA.
        /// </summary>
        public const string FHCTXA = "FHCTXA";
    }

    /// <inheritdoc />
    public override string TableName => "F4981";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHUK01", "FHUK01", JdeDataType.Numeric, null, true, true),
        new JdeField("FHSHPN", "FHSHPN", JdeDataType.Numeric),
        new JdeField("FHRSSN", "FHRSSN", JdeDataType.Numeric),
        new JdeField("FHVMCU", "FHVMCU", JdeDataType.String, 24),
        new JdeField("FHLDNM", "FHLDNM", JdeDataType.Numeric),
        new JdeField("FHDLNO", "FHDLNO", JdeDataType.Numeric),
        new JdeField("FHOSEQ", "FHOSEQ", JdeDataType.Numeric),
        new JdeField("FHNMFC", "FHNMFC", JdeDataType.String, 8),
        new JdeField("FHDSGP", "FHDSGP", JdeDataType.String, 6),
        new JdeField("FHFRT1", "FHFRT1", JdeDataType.String, 12),
        new JdeField("FHFRT2", "FHFRT2", JdeDataType.String, 12),
        new JdeField("FHORGN", "FHORGN", JdeDataType.Numeric),
        new JdeField("FHNMCU", "FHNMCU", JdeDataType.String, 24),
        new JdeField("FHBLPB", "FHBLPB", JdeDataType.String, 2),
        new JdeField("FHOVFG", "FHOVFG", JdeDataType.String, 2),
        new JdeField("FHOVFH", "FHOVFH", JdeDataType.String, 2),
        new JdeField("FHMOT", "FHMOT", JdeDataType.String, 6),
        new JdeField("FHCARS", "FHCARS", JdeDataType.Numeric),
        new JdeField("FHCAMD", "FHCAMD", JdeDataType.String, 2),
        new JdeField("FHWGTS", "FHWGTS", JdeDataType.Numeric),
        new JdeField("FHWTUM", "FHWTUM", JdeDataType.String, 4),
        new JdeField("FHSCVL", "FHSCVL", JdeDataType.Numeric),
        new JdeField("FHVLUM", "FHVLUM", JdeDataType.String, 4),
        new JdeField("FHFRSC", "FHFRSC", JdeDataType.String, 16),
        new JdeField("FHRTNM", "FHRTNM", JdeDataType.String, 20),
        new JdeField("FHSDSQ", "FHSDSQ", JdeDataType.Numeric),
        new JdeField("FHSCSN", "FHSCSN", JdeDataType.Numeric),
        new JdeField("FHRTGB", "FHRTGB", JdeDataType.String, 2),
        new JdeField("FHRTDQ", "FHRTDQ", JdeDataType.Numeric),
        new JdeField("FHUOM", "FHUOM", JdeDataType.String, 4),
        new JdeField("FHCGC1", "FHCGC1", JdeDataType.String, 6),
        new JdeField("FHAG", "FHAG", JdeDataType.Numeric),
        new JdeField("FHFAA", "FHFAA", JdeDataType.Numeric),
        new JdeField("FHNAMT", "FHNAMT", JdeDataType.Numeric),
        new JdeField("FHCRDC", "FHCRDC", JdeDataType.String, 6),
        new JdeField("FHNAMF", "FHNAMF", JdeDataType.Numeric),
        new JdeField("FHCRCD", "FHCRCD", JdeDataType.String, 6),
        new JdeField("FHDOCO", "FHDOCO", JdeDataType.Numeric),
        new JdeField("FHDCTO", "FHDCTO", JdeDataType.String, 4),
        new JdeField("FHKCOO", "FHKCOO", JdeDataType.String, 10),
        new JdeField("FHLNID", "FHLNID", JdeDataType.Numeric),
        new JdeField("FHODOC", "FHODOC", JdeDataType.Numeric),
        new JdeField("FHODCT", "FHODCT", JdeDataType.String, 4),
        new JdeField("FHOKCO", "FHOKCO", JdeDataType.String, 10),
        new JdeField("FHJELN", "FHJELN", JdeDataType.Numeric),
        new JdeField("FHDOC", "FHDOC", JdeDataType.Numeric),
        new JdeField("FHDCT", "FHDCT", JdeDataType.String, 4),
        new JdeField("FHKCO", "FHKCO", JdeDataType.String, 10),
        new JdeField("FHDGJ", "FHDGJ", JdeDataType.Numeric),
        new JdeField("FHVINV", "FHVINV", JdeDataType.String, 50),
        new JdeField("FHREFQ", "FHREFQ", JdeDataType.String, 4),
        new JdeField("FHREFN", "FHREFN", JdeDataType.String, 60),
        new JdeField("FHSHAN", "FHSHAN", JdeDataType.Numeric),
        new JdeField("FHCTY1", "FHCTY1", JdeDataType.String, 50),
        new JdeField("FHADDS", "FHADDS", JdeDataType.String, 6),
        new JdeField("FHADDZ", "FHADDZ", JdeDataType.String, 24),
        new JdeField("FHZON", "FHZON", JdeDataType.String, 6),
        new JdeField("FHCZON", "FHCZON", JdeDataType.String, 20),
        new JdeField("FHFRTH", "FHFRTH", JdeDataType.String, 6),
        new JdeField("FHRTN", "FHRTN", JdeDataType.Numeric),
        new JdeField("FHADDJ", "FHADDJ", JdeDataType.Numeric),
        new JdeField("FHUKID", "FHUKID", JdeDataType.Numeric),
        new JdeField("FHURCD", "FHURCD", JdeDataType.String, 4),
        new JdeField("FHURDT", "FHURDT", JdeDataType.Numeric),
        new JdeField("FHURAT", "FHURAT", JdeDataType.Numeric),
        new JdeField("FHURAB", "FHURAB", JdeDataType.Numeric),
        new JdeField("FHURRF", "FHURRF", JdeDataType.String, 30),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20),
        new JdeField("FHUPMJ", "FHUPMJ", JdeDataType.Numeric),
        new JdeField("FHTDAY", "FHTDAY", JdeDataType.Numeric),
        new JdeField("FHFRSN", "FHFRSN", JdeDataType.String, 6),
        new JdeField("FHANI", "FHANI", JdeDataType.String, 58),
        new JdeField("FHTXA1", "FHTXA1", JdeDataType.String, 20),
        new JdeField("FHEXR1", "FHEXR1", JdeDataType.String, 4),
        new JdeField("FHCTYO", "FHCTYO", JdeDataType.String, 50),
        new JdeField("FHADSO", "FHADSO", JdeDataType.String, 6),
        new JdeField("FHADZO", "FHADZO", JdeDataType.String, 24),
        new JdeField("FHCTRO", "FHCTRO", JdeDataType.String, 6),
        new JdeField("FHSCT1", "FHSCT1", JdeDataType.String, 6),
        new JdeField("FHSCT2", "FHSCT2", JdeDataType.String, 6),
        new JdeField("FHSCT3", "FHSCT3", JdeDataType.String, 6),
        new JdeField("FHSC1O", "FHSC1O", JdeDataType.String, 6),
        new JdeField("FHSC2O", "FHSC2O", JdeDataType.String, 6),
        new JdeField("FHSC3O", "FHSC3O", JdeDataType.String, 6),
        new JdeField("FHLNMB", "FHLNMB", JdeDataType.Numeric),
        new JdeField("FHCNMR", "FHCNMR", JdeDataType.String, 48),
        new JdeField("FHSTAM", "FHSTAM", JdeDataType.Numeric),
        new JdeField("FHCTAM", "FHCTAM", JdeDataType.Numeric),
        new JdeField("FHTX", "FHTX", JdeDataType.String, 2),
        new JdeField("FHOVRTAX", "FHOVRTAX", JdeDataType.String, 2),
        new JdeField("FHATXA", "FHATXA", JdeDataType.Numeric),
        new JdeField("FHCTXA", "FHCTXA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4981_0", "Primary Key on FHUK01", new[] { "FHUK01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4981_10", "Index on FHADDZ, FHADDJ", new[] { "FHADDZ", "FHADDJ" }),
        new JdeIndex("F4981_11", "Index on FHADZO, FHADDJ", new[] { "FHADZO", "FHADDJ" }),
        new JdeIndex("F4981_12", "Index on FHREFN, FHCARS", new[] { "FHREFN", "FHCARS" }),
        new JdeIndex("F4981_13", "Index on FHCARS, FHCNMR", new[] { "FHCARS", "FHCNMR" }),
        new JdeIndex("F4981_2", "Index on FHSHPN, FHRSSN, FHSDSQ, FHSCSN", new[] { "FHSHPN", "FHRSSN", "FHSDSQ", "FHSCSN" }),
        new JdeIndex("F4981_3", "Index on FHVMCU, FHLDNM, FHSDSQ, FHSCSN", new[] { "FHVMCU", "FHLDNM", "FHSDSQ", "FHSCSN" }),
        new JdeIndex("F4981_4", "Index on FHDLNO, FHSDSQ, FHSCSN", new[] { "FHDLNO", "FHSDSQ", "FHSCSN" }),
        new JdeIndex("F4981_6", "Index on FHODOC, FHODCT, FHOKCO, FHDGJ, SYS_NC00095$", new[] { "FHODOC", "FHODCT", "FHOKCO", "FHDGJ", "SYS_NC00095$" }),
        new JdeIndex("F4981_7", "Index on FHDOC, FHDCT, FHKCO", new[] { "FHDOC", "FHDCT", "FHKCO" }),
        new JdeIndex("F4981_8", "Index on FHCARS, FHADDJ", new[] { "FHCARS", "FHADDJ" })
    };
}
