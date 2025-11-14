using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09521 - .
/// </summary>
public class F09521 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FRCSHTYP.
        /// </summary>
        public const string FRCSHTYP = "FRCSHTYP";

        /// <summary>
        /// FRSRCSYS.
        /// </summary>
        public const string FRSRCSYS = "FRSRCSYS";

        /// <summary>
        /// FRRLSTAT.
        /// </summary>
        public const string FRRLSTAT = "FRRLSTAT";

        /// <summary>
        /// FRNDCRCD.
        /// </summary>
        public const string FRNDCRCD = "FRNDCRCD";

        /// <summary>
        /// FRWGHTNO.
        /// </summary>
        public const string FRWGHTNO = "FRWGHTNO";

        /// <summary>
        /// FRBEGOBJ.
        /// </summary>
        public const string FRBEGOBJ = "FRBEGOBJ";

        /// <summary>
        /// FRBEGSUB.
        /// </summary>
        public const string FRBEGSUB = "FRBEGSUB";

        /// <summary>
        /// FRENDOBJ.
        /// </summary>
        public const string FRENDOBJ = "FRENDOBJ";

        /// <summary>
        /// FRENDSUB.
        /// </summary>
        public const string FRENDSUB = "FRENDSUB";

        /// <summary>
        /// FRBNKANI.
        /// </summary>
        public const string FRBNKANI = "FRBNKANI";

        /// <summary>
        /// FRBNKAID.
        /// </summary>
        public const string FRBNKAID = "FRBNKAID";

        /// <summary>
        /// FRBCRC.
        /// </summary>
        public const string FRBCRC = "FRBCRC";

        /// <summary>
        /// FRDCT.
        /// </summary>
        public const string FRDCT = "FRDCT";

        /// <summary>
        /// FRPYIN.
        /// </summary>
        public const string FRPYIN = "FRPYIN";

        /// <summary>
        /// FROMOD.
        /// </summary>
        public const string FROMOD = "FROMOD";

        /// <summary>
        /// FRRP3.
        /// </summary>
        public const string FRRP3 = "FRRP3";

        /// <summary>
        /// FRPDCATG.
        /// </summary>
        public const string FRPDCATG = "FRPDCATG";

        /// <summary>
        /// FRPDDAYB.
        /// </summary>
        public const string FRPDDAYB = "FRPDDAYB";

        /// <summary>
        /// FRPDDAYE.
        /// </summary>
        public const string FRPDDAYE = "FRPDDAYE";

        /// <summary>
        /// FRPDPROC.
        /// </summary>
        public const string FRPDPROC = "FRPDPROC";

        /// <summary>
        /// FRCFAMT1.
        /// </summary>
        public const string FRCFAMT1 = "FRCFAMT1";

        /// <summary>
        /// FRCFAMT2.
        /// </summary>
        public const string FRCFAMT2 = "FRCFAMT2";

        /// <summary>
        /// FRCFDTE3.
        /// </summary>
        public const string FRCFDTE3 = "FRCFDTE3";

        /// <summary>
        /// FRCFDTE4.
        /// </summary>
        public const string FRCFDTE4 = "FRCFDTE4";

        /// <summary>
        /// FRCFDSC1.
        /// </summary>
        public const string FRCFDSC1 = "FRCFDSC1";

        /// <summary>
        /// FRCFFLG3.
        /// </summary>
        public const string FRCFFLG3 = "FRCFFLG3";

        /// <summary>
        /// FRCFFLG4.
        /// </summary>
        public const string FRCFFLG4 = "FRCFFLG4";

        /// <summary>
        /// FRCFFLG5.
        /// </summary>
        public const string FRCFFLG5 = "FRCFFLG5";

        /// <summary>
        /// FRCFFLG6.
        /// </summary>
        public const string FRCFFLG6 = "FRCFFLG6";

        /// <summary>
        /// FRCFFLG7.
        /// </summary>
        public const string FRCFFLG7 = "FRCFFLG7";

        /// <summary>
        /// FRCFFLG8.
        /// </summary>
        public const string FRCFFLG8 = "FRCFFLG8";

        /// <summary>
        /// FRCFFLG9.
        /// </summary>
        public const string FRCFFLG9 = "FRCFFLG9";

        /// <summary>
        /// FRCFFLG10.
        /// </summary>
        public const string FRCFFLG10 = "FRCFFLG10";

        /// <summary>
        /// FRCFFLG11.
        /// </summary>
        public const string FRCFFLG11 = "FRCFFLG11";

        /// <summary>
        /// FRCFFLG12.
        /// </summary>
        public const string FRCFFLG12 = "FRCFFLG12";

        /// <summary>
        /// FRCFFLG13.
        /// </summary>
        public const string FRCFFLG13 = "FRCFFLG13";

        /// <summary>
        /// FRCFFLG14.
        /// </summary>
        public const string FRCFFLG14 = "FRCFFLG14";

        /// <summary>
        /// FRCFFLG15.
        /// </summary>
        public const string FRCFFLG15 = "FRCFFLG15";

        /// <summary>
        /// FRCFFLG16.
        /// </summary>
        public const string FRCFFLG16 = "FRCFFLG16";

        /// <summary>
        /// FRCFFLG17.
        /// </summary>
        public const string FRCFFLG17 = "FRCFFLG17";

        /// <summary>
        /// FRCFFLG18.
        /// </summary>
        public const string FRCFFLG18 = "FRCFFLG18";

        /// <summary>
        /// FRCFNO1.
        /// </summary>
        public const string FRCFNO1 = "FRCFNO1";

        /// <summary>
        /// FRCFNO2.
        /// </summary>
        public const string FRCFNO2 = "FRCFNO2";

        /// <summary>
        /// FRCFPCT1.
        /// </summary>
        public const string FRCFPCT1 = "FRCFPCT1";

        /// <summary>
        /// FRCFPCT2.
        /// </summary>
        public const string FRCFPCT2 = "FRCFPCT2";

        /// <summary>
        /// FRCFSTR1.
        /// </summary>
        public const string FRCFSTR1 = "FRCFSTR1";

        /// <summary>
        /// FRCFSTR2.
        /// </summary>
        public const string FRCFSTR2 = "FRCFSTR2";

        /// <summary>
        /// FRPID.
        /// </summary>
        public const string FRPID = "FRPID";

        /// <summary>
        /// FRJOBN.
        /// </summary>
        public const string FRJOBN = "FRJOBN";

        /// <summary>
        /// FRUSER.
        /// </summary>
        public const string FRUSER = "FRUSER";

        /// <summary>
        /// FRUPMT.
        /// </summary>
        public const string FRUPMT = "FRUPMT";

        /// <summary>
        /// FRUPMJ.
        /// </summary>
        public const string FRUPMJ = "FRUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F09521";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRCSHTYP", "FRCSHTYP", JdeDataType.String, 20, true, true),
        new JdeField("FRSRCSYS", "FRSRCSYS", JdeDataType.String, 8),
        new JdeField("FRRLSTAT", "FRRLSTAT", JdeDataType.String, 2),
        new JdeField("FRNDCRCD", "FRNDCRCD", JdeDataType.String, 6),
        new JdeField("FRWGHTNO", "FRWGHTNO", JdeDataType.Numeric),
        new JdeField("FRBEGOBJ", "FRBEGOBJ", JdeDataType.String, 12),
        new JdeField("FRBEGSUB", "FRBEGSUB", JdeDataType.String, 16),
        new JdeField("FRENDOBJ", "FRENDOBJ", JdeDataType.String, 12),
        new JdeField("FRENDSUB", "FRENDSUB", JdeDataType.String, 16),
        new JdeField("FRBNKANI", "FRBNKANI", JdeDataType.String, 58),
        new JdeField("FRBNKAID", "FRBNKAID", JdeDataType.String, 16),
        new JdeField("FRBCRC", "FRBCRC", JdeDataType.String, 6),
        new JdeField("FRDCT", "FRDCT", JdeDataType.String, 4),
        new JdeField("FRPYIN", "FRPYIN", JdeDataType.String, 2),
        new JdeField("FROMOD", "FROMOD", JdeDataType.String, 2),
        new JdeField("FRRP3", "FRRP3", JdeDataType.String, 2),
        new JdeField("FRPDCATG", "FRPDCATG", JdeDataType.String, 2),
        new JdeField("FRPDDAYB", "FRPDDAYB", JdeDataType.Numeric),
        new JdeField("FRPDDAYE", "FRPDDAYE", JdeDataType.Numeric),
        new JdeField("FRPDPROC", "FRPDPROC", JdeDataType.String, 2),
        new JdeField("FRCFAMT1", "FRCFAMT1", JdeDataType.Numeric),
        new JdeField("FRCFAMT2", "FRCFAMT2", JdeDataType.Numeric),
        new JdeField("FRCFDTE3", "FRCFDTE3", JdeDataType.Numeric),
        new JdeField("FRCFDTE4", "FRCFDTE4", JdeDataType.Numeric),
        new JdeField("FRCFDSC1", "FRCFDSC1", JdeDataType.String, 58),
        new JdeField("FRCFFLG3", "FRCFFLG3", JdeDataType.String, 2),
        new JdeField("FRCFFLG4", "FRCFFLG4", JdeDataType.String, 2),
        new JdeField("FRCFFLG5", "FRCFFLG5", JdeDataType.String, 2),
        new JdeField("FRCFFLG6", "FRCFFLG6", JdeDataType.String, 2),
        new JdeField("FRCFFLG7", "FRCFFLG7", JdeDataType.String, 2),
        new JdeField("FRCFFLG8", "FRCFFLG8", JdeDataType.String, 2),
        new JdeField("FRCFFLG9", "FRCFFLG9", JdeDataType.String, 2),
        new JdeField("FRCFFLG10", "FRCFFLG10", JdeDataType.String, 2),
        new JdeField("FRCFFLG11", "FRCFFLG11", JdeDataType.String, 2),
        new JdeField("FRCFFLG12", "FRCFFLG12", JdeDataType.String, 2),
        new JdeField("FRCFFLG13", "FRCFFLG13", JdeDataType.String, 2),
        new JdeField("FRCFFLG14", "FRCFFLG14", JdeDataType.String, 2),
        new JdeField("FRCFFLG15", "FRCFFLG15", JdeDataType.String, 2),
        new JdeField("FRCFFLG16", "FRCFFLG16", JdeDataType.String, 2),
        new JdeField("FRCFFLG17", "FRCFFLG17", JdeDataType.String, 2),
        new JdeField("FRCFFLG18", "FRCFFLG18", JdeDataType.String, 2),
        new JdeField("FRCFNO1", "FRCFNO1", JdeDataType.Numeric),
        new JdeField("FRCFNO2", "FRCFNO2", JdeDataType.Numeric),
        new JdeField("FRCFPCT1", "FRCFPCT1", JdeDataType.Numeric),
        new JdeField("FRCFPCT2", "FRCFPCT2", JdeDataType.Numeric),
        new JdeField("FRCFSTR1", "FRCFSTR1", JdeDataType.String, 6),
        new JdeField("FRCFSTR2", "FRCFSTR2", JdeDataType.String, 16),
        new JdeField("FRPID", "FRPID", JdeDataType.String, 20),
        new JdeField("FRJOBN", "FRJOBN", JdeDataType.String, 20),
        new JdeField("FRUSER", "FRUSER", JdeDataType.String, 20),
        new JdeField("FRUPMT", "FRUPMT", JdeDataType.Numeric),
        new JdeField("FRUPMJ", "FRUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09521_0", "Primary Key on FRCSHTYP", new[] { "FRCSHTYP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09521_2", "Index on FRSRCSYS, FRRLSTAT", new[] { "FRSRCSYS", "FRRLSTAT" }),
        new JdeIndex("F09521_3", "Index on FRSRCSYS, FRENDOBJ, FRENDSUB, FRBEGOBJ, FRBEGSUB, SYS_NC00053$, SYS_NC00054$, FRDCT, FRPYIN, FRBCRC, FROMOD, FRRP3, FRBNKANI", new[] { "FRSRCSYS", "FRENDOBJ", "FRENDSUB", "FRBEGOBJ", "FRBEGSUB", "SYS_NC00053$", "SYS_NC00054$", "FRDCT", "FRPYIN", "FRBCRC", "FROMOD", "FRRP3", "FRBNKANI" })
    };
}
