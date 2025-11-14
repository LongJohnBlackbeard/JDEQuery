using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B13Z1 - .
/// </summary>
public class F03B13Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RUEDUS.
        /// </summary>
        public const string RUEDUS = "RUEDUS";

        /// <summary>
        /// RUEDBT.
        /// </summary>
        public const string RUEDBT = "RUEDBT";

        /// <summary>
        /// RUEDTN.
        /// </summary>
        public const string RUEDTN = "RUEDTN";

        /// <summary>
        /// RUEDLN.
        /// </summary>
        public const string RUEDLN = "RUEDLN";

        /// <summary>
        /// RUICU.
        /// </summary>
        public const string RUICU = "RUICU";

        /// <summary>
        /// RUCKNU.
        /// </summary>
        public const string RUCKNU = "RUCKNU";

        /// <summary>
        /// RUKCO.
        /// </summary>
        public const string RUKCO = "RUKCO";

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
        /// RUCTL.
        /// </summary>
        public const string RUCTL = "RUCTL";

        /// <summary>
        /// RUGMFD.
        /// </summary>
        public const string RUGMFD = "RUGMFD";

        /// <summary>
        /// RUVR01.
        /// </summary>
        public const string RUVR01 = "RUVR01";

        /// <summary>
        /// RUPYID.
        /// </summary>
        public const string RUPYID = "RUPYID";

        /// <summary>
        /// RUEUPS.
        /// </summary>
        public const string RUEUPS = "RUEUPS";

        /// <summary>
        /// RUICUT.
        /// </summary>
        public const string RUICUT = "RUICUT";

        /// <summary>
        /// RUDIC#.
        /// </summary>
        public const string RUDIC_ = "RUDIC#";

        /// <summary>
        /// RUDICJ.
        /// </summary>
        public const string RUDICJ = "RUDICJ";

        /// <summary>
        /// RUUSER.
        /// </summary>
        public const string RUUSER = "RUUSER";

        /// <summary>
        /// RUAN8.
        /// </summary>
        public const string RUAN8 = "RUAN8";

        /// <summary>
        /// RUDG#.
        /// </summary>
        public const string RUDG_ = "RUDG#";

        /// <summary>
        /// RUDGJ.
        /// </summary>
        public const string RUDGJ = "RUDGJ";

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
        /// RUDMTJ.
        /// </summary>
        public const string RUDMTJ = "RUDMTJ";

        /// <summary>
        /// RUCKAM.
        /// </summary>
        public const string RUCKAM = "RUCKAM";

        /// <summary>
        /// RUAG.
        /// </summary>
        public const string RUAG = "RUAG";

        /// <summary>
        /// RUFAP.
        /// </summary>
        public const string RUFAP = "RUFAP";

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
        /// RUCRCD.
        /// </summary>
        public const string RUCRCD = "RUCRCD";

        /// <summary>
        /// RUCRR.
        /// </summary>
        public const string RUCRR = "RUCRR";

        /// <summary>
        /// RUCRRM.
        /// </summary>
        public const string RUCRRM = "RUCRRM";

        /// <summary>
        /// RUCBNK.
        /// </summary>
        public const string RUCBNK = "RUCBNK";

        /// <summary>
        /// RUTNST.
        /// </summary>
        public const string RUTNST = "RUTNST";

        /// <summary>
        /// RUEHBK.
        /// </summary>
        public const string RUEHBK = "RUEHBK";

        /// <summary>
        /// RUEHTN.
        /// </summary>
        public const string RUEHTN = "RUEHTN";

        /// <summary>
        /// RUPYIN.
        /// </summary>
        public const string RUPYIN = "RUPYIN";

        /// <summary>
        /// RUTYIN.
        /// </summary>
        public const string RUTYIN = "RUTYIN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B13Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RUEDUS", "RUEDUS", JdeDataType.String, 20, true, true),
        new JdeField("RUEDBT", "RUEDBT", JdeDataType.String, 30, true, true),
        new JdeField("RUEDTN", "RUEDTN", JdeDataType.String, 44, true, true),
        new JdeField("RUEDLN", "RUEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RUICU", "RUICU", JdeDataType.Numeric),
        new JdeField("RUCKNU", "RUCKNU", JdeDataType.String, 50),
        new JdeField("RUKCO", "RUKCO", JdeDataType.String, 10),
        new JdeField("RUDCT", "RUDCT", JdeDataType.String, 4),
        new JdeField("RUDOC", "RUDOC", JdeDataType.Numeric),
        new JdeField("RUSFX", "RUSFX", JdeDataType.String, 6),
        new JdeField("RUCTL", "RUCTL", JdeDataType.String, 26),
        new JdeField("RUGMFD", "RUGMFD", JdeDataType.String, 100),
        new JdeField("RUVR01", "RUVR01", JdeDataType.String, 50),
        new JdeField("RUPYID", "RUPYID", JdeDataType.Numeric),
        new JdeField("RUEUPS", "RUEUPS", JdeDataType.String, 2),
        new JdeField("RUICUT", "RUICUT", JdeDataType.String, 4),
        new JdeField("RUDIC#", "RUDIC#", JdeDataType.Numeric),
        new JdeField("RUDICJ", "RUDICJ", JdeDataType.Numeric),
        new JdeField("RUUSER", "RUUSER", JdeDataType.String, 20),
        new JdeField("RUAN8", "RUAN8", JdeDataType.Numeric),
        new JdeField("RUDG#", "RUDG#", JdeDataType.Numeric),
        new JdeField("RUDGJ", "RUDGJ", JdeDataType.Numeric),
        new JdeField("RUDMTM", "RUDMTM", JdeDataType.Numeric),
        new JdeField("RUDMTD", "RUDMTD", JdeDataType.Numeric),
        new JdeField("RUDMTY", "RUDMTY", JdeDataType.Numeric),
        new JdeField("RUDMT#", "RUDMT#", JdeDataType.Numeric),
        new JdeField("RUDMTJ", "RUDMTJ", JdeDataType.Numeric),
        new JdeField("RUCKAM", "RUCKAM", JdeDataType.Numeric),
        new JdeField("RUAG", "RUAG", JdeDataType.Numeric),
        new JdeField("RUFAP", "RUFAP", JdeDataType.Numeric),
        new JdeField("RURMK", "RURMK", JdeDataType.String, 60),
        new JdeField("RUGLBA", "RUGLBA", JdeDataType.String, 16),
        new JdeField("RUAM", "RUAM", JdeDataType.String, 2),
        new JdeField("RUCO", "RUCO", JdeDataType.String, 10),
        new JdeField("RUCRCD", "RUCRCD", JdeDataType.String, 6),
        new JdeField("RUCRR", "RUCRR", JdeDataType.Numeric),
        new JdeField("RUCRRM", "RUCRRM", JdeDataType.String, 2),
        new JdeField("RUCBNK", "RUCBNK", JdeDataType.String, 40),
        new JdeField("RUTNST", "RUTNST", JdeDataType.String, 40),
        new JdeField("RUEHBK", "RUEHBK", JdeDataType.String, 40),
        new JdeField("RUEHTN", "RUEHTN", JdeDataType.String, 40),
        new JdeField("RUPYIN", "RUPYIN", JdeDataType.String, 2),
        new JdeField("RUTYIN", "RUTYIN", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B13Z1_0", "Primary Key on RUEDUS, RUEDBT, RUEDTN, RUEDLN", new[] { "RUEDUS", "RUEDBT", "RUEDTN", "RUEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B13Z1_2", "Index on RUPYID", new[] { "RUPYID" }),
        new JdeIndex("F03B13Z1_3", "Index on RUEUPS, RUDICJ", new[] { "RUEUPS", "RUDICJ" }),
        new JdeIndex("F03B13Z1_4", "Index on RUICUT, RUICU, RUCKNU, RUDMTJ", new[] { "RUICUT", "RUICU", "RUCKNU", "RUDMTJ" }),
        new JdeIndex("F03B13Z1_5", "Index on RUEDUS, RUEDBT, RUEUPS", new[] { "RUEDUS", "RUEDBT", "RUEUPS" })
    };
}
