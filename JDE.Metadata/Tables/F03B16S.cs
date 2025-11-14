using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B16S - .
/// </summary>
public class F03B16S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RSAN8.
        /// </summary>
        public const string RSAN8 = "RSAN8";

        /// <summary>
        /// RSPART.
        /// </summary>
        public const string RSPART = "RSPART";

        /// <summary>
        /// RSCO.
        /// </summary>
        public const string RSCO = "RSCO";

        /// <summary>
        /// RSENBL.
        /// </summary>
        public const string RSENBL = "RSENBL";

        /// <summary>
        /// RSAHB.
        /// </summary>
        public const string RSAHB = "RSAHB";

        /// <summary>
        /// RSDHBJ.
        /// </summary>
        public const string RSDHBJ = "RSDHBJ";

        /// <summary>
        /// RSACLH.
        /// </summary>
        public const string RSACLH = "RSACLH";

        /// <summary>
        /// RSAVDL.
        /// </summary>
        public const string RSAVDL = "RSAVDL";

        /// <summary>
        /// RSAVDN.
        /// </summary>
        public const string RSAVDN = "RSAVDN";

        /// <summary>
        /// RSAG.
        /// </summary>
        public const string RSAG = "RSAG";

        /// <summary>
        /// RSNINV.
        /// </summary>
        public const string RSNINV = "RSNINV";

        /// <summary>
        /// RSSAG.
        /// </summary>
        public const string RSSAG = "RSSAG";

        /// <summary>
        /// RSCREE.
        /// </summary>
        public const string RSCREE = "RSCREE";

        /// <summary>
        /// RSADSC.
        /// </summary>
        public const string RSADSC = "RSADSC";

        /// <summary>
        /// RSDFEE.
        /// </summary>
        public const string RSDFEE = "RSDFEE";

        /// <summary>
        /// RSECBA.
        /// </summary>
        public const string RSECBA = "RSECBA";

        /// <summary>
        /// RSNCB.
        /// </summary>
        public const string RSNCB = "RSNCB";

        /// <summary>
        /// RSDFIJ.
        /// </summary>
        public const string RSDFIJ = "RSDFIJ";

        /// <summary>
        /// RSDLIJ.
        /// </summary>
        public const string RSDLIJ = "RSDLIJ";

        /// <summary>
        /// RSDT1J.
        /// </summary>
        public const string RSDT1J = "RSDT1J";

        /// <summary>
        /// RSASTY.
        /// </summary>
        public const string RSASTY = "RSASTY";

        /// <summary>
        /// RSSPYE.
        /// </summary>
        public const string RSSPYE = "RSSPYE";

        /// <summary>
        /// RSPAAP.
        /// </summary>
        public const string RSPAAP = "RSPAAP";

        /// <summary>
        /// RSEDSC.
        /// </summary>
        public const string RSEDSC = "RSEDSC";

        /// <summary>
        /// RSUDSC.
        /// </summary>
        public const string RSUDSC = "RSUDSC";

        /// <summary>
        /// RSNINP.
        /// </summary>
        public const string RSNINP = "RSNINP";

        /// <summary>
        /// RSAIPL.
        /// </summary>
        public const string RSAIPL = "RSAIPL";

        /// <summary>
        /// RSNIPL.
        /// </summary>
        public const string RSNIPL = "RSNIPL";

        /// <summary>
        /// RSDDCA.
        /// </summary>
        public const string RSDDCA = "RSDDCA";

        /// <summary>
        /// RSDDCN.
        /// </summary>
        public const string RSDDCN = "RSDDCN";

        /// <summary>
        /// RSMWO.
        /// </summary>
        public const string RSMWO = "RSMWO";

        /// <summary>
        /// RSBDBT.
        /// </summary>
        public const string RSBDBT = "RSBDBT";

        /// <summary>
        /// RSANSF.
        /// </summary>
        public const string RSANSF = "RSANSF";

        /// <summary>
        /// RSNNSF.
        /// </summary>
        public const string RSNNSF = "RSNNSF";

        /// <summary>
        /// RSDLP.
        /// </summary>
        public const string RSDLP = "RSDLP";

        /// <summary>
        /// RSALP.
        /// </summary>
        public const string RSALP = "RSALP";

        /// <summary>
        /// RSNXPD.
        /// </summary>
        public const string RSNXPD = "RSNXPD";

        /// <summary>
        /// RSNBR1.
        /// </summary>
        public const string RSNBR1 = "RSNBR1";

        /// <summary>
        /// RSDLQJ.
        /// </summary>
        public const string RSDLQJ = "RSDLQJ";

        /// <summary>
        /// RSCRCD.
        /// </summary>
        public const string RSCRCD = "RSCRCD";

        /// <summary>
        /// RSCMGR.
        /// </summary>
        public const string RSCMGR = "RSCMGR";

        /// <summary>
        /// RSCLMG.
        /// </summary>
        public const string RSCLMG = "RSCLMG";

        /// <summary>
        /// RSUSER.
        /// </summary>
        public const string RSUSER = "RSUSER";

        /// <summary>
        /// RSPID.
        /// </summary>
        public const string RSPID = "RSPID";

        /// <summary>
        /// RSUPMJ.
        /// </summary>
        public const string RSUPMJ = "RSUPMJ";

        /// <summary>
        /// RSUPMT.
        /// </summary>
        public const string RSUPMT = "RSUPMT";

        /// <summary>
        /// RSJOBN.
        /// </summary>
        public const string RSJOBN = "RSJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B16S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RSAN8", "RSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RSPART", "RSPART", JdeDataType.String, 2, true, true),
        new JdeField("RSCO", "RSCO", JdeDataType.String, 10, true, true),
        new JdeField("RSENBL", "RSENBL", JdeDataType.Numeric),
        new JdeField("RSAHB", "RSAHB", JdeDataType.Numeric),
        new JdeField("RSDHBJ", "RSDHBJ", JdeDataType.Numeric),
        new JdeField("RSACLH", "RSACLH", JdeDataType.Numeric),
        new JdeField("RSAVDL", "RSAVDL", JdeDataType.Numeric),
        new JdeField("RSAVDN", "RSAVDN", JdeDataType.Numeric),
        new JdeField("RSAG", "RSAG", JdeDataType.Numeric),
        new JdeField("RSNINV", "RSNINV", JdeDataType.Numeric),
        new JdeField("RSSAG", "RSSAG", JdeDataType.Numeric),
        new JdeField("RSCREE", "RSCREE", JdeDataType.Numeric),
        new JdeField("RSADSC", "RSADSC", JdeDataType.Numeric),
        new JdeField("RSDFEE", "RSDFEE", JdeDataType.Numeric),
        new JdeField("RSECBA", "RSECBA", JdeDataType.Numeric),
        new JdeField("RSNCB", "RSNCB", JdeDataType.Numeric),
        new JdeField("RSDFIJ", "RSDFIJ", JdeDataType.Numeric),
        new JdeField("RSDLIJ", "RSDLIJ", JdeDataType.Numeric),
        new JdeField("RSDT1J", "RSDT1J", JdeDataType.Numeric),
        new JdeField("RSASTY", "RSASTY", JdeDataType.Numeric),
        new JdeField("RSSPYE", "RSSPYE", JdeDataType.Numeric),
        new JdeField("RSPAAP", "RSPAAP", JdeDataType.Numeric),
        new JdeField("RSEDSC", "RSEDSC", JdeDataType.Numeric),
        new JdeField("RSUDSC", "RSUDSC", JdeDataType.Numeric),
        new JdeField("RSNINP", "RSNINP", JdeDataType.Numeric),
        new JdeField("RSAIPL", "RSAIPL", JdeDataType.Numeric),
        new JdeField("RSNIPL", "RSNIPL", JdeDataType.Numeric),
        new JdeField("RSDDCA", "RSDDCA", JdeDataType.Numeric),
        new JdeField("RSDDCN", "RSDDCN", JdeDataType.Numeric),
        new JdeField("RSMWO", "RSMWO", JdeDataType.Numeric),
        new JdeField("RSBDBT", "RSBDBT", JdeDataType.Numeric),
        new JdeField("RSANSF", "RSANSF", JdeDataType.Numeric),
        new JdeField("RSNNSF", "RSNNSF", JdeDataType.Numeric),
        new JdeField("RSDLP", "RSDLP", JdeDataType.Numeric),
        new JdeField("RSALP", "RSALP", JdeDataType.Numeric),
        new JdeField("RSNXPD", "RSNXPD", JdeDataType.Numeric),
        new JdeField("RSNBR1", "RSNBR1", JdeDataType.Numeric),
        new JdeField("RSDLQJ", "RSDLQJ", JdeDataType.Numeric),
        new JdeField("RSCRCD", "RSCRCD", JdeDataType.String, 6),
        new JdeField("RSCMGR", "RSCMGR", JdeDataType.String, 20),
        new JdeField("RSCLMG", "RSCLMG", JdeDataType.String, 20),
        new JdeField("RSUSER", "RSUSER", JdeDataType.String, 20),
        new JdeField("RSPID", "RSPID", JdeDataType.String, 20),
        new JdeField("RSUPMJ", "RSUPMJ", JdeDataType.Numeric),
        new JdeField("RSUPMT", "RSUPMT", JdeDataType.Numeric),
        new JdeField("RSJOBN", "RSJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B16S_0", "Primary Key on RSAN8, RSCO, RSPART", new[] { "RSAN8", "RSCO", "RSPART" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B16S_2", "Index on RSCO", new[] { "RSCO" })
    };
}
