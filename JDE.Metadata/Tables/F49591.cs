using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49591 - .
/// </summary>
public class F49591 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DBBN01.
        /// </summary>
        public const string DBBN01 = "DBBN01";

        /// <summary>
        /// DBSEQ1.
        /// </summary>
        public const string DBSEQ1 = "DBSEQ1";

        /// <summary>
        /// DBMCUZ.
        /// </summary>
        public const string DBMCUZ = "DBMCUZ";

        /// <summary>
        /// DBDCCD.
        /// </summary>
        public const string DBDCCD = "DBDCCD";

        /// <summary>
        /// DBVMCU.
        /// </summary>
        public const string DBVMCU = "DBVMCU";

        /// <summary>
        /// DBSEQ.
        /// </summary>
        public const string DBSEQ = "DBSEQ";

        /// <summary>
        /// DBLDNM.
        /// </summary>
        public const string DBLDNM = "DBLDNM";

        /// <summary>
        /// DBTRPL.
        /// </summary>
        public const string DBTRPL = "DBTRPL";

        /// <summary>
        /// DBSHPN.
        /// </summary>
        public const string DBSHPN = "DBSHPN";

        /// <summary>
        /// DBRSSN.
        /// </summary>
        public const string DBRSSN = "DBRSSN";

        /// <summary>
        /// DBDCPR.
        /// </summary>
        public const string DBDCPR = "DBDCPR";

        /// <summary>
        /// DBDPAL.
        /// </summary>
        public const string DBDPAL = "DBDPAL";

        /// <summary>
        /// DBIMSC.
        /// </summary>
        public const string DBIMSC = "DBIMSC";

        /// <summary>
        /// DBDFTU.
        /// </summary>
        public const string DBDFTU = "DBDFTU";

        /// <summary>
        /// DBDDRF.
        /// </summary>
        public const string DBDDRF = "DBDDRF";

        /// <summary>
        /// DBURCD.
        /// </summary>
        public const string DBURCD = "DBURCD";

        /// <summary>
        /// DBURDT.
        /// </summary>
        public const string DBURDT = "DBURDT";

        /// <summary>
        /// DBURAT.
        /// </summary>
        public const string DBURAT = "DBURAT";

        /// <summary>
        /// DBURAB.
        /// </summary>
        public const string DBURAB = "DBURAB";

        /// <summary>
        /// DBURRF.
        /// </summary>
        public const string DBURRF = "DBURRF";

        /// <summary>
        /// DBUSER.
        /// </summary>
        public const string DBUSER = "DBUSER";

        /// <summary>
        /// DBPID.
        /// </summary>
        public const string DBPID = "DBPID";

        /// <summary>
        /// DBJOBN.
        /// </summary>
        public const string DBJOBN = "DBJOBN";

        /// <summary>
        /// DBUPMJ.
        /// </summary>
        public const string DBUPMJ = "DBUPMJ";

        /// <summary>
        /// DBTDAY.
        /// </summary>
        public const string DBTDAY = "DBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F49591";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DBBN01", "DBBN01", JdeDataType.Numeric, null, true, true),
        new JdeField("DBSEQ1", "DBSEQ1", JdeDataType.Numeric, null, true, true),
        new JdeField("DBMCUZ", "DBMCUZ", JdeDataType.String, 24, true, true),
        new JdeField("DBDCCD", "DBDCCD", JdeDataType.String, 8, true, true),
        new JdeField("DBVMCU", "DBVMCU", JdeDataType.String, 24),
        new JdeField("DBSEQ", "DBSEQ", JdeDataType.Numeric),
        new JdeField("DBLDNM", "DBLDNM", JdeDataType.Numeric),
        new JdeField("DBTRPL", "DBTRPL", JdeDataType.Numeric),
        new JdeField("DBSHPN", "DBSHPN", JdeDataType.Numeric),
        new JdeField("DBRSSN", "DBRSSN", JdeDataType.Numeric),
        new JdeField("DBDCPR", "DBDCPR", JdeDataType.String, 2),
        new JdeField("DBDPAL", "DBDPAL", JdeDataType.String, 2),
        new JdeField("DBIMSC", "DBIMSC", JdeDataType.String, 2),
        new JdeField("DBDFTU", "DBDFTU", JdeDataType.String, 2),
        new JdeField("DBDDRF", "DBDDRF", JdeDataType.String, 2),
        new JdeField("DBURCD", "DBURCD", JdeDataType.String, 4),
        new JdeField("DBURDT", "DBURDT", JdeDataType.Numeric),
        new JdeField("DBURAT", "DBURAT", JdeDataType.Numeric),
        new JdeField("DBURAB", "DBURAB", JdeDataType.Numeric),
        new JdeField("DBURRF", "DBURRF", JdeDataType.String, 30),
        new JdeField("DBUSER", "DBUSER", JdeDataType.String, 20),
        new JdeField("DBPID", "DBPID", JdeDataType.String, 20),
        new JdeField("DBJOBN", "DBJOBN", JdeDataType.String, 20),
        new JdeField("DBUPMJ", "DBUPMJ", JdeDataType.Numeric),
        new JdeField("DBTDAY", "DBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49591_0", "Primary Key on DBBN01, DBSEQ1, DBMCUZ, DBDCCD", new[] { "DBBN01", "DBSEQ1", "DBMCUZ", "DBDCCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F49591_2", "Index on DBBN01, DBSEQ, DBDCCD, DBMCUZ, DBSEQ1", new[] { "DBBN01", "DBSEQ", "DBDCCD", "DBMCUZ", "DBSEQ1" }),
        new JdeIndex("F49591_3", "Index on DBBN01, DBSHPN, DBDCCD", new[] { "DBBN01", "DBSHPN", "DBDCCD" })
    };
}
