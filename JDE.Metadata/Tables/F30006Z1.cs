using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30006Z1 - .
/// </summary>
public class F30006Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZMCUW.
        /// </summary>
        public const string SZMCUW = "SZMCUW";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZLOCN.
        /// </summary>
        public const string SZLOCN = "SZLOCN";

        /// <summary>
        /// SZCRTW.
        /// </summary>
        public const string SZCRTW = "SZCRTW";

        /// <summary>
        /// SZPILC.
        /// </summary>
        public const string SZPILC = "SZPILC";

        /// <summary>
        /// SZBFPF.
        /// </summary>
        public const string SZBFPF = "SZBFPF";

        /// <summary>
        /// SZDEMO.
        /// </summary>
        public const string SZDEMO = "SZDEMO";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZAVRT.
        /// </summary>
        public const string SZAVRT = "SZAVRT";

        /// <summary>
        /// SZTRKS.
        /// </summary>
        public const string SZTRKS = "SZTRKS";

        /// <summary>
        /// SZWRHR.
        /// </summary>
        public const string SZWRHR = "SZWRHR";

        /// <summary>
        /// SZWORE.
        /// </summary>
        public const string SZWORE = "SZWORE";

        /// <summary>
        /// SZWORU.
        /// </summary>
        public const string SZWORU = "SZWORU";

        /// <summary>
        /// SZQMAD.
        /// </summary>
        public const string SZQMAD = "SZQMAD";

        /// <summary>
        /// SZNOMA.
        /// </summary>
        public const string SZNOMA = "SZNOMA";

        /// <summary>
        /// SZSQD.
        /// </summary>
        public const string SZSQD = "SZSQD";

        /// <summary>
        /// SZMOVD.
        /// </summary>
        public const string SZMOVD = "SZMOVD";

        /// <summary>
        /// SZQUED.
        /// </summary>
        public const string SZQUED = "SZQUED";

        /// <summary>
        /// SZSETC.
        /// </summary>
        public const string SZSETC = "SZSETC";

        /// <summary>
        /// SZDL1.
        /// </summary>
        public const string SZDL1 = "SZDL1";

        /// <summary>
        /// SZDL2.
        /// </summary>
        public const string SZDL2 = "SZDL2";

        /// <summary>
        /// SZDL3.
        /// </summary>
        public const string SZDL3 = "SZDL3";

        /// <summary>
        /// SZDE1.
        /// </summary>
        public const string SZDE1 = "SZDE1";

        /// <summary>
        /// SZDE2.
        /// </summary>
        public const string SZDE2 = "SZDE2";

        /// <summary>
        /// SZDE3.
        /// </summary>
        public const string SZDE3 = "SZDE3";

        /// <summary>
        /// SZDC1.
        /// </summary>
        public const string SZDC1 = "SZDC1";

        /// <summary>
        /// SZDC2.
        /// </summary>
        public const string SZDC2 = "SZDC2";

        /// <summary>
        /// SZDC3.
        /// </summary>
        public const string SZDC3 = "SZDC3";

        /// <summary>
        /// SZLIC.
        /// </summary>
        public const string SZLIC = "SZLIC";

        /// <summary>
        /// SZWRH2.
        /// </summary>
        public const string SZWRH2 = "SZWRH2";

        /// <summary>
        /// SZWRH3.
        /// </summary>
        public const string SZWRH3 = "SZWRH3";

        /// <summary>
        /// SZWRH4.
        /// </summary>
        public const string SZWRH4 = "SZWRH4";

        /// <summary>
        /// SZWRH5.
        /// </summary>
        public const string SZWRH5 = "SZWRH5";

        /// <summary>
        /// SZWRH6.
        /// </summary>
        public const string SZWRH6 = "SZWRH6";

        /// <summary>
        /// SZCAPU.
        /// </summary>
        public const string SZCAPU = "SZCAPU";

        /// <summary>
        /// SZCPSD.
        /// </summary>
        public const string SZCPSD = "SZCPSD";

        /// <summary>
        /// SZCPMI.
        /// </summary>
        public const string SZCPMI = "SZCPMI";

        /// <summary>
        /// SZCPMA.
        /// </summary>
        public const string SZCPMA = "SZCPMA";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZWDCT.
        /// </summary>
        public const string SZWDCT = "SZWDCT";

        /// <summary>
        /// SZWDCK.
        /// </summary>
        public const string SZWDCK = "SZWDCK";

        /// <summary>
        /// SZLOMC.
        /// </summary>
        public const string SZLOMC = "SZLOMC";

        /// <summary>
        /// SZCOLO.
        /// </summary>
        public const string SZCOLO = "SZCOLO";

        /// <summary>
        /// SZBFWC.
        /// </summary>
        public const string SZBFWC = "SZBFWC";

        /// <summary>
        /// SZITML.
        /// </summary>
        public const string SZITML = "SZITML";

        /// <summary>
        /// SZAPSC.
        /// </summary>
        public const string SZAPSC = "SZAPSC";
    }

    /// <inheritdoc />
    public override string TableName => "F30006Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZMCUW", "SZMCUW", JdeDataType.String, 24),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZLOCN", "SZLOCN", JdeDataType.String, 40),
        new JdeField("SZCRTW", "SZCRTW", JdeDataType.String, 2),
        new JdeField("SZPILC", "SZPILC", JdeDataType.String, 2),
        new JdeField("SZBFPF", "SZBFPF", JdeDataType.String, 2),
        new JdeField("SZDEMO", "SZDEMO", JdeDataType.String, 2),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZAVRT", "SZAVRT", JdeDataType.Numeric),
        new JdeField("SZTRKS", "SZTRKS", JdeDataType.Numeric),
        new JdeField("SZWRHR", "SZWRHR", JdeDataType.Numeric),
        new JdeField("SZWORE", "SZWORE", JdeDataType.Numeric),
        new JdeField("SZWORU", "SZWORU", JdeDataType.Numeric),
        new JdeField("SZQMAD", "SZQMAD", JdeDataType.Numeric),
        new JdeField("SZNOMA", "SZNOMA", JdeDataType.Numeric),
        new JdeField("SZSQD", "SZSQD", JdeDataType.Numeric),
        new JdeField("SZMOVD", "SZMOVD", JdeDataType.Numeric),
        new JdeField("SZQUED", "SZQUED", JdeDataType.Numeric),
        new JdeField("SZSETC", "SZSETC", JdeDataType.Numeric),
        new JdeField("SZDL1", "SZDL1", JdeDataType.Numeric),
        new JdeField("SZDL2", "SZDL2", JdeDataType.Numeric),
        new JdeField("SZDL3", "SZDL3", JdeDataType.Numeric),
        new JdeField("SZDE1", "SZDE1", JdeDataType.Numeric),
        new JdeField("SZDE2", "SZDE2", JdeDataType.Numeric),
        new JdeField("SZDE3", "SZDE3", JdeDataType.Numeric),
        new JdeField("SZDC1", "SZDC1", JdeDataType.String, 2),
        new JdeField("SZDC2", "SZDC2", JdeDataType.String, 2),
        new JdeField("SZDC3", "SZDC3", JdeDataType.String, 2),
        new JdeField("SZLIC", "SZLIC", JdeDataType.String, 2),
        new JdeField("SZWRH2", "SZWRH2", JdeDataType.Numeric),
        new JdeField("SZWRH3", "SZWRH3", JdeDataType.Numeric),
        new JdeField("SZWRH4", "SZWRH4", JdeDataType.Numeric),
        new JdeField("SZWRH5", "SZWRH5", JdeDataType.Numeric),
        new JdeField("SZWRH6", "SZWRH6", JdeDataType.Numeric),
        new JdeField("SZCAPU", "SZCAPU", JdeDataType.String, 4),
        new JdeField("SZCPSD", "SZCPSD", JdeDataType.Numeric),
        new JdeField("SZCPMI", "SZCPMI", JdeDataType.Numeric),
        new JdeField("SZCPMA", "SZCPMA", JdeDataType.Numeric),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZWDCT", "SZWDCT", JdeDataType.String, 20),
        new JdeField("SZWDCK", "SZWDCK", JdeDataType.String, 20),
        new JdeField("SZLOMC", "SZLOMC", JdeDataType.String, 24),
        new JdeField("SZCOLO", "SZCOLO", JdeDataType.String, 40),
        new JdeField("SZBFWC", "SZBFWC", JdeDataType.String, 2),
        new JdeField("SZITML", "SZITML", JdeDataType.Numeric),
        new JdeField("SZAPSC", "SZAPSC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30006Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30006Z1_2", "Index on SZEDUS, SZEDBT, SZEDTN, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDSP" }),
        new JdeIndex("F30006Z1_3", "Index on SZEDUS, SZEDBT, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDSP" }),
        new JdeIndex("F30006Z1_4", "Index on SZEDUS, SZEDBT, SZEDTN", new[] { "SZEDUS", "SZEDBT", "SZEDTN" }),
        new JdeIndex("F30006Z1_5", "Index on SZEDUS, SZEDBT, SZEDTN, SYS_NC00071$", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SYS_NC00071$" })
    };
}
