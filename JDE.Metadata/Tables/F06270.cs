using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06270 - .
/// </summary>
public class F06270 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JPVERS.
        /// </summary>
        public const string JPVERS = "JPVERS";

        /// <summary>
        /// JPPID.
        /// </summary>
        public const string JPPID = "JPPID";

        /// <summary>
        /// JPRPE1.
        /// </summary>
        public const string JPRPE1 = "JPRPE1";

        /// <summary>
        /// JPRPE2.
        /// </summary>
        public const string JPRPE2 = "JPRPE2";

        /// <summary>
        /// JPDWK1.
        /// </summary>
        public const string JPDWK1 = "JPDWK1";

        /// <summary>
        /// JPDWK2.
        /// </summary>
        public const string JPDWK2 = "JPDWK2";

        /// <summary>
        /// JPDWK3.
        /// </summary>
        public const string JPDWK3 = "JPDWK3";

        /// <summary>
        /// JPDWK4.
        /// </summary>
        public const string JPDWK4 = "JPDWK4";

        /// <summary>
        /// JPPDBA.
        /// </summary>
        public const string JPPDBA = "JPPDBA";

        /// <summary>
        /// JPRETP.
        /// </summary>
        public const string JPRETP = "JPRETP";

        /// <summary>
        /// JPPHRW.
        /// </summary>
        public const string JPPHRW = "JPPHRW";

        /// <summary>
        /// JPGPA.
        /// </summary>
        public const string JPGPA = "JPGPA";

        /// <summary>
        /// JPICC.
        /// </summary>
        public const string JPICC = "JPICC";

        /// <summary>
        /// JPICT.
        /// </summary>
        public const string JPICT = "JPICT";

        /// <summary>
        /// JPDOCM.
        /// </summary>
        public const string JPDOCM = "JPDOCM";

        /// <summary>
        /// JPCKDT.
        /// </summary>
        public const string JPCKDT = "JPCKDT";

        /// <summary>
        /// JPCYGR.
        /// </summary>
        public const string JPCYGR = "JPCYGR";

        /// <summary>
        /// JPRPM.
        /// </summary>
        public const string JPRPM = "JPRPM";

        /// <summary>
        /// JPANI.
        /// </summary>
        public const string JPANI = "JPANI";

        /// <summary>
        /// JPRLDM.
        /// </summary>
        public const string JPRLDM = "JPRLDM";

        /// <summary>
        /// JPRRRC.
        /// </summary>
        public const string JPRRRC = "JPRRRC";

        /// <summary>
        /// JPPF0.
        /// </summary>
        public const string JPPF0 = "JPPF0";

        /// <summary>
        /// JPPF1.
        /// </summary>
        public const string JPPF1 = "JPPF1";

        /// <summary>
        /// JPPF2.
        /// </summary>
        public const string JPPF2 = "JPPF2";

        /// <summary>
        /// JPPF3.
        /// </summary>
        public const string JPPF3 = "JPPF3";

        /// <summary>
        /// JPPF4.
        /// </summary>
        public const string JPPF4 = "JPPF4";

        /// <summary>
        /// JPPF5.
        /// </summary>
        public const string JPPF5 = "JPPF5";

        /// <summary>
        /// JPPF6.
        /// </summary>
        public const string JPPF6 = "JPPF6";

        /// <summary>
        /// JPPF7.
        /// </summary>
        public const string JPPF7 = "JPPF7";

        /// <summary>
        /// JPPF8.
        /// </summary>
        public const string JPPF8 = "JPPF8";

        /// <summary>
        /// JPPF9.
        /// </summary>
        public const string JPPF9 = "JPPF9";

        /// <summary>
        /// JPRCC1.
        /// </summary>
        public const string JPRCC1 = "JPRCC1";

        /// <summary>
        /// JPRCC2.
        /// </summary>
        public const string JPRCC2 = "JPRCC2";

        /// <summary>
        /// JPRCC3.
        /// </summary>
        public const string JPRCC3 = "JPRCC3";

        /// <summary>
        /// JPRCC4.
        /// </summary>
        public const string JPRCC4 = "JPRCC4";

        /// <summary>
        /// JPRCC5.
        /// </summary>
        public const string JPRCC5 = "JPRCC5";

        /// <summary>
        /// JPHMCU.
        /// </summary>
        public const string JPHMCU = "JPHMCU";

        /// <summary>
        /// JPHMCO.
        /// </summary>
        public const string JPHMCO = "JPHMCO";

        /// <summary>
        /// JPMCU.
        /// </summary>
        public const string JPMCU = "JPMCU";

        /// <summary>
        /// JPMCUO.
        /// </summary>
        public const string JPMCUO = "JPMCUO";

        /// <summary>
        /// JPSG.
        /// </summary>
        public const string JPSG = "JPSG";

        /// <summary>
        /// JPMAIL.
        /// </summary>
        public const string JPMAIL = "JPMAIL";

        /// <summary>
        /// JPUN.
        /// </summary>
        public const string JPUN = "JPUN";

        /// <summary>
        /// JPJBCD.
        /// </summary>
        public const string JPJBCD = "JPJBCD";

        /// <summary>
        /// JPJBST.
        /// </summary>
        public const string JPJBST = "JPJBST";

        /// <summary>
        /// JPSHFT.
        /// </summary>
        public const string JPSHFT = "JPSHFT";

        /// <summary>
        /// JPSALY.
        /// </summary>
        public const string JPSALY = "JPSALY";

        /// <summary>
        /// JPPFRQ.
        /// </summary>
        public const string JPPFRQ = "JPPFRQ";

        /// <summary>
        /// JPP001.
        /// </summary>
        public const string JPP001 = "JPP001";

        /// <summary>
        /// JPP002.
        /// </summary>
        public const string JPP002 = "JPP002";

        /// <summary>
        /// JPP003.
        /// </summary>
        public const string JPP003 = "JPP003";

        /// <summary>
        /// JPP004.
        /// </summary>
        public const string JPP004 = "JPP004";

        /// <summary>
        /// JPPYST.
        /// </summary>
        public const string JPPYST = "JPPYST";

        /// <summary>
        /// JPTARA.
        /// </summary>
        public const string JPTARA = "JPTARA";

        /// <summary>
        /// JPBRDS.
        /// </summary>
        public const string JPBRDS = "JPBRDS";

        /// <summary>
        /// JPICU.
        /// </summary>
        public const string JPICU = "JPICU";

        /// <summary>
        /// JPPCCD.
        /// </summary>
        public const string JPPCCD = "JPPCCD";

        /// <summary>
        /// JPAMRT.
        /// </summary>
        public const string JPAMRT = "JPAMRT";

        /// <summary>
        /// JPRTTP.
        /// </summary>
        public const string JPRTTP = "JPRTTP";

        /// <summary>
        /// JPRTOP.
        /// </summary>
        public const string JPRTOP = "JPRTOP";

        /// <summary>
        /// JPRTJE.
        /// </summary>
        public const string JPRTJE = "JPRTJE";

        /// <summary>
        /// JPRTRO.
        /// </summary>
        public const string JPRTRO = "JPRTRO";

        /// <summary>
        /// JPRTFU.
        /// </summary>
        public const string JPRTFU = "JPRTFU";

        /// <summary>
        /// JPSL01.
        /// </summary>
        public const string JPSL01 = "JPSL01";

        /// <summary>
        /// JPSL02.
        /// </summary>
        public const string JPSL02 = "JPSL02";

        /// <summary>
        /// JPSL03.
        /// </summary>
        public const string JPSL03 = "JPSL03";

        /// <summary>
        /// JPSL04.
        /// </summary>
        public const string JPSL04 = "JPSL04";

        /// <summary>
        /// JPSL05.
        /// </summary>
        public const string JPSL05 = "JPSL05";

        /// <summary>
        /// JPSL06.
        /// </summary>
        public const string JPSL06 = "JPSL06";

        /// <summary>
        /// JPSL07.
        /// </summary>
        public const string JPSL07 = "JPSL07";

        /// <summary>
        /// JPSL08.
        /// </summary>
        public const string JPSL08 = "JPSL08";

        /// <summary>
        /// JPSL09.
        /// </summary>
        public const string JPSL09 = "JPSL09";

        /// <summary>
        /// JPSL10.
        /// </summary>
        public const string JPSL10 = "JPSL10";

        /// <summary>
        /// JPSL11.
        /// </summary>
        public const string JPSL11 = "JPSL11";

        /// <summary>
        /// JPSL12.
        /// </summary>
        public const string JPSL12 = "JPSL12";

        /// <summary>
        /// JPSL13.
        /// </summary>
        public const string JPSL13 = "JPSL13";

        /// <summary>
        /// JPSL14.
        /// </summary>
        public const string JPSL14 = "JPSL14";

        /// <summary>
        /// JPSL15.
        /// </summary>
        public const string JPSL15 = "JPSL15";

        /// <summary>
        /// JPSL16.
        /// </summary>
        public const string JPSL16 = "JPSL16";

        /// <summary>
        /// JPSL17.
        /// </summary>
        public const string JPSL17 = "JPSL17";

        /// <summary>
        /// JPJCTY.
        /// </summary>
        public const string JPJCTY = "JPJCTY";

        /// <summary>
        /// JPRRP.
        /// </summary>
        public const string JPRRP = "JPRRP";

        /// <summary>
        /// JPAGDT.
        /// </summary>
        public const string JPAGDT = "JPAGDT";
    }

    /// <inheritdoc />
    public override string TableName => "F06270";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JPVERS", "JPVERS", JdeDataType.String, 20, true, true),
        new JdeField("JPPID", "JPPID", JdeDataType.String, 20, true, true),
        new JdeField("JPRPE1", "JPRPE1", JdeDataType.Numeric),
        new JdeField("JPRPE2", "JPRPE2", JdeDataType.Numeric),
        new JdeField("JPDWK1", "JPDWK1", JdeDataType.Numeric),
        new JdeField("JPDWK2", "JPDWK2", JdeDataType.Numeric),
        new JdeField("JPDWK3", "JPDWK3", JdeDataType.Numeric),
        new JdeField("JPDWK4", "JPDWK4", JdeDataType.Numeric),
        new JdeField("JPPDBA", "JPPDBA", JdeDataType.Numeric),
        new JdeField("JPRETP", "JPRETP", JdeDataType.Numeric),
        new JdeField("JPPHRW", "JPPHRW", JdeDataType.Numeric),
        new JdeField("JPGPA", "JPGPA", JdeDataType.Numeric),
        new JdeField("JPICC", "JPICC", JdeDataType.String, 2),
        new JdeField("JPICT", "JPICT", JdeDataType.String, 2),
        new JdeField("JPDOCM", "JPDOCM", JdeDataType.Numeric),
        new JdeField("JPCKDT", "JPCKDT", JdeDataType.Numeric),
        new JdeField("JPCYGR", "JPCYGR", JdeDataType.String, 4),
        new JdeField("JPRPM", "JPRPM", JdeDataType.String, 2),
        new JdeField("JPANI", "JPANI", JdeDataType.String, 58),
        new JdeField("JPRLDM", "JPRLDM", JdeDataType.String, 2),
        new JdeField("JPRRRC", "JPRRRC", JdeDataType.String, 2),
        new JdeField("JPPF0", "JPPF0", JdeDataType.String, 2),
        new JdeField("JPPF1", "JPPF1", JdeDataType.String, 2),
        new JdeField("JPPF2", "JPPF2", JdeDataType.String, 2),
        new JdeField("JPPF3", "JPPF3", JdeDataType.String, 2),
        new JdeField("JPPF4", "JPPF4", JdeDataType.String, 2),
        new JdeField("JPPF5", "JPPF5", JdeDataType.String, 2),
        new JdeField("JPPF6", "JPPF6", JdeDataType.String, 2),
        new JdeField("JPPF7", "JPPF7", JdeDataType.String, 2),
        new JdeField("JPPF8", "JPPF8", JdeDataType.String, 2),
        new JdeField("JPPF9", "JPPF9", JdeDataType.String, 2),
        new JdeField("JPRCC1", "JPRCC1", JdeDataType.String, 2),
        new JdeField("JPRCC2", "JPRCC2", JdeDataType.String, 2),
        new JdeField("JPRCC3", "JPRCC3", JdeDataType.String, 2),
        new JdeField("JPRCC4", "JPRCC4", JdeDataType.String, 2),
        new JdeField("JPRCC5", "JPRCC5", JdeDataType.String, 2),
        new JdeField("JPHMCU", "JPHMCU", JdeDataType.String, 24),
        new JdeField("JPHMCO", "JPHMCO", JdeDataType.String, 10),
        new JdeField("JPMCU", "JPMCU", JdeDataType.String, 24),
        new JdeField("JPMCUO", "JPMCUO", JdeDataType.String, 24),
        new JdeField("JPSG", "JPSG", JdeDataType.String, 24),
        new JdeField("JPMAIL", "JPMAIL", JdeDataType.String, 20),
        new JdeField("JPUN", "JPUN", JdeDataType.String, 12),
        new JdeField("JPJBCD", "JPJBCD", JdeDataType.String, 12),
        new JdeField("JPJBST", "JPJBST", JdeDataType.String, 8),
        new JdeField("JPSHFT", "JPSHFT", JdeDataType.String, 2),
        new JdeField("JPSALY", "JPSALY", JdeDataType.String, 2),
        new JdeField("JPPFRQ", "JPPFRQ", JdeDataType.String, 2),
        new JdeField("JPP001", "JPP001", JdeDataType.String, 6),
        new JdeField("JPP002", "JPP002", JdeDataType.String, 6),
        new JdeField("JPP003", "JPP003", JdeDataType.String, 6),
        new JdeField("JPP004", "JPP004", JdeDataType.String, 6),
        new JdeField("JPPYST", "JPPYST", JdeDataType.String, 2),
        new JdeField("JPTARA", "JPTARA", JdeDataType.String, 20),
        new JdeField("JPBRDS", "JPBRDS", JdeDataType.String, 2),
        new JdeField("JPICU", "JPICU", JdeDataType.Numeric),
        new JdeField("JPPCCD", "JPPCCD", JdeDataType.String, 10),
        new JdeField("JPAMRT", "JPAMRT", JdeDataType.Numeric),
        new JdeField("JPRTTP", "JPRTTP", JdeDataType.String, 2),
        new JdeField("JPRTOP", "JPRTOP", JdeDataType.String, 2),
        new JdeField("JPRTJE", "JPRTJE", JdeDataType.String, 2),
        new JdeField("JPRTRO", "JPRTRO", JdeDataType.String, 2),
        new JdeField("JPRTFU", "JPRTFU", JdeDataType.String, 2),
        new JdeField("JPSL01", "JPSL01", JdeDataType.String, 2),
        new JdeField("JPSL02", "JPSL02", JdeDataType.String, 2),
        new JdeField("JPSL03", "JPSL03", JdeDataType.String, 2),
        new JdeField("JPSL04", "JPSL04", JdeDataType.String, 2),
        new JdeField("JPSL05", "JPSL05", JdeDataType.String, 2),
        new JdeField("JPSL06", "JPSL06", JdeDataType.String, 2),
        new JdeField("JPSL07", "JPSL07", JdeDataType.String, 2),
        new JdeField("JPSL08", "JPSL08", JdeDataType.String, 2),
        new JdeField("JPSL09", "JPSL09", JdeDataType.String, 2),
        new JdeField("JPSL10", "JPSL10", JdeDataType.String, 2),
        new JdeField("JPSL11", "JPSL11", JdeDataType.String, 2),
        new JdeField("JPSL12", "JPSL12", JdeDataType.String, 2),
        new JdeField("JPSL13", "JPSL13", JdeDataType.String, 2),
        new JdeField("JPSL14", "JPSL14", JdeDataType.String, 2),
        new JdeField("JPSL15", "JPSL15", JdeDataType.String, 2),
        new JdeField("JPSL16", "JPSL16", JdeDataType.String, 2),
        new JdeField("JPSL17", "JPSL17", JdeDataType.String, 2),
        new JdeField("JPJCTY", "JPJCTY", JdeDataType.String, 2),
        new JdeField("JPRRP", "JPRRP", JdeDataType.String, 2),
        new JdeField("JPAGDT", "JPAGDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06270_0", "Primary Key on JPVERS, JPPID", new[] { "JPVERS", "JPPID" }, isUnique: true, isPrimaryKey: true)
    };
}
