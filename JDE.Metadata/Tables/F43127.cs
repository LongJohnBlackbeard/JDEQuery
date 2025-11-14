using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43127 - .
/// </summary>
public class F43127 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRMATC.
        /// </summary>
        public const string PRMATC = "PRMATC";

        /// <summary>
        /// PRKCOO.
        /// </summary>
        public const string PRKCOO = "PRKCOO";

        /// <summary>
        /// PRDOCO.
        /// </summary>
        public const string PRDOCO = "PRDOCO";

        /// <summary>
        /// PRDCTO.
        /// </summary>
        public const string PRDCTO = "PRDCTO";

        /// <summary>
        /// PRSFXO.
        /// </summary>
        public const string PRSFXO = "PRSFXO";

        /// <summary>
        /// PRLNID.
        /// </summary>
        public const string PRLNID = "PRLNID";

        /// <summary>
        /// PRNLIN.
        /// </summary>
        public const string PRNLIN = "PRNLIN";

        /// <summary>
        /// PRDLNID.
        /// </summary>
        public const string PRDLNID = "PRDLNID";

        /// <summary>
        /// PRNBACTY.
        /// </summary>
        public const string PRNBACTY = "PRNBACTY";

        /// <summary>
        /// PRAID.
        /// </summary>
        public const string PRAID = "PRAID";

        /// <summary>
        /// PRANI.
        /// </summary>
        public const string PRANI = "PRANI";

        /// <summary>
        /// PRSBL.
        /// </summary>
        public const string PRSBL = "PRSBL";

        /// <summary>
        /// PRSBLT.
        /// </summary>
        public const string PRSBLT = "PRSBLT";

        /// <summary>
        /// PRDOC.
        /// </summary>
        public const string PRDOC = "PRDOC";

        /// <summary>
        /// PRDCT.
        /// </summary>
        public const string PRDCT = "PRDCT";

        /// <summary>
        /// PRKCO.
        /// </summary>
        public const string PRKCO = "PRKCO";

        /// <summary>
        /// PRSFX.
        /// </summary>
        public const string PRSFX = "PRSFX";

        /// <summary>
        /// PRJELN.
        /// </summary>
        public const string PRJELN = "PRJELN";

        /// <summary>
        /// PRCRCD.
        /// </summary>
        public const string PRCRCD = "PRCRCD";

        /// <summary>
        /// PRNBRETA.
        /// </summary>
        public const string PRNBRETA = "PRNBRETA";

        /// <summary>
        /// PRNBREFA.
        /// </summary>
        public const string PRNBREFA = "PRNBREFA";

        /// <summary>
        /// PRURCD.
        /// </summary>
        public const string PRURCD = "PRURCD";

        /// <summary>
        /// PRURDT.
        /// </summary>
        public const string PRURDT = "PRURDT";

        /// <summary>
        /// PRURAT.
        /// </summary>
        public const string PRURAT = "PRURAT";

        /// <summary>
        /// PRURAB.
        /// </summary>
        public const string PRURAB = "PRURAB";

        /// <summary>
        /// PRURRF.
        /// </summary>
        public const string PRURRF = "PRURRF";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PRPID.
        /// </summary>
        public const string PRPID = "PRPID";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRTORG.
        /// </summary>
        public const string PRTORG = "PRTORG";

        /// <summary>
        /// PRUUPMJ.
        /// </summary>
        public const string PRUUPMJ = "PRUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43127";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRMATC", "PRMATC", JdeDataType.String, 2, true, true),
        new JdeField("PRKCOO", "PRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PRDOCO", "PRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDCTO", "PRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PRSFXO", "PRSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PRLNID", "PRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRNLIN", "PRNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDLNID", "PRDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRNBACTY", "PRNBACTY", JdeDataType.String, 4, true, true),
        new JdeField("PRAID", "PRAID", JdeDataType.String, 16),
        new JdeField("PRANI", "PRANI", JdeDataType.String, 58),
        new JdeField("PRSBL", "PRSBL", JdeDataType.String, 16),
        new JdeField("PRSBLT", "PRSBLT", JdeDataType.String, 2),
        new JdeField("PRDOC", "PRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDCT", "PRDCT", JdeDataType.String, 4),
        new JdeField("PRKCO", "PRKCO", JdeDataType.String, 10),
        new JdeField("PRSFX", "PRSFX", JdeDataType.String, 6),
        new JdeField("PRJELN", "PRJELN", JdeDataType.Numeric),
        new JdeField("PRCRCD", "PRCRCD", JdeDataType.String, 6),
        new JdeField("PRNBRETA", "PRNBRETA", JdeDataType.Numeric),
        new JdeField("PRNBREFA", "PRNBREFA", JdeDataType.Numeric),
        new JdeField("PRURCD", "PRURCD", JdeDataType.String, 4),
        new JdeField("PRURDT", "PRURDT", JdeDataType.Numeric),
        new JdeField("PRURAT", "PRURAT", JdeDataType.Numeric),
        new JdeField("PRURAB", "PRURAB", JdeDataType.Numeric),
        new JdeField("PRURRF", "PRURRF", JdeDataType.String, 30),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PRPID", "PRPID", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRTORG", "PRTORG", JdeDataType.String, 20),
        new JdeField("PRUUPMJ", "PRUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43127_0", "Primary Key on PRMATC, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRLNID, PRNLIN, PRNBACTY, PRDLNID, PRDOC", new[] { "PRMATC", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRLNID", "PRNLIN", "PRNBACTY", "PRDLNID", "PRDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43127_2", "Index on PRMATC, PRDOC, PRDCT, PRKCO", new[] { "PRMATC", "PRDOC", "PRDCT", "PRKCO" }),
        new JdeIndex("F43127_3", "Index on PRDOC, PRDCT, PRKCO", new[] { "PRDOC", "PRDCT", "PRKCO" }),
        new JdeIndex("F43127_4", "Index on PRMATC, PRDOC, PRDCT, PRKCO, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRLNID, PRNLIN", new[] { "PRMATC", "PRDOC", "PRDCT", "PRKCO", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRLNID", "PRNLIN" }),
        new JdeIndex("F43127_5", "Index on PRNBACTY, PRDOC, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRLNID, PRDLNID, PRSFX, SYS_NC00032$, PRMATC", new[] { "PRNBACTY", "PRDOC", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRLNID", "PRDLNID", "PRSFX", "SYS_NC00032$", "PRMATC" })
    };
}
