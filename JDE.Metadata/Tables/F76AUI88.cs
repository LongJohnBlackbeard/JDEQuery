using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI88 - .
/// </summary>
public class F76AUI88 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LIACAI.
        /// </summary>
        public const string LIACAI = "LIACAI";

        /// <summary>
        /// LIACEM.
        /// </summary>
        public const string LIACEM = "LIACEM";

        /// <summary>
        /// LIADGI.
        /// </summary>
        public const string LIADGI = "LIADGI";

        /// <summary>
        /// LICO.
        /// </summary>
        public const string LICO = "LICO";

        /// <summary>
        /// LIDIM.
        /// </summary>
        public const string LIDIM = "LIDIM";

        /// <summary>
        /// LIAINW.
        /// </summary>
        public const string LIAINW = "LIAINW";

        /// <summary>
        /// LIDIY.
        /// </summary>
        public const string LIDIY = "LIDIY";

        /// <summary>
        /// LIDOCO.
        /// </summary>
        public const string LIDOCO = "LIDOCO";

        /// <summary>
        /// LIKCOO.
        /// </summary>
        public const string LIKCOO = "LIKCOO";

        /// <summary>
        /// LIDCTO.
        /// </summary>
        public const string LIDCTO = "LIDCTO";

        /// <summary>
        /// LIDOC.
        /// </summary>
        public const string LIDOC = "LIDOC";

        /// <summary>
        /// LIDCT.
        /// </summary>
        public const string LIDCT = "LIDCT";

        /// <summary>
        /// LIKCO.
        /// </summary>
        public const string LIKCO = "LIKCO";

        /// <summary>
        /// LIACEM1.
        /// </summary>
        public const string LIACEM1 = "LIACEM1";

        /// <summary>
        /// LIADGI1.
        /// </summary>
        public const string LIADGI1 = "LIADGI1";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI88";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LIACAI", "LIACAI", JdeDataType.String, 28, true, true),
        new JdeField("LIACEM", "LIACEM", JdeDataType.String, 8, true, true),
        new JdeField("LIADGI", "LIADGI", JdeDataType.String, 4, true, true),
        new JdeField("LICO", "LICO", JdeDataType.String, 10, true, true),
        new JdeField("LIDIM", "LIDIM", JdeDataType.Numeric, null, true, true),
        new JdeField("LIAINW", "LIAINW", JdeDataType.String, 16),
        new JdeField("LIDIY", "LIDIY", JdeDataType.Numeric, null, true, true),
        new JdeField("LIDOCO", "LIDOCO", JdeDataType.Numeric),
        new JdeField("LIKCOO", "LIKCOO", JdeDataType.String, 10),
        new JdeField("LIDCTO", "LIDCTO", JdeDataType.String, 4),
        new JdeField("LIDOC", "LIDOC", JdeDataType.Numeric),
        new JdeField("LIDCT", "LIDCT", JdeDataType.String, 4),
        new JdeField("LIKCO", "LIKCO", JdeDataType.String, 10),
        new JdeField("LIACEM1", "LIACEM1", JdeDataType.String, 30, true, true),
        new JdeField("LIADGI1", "LIADGI1", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI88_0", "Primary Key on LICO, LIDIM, LIDIY, LIACAI, LIACEM1, LIADGI1, LIACEM, LIADGI", new[] { "LICO", "LIDIM", "LIDIY", "LIACAI", "LIACEM1", "LIADGI1", "LIACEM", "LIADGI" }, isUnique: true, isPrimaryKey: true)
    };
}
