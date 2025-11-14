using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7420015 - .
/// </summary>
public class F7420015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SRKCOO.
        /// </summary>
        public const string SRKCOO = "SRKCOO";

        /// <summary>
        /// SRDCTO.
        /// </summary>
        public const string SRDCTO = "SRDCTO";

        /// <summary>
        /// SRDOCO.
        /// </summary>
        public const string SRDOCO = "SRDOCO";

        /// <summary>
        /// SRKCO.
        /// </summary>
        public const string SRKCO = "SRKCO";

        /// <summary>
        /// SRDCT.
        /// </summary>
        public const string SRDCT = "SRDCT";

        /// <summary>
        /// SRDOC.
        /// </summary>
        public const string SRDOC = "SRDOC";
    }

    /// <inheritdoc />
    public override string TableName => "F7420015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SRKCOO", "SRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SRDCTO", "SRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SRDOCO", "SRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SRKCO", "SRKCO", JdeDataType.String, 10, true, true),
        new JdeField("SRDCT", "SRDCT", JdeDataType.String, 4, true, true),
        new JdeField("SRDOC", "SRDOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7420015_0", "Primary Key on SRKCOO, SRDCTO, SRDOCO, SRKCO, SRDCT, SRDOC", new[] { "SRKCOO", "SRDCTO", "SRDOCO", "SRKCO", "SRDCT", "SRDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7420015_2", "Index on SRKCO, SRDCT, SRDOC", new[] { "SRKCO", "SRDCT", "SRDOC" }),
        new JdeIndex("F7420015_3", "Index on SRKCOO, SRDCTO, SRDOCO", new[] { "SRKCOO", "SRDCTO", "SRDOCO" })
    };
}
