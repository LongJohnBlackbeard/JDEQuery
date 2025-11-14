using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30026 - .
/// </summary>
public class F30026 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IEITM.
        /// </summary>
        public const string IEITM = "IEITM";

        /// <summary>
        /// IELITM.
        /// </summary>
        public const string IELITM = "IELITM";

        /// <summary>
        /// IEAITM.
        /// </summary>
        public const string IEAITM = "IEAITM";

        /// <summary>
        /// IEMMCU.
        /// </summary>
        public const string IEMMCU = "IEMMCU";

        /// <summary>
        /// IELOCN.
        /// </summary>
        public const string IELOCN = "IELOCN";

        /// <summary>
        /// IELOTN.
        /// </summary>
        public const string IELOTN = "IELOTN";

        /// <summary>
        /// IELEDG.
        /// </summary>
        public const string IELEDG = "IELEDG";

        /// <summary>
        /// IECOST.
        /// </summary>
        public const string IECOST = "IECOST";

        /// <summary>
        /// IELOTG.
        /// </summary>
        public const string IELOTG = "IELOTG";

        /// <summary>
        /// IESTDC.
        /// </summary>
        public const string IESTDC = "IESTDC";

        /// <summary>
        /// IEXSMC.
        /// </summary>
        public const string IEXSMC = "IEXSMC";

        /// <summary>
        /// IECSL.
        /// </summary>
        public const string IECSL = "IECSL";

        /// <summary>
        /// IEXSCR.
        /// </summary>
        public const string IEXSCR = "IEXSCR";

        /// <summary>
        /// IESCTC.
        /// </summary>
        public const string IESCTC = "IESCTC";

        /// <summary>
        /// IEXSFC.
        /// </summary>
        public const string IEXSFC = "IEXSFC";

        /// <summary>
        /// IESTFC.
        /// </summary>
        public const string IESTFC = "IESTFC";

        /// <summary>
        /// IEXSF.
        /// </summary>
        public const string IEXSF = "IEXSF";

        /// <summary>
        /// IERATS.
        /// </summary>
        public const string IERATS = "IERATS";

        /// <summary>
        /// IEXSRC.
        /// </summary>
        public const string IEXSRC = "IEXSRC";

        /// <summary>
        /// IERTSD.
        /// </summary>
        public const string IERTSD = "IERTSD";

        /// <summary>
        /// IEXSR.
        /// </summary>
        public const string IEXSR = "IEXSR";

        /// <summary>
        /// IEPFLG.
        /// </summary>
        public const string IEPFLG = "IEPFLG";

        /// <summary>
        /// IEUSER.
        /// </summary>
        public const string IEUSER = "IEUSER";

        /// <summary>
        /// IEPID.
        /// </summary>
        public const string IEPID = "IEPID";

        /// <summary>
        /// IEJOBN.
        /// </summary>
        public const string IEJOBN = "IEJOBN";

        /// <summary>
        /// IEUPMJ.
        /// </summary>
        public const string IEUPMJ = "IEUPMJ";

        /// <summary>
        /// IETDAY.
        /// </summary>
        public const string IETDAY = "IETDAY";

        /// <summary>
        /// IEOPSQ.
        /// </summary>
        public const string IEOPSQ = "IEOPSQ";

        /// <summary>
        /// IEMCUL.
        /// </summary>
        public const string IEMCUL = "IEMCUL";

        /// <summary>
        /// IEWMCU.
        /// </summary>
        public const string IEWMCU = "IEWMCU";

        /// <summary>
        /// IELDA.
        /// </summary>
        public const string IELDA = "IELDA";

        /// <summary>
        /// IETBM.
        /// </summary>
        public const string IETBM = "IETBM";

        /// <summary>
        /// IEACQ.
        /// </summary>
        public const string IEACQ = "IEACQ";

        /// <summary>
        /// IEF.
        /// </summary>
        public const string IEF = "IEF";
    }

    /// <inheritdoc />
    public override string TableName => "F30026";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IEITM", "IEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IELITM", "IELITM", JdeDataType.String, 50),
        new JdeField("IEAITM", "IEAITM", JdeDataType.String, 50),
        new JdeField("IEMMCU", "IEMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IELOCN", "IELOCN", JdeDataType.String, 40, true, true),
        new JdeField("IELOTN", "IELOTN", JdeDataType.String, 60, true, true),
        new JdeField("IELEDG", "IELEDG", JdeDataType.String, 4, true, true),
        new JdeField("IECOST", "IECOST", JdeDataType.String, 6, true, true),
        new JdeField("IELOTG", "IELOTG", JdeDataType.String, 6),
        new JdeField("IESTDC", "IESTDC", JdeDataType.Numeric),
        new JdeField("IEXSMC", "IEXSMC", JdeDataType.Numeric),
        new JdeField("IECSL", "IECSL", JdeDataType.Numeric),
        new JdeField("IEXSCR", "IEXSCR", JdeDataType.Numeric),
        new JdeField("IESCTC", "IESCTC", JdeDataType.String, 8),
        new JdeField("IEXSFC", "IEXSFC", JdeDataType.String, 8),
        new JdeField("IESTFC", "IESTFC", JdeDataType.Numeric),
        new JdeField("IEXSF", "IEXSF", JdeDataType.Numeric),
        new JdeField("IERATS", "IERATS", JdeDataType.String, 8),
        new JdeField("IEXSRC", "IEXSRC", JdeDataType.String, 8),
        new JdeField("IERTSD", "IERTSD", JdeDataType.Numeric),
        new JdeField("IEXSR", "IEXSR", JdeDataType.Numeric),
        new JdeField("IEPFLG", "IEPFLG", JdeDataType.String, 2),
        new JdeField("IEUSER", "IEUSER", JdeDataType.String, 20),
        new JdeField("IEPID", "IEPID", JdeDataType.String, 20),
        new JdeField("IEJOBN", "IEJOBN", JdeDataType.String, 20),
        new JdeField("IEUPMJ", "IEUPMJ", JdeDataType.Numeric),
        new JdeField("IETDAY", "IETDAY", JdeDataType.Numeric),
        new JdeField("IEOPSQ", "IEOPSQ", JdeDataType.Numeric),
        new JdeField("IEMCUL", "IEMCUL", JdeDataType.String, 24),
        new JdeField("IEWMCU", "IEWMCU", JdeDataType.String, 24),
        new JdeField("IELDA", "IELDA", JdeDataType.String, 2),
        new JdeField("IETBM", "IETBM", JdeDataType.String, 6),
        new JdeField("IEACQ", "IEACQ", JdeDataType.Numeric),
        new JdeField("IEF", "IEF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30026_0", "Primary Key on IEITM, IEMMCU, IELOCN, IELOTN, IELEDG, IECOST", new[] { "IEITM", "IEMMCU", "IELOCN", "IELOTN", "IELEDG", "IECOST" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30026_2", "Index on IEITM, IEMMCU, IELOCN, IELEDG, IECOST", new[] { "IEITM", "IEMMCU", "IELOCN", "IELEDG", "IECOST" }),
        new JdeIndex("F30026_3", "Index on IELEDG, IEITM, IEMMCU, IELOCN, IELOTN, IECOST", new[] { "IELEDG", "IEITM", "IEMMCU", "IELOCN", "IELOTN", "IECOST" })
    };
}
