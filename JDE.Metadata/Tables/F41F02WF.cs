using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41F02WF - .
/// </summary>
public class F41F02WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S1JOBS.
        /// </summary>
        public const string S1JOBS = "S1JOBS";

        /// <summary>
        /// S1C9ITMP.
        /// </summary>
        public const string S1C9ITMP = "S1C9ITMP";

        /// <summary>
        /// S1C9LVL0.
        /// </summary>
        public const string S1C9LVL0 = "S1C9LVL0";

        /// <summary>
        /// S1DSC2.
        /// </summary>
        public const string S1DSC2 = "S1DSC2";

        /// <summary>
        /// S1ITM.
        /// </summary>
        public const string S1ITM = "S1ITM";

        /// <summary>
        /// S1LITM.
        /// </summary>
        public const string S1LITM = "S1LITM";

        /// <summary>
        /// S1DSC1.
        /// </summary>
        public const string S1DSC1 = "S1DSC1";

        /// <summary>
        /// S1C9LVNO.
        /// </summary>
        public const string S1C9LVNO = "S1C9LVNO";

        /// <summary>
        /// S1C9STRC.
        /// </summary>
        public const string S1C9STRC = "S1C9STRC";

        /// <summary>
        /// S1APPELC01.
        /// </summary>
        public const string S1APPELC01 = "S1APPELC01";

        /// <summary>
        /// S1APPELS01.
        /// </summary>
        public const string S1APPELS01 = "S1APPELS01";

        /// <summary>
        /// S1APPELD01.
        /// </summary>
        public const string S1APPELD01 = "S1APPELD01";

        /// <summary>
        /// S1APPELN01.
        /// </summary>
        public const string S1APPELN01 = "S1APPELN01";

        /// <summary>
        /// S1URCD.
        /// </summary>
        public const string S1URCD = "S1URCD";

        /// <summary>
        /// S1URDT.
        /// </summary>
        public const string S1URDT = "S1URDT";

        /// <summary>
        /// S1URAT.
        /// </summary>
        public const string S1URAT = "S1URAT";

        /// <summary>
        /// S1URAB.
        /// </summary>
        public const string S1URAB = "S1URAB";

        /// <summary>
        /// S1URRF.
        /// </summary>
        public const string S1URRF = "S1URRF";

        /// <summary>
        /// S1USER.
        /// </summary>
        public const string S1USER = "S1USER";

        /// <summary>
        /// S1PID.
        /// </summary>
        public const string S1PID = "S1PID";

        /// <summary>
        /// S1MKEY.
        /// </summary>
        public const string S1MKEY = "S1MKEY";

        /// <summary>
        /// S1UPMJ.
        /// </summary>
        public const string S1UPMJ = "S1UPMJ";

        /// <summary>
        /// S1UPMT.
        /// </summary>
        public const string S1UPMT = "S1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F41F02WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S1JOBS", "S1JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("S1C9ITMP", "S1C9ITMP", JdeDataType.Numeric),
        new JdeField("S1C9LVL0", "S1C9LVL0", JdeDataType.String, 50),
        new JdeField("S1DSC2", "S1DSC2", JdeDataType.String, 60),
        new JdeField("S1ITM", "S1ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("S1LITM", "S1LITM", JdeDataType.String, 50),
        new JdeField("S1DSC1", "S1DSC1", JdeDataType.String, 60),
        new JdeField("S1C9LVNO", "S1C9LVNO", JdeDataType.Numeric),
        new JdeField("S1C9STRC", "S1C9STRC", JdeDataType.String, 6),
        new JdeField("S1APPELC01", "S1APPELC01", JdeDataType.String, 2),
        new JdeField("S1APPELS01", "S1APPELS01", JdeDataType.String, 60),
        new JdeField("S1APPELD01", "S1APPELD01", JdeDataType.Numeric),
        new JdeField("S1APPELN01", "S1APPELN01", JdeDataType.Numeric),
        new JdeField("S1URCD", "S1URCD", JdeDataType.String, 4),
        new JdeField("S1URDT", "S1URDT", JdeDataType.Numeric),
        new JdeField("S1URAT", "S1URAT", JdeDataType.Numeric),
        new JdeField("S1URAB", "S1URAB", JdeDataType.Numeric),
        new JdeField("S1URRF", "S1URRF", JdeDataType.String, 30),
        new JdeField("S1USER", "S1USER", JdeDataType.String, 20, true, true),
        new JdeField("S1PID", "S1PID", JdeDataType.String, 20),
        new JdeField("S1MKEY", "S1MKEY", JdeDataType.String, 30),
        new JdeField("S1UPMJ", "S1UPMJ", JdeDataType.Numeric),
        new JdeField("S1UPMT", "S1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41F02WF_0", "Primary Key on S1JOBS, S1USER, S1ITM", new[] { "S1JOBS", "S1USER", "S1ITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41F02WF_2", "Index on S1JOBS, S1USER, S1C9LVNO, S1LITM", new[] { "S1JOBS", "S1USER", "S1C9LVNO", "S1LITM" })
    };
}
