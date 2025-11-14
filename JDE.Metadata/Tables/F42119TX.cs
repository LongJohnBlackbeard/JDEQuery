using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42119TX - .
/// </summary>
public class F42119TX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTKCOO.
        /// </summary>
        public const string DTKCOO = "DTKCOO";

        /// <summary>
        /// DTDOCO.
        /// </summary>
        public const string DTDOCO = "DTDOCO";

        /// <summary>
        /// DTDCTO.
        /// </summary>
        public const string DTDCTO = "DTDCTO";

        /// <summary>
        /// DTLNID.
        /// </summary>
        public const string DTLNID = "DTLNID";

        /// <summary>
        /// DTTUPRC.
        /// </summary>
        public const string DTTUPRC = "DTTUPRC";

        /// <summary>
        /// DTUTA.
        /// </summary>
        public const string DTUTA = "DTUTA";

        /// <summary>
        /// DTTAEXP.
        /// </summary>
        public const string DTTAEXP = "DTTAEXP";

        /// <summary>
        /// DTETA.
        /// </summary>
        public const string DTETA = "DTETA";

        /// <summary>
        /// DTTFUP.
        /// </summary>
        public const string DTTFUP = "DTTFUP";

        /// <summary>
        /// DTFUTA.
        /// </summary>
        public const string DTFUTA = "DTFUTA";

        /// <summary>
        /// DTTFEA.
        /// </summary>
        public const string DTTFEA = "DTTFEA";

        /// <summary>
        /// DTFETA.
        /// </summary>
        public const string DTFETA = "DTFETA";

        /// <summary>
        /// DTTPROV.
        /// </summary>
        public const string DTTPROV = "DTTPROV";

        /// <summary>
        /// DTDTXJ.
        /// </summary>
        public const string DTDTXJ = "DTDTXJ";

        /// <summary>
        /// DTTKITAMTD.
        /// </summary>
        public const string DTTKITAMTD = "DTTKITAMTD";

        /// <summary>
        /// DTTKITAMTF.
        /// </summary>
        public const string DTTKITAMTF = "DTTKITAMTF";

        /// <summary>
        /// DTCRCD.
        /// </summary>
        public const string DTCRCD = "DTCRCD";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F42119TX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTKCOO", "DTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("DTDOCO", "DTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("DTDCTO", "DTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("DTLNID", "DTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTTUPRC", "DTTUPRC", JdeDataType.Numeric),
        new JdeField("DTUTA", "DTUTA", JdeDataType.Numeric),
        new JdeField("DTTAEXP", "DTTAEXP", JdeDataType.Numeric),
        new JdeField("DTETA", "DTETA", JdeDataType.Numeric),
        new JdeField("DTTFUP", "DTTFUP", JdeDataType.Numeric),
        new JdeField("DTFUTA", "DTFUTA", JdeDataType.Numeric),
        new JdeField("DTTFEA", "DTTFEA", JdeDataType.Numeric),
        new JdeField("DTFETA", "DTFETA", JdeDataType.Numeric),
        new JdeField("DTTPROV", "DTTPROV", JdeDataType.String, 2),
        new JdeField("DTDTXJ", "DTDTXJ", JdeDataType.Numeric),
        new JdeField("DTTKITAMTD", "DTTKITAMTD", JdeDataType.Numeric),
        new JdeField("DTTKITAMTF", "DTTKITAMTF", JdeDataType.Numeric),
        new JdeField("DTCRCD", "DTCRCD", JdeDataType.String, 6),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42119TX_0", "Primary Key on DTDOCO, DTDCTO, DTKCOO, DTLNID", new[] { "DTDOCO", "DTDCTO", "DTKCOO", "DTLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
