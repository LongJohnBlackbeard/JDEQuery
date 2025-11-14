using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42I20 - .
/// </summary>
public class F42I20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OICYNUM.
        /// </summary>
        public const string OICYNUM = "OICYNUM";

        /// <summary>
        /// OIDSC1.
        /// </summary>
        public const string OIDSC1 = "OIDSC1";

        /// <summary>
        /// OICYCST.
        /// </summary>
        public const string OICYCST = "OICYCST";

        /// <summary>
        /// OICSDJ.
        /// </summary>
        public const string OICSDJ = "OICSDJ";

        /// <summary>
        /// OICYLOC.
        /// </summary>
        public const string OICYLOC = "OICYLOC";

        /// <summary>
        /// OICYAGR.
        /// </summary>
        public const string OICYAGR = "OICYAGR";

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

        /// <summary>
        /// OISNTJ.
        /// </summary>
        public const string OISNTJ = "OISNTJ";

        /// <summary>
        /// OIFUCHAR34.
        /// </summary>
        public const string OIFUCHAR34 = "OIFUCHAR34";

        /// <summary>
        /// OIFUCHAR35.
        /// </summary>
        public const string OIFUCHAR35 = "OIFUCHAR35";

        /// <summary>
        /// OIFUCHAR36.
        /// </summary>
        public const string OIFUCHAR36 = "OIFUCHAR36";

        /// <summary>
        /// OIFUNUM34.
        /// </summary>
        public const string OIFUNUM34 = "OIFUNUM34";

        /// <summary>
        /// OIFUNUM35.
        /// </summary>
        public const string OIFUNUM35 = "OIFUNUM35";

        /// <summary>
        /// OIFUNUM36.
        /// </summary>
        public const string OIFUNUM36 = "OIFUNUM36";

        /// <summary>
        /// OIFUTSTR34.
        /// </summary>
        public const string OIFUTSTR34 = "OIFUTSTR34";

        /// <summary>
        /// OIFUTSTR35.
        /// </summary>
        public const string OIFUTSTR35 = "OIFUTSTR35";

        /// <summary>
        /// OIFUTSTR36.
        /// </summary>
        public const string OIFUTSTR36 = "OIFUTSTR36";

        /// <summary>
        /// OIFUDT54.
        /// </summary>
        public const string OIFUDT54 = "OIFUDT54";

        /// <summary>
        /// OIFUDT55.
        /// </summary>
        public const string OIFUDT55 = "OIFUDT55";

        /// <summary>
        /// OIFUDT56.
        /// </summary>
        public const string OIFUDT56 = "OIFUDT56";

        /// <summary>
        /// OIURAT.
        /// </summary>
        public const string OIURAT = "OIURAT";

        /// <summary>
        /// OIURCD.
        /// </summary>
        public const string OIURCD = "OIURCD";

        /// <summary>
        /// OIURDT.
        /// </summary>
        public const string OIURDT = "OIURDT";

        /// <summary>
        /// OIURAB.
        /// </summary>
        public const string OIURAB = "OIURAB";

        /// <summary>
        /// OIURRF.
        /// </summary>
        public const string OIURRF = "OIURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F42I20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OICYNUM", "OICYNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDSC1", "OIDSC1", JdeDataType.String, 60),
        new JdeField("OICYCST", "OICYCST", JdeDataType.String, 4),
        new JdeField("OICSDJ", "OICSDJ", JdeDataType.Numeric),
        new JdeField("OICYLOC", "OICYLOC", JdeDataType.Numeric),
        new JdeField("OICYAGR", "OICYAGR", JdeDataType.Numeric),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OITDAY", "OITDAY", JdeDataType.Numeric),
        new JdeField("OISNTJ", "OISNTJ", JdeDataType.Numeric),
        new JdeField("OIFUCHAR34", "OIFUCHAR34", JdeDataType.String, 2),
        new JdeField("OIFUCHAR35", "OIFUCHAR35", JdeDataType.String, 2),
        new JdeField("OIFUCHAR36", "OIFUCHAR36", JdeDataType.String, 2),
        new JdeField("OIFUNUM34", "OIFUNUM34", JdeDataType.Numeric),
        new JdeField("OIFUNUM35", "OIFUNUM35", JdeDataType.Numeric),
        new JdeField("OIFUNUM36", "OIFUNUM36", JdeDataType.Numeric),
        new JdeField("OIFUTSTR34", "OIFUTSTR34", JdeDataType.String, 100),
        new JdeField("OIFUTSTR35", "OIFUTSTR35", JdeDataType.String, 100),
        new JdeField("OIFUTSTR36", "OIFUTSTR36", JdeDataType.String, 100),
        new JdeField("OIFUDT54", "OIFUDT54", JdeDataType.Numeric),
        new JdeField("OIFUDT55", "OIFUDT55", JdeDataType.Numeric),
        new JdeField("OIFUDT56", "OIFUDT56", JdeDataType.Numeric),
        new JdeField("OIURAT", "OIURAT", JdeDataType.Numeric),
        new JdeField("OIURCD", "OIURCD", JdeDataType.String, 4),
        new JdeField("OIURDT", "OIURDT", JdeDataType.Numeric),
        new JdeField("OIURAB", "OIURAB", JdeDataType.Numeric),
        new JdeField("OIURRF", "OIURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42I20_0", "Primary Key on OICYNUM", new[] { "OICYNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
