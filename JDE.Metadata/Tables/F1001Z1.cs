using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1001Z1 - .
/// </summary>
public class F1001Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IAEDUS.
        /// </summary>
        public const string IAEDUS = "IAEDUS";

        /// <summary>
        /// IAEDBT.
        /// </summary>
        public const string IAEDBT = "IAEDBT";

        /// <summary>
        /// IAEDTN.
        /// </summary>
        public const string IAEDTN = "IAEDTN";

        /// <summary>
        /// IAEDLN.
        /// </summary>
        public const string IAEDLN = "IAEDLN";

        /// <summary>
        /// IAEDCT.
        /// </summary>
        public const string IAEDCT = "IAEDCT";

        /// <summary>
        /// IATYTN.
        /// </summary>
        public const string IATYTN = "IATYTN";

        /// <summary>
        /// IAEDFT.
        /// </summary>
        public const string IAEDFT = "IAEDFT";

        /// <summary>
        /// IAEDDT.
        /// </summary>
        public const string IAEDDT = "IAEDDT";

        /// <summary>
        /// IADRIN.
        /// </summary>
        public const string IADRIN = "IADRIN";

        /// <summary>
        /// IAEDDL.
        /// </summary>
        public const string IAEDDL = "IAEDDL";

        /// <summary>
        /// IAEDSP.
        /// </summary>
        public const string IAEDSP = "IAEDSP";

        /// <summary>
        /// IAPNID.
        /// </summary>
        public const string IAPNID = "IAPNID";

        /// <summary>
        /// IATNAC.
        /// </summary>
        public const string IATNAC = "IATNAC";

        /// <summary>
        /// IATRFG.
        /// </summary>
        public const string IATRFG = "IATRFG";

        /// <summary>
        /// IATRSE.
        /// </summary>
        public const string IATRSE = "IATRSE";

        /// <summary>
        /// IADTSE.
        /// </summary>
        public const string IADTSE = "IADTSE";

        /// <summary>
        /// IATRRC.
        /// </summary>
        public const string IATRRC = "IATRRC";

        /// <summary>
        /// IADTRI.
        /// </summary>
        public const string IADTRI = "IADTRI";

        /// <summary>
        /// IACCSE.
        /// </summary>
        public const string IACCSE = "IACCSE";

        /// <summary>
        /// IACNAM.
        /// </summary>
        public const string IACNAM = "IACNAM";

        /// <summary>
        /// IAPN.
        /// </summary>
        public const string IAPN = "IAPN";

        /// <summary>
        /// IAFY.
        /// </summary>
        public const string IAFY = "IAFY";

        /// <summary>
        /// IACTRY.
        /// </summary>
        public const string IACTRY = "IACTRY";

        /// <summary>
        /// IALT.
        /// </summary>
        public const string IALT = "IALT";

        /// <summary>
        /// IACO.
        /// </summary>
        public const string IACO = "IACO";

        /// <summary>
        /// IAIN01.
        /// </summary>
        public const string IAIN01 = "IAIN01";

        /// <summary>
        /// IAIN02.
        /// </summary>
        public const string IAIN02 = "IAIN02";

        /// <summary>
        /// IAIN03.
        /// </summary>
        public const string IAIN03 = "IAIN03";

        /// <summary>
        /// IAIN04.
        /// </summary>
        public const string IAIN04 = "IAIN04";

        /// <summary>
        /// IAIN05.
        /// </summary>
        public const string IAIN05 = "IAIN05";

        /// <summary>
        /// IAIN06.
        /// </summary>
        public const string IAIN06 = "IAIN06";

        /// <summary>
        /// IAIN07.
        /// </summary>
        public const string IAIN07 = "IAIN07";

        /// <summary>
        /// IAIN08.
        /// </summary>
        public const string IAIN08 = "IAIN08";

        /// <summary>
        /// IAIN09.
        /// </summary>
        public const string IAIN09 = "IAIN09";

        /// <summary>
        /// IAIN10.
        /// </summary>
        public const string IAIN10 = "IAIN10";

        /// <summary>
        /// IAIN11.
        /// </summary>
        public const string IAIN11 = "IAIN11";

        /// <summary>
        /// IAIN12.
        /// </summary>
        public const string IAIN12 = "IAIN12";

        /// <summary>
        /// IAURDT.
        /// </summary>
        public const string IAURDT = "IAURDT";

        /// <summary>
        /// IAURRF.
        /// </summary>
        public const string IAURRF = "IAURRF";

        /// <summary>
        /// IAURCD.
        /// </summary>
        public const string IAURCD = "IAURCD";

        /// <summary>
        /// IAURC1.
        /// </summary>
        public const string IAURC1 = "IAURC1";

        /// <summary>
        /// IAURC2.
        /// </summary>
        public const string IAURC2 = "IAURC2";

        /// <summary>
        /// IAURAT.
        /// </summary>
        public const string IAURAT = "IAURAT";

        /// <summary>
        /// IAURAB.
        /// </summary>
        public const string IAURAB = "IAURAB";

        /// <summary>
        /// IATORG.
        /// </summary>
        public const string IATORG = "IATORG";

        /// <summary>
        /// IAUSER.
        /// </summary>
        public const string IAUSER = "IAUSER";

        /// <summary>
        /// IAPID.
        /// </summary>
        public const string IAPID = "IAPID";

        /// <summary>
        /// IAVERS.
        /// </summary>
        public const string IAVERS = "IAVERS";

        /// <summary>
        /// IAJOBN.
        /// </summary>
        public const string IAJOBN = "IAJOBN";

        /// <summary>
        /// IAUPMJ.
        /// </summary>
        public const string IAUPMJ = "IAUPMJ";

        /// <summary>
        /// IAUPMT.
        /// </summary>
        public const string IAUPMT = "IAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1001Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IAEDUS", "IAEDUS", JdeDataType.String, 20, true, true),
        new JdeField("IAEDBT", "IAEDBT", JdeDataType.String, 30, true, true),
        new JdeField("IAEDTN", "IAEDTN", JdeDataType.String, 44, true, true),
        new JdeField("IAEDLN", "IAEDLN", JdeDataType.Numeric),
        new JdeField("IAEDCT", "IAEDCT", JdeDataType.String, 4),
        new JdeField("IATYTN", "IATYTN", JdeDataType.String, 16),
        new JdeField("IAEDFT", "IAEDFT", JdeDataType.String, 20),
        new JdeField("IAEDDT", "IAEDDT", JdeDataType.Numeric),
        new JdeField("IADRIN", "IADRIN", JdeDataType.String, 2),
        new JdeField("IAEDDL", "IAEDDL", JdeDataType.Numeric),
        new JdeField("IAEDSP", "IAEDSP", JdeDataType.String, 2),
        new JdeField("IAPNID", "IAPNID", JdeDataType.String, 30),
        new JdeField("IATNAC", "IATNAC", JdeDataType.String, 4),
        new JdeField("IATRFG", "IATRFG", JdeDataType.String, 2),
        new JdeField("IATRSE", "IATRSE", JdeDataType.Numeric),
        new JdeField("IADTSE", "IADTSE", JdeDataType.Numeric),
        new JdeField("IATRRC", "IATRRC", JdeDataType.Numeric),
        new JdeField("IADTRI", "IADTRI", JdeDataType.Numeric),
        new JdeField("IACCSE", "IACCSE", JdeDataType.String, 2),
        new JdeField("IACNAM", "IACNAM", JdeDataType.String, 6),
        new JdeField("IAPN", "IAPN", JdeDataType.Numeric),
        new JdeField("IAFY", "IAFY", JdeDataType.Numeric),
        new JdeField("IACTRY", "IACTRY", JdeDataType.Numeric),
        new JdeField("IALT", "IALT", JdeDataType.String, 4),
        new JdeField("IACO", "IACO", JdeDataType.String, 10),
        new JdeField("IAIN01", "IAIN01", JdeDataType.String, 2),
        new JdeField("IAIN02", "IAIN02", JdeDataType.String, 2),
        new JdeField("IAIN03", "IAIN03", JdeDataType.String, 2),
        new JdeField("IAIN04", "IAIN04", JdeDataType.String, 2),
        new JdeField("IAIN05", "IAIN05", JdeDataType.String, 2),
        new JdeField("IAIN06", "IAIN06", JdeDataType.String, 2),
        new JdeField("IAIN07", "IAIN07", JdeDataType.String, 2),
        new JdeField("IAIN08", "IAIN08", JdeDataType.String, 2),
        new JdeField("IAIN09", "IAIN09", JdeDataType.String, 2),
        new JdeField("IAIN10", "IAIN10", JdeDataType.String, 2),
        new JdeField("IAIN11", "IAIN11", JdeDataType.String, 2),
        new JdeField("IAIN12", "IAIN12", JdeDataType.String, 2),
        new JdeField("IAURDT", "IAURDT", JdeDataType.Numeric),
        new JdeField("IAURRF", "IAURRF", JdeDataType.String, 30),
        new JdeField("IAURCD", "IAURCD", JdeDataType.String, 4),
        new JdeField("IAURC1", "IAURC1", JdeDataType.String, 6),
        new JdeField("IAURC2", "IAURC2", JdeDataType.String, 20),
        new JdeField("IAURAT", "IAURAT", JdeDataType.Numeric),
        new JdeField("IAURAB", "IAURAB", JdeDataType.Numeric),
        new JdeField("IATORG", "IATORG", JdeDataType.String, 20),
        new JdeField("IAUSER", "IAUSER", JdeDataType.String, 20),
        new JdeField("IAPID", "IAPID", JdeDataType.String, 20),
        new JdeField("IAVERS", "IAVERS", JdeDataType.String, 20),
        new JdeField("IAJOBN", "IAJOBN", JdeDataType.String, 20),
        new JdeField("IAUPMJ", "IAUPMJ", JdeDataType.Numeric),
        new JdeField("IAUPMT", "IAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1001Z1_0", "Primary Key on IAEDUS, IAEDBT, IAEDTN", new[] { "IAEDUS", "IAEDBT", "IAEDTN" }, isUnique: true, isPrimaryKey: true)
    };
}
