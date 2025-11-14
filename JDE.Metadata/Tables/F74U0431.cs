using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0431 - .
/// </summary>
public class F74U0431 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LLDOCO.
        /// </summary>
        public const string LLDOCO = "LLDOCO";

        /// <summary>
        /// LLDCTO.
        /// </summary>
        public const string LLDCTO = "LLDCTO";

        /// <summary>
        /// LLKCOO.
        /// </summary>
        public const string LLKCOO = "LLKCOO";

        /// <summary>
        /// LLUKCENM.
        /// </summary>
        public const string LLUKCENM = "LLUKCENM";

        /// <summary>
        /// LLDPRT.
        /// </summary>
        public const string LLDPRT = "LLDPRT";

        /// <summary>
        /// LLUKCEDT.
        /// </summary>
        public const string LLUKCEDT = "LLUKCEDT";

        /// <summary>
        /// LLMCU.
        /// </summary>
        public const string LLMCU = "LLMCU";

        /// <summary>
        /// LL74UARP.
        /// </summary>
        public const string LL74UARP = "LL74UARP";

        /// <summary>
        /// LLLTNA.
        /// </summary>
        public const string LLLTNA = "LLLTNA";

        /// <summary>
        /// LL74ULTTY.
        /// </summary>
        public const string LL74ULTTY = "LL74ULTTY";

        /// <summary>
        /// LLDAYSC.
        /// </summary>
        public const string LLDAYSC = "LLDAYSC";

        /// <summary>
        /// LLPID.
        /// </summary>
        public const string LLPID = "LLPID";

        /// <summary>
        /// LLJOBN.
        /// </summary>
        public const string LLJOBN = "LLJOBN";

        /// <summary>
        /// LLUSER.
        /// </summary>
        public const string LLUSER = "LLUSER";

        /// <summary>
        /// LLUPMJ.
        /// </summary>
        public const string LLUPMJ = "LLUPMJ";

        /// <summary>
        /// LLUPMT.
        /// </summary>
        public const string LLUPMT = "LLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0431";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LLDOCO", "LLDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("LLDCTO", "LLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("LLKCOO", "LLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("LLUKCENM", "LLUKCENM", JdeDataType.Numeric, null, true, true),
        new JdeField("LLDPRT", "LLDPRT", JdeDataType.Numeric, null, true, true),
        new JdeField("LLUKCEDT", "LLUKCEDT", JdeDataType.Numeric),
        new JdeField("LLMCU", "LLMCU", JdeDataType.String, 24),
        new JdeField("LL74UARP", "LL74UARP", JdeDataType.Numeric),
        new JdeField("LLLTNA", "LLLTNA", JdeDataType.String, 20),
        new JdeField("LL74ULTTY", "LL74ULTTY", JdeDataType.String, 2),
        new JdeField("LLDAYSC", "LLDAYSC", JdeDataType.Numeric),
        new JdeField("LLPID", "LLPID", JdeDataType.String, 20),
        new JdeField("LLJOBN", "LLJOBN", JdeDataType.String, 20),
        new JdeField("LLUSER", "LLUSER", JdeDataType.String, 20),
        new JdeField("LLUPMJ", "LLUPMJ", JdeDataType.Numeric),
        new JdeField("LLUPMT", "LLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0431_0", "Primary Key on LLDOCO, LLDCTO, LLKCOO, LLUKCENM, LLDPRT", new[] { "LLDOCO", "LLDCTO", "LLKCOO", "LLUKCENM", "LLDPRT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0431_2", "Index on LLDOCO, LLDCTO, LLKCOO, LLUKCENM, LLLTNA, LL74ULTTY", new[] { "LLDOCO", "LLDCTO", "LLKCOO", "LLUKCENM", "LLLTNA", "LL74ULTTY" }),
        new JdeIndex("F74U0431_3", "Index on LLDOCO, LLDCTO, LLKCOO, LLUKCENM, LLDAYSC", new[] { "LLDOCO", "LLDCTO", "LLKCOO", "LLUKCENM", "LLDAYSC" })
    };
}
