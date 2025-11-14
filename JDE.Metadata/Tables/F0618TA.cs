using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0618TA - .
/// </summary>
public class F0618TA : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YTAN8.
        /// </summary>
        public const string YTAN8 = "YTAN8";

        /// <summary>
        /// YTPRTR.
        /// </summary>
        public const string YTPRTR = "YTPRTR";

        /// <summary>
        /// YTDWK.
        /// </summary>
        public const string YTDWK = "YTDWK";

        /// <summary>
        /// YTBLGRT.
        /// </summary>
        public const string YTBLGRT = "YTBLGRT";

        /// <summary>
        /// YTRCHGAMT.
        /// </summary>
        public const string YTRCHGAMT = "YTRCHGAMT";

        /// <summary>
        /// YTFBLGRT.
        /// </summary>
        public const string YTFBLGRT = "YTFBLGRT";

        /// <summary>
        /// YTFRCHGAMT.
        /// </summary>
        public const string YTFRCHGAMT = "YTFRCHGAMT";

        /// <summary>
        /// YTCRR.
        /// </summary>
        public const string YTCRR = "YTCRR";

        /// <summary>
        /// YTCRCD.
        /// </summary>
        public const string YTCRCD = "YTCRCD";

        /// <summary>
        /// YTCRDC.
        /// </summary>
        public const string YTCRDC = "YTCRDC";

        /// <summary>
        /// YTRCHGMODE.
        /// </summary>
        public const string YTRCHGMODE = "YTRCHGMODE";
    }

    /// <inheritdoc />
    public override string TableName => "F0618TA";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YTAN8", "YTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YTPRTR", "YTPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("YTDWK", "YTDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("YTBLGRT", "YTBLGRT", JdeDataType.Numeric),
        new JdeField("YTRCHGAMT", "YTRCHGAMT", JdeDataType.Numeric),
        new JdeField("YTFBLGRT", "YTFBLGRT", JdeDataType.Numeric),
        new JdeField("YTFRCHGAMT", "YTFRCHGAMT", JdeDataType.Numeric),
        new JdeField("YTCRR", "YTCRR", JdeDataType.Numeric),
        new JdeField("YTCRCD", "YTCRCD", JdeDataType.String, 6),
        new JdeField("YTCRDC", "YTCRDC", JdeDataType.String, 6),
        new JdeField("YTRCHGMODE", "YTRCHGMODE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0618TA_0", "Primary Key on YTAN8, YTPRTR, YTDWK", new[] { "YTAN8", "YTPRTR", "YTDWK" }, isUnique: true, isPrimaryKey: true)
    };
}
