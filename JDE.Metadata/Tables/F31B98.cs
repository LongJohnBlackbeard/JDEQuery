using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B98 - .
/// </summary>
public class F31B98 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BMWVID.
        /// </summary>
        public const string BMWVID = "BMWVID";

        /// <summary>
        /// BMWVNUM.
        /// </summary>
        public const string BMWVNUM = "BMWVNUM";

        /// <summary>
        /// BMEURID.
        /// </summary>
        public const string BMEURID = "BMEURID";

        /// <summary>
        /// BMWOD.
        /// </summary>
        public const string BMWOD = "BMWOD";

        /// <summary>
        /// BMLOCN.
        /// </summary>
        public const string BMLOCN = "BMLOCN";

        /// <summary>
        /// BMLOTN.
        /// </summary>
        public const string BMLOTN = "BMLOTN";

        /// <summary>
        /// BMWBOTREF.
        /// </summary>
        public const string BMWBOTREF = "BMWBOTREF";

        /// <summary>
        /// BMWQTYPRO.
        /// </summary>
        public const string BMWQTYPRO = "BMWQTYPRO";

        /// <summary>
        /// BMPROUOM.
        /// </summary>
        public const string BMPROUOM = "BMPROUOM";

        /// <summary>
        /// BMWQTYSMP.
        /// </summary>
        public const string BMWQTYSMP = "BMWQTYSMP";

        /// <summary>
        /// BMSAMUOM.
        /// </summary>
        public const string BMSAMUOM = "BMSAMUOM";

        /// <summary>
        /// BMWQTYBKN.
        /// </summary>
        public const string BMWQTYBKN = "BMWQTYBKN";

        /// <summary>
        /// BMBROUOM.
        /// </summary>
        public const string BMBROUOM = "BMBROUOM";

        /// <summary>
        /// BMWQTY4.
        /// </summary>
        public const string BMWQTY4 = "BMWQTY4";

        /// <summary>
        /// BMQTY4UOM.
        /// </summary>
        public const string BMQTY4UOM = "BMQTY4UOM";

        /// <summary>
        /// BMWQTY5.
        /// </summary>
        public const string BMWQTY5 = "BMWQTY5";

        /// <summary>
        /// BMQTY5UOM.
        /// </summary>
        public const string BMQTY5UOM = "BMQTY5UOM";

        /// <summary>
        /// BMPROUOMPD.
        /// </summary>
        public const string BMPROUOMPD = "BMPROUOMPD";

        /// <summary>
        /// BMPROUOMSM.
        /// </summary>
        public const string BMPROUOMSM = "BMPROUOMSM";

        /// <summary>
        /// BMPROUOMBR.
        /// </summary>
        public const string BMPROUOMBR = "BMPROUOMBR";

        /// <summary>
        /// BMPROUOMQ4.
        /// </summary>
        public const string BMPROUOMQ4 = "BMPROUOMQ4";

        /// <summary>
        /// BMPROUOMQ5.
        /// </summary>
        public const string BMPROUOMQ5 = "BMPROUOMQ5";

        /// <summary>
        /// BMURDT.
        /// </summary>
        public const string BMURDT = "BMURDT";

        /// <summary>
        /// BMURRF.
        /// </summary>
        public const string BMURRF = "BMURRF";

        /// <summary>
        /// BMURAT.
        /// </summary>
        public const string BMURAT = "BMURAT";

        /// <summary>
        /// BMURAB.
        /// </summary>
        public const string BMURAB = "BMURAB";

        /// <summary>
        /// BMUSER.
        /// </summary>
        public const string BMUSER = "BMUSER";

        /// <summary>
        /// BMPID.
        /// </summary>
        public const string BMPID = "BMPID";

        /// <summary>
        /// BMJOBN.
        /// </summary>
        public const string BMJOBN = "BMJOBN";

        /// <summary>
        /// BMUPMJ.
        /// </summary>
        public const string BMUPMJ = "BMUPMJ";

        /// <summary>
        /// BMTDAY.
        /// </summary>
        public const string BMTDAY = "BMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B98";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BMWVID", "BMWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("BMWVNUM", "BMWVNUM", JdeDataType.String, 60),
        new JdeField("BMEURID", "BMEURID", JdeDataType.Numeric),
        new JdeField("BMWOD", "BMWOD", JdeDataType.Numeric),
        new JdeField("BMLOCN", "BMLOCN", JdeDataType.String, 40),
        new JdeField("BMLOTN", "BMLOTN", JdeDataType.String, 60),
        new JdeField("BMWBOTREF", "BMWBOTREF", JdeDataType.String, 60),
        new JdeField("BMWQTYPRO", "BMWQTYPRO", JdeDataType.Numeric),
        new JdeField("BMPROUOM", "BMPROUOM", JdeDataType.String, 4),
        new JdeField("BMWQTYSMP", "BMWQTYSMP", JdeDataType.Numeric),
        new JdeField("BMSAMUOM", "BMSAMUOM", JdeDataType.String, 4),
        new JdeField("BMWQTYBKN", "BMWQTYBKN", JdeDataType.Numeric),
        new JdeField("BMBROUOM", "BMBROUOM", JdeDataType.String, 4),
        new JdeField("BMWQTY4", "BMWQTY4", JdeDataType.Numeric),
        new JdeField("BMQTY4UOM", "BMQTY4UOM", JdeDataType.String, 4),
        new JdeField("BMWQTY5", "BMWQTY5", JdeDataType.Numeric),
        new JdeField("BMQTY5UOM", "BMQTY5UOM", JdeDataType.String, 4),
        new JdeField("BMPROUOMPD", "BMPROUOMPD", JdeDataType.String, 4),
        new JdeField("BMPROUOMSM", "BMPROUOMSM", JdeDataType.String, 4),
        new JdeField("BMPROUOMBR", "BMPROUOMBR", JdeDataType.String, 4),
        new JdeField("BMPROUOMQ4", "BMPROUOMQ4", JdeDataType.String, 4),
        new JdeField("BMPROUOMQ5", "BMPROUOMQ5", JdeDataType.String, 4),
        new JdeField("BMURDT", "BMURDT", JdeDataType.Numeric),
        new JdeField("BMURRF", "BMURRF", JdeDataType.String, 30),
        new JdeField("BMURAT", "BMURAT", JdeDataType.Numeric),
        new JdeField("BMURAB", "BMURAB", JdeDataType.Numeric),
        new JdeField("BMUSER", "BMUSER", JdeDataType.String, 20),
        new JdeField("BMPID", "BMPID", JdeDataType.String, 20),
        new JdeField("BMJOBN", "BMJOBN", JdeDataType.String, 20),
        new JdeField("BMUPMJ", "BMUPMJ", JdeDataType.Numeric),
        new JdeField("BMTDAY", "BMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B98_0", "Primary Key on BMWVID", new[] { "BMWVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B98_2", "Index on BMWVNUM", new[] { "BMWVNUM" })
    };
}
