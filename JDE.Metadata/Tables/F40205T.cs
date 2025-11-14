using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40205T - .
/// </summary>
public class F40205T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OILNTY.
        /// </summary>
        public const string OILNTY = "OILNTY";

        /// <summary>
        /// OIOILNTY.
        /// </summary>
        public const string OIOILNTY = "OIOILNTY";

        /// <summary>
        /// OIFUTCHAR6.
        /// </summary>
        public const string OIFUTCHAR6 = "OIFUTCHAR6";

        /// <summary>
        /// OIFUTCHAR7.
        /// </summary>
        public const string OIFUTCHAR7 = "OIFUTCHAR7";

        /// <summary>
        /// OIFUTCHAR8.
        /// </summary>
        public const string OIFUTCHAR8 = "OIFUTCHAR8";

        /// <summary>
        /// OIFUNUM4.
        /// </summary>
        public const string OIFUNUM4 = "OIFUNUM4";

        /// <summary>
        /// OIFUNUM5.
        /// </summary>
        public const string OIFUNUM5 = "OIFUNUM5";

        /// <summary>
        /// OIFUNUM6.
        /// </summary>
        public const string OIFUNUM6 = "OIFUNUM6";

        /// <summary>
        /// OIFUTSTR4.
        /// </summary>
        public const string OIFUTSTR4 = "OIFUTSTR4";

        /// <summary>
        /// OIFUTSTR5.
        /// </summary>
        public const string OIFUTSTR5 = "OIFUTSTR5";

        /// <summary>
        /// OIFUTSTR6.
        /// </summary>
        public const string OIFUTSTR6 = "OIFUTSTR6";

        /// <summary>
        /// OIFUDT2.
        /// </summary>
        public const string OIFUDT2 = "OIFUDT2";

        /// <summary>
        /// OIFUDT20.
        /// </summary>
        public const string OIFUDT20 = "OIFUDT20";

        /// <summary>
        /// OIFUDT30.
        /// </summary>
        public const string OIFUDT30 = "OIFUDT30";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIJOBN.
        /// </summary>
        public const string OIJOBN = "OIJOBN";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

        /// <summary>
        /// OITDAY.
        /// </summary>
        public const string OITDAY = "OITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40205T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OILNTY", "OILNTY", JdeDataType.String, 4, true, true),
        new JdeField("OIOILNTY", "OIOILNTY", JdeDataType.String, 2),
        new JdeField("OIFUTCHAR6", "OIFUTCHAR6", JdeDataType.String, 2),
        new JdeField("OIFUTCHAR7", "OIFUTCHAR7", JdeDataType.String, 2),
        new JdeField("OIFUTCHAR8", "OIFUTCHAR8", JdeDataType.String, 2),
        new JdeField("OIFUNUM4", "OIFUNUM4", JdeDataType.Numeric),
        new JdeField("OIFUNUM5", "OIFUNUM5", JdeDataType.Numeric),
        new JdeField("OIFUNUM6", "OIFUNUM6", JdeDataType.Numeric),
        new JdeField("OIFUTSTR4", "OIFUTSTR4", JdeDataType.String, 100),
        new JdeField("OIFUTSTR5", "OIFUTSTR5", JdeDataType.String, 100),
        new JdeField("OIFUTSTR6", "OIFUTSTR6", JdeDataType.String, 100),
        new JdeField("OIFUDT2", "OIFUDT2", JdeDataType.Numeric),
        new JdeField("OIFUDT20", "OIFUDT20", JdeDataType.Numeric),
        new JdeField("OIFUDT30", "OIFUDT30", JdeDataType.Numeric),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OITDAY", "OITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40205T_0", "Primary Key on OILNTY", new[] { "OILNTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40205T_2", "Index on OIOILNTY", new[] { "OIOILNTY" })
    };
}
