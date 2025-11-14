using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00091 - .
/// </summary>
public class F00091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T2SDB.
        /// </summary>
        public const string T2SDB = "T2SDB";

        /// <summary>
        /// T2TYDT.
        /// </summary>
        public const string T2TYDT = "T2TYDT";

        /// <summary>
        /// T2CLS.
        /// </summary>
        public const string T2CLS = "T2CLS";

        /// <summary>
        /// T2DSPM.
        /// </summary>
        public const string T2DSPM = "T2DSPM";

        /// <summary>
        /// T2DSS5.
        /// </summary>
        public const string T2DSS5 = "T2DSS5";

        /// <summary>
        /// T2DL01.
        /// </summary>
        public const string T2DL01 = "T2DL01";

        /// <summary>
        /// T2SY.
        /// </summary>
        public const string T2SY = "T2SY";

        /// <summary>
        /// T2SY1.
        /// </summary>
        public const string T2SY1 = "T2SY1";

        /// <summary>
        /// T2SY2.
        /// </summary>
        public const string T2SY2 = "T2SY2";

        /// <summary>
        /// T2RT.
        /// </summary>
        public const string T2RT = "T2RT";

        /// <summary>
        /// T2RT1.
        /// </summary>
        public const string T2RT1 = "T2RT1";

        /// <summary>
        /// T2RT2.
        /// </summary>
        public const string T2RT2 = "T2RT2";

        /// <summary>
        /// T2GDC1.
        /// </summary>
        public const string T2GDC1 = "T2GDC1";

        /// <summary>
        /// T2GDC2.
        /// </summary>
        public const string T2GDC2 = "T2GDC2";

        /// <summary>
        /// T2GDC3.
        /// </summary>
        public const string T2GDC3 = "T2GDC3";

        /// <summary>
        /// T2GDC4.
        /// </summary>
        public const string T2GDC4 = "T2GDC4";

        /// <summary>
        /// T2GDC5.
        /// </summary>
        public const string T2GDC5 = "T2GDC5";

        /// <summary>
        /// T2GDC6.
        /// </summary>
        public const string T2GDC6 = "T2GDC6";

        /// <summary>
        /// T2GDC7.
        /// </summary>
        public const string T2GDC7 = "T2GDC7";

        /// <summary>
        /// T2GDCA.
        /// </summary>
        public const string T2GDCA = "T2GDCA";

        /// <summary>
        /// T2GDC0.
        /// </summary>
        public const string T2GDC0 = "T2GDC0";

        /// <summary>
        /// T2GDCC.
        /// </summary>
        public const string T2GDCC = "T2GDCC";

        /// <summary>
        /// T2GDC8.
        /// </summary>
        public const string T2GDC8 = "T2GDC8";

        /// <summary>
        /// T2GDCD.
        /// </summary>
        public const string T2GDCD = "T2GDCD";

        /// <summary>
        /// T2AT1.
        /// </summary>
        public const string T2AT1 = "T2AT1";

        /// <summary>
        /// T2EAP.
        /// </summary>
        public const string T2EAP = "T2EAP";

        /// <summary>
        /// T2PGM.
        /// </summary>
        public const string T2PGM = "T2PGM";

        /// <summary>
        /// T2VERS.
        /// </summary>
        public const string T2VERS = "T2VERS";

        /// <summary>
        /// T2USER.
        /// </summary>
        public const string T2USER = "T2USER";

        /// <summary>
        /// T2JOBN.
        /// </summary>
        public const string T2JOBN = "T2JOBN";

        /// <summary>
        /// T2UPMJ.
        /// </summary>
        public const string T2UPMJ = "T2UPMJ";

        /// <summary>
        /// T2TDAY.
        /// </summary>
        public const string T2TDAY = "T2TDAY";

        /// <summary>
        /// T2GDCE.
        /// </summary>
        public const string T2GDCE = "T2GDCE";

        /// <summary>
        /// T2GDCF.
        /// </summary>
        public const string T2GDCF = "T2GDCF";
    }

    /// <inheritdoc />
    public override string TableName => "F00091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T2SDB", "T2SDB", JdeDataType.String, 8, true, true),
        new JdeField("T2TYDT", "T2TYDT", JdeDataType.String, 4, true, true),
        new JdeField("T2CLS", "T2CLS", JdeDataType.String, 8),
        new JdeField("T2DSPM", "T2DSPM", JdeDataType.String, 2),
        new JdeField("T2DSS5", "T2DSS5", JdeDataType.Numeric),
        new JdeField("T2DL01", "T2DL01", JdeDataType.String, 60),
        new JdeField("T2SY", "T2SY", JdeDataType.String, 8),
        new JdeField("T2SY1", "T2SY1", JdeDataType.String, 8),
        new JdeField("T2SY2", "T2SY2", JdeDataType.String, 8),
        new JdeField("T2RT", "T2RT", JdeDataType.String, 4),
        new JdeField("T2RT1", "T2RT1", JdeDataType.String, 4),
        new JdeField("T2RT2", "T2RT2", JdeDataType.String, 4),
        new JdeField("T2GDC1", "T2GDC1", JdeDataType.String, 20),
        new JdeField("T2GDC2", "T2GDC2", JdeDataType.String, 20),
        new JdeField("T2GDC3", "T2GDC3", JdeDataType.String, 60),
        new JdeField("T2GDC4", "T2GDC4", JdeDataType.String, 60),
        new JdeField("T2GDC5", "T2GDC5", JdeDataType.String, 20),
        new JdeField("T2GDC6", "T2GDC6", JdeDataType.String, 20),
        new JdeField("T2GDC7", "T2GDC7", JdeDataType.String, 20),
        new JdeField("T2GDCA", "T2GDCA", JdeDataType.String, 20),
        new JdeField("T2GDC0", "T2GDC0", JdeDataType.String, 20),
        new JdeField("T2GDCC", "T2GDCC", JdeDataType.String, 20),
        new JdeField("T2GDC8", "T2GDC8", JdeDataType.String, 20),
        new JdeField("T2GDCD", "T2GDCD", JdeDataType.String, 20),
        new JdeField("T2AT1", "T2AT1", JdeDataType.String, 6),
        new JdeField("T2EAP", "T2EAP", JdeDataType.String, 20),
        new JdeField("T2PGM", "T2PGM", JdeDataType.String, 20),
        new JdeField("T2VERS", "T2VERS", JdeDataType.String, 20),
        new JdeField("T2USER", "T2USER", JdeDataType.String, 20),
        new JdeField("T2JOBN", "T2JOBN", JdeDataType.String, 20),
        new JdeField("T2UPMJ", "T2UPMJ", JdeDataType.Numeric),
        new JdeField("T2TDAY", "T2TDAY", JdeDataType.Numeric),
        new JdeField("T2GDCE", "T2GDCE", JdeDataType.String, 60),
        new JdeField("T2GDCF", "T2GDCF", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00091_0", "Primary Key on T2SDB, T2TYDT", new[] { "T2SDB", "T2TYDT" }, isUnique: true, isPrimaryKey: true)
    };
}
