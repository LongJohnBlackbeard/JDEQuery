using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0312 - .
/// </summary>
public class F0312 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RUPOST.
        /// </summary>
        public const string RUPOST = "RUPOST";

        /// <summary>
        /// RUICU.
        /// </summary>
        public const string RUICU = "RUICU";

        /// <summary>
        /// RUICUT.
        /// </summary>
        public const string RUICUT = "RUICUT";

        /// <summary>
        /// RUDICM.
        /// </summary>
        public const string RUDICM = "RUDICM";

        /// <summary>
        /// RUDICD.
        /// </summary>
        public const string RUDICD = "RUDICD";

        /// <summary>
        /// RUDICY.
        /// </summary>
        public const string RUDICY = "RUDICY";

        /// <summary>
        /// RUDIC#.
        /// </summary>
        public const string RUDIC_ = "RUDIC#";

        /// <summary>
        /// RUUSER.
        /// </summary>
        public const string RUUSER = "RUUSER";

        /// <summary>
        /// RUAN8.
        /// </summary>
        public const string RUAN8 = "RUAN8";

        /// <summary>
        /// RUDCT.
        /// </summary>
        public const string RUDCT = "RUDCT";

        /// <summary>
        /// RUDOC.
        /// </summary>
        public const string RUDOC = "RUDOC";

        /// <summary>
        /// RUSFX.
        /// </summary>
        public const string RUSFX = "RUSFX";

        /// <summary>
        /// RUDGM.
        /// </summary>
        public const string RUDGM = "RUDGM";

        /// <summary>
        /// RUDGD.
        /// </summary>
        public const string RUDGD = "RUDGD";

        /// <summary>
        /// RUDGY.
        /// </summary>
        public const string RUDGY = "RUDGY";

        /// <summary>
        /// RUDG#.
        /// </summary>
        public const string RUDG_ = "RUDG#";

        /// <summary>
        /// RUDCTM.
        /// </summary>
        public const string RUDCTM = "RUDCTM";

        /// <summary>
        /// RUDOCM.
        /// </summary>
        public const string RUDOCM = "RUDOCM";

        /// <summary>
        /// RUDMTM.
        /// </summary>
        public const string RUDMTM = "RUDMTM";

        /// <summary>
        /// RUDMTD.
        /// </summary>
        public const string RUDMTD = "RUDMTD";

        /// <summary>
        /// RUDMTY.
        /// </summary>
        public const string RUDMTY = "RUDMTY";

        /// <summary>
        /// RUDMT#.
        /// </summary>
        public const string RUDMT_ = "RUDMT#";

        /// <summary>
        /// RUAG.
        /// </summary>
        public const string RUAG = "RUAG";

        /// <summary>
        /// RURMK.
        /// </summary>
        public const string RURMK = "RURMK";

        /// <summary>
        /// RUGLBA.
        /// </summary>
        public const string RUGLBA = "RUGLBA";

        /// <summary>
        /// RUAM.
        /// </summary>
        public const string RUAM = "RUAM";

        /// <summary>
        /// RUCO.
        /// </summary>
        public const string RUCO = "RUCO";

        /// <summary>
        /// RUPO.
        /// </summary>
        public const string RUPO = "RUPO";

        /// <summary>
        /// RUCRCD.
        /// </summary>
        public const string RUCRCD = "RUCRCD";

        /// <summary>
        /// RUCRR.
        /// </summary>
        public const string RUCRR = "RUCRR";

        /// <summary>
        /// RUACR.
        /// </summary>
        public const string RUACR = "RUACR";

        /// <summary>
        /// RUADSA.
        /// </summary>
        public const string RUADSA = "RUADSA";

        /// <summary>
        /// RUTRTC.
        /// </summary>
        public const string RUTRTC = "RUTRTC";

        /// <summary>
        /// RUCDSA.
        /// </summary>
        public const string RUCDSA = "RUCDSA";

        /// <summary>
        /// RUCBNK.
        /// </summary>
        public const string RUCBNK = "RUCBNK";

        /// <summary>
        /// RUTNST.
        /// </summary>
        public const string RUTNST = "RUTNST";

        /// <summary>
        /// RUDKC.
        /// </summary>
        public const string RUDKC = "RUDKC";

        /// <summary>
        /// RUCTL.
        /// </summary>
        public const string RUCTL = "RUCTL";

        /// <summary>
        /// RURP1.
        /// </summary>
        public const string RURP1 = "RURP1";

        /// <summary>
        /// RURP2.
        /// </summary>
        public const string RURP2 = "RURP2";

        /// <summary>
        /// RURP3.
        /// </summary>
        public const string RURP3 = "RURP3";

        /// <summary>
        /// RUPYIN.
        /// </summary>
        public const string RUPYIN = "RUPYIN";

        /// <summary>
        /// RUDCTO.
        /// </summary>
        public const string RUDCTO = "RUDCTO";

        /// <summary>
        /// RUKCO.
        /// </summary>
        public const string RUKCO = "RUKCO";

        /// <summary>
        /// RUPDCT.
        /// </summary>
        public const string RUPDCT = "RUPDCT";

        /// <summary>
        /// RUPKCO.
        /// </summary>
        public const string RUPKCO = "RUPKCO";

        /// <summary>
        /// RUCRRM.
        /// </summary>
        public const string RUCRRM = "RUCRRM";

        /// <summary>
        /// RUDICJ.
        /// </summary>
        public const string RUDICJ = "RUDICJ";

        /// <summary>
        /// RUDGJ.
        /// </summary>
        public const string RUDGJ = "RUDGJ";

        /// <summary>
        /// RUDMTJ.
        /// </summary>
        public const string RUDMTJ = "RUDMTJ";

        /// <summary>
        /// RUAR.
        /// </summary>
        public const string RUAR = "RUAR";

        /// <summary>
        /// RUVR01.
        /// </summary>
        public const string RUVR01 = "RUVR01";
    }

    /// <inheritdoc />
    public override string TableName => "F0312";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RUPOST", "RUPOST", JdeDataType.String, 2),
        new JdeField("RUICU", "RUICU", JdeDataType.Numeric, null, true, true),
        new JdeField("RUICUT", "RUICUT", JdeDataType.String, 4),
        new JdeField("RUDICM", "RUDICM", JdeDataType.Numeric),
        new JdeField("RUDICD", "RUDICD", JdeDataType.Numeric),
        new JdeField("RUDICY", "RUDICY", JdeDataType.Numeric),
        new JdeField("RUDIC#", "RUDIC#", JdeDataType.Numeric),
        new JdeField("RUUSER", "RUUSER", JdeDataType.String, 20),
        new JdeField("RUAN8", "RUAN8", JdeDataType.Numeric),
        new JdeField("RUDCT", "RUDCT", JdeDataType.String, 4),
        new JdeField("RUDOC", "RUDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RUSFX", "RUSFX", JdeDataType.String, 6),
        new JdeField("RUDGM", "RUDGM", JdeDataType.Numeric),
        new JdeField("RUDGD", "RUDGD", JdeDataType.Numeric),
        new JdeField("RUDGY", "RUDGY", JdeDataType.Numeric),
        new JdeField("RUDG#", "RUDG#", JdeDataType.Numeric),
        new JdeField("RUDCTM", "RUDCTM", JdeDataType.String, 4),
        new JdeField("RUDOCM", "RUDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("RUDMTM", "RUDMTM", JdeDataType.Numeric),
        new JdeField("RUDMTD", "RUDMTD", JdeDataType.Numeric),
        new JdeField("RUDMTY", "RUDMTY", JdeDataType.Numeric),
        new JdeField("RUDMT#", "RUDMT#", JdeDataType.Numeric),
        new JdeField("RUAG", "RUAG", JdeDataType.Numeric),
        new JdeField("RURMK", "RURMK", JdeDataType.String, 60),
        new JdeField("RUGLBA", "RUGLBA", JdeDataType.String, 16, true, true),
        new JdeField("RUAM", "RUAM", JdeDataType.String, 2),
        new JdeField("RUCO", "RUCO", JdeDataType.String, 10),
        new JdeField("RUPO", "RUPO", JdeDataType.String, 16),
        new JdeField("RUCRCD", "RUCRCD", JdeDataType.String, 6),
        new JdeField("RUCRR", "RUCRR", JdeDataType.Numeric),
        new JdeField("RUACR", "RUACR", JdeDataType.Numeric),
        new JdeField("RUADSA", "RUADSA", JdeDataType.Numeric),
        new JdeField("RUTRTC", "RUTRTC", JdeDataType.String, 2),
        new JdeField("RUCDSA", "RUCDSA", JdeDataType.Numeric),
        new JdeField("RUCBNK", "RUCBNK", JdeDataType.String, 40),
        new JdeField("RUTNST", "RUTNST", JdeDataType.String, 40),
        new JdeField("RUDKC", "RUDKC", JdeDataType.Numeric),
        new JdeField("RUCTL", "RUCTL", JdeDataType.String, 26),
        new JdeField("RURP1", "RURP1", JdeDataType.String, 2),
        new JdeField("RURP2", "RURP2", JdeDataType.String, 2),
        new JdeField("RURP3", "RURP3", JdeDataType.String, 2),
        new JdeField("RUPYIN", "RUPYIN", JdeDataType.String, 2),
        new JdeField("RUDCTO", "RUDCTO", JdeDataType.String, 4),
        new JdeField("RUKCO", "RUKCO", JdeDataType.String, 10),
        new JdeField("RUPDCT", "RUPDCT", JdeDataType.String, 4),
        new JdeField("RUPKCO", "RUPKCO", JdeDataType.String, 10),
        new JdeField("RUCRRM", "RUCRRM", JdeDataType.String, 2),
        new JdeField("RUDICJ", "RUDICJ", JdeDataType.Numeric),
        new JdeField("RUDGJ", "RUDGJ", JdeDataType.Numeric),
        new JdeField("RUDMTJ", "RUDMTJ", JdeDataType.Numeric),
        new JdeField("RUAR", "RUAR", JdeDataType.String, 4),
        new JdeField("RUVR01", "RUVR01", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0312_0", "Primary Key on RUGLBA, RUDOCM, RUICU, RUDOC", new[] { "RUGLBA", "RUDOCM", "RUICU", "RUDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0312_2", "Index on RUICU, RUDOCM, RUDOC, RUDCT, RUKCO, RUSFX", new[] { "RUICU", "RUDOCM", "RUDOC", "RUDCT", "RUKCO", "RUSFX" }),
        new JdeIndex("F0312_4", "Index on RUAN8, RUICU", new[] { "RUAN8", "RUICU" }),
        new JdeIndex("F0312_5", "Index on RUDCT, RUPO, RUPYIN", new[] { "RUDCT", "RUPO", "RUPYIN" })
    };
}
