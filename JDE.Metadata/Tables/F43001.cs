using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43001 - .
/// </summary>
public class F43001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SAUK01.
        /// </summary>
        public const string SAUK01 = "SAUK01";

        /// <summary>
        /// SAUKID.
        /// </summary>
        public const string SAUKID = "SAUKID";

        /// <summary>
        /// SAAN8.
        /// </summary>
        public const string SAAN8 = "SAAN8";

        /// <summary>
        /// SAANBY.
        /// </summary>
        public const string SAANBY = "SAANBY";

        /// <summary>
        /// SAANPL.
        /// </summary>
        public const string SAANPL = "SAANPL";

        /// <summary>
        /// SAKCOO.
        /// </summary>
        public const string SAKCOO = "SAKCOO";

        /// <summary>
        /// SADOCO.
        /// </summary>
        public const string SADOCO = "SADOCO";

        /// <summary>
        /// SADCTO.
        /// </summary>
        public const string SADCTO = "SADCTO";

        /// <summary>
        /// SALNID.
        /// </summary>
        public const string SALNID = "SALNID";

        /// <summary>
        /// SASFXO.
        /// </summary>
        public const string SASFXO = "SASFXO";

        /// <summary>
        /// SAITM.
        /// </summary>
        public const string SAITM = "SAITM";

        /// <summary>
        /// SAAITM.
        /// </summary>
        public const string SAAITM = "SAAITM";

        /// <summary>
        /// SALITM.
        /// </summary>
        public const string SALITM = "SALITM";

        /// <summary>
        /// SATRTE.
        /// </summary>
        public const string SATRTE = "SATRTE";

        /// <summary>
        /// SATPUR.
        /// </summary>
        public const string SATPUR = "SATPUR";

        /// <summary>
        /// SAXTND.
        /// </summary>
        public const string SAXTND = "SAXTND";

        /// <summary>
        /// SAUORG.
        /// </summary>
        public const string SAUORG = "SAUORG";

        /// <summary>
        /// SASOQS.
        /// </summary>
        public const string SASOQS = "SASOQS";

        /// <summary>
        /// SATRUM.
        /// </summary>
        public const string SATRUM = "SATRUM";

        /// <summary>
        /// SAPRRC.
        /// </summary>
        public const string SAPRRC = "SAPRRC";

        /// <summary>
        /// SAAEXP.
        /// </summary>
        public const string SAAEXP = "SAAEXP";

        /// <summary>
        /// SANXTR.
        /// </summary>
        public const string SANXTR = "SANXTR";

        /// <summary>
        /// SAVR01.
        /// </summary>
        public const string SAVR01 = "SAVR01";

        /// <summary>
        /// SAPDDJ.
        /// </summary>
        public const string SAPDDJ = "SAPDDJ";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";

        /// <summary>
        /// SATDAY.
        /// </summary>
        public const string SATDAY = "SATDAY";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SAUK01", "SAUK01", JdeDataType.Numeric, null, true, true),
        new JdeField("SAUKID", "SAUKID", JdeDataType.Numeric),
        new JdeField("SAAN8", "SAAN8", JdeDataType.Numeric),
        new JdeField("SAANBY", "SAANBY", JdeDataType.Numeric),
        new JdeField("SAANPL", "SAANPL", JdeDataType.Numeric),
        new JdeField("SAKCOO", "SAKCOO", JdeDataType.String, 10),
        new JdeField("SADOCO", "SADOCO", JdeDataType.Numeric),
        new JdeField("SADCTO", "SADCTO", JdeDataType.String, 4),
        new JdeField("SALNID", "SALNID", JdeDataType.Numeric),
        new JdeField("SASFXO", "SASFXO", JdeDataType.String, 6),
        new JdeField("SAITM", "SAITM", JdeDataType.Numeric),
        new JdeField("SAAITM", "SAAITM", JdeDataType.String, 50),
        new JdeField("SALITM", "SALITM", JdeDataType.String, 50),
        new JdeField("SATRTE", "SATRTE", JdeDataType.String, 2),
        new JdeField("SATPUR", "SATPUR", JdeDataType.String, 4),
        new JdeField("SAXTND", "SAXTND", JdeDataType.Numeric),
        new JdeField("SAUORG", "SAUORG", JdeDataType.Numeric),
        new JdeField("SASOQS", "SASOQS", JdeDataType.Numeric),
        new JdeField("SATRUM", "SATRUM", JdeDataType.String, 4),
        new JdeField("SAPRRC", "SAPRRC", JdeDataType.Numeric),
        new JdeField("SAAEXP", "SAAEXP", JdeDataType.Numeric),
        new JdeField("SANXTR", "SANXTR", JdeDataType.String, 6),
        new JdeField("SAVR01", "SAVR01", JdeDataType.String, 50),
        new JdeField("SAPDDJ", "SAPDDJ", JdeDataType.Numeric),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20),
        new JdeField("SATDAY", "SATDAY", JdeDataType.Numeric),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43001_0", "Primary Key on SAUK01", new[] { "SAUK01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43001_2", "Index on SAUKID, SAANPL", new[] { "SAUKID", "SAANPL" }),
        new JdeIndex("F43001_3", "Index on SAUKID, SAANBY", new[] { "SAUKID", "SAANBY" }),
        new JdeIndex("F43001_4", "Index on SAANPL, SAITM, SADOCO", new[] { "SAANPL", "SAITM", "SADOCO" }),
        new JdeIndex("F43001_5", "Index on SAANPL, SAAN8, SADOCO", new[] { "SAANPL", "SAAN8", "SADOCO" }),
        new JdeIndex("F43001_6", "Index on SAANBY, SAITM, SADOCO", new[] { "SAANBY", "SAITM", "SADOCO" }),
        new JdeIndex("F43001_7", "Index on SAANBY, SAAN8, SADOCO", new[] { "SAANBY", "SAAN8", "SADOCO" })
    };
}
