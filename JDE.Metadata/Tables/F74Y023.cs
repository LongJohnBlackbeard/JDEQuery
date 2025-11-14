using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y023 - .
/// </summary>
public class F74Y023 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMY74IDEC.
        /// </summary>
        public const string IMY74IDEC = "IMY74IDEC";

        /// <summary>
        /// IMKCOO.
        /// </summary>
        public const string IMKCOO = "IMKCOO";

        /// <summary>
        /// IMDCTO.
        /// </summary>
        public const string IMDCTO = "IMDCTO";

        /// <summary>
        /// IMDOCO.
        /// </summary>
        public const string IMDOCO = "IMDOCO";

        /// <summary>
        /// IMY74SEC.
        /// </summary>
        public const string IMY74SEC = "IMY74SEC";

        /// <summary>
        /// IMY74MOS.
        /// </summary>
        public const string IMY74MOS = "IMY74MOS";

        /// <summary>
        /// IMY74MOC.
        /// </summary>
        public const string IMY74MOC = "IMY74MOC";

        /// <summary>
        /// IMY74PCTR.
        /// </summary>
        public const string IMY74PCTR = "IMY74PCTR";

        /// <summary>
        /// IMY74NSE.
        /// </summary>
        public const string IMY74NSE = "IMY74NSE";

        /// <summary>
        /// IMY74NMS.
        /// </summary>
        public const string IMY74NMS = "IMY74NMS";

        /// <summary>
        /// IMY74NMC.
        /// </summary>
        public const string IMY74NMC = "IMY74NMC";

        /// <summary>
        /// IMY74NPCR.
        /// </summary>
        public const string IMY74NPCR = "IMY74NPCR";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMPID.
        /// </summary>
        public const string IMPID = "IMPID";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMUPMT.
        /// </summary>
        public const string IMUPMT = "IMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y023";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMY74IDEC", "IMY74IDEC", JdeDataType.Numeric, null, true, true),
        new JdeField("IMKCOO", "IMKCOO", JdeDataType.String, 10, true, true),
        new JdeField("IMDCTO", "IMDCTO", JdeDataType.String, 4, true, true),
        new JdeField("IMDOCO", "IMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IMY74SEC", "IMY74SEC", JdeDataType.String, 20, true, true),
        new JdeField("IMY74MOS", "IMY74MOS", JdeDataType.String, 2, true, true),
        new JdeField("IMY74MOC", "IMY74MOC", JdeDataType.String, 2, true, true),
        new JdeField("IMY74PCTR", "IMY74PCTR", JdeDataType.String, 6, true, true),
        new JdeField("IMY74NSE", "IMY74NSE", JdeDataType.String, 20),
        new JdeField("IMY74NMS", "IMY74NMS", JdeDataType.String, 2),
        new JdeField("IMY74NMC", "IMY74NMC", JdeDataType.String, 2),
        new JdeField("IMY74NPCR", "IMY74NPCR", JdeDataType.String, 6),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMUPMT", "IMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y023_0", "Primary Key on IMY74IDEC, IMKCOO, IMDCTO, IMDOCO, IMY74SEC, IMY74MOS, IMY74MOC, IMY74PCTR", new[] { "IMY74IDEC", "IMKCOO", "IMDCTO", "IMDOCO", "IMY74SEC", "IMY74MOS", "IMY74MOC", "IMY74PCTR" }, isUnique: true, isPrimaryKey: true)
    };
}
