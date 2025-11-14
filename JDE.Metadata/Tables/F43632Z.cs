using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43632Z - .
/// </summary>
public class F43632Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OIJOBS.
        /// </summary>
        public const string OIJOBS = "OIJOBS";

        /// <summary>
        /// OITCID.
        /// </summary>
        public const string OITCID = "OITCID";

        /// <summary>
        /// OIPEID.
        /// </summary>
        public const string OIPEID = "OIPEID";

        /// <summary>
        /// OICTID.
        /// </summary>
        public const string OICTID = "OICTID";

        /// <summary>
        /// OIDOCO.
        /// </summary>
        public const string OIDOCO = "OIDOCO";

        /// <summary>
        /// OIDCTO.
        /// </summary>
        public const string OIDCTO = "OIDCTO";

        /// <summary>
        /// OIKCOO.
        /// </summary>
        public const string OIKCOO = "OIKCOO";

        /// <summary>
        /// OISFXO.
        /// </summary>
        public const string OISFXO = "OISFXO";

        /// <summary>
        /// OILNID.
        /// </summary>
        public const string OILNID = "OILNID";

        /// <summary>
        /// OIDLNID.
        /// </summary>
        public const string OIDLNID = "OIDLNID";

        /// <summary>
        /// OIMCU.
        /// </summary>
        public const string OIMCU = "OIMCU";

        /// <summary>
        /// OIITM.
        /// </summary>
        public const string OIITM = "OIITM";

        /// <summary>
        /// OILITM.
        /// </summary>
        public const string OILITM = "OILITM";

        /// <summary>
        /// OIAITM.
        /// </summary>
        public const string OIAITM = "OIAITM";

        /// <summary>
        /// OIAID.
        /// </summary>
        public const string OIAID = "OIAID";

        /// <summary>
        /// OIDSC1.
        /// </summary>
        public const string OIDSC1 = "OIDSC1";

        /// <summary>
        /// OIAN8.
        /// </summary>
        public const string OIAN8 = "OIAN8";

        /// <summary>
        /// OIDRQJ.
        /// </summary>
        public const string OIDRQJ = "OIDRQJ";

        /// <summary>
        /// OIUOM.
        /// </summary>
        public const string OIUOM = "OIUOM";

        /// <summary>
        /// OIUORG.
        /// </summary>
        public const string OIUORG = "OIUORG";

        /// <summary>
        /// OIUOPN.
        /// </summary>
        public const string OIUOPN = "OIUOPN";

        /// <summary>
        /// OIAOPN.
        /// </summary>
        public const string OIAOPN = "OIAOPN";

        /// <summary>
        /// OIFAP.
        /// </summary>
        public const string OIFAP = "OIFAP";

        /// <summary>
        /// OICRCD.
        /// </summary>
        public const string OICRCD = "OICRCD";

        /// <summary>
        /// OILNTY.
        /// </summary>
        public const string OILNTY = "OILNTY";

        /// <summary>
        /// OINXTR.
        /// </summary>
        public const string OINXTR = "OINXTR";

        /// <summary>
        /// OIMACT.
        /// </summary>
        public const string OIMACT = "OIMACT";
    }

    /// <inheritdoc />
    public override string TableName => "F43632Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIJOBS", "OIJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("OITCID", "OITCID", JdeDataType.Numeric, null, true, true),
        new JdeField("OIPEID", "OIPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("OICTID", "OICTID", JdeDataType.String, 30, true, true),
        new JdeField("OIDOCO", "OIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDCTO", "OIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OIKCOO", "OIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OISFXO", "OISFXO", JdeDataType.String, 6, true, true),
        new JdeField("OILNID", "OILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDLNID", "OIDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OIMCU", "OIMCU", JdeDataType.String, 24),
        new JdeField("OIITM", "OIITM", JdeDataType.Numeric),
        new JdeField("OILITM", "OILITM", JdeDataType.String, 50),
        new JdeField("OIAITM", "OIAITM", JdeDataType.String, 50),
        new JdeField("OIAID", "OIAID", JdeDataType.String, 16),
        new JdeField("OIDSC1", "OIDSC1", JdeDataType.String, 60),
        new JdeField("OIAN8", "OIAN8", JdeDataType.Numeric),
        new JdeField("OIDRQJ", "OIDRQJ", JdeDataType.Numeric),
        new JdeField("OIUOM", "OIUOM", JdeDataType.String, 4),
        new JdeField("OIUORG", "OIUORG", JdeDataType.Numeric),
        new JdeField("OIUOPN", "OIUOPN", JdeDataType.Numeric),
        new JdeField("OIAOPN", "OIAOPN", JdeDataType.Numeric),
        new JdeField("OIFAP", "OIFAP", JdeDataType.Numeric),
        new JdeField("OICRCD", "OICRCD", JdeDataType.String, 6),
        new JdeField("OILNTY", "OILNTY", JdeDataType.String, 4),
        new JdeField("OINXTR", "OINXTR", JdeDataType.String, 6),
        new JdeField("OIMACT", "OIMACT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43632Z_0", "Primary Key on OIJOBS, OITCID, OIPEID, OICTID, OIKCOO, OIDOCO, OIDCTO, OISFXO, OILNID, OIDLNID", new[] { "OIJOBS", "OITCID", "OIPEID", "OICTID", "OIKCOO", "OIDOCO", "OIDCTO", "OISFXO", "OILNID", "OIDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
