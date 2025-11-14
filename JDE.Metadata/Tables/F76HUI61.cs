using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76HUI61 - .
/// </summary>
public class F76HUI61 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZTJOBS.
        /// </summary>
        public const string ZTJOBS = "ZTJOBS";

        /// <summary>
        /// ZTCTID.
        /// </summary>
        public const string ZTCTID = "ZTCTID";

        /// <summary>
        /// ZTEDUS.
        /// </summary>
        public const string ZTEDUS = "ZTEDUS";

        /// <summary>
        /// ZTEDTN.
        /// </summary>
        public const string ZTEDTN = "ZTEDTN";

        /// <summary>
        /// ZTEDBT.
        /// </summary>
        public const string ZTEDBT = "ZTEDBT";

        /// <summary>
        /// ZTH76LECO.
        /// </summary>
        public const string ZTH76LECO = "ZTH76LECO";

        /// <summary>
        /// ZTH76LEDT.
        /// </summary>
        public const string ZTH76LEDT = "ZTH76LEDT";

        /// <summary>
        /// ZTH76EMS.
        /// </summary>
        public const string ZTH76EMS = "ZTH76EMS";

        /// <summary>
        /// ZTH76LENU.
        /// </summary>
        public const string ZTH76LENU = "ZTH76LENU";

        /// <summary>
        /// ZTH76IPRT.
        /// </summary>
        public const string ZTH76IPRT = "ZTH76IPRT";

        /// <summary>
        /// ZTH76IDPT.
        /// </summary>
        public const string ZTH76IDPT = "ZTH76IDPT";

        /// <summary>
        /// ZTH76IRPT.
        /// </summary>
        public const string ZTH76IRPT = "ZTH76IRPT";

        /// <summary>
        /// ZTH76IDPR.
        /// </summary>
        public const string ZTH76IDPR = "ZTH76IDPR";

        /// <summary>
        /// ZTH76IRMA.
        /// </summary>
        public const string ZTH76IRMA = "ZTH76IRMA";

        /// <summary>
        /// ZTH76IDRM.
        /// </summary>
        public const string ZTH76IDRM = "ZTH76IDRM";

        /// <summary>
        /// ZTH76IR03.
        /// </summary>
        public const string ZTH76IR03 = "ZTH76IR03";

        /// <summary>
        /// ZTH76ID03.
        /// </summary>
        public const string ZTH76ID03 = "ZTH76ID03";

        /// <summary>
        /// ZTH76IR04.
        /// </summary>
        public const string ZTH76IR04 = "ZTH76IR04";

        /// <summary>
        /// ZTH76ID04.
        /// </summary>
        public const string ZTH76ID04 = "ZTH76ID04";

        /// <summary>
        /// ZTH76PRFL.
        /// </summary>
        public const string ZTH76PRFL = "ZTH76PRFL";

        /// <summary>
        /// ZTH76PRON.
        /// </summary>
        public const string ZTH76PRON = "ZTH76PRON";

        /// <summary>
        /// ZTH76PRST.
        /// </summary>
        public const string ZTH76PRST = "ZTH76PRST";

        /// <summary>
        /// ZTH76TORG.
        /// </summary>
        public const string ZTH76TORG = "ZTH76TORG";

        /// <summary>
        /// ZTH76FUC.
        /// </summary>
        public const string ZTH76FUC = "ZTH76FUC";

        /// <summary>
        /// ZTH76FUD.
        /// </summary>
        public const string ZTH76FUD = "ZTH76FUD";

        /// <summary>
        /// ZTH76FUR.
        /// </summary>
        public const string ZTH76FUR = "ZTH76FUR";

        /// <summary>
        /// ZTH76FUA.
        /// </summary>
        public const string ZTH76FUA = "ZTH76FUA";

        /// <summary>
        /// ZTH76FUF.
        /// </summary>
        public const string ZTH76FUF = "ZTH76FUF";

        /// <summary>
        /// ZTTORG.
        /// </summary>
        public const string ZTTORG = "ZTTORG";

        /// <summary>
        /// ZTUSER.
        /// </summary>
        public const string ZTUSER = "ZTUSER";

        /// <summary>
        /// ZTPID.
        /// </summary>
        public const string ZTPID = "ZTPID";

        /// <summary>
        /// ZTJOBN.
        /// </summary>
        public const string ZTJOBN = "ZTJOBN";

        /// <summary>
        /// ZTUPMJ.
        /// </summary>
        public const string ZTUPMJ = "ZTUPMJ";

        /// <summary>
        /// ZTUPMT.
        /// </summary>
        public const string ZTUPMT = "ZTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76HUI61";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZTJOBS", "ZTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTCTID", "ZTCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZTEDUS", "ZTEDUS", JdeDataType.String, 20),
        new JdeField("ZTEDTN", "ZTEDTN", JdeDataType.String, 44),
        new JdeField("ZTEDBT", "ZTEDBT", JdeDataType.String, 30),
        new JdeField("ZTH76LECO", "ZTH76LECO", JdeDataType.String, 10),
        new JdeField("ZTH76LEDT", "ZTH76LEDT", JdeDataType.String, 6),
        new JdeField("ZTH76EMS", "ZTH76EMS", JdeDataType.String, 8),
        new JdeField("ZTH76LENU", "ZTH76LENU", JdeDataType.Numeric),
        new JdeField("ZTH76IPRT", "ZTH76IPRT", JdeDataType.String, 2),
        new JdeField("ZTH76IDPT", "ZTH76IDPT", JdeDataType.Numeric),
        new JdeField("ZTH76IRPT", "ZTH76IRPT", JdeDataType.String, 2),
        new JdeField("ZTH76IDPR", "ZTH76IDPR", JdeDataType.Numeric),
        new JdeField("ZTH76IRMA", "ZTH76IRMA", JdeDataType.String, 2),
        new JdeField("ZTH76IDRM", "ZTH76IDRM", JdeDataType.Numeric),
        new JdeField("ZTH76IR03", "ZTH76IR03", JdeDataType.String, 2),
        new JdeField("ZTH76ID03", "ZTH76ID03", JdeDataType.Numeric),
        new JdeField("ZTH76IR04", "ZTH76IR04", JdeDataType.String, 2),
        new JdeField("ZTH76ID04", "ZTH76ID04", JdeDataType.Numeric),
        new JdeField("ZTH76PRFL", "ZTH76PRFL", JdeDataType.String, 2),
        new JdeField("ZTH76PRON", "ZTH76PRON", JdeDataType.Numeric),
        new JdeField("ZTH76PRST", "ZTH76PRST", JdeDataType.String, 4),
        new JdeField("ZTH76TORG", "ZTH76TORG", JdeDataType.String, 6),
        new JdeField("ZTH76FUC", "ZTH76FUC", JdeDataType.String, 20),
        new JdeField("ZTH76FUD", "ZTH76FUD", JdeDataType.Numeric),
        new JdeField("ZTH76FUR", "ZTH76FUR", JdeDataType.String, 30),
        new JdeField("ZTH76FUA", "ZTH76FUA", JdeDataType.Numeric),
        new JdeField("ZTH76FUF", "ZTH76FUF", JdeDataType.String, 2),
        new JdeField("ZTTORG", "ZTTORG", JdeDataType.String, 20),
        new JdeField("ZTUSER", "ZTUSER", JdeDataType.String, 20),
        new JdeField("ZTPID", "ZTPID", JdeDataType.String, 20),
        new JdeField("ZTJOBN", "ZTJOBN", JdeDataType.String, 20),
        new JdeField("ZTUPMJ", "ZTUPMJ", JdeDataType.Numeric),
        new JdeField("ZTUPMT", "ZTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76HUI61_0", "Primary Key on ZTJOBS, ZTCTID", new[] { "ZTJOBS", "ZTCTID" }, isUnique: true, isPrimaryKey: true)
    };
}
