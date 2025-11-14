using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0742 - .
/// </summary>
public class F76B0742 : JdeTable
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
        /// PDB76RESQ.
        /// </summary>
        public const string PDB76RESQ = "PDB76RESQ";

        /// <summary>
        /// PDMPID.
        /// </summary>
        public const string PDMPID = "PDMPID";

        /// <summary>
        /// PDVERS.
        /// </summary>
        public const string PDVERS = "PDVERS";

        /// <summary>
        /// PDB76REST.
        /// </summary>
        public const string PDB76REST = "PDB76REST";

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
    public override string TableName => "F76B0742";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDJOBS", "PDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PDB76BLCK", "PDB76BLCK", JdeDataType.String, 2, true, true),
        new JdeField("PDB76RESQ", "PDB76RESQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PDMPID", "PDMPID", JdeDataType.String, 20),
        new JdeField("PDVERS", "PDVERS", JdeDataType.String, 20),
        new JdeField("PDB76REST", "PDB76REST", JdeDataType.String, 2),
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
        new JdeIndex("F76B0742_0", "Primary Key on PDJOBS, PDB76BLCK, PDB76RESQ", new[] { "PDJOBS", "PDB76BLCK", "PDB76RESQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B0742_2", "Index on PDJOBS, PDB76BLCK, PDMPID, PDVERS", new[] { "PDJOBS", "PDB76BLCK", "PDMPID", "PDVERS" })
    };
}
