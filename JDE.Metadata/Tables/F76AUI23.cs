using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI23 - .
/// </summary>
public class F76AUI23 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TWJOBS.
        /// </summary>
        public const string TWJOBS = "TWJOBS";

        /// <summary>
        /// TWCTID.
        /// </summary>
        public const string TWCTID = "TWCTID";

        /// <summary>
        /// TWKCO.
        /// </summary>
        public const string TWKCO = "TWKCO";

        /// <summary>
        /// TWDCT.
        /// </summary>
        public const string TWDCT = "TWDCT";

        /// <summary>
        /// TWDOC.
        /// </summary>
        public const string TWDOC = "TWDOC";

        /// <summary>
        /// TWATXC.
        /// </summary>
        public const string TWATXC = "TWATXC";

        /// <summary>
        /// TWOTOT.
        /// </summary>
        public const string TWOTOT = "TWOTOT";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI23";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TWJOBS", "TWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TWCTID", "TWCTID", JdeDataType.String, 30, true, true),
        new JdeField("TWKCO", "TWKCO", JdeDataType.String, 10, true, true),
        new JdeField("TWDCT", "TWDCT", JdeDataType.String, 4, true, true),
        new JdeField("TWDOC", "TWDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TWATXC", "TWATXC", JdeDataType.String, 20, true, true),
        new JdeField("TWOTOT", "TWOTOT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI23_0", "Primary Key on TWJOBS, TWCTID, TWKCO, TWDCT, TWDOC, TWATXC", new[] { "TWJOBS", "TWCTID", "TWKCO", "TWDCT", "TWDOC", "TWATXC" }, isUnique: true, isPrimaryKey: true)
    };
}
