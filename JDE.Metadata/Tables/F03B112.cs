using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B112 - .
/// </summary>
public class F03B112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RWDOC.
        /// </summary>
        public const string RWDOC = "RWDOC";

        /// <summary>
        /// RWDCT.
        /// </summary>
        public const string RWDCT = "RWDCT";

        /// <summary>
        /// RWKCO.
        /// </summary>
        public const string RWKCO = "RWKCO";

        /// <summary>
        /// RWSFX.
        /// </summary>
        public const string RWSFX = "RWSFX";

        /// <summary>
        /// RWSFXE.
        /// </summary>
        public const string RWSFXE = "RWSFXE";

        /// <summary>
        /// RWODOC.
        /// </summary>
        public const string RWODOC = "RWODOC";

        /// <summary>
        /// RWODCT.
        /// </summary>
        public const string RWODCT = "RWODCT";

        /// <summary>
        /// RWOKCO.
        /// </summary>
        public const string RWOKCO = "RWOKCO";

        /// <summary>
        /// RWOSFX.
        /// </summary>
        public const string RWOSFX = "RWOSFX";

        /// <summary>
        /// RWARE.
        /// </summary>
        public const string RWARE = "RWARE";

        /// <summary>
        /// RWFY.
        /// </summary>
        public const string RWFY = "RWFY";

        /// <summary>
        /// RWCTRY.
        /// </summary>
        public const string RWCTRY = "RWCTRY";

        /// <summary>
        /// RWPN.
        /// </summary>
        public const string RWPN = "RWPN";

        /// <summary>
        /// RWCO.
        /// </summary>
        public const string RWCO = "RWCO";

        /// <summary>
        /// RWDGJ.
        /// </summary>
        public const string RWDGJ = "RWDGJ";

        /// <summary>
        /// RWDIVJ.
        /// </summary>
        public const string RWDIVJ = "RWDIVJ";

        /// <summary>
        /// RWICU.
        /// </summary>
        public const string RWICU = "RWICU";

        /// <summary>
        /// RWICUT.
        /// </summary>
        public const string RWICUT = "RWICUT";

        /// <summary>
        /// RWDICJ.
        /// </summary>
        public const string RWDICJ = "RWDICJ";

        /// <summary>
        /// RWAN8.
        /// </summary>
        public const string RWAN8 = "RWAN8";

        /// <summary>
        /// RWPA8.
        /// </summary>
        public const string RWPA8 = "RWPA8";

        /// <summary>
        /// RWPOST.
        /// </summary>
        public const string RWPOST = "RWPOST";

        /// <summary>
        /// RWPST.
        /// </summary>
        public const string RWPST = "RWPST";

        /// <summary>
        /// RWGLC.
        /// </summary>
        public const string RWGLC = "RWGLC";

        /// <summary>
        /// RWRMK.
        /// </summary>
        public const string RWRMK = "RWRMK";

        /// <summary>
        /// RWAG.
        /// </summary>
        public const string RWAG = "RWAG";

        /// <summary>
        /// RWAAP.
        /// </summary>
        public const string RWAAP = "RWAAP";

        /// <summary>
        /// RWADSC.
        /// </summary>
        public const string RWADSC = "RWADSC";

        /// <summary>
        /// RWADSA.
        /// </summary>
        public const string RWADSA = "RWADSA";

        /// <summary>
        /// RWATXA.
        /// </summary>
        public const string RWATXA = "RWATXA";

        /// <summary>
        /// RWATXN.
        /// </summary>
        public const string RWATXN = "RWATXN";

        /// <summary>
        /// RWSTAM.
        /// </summary>
        public const string RWSTAM = "RWSTAM";

        /// <summary>
        /// RWBCRC.
        /// </summary>
        public const string RWBCRC = "RWBCRC";

        /// <summary>
        /// RWDMCD.
        /// </summary>
        public const string RWDMCD = "RWDMCD";

        /// <summary>
        /// RWCRRM.
        /// </summary>
        public const string RWCRRM = "RWCRRM";

        /// <summary>
        /// RWCRR.
        /// </summary>
        public const string RWCRR = "RWCRR";

        /// <summary>
        /// RWCRCD.
        /// </summary>
        public const string RWCRCD = "RWCRCD";

        /// <summary>
        /// RWACR.
        /// </summary>
        public const string RWACR = "RWACR";

        /// <summary>
        /// RWFAP.
        /// </summary>
        public const string RWFAP = "RWFAP";

        /// <summary>
        /// RWCDS.
        /// </summary>
        public const string RWCDS = "RWCDS";

        /// <summary>
        /// RWCDSA.
        /// </summary>
        public const string RWCDSA = "RWCDSA";

        /// <summary>
        /// RWCTXA.
        /// </summary>
        public const string RWCTXA = "RWCTXA";

        /// <summary>
        /// RWCTXN.
        /// </summary>
        public const string RWCTXN = "RWCTXN";

        /// <summary>
        /// RWCTAM.
        /// </summary>
        public const string RWCTAM = "RWCTAM";

        /// <summary>
        /// RWTXA1.
        /// </summary>
        public const string RWTXA1 = "RWTXA1";

        /// <summary>
        /// RWEXR1.
        /// </summary>
        public const string RWEXR1 = "RWEXR1";

        /// <summary>
        /// RWPTC.
        /// </summary>
        public const string RWPTC = "RWPTC";

        /// <summary>
        /// RWDSVJ.
        /// </summary>
        public const string RWDSVJ = "RWDSVJ";

        /// <summary>
        /// RWITM.
        /// </summary>
        public const string RWITM = "RWITM";

        /// <summary>
        /// RWDDJ.
        /// </summary>
        public const string RWDDJ = "RWDDJ";

        /// <summary>
        /// RWDDNJ.
        /// </summary>
        public const string RWDDNJ = "RWDDNJ";

        /// <summary>
        /// RWODDJ.
        /// </summary>
        public const string RWODDJ = "RWODDJ";

        /// <summary>
        /// RWOAG.
        /// </summary>
        public const string RWOAG = "RWOAG";

        /// <summary>
        /// RWISTC.
        /// </summary>
        public const string RWISTC = "RWISTC";

        /// <summary>
        /// RWRNID.
        /// </summary>
        public const string RWRNID = "RWRNID";

        /// <summary>
        /// RWMCU.
        /// </summary>
        public const string RWMCU = "RWMCU";

        /// <summary>
        /// RWSTPF.
        /// </summary>
        public const string RWSTPF = "RWSTPF";

        /// <summary>
        /// RWUSER.
        /// </summary>
        public const string RWUSER = "RWUSER";

        /// <summary>
        /// RWPID.
        /// </summary>
        public const string RWPID = "RWPID";

        /// <summary>
        /// RWUPMJ.
        /// </summary>
        public const string RWUPMJ = "RWUPMJ";

        /// <summary>
        /// RWUPMT.
        /// </summary>
        public const string RWUPMT = "RWUPMT";

        /// <summary>
        /// RWJOBN.
        /// </summary>
        public const string RWJOBN = "RWJOBN";

        /// <summary>
        /// RWOMOD.
        /// </summary>
        public const string RWOMOD = "RWOMOD";

        /// <summary>
        /// RWATAD.
        /// </summary>
        public const string RWATAD = "RWATAD";

        /// <summary>
        /// RWCTAD.
        /// </summary>
        public const string RWCTAD = "RWCTAD";

        /// <summary>
        /// RWNRTA.
        /// </summary>
        public const string RWNRTA = "RWNRTA";

        /// <summary>
        /// RWFNRT.
        /// </summary>
        public const string RWFNRT = "RWFNRT";
    }

    /// <inheritdoc />
    public override string TableName => "F03B112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RWDOC", "RWDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RWDCT", "RWDCT", JdeDataType.String, 4, true, true),
        new JdeField("RWKCO", "RWKCO", JdeDataType.String, 10, true, true),
        new JdeField("RWSFX", "RWSFX", JdeDataType.String, 6, true, true),
        new JdeField("RWSFXE", "RWSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RWODOC", "RWODOC", JdeDataType.Numeric),
        new JdeField("RWODCT", "RWODCT", JdeDataType.String, 4),
        new JdeField("RWOKCO", "RWOKCO", JdeDataType.String, 10),
        new JdeField("RWOSFX", "RWOSFX", JdeDataType.String, 6),
        new JdeField("RWARE", "RWARE", JdeDataType.String, 6),
        new JdeField("RWFY", "RWFY", JdeDataType.Numeric),
        new JdeField("RWCTRY", "RWCTRY", JdeDataType.Numeric),
        new JdeField("RWPN", "RWPN", JdeDataType.Numeric),
        new JdeField("RWCO", "RWCO", JdeDataType.String, 10),
        new JdeField("RWDGJ", "RWDGJ", JdeDataType.Numeric),
        new JdeField("RWDIVJ", "RWDIVJ", JdeDataType.Numeric),
        new JdeField("RWICU", "RWICU", JdeDataType.Numeric),
        new JdeField("RWICUT", "RWICUT", JdeDataType.String, 4),
        new JdeField("RWDICJ", "RWDICJ", JdeDataType.Numeric),
        new JdeField("RWAN8", "RWAN8", JdeDataType.Numeric),
        new JdeField("RWPA8", "RWPA8", JdeDataType.Numeric),
        new JdeField("RWPOST", "RWPOST", JdeDataType.String, 2),
        new JdeField("RWPST", "RWPST", JdeDataType.String, 2),
        new JdeField("RWGLC", "RWGLC", JdeDataType.String, 8),
        new JdeField("RWRMK", "RWRMK", JdeDataType.String, 60),
        new JdeField("RWAG", "RWAG", JdeDataType.Numeric),
        new JdeField("RWAAP", "RWAAP", JdeDataType.Numeric),
        new JdeField("RWADSC", "RWADSC", JdeDataType.Numeric),
        new JdeField("RWADSA", "RWADSA", JdeDataType.Numeric),
        new JdeField("RWATXA", "RWATXA", JdeDataType.Numeric),
        new JdeField("RWATXN", "RWATXN", JdeDataType.Numeric),
        new JdeField("RWSTAM", "RWSTAM", JdeDataType.Numeric),
        new JdeField("RWBCRC", "RWBCRC", JdeDataType.String, 6),
        new JdeField("RWDMCD", "RWDMCD", JdeDataType.String, 2),
        new JdeField("RWCRRM", "RWCRRM", JdeDataType.String, 2),
        new JdeField("RWCRR", "RWCRR", JdeDataType.Numeric),
        new JdeField("RWCRCD", "RWCRCD", JdeDataType.String, 6),
        new JdeField("RWACR", "RWACR", JdeDataType.Numeric),
        new JdeField("RWFAP", "RWFAP", JdeDataType.Numeric),
        new JdeField("RWCDS", "RWCDS", JdeDataType.Numeric),
        new JdeField("RWCDSA", "RWCDSA", JdeDataType.Numeric),
        new JdeField("RWCTXA", "RWCTXA", JdeDataType.Numeric),
        new JdeField("RWCTXN", "RWCTXN", JdeDataType.Numeric),
        new JdeField("RWCTAM", "RWCTAM", JdeDataType.Numeric),
        new JdeField("RWTXA1", "RWTXA1", JdeDataType.String, 20),
        new JdeField("RWEXR1", "RWEXR1", JdeDataType.String, 4),
        new JdeField("RWPTC", "RWPTC", JdeDataType.String, 6),
        new JdeField("RWDSVJ", "RWDSVJ", JdeDataType.Numeric),
        new JdeField("RWITM", "RWITM", JdeDataType.Numeric),
        new JdeField("RWDDJ", "RWDDJ", JdeDataType.Numeric),
        new JdeField("RWDDNJ", "RWDDNJ", JdeDataType.Numeric),
        new JdeField("RWODDJ", "RWODDJ", JdeDataType.Numeric),
        new JdeField("RWOAG", "RWOAG", JdeDataType.Numeric),
        new JdeField("RWISTC", "RWISTC", JdeDataType.String, 2),
        new JdeField("RWRNID", "RWRNID", JdeDataType.Numeric),
        new JdeField("RWMCU", "RWMCU", JdeDataType.String, 24),
        new JdeField("RWSTPF", "RWSTPF", JdeDataType.String, 2),
        new JdeField("RWUSER", "RWUSER", JdeDataType.String, 20),
        new JdeField("RWPID", "RWPID", JdeDataType.String, 20),
        new JdeField("RWUPMJ", "RWUPMJ", JdeDataType.Numeric),
        new JdeField("RWUPMT", "RWUPMT", JdeDataType.Numeric),
        new JdeField("RWJOBN", "RWJOBN", JdeDataType.String, 20),
        new JdeField("RWOMOD", "RWOMOD", JdeDataType.String, 2),
        new JdeField("RWATAD", "RWATAD", JdeDataType.Numeric),
        new JdeField("RWCTAD", "RWCTAD", JdeDataType.Numeric),
        new JdeField("RWNRTA", "RWNRTA", JdeDataType.Numeric),
        new JdeField("RWFNRT", "RWFNRT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B112_0", "Primary Key on RWDOC, RWDCT, RWKCO, RWSFX, RWSFXE", new[] { "RWDOC", "RWDCT", "RWKCO", "RWSFX", "RWSFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B112_2", "Index on RWICUT, RWICU, RWPOST", new[] { "RWICUT", "RWICU", "RWPOST" }),
        new JdeIndex("F03B112_3", "Index on RWODOC, RWODCT, RWOKCO, RWOSFX, RWPOST", new[] { "RWODOC", "RWODCT", "RWOKCO", "RWOSFX", "RWPOST" }),
        new JdeIndex("F03B112_5", "Index on RWDOC, RWDCT, RWKCO, RWSFX, SYS_NC00068$", new[] { "RWDOC", "RWDCT", "RWKCO", "RWSFX", "SYS_NC00068$" }),
        new JdeIndex("F03B112_6", "Index on RWAN8, RWCO, RWDGJ", new[] { "RWAN8", "RWCO", "RWDGJ" })
    };
}
