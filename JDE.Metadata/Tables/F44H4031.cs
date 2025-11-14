using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H4031 - .
/// </summary>
public class F44H4031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OVHBAREA.
        /// </summary>
        public const string OVHBAREA = "OVHBAREA";

        /// <summary>
        /// OVHBMCUS.
        /// </summary>
        public const string OVHBMCUS = "OVHBMCUS";

        /// <summary>
        /// OVCPHASE.
        /// </summary>
        public const string OVCPHASE = "OVCPHASE";

        /// <summary>
        /// OVHBPLAN.
        /// </summary>
        public const string OVHBPLAN = "OVHBPLAN";

        /// <summary>
        /// OVOPM01.
        /// </summary>
        public const string OVOPM01 = "OVOPM01";

        /// <summary>
        /// OVOPM02.
        /// </summary>
        public const string OVOPM02 = "OVOPM02";

        /// <summary>
        /// OVOPM03.
        /// </summary>
        public const string OVOPM03 = "OVOPM03";

        /// <summary>
        /// OVOPTION.
        /// </summary>
        public const string OVOPTION = "OVOPTION";

        /// <summary>
        /// OVOPPLB.
        /// </summary>
        public const string OVOPPLB = "OVOPPLB";

        /// <summary>
        /// OVOPPVV.
        /// </summary>
        public const string OVOPPVV = "OVOPPVV";

        /// <summary>
        /// OVOPPED.
        /// </summary>
        public const string OVOPPED = "OVOPPED";

        /// <summary>
        /// OVOPPXD.
        /// </summary>
        public const string OVOPPXD = "OVOPPXD";

        /// <summary>
        /// OVCRTU.
        /// </summary>
        public const string OVCRTU = "OVCRTU";

        /// <summary>
        /// OVCRTJ.
        /// </summary>
        public const string OVCRTJ = "OVCRTJ";

        /// <summary>
        /// OVCRTT.
        /// </summary>
        public const string OVCRTT = "OVCRTT";

        /// <summary>
        /// OVWRKSTNID.
        /// </summary>
        public const string OVWRKSTNID = "OVWRKSTNID";

        /// <summary>
        /// OVHBOPID.
        /// </summary>
        public const string OVHBOPID = "OVHBOPID";

        /// <summary>
        /// OVUPMB.
        /// </summary>
        public const string OVUPMB = "OVUPMB";

        /// <summary>
        /// OVUPMJ.
        /// </summary>
        public const string OVUPMJ = "OVUPMJ";

        /// <summary>
        /// OVUPMT.
        /// </summary>
        public const string OVUPMT = "OVUPMT";

        /// <summary>
        /// OVJOBN.
        /// </summary>
        public const string OVJOBN = "OVJOBN";

        /// <summary>
        /// OVPID.
        /// </summary>
        public const string OVPID = "OVPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H4031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OVHBAREA", "OVHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("OVHBMCUS", "OVHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OVCPHASE", "OVCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("OVHBPLAN", "OVHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("OVOPM01", "OVOPM01", JdeDataType.String, 6, true, true),
        new JdeField("OVOPM02", "OVOPM02", JdeDataType.String, 6, true, true),
        new JdeField("OVOPM03", "OVOPM03", JdeDataType.String, 6, true, true),
        new JdeField("OVOPTION", "OVOPTION", JdeDataType.String, 16, true, true),
        new JdeField("OVOPPLB", "OVOPPLB", JdeDataType.String, 40, true, true),
        new JdeField("OVOPPVV", "OVOPPVV", JdeDataType.String, 60, true, true),
        new JdeField("OVOPPED", "OVOPPED", JdeDataType.Numeric),
        new JdeField("OVOPPXD", "OVOPPXD", JdeDataType.Numeric),
        new JdeField("OVCRTU", "OVCRTU", JdeDataType.String, 20),
        new JdeField("OVCRTJ", "OVCRTJ", JdeDataType.Numeric),
        new JdeField("OVCRTT", "OVCRTT", JdeDataType.Numeric),
        new JdeField("OVWRKSTNID", "OVWRKSTNID", JdeDataType.String, 20),
        new JdeField("OVHBOPID", "OVHBOPID", JdeDataType.String, 20),
        new JdeField("OVUPMB", "OVUPMB", JdeDataType.String, 20),
        new JdeField("OVUPMJ", "OVUPMJ", JdeDataType.Numeric),
        new JdeField("OVUPMT", "OVUPMT", JdeDataType.Numeric),
        new JdeField("OVJOBN", "OVJOBN", JdeDataType.String, 20),
        new JdeField("OVPID", "OVPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H4031_0", "Primary Key on OVHBAREA, OVHBMCUS, OVCPHASE, OVHBPLAN, OVOPTION, OVOPM01, OVOPM02, OVOPM03, OVOPPLB, OVOPPVV", new[] { "OVHBAREA", "OVHBMCUS", "OVCPHASE", "OVHBPLAN", "OVOPTION", "OVOPM01", "OVOPM02", "OVOPM03", "OVOPPLB", "OVOPPVV" }, isUnique: true, isPrimaryKey: true)
    };
}
