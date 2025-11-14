using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74LUI02 - .
/// </summary>
public class F74LUI02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTJOBS.
        /// </summary>
        public const string TTJOBS = "TTJOBS";

        /// <summary>
        /// TTITM.
        /// </summary>
        public const string TTITM = "TTITM";

        /// <summary>
        /// TTLITM.
        /// </summary>
        public const string TTLITM = "TTLITM";

        /// <summary>
        /// TTDSC1.
        /// </summary>
        public const string TTDSC1 = "TTDSC1";

        /// <summary>
        /// TTG70CC01.
        /// </summary>
        public const string TTG70CC01 = "TTG70CC01";

        /// <summary>
        /// TTG70CC02.
        /// </summary>
        public const string TTG70CC02 = "TTG70CC02";

        /// <summary>
        /// TTCITM.
        /// </summary>
        public const string TTCITM = "TTCITM";
    }

    /// <inheritdoc />
    public override string TableName => "F74LUI02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTJOBS", "TTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TTITM", "TTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TTLITM", "TTLITM", JdeDataType.String, 50),
        new JdeField("TTDSC1", "TTDSC1", JdeDataType.String, 60),
        new JdeField("TTG70CC01", "TTG70CC01", JdeDataType.String, 20),
        new JdeField("TTG70CC02", "TTG70CC02", JdeDataType.String, 20),
        new JdeField("TTCITM", "TTCITM", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74LUI02_0", "Primary Key on TTJOBS, TTITM", new[] { "TTJOBS", "TTITM" }, isUnique: true, isPrimaryKey: true)
    };
}
