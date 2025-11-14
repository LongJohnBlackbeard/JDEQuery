using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B5120 - .
/// </summary>
public class F31B5120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPUKID.
        /// </summary>
        public const string WPUKID = "WPUKID";

        /// <summary>
        /// WPMMCU.
        /// </summary>
        public const string WPMMCU = "WPMMCU";

        /// <summary>
        /// WPPRTNO.
        /// </summary>
        public const string WPPRTNO = "WPPRTNO";

        /// <summary>
        /// WPSCTN.
        /// </summary>
        public const string WPSCTN = "WPSCTN";

        /// <summary>
        /// WP702LNR.
        /// </summary>
        public const string WP702LNR = "WP702LNR";

        /// <summary>
        /// WPWDSC2.
        /// </summary>
        public const string WPWDSC2 = "WPWDSC2";

        /// <summary>
        /// WPAQNTY.
        /// </summary>
        public const string WPAQNTY = "WPAQNTY";

        /// <summary>
        /// WPBQNTY.
        /// </summary>
        public const string WPBQNTY = "WPBQNTY";

        /// <summary>
        /// WPCQNTY.
        /// </summary>
        public const string WPCQNTY = "WPCQNTY";

        /// <summary>
        /// WPDQNTY.
        /// </summary>
        public const string WPDQNTY = "WPDQNTY";

        /// <summary>
        /// WPEQNTY.
        /// </summary>
        public const string WPEQNTY = "WPEQNTY";

        /// <summary>
        /// WPE1QNTY.
        /// </summary>
        public const string WPE1QNTY = "WPE1QNTY";

        /// <summary>
        /// WPFQNTY.
        /// </summary>
        public const string WPFQNTY = "WPFQNTY";

        /// <summary>
        /// WPGQNTY.
        /// </summary>
        public const string WPGQNTY = "WPGQNTY";

        /// <summary>
        /// WPHRQNTY.
        /// </summary>
        public const string WPHRQNTY = "WPHRQNTY";

        /// <summary>
        /// WPIQNTY.
        /// </summary>
        public const string WPIQNTY = "WPIQNTY";

        /// <summary>
        /// WPJQNTY.
        /// </summary>
        public const string WPJQNTY = "WPJQNTY";

        /// <summary>
        /// WPKQNTY.
        /// </summary>
        public const string WPKQNTY = "WPKQNTY";

        /// <summary>
        /// WPLRQNTY.
        /// </summary>
        public const string WPLRQNTY = "WPLRQNTY";

        /// <summary>
        /// WPWPRSD.
        /// </summary>
        public const string WPWPRSD = "WPWPRSD";

        /// <summary>
        /// WPWPRED.
        /// </summary>
        public const string WPWPRED = "WPWPRED";

        /// <summary>
        /// WPUSER.
        /// </summary>
        public const string WPUSER = "WPUSER";

        /// <summary>
        /// WPPID.
        /// </summary>
        public const string WPPID = "WPPID";

        /// <summary>
        /// WPJOBN.
        /// </summary>
        public const string WPJOBN = "WPJOBN";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPTDAY.
        /// </summary>
        public const string WPTDAY = "WPTDAY";

        /// <summary>
        /// WPURCD.
        /// </summary>
        public const string WPURCD = "WPURCD";

        /// <summary>
        /// WPURAB.
        /// </summary>
        public const string WPURAB = "WPURAB";

        /// <summary>
        /// WPURAT.
        /// </summary>
        public const string WPURAT = "WPURAT";

        /// <summary>
        /// WPURDT.
        /// </summary>
        public const string WPURDT = "WPURDT";

        /// <summary>
        /// WPURRF.
        /// </summary>
        public const string WPURRF = "WPURRF";

        /// <summary>
        /// WPFFU3.
        /// </summary>
        public const string WPFFU3 = "WPFFU3";

        /// <summary>
        /// WPFFU5.
        /// </summary>
        public const string WPFFU5 = "WPFFU5";

        /// <summary>
        /// WPFFU6.
        /// </summary>
        public const string WPFFU6 = "WPFFU6";

        /// <summary>
        /// WPFFU4.
        /// </summary>
        public const string WPFFU4 = "WPFFU4";

        /// <summary>
        /// WPFFU7.
        /// </summary>
        public const string WPFFU7 = "WPFFU7";

        /// <summary>
        /// WPFFU8.
        /// </summary>
        public const string WPFFU8 = "WPFFU8";

        /// <summary>
        /// WPTFUDJ.
        /// </summary>
        public const string WPTFUDJ = "WPTFUDJ";

        /// <summary>
        /// WPTFUDJ2.
        /// </summary>
        public const string WPTFUDJ2 = "WPTFUDJ2";

        /// <summary>
        /// WPTFUDJ3.
        /// </summary>
        public const string WPTFUDJ3 = "WPTFUDJ3";
    }

    /// <inheritdoc />
    public override string TableName => "F31B5120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPUKID", "WPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WPMMCU", "WPMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WPPRTNO", "WPPRTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("WPSCTN", "WPSCTN", JdeDataType.String, 2, true, true),
        new JdeField("WP702LNR", "WP702LNR", JdeDataType.Numeric, null, true, true),
        new JdeField("WPWDSC2", "WPWDSC2", JdeDataType.String, 100),
        new JdeField("WPAQNTY", "WPAQNTY", JdeDataType.Numeric),
        new JdeField("WPBQNTY", "WPBQNTY", JdeDataType.Numeric),
        new JdeField("WPCQNTY", "WPCQNTY", JdeDataType.Numeric),
        new JdeField("WPDQNTY", "WPDQNTY", JdeDataType.Numeric),
        new JdeField("WPEQNTY", "WPEQNTY", JdeDataType.Numeric),
        new JdeField("WPE1QNTY", "WPE1QNTY", JdeDataType.Numeric),
        new JdeField("WPFQNTY", "WPFQNTY", JdeDataType.Numeric),
        new JdeField("WPGQNTY", "WPGQNTY", JdeDataType.Numeric),
        new JdeField("WPHRQNTY", "WPHRQNTY", JdeDataType.Numeric),
        new JdeField("WPIQNTY", "WPIQNTY", JdeDataType.Numeric),
        new JdeField("WPJQNTY", "WPJQNTY", JdeDataType.Numeric),
        new JdeField("WPKQNTY", "WPKQNTY", JdeDataType.Numeric),
        new JdeField("WPLRQNTY", "WPLRQNTY", JdeDataType.Numeric),
        new JdeField("WPWPRSD", "WPWPRSD", JdeDataType.Numeric),
        new JdeField("WPWPRED", "WPWPRED", JdeDataType.Numeric),
        new JdeField("WPUSER", "WPUSER", JdeDataType.String, 20),
        new JdeField("WPPID", "WPPID", JdeDataType.String, 20),
        new JdeField("WPJOBN", "WPJOBN", JdeDataType.String, 20),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric),
        new JdeField("WPTDAY", "WPTDAY", JdeDataType.Numeric),
        new JdeField("WPURCD", "WPURCD", JdeDataType.String, 4),
        new JdeField("WPURAB", "WPURAB", JdeDataType.Numeric),
        new JdeField("WPURAT", "WPURAT", JdeDataType.Numeric),
        new JdeField("WPURDT", "WPURDT", JdeDataType.Numeric),
        new JdeField("WPURRF", "WPURRF", JdeDataType.String, 30),
        new JdeField("WPFFU3", "WPFFU3", JdeDataType.String, 20),
        new JdeField("WPFFU5", "WPFFU5", JdeDataType.String, 20),
        new JdeField("WPFFU6", "WPFFU6", JdeDataType.String, 20),
        new JdeField("WPFFU4", "WPFFU4", JdeDataType.Numeric),
        new JdeField("WPFFU7", "WPFFU7", JdeDataType.Numeric),
        new JdeField("WPFFU8", "WPFFU8", JdeDataType.Numeric),
        new JdeField("WPTFUDJ", "WPTFUDJ", JdeDataType.Numeric),
        new JdeField("WPTFUDJ2", "WPTFUDJ2", JdeDataType.Numeric),
        new JdeField("WPTFUDJ3", "WPTFUDJ3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B5120_0", "Primary Key on WPMMCU, WPPRTNO, WPSCTN, WP702LNR, WPUKID", new[] { "WPMMCU", "WPPRTNO", "WPSCTN", "WP702LNR", "WPUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
