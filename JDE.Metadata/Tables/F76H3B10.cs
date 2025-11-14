using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B10 - .
/// </summary>
public class F76H3B10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTKCO.
        /// </summary>
        public const string RTKCO = "RTKCO";

        /// <summary>
        /// RTDCT.
        /// </summary>
        public const string RTDCT = "RTDCT";

        /// <summary>
        /// RTDOC.
        /// </summary>
        public const string RTDOC = "RTDOC";

        /// <summary>
        /// RTH76LECO.
        /// </summary>
        public const string RTH76LECO = "RTH76LECO";

        /// <summary>
        /// RTH76LEDT.
        /// </summary>
        public const string RTH76LEDT = "RTH76LEDT";

        /// <summary>
        /// RTH76EMS.
        /// </summary>
        public const string RTH76EMS = "RTH76EMS";

        /// <summary>
        /// RTH76LENU.
        /// </summary>
        public const string RTH76LENU = "RTH76LENU";

        /// <summary>
        /// RTH76IPRT.
        /// </summary>
        public const string RTH76IPRT = "RTH76IPRT";

        /// <summary>
        /// RTH76IDPT.
        /// </summary>
        public const string RTH76IDPT = "RTH76IDPT";

        /// <summary>
        /// RTH76IRPT.
        /// </summary>
        public const string RTH76IRPT = "RTH76IRPT";

        /// <summary>
        /// RTH76IDPR.
        /// </summary>
        public const string RTH76IDPR = "RTH76IDPR";

        /// <summary>
        /// RTH76IRMA.
        /// </summary>
        public const string RTH76IRMA = "RTH76IRMA";

        /// <summary>
        /// RTH76IDRM.
        /// </summary>
        public const string RTH76IDRM = "RTH76IDRM";

        /// <summary>
        /// RTH76IR03.
        /// </summary>
        public const string RTH76IR03 = "RTH76IR03";

        /// <summary>
        /// RTH76ID03.
        /// </summary>
        public const string RTH76ID03 = "RTH76ID03";

        /// <summary>
        /// RTH76IR04.
        /// </summary>
        public const string RTH76IR04 = "RTH76IR04";

        /// <summary>
        /// RTH76ID04.
        /// </summary>
        public const string RTH76ID04 = "RTH76ID04";

        /// <summary>
        /// RTH76PRFL.
        /// </summary>
        public const string RTH76PRFL = "RTH76PRFL";

        /// <summary>
        /// RTH76PRON.
        /// </summary>
        public const string RTH76PRON = "RTH76PRON";

        /// <summary>
        /// RTH76PRST.
        /// </summary>
        public const string RTH76PRST = "RTH76PRST";

        /// <summary>
        /// RTH76TORG.
        /// </summary>
        public const string RTH76TORG = "RTH76TORG";

        /// <summary>
        /// RTH76FUC.
        /// </summary>
        public const string RTH76FUC = "RTH76FUC";

        /// <summary>
        /// RTH76FUD.
        /// </summary>
        public const string RTH76FUD = "RTH76FUD";

        /// <summary>
        /// RTH76FUR.
        /// </summary>
        public const string RTH76FUR = "RTH76FUR";

        /// <summary>
        /// RTH76FUA.
        /// </summary>
        public const string RTH76FUA = "RTH76FUA";

        /// <summary>
        /// RTH76FUF.
        /// </summary>
        public const string RTH76FUF = "RTH76FUF";

        /// <summary>
        /// RTTORG.
        /// </summary>
        public const string RTTORG = "RTTORG";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTKCO", "RTKCO", JdeDataType.String, 10, true, true),
        new JdeField("RTDCT", "RTDCT", JdeDataType.String, 4, true, true),
        new JdeField("RTDOC", "RTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RTH76LECO", "RTH76LECO", JdeDataType.String, 10),
        new JdeField("RTH76LEDT", "RTH76LEDT", JdeDataType.String, 6),
        new JdeField("RTH76EMS", "RTH76EMS", JdeDataType.String, 8),
        new JdeField("RTH76LENU", "RTH76LENU", JdeDataType.Numeric),
        new JdeField("RTH76IPRT", "RTH76IPRT", JdeDataType.String, 2),
        new JdeField("RTH76IDPT", "RTH76IDPT", JdeDataType.Numeric),
        new JdeField("RTH76IRPT", "RTH76IRPT", JdeDataType.String, 2),
        new JdeField("RTH76IDPR", "RTH76IDPR", JdeDataType.Numeric),
        new JdeField("RTH76IRMA", "RTH76IRMA", JdeDataType.String, 2),
        new JdeField("RTH76IDRM", "RTH76IDRM", JdeDataType.Numeric),
        new JdeField("RTH76IR03", "RTH76IR03", JdeDataType.String, 2),
        new JdeField("RTH76ID03", "RTH76ID03", JdeDataType.Numeric),
        new JdeField("RTH76IR04", "RTH76IR04", JdeDataType.String, 2),
        new JdeField("RTH76ID04", "RTH76ID04", JdeDataType.Numeric),
        new JdeField("RTH76PRFL", "RTH76PRFL", JdeDataType.String, 2),
        new JdeField("RTH76PRON", "RTH76PRON", JdeDataType.Numeric),
        new JdeField("RTH76PRST", "RTH76PRST", JdeDataType.String, 4),
        new JdeField("RTH76TORG", "RTH76TORG", JdeDataType.String, 6),
        new JdeField("RTH76FUC", "RTH76FUC", JdeDataType.String, 20),
        new JdeField("RTH76FUD", "RTH76FUD", JdeDataType.Numeric),
        new JdeField("RTH76FUR", "RTH76FUR", JdeDataType.String, 30),
        new JdeField("RTH76FUA", "RTH76FUA", JdeDataType.Numeric),
        new JdeField("RTH76FUF", "RTH76FUF", JdeDataType.String, 2),
        new JdeField("RTTORG", "RTTORG", JdeDataType.String, 20),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B10_0", "Primary Key on RTKCO, RTDCT, RTDOC", new[] { "RTKCO", "RTDCT", "RTDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H3B10_2", "Index on RTH76LECO, RTH76LEDT, RTH76EMS, RTH76LENU", new[] { "RTH76LECO", "RTH76LEDT", "RTH76EMS", "RTH76LENU" })
    };
}
