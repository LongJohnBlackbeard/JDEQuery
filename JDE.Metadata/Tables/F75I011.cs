using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I011 - .
/// </summary>
public class F75I011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDYRM.
        /// </summary>
        public const string PDYRM = "PDYRM";

        /// <summary>
        /// PDI75ITTY.
        /// </summary>
        public const string PDI75ITTY = "PDI75ITTY";

        /// <summary>
        /// PDI75DES1.
        /// </summary>
        public const string PDI75DES1 = "PDI75DES1";

        /// <summary>
        /// PDI75TTYP.
        /// </summary>
        public const string PDI75TTYP = "PDI75TTYP";

        /// <summary>
        /// PDI75DES2.
        /// </summary>
        public const string PDI75DES2 = "PDI75DES2";

        /// <summary>
        /// PDI75TXTY.
        /// </summary>
        public const string PDI75TXTY = "PDI75TXTY";

        /// <summary>
        /// PDI75DES3.
        /// </summary>
        public const string PDI75DES3 = "PDI75DES3";

        /// <summary>
        /// PDI75PERC.
        /// </summary>
        public const string PDI75PERC = "PDI75PERC";

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
    public override string TableName => "F75I011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDYRM", "PDYRM", JdeDataType.Numeric, null, true, true),
        new JdeField("PDI75ITTY", "PDI75ITTY", JdeDataType.String, 12, true, true),
        new JdeField("PDI75DES1", "PDI75DES1", JdeDataType.String, 60),
        new JdeField("PDI75TTYP", "PDI75TTYP", JdeDataType.String, 10, true, true),
        new JdeField("PDI75DES2", "PDI75DES2", JdeDataType.String, 60),
        new JdeField("PDI75TXTY", "PDI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("PDI75DES3", "PDI75DES3", JdeDataType.String, 60),
        new JdeField("PDI75PERC", "PDI75PERC", JdeDataType.Numeric),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I011_0", "Primary Key on PDYRM, PDI75ITTY, PDI75TXTY, PDI75TTYP", new[] { "PDYRM", "PDI75ITTY", "PDI75TXTY", "PDI75TTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
