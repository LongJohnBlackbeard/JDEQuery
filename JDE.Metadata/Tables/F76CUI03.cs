using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CUI03 - .
/// </summary>
public class F76CUI03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GMCO.
        /// </summary>
        public const string GMCO = "GMCO";

        /// <summary>
        /// GMAID.
        /// </summary>
        public const string GMAID = "GMAID";

        /// <summary>
        /// GMMCU.
        /// </summary>
        public const string GMMCU = "GMMCU";

        /// <summary>
        /// GMOBJ.
        /// </summary>
        public const string GMOBJ = "GMOBJ";

        /// <summary>
        /// GMSUB.
        /// </summary>
        public const string GMSUB = "GMSUB";

        /// <summary>
        /// GMANS.
        /// </summary>
        public const string GMANS = "GMANS";

        /// <summary>
        /// GMLDA.
        /// </summary>
        public const string GMLDA = "GMLDA";

        /// <summary>
        /// GMDL01.
        /// </summary>
        public const string GMDL01 = "GMDL01";

        /// <summary>
        /// GMPEC.
        /// </summary>
        public const string GMPEC = "GMPEC";

        /// <summary>
        /// GMFMOD.
        /// </summary>
        public const string GMFMOD = "GMFMOD";

        /// <summary>
        /// GMR021.
        /// </summary>
        public const string GMR021 = "GMR021";

        /// <summary>
        /// GMUSER.
        /// </summary>
        public const string GMUSER = "GMUSER";

        /// <summary>
        /// GMPID.
        /// </summary>
        public const string GMPID = "GMPID";

        /// <summary>
        /// GMJOBN.
        /// </summary>
        public const string GMJOBN = "GMJOBN";

        /// <summary>
        /// GMUPMJ.
        /// </summary>
        public const string GMUPMJ = "GMUPMJ";

        /// <summary>
        /// GMUPMT.
        /// </summary>
        public const string GMUPMT = "GMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76CUI03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GMCO", "GMCO", JdeDataType.String, 10),
        new JdeField("GMAID", "GMAID", JdeDataType.String, 16),
        new JdeField("GMMCU", "GMMCU", JdeDataType.String, 24, true, true),
        new JdeField("GMOBJ", "GMOBJ", JdeDataType.String, 12, true, true),
        new JdeField("GMSUB", "GMSUB", JdeDataType.String, 16, true, true),
        new JdeField("GMANS", "GMANS", JdeDataType.String, 50),
        new JdeField("GMLDA", "GMLDA", JdeDataType.String, 2),
        new JdeField("GMDL01", "GMDL01", JdeDataType.String, 60),
        new JdeField("GMPEC", "GMPEC", JdeDataType.String, 2),
        new JdeField("GMFMOD", "GMFMOD", JdeDataType.String, 2),
        new JdeField("GMR021", "GMR021", JdeDataType.String, 20, true, true),
        new JdeField("GMUSER", "GMUSER", JdeDataType.String, 20),
        new JdeField("GMPID", "GMPID", JdeDataType.String, 20),
        new JdeField("GMJOBN", "GMJOBN", JdeDataType.String, 20),
        new JdeField("GMUPMJ", "GMUPMJ", JdeDataType.Numeric),
        new JdeField("GMUPMT", "GMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CUI03_0", "Primary Key on GMMCU, GMR021, GMOBJ, GMSUB", new[] { "GMMCU", "GMR021", "GMOBJ", "GMSUB" }, isUnique: true, isPrimaryKey: true)
    };
}
