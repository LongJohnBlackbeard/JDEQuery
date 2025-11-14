using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470373 - .
/// </summary>
public class F470373 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AGEDTY.
        /// </summary>
        public const string AGEDTY = "AGEDTY";

        /// <summary>
        /// AGEDSQ.
        /// </summary>
        public const string AGEDSQ = "AGEDSQ";

        /// <summary>
        /// AGEKCO.
        /// </summary>
        public const string AGEKCO = "AGEKCO";

        /// <summary>
        /// AGEDOC.
        /// </summary>
        public const string AGEDOC = "AGEDOC";

        /// <summary>
        /// AGEDCT.
        /// </summary>
        public const string AGEDCT = "AGEDCT";

        /// <summary>
        /// AGEDST.
        /// </summary>
        public const string AGEDST = "AGEDST";

        /// <summary>
        /// AGEDFT.
        /// </summary>
        public const string AGEDFT = "AGEDFT";

        /// <summary>
        /// AGEDDT.
        /// </summary>
        public const string AGEDDT = "AGEDDT";

        /// <summary>
        /// AGEDER.
        /// </summary>
        public const string AGEDER = "AGEDER";

        /// <summary>
        /// AGEDDL.
        /// </summary>
        public const string AGEDDL = "AGEDDL";

        /// <summary>
        /// AGEDSP.
        /// </summary>
        public const string AGEDSP = "AGEDSP";

        /// <summary>
        /// AGEDBT.
        /// </summary>
        public const string AGEDBT = "AGEDBT";

        /// <summary>
        /// AGSTPC.
        /// </summary>
        public const string AGSTPC = "AGSTPC";

        /// <summary>
        /// AGANTY.
        /// </summary>
        public const string AGANTY = "AGANTY";

        /// <summary>
        /// AGLINS.
        /// </summary>
        public const string AGLINS = "AGLINS";

        /// <summary>
        /// AGSHPN.
        /// </summary>
        public const string AGSHPN = "AGSHPN";

        /// <summary>
        /// AGUL01.
        /// </summary>
        public const string AGUL01 = "AGUL01";

        /// <summary>
        /// AGDAYSAV.
        /// </summary>
        public const string AGDAYSAV = "AGDAYSAV";

        /// <summary>
        /// AGSCAC.
        /// </summary>
        public const string AGSCAC = "AGSCAC";

        /// <summary>
        /// AGALPH.
        /// </summary>
        public const string AGALPH = "AGALPH";

        /// <summary>
        /// AGAETC.
        /// </summary>
        public const string AGAETC = "AGAETC";

        /// <summary>
        /// AGETRC.
        /// </summary>
        public const string AGETRC = "AGETRC";

        /// <summary>
        /// AGETRSC.
        /// </summary>
        public const string AGETRSC = "AGETRSC";

        /// <summary>
        /// AGSLN.
        /// </summary>
        public const string AGSLN = "AGSLN";

        /// <summary>
        /// AGCTR.
        /// </summary>
        public const string AGCTR = "AGCTR";

        /// <summary>
        /// AGLNGP.
        /// </summary>
        public const string AGLNGP = "AGLNGP";

        /// <summary>
        /// AGPOOLPT.
        /// </summary>
        public const string AGPOOLPT = "AGPOOLPT";

        /// <summary>
        /// AGCSGSHPNO.
        /// </summary>
        public const string AGCSGSHPNO = "AGCSGSHPNO";

        /// <summary>
        /// AGMLTCARTN.
        /// </summary>
        public const string AGMLTCARTN = "AGMLTCARTN";

        /// <summary>
        /// AGNCTR.
        /// </summary>
        public const string AGNCTR = "AGNCTR";

        /// <summary>
        /// AGRFQ3.
        /// </summary>
        public const string AGRFQ3 = "AGRFQ3";

        /// <summary>
        /// AGRF3.
        /// </summary>
        public const string AGRF3 = "AGRF3";

        /// <summary>
        /// AGRFQ4.
        /// </summary>
        public const string AGRFQ4 = "AGRFQ4";

        /// <summary>
        /// AGRF4.
        /// </summary>
        public const string AGRF4 = "AGRF4";

        /// <summary>
        /// AGRFQ5.
        /// </summary>
        public const string AGRFQ5 = "AGRFQ5";

        /// <summary>
        /// AGRF5.
        /// </summary>
        public const string AGRF5 = "AGRF5";

        /// <summary>
        /// AGRFQ6.
        /// </summary>
        public const string AGRFQ6 = "AGRFQ6";

        /// <summary>
        /// AGRF6.
        /// </summary>
        public const string AGRF6 = "AGRF6";

        /// <summary>
        /// AGRFQ7.
        /// </summary>
        public const string AGRFQ7 = "AGRFQ7";

        /// <summary>
        /// AGRF7.
        /// </summary>
        public const string AGRF7 = "AGRF7";

        /// <summary>
        /// AGRFQ8.
        /// </summary>
        public const string AGRFQ8 = "AGRFQ8";

        /// <summary>
        /// AGRF8.
        /// </summary>
        public const string AGRF8 = "AGRF8";

        /// <summary>
        /// AGRFQ9.
        /// </summary>
        public const string AGRFQ9 = "AGRFQ9";

        /// <summary>
        /// AGRF9.
        /// </summary>
        public const string AGRF9 = "AGRF9";

        /// <summary>
        /// AGRFQ10.
        /// </summary>
        public const string AGRFQ10 = "AGRFQ10";

        /// <summary>
        /// AGRFN10.
        /// </summary>
        public const string AGRFN10 = "AGRFN10";

        /// <summary>
        /// AGRFQ11.
        /// </summary>
        public const string AGRFQ11 = "AGRFQ11";

        /// <summary>
        /// AGRFN11.
        /// </summary>
        public const string AGRFN11 = "AGRFN11";

        /// <summary>
        /// AGRFQ12.
        /// </summary>
        public const string AGRFQ12 = "AGRFQ12";

        /// <summary>
        /// AGRFN12.
        /// </summary>
        public const string AGRFN12 = "AGRFN12";

        /// <summary>
        /// AGRFQ13.
        /// </summary>
        public const string AGRFQ13 = "AGRFQ13";

        /// <summary>
        /// AGRFN13.
        /// </summary>
        public const string AGRFN13 = "AGRFN13";

        /// <summary>
        /// AGRFQ14.
        /// </summary>
        public const string AGRFQ14 = "AGRFQ14";

        /// <summary>
        /// AGRFN14.
        /// </summary>
        public const string AGRFN14 = "AGRFN14";

        /// <summary>
        /// AGRFQ15.
        /// </summary>
        public const string AGRFQ15 = "AGRFQ15";

        /// <summary>
        /// AGRFN15.
        /// </summary>
        public const string AGRFN15 = "AGRFN15";

        /// <summary>
        /// AGRFQ16.
        /// </summary>
        public const string AGRFQ16 = "AGRFQ16";

        /// <summary>
        /// AGRFN16.
        /// </summary>
        public const string AGRFN16 = "AGRFN16";

        /// <summary>
        /// AGRFQ17.
        /// </summary>
        public const string AGRFQ17 = "AGRFQ17";

        /// <summary>
        /// AGRFN17.
        /// </summary>
        public const string AGRFN17 = "AGRFN17";

        /// <summary>
        /// AGRFQ18.
        /// </summary>
        public const string AGRFQ18 = "AGRFQ18";

        /// <summary>
        /// AGRFN18.
        /// </summary>
        public const string AGRFN18 = "AGRFN18";

        /// <summary>
        /// AGRFQ19.
        /// </summary>
        public const string AGRFQ19 = "AGRFQ19";

        /// <summary>
        /// AGRFN19.
        /// </summary>
        public const string AGRFN19 = "AGRFN19";

        /// <summary>
        /// AGRFQ20.
        /// </summary>
        public const string AGRFQ20 = "AGRFQ20";

        /// <summary>
        /// AGRFN20.
        /// </summary>
        public const string AGRFN20 = "AGRFN20";
    }

    /// <inheritdoc />
    public override string TableName => "F470373";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AGEDTY", "AGEDTY", JdeDataType.String, 2),
        new JdeField("AGEDSQ", "AGEDSQ", JdeDataType.Numeric),
        new JdeField("AGEKCO", "AGEKCO", JdeDataType.String, 10, true, true),
        new JdeField("AGEDOC", "AGEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("AGEDCT", "AGEDCT", JdeDataType.String, 4, true, true),
        new JdeField("AGEDST", "AGEDST", JdeDataType.String, 12),
        new JdeField("AGEDFT", "AGEDFT", JdeDataType.String, 20),
        new JdeField("AGEDDT", "AGEDDT", JdeDataType.Numeric),
        new JdeField("AGEDER", "AGEDER", JdeDataType.String, 2),
        new JdeField("AGEDDL", "AGEDDL", JdeDataType.Numeric),
        new JdeField("AGEDSP", "AGEDSP", JdeDataType.String, 2),
        new JdeField("AGEDBT", "AGEDBT", JdeDataType.String, 30),
        new JdeField("AGSTPC", "AGSTPC", JdeDataType.String, 2, true, true),
        new JdeField("AGANTY", "AGANTY", JdeDataType.String, 2, true, true),
        new JdeField("AGLINS", "AGLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("AGSHPN", "AGSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("AGUL01", "AGUL01", JdeDataType.String, 20),
        new JdeField("AGDAYSAV", "AGDAYSAV", JdeDataType.String, 2),
        new JdeField("AGSCAC", "AGSCAC", JdeDataType.String, 8),
        new JdeField("AGALPH", "AGALPH", JdeDataType.String, 80),
        new JdeField("AGAETC", "AGAETC", JdeDataType.String, 20),
        new JdeField("AGETRC", "AGETRC", JdeDataType.String, 6),
        new JdeField("AGETRSC", "AGETRSC", JdeDataType.String, 6),
        new JdeField("AGSLN", "AGSLN", JdeDataType.Numeric),
        new JdeField("AGCTR", "AGCTR", JdeDataType.String, 6),
        new JdeField("AGLNGP", "AGLNGP", JdeDataType.String, 4),
        new JdeField("AGPOOLPT", "AGPOOLPT", JdeDataType.String, 50),
        new JdeField("AGCSGSHPNO", "AGCSGSHPNO", JdeDataType.String, 70),
        new JdeField("AGMLTCARTN", "AGMLTCARTN", JdeDataType.String, 2),
        new JdeField("AGNCTR", "AGNCTR", JdeDataType.Numeric),
        new JdeField("AGRFQ3", "AGRFQ3", JdeDataType.String, 4),
        new JdeField("AGRF3", "AGRF3", JdeDataType.String, 60),
        new JdeField("AGRFQ4", "AGRFQ4", JdeDataType.String, 4),
        new JdeField("AGRF4", "AGRF4", JdeDataType.String, 60),
        new JdeField("AGRFQ5", "AGRFQ5", JdeDataType.String, 4),
        new JdeField("AGRF5", "AGRF5", JdeDataType.String, 60),
        new JdeField("AGRFQ6", "AGRFQ6", JdeDataType.String, 4),
        new JdeField("AGRF6", "AGRF6", JdeDataType.String, 60),
        new JdeField("AGRFQ7", "AGRFQ7", JdeDataType.String, 4),
        new JdeField("AGRF7", "AGRF7", JdeDataType.String, 60),
        new JdeField("AGRFQ8", "AGRFQ8", JdeDataType.String, 4),
        new JdeField("AGRF8", "AGRF8", JdeDataType.String, 60),
        new JdeField("AGRFQ9", "AGRFQ9", JdeDataType.String, 4),
        new JdeField("AGRF9", "AGRF9", JdeDataType.String, 60),
        new JdeField("AGRFQ10", "AGRFQ10", JdeDataType.String, 4),
        new JdeField("AGRFN10", "AGRFN10", JdeDataType.String, 60),
        new JdeField("AGRFQ11", "AGRFQ11", JdeDataType.String, 4),
        new JdeField("AGRFN11", "AGRFN11", JdeDataType.String, 60),
        new JdeField("AGRFQ12", "AGRFQ12", JdeDataType.String, 4),
        new JdeField("AGRFN12", "AGRFN12", JdeDataType.String, 60),
        new JdeField("AGRFQ13", "AGRFQ13", JdeDataType.String, 4),
        new JdeField("AGRFN13", "AGRFN13", JdeDataType.String, 60),
        new JdeField("AGRFQ14", "AGRFQ14", JdeDataType.String, 4),
        new JdeField("AGRFN14", "AGRFN14", JdeDataType.String, 60),
        new JdeField("AGRFQ15", "AGRFQ15", JdeDataType.String, 4),
        new JdeField("AGRFN15", "AGRFN15", JdeDataType.String, 60),
        new JdeField("AGRFQ16", "AGRFQ16", JdeDataType.String, 4),
        new JdeField("AGRFN16", "AGRFN16", JdeDataType.String, 60),
        new JdeField("AGRFQ17", "AGRFQ17", JdeDataType.String, 4),
        new JdeField("AGRFN17", "AGRFN17", JdeDataType.String, 60),
        new JdeField("AGRFQ18", "AGRFQ18", JdeDataType.String, 4),
        new JdeField("AGRFN18", "AGRFN18", JdeDataType.String, 60),
        new JdeField("AGRFQ19", "AGRFQ19", JdeDataType.String, 4),
        new JdeField("AGRFN19", "AGRFN19", JdeDataType.String, 60),
        new JdeField("AGRFQ20", "AGRFQ20", JdeDataType.String, 4),
        new JdeField("AGRFN20", "AGRFN20", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470373_0", "Primary Key on AGEDOC, AGEDCT, AGEKCO, AGSTPC, AGANTY, AGLINS, AGSHPN", new[] { "AGEDOC", "AGEDCT", "AGEKCO", "AGSTPC", "AGANTY", "AGLINS", "AGSHPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F470373_2", "Index on AGEDOC, AGEDCT, AGEKCO, AGSHPN", new[] { "AGEDOC", "AGEDCT", "AGEKCO", "AGSHPN" })
    };
}
