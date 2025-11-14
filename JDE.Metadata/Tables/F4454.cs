using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4454 - .
/// </summary>
public class F4454 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JGMCUS.
        /// </summary>
        public const string JGMCUS = "JGMCUS";

        /// <summary>
        /// JGALOT.
        /// </summary>
        public const string JGALOT = "JGALOT";

        /// <summary>
        /// JGDL01.
        /// </summary>
        public const string JGDL01 = "JGDL01";

        /// <summary>
        /// JGDOCO.
        /// </summary>
        public const string JGDOCO = "JGDOCO";

        /// <summary>
        /// JGDCTO.
        /// </summary>
        public const string JGDCTO = "JGDCTO";

        /// <summary>
        /// JGKCO.
        /// </summary>
        public const string JGKCO = "JGKCO";

        /// <summary>
        /// JGAN8.
        /// </summary>
        public const string JGAN8 = "JGAN8";

        /// <summary>
        /// JGALPH.
        /// </summary>
        public const string JGALPH = "JGALPH";
    }

    /// <inheritdoc />
    public override string TableName => "F4454";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JGMCUS", "JGMCUS", JdeDataType.String, 24, true, true),
        new JdeField("JGALOT", "JGALOT", JdeDataType.String, 8, true, true),
        new JdeField("JGDL01", "JGDL01", JdeDataType.String, 60, true, true),
        new JdeField("JGDOCO", "JGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("JGDCTO", "JGDCTO", JdeDataType.String, 4, true, true),
        new JdeField("JGKCO", "JGKCO", JdeDataType.String, 10, true, true),
        new JdeField("JGAN8", "JGAN8", JdeDataType.Numeric),
        new JdeField("JGALPH", "JGALPH", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4454_0", "Primary Key on JGMCUS, JGALOT, JGDL01, JGDOCO, JGDCTO, JGKCO", new[] { "JGMCUS", "JGALOT", "JGDL01", "JGDOCO", "JGDCTO", "JGKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
