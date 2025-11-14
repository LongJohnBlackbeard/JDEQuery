using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS06 - .
/// </summary>
public class F54HS06 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S7HSINO.
        /// </summary>
        public const string S7HSINO = "S7HSINO";

        /// <summary>
        /// S7UKID.
        /// </summary>
        public const string S7UKID = "S7UKID";

        /// <summary>
        /// S7RCK7.
        /// </summary>
        public const string S7RCK7 = "S7RCK7";

        /// <summary>
        /// S7ISSUE.
        /// </summary>
        public const string S7ISSUE = "S7ISSUE";

        /// <summary>
        /// S7DL01.
        /// </summary>
        public const string S7DL01 = "S7DL01";

        /// <summary>
        /// S7HSITT.
        /// </summary>
        public const string S7HSITT = "S7HSITT";

        /// <summary>
        /// S7PRIOR.
        /// </summary>
        public const string S7PRIOR = "S7PRIOR";

        /// <summary>
        /// S7CLST.
        /// </summary>
        public const string S7CLST = "S7CLST";

        /// <summary>
        /// S7ANP.
        /// </summary>
        public const string S7ANP = "S7ANP";

        /// <summary>
        /// S7NAME.
        /// </summary>
        public const string S7NAME = "S7NAME";

        /// <summary>
        /// S7HSITBD.
        /// </summary>
        public const string S7HSITBD = "S7HSITBD";

        /// <summary>
        /// S7HSITED.
        /// </summary>
        public const string S7HSITED = "S7HSITED";

        /// <summary>
        /// S7REM1.
        /// </summary>
        public const string S7REM1 = "S7REM1";

        /// <summary>
        /// S7HSIT1.
        /// </summary>
        public const string S7HSIT1 = "S7HSIT1";

        /// <summary>
        /// S7HSIT2.
        /// </summary>
        public const string S7HSIT2 = "S7HSIT2";

        /// <summary>
        /// S7HSIT3.
        /// </summary>
        public const string S7HSIT3 = "S7HSIT3";

        /// <summary>
        /// S7HSIT4.
        /// </summary>
        public const string S7HSIT4 = "S7HSIT4";

        /// <summary>
        /// S7HSIT5.
        /// </summary>
        public const string S7HSIT5 = "S7HSIT5";

        /// <summary>
        /// S7URAB.
        /// </summary>
        public const string S7URAB = "S7URAB";

        /// <summary>
        /// S7URCD.
        /// </summary>
        public const string S7URCD = "S7URCD";

        /// <summary>
        /// S7URAT.
        /// </summary>
        public const string S7URAT = "S7URAT";

        /// <summary>
        /// S7URDT.
        /// </summary>
        public const string S7URDT = "S7URDT";

        /// <summary>
        /// S7URRF.
        /// </summary>
        public const string S7URRF = "S7URRF";

        /// <summary>
        /// S7USER.
        /// </summary>
        public const string S7USER = "S7USER";

        /// <summary>
        /// S7UPMJ.
        /// </summary>
        public const string S7UPMJ = "S7UPMJ";

        /// <summary>
        /// S7UPMT.
        /// </summary>
        public const string S7UPMT = "S7UPMT";

        /// <summary>
        /// S7JOBN.
        /// </summary>
        public const string S7JOBN = "S7JOBN";

        /// <summary>
        /// S7PID.
        /// </summary>
        public const string S7PID = "S7PID";

        /// <summary>
        /// S7HSIECD.
        /// </summary>
        public const string S7HSIECD = "S7HSIECD";

        /// <summary>
        /// S7HSIACD.
        /// </summary>
        public const string S7HSIACD = "S7HSIACD";

        /// <summary>
        /// S7HSIT6.
        /// </summary>
        public const string S7HSIT6 = "S7HSIT6";

        /// <summary>
        /// S7HSIT7.
        /// </summary>
        public const string S7HSIT7 = "S7HSIT7";

        /// <summary>
        /// S7HSIT8.
        /// </summary>
        public const string S7HSIT8 = "S7HSIT8";

        /// <summary>
        /// S7HSIT9.
        /// </summary>
        public const string S7HSIT9 = "S7HSIT9";

        /// <summary>
        /// S7HSIT10.
        /// </summary>
        public const string S7HSIT10 = "S7HSIT10";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS06";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S7HSINO", "S7HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S7UKID", "S7UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("S7RCK7", "S7RCK7", JdeDataType.Numeric),
        new JdeField("S7ISSUE", "S7ISSUE", JdeDataType.String, 160),
        new JdeField("S7DL01", "S7DL01", JdeDataType.String, 60),
        new JdeField("S7HSITT", "S7HSITT", JdeDataType.String, 4),
        new JdeField("S7PRIOR", "S7PRIOR", JdeDataType.String, 4),
        new JdeField("S7CLST", "S7CLST", JdeDataType.String, 6),
        new JdeField("S7ANP", "S7ANP", JdeDataType.Numeric),
        new JdeField("S7NAME", "S7NAME", JdeDataType.String, 60),
        new JdeField("S7HSITBD", "S7HSITBD", JdeDataType.Numeric),
        new JdeField("S7HSITED", "S7HSITED", JdeDataType.Numeric),
        new JdeField("S7REM1", "S7REM1", JdeDataType.String, 80),
        new JdeField("S7HSIT1", "S7HSIT1", JdeDataType.String, 6),
        new JdeField("S7HSIT2", "S7HSIT2", JdeDataType.String, 6),
        new JdeField("S7HSIT3", "S7HSIT3", JdeDataType.String, 6),
        new JdeField("S7HSIT4", "S7HSIT4", JdeDataType.String, 6),
        new JdeField("S7HSIT5", "S7HSIT5", JdeDataType.String, 6),
        new JdeField("S7URAB", "S7URAB", JdeDataType.Numeric),
        new JdeField("S7URCD", "S7URCD", JdeDataType.String, 4),
        new JdeField("S7URAT", "S7URAT", JdeDataType.Numeric),
        new JdeField("S7URDT", "S7URDT", JdeDataType.Numeric),
        new JdeField("S7URRF", "S7URRF", JdeDataType.String, 30),
        new JdeField("S7USER", "S7USER", JdeDataType.String, 20),
        new JdeField("S7UPMJ", "S7UPMJ", JdeDataType.Numeric),
        new JdeField("S7UPMT", "S7UPMT", JdeDataType.Numeric),
        new JdeField("S7JOBN", "S7JOBN", JdeDataType.String, 20),
        new JdeField("S7PID", "S7PID", JdeDataType.String, 20),
        new JdeField("S7HSIECD", "S7HSIECD", JdeDataType.Numeric),
        new JdeField("S7HSIACD", "S7HSIACD", JdeDataType.Numeric),
        new JdeField("S7HSIT6", "S7HSIT6", JdeDataType.String, 20),
        new JdeField("S7HSIT7", "S7HSIT7", JdeDataType.String, 20),
        new JdeField("S7HSIT8", "S7HSIT8", JdeDataType.String, 20),
        new JdeField("S7HSIT9", "S7HSIT9", JdeDataType.String, 20),
        new JdeField("S7HSIT10", "S7HSIT10", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS06_0", "Primary Key on S7HSINO, S7UKID", new[] { "S7HSINO", "S7UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
