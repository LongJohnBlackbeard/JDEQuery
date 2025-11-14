using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1517 - .
/// </summary>
public class F1517 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ASDOCO.
        /// </summary>
        public const string ASDOCO = "ASDOCO";

        /// <summary>
        /// ASNUMB.
        /// </summary>
        public const string ASNUMB = "ASNUMB";

        /// <summary>
        /// ASLEAST.
        /// </summary>
        public const string ASLEAST = "ASLEAST";

        /// <summary>
        /// ASLELC.
        /// </summary>
        public const string ASLELC = "ASLELC";

        /// <summary>
        /// ASLEASPN.
        /// </summary>
        public const string ASLEASPN = "ASLEASPN";

        /// <summary>
        /// ASLEASBB.
        /// </summary>
        public const string ASLEASBB = "ASLEASBB";

        /// <summary>
        /// ASLEASI.
        /// </summary>
        public const string ASLEASI = "ASLEASI";

        /// <summary>
        /// ASLEASPT.
        /// </summary>
        public const string ASLEASPT = "ASLEASPT";

        /// <summary>
        /// ASLEASPL.
        /// </summary>
        public const string ASLEASPL = "ASLEASPL";

        /// <summary>
        /// ASLEASIE.
        /// </summary>
        public const string ASLEASIE = "ASLEASIE";

        /// <summary>
        /// ASLEASR.
        /// </summary>
        public const string ASLEASR = "ASLEASR";

        /// <summary>
        /// ASLEASEB.
        /// </summary>
        public const string ASLEASEB = "ASLEASEB";

        /// <summary>
        /// ASCRCD.
        /// </summary>
        public const string ASCRCD = "ASCRCD";

        /// <summary>
        /// ASUSER.
        /// </summary>
        public const string ASUSER = "ASUSER";

        /// <summary>
        /// ASPID.
        /// </summary>
        public const string ASPID = "ASPID";

        /// <summary>
        /// ASUPMJ.
        /// </summary>
        public const string ASUPMJ = "ASUPMJ";

        /// <summary>
        /// ASUPMT.
        /// </summary>
        public const string ASUPMT = "ASUPMT";

        /// <summary>
        /// ASMKEY.
        /// </summary>
        public const string ASMKEY = "ASMKEY";

        /// <summary>
        /// ASENTJ.
        /// </summary>
        public const string ASENTJ = "ASENTJ";

        /// <summary>
        /// ASTORG.
        /// </summary>
        public const string ASTORG = "ASTORG";

        /// <summary>
        /// ASURCD.
        /// </summary>
        public const string ASURCD = "ASURCD";

        /// <summary>
        /// ASURDT.
        /// </summary>
        public const string ASURDT = "ASURDT";

        /// <summary>
        /// ASURAT.
        /// </summary>
        public const string ASURAT = "ASURAT";

        /// <summary>
        /// ASURAB.
        /// </summary>
        public const string ASURAB = "ASURAB";

        /// <summary>
        /// ASURRF.
        /// </summary>
        public const string ASURRF = "ASURRF";

        /// <summary>
        /// ASLESPBD.
        /// </summary>
        public const string ASLESPBD = "ASLESPBD";

        /// <summary>
        /// ASLSVR.
        /// </summary>
        public const string ASLSVR = "ASLSVR";

        /// <summary>
        /// ASDOC.
        /// </summary>
        public const string ASDOC = "ASDOC";

        /// <summary>
        /// ASDGJ.
        /// </summary>
        public const string ASDGJ = "ASDGJ";

        /// <summary>
        /// ASLEAOB.
        /// </summary>
        public const string ASLEAOB = "ASLEAOB";

        /// <summary>
        /// ASLZET.
        /// </summary>
        public const string ASLZET = "ASLZET";

        /// <summary>
        /// ASLZRM.
        /// </summary>
        public const string ASLZRM = "ASLZRM";

        /// <summary>
        /// ASLZMIR.
        /// </summary>
        public const string ASLZMIR = "ASLZMIR";

        /// <summary>
        /// ASLZRDOC.
        /// </summary>
        public const string ASLZRDOC = "ASLZRDOC";

        /// <summary>
        /// ASLZRDGJ.
        /// </summary>
        public const string ASLZRDGJ = "ASLZRDGJ";

        /// <summary>
        /// ASLZADOC.
        /// </summary>
        public const string ASLZADOC = "ASLZADOC";

        /// <summary>
        /// ASLZADGJ.
        /// </summary>
        public const string ASLZADGJ = "ASLZADGJ";

        /// <summary>
        /// ASLZBDOC.
        /// </summary>
        public const string ASLZBDOC = "ASLZBDOC";

        /// <summary>
        /// ASLZBDGJ.
        /// </summary>
        public const string ASLZBDGJ = "ASLZBDGJ";

        /// <summary>
        /// ASBCRC.
        /// </summary>
        public const string ASBCRC = "ASBCRC";

        /// <summary>
        /// ASLZTCF.
        /// </summary>
        public const string ASLZTCF = "ASLZTCF";

        /// <summary>
        /// ASLZSER.
        /// </summary>
        public const string ASLZSER = "ASLZSER";

        /// <summary>
        /// ASLZLLGL.
        /// </summary>
        public const string ASLZLLGL = "ASLZLLGL";

        /// <summary>
        /// ASLZVDOC.
        /// </summary>
        public const string ASLZVDOC = "ASLZVDOC";

        /// <summary>
        /// ASLZVDGJ.
        /// </summary>
        public const string ASLZVDGJ = "ASLZVDGJ";

        /// <summary>
        /// ASLZWDOC.
        /// </summary>
        public const string ASLZWDOC = "ASLZWDOC";

        /// <summary>
        /// ASLZWDGJ.
        /// </summary>
        public const string ASLZWDGJ = "ASLZWDGJ";
    }

    /// <inheritdoc />
    public override string TableName => "F1517";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ASDOCO", "ASDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ASNUMB", "ASNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("ASLEAST", "ASLEAST", JdeDataType.String, 2, true, true),
        new JdeField("ASLELC", "ASLELC", JdeDataType.String, 2, true, true),
        new JdeField("ASLEASPN", "ASLEASPN", JdeDataType.Numeric, null, true, true),
        new JdeField("ASLEASBB", "ASLEASBB", JdeDataType.Numeric),
        new JdeField("ASLEASI", "ASLEASI", JdeDataType.Numeric),
        new JdeField("ASLEASPT", "ASLEASPT", JdeDataType.Numeric),
        new JdeField("ASLEASPL", "ASLEASPL", JdeDataType.Numeric),
        new JdeField("ASLEASIE", "ASLEASIE", JdeDataType.Numeric),
        new JdeField("ASLEASR", "ASLEASR", JdeDataType.Numeric),
        new JdeField("ASLEASEB", "ASLEASEB", JdeDataType.Numeric),
        new JdeField("ASCRCD", "ASCRCD", JdeDataType.String, 6, true, true),
        new JdeField("ASUSER", "ASUSER", JdeDataType.String, 20),
        new JdeField("ASPID", "ASPID", JdeDataType.String, 20),
        new JdeField("ASUPMJ", "ASUPMJ", JdeDataType.Numeric),
        new JdeField("ASUPMT", "ASUPMT", JdeDataType.Numeric),
        new JdeField("ASMKEY", "ASMKEY", JdeDataType.String, 30),
        new JdeField("ASENTJ", "ASENTJ", JdeDataType.Numeric),
        new JdeField("ASTORG", "ASTORG", JdeDataType.String, 20),
        new JdeField("ASURCD", "ASURCD", JdeDataType.String, 4),
        new JdeField("ASURDT", "ASURDT", JdeDataType.Numeric),
        new JdeField("ASURAT", "ASURAT", JdeDataType.Numeric),
        new JdeField("ASURAB", "ASURAB", JdeDataType.Numeric),
        new JdeField("ASURRF", "ASURRF", JdeDataType.String, 30),
        new JdeField("ASLESPBD", "ASLESPBD", JdeDataType.Numeric),
        new JdeField("ASLSVR", "ASLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("ASDOC", "ASDOC", JdeDataType.Numeric),
        new JdeField("ASDGJ", "ASDGJ", JdeDataType.Numeric),
        new JdeField("ASLEAOB", "ASLEAOB", JdeDataType.String, 2),
        new JdeField("ASLZET", "ASLZET", JdeDataType.String, 2),
        new JdeField("ASLZRM", "ASLZRM", JdeDataType.String, 2),
        new JdeField("ASLZMIR", "ASLZMIR", JdeDataType.Numeric),
        new JdeField("ASLZRDOC", "ASLZRDOC", JdeDataType.Numeric),
        new JdeField("ASLZRDGJ", "ASLZRDGJ", JdeDataType.Numeric),
        new JdeField("ASLZADOC", "ASLZADOC", JdeDataType.Numeric),
        new JdeField("ASLZADGJ", "ASLZADGJ", JdeDataType.Numeric),
        new JdeField("ASLZBDOC", "ASLZBDOC", JdeDataType.Numeric),
        new JdeField("ASLZBDGJ", "ASLZBDGJ", JdeDataType.Numeric),
        new JdeField("ASBCRC", "ASBCRC", JdeDataType.String, 6),
        new JdeField("ASLZTCF", "ASLZTCF", JdeDataType.String, 2),
        new JdeField("ASLZSER", "ASLZSER", JdeDataType.Numeric),
        new JdeField("ASLZLLGL", "ASLZLLGL", JdeDataType.Numeric),
        new JdeField("ASLZVDOC", "ASLZVDOC", JdeDataType.Numeric),
        new JdeField("ASLZVDGJ", "ASLZVDGJ", JdeDataType.Numeric),
        new JdeField("ASLZWDOC", "ASLZWDOC", JdeDataType.Numeric),
        new JdeField("ASLZWDGJ", "ASLZWDGJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1517_0", "Primary Key on ASDOCO, ASLSVR, ASNUMB, ASLEAST, ASLELC, ASCRCD, ASLEASPN", new[] { "ASDOCO", "ASLSVR", "ASNUMB", "ASLEAST", "ASLELC", "ASCRCD", "ASLEASPN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1517_2", "Index on ASDOCO, ASLSVR", new[] { "ASDOCO", "ASLSVR" }),
        new JdeIndex("F1517_3", "Index on ASDOCO, ASLSVR, ASNUMB, ASLEAST, ASLELC, ASCRCD, SYS_NC00048$", new[] { "ASDOCO", "ASLSVR", "ASNUMB", "ASLEAST", "ASLELC", "ASCRCD", "SYS_NC00048$" })
    };
}
