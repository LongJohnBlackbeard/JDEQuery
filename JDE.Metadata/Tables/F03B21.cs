using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B21 - .
/// </summary>
public class F03B21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZSUKID.
        /// </summary>
        public const string ZSUKID = "ZSUKID";

        /// <summary>
        /// ZSRC5.
        /// </summary>
        public const string ZSRC5 = "ZSRC5";

        /// <summary>
        /// ZSAN8.
        /// </summary>
        public const string ZSAN8 = "ZSAN8";

        /// <summary>
        /// ZSCO.
        /// </summary>
        public const string ZSCO = "ZSCO";

        /// <summary>
        /// ZSDOC.
        /// </summary>
        public const string ZSDOC = "ZSDOC";

        /// <summary>
        /// ZSDCT.
        /// </summary>
        public const string ZSDCT = "ZSDCT";

        /// <summary>
        /// ZSKCO.
        /// </summary>
        public const string ZSKCO = "ZSKCO";

        /// <summary>
        /// ZSSFX.
        /// </summary>
        public const string ZSSFX = "ZSSFX";

        /// <summary>
        /// ZSDDJ.
        /// </summary>
        public const string ZSDDJ = "ZSDDJ";

        /// <summary>
        /// ZSDDNJ.
        /// </summary>
        public const string ZSDDNJ = "ZSDDNJ";

        /// <summary>
        /// ZSDGJ.
        /// </summary>
        public const string ZSDGJ = "ZSDGJ";

        /// <summary>
        /// ZSDIVJ.
        /// </summary>
        public const string ZSDIVJ = "ZSDIVJ";

        /// <summary>
        /// ZSNOTJ.
        /// </summary>
        public const string ZSNOTJ = "ZSNOTJ";

        /// <summary>
        /// ZSRMK.
        /// </summary>
        public const string ZSRMK = "ZSRMK";

        /// <summary>
        /// ZSCTL.
        /// </summary>
        public const string ZSCTL = "ZSCTL";

        /// <summary>
        /// ZSRMDS.
        /// </summary>
        public const string ZSRMDS = "ZSRMDS";

        /// <summary>
        /// ZSCRRM.
        /// </summary>
        public const string ZSCRRM = "ZSCRRM";

        /// <summary>
        /// ZSCRCD.
        /// </summary>
        public const string ZSCRCD = "ZSCRCD";

        /// <summary>
        /// ZSBCRC.
        /// </summary>
        public const string ZSBCRC = "ZSBCRC";

        /// <summary>
        /// ZSTCRC.
        /// </summary>
        public const string ZSTCRC = "ZSTCRC";

        /// <summary>
        /// ZSPST.
        /// </summary>
        public const string ZSPST = "ZSPST";

        /// <summary>
        /// ZSPTC.
        /// </summary>
        public const string ZSPTC = "ZSPTC";

        /// <summary>
        /// ZSISTR.
        /// </summary>
        public const string ZSISTR = "ZSISTR";

        /// <summary>
        /// ZSAAP.
        /// </summary>
        public const string ZSAAP = "ZSAAP";

        /// <summary>
        /// ZSADSA.
        /// </summary>
        public const string ZSADSA = "ZSADSA";

        /// <summary>
        /// ZSPYRD.
        /// </summary>
        public const string ZSPYRD = "ZSPYRD";

        /// <summary>
        /// ZSADJ.
        /// </summary>
        public const string ZSADJ = "ZSADJ";

        /// <summary>
        /// ZSADJD.
        /// </summary>
        public const string ZSADJD = "ZSADJD";

        /// <summary>
        /// ZSCAD.
        /// </summary>
        public const string ZSCAD = "ZSCAD";

        /// <summary>
        /// ZSPAD.
        /// </summary>
        public const string ZSPAD = "ZSPAD";

        /// <summary>
        /// ZSATXA.
        /// </summary>
        public const string ZSATXA = "ZSATXA";

        /// <summary>
        /// ZSATXN.
        /// </summary>
        public const string ZSATXN = "ZSATXN";

        /// <summary>
        /// ZSSTAM.
        /// </summary>
        public const string ZSSTAM = "ZSSTAM";

        /// <summary>
        /// ZSODAM.
        /// </summary>
        public const string ZSODAM = "ZSODAM";

        /// <summary>
        /// ZSFAP.
        /// </summary>
        public const string ZSFAP = "ZSFAP";

        /// <summary>
        /// ZSCDSA.
        /// </summary>
        public const string ZSCDSA = "ZSCDSA";

        /// <summary>
        /// ZSPYRF.
        /// </summary>
        public const string ZSPYRF = "ZSPYRF";

        /// <summary>
        /// ZSFADJ.
        /// </summary>
        public const string ZSFADJ = "ZSFADJ";

        /// <summary>
        /// ZSADJF.
        /// </summary>
        public const string ZSADJF = "ZSADJF";

        /// <summary>
        /// ZSFAD.
        /// </summary>
        public const string ZSFAD = "ZSFAD";

        /// <summary>
        /// ZSPFAD.
        /// </summary>
        public const string ZSPFAD = "ZSPFAD";

        /// <summary>
        /// ZSCTXA.
        /// </summary>
        public const string ZSCTXA = "ZSCTXA";

        /// <summary>
        /// ZSCTXN.
        /// </summary>
        public const string ZSCTXN = "ZSCTXN";

        /// <summary>
        /// ZSCTAM.
        /// </summary>
        public const string ZSCTAM = "ZSCTAM";

        /// <summary>
        /// ZSFDAM.
        /// </summary>
        public const string ZSFDAM = "ZSFDAM";

        /// <summary>
        /// ZSTADA.
        /// </summary>
        public const string ZSTADA = "ZSTADA";

        /// <summary>
        /// ZSTAAP.
        /// </summary>
        public const string ZSTAAP = "ZSTAAP";

        /// <summary>
        /// ZSTAAJ.
        /// </summary>
        public const string ZSTAAJ = "ZSTAAJ";

        /// <summary>
        /// ZSAAB.
        /// </summary>
        public const string ZSAAB = "ZSAAB";

        /// <summary>
        /// ZSRC.
        /// </summary>
        public const string ZSRC = "ZSRC";

        /// <summary>
        /// ZSLNID.
        /// </summary>
        public const string ZSLNID = "ZSLNID";

        /// <summary>
        /// ZSSDOC.
        /// </summary>
        public const string ZSSDOC = "ZSSDOC";

        /// <summary>
        /// ZSSDCT.
        /// </summary>
        public const string ZSSDCT = "ZSSDCT";

        /// <summary>
        /// ZSSKCO.
        /// </summary>
        public const string ZSSKCO = "ZSSKCO";

        /// <summary>
        /// ZSSFXO.
        /// </summary>
        public const string ZSSFXO = "ZSSFXO";

        /// <summary>
        /// ZSUSER.
        /// </summary>
        public const string ZSUSER = "ZSUSER";

        /// <summary>
        /// ZSPID.
        /// </summary>
        public const string ZSPID = "ZSPID";

        /// <summary>
        /// ZSUPMJ.
        /// </summary>
        public const string ZSUPMJ = "ZSUPMJ";

        /// <summary>
        /// ZSUPMT.
        /// </summary>
        public const string ZSUPMT = "ZSUPMT";

        /// <summary>
        /// ZSJOBN.
        /// </summary>
        public const string ZSJOBN = "ZSJOBN";

        /// <summary>
        /// ZSAG.
        /// </summary>
        public const string ZSAG = "ZSAG";

        /// <summary>
        /// ZSACR.
        /// </summary>
        public const string ZSACR = "ZSACR";

        /// <summary>
        /// ZSDTPB.
        /// </summary>
        public const string ZSDTPB = "ZSDTPB";
    }

    /// <inheritdoc />
    public override string TableName => "F03B21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZSUKID", "ZSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZSRC5", "ZSRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("ZSAN8", "ZSAN8", JdeDataType.Numeric),
        new JdeField("ZSCO", "ZSCO", JdeDataType.String, 10),
        new JdeField("ZSDOC", "ZSDOC", JdeDataType.Numeric),
        new JdeField("ZSDCT", "ZSDCT", JdeDataType.String, 4),
        new JdeField("ZSKCO", "ZSKCO", JdeDataType.String, 10),
        new JdeField("ZSSFX", "ZSSFX", JdeDataType.String, 6),
        new JdeField("ZSDDJ", "ZSDDJ", JdeDataType.Numeric),
        new JdeField("ZSDDNJ", "ZSDDNJ", JdeDataType.Numeric),
        new JdeField("ZSDGJ", "ZSDGJ", JdeDataType.Numeric),
        new JdeField("ZSDIVJ", "ZSDIVJ", JdeDataType.Numeric),
        new JdeField("ZSNOTJ", "ZSNOTJ", JdeDataType.Numeric),
        new JdeField("ZSRMK", "ZSRMK", JdeDataType.String, 60),
        new JdeField("ZSCTL", "ZSCTL", JdeDataType.String, 26),
        new JdeField("ZSRMDS", "ZSRMDS", JdeDataType.Numeric),
        new JdeField("ZSCRRM", "ZSCRRM", JdeDataType.String, 2),
        new JdeField("ZSCRCD", "ZSCRCD", JdeDataType.String, 6),
        new JdeField("ZSBCRC", "ZSBCRC", JdeDataType.String, 6),
        new JdeField("ZSTCRC", "ZSTCRC", JdeDataType.String, 6),
        new JdeField("ZSPST", "ZSPST", JdeDataType.String, 2),
        new JdeField("ZSPTC", "ZSPTC", JdeDataType.String, 6),
        new JdeField("ZSISTR", "ZSISTR", JdeDataType.String, 2),
        new JdeField("ZSAAP", "ZSAAP", JdeDataType.Numeric),
        new JdeField("ZSADSA", "ZSADSA", JdeDataType.Numeric),
        new JdeField("ZSPYRD", "ZSPYRD", JdeDataType.Numeric),
        new JdeField("ZSADJ", "ZSADJ", JdeDataType.Numeric),
        new JdeField("ZSADJD", "ZSADJD", JdeDataType.Numeric),
        new JdeField("ZSCAD", "ZSCAD", JdeDataType.Numeric),
        new JdeField("ZSPAD", "ZSPAD", JdeDataType.Numeric),
        new JdeField("ZSATXA", "ZSATXA", JdeDataType.Numeric),
        new JdeField("ZSATXN", "ZSATXN", JdeDataType.Numeric),
        new JdeField("ZSSTAM", "ZSSTAM", JdeDataType.Numeric),
        new JdeField("ZSODAM", "ZSODAM", JdeDataType.Numeric),
        new JdeField("ZSFAP", "ZSFAP", JdeDataType.Numeric),
        new JdeField("ZSCDSA", "ZSCDSA", JdeDataType.Numeric),
        new JdeField("ZSPYRF", "ZSPYRF", JdeDataType.Numeric),
        new JdeField("ZSFADJ", "ZSFADJ", JdeDataType.Numeric),
        new JdeField("ZSADJF", "ZSADJF", JdeDataType.Numeric),
        new JdeField("ZSFAD", "ZSFAD", JdeDataType.Numeric),
        new JdeField("ZSPFAD", "ZSPFAD", JdeDataType.Numeric),
        new JdeField("ZSCTXA", "ZSCTXA", JdeDataType.Numeric),
        new JdeField("ZSCTXN", "ZSCTXN", JdeDataType.Numeric),
        new JdeField("ZSCTAM", "ZSCTAM", JdeDataType.Numeric),
        new JdeField("ZSFDAM", "ZSFDAM", JdeDataType.Numeric),
        new JdeField("ZSTADA", "ZSTADA", JdeDataType.Numeric),
        new JdeField("ZSTAAP", "ZSTAAP", JdeDataType.Numeric),
        new JdeField("ZSTAAJ", "ZSTAAJ", JdeDataType.Numeric),
        new JdeField("ZSAAB", "ZSAAB", JdeDataType.String, 2),
        new JdeField("ZSRC", "ZSRC", JdeDataType.String, 2),
        new JdeField("ZSLNID", "ZSLNID", JdeDataType.Numeric),
        new JdeField("ZSSDOC", "ZSSDOC", JdeDataType.Numeric),
        new JdeField("ZSSDCT", "ZSSDCT", JdeDataType.String, 4),
        new JdeField("ZSSKCO", "ZSSKCO", JdeDataType.String, 10),
        new JdeField("ZSSFXO", "ZSSFXO", JdeDataType.String, 6),
        new JdeField("ZSUSER", "ZSUSER", JdeDataType.String, 20),
        new JdeField("ZSPID", "ZSPID", JdeDataType.String, 20),
        new JdeField("ZSUPMJ", "ZSUPMJ", JdeDataType.Numeric),
        new JdeField("ZSUPMT", "ZSUPMT", JdeDataType.Numeric),
        new JdeField("ZSJOBN", "ZSJOBN", JdeDataType.String, 20),
        new JdeField("ZSAG", "ZSAG", JdeDataType.Numeric),
        new JdeField("ZSACR", "ZSACR", JdeDataType.Numeric),
        new JdeField("ZSDTPB", "ZSDTPB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B21_0", "Primary Key on ZSUKID, ZSRC5", new[] { "ZSUKID", "ZSRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B21_2", "Index on ZSDOC, ZSDCT, ZSKCO, ZSSFX, SYS_NC00064$", new[] { "ZSDOC", "ZSDCT", "ZSKCO", "ZSSFX", "SYS_NC00064$" })
    };
}
