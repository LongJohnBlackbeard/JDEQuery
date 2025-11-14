using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F300210 - .
/// </summary>
public class F300210 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHUKID.
        /// </summary>
        public const string EHUKID = "EHUKID";

        /// <summary>
        /// EHKIT.
        /// </summary>
        public const string EHKIT = "EHKIT";

        /// <summary>
        /// EHTBM.
        /// </summary>
        public const string EHTBM = "EHTBM";

        /// <summary>
        /// EHMMCU.
        /// </summary>
        public const string EHMMCU = "EHMMCU";

        /// <summary>
        /// EHLBQTY.
        /// </summary>
        public const string EHLBQTY = "EHLBQTY";

        /// <summary>
        /// EHUOM.
        /// </summary>
        public const string EHUOM = "EHUOM";

        /// <summary>
        /// EHSTKT.
        /// </summary>
        public const string EHSTKT = "EHSTKT";

        /// <summary>
        /// EHITM.
        /// </summary>
        public const string EHITM = "EHITM";

        /// <summary>
        /// EHCMCU.
        /// </summary>
        public const string EHCMCU = "EHCMCU";

        /// <summary>
        /// EHUEFFD.
        /// </summary>
        public const string EHUEFFD = "EHUEFFD";

        /// <summary>
        /// EHUEFTD.
        /// </summary>
        public const string EHUEFTD = "EHUEFTD";

        /// <summary>
        /// EHDFMLINE.
        /// </summary>
        public const string EHDFMLINE = "EHDFMLINE";

        /// <summary>
        /// EHBQTE1.
        /// </summary>
        public const string EHBQTE1 = "EHBQTE1";

        /// <summary>
        /// EHLQNTY.
        /// </summary>
        public const string EHLQNTY = "EHLQNTY";

        /// <summary>
        /// EHUM.
        /// </summary>
        public const string EHUM = "EHUM";

        /// <summary>
        /// EHLBOM.
        /// </summary>
        public const string EHLBOM = "EHLBOM";

        /// <summary>
        /// EHBRVN.
        /// </summary>
        public const string EHBRVN = "EHBRVN";

        /// <summary>
        /// EHBREV.
        /// </summary>
        public const string EHBREV = "EHBREV";

        /// <summary>
        /// EHDSC1.
        /// </summary>
        public const string EHDSC1 = "EHDSC1";

        /// <summary>
        /// EHBCHGF.
        /// </summary>
        public const string EHBCHGF = "EHBCHGF";

        /// <summary>
        /// EHCOLOCN.
        /// </summary>
        public const string EHCOLOCN = "EHCOLOCN";

        /// <summary>
        /// EHBOSTR.
        /// </summary>
        public const string EHBOSTR = "EHBOSTR";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHMKEY.
        /// </summary>
        public const string EHMKEY = "EHMKEY";

        /// <summary>
        /// EHUUPMJ.
        /// </summary>
        public const string EHUUPMJ = "EHUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F300210";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHUKID", "EHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("EHKIT", "EHKIT", JdeDataType.Numeric),
        new JdeField("EHTBM", "EHTBM", JdeDataType.String, 6),
        new JdeField("EHMMCU", "EHMMCU", JdeDataType.String, 24),
        new JdeField("EHLBQTY", "EHLBQTY", JdeDataType.Numeric),
        new JdeField("EHUOM", "EHUOM", JdeDataType.String, 4),
        new JdeField("EHSTKT", "EHSTKT", JdeDataType.String, 2),
        new JdeField("EHITM", "EHITM", JdeDataType.Numeric),
        new JdeField("EHCMCU", "EHCMCU", JdeDataType.String, 24),
        new JdeField("EHUEFFD", "EHUEFFD", JdeDataType.Date),
        new JdeField("EHUEFTD", "EHUEFTD", JdeDataType.Date),
        new JdeField("EHDFMLINE", "EHDFMLINE", JdeDataType.String, 24),
        new JdeField("EHBQTE1", "EHBQTE1", JdeDataType.Numeric),
        new JdeField("EHLQNTY", "EHLQNTY", JdeDataType.Numeric),
        new JdeField("EHUM", "EHUM", JdeDataType.String, 4),
        new JdeField("EHLBOM", "EHLBOM", JdeDataType.Numeric),
        new JdeField("EHBRVN", "EHBRVN", JdeDataType.Numeric),
        new JdeField("EHBREV", "EHBREV", JdeDataType.String, 6),
        new JdeField("EHDSC1", "EHDSC1", JdeDataType.String, 60),
        new JdeField("EHBCHGF", "EHBCHGF", JdeDataType.String, 2),
        new JdeField("EHCOLOCN", "EHCOLOCN", JdeDataType.String, 40),
        new JdeField("EHBOSTR", "EHBOSTR", JdeDataType.String, 8),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHMKEY", "EHMKEY", JdeDataType.String, 30),
        new JdeField("EHUUPMJ", "EHUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F300210_0", "Primary Key on EHUKID", new[] { "EHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F300210_2", "Index on EHKIT, EHTBM, EHMMCU, EHLBQTY, EHDFMLINE, EHBRVN, EHLBOM", new[] { "EHKIT", "EHTBM", "EHMMCU", "EHLBQTY", "EHDFMLINE", "EHBRVN", "EHLBOM" }),
        new JdeIndex("F300210_3", "Index on EHKIT, EHMMCU, EHTBM, EHLBQTY, EHITM, EHCMCU, EHBQTE1, EHSTKT, EHDFMLINE", new[] { "EHKIT", "EHMMCU", "EHTBM", "EHLBQTY", "EHITM", "EHCMCU", "EHBQTE1", "EHSTKT", "EHDFMLINE" })
    };
}
