using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09622 - .
/// </summary>
public class F09622 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTTRANT.
        /// </summary>
        public const string TTTRANT = "TTTRANT";

        /// <summary>
        /// TTSTRN.
        /// </summary>
        public const string TTSTRN = "TTSTRN";

        /// <summary>
        /// TTEFI.
        /// </summary>
        public const string TTEFI = "TTEFI";

        /// <summary>
        /// TTMCUOFF.
        /// </summary>
        public const string TTMCUOFF = "TTMCUOFF";

        /// <summary>
        /// TTOBJ.
        /// </summary>
        public const string TTOBJ = "TTOBJ";

        /// <summary>
        /// TTSUB.
        /// </summary>
        public const string TTSUB = "TTSUB";

        /// <summary>
        /// TTDDBCR.
        /// </summary>
        public const string TTDDBCR = "TTDDBCR";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09622";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTTRANT", "TTTRANT", JdeDataType.String, 8, true, true),
        new JdeField("TTSTRN", "TTSTRN", JdeDataType.String, 6, true, true),
        new JdeField("TTEFI", "TTEFI", JdeDataType.String, 12, true, true),
        new JdeField("TTMCUOFF", "TTMCUOFF", JdeDataType.String, 2),
        new JdeField("TTOBJ", "TTOBJ", JdeDataType.String, 12),
        new JdeField("TTSUB", "TTSUB", JdeDataType.String, 16),
        new JdeField("TTDDBCR", "TTDDBCR", JdeDataType.String, 4),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09622_0", "Primary Key on TTEFI, TTTRANT, TTSTRN", new[] { "TTEFI", "TTTRANT", "TTSTRN" }, isUnique: true, isPrimaryKey: true)
    };
}
