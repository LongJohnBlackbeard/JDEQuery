using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I013 - .
/// </summary>
public class F75I013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDTCID.
        /// </summary>
        public const string PDTCID = "PDTCID";

        /// <summary>
        /// PDYRM.
        /// </summary>
        public const string PDYRM = "PDYRM";

        /// <summary>
        /// PDMT.
        /// </summary>
        public const string PDMT = "PDMT";

        /// <summary>
        /// PDI75ITTY.
        /// </summary>
        public const string PDI75ITTY = "PDI75ITTY";

        /// <summary>
        /// PDI75TTYP.
        /// </summary>
        public const string PDI75TTYP = "PDI75TTYP";

        /// <summary>
        /// PDI75SRCT.
        /// </summary>
        public const string PDI75SRCT = "PDI75SRCT";

        /// <summary>
        /// PDYEXU.
        /// </summary>
        public const string PDYEXU = "PDYEXU";

        /// <summary>
        /// PDI75TXTY.
        /// </summary>
        public const string PDI75TXTY = "PDI75TXTY";

        /// <summary>
        /// PDI75YEXU.
        /// </summary>
        public const string PDI75YEXU = "PDI75YEXU";

        /// <summary>
        /// PDI75CAMU.
        /// </summary>
        public const string PDI75CAMU = "PDI75CAMU";

        /// <summary>
        /// PDDOCO.
        /// </summary>
        public const string PDDOCO = "PDDOCO";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDTDAY.
        /// </summary>
        public const string PDTDAY = "PDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDTCID", "PDTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDYRM", "PDYRM", JdeDataType.Numeric),
        new JdeField("PDMT", "PDMT", JdeDataType.Numeric),
        new JdeField("PDI75ITTY", "PDI75ITTY", JdeDataType.String, 12, true, true),
        new JdeField("PDI75TTYP", "PDI75TTYP", JdeDataType.String, 10, true, true),
        new JdeField("PDI75SRCT", "PDI75SRCT", JdeDataType.String, 12),
        new JdeField("PDYEXU", "PDYEXU", JdeDataType.Numeric),
        new JdeField("PDI75TXTY", "PDI75TXTY", JdeDataType.String, 10),
        new JdeField("PDI75YEXU", "PDI75YEXU", JdeDataType.Numeric),
        new JdeField("PDI75CAMU", "PDI75CAMU", JdeDataType.Numeric),
        new JdeField("PDDOCO", "PDDOCO", JdeDataType.Numeric),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I013_0", "Primary Key on PDTCID, PDI75ITTY, PDI75TTYP", new[] { "PDTCID", "PDI75ITTY", "PDI75TTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
