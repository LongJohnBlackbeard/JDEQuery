using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32GOP - .
/// </summary>
public class F32GOP : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPDOCO.
        /// </summary>
        public const string GPDOCO = "GPDOCO";

        /// <summary>
        /// GPDCTO.
        /// </summary>
        public const string GPDCTO = "GPDCTO";

        /// <summary>
        /// GPKCOO.
        /// </summary>
        public const string GPKCOO = "GPKCOO";

        /// <summary>
        /// GPLNID.
        /// </summary>
        public const string GPLNID = "GPLNID";

        /// <summary>
        /// GPMCU.
        /// </summary>
        public const string GPMCU = "GPMCU";

        /// <summary>
        /// GPITM.
        /// </summary>
        public const string GPITM = "GPITM";

        /// <summary>
        /// GPUPRC.
        /// </summary>
        public const string GPUPRC = "GPUPRC";

        /// <summary>
        /// GPQTY.
        /// </summary>
        public const string GPQTY = "GPQTY";

        /// <summary>
        /// GPTMLNID.
        /// </summary>
        public const string GPTMLNID = "GPTMLNID";

        /// <summary>
        /// GPPALNID.
        /// </summary>
        public const string GPPALNID = "GPPALNID";

        /// <summary>
        /// GPATOMLNID.
        /// </summary>
        public const string GPATOMLNID = "GPATOMLNID";

        /// <summary>
        /// GPATOPLNID.
        /// </summary>
        public const string GPATOPLNID = "GPATOPLNID";

        /// <summary>
        /// GPCFGSID.
        /// </summary>
        public const string GPCFGSID = "GPCFGSID";

        /// <summary>
        /// GPPPDJ.
        /// </summary>
        public const string GPPPDJ = "GPPPDJ";

        /// <summary>
        /// GPRSDJ.
        /// </summary>
        public const string GPRSDJ = "GPRSDJ";

        /// <summary>
        /// GPOPPL.
        /// </summary>
        public const string GPOPPL = "GPOPPL";

        /// <summary>
        /// GPOPBA.
        /// </summary>
        public const string GPOPBA = "GPOPBA";

        /// <summary>
        /// GPOPSS.
        /// </summary>
        public const string GPOPSS = "GPOPSS";

        /// <summary>
        /// GPOPLL.
        /// </summary>
        public const string GPOPLL = "GPOPLL";

        /// <summary>
        /// GPRPPDJ.
        /// </summary>
        public const string GPRPPDJ = "GPRPPDJ";

        /// <summary>
        /// GPRRSDJ.
        /// </summary>
        public const string GPRRSDJ = "GPRRSDJ";

        /// <summary>
        /// GPTIP.
        /// </summary>
        public const string GPTIP = "GPTIP";

        /// <summary>
        /// GPUOM.
        /// </summary>
        public const string GPUOM = "GPUOM";

        /// <summary>
        /// GPGOPQTY.
        /// </summary>
        public const string GPGOPQTY = "GPGOPQTY";

        /// <summary>
        /// GPURCD.
        /// </summary>
        public const string GPURCD = "GPURCD";

        /// <summary>
        /// GPURDT.
        /// </summary>
        public const string GPURDT = "GPURDT";

        /// <summary>
        /// GPURAT.
        /// </summary>
        public const string GPURAT = "GPURAT";

        /// <summary>
        /// GPURAB.
        /// </summary>
        public const string GPURAB = "GPURAB";

        /// <summary>
        /// GPURRF.
        /// </summary>
        public const string GPURRF = "GPURRF";

        /// <summary>
        /// GPUSER.
        /// </summary>
        public const string GPUSER = "GPUSER";

        /// <summary>
        /// GPPID.
        /// </summary>
        public const string GPPID = "GPPID";

        /// <summary>
        /// GPJOBN.
        /// </summary>
        public const string GPJOBN = "GPJOBN";

        /// <summary>
        /// GPUPMJ.
        /// </summary>
        public const string GPUPMJ = "GPUPMJ";

        /// <summary>
        /// GPTDAY.
        /// </summary>
        public const string GPTDAY = "GPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F32GOP";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPDOCO", "GPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("GPDCTO", "GPDCTO", JdeDataType.String, 4, true, true),
        new JdeField("GPKCOO", "GPKCOO", JdeDataType.String, 10, true, true),
        new JdeField("GPLNID", "GPLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("GPMCU", "GPMCU", JdeDataType.String, 24),
        new JdeField("GPITM", "GPITM", JdeDataType.Numeric),
        new JdeField("GPUPRC", "GPUPRC", JdeDataType.Numeric),
        new JdeField("GPQTY", "GPQTY", JdeDataType.Numeric),
        new JdeField("GPTMLNID", "GPTMLNID", JdeDataType.Numeric),
        new JdeField("GPPALNID", "GPPALNID", JdeDataType.Numeric),
        new JdeField("GPATOMLNID", "GPATOMLNID", JdeDataType.Numeric),
        new JdeField("GPATOPLNID", "GPATOPLNID", JdeDataType.Numeric),
        new JdeField("GPCFGSID", "GPCFGSID", JdeDataType.String, 64),
        new JdeField("GPPPDJ", "GPPPDJ", JdeDataType.Numeric),
        new JdeField("GPRSDJ", "GPRSDJ", JdeDataType.Numeric),
        new JdeField("GPOPPL", "GPOPPL", JdeDataType.String, 2),
        new JdeField("GPOPBA", "GPOPBA", JdeDataType.String, 2),
        new JdeField("GPOPSS", "GPOPSS", JdeDataType.String, 2),
        new JdeField("GPOPLL", "GPOPLL", JdeDataType.String, 2),
        new JdeField("GPRPPDJ", "GPRPPDJ", JdeDataType.Numeric),
        new JdeField("GPRRSDJ", "GPRRSDJ", JdeDataType.Numeric),
        new JdeField("GPTIP", "GPTIP", JdeDataType.String, 2),
        new JdeField("GPUOM", "GPUOM", JdeDataType.String, 4),
        new JdeField("GPGOPQTY", "GPGOPQTY", JdeDataType.Numeric),
        new JdeField("GPURCD", "GPURCD", JdeDataType.String, 4),
        new JdeField("GPURDT", "GPURDT", JdeDataType.Numeric),
        new JdeField("GPURAT", "GPURAT", JdeDataType.Numeric),
        new JdeField("GPURAB", "GPURAB", JdeDataType.Numeric),
        new JdeField("GPURRF", "GPURRF", JdeDataType.String, 30),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPJOBN", "GPJOBN", JdeDataType.String, 20),
        new JdeField("GPUPMJ", "GPUPMJ", JdeDataType.Numeric),
        new JdeField("GPTDAY", "GPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32GOP_0", "Primary Key on GPDOCO, GPDCTO, GPKCOO, GPLNID", new[] { "GPDOCO", "GPDCTO", "GPKCOO", "GPLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F32GOP_2", "Index on GPDOCO, GPDCTO, GPKCOO, GPTMLNID", new[] { "GPDOCO", "GPDCTO", "GPKCOO", "GPTMLNID" })
    };
}
