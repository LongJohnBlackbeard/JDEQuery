using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76111BT - .
/// </summary>
public class F76111BT : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TABRANFK.
        /// </summary>
        public const string TABRANFK = "TABRANFK";

        /// <summary>
        /// TALNID.
        /// </summary>
        public const string TALNID = "TALNID";

        /// <summary>
        /// TABNOP.
        /// </summary>
        public const string TABNOP = "TABNOP";

        /// <summary>
        /// TABSOP.
        /// </summary>
        public const string TABSOP = "TABSOP";

        /// <summary>
        /// TAITM.
        /// </summary>
        public const string TAITM = "TAITM";

        /// <summary>
        /// TALITM.
        /// </summary>
        public const string TALITM = "TALITM";

        /// <summary>
        /// TAAITM.
        /// </summary>
        public const string TAAITM = "TAAITM";

        /// <summary>
        /// TADSC1.
        /// </summary>
        public const string TADSC1 = "TADSC1";

        /// <summary>
        /// TADSC2.
        /// </summary>
        public const string TADSC2 = "TADSC2";

        /// <summary>
        /// TAUORG.
        /// </summary>
        public const string TAUORG = "TAUORG";

        /// <summary>
        /// TAUOM.
        /// </summary>
        public const string TAUOM = "TAUOM";

        /// <summary>
        /// TAPRIC.
        /// </summary>
        public const string TAPRIC = "TAPRIC";

        /// <summary>
        /// TAUPRC.
        /// </summary>
        public const string TAUPRC = "TAUPRC";

        /// <summary>
        /// TAAEXP.
        /// </summary>
        public const string TAAEXP = "TAAEXP";

        /// <summary>
        /// TABCLF.
        /// </summary>
        public const string TABCLF = "TABCLF";

        /// <summary>
        /// TABRAAIP.
        /// </summary>
        public const string TABRAAIP = "TABRAAIP";

        /// <summary>
        /// TABBCL.
        /// </summary>
        public const string TABBCL = "TABBCL";

        /// <summary>
        /// TABBIR.
        /// </summary>
        public const string TABBIR = "TABBIR";

        /// <summary>
        /// TABRAAIC.
        /// </summary>
        public const string TABRAAIC = "TABRAAIC";

        /// <summary>
        /// TABRAVCI.
        /// </summary>
        public const string TABRAVCI = "TABRAVCI";

        /// <summary>
        /// TABREP.
        /// </summary>
        public const string TABREP = "TABREP";

        /// <summary>
        /// TABBIS.
        /// </summary>
        public const string TABBIS = "TABBIS";

        /// <summary>
        /// TABVIS.
        /// </summary>
        public const string TABVIS = "TABVIS";

        /// <summary>
        /// TABSTT.
        /// </summary>
        public const string TABSTT = "TABSTT";

        /// <summary>
        /// TABDIZ.
        /// </summary>
        public const string TABDIZ = "TABDIZ";

        /// <summary>
        /// TABDES.
        /// </summary>
        public const string TABDES = "TABDES";

        /// <summary>
        /// TABRATDF.
        /// </summary>
        public const string TABRATDF = "TABRATDF";

        /// <summary>
        /// TABBTP.
        /// </summary>
        public const string TABBTP = "TABBTP";

        /// <summary>
        /// TABIPI.
        /// </summary>
        public const string TABIPI = "TABIPI";

        /// <summary>
        /// TABBCS.
        /// </summary>
        public const string TABBCS = "TABBCS";

        /// <summary>
        /// TABISS.
        /// </summary>
        public const string TABISS = "TABISS";

        /// <summary>
        /// TABRAAIS.
        /// </summary>
        public const string TABRAAIS = "TABRAAIS";

        /// <summary>
        /// TABRAITC.
        /// </summary>
        public const string TABRAITC = "TABRAITC";

        /// <summary>
        /// TABRABIP.
        /// </summary>
        public const string TABRABIP = "TABRABIP";

        /// <summary>
        /// TABRAITP.
        /// </summary>
        public const string TABRAITP = "TABRAITP";

        /// <summary>
        /// TABRAPBR.
        /// </summary>
        public const string TABRAPBR = "TABRAPBR";

        /// <summary>
        /// TABRAUDP.
        /// </summary>
        public const string TABRAUDP = "TABRAUDP";

        /// <summary>
        /// TATRTY.
        /// </summary>
        public const string TATRTY = "TATRTY";

        /// <summary>
        /// TAUSER.
        /// </summary>
        public const string TAUSER = "TAUSER";

        /// <summary>
        /// TAPID.
        /// </summary>
        public const string TAPID = "TAPID";

        /// <summary>
        /// TAJOBN.
        /// </summary>
        public const string TAJOBN = "TAJOBN";

        /// <summary>
        /// TAUPMJ.
        /// </summary>
        public const string TAUPMJ = "TAUPMJ";

        /// <summary>
        /// TAUPMT.
        /// </summary>
        public const string TAUPMT = "TAUPMT";

        /// <summary>
        /// TATDAY.
        /// </summary>
        public const string TATDAY = "TATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76111BT";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TABRANFK", "TABRANFK", JdeDataType.Numeric, null, true, true),
        new JdeField("TALNID", "TALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TABNOP", "TABNOP", JdeDataType.Numeric),
        new JdeField("TABSOP", "TABSOP", JdeDataType.String, 4),
        new JdeField("TAITM", "TAITM", JdeDataType.Numeric),
        new JdeField("TALITM", "TALITM", JdeDataType.String, 50),
        new JdeField("TAAITM", "TAAITM", JdeDataType.String, 50),
        new JdeField("TADSC1", "TADSC1", JdeDataType.String, 60),
        new JdeField("TADSC2", "TADSC2", JdeDataType.String, 60),
        new JdeField("TAUORG", "TAUORG", JdeDataType.Numeric),
        new JdeField("TAUOM", "TAUOM", JdeDataType.String, 4),
        new JdeField("TAPRIC", "TAPRIC", JdeDataType.Numeric),
        new JdeField("TAUPRC", "TAUPRC", JdeDataType.Numeric),
        new JdeField("TAAEXP", "TAAEXP", JdeDataType.Numeric),
        new JdeField("TABCLF", "TABCLF", JdeDataType.String, 20),
        new JdeField("TABRAAIP", "TABRAAIP", JdeDataType.Numeric),
        new JdeField("TABBCL", "TABBCL", JdeDataType.Numeric),
        new JdeField("TABBIR", "TABBIR", JdeDataType.Numeric),
        new JdeField("TABRAAIC", "TABRAAIC", JdeDataType.Numeric),
        new JdeField("TABRAVCI", "TABRAVCI", JdeDataType.Numeric),
        new JdeField("TABREP", "TABREP", JdeDataType.Numeric),
        new JdeField("TABBIS", "TABBIS", JdeDataType.Numeric),
        new JdeField("TABVIS", "TABVIS", JdeDataType.Numeric),
        new JdeField("TABSTT", "TABSTT", JdeDataType.String, 4),
        new JdeField("TABDIZ", "TABDIZ", JdeDataType.Numeric),
        new JdeField("TABDES", "TABDES", JdeDataType.Numeric),
        new JdeField("TABRATDF", "TABRATDF", JdeDataType.Numeric),
        new JdeField("TABBTP", "TABBTP", JdeDataType.Numeric),
        new JdeField("TABIPI", "TABIPI", JdeDataType.Numeric),
        new JdeField("TABBCS", "TABBCS", JdeDataType.Numeric),
        new JdeField("TABISS", "TABISS", JdeDataType.Numeric),
        new JdeField("TABRAAIS", "TABRAAIS", JdeDataType.Numeric),
        new JdeField("TABRAITC", "TABRAITC", JdeDataType.String, 2),
        new JdeField("TABRABIP", "TABRABIP", JdeDataType.Numeric),
        new JdeField("TABRAITP", "TABRAITP", JdeDataType.String, 2),
        new JdeField("TABRAPBR", "TABRAPBR", JdeDataType.Numeric),
        new JdeField("TABRAUDP", "TABRAUDP", JdeDataType.String, 4),
        new JdeField("TATRTY", "TATRTY", JdeDataType.String, 6),
        new JdeField("TAUSER", "TAUSER", JdeDataType.String, 20),
        new JdeField("TAPID", "TAPID", JdeDataType.String, 20),
        new JdeField("TAJOBN", "TAJOBN", JdeDataType.String, 20),
        new JdeField("TAUPMJ", "TAUPMJ", JdeDataType.Numeric),
        new JdeField("TAUPMT", "TAUPMT", JdeDataType.Numeric),
        new JdeField("TATDAY", "TATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76111BT_0", "Primary Key on TABRANFK, TALNID", new[] { "TABRANFK", "TALNID" }, isUnique: true, isPrimaryKey: true)
    };
}
