using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48091 - .
/// </summary>
public class F48091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WZBCT3.
        /// </summary>
        public const string WZBCT3 = "WZBCT3";

        /// <summary>
        /// WZBBDR.
        /// </summary>
        public const string WZBBDR = "WZBBDR";

        /// <summary>
        /// WZEBAS.
        /// </summary>
        public const string WZEBAS = "WZEBAS";

        /// <summary>
        /// WZLBAS.
        /// </summary>
        public const string WZLBAS = "WZLBAS";

        /// <summary>
        /// WZCNBS.
        /// </summary>
        public const string WZCNBS = "WZCNBS";

        /// <summary>
        /// WZPERT.
        /// </summary>
        public const string WZPERT = "WZPERT";

        /// <summary>
        /// WZINDI.
        /// </summary>
        public const string WZINDI = "WZINDI";

        /// <summary>
        /// WZBUNP.
        /// </summary>
        public const string WZBUNP = "WZBUNP";

        /// <summary>
        /// WZPRRR.
        /// </summary>
        public const string WZPRRR = "WZPRRR";

        /// <summary>
        /// WZISAC.
        /// </summary>
        public const string WZISAC = "WZISAC";

        /// <summary>
        /// WZCNTM.
        /// </summary>
        public const string WZCNTM = "WZCNTM";

        /// <summary>
        /// WZINDO.
        /// </summary>
        public const string WZINDO = "WZINDO";

        /// <summary>
        /// WZJRNL.
        /// </summary>
        public const string WZJRNL = "WZJRNL";

        /// <summary>
        /// WZPDBO.
        /// </summary>
        public const string WZPDBO = "WZPDBO";

        /// <summary>
        /// WZICTL.
        /// </summary>
        public const string WZICTL = "WZICTL";

        /// <summary>
        /// WZDSVB.
        /// </summary>
        public const string WZDSVB = "WZDSVB";

        /// <summary>
        /// WZDCTI.
        /// </summary>
        public const string WZDCTI = "WZDCTI";

        /// <summary>
        /// WZERDB.
        /// </summary>
        public const string WZERDB = "WZERDB";

        /// <summary>
        /// WZMBGC.
        /// </summary>
        public const string WZMBGC = "WZMBGC";

        /// <summary>
        /// WZDTAI.
        /// </summary>
        public const string WZDTAI = "WZDTAI";

        /// <summary>
        /// WZCRRM.
        /// </summary>
        public const string WZCRRM = "WZCRRM";

        /// <summary>
        /// WZBCT1.
        /// </summary>
        public const string WZBCT1 = "WZBCT1";

        /// <summary>
        /// WZBCT2.
        /// </summary>
        public const string WZBCT2 = "WZBCT2";

        /// <summary>
        /// WZBUF.
        /// </summary>
        public const string WZBUF = "WZBUF";

        /// <summary>
        /// WZBSOU.
        /// </summary>
        public const string WZBSOU = "WZBSOU";

        /// <summary>
        /// WZBEDB.
        /// </summary>
        public const string WZBEDB = "WZBEDB";

        /// <summary>
        /// WZBURTC.
        /// </summary>
        public const string WZBURTC = "WZBURTC";

        /// <summary>
        /// WZBURTI.
        /// </summary>
        public const string WZBURTI = "WZBURTI";

        /// <summary>
        /// WZBURTR.
        /// </summary>
        public const string WZBURTR = "WZBURTR";

        /// <summary>
        /// WZBURTAC.
        /// </summary>
        public const string WZBURTAC = "WZBURTAC";

        /// <summary>
        /// WZPID.
        /// </summary>
        public const string WZPID = "WZPID";

        /// <summary>
        /// WZJOBN.
        /// </summary>
        public const string WZJOBN = "WZJOBN";

        /// <summary>
        /// WZUSER.
        /// </summary>
        public const string WZUSER = "WZUSER";

        /// <summary>
        /// WZUPMJ.
        /// </summary>
        public const string WZUPMJ = "WZUPMJ";

        /// <summary>
        /// WZUPMT.
        /// </summary>
        public const string WZUPMT = "WZUPMT";

        /// <summary>
        /// WZGCUSED.
        /// </summary>
        public const string WZGCUSED = "WZGCUSED";

        /// <summary>
        /// WZMIHF.
        /// </summary>
        public const string WZMIHF = "WZMIHF";

        /// <summary>
        /// WZDJOTY.
        /// </summary>
        public const string WZDJOTY = "WZDJOTY";

        /// <summary>
        /// WZLETF.
        /// </summary>
        public const string WZLETF = "WZLETF";

        /// <summary>
        /// WZDTXA1.
        /// </summary>
        public const string WZDTXA1 = "WZDTXA1";

        /// <summary>
        /// WZDEXR1.
        /// </summary>
        public const string WZDEXR1 = "WZDEXR1";

        /// <summary>
        /// WZCETU.
        /// </summary>
        public const string WZCETU = "WZCETU";
    }

    /// <inheritdoc />
    public override string TableName => "F48091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WZBCT3", "WZBCT3", JdeDataType.String, 2, true, true),
        new JdeField("WZBBDR", "WZBBDR", JdeDataType.String, 2),
        new JdeField("WZEBAS", "WZEBAS", JdeDataType.String, 2),
        new JdeField("WZLBAS", "WZLBAS", JdeDataType.String, 2),
        new JdeField("WZCNBS", "WZCNBS", JdeDataType.String, 2),
        new JdeField("WZPERT", "WZPERT", JdeDataType.Numeric),
        new JdeField("WZINDI", "WZINDI", JdeDataType.String, 2),
        new JdeField("WZBUNP", "WZBUNP", JdeDataType.String, 2),
        new JdeField("WZPRRR", "WZPRRR", JdeDataType.String, 2),
        new JdeField("WZISAC", "WZISAC", JdeDataType.String, 2),
        new JdeField("WZCNTM", "WZCNTM", JdeDataType.String, 2),
        new JdeField("WZINDO", "WZINDO", JdeDataType.String, 2),
        new JdeField("WZJRNL", "WZJRNL", JdeDataType.String, 2),
        new JdeField("WZPDBO", "WZPDBO", JdeDataType.Numeric),
        new JdeField("WZICTL", "WZICTL", JdeDataType.String, 2),
        new JdeField("WZDSVB", "WZDSVB", JdeDataType.String, 2),
        new JdeField("WZDCTI", "WZDCTI", JdeDataType.String, 4),
        new JdeField("WZERDB", "WZERDB", JdeDataType.String, 2),
        new JdeField("WZMBGC", "WZMBGC", JdeDataType.String, 2),
        new JdeField("WZDTAI", "WZDTAI", JdeDataType.String, 20),
        new JdeField("WZCRRM", "WZCRRM", JdeDataType.String, 2),
        new JdeField("WZBCT1", "WZBCT1", JdeDataType.String, 2),
        new JdeField("WZBCT2", "WZBCT2", JdeDataType.String, 2),
        new JdeField("WZBUF", "WZBUF", JdeDataType.String, 2),
        new JdeField("WZBSOU", "WZBSOU", JdeDataType.String, 2),
        new JdeField("WZBEDB", "WZBEDB", JdeDataType.String, 2),
        new JdeField("WZBURTC", "WZBURTC", JdeDataType.String, 10),
        new JdeField("WZBURTI", "WZBURTI", JdeDataType.String, 10),
        new JdeField("WZBURTR", "WZBURTR", JdeDataType.String, 10),
        new JdeField("WZBURTAC", "WZBURTAC", JdeDataType.String, 10),
        new JdeField("WZPID", "WZPID", JdeDataType.String, 20),
        new JdeField("WZJOBN", "WZJOBN", JdeDataType.String, 20),
        new JdeField("WZUSER", "WZUSER", JdeDataType.String, 20),
        new JdeField("WZUPMJ", "WZUPMJ", JdeDataType.Numeric),
        new JdeField("WZUPMT", "WZUPMT", JdeDataType.Numeric),
        new JdeField("WZGCUSED", "WZGCUSED", JdeDataType.String, 2),
        new JdeField("WZMIHF", "WZMIHF", JdeDataType.String, 2),
        new JdeField("WZDJOTY", "WZDJOTY", JdeDataType.String, 12),
        new JdeField("WZLETF", "WZLETF", JdeDataType.String, 2),
        new JdeField("WZDTXA1", "WZDTXA1", JdeDataType.String, 20),
        new JdeField("WZDEXR1", "WZDEXR1", JdeDataType.String, 4),
        new JdeField("WZCETU", "WZCETU", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48091_0", "Primary Key on WZBCT3", new[] { "WZBCT3" }, isUnique: true, isPrimaryKey: true)
    };
}
