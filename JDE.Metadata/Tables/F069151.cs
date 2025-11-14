using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069151 - .
/// </summary>
public class F069151 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JGDTEY.
        /// </summary>
        public const string JGDTEY = "JGDTEY";

        /// <summary>
        /// JGHLCD.
        /// </summary>
        public const string JGHLCD = "JGHLCD";

        /// <summary>
        /// JGHLDT.
        /// </summary>
        public const string JGHLDT = "JGHLDT";

        /// <summary>
        /// JGPHRW.
        /// </summary>
        public const string JGPHRW = "JGPHRW";

        /// <summary>
        /// JGHLTY.
        /// </summary>
        public const string JGHLTY = "JGHLTY";
    }

    /// <inheritdoc />
    public override string TableName => "F069151";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JGDTEY", "JGDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JGHLCD", "JGHLCD", JdeDataType.String, 6, true, true),
        new JdeField("JGHLDT", "JGHLDT", JdeDataType.Numeric),
        new JdeField("JGPHRW", "JGPHRW", JdeDataType.Numeric),
        new JdeField("JGHLTY", "JGHLTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069151_0", "Primary Key on JGDTEY, JGHLCD", new[] { "JGDTEY", "JGHLCD" }, isUnique: true, isPrimaryKey: true)
    };
}
