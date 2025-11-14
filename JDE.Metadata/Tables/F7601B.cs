using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7601B - .
/// </summary>
public class F7601B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FHBNNF.
        /// </summary>
        public const string FHBNNF = "FHBNNF";

        /// <summary>
        /// FHBSER.
        /// </summary>
        public const string FHBSER = "FHBSER";

        /// <summary>
        /// FHN001.
        /// </summary>
        public const string FHN001 = "FHN001";

        /// <summary>
        /// FHDCT.
        /// </summary>
        public const string FHDCT = "FHDCT";

        /// <summary>
        /// FHBNF0.
        /// </summary>
        public const string FHBNF0 = "FHBNF0";

        /// <summary>
        /// FHBSR0.
        /// </summary>
        public const string FHBSR0 = "FHBSR0";

        /// <summary>
        /// FHN002.
        /// </summary>
        public const string FHN002 = "FHN002";

        /// <summary>
        /// FHBNFS.
        /// </summary>
        public const string FHBNFS = "FHBNFS";

        /// <summary>
        /// FHOCTO.
        /// </summary>
        public const string FHOCTO = "FHOCTO";

        /// <summary>
        /// FHMCU.
        /// </summary>
        public const string FHMCU = "FHMCU";

        /// <summary>
        /// FHCO.
        /// </summary>
        public const string FHCO = "FHCO";

        /// <summary>
        /// FHFCO.
        /// </summary>
        public const string FHFCO = "FHFCO";

        /// <summary>
        /// FHSHAN.
        /// </summary>
        public const string FHSHAN = "FHSHAN";

        /// <summary>
        /// FHAN8.
        /// </summary>
        public const string FHAN8 = "FHAN8";

        /// <summary>
        /// FHBCGT.
        /// </summary>
        public const string FHBCGT = "FHBCGT";

        /// <summary>
        /// FHBCPT.
        /// </summary>
        public const string FHBCPT = "FHBCPT";

        /// <summary>
        /// FHSHST.
        /// </summary>
        public const string FHSHST = "FHSHST";

        /// <summary>
        /// FHSHZP.
        /// </summary>
        public const string FHSHZP = "FHSHZP";

        /// <summary>
        /// FHVR01.
        /// </summary>
        public const string FHVR01 = "FHVR01";

        /// <summary>
        /// FHBSFH.
        /// </summary>
        public const string FHBSFH = "FHBSFH";

        /// <summary>
        /// FHAN8V.
        /// </summary>
        public const string FHAN8V = "FHAN8V";

        /// <summary>
        /// FHBCGF.
        /// </summary>
        public const string FHBCGF = "FHBCGF";

        /// <summary>
        /// FHBCPF.
        /// </summary>
        public const string FHBCPF = "FHBCPF";

        /// <summary>
        /// FHADDS.
        /// </summary>
        public const string FHADDS = "FHADDS";

        /// <summary>
        /// FHBFRT.
        /// </summary>
        public const string FHBFRT = "FHBFRT";

        /// <summary>
        /// FHBSEG.
        /// </summary>
        public const string FHBSEG = "FHBSEG";

        /// <summary>
        /// FHBDFN.
        /// </summary>
        public const string FHBDFN = "FHBDFN";

        /// <summary>
        /// FHBDES.
        /// </summary>
        public const string FHBDES = "FHBDES";

        /// <summary>
        /// FHBVTM.
        /// </summary>
        public const string FHBVTM = "FHBVTM";

        /// <summary>
        /// FHGDVL.
        /// </summary>
        public const string FHGDVL = "FHGDVL";

        /// <summary>
        /// FHBVTN.
        /// </summary>
        public const string FHBVTN = "FHBVTN";

        /// <summary>
        /// FHBICM.
        /// </summary>
        public const string FHBICM = "FHBICM";

        /// <summary>
        /// FHBBCL.
        /// </summary>
        public const string FHBBCL = "FHBBCL";

        /// <summary>
        /// FHBVIS.
        /// </summary>
        public const string FHBVIS = "FHBVIS";

        /// <summary>
        /// FHBBIS.
        /// </summary>
        public const string FHBBIS = "FHBBIS";

        /// <summary>
        /// FHBREP.
        /// </summary>
        public const string FHBREP = "FHBREP";

        /// <summary>
        /// FHBDIZ.
        /// </summary>
        public const string FHBDIZ = "FHBDIZ";

        /// <summary>
        /// FHBVII.
        /// </summary>
        public const string FHBVII = "FHBVII";

        /// <summary>
        /// FHBVOI.
        /// </summary>
        public const string FHBVOI = "FHBVOI";

        /// <summary>
        /// FHBIPI.
        /// </summary>
        public const string FHBIPI = "FHBIPI";

        /// <summary>
        /// FHBBTP.
        /// </summary>
        public const string FHBBTP = "FHBBTP";

        /// <summary>
        /// FHBVOP.
        /// </summary>
        public const string FHBVOP = "FHBVOP";

        /// <summary>
        /// FHBVIP.
        /// </summary>
        public const string FHBVIP = "FHBVIP";

        /// <summary>
        /// FHBISS.
        /// </summary>
        public const string FHBISS = "FHBISS";

        /// <summary>
        /// FHBBCS.
        /// </summary>
        public const string FHBBCS = "FHBBCS";

        /// <summary>
        /// FHBIRT.
        /// </summary>
        public const string FHBIRT = "FHBIRT";

        /// <summary>
        /// FHBBCR.
        /// </summary>
        public const string FHBBCR = "FHBBCR";

        /// <summary>
        /// FHBIIT.
        /// </summary>
        public const string FHBIIT = "FHBIIT";

        /// <summary>
        /// FHBBCI.
        /// </summary>
        public const string FHBBCI = "FHBBCI";

        /// <summary>
        /// FHIRRI.
        /// </summary>
        public const string FHIRRI = "FHIRRI";

        /// <summary>
        /// FHISSU.
        /// </summary>
        public const string FHISSU = "FHISSU";

        /// <summary>
        /// FHSHPJ.
        /// </summary>
        public const string FHSHPJ = "FHSHPJ";

        /// <summary>
        /// FHADDJ.
        /// </summary>
        public const string FHADDJ = "FHADDJ";

        /// <summary>
        /// FHCNDJ.
        /// </summary>
        public const string FHCNDJ = "FHCNDJ";

        /// <summary>
        /// FHDETM.
        /// </summary>
        public const string FHDETM = "FHDETM";

        /// <summary>
        /// FHBINM.
        /// </summary>
        public const string FHBINM = "FHBINM";

        /// <summary>
        /// FHLNID.
        /// </summary>
        public const string FHLNID = "FHLNID";

        /// <summary>
        /// FHANCR.
        /// </summary>
        public const string FHANCR = "FHANCR";

        /// <summary>
        /// FHBCGC.
        /// </summary>
        public const string FHBCGC = "FHBCGC";

        /// <summary>
        /// FHCRTY.
        /// </summary>
        public const string FHCRTY = "FHCRTY";

        /// <summary>
        /// FHFRTH.
        /// </summary>
        public const string FHFRTH = "FHFRTH";

        /// <summary>
        /// FHLICP.
        /// </summary>
        public const string FHLICP = "FHLICP";

        /// <summary>
        /// FHSTCD.
        /// </summary>
        public const string FHSTCD = "FHSTCD";

        /// <summary>
        /// FHTOQN.
        /// </summary>
        public const string FHTOQN = "FHTOQN";

        /// <summary>
        /// FHEQUP.
        /// </summary>
        public const string FHEQUP = "FHEQUP";

        /// <summary>
        /// FHR2.
        /// </summary>
        public const string FHR2 = "FHR2";

        /// <summary>
        /// FHREF.
        /// </summary>
        public const string FHREF = "FHREF";

        /// <summary>
        /// FHITWT.
        /// </summary>
        public const string FHITWT = "FHITWT";

        /// <summary>
        /// FHTOWT.
        /// </summary>
        public const string FHTOWT = "FHTOWT";

        /// <summary>
        /// FHBD01.
        /// </summary>
        public const string FHBD01 = "FHBD01";

        /// <summary>
        /// FHAA1.
        /// </summary>
        public const string FHAA1 = "FHAA1";

        /// <summary>
        /// FHBD02.
        /// </summary>
        public const string FHBD02 = "FHBD02";

        /// <summary>
        /// FHAA2.
        /// </summary>
        public const string FHAA2 = "FHAA2";

        /// <summary>
        /// FHBD03.
        /// </summary>
        public const string FHBD03 = "FHBD03";

        /// <summary>
        /// FHBD04.
        /// </summary>
        public const string FHBD04 = "FHBD04";

        /// <summary>
        /// FHBVLF.
        /// </summary>
        public const string FHBVLF = "FHBVLF";

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
        /// FHBBIR.
        /// </summary>
        public const string FHBBIR = "FHBBIR";

        /// <summary>
        /// FHBIPR.
        /// </summary>
        public const string FHBIPR = "FHBIPR";

        /// <summary>
        /// FHCRCD.
        /// </summary>
        public const string FHCRCD = "FHCRCD";

        /// <summary>
        /// FHFTR.
        /// </summary>
        public const string FHFTR = "FHFTR";

        /// <summary>
        /// FHF1T.
        /// </summary>
        public const string FHF1T = "FHF1T";

        /// <summary>
        /// FHUSB1.
        /// </summary>
        public const string FHUSB1 = "FHUSB1";
    }

    /// <inheritdoc />
    public override string TableName => "F7601B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FHBNNF", "FHBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("FHBSER", "FHBSER", JdeDataType.String, 4, true, true),
        new JdeField("FHN001", "FHN001", JdeDataType.Numeric, null, true, true),
        new JdeField("FHDCT", "FHDCT", JdeDataType.String, 4, true, true),
        new JdeField("FHBNF0", "FHBNF0", JdeDataType.Numeric),
        new JdeField("FHBSR0", "FHBSR0", JdeDataType.String, 4),
        new JdeField("FHN002", "FHN002", JdeDataType.Numeric),
        new JdeField("FHBNFS", "FHBNFS", JdeDataType.String, 2),
        new JdeField("FHOCTO", "FHOCTO", JdeDataType.String, 4),
        new JdeField("FHMCU", "FHMCU", JdeDataType.String, 24),
        new JdeField("FHCO", "FHCO", JdeDataType.String, 10),
        new JdeField("FHFCO", "FHFCO", JdeDataType.String, 10),
        new JdeField("FHSHAN", "FHSHAN", JdeDataType.Numeric),
        new JdeField("FHAN8", "FHAN8", JdeDataType.Numeric),
        new JdeField("FHBCGT", "FHBCGT", JdeDataType.String, 30),
        new JdeField("FHBCPT", "FHBCPT", JdeDataType.String, 22),
        new JdeField("FHSHST", "FHSHST", JdeDataType.String, 6),
        new JdeField("FHSHZP", "FHSHZP", JdeDataType.String, 24),
        new JdeField("FHVR01", "FHVR01", JdeDataType.String, 50),
        new JdeField("FHBSFH", "FHBSFH", JdeDataType.Numeric),
        new JdeField("FHAN8V", "FHAN8V", JdeDataType.Numeric),
        new JdeField("FHBCGF", "FHBCGF", JdeDataType.String, 30),
        new JdeField("FHBCPF", "FHBCPF", JdeDataType.String, 22),
        new JdeField("FHADDS", "FHADDS", JdeDataType.String, 6),
        new JdeField("FHBFRT", "FHBFRT", JdeDataType.Numeric),
        new JdeField("FHBSEG", "FHBSEG", JdeDataType.Numeric),
        new JdeField("FHBDFN", "FHBDFN", JdeDataType.Numeric),
        new JdeField("FHBDES", "FHBDES", JdeDataType.Numeric),
        new JdeField("FHBVTM", "FHBVTM", JdeDataType.Numeric),
        new JdeField("FHGDVL", "FHGDVL", JdeDataType.Numeric),
        new JdeField("FHBVTN", "FHBVTN", JdeDataType.Numeric),
        new JdeField("FHBICM", "FHBICM", JdeDataType.Numeric),
        new JdeField("FHBBCL", "FHBBCL", JdeDataType.Numeric),
        new JdeField("FHBVIS", "FHBVIS", JdeDataType.Numeric),
        new JdeField("FHBBIS", "FHBBIS", JdeDataType.Numeric),
        new JdeField("FHBREP", "FHBREP", JdeDataType.Numeric),
        new JdeField("FHBDIZ", "FHBDIZ", JdeDataType.Numeric),
        new JdeField("FHBVII", "FHBVII", JdeDataType.Numeric),
        new JdeField("FHBVOI", "FHBVOI", JdeDataType.Numeric),
        new JdeField("FHBIPI", "FHBIPI", JdeDataType.Numeric),
        new JdeField("FHBBTP", "FHBBTP", JdeDataType.Numeric),
        new JdeField("FHBVOP", "FHBVOP", JdeDataType.Numeric),
        new JdeField("FHBVIP", "FHBVIP", JdeDataType.Numeric),
        new JdeField("FHBISS", "FHBISS", JdeDataType.Numeric),
        new JdeField("FHBBCS", "FHBBCS", JdeDataType.Numeric),
        new JdeField("FHBIRT", "FHBIRT", JdeDataType.Numeric),
        new JdeField("FHBBCR", "FHBBCR", JdeDataType.Numeric),
        new JdeField("FHBIIT", "FHBIIT", JdeDataType.Numeric),
        new JdeField("FHBBCI", "FHBBCI", JdeDataType.Numeric),
        new JdeField("FHIRRI", "FHIRRI", JdeDataType.Numeric),
        new JdeField("FHISSU", "FHISSU", JdeDataType.Numeric),
        new JdeField("FHSHPJ", "FHSHPJ", JdeDataType.Numeric),
        new JdeField("FHADDJ", "FHADDJ", JdeDataType.Numeric),
        new JdeField("FHCNDJ", "FHCNDJ", JdeDataType.Numeric),
        new JdeField("FHDETM", "FHDETM", JdeDataType.Numeric),
        new JdeField("FHBINM", "FHBINM", JdeDataType.String, 20),
        new JdeField("FHLNID", "FHLNID", JdeDataType.Numeric),
        new JdeField("FHANCR", "FHANCR", JdeDataType.Numeric),
        new JdeField("FHBCGC", "FHBCGC", JdeDataType.String, 30),
        new JdeField("FHCRTY", "FHCRTY", JdeDataType.String, 6),
        new JdeField("FHFRTH", "FHFRTH", JdeDataType.String, 6),
        new JdeField("FHLICP", "FHLICP", JdeDataType.String, 20),
        new JdeField("FHSTCD", "FHSTCD", JdeDataType.String, 6),
        new JdeField("FHTOQN", "FHTOQN", JdeDataType.Numeric),
        new JdeField("FHEQUP", "FHEQUP", JdeDataType.String, 30),
        new JdeField("FHR2", "FHR2", JdeDataType.String, 16),
        new JdeField("FHREF", "FHREF", JdeDataType.String, 30),
        new JdeField("FHITWT", "FHITWT", JdeDataType.Numeric),
        new JdeField("FHTOWT", "FHTOWT", JdeDataType.Numeric),
        new JdeField("FHBD01", "FHBD01", JdeDataType.String, 6),
        new JdeField("FHAA1", "FHAA1", JdeDataType.Numeric),
        new JdeField("FHBD02", "FHBD02", JdeDataType.String, 6),
        new JdeField("FHAA2", "FHAA2", JdeDataType.Numeric),
        new JdeField("FHBD03", "FHBD03", JdeDataType.String, 6),
        new JdeField("FHBD04", "FHBD04", JdeDataType.String, 6),
        new JdeField("FHBVLF", "FHBVLF", JdeDataType.Numeric),
        new JdeField("FHUSER", "FHUSER", JdeDataType.String, 20),
        new JdeField("FHPID", "FHPID", JdeDataType.String, 20),
        new JdeField("FHJOBN", "FHJOBN", JdeDataType.String, 20),
        new JdeField("FHUPMJ", "FHUPMJ", JdeDataType.Numeric),
        new JdeField("FHTDAY", "FHTDAY", JdeDataType.Numeric),
        new JdeField("FHBBIR", "FHBBIR", JdeDataType.Numeric),
        new JdeField("FHBIPR", "FHBIPR", JdeDataType.Numeric),
        new JdeField("FHCRCD", "FHCRCD", JdeDataType.String, 6),
        new JdeField("FHFTR", "FHFTR", JdeDataType.Numeric),
        new JdeField("FHF1T", "FHF1T", JdeDataType.String, 60),
        new JdeField("FHUSB1", "FHUSB1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7601B_0", "Primary Key on FHBNNF, FHBSER, FHN001, FHDCT", new[] { "FHBNNF", "FHBSER", "FHN001", "FHDCT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7601B_3", "Index on FHBNNF, FHBSER, FHDCT", new[] { "FHBNNF", "FHBSER", "FHDCT" }),
        new JdeIndex("F7601B_4", "Index on FHBSFH, FHBNNF, FHBSER, FHDCT", new[] { "FHBSFH", "FHBNNF", "FHBSER", "FHDCT" })
    };
}
