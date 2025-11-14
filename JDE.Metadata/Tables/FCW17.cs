using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW17 - .
/// </summary>
public class FCW17 : JdeTable
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
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFUM.
        /// </summary>
        public const string WFUM = "WFUM";

        /// <summary>
        /// WFRUM.
        /// </summary>
        public const string WFRUM = "WFRUM";

        /// <summary>
        /// WFUSTR.
        /// </summary>
        public const string WFUSTR = "WFUSTR";

        /// <summary>
        /// WFCONV.
        /// </summary>
        public const string WFCONV = "WFCONV";

        /// <summary>
        /// WFCNV1.
        /// </summary>
        public const string WFCNV1 = "WFCNV1";

        /// <summary>
        /// WFEXPO.
        /// </summary>
        public const string WFEXPO = "WFEXPO";

        /// <summary>
        /// WFEXSO.
        /// </summary>
        public const string WFEXSO = "WFEXSO";

        /// <summary>
        /// WFPUPC.
        /// </summary>
        public const string WFPUPC = "WFPUPC";

        /// <summary>
        /// WFSEPC.
        /// </summary>
        public const string WFSEPC = "WFSEPC";
    }

    /// <inheritdoc />
    public override string TableName => "FCW17";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24, true, true),
        new JdeField("WFUM", "WFUM", JdeDataType.String, 4, true, true),
        new JdeField("WFRUM", "WFRUM", JdeDataType.String, 4, true, true),
        new JdeField("WFUSTR", "WFUSTR", JdeDataType.String, 2),
        new JdeField("WFCONV", "WFCONV", JdeDataType.Numeric),
        new JdeField("WFCNV1", "WFCNV1", JdeDataType.Numeric),
        new JdeField("WFEXPO", "WFEXPO", JdeDataType.String, 2),
        new JdeField("WFEXSO", "WFEXSO", JdeDataType.String, 2),
        new JdeField("WFPUPC", "WFPUPC", JdeDataType.Numeric),
        new JdeField("WFSEPC", "WFSEPC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW17_0", "Primary Key on WFITM, WFEV01, WFMCU, WFUM, WFRUM", new[] { "WFITM", "WFEV01", "WFMCU", "WFUM", "WFRUM" }, isUnique: true, isPrimaryKey: true)
    };
}
