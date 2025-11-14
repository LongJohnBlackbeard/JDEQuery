using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74900 - .
/// </summary>
public class F74900 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPTORG.
        /// </summary>
        public const string RPTORG = "RPTORG";

        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPSFX.
        /// </summary>
        public const string RPSFX = "RPSFX";

        /// <summary>
        /// RPSFXE.
        /// </summary>
        public const string RPSFXE = "RPSFXE";

        /// <summary>
        /// RPAN8.
        /// </summary>
        public const string RPAN8 = "RPAN8";

        /// <summary>
        /// RPRP1.
        /// </summary>
        public const string RPRP1 = "RPRP1";

        /// <summary>
        /// RPYN.
        /// </summary>
        public const string RPYN = "RPYN";

        /// <summary>
        /// RPCTR.
        /// </summary>
        public const string RPCTR = "RPCTR";

        /// <summary>
        /// RPGFL1.
        /// </summary>
        public const string RPGFL1 = "RPGFL1";

        /// <summary>
        /// RPDGJ.
        /// </summary>
        public const string RPDGJ = "RPDGJ";

        /// <summary>
        /// RPDIVJ.
        /// </summary>
        public const string RPDIVJ = "RPDIVJ";

        /// <summary>
        /// RPICUT.
        /// </summary>
        public const string RPICUT = "RPICUT";

        /// <summary>
        /// RPICU.
        /// </summary>
        public const string RPICU = "RPICU";

        /// <summary>
        /// RPDICJ.
        /// </summary>
        public const string RPDICJ = "RPDICJ";

        /// <summary>
        /// RPFY.
        /// </summary>
        public const string RPFY = "RPFY";

        /// <summary>
        /// RPCTRY.
        /// </summary>
        public const string RPCTRY = "RPCTRY";

        /// <summary>
        /// RPPN.
        /// </summary>
        public const string RPPN = "RPPN";

        /// <summary>
        /// RPCO.
        /// </summary>
        public const string RPCO = "RPCO";

        /// <summary>
        /// RPGLC.
        /// </summary>
        public const string RPGLC = "RPGLC";

        /// <summary>
        /// RPAID.
        /// </summary>
        public const string RPAID = "RPAID";

        /// <summary>
        /// RPPA8.
        /// </summary>
        public const string RPPA8 = "RPPA8";

        /// <summary>
        /// RPAN8J.
        /// </summary>
        public const string RPAN8J = "RPAN8J";

        /// <summary>
        /// RPPYR.
        /// </summary>
        public const string RPPYR = "RPPYR";

        /// <summary>
        /// RPPYE.
        /// </summary>
        public const string RPPYE = "RPPYE";

        /// <summary>
        /// RPPOST.
        /// </summary>
        public const string RPPOST = "RPPOST";

        /// <summary>
        /// RPISTR.
        /// </summary>
        public const string RPISTR = "RPISTR";

        /// <summary>
        /// RPBALJ.
        /// </summary>
        public const string RPBALJ = "RPBALJ";

        /// <summary>
        /// RPPST.
        /// </summary>
        public const string RPPST = "RPPST";

        /// <summary>
        /// RPAG.
        /// </summary>
        public const string RPAG = "RPAG";

        /// <summary>
        /// RPAAP.
        /// </summary>
        public const string RPAAP = "RPAAP";

        /// <summary>
        /// RPADSC.
        /// </summary>
        public const string RPADSC = "RPADSC";

        /// <summary>
        /// RPADSA.
        /// </summary>
        public const string RPADSA = "RPADSA";

        /// <summary>
        /// RPATXA.
        /// </summary>
        public const string RPATXA = "RPATXA";

        /// <summary>
        /// RPATXN.
        /// </summary>
        public const string RPATXN = "RPATXN";

        /// <summary>
        /// RPSTAM.
        /// </summary>
        public const string RPSTAM = "RPSTAM";

        /// <summary>
        /// RPBCRC.
        /// </summary>
        public const string RPBCRC = "RPBCRC";

        /// <summary>
        /// RPCRRM.
        /// </summary>
        public const string RPCRRM = "RPCRRM";

        /// <summary>
        /// RPCRCD.
        /// </summary>
        public const string RPCRCD = "RPCRCD";

        /// <summary>
        /// RPCRR.
        /// </summary>
        public const string RPCRR = "RPCRR";

        /// <summary>
        /// RPDMCD.
        /// </summary>
        public const string RPDMCD = "RPDMCD";

        /// <summary>
        /// RPACR.
        /// </summary>
        public const string RPACR = "RPACR";

        /// <summary>
        /// RPFAP.
        /// </summary>
        public const string RPFAP = "RPFAP";

        /// <summary>
        /// RPCDS.
        /// </summary>
        public const string RPCDS = "RPCDS";

        /// <summary>
        /// RPCDSA.
        /// </summary>
        public const string RPCDSA = "RPCDSA";

        /// <summary>
        /// RPCTXA.
        /// </summary>
        public const string RPCTXA = "RPCTXA";

        /// <summary>
        /// RPCTXN.
        /// </summary>
        public const string RPCTXN = "RPCTXN";

        /// <summary>
        /// RPCTAM.
        /// </summary>
        public const string RPCTAM = "RPCTAM";

        /// <summary>
        /// RPTXA1.
        /// </summary>
        public const string RPTXA1 = "RPTXA1";

        /// <summary>
        /// RPEXR1.
        /// </summary>
        public const string RPEXR1 = "RPEXR1";

        /// <summary>
        /// RPDSVJ.
        /// </summary>
        public const string RPDSVJ = "RPDSVJ";

        /// <summary>
        /// RPGLBA.
        /// </summary>
        public const string RPGLBA = "RPGLBA";

        /// <summary>
        /// RPAM.
        /// </summary>
        public const string RPAM = "RPAM";

        /// <summary>
        /// RPAID2.
        /// </summary>
        public const string RPAID2 = "RPAID2";

        /// <summary>
        /// RPAM2.
        /// </summary>
        public const string RPAM2 = "RPAM2";

        /// <summary>
        /// RPMCU.
        /// </summary>
        public const string RPMCU = "RPMCU";

        /// <summary>
        /// RPOBJ.
        /// </summary>
        public const string RPOBJ = "RPOBJ";

        /// <summary>
        /// RPSUB.
        /// </summary>
        public const string RPSUB = "RPSUB";

        /// <summary>
        /// RPSBLT.
        /// </summary>
        public const string RPSBLT = "RPSBLT";

        /// <summary>
        /// RPSBL.
        /// </summary>
        public const string RPSBL = "RPSBL";

        /// <summary>
        /// RPPTC.
        /// </summary>
        public const string RPPTC = "RPPTC";

        /// <summary>
        /// RPDDJ.
        /// </summary>
        public const string RPDDJ = "RPDDJ";

        /// <summary>
        /// RPDDNJ.
        /// </summary>
        public const string RPDDNJ = "RPDDNJ";

        /// <summary>
        /// RPURC1.
        /// </summary>
        public const string RPURC1 = "RPURC1";

        /// <summary>
        /// RPURDT.
        /// </summary>
        public const string RPURDT = "RPURDT";

        /// <summary>
        /// RPURAT.
        /// </summary>
        public const string RPURAT = "RPURAT";

        /// <summary>
        /// RPURAB.
        /// </summary>
        public const string RPURAB = "RPURAB";

        /// <summary>
        /// RPURRF.
        /// </summary>
        public const string RPURRF = "RPURRF";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPUPMT.
        /// </summary>
        public const string RPUPMT = "RPUPMT";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74900";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPTORG", "RPTORG", JdeDataType.String, 20, true, true),
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPSFXE", "RPSFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("RPAN8", "RPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RPRP1", "RPRP1", JdeDataType.String, 2),
        new JdeField("RPYN", "RPYN", JdeDataType.String, 2),
        new JdeField("RPCTR", "RPCTR", JdeDataType.String, 6),
        new JdeField("RPGFL1", "RPGFL1", JdeDataType.String, 2),
        new JdeField("RPDGJ", "RPDGJ", JdeDataType.Numeric),
        new JdeField("RPDIVJ", "RPDIVJ", JdeDataType.Numeric),
        new JdeField("RPICUT", "RPICUT", JdeDataType.String, 4),
        new JdeField("RPICU", "RPICU", JdeDataType.Numeric),
        new JdeField("RPDICJ", "RPDICJ", JdeDataType.Numeric),
        new JdeField("RPFY", "RPFY", JdeDataType.Numeric),
        new JdeField("RPCTRY", "RPCTRY", JdeDataType.Numeric),
        new JdeField("RPPN", "RPPN", JdeDataType.Numeric),
        new JdeField("RPCO", "RPCO", JdeDataType.String, 10),
        new JdeField("RPGLC", "RPGLC", JdeDataType.String, 8),
        new JdeField("RPAID", "RPAID", JdeDataType.String, 16),
        new JdeField("RPPA8", "RPPA8", JdeDataType.Numeric),
        new JdeField("RPAN8J", "RPAN8J", JdeDataType.Numeric),
        new JdeField("RPPYR", "RPPYR", JdeDataType.Numeric),
        new JdeField("RPPYE", "RPPYE", JdeDataType.Numeric),
        new JdeField("RPPOST", "RPPOST", JdeDataType.String, 2),
        new JdeField("RPISTR", "RPISTR", JdeDataType.String, 2),
        new JdeField("RPBALJ", "RPBALJ", JdeDataType.String, 2),
        new JdeField("RPPST", "RPPST", JdeDataType.String, 2),
        new JdeField("RPAG", "RPAG", JdeDataType.Numeric),
        new JdeField("RPAAP", "RPAAP", JdeDataType.Numeric),
        new JdeField("RPADSC", "RPADSC", JdeDataType.Numeric),
        new JdeField("RPADSA", "RPADSA", JdeDataType.Numeric),
        new JdeField("RPATXA", "RPATXA", JdeDataType.Numeric),
        new JdeField("RPATXN", "RPATXN", JdeDataType.Numeric),
        new JdeField("RPSTAM", "RPSTAM", JdeDataType.Numeric),
        new JdeField("RPBCRC", "RPBCRC", JdeDataType.String, 6),
        new JdeField("RPCRRM", "RPCRRM", JdeDataType.String, 2),
        new JdeField("RPCRCD", "RPCRCD", JdeDataType.String, 6),
        new JdeField("RPCRR", "RPCRR", JdeDataType.Numeric),
        new JdeField("RPDMCD", "RPDMCD", JdeDataType.String, 2),
        new JdeField("RPACR", "RPACR", JdeDataType.Numeric),
        new JdeField("RPFAP", "RPFAP", JdeDataType.Numeric),
        new JdeField("RPCDS", "RPCDS", JdeDataType.Numeric),
        new JdeField("RPCDSA", "RPCDSA", JdeDataType.Numeric),
        new JdeField("RPCTXA", "RPCTXA", JdeDataType.Numeric),
        new JdeField("RPCTXN", "RPCTXN", JdeDataType.Numeric),
        new JdeField("RPCTAM", "RPCTAM", JdeDataType.Numeric),
        new JdeField("RPTXA1", "RPTXA1", JdeDataType.String, 20),
        new JdeField("RPEXR1", "RPEXR1", JdeDataType.String, 4),
        new JdeField("RPDSVJ", "RPDSVJ", JdeDataType.Numeric),
        new JdeField("RPGLBA", "RPGLBA", JdeDataType.String, 16),
        new JdeField("RPAM", "RPAM", JdeDataType.String, 2),
        new JdeField("RPAID2", "RPAID2", JdeDataType.String, 16),
        new JdeField("RPAM2", "RPAM2", JdeDataType.String, 2),
        new JdeField("RPMCU", "RPMCU", JdeDataType.String, 24),
        new JdeField("RPOBJ", "RPOBJ", JdeDataType.String, 12),
        new JdeField("RPSUB", "RPSUB", JdeDataType.String, 16),
        new JdeField("RPSBLT", "RPSBLT", JdeDataType.String, 2),
        new JdeField("RPSBL", "RPSBL", JdeDataType.String, 16),
        new JdeField("RPPTC", "RPPTC", JdeDataType.String, 6),
        new JdeField("RPDDJ", "RPDDJ", JdeDataType.Numeric),
        new JdeField("RPDDNJ", "RPDDNJ", JdeDataType.Numeric),
        new JdeField("RPURC1", "RPURC1", JdeDataType.String, 6),
        new JdeField("RPURDT", "RPURDT", JdeDataType.Numeric),
        new JdeField("RPURAT", "RPURAT", JdeDataType.Numeric),
        new JdeField("RPURAB", "RPURAB", JdeDataType.Numeric),
        new JdeField("RPURRF", "RPURRF", JdeDataType.String, 30),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74900_0", "Primary Key on RPAN8, RPDCT, RPDOC, RPKCO, RPSFX, RPSFXE, RPTORG", new[] { "RPAN8", "RPDCT", "RPDOC", "RPKCO", "RPSFX", "RPSFXE", "RPTORG" }, isUnique: true, isPrimaryKey: true)
    };
}
