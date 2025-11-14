using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740003 - .
/// </summary>
public class F740003 : JdeTable
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
        /// TTEFDJ.
        /// </summary>
        public const string TTEFDJ = "TTEFDJ";

        /// <summary>
        /// TTTA1.
        /// </summary>
        public const string TTTA1 = "TTTA1";

        /// <summary>
        /// TTK74EXRC.
        /// </summary>
        public const string TTK74EXRC = "TTK74EXRC";

        /// <summary>
        /// TTK74TVCC.
        /// </summary>
        public const string TTK74TVCC = "TTK74TVCC";

        /// <summary>
        /// TTK74TE.
        /// </summary>
        public const string TTK74TE = "TTK74TE";

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

        /// <summary>
        /// TTYFUTDT.
        /// </summary>
        public const string TTYFUTDT = "TTYFUTDT";

        /// <summary>
        /// TTFUT3.
        /// </summary>
        public const string TTFUT3 = "TTFUT3";

        /// <summary>
        /// TTFUTCH1.
        /// </summary>
        public const string TTFUTCH1 = "TTFUTCH1";

        /// <summary>
        /// TTX2.
        /// </summary>
        public const string TTX2 = "TTX2";

        /// <summary>
        /// TTFFU4.
        /// </summary>
        public const string TTFFU4 = "TTFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F740003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTTXA1", "TTTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TTITM", "TTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TTEFDJ", "TTEFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TTTA1", "TTTA1", JdeDataType.Numeric),
        new JdeField("TTK74EXRC", "TTK74EXRC", JdeDataType.String, 20),
        new JdeField("TTK74TVCC", "TTK74TVCC", JdeDataType.String, 20),
        new JdeField("TTK74TE", "TTK74TE", JdeDataType.String, 2),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric),
        new JdeField("TTYFUTDT", "TTYFUTDT", JdeDataType.Numeric),
        new JdeField("TTFUT3", "TTFUT3", JdeDataType.String, 60),
        new JdeField("TTFUTCH1", "TTFUTCH1", JdeDataType.String, 2),
        new JdeField("TTX2", "TTX2", JdeDataType.String, 2),
        new JdeField("TTFFU4", "TTFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740003_0", "Primary Key on TTTXA1, TTITM, TTEFDJ", new[] { "TTTXA1", "TTITM", "TTEFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
