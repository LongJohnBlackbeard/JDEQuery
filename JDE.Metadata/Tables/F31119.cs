using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31119 - .
/// </summary>
public class F31119 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WYUKID.
        /// </summary>
        public const string WYUKID = "WYUKID";

        /// <summary>
        /// WYDOCO.
        /// </summary>
        public const string WYDOCO = "WYDOCO";

        /// <summary>
        /// WYDCTO.
        /// </summary>
        public const string WYDCTO = "WYDCTO";

        /// <summary>
        /// WYSFXO.
        /// </summary>
        public const string WYSFXO = "WYSFXO";

        /// <summary>
        /// WYTBM.
        /// </summary>
        public const string WYTBM = "WYTBM";

        /// <summary>
        /// WYFORQ.
        /// </summary>
        public const string WYFORQ = "WYFORQ";

        /// <summary>
        /// WYITC.
        /// </summary>
        public const string WYITC = "WYITC";

        /// <summary>
        /// WYCOBY.
        /// </summary>
        public const string WYCOBY = "WYCOBY";

        /// <summary>
        /// WYCOTY.
        /// </summary>
        public const string WYCOTY = "WYCOTY";

        /// <summary>
        /// WYCPNT.
        /// </summary>
        public const string WYCPNT = "WYCPNT";

        /// <summary>
        /// WYFRMP.
        /// </summary>
        public const string WYFRMP = "WYFRMP";

        /// <summary>
        /// WYTHRP.
        /// </summary>
        public const string WYTHRP = "WYTHRP";

        /// <summary>
        /// WYFRGD.
        /// </summary>
        public const string WYFRGD = "WYFRGD";

        /// <summary>
        /// WYTHGD.
        /// </summary>
        public const string WYTHGD = "WYTHGD";

        /// <summary>
        /// WYRKCO.
        /// </summary>
        public const string WYRKCO = "WYRKCO";

        /// <summary>
        /// WYRORN.
        /// </summary>
        public const string WYRORN = "WYRORN";

        /// <summary>
        /// WYRCTO.
        /// </summary>
        public const string WYRCTO = "WYRCTO";

        /// <summary>
        /// WYRLLN.
        /// </summary>
        public const string WYRLLN = "WYRLLN";

        /// <summary>
        /// WYOPSQ.
        /// </summary>
        public const string WYOPSQ = "WYOPSQ";

        /// <summary>
        /// WYBSEQ.
        /// </summary>
        public const string WYBSEQ = "WYBSEQ";

        /// <summary>
        /// WYRSCP.
        /// </summary>
        public const string WYRSCP = "WYRSCP";

        /// <summary>
        /// WYSCRP.
        /// </summary>
        public const string WYSCRP = "WYSCRP";

        /// <summary>
        /// WYREWP.
        /// </summary>
        public const string WYREWP = "WYREWP";

        /// <summary>
        /// WYASIP.
        /// </summary>
        public const string WYASIP = "WYASIP";

        /// <summary>
        /// WYCPYP.
        /// </summary>
        public const string WYCPYP = "WYCPYP";

        /// <summary>
        /// WYSTPP.
        /// </summary>
        public const string WYSTPP = "WYSTPP";

        /// <summary>
        /// WYLOVD.
        /// </summary>
        public const string WYLOVD = "WYLOVD";

        /// <summary>
        /// WYCPIT.
        /// </summary>
        public const string WYCPIT = "WYCPIT";

        /// <summary>
        /// WYCPIL.
        /// </summary>
        public const string WYCPIL = "WYCPIL";

        /// <summary>
        /// WYCPIA.
        /// </summary>
        public const string WYCPIA = "WYCPIA";

        /// <summary>
        /// WYCMCU.
        /// </summary>
        public const string WYCMCU = "WYCMCU";

        /// <summary>
        /// WYDSC1.
        /// </summary>
        public const string WYDSC1 = "WYDSC1";

        /// <summary>
        /// WYDSC2.
        /// </summary>
        public const string WYDSC2 = "WYDSC2";

        /// <summary>
        /// WYLOCN.
        /// </summary>
        public const string WYLOCN = "WYLOCN";

        /// <summary>
        /// WYLOTN.
        /// </summary>
        public const string WYLOTN = "WYLOTN";

        /// <summary>
        /// WYAN8.
        /// </summary>
        public const string WYAN8 = "WYAN8";

        /// <summary>
        /// WYLNTY.
        /// </summary>
        public const string WYLNTY = "WYLNTY";

        /// <summary>
        /// WYSERN.
        /// </summary>
        public const string WYSERN = "WYSERN";

        /// <summary>
        /// WYTRDJ.
        /// </summary>
        public const string WYTRDJ = "WYTRDJ";

        /// <summary>
        /// WYDRQJ.
        /// </summary>
        public const string WYDRQJ = "WYDRQJ";

        /// <summary>
        /// WYUORG.
        /// </summary>
        public const string WYUORG = "WYUORG";

        /// <summary>
        /// WYTRQT.
        /// </summary>
        public const string WYTRQT = "WYTRQT";

        /// <summary>
        /// WYSOCN.
        /// </summary>
        public const string WYSOCN = "WYSOCN";

        /// <summary>
        /// WYSOBK.
        /// </summary>
        public const string WYSOBK = "WYSOBK";

        /// <summary>
        /// WYCTS1.
        /// </summary>
        public const string WYCTS1 = "WYCTS1";

        /// <summary>
        /// WYQNTA.
        /// </summary>
        public const string WYQNTA = "WYQNTA";

        /// <summary>
        /// WYUM.
        /// </summary>
        public const string WYUM = "WYUM";

        /// <summary>
        /// WYEA.
        /// </summary>
        public const string WYEA = "WYEA";

        /// <summary>
        /// WYRTG.
        /// </summary>
        public const string WYRTG = "WYRTG";

        /// <summary>
        /// WYMTST.
        /// </summary>
        public const string WYMTST = "WYMTST";

        /// <summary>
        /// WYDCT.
        /// </summary>
        public const string WYDCT = "WYDCT";

        /// <summary>
        /// WYSHNO.
        /// </summary>
        public const string WYSHNO = "WYSHNO";

        /// <summary>
        /// WYMCU.
        /// </summary>
        public const string WYMCU = "WYMCU";

        /// <summary>
        /// WYOMCU.
        /// </summary>
        public const string WYOMCU = "WYOMCU";

        /// <summary>
        /// WYOBJ.
        /// </summary>
        public const string WYOBJ = "WYOBJ";

        /// <summary>
        /// WYSUB.
        /// </summary>
        public const string WYSUB = "WYSUB";

        /// <summary>
        /// WYCMRV.
        /// </summary>
        public const string WYCMRV = "WYCMRV";

        /// <summary>
        /// WYSTRX.
        /// </summary>
        public const string WYSTRX = "WYSTRX";

        /// <summary>
        /// WYPARS.
        /// </summary>
        public const string WYPARS = "WYPARS";

        /// <summary>
        /// WYCOMM.
        /// </summary>
        public const string WYCOMM = "WYCOMM";

        /// <summary>
        /// WYURCD.
        /// </summary>
        public const string WYURCD = "WYURCD";

        /// <summary>
        /// WYURDT.
        /// </summary>
        public const string WYURDT = "WYURDT";

        /// <summary>
        /// WYURAT.
        /// </summary>
        public const string WYURAT = "WYURAT";

        /// <summary>
        /// WYURRF.
        /// </summary>
        public const string WYURRF = "WYURRF";

        /// <summary>
        /// WYURAB.
        /// </summary>
        public const string WYURAB = "WYURAB";

        /// <summary>
        /// WYUSER.
        /// </summary>
        public const string WYUSER = "WYUSER";

        /// <summary>
        /// WYPID.
        /// </summary>
        public const string WYPID = "WYPID";

        /// <summary>
        /// WYJOBN.
        /// </summary>
        public const string WYJOBN = "WYJOBN";

        /// <summary>
        /// WYUPMJ.
        /// </summary>
        public const string WYUPMJ = "WYUPMJ";

        /// <summary>
        /// WYTDAY.
        /// </summary>
        public const string WYTDAY = "WYTDAY";

        /// <summary>
        /// WYVEND.
        /// </summary>
        public const string WYVEND = "WYVEND";

        /// <summary>
        /// WYPOC.
        /// </summary>
        public const string WYPOC = "WYPOC";

        /// <summary>
        /// WYCTS4.
        /// </summary>
        public const string WYCTS4 = "WYCTS4";

        /// <summary>
        /// WYCTS7.
        /// </summary>
        public const string WYCTS7 = "WYCTS7";

        /// <summary>
        /// WYCTS8.
        /// </summary>
        public const string WYCTS8 = "WYCTS8";

        /// <summary>
        /// WYGLD.
        /// </summary>
        public const string WYGLD = "WYGLD";

        /// <summary>
        /// WYSBFL.
        /// </summary>
        public const string WYSBFL = "WYSBFL";

        /// <summary>
        /// WYAING.
        /// </summary>
        public const string WYAING = "WYAING";

        /// <summary>
        /// WYSSTQ.
        /// </summary>
        public const string WYSSTQ = "WYSSTQ";

        /// <summary>
        /// WYUOM2.
        /// </summary>
        public const string WYUOM2 = "WYUOM2";

        /// <summary>
        /// WYAPSC.
        /// </summary>
        public const string WYAPSC = "WYAPSC";

        /// <summary>
        /// WYPSN.
        /// </summary>
        public const string WYPSN = "WYPSN";

        /// <summary>
        /// WYDLEJ.
        /// </summary>
        public const string WYDLEJ = "WYDLEJ";

        /// <summary>
        /// WYCOST.
        /// </summary>
        public const string WYCOST = "WYCOST";

        /// <summary>
        /// WYCHPP.
        /// </summary>
        public const string WYCHPP = "WYCHPP";

        /// <summary>
        /// WYCPNB.
        /// </summary>
        public const string WYCPNB = "WYCPNB";

        /// <summary>
        /// WYBSEQAN.
        /// </summary>
        public const string WYBSEQAN = "WYBSEQAN";

        /// <summary>
        /// WYACTN.
        /// </summary>
        public const string WYACTN = "WYACTN";
    }

    /// <inheritdoc />
    public override string TableName => "F31119";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WYUKID", "WYUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WYDOCO", "WYDOCO", JdeDataType.Numeric),
        new JdeField("WYDCTO", "WYDCTO", JdeDataType.String, 4),
        new JdeField("WYSFXO", "WYSFXO", JdeDataType.String, 6),
        new JdeField("WYTBM", "WYTBM", JdeDataType.String, 6),
        new JdeField("WYFORQ", "WYFORQ", JdeDataType.String, 2),
        new JdeField("WYITC", "WYITC", JdeDataType.String, 2),
        new JdeField("WYCOBY", "WYCOBY", JdeDataType.String, 2),
        new JdeField("WYCOTY", "WYCOTY", JdeDataType.String, 2),
        new JdeField("WYCPNT", "WYCPNT", JdeDataType.Numeric),
        new JdeField("WYFRMP", "WYFRMP", JdeDataType.Numeric),
        new JdeField("WYTHRP", "WYTHRP", JdeDataType.Numeric),
        new JdeField("WYFRGD", "WYFRGD", JdeDataType.String, 6),
        new JdeField("WYTHGD", "WYTHGD", JdeDataType.String, 6),
        new JdeField("WYRKCO", "WYRKCO", JdeDataType.String, 10),
        new JdeField("WYRORN", "WYRORN", JdeDataType.String, 16),
        new JdeField("WYRCTO", "WYRCTO", JdeDataType.String, 4),
        new JdeField("WYRLLN", "WYRLLN", JdeDataType.Numeric),
        new JdeField("WYOPSQ", "WYOPSQ", JdeDataType.Numeric),
        new JdeField("WYBSEQ", "WYBSEQ", JdeDataType.Numeric),
        new JdeField("WYRSCP", "WYRSCP", JdeDataType.Numeric),
        new JdeField("WYSCRP", "WYSCRP", JdeDataType.Numeric),
        new JdeField("WYREWP", "WYREWP", JdeDataType.Numeric),
        new JdeField("WYASIP", "WYASIP", JdeDataType.Numeric),
        new JdeField("WYCPYP", "WYCPYP", JdeDataType.Numeric),
        new JdeField("WYSTPP", "WYSTPP", JdeDataType.Numeric),
        new JdeField("WYLOVD", "WYLOVD", JdeDataType.Numeric),
        new JdeField("WYCPIT", "WYCPIT", JdeDataType.Numeric),
        new JdeField("WYCPIL", "WYCPIL", JdeDataType.String, 50),
        new JdeField("WYCPIA", "WYCPIA", JdeDataType.String, 50),
        new JdeField("WYCMCU", "WYCMCU", JdeDataType.String, 24),
        new JdeField("WYDSC1", "WYDSC1", JdeDataType.String, 60),
        new JdeField("WYDSC2", "WYDSC2", JdeDataType.String, 60),
        new JdeField("WYLOCN", "WYLOCN", JdeDataType.String, 40),
        new JdeField("WYLOTN", "WYLOTN", JdeDataType.String, 60),
        new JdeField("WYAN8", "WYAN8", JdeDataType.Numeric),
        new JdeField("WYLNTY", "WYLNTY", JdeDataType.String, 4),
        new JdeField("WYSERN", "WYSERN", JdeDataType.String, 60),
        new JdeField("WYTRDJ", "WYTRDJ", JdeDataType.Numeric),
        new JdeField("WYDRQJ", "WYDRQJ", JdeDataType.Numeric),
        new JdeField("WYUORG", "WYUORG", JdeDataType.Numeric),
        new JdeField("WYTRQT", "WYTRQT", JdeDataType.Numeric),
        new JdeField("WYSOCN", "WYSOCN", JdeDataType.Numeric),
        new JdeField("WYSOBK", "WYSOBK", JdeDataType.Numeric),
        new JdeField("WYCTS1", "WYCTS1", JdeDataType.Numeric),
        new JdeField("WYQNTA", "WYQNTA", JdeDataType.Numeric),
        new JdeField("WYUM", "WYUM", JdeDataType.String, 4),
        new JdeField("WYEA", "WYEA", JdeDataType.Numeric),
        new JdeField("WYRTG", "WYRTG", JdeDataType.String, 2),
        new JdeField("WYMTST", "WYMTST", JdeDataType.String, 4),
        new JdeField("WYDCT", "WYDCT", JdeDataType.String, 4),
        new JdeField("WYSHNO", "WYSHNO", JdeDataType.String, 20),
        new JdeField("WYMCU", "WYMCU", JdeDataType.String, 24),
        new JdeField("WYOMCU", "WYOMCU", JdeDataType.String, 24),
        new JdeField("WYOBJ", "WYOBJ", JdeDataType.String, 12),
        new JdeField("WYSUB", "WYSUB", JdeDataType.String, 16),
        new JdeField("WYCMRV", "WYCMRV", JdeDataType.String, 6),
        new JdeField("WYSTRX", "WYSTRX", JdeDataType.Numeric),
        new JdeField("WYPARS", "WYPARS", JdeDataType.String, 16),
        new JdeField("WYCOMM", "WYCOMM", JdeDataType.String, 2),
        new JdeField("WYURCD", "WYURCD", JdeDataType.String, 4),
        new JdeField("WYURDT", "WYURDT", JdeDataType.Numeric),
        new JdeField("WYURAT", "WYURAT", JdeDataType.Numeric),
        new JdeField("WYURRF", "WYURRF", JdeDataType.String, 30),
        new JdeField("WYURAB", "WYURAB", JdeDataType.Numeric),
        new JdeField("WYUSER", "WYUSER", JdeDataType.String, 20, true, true),
        new JdeField("WYPID", "WYPID", JdeDataType.String, 20),
        new JdeField("WYJOBN", "WYJOBN", JdeDataType.String, 20),
        new JdeField("WYUPMJ", "WYUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("WYTDAY", "WYTDAY", JdeDataType.Numeric, null, true, true),
        new JdeField("WYVEND", "WYVEND", JdeDataType.Numeric),
        new JdeField("WYPOC", "WYPOC", JdeDataType.String, 2),
        new JdeField("WYCTS4", "WYCTS4", JdeDataType.Numeric),
        new JdeField("WYCTS7", "WYCTS7", JdeDataType.Numeric),
        new JdeField("WYCTS8", "WYCTS8", JdeDataType.Numeric),
        new JdeField("WYGLD", "WYGLD", JdeDataType.Numeric),
        new JdeField("WYSBFL", "WYSBFL", JdeDataType.String, 2),
        new JdeField("WYAING", "WYAING", JdeDataType.String, 2),
        new JdeField("WYSSTQ", "WYSSTQ", JdeDataType.Numeric),
        new JdeField("WYUOM2", "WYUOM2", JdeDataType.String, 4),
        new JdeField("WYAPSC", "WYAPSC", JdeDataType.String, 2),
        new JdeField("WYPSN", "WYPSN", JdeDataType.Numeric),
        new JdeField("WYDLEJ", "WYDLEJ", JdeDataType.Numeric),
        new JdeField("WYCOST", "WYCOST", JdeDataType.String, 6),
        new JdeField("WYCHPP", "WYCHPP", JdeDataType.String, 2),
        new JdeField("WYCPNB", "WYCPNB", JdeDataType.Numeric),
        new JdeField("WYBSEQAN", "WYBSEQAN", JdeDataType.String, 10),
        new JdeField("WYACTN", "WYACTN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31119_0", "Primary Key on WYUKID, WYUSER, WYUPMJ, WYTDAY", new[] { "WYUKID", "WYUSER", "WYUPMJ", "WYTDAY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31119_2", "Index on WYDOCO", new[] { "WYDOCO" })
    };
}
