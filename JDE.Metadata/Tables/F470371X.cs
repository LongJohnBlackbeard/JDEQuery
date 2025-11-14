using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470371X - .
/// </summary>
public class F470371X : JdeTable
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
        /// DTEDOC.
        /// </summary>
        public const string DTEDOC = "DTEDOC";

        /// <summary>
        /// DTEKCO.
        /// </summary>
        public const string DTEKCO = "DTEKCO";

        /// <summary>
        /// DTEDCT.
        /// </summary>
        public const string DTEDCT = "DTEDCT";

        /// <summary>
        /// DTEDLN.
        /// </summary>
        public const string DTEDLN = "DTEDLN";

        /// <summary>
        /// DTSTPC.
        /// </summary>
        public const string DTSTPC = "DTSTPC";

        /// <summary>
        /// DTANTY.
        /// </summary>
        public const string DTANTY = "DTANTY";

        /// <summary>
        /// DTLINS.
        /// </summary>
        public const string DTLINS = "DTLINS";

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
        /// DTHLVL.
        /// </summary>
        public const string DTHLVL = "DTHLVL";

        /// <summary>
        /// DTHL03.
        /// </summary>
        public const string DTHL03 = "DTHL03";

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
    public override string TableName => "F470371X";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTEDTY", "DTEDTY", JdeDataType.String, 2),
        new JdeField("DTEDSQ", "DTEDSQ", JdeDataType.Numeric),
        new JdeField("DTEDOC", "DTEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("DTEKCO", "DTEKCO", JdeDataType.String, 10, true, true),
        new JdeField("DTEDCT", "DTEDCT", JdeDataType.String, 4, true, true),
        new JdeField("DTEDLN", "DTEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("DTSTPC", "DTSTPC", JdeDataType.String, 2, true, true),
        new JdeField("DTANTY", "DTANTY", JdeDataType.String, 2, true, true),
        new JdeField("DTLINS", "DTLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("DTEDST", "DTEDST", JdeDataType.String, 12),
        new JdeField("DTEDFT", "DTEDFT", JdeDataType.String, 20),
        new JdeField("DTEDDT", "DTEDDT", JdeDataType.Numeric),
        new JdeField("DTEDER", "DTEDER", JdeDataType.String, 2),
        new JdeField("DTEDDL", "DTEDDL", JdeDataType.Numeric),
        new JdeField("DTEDSP", "DTEDSP", JdeDataType.String, 2),
        new JdeField("DTEDBT", "DTEDBT", JdeDataType.String, 30),
        new JdeField("DTPNID", "DTPNID", JdeDataType.String, 30),
        new JdeField("DTHLVL", "DTHLVL", JdeDataType.Numeric),
        new JdeField("DTHL03", "DTHL03", JdeDataType.String, 4),
        new JdeField("DTKCOO", "DTKCOO", JdeDataType.String, 10),
        new JdeField("DTDOCO", "DTDOCO", JdeDataType.Numeric),
        new JdeField("DTDCTO", "DTDCTO", JdeDataType.String, 4),
        new JdeField("DTLNID", "DTLNID", JdeDataType.Numeric),
        new JdeField("DTSFXO", "DTSFXO", JdeDataType.String, 6),
        new JdeField("DTTUPRC", "DTTUPRC", JdeDataType.Numeric),
        new JdeField("DTTAEXP", "DTTAEXP", JdeDataType.Numeric),
        new JdeField("DTTFUP", "DTTFUP", JdeDataType.Numeric),
        new JdeField("DTTFEA", "DTTFEA", JdeDataType.Numeric),
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
        new JdeIndex("F470371X_0", "Primary Key on DTEDOC, DTEDCT, DTEKCO, DTEDLN, DTSTPC, DTANTY, DTLINS", new[] { "DTEDOC", "DTEDCT", "DTEKCO", "DTEDLN", "DTSTPC", "DTANTY", "DTLINS" }, isUnique: true, isPrimaryKey: true)
    };
}
