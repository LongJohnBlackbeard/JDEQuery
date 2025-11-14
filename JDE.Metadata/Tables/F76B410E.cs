using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B410E - .
/// </summary>
public class F76B410E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHBRNFK.
        /// </summary>
        public const string SHBRNFK = "SHBRNFK";

        /// <summary>
        /// SHFCO.
        /// </summary>
        public const string SHFCO = "SHFCO";

        /// <summary>
        /// SHN001.
        /// </summary>
        public const string SHN001 = "SHN001";

        /// <summary>
        /// SHDCT.
        /// </summary>
        public const string SHDCT = "SHDCT";

        /// <summary>
        /// SHBRMD.
        /// </summary>
        public const string SHBRMD = "SHBRMD";

        /// <summary>
        /// SHBSER.
        /// </summary>
        public const string SHBSER = "SHBSER";

        /// <summary>
        /// SHBNNF.
        /// </summary>
        public const string SHBNNF = "SHBNNF";

        /// <summary>
        /// SHBRNFDE.
        /// </summary>
        public const string SHBRNFDE = "SHBRNFDE";

        /// <summary>
        /// SHBSFH.
        /// </summary>
        public const string SHBSFH = "SHBSFH";

        /// <summary>
        /// SHBRNFDES.
        /// </summary>
        public const string SHBRNFDES = "SHBRNFDES";

        /// <summary>
        /// SHBRNFIV.
        /// </summary>
        public const string SHBRNFIV = "SHBRNFIV";

        /// <summary>
        /// SHBDES.
        /// </summary>
        public const string SHBDES = "SHBDES";

        /// <summary>
        /// SHBFRT.
        /// </summary>
        public const string SHBFRT = "SHBFRT";

        /// <summary>
        /// SHBSEG.
        /// </summary>
        public const string SHBSEG = "SHBSEG";

        /// <summary>
        /// SHBDFN.
        /// </summary>
        public const string SHBDFN = "SHBDFN";

        /// <summary>
        /// SHBIPI.
        /// </summary>
        public const string SHBIPI = "SHBIPI";

        /// <summary>
        /// SHBVIS.
        /// </summary>
        public const string SHBVIS = "SHBVIS";

        /// <summary>
        /// SHBVTN.
        /// </summary>
        public const string SHBVTN = "SHBVTN";

        /// <summary>
        /// SHBRSTID.
        /// </summary>
        public const string SHBRSTID = "SHBRSTID";

        /// <summary>
        /// SHBRIT.
        /// </summary>
        public const string SHBRIT = "SHBRIT";

        /// <summary>
        /// SHREMBR.
        /// </summary>
        public const string SHREMBR = "SHREMBR";

        /// <summary>
        /// SHRDOR.
        /// </summary>
        public const string SHRDOR = "SHRDOR";

        /// <summary>
        /// SHC1FU.
        /// </summary>
        public const string SHC1FU = "SHC1FU";

        /// <summary>
        /// SHC2FU.
        /// </summary>
        public const string SHC2FU = "SHC2FU";

        /// <summary>
        /// SHD1FU.
        /// </summary>
        public const string SHD1FU = "SHD1FU";

        /// <summary>
        /// SHD2FU.
        /// </summary>
        public const string SHD2FU = "SHD2FU";

        /// <summary>
        /// SHN1FU.
        /// </summary>
        public const string SHN1FU = "SHN1FU";

        /// <summary>
        /// SHN2FU.
        /// </summary>
        public const string SHN2FU = "SHN2FU";

        /// <summary>
        /// SHN3FU.
        /// </summary>
        public const string SHN3FU = "SHN3FU";

        /// <summary>
        /// SHN4FU.
        /// </summary>
        public const string SHN4FU = "SHN4FU";

        /// <summary>
        /// SHN5FU.
        /// </summary>
        public const string SHN5FU = "SHN5FU";

        /// <summary>
        /// SHN6FU.
        /// </summary>
        public const string SHN6FU = "SHN6FU";

        /// <summary>
        /// SHN7FU.
        /// </summary>
        public const string SHN7FU = "SHN7FU";

        /// <summary>
        /// SHS1FU.
        /// </summary>
        public const string SHS1FU = "SHS1FU";

        /// <summary>
        /// SHS2FU.
        /// </summary>
        public const string SHS2FU = "SHS2FU";

        /// <summary>
        /// SHS3FU.
        /// </summary>
        public const string SHS3FU = "SHS3FU";

        /// <summary>
        /// SHS4FU.
        /// </summary>
        public const string SHS4FU = "SHS4FU";

        /// <summary>
        /// SHGENLNG.
        /// </summary>
        public const string SHGENLNG = "SHGENLNG";

        /// <summary>
        /// SHTORG.
        /// </summary>
        public const string SHTORG = "SHTORG";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B410E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHBRNFK", "SHBRNFK", JdeDataType.Numeric, null, true, true),
        new JdeField("SHFCO", "SHFCO", JdeDataType.String, 10),
        new JdeField("SHN001", "SHN001", JdeDataType.Numeric),
        new JdeField("SHDCT", "SHDCT", JdeDataType.String, 4),
        new JdeField("SHBRMD", "SHBRMD", JdeDataType.String, 4),
        new JdeField("SHBSER", "SHBSER", JdeDataType.String, 4),
        new JdeField("SHBNNF", "SHBNNF", JdeDataType.Numeric),
        new JdeField("SHBRNFDE", "SHBRNFDE", JdeDataType.Numeric),
        new JdeField("SHBSFH", "SHBSFH", JdeDataType.Numeric),
        new JdeField("SHBRNFDES", "SHBRNFDES", JdeDataType.Numeric),
        new JdeField("SHBRNFIV", "SHBRNFIV", JdeDataType.Numeric),
        new JdeField("SHBDES", "SHBDES", JdeDataType.Numeric),
        new JdeField("SHBFRT", "SHBFRT", JdeDataType.Numeric),
        new JdeField("SHBSEG", "SHBSEG", JdeDataType.Numeric),
        new JdeField("SHBDFN", "SHBDFN", JdeDataType.Numeric),
        new JdeField("SHBIPI", "SHBIPI", JdeDataType.Numeric),
        new JdeField("SHBVIS", "SHBVIS", JdeDataType.Numeric),
        new JdeField("SHBVTN", "SHBVTN", JdeDataType.Numeric),
        new JdeField("SHBRSTID", "SHBRSTID", JdeDataType.String, 40),
        new JdeField("SHBRIT", "SHBRIT", JdeDataType.String, 2),
        new JdeField("SHREMBR", "SHREMBR", JdeDataType.String, 90),
        new JdeField("SHRDOR", "SHRDOR", JdeDataType.String, 2),
        new JdeField("SHC1FU", "SHC1FU", JdeDataType.String, 2),
        new JdeField("SHC2FU", "SHC2FU", JdeDataType.String, 2),
        new JdeField("SHD1FU", "SHD1FU", JdeDataType.Numeric),
        new JdeField("SHD2FU", "SHD2FU", JdeDataType.Numeric),
        new JdeField("SHN1FU", "SHN1FU", JdeDataType.Numeric),
        new JdeField("SHN2FU", "SHN2FU", JdeDataType.Numeric),
        new JdeField("SHN3FU", "SHN3FU", JdeDataType.Numeric),
        new JdeField("SHN4FU", "SHN4FU", JdeDataType.Numeric),
        new JdeField("SHN5FU", "SHN5FU", JdeDataType.Numeric),
        new JdeField("SHN6FU", "SHN6FU", JdeDataType.Numeric),
        new JdeField("SHN7FU", "SHN7FU", JdeDataType.Numeric),
        new JdeField("SHS1FU", "SHS1FU", JdeDataType.String, 60),
        new JdeField("SHS2FU", "SHS2FU", JdeDataType.String, 60),
        new JdeField("SHS3FU", "SHS3FU", JdeDataType.String, 6),
        new JdeField("SHS4FU", "SHS4FU", JdeDataType.String, 6),
        new JdeField("SHGENLNG", "SHGENLNG", JdeDataType.Numeric),
        new JdeField("SHTORG", "SHTORG", JdeDataType.String, 20),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B410E_0", "Primary Key on SHBRNFK", new[] { "SHBRNFK" }, isUnique: true, isPrimaryKey: true)
    };
}
