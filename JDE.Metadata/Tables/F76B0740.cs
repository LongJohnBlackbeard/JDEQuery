using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0740 - .
/// </summary>
public class F76B0740 : JdeTable
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
        /// PHB76ATCT.
        /// </summary>
        public const string PHB76ATCT = "PHB76ATCT";

        /// <summary>
        /// PHDSC1.
        /// </summary>
        public const string PHDSC1 = "PHDSC1";

        /// <summary>
        /// PHCO.
        /// </summary>
        public const string PHCO = "PHCO";

        /// <summary>
        /// PHEFTB.
        /// </summary>
        public const string PHEFTB = "PHEFTB";

        /// <summary>
        /// PHEFTE.
        /// </summary>
        public const string PHEFTE = "PHEFTE";

        /// <summary>
        /// PHGPDP.
        /// </summary>
        public const string PHGPDP = "PHGPDP";

        /// <summary>
        /// PHB76COPU.
        /// </summary>
        public const string PHB76COPU = "PHB76COPU";

        /// <summary>
        /// PHGPBT.
        /// </summary>
        public const string PHGPBT = "PHGPBT";

        /// <summary>
        /// PHB76PRST.
        /// </summary>
        public const string PHB76PRST = "PHB76PRST";

        /// <summary>
        /// PHURCD.
        /// </summary>
        public const string PHURCD = "PHURCD";

        /// <summary>
        /// PHURDT.
        /// </summary>
        public const string PHURDT = "PHURDT";

        /// <summary>
        /// PHURAT.
        /// </summary>
        public const string PHURAT = "PHURAT";

        /// <summary>
        /// PHURAB.
        /// </summary>
        public const string PHURAB = "PHURAB";

        /// <summary>
        /// PHURRF.
        /// </summary>
        public const string PHURRF = "PHURRF";

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
    public override string TableName => "F76B0740";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHJOBS", "PHJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PHB76ATCT", "PHB76ATCT", JdeDataType.String, 4),
        new JdeField("PHDSC1", "PHDSC1", JdeDataType.String, 60),
        new JdeField("PHCO", "PHCO", JdeDataType.String, 10),
        new JdeField("PHEFTB", "PHEFTB", JdeDataType.Numeric),
        new JdeField("PHEFTE", "PHEFTE", JdeDataType.Numeric),
        new JdeField("PHGPDP", "PHGPDP", JdeDataType.Numeric),
        new JdeField("PHB76COPU", "PHB76COPU", JdeDataType.String, 6),
        new JdeField("PHGPBT", "PHGPBT", JdeDataType.Numeric),
        new JdeField("PHB76PRST", "PHB76PRST", JdeDataType.String, 2),
        new JdeField("PHURCD", "PHURCD", JdeDataType.String, 4),
        new JdeField("PHURDT", "PHURDT", JdeDataType.Numeric),
        new JdeField("PHURAT", "PHURAT", JdeDataType.Numeric),
        new JdeField("PHURAB", "PHURAB", JdeDataType.Numeric),
        new JdeField("PHURRF", "PHURRF", JdeDataType.String, 30),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0740_0", "Primary Key on PHJOBS", new[] { "PHJOBS" }, isUnique: true, isPrimaryKey: true)
    };
}
