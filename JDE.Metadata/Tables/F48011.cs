using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48011 - .
/// </summary>
public class F48011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WGICU.
        /// </summary>
        public const string WGICU = "WGICU";

        /// <summary>
        /// WGBCTY.
        /// </summary>
        public const string WGBCTY = "WGBCTY";

        /// <summary>
        /// WGBS.
        /// </summary>
        public const string WGBS = "WGBS";

        /// <summary>
        /// WGCUAC.
        /// </summary>
        public const string WGCUAC = "WGCUAC";

        /// <summary>
        /// WGAME.
        /// </summary>
        public const string WGAME = "WGAME";

        /// <summary>
        /// WGDOCN.
        /// </summary>
        public const string WGDOCN = "WGDOCN";

        /// <summary>
        /// WGDICJ.
        /// </summary>
        public const string WGDICJ = "WGDICJ";

        /// <summary>
        /// WGGTYP.
        /// </summary>
        public const string WGGTYP = "WGGTYP";

        /// <summary>
        /// WGDGL.
        /// </summary>
        public const string WGDGL = "WGDGL";

        /// <summary>
        /// WGBTFR.
        /// </summary>
        public const string WGBTFR = "WGBTFR";

        /// <summary>
        /// WGICUJ.
        /// </summary>
        public const string WGICUJ = "WGICUJ";

        /// <summary>
        /// WGAMEJ.
        /// </summary>
        public const string WGAMEJ = "WGAMEJ";

        /// <summary>
        /// WGDOCJ.
        /// </summary>
        public const string WGDOCJ = "WGDOCJ";

        /// <summary>
        /// WGRGEN.
        /// </summary>
        public const string WGRGEN = "WGRGEN";

        /// <summary>
        /// WGICUA.
        /// </summary>
        public const string WGICUA = "WGICUA";

        /// <summary>
        /// WGBCT1.
        /// </summary>
        public const string WGBCT1 = "WGBCT1";

        /// <summary>
        /// WGBCT2.
        /// </summary>
        public const string WGBCT2 = "WGBCT2";

        /// <summary>
        /// WGBCT3.
        /// </summary>
        public const string WGBCT3 = "WGBCT3";

        /// <summary>
        /// WGBCT4.
        /// </summary>
        public const string WGBCT4 = "WGBCT4";

        /// <summary>
        /// WGBCT5.
        /// </summary>
        public const string WGBCT5 = "WGBCT5";

        /// <summary>
        /// WGBCTK.
        /// </summary>
        public const string WGBCTK = "WGBCTK";

        /// <summary>
        /// WGBCTC.
        /// </summary>
        public const string WGBCTC = "WGBCTC";

        /// <summary>
        /// WGIAPP.
        /// </summary>
        public const string WGIAPP = "WGIAPP";

        /// <summary>
        /// WGAUSR.
        /// </summary>
        public const string WGAUSR = "WGAUSR";

        /// <summary>
        /// WGUSER.
        /// </summary>
        public const string WGUSER = "WGUSER";

        /// <summary>
        /// WGJOBN.
        /// </summary>
        public const string WGJOBN = "WGJOBN";

        /// <summary>
        /// WGPID.
        /// </summary>
        public const string WGPID = "WGPID";

        /// <summary>
        /// WGUPMJ.
        /// </summary>
        public const string WGUPMJ = "WGUPMJ";

        /// <summary>
        /// WGUPMT.
        /// </summary>
        public const string WGUPMT = "WGUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WGICU", "WGICU", JdeDataType.Numeric, null, true, true),
        new JdeField("WGBCTY", "WGBCTY", JdeDataType.String, 2, true, true),
        new JdeField("WGBS", "WGBS", JdeDataType.String, 2),
        new JdeField("WGCUAC", "WGCUAC", JdeDataType.String, 2),
        new JdeField("WGAME", "WGAME", JdeDataType.Numeric),
        new JdeField("WGDOCN", "WGDOCN", JdeDataType.Numeric),
        new JdeField("WGDICJ", "WGDICJ", JdeDataType.Numeric),
        new JdeField("WGGTYP", "WGGTYP", JdeDataType.String, 2),
        new JdeField("WGDGL", "WGDGL", JdeDataType.Numeric),
        new JdeField("WGBTFR", "WGBTFR", JdeDataType.Numeric),
        new JdeField("WGICUJ", "WGICUJ", JdeDataType.Numeric),
        new JdeField("WGAMEJ", "WGAMEJ", JdeDataType.Numeric),
        new JdeField("WGDOCJ", "WGDOCJ", JdeDataType.Numeric),
        new JdeField("WGRGEN", "WGRGEN", JdeDataType.String, 2),
        new JdeField("WGICUA", "WGICUA", JdeDataType.Numeric),
        new JdeField("WGBCT1", "WGBCT1", JdeDataType.String, 2),
        new JdeField("WGBCT2", "WGBCT2", JdeDataType.String, 2),
        new JdeField("WGBCT3", "WGBCT3", JdeDataType.String, 2),
        new JdeField("WGBCT4", "WGBCT4", JdeDataType.String, 2),
        new JdeField("WGBCT5", "WGBCT5", JdeDataType.String, 2),
        new JdeField("WGBCTK", "WGBCTK", JdeDataType.String, 20),
        new JdeField("WGBCTC", "WGBCTC", JdeDataType.String, 4),
        new JdeField("WGIAPP", "WGIAPP", JdeDataType.String, 2),
        new JdeField("WGAUSR", "WGAUSR", JdeDataType.String, 20),
        new JdeField("WGUSER", "WGUSER", JdeDataType.String, 20),
        new JdeField("WGJOBN", "WGJOBN", JdeDataType.String, 20),
        new JdeField("WGPID", "WGPID", JdeDataType.String, 20),
        new JdeField("WGUPMJ", "WGUPMJ", JdeDataType.Numeric),
        new JdeField("WGUPMT", "WGUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48011_0", "Primary Key on WGBCTY, WGICU", new[] { "WGBCTY", "WGICU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48011_2", "Index on WGICU, WGBS", new[] { "WGICU", "WGBS" }),
        new JdeIndex("F48011_4", "Index on WGDICJ, WGBS", new[] { "WGDICJ", "WGBS" }),
        new JdeIndex("F48011_5", "Index on WGUSER, WGBS", new[] { "WGUSER", "WGBS" }),
        new JdeIndex("F48011_6", "Index on WGICUJ", new[] { "WGICUJ" }),
        new JdeIndex("F48011_7", "Index on WGICU", new[] { "WGICU" })
    };
}
