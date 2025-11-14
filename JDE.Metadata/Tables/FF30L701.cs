using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L701 - .
/// </summary>
public class FF30L701 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMPROID.
        /// </summary>
        public const string PMPROID = "PMPROID";

        /// <summary>
        /// PMPRNA.
        /// </summary>
        public const string PMPRNA = "PMPRNA";

        /// <summary>
        /// PMDSCPR.
        /// </summary>
        public const string PMDSCPR = "PMDSCPR";

        /// <summary>
        /// PMPRWC.
        /// </summary>
        public const string PMPRWC = "PMPRWC";

        /// <summary>
        /// PMPRDLB.
        /// </summary>
        public const string PMPRDLB = "PMPRDLB";

        /// <summary>
        /// PMPRMC.
        /// </summary>
        public const string PMPRMC = "PMPRMC";

        /// <summary>
        /// PMPRYP.
        /// </summary>
        public const string PMPRYP = "PMPRYP";

        /// <summary>
        /// PMPRWP.
        /// </summary>
        public const string PMPRWP = "PMPRWP";

        /// <summary>
        /// PMPSRP.
        /// </summary>
        public const string PMPSRP = "PMPSRP";

        /// <summary>
        /// PMSPRID.
        /// </summary>
        public const string PMSPRID = "PMSPRID";

        /// <summary>
        /// PMEOLF.
        /// </summary>
        public const string PMEOLF = "PMEOLF";

        /// <summary>
        /// PMFSCID.
        /// </summary>
        public const string PMFSCID = "PMFSCID";

        /// <summary>
        /// PMURCD.
        /// </summary>
        public const string PMURCD = "PMURCD";

        /// <summary>
        /// PMURDT.
        /// </summary>
        public const string PMURDT = "PMURDT";

        /// <summary>
        /// PMURAT.
        /// </summary>
        public const string PMURAT = "PMURAT";

        /// <summary>
        /// PMURAB.
        /// </summary>
        public const string PMURAB = "PMURAB";

        /// <summary>
        /// PMURRF.
        /// </summary>
        public const string PMURRF = "PMURRF";

        /// <summary>
        /// PMUSER.
        /// </summary>
        public const string PMUSER = "PMUSER";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMMKEY.
        /// </summary>
        public const string PMMKEY = "PMMKEY";

        /// <summary>
        /// PMUUPMJ.
        /// </summary>
        public const string PMUUPMJ = "PMUUPMJ";

        /// <summary>
        /// PMPMMMT.
        /// </summary>
        public const string PMPMMMT = "PMPMMMT";

        /// <summary>
        /// PMPMMST.
        /// </summary>
        public const string PMPMMST = "PMPMMST";

        /// <summary>
        /// PMPMLMT.
        /// </summary>
        public const string PMPMLMT = "PMPMLMT";

        /// <summary>
        /// PMPMLST.
        /// </summary>
        public const string PMPMLST = "PMPMLST";

        /// <summary>
        /// PMDFMMCU.
        /// </summary>
        public const string PMDFMMCU = "PMDFMMCU";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L701";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMPROID", "PMPROID", JdeDataType.Numeric, null, true, true),
        new JdeField("PMPRNA", "PMPRNA", JdeDataType.String, 60),
        new JdeField("PMDSCPR", "PMDSCPR", JdeDataType.String, 60),
        new JdeField("PMPRWC", "PMPRWC", JdeDataType.String, 24),
        new JdeField("PMPRDLB", "PMPRDLB", JdeDataType.Numeric),
        new JdeField("PMPRMC", "PMPRMC", JdeDataType.Numeric),
        new JdeField("PMPRYP", "PMPRYP", JdeDataType.Numeric),
        new JdeField("PMPRWP", "PMPRWP", JdeDataType.Numeric),
        new JdeField("PMPSRP", "PMPSRP", JdeDataType.Numeric),
        new JdeField("PMSPRID", "PMSPRID", JdeDataType.Numeric),
        new JdeField("PMEOLF", "PMEOLF", JdeDataType.String, 2),
        new JdeField("PMFSCID", "PMFSCID", JdeDataType.Numeric),
        new JdeField("PMURCD", "PMURCD", JdeDataType.String, 4),
        new JdeField("PMURDT", "PMURDT", JdeDataType.Numeric),
        new JdeField("PMURAT", "PMURAT", JdeDataType.Numeric),
        new JdeField("PMURAB", "PMURAB", JdeDataType.Numeric),
        new JdeField("PMURRF", "PMURRF", JdeDataType.String, 30),
        new JdeField("PMUSER", "PMUSER", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMMKEY", "PMMKEY", JdeDataType.String, 30),
        new JdeField("PMUUPMJ", "PMUUPMJ", JdeDataType.Date),
        new JdeField("PMPMMMT", "PMPMMMT", JdeDataType.Numeric),
        new JdeField("PMPMMST", "PMPMMST", JdeDataType.Numeric),
        new JdeField("PMPMLMT", "PMPMLMT", JdeDataType.Numeric),
        new JdeField("PMPMLST", "PMPMLST", JdeDataType.Numeric),
        new JdeField("PMDFMMCU", "PMDFMMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L701_0", "Primary Key on PMPROID", new[] { "PMPROID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L701_2", "Unique Index on PMFSCID, PMPRNA", new[] { "PMFSCID", "PMPRNA" }, isUnique: true),
        new JdeIndex("FF30L701_3", "Index on PMEOLF", new[] { "PMEOLF" }),
        new JdeIndex("FF30L701_4", "Index on PMFSCID", new[] { "PMFSCID" }),
        new JdeIndex("FF30L701_5", "Index on PMSPRID", new[] { "PMSPRID" }),
        new JdeIndex("FF30L701_6", "Index on PMEOLF, PMFSCID", new[] { "PMEOLF", "PMFSCID" }),
        new JdeIndex("FF30L701_7", "Index on PMFSCID, PMPRWC, PMDFMMCU", new[] { "PMFSCID", "PMPRWC", "PMDFMMCU" })
    };
}
