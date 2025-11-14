using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40UI00T - .
/// </summary>
public class F40UI00T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PNSEQ.
        /// </summary>
        public const string PNSEQ = "PNSEQ";

        /// <summary>
        /// PNDOCO.
        /// </summary>
        public const string PNDOCO = "PNDOCO";

        /// <summary>
        /// PNDCTO.
        /// </summary>
        public const string PNDCTO = "PNDCTO";

        /// <summary>
        /// PNKCOO.
        /// </summary>
        public const string PNKCOO = "PNKCOO";

        /// <summary>
        /// PNSFXO.
        /// </summary>
        public const string PNSFXO = "PNSFXO";

        /// <summary>
        /// PNTA.
        /// </summary>
        public const string PNTA = "PNTA";

        /// <summary>
        /// PNTAXA.
        /// </summary>
        public const string PNTAXA = "PNTAXA";

        /// <summary>
        /// PNTXR1.
        /// </summary>
        public const string PNTXR1 = "PNTXR1";

        /// <summary>
        /// PNFTXB.
        /// </summary>
        public const string PNFTXB = "PNFTXB";

        /// <summary>
        /// PNTXBL.
        /// </summary>
        public const string PNTXBL = "PNTXBL";

        /// <summary>
        /// PNFTXA.
        /// </summary>
        public const string PNFTXA = "PNFTXA";

        /// <summary>
        /// PNTXAM.
        /// </summary>
        public const string PNTXAM = "PNTXAM";

        /// <summary>
        /// PNEXR1.
        /// </summary>
        public const string PNEXR1 = "PNEXR1";

        /// <summary>
        /// PNDL01.
        /// </summary>
        public const string PNDL01 = "PNDL01";

        /// <summary>
        /// PNTXA1.
        /// </summary>
        public const string PNTXA1 = "PNTXA1";

        /// <summary>
        /// PNITM.
        /// </summary>
        public const string PNITM = "PNITM";

        /// <summary>
        /// PNATXT.
        /// </summary>
        public const string PNATXT = "PNATXT";

        /// <summary>
        /// PNURCD.
        /// </summary>
        public const string PNURCD = "PNURCD";

        /// <summary>
        /// PNURDT.
        /// </summary>
        public const string PNURDT = "PNURDT";

        /// <summary>
        /// PNURAT.
        /// </summary>
        public const string PNURAT = "PNURAT";

        /// <summary>
        /// PNURAB.
        /// </summary>
        public const string PNURAB = "PNURAB";

        /// <summary>
        /// PNURRF.
        /// </summary>
        public const string PNURRF = "PNURRF";

        /// <summary>
        /// PNUSER.
        /// </summary>
        public const string PNUSER = "PNUSER";

        /// <summary>
        /// PNPID.
        /// </summary>
        public const string PNPID = "PNPID";

        /// <summary>
        /// PNJOBN.
        /// </summary>
        public const string PNJOBN = "PNJOBN";

        /// <summary>
        /// PNUPMJ.
        /// </summary>
        public const string PNUPMJ = "PNUPMJ";

        /// <summary>
        /// PNTDAY.
        /// </summary>
        public const string PNTDAY = "PNTDAY";

        /// <summary>
        /// PNCTID.
        /// </summary>
        public const string PNCTID = "PNCTID";

        /// <summary>
        /// PNSEQ1.
        /// </summary>
        public const string PNSEQ1 = "PNSEQ1";
    }

    /// <inheritdoc />
    public override string TableName => "F40UI00T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PNSEQ", "PNSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PNDOCO", "PNDOCO", JdeDataType.Numeric),
        new JdeField("PNDCTO", "PNDCTO", JdeDataType.String, 4),
        new JdeField("PNKCOO", "PNKCOO", JdeDataType.String, 10),
        new JdeField("PNSFXO", "PNSFXO", JdeDataType.String, 6),
        new JdeField("PNTA", "PNTA", JdeDataType.String, 20),
        new JdeField("PNTAXA", "PNTAXA", JdeDataType.String, 60),
        new JdeField("PNTXR1", "PNTXR1", JdeDataType.Numeric),
        new JdeField("PNFTXB", "PNFTXB", JdeDataType.Numeric),
        new JdeField("PNTXBL", "PNTXBL", JdeDataType.Numeric),
        new JdeField("PNFTXA", "PNFTXA", JdeDataType.Numeric),
        new JdeField("PNTXAM", "PNTXAM", JdeDataType.Numeric),
        new JdeField("PNEXR1", "PNEXR1", JdeDataType.String, 4),
        new JdeField("PNDL01", "PNDL01", JdeDataType.String, 60),
        new JdeField("PNTXA1", "PNTXA1", JdeDataType.String, 20),
        new JdeField("PNITM", "PNITM", JdeDataType.Numeric),
        new JdeField("PNATXT", "PNATXT", JdeDataType.String, 2),
        new JdeField("PNURCD", "PNURCD", JdeDataType.String, 4),
        new JdeField("PNURDT", "PNURDT", JdeDataType.Numeric),
        new JdeField("PNURAT", "PNURAT", JdeDataType.Numeric),
        new JdeField("PNURAB", "PNURAB", JdeDataType.Numeric),
        new JdeField("PNURRF", "PNURRF", JdeDataType.String, 30),
        new JdeField("PNUSER", "PNUSER", JdeDataType.String, 20),
        new JdeField("PNPID", "PNPID", JdeDataType.String, 20),
        new JdeField("PNJOBN", "PNJOBN", JdeDataType.String, 20, true, true),
        new JdeField("PNUPMJ", "PNUPMJ", JdeDataType.Numeric),
        new JdeField("PNTDAY", "PNTDAY", JdeDataType.Numeric),
        new JdeField("PNCTID", "PNCTID", JdeDataType.String, 30, true, true),
        new JdeField("PNSEQ1", "PNSEQ1", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40UI00T_0", "Primary Key on PNCTID, PNJOBN, PNSEQ, PNSEQ1", new[] { "PNCTID", "PNJOBN", "PNSEQ", "PNSEQ1" }, isUnique: true, isPrimaryKey: true)
    };
}
