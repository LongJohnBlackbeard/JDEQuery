using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43C05 - .
/// </summary>
public class F43C05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CACNTRTID.
        /// </summary>
        public const string CACNTRTID = "CACNTRTID";

        /// <summary>
        /// CADTSEQNUM.
        /// </summary>
        public const string CADTSEQNUM = "CADTSEQNUM";

        /// <summary>
        /// CAACTDTCD.
        /// </summary>
        public const string CAACTDTCD = "CAACTDTCD";

        /// <summary>
        /// CAACTDTDSC.
        /// </summary>
        public const string CAACTDTDSC = "CAACTDTDSC";

        /// <summary>
        /// CARECRR.
        /// </summary>
        public const string CARECRR = "CARECRR";

        /// <summary>
        /// CADTERQRD.
        /// </summary>
        public const string CADTERQRD = "CADTERQRD";

        /// <summary>
        /// CACNTRCLS.
        /// </summary>
        public const string CACNTRCLS = "CACNTRCLS";

        /// <summary>
        /// CADTECMPL.
        /// </summary>
        public const string CADTECMPL = "CADTECMPL";

        /// <summary>
        /// CAPRSNRSP.
        /// </summary>
        public const string CAPRSNRSP = "CAPRSNRSP";

        /// <summary>
        /// CADTCOMM.
        /// </summary>
        public const string CADTCOMM = "CADTCOMM";

        /// <summary>
        /// CAURCD.
        /// </summary>
        public const string CAURCD = "CAURCD";

        /// <summary>
        /// CAURDT.
        /// </summary>
        public const string CAURDT = "CAURDT";

        /// <summary>
        /// CAURAT.
        /// </summary>
        public const string CAURAT = "CAURAT";

        /// <summary>
        /// CAURAB.
        /// </summary>
        public const string CAURAB = "CAURAB";

        /// <summary>
        /// CAURRF.
        /// </summary>
        public const string CAURRF = "CAURRF";

        /// <summary>
        /// CATORG.
        /// </summary>
        public const string CATORG = "CATORG";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAJOBN.
        /// </summary>
        public const string CAJOBN = "CAJOBN";

        /// <summary>
        /// CAUUPMJ.
        /// </summary>
        public const string CAUUPMJ = "CAUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43C05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CACNTRTID", "CACNTRTID", JdeDataType.Numeric, null, true, true),
        new JdeField("CADTSEQNUM", "CADTSEQNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("CAACTDTCD", "CAACTDTCD", JdeDataType.String, 6),
        new JdeField("CAACTDTDSC", "CAACTDTDSC", JdeDataType.String, 60),
        new JdeField("CARECRR", "CARECRR", JdeDataType.String, 2),
        new JdeField("CADTERQRD", "CADTERQRD", JdeDataType.Date),
        new JdeField("CACNTRCLS", "CACNTRCLS", JdeDataType.String, 2),
        new JdeField("CADTECMPL", "CADTECMPL", JdeDataType.Date),
        new JdeField("CAPRSNRSP", "CAPRSNRSP", JdeDataType.Numeric),
        new JdeField("CADTCOMM", "CADTCOMM", JdeDataType.String, 510),
        new JdeField("CAURCD", "CAURCD", JdeDataType.String, 4),
        new JdeField("CAURDT", "CAURDT", JdeDataType.Numeric),
        new JdeField("CAURAT", "CAURAT", JdeDataType.Numeric),
        new JdeField("CAURAB", "CAURAB", JdeDataType.Numeric),
        new JdeField("CAURRF", "CAURRF", JdeDataType.String, 30),
        new JdeField("CATORG", "CATORG", JdeDataType.String, 20),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAJOBN", "CAJOBN", JdeDataType.String, 20),
        new JdeField("CAUUPMJ", "CAUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43C05_0", "Primary Key on CACNTRTID, CADTSEQNUM", new[] { "CACNTRTID", "CADTSEQNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
