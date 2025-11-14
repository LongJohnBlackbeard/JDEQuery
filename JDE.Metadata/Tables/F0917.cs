using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0917 - .
/// </summary>
public class F0917 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GDPOST.
        /// </summary>
        public const string GDPOST = "GDPOST";

        /// <summary>
        /// GDGLBA.
        /// </summary>
        public const string GDGLBA = "GDGLBA";

        /// <summary>
        /// GDAM.
        /// </summary>
        public const string GDAM = "GDAM";

        /// <summary>
        /// GDSTMD.
        /// </summary>
        public const string GDSTMD = "GDSTMD";

        /// <summary>
        /// GDSTBA.
        /// </summary>
        public const string GDSTBA = "GDSTBA";

        /// <summary>
        /// GDLIN.
        /// </summary>
        public const string GDLIN = "GDLIN";

        /// <summary>
        /// GDSEQ.
        /// </summary>
        public const string GDSEQ = "GDSEQ";

        /// <summary>
        /// GDSSTC.
        /// </summary>
        public const string GDSSTC = "GDSSTC";

        /// <summary>
        /// GDSTRN.
        /// </summary>
        public const string GDSTRN = "GDSTRN";

        /// <summary>
        /// GDAG.
        /// </summary>
        public const string GDAG = "GDAG";

        /// <summary>
        /// GDCRCD.
        /// </summary>
        public const string GDCRCD = "GDCRCD";

        /// <summary>
        /// GDACR.
        /// </summary>
        public const string GDACR = "GDACR";

        /// <summary>
        /// GDABC.
        /// </summary>
        public const string GDABC = "GDABC";

        /// <summary>
        /// GDSTAM.
        /// </summary>
        public const string GDSTAM = "GDSTAM";

        /// <summary>
        /// GDCTAM.
        /// </summary>
        public const string GDCTAM = "GDCTAM";

        /// <summary>
        /// GDATXA.
        /// </summary>
        public const string GDATXA = "GDATXA";

        /// <summary>
        /// GDCTXA.
        /// </summary>
        public const string GDCTXA = "GDCTXA";

        /// <summary>
        /// GDEXR1.
        /// </summary>
        public const string GDEXR1 = "GDEXR1";

        /// <summary>
        /// GDTXA1.
        /// </summary>
        public const string GDTXA1 = "GDTXA1";

        /// <summary>
        /// GDRMK.
        /// </summary>
        public const string GDRMK = "GDRMK";

        /// <summary>
        /// GDAN8.
        /// </summary>
        public const string GDAN8 = "GDAN8";

        /// <summary>
        /// GDCBNK.
        /// </summary>
        public const string GDCBNK = "GDCBNK";

        /// <summary>
        /// GDTNST.
        /// </summary>
        public const string GDTNST = "GDTNST";

        /// <summary>
        /// GDCO.
        /// </summary>
        public const string GDCO = "GDCO";

        /// <summary>
        /// GDDOC.
        /// </summary>
        public const string GDDOC = "GDDOC";

        /// <summary>
        /// GDDCT.
        /// </summary>
        public const string GDDCT = "GDDCT";

        /// <summary>
        /// GDSFX.
        /// </summary>
        public const string GDSFX = "GDSFX";

        /// <summary>
        /// GDDOCM.
        /// </summary>
        public const string GDDOCM = "GDDOCM";

        /// <summary>
        /// GDDCTM.
        /// </summary>
        public const string GDDCTM = "GDDCTM";

        /// <summary>
        /// GDDMTJ.
        /// </summary>
        public const string GDDMTJ = "GDDMTJ";

        /// <summary>
        /// GDPO.
        /// </summary>
        public const string GDPO = "GDPO";

        /// <summary>
        /// GDDCTO.
        /// </summary>
        public const string GDDCTO = "GDDCTO";

        /// <summary>
        /// GDANI.
        /// </summary>
        public const string GDANI = "GDANI";

        /// <summary>
        /// GDDGJ.
        /// </summary>
        public const string GDDGJ = "GDDGJ";

        /// <summary>
        /// GDSBL.
        /// </summary>
        public const string GDSBL = "GDSBL";

        /// <summary>
        /// GDSBLT.
        /// </summary>
        public const string GDSBLT = "GDSBLT";

        /// <summary>
        /// GDTRTC.
        /// </summary>
        public const string GDTRTC = "GDTRTC";

        /// <summary>
        /// GDVLDT.
        /// </summary>
        public const string GDVLDT = "GDVLDT";

        /// <summary>
        /// GDPYIN.
        /// </summary>
        public const string GDPYIN = "GDPYIN";

        /// <summary>
        /// GDCTL.
        /// </summary>
        public const string GDCTL = "GDCTL";

        /// <summary>
        /// GDR1.
        /// </summary>
        public const string GDR1 = "GDR1";

        /// <summary>
        /// GDHMCU.
        /// </summary>
        public const string GDHMCU = "GDHMCU";

        /// <summary>
        /// GDUSER.
        /// </summary>
        public const string GDUSER = "GDUSER";

        /// <summary>
        /// GDKCO.
        /// </summary>
        public const string GDKCO = "GDKCO";

        /// <summary>
        /// GDBTT.
        /// </summary>
        public const string GDBTT = "GDBTT";

        /// <summary>
        /// GDR1O.
        /// </summary>
        public const string GDR1O = "GDR1O";

        /// <summary>
        /// GDOVDT.
        /// </summary>
        public const string GDOVDT = "GDOVDT";

        /// <summary>
        /// GDEXA.
        /// </summary>
        public const string GDEXA = "GDEXA";

        /// <summary>
        /// GDDG.
        /// </summary>
        public const string GDDG = "GDDG";

        /// <summary>
        /// GDDMT.
        /// </summary>
        public const string GDDMT = "GDDMT";

        /// <summary>
        /// GDPYID.
        /// </summary>
        public const string GDPYID = "GDPYID";

        /// <summary>
        /// GDPID.
        /// </summary>
        public const string GDPID = "GDPID";

        /// <summary>
        /// GDJOBN.
        /// </summary>
        public const string GDJOBN = "GDJOBN";

        /// <summary>
        /// GDUPMJ.
        /// </summary>
        public const string GDUPMJ = "GDUPMJ";

        /// <summary>
        /// GDUPMT.
        /// </summary>
        public const string GDUPMT = "GDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0917";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GDPOST", "GDPOST", JdeDataType.String, 2),
        new JdeField("GDGLBA", "GDGLBA", JdeDataType.String, 16, true, true),
        new JdeField("GDAM", "GDAM", JdeDataType.String, 2),
        new JdeField("GDSTMD", "GDSTMD", JdeDataType.Numeric, null, true, true),
        new JdeField("GDSTBA", "GDSTBA", JdeDataType.String, 30, true, true),
        new JdeField("GDLIN", "GDLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("GDSEQ", "GDSEQ", JdeDataType.Numeric),
        new JdeField("GDSSTC", "GDSSTC", JdeDataType.String, 2),
        new JdeField("GDSTRN", "GDSTRN", JdeDataType.String, 6),
        new JdeField("GDAG", "GDAG", JdeDataType.Numeric),
        new JdeField("GDCRCD", "GDCRCD", JdeDataType.String, 6),
        new JdeField("GDACR", "GDACR", JdeDataType.Numeric),
        new JdeField("GDABC", "GDABC", JdeDataType.Numeric),
        new JdeField("GDSTAM", "GDSTAM", JdeDataType.Numeric),
        new JdeField("GDCTAM", "GDCTAM", JdeDataType.Numeric),
        new JdeField("GDATXA", "GDATXA", JdeDataType.Numeric),
        new JdeField("GDCTXA", "GDCTXA", JdeDataType.Numeric),
        new JdeField("GDEXR1", "GDEXR1", JdeDataType.String, 4),
        new JdeField("GDTXA1", "GDTXA1", JdeDataType.String, 20),
        new JdeField("GDRMK", "GDRMK", JdeDataType.String, 60),
        new JdeField("GDAN8", "GDAN8", JdeDataType.Numeric),
        new JdeField("GDCBNK", "GDCBNK", JdeDataType.String, 40),
        new JdeField("GDTNST", "GDTNST", JdeDataType.String, 40),
        new JdeField("GDCO", "GDCO", JdeDataType.String, 10),
        new JdeField("GDDOC", "GDDOC", JdeDataType.Numeric),
        new JdeField("GDDCT", "GDDCT", JdeDataType.String, 4),
        new JdeField("GDSFX", "GDSFX", JdeDataType.String, 6),
        new JdeField("GDDOCM", "GDDOCM", JdeDataType.Numeric),
        new JdeField("GDDCTM", "GDDCTM", JdeDataType.String, 4),
        new JdeField("GDDMTJ", "GDDMTJ", JdeDataType.Numeric),
        new JdeField("GDPO", "GDPO", JdeDataType.String, 16),
        new JdeField("GDDCTO", "GDDCTO", JdeDataType.String, 4),
        new JdeField("GDANI", "GDANI", JdeDataType.String, 58),
        new JdeField("GDDGJ", "GDDGJ", JdeDataType.Numeric),
        new JdeField("GDSBL", "GDSBL", JdeDataType.String, 16),
        new JdeField("GDSBLT", "GDSBLT", JdeDataType.String, 2),
        new JdeField("GDTRTC", "GDTRTC", JdeDataType.String, 2),
        new JdeField("GDVLDT", "GDVLDT", JdeDataType.Numeric),
        new JdeField("GDPYIN", "GDPYIN", JdeDataType.String, 2),
        new JdeField("GDCTL", "GDCTL", JdeDataType.String, 26),
        new JdeField("GDR1", "GDR1", JdeDataType.String, 16),
        new JdeField("GDHMCU", "GDHMCU", JdeDataType.String, 24),
        new JdeField("GDUSER", "GDUSER", JdeDataType.String, 20),
        new JdeField("GDKCO", "GDKCO", JdeDataType.String, 10),
        new JdeField("GDBTT", "GDBTT", JdeDataType.String, 2),
        new JdeField("GDR1O", "GDR1O", JdeDataType.String, 16),
        new JdeField("GDOVDT", "GDOVDT", JdeDataType.Numeric),
        new JdeField("GDEXA", "GDEXA", JdeDataType.String, 60),
        new JdeField("GDDG", "GDDG", JdeDataType.Numeric),
        new JdeField("GDDMT", "GDDMT", JdeDataType.Numeric),
        new JdeField("GDPYID", "GDPYID", JdeDataType.Numeric),
        new JdeField("GDPID", "GDPID", JdeDataType.String, 20),
        new JdeField("GDJOBN", "GDJOBN", JdeDataType.String, 20),
        new JdeField("GDUPMJ", "GDUPMJ", JdeDataType.Numeric),
        new JdeField("GDUPMT", "GDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0917_0", "Primary Key on GDGLBA, GDSTMD, GDSTBA, GDLIN", new[] { "GDGLBA", "GDSTMD", "GDSTBA", "GDLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0917_2", "Index on GDGLBA, GDSTMD, GDSTBA, GDSEQ", new[] { "GDGLBA", "GDSTMD", "GDSTBA", "GDSEQ" }),
        new JdeIndex("F0917_3", "Index on GDGLBA, GDSTMD, GDSTBA", new[] { "GDGLBA", "GDSTMD", "GDSTBA" }),
        new JdeIndex("F0917_4", "Index on GDGLBA, GDSTMD, GDSTBA, GDR1", new[] { "GDGLBA", "GDSTMD", "GDSTBA", "GDR1" }),
        new JdeIndex("F0917_5", "Index on GDGLBA, GDR1", new[] { "GDGLBA", "GDR1" })
    };
}
