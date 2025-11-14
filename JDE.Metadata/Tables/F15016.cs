using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15016 - .
/// </summary>
public class F15016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NUDOCO.
        /// </summary>
        public const string NUDOCO = "NUDOCO";

        /// <summary>
        /// NUAN8.
        /// </summary>
        public const string NUAN8 = "NUAN8";

        /// <summary>
        /// NUINDX.
        /// </summary>
        public const string NUINDX = "NUINDX";

        /// <summary>
        /// NUBLMN.
        /// </summary>
        public const string NUBLMN = "NUBLMN";

        /// <summary>
        /// NUGLC.
        /// </summary>
        public const string NUGLC = "NUGLC";

        /// <summary>
        /// NUBRCD.
        /// </summary>
        public const string NUBRCD = "NUBRCD";

        /// <summary>
        /// NUBRRT.
        /// </summary>
        public const string NUBRRT = "NUBRRT";

        /// <summary>
        /// NUBPSM.
        /// </summary>
        public const string NUBPSM = "NUBPSM";

        /// <summary>
        /// NUBPSY.
        /// </summary>
        public const string NUBPSY = "NUBPSY";

        /// <summary>
        /// NUBPS#.
        /// </summary>
        public const string NUBPS_ = "NUBPS#";

        /// <summary>
        /// NUBPEM.
        /// </summary>
        public const string NUBPEM = "NUBPEM";

        /// <summary>
        /// NUBPEY.
        /// </summary>
        public const string NUBPEY = "NUBPEY";

        /// <summary>
        /// NUBPE#.
        /// </summary>
        public const string NUBPE_ = "NUBPE#";

        /// <summary>
        /// NUBINX.
        /// </summary>
        public const string NUBINX = "NUBINX";

        /// <summary>
        /// NUBESA.
        /// </summary>
        public const string NUBESA = "NUBESA";

        /// <summary>
        /// NULPSM.
        /// </summary>
        public const string NULPSM = "NULPSM";

        /// <summary>
        /// NULPSY.
        /// </summary>
        public const string NULPSY = "NULPSY";

        /// <summary>
        /// NULPS#.
        /// </summary>
        public const string NULPS_ = "NULPS#";

        /// <summary>
        /// NULPEM.
        /// </summary>
        public const string NULPEM = "NULPEM";

        /// <summary>
        /// NULPEY.
        /// </summary>
        public const string NULPEY = "NULPEY";

        /// <summary>
        /// NULPE#.
        /// </summary>
        public const string NULPE_ = "NULPE#";

        /// <summary>
        /// NULINX.
        /// </summary>
        public const string NULINX = "NULINX";

        /// <summary>
        /// NULESA.
        /// </summary>
        public const string NULESA = "NULESA";

        /// <summary>
        /// NUNPSM.
        /// </summary>
        public const string NUNPSM = "NUNPSM";

        /// <summary>
        /// NUNPSY.
        /// </summary>
        public const string NUNPSY = "NUNPSY";

        /// <summary>
        /// NUNPS#.
        /// </summary>
        public const string NUNPS_ = "NUNPS#";

        /// <summary>
        /// NUESCL.
        /// </summary>
        public const string NUESCL = "NUESCL";

        /// <summary>
        /// NUORLS.
        /// </summary>
        public const string NUORLS = "NUORLS";

        /// <summary>
        /// NUESCM.
        /// </summary>
        public const string NUESCM = "NUESCM";

        /// <summary>
        /// NUEMNY.
        /// </summary>
        public const string NUEMNY = "NUEMNY";

        /// <summary>
        /// NUEMXY.
        /// </summary>
        public const string NUEMXY = "NUEMXY";

        /// <summary>
        /// NUEMXL.
        /// </summary>
        public const string NUEMXL = "NUEMXL";

        /// <summary>
        /// NUBERF.
        /// </summary>
        public const string NUBERF = "NUBERF";

        /// <summary>
        /// NUBLGR.
        /// </summary>
        public const string NUBLGR = "NUBLGR";

        /// <summary>
        /// NURMK.
        /// </summary>
        public const string NURMK = "NURMK";

        /// <summary>
        /// NUEFTB.
        /// </summary>
        public const string NUEFTB = "NUEFTB";

        /// <summary>
        /// NUEFTE.
        /// </summary>
        public const string NUEFTE = "NUEFTE";

        /// <summary>
        /// NUBLFC.
        /// </summary>
        public const string NUBLFC = "NUBLFC";

        /// <summary>
        /// NUAN8J.
        /// </summary>
        public const string NUAN8J = "NUAN8J";

        /// <summary>
        /// NUMCU.
        /// </summary>
        public const string NUMCU = "NUMCU";

        /// <summary>
        /// NUUNIT.
        /// </summary>
        public const string NUUNIT = "NUUNIT";

        /// <summary>
        /// NUTRAR.
        /// </summary>
        public const string NUTRAR = "NUTRAR";

        /// <summary>
        /// NUSEPI.
        /// </summary>
        public const string NUSEPI = "NUSEPI";

        /// <summary>
        /// NUSUSP.
        /// </summary>
        public const string NUSUSP = "NUSUSP";

        /// <summary>
        /// NUDEAL.
        /// </summary>
        public const string NUDEAL = "NUDEAL";

        /// <summary>
        /// NUGENT.
        /// </summary>
        public const string NUGENT = "NUGENT";

        /// <summary>
        /// NUBCI.
        /// </summary>
        public const string NUBCI = "NUBCI";

        /// <summary>
        /// NUCRCD.
        /// </summary>
        public const string NUCRCD = "NUCRCD";

        /// <summary>
        /// NUACR.
        /// </summary>
        public const string NUACR = "NUACR";

        /// <summary>
        /// NUTXA1.
        /// </summary>
        public const string NUTXA1 = "NUTXA1";

        /// <summary>
        /// NUEXR1.
        /// </summary>
        public const string NUEXR1 = "NUEXR1";

        /// <summary>
        /// NUSTAM.
        /// </summary>
        public const string NUSTAM = "NUSTAM";

        /// <summary>
        /// NUATXN.
        /// </summary>
        public const string NUATXN = "NUATXN";

        /// <summary>
        /// NUATXA.
        /// </summary>
        public const string NUATXA = "NUATXA";

        /// <summary>
        /// NUUSER.
        /// </summary>
        public const string NUUSER = "NUUSER";

        /// <summary>
        /// NUUPMJ.
        /// </summary>
        public const string NUUPMJ = "NUUPMJ";

        /// <summary>
        /// NUPID.
        /// </summary>
        public const string NUPID = "NUPID";

        /// <summary>
        /// NUJOBN.
        /// </summary>
        public const string NUJOBN = "NUJOBN";

        /// <summary>
        /// NUCRRM.
        /// </summary>
        public const string NUCRRM = "NUCRRM";

        /// <summary>
        /// NUCTAM.
        /// </summary>
        public const string NUCTAM = "NUCTAM";

        /// <summary>
        /// NUCTXA.
        /// </summary>
        public const string NUCTXA = "NUCTXA";

        /// <summary>
        /// NUCTXN.
        /// </summary>
        public const string NUCTXN = "NUCTXN";

        /// <summary>
        /// NUBLMR.
        /// </summary>
        public const string NUBLMR = "NUBLMR";

        /// <summary>
        /// NUEBOC.
        /// </summary>
        public const string NUEBOC = "NUEBOC";

        /// <summary>
        /// NUMER.
        /// </summary>
        public const string NUMER = "NUMER";

        /// <summary>
        /// NUPWF.
        /// </summary>
        public const string NUPWF = "NUPWF";

        /// <summary>
        /// NUPWC.
        /// </summary>
        public const string NUPWC = "NUPWC";

        /// <summary>
        /// NUPWSF.
        /// </summary>
        public const string NUPWSF = "NUPWSF";

        /// <summary>
        /// NUUNGR.
        /// </summary>
        public const string NUUNGR = "NUUNGR";

        /// <summary>
        /// NUUPMT.
        /// </summary>
        public const string NUUPMT = "NUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F15016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NUDOCO", "NUDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NUAN8", "NUAN8", JdeDataType.Numeric),
        new JdeField("NUINDX", "NUINDX", JdeDataType.String, 10),
        new JdeField("NUBLMN", "NUBLMN", JdeDataType.String, 2),
        new JdeField("NUGLC", "NUGLC", JdeDataType.String, 8),
        new JdeField("NUBRCD", "NUBRCD", JdeDataType.String, 8),
        new JdeField("NUBRRT", "NUBRRT", JdeDataType.String, 8),
        new JdeField("NUBPSM", "NUBPSM", JdeDataType.Numeric),
        new JdeField("NUBPSY", "NUBPSY", JdeDataType.Numeric),
        new JdeField("NUBPS#", "NUBPS#", JdeDataType.Numeric),
        new JdeField("NUBPEM", "NUBPEM", JdeDataType.Numeric),
        new JdeField("NUBPEY", "NUBPEY", JdeDataType.Numeric),
        new JdeField("NUBPE#", "NUBPE#", JdeDataType.Numeric),
        new JdeField("NUBINX", "NUBINX", JdeDataType.Numeric),
        new JdeField("NUBESA", "NUBESA", JdeDataType.Numeric),
        new JdeField("NULPSM", "NULPSM", JdeDataType.Numeric),
        new JdeField("NULPSY", "NULPSY", JdeDataType.Numeric),
        new JdeField("NULPS#", "NULPS#", JdeDataType.Numeric),
        new JdeField("NULPEM", "NULPEM", JdeDataType.Numeric),
        new JdeField("NULPEY", "NULPEY", JdeDataType.Numeric),
        new JdeField("NULPE#", "NULPE#", JdeDataType.Numeric),
        new JdeField("NULINX", "NULINX", JdeDataType.Numeric),
        new JdeField("NULESA", "NULESA", JdeDataType.Numeric),
        new JdeField("NUNPSM", "NUNPSM", JdeDataType.Numeric),
        new JdeField("NUNPSY", "NUNPSY", JdeDataType.Numeric),
        new JdeField("NUNPS#", "NUNPS#", JdeDataType.Numeric),
        new JdeField("NUESCL", "NUESCL", JdeDataType.Numeric),
        new JdeField("NUORLS", "NUORLS", JdeDataType.String, 2),
        new JdeField("NUESCM", "NUESCM", JdeDataType.String, 2),
        new JdeField("NUEMNY", "NUEMNY", JdeDataType.Numeric),
        new JdeField("NUEMXY", "NUEMXY", JdeDataType.Numeric),
        new JdeField("NUEMXL", "NUEMXL", JdeDataType.Numeric),
        new JdeField("NUBERF", "NUBERF", JdeDataType.Numeric),
        new JdeField("NUBLGR", "NUBLGR", JdeDataType.String, 24),
        new JdeField("NURMK", "NURMK", JdeDataType.String, 60),
        new JdeField("NUEFTB", "NUEFTB", JdeDataType.Numeric),
        new JdeField("NUEFTE", "NUEFTE", JdeDataType.Numeric),
        new JdeField("NUBLFC", "NUBLFC", JdeDataType.String, 2),
        new JdeField("NUAN8J", "NUAN8J", JdeDataType.Numeric),
        new JdeField("NUMCU", "NUMCU", JdeDataType.String, 24),
        new JdeField("NUUNIT", "NUUNIT", JdeDataType.String, 16),
        new JdeField("NUTRAR", "NUTRAR", JdeDataType.String, 6),
        new JdeField("NUSEPI", "NUSEPI", JdeDataType.String, 2),
        new JdeField("NUSUSP", "NUSUSP", JdeDataType.String, 2),
        new JdeField("NUDEAL", "NUDEAL", JdeDataType.String, 16),
        new JdeField("NUGENT", "NUGENT", JdeDataType.String, 2),
        new JdeField("NUBCI", "NUBCI", JdeDataType.Numeric, null, true, true),
        new JdeField("NUCRCD", "NUCRCD", JdeDataType.String, 6),
        new JdeField("NUACR", "NUACR", JdeDataType.Numeric),
        new JdeField("NUTXA1", "NUTXA1", JdeDataType.String, 20),
        new JdeField("NUEXR1", "NUEXR1", JdeDataType.String, 4),
        new JdeField("NUSTAM", "NUSTAM", JdeDataType.Numeric),
        new JdeField("NUATXN", "NUATXN", JdeDataType.Numeric),
        new JdeField("NUATXA", "NUATXA", JdeDataType.Numeric),
        new JdeField("NUUSER", "NUUSER", JdeDataType.String, 20),
        new JdeField("NUUPMJ", "NUUPMJ", JdeDataType.Numeric),
        new JdeField("NUPID", "NUPID", JdeDataType.String, 20),
        new JdeField("NUJOBN", "NUJOBN", JdeDataType.String, 20),
        new JdeField("NUCRRM", "NUCRRM", JdeDataType.String, 2),
        new JdeField("NUCTAM", "NUCTAM", JdeDataType.Numeric),
        new JdeField("NUCTXA", "NUCTXA", JdeDataType.Numeric),
        new JdeField("NUCTXN", "NUCTXN", JdeDataType.Numeric),
        new JdeField("NUBLMR", "NUBLMR", JdeDataType.String, 2),
        new JdeField("NUEBOC", "NUEBOC", JdeDataType.String, 2),
        new JdeField("NUMER", "NUMER", JdeDataType.Numeric),
        new JdeField("NUPWF", "NUPWF", JdeDataType.Numeric),
        new JdeField("NUPWC", "NUPWC", JdeDataType.String, 2),
        new JdeField("NUPWSF", "NUPWSF", JdeDataType.Numeric),
        new JdeField("NUUNGR", "NUUNGR", JdeDataType.String, 2),
        new JdeField("NUUPMT", "NUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15016_0", "Primary Key on NUDOCO, NUBCI", new[] { "NUDOCO", "NUBCI" }, isUnique: true, isPrimaryKey: true)
    };
}
