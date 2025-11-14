using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41500 - .
/// </summary>
public class F41500 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPMCU.
        /// </summary>
        public const string PPMCU = "PPMCU";

        /// <summary>
        /// PPTKID.
        /// </summary>
        public const string PPTKID = "PPTKID";

        /// <summary>
        /// PPDL01.
        /// </summary>
        public const string PPDL01 = "PPDL01";

        /// <summary>
        /// PPTKLO.
        /// </summary>
        public const string PPTKLO = "PPTKLO";

        /// <summary>
        /// PPTUSE.
        /// </summary>
        public const string PPTUSE = "PPTUSE";

        /// <summary>
        /// PPTKTY.
        /// </summary>
        public const string PPTKTY = "PPTKTY";

        /// <summary>
        /// PPTKCP.
        /// </summary>
        public const string PPTKCP = "PPTKCP";

        /// <summary>
        /// PPBUM1.
        /// </summary>
        public const string PPBUM1 = "PPBUM1";

        /// <summary>
        /// PPHTTK.
        /// </summary>
        public const string PPHTTK = "PPHTTK";

        /// <summary>
        /// PPPREZ.
        /// </summary>
        public const string PPPREZ = "PPPREZ";

        /// <summary>
        /// PPIDTE.
        /// </summary>
        public const string PPIDTE = "PPIDTE";

        /// <summary>
        /// PPDTCL.
        /// </summary>
        public const string PPDTCL = "PPDTCL";

        /// <summary>
        /// PPSTRP.
        /// </summary>
        public const string PPSTRP = "PPSTRP";

        /// <summary>
        /// PPDIPT.
        /// </summary>
        public const string PPDIPT = "PPDIPT";

        /// <summary>
        /// PPGAMT.
        /// </summary>
        public const string PPGAMT = "PPGAMT";

        /// <summary>
        /// PPFLTR.
        /// </summary>
        public const string PPFLTR = "PPFLTR";

        /// <summary>
        /// PPTEXP.
        /// </summary>
        public const string PPTEXP = "PPTEXP";

        /// <summary>
        /// PPTSTU.
        /// </summary>
        public const string PPTSTU = "PPTSTU";

        /// <summary>
        /// PPCUTK.
        /// </summary>
        public const string PPCUTK = "PPCUTK";

        /// <summary>
        /// PPSCOM.
        /// </summary>
        public const string PPSCOM = "PPSCOM";

        /// <summary>
        /// PPTDIA.
        /// </summary>
        public const string PPTDIA = "PPTDIA";

        /// <summary>
        /// PPBUM2.
        /// </summary>
        public const string PPBUM2 = "PPBUM2";

        /// <summary>
        /// PPTHGT.
        /// </summary>
        public const string PPTHGT = "PPTHGT";

        /// <summary>
        /// PPBUM3.
        /// </summary>
        public const string PPBUM3 = "PPBUM3";

        /// <summary>
        /// PPSTEM.
        /// </summary>
        public const string PPSTEM = "PPSTEM";

        /// <summary>
        /// PPSTPU.
        /// </summary>
        public const string PPSTPU = "PPSTPU";

        /// <summary>
        /// PPREFH.
        /// </summary>
        public const string PPREFH = "PPREFH";

        /// <summary>
        /// PPBUM4.
        /// </summary>
        public const string PPBUM4 = "PPBUM4";

        /// <summary>
        /// PPRWGH.
        /// </summary>
        public const string PPRWGH = "PPRWGH";

        /// <summary>
        /// PPBUM5.
        /// </summary>
        public const string PPBUM5 = "PPBUM5";

        /// <summary>
        /// PPFLHT.
        /// </summary>
        public const string PPFLHT = "PPFLHT";

        /// <summary>
        /// PPBUM6.
        /// </summary>
        public const string PPBUM6 = "PPBUM6";

        /// <summary>
        /// PPUNPV.
        /// </summary>
        public const string PPUNPV = "PPUNPV";

        /// <summary>
        /// PPBUM7.
        /// </summary>
        public const string PPBUM7 = "PPBUM7";

        /// <summary>
        /// PPPIPV.
        /// </summary>
        public const string PPPIPV = "PPPIPV";

        /// <summary>
        /// PPBUM8.
        /// </summary>
        public const string PPBUM8 = "PPBUM8";

        /// <summary>
        /// PPDISV.
        /// </summary>
        public const string PPDISV = "PPDISV";

        /// <summary>
        /// PPBUM9.
        /// </summary>
        public const string PPBUM9 = "PPBUM9";

        /// <summary>
        /// PPDIHR.
        /// </summary>
        public const string PPDIHR = "PPDIHR";

        /// <summary>
        /// PPDHRU.
        /// </summary>
        public const string PPDHRU = "PPDHRU";

        /// <summary>
        /// PPFIRH.
        /// </summary>
        public const string PPFIRH = "PPFIRH";

        /// <summary>
        /// PPFRHU.
        /// </summary>
        public const string PPFRHU = "PPFRHU";

        /// <summary>
        /// PPLSWN.
        /// </summary>
        public const string PPLSWN = "PPLSWN";

        /// <summary>
        /// PPBUM0.
        /// </summary>
        public const string PPBUM0 = "PPBUM0";

        /// <summary>
        /// PPLOSC.
        /// </summary>
        public const string PPLOSC = "PPLOSC";

        /// <summary>
        /// PPHISC.
        /// </summary>
        public const string PPHISC = "PPHISC";

        /// <summary>
        /// PPITM.
        /// </summary>
        public const string PPITM = "PPITM";

        /// <summary>
        /// PPITML.
        /// </summary>
        public const string PPITML = "PPITML";

        /// <summary>
        /// PPPCSD.
        /// </summary>
        public const string PPPCSD = "PPPCSD";

        /// <summary>
        /// PPRTOB.
        /// </summary>
        public const string PPRTOB = "PPRTOB";

        /// <summary>
        /// PPURCD.
        /// </summary>
        public const string PPURCD = "PPURCD";

        /// <summary>
        /// PPURAT.
        /// </summary>
        public const string PPURAT = "PPURAT";

        /// <summary>
        /// PPURAB.
        /// </summary>
        public const string PPURAB = "PPURAB";

        /// <summary>
        /// PPURRF.
        /// </summary>
        public const string PPURRF = "PPURRF";

        /// <summary>
        /// PPURDT.
        /// </summary>
        public const string PPURDT = "PPURDT";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPJOBN.
        /// </summary>
        public const string PPJOBN = "PPJOBN";

        /// <summary>
        /// PPUPMJ.
        /// </summary>
        public const string PPUPMJ = "PPUPMJ";

        /// <summary>
        /// PPTDAY.
        /// </summary>
        public const string PPTDAY = "PPTDAY";

        /// <summary>
        /// PPTNKN.
        /// </summary>
        public const string PPTNKN = "PPTNKN";

        /// <summary>
        /// PPEXPF.
        /// </summary>
        public const string PPEXPF = "PPEXPF";
    }

    /// <inheritdoc />
    public override string TableName => "F41500";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPMCU", "PPMCU", JdeDataType.String, 24, true, true),
        new JdeField("PPTKID", "PPTKID", JdeDataType.String, 16, true, true),
        new JdeField("PPDL01", "PPDL01", JdeDataType.String, 60),
        new JdeField("PPTKLO", "PPTKLO", JdeDataType.String, 6),
        new JdeField("PPTUSE", "PPTUSE", JdeDataType.String, 6),
        new JdeField("PPTKTY", "PPTKTY", JdeDataType.String, 6),
        new JdeField("PPTKCP", "PPTKCP", JdeDataType.Numeric),
        new JdeField("PPBUM1", "PPBUM1", JdeDataType.String, 4),
        new JdeField("PPHTTK", "PPHTTK", JdeDataType.String, 2),
        new JdeField("PPPREZ", "PPPREZ", JdeDataType.String, 2),
        new JdeField("PPIDTE", "PPIDTE", JdeDataType.Numeric),
        new JdeField("PPDTCL", "PPDTCL", JdeDataType.Numeric),
        new JdeField("PPSTRP", "PPSTRP", JdeDataType.String, 4),
        new JdeField("PPDIPT", "PPDIPT", JdeDataType.String, 2),
        new JdeField("PPGAMT", "PPGAMT", JdeDataType.String, 2),
        new JdeField("PPFLTR", "PPFLTR", JdeDataType.String, 2),
        new JdeField("PPTEXP", "PPTEXP", JdeDataType.Numeric),
        new JdeField("PPTSTU", "PPTSTU", JdeDataType.String, 2),
        new JdeField("PPCUTK", "PPCUTK", JdeDataType.String, 2),
        new JdeField("PPSCOM", "PPSCOM", JdeDataType.String, 2),
        new JdeField("PPTDIA", "PPTDIA", JdeDataType.Numeric),
        new JdeField("PPBUM2", "PPBUM2", JdeDataType.String, 4),
        new JdeField("PPTHGT", "PPTHGT", JdeDataType.Numeric),
        new JdeField("PPBUM3", "PPBUM3", JdeDataType.String, 4),
        new JdeField("PPSTEM", "PPSTEM", JdeDataType.Numeric),
        new JdeField("PPSTPU", "PPSTPU", JdeDataType.String, 2),
        new JdeField("PPREFH", "PPREFH", JdeDataType.Numeric),
        new JdeField("PPBUM4", "PPBUM4", JdeDataType.String, 4),
        new JdeField("PPRWGH", "PPRWGH", JdeDataType.Numeric),
        new JdeField("PPBUM5", "PPBUM5", JdeDataType.String, 4),
        new JdeField("PPFLHT", "PPFLHT", JdeDataType.Numeric),
        new JdeField("PPBUM6", "PPBUM6", JdeDataType.String, 4),
        new JdeField("PPUNPV", "PPUNPV", JdeDataType.Numeric),
        new JdeField("PPBUM7", "PPBUM7", JdeDataType.String, 4),
        new JdeField("PPPIPV", "PPPIPV", JdeDataType.Numeric),
        new JdeField("PPBUM8", "PPBUM8", JdeDataType.String, 4),
        new JdeField("PPDISV", "PPDISV", JdeDataType.Numeric),
        new JdeField("PPBUM9", "PPBUM9", JdeDataType.String, 4),
        new JdeField("PPDIHR", "PPDIHR", JdeDataType.Numeric),
        new JdeField("PPDHRU", "PPDHRU", JdeDataType.String, 4),
        new JdeField("PPFIRH", "PPFIRH", JdeDataType.Numeric),
        new JdeField("PPFRHU", "PPFRHU", JdeDataType.String, 4),
        new JdeField("PPLSWN", "PPLSWN", JdeDataType.Numeric),
        new JdeField("PPBUM0", "PPBUM0", JdeDataType.String, 4),
        new JdeField("PPLOSC", "PPLOSC", JdeDataType.Numeric),
        new JdeField("PPHISC", "PPHISC", JdeDataType.Numeric),
        new JdeField("PPITM", "PPITM", JdeDataType.Numeric),
        new JdeField("PPITML", "PPITML", JdeDataType.Numeric),
        new JdeField("PPPCSD", "PPPCSD", JdeDataType.String, 20),
        new JdeField("PPRTOB", "PPRTOB", JdeDataType.String, 2),
        new JdeField("PPURCD", "PPURCD", JdeDataType.String, 4),
        new JdeField("PPURAT", "PPURAT", JdeDataType.Numeric),
        new JdeField("PPURAB", "PPURAB", JdeDataType.Numeric),
        new JdeField("PPURRF", "PPURRF", JdeDataType.String, 30),
        new JdeField("PPURDT", "PPURDT", JdeDataType.Numeric),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPJOBN", "PPJOBN", JdeDataType.String, 20),
        new JdeField("PPUPMJ", "PPUPMJ", JdeDataType.Numeric),
        new JdeField("PPTDAY", "PPTDAY", JdeDataType.Numeric),
        new JdeField("PPTNKN", "PPTNKN", JdeDataType.Numeric),
        new JdeField("PPEXPF", "PPEXPF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41500_0", "Primary Key on PPMCU, PPTKID", new[] { "PPMCU", "PPTKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41500_2", "Index on PPTKTY, PPTKID", new[] { "PPTKTY", "PPTKID" }),
        new JdeIndex("F41500_3", "Index on PPITM, PPMCU, PPCUTK, PPTKID", new[] { "PPITM", "PPMCU", "PPCUTK", "PPTKID" }),
        new JdeIndex("F41500_4", "Index on PPITM, PPMCU, PPCUTK", new[] { "PPITM", "PPMCU", "PPCUTK" })
    };
}
