using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW12 - .
/// </summary>
public class FCW12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCITM.
        /// </summary>
        public const string WCITM = "WCITM";

        /// <summary>
        /// WCEV01.
        /// </summary>
        public const string WCEV01 = "WCEV01";

        /// <summary>
        /// WCMCU.
        /// </summary>
        public const string WCMCU = "WCMCU";

        /// <summary>
        /// WCLOCN.
        /// </summary>
        public const string WCLOCN = "WCLOCN";

        /// <summary>
        /// WCLOTN.
        /// </summary>
        public const string WCLOTN = "WCLOTN";

        /// <summary>
        /// WCLEDG.
        /// </summary>
        public const string WCLEDG = "WCLEDG";

        /// <summary>
        /// WCLOTG.
        /// </summary>
        public const string WCLOTG = "WCLOTG";

        /// <summary>
        /// WCUNCS.
        /// </summary>
        public const string WCUNCS = "WCUNCS";

        /// <summary>
        /// WCCSPO.
        /// </summary>
        public const string WCCSPO = "WCCSPO";

        /// <summary>
        /// WCCSIN.
        /// </summary>
        public const string WCCSIN = "WCCSIN";

        /// <summary>
        /// WCURCD.
        /// </summary>
        public const string WCURCD = "WCURCD";

        /// <summary>
        /// WCURDT.
        /// </summary>
        public const string WCURDT = "WCURDT";

        /// <summary>
        /// WCURAT.
        /// </summary>
        public const string WCURAT = "WCURAT";

        /// <summary>
        /// WCURAB.
        /// </summary>
        public const string WCURAB = "WCURAB";

        /// <summary>
        /// WCURRF.
        /// </summary>
        public const string WCURRF = "WCURRF";

        /// <summary>
        /// WCCCFL.
        /// </summary>
        public const string WCCCFL = "WCCCFL";

        /// <summary>
        /// WCCRCS.
        /// </summary>
        public const string WCCRCS = "WCCRCS";

        /// <summary>
        /// WCOSTC.
        /// </summary>
        public const string WCOSTC = "WCOSTC";

        /// <summary>
        /// WCSTOC.
        /// </summary>
        public const string WCSTOC = "WCSTOC";
    }

    /// <inheritdoc />
    public override string TableName => "FCW12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCITM", "WCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WCEV01", "WCEV01", JdeDataType.String, 2, true, true),
        new JdeField("WCMCU", "WCMCU", JdeDataType.String, 24, true, true),
        new JdeField("WCLOCN", "WCLOCN", JdeDataType.String, 40, true, true),
        new JdeField("WCLOTN", "WCLOTN", JdeDataType.String, 60, true, true),
        new JdeField("WCLEDG", "WCLEDG", JdeDataType.String, 4, true, true),
        new JdeField("WCLOTG", "WCLOTG", JdeDataType.String, 6),
        new JdeField("WCUNCS", "WCUNCS", JdeDataType.Numeric),
        new JdeField("WCCSPO", "WCCSPO", JdeDataType.String, 2),
        new JdeField("WCCSIN", "WCCSIN", JdeDataType.String, 2),
        new JdeField("WCURCD", "WCURCD", JdeDataType.String, 4),
        new JdeField("WCURDT", "WCURDT", JdeDataType.Numeric),
        new JdeField("WCURAT", "WCURAT", JdeDataType.Numeric),
        new JdeField("WCURAB", "WCURAB", JdeDataType.Numeric),
        new JdeField("WCURRF", "WCURRF", JdeDataType.String, 30),
        new JdeField("WCCCFL", "WCCCFL", JdeDataType.String, 2),
        new JdeField("WCCRCS", "WCCRCS", JdeDataType.Numeric),
        new JdeField("WCOSTC", "WCOSTC", JdeDataType.Numeric),
        new JdeField("WCSTOC", "WCSTOC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW12_0", "Primary Key on WCITM, WCEV01, WCMCU, WCLOCN, WCLOTN, WCLEDG", new[] { "WCITM", "WCEV01", "WCMCU", "WCLOCN", "WCLOTN", "WCLEDG" }, isUnique: true, isPrimaryKey: true)
    };
}
