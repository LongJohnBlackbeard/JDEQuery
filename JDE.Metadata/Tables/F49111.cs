using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49111 - .
/// </summary>
public class F49111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDBN01.
        /// </summary>
        public const string CDBN01 = "CDBN01";

        /// <summary>
        /// CDMCUZ.
        /// </summary>
        public const string CDMCUZ = "CDMCUZ";

        /// <summary>
        /// CDDCCD.
        /// </summary>
        public const string CDDCCD = "CDDCCD";

        /// <summary>
        /// CDSHPN.
        /// </summary>
        public const string CDSHPN = "CDSHPN";

        /// <summary>
        /// CDRSSN.
        /// </summary>
        public const string CDRSSN = "CDRSSN";

        /// <summary>
        /// CDCTID.
        /// </summary>
        public const string CDCTID = "CDCTID";

        /// <summary>
        /// CDDOCO.
        /// </summary>
        public const string CDDOCO = "CDDOCO";

        /// <summary>
        /// CDDCTO.
        /// </summary>
        public const string CDDCTO = "CDDCTO";

        /// <summary>
        /// CDKCOO.
        /// </summary>
        public const string CDKCOO = "CDKCOO";

        /// <summary>
        /// CDLNID.
        /// </summary>
        public const string CDLNID = "CDLNID";

        /// <summary>
        /// CDCEQT.
        /// </summary>
        public const string CDCEQT = "CDCEQT";

        /// <summary>
        /// CDEQTY.
        /// </summary>
        public const string CDEQTY = "CDEQTY";

        /// <summary>
        /// CDTQTY.
        /// </summary>
        public const string CDTQTY = "CDTQTY";

        /// <summary>
        /// CDGWEI.
        /// </summary>
        public const string CDGWEI = "CDGWEI";

        /// <summary>
        /// CDITM.
        /// </summary>
        public const string CDITM = "CDITM";

        /// <summary>
        /// CDNMFC.
        /// </summary>
        public const string CDNMFC = "CDNMFC";

        /// <summary>
        /// CDWEIT.
        /// </summary>
        public const string CDWEIT = "CDWEIT";
    }

    /// <inheritdoc />
    public override string TableName => "F49111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDBN01", "CDBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("CDMCUZ", "CDMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("CDDCCD", "CDDCCD", JdeDataType.String, 8, true, true),
        new JdeField("CDSHPN", "CDSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("CDRSSN", "CDRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCTID", "CDCTID", JdeDataType.String, 30),
        new JdeField("CDDOCO", "CDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CDDCTO", "CDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CDKCOO", "CDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CDLNID", "CDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCEQT", "CDCEQT", JdeDataType.String, 50),
        new JdeField("CDEQTY", "CDEQTY", JdeDataType.String, 10, true, true),
        new JdeField("CDTQTY", "CDTQTY", JdeDataType.Numeric),
        new JdeField("CDGWEI", "CDGWEI", JdeDataType.Numeric),
        new JdeField("CDITM", "CDITM", JdeDataType.Numeric),
        new JdeField("CDNMFC", "CDNMFC", JdeDataType.String, 8),
        new JdeField("CDWEIT", "CDWEIT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49111_0", "Primary Key on CDBN01, CDMCUZ, CDDCCD, CDSHPN, CDRSSN, CDDOCO, CDDCTO, CDKCOO, CDLNID, CDEQTY", new[] { "CDBN01", "CDMCUZ", "CDDCCD", "CDSHPN", "CDRSSN", "CDDOCO", "CDDCTO", "CDKCOO", "CDLNID", "CDEQTY" }, isUnique: true, isPrimaryKey: true)
    };
}
