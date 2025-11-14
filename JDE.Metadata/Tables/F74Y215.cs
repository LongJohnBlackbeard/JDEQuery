using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y215 - .
/// </summary>
public class F74Y215 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROKCOO.
        /// </summary>
        public const string ROKCOO = "ROKCOO";

        /// <summary>
        /// RODCTO.
        /// </summary>
        public const string RODCTO = "RODCTO";

        /// <summary>
        /// RODOCO.
        /// </summary>
        public const string RODOCO = "RODOCO";

        /// <summary>
        /// ROKCO.
        /// </summary>
        public const string ROKCO = "ROKCO";

        /// <summary>
        /// RODCT.
        /// </summary>
        public const string RODCT = "RODCT";

        /// <summary>
        /// RODOC.
        /// </summary>
        public const string RODOC = "RODOC";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y215";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROKCOO", "ROKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RODCTO", "RODCTO", JdeDataType.String, 4, true, true),
        new JdeField("RODOCO", "RODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ROKCO", "ROKCO", JdeDataType.String, 10, true, true),
        new JdeField("RODCT", "RODCT", JdeDataType.String, 4, true, true),
        new JdeField("RODOC", "RODOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y215_0", "Primary Key on ROKCOO, RODCTO, RODOCO, ROKCO, RODCT, RODOC", new[] { "ROKCOO", "RODCTO", "RODOCO", "ROKCO", "RODCT", "RODOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74Y215_2", "Index on ROKCO, RODCT, RODOC", new[] { "ROKCO", "RODCT", "RODOC" })
    };
}
