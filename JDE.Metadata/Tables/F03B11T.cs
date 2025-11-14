using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B11T - .
/// </summary>
public class F03B11T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKDOC.
        /// </summary>
        public const string TKDOC = "TKDOC";

        /// <summary>
        /// TKDCT.
        /// </summary>
        public const string TKDCT = "TKDCT";

        /// <summary>
        /// TKKCO.
        /// </summary>
        public const string TKKCO = "TKKCO";

        /// <summary>
        /// TKSFX.
        /// </summary>
        public const string TKSFX = "TKSFX";

        /// <summary>
        /// TKRRF.
        /// </summary>
        public const string TKRRF = "TKRRF";

        /// <summary>
        /// TKCHT1.
        /// </summary>
        public const string TKCHT1 = "TKCHT1";

        /// <summary>
        /// TKSTRT1.
        /// </summary>
        public const string TKSTRT1 = "TKSTRT1";

        /// <summary>
        /// TKDJT1.
        /// </summary>
        public const string TKDJT1 = "TKDJT1";

        /// <summary>
        /// TKAAMT1.
        /// </summary>
        public const string TKAAMT1 = "TKAAMT1";
    }

    /// <inheritdoc />
    public override string TableName => "F03B11T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKDOC", "TKDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TKDCT", "TKDCT", JdeDataType.String, 4, true, true),
        new JdeField("TKKCO", "TKKCO", JdeDataType.String, 10, true, true),
        new JdeField("TKSFX", "TKSFX", JdeDataType.String, 6, true, true),
        new JdeField("TKRRF", "TKRRF", JdeDataType.String, 2),
        new JdeField("TKCHT1", "TKCHT1", JdeDataType.String, 2),
        new JdeField("TKSTRT1", "TKSTRT1", JdeDataType.String, 60),
        new JdeField("TKDJT1", "TKDJT1", JdeDataType.Numeric),
        new JdeField("TKAAMT1", "TKAAMT1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B11T_0", "Primary Key on TKDCT, TKDOC, TKKCO, TKSFX", new[] { "TKDCT", "TKDOC", "TKKCO", "TKSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
