using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7404573 - .
/// </summary>
public class F7404573 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KIHDC.
        /// </summary>
        public const string KIHDC = "KIHDC";

        /// <summary>
        /// KICKC.
        /// </summary>
        public const string KICKC = "KICKC";

        /// <summary>
        /// KIRC.
        /// </summary>
        public const string KIRC = "KIRC";

        /// <summary>
        /// KIKCO.
        /// </summary>
        public const string KIKCO = "KIKCO";

        /// <summary>
        /// KIDOC.
        /// </summary>
        public const string KIDOC = "KIDOC";

        /// <summary>
        /// KIDCT.
        /// </summary>
        public const string KIDCT = "KIDCT";

        /// <summary>
        /// KISFX.
        /// </summary>
        public const string KISFX = "KISFX";

        /// <summary>
        /// KISFXE.
        /// </summary>
        public const string KISFXE = "KISFXE";

        /// <summary>
        /// KIZT16.
        /// </summary>
        public const string KIZT16 = "KIZT16";

        /// <summary>
        /// KIZT17.
        /// </summary>
        public const string KIZT17 = "KIZT17";

        /// <summary>
        /// KIZT18.
        /// </summary>
        public const string KIZT18 = "KIZT18";

        /// <summary>
        /// KIZT19.
        /// </summary>
        public const string KIZT19 = "KIZT19";

        /// <summary>
        /// KIZT21.
        /// </summary>
        public const string KIZT21 = "KIZT21";

        /// <summary>
        /// KIZT22.
        /// </summary>
        public const string KIZT22 = "KIZT22";

        /// <summary>
        /// KIZW03.
        /// </summary>
        public const string KIZW03 = "KIZW03";

        /// <summary>
        /// KIZW04.
        /// </summary>
        public const string KIZW04 = "KIZW04";

        /// <summary>
        /// KIZAIC.
        /// </summary>
        public const string KIZAIC = "KIZAIC";

        /// <summary>
        /// KIZIPB.
        /// </summary>
        public const string KIZIPB = "KIZIPB";

        /// <summary>
        /// KIZCNT.
        /// </summary>
        public const string KIZCNT = "KIZCNT";

        /// <summary>
        /// KIZRC.
        /// </summary>
        public const string KIZRC = "KIZRC";
    }

    /// <inheritdoc />
    public override string TableName => "F7404573";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KIHDC", "KIHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("KICKC", "KICKC", JdeDataType.Numeric, null, true, true),
        new JdeField("KIRC", "KIRC", JdeDataType.String, 2, true, true),
        new JdeField("KIKCO", "KIKCO", JdeDataType.String, 10, true, true),
        new JdeField("KIDOC", "KIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("KIDCT", "KIDCT", JdeDataType.String, 4, true, true),
        new JdeField("KISFX", "KISFX", JdeDataType.String, 6, true, true),
        new JdeField("KISFXE", "KISFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("KIZT16", "KIZT16", JdeDataType.Numeric),
        new JdeField("KIZT17", "KIZT17", JdeDataType.Numeric),
        new JdeField("KIZT18", "KIZT18", JdeDataType.Numeric),
        new JdeField("KIZT19", "KIZT19", JdeDataType.Numeric),
        new JdeField("KIZT21", "KIZT21", JdeDataType.Numeric),
        new JdeField("KIZT22", "KIZT22", JdeDataType.Numeric),
        new JdeField("KIZW03", "KIZW03", JdeDataType.Numeric),
        new JdeField("KIZW04", "KIZW04", JdeDataType.Numeric),
        new JdeField("KIZAIC", "KIZAIC", JdeDataType.String, 50),
        new JdeField("KIZIPB", "KIZIPB", JdeDataType.String, 54),
        new JdeField("KIZCNT", "KIZCNT", JdeDataType.String, 70),
        new JdeField("KIZRC", "KIZRC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7404573_0", "Primary Key on KIHDC, KICKC, KIRC, KIKCO, KIDOC, KIDCT, KISFX, KISFXE", new[] { "KIHDC", "KICKC", "KIRC", "KIKCO", "KIDOC", "KIDCT", "KISFX", "KISFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
