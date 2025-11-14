using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B410D - .
/// </summary>
public class F76B410D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHBRNFK.
        /// </summary>
        public const string CHBRNFK = "CHBRNFK";

        /// <summary>
        /// CHFCO.
        /// </summary>
        public const string CHFCO = "CHFCO";

        /// <summary>
        /// CHN001.
        /// </summary>
        public const string CHN001 = "CHN001";

        /// <summary>
        /// CHDCT.
        /// </summary>
        public const string CHDCT = "CHDCT";

        /// <summary>
        /// CHBRMI.
        /// </summary>
        public const string CHBRMI = "CHBRMI";

        /// <summary>
        /// CHBRMD.
        /// </summary>
        public const string CHBRMD = "CHBRMD";

        /// <summary>
        /// CHBSER.
        /// </summary>
        public const string CHBSER = "CHBSER";

        /// <summary>
        /// CHBNNF.
        /// </summary>
        public const string CHBNNF = "CHBNNF";

        /// <summary>
        /// CHBRNFDE.
        /// </summary>
        public const string CHBRNFDE = "CHBRNFDE";

        /// <summary>
        /// CHAN8.
        /// </summary>
        public const string CHAN8 = "CHAN8";

        /// <summary>
        /// CHBRNFDES.
        /// </summary>
        public const string CHBRNFDES = "CHBRNFDES";

        /// <summary>
        /// CHBRNFIV.
        /// </summary>
        public const string CHBRNFIV = "CHBRNFIV";

        /// <summary>
        /// CHBDES.
        /// </summary>
        public const string CHBDES = "CHBDES";

        /// <summary>
        /// CHBFRT.
        /// </summary>
        public const string CHBFRT = "CHBFRT";

        /// <summary>
        /// CHBSEG.
        /// </summary>
        public const string CHBSEG = "CHBSEG";

        /// <summary>
        /// CHBDFN.
        /// </summary>
        public const string CHBDFN = "CHBDFN";

        /// <summary>
        /// CHBIPI.
        /// </summary>
        public const string CHBIPI = "CHBIPI";

        /// <summary>
        /// CHBVIS.
        /// </summary>
        public const string CHBVIS = "CHBVIS";

        /// <summary>
        /// CHBVTN.
        /// </summary>
        public const string CHBVTN = "CHBVTN";

        /// <summary>
        /// CHBRSTID.
        /// </summary>
        public const string CHBRSTID = "CHBRSTID";

        /// <summary>
        /// CHBRTT.
        /// </summary>
        public const string CHBRTT = "CHBRTT";

        /// <summary>
        /// CHANCR.
        /// </summary>
        public const string CHANCR = "CHANCR";

        /// <summary>
        /// CHBRVQ.
        /// </summary>
        public const string CHBRVQ = "CHBRVQ";

        /// <summary>
        /// CHBRVT.
        /// </summary>
        public const string CHBRVT = "CHBRVT";

        /// <summary>
        /// CHBRGW.
        /// </summary>
        public const string CHBRGW = "CHBRGW";

        /// <summary>
        /// CHBRNW.
        /// </summary>
        public const string CHBRNW = "CHBRNW";

        /// <summary>
        /// CHBRFM.
        /// </summary>
        public const string CHBRFM = "CHBRFM";

        /// <summary>
        /// CHLICP.
        /// </summary>
        public const string CHLICP = "CHLICP";

        /// <summary>
        /// CHBRCS.
        /// </summary>
        public const string CHBRCS = "CHBRCS";

        /// <summary>
        /// CHBRIT.
        /// </summary>
        public const string CHBRIT = "CHBRIT";

        /// <summary>
        /// CHREMBR.
        /// </summary>
        public const string CHREMBR = "CHREMBR";

        /// <summary>
        /// CHRDOR.
        /// </summary>
        public const string CHRDOR = "CHRDOR";

        /// <summary>
        /// CHC1FU.
        /// </summary>
        public const string CHC1FU = "CHC1FU";

        /// <summary>
        /// CHC2FU.
        /// </summary>
        public const string CHC2FU = "CHC2FU";

        /// <summary>
        /// CHD1FU.
        /// </summary>
        public const string CHD1FU = "CHD1FU";

        /// <summary>
        /// CHD2FU.
        /// </summary>
        public const string CHD2FU = "CHD2FU";

        /// <summary>
        /// CHN1FU.
        /// </summary>
        public const string CHN1FU = "CHN1FU";

        /// <summary>
        /// CHN2FU.
        /// </summary>
        public const string CHN2FU = "CHN2FU";

        /// <summary>
        /// CHN3FU.
        /// </summary>
        public const string CHN3FU = "CHN3FU";

        /// <summary>
        /// CHN4FU.
        /// </summary>
        public const string CHN4FU = "CHN4FU";

        /// <summary>
        /// CHN5FU.
        /// </summary>
        public const string CHN5FU = "CHN5FU";

        /// <summary>
        /// CHN6FU.
        /// </summary>
        public const string CHN6FU = "CHN6FU";

        /// <summary>
        /// CHN7FU.
        /// </summary>
        public const string CHN7FU = "CHN7FU";

        /// <summary>
        /// CHS1FU.
        /// </summary>
        public const string CHS1FU = "CHS1FU";

        /// <summary>
        /// CHS2FU.
        /// </summary>
        public const string CHS2FU = "CHS2FU";

        /// <summary>
        /// CHS3FU.
        /// </summary>
        public const string CHS3FU = "CHS3FU";

        /// <summary>
        /// CHS4FU.
        /// </summary>
        public const string CHS4FU = "CHS4FU";

        /// <summary>
        /// CHGENLNG.
        /// </summary>
        public const string CHGENLNG = "CHGENLNG";

        /// <summary>
        /// CHTORG.
        /// </summary>
        public const string CHTORG = "CHTORG";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHUPMT.
        /// </summary>
        public const string CHUPMT = "CHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B410D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHBRNFK", "CHBRNFK", JdeDataType.Numeric, null, true, true),
        new JdeField("CHFCO", "CHFCO", JdeDataType.String, 10),
        new JdeField("CHN001", "CHN001", JdeDataType.Numeric),
        new JdeField("CHDCT", "CHDCT", JdeDataType.String, 4),
        new JdeField("CHBRMI", "CHBRMI", JdeDataType.String, 2),
        new JdeField("CHBRMD", "CHBRMD", JdeDataType.String, 4),
        new JdeField("CHBSER", "CHBSER", JdeDataType.String, 4),
        new JdeField("CHBNNF", "CHBNNF", JdeDataType.Numeric),
        new JdeField("CHBRNFDE", "CHBRNFDE", JdeDataType.Numeric),
        new JdeField("CHAN8", "CHAN8", JdeDataType.Numeric),
        new JdeField("CHBRNFDES", "CHBRNFDES", JdeDataType.Numeric),
        new JdeField("CHBRNFIV", "CHBRNFIV", JdeDataType.Numeric),
        new JdeField("CHBDES", "CHBDES", JdeDataType.Numeric),
        new JdeField("CHBFRT", "CHBFRT", JdeDataType.Numeric),
        new JdeField("CHBSEG", "CHBSEG", JdeDataType.Numeric),
        new JdeField("CHBDFN", "CHBDFN", JdeDataType.Numeric),
        new JdeField("CHBIPI", "CHBIPI", JdeDataType.Numeric),
        new JdeField("CHBVIS", "CHBVIS", JdeDataType.Numeric),
        new JdeField("CHBVTN", "CHBVTN", JdeDataType.Numeric),
        new JdeField("CHBRSTID", "CHBRSTID", JdeDataType.String, 40),
        new JdeField("CHBRTT", "CHBRTT", JdeDataType.String, 30),
        new JdeField("CHANCR", "CHANCR", JdeDataType.Numeric),
        new JdeField("CHBRVQ", "CHBRVQ", JdeDataType.Numeric),
        new JdeField("CHBRVT", "CHBRVT", JdeDataType.String, 20),
        new JdeField("CHBRGW", "CHBRGW", JdeDataType.Numeric),
        new JdeField("CHBRNW", "CHBRNW", JdeDataType.Numeric),
        new JdeField("CHBRFM", "CHBRFM", JdeDataType.String, 6),
        new JdeField("CHLICP", "CHLICP", JdeDataType.String, 20),
        new JdeField("CHBRCS", "CHBRCS", JdeDataType.String, 2),
        new JdeField("CHBRIT", "CHBRIT", JdeDataType.String, 2),
        new JdeField("CHREMBR", "CHREMBR", JdeDataType.String, 90),
        new JdeField("CHRDOR", "CHRDOR", JdeDataType.String, 2),
        new JdeField("CHC1FU", "CHC1FU", JdeDataType.String, 2),
        new JdeField("CHC2FU", "CHC2FU", JdeDataType.String, 2),
        new JdeField("CHD1FU", "CHD1FU", JdeDataType.Numeric),
        new JdeField("CHD2FU", "CHD2FU", JdeDataType.Numeric),
        new JdeField("CHN1FU", "CHN1FU", JdeDataType.Numeric),
        new JdeField("CHN2FU", "CHN2FU", JdeDataType.Numeric),
        new JdeField("CHN3FU", "CHN3FU", JdeDataType.Numeric),
        new JdeField("CHN4FU", "CHN4FU", JdeDataType.Numeric),
        new JdeField("CHN5FU", "CHN5FU", JdeDataType.Numeric),
        new JdeField("CHN6FU", "CHN6FU", JdeDataType.Numeric),
        new JdeField("CHN7FU", "CHN7FU", JdeDataType.Numeric),
        new JdeField("CHS1FU", "CHS1FU", JdeDataType.String, 60),
        new JdeField("CHS2FU", "CHS2FU", JdeDataType.String, 60),
        new JdeField("CHS3FU", "CHS3FU", JdeDataType.String, 6),
        new JdeField("CHS4FU", "CHS4FU", JdeDataType.String, 6),
        new JdeField("CHGENLNG", "CHGENLNG", JdeDataType.Numeric),
        new JdeField("CHTORG", "CHTORG", JdeDataType.String, 20),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHUPMT", "CHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B410D_0", "Primary Key on CHBRNFK", new[] { "CHBRNFK" }, isUnique: true, isPrimaryKey: true)
    };
}
