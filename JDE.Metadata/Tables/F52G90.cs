using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52G90 - .
/// </summary>
public class F52G90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTUKID.
        /// </summary>
        public const string WTUKID = "WTUKID";

        /// <summary>
        /// WTPLCODE.
        /// </summary>
        public const string WTPLCODE = "WTPLCODE";

        /// <summary>
        /// WTPLSK1.
        /// </summary>
        public const string WTPLSK1 = "WTPLSK1";

        /// <summary>
        /// WTPLSK2.
        /// </summary>
        public const string WTPLSK2 = "WTPLSK2";

        /// <summary>
        /// WTPLSK3.
        /// </summary>
        public const string WTPLSK3 = "WTPLSK3";

        /// <summary>
        /// WTIPSEQ.
        /// </summary>
        public const string WTIPSEQ = "WTIPSEQ";

        /// <summary>
        /// WTSSK1.
        /// </summary>
        public const string WTSSK1 = "WTSSK1";

        /// <summary>
        /// WTSSK2.
        /// </summary>
        public const string WTSSK2 = "WTSSK2";

        /// <summary>
        /// WTSSK3.
        /// </summary>
        public const string WTSSK3 = "WTSSK3";

        /// <summary>
        /// WTSSK4.
        /// </summary>
        public const string WTSSK4 = "WTSSK4";

        /// <summary>
        /// WTSSK5.
        /// </summary>
        public const string WTSSK5 = "WTSSK5";

        /// <summary>
        /// WTIPLT.
        /// </summary>
        public const string WTIPLT = "WTIPLT";

        /// <summary>
        /// WTIPTLD.
        /// </summary>
        public const string WTIPTLD = "WTIPTLD";

        /// <summary>
        /// WTIPALD.
        /// </summary>
        public const string WTIPALD = "WTIPALD";

        /// <summary>
        /// WTIPCV.
        /// </summary>
        public const string WTIPCV = "WTIPCV";

        /// <summary>
        /// WTIPPC.
        /// </summary>
        public const string WTIPPC = "WTIPPC";

        /// <summary>
        /// WTIPCURR.
        /// </summary>
        public const string WTIPCURR = "WTIPCURR";

        /// <summary>
        /// WTIPCURH.
        /// </summary>
        public const string WTIPCURH = "WTIPCURH";

        /// <summary>
        /// WTIPCURA.
        /// </summary>
        public const string WTIPCURA = "WTIPCURA";

        /// <summary>
        /// WTIPCUMR.
        /// </summary>
        public const string WTIPCUMR = "WTIPCUMR";

        /// <summary>
        /// WTIPCUMH.
        /// </summary>
        public const string WTIPCUMH = "WTIPCUMH";

        /// <summary>
        /// WTIPCUMA.
        /// </summary>
        public const string WTIPCUMA = "WTIPCUMA";

        /// <summary>
        /// WTIPSTYLE.
        /// </summary>
        public const string WTIPSTYLE = "WTIPSTYLE";

        /// <summary>
        /// WTDOCZ.
        /// </summary>
        public const string WTDOCZ = "WTDOCZ";

        /// <summary>
        /// WTDCTI.
        /// </summary>
        public const string WTDCTI = "WTDCTI";

        /// <summary>
        /// WTKCOI.
        /// </summary>
        public const string WTKCOI = "WTKCOI";

        /// <summary>
        /// WTICU.
        /// </summary>
        public const string WTICU = "WTICU";

        /// <summary>
        /// WTPCTN.
        /// </summary>
        public const string WTPCTN = "WTPCTN";

        /// <summary>
        /// WTPCTT.
        /// </summary>
        public const string WTPCTT = "WTPCTT";

        /// <summary>
        /// WTPCKO.
        /// </summary>
        public const string WTPCKO = "WTPCKO";

        /// <summary>
        /// WTDOCO.
        /// </summary>
        public const string WTDOCO = "WTDOCO";

        /// <summary>
        /// WTDCTO.
        /// </summary>
        public const string WTDCTO = "WTDCTO";

        /// <summary>
        /// WTKCOO.
        /// </summary>
        public const string WTKCOO = "WTKCOO";

        /// <summary>
        /// WTIPSECT.
        /// </summary>
        public const string WTIPSECT = "WTIPSECT";

        /// <summary>
        /// WTIPSECN.
        /// </summary>
        public const string WTIPSECN = "WTIPSECN";

        /// <summary>
        /// WTCRCD.
        /// </summary>
        public const string WTCRCD = "WTCRCD";

        /// <summary>
        /// WTAN8.
        /// </summary>
        public const string WTAN8 = "WTAN8";

        /// <summary>
        /// WTDSVJ.
        /// </summary>
        public const string WTDSVJ = "WTDSVJ";

        /// <summary>
        /// WTJBCD.
        /// </summary>
        public const string WTJBCD = "WTJBCD";

        /// <summary>
        /// WTPDBA.
        /// </summary>
        public const string WTPDBA = "WTPDBA";

        /// <summary>
        /// WTMCU.
        /// </summary>
        public const string WTMCU = "WTMCU";

        /// <summary>
        /// WTOBJ.
        /// </summary>
        public const string WTOBJ = "WTOBJ";

        /// <summary>
        /// WTSUB.
        /// </summary>
        public const string WTSUB = "WTSUB";

        /// <summary>
        /// WTJBST.
        /// </summary>
        public const string WTJBST = "WTJBST";

        /// <summary>
        /// WTEXR.
        /// </summary>
        public const string WTEXR = "WTEXR";

        /// <summary>
        /// WTEXA.
        /// </summary>
        public const string WTEXA = "WTEXA";

        /// <summary>
        /// WTTXA1.
        /// </summary>
        public const string WTTXA1 = "WTTXA1";

        /// <summary>
        /// WTEXR1.
        /// </summary>
        public const string WTEXR1 = "WTEXR1";

        /// <summary>
        /// WTCCOD.
        /// </summary>
        public const string WTCCOD = "WTCCOD";

        /// <summary>
        /// WTUSER.
        /// </summary>
        public const string WTUSER = "WTUSER";

        /// <summary>
        /// WTPID.
        /// </summary>
        public const string WTPID = "WTPID";

        /// <summary>
        /// WTMKEY.
        /// </summary>
        public const string WTMKEY = "WTMKEY";

        /// <summary>
        /// WTUPMJ.
        /// </summary>
        public const string WTUPMJ = "WTUPMJ";

        /// <summary>
        /// WTUPMT.
        /// </summary>
        public const string WTUPMT = "WTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F52G90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTUKID", "WTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WTPLCODE", "WTPLCODE", JdeDataType.String, 2, true, true),
        new JdeField("WTPLSK1", "WTPLSK1", JdeDataType.String, 40, true, true),
        new JdeField("WTPLSK2", "WTPLSK2", JdeDataType.String, 40, true, true),
        new JdeField("WTPLSK3", "WTPLSK3", JdeDataType.String, 40, true, true),
        new JdeField("WTIPSEQ", "WTIPSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WTSSK1", "WTSSK1", JdeDataType.String, 80, true, true),
        new JdeField("WTSSK2", "WTSSK2", JdeDataType.String, 80, true, true),
        new JdeField("WTSSK3", "WTSSK3", JdeDataType.String, 80, true, true),
        new JdeField("WTSSK4", "WTSSK4", JdeDataType.String, 80, true, true),
        new JdeField("WTSSK5", "WTSSK5", JdeDataType.String, 80),
        new JdeField("WTIPLT", "WTIPLT", JdeDataType.String, 2),
        new JdeField("WTIPTLD", "WTIPTLD", JdeDataType.String, 200),
        new JdeField("WTIPALD", "WTIPALD", JdeDataType.String, 80),
        new JdeField("WTIPCV", "WTIPCV", JdeDataType.Numeric),
        new JdeField("WTIPPC", "WTIPPC", JdeDataType.Numeric),
        new JdeField("WTIPCURR", "WTIPCURR", JdeDataType.Numeric),
        new JdeField("WTIPCURH", "WTIPCURH", JdeDataType.Numeric),
        new JdeField("WTIPCURA", "WTIPCURA", JdeDataType.Numeric),
        new JdeField("WTIPCUMR", "WTIPCUMR", JdeDataType.Numeric),
        new JdeField("WTIPCUMH", "WTIPCUMH", JdeDataType.Numeric),
        new JdeField("WTIPCUMA", "WTIPCUMA", JdeDataType.Numeric),
        new JdeField("WTIPSTYLE", "WTIPSTYLE", JdeDataType.String, 20),
        new JdeField("WTDOCZ", "WTDOCZ", JdeDataType.Numeric),
        new JdeField("WTDCTI", "WTDCTI", JdeDataType.String, 4),
        new JdeField("WTKCOI", "WTKCOI", JdeDataType.String, 10),
        new JdeField("WTICU", "WTICU", JdeDataType.Numeric),
        new JdeField("WTPCTN", "WTPCTN", JdeDataType.Numeric),
        new JdeField("WTPCTT", "WTPCTT", JdeDataType.String, 4),
        new JdeField("WTPCKO", "WTPCKO", JdeDataType.String, 10),
        new JdeField("WTDOCO", "WTDOCO", JdeDataType.Numeric),
        new JdeField("WTDCTO", "WTDCTO", JdeDataType.String, 4),
        new JdeField("WTKCOO", "WTKCOO", JdeDataType.String, 10),
        new JdeField("WTIPSECT", "WTIPSECT", JdeDataType.String, 6),
        new JdeField("WTIPSECN", "WTIPSECN", JdeDataType.String, 60),
        new JdeField("WTCRCD", "WTCRCD", JdeDataType.String, 6),
        new JdeField("WTAN8", "WTAN8", JdeDataType.Numeric),
        new JdeField("WTDSVJ", "WTDSVJ", JdeDataType.Numeric),
        new JdeField("WTJBCD", "WTJBCD", JdeDataType.String, 12),
        new JdeField("WTPDBA", "WTPDBA", JdeDataType.Numeric),
        new JdeField("WTMCU", "WTMCU", JdeDataType.String, 24),
        new JdeField("WTOBJ", "WTOBJ", JdeDataType.String, 12),
        new JdeField("WTSUB", "WTSUB", JdeDataType.String, 16),
        new JdeField("WTJBST", "WTJBST", JdeDataType.String, 8),
        new JdeField("WTEXR", "WTEXR", JdeDataType.String, 60),
        new JdeField("WTEXA", "WTEXA", JdeDataType.String, 60),
        new JdeField("WTTXA1", "WTTXA1", JdeDataType.String, 20),
        new JdeField("WTEXR1", "WTEXR1", JdeDataType.String, 4),
        new JdeField("WTCCOD", "WTCCOD", JdeDataType.String, 10),
        new JdeField("WTUSER", "WTUSER", JdeDataType.String, 20),
        new JdeField("WTPID", "WTPID", JdeDataType.String, 20),
        new JdeField("WTMKEY", "WTMKEY", JdeDataType.String, 30),
        new JdeField("WTUPMJ", "WTUPMJ", JdeDataType.Numeric),
        new JdeField("WTUPMT", "WTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52G90_0", "Primary Key on WTUKID, WTPLCODE, WTPLSK1, WTPLSK2, WTPLSK3, WTIPSEQ, WTSSK1, WTSSK2, WTSSK3, WTSSK4", new[] { "WTUKID", "WTPLCODE", "WTPLSK1", "WTPLSK2", "WTPLSK3", "WTIPSEQ", "WTSSK1", "WTSSK2", "WTSSK3", "WTSSK4" }, isUnique: true, isPrimaryKey: true)
    };
}
