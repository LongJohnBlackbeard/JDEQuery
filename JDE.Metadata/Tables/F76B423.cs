using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B423 - .
/// </summary>
public class F76B423 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCDOCO.
        /// </summary>
        public const string WCDOCO = "WCDOCO";

        /// <summary>
        /// WCKCOO.
        /// </summary>
        public const string WCKCOO = "WCKCOO";

        /// <summary>
        /// WCDCTO.
        /// </summary>
        public const string WCDCTO = "WCDCTO";

        /// <summary>
        /// WCLNID.
        /// </summary>
        public const string WCLNID = "WCLNID";

        /// <summary>
        /// WCB76ISSS.
        /// </summary>
        public const string WCB76ISSS = "WCB76ISSS";

        /// <summary>
        /// WCB76CTYC.
        /// </summary>
        public const string WCB76CTYC = "WCB76CTYC";

        /// <summary>
        /// WCB76SVTC.
        /// </summary>
        public const string WCB76SVTC = "WCB76SVTC";

        /// <summary>
        /// WCB76IRS.
        /// </summary>
        public const string WCB76IRS = "WCB76IRS";

        /// <summary>
        /// WCB76IRPJWC.
        /// </summary>
        public const string WCB76IRPJWC = "WCB76IRPJWC";

        /// <summary>
        /// WCB76INSSS.
        /// </summary>
        public const string WCB76INSSS = "WCB76INSSS";

        /// <summary>
        /// WCB76INSSWC.
        /// </summary>
        public const string WCB76INSSWC = "WCB76INSSWC";

        /// <summary>
        /// WCB76PISS.
        /// </summary>
        public const string WCB76PISS = "WCB76PISS";

        /// <summary>
        /// WCB76BTPIS.
        /// </summary>
        public const string WCB76BTPIS = "WCB76BTPIS";

        /// <summary>
        /// WCB76COFS.
        /// </summary>
        public const string WCB76COFS = "WCB76COFS";

        /// <summary>
        /// WCB76COFWC.
        /// </summary>
        public const string WCB76COFWC = "WCB76COFWC";

        /// <summary>
        /// WCB76CSLLS.
        /// </summary>
        public const string WCB76CSLLS = "WCB76CSLLS";

        /// <summary>
        /// WCB76CSLLWC.
        /// </summary>
        public const string WCB76CSLLWC = "WCB76CSLLWC";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCUPMJ.
        /// </summary>
        public const string WCUPMJ = "WCUPMJ";

        /// <summary>
        /// WCUPMT.
        /// </summary>
        public const string WCUPMT = "WCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B423";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCDOCO", "WCDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WCKCOO", "WCKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WCDCTO", "WCDCTO", JdeDataType.String, 4, true, true),
        new JdeField("WCLNID", "WCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WCB76ISSS", "WCB76ISSS", JdeDataType.String, 2),
        new JdeField("WCB76CTYC", "WCB76CTYC", JdeDataType.String, 20),
        new JdeField("WCB76SVTC", "WCB76SVTC", JdeDataType.String, 20),
        new JdeField("WCB76IRS", "WCB76IRS", JdeDataType.String, 2),
        new JdeField("WCB76IRPJWC", "WCB76IRPJWC", JdeDataType.String, 16),
        new JdeField("WCB76INSSS", "WCB76INSSS", JdeDataType.String, 2),
        new JdeField("WCB76INSSWC", "WCB76INSSWC", JdeDataType.String, 16),
        new JdeField("WCB76PISS", "WCB76PISS", JdeDataType.String, 2),
        new JdeField("WCB76BTPIS", "WCB76BTPIS", JdeDataType.String, 16),
        new JdeField("WCB76COFS", "WCB76COFS", JdeDataType.String, 2),
        new JdeField("WCB76COFWC", "WCB76COFWC", JdeDataType.String, 16),
        new JdeField("WCB76CSLLS", "WCB76CSLLS", JdeDataType.String, 2),
        new JdeField("WCB76CSLLWC", "WCB76CSLLWC", JdeDataType.String, 16),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCUPMT", "WCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B423_0", "Primary Key on WCDOCO, WCKCOO, WCDCTO, WCLNID", new[] { "WCDOCO", "WCKCOO", "WCDCTO", "WCLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
