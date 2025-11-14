using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D306 - .
/// </summary>
public class F80D306 : JdeTable
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
        /// HDOBNM.
        /// </summary>
        public const string HDOBNM = "HDOBNM";

        /// <summary>
        /// HDFMNM.
        /// </summary>
        public const string HDFMNM = "HDFMNM";

        /// <summary>
        /// HDIMFOW.
        /// </summary>
        public const string HDIMFOW = "HDIMFOW";

        /// <summary>
        /// HDVERS.
        /// </summary>
        public const string HDVERS = "HDVERS";

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
    public override string TableName => "F80D306";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDACTIID", "HDACTIID", JdeDataType.Numeric, null, true, true),
        new JdeField("HDOBNM", "HDOBNM", JdeDataType.String, 20),
        new JdeField("HDFMNM", "HDFMNM", JdeDataType.String, 20),
        new JdeField("HDIMFOW", "HDIMFOW", JdeDataType.String, 2),
        new JdeField("HDVERS", "HDVERS", JdeDataType.String, 20),
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
        new JdeIndex("F80D306_0", "Primary Key on HDACTIID", new[] { "HDACTIID" }, isUnique: true, isPrimaryKey: true)
    };
}
