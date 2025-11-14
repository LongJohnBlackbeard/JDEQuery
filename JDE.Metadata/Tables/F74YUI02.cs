using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74YUI02 - .
/// </summary>
public class F74YUI02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTJOBS.
        /// </summary>
        public const string TTJOBS = "TTJOBS";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTTXA1.
        /// </summary>
        public const string TTTXA1 = "TTTXA1";

        /// <summary>
        /// TTDCTO.
        /// </summary>
        public const string TTDCTO = "TTDCTO";

        /// <summary>
        /// TTDOCO.
        /// </summary>
        public const string TTDOCO = "TTDOCO";

        /// <summary>
        /// TTSFXO.
        /// </summary>
        public const string TTSFXO = "TTSFXO";

        /// <summary>
        /// TTLNID.
        /// </summary>
        public const string TTLNID = "TTLNID";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";

        /// <summary>
        /// TTKCOO.
        /// </summary>
        public const string TTKCOO = "TTKCOO";

        /// <summary>
        /// TTCO.
        /// </summary>
        public const string TTCO = "TTCO";

        /// <summary>
        /// TTAN8.
        /// </summary>
        public const string TTAN8 = "TTAN8";

        /// <summary>
        /// TTTXR1.
        /// </summary>
        public const string TTTXR1 = "TTTXR1";

        /// <summary>
        /// TTICUT.
        /// </summary>
        public const string TTICUT = "TTICUT";

        /// <summary>
        /// TTATXA.
        /// </summary>
        public const string TTATXA = "TTATXA";

        /// <summary>
        /// TTITM.
        /// </summary>
        public const string TTITM = "TTITM";

        /// <summary>
        /// TTEFDJ.
        /// </summary>
        public const string TTEFDJ = "TTEFDJ";

        /// <summary>
        /// TTLCTR.
        /// </summary>
        public const string TTLCTR = "TTLCTR";

        /// <summary>
        /// TTK70ADSTR.
        /// </summary>
        public const string TTK70ADSTR = "TTK70ADSTR";

        /// <summary>
        /// TTK70ADS01.
        /// </summary>
        public const string TTK70ADS01 = "TTK70ADS01";

        /// <summary>
        /// TTSTAM.
        /// </summary>
        public const string TTSTAM = "TTSTAM";

        /// <summary>
        /// TTATXN.
        /// </summary>
        public const string TTATXN = "TTATXN";

        /// <summary>
        /// TTEXR1.
        /// </summary>
        public const string TTEXR1 = "TTEXR1";

        /// <summary>
        /// TTDGL.
        /// </summary>
        public const string TTDGL = "TTDGL";

        /// <summary>
        /// TTSTA1.
        /// </summary>
        public const string TTSTA1 = "TTSTA1";

        /// <summary>
        /// TTCRCD.
        /// </summary>
        public const string TTCRCD = "TTCRCD";

        /// <summary>
        /// TTCRR.
        /// </summary>
        public const string TTCRR = "TTCRR";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTY74UPMJ.
        /// </summary>
        public const string TTY74UPMJ = "TTY74UPMJ";

        /// <summary>
        /// TTY74UPMT.
        /// </summary>
        public const string TTY74UPMT = "TTY74UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74YUI02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTJOBS", "TTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20, true, true),
        new JdeField("TTTXA1", "TTTXA1", JdeDataType.String, 20),
        new JdeField("TTDCTO", "TTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TTDOCO", "TTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TTSFXO", "TTSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TTLNID", "TTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("TTKCOO", "TTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TTCO", "TTCO", JdeDataType.String, 10),
        new JdeField("TTAN8", "TTAN8", JdeDataType.Numeric),
        new JdeField("TTTXR1", "TTTXR1", JdeDataType.Numeric),
        new JdeField("TTICUT", "TTICUT", JdeDataType.String, 4),
        new JdeField("TTATXA", "TTATXA", JdeDataType.Numeric),
        new JdeField("TTITM", "TTITM", JdeDataType.Numeric),
        new JdeField("TTEFDJ", "TTEFDJ", JdeDataType.Numeric),
        new JdeField("TTLCTR", "TTLCTR", JdeDataType.String, 6),
        new JdeField("TTK70ADSTR", "TTK70ADSTR", JdeDataType.String, 20),
        new JdeField("TTK70ADS01", "TTK70ADS01", JdeDataType.String, 300),
        new JdeField("TTSTAM", "TTSTAM", JdeDataType.Numeric),
        new JdeField("TTATXN", "TTATXN", JdeDataType.Numeric),
        new JdeField("TTEXR1", "TTEXR1", JdeDataType.String, 4),
        new JdeField("TTDGL", "TTDGL", JdeDataType.Numeric),
        new JdeField("TTSTA1", "TTSTA1", JdeDataType.Numeric),
        new JdeField("TTCRCD", "TTCRCD", JdeDataType.String, 6),
        new JdeField("TTCRR", "TTCRR", JdeDataType.Numeric),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTY74UPMJ", "TTY74UPMJ", JdeDataType.Numeric),
        new JdeField("TTY74UPMT", "TTY74UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74YUI02_0", "Primary Key on TTJOBS, TTUSER, TTDCTO, TTDOCO, TTSFXO, TTLNID, TTUPMJ, TTUPMT, TTKCOO", new[] { "TTJOBS", "TTUSER", "TTDCTO", "TTDOCO", "TTSFXO", "TTLNID", "TTUPMJ", "TTUPMT", "TTKCOO" }, isUnique: true, isPrimaryKey: true)
    };
}
