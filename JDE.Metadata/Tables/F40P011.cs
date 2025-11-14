using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40P011 - .
/// </summary>
public class F40P011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDDIDP.
        /// </summary>
        public const string PDDIDP = "PDDIDP";

        /// <summary>
        /// PDPMTN.
        /// </summary>
        public const string PDPMTN = "PDPMTN";

        /// <summary>
        /// PDDESC.
        /// </summary>
        public const string PDDESC = "PDDESC";

        /// <summary>
        /// PDDEALSTS.
        /// </summary>
        public const string PDDEALSTS = "PDDEALSTS";

        /// <summary>
        /// PDAN8.
        /// </summary>
        public const string PDAN8 = "PDAN8";

        /// <summary>
        /// PDITM.
        /// </summary>
        public const string PDITM = "PDITM";

        /// <summary>
        /// PDACNT.
        /// </summary>
        public const string PDACNT = "PDACNT";

        /// <summary>
        /// PDBSCD.
        /// </summary>
        public const string PDBSCD = "PDBSCD";

        /// <summary>
        /// PDFVTR.
        /// </summary>
        public const string PDFVTR = "PDFVTR";

        /// <summary>
        /// PDUOME1.
        /// </summary>
        public const string PDUOME1 = "PDUOME1";

        /// <summary>
        /// PDCRCD.
        /// </summary>
        public const string PDCRCD = "PDCRCD";

        /// <summary>
        /// PDESTLIFT.
        /// </summary>
        public const string PDESTLIFT = "PDESTLIFT";

        /// <summary>
        /// PDESTQTY.
        /// </summary>
        public const string PDESTQTY = "PDESTQTY";

        /// <summary>
        /// PDUOM.
        /// </summary>
        public const string PDUOM = "PDUOM";

        /// <summary>
        /// PDTACTIC1.
        /// </summary>
        public const string PDTACTIC1 = "PDTACTIC1";

        /// <summary>
        /// PDTACTIC2.
        /// </summary>
        public const string PDTACTIC2 = "PDTACTIC2";

        /// <summary>
        /// PDTACTIC3.
        /// </summary>
        public const string PDTACTIC3 = "PDTACTIC3";

        /// <summary>
        /// PDTACTIC4.
        /// </summary>
        public const string PDTACTIC4 = "PDTACTIC4";

        /// <summary>
        /// PDDEALREF1.
        /// </summary>
        public const string PDDEALREF1 = "PDDEALREF1";

        /// <summary>
        /// PDDEALREF2.
        /// </summary>
        public const string PDDEALREF2 = "PDDEALREF2";

        /// <summary>
        /// PDGPC1.
        /// </summary>
        public const string PDGPC1 = "PDGPC1";

        /// <summary>
        /// PDGPC2.
        /// </summary>
        public const string PDGPC2 = "PDGPC2";

        /// <summary>
        /// PDEFTJ.
        /// </summary>
        public const string PDEFTJ = "PDEFTJ";

        /// <summary>
        /// PDEXDJ.
        /// </summary>
        public const string PDEXDJ = "PDEXDJ";

        /// <summary>
        /// PDPRADJIND.
        /// </summary>
        public const string PDPRADJIND = "PDPRADJIND";

        /// <summary>
        /// PDEXPFLAG.
        /// </summary>
        public const string PDEXPFLAG = "PDEXPFLAG";

        /// <summary>
        /// PDCOSA.
        /// </summary>
        public const string PDCOSA = "PDCOSA";

        /// <summary>
        /// PDEXSA.
        /// </summary>
        public const string PDEXSA = "PDEXSA";

        /// <summary>
        /// PDNOSA.
        /// </summary>
        public const string PDNOSA = "PDNOSA";

        /// <summary>
        /// PDNIB.
        /// </summary>
        public const string PDNIB = "PDNIB";

        /// <summary>
        /// PDNID.
        /// </summary>
        public const string PDNID = "PDNID";

        /// <summary>
        /// PDNIA.
        /// </summary>
        public const string PDNIA = "PDNIA";

        /// <summary>
        /// PDNIPF.
        /// </summary>
        public const string PDNIPF = "PDNIPF";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDFUTUSE12.
        /// </summary>
        public const string PDFUTUSE12 = "PDFUTUSE12";

        /// <summary>
        /// PDFUTUSE13.
        /// </summary>
        public const string PDFUTUSE13 = "PDFUTUSE13";

        /// <summary>
        /// PDFUTUSE14.
        /// </summary>
        public const string PDFUTUSE14 = "PDFUTUSE14";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDTDAY.
        /// </summary>
        public const string PDTDAY = "PDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40P011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDDIDP", "PDDIDP", JdeDataType.String, 24, true, true),
        new JdeField("PDPMTN", "PDPMTN", JdeDataType.String, 24, true, true),
        new JdeField("PDDESC", "PDDESC", JdeDataType.String, 60),
        new JdeField("PDDEALSTS", "PDDEALSTS", JdeDataType.String, 4),
        new JdeField("PDAN8", "PDAN8", JdeDataType.Numeric),
        new JdeField("PDITM", "PDITM", JdeDataType.Numeric),
        new JdeField("PDACNT", "PDACNT", JdeDataType.String, 2),
        new JdeField("PDBSCD", "PDBSCD", JdeDataType.String, 2),
        new JdeField("PDFVTR", "PDFVTR", JdeDataType.Numeric),
        new JdeField("PDUOME1", "PDUOME1", JdeDataType.String, 4),
        new JdeField("PDCRCD", "PDCRCD", JdeDataType.String, 6),
        new JdeField("PDESTLIFT", "PDESTLIFT", JdeDataType.Numeric),
        new JdeField("PDESTQTY", "PDESTQTY", JdeDataType.Numeric),
        new JdeField("PDUOM", "PDUOM", JdeDataType.String, 4),
        new JdeField("PDTACTIC1", "PDTACTIC1", JdeDataType.String, 4),
        new JdeField("PDTACTIC2", "PDTACTIC2", JdeDataType.String, 4),
        new JdeField("PDTACTIC3", "PDTACTIC3", JdeDataType.String, 4),
        new JdeField("PDTACTIC4", "PDTACTIC4", JdeDataType.String, 4),
        new JdeField("PDDEALREF1", "PDDEALREF1", JdeDataType.String, 60),
        new JdeField("PDDEALREF2", "PDDEALREF2", JdeDataType.String, 60),
        new JdeField("PDGPC1", "PDGPC1", JdeDataType.String, 12),
        new JdeField("PDGPC2", "PDGPC2", JdeDataType.String, 12),
        new JdeField("PDEFTJ", "PDEFTJ", JdeDataType.Numeric),
        new JdeField("PDEXDJ", "PDEXDJ", JdeDataType.Numeric),
        new JdeField("PDPRADJIND", "PDPRADJIND", JdeDataType.Numeric),
        new JdeField("PDEXPFLAG", "PDEXPFLAG", JdeDataType.Numeric),
        new JdeField("PDCOSA", "PDCOSA", JdeDataType.Numeric),
        new JdeField("PDEXSA", "PDEXSA", JdeDataType.Numeric),
        new JdeField("PDNOSA", "PDNOSA", JdeDataType.Numeric),
        new JdeField("PDNIB", "PDNIB", JdeDataType.Numeric),
        new JdeField("PDNID", "PDNID", JdeDataType.Numeric),
        new JdeField("PDNIA", "PDNIA", JdeDataType.Numeric),
        new JdeField("PDNIPF", "PDNIPF", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDFUTUSE12", "PDFUTUSE12", JdeDataType.String, 8),
        new JdeField("PDFUTUSE13", "PDFUTUSE13", JdeDataType.String, 8),
        new JdeField("PDFUTUSE14", "PDFUTUSE14", JdeDataType.String, 8),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDTDAY", "PDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40P011_0", "Primary Key on PDPMTN, PDDIDP", new[] { "PDPMTN", "PDDIDP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40P011_2", "Index on PDAN8, PDITM, PDEFTJ", new[] { "PDAN8", "PDITM", "PDEFTJ" })
    };
}
