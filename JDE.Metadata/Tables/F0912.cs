using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0912 - .
/// </summary>
public class F0912 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RJHST.
        /// </summary>
        public const string RJHST = "RJHST";

        /// <summary>
        /// RJDIST.
        /// </summary>
        public const string RJDIST = "RJDIST";

        /// <summary>
        /// RJRFAC.
        /// </summary>
        public const string RJRFAC = "RJRFAC";

        /// <summary>
        /// RJSEN.
        /// </summary>
        public const string RJSEN = "RJSEN";

        /// <summary>
        /// RJMCU.
        /// </summary>
        public const string RJMCU = "RJMCU";

        /// <summary>
        /// RJFROM.
        /// </summary>
        public const string RJFROM = "RJFROM";

        /// <summary>
        /// RJOBJF.
        /// </summary>
        public const string RJOBJF = "RJOBJF";

        /// <summary>
        /// RJFSUB.
        /// </summary>
        public const string RJFSUB = "RJFSUB";

        /// <summary>
        /// RJTHRU.
        /// </summary>
        public const string RJTHRU = "RJTHRU";

        /// <summary>
        /// RJOBJT.
        /// </summary>
        public const string RJOBJT = "RJOBJT";

        /// <summary>
        /// RJSUBT.
        /// </summary>
        public const string RJSUBT = "RJSUBT";

        /// <summary>
        /// RJMORY.
        /// </summary>
        public const string RJMORY = "RJMORY";

        /// <summary>
        /// RJUSER.
        /// </summary>
        public const string RJUSER = "RJUSER";

        /// <summary>
        /// RJAID.
        /// </summary>
        public const string RJAID = "RJAID";

        /// <summary>
        /// RJANI.
        /// </summary>
        public const string RJANI = "RJANI";

        /// <summary>
        /// RJCO.
        /// </summary>
        public const string RJCO = "RJCO";

        /// <summary>
        /// RJLT.
        /// </summary>
        public const string RJLT = "RJLT";

        /// <summary>
        /// RJSBL.
        /// </summary>
        public const string RJSBL = "RJSBL";

        /// <summary>
        /// RJAM.
        /// </summary>
        public const string RJAM = "RJAM";

        /// <summary>
        /// RJGLC.
        /// </summary>
        public const string RJGLC = "RJGLC";

        /// <summary>
        /// RJR1.
        /// </summary>
        public const string RJR1 = "RJR1";

        /// <summary>
        /// RJR2.
        /// </summary>
        public const string RJR2 = "RJR2";

        /// <summary>
        /// RJDCT.
        /// </summary>
        public const string RJDCT = "RJDCT";

        /// <summary>
        /// RJDOC.
        /// </summary>
        public const string RJDOC = "RJDOC";

        /// <summary>
        /// RJSFX.
        /// </summary>
        public const string RJSFX = "RJSFX";

        /// <summary>
        /// RJASID.
        /// </summary>
        public const string RJASID = "RJASID";

        /// <summary>
        /// RJDGJ.
        /// </summary>
        public const string RJDGJ = "RJDGJ";

        /// <summary>
        /// RJDSVJ.
        /// </summary>
        public const string RJDSVJ = "RJDSVJ";

        /// <summary>
        /// RJEXA.
        /// </summary>
        public const string RJEXA = "RJEXA";

        /// <summary>
        /// RJEXR.
        /// </summary>
        public const string RJEXR = "RJEXR";

        /// <summary>
        /// RJAA.
        /// </summary>
        public const string RJAA = "RJAA";

        /// <summary>
        /// RJU.
        /// </summary>
        public const string RJU = "RJU";

        /// <summary>
        /// RJJELN.
        /// </summary>
        public const string RJJELN = "RJJELN";

        /// <summary>
        /// RJUM.
        /// </summary>
        public const string RJUM = "RJUM";

        /// <summary>
        /// RJRE.
        /// </summary>
        public const string RJRE = "RJRE";

        /// <summary>
        /// RJDOI.
        /// </summary>
        public const string RJDOI = "RJDOI";

        /// <summary>
        /// RJBC.
        /// </summary>
        public const string RJBC = "RJBC";

        /// <summary>
        /// RJFY.
        /// </summary>
        public const string RJFY = "RJFY";

        /// <summary>
        /// RJPN.
        /// </summary>
        public const string RJPN = "RJPN";

        /// <summary>
        /// RJCTRY.
        /// </summary>
        public const string RJCTRY = "RJCTRY";

        /// <summary>
        /// RJRF.
        /// </summary>
        public const string RJRF = "RJRF";

        /// <summary>
        /// RJFLT.
        /// </summary>
        public const string RJFLT = "RJFLT";

        /// <summary>
        /// RJFPN.
        /// </summary>
        public const string RJFPN = "RJFPN";

        /// <summary>
        /// RJFFY.
        /// </summary>
        public const string RJFFY = "RJFFY";

        /// <summary>
        /// RJFCTY.
        /// </summary>
        public const string RJFCTY = "RJFCTY";

        /// <summary>
        /// RJFSBL.
        /// </summary>
        public const string RJFSBL = "RJFSBL";

        /// <summary>
        /// RJSLK.
        /// </summary>
        public const string RJSLK = "RJSLK";

        /// <summary>
        /// RJSBLT.
        /// </summary>
        public const string RJSBLT = "RJSBLT";

        /// <summary>
        /// RJSDTE.
        /// </summary>
        public const string RJSDTE = "RJSDTE";

        /// <summary>
        /// RJPID.
        /// </summary>
        public const string RJPID = "RJPID";

        /// <summary>
        /// RJUPMJ.
        /// </summary>
        public const string RJUPMJ = "RJUPMJ";

        /// <summary>
        /// RJJOBN.
        /// </summary>
        public const string RJJOBN = "RJJOBN";

        /// <summary>
        /// RJUPMT.
        /// </summary>
        public const string RJUPMT = "RJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F0912";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RJHST", "RJHST", JdeDataType.String, 2),
        new JdeField("RJDIST", "RJDIST", JdeDataType.String, 2),
        new JdeField("RJRFAC", "RJRFAC", JdeDataType.Numeric),
        new JdeField("RJSEN", "RJSEN", JdeDataType.Numeric),
        new JdeField("RJMCU", "RJMCU", JdeDataType.String, 24),
        new JdeField("RJFROM", "RJFROM", JdeDataType.String, 30),
        new JdeField("RJOBJF", "RJOBJF", JdeDataType.String, 12),
        new JdeField("RJFSUB", "RJFSUB", JdeDataType.String, 16),
        new JdeField("RJTHRU", "RJTHRU", JdeDataType.String, 30),
        new JdeField("RJOBJT", "RJOBJT", JdeDataType.String, 12),
        new JdeField("RJSUBT", "RJSUBT", JdeDataType.String, 16),
        new JdeField("RJMORY", "RJMORY", JdeDataType.String, 2),
        new JdeField("RJUSER", "RJUSER", JdeDataType.String, 20),
        new JdeField("RJAID", "RJAID", JdeDataType.String, 16),
        new JdeField("RJANI", "RJANI", JdeDataType.String, 58),
        new JdeField("RJCO", "RJCO", JdeDataType.String, 10, true, true),
        new JdeField("RJLT", "RJLT", JdeDataType.String, 4),
        new JdeField("RJSBL", "RJSBL", JdeDataType.String, 16),
        new JdeField("RJAM", "RJAM", JdeDataType.String, 2),
        new JdeField("RJGLC", "RJGLC", JdeDataType.String, 8),
        new JdeField("RJR1", "RJR1", JdeDataType.String, 16),
        new JdeField("RJR2", "RJR2", JdeDataType.String, 16),
        new JdeField("RJDCT", "RJDCT", JdeDataType.String, 4, true, true),
        new JdeField("RJDOC", "RJDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RJSFX", "RJSFX", JdeDataType.String, 6),
        new JdeField("RJASID", "RJASID", JdeDataType.String, 50),
        new JdeField("RJDGJ", "RJDGJ", JdeDataType.Numeric),
        new JdeField("RJDSVJ", "RJDSVJ", JdeDataType.Numeric),
        new JdeField("RJEXA", "RJEXA", JdeDataType.String, 60),
        new JdeField("RJEXR", "RJEXR", JdeDataType.String, 60),
        new JdeField("RJAA", "RJAA", JdeDataType.Numeric),
        new JdeField("RJU", "RJU", JdeDataType.Numeric),
        new JdeField("RJJELN", "RJJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("RJUM", "RJUM", JdeDataType.String, 4),
        new JdeField("RJRE", "RJRE", JdeDataType.String, 2),
        new JdeField("RJDOI", "RJDOI", JdeDataType.Numeric),
        new JdeField("RJBC", "RJBC", JdeDataType.String, 2),
        new JdeField("RJFY", "RJFY", JdeDataType.Numeric),
        new JdeField("RJPN", "RJPN", JdeDataType.Numeric),
        new JdeField("RJCTRY", "RJCTRY", JdeDataType.Numeric),
        new JdeField("RJRF", "RJRF", JdeDataType.String, 4),
        new JdeField("RJFLT", "RJFLT", JdeDataType.String, 4),
        new JdeField("RJFPN", "RJFPN", JdeDataType.Numeric),
        new JdeField("RJFFY", "RJFFY", JdeDataType.Numeric),
        new JdeField("RJFCTY", "RJFCTY", JdeDataType.Numeric),
        new JdeField("RJFSBL", "RJFSBL", JdeDataType.String, 16),
        new JdeField("RJSLK", "RJSLK", JdeDataType.String, 2),
        new JdeField("RJSBLT", "RJSBLT", JdeDataType.String, 2),
        new JdeField("RJSDTE", "RJSDTE", JdeDataType.Numeric),
        new JdeField("RJPID", "RJPID", JdeDataType.String, 20),
        new JdeField("RJUPMJ", "RJUPMJ", JdeDataType.Numeric),
        new JdeField("RJJOBN", "RJJOBN", JdeDataType.String, 20),
        new JdeField("RJUPMT", "RJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0912_0", "Primary Key on RJDCT, RJDOC, RJCO, RJJELN", new[] { "RJDCT", "RJDOC", "RJCO", "RJJELN" }, isUnique: true, isPrimaryKey: true)
    };
}
