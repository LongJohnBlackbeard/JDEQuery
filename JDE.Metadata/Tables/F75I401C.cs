using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I401C - .
/// </summary>
public class F75I401C : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAKCOO.
        /// </summary>
        public const string QAKCOO = "QAKCOO";

        /// <summary>
        /// QAKCO.
        /// </summary>
        public const string QAKCO = "QAKCO";

        /// <summary>
        /// QACO.
        /// </summary>
        public const string QACO = "QACO";

        /// <summary>
        /// QADOCO.
        /// </summary>
        public const string QADOCO = "QADOCO";

        /// <summary>
        /// QADCTO.
        /// </summary>
        public const string QADCTO = "QADCTO";

        /// <summary>
        /// QADOC.
        /// </summary>
        public const string QADOC = "QADOC";

        /// <summary>
        /// QADCT.
        /// </summary>
        public const string QADCT = "QADCT";

        /// <summary>
        /// QALNID.
        /// </summary>
        public const string QALNID = "QALNID";

        /// <summary>
        /// QAYFRMTY.
        /// </summary>
        public const string QAYFRMTY = "QAYFRMTY";

        /// <summary>
        /// QASTOP.
        /// </summary>
        public const string QASTOP = "QASTOP";

        /// <summary>
        /// QAMCU.
        /// </summary>
        public const string QAMCU = "QAMCU";

        /// <summary>
        /// QAUSER.
        /// </summary>
        public const string QAUSER = "QAUSER";

        /// <summary>
        /// QAPID.
        /// </summary>
        public const string QAPID = "QAPID";

        /// <summary>
        /// QAUPMJ.
        /// </summary>
        public const string QAUPMJ = "QAUPMJ";

        /// <summary>
        /// QAJOBN.
        /// </summary>
        public const string QAJOBN = "QAJOBN";

        /// <summary>
        /// QAUPMT.
        /// </summary>
        public const string QAUPMT = "QAUPMT";

        /// <summary>
        /// QATORG.
        /// </summary>
        public const string QATORG = "QATORG";

        /// <summary>
        /// QAADSO.
        /// </summary>
        public const string QAADSO = "QAADSO";

        /// <summary>
        /// QAAVCO.
        /// </summary>
        public const string QAAVCO = "QAAVCO";

        /// <summary>
        /// QAREM1.
        /// </summary>
        public const string QAREM1 = "QAREM1";

        /// <summary>
        /// QAAIS5.
        /// </summary>
        public const string QAAIS5 = "QAAIS5";

        /// <summary>
        /// QAUPRC.
        /// </summary>
        public const string QAUPRC = "QAUPRC";

        /// <summary>
        /// QASOQS.
        /// </summary>
        public const string QASOQS = "QASOQS";

        /// <summary>
        /// QAAEXP.
        /// </summary>
        public const string QAAEXP = "QAAEXP";

        /// <summary>
        /// QADGL.
        /// </summary>
        public const string QADGL = "QADGL";

        /// <summary>
        /// QACUSTSUP.
        /// </summary>
        public const string QACUSTSUP = "QACUSTSUP";

        /// <summary>
        /// QAI75NFA.
        /// </summary>
        public const string QAI75NFA = "QAI75NFA";

        /// <summary>
        /// QAI75STA.
        /// </summary>
        public const string QAI75STA = "QAI75STA";

        /// <summary>
        /// QAI75STR.
        /// </summary>
        public const string QAI75STR = "QAI75STR";

        /// <summary>
        /// QALITM.
        /// </summary>
        public const string QALITM = "QALITM";

        /// <summary>
        /// QAI75STN.
        /// </summary>
        public const string QAI75STN = "QAI75STN";

        /// <summary>
        /// QAI75FNBR.
        /// </summary>
        public const string QAI75FNBR = "QAI75FNBR";

        /// <summary>
        /// QAI75FRD.
        /// </summary>
        public const string QAI75FRD = "QAI75FRD";

        /// <summary>
        /// QAIVD.
        /// </summary>
        public const string QAIVD = "QAIVD";
    }

    /// <inheritdoc />
    public override string TableName => "F75I401C";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAKCOO", "QAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("QAKCO", "QAKCO", JdeDataType.String, 10),
        new JdeField("QACO", "QACO", JdeDataType.String, 10),
        new JdeField("QADOCO", "QADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("QADCTO", "QADCTO", JdeDataType.String, 4),
        new JdeField("QADOC", "QADOC", JdeDataType.Numeric),
        new JdeField("QADCT", "QADCT", JdeDataType.String, 4),
        new JdeField("QALNID", "QALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QAYFRMTY", "QAYFRMTY", JdeDataType.String, 20),
        new JdeField("QASTOP", "QASTOP", JdeDataType.String, 6),
        new JdeField("QAMCU", "QAMCU", JdeDataType.String, 24),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20, true, true),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QAUPMJ", "QAUPMJ", JdeDataType.Numeric),
        new JdeField("QAJOBN", "QAJOBN", JdeDataType.String, 20, true, true),
        new JdeField("QAUPMT", "QAUPMT", JdeDataType.Numeric),
        new JdeField("QATORG", "QATORG", JdeDataType.String, 20),
        new JdeField("QAADSO", "QAADSO", JdeDataType.String, 6),
        new JdeField("QAAVCO", "QAAVCO", JdeDataType.Numeric),
        new JdeField("QAREM1", "QAREM1", JdeDataType.String, 80),
        new JdeField("QAAIS5", "QAAIS5", JdeDataType.Numeric),
        new JdeField("QAUPRC", "QAUPRC", JdeDataType.Numeric),
        new JdeField("QASOQS", "QASOQS", JdeDataType.Numeric),
        new JdeField("QAAEXP", "QAAEXP", JdeDataType.Numeric),
        new JdeField("QADGL", "QADGL", JdeDataType.Numeric),
        new JdeField("QACUSTSUP", "QACUSTSUP", JdeDataType.Numeric),
        new JdeField("QAI75NFA", "QAI75NFA", JdeDataType.Numeric),
        new JdeField("QAI75STA", "QAI75STA", JdeDataType.Numeric),
        new JdeField("QAI75STR", "QAI75STR", JdeDataType.Numeric),
        new JdeField("QALITM", "QALITM", JdeDataType.String, 50),
        new JdeField("QAI75STN", "QAI75STN", JdeDataType.String, 60),
        new JdeField("QAI75FNBR", "QAI75FNBR", JdeDataType.String, 60),
        new JdeField("QAI75FRD", "QAI75FRD", JdeDataType.Numeric),
        new JdeField("QAIVD", "QAIVD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I401C_0", "Primary Key on QAKCOO, QADOCO, QALNID, QAUSER, QAJOBN", new[] { "QAKCOO", "QADOCO", "QALNID", "QAUSER", "QAJOBN" }, isUnique: true, isPrimaryKey: true)
    };
}
