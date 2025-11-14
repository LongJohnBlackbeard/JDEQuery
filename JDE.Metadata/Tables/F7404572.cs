using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7404572 - .
/// </summary>
public class F7404572 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KLHDC.
        /// </summary>
        public const string KLHDC = "KLHDC";

        /// <summary>
        /// KLCKC.
        /// </summary>
        public const string KLCKC = "KLCKC";

        /// <summary>
        /// KLZT16.
        /// </summary>
        public const string KLZT16 = "KLZT16";

        /// <summary>
        /// KLZT17.
        /// </summary>
        public const string KLZT17 = "KLZT17";

        /// <summary>
        /// KLZT18.
        /// </summary>
        public const string KLZT18 = "KLZT18";

        /// <summary>
        /// KLZT19.
        /// </summary>
        public const string KLZT19 = "KLZT19";

        /// <summary>
        /// KLZT21.
        /// </summary>
        public const string KLZT21 = "KLZT21";

        /// <summary>
        /// KLZT22.
        /// </summary>
        public const string KLZT22 = "KLZT22";

        /// <summary>
        /// KLZW03.
        /// </summary>
        public const string KLZW03 = "KLZW03";

        /// <summary>
        /// KLZW04.
        /// </summary>
        public const string KLZW04 = "KLZW04";

        /// <summary>
        /// KLZAIC.
        /// </summary>
        public const string KLZAIC = "KLZAIC";

        /// <summary>
        /// KLZIPB.
        /// </summary>
        public const string KLZIPB = "KLZIPB";

        /// <summary>
        /// KLZCNT.
        /// </summary>
        public const string KLZCNT = "KLZCNT";

        /// <summary>
        /// KLZRC.
        /// </summary>
        public const string KLZRC = "KLZRC";
    }

    /// <inheritdoc />
    public override string TableName => "F7404572";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KLHDC", "KLHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("KLCKC", "KLCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("KLZT16", "KLZT16", JdeDataType.Numeric),
        new JdeField("KLZT17", "KLZT17", JdeDataType.Numeric),
        new JdeField("KLZT18", "KLZT18", JdeDataType.Numeric),
        new JdeField("KLZT19", "KLZT19", JdeDataType.Numeric),
        new JdeField("KLZT21", "KLZT21", JdeDataType.Numeric),
        new JdeField("KLZT22", "KLZT22", JdeDataType.Numeric),
        new JdeField("KLZW03", "KLZW03", JdeDataType.Numeric),
        new JdeField("KLZW04", "KLZW04", JdeDataType.Numeric),
        new JdeField("KLZAIC", "KLZAIC", JdeDataType.String, 50),
        new JdeField("KLZIPB", "KLZIPB", JdeDataType.String, 54),
        new JdeField("KLZCNT", "KLZCNT", JdeDataType.String, 70),
        new JdeField("KLZRC", "KLZRC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7404572_0", "Primary Key on KLHDC, KLCKC", new[] { "KLHDC", "KLCKC" }, isUnique: true, isPrimaryKey: true)
    };
}
