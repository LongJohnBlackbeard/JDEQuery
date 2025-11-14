using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47132TX - .
/// </summary>
public class F47132TX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTEDTY.
        /// </summary>
        public const string DTEDTY = "DTEDTY";

        /// <summary>
        /// DTEDSQ.
        /// </summary>
        public const string DTEDSQ = "DTEDSQ";

        /// <summary>
        /// DTEKCO.
        /// </summary>
        public const string DTEKCO = "DTEKCO";

        /// <summary>
        /// DTEDOC.
        /// </summary>
        public const string DTEDOC = "DTEDOC";

        /// <summary>
        /// DTEDCT.
        /// </summary>
        public const string DTEDCT = "DTEDCT";

        /// <summary>
        /// DTEDLN.
        /// </summary>
        public const string DTEDLN = "DTEDLN";

        /// <summary>
        /// DTEDST.
        /// </summary>
        public const string DTEDST = "DTEDST";

        /// <summary>
        /// DTEDFT.
        /// </summary>
        public const string DTEDFT = "DTEDFT";

        /// <summary>
        /// DTEDDT.
        /// </summary>
        public const string DTEDDT = "DTEDDT";

        /// <summary>
        /// DTEDER.
        /// </summary>
        public const string DTEDER = "DTEDER";

        /// <summary>
        /// DTEDDL.
        /// </summary>
        public const string DTEDDL = "DTEDDL";

        /// <summary>
        /// DTEDSP.
        /// </summary>
        public const string DTEDSP = "DTEDSP";

        /// <summary>
        /// DTEDBT.
        /// </summary>
        public const string DTEDBT = "DTEDBT";

        /// <summary>
        /// DTPNID.
        /// </summary>
        public const string DTPNID = "DTPNID";

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
        /// DTSFXO.
        /// </summary>
        public const string DTSFXO = "DTSFXO";

        /// <summary>
        /// DTTUPRC.
        /// </summary>
        public const string DTTUPRC = "DTTUPRC";

        /// <summary>
        /// DTTAEXP.
        /// </summary>
        public const string DTTAEXP = "DTTAEXP";

        /// <summary>
        /// DTTFUP.
        /// </summary>
        public const string DTTFUP = "DTTFUP";

        /// <summary>
        /// DTTFEA.
        /// </summary>
        public const string DTTFEA = "DTTFEA";

        /// <summary>
        /// DTTPROV.
        /// </summary>
        public const string DTTPROV = "DTTPROV";

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
    public override string TableName => "F47132TX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTEDTY", "DTEDTY", JdeDataType.String, 2),
        new JdeField("DTEDSQ", "DTEDSQ", JdeDataType.Numeric),
        new JdeField("DTEKCO", "DTEKCO", JdeDataType.String, 10, true, true),
        new JdeField("DTEDOC", "DTEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DTEDCT", "DTEDCT", JdeDataType.String, 4, true, true),
        new JdeField("DTEDLN", "DTEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("DTEDST", "DTEDST", JdeDataType.String, 12),
        new JdeField("DTEDFT", "DTEDFT", JdeDataType.String, 20),
        new JdeField("DTEDDT", "DTEDDT", JdeDataType.Numeric),
        new JdeField("DTEDER", "DTEDER", JdeDataType.String, 2),
        new JdeField("DTEDDL", "DTEDDL", JdeDataType.Numeric),
        new JdeField("DTEDSP", "DTEDSP", JdeDataType.String, 2),
        new JdeField("DTEDBT", "DTEDBT", JdeDataType.String, 30),
        new JdeField("DTPNID", "DTPNID", JdeDataType.String, 30),
        new JdeField("DTKCOO", "DTKCOO", JdeDataType.String, 10),
        new JdeField("DTDOCO", "DTDOCO", JdeDataType.Numeric),
        new JdeField("DTDCTO", "DTDCTO", JdeDataType.String, 4),
        new JdeField("DTLNID", "DTLNID", JdeDataType.Numeric),
        new JdeField("DTSFXO", "DTSFXO", JdeDataType.String, 6),
        new JdeField("DTTUPRC", "DTTUPRC", JdeDataType.Numeric),
        new JdeField("DTTAEXP", "DTTAEXP", JdeDataType.Numeric),
        new JdeField("DTTFUP", "DTTFUP", JdeDataType.Numeric),
        new JdeField("DTTFEA", "DTTFEA", JdeDataType.Numeric),
        new JdeField("DTTPROV", "DTTPROV", JdeDataType.String, 2),
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
        new JdeIndex("F47132TX_0", "Primary Key on DTEDOC, DTEDCT, DTEKCO, DTEDLN", new[] { "DTEDOC", "DTEDCT", "DTEKCO", "DTEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
