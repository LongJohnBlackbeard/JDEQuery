using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07811 - .
/// </summary>
public class F07811 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEIDYE.
        /// </summary>
        public const string JEIDYE = "JEIDYE";

        /// <summary>
        /// JEDTEY.
        /// </summary>
        public const string JEDTEY = "JEDTEY";

        /// <summary>
        /// JEAN8.
        /// </summary>
        public const string JEAN8 = "JEAN8";

        /// <summary>
        /// JEALPH.
        /// </summary>
        public const string JEALPH = "JEALPH";

        /// <summary>
        /// JECO.
        /// </summary>
        public const string JECO = "JECO";

        /// <summary>
        /// JETARA.
        /// </summary>
        public const string JETARA = "JETARA";

        /// <summary>
        /// JEPTAX.
        /// </summary>
        public const string JEPTAX = "JEPTAX";

        /// <summary>
        /// JEPDBA.
        /// </summary>
        public const string JEPDBA = "JEPDBA";

        /// <summary>
        /// JEDSCA.
        /// </summary>
        public const string JEDSCA = "JEDSCA";

        /// <summary>
        /// JEDTAI.
        /// </summary>
        public const string JEDTAI = "JEDTAI";

        /// <summary>
        /// JEGPA.
        /// </summary>
        public const string JEGPA = "JEGPA";

        /// <summary>
        /// JESEQ.
        /// </summary>
        public const string JESEQ = "JESEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F07811";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEIDYE", "JEIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JEDTEY", "JEDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JEAN8", "JEAN8", JdeDataType.Numeric),
        new JdeField("JEALPH", "JEALPH", JdeDataType.String, 80),
        new JdeField("JECO", "JECO", JdeDataType.String, 10),
        new JdeField("JETARA", "JETARA", JdeDataType.String, 20),
        new JdeField("JEPTAX", "JEPTAX", JdeDataType.String, 4),
        new JdeField("JEPDBA", "JEPDBA", JdeDataType.Numeric),
        new JdeField("JEDSCA", "JEDSCA", JdeDataType.String, 80),
        new JdeField("JEDTAI", "JEDTAI", JdeDataType.String, 20),
        new JdeField("JEGPA", "JEGPA", JdeDataType.Numeric),
        new JdeField("JESEQ", "JESEQ", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07811_0", "Primary Key on JEIDYE, JEDTEY, JESEQ", new[] { "JEIDYE", "JEDTEY", "JESEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
