using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I035 - .
/// </summary>
public class F75I035 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DGKCO.
        /// </summary>
        public const string DGKCO = "DGKCO";

        /// <summary>
        /// DGDCT.
        /// </summary>
        public const string DGDCT = "DGDCT";

        /// <summary>
        /// DGDOC.
        /// </summary>
        public const string DGDOC = "DGDOC";

        /// <summary>
        /// DGSEQ.
        /// </summary>
        public const string DGSEQ = "DGSEQ";

        /// <summary>
        /// DGLNID.
        /// </summary>
        public const string DGLNID = "DGLNID";

        /// <summary>
        /// DGCRCD.
        /// </summary>
        public const string DGCRCD = "DGCRCD";

        /// <summary>
        /// DGRAMT.
        /// </summary>
        public const string DGRAMT = "DGRAMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I035";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DGKCO", "DGKCO", JdeDataType.String, 10, true, true),
        new JdeField("DGDCT", "DGDCT", JdeDataType.String, 4, true, true),
        new JdeField("DGDOC", "DGDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DGSEQ", "DGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DGLNID", "DGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DGCRCD", "DGCRCD", JdeDataType.String, 6),
        new JdeField("DGRAMT", "DGRAMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I035_0", "Primary Key on DGKCO, DGDCT, DGDOC, DGSEQ, DGLNID", new[] { "DGKCO", "DGDCT", "DGDOC", "DGSEQ", "DGLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
