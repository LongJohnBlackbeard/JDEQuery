using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43091 - .
/// </summary>
public class F43091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPMCU.
        /// </summary>
        public const string PPMCU = "PPMCU";

        /// <summary>
        /// PPNROU.
        /// </summary>
        public const string PPNROU = "PPNROU";

        /// <summary>
        /// PPOPRS.
        /// </summary>
        public const string PPOPRS = "PPOPRS";

        /// <summary>
        /// PPOPRC.
        /// </summary>
        public const string PPOPRC = "PPOPRC";

        /// <summary>
        /// PPTRTY.
        /// </summary>
        public const string PPTRTY = "PPTRTY";

        /// <summary>
        /// PPPDAY.
        /// </summary>
        public const string PPPDAY = "PPPDAY";

        /// <summary>
        /// PPUPIB.
        /// </summary>
        public const string PPUPIB = "PPUPIB";

        /// <summary>
        /// PPUPGL.
        /// </summary>
        public const string PPUPGL = "PPUPGL";

        /// <summary>
        /// PPGLPT.
        /// </summary>
        public const string PPGLPT = "PPGLPT";

        /// <summary>
        /// PPRCPT.
        /// </summary>
        public const string PPRCPT = "PPRCPT";

        /// <summary>
        /// PPPMTE.
        /// </summary>
        public const string PPPMTE = "PPPMTE";
    }

    /// <inheritdoc />
    public override string TableName => "F43091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPMCU", "PPMCU", JdeDataType.String, 24, true, true),
        new JdeField("PPNROU", "PPNROU", JdeDataType.String, 8, true, true),
        new JdeField("PPOPRS", "PPOPRS", JdeDataType.Numeric, null, true, true),
        new JdeField("PPOPRC", "PPOPRC", JdeDataType.String, 8),
        new JdeField("PPTRTY", "PPTRTY", JdeDataType.String, 6),
        new JdeField("PPPDAY", "PPPDAY", JdeDataType.Numeric),
        new JdeField("PPUPIB", "PPUPIB", JdeDataType.String, 8),
        new JdeField("PPUPGL", "PPUPGL", JdeDataType.String, 2),
        new JdeField("PPGLPT", "PPGLPT", JdeDataType.String, 8),
        new JdeField("PPRCPT", "PPRCPT", JdeDataType.String, 2),
        new JdeField("PPPMTE", "PPPMTE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43091_0", "Primary Key on PPNROU, PPMCU, PPOPRS", new[] { "PPNROU", "PPMCU", "PPOPRS" }, isUnique: true, isPrimaryKey: true)
    };
}
