using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70XMLZ1 - .
/// </summary>
public class F70XMLZ1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDUS.
        /// </summary>
        public const string SYEDUS = "SYEDUS";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYEDTN.
        /// </summary>
        public const string SYEDTN = "SYEDTN";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYTYTN.
        /// </summary>
        public const string SYTYTN = "SYTYTN";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYDRIN.
        /// </summary>
        public const string SYDRIN = "SYDRIN";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYTNAC.
        /// </summary>
        public const string SYTNAC = "SYTNAC";

        /// <summary>
        /// SYG70XDPR.
        /// </summary>
        public const string SYG70XDPR = "SYG70XDPR";

        /// <summary>
        /// SYG70XTG.
        /// </summary>
        public const string SYG70XTG = "SYG70XTG";

        /// <summary>
        /// SYG70INRE.
        /// </summary>
        public const string SYG70INRE = "SYG70INRE";

        /// <summary>
        /// SYG70XCD.
        /// </summary>
        public const string SYG70XCD = "SYG70XCD";

        /// <summary>
        /// SYG70XDOS.
        /// </summary>
        public const string SYG70XDOS = "SYG70XDOS";

        /// <summary>
        /// SYG70TXFT.
        /// </summary>
        public const string SYG70TXFT = "SYG70TXFT";

        /// <summary>
        /// SYG70XMLV.
        /// </summary>
        public const string SYG70XMLV = "SYG70XMLV";

        /// <summary>
        /// SYG70PATH.
        /// </summary>
        public const string SYG70PATH = "SYG70PATH";

        /// <summary>
        /// SYG70XSG1.
        /// </summary>
        public const string SYG70XSG1 = "SYG70XSG1";

        /// <summary>
        /// SYG70XSG2.
        /// </summary>
        public const string SYG70XSG2 = "SYG70XSG2";

        /// <summary>
        /// SYG70XSG3.
        /// </summary>
        public const string SYG70XSG3 = "SYG70XSG3";

        /// <summary>
        /// SYG70XNG1.
        /// </summary>
        public const string SYG70XNG1 = "SYG70XNG1";

        /// <summary>
        /// SYG70XNG2.
        /// </summary>
        public const string SYG70XNG2 = "SYG70XNG2";

        /// <summary>
        /// SYG70XNG3.
        /// </summary>
        public const string SYG70XNG3 = "SYG70XNG3";

        /// <summary>
        /// SYG70XDG1.
        /// </summary>
        public const string SYG70XDG1 = "SYG70XDG1";

        /// <summary>
        /// SYG70XDG2.
        /// </summary>
        public const string SYG70XDG2 = "SYG70XDG2";

        /// <summary>
        /// SYG70XDG3.
        /// </summary>
        public const string SYG70XDG3 = "SYG70XDG3";

        /// <summary>
        /// SYG70XIG1.
        /// </summary>
        public const string SYG70XIG1 = "SYG70XIG1";

        /// <summary>
        /// SYG70XCG1.
        /// </summary>
        public const string SYG70XCG1 = "SYG70XCG1";

        /// <summary>
        /// SYG70XCG2.
        /// </summary>
        public const string SYG70XCG2 = "SYG70XCG2";

        /// <summary>
        /// SYG70XCG3.
        /// </summary>
        public const string SYG70XCG3 = "SYG70XCG3";

        /// <summary>
        /// SYG70AN8.
        /// </summary>
        public const string SYG70AN8 = "SYG70AN8";

        /// <summary>
        /// SYG70MCU.
        /// </summary>
        public const string SYG70MCU = "SYG70MCU";

        /// <summary>
        /// SYG70CO.
        /// </summary>
        public const string SYG70CO = "SYG70CO";

        /// <summary>
        /// SYG70DCT.
        /// </summary>
        public const string SYG70DCT = "SYG70DCT";

        /// <summary>
        /// SYG70XECD.
        /// </summary>
        public const string SYG70XECD = "SYG70XECD";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYUPMT.
        /// </summary>
        public const string SYUPMT = "SYUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F70XMLZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDUS", "SYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SYEDTN", "SYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4),
        new JdeField("SYTYTN", "SYTYTN", JdeDataType.String, 16),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYDRIN", "SYDRIN", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTNAC", "SYTNAC", JdeDataType.String, 4),
        new JdeField("SYG70XDPR", "SYG70XDPR", JdeDataType.Numeric),
        new JdeField("SYG70XTG", "SYG70XTG", JdeDataType.String, 20),
        new JdeField("SYG70INRE", "SYG70INRE", JdeDataType.String, 120),
        new JdeField("SYG70XCD", "SYG70XCD", JdeDataType.String, 20),
        new JdeField("SYG70XDOS", "SYG70XDOS", JdeDataType.String, 2),
        new JdeField("SYG70TXFT", "SYG70TXFT", JdeDataType.String),
        new JdeField("SYG70XMLV", "SYG70XMLV", JdeDataType.String, 8),
        new JdeField("SYG70PATH", "SYG70PATH", JdeDataType.String, 510),
        new JdeField("SYG70XSG1", "SYG70XSG1", JdeDataType.String, 120),
        new JdeField("SYG70XSG2", "SYG70XSG2", JdeDataType.String, 120),
        new JdeField("SYG70XSG3", "SYG70XSG3", JdeDataType.String, 200),
        new JdeField("SYG70XNG1", "SYG70XNG1", JdeDataType.Numeric),
        new JdeField("SYG70XNG2", "SYG70XNG2", JdeDataType.Numeric),
        new JdeField("SYG70XNG3", "SYG70XNG3", JdeDataType.Numeric),
        new JdeField("SYG70XDG1", "SYG70XDG1", JdeDataType.Numeric),
        new JdeField("SYG70XDG2", "SYG70XDG2", JdeDataType.Numeric),
        new JdeField("SYG70XDG3", "SYG70XDG3", JdeDataType.Numeric),
        new JdeField("SYG70XIG1", "SYG70XIG1", JdeDataType.Numeric),
        new JdeField("SYG70XCG1", "SYG70XCG1", JdeDataType.String, 2),
        new JdeField("SYG70XCG2", "SYG70XCG2", JdeDataType.String, 2),
        new JdeField("SYG70XCG3", "SYG70XCG3", JdeDataType.String, 2),
        new JdeField("SYG70AN8", "SYG70AN8", JdeDataType.Numeric),
        new JdeField("SYG70MCU", "SYG70MCU", JdeDataType.String, 24),
        new JdeField("SYG70CO", "SYG70CO", JdeDataType.String, 10),
        new JdeField("SYG70DCT", "SYG70DCT", JdeDataType.String, 4),
        new JdeField("SYG70XECD", "SYG70XECD", JdeDataType.String, 6),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYUPMT", "SYUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70XMLZ1_0", "Primary Key on SYEDUS, SYEDBT, SYEDTN, SYEDLN", new[] { "SYEDUS", "SYEDBT", "SYEDTN", "SYEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F70XMLZ1_2", "Index on SYG70INRE, SYDRIN", new[] { "SYG70INRE", "SYDRIN" })
    };
}
