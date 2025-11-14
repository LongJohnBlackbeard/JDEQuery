using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B040 - .
/// </summary>
public class F76B040 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHJOBS.
        /// </summary>
        public const string PHJOBS = "PHJOBS";

        /// <summary>
        /// PHB76LECO.
        /// </summary>
        public const string PHB76LECO = "PHB76LECO";

        /// <summary>
        /// PHB76ATCT.
        /// </summary>
        public const string PHB76ATCT = "PHB76ATCT";

        /// <summary>
        /// PHDSC1.
        /// </summary>
        public const string PHDSC1 = "PHDSC1";

        /// <summary>
        /// PHEFTB.
        /// </summary>
        public const string PHEFTB = "PHEFTB";

        /// <summary>
        /// PHEFTE.
        /// </summary>
        public const string PHEFTE = "PHEFTE";

        /// <summary>
        /// PHB76WRTY.
        /// </summary>
        public const string PHB76WRTY = "PHB76WRTY";

        /// <summary>
        /// PHB76RNP.
        /// </summary>
        public const string PHB76RNP = "PHB76RNP";

        /// <summary>
        /// PHB76VPC.
        /// </summary>
        public const string PHB76VPC = "PHB76VPC";

        /// <summary>
        /// PHB76CSPI.
        /// </summary>
        public const string PHB76CSPI = "PHB76CSPI";

        /// <summary>
        /// PHB76TIC.
        /// </summary>
        public const string PHB76TIC = "PHB76TIC";

        /// <summary>
        /// PHB76MOA.
        /// </summary>
        public const string PHB76MOA = "PHB76MOA";

        /// <summary>
        /// PHB76TOC.
        /// </summary>
        public const string PHB76TOC = "PHB76TOC";

        /// <summary>
        /// PHB76CIB.
        /// </summary>
        public const string PHB76CIB = "PHB76CIB";

        /// <summary>
        /// PHGPDP.
        /// </summary>
        public const string PHGPDP = "PHGPDP";

        /// <summary>
        /// PHGPBT.
        /// </summary>
        public const string PHGPBT = "PHGPBT";

        /// <summary>
        /// PHB76PRST.
        /// </summary>
        public const string PHB76PRST = "PHB76PRST";

        /// <summary>
        /// PHB76URAB.
        /// </summary>
        public const string PHB76URAB = "PHB76URAB";

        /// <summary>
        /// PHB76URAT.
        /// </summary>
        public const string PHB76URAT = "PHB76URAT";

        /// <summary>
        /// PHB76URRF.
        /// </summary>
        public const string PHB76URRF = "PHB76URRF";

        /// <summary>
        /// PHB76URDT.
        /// </summary>
        public const string PHB76URDT = "PHB76URDT";

        /// <summary>
        /// PHB76URCD.
        /// </summary>
        public const string PHB76URCD = "PHB76URCD";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B040";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHJOBS", "PHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PHB76LECO", "PHB76LECO", JdeDataType.String, 10),
        new JdeField("PHB76ATCT", "PHB76ATCT", JdeDataType.String, 4),
        new JdeField("PHDSC1", "PHDSC1", JdeDataType.String, 60),
        new JdeField("PHEFTB", "PHEFTB", JdeDataType.Numeric),
        new JdeField("PHEFTE", "PHEFTE", JdeDataType.Numeric),
        new JdeField("PHB76WRTY", "PHB76WRTY", JdeDataType.Numeric),
        new JdeField("PHB76RNP", "PHB76RNP", JdeDataType.String, 82),
        new JdeField("PHB76VPC", "PHB76VPC", JdeDataType.String, 6),
        new JdeField("PHB76CSPI", "PHB76CSPI", JdeDataType.String, 2),
        new JdeField("PHB76TIC", "PHB76TIC", JdeDataType.Numeric),
        new JdeField("PHB76MOA", "PHB76MOA", JdeDataType.Numeric),
        new JdeField("PHB76TOC", "PHB76TOC", JdeDataType.Numeric),
        new JdeField("PHB76CIB", "PHB76CIB", JdeDataType.String, 2),
        new JdeField("PHGPDP", "PHGPDP", JdeDataType.Numeric),
        new JdeField("PHGPBT", "PHGPBT", JdeDataType.Numeric),
        new JdeField("PHB76PRST", "PHB76PRST", JdeDataType.String, 2),
        new JdeField("PHB76URAB", "PHB76URAB", JdeDataType.Numeric),
        new JdeField("PHB76URAT", "PHB76URAT", JdeDataType.Numeric),
        new JdeField("PHB76URRF", "PHB76URRF", JdeDataType.String, 30),
        new JdeField("PHB76URDT", "PHB76URDT", JdeDataType.Numeric),
        new JdeField("PHB76URCD", "PHB76URCD", JdeDataType.String, 4),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B040_0", "Primary Key on PHJOBS", new[] { "PHJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
