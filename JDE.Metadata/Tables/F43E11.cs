using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43E11 - .
/// </summary>
public class F43E11 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDKCOO.
        /// </summary>
        public const string RDKCOO = "RDKCOO";

        /// <summary>
        /// RDDOCO.
        /// </summary>
        public const string RDDOCO = "RDDOCO";

        /// <summary>
        /// RDDCTO.
        /// </summary>
        public const string RDDCTO = "RDDCTO";

        /// <summary>
        /// RDSFXO.
        /// </summary>
        public const string RDSFXO = "RDSFXO";

        /// <summary>
        /// RDLNID.
        /// </summary>
        public const string RDLNID = "RDLNID";

        /// <summary>
        /// RDMCU.
        /// </summary>
        public const string RDMCU = "RDMCU";

        /// <summary>
        /// RDAN8.
        /// </summary>
        public const string RDAN8 = "RDAN8";

        /// <summary>
        /// RDSHAN.
        /// </summary>
        public const string RDSHAN = "RDSHAN";

        /// <summary>
        /// RDANBY.
        /// </summary>
        public const string RDANBY = "RDANBY";

        /// <summary>
        /// RDTRDJ.
        /// </summary>
        public const string RDTRDJ = "RDTRDJ";

        /// <summary>
        /// RDDRQJ.
        /// </summary>
        public const string RDDRQJ = "RDDRQJ";

        /// <summary>
        /// RDITM.
        /// </summary>
        public const string RDITM = "RDITM";

        /// <summary>
        /// RDLITM.
        /// </summary>
        public const string RDLITM = "RDLITM";

        /// <summary>
        /// RDAITM.
        /// </summary>
        public const string RDAITM = "RDAITM";

        /// <summary>
        /// RDCITM.
        /// </summary>
        public const string RDCITM = "RDCITM";

        /// <summary>
        /// RDUNSPSC.
        /// </summary>
        public const string RDUNSPSC = "RDUNSPSC";

        /// <summary>
        /// RDDSC1.
        /// </summary>
        public const string RDDSC1 = "RDDSC1";

        /// <summary>
        /// RDDSC2.
        /// </summary>
        public const string RDDSC2 = "RDDSC2";

        /// <summary>
        /// RDPROV.
        /// </summary>
        public const string RDPROV = "RDPROV";

        /// <summary>
        /// RDPRRC.
        /// </summary>
        public const string RDPRRC = "RDPRRC";

        /// <summary>
        /// RDCRCD.
        /// </summary>
        public const string RDCRCD = "RDCRCD";

        /// <summary>
        /// RDCRR.
        /// </summary>
        public const string RDCRR = "RDCRR";

        /// <summary>
        /// RDFRRC.
        /// </summary>
        public const string RDFRRC = "RDFRRC";

        /// <summary>
        /// RDUOM.
        /// </summary>
        public const string RDUOM = "RDUOM";

        /// <summary>
        /// RDUOM1.
        /// </summary>
        public const string RDUOM1 = "RDUOM1";

        /// <summary>
        /// RDUORG.
        /// </summary>
        public const string RDUORG = "RDUORG";

        /// <summary>
        /// RDAEXP.
        /// </summary>
        public const string RDAEXP = "RDAEXP";

        /// <summary>
        /// RDFEA.
        /// </summary>
        public const string RDFEA = "RDFEA";

        /// <summary>
        /// RDAOPN.
        /// </summary>
        public const string RDAOPN = "RDAOPN";

        /// <summary>
        /// RDUOPN.
        /// </summary>
        public const string RDUOPN = "RDUOPN";

        /// <summary>
        /// RDMACT.
        /// </summary>
        public const string RDMACT = "RDMACT";

        /// <summary>
        /// RDGLC.
        /// </summary>
        public const string RDGLC = "RDGLC";

        /// <summary>
        /// RDCMDCDE.
        /// </summary>
        public const string RDCMDCDE = "RDCMDCDE";

        /// <summary>
        /// RDERDS.
        /// </summary>
        public const string RDERDS = "RDERDS";

        /// <summary>
        /// RDLNTY.
        /// </summary>
        public const string RDLNTY = "RDLNTY";

        /// <summary>
        /// RDERBP.
        /// </summary>
        public const string RDERBP = "RDERBP";

        /// <summary>
        /// RDERCA.
        /// </summary>
        public const string RDERCA = "RDERCA";

        /// <summary>
        /// RDEREL.
        /// </summary>
        public const string RDEREL = "RDEREL";

        /// <summary>
        /// RDERTYP.
        /// </summary>
        public const string RDERTYP = "RDERTYP";

        /// <summary>
        /// RDERTO.
        /// </summary>
        public const string RDERTO = "RDERTO";

        /// <summary>
        /// RDERPR.
        /// </summary>
        public const string RDERPR = "RDERPR";

        /// <summary>
        /// RDERTA.
        /// </summary>
        public const string RDERTA = "RDERTA";

        /// <summary>
        /// RDAREQ.
        /// </summary>
        public const string RDAREQ = "RDAREQ";

        /// <summary>
        /// RDTORG.
        /// </summary>
        public const string RDTORG = "RDTORG";

        /// <summary>
        /// RDGKCOO.
        /// </summary>
        public const string RDGKCOO = "RDGKCOO";

        /// <summary>
        /// RDGDOCO.
        /// </summary>
        public const string RDGDOCO = "RDGDOCO";

        /// <summary>
        /// RDGDCTO.
        /// </summary>
        public const string RDGDCTO = "RDGDCTO";

        /// <summary>
        /// RDGSFXO.
        /// </summary>
        public const string RDGSFXO = "RDGSFXO";

        /// <summary>
        /// RDGLNID.
        /// </summary>
        public const string RDGLNID = "RDGLNID";

        /// <summary>
        /// RDGORDJ.
        /// </summary>
        public const string RDGORDJ = "RDGORDJ";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDINV01.
        /// </summary>
        public const string RDINV01 = "RDINV01";

        /// <summary>
        /// RDINV02.
        /// </summary>
        public const string RDINV02 = "RDINV02";

        /// <summary>
        /// RDINV03.
        /// </summary>
        public const string RDINV03 = "RDINV03";

        /// <summary>
        /// RDINV05.
        /// </summary>
        public const string RDINV05 = "RDINV05";

        /// <summary>
        /// RDINV06.
        /// </summary>
        public const string RDINV06 = "RDINV06";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDTDAY.
        /// </summary>
        public const string RDTDAY = "RDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43E11";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDKCOO", "RDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RDDOCO", "RDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RDDCTO", "RDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RDSFXO", "RDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("RDLNID", "RDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDMCU", "RDMCU", JdeDataType.String, 24),
        new JdeField("RDAN8", "RDAN8", JdeDataType.Numeric),
        new JdeField("RDSHAN", "RDSHAN", JdeDataType.Numeric),
        new JdeField("RDANBY", "RDANBY", JdeDataType.Numeric),
        new JdeField("RDTRDJ", "RDTRDJ", JdeDataType.Numeric),
        new JdeField("RDDRQJ", "RDDRQJ", JdeDataType.Numeric),
        new JdeField("RDITM", "RDITM", JdeDataType.Numeric),
        new JdeField("RDLITM", "RDLITM", JdeDataType.String, 50),
        new JdeField("RDAITM", "RDAITM", JdeDataType.String, 50),
        new JdeField("RDCITM", "RDCITM", JdeDataType.String, 50),
        new JdeField("RDUNSPSC", "RDUNSPSC", JdeDataType.String, 16),
        new JdeField("RDDSC1", "RDDSC1", JdeDataType.String, 60),
        new JdeField("RDDSC2", "RDDSC2", JdeDataType.String, 60),
        new JdeField("RDPROV", "RDPROV", JdeDataType.String, 2),
        new JdeField("RDPRRC", "RDPRRC", JdeDataType.Numeric),
        new JdeField("RDCRCD", "RDCRCD", JdeDataType.String, 6),
        new JdeField("RDCRR", "RDCRR", JdeDataType.Numeric),
        new JdeField("RDFRRC", "RDFRRC", JdeDataType.Numeric),
        new JdeField("RDUOM", "RDUOM", JdeDataType.String, 4),
        new JdeField("RDUOM1", "RDUOM1", JdeDataType.String, 4),
        new JdeField("RDUORG", "RDUORG", JdeDataType.Numeric),
        new JdeField("RDAEXP", "RDAEXP", JdeDataType.Numeric),
        new JdeField("RDFEA", "RDFEA", JdeDataType.Numeric),
        new JdeField("RDAOPN", "RDAOPN", JdeDataType.Numeric),
        new JdeField("RDUOPN", "RDUOPN", JdeDataType.Numeric),
        new JdeField("RDMACT", "RDMACT", JdeDataType.String, 2),
        new JdeField("RDGLC", "RDGLC", JdeDataType.String, 8),
        new JdeField("RDCMDCDE", "RDCMDCDE", JdeDataType.String, 30),
        new JdeField("RDERDS", "RDERDS", JdeDataType.String, 24),
        new JdeField("RDLNTY", "RDLNTY", JdeDataType.String, 4),
        new JdeField("RDERBP", "RDERBP", JdeDataType.String, 2),
        new JdeField("RDERCA", "RDERCA", JdeDataType.String, 2),
        new JdeField("RDEREL", "RDEREL", JdeDataType.String, 2),
        new JdeField("RDERTYP", "RDERTYP", JdeDataType.String, 2),
        new JdeField("RDERTO", "RDERTO", JdeDataType.String, 2),
        new JdeField("RDERPR", "RDERPR", JdeDataType.String, 2),
        new JdeField("RDERTA", "RDERTA", JdeDataType.String, 2),
        new JdeField("RDAREQ", "RDAREQ", JdeDataType.Numeric),
        new JdeField("RDTORG", "RDTORG", JdeDataType.String, 20),
        new JdeField("RDGKCOO", "RDGKCOO", JdeDataType.String, 10),
        new JdeField("RDGDOCO", "RDGDOCO", JdeDataType.Numeric),
        new JdeField("RDGDCTO", "RDGDCTO", JdeDataType.String, 4),
        new JdeField("RDGSFXO", "RDGSFXO", JdeDataType.String, 6),
        new JdeField("RDGLNID", "RDGLNID", JdeDataType.Numeric),
        new JdeField("RDGORDJ", "RDGORDJ", JdeDataType.Numeric),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDINV01", "RDINV01", JdeDataType.String, 2),
        new JdeField("RDINV02", "RDINV02", JdeDataType.String, 60),
        new JdeField("RDINV03", "RDINV03", JdeDataType.Numeric),
        new JdeField("RDINV05", "RDINV05", JdeDataType.Numeric),
        new JdeField("RDINV06", "RDINV06", JdeDataType.Numeric),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDTDAY", "RDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43E11_0", "Primary Key on RDKCOO, RDDOCO, RDDCTO, RDSFXO, RDLNID", new[] { "RDKCOO", "RDDOCO", "RDDCTO", "RDSFXO", "RDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43E11_2", "Index on RDKCOO, RDDOCO, RDDCTO", new[] { "RDKCOO", "RDDOCO", "RDDCTO" }),
        new JdeIndex("F43E11_3", "Index on RDGKCOO, RDGDOCO, RDGDCTO, RDGSFXO, RDGLNID, RDERDS", new[] { "RDGKCOO", "RDGDOCO", "RDGDCTO", "RDGSFXO", "RDGLNID", "RDERDS" }),
        new JdeIndex("F43E11_4", "Index on RDANBY, RDERPR", new[] { "RDANBY", "RDERPR" }),
        new JdeIndex("F43E11_5", "Index on RDERTYP, RDANBY", new[] { "RDERTYP", "RDANBY" }),
        new JdeIndex("F43E11_6", "Index on RDERDS, RDAREQ", new[] { "RDERDS", "RDAREQ" }),
        new JdeIndex("F43E11_7", "Index on RDAREQ, RDTRDJ", new[] { "RDAREQ", "RDTRDJ" }),
        new JdeIndex("F43E11_8", "Index on RDANBY, RDTRDJ", new[] { "RDANBY", "RDTRDJ" }),
        new JdeIndex("F43E11_9", "Index on RDANBY, RDDRQJ", new[] { "RDANBY", "RDDRQJ" })
    };
}
