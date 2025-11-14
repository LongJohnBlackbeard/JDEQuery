using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P3B24 - .
/// </summary>
public class F74P3B24 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDDOC.
        /// </summary>
        public const string PDDOC = "PDDOC";

        /// <summary>
        /// PDDCT.
        /// </summary>
        public const string PDDCT = "PDDCT";

        /// <summary>
        /// PDKCO.
        /// </summary>
        public const string PDKCO = "PDKCO";

        /// <summary>
        /// PDSFX.
        /// </summary>
        public const string PDSFX = "PDSFX";

        /// <summary>
        /// PDSEQ.
        /// </summary>
        public const string PDSEQ = "PDSEQ";

        /// <summary>
        /// PDLFCJ.
        /// </summary>
        public const string PDLFCJ = "PDLFCJ";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

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
    public override string TableName => "F74P3B24";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDDOC", "PDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDCT", "PDDCT", JdeDataType.String, 4, true, true),
        new JdeField("PDKCO", "PDKCO", JdeDataType.String, 10, true, true),
        new JdeField("PDSFX", "PDSFX", JdeDataType.String, 6, true, true),
        new JdeField("PDSEQ", "PDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PDLFCJ", "PDLFCJ", JdeDataType.Numeric),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P3B24_0", "Primary Key on PDDOC, PDDCT, PDKCO, PDSFX, PDSEQ", new[] { "PDDOC", "PDDCT", "PDKCO", "PDSFX", "PDSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74P3B24_2", "Index on PDDOC, PDDCT, PDKCO, PDSFX, SYS_NC00012$", new[] { "PDDOC", "PDDCT", "PDKCO", "PDSFX", "SYS_NC00012$" })
    };
}
