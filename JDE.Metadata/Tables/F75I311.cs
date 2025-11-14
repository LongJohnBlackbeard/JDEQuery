using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I311 - .
/// </summary>
public class F75I311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EBYEXU.
        /// </summary>
        public const string EBYEXU = "EBYEXU";

        /// <summary>
        /// EBYRM.
        /// </summary>
        public const string EBYRM = "EBYRM";

        /// <summary>
        /// EBMNTH.
        /// </summary>
        public const string EBMNTH = "EBMNTH";

        /// <summary>
        /// EBI75TXRG.
        /// </summary>
        public const string EBI75TXRG = "EBI75TXRG";

        /// <summary>
        /// EBI75TXTY.
        /// </summary>
        public const string EBI75TXTY = "EBI75TXTY";

        /// <summary>
        /// EBI75ITTY.
        /// </summary>
        public const string EBI75ITTY = "EBI75ITTY";

        /// <summary>
        /// EBI75OPBL.
        /// </summary>
        public const string EBI75OPBL = "EBI75OPBL";

        /// <summary>
        /// EBI75CLBL.
        /// </summary>
        public const string EBI75CLBL = "EBI75CLBL";

        /// <summary>
        /// EBI75CRAT.
        /// </summary>
        public const string EBI75CRAT = "EBI75CRAT";

        /// <summary>
        /// EBI75DRAT.
        /// </summary>
        public const string EBI75DRAT = "EBI75DRAT";

        /// <summary>
        /// EBUSER.
        /// </summary>
        public const string EBUSER = "EBUSER";

        /// <summary>
        /// EBPID.
        /// </summary>
        public const string EBPID = "EBPID";

        /// <summary>
        /// EBUPMJ.
        /// </summary>
        public const string EBUPMJ = "EBUPMJ";

        /// <summary>
        /// EBUPMT.
        /// </summary>
        public const string EBUPMT = "EBUPMT";

        /// <summary>
        /// EBJOBN.
        /// </summary>
        public const string EBJOBN = "EBJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75I311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EBYEXU", "EBYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("EBYRM", "EBYRM", JdeDataType.Numeric, null, true, true),
        new JdeField("EBMNTH", "EBMNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("EBI75TXRG", "EBI75TXRG", JdeDataType.String, 10, true, true),
        new JdeField("EBI75TXTY", "EBI75TXTY", JdeDataType.String, 10, true, true),
        new JdeField("EBI75ITTY", "EBI75ITTY", JdeDataType.String, 12, true, true),
        new JdeField("EBI75OPBL", "EBI75OPBL", JdeDataType.Numeric),
        new JdeField("EBI75CLBL", "EBI75CLBL", JdeDataType.Numeric),
        new JdeField("EBI75CRAT", "EBI75CRAT", JdeDataType.Numeric),
        new JdeField("EBI75DRAT", "EBI75DRAT", JdeDataType.Numeric),
        new JdeField("EBUSER", "EBUSER", JdeDataType.String, 20),
        new JdeField("EBPID", "EBPID", JdeDataType.String, 20),
        new JdeField("EBUPMJ", "EBUPMJ", JdeDataType.Numeric),
        new JdeField("EBUPMT", "EBUPMT", JdeDataType.Numeric),
        new JdeField("EBJOBN", "EBJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I311_0", "Primary Key on EBYEXU, EBYRM, EBMNTH, EBI75TXRG, EBI75TXTY, EBI75ITTY", new[] { "EBYEXU", "EBYRM", "EBMNTH", "EBI75TXRG", "EBI75TXTY", "EBI75ITTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I311_2", "Index on EBYEXU, EBYRM, EBMNTH", new[] { "EBYEXU", "EBYRM", "EBMNTH" })
    };
}
