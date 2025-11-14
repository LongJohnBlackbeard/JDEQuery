using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06925 - .
/// </summary>
public class F06925 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YGUN.
        /// </summary>
        public const string YGUN = "YGUN";

        /// <summary>
        /// YGMCU.
        /// </summary>
        public const string YGMCU = "YGMCU";

        /// <summary>
        /// YGJBCD.
        /// </summary>
        public const string YGJBCD = "YGJBCD";

        /// <summary>
        /// YGJBST.
        /// </summary>
        public const string YGJBST = "YGJBST";

        /// <summary>
        /// YGPDBA.
        /// </summary>
        public const string YGPDBA = "YGPDBA";

        /// <summary>
        /// YGAN8.
        /// </summary>
        public const string YGAN8 = "YGAN8";

        /// <summary>
        /// YGANN8.
        /// </summary>
        public const string YGANN8 = "YGANN8";

        /// <summary>
        /// YGEFTB.
        /// </summary>
        public const string YGEFTB = "YGEFTB";

        /// <summary>
        /// YGEFTE.
        /// </summary>
        public const string YGEFTE = "YGEFTE";
    }

    /// <inheritdoc />
    public override string TableName => "F06925";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YGUN", "YGUN", JdeDataType.String, 12, true, true),
        new JdeField("YGMCU", "YGMCU", JdeDataType.String, 24, true, true),
        new JdeField("YGJBCD", "YGJBCD", JdeDataType.String, 12, true, true),
        new JdeField("YGJBST", "YGJBST", JdeDataType.String, 8, true, true),
        new JdeField("YGPDBA", "YGPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YGAN8", "YGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YGANN8", "YGANN8", JdeDataType.Numeric),
        new JdeField("YGEFTB", "YGEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("YGEFTE", "YGEFTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06925_0", "Primary Key on YGUN, YGMCU, YGJBCD, YGJBST, YGPDBA, YGEFTB, YGAN8", new[] { "YGUN", "YGMCU", "YGJBCD", "YGJBST", "YGPDBA", "YGEFTB", "YGAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
