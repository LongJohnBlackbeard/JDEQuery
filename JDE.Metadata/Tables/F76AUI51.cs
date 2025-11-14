using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI51 - .
/// </summary>
public class F76AUI51 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IKHDC.
        /// </summary>
        public const string IKHDC = "IKHDC";

        /// <summary>
        /// IKCKC.
        /// </summary>
        public const string IKCKC = "IKCKC";

        /// <summary>
        /// IKAN8.
        /// </summary>
        public const string IKAN8 = "IKAN8";

        /// <summary>
        /// IKDCT.
        /// </summary>
        public const string IKDCT = "IKDCT";

        /// <summary>
        /// IKDOC.
        /// </summary>
        public const string IKDOC = "IKDOC";

        /// <summary>
        /// IKKCO.
        /// </summary>
        public const string IKKCO = "IKKCO";

        /// <summary>
        /// IKSFX.
        /// </summary>
        public const string IKSFX = "IKSFX";

        /// <summary>
        /// IKPTC.
        /// </summary>
        public const string IKPTC = "IKPTC";

        /// <summary>
        /// IKPYIN.
        /// </summary>
        public const string IKPYIN = "IKPYIN";

        /// <summary>
        /// IKDTAI.
        /// </summary>
        public const string IKDTAI = "IKDTAI";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI51";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IKHDC", "IKHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("IKCKC", "IKCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("IKAN8", "IKAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("IKDCT", "IKDCT", JdeDataType.String, 4, true, true),
        new JdeField("IKDOC", "IKDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("IKKCO", "IKKCO", JdeDataType.String, 10, true, true),
        new JdeField("IKSFX", "IKSFX", JdeDataType.String, 6, true, true),
        new JdeField("IKPTC", "IKPTC", JdeDataType.String, 6),
        new JdeField("IKPYIN", "IKPYIN", JdeDataType.String, 2),
        new JdeField("IKDTAI", "IKDTAI", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI51_0", "Primary Key on IKHDC, IKCKC, IKAN8, IKDCT, IKDOC, IKKCO, IKSFX", new[] { "IKHDC", "IKCKC", "IKAN8", "IKDCT", "IKDOC", "IKKCO", "IKSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
