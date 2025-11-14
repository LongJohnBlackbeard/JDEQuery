using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09301 - .
/// </summary>
public class F09301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FSRUNUID.
        /// </summary>
        public const string FSRUNUID = "FSRUNUID";

        /// <summary>
        /// FSRUNID.
        /// </summary>
        public const string FSRUNID = "FSRUNID";

        /// <summary>
        /// FSRUNST.
        /// </summary>
        public const string FSRUNST = "FSRUNST";

        /// <summary>
        /// FSRPSTN.
        /// </summary>
        public const string FSRPSTN = "FSRPSTN";

        /// <summary>
        /// FSVERN.
        /// </summary>
        public const string FSVERN = "FSVERN";

        /// <summary>
        /// FSWOBNM.
        /// </summary>
        public const string FSWOBNM = "FSWOBNM";

        /// <summary>
        /// FSRUNDJ.
        /// </summary>
        public const string FSRUNDJ = "FSRUNDJ";

        /// <summary>
        /// FSEXTM.
        /// </summary>
        public const string FSEXTM = "FSEXTM";

        /// <summary>
        /// FSFRCC1.
        /// </summary>
        public const string FSFRCC1 = "FSFRCC1";

        /// <summary>
        /// FSFRCC2.
        /// </summary>
        public const string FSFRCC2 = "FSFRCC2";

        /// <summary>
        /// FSFRCC3.
        /// </summary>
        public const string FSFRCC3 = "FSFRCC3";

        /// <summary>
        /// FSFRCC4.
        /// </summary>
        public const string FSFRCC4 = "FSFRCC4";

        /// <summary>
        /// FSFRCC5.
        /// </summary>
        public const string FSFRCC5 = "FSFRCC5";

        /// <summary>
        /// FSLYNM.
        /// </summary>
        public const string FSLYNM = "FSLYNM";

        /// <summary>
        /// FSLYFM.
        /// </summary>
        public const string FSLYFM = "FSLYFM";

        /// <summary>
        /// FSCRNU1.
        /// </summary>
        public const string FSCRNU1 = "FSCRNU1";

        /// <summary>
        /// FSCRNU2.
        /// </summary>
        public const string FSCRNU2 = "FSCRNU2";

        /// <summary>
        /// FSCRNU3.
        /// </summary>
        public const string FSCRNU3 = "FSCRNU3";

        /// <summary>
        /// FSCRST1.
        /// </summary>
        public const string FSCRST1 = "FSCRST1";

        /// <summary>
        /// FSCRST2.
        /// </summary>
        public const string FSCRST2 = "FSCRST2";

        /// <summary>
        /// FSCRST3.
        /// </summary>
        public const string FSCRST3 = "FSCRST3";

        /// <summary>
        /// FSCRCT1.
        /// </summary>
        public const string FSCRCT1 = "FSCRCT1";

        /// <summary>
        /// FSCRCT2.
        /// </summary>
        public const string FSCRCT2 = "FSCRCT2";

        /// <summary>
        /// FSCRCT3.
        /// </summary>
        public const string FSCRCT3 = "FSCRCT3";

        /// <summary>
        /// FSCRDT1.
        /// </summary>
        public const string FSCRDT1 = "FSCRDT1";

        /// <summary>
        /// FSCRDT2.
        /// </summary>
        public const string FSCRDT2 = "FSCRDT2";

        /// <summary>
        /// FSCRDT3.
        /// </summary>
        public const string FSCRDT3 = "FSCRDT3";

        /// <summary>
        /// FSUSER.
        /// </summary>
        public const string FSUSER = "FSUSER";

        /// <summary>
        /// FSPID.
        /// </summary>
        public const string FSPID = "FSPID";

        /// <summary>
        /// FSJOBN.
        /// </summary>
        public const string FSJOBN = "FSJOBN";

        /// <summary>
        /// FSUPMJ.
        /// </summary>
        public const string FSUPMJ = "FSUPMJ";

        /// <summary>
        /// FSUPMT.
        /// </summary>
        public const string FSUPMT = "FSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FSRUNUID", "FSRUNUID", JdeDataType.String, 20, true, true),
        new JdeField("FSRUNID", "FSRUNID", JdeDataType.Numeric, null, true, true),
        new JdeField("FSRUNST", "FSRUNST", JdeDataType.String, 2),
        new JdeField("FSRPSTN", "FSRPSTN", JdeDataType.String, 40),
        new JdeField("FSVERN", "FSVERN", JdeDataType.String, 40),
        new JdeField("FSWOBNM", "FSWOBNM", JdeDataType.String, 60),
        new JdeField("FSRUNDJ", "FSRUNDJ", JdeDataType.Numeric),
        new JdeField("FSEXTM", "FSEXTM", JdeDataType.Numeric),
        new JdeField("FSFRCC1", "FSFRCC1", JdeDataType.String, 20),
        new JdeField("FSFRCC2", "FSFRCC2", JdeDataType.String, 20),
        new JdeField("FSFRCC3", "FSFRCC3", JdeDataType.String, 20),
        new JdeField("FSFRCC4", "FSFRCC4", JdeDataType.String, 20),
        new JdeField("FSFRCC5", "FSFRCC5", JdeDataType.String, 20),
        new JdeField("FSLYNM", "FSLYNM", JdeDataType.String, 200),
        new JdeField("FSLYFM", "FSLYFM", JdeDataType.String, 100),
        new JdeField("FSCRNU1", "FSCRNU1", JdeDataType.Numeric),
        new JdeField("FSCRNU2", "FSCRNU2", JdeDataType.Numeric),
        new JdeField("FSCRNU3", "FSCRNU3", JdeDataType.Numeric),
        new JdeField("FSCRST1", "FSCRST1", JdeDataType.String, 160),
        new JdeField("FSCRST2", "FSCRST2", JdeDataType.String, 160),
        new JdeField("FSCRST3", "FSCRST3", JdeDataType.String, 160),
        new JdeField("FSCRCT1", "FSCRCT1", JdeDataType.String, 2),
        new JdeField("FSCRCT2", "FSCRCT2", JdeDataType.String, 2),
        new JdeField("FSCRCT3", "FSCRCT3", JdeDataType.String, 2),
        new JdeField("FSCRDT1", "FSCRDT1", JdeDataType.Numeric),
        new JdeField("FSCRDT2", "FSCRDT2", JdeDataType.Numeric),
        new JdeField("FSCRDT3", "FSCRDT3", JdeDataType.Numeric),
        new JdeField("FSUSER", "FSUSER", JdeDataType.String, 20),
        new JdeField("FSPID", "FSPID", JdeDataType.String, 20),
        new JdeField("FSJOBN", "FSJOBN", JdeDataType.String, 20),
        new JdeField("FSUPMJ", "FSUPMJ", JdeDataType.Numeric),
        new JdeField("FSUPMT", "FSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09301_0", "Primary Key on FSRUNUID, FSRUNID", new[] { "FSRUNUID", "FSRUNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09301_2", "Index on FSRUNUID, SYS_NC00033$, SYS_NC00034$", new[] { "FSRUNUID", "SYS_NC00033$", "SYS_NC00034$" })
    };
}
