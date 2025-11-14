using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J11FP - .
/// </summary>
public class F09J11FP : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FPUKID.
        /// </summary>
        public const string FPUKID = "FPUKID";

        /// <summary>
        /// FPJVNAME.
        /// </summary>
        public const string FPJVNAME = "FPJVNAME";

        /// <summary>
        /// FPJVOVN.
        /// </summary>
        public const string FPJVOVN = "FPJVOVN";

        /// <summary>
        /// FPJVOM.
        /// </summary>
        public const string FPJVOM = "FPJVOM";

        /// <summary>
        /// FPJVLNID.
        /// </summary>
        public const string FPJVLNID = "FPJVLNID";

        /// <summary>
        /// FPMT.
        /// </summary>
        public const string FPMT = "FPMT";

        /// <summary>
        /// FPYR.
        /// </summary>
        public const string FPYR = "FPYR";

        /// <summary>
        /// FPCTRY.
        /// </summary>
        public const string FPCTRY = "FPCTRY";

        /// <summary>
        /// FPMCU.
        /// </summary>
        public const string FPMCU = "FPMCU";

        /// <summary>
        /// FPMCUS.
        /// </summary>
        public const string FPMCUS = "FPMCUS";

        /// <summary>
        /// FPJVSTDATE.
        /// </summary>
        public const string FPJVSTDATE = "FPJVSTDATE";

        /// <summary>
        /// FPJVTHDATE.
        /// </summary>
        public const string FPJVTHDATE = "FPJVTHDATE";

        /// <summary>
        /// FPJVAGN.
        /// </summary>
        public const string FPJVAGN = "FPJVAGN";

        /// <summary>
        /// FPDSVJ.
        /// </summary>
        public const string FPDSVJ = "FPDSVJ";

        /// <summary>
        /// FPDGJ.
        /// </summary>
        public const string FPDGJ = "FPDGJ";

        /// <summary>
        /// FPKCO.
        /// </summary>
        public const string FPKCO = "FPKCO";

        /// <summary>
        /// FPDCT.
        /// </summary>
        public const string FPDCT = "FPDCT";

        /// <summary>
        /// FPDOC.
        /// </summary>
        public const string FPDOC = "FPDOC";

        /// <summary>
        /// FPLT.
        /// </summary>
        public const string FPLT = "FPLT";

        /// <summary>
        /// FPEXTL.
        /// </summary>
        public const string FPEXTL = "FPEXTL";

        /// <summary>
        /// FPEXA.
        /// </summary>
        public const string FPEXA = "FPEXA";

        /// <summary>
        /// FPEXR.
        /// </summary>
        public const string FPEXR = "FPEXR";

        /// <summary>
        /// FPANI.
        /// </summary>
        public const string FPANI = "FPANI";

        /// <summary>
        /// FPJELN.
        /// </summary>
        public const string FPJELN = "FPJELN";

        /// <summary>
        /// FPSBL.
        /// </summary>
        public const string FPSBL = "FPSBL";

        /// <summary>
        /// FPSBLT.
        /// </summary>
        public const string FPSBLT = "FPSBLT";

        /// <summary>
        /// FPAA.
        /// </summary>
        public const string FPAA = "FPAA";

        /// <summary>
        /// FPCRCD.
        /// </summary>
        public const string FPCRCD = "FPCRCD";

        /// <summary>
        /// FPJVACR.
        /// </summary>
        public const string FPJVACR = "FPJVACR";

        /// <summary>
        /// FPCRRMULT.
        /// </summary>
        public const string FPCRRMULT = "FPCRRMULT";

        /// <summary>
        /// FPCRRMDIV.
        /// </summary>
        public const string FPCRRMDIV = "FPCRRMDIV";

        /// <summary>
        /// FPCRCFP.
        /// </summary>
        public const string FPCRCFP = "FPCRCFP";

        /// <summary>
        /// FPUPMJ.
        /// </summary>
        public const string FPUPMJ = "FPUPMJ";

        /// <summary>
        /// FPUPMT.
        /// </summary>
        public const string FPUPMT = "FPUPMT";

        /// <summary>
        /// FPMKEY.
        /// </summary>
        public const string FPMKEY = "FPMKEY";

        /// <summary>
        /// FPPID.
        /// </summary>
        public const string FPPID = "FPPID";

        /// <summary>
        /// FPUSER.
        /// </summary>
        public const string FPUSER = "FPUSER";

        /// <summary>
        /// FPTORG.
        /// </summary>
        public const string FPTORG = "FPTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F09J11FP";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FPUKID", "FPUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("FPJVNAME", "FPJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("FPJVOVN", "FPJVOVN", JdeDataType.String, 40, true, true),
        new JdeField("FPJVOM", "FPJVOM", JdeDataType.String, 4, true, true),
        new JdeField("FPJVLNID", "FPJVLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("FPMT", "FPMT", JdeDataType.Numeric),
        new JdeField("FPYR", "FPYR", JdeDataType.Numeric),
        new JdeField("FPCTRY", "FPCTRY", JdeDataType.Numeric),
        new JdeField("FPMCU", "FPMCU", JdeDataType.String, 24),
        new JdeField("FPMCUS", "FPMCUS", JdeDataType.String, 24),
        new JdeField("FPJVSTDATE", "FPJVSTDATE", JdeDataType.Numeric),
        new JdeField("FPJVTHDATE", "FPJVTHDATE", JdeDataType.Numeric),
        new JdeField("FPJVAGN", "FPJVAGN", JdeDataType.String, 40),
        new JdeField("FPDSVJ", "FPDSVJ", JdeDataType.Numeric),
        new JdeField("FPDGJ", "FPDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FPKCO", "FPKCO", JdeDataType.String, 10, true, true),
        new JdeField("FPDCT", "FPDCT", JdeDataType.String, 4, true, true),
        new JdeField("FPDOC", "FPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("FPLT", "FPLT", JdeDataType.String, 4, true, true),
        new JdeField("FPEXTL", "FPEXTL", JdeDataType.String, 4, true, true),
        new JdeField("FPEXA", "FPEXA", JdeDataType.String, 60),
        new JdeField("FPEXR", "FPEXR", JdeDataType.String, 60),
        new JdeField("FPANI", "FPANI", JdeDataType.String, 58),
        new JdeField("FPJELN", "FPJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("FPSBL", "FPSBL", JdeDataType.String, 16),
        new JdeField("FPSBLT", "FPSBLT", JdeDataType.String, 2),
        new JdeField("FPAA", "FPAA", JdeDataType.Numeric),
        new JdeField("FPCRCD", "FPCRCD", JdeDataType.String, 6),
        new JdeField("FPJVACR", "FPJVACR", JdeDataType.Numeric),
        new JdeField("FPCRRMULT", "FPCRRMULT", JdeDataType.Numeric),
        new JdeField("FPCRRMDIV", "FPCRRMDIV", JdeDataType.Numeric),
        new JdeField("FPCRCFP", "FPCRCFP", JdeDataType.String, 2),
        new JdeField("FPUPMJ", "FPUPMJ", JdeDataType.Numeric),
        new JdeField("FPUPMT", "FPUPMT", JdeDataType.Numeric),
        new JdeField("FPMKEY", "FPMKEY", JdeDataType.String, 30),
        new JdeField("FPPID", "FPPID", JdeDataType.String, 20),
        new JdeField("FPUSER", "FPUSER", JdeDataType.String, 20),
        new JdeField("FPTORG", "FPTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J11FP_0", "Primary Key on FPUKID, FPJVNAME, FPJVOVN, FPJVOM, FPJVLNID, FPKCO, FPDCT, FPDOC, FPDGJ, FPLT, FPJELN, FPEXTL", new[] { "FPUKID", "FPJVNAME", "FPJVOVN", "FPJVOM", "FPJVLNID", "FPKCO", "FPDCT", "FPDOC", "FPDGJ", "FPLT", "FPJELN", "FPEXTL" }, isUnique: true, isPrimaryKey: true)
    };
}
