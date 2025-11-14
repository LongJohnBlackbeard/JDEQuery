using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW58 - .
/// </summary>
public class FCW58 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFPRODM.
        /// </summary>
        public const string WFPRODM = "WFPRODM";

        /// <summary>
        /// WFPRODF.
        /// </summary>
        public const string WFPRODF = "WFPRODF";

        /// <summary>
        /// WFMCUZ.
        /// </summary>
        public const string WFMCUZ = "WFMCUZ";

        /// <summary>
        /// WFDCD1.
        /// </summary>
        public const string WFDCD1 = "WFDCD1";

        /// <summary>
        /// WFDCD2.
        /// </summary>
        public const string WFDCD2 = "WFDCD2";

        /// <summary>
        /// WFDCD3.
        /// </summary>
        public const string WFDCD3 = "WFDCD3";

        /// <summary>
        /// WFDCD4.
        /// </summary>
        public const string WFDCD4 = "WFDCD4";

        /// <summary>
        /// WFDCD5.
        /// </summary>
        public const string WFDCD5 = "WFDCD5";

        /// <summary>
        /// WFRTRND.
        /// </summary>
        public const string WFRTRND = "WFRTRND";

        /// <summary>
        /// WFRPRBL.
        /// </summary>
        public const string WFRPRBL = "WFRPRBL";

        /// <summary>
        /// WFCCOST.
        /// </summary>
        public const string WFCCOST = "WFCCOST";

        /// <summary>
        /// WFRETPOL.
        /// </summary>
        public const string WFRETPOL = "WFRETPOL";

        /// <summary>
        /// WFSRYN.
        /// </summary>
        public const string WFSRYN = "WFSRYN";

        /// <summary>
        /// WFIBYN.
        /// </summary>
        public const string WFIBYN = "WFIBYN";

        /// <summary>
        /// WFVMRS33.
        /// </summary>
        public const string WFVMRS33 = "WFVMRS33";
    }

    /// <inheritdoc />
    public override string TableName => "FCW58";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFPRODM", "WFPRODM", JdeDataType.String, 16),
        new JdeField("WFPRODF", "WFPRODF", JdeDataType.String, 16),
        new JdeField("WFMCUZ", "WFMCUZ", JdeDataType.String, 24),
        new JdeField("WFDCD1", "WFDCD1", JdeDataType.String, 6),
        new JdeField("WFDCD2", "WFDCD2", JdeDataType.String, 6),
        new JdeField("WFDCD3", "WFDCD3", JdeDataType.String, 6),
        new JdeField("WFDCD4", "WFDCD4", JdeDataType.String, 6),
        new JdeField("WFDCD5", "WFDCD5", JdeDataType.String, 6),
        new JdeField("WFRTRND", "WFRTRND", JdeDataType.String, 2),
        new JdeField("WFRPRBL", "WFRPRBL", JdeDataType.String, 2),
        new JdeField("WFCCOST", "WFCCOST", JdeDataType.String, 6),
        new JdeField("WFRETPOL", "WFRETPOL", JdeDataType.String, 2),
        new JdeField("WFSRYN", "WFSRYN", JdeDataType.String, 2),
        new JdeField("WFIBYN", "WFIBYN", JdeDataType.String, 2),
        new JdeField("WFVMRS33", "WFVMRS33", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW58_0", "Primary Key on WFITM, WFEV01", new[] { "WFITM", "WFEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
