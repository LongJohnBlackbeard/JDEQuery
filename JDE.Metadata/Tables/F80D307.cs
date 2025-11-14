using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D307 - .
/// </summary>
public class F80D307 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HDACTIID.
        /// </summary>
        public const string HDACTIID = "HDACTIID";

        /// <summary>
        /// HDMETRIC.
        /// </summary>
        public const string HDMETRIC = "HDMETRIC";

        /// <summary>
        /// HDURCD.
        /// </summary>
        public const string HDURCD = "HDURCD";

        /// <summary>
        /// HDURDT.
        /// </summary>
        public const string HDURDT = "HDURDT";

        /// <summary>
        /// HDURAT.
        /// </summary>
        public const string HDURAT = "HDURAT";

        /// <summary>
        /// HDURAB.
        /// </summary>
        public const string HDURAB = "HDURAB";

        /// <summary>
        /// HDURRF.
        /// </summary>
        public const string HDURRF = "HDURRF";

        /// <summary>
        /// HDUSER.
        /// </summary>
        public const string HDUSER = "HDUSER";

        /// <summary>
        /// HDMKEY.
        /// </summary>
        public const string HDMKEY = "HDMKEY";

        /// <summary>
        /// HDPID.
        /// </summary>
        public const string HDPID = "HDPID";

        /// <summary>
        /// HDUUPMJ.
        /// </summary>
        public const string HDUUPMJ = "HDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D307";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDACTIID", "HDACTIID", JdeDataType.Numeric, null, true, true),
        new JdeField("HDMETRIC", "HDMETRIC", JdeDataType.Numeric, null, true, true),
        new JdeField("HDURCD", "HDURCD", JdeDataType.String, 4),
        new JdeField("HDURDT", "HDURDT", JdeDataType.Numeric),
        new JdeField("HDURAT", "HDURAT", JdeDataType.Numeric),
        new JdeField("HDURAB", "HDURAB", JdeDataType.Numeric),
        new JdeField("HDURRF", "HDURRF", JdeDataType.String, 30),
        new JdeField("HDUSER", "HDUSER", JdeDataType.String, 20),
        new JdeField("HDMKEY", "HDMKEY", JdeDataType.String, 30),
        new JdeField("HDPID", "HDPID", JdeDataType.String, 20),
        new JdeField("HDUUPMJ", "HDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D307_0", "Primary Key on HDMETRIC, HDACTIID", new[] { "HDMETRIC", "HDACTIID" }, isUnique: true, isPrimaryKey: true)
    };
}
