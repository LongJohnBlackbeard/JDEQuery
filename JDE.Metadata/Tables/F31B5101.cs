using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B5101 - .
/// </summary>
public class F31B5101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLMMCU.
        /// </summary>
        public const string WLMMCU = "WLMMCU";

        /// <summary>
        /// WLPRTNO.
        /// </summary>
        public const string WLPRTNO = "WLPRTNO";

        /// <summary>
        /// WLSCTN.
        /// </summary>
        public const string WLSCTN = "WLSCTN";

        /// <summary>
        /// WL702LNR.
        /// </summary>
        public const string WL702LNR = "WL702LNR";

        /// <summary>
        /// WLWDSC2.
        /// </summary>
        public const string WLWDSC2 = "WLWDSC2";

        /// <summary>
        /// WLUSER.
        /// </summary>
        public const string WLUSER = "WLUSER";

        /// <summary>
        /// WLPID.
        /// </summary>
        public const string WLPID = "WLPID";

        /// <summary>
        /// WLUPMJ.
        /// </summary>
        public const string WLUPMJ = "WLUPMJ";

        /// <summary>
        /// WLTDAY.
        /// </summary>
        public const string WLTDAY = "WLTDAY";

        /// <summary>
        /// WLJOBN.
        /// </summary>
        public const string WLJOBN = "WLJOBN";

        /// <summary>
        /// WLURCD.
        /// </summary>
        public const string WLURCD = "WLURCD";

        /// <summary>
        /// WLURAB.
        /// </summary>
        public const string WLURAB = "WLURAB";

        /// <summary>
        /// WLURAT.
        /// </summary>
        public const string WLURAT = "WLURAT";

        /// <summary>
        /// WLURDT.
        /// </summary>
        public const string WLURDT = "WLURDT";

        /// <summary>
        /// WLURRF.
        /// </summary>
        public const string WLURRF = "WLURRF";

        /// <summary>
        /// WLFFU3.
        /// </summary>
        public const string WLFFU3 = "WLFFU3";

        /// <summary>
        /// WLFFU5.
        /// </summary>
        public const string WLFFU5 = "WLFFU5";

        /// <summary>
        /// WLFFU6.
        /// </summary>
        public const string WLFFU6 = "WLFFU6";

        /// <summary>
        /// WLFFU4.
        /// </summary>
        public const string WLFFU4 = "WLFFU4";

        /// <summary>
        /// WLFFU7.
        /// </summary>
        public const string WLFFU7 = "WLFFU7";

        /// <summary>
        /// WLFFU8.
        /// </summary>
        public const string WLFFU8 = "WLFFU8";

        /// <summary>
        /// WLTFUDJ.
        /// </summary>
        public const string WLTFUDJ = "WLTFUDJ";

        /// <summary>
        /// WLTFUDJ2.
        /// </summary>
        public const string WLTFUDJ2 = "WLTFUDJ2";

        /// <summary>
        /// WLTFUDJ3.
        /// </summary>
        public const string WLTFUDJ3 = "WLTFUDJ3";
    }

    /// <inheritdoc />
    public override string TableName => "F31B5101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLMMCU", "WLMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WLPRTNO", "WLPRTNO", JdeDataType.Numeric, null, true, true),
        new JdeField("WLSCTN", "WLSCTN", JdeDataType.String, 2, true, true),
        new JdeField("WL702LNR", "WL702LNR", JdeDataType.Numeric, null, true, true),
        new JdeField("WLWDSC2", "WLWDSC2", JdeDataType.String, 100),
        new JdeField("WLUSER", "WLUSER", JdeDataType.String, 20),
        new JdeField("WLPID", "WLPID", JdeDataType.String, 20),
        new JdeField("WLUPMJ", "WLUPMJ", JdeDataType.Numeric),
        new JdeField("WLTDAY", "WLTDAY", JdeDataType.Numeric),
        new JdeField("WLJOBN", "WLJOBN", JdeDataType.String, 20),
        new JdeField("WLURCD", "WLURCD", JdeDataType.String, 4),
        new JdeField("WLURAB", "WLURAB", JdeDataType.Numeric),
        new JdeField("WLURAT", "WLURAT", JdeDataType.Numeric),
        new JdeField("WLURDT", "WLURDT", JdeDataType.Numeric),
        new JdeField("WLURRF", "WLURRF", JdeDataType.String, 30),
        new JdeField("WLFFU3", "WLFFU3", JdeDataType.String, 20),
        new JdeField("WLFFU5", "WLFFU5", JdeDataType.String, 20),
        new JdeField("WLFFU6", "WLFFU6", JdeDataType.String, 20),
        new JdeField("WLFFU4", "WLFFU4", JdeDataType.Numeric),
        new JdeField("WLFFU7", "WLFFU7", JdeDataType.Numeric),
        new JdeField("WLFFU8", "WLFFU8", JdeDataType.Numeric),
        new JdeField("WLTFUDJ", "WLTFUDJ", JdeDataType.Numeric),
        new JdeField("WLTFUDJ2", "WLTFUDJ2", JdeDataType.Numeric),
        new JdeField("WLTFUDJ3", "WLTFUDJ3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B5101_0", "Primary Key on WLMMCU, WLPRTNO, WLSCTN, WL702LNR", new[] { "WLMMCU", "WLPRTNO", "WLSCTN", "WL702LNR" }, isUnique: true, isPrimaryKey: true)
    };
}
