using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C311T - .
/// </summary>
public class F76C311T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPCTID.
        /// </summary>
        public const string RPCTID = "RPCTID";

        /// <summary>
        /// RPJOBS.
        /// </summary>
        public const string RPJOBS = "RPJOBS";
    }

    /// <inheritdoc />
    public override string TableName => "F76C311T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPCTID", "RPCTID", JdeDataType.String, 30),
        new JdeField("RPJOBS", "RPJOBS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C311T_0", "Primary Key on RPDOC, RPDCT, RPKCO, RPSFX", new[] { "RPDOC", "RPDCT", "RPKCO", "RPSFX" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76C311T_25", "Index on RPCTID, RPJOBS", new[] { "RPCTID", "RPJOBS" })
    };
}
