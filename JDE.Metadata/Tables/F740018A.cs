using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740018A - .
/// </summary>
public class F740018A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTTXA1.
        /// </summary>
        public const string TTTXA1 = "TTTXA1";

        /// <summary>
        /// TTITM.
        /// </summary>
        public const string TTITM = "TTITM";

        /// <summary>
        /// TT74TRTY.
        /// </summary>
        public const string TT74TRTY = "TT74TRTY";

        /// <summary>
        /// TT74TRFG.
        /// </summary>
        public const string TT74TRFG = "TT74TRFG";

        /// <summary>
        /// TTFFG1.
        /// </summary>
        public const string TTFFG1 = "TTFFG1";

        /// <summary>
        /// TTFFU4.
        /// </summary>
        public const string TTFFU4 = "TTFFU4";

        /// <summary>
        /// TTFUT3.
        /// </summary>
        public const string TTFUT3 = "TTFUT3";

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
    public override string TableName => "F740018A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTTXA1", "TTTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TTITM", "TTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TT74TRTY", "TT74TRTY", JdeDataType.String, 2),
        new JdeField("TT74TRFG", "TT74TRFG", JdeDataType.String, 2),
        new JdeField("TTFFG1", "TTFFG1", JdeDataType.String, 2),
        new JdeField("TTFFU4", "TTFFU4", JdeDataType.Numeric),
        new JdeField("TTFUT3", "TTFUT3", JdeDataType.String, 60),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740018A_0", "Primary Key on TTTXA1, TTITM", new[] { "TTTXA1", "TTITM" }, isUnique: true, isPrimaryKey: true)
    };
}
