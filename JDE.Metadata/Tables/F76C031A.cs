using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76C031A - .
/// </summary>
public class F76C031A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// RPAN8.
        /// </summary>
        public const string RPAN8 = "RPAN8";

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
        /// RPAM2.
        /// </summary>
        public const string RPAM2 = "RPAM2";

        /// <summary>
        /// RPAID2.
        /// </summary>
        public const string RPAID2 = "RPAID2";

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
        /// RPRDDJ.
        /// </summary>
        public const string RPRDDJ = "RPRDDJ";

        /// <summary>
        /// RPRDSJ.
        /// </summary>
        public const string RPRDSJ = "RPRDSJ";

        /// <summary>
        /// RPLFCJ.
        /// </summary>
        public const string RPLFCJ = "RPLFCJ";

        /// <summary>
        /// RPSMTJ.
        /// </summary>
        public const string RPSMTJ = "RPSMTJ";

        /// <summary>
        /// RPNBRR.
        /// </summary>
        public const string RPNBRR = "RPNBRR";

        /// <summary>
        /// RPRDRL.
        /// </summary>
        public const string RPRDRL = "RPRDRL";

        /// <summary>
        /// RPRMDS.
        /// </summary>
        public const string RPRMDS = "RPRMDS";

        /// <summary>
        /// RPCOLL.
        /// </summary>
        public const string RPCOLL = "RPCOLL";

        /// <summary>
        /// RPCORC.
        /// </summary>
        public const string RPCORC = "RPCORC";

        /// <summary>
        /// RPAFC.
        /// </summary>
        public const string RPAFC = "RPAFC";

        /// <summary>
        /// RPDNLT.
        /// </summary>
        public const string RPDNLT = "RPDNLT";

        /// <summary>
        /// RPRSCO.
        /// </summary>
        public const string RPRSCO = "RPRSCO";

        /// <summary>
        /// RPODOC.
        /// </summary>
        public const string RPODOC = "RPODOC";

        /// <summary>
        /// RPODCT.
        /// </summary>
        public const string RPODCT = "RPODCT";

        /// <summary>
        /// RPOKCO.
        /// </summary>
        public const string RPOKCO = "RPOKCO";

        /// <summary>
        /// RPOSFX.
        /// </summary>
        public const string RPOSFX = "RPOSFX";

        /// <summary>
        /// RPVINV.
        /// </summary>
        public const string RPVINV = "RPVINV";

        /// <summary>
        /// RPLNID.
        /// </summary>
        public const string RPLNID = "RPLNID";

        /// <summary>
        /// RPCRRM.
        /// </summary>
        public const string RPCRRM = "RPCRRM";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPUPMT.
        /// </summary>
        public const string RPUPMT = "RPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76C031A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPSFX", "RPSFX", JdeDataType.String, 6, true, true),
        new JdeField("RPAN8", "RPAN8", JdeDataType.Numeric),
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
        new JdeField("RPAM2", "RPAM2", JdeDataType.String, 2),
        new JdeField("RPAID2", "RPAID2", JdeDataType.String, 16),
        new JdeField("RPMCU", "RPMCU", JdeDataType.String, 24),
        new JdeField("RPOBJ", "RPOBJ", JdeDataType.String, 12),
        new JdeField("RPSUB", "RPSUB", JdeDataType.String, 16),
        new JdeField("RPSBLT", "RPSBLT", JdeDataType.String, 2),
        new JdeField("RPSBL", "RPSBL", JdeDataType.String, 16),
        new JdeField("RPPTC", "RPPTC", JdeDataType.String, 6),
        new JdeField("RPDDJ", "RPDDJ", JdeDataType.Numeric),
        new JdeField("RPDDNJ", "RPDDNJ", JdeDataType.Numeric),
        new JdeField("RPRDDJ", "RPRDDJ", JdeDataType.Numeric),
        new JdeField("RPRDSJ", "RPRDSJ", JdeDataType.Numeric),
        new JdeField("RPLFCJ", "RPLFCJ", JdeDataType.Numeric),
        new JdeField("RPSMTJ", "RPSMTJ", JdeDataType.Numeric),
        new JdeField("RPNBRR", "RPNBRR", JdeDataType.String, 2),
        new JdeField("RPRDRL", "RPRDRL", JdeDataType.String, 2),
        new JdeField("RPRMDS", "RPRMDS", JdeDataType.Numeric),
        new JdeField("RPCOLL", "RPCOLL", JdeDataType.String, 2),
        new JdeField("RPCORC", "RPCORC", JdeDataType.String, 4),
        new JdeField("RPAFC", "RPAFC", JdeDataType.String, 2),
        new JdeField("RPDNLT", "RPDNLT", JdeDataType.String, 2),
        new JdeField("RPRSCO", "RPRSCO", JdeDataType.String, 4),
        new JdeField("RPODOC", "RPODOC", JdeDataType.Numeric),
        new JdeField("RPODCT", "RPODCT", JdeDataType.String, 4),
        new JdeField("RPOKCO", "RPOKCO", JdeDataType.String, 10),
        new JdeField("RPOSFX", "RPOSFX", JdeDataType.String, 6),
        new JdeField("RPVINV", "RPVINV", JdeDataType.String, 50),
        new JdeField("RPLNID", "RPLNID", JdeDataType.Numeric),
        new JdeField("RPCRRM", "RPCRRM", JdeDataType.String, 2),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76C031A_0", "Primary Key on RPDOC, RPDCT, RPKCO, RPSFX", new[] { "RPDOC", "RPDCT", "RPKCO", "RPSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
