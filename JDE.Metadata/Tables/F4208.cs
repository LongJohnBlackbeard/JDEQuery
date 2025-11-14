using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4208 - .
/// </summary>
public class F4208 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PGCPGP.
        /// </summary>
        public const string PGCPGP = "PGCPGP";

        /// <summary>
        /// PGDESC.
        /// </summary>
        public const string PGDESC = "PGDESC";

        /// <summary>
        /// PGMCAT.
        /// </summary>
        public const string PGMCAT = "PGMCAT";

        /// <summary>
        /// PGCLV.
        /// </summary>
        public const string PGCLV = "PGCLV";

        /// <summary>
        /// PGTYDS.
        /// </summary>
        public const string PGTYDS = "PGTYDS";

        /// <summary>
        /// PGCXPJ.
        /// </summary>
        public const string PGCXPJ = "PGCXPJ";

        /// <summary>
        /// PGCEFJ.
        /// </summary>
        public const string PGCEFJ = "PGCEFJ";

        /// <summary>
        /// PGUPMJ.
        /// </summary>
        public const string PGUPMJ = "PGUPMJ";

        /// <summary>
        /// PGTDAY.
        /// </summary>
        public const string PGTDAY = "PGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4208";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PGCPGP", "PGCPGP", JdeDataType.String, 16, true, true),
        new JdeField("PGDESC", "PGDESC", JdeDataType.String, 60),
        new JdeField("PGMCAT", "PGMCAT", JdeDataType.String, 16, true, true),
        new JdeField("PGCLV", "PGCLV", JdeDataType.String, 6, true, true),
        new JdeField("PGTYDS", "PGTYDS", JdeDataType.String, 2),
        new JdeField("PGCXPJ", "PGCXPJ", JdeDataType.Numeric),
        new JdeField("PGCEFJ", "PGCEFJ", JdeDataType.Numeric),
        new JdeField("PGUPMJ", "PGUPMJ", JdeDataType.Numeric),
        new JdeField("PGTDAY", "PGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4208_0", "Primary Key on PGCPGP, PGMCAT, PGCLV", new[] { "PGCPGP", "PGMCAT", "PGCLV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4208_2", "Index on PGMCAT, PGCLV", new[] { "PGMCAT", "PGCLV" })
    };
}
