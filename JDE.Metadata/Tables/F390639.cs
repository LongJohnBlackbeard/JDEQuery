using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F390639 - .
/// </summary>
public class F390639 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SUCRCD.
        /// </summary>
        public const string SUCRCD = "SUCRCD";

        /// <summary>
        /// SUSVYR.
        /// </summary>
        public const string SUSVYR = "SUSVYR";

        /// <summary>
        /// SUPNC.
        /// </summary>
        public const string SUPNC = "SUPNC";

        /// <summary>
        /// SUITPL.
        /// </summary>
        public const string SUITPL = "SUITPL";

        /// <summary>
        /// SUITM.
        /// </summary>
        public const string SUITM = "SUITM";

        /// <summary>
        /// SUCO.
        /// </summary>
        public const string SUCO = "SUCO";

        /// <summary>
        /// SUMCU.
        /// </summary>
        public const string SUMCU = "SUMCU";

        /// <summary>
        /// SUQRCT.
        /// </summary>
        public const string SUQRCT = "SUQRCT";

        /// <summary>
        /// SUUOM.
        /// </summary>
        public const string SUUOM = "SUUOM";

        /// <summary>
        /// SUOPQT.
        /// </summary>
        public const string SUOPQT = "SUOPQT";

        /// <summary>
        /// SUOPAM.
        /// </summary>
        public const string SUOPAM = "SUOPAM";

        /// <summary>
        /// SUPIQT.
        /// </summary>
        public const string SUPIQT = "SUPIQT";

        /// <summary>
        /// SUPIAM.
        /// </summary>
        public const string SUPIAM = "SUPIAM";

        /// <summary>
        /// SUPOQT.
        /// </summary>
        public const string SUPOQT = "SUPOQT";

        /// <summary>
        /// SUPOAM.
        /// </summary>
        public const string SUPOAM = "SUPOAM";

        /// <summary>
        /// SUCLQT.
        /// </summary>
        public const string SUCLQT = "SUCLQT";

        /// <summary>
        /// SUCLAM.
        /// </summary>
        public const string SUCLAM = "SUCLAM";

        /// <summary>
        /// SUADQT.
        /// </summary>
        public const string SUADQT = "SUADQT";

        /// <summary>
        /// SUADAM.
        /// </summary>
        public const string SUADAM = "SUADAM";

        /// <summary>
        /// SUSVQT.
        /// </summary>
        public const string SUSVQT = "SUSVQT";

        /// <summary>
        /// SUSVUM.
        /// </summary>
        public const string SUSVUM = "SUSVUM";

        /// <summary>
        /// SUSVDT.
        /// </summary>
        public const string SUSVDT = "SUSVDT";

        /// <summary>
        /// SUSVFU.
        /// </summary>
        public const string SUSVFU = "SUSVFU";

        /// <summary>
        /// SUSVF1.
        /// </summary>
        public const string SUSVF1 = "SUSVF1";

        /// <summary>
        /// SUSVF2.
        /// </summary>
        public const string SUSVF2 = "SUSVF2";

        /// <summary>
        /// SUSVF3.
        /// </summary>
        public const string SUSVF3 = "SUSVF3";

        /// <summary>
        /// SUSVF4.
        /// </summary>
        public const string SUSVF4 = "SUSVF4";

        /// <summary>
        /// SUSVF5.
        /// </summary>
        public const string SUSVF5 = "SUSVF5";

        /// <summary>
        /// SUUSER.
        /// </summary>
        public const string SUUSER = "SUUSER";

        /// <summary>
        /// SUPID.
        /// </summary>
        public const string SUPID = "SUPID";

        /// <summary>
        /// SUJOBN.
        /// </summary>
        public const string SUJOBN = "SUJOBN";

        /// <summary>
        /// SUUPMJ.
        /// </summary>
        public const string SUUPMJ = "SUUPMJ";

        /// <summary>
        /// SUTDAY.
        /// </summary>
        public const string SUTDAY = "SUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F390639";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SUCRCD", "SUCRCD", JdeDataType.String, 6, true, true),
        new JdeField("SUSVYR", "SUSVYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SUPNC", "SUPNC", JdeDataType.Numeric, null, true, true),
        new JdeField("SUITPL", "SUITPL", JdeDataType.String, 20, true, true),
        new JdeField("SUITM", "SUITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SUCO", "SUCO", JdeDataType.String, 10, true, true),
        new JdeField("SUMCU", "SUMCU", JdeDataType.String, 24, true, true),
        new JdeField("SUQRCT", "SUQRCT", JdeDataType.String, 2, true, true),
        new JdeField("SUUOM", "SUUOM", JdeDataType.String, 4),
        new JdeField("SUOPQT", "SUOPQT", JdeDataType.Numeric),
        new JdeField("SUOPAM", "SUOPAM", JdeDataType.Numeric),
        new JdeField("SUPIQT", "SUPIQT", JdeDataType.Numeric),
        new JdeField("SUPIAM", "SUPIAM", JdeDataType.Numeric),
        new JdeField("SUPOQT", "SUPOQT", JdeDataType.Numeric),
        new JdeField("SUPOAM", "SUPOAM", JdeDataType.Numeric),
        new JdeField("SUCLQT", "SUCLQT", JdeDataType.Numeric),
        new JdeField("SUCLAM", "SUCLAM", JdeDataType.Numeric),
        new JdeField("SUADQT", "SUADQT", JdeDataType.Numeric),
        new JdeField("SUADAM", "SUADAM", JdeDataType.Numeric),
        new JdeField("SUSVQT", "SUSVQT", JdeDataType.Numeric),
        new JdeField("SUSVUM", "SUSVUM", JdeDataType.String, 4),
        new JdeField("SUSVDT", "SUSVDT", JdeDataType.Numeric),
        new JdeField("SUSVFU", "SUSVFU", JdeDataType.String, 4),
        new JdeField("SUSVF1", "SUSVF1", JdeDataType.String, 2),
        new JdeField("SUSVF2", "SUSVF2", JdeDataType.String, 2),
        new JdeField("SUSVF3", "SUSVF3", JdeDataType.String, 2),
        new JdeField("SUSVF4", "SUSVF4", JdeDataType.String, 2),
        new JdeField("SUSVF5", "SUSVF5", JdeDataType.String, 2),
        new JdeField("SUUSER", "SUUSER", JdeDataType.String, 20),
        new JdeField("SUPID", "SUPID", JdeDataType.String, 20),
        new JdeField("SUJOBN", "SUJOBN", JdeDataType.String, 20),
        new JdeField("SUUPMJ", "SUUPMJ", JdeDataType.Numeric),
        new JdeField("SUTDAY", "SUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F390639_0", "Primary Key on SUCRCD, SUSVYR, SUPNC, SUITPL, SUITM, SUCO, SUMCU, SUQRCT", new[] { "SUCRCD", "SUSVYR", "SUPNC", "SUITPL", "SUITM", "SUCO", "SUMCU", "SUQRCT" }, isUnique: true, isPrimaryKey: true)
    };
}
