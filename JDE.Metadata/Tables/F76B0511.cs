using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0511 - .
/// </summary>
public class F76B0511 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDJOBS.
        /// </summary>
        public const string PDJOBS = "PDJOBS";

        /// <summary>
        /// PDB76BLCK.
        /// </summary>
        public const string PDB76BLCK = "PDB76BLCK";

        /// <summary>
        /// PDB76SBPR.
        /// </summary>
        public const string PDB76SBPR = "PDB76SBPR";

        /// <summary>
        /// PDB76RECD.
        /// </summary>
        public const string PDB76RECD = "PDB76RECD";

        /// <summary>
        /// PDB76BSEQ.
        /// </summary>
        public const string PDB76BSEQ = "PDB76BSEQ";

        /// <summary>
        /// PDUSEQ.
        /// </summary>
        public const string PDUSEQ = "PDUSEQ";

        /// <summary>
        /// PDGPTX.
        /// </summary>
        public const string PDGPTX = "PDGPTX";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0511";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDJOBS", "PDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PDB76BLCK", "PDB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("PDB76SBPR", "PDB76SBPR", JdeDataType.Numeric, null, true, true),
        new JdeField("PDB76RECD", "PDB76RECD", JdeDataType.String, 8, true, true),
        new JdeField("PDB76BSEQ", "PDB76BSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PDUSEQ", "PDUSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PDGPTX", "PDGPTX", JdeDataType.String, 3000),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0511_0", "Primary Key on PDJOBS, PDB76BLCK, PDB76SBPR, PDB76BSEQ, PDB76RECD, PDUSEQ", new[] { "PDJOBS", "PDB76BLCK", "PDB76SBPR", "PDB76BSEQ", "PDB76RECD", "PDUSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
