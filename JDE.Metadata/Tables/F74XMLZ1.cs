using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74XMLZ1 - .
/// </summary>
public class F74XMLZ1 : JdeTable
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
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

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
        /// SYTNAC.
        /// </summary>
        public const string SYTNAC = "SYTNAC";

        /// <summary>
        /// SYK74XDPR.
        /// </summary>
        public const string SYK74XDPR = "SYK74XDPR";

        /// <summary>
        /// SYK74XTG.
        /// </summary>
        public const string SYK74XTG = "SYK74XTG";

        /// <summary>
        /// SYK74INRE.
        /// </summary>
        public const string SYK74INRE = "SYK74INRE";

        /// <summary>
        /// SYK74XCD.
        /// </summary>
        public const string SYK74XCD = "SYK74XCD";

        /// <summary>
        /// SYK74XDOS.
        /// </summary>
        public const string SYK74XDOS = "SYK74XDOS";

        /// <summary>
        /// SYK74TXFT.
        /// </summary>
        public const string SYK74TXFT = "SYK74TXFT";

        /// <summary>
        /// SYK74XMLV.
        /// </summary>
        public const string SYK74XMLV = "SYK74XMLV";

        /// <summary>
        /// SYK74PATH.
        /// </summary>
        public const string SYK74PATH = "SYK74PATH";

        /// <summary>
        /// SYK74XSG1.
        /// </summary>
        public const string SYK74XSG1 = "SYK74XSG1";

        /// <summary>
        /// SYK74XSG2.
        /// </summary>
        public const string SYK74XSG2 = "SYK74XSG2";

        /// <summary>
        /// SYK74XSG3.
        /// </summary>
        public const string SYK74XSG3 = "SYK74XSG3";

        /// <summary>
        /// SYK74XNG1.
        /// </summary>
        public const string SYK74XNG1 = "SYK74XNG1";

        /// <summary>
        /// SYK74XNG2.
        /// </summary>
        public const string SYK74XNG2 = "SYK74XNG2";

        /// <summary>
        /// SYK74XNG3.
        /// </summary>
        public const string SYK74XNG3 = "SYK74XNG3";

        /// <summary>
        /// SYK74XDG1.
        /// </summary>
        public const string SYK74XDG1 = "SYK74XDG1";

        /// <summary>
        /// SYK74XDG2.
        /// </summary>
        public const string SYK74XDG2 = "SYK74XDG2";

        /// <summary>
        /// SYK74XDG3.
        /// </summary>
        public const string SYK74XDG3 = "SYK74XDG3";

        /// <summary>
        /// SYK74XIG1.
        /// </summary>
        public const string SYK74XIG1 = "SYK74XIG1";

        /// <summary>
        /// SYK74XCG1.
        /// </summary>
        public const string SYK74XCG1 = "SYK74XCG1";

        /// <summary>
        /// SYK74XCG2.
        /// </summary>
        public const string SYK74XCG2 = "SYK74XCG2";

        /// <summary>
        /// SYK74XCG3.
        /// </summary>
        public const string SYK74XCG3 = "SYK74XCG3";

        /// <summary>
        /// SYK74AN8.
        /// </summary>
        public const string SYK74AN8 = "SYK74AN8";

        /// <summary>
        /// SYK74MCU.
        /// </summary>
        public const string SYK74MCU = "SYK74MCU";

        /// <summary>
        /// SYK74CO.
        /// </summary>
        public const string SYK74CO = "SYK74CO";

        /// <summary>
        /// SYK74DCT.
        /// </summary>
        public const string SYK74DCT = "SYK74DCT";

        /// <summary>
        /// SYK74XECD.
        /// </summary>
        public const string SYK74XECD = "SYK74XECD";

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
    public override string TableName => "F74XMLZ1";

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
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTYTN", "SYTYTN", JdeDataType.String, 16),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYDRIN", "SYDRIN", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYTNAC", "SYTNAC", JdeDataType.String, 4),
        new JdeField("SYK74XDPR", "SYK74XDPR", JdeDataType.Numeric),
        new JdeField("SYK74XTG", "SYK74XTG", JdeDataType.String, 20),
        new JdeField("SYK74INRE", "SYK74INRE", JdeDataType.String, 120),
        new JdeField("SYK74XCD", "SYK74XCD", JdeDataType.String, 20),
        new JdeField("SYK74XDOS", "SYK74XDOS", JdeDataType.String, 2),
        new JdeField("SYK74TXFT", "SYK74TXFT", JdeDataType.String),
        new JdeField("SYK74XMLV", "SYK74XMLV", JdeDataType.String, 8),
        new JdeField("SYK74PATH", "SYK74PATH", JdeDataType.String, 510),
        new JdeField("SYK74XSG1", "SYK74XSG1", JdeDataType.String, 120),
        new JdeField("SYK74XSG2", "SYK74XSG2", JdeDataType.String, 120),
        new JdeField("SYK74XSG3", "SYK74XSG3", JdeDataType.String, 200),
        new JdeField("SYK74XNG1", "SYK74XNG1", JdeDataType.Numeric),
        new JdeField("SYK74XNG2", "SYK74XNG2", JdeDataType.Numeric),
        new JdeField("SYK74XNG3", "SYK74XNG3", JdeDataType.Numeric),
        new JdeField("SYK74XDG1", "SYK74XDG1", JdeDataType.Numeric),
        new JdeField("SYK74XDG2", "SYK74XDG2", JdeDataType.Numeric),
        new JdeField("SYK74XDG3", "SYK74XDG3", JdeDataType.Numeric),
        new JdeField("SYK74XIG1", "SYK74XIG1", JdeDataType.Numeric),
        new JdeField("SYK74XCG1", "SYK74XCG1", JdeDataType.String, 2),
        new JdeField("SYK74XCG2", "SYK74XCG2", JdeDataType.String, 2),
        new JdeField("SYK74XCG3", "SYK74XCG3", JdeDataType.String, 2),
        new JdeField("SYK74AN8", "SYK74AN8", JdeDataType.Numeric),
        new JdeField("SYK74MCU", "SYK74MCU", JdeDataType.String, 24),
        new JdeField("SYK74CO", "SYK74CO", JdeDataType.String, 10),
        new JdeField("SYK74DCT", "SYK74DCT", JdeDataType.String, 4),
        new JdeField("SYK74XECD", "SYK74XECD", JdeDataType.String, 6),
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
        new JdeIndex("F74XMLZ1_0", "Primary Key on SYEDUS, SYEDBT, SYEDTN, SYEDLN", new[] { "SYEDUS", "SYEDBT", "SYEDTN", "SYEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74XMLZ1_2", "Index on SYK74INRE, SYDRIN", new[] { "SYK74INRE", "SYDRIN" })
    };
}
