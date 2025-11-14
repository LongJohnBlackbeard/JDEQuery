using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T034 - .
/// </summary>
public class F75T034 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VADOC.
        /// </summary>
        public const string VADOC = "VADOC";

        /// <summary>
        /// VADCT.
        /// </summary>
        public const string VADCT = "VADCT";

        /// <summary>
        /// VAKCO.
        /// </summary>
        public const string VAKCO = "VAKCO";

        /// <summary>
        /// VA75TEGNO1.
        /// </summary>
        public const string VA75TEGNO1 = "VA75TEGNO1";

        /// <summary>
        /// VA75TEGDT.
        /// </summary>
        public const string VA75TEGDT = "VA75TEGDT";

        /// <summary>
        /// VA75TGFC.
        /// </summary>
        public const string VA75TGFC = "VA75TGFC";

        /// <summary>
        /// VA75TAPTT.
        /// </summary>
        public const string VA75TAPTT = "VA75TAPTT";

        /// <summary>
        /// VAUSER.
        /// </summary>
        public const string VAUSER = "VAUSER";

        /// <summary>
        /// VAPID.
        /// </summary>
        public const string VAPID = "VAPID";

        /// <summary>
        /// VAJOBN.
        /// </summary>
        public const string VAJOBN = "VAJOBN";

        /// <summary>
        /// VAUPMJ.
        /// </summary>
        public const string VAUPMJ = "VAUPMJ";

        /// <summary>
        /// VAUPMT.
        /// </summary>
        public const string VAUPMT = "VAUPMT";

        /// <summary>
        /// VAYFUTDT.
        /// </summary>
        public const string VAYFUTDT = "VAYFUTDT";

        /// <summary>
        /// VAFFU4.
        /// </summary>
        public const string VAFFU4 = "VAFFU4";

        /// <summary>
        /// VAFUT3.
        /// </summary>
        public const string VAFUT3 = "VAFUT3";

        /// <summary>
        /// VAX2.
        /// </summary>
        public const string VAX2 = "VAX2";

        /// <summary>
        /// VAFUTCH1.
        /// </summary>
        public const string VAFUTCH1 = "VAFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75T034";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VADOC", "VADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VADCT", "VADCT", JdeDataType.String, 4, true, true),
        new JdeField("VAKCO", "VAKCO", JdeDataType.String, 10, true, true),
        new JdeField("VA75TEGNO1", "VA75TEGNO1", JdeDataType.String, 40),
        new JdeField("VA75TEGDT", "VA75TEGDT", JdeDataType.Numeric),
        new JdeField("VA75TGFC", "VA75TGFC", JdeDataType.String, 4),
        new JdeField("VA75TAPTT", "VA75TAPTT", JdeDataType.String, 60),
        new JdeField("VAUSER", "VAUSER", JdeDataType.String, 20),
        new JdeField("VAPID", "VAPID", JdeDataType.String, 20),
        new JdeField("VAJOBN", "VAJOBN", JdeDataType.String, 20),
        new JdeField("VAUPMJ", "VAUPMJ", JdeDataType.Numeric),
        new JdeField("VAUPMT", "VAUPMT", JdeDataType.Numeric),
        new JdeField("VAYFUTDT", "VAYFUTDT", JdeDataType.Numeric),
        new JdeField("VAFFU4", "VAFFU4", JdeDataType.Numeric),
        new JdeField("VAFUT3", "VAFUT3", JdeDataType.String, 60),
        new JdeField("VAX2", "VAX2", JdeDataType.String, 2),
        new JdeField("VAFUTCH1", "VAFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T034_0", "Primary Key on VADOC, VADCT, VAKCO", new[] { "VADOC", "VADCT", "VAKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
