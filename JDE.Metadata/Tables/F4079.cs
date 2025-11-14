using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4079 - .
/// </summary>
public class F4079 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVAN8.
        /// </summary>
        public const string SVAN8 = "SVAN8";

        /// <summary>
        /// SVITM.
        /// </summary>
        public const string SVITM = "SVITM";

        /// <summary>
        /// SVIGID.
        /// </summary>
        public const string SVIGID = "SVIGID";

        /// <summary>
        /// SVCGID.
        /// </summary>
        public const string SVCGID = "SVCGID";

        /// <summary>
        /// SVOGID.
        /// </summary>
        public const string SVOGID = "SVOGID";

        /// <summary>
        /// SVAST.
        /// </summary>
        public const string SVAST = "SVAST";

        /// <summary>
        /// SVEFTJ.
        /// </summary>
        public const string SVEFTJ = "SVEFTJ";

        /// <summary>
        /// SVEXDJ.
        /// </summary>
        public const string SVEXDJ = "SVEXDJ";

        /// <summary>
        /// SVDOCO.
        /// </summary>
        public const string SVDOCO = "SVDOCO";

        /// <summary>
        /// SVDCTO.
        /// </summary>
        public const string SVDCTO = "SVDCTO";

        /// <summary>
        /// SVKCOO.
        /// </summary>
        public const string SVKCOO = "SVKCOO";

        /// <summary>
        /// SVSFXO.
        /// </summary>
        public const string SVSFXO = "SVSFXO";

        /// <summary>
        /// SVLNID.
        /// </summary>
        public const string SVLNID = "SVLNID";

        /// <summary>
        /// SVTOSA.
        /// </summary>
        public const string SVTOSA = "SVTOSA";

        /// <summary>
        /// SVCRCD.
        /// </summary>
        public const string SVCRCD = "SVCRCD";

        /// <summary>
        /// SVTOQN.
        /// </summary>
        public const string SVTOQN = "SVTOQN";

        /// <summary>
        /// SVUOM.
        /// </summary>
        public const string SVUOM = "SVUOM";

        /// <summary>
        /// SVTOWT.
        /// </summary>
        public const string SVTOWT = "SVTOWT";

        /// <summary>
        /// SVWTUM.
        /// </summary>
        public const string SVWTUM = "SVWTUM";

        /// <summary>
        /// SVRORN.
        /// </summary>
        public const string SVRORN = "SVRORN";

        /// <summary>
        /// SVRCTO.
        /// </summary>
        public const string SVRCTO = "SVRCTO";

        /// <summary>
        /// SVRKCO.
        /// </summary>
        public const string SVRKCO = "SVRKCO";

        /// <summary>
        /// SVRLLN.
        /// </summary>
        public const string SVRLLN = "SVRLLN";

        /// <summary>
        /// SVURDT.
        /// </summary>
        public const string SVURDT = "SVURDT";

        /// <summary>
        /// SVURAT.
        /// </summary>
        public const string SVURAT = "SVURAT";

        /// <summary>
        /// SVURC1.
        /// </summary>
        public const string SVURC1 = "SVURC1";

        /// <summary>
        /// SVCUMQTY.
        /// </summary>
        public const string SVCUMQTY = "SVCUMQTY";

        /// <summary>
        /// SVCUMWGT.
        /// </summary>
        public const string SVCUMWGT = "SVCUMWGT";

        /// <summary>
        /// SVCUMAMT.
        /// </summary>
        public const string SVCUMAMT = "SVCUMAMT";

        /// <summary>
        /// SVORDSEQ.
        /// </summary>
        public const string SVORDSEQ = "SVORDSEQ";

        /// <summary>
        /// SVVIDCHG.
        /// </summary>
        public const string SVVIDCHG = "SVVIDCHG";

        /// <summary>
        /// SVUSER.
        /// </summary>
        public const string SVUSER = "SVUSER";

        /// <summary>
        /// SVPID.
        /// </summary>
        public const string SVPID = "SVPID";

        /// <summary>
        /// SVJOBN.
        /// </summary>
        public const string SVJOBN = "SVJOBN";

        /// <summary>
        /// SVUPMJ.
        /// </summary>
        public const string SVUPMJ = "SVUPMJ";

        /// <summary>
        /// SVTDAY.
        /// </summary>
        public const string SVTDAY = "SVTDAY";

        /// <summary>
        /// SVRUPMJ.
        /// </summary>
        public const string SVRUPMJ = "SVRUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4079";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVAN8", "SVAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SVITM", "SVITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SVIGID", "SVIGID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVCGID", "SVCGID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVOGID", "SVOGID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVAST", "SVAST", JdeDataType.String, 16, true, true),
        new JdeField("SVEFTJ", "SVEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SVEXDJ", "SVEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SVDOCO", "SVDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SVDCTO", "SVDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SVKCOO", "SVKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SVSFXO", "SVSFXO", JdeDataType.String, 6, true, true),
        new JdeField("SVLNID", "SVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SVTOSA", "SVTOSA", JdeDataType.Numeric),
        new JdeField("SVCRCD", "SVCRCD", JdeDataType.String, 6),
        new JdeField("SVTOQN", "SVTOQN", JdeDataType.Numeric),
        new JdeField("SVUOM", "SVUOM", JdeDataType.String, 4),
        new JdeField("SVTOWT", "SVTOWT", JdeDataType.Numeric),
        new JdeField("SVWTUM", "SVWTUM", JdeDataType.String, 4),
        new JdeField("SVRORN", "SVRORN", JdeDataType.String, 16),
        new JdeField("SVRCTO", "SVRCTO", JdeDataType.String, 4),
        new JdeField("SVRKCO", "SVRKCO", JdeDataType.String, 10),
        new JdeField("SVRLLN", "SVRLLN", JdeDataType.Numeric),
        new JdeField("SVURDT", "SVURDT", JdeDataType.Numeric),
        new JdeField("SVURAT", "SVURAT", JdeDataType.Numeric),
        new JdeField("SVURC1", "SVURC1", JdeDataType.String, 6),
        new JdeField("SVCUMQTY", "SVCUMQTY", JdeDataType.Numeric),
        new JdeField("SVCUMWGT", "SVCUMWGT", JdeDataType.Numeric),
        new JdeField("SVCUMAMT", "SVCUMAMT", JdeDataType.Numeric),
        new JdeField("SVORDSEQ", "SVORDSEQ", JdeDataType.Numeric),
        new JdeField("SVVIDCHG", "SVVIDCHG", JdeDataType.String, 2),
        new JdeField("SVUSER", "SVUSER", JdeDataType.String, 20),
        new JdeField("SVPID", "SVPID", JdeDataType.String, 20),
        new JdeField("SVJOBN", "SVJOBN", JdeDataType.String, 20),
        new JdeField("SVUPMJ", "SVUPMJ", JdeDataType.Numeric),
        new JdeField("SVTDAY", "SVTDAY", JdeDataType.Numeric),
        new JdeField("SVRUPMJ", "SVRUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4079_0", "Primary Key on SVAN8, SVITM, SVIGID, SVCGID, SVOGID, SVAST, SVEFTJ, SVEXDJ, SVDOCO, SVDCTO, SVKCOO, SVSFXO, SVLNID", new[] { "SVAN8", "SVITM", "SVIGID", "SVCGID", "SVOGID", "SVAST", "SVEFTJ", "SVEXDJ", "SVDOCO", "SVDCTO", "SVKCOO", "SVSFXO", "SVLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4079_2", "Index on SVAN8, SVITM, SVIGID, SVCGID, SVOGID, SVEFTJ, SVAST, SVEXDJ", new[] { "SVAN8", "SVITM", "SVIGID", "SVCGID", "SVOGID", "SVEFTJ", "SVAST", "SVEXDJ" }),
        new JdeIndex("F4079_3", "Index on SVAN8, SVITM, SVIGID, SVCGID, SVOGID, SVAST, SVEFTJ, SVEXDJ, SVORDSEQ, SVLNID", new[] { "SVAN8", "SVITM", "SVIGID", "SVCGID", "SVOGID", "SVAST", "SVEFTJ", "SVEXDJ", "SVORDSEQ", "SVLNID" }),
        new JdeIndex("F4079_4", "Index on SYS_NC00038$, SVAN8, SVITM, SVIGID, SVCGID, SVOGID, SVAST, SVEFTJ, SVEXDJ, SVORDSEQ", new[] { "SYS_NC00038$", "SVAN8", "SVITM", "SVIGID", "SVCGID", "SVOGID", "SVAST", "SVEFTJ", "SVEXDJ", "SVORDSEQ" }),
        new JdeIndex("F4079_5", "Index on SVDOCO, SVDCTO, SVKCOO, SVSFXO, SVLNID", new[] { "SVDOCO", "SVDCTO", "SVKCOO", "SVSFXO", "SVLNID" })
    };
}
