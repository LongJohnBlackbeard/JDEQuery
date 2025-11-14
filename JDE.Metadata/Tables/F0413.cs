using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0413 - .
/// </summary>
public class F0413 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RMPYID.
        /// </summary>
        public const string RMPYID = "RMPYID";

        /// <summary>
        /// RMDCTM.
        /// </summary>
        public const string RMDCTM = "RMDCTM";

        /// <summary>
        /// RMDOCM.
        /// </summary>
        public const string RMDOCM = "RMDOCM";

        /// <summary>
        /// RMPYE.
        /// </summary>
        public const string RMPYE = "RMPYE";

        /// <summary>
        /// RMGLBA.
        /// </summary>
        public const string RMGLBA = "RMGLBA";

        /// <summary>
        /// RMDMTJ.
        /// </summary>
        public const string RMDMTJ = "RMDMTJ";

        /// <summary>
        /// RMVDGJ.
        /// </summary>
        public const string RMVDGJ = "RMVDGJ";

        /// <summary>
        /// RMICU.
        /// </summary>
        public const string RMICU = "RMICU";

        /// <summary>
        /// RMICUT.
        /// </summary>
        public const string RMICUT = "RMICUT";

        /// <summary>
        /// RMDICJ.
        /// </summary>
        public const string RMDICJ = "RMDICJ";

        /// <summary>
        /// RMPAAP.
        /// </summary>
        public const string RMPAAP = "RMPAAP";

        /// <summary>
        /// RMCRCD.
        /// </summary>
        public const string RMCRCD = "RMCRCD";

        /// <summary>
        /// RMCRRM.
        /// </summary>
        public const string RMCRRM = "RMCRRM";

        /// <summary>
        /// RMAM.
        /// </summary>
        public const string RMAM = "RMAM";

        /// <summary>
        /// RMVLDT.
        /// </summary>
        public const string RMVLDT = "RMVLDT";

        /// <summary>
        /// RMPYIN.
        /// </summary>
        public const string RMPYIN = "RMPYIN";

        /// <summary>
        /// RMISTP.
        /// </summary>
        public const string RMISTP = "RMISTP";

        /// <summary>
        /// RMCBNK.
        /// </summary>
        public const string RMCBNK = "RMCBNK";

        /// <summary>
        /// RMBKTR.
        /// </summary>
        public const string RMBKTR = "RMBKTR";

        /// <summary>
        /// RMTORG.
        /// </summary>
        public const string RMTORG = "RMTORG";

        /// <summary>
        /// RMUSER.
        /// </summary>
        public const string RMUSER = "RMUSER";

        /// <summary>
        /// RMPID.
        /// </summary>
        public const string RMPID = "RMPID";

        /// <summary>
        /// RMUPMJ.
        /// </summary>
        public const string RMUPMJ = "RMUPMJ";

        /// <summary>
        /// RMUPMT.
        /// </summary>
        public const string RMUPMT = "RMUPMT";

        /// <summary>
        /// RMJOBN.
        /// </summary>
        public const string RMJOBN = "RMJOBN";

        /// <summary>
        /// RMMIP.
        /// </summary>
        public const string RMMIP = "RMMIP";

        /// <summary>
        /// RMLRFL.
        /// </summary>
        public const string RMLRFL = "RMLRFL";

        /// <summary>
        /// RMPRGF.
        /// </summary>
        public const string RMPRGF = "RMPRGF";

        /// <summary>
        /// RMGFL7.
        /// </summary>
        public const string RMGFL7 = "RMGFL7";

        /// <summary>
        /// RMGFL8.
        /// </summary>
        public const string RMGFL8 = "RMGFL8";

        /// <summary>
        /// RMGAM3.
        /// </summary>
        public const string RMGAM3 = "RMGAM3";

        /// <summary>
        /// RMGAM4.
        /// </summary>
        public const string RMGAM4 = "RMGAM4";

        /// <summary>
        /// RMGEN6.
        /// </summary>
        public const string RMGEN6 = "RMGEN6";

        /// <summary>
        /// RMGEN7.
        /// </summary>
        public const string RMGEN7 = "RMGEN7";

        /// <summary>
        /// RMNETTCID.
        /// </summary>
        public const string RMNETTCID = "RMNETTCID";

        /// <summary>
        /// RMNETDOC.
        /// </summary>
        public const string RMNETDOC = "RMNETDOC";

        /// <summary>
        /// RMRCND.
        /// </summary>
        public const string RMRCND = "RMRCND";

        /// <summary>
        /// RMR3.
        /// </summary>
        public const string RMR3 = "RMR3";

        /// <summary>
        /// RMCNTRTID.
        /// </summary>
        public const string RMCNTRTID = "RMCNTRTID";

        /// <summary>
        /// RMCNTRTCD.
        /// </summary>
        public const string RMCNTRTCD = "RMCNTRTCD";

        /// <summary>
        /// RMWVID.
        /// </summary>
        public const string RMWVID = "RMWVID";

        /// <summary>
        /// RMBLSCD2.
        /// </summary>
        public const string RMBLSCD2 = "RMBLSCD2";

        /// <summary>
        /// RMHARPER.
        /// </summary>
        public const string RMHARPER = "RMHARPER";

        /// <summary>
        /// RMHARSFX.
        /// </summary>
        public const string RMHARSFX = "RMHARSFX";
    }

    /// <inheritdoc />
    public override string TableName => "F0413";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RMPYID", "RMPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RMDCTM", "RMDCTM", JdeDataType.String, 4),
        new JdeField("RMDOCM", "RMDOCM", JdeDataType.Numeric),
        new JdeField("RMPYE", "RMPYE", JdeDataType.Numeric),
        new JdeField("RMGLBA", "RMGLBA", JdeDataType.String, 16),
        new JdeField("RMDMTJ", "RMDMTJ", JdeDataType.Numeric),
        new JdeField("RMVDGJ", "RMVDGJ", JdeDataType.Numeric),
        new JdeField("RMICU", "RMICU", JdeDataType.Numeric),
        new JdeField("RMICUT", "RMICUT", JdeDataType.String, 4),
        new JdeField("RMDICJ", "RMDICJ", JdeDataType.Numeric),
        new JdeField("RMPAAP", "RMPAAP", JdeDataType.Numeric),
        new JdeField("RMCRCD", "RMCRCD", JdeDataType.String, 6),
        new JdeField("RMCRRM", "RMCRRM", JdeDataType.String, 2),
        new JdeField("RMAM", "RMAM", JdeDataType.String, 2),
        new JdeField("RMVLDT", "RMVLDT", JdeDataType.Numeric),
        new JdeField("RMPYIN", "RMPYIN", JdeDataType.String, 2),
        new JdeField("RMISTP", "RMISTP", JdeDataType.String, 2),
        new JdeField("RMCBNK", "RMCBNK", JdeDataType.String, 40),
        new JdeField("RMBKTR", "RMBKTR", JdeDataType.String, 16),
        new JdeField("RMTORG", "RMTORG", JdeDataType.String, 20),
        new JdeField("RMUSER", "RMUSER", JdeDataType.String, 20),
        new JdeField("RMPID", "RMPID", JdeDataType.String, 20),
        new JdeField("RMUPMJ", "RMUPMJ", JdeDataType.Numeric),
        new JdeField("RMUPMT", "RMUPMT", JdeDataType.Numeric),
        new JdeField("RMJOBN", "RMJOBN", JdeDataType.String, 20),
        new JdeField("RMMIP", "RMMIP", JdeDataType.String, 2),
        new JdeField("RMLRFL", "RMLRFL", JdeDataType.String, 2),
        new JdeField("RMPRGF", "RMPRGF", JdeDataType.String, 2),
        new JdeField("RMGFL7", "RMGFL7", JdeDataType.String, 2),
        new JdeField("RMGFL8", "RMGFL8", JdeDataType.String, 2),
        new JdeField("RMGAM3", "RMGAM3", JdeDataType.Numeric),
        new JdeField("RMGAM4", "RMGAM4", JdeDataType.Numeric),
        new JdeField("RMGEN6", "RMGEN6", JdeDataType.String, 50),
        new JdeField("RMGEN7", "RMGEN7", JdeDataType.String, 50),
        new JdeField("RMNETTCID", "RMNETTCID", JdeDataType.Numeric),
        new JdeField("RMNETDOC", "RMNETDOC", JdeDataType.Numeric),
        new JdeField("RMRCND", "RMRCND", JdeDataType.String, 2),
        new JdeField("RMR3", "RMR3", JdeDataType.String, 16),
        new JdeField("RMCNTRTID", "RMCNTRTID", JdeDataType.Numeric),
        new JdeField("RMCNTRTCD", "RMCNTRTCD", JdeDataType.String, 24),
        new JdeField("RMWVID", "RMWVID", JdeDataType.Numeric),
        new JdeField("RMBLSCD2", "RMBLSCD2", JdeDataType.String, 20),
        new JdeField("RMHARPER", "RMHARPER", JdeDataType.String, 12),
        new JdeField("RMHARSFX", "RMHARSFX", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0413_0", "Primary Key on RMPYID", new[] { "RMPYID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0413_10", "Index on RMNETTCID, RMNETDOC, RMVDGJ", new[] { "RMNETTCID", "RMNETDOC", "RMVDGJ" }),
        new JdeIndex("F0413_11", "Index on RMDOCM, RMICU, RMICUT, RMVDGJ", new[] { "RMDOCM", "RMICU", "RMICUT", "RMVDGJ" }),
        new JdeIndex("F0413_12", "Index on RMDCTM, RMDOCM, RMPYE", new[] { "RMDCTM", "RMDOCM", "RMPYE" }),
        new JdeIndex("F0413_2", "Index on RMICU, RMICUT, RMISTP", new[] { "RMICU", "RMICUT", "RMISTP" }),
        new JdeIndex("F0413_3", "Index on RMDOCM, RMGLBA, RMPYE, RMDCTM", new[] { "RMDOCM", "RMGLBA", "RMPYE", "RMDCTM" }),
        new JdeIndex("F0413_4", "Index on RMPYE, RMDOCM, RMGLBA, RMDCTM", new[] { "RMPYE", "RMDOCM", "RMGLBA", "RMDCTM" }),
        new JdeIndex("F0413_5", "Index on RMGLBA, RMPYE", new[] { "RMGLBA", "RMPYE" }),
        new JdeIndex("F0413_6", "Index on RMPYE, RMDMTJ, RMGLBA", new[] { "RMPYE", "RMDMTJ", "RMGLBA" }),
        new JdeIndex("F0413_7", "Index on RMGLBA, RMDMTJ, RMPYE", new[] { "RMGLBA", "RMDMTJ", "RMPYE" }),
        new JdeIndex("F0413_8", "Index on RMICU, RMDOCM, RMDCTM", new[] { "RMICU", "RMDOCM", "RMDCTM" }),
        new JdeIndex("F0413_9", "Index on RMNETTCID, RMNETDOC", new[] { "RMNETTCID", "RMNETDOC" })
    };
}
