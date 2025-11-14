using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42UI11C - .
/// </summary>
public class F42UI11C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCCTID.
        /// </summary>
        public const string SCCTID = "SCCTID";

        /// <summary>
        /// SCPROCESSID.
        /// </summary>
        public const string SCPROCESSID = "SCPROCESSID";

        /// <summary>
        /// SCSNID.
        /// </summary>
        public const string SCSNID = "SCSNID";

        /// <summary>
        /// SCJOBS.
        /// </summary>
        public const string SCJOBS = "SCJOBS";

        /// <summary>
        /// SCLNIX.
        /// </summary>
        public const string SCLNIX = "SCLNIX";

        /// <summary>
        /// SCAN8.
        /// </summary>
        public const string SCAN8 = "SCAN8";

        /// <summary>
        /// SCITM.
        /// </summary>
        public const string SCITM = "SCITM";

        /// <summary>
        /// SCLITM.
        /// </summary>
        public const string SCLITM = "SCLITM";

        /// <summary>
        /// SCAITM.
        /// </summary>
        public const string SCAITM = "SCAITM";

        /// <summary>
        /// SCUORG.
        /// </summary>
        public const string SCUORG = "SCUORG";

        /// <summary>
        /// SCDRQJ.
        /// </summary>
        public const string SCDRQJ = "SCDRQJ";

        /// <summary>
        /// SCSHAN.
        /// </summary>
        public const string SCSHAN = "SCSHAN";
    }

    /// <inheritdoc />
    public override string TableName => "F42UI11C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCCTID", "SCCTID", JdeDataType.String, 30, true, true),
        new JdeField("SCPROCESSID", "SCPROCESSID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCSNID", "SCSNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SCJOBS", "SCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("SCLNIX", "SCLNIX", JdeDataType.Numeric, null, true, true),
        new JdeField("SCAN8", "SCAN8", JdeDataType.Numeric),
        new JdeField("SCITM", "SCITM", JdeDataType.Numeric),
        new JdeField("SCLITM", "SCLITM", JdeDataType.String, 50),
        new JdeField("SCAITM", "SCAITM", JdeDataType.String, 50),
        new JdeField("SCUORG", "SCUORG", JdeDataType.Numeric),
        new JdeField("SCDRQJ", "SCDRQJ", JdeDataType.Numeric),
        new JdeField("SCSHAN", "SCSHAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42UI11C_0", "Primary Key on SCCTID, SCPROCESSID, SCSNID, SCJOBS, SCLNIX", new[] { "SCCTID", "SCPROCESSID", "SCSNID", "SCJOBS", "SCLNIX" }, isUnique: true, isPrimaryKey: true)
    };
}
