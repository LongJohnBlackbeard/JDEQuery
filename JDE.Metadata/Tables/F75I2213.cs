using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I2213 - .
/// </summary>
public class F75I2213 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTDOC.
        /// </summary>
        public const string TTDOC = "TTDOC";

        /// <summary>
        /// TTDCT.
        /// </summary>
        public const string TTDCT = "TTDCT";

        /// <summary>
        /// TTDOCO.
        /// </summary>
        public const string TTDOCO = "TTDOCO";

        /// <summary>
        /// TTLNID.
        /// </summary>
        public const string TTLNID = "TTLNID";

        /// <summary>
        /// TTMCU.
        /// </summary>
        public const string TTMCU = "TTMCU";

        /// <summary>
        /// TTFVTR.
        /// </summary>
        public const string TTFVTR = "TTFVTR";

        /// <summary>
        /// TTDCTO.
        /// </summary>
        public const string TTDCTO = "TTDCTO";

        /// <summary>
        /// TTTRDJ.
        /// </summary>
        public const string TTTRDJ = "TTTRDJ";

        /// <summary>
        /// TTAN8.
        /// </summary>
        public const string TTAN8 = "TTAN8";

        /// <summary>
        /// TTDL02.
        /// </summary>
        public const string TTDL02 = "TTDL02";

        /// <summary>
        /// TTSOQS.
        /// </summary>
        public const string TTSOQS = "TTSOQS";

        /// <summary>
        /// TTUPRC.
        /// </summary>
        public const string TTUPRC = "TTUPRC";

        /// <summary>
        /// TTAEXP.
        /// </summary>
        public const string TTAEXP = "TTAEXP";

        /// <summary>
        /// TTDOC1.
        /// </summary>
        public const string TTDOC1 = "TTDOC1";

        /// <summary>
        /// TTDCT5.
        /// </summary>
        public const string TTDCT5 = "TTDCT5";

        /// <summary>
        /// TTDCT1.
        /// </summary>
        public const string TTDCT1 = "TTDCT1";

        /// <summary>
        /// TTDOC5.
        /// </summary>
        public const string TTDOC5 = "TTDOC5";

        /// <summary>
        /// TTLNIX.
        /// </summary>
        public const string TTLNIX = "TTLNIX";

        /// <summary>
        /// TTDTE.
        /// </summary>
        public const string TTDTE = "TTDTE";

        /// <summary>
        /// TTAN81.
        /// </summary>
        public const string TTAN81 = "TTAN81";

        /// <summary>
        /// TTLITM.
        /// </summary>
        public const string TTLITM = "TTLITM";

        /// <summary>
        /// TTQTYS.
        /// </summary>
        public const string TTQTYS = "TTQTYS";

        /// <summary>
        /// TTAREC.
        /// </summary>
        public const string TTAREC = "TTAREC";

        /// <summary>
        /// TTFLAG.
        /// </summary>
        public const string TTFLAG = "TTFLAG";

        /// <summary>
        /// TTAG.
        /// </summary>
        public const string TTAG = "TTAG";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTAIS5.
        /// </summary>
        public const string TTAIS5 = "TTAIS5";

        /// <summary>
        /// TTADSO.
        /// </summary>
        public const string TTADSO = "TTADSO";

        /// <summary>
        /// TTAFA1.
        /// </summary>
        public const string TTAFA1 = "TTAFA1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I2213";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTDOC", "TTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TTDCT", "TTDCT", JdeDataType.String, 4, true, true),
        new JdeField("TTDOCO", "TTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TTLNID", "TTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TTMCU", "TTMCU", JdeDataType.String, 24, true, true),
        new JdeField("TTFVTR", "TTFVTR", JdeDataType.Numeric, null, true, true),
        new JdeField("TTDCTO", "TTDCTO", JdeDataType.String, 4),
        new JdeField("TTTRDJ", "TTTRDJ", JdeDataType.Numeric),
        new JdeField("TTAN8", "TTAN8", JdeDataType.Numeric),
        new JdeField("TTDL02", "TTDL02", JdeDataType.String, 60),
        new JdeField("TTSOQS", "TTSOQS", JdeDataType.Numeric),
        new JdeField("TTUPRC", "TTUPRC", JdeDataType.Numeric),
        new JdeField("TTAEXP", "TTAEXP", JdeDataType.Numeric),
        new JdeField("TTDOC1", "TTDOC1", JdeDataType.Numeric),
        new JdeField("TTDCT5", "TTDCT5", JdeDataType.String, 4),
        new JdeField("TTDCT1", "TTDCT1", JdeDataType.String, 4),
        new JdeField("TTDOC5", "TTDOC5", JdeDataType.Numeric),
        new JdeField("TTLNIX", "TTLNIX", JdeDataType.Numeric),
        new JdeField("TTDTE", "TTDTE", JdeDataType.Numeric),
        new JdeField("TTAN81", "TTAN81", JdeDataType.Numeric),
        new JdeField("TTLITM", "TTLITM", JdeDataType.String, 50),
        new JdeField("TTQTYS", "TTQTYS", JdeDataType.Numeric),
        new JdeField("TTAREC", "TTAREC", JdeDataType.Numeric),
        new JdeField("TTFLAG", "TTFLAG", JdeDataType.String, 2),
        new JdeField("TTAG", "TTAG", JdeDataType.Numeric),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTAIS5", "TTAIS5", JdeDataType.Numeric),
        new JdeField("TTADSO", "TTADSO", JdeDataType.String, 6),
        new JdeField("TTAFA1", "TTAFA1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I2213_0", "Primary Key on TTDOC, TTDCT, TTDOCO, TTLNID, TTMCU, TTFVTR", new[] { "TTDOC", "TTDCT", "TTDOCO", "TTLNID", "TTMCU", "TTFVTR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I2213_2", "Index on TTMCU", new[] { "TTMCU" }),
        new JdeIndex("F75I2213_3", "Index on TTMCU, TTFVTR", new[] { "TTMCU", "TTFVTR" })
    };
}
