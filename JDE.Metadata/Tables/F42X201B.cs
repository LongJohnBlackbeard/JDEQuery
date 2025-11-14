using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42X201B - .
/// </summary>
public class F42X201B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PG42XPSIM.
        /// </summary>
        public const string PG42XPSIM = "PG42XPSIM";

        /// <summary>
        /// PG42XSCEN.
        /// </summary>
        public const string PG42XSCEN = "PG42XSCEN";

        /// <summary>
        /// PG42XREV.
        /// </summary>
        public const string PG42XREV = "PG42XREV";

        /// <summary>
        /// PG42XCHART.
        /// </summary>
        public const string PG42XCHART = "PG42XCHART";

        /// <summary>
        /// PG42XCDATA.
        /// </summary>
        public const string PG42XCDATA = "PG42XCDATA";

        /// <summary>
        /// PG42XAMAX.
        /// </summary>
        public const string PG42XAMAX = "PG42XAMAX";

        /// <summary>
        /// PG42XAMIN.
        /// </summary>
        public const string PG42XAMIN = "PG42XAMIN";
    }

    /// <inheritdoc />
    public override string TableName => "F42X201B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PG42XPSIM", "PG42XPSIM", JdeDataType.String, 80, true, true),
        new JdeField("PG42XSCEN", "PG42XSCEN", JdeDataType.Numeric, null, true, true),
        new JdeField("PG42XREV", "PG42XREV", JdeDataType.Numeric, null, true, true),
        new JdeField("PG42XCHART", "PG42XCHART", JdeDataType.Numeric, null, true, true),
        new JdeField("PG42XCDATA", "PG42XCDATA", JdeDataType.String),
        new JdeField("PG42XAMAX", "PG42XAMAX", JdeDataType.Numeric),
        new JdeField("PG42XAMIN", "PG42XAMIN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42X201B_0", "Primary Key on PG42XPSIM, PG42XSCEN, PG42XREV, PG42XCHART", new[] { "PG42XPSIM", "PG42XSCEN", "PG42XREV", "PG42XCHART" }, isUnique: true, isPrimaryKey: true)
    };
}
