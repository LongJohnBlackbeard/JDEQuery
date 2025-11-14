using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74LUI03 - .
/// </summary>
public class F74LUI03 : JdeTable
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
        /// TTTXA1.
        /// </summary>
        public const string TTTXA1 = "TTTXA1";

        /// <summary>
        /// TTEFDJ.
        /// </summary>
        public const string TTEFDJ = "TTEFDJ";

        /// <summary>
        /// TTITM.
        /// </summary>
        public const string TTITM = "TTITM";

        /// <summary>
        /// TTTXR1.
        /// </summary>
        public const string TTTXR1 = "TTTXR1";

        /// <summary>
        /// TTL74TT.
        /// </summary>
        public const string TTL74TT = "TTL74TT";

        /// <summary>
        /// TTL74TR.
        /// </summary>
        public const string TTL74TR = "TTL74TR";

        /// <summary>
        /// TTL74TC.
        /// </summary>
        public const string TTL74TC = "TTL74TC";

        /// <summary>
        /// TTSTAM.
        /// </summary>
        public const string TTSTAM = "TTSTAM";
    }

    /// <inheritdoc />
    public override string TableName => "F74LUI03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTJOBS", "TTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TTTXA1", "TTTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TTEFDJ", "TTEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TTITM", "TTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TTTXR1", "TTTXR1", JdeDataType.Numeric),
        new JdeField("TTL74TT", "TTL74TT", JdeDataType.String, 6),
        new JdeField("TTL74TR", "TTL74TR", JdeDataType.String, 10),
        new JdeField("TTL74TC", "TTL74TC", JdeDataType.String, 6),
        new JdeField("TTSTAM", "TTSTAM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74LUI03_0", "Primary Key on TTJOBS, TTTXA1, TTEFDJ, TTITM", new[] { "TTJOBS", "TTTXA1", "TTEFDJ", "TTITM" }, isUnique: true, isPrimaryKey: true)
    };
}
