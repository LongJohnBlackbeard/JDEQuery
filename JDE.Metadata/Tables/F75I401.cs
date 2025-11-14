using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I401 - .
/// </summary>
public class F75I401 : JdeTable
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
        /// QADOCO.
        /// </summary>
        public const string QADOCO = "QADOCO";

        /// <summary>
        /// QADCTO.
        /// </summary>
        public const string QADCTO = "QADCTO";

        /// <summary>
        /// QALNID.
        /// </summary>
        public const string QALNID = "QALNID";

        /// <summary>
        /// QAKCO.
        /// </summary>
        public const string QAKCO = "QAKCO";

        /// <summary>
        /// QACUSTSUP.
        /// </summary>
        public const string QACUSTSUP = "QACUSTSUP";

        /// <summary>
        /// QADOC.
        /// </summary>
        public const string QADOC = "QADOC";

        /// <summary>
        /// QADCT.
        /// </summary>
        public const string QADCT = "QADCT";

        /// <summary>
        /// QAYFRMTY.
        /// </summary>
        public const string QAYFRMTY = "QAYFRMTY";

        /// <summary>
        /// QASTOP.
        /// </summary>
        public const string QASTOP = "QASTOP";

        /// <summary>
        /// QACO.
        /// </summary>
        public const string QACO = "QACO";

        /// <summary>
        /// QAIVD.
        /// </summary>
        public const string QAIVD = "QAIVD";

        /// <summary>
        /// QAI75FNBR.
        /// </summary>
        public const string QAI75FNBR = "QAI75FNBR";

        /// <summary>
        /// QAI75STN.
        /// </summary>
        public const string QAI75STN = "QAI75STN";

        /// <summary>
        /// QAMCU.
        /// </summary>
        public const string QAMCU = "QAMCU";

        /// <summary>
        /// QAI75STR.
        /// </summary>
        public const string QAI75STR = "QAI75STR";

        /// <summary>
        /// QAI75NFA.
        /// </summary>
        public const string QAI75NFA = "QAI75NFA";

        /// <summary>
        /// QAI75FRD.
        /// </summary>
        public const string QAI75FRD = "QAI75FRD";

        /// <summary>
        /// QAUSER.
        /// </summary>
        public const string QAUSER = "QAUSER";

        /// <summary>
        /// QALITM.
        /// </summary>
        public const string QALITM = "QALITM";

        /// <summary>
        /// QAPID.
        /// </summary>
        public const string QAPID = "QAPID";

        /// <summary>
        /// QAI75STA.
        /// </summary>
        public const string QAI75STA = "QAI75STA";

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
        /// QASOQS.
        /// </summary>
        public const string QASOQS = "QASOQS";

        /// <summary>
        /// QAAEXP.
        /// </summary>
        public const string QAAEXP = "QAAEXP";

        /// <summary>
        /// QAUPRC.
        /// </summary>
        public const string QAUPRC = "QAUPRC";

        /// <summary>
        /// QADGL.
        /// </summary>
        public const string QADGL = "QADGL";
    }

    /// <inheritdoc />
    public override string TableName => "F75I401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAKCOO", "QAKCOO", JdeDataType.String, 10, true, true),
        new JdeField("QADOCO", "QADOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("QADCTO", "QADCTO", JdeDataType.String, 4, true, true),
        new JdeField("QALNID", "QALNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QAKCO", "QAKCO", JdeDataType.String, 10),
        new JdeField("QACUSTSUP", "QACUSTSUP", JdeDataType.Numeric),
        new JdeField("QADOC", "QADOC", JdeDataType.Numeric),
        new JdeField("QADCT", "QADCT", JdeDataType.String, 4),
        new JdeField("QAYFRMTY", "QAYFRMTY", JdeDataType.String, 20),
        new JdeField("QASTOP", "QASTOP", JdeDataType.String, 6),
        new JdeField("QACO", "QACO", JdeDataType.String, 10),
        new JdeField("QAIVD", "QAIVD", JdeDataType.Numeric),
        new JdeField("QAI75FNBR", "QAI75FNBR", JdeDataType.String, 60),
        new JdeField("QAI75STN", "QAI75STN", JdeDataType.String, 60, true, true),
        new JdeField("QAMCU", "QAMCU", JdeDataType.String, 24),
        new JdeField("QAI75STR", "QAI75STR", JdeDataType.Numeric),
        new JdeField("QAI75NFA", "QAI75NFA", JdeDataType.Numeric),
        new JdeField("QAI75FRD", "QAI75FRD", JdeDataType.Numeric),
        new JdeField("QAUSER", "QAUSER", JdeDataType.String, 20),
        new JdeField("QALITM", "QALITM", JdeDataType.String, 50),
        new JdeField("QAPID", "QAPID", JdeDataType.String, 20),
        new JdeField("QAI75STA", "QAI75STA", JdeDataType.Numeric),
        new JdeField("QAUPMJ", "QAUPMJ", JdeDataType.Numeric),
        new JdeField("QAJOBN", "QAJOBN", JdeDataType.String, 20),
        new JdeField("QAUPMT", "QAUPMT", JdeDataType.Numeric),
        new JdeField("QATORG", "QATORG", JdeDataType.String, 20),
        new JdeField("QAADSO", "QAADSO", JdeDataType.String, 6),
        new JdeField("QAAVCO", "QAAVCO", JdeDataType.Numeric),
        new JdeField("QAREM1", "QAREM1", JdeDataType.String, 80),
        new JdeField("QAAIS5", "QAAIS5", JdeDataType.Numeric),
        new JdeField("QASOQS", "QASOQS", JdeDataType.Numeric),
        new JdeField("QAAEXP", "QAAEXP", JdeDataType.Numeric),
        new JdeField("QAUPRC", "QAUPRC", JdeDataType.Numeric),
        new JdeField("QADGL", "QADGL", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I401_0", "Primary Key on QAKCOO, QADOCO, QADCTO, QALNID, QAI75STN", new[] { "QAKCOO", "QADOCO", "QADCTO", "QALNID", "QAI75STN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I401_2", "Index on QAMCU, QACUSTSUP, QAKCOO, QADOCO, QADCTO, QALNID, QADOC, QADCT", new[] { "QAMCU", "QACUSTSUP", "QAKCOO", "QADOCO", "QADCTO", "QALNID", "QADOC", "QADCT" }),
        new JdeIndex("F75I401_3", "Index on QACUSTSUP, QAKCO, QAYFRMTY", new[] { "QACUSTSUP", "QAKCO", "QAYFRMTY" })
    };
}
