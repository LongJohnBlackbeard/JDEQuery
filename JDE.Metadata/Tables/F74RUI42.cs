using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74RUI42 - .
/// </summary>
public class F74RUI42 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W2KCO.
        /// </summary>
        public const string W2KCO = "W2KCO";

        /// <summary>
        /// W2DCT.
        /// </summary>
        public const string W2DCT = "W2DCT";

        /// <summary>
        /// W2DOC.
        /// </summary>
        public const string W2DOC = "W2DOC";

        /// <summary>
        /// W2LNID.
        /// </summary>
        public const string W2LNID = "W2LNID";

        /// <summary>
        /// W2NLNID.
        /// </summary>
        public const string W2NLNID = "W2NLNID";

        /// <summary>
        /// W2SY.
        /// </summary>
        public const string W2SY = "W2SY";

        /// <summary>
        /// W2DL01.
        /// </summary>
        public const string W2DL01 = "W2DL01";

        /// <summary>
        /// W2K74CUDE.
        /// </summary>
        public const string W2K74CUDE = "W2K74CUDE";

        /// <summary>
        /// W2JOBS.
        /// </summary>
        public const string W2JOBS = "W2JOBS";

        /// <summary>
        /// W2CTID.
        /// </summary>
        public const string W2CTID = "W2CTID";

        /// <summary>
        /// W2PID.
        /// </summary>
        public const string W2PID = "W2PID";

        /// <summary>
        /// W2USER.
        /// </summary>
        public const string W2USER = "W2USER";

        /// <summary>
        /// W2UPMJ.
        /// </summary>
        public const string W2UPMJ = "W2UPMJ";

        /// <summary>
        /// W2UPMT.
        /// </summary>
        public const string W2UPMT = "W2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74RUI42";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W2KCO", "W2KCO", JdeDataType.String, 10, true, true),
        new JdeField("W2DCT", "W2DCT", JdeDataType.String, 4, true, true),
        new JdeField("W2DOC", "W2DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("W2LNID", "W2LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("W2NLNID", "W2NLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("W2SY", "W2SY", JdeDataType.String, 8, true, true),
        new JdeField("W2DL01", "W2DL01", JdeDataType.String, 60),
        new JdeField("W2K74CUDE", "W2K74CUDE", JdeDataType.String, 120),
        new JdeField("W2JOBS", "W2JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("W2CTID", "W2CTID", JdeDataType.String, 30, true, true),
        new JdeField("W2PID", "W2PID", JdeDataType.String, 20),
        new JdeField("W2USER", "W2USER", JdeDataType.String, 20),
        new JdeField("W2UPMJ", "W2UPMJ", JdeDataType.Numeric),
        new JdeField("W2UPMT", "W2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74RUI42_0", "Primary Key on W2KCO, W2DCT, W2DOC, W2LNID, W2NLNID, W2SY, W2JOBS, W2CTID", new[] { "W2KCO", "W2DCT", "W2DOC", "W2LNID", "W2NLNID", "W2SY", "W2JOBS", "W2CTID" }, isUnique: true, isPrimaryKey: true)
    };
}
