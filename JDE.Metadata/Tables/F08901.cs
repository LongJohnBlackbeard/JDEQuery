using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08901 - .
/// </summary>
public class F08901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HUAN8.
        /// </summary>
        public const string HUAN8 = "HUAN8";

        /// <summary>
        /// HUALPH.
        /// </summary>
        public const string HUALPH = "HUALPH";

        /// <summary>
        /// HUSSN.
        /// </summary>
        public const string HUSSN = "HUSSN";

        /// <summary>
        /// HUDOB.
        /// </summary>
        public const string HUDOB = "HUDOB";

        /// <summary>
        /// HUDTDH.
        /// </summary>
        public const string HUDTDH = "HUDTDH";

        /// <summary>
        /// HUSEX.
        /// </summary>
        public const string HUSEX = "HUSEX";

        /// <summary>
        /// HUHSG.
        /// </summary>
        public const string HUHSG = "HUHSG";

        /// <summary>
        /// HUFTS.
        /// </summary>
        public const string HUFTS = "HUFTS";

        /// <summary>
        /// HUSCA.
        /// </summary>
        public const string HUSCA = "HUSCA";

        /// <summary>
        /// HUEMP.
        /// </summary>
        public const string HUEMP = "HUEMP";

        /// <summary>
        /// HUPU01.
        /// </summary>
        public const string HUPU01 = "HUPU01";

        /// <summary>
        /// HUPU02.
        /// </summary>
        public const string HUPU02 = "HUPU02";

        /// <summary>
        /// HUPU03.
        /// </summary>
        public const string HUPU03 = "HUPU03";

        /// <summary>
        /// HUPU04.
        /// </summary>
        public const string HUPU04 = "HUPU04";

        /// <summary>
        /// HUPU05.
        /// </summary>
        public const string HUPU05 = "HUPU05";

        /// <summary>
        /// HUPU06.
        /// </summary>
        public const string HUPU06 = "HUPU06";

        /// <summary>
        /// HUPU07.
        /// </summary>
        public const string HUPU07 = "HUPU07";

        /// <summary>
        /// HUPU08.
        /// </summary>
        public const string HUPU08 = "HUPU08";

        /// <summary>
        /// HUPU09.
        /// </summary>
        public const string HUPU09 = "HUPU09";

        /// <summary>
        /// HUPU10.
        /// </summary>
        public const string HUPU10 = "HUPU10";

        /// <summary>
        /// HUUSER.
        /// </summary>
        public const string HUUSER = "HUUSER";

        /// <summary>
        /// HUPID.
        /// </summary>
        public const string HUPID = "HUPID";

        /// <summary>
        /// HUJOBN.
        /// </summary>
        public const string HUJOBN = "HUJOBN";

        /// <summary>
        /// HUUPMJ.
        /// </summary>
        public const string HUUPMJ = "HUUPMJ";

        /// <summary>
        /// HUILET.
        /// </summary>
        public const string HUILET = "HUILET";

        /// <summary>
        /// HUNDT.
        /// </summary>
        public const string HUNDT = "HUNDT";

        /// <summary>
        /// HUDSBF.
        /// </summary>
        public const string HUDSBF = "HUDSBF";

        /// <summary>
        /// HUDSBD.
        /// </summary>
        public const string HUDSBD = "HUDSBD";

        /// <summary>
        /// HUMCDT.
        /// </summary>
        public const string HUMCDT = "HUMCDT";
    }

    /// <inheritdoc />
    public override string TableName => "F08901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HUAN8", "HUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HUALPH", "HUALPH", JdeDataType.String, 80),
        new JdeField("HUSSN", "HUSSN", JdeDataType.String, 40),
        new JdeField("HUDOB", "HUDOB", JdeDataType.Numeric),
        new JdeField("HUDTDH", "HUDTDH", JdeDataType.Numeric),
        new JdeField("HUSEX", "HUSEX", JdeDataType.String, 2),
        new JdeField("HUHSG", "HUHSG", JdeDataType.String, 2),
        new JdeField("HUFTS", "HUFTS", JdeDataType.String, 2),
        new JdeField("HUSCA", "HUSCA", JdeDataType.String, 60),
        new JdeField("HUEMP", "HUEMP", JdeDataType.String, 2),
        new JdeField("HUPU01", "HUPU01", JdeDataType.String, 6),
        new JdeField("HUPU02", "HUPU02", JdeDataType.String, 6),
        new JdeField("HUPU03", "HUPU03", JdeDataType.String, 6),
        new JdeField("HUPU04", "HUPU04", JdeDataType.String, 6),
        new JdeField("HUPU05", "HUPU05", JdeDataType.String, 6),
        new JdeField("HUPU06", "HUPU06", JdeDataType.String, 6),
        new JdeField("HUPU07", "HUPU07", JdeDataType.String, 6),
        new JdeField("HUPU08", "HUPU08", JdeDataType.String, 6),
        new JdeField("HUPU09", "HUPU09", JdeDataType.String, 6),
        new JdeField("HUPU10", "HUPU10", JdeDataType.String, 6),
        new JdeField("HUUSER", "HUUSER", JdeDataType.String, 20),
        new JdeField("HUPID", "HUPID", JdeDataType.String, 20),
        new JdeField("HUJOBN", "HUJOBN", JdeDataType.String, 20),
        new JdeField("HUUPMJ", "HUUPMJ", JdeDataType.Numeric),
        new JdeField("HUILET", "HUILET", JdeDataType.String, 2),
        new JdeField("HUNDT", "HUNDT", JdeDataType.Numeric),
        new JdeField("HUDSBF", "HUDSBF", JdeDataType.String, 2),
        new JdeField("HUDSBD", "HUDSBD", JdeDataType.Numeric),
        new JdeField("HUMCDT", "HUMCDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08901_0", "Primary Key on HUAN8", new[] { "HUAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08901_2", "Index on HUSSN", new[] { "HUSSN" })
    };
}
