using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS06M - .
/// </summary>
public class F54HS06M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I7HSINO.
        /// </summary>
        public const string I7HSINO = "I7HSINO";

        /// <summary>
        /// I7UKID.
        /// </summary>
        public const string I7UKID = "I7UKID";

        /// <summary>
        /// I7HSIMN.
        /// </summary>
        public const string I7HSIMN = "I7HSIMN";

        /// <summary>
        /// I7HSIMT.
        /// </summary>
        public const string I7HSIMT = "I7HSIMT";

        /// <summary>
        /// I7MODDT.
        /// </summary>
        public const string I7MODDT = "I7MODDT";

        /// <summary>
        /// I7RCK7.
        /// </summary>
        public const string I7RCK7 = "I7RCK7";

        /// <summary>
        /// I7ISSUE.
        /// </summary>
        public const string I7ISSUE = "I7ISSUE";

        /// <summary>
        /// I7DL01.
        /// </summary>
        public const string I7DL01 = "I7DL01";

        /// <summary>
        /// I7HSITT.
        /// </summary>
        public const string I7HSITT = "I7HSITT";

        /// <summary>
        /// I7PRIOR.
        /// </summary>
        public const string I7PRIOR = "I7PRIOR";

        /// <summary>
        /// I7CLST.
        /// </summary>
        public const string I7CLST = "I7CLST";

        /// <summary>
        /// I7ANP.
        /// </summary>
        public const string I7ANP = "I7ANP";

        /// <summary>
        /// I7NAME.
        /// </summary>
        public const string I7NAME = "I7NAME";

        /// <summary>
        /// I7HSITBD.
        /// </summary>
        public const string I7HSITBD = "I7HSITBD";

        /// <summary>
        /// I7HSITED.
        /// </summary>
        public const string I7HSITED = "I7HSITED";

        /// <summary>
        /// I7REM1.
        /// </summary>
        public const string I7REM1 = "I7REM1";

        /// <summary>
        /// I7HSIT1.
        /// </summary>
        public const string I7HSIT1 = "I7HSIT1";

        /// <summary>
        /// I7HSIT2.
        /// </summary>
        public const string I7HSIT2 = "I7HSIT2";

        /// <summary>
        /// I7HSIT3.
        /// </summary>
        public const string I7HSIT3 = "I7HSIT3";

        /// <summary>
        /// I7HSIT4.
        /// </summary>
        public const string I7HSIT4 = "I7HSIT4";

        /// <summary>
        /// I7HSIT5.
        /// </summary>
        public const string I7HSIT5 = "I7HSIT5";

        /// <summary>
        /// I7URAB.
        /// </summary>
        public const string I7URAB = "I7URAB";

        /// <summary>
        /// I7URCD.
        /// </summary>
        public const string I7URCD = "I7URCD";

        /// <summary>
        /// I7URAT.
        /// </summary>
        public const string I7URAT = "I7URAT";

        /// <summary>
        /// I7URDT.
        /// </summary>
        public const string I7URDT = "I7URDT";

        /// <summary>
        /// I7URRF.
        /// </summary>
        public const string I7URRF = "I7URRF";

        /// <summary>
        /// I7USER.
        /// </summary>
        public const string I7USER = "I7USER";

        /// <summary>
        /// I7UPMJ.
        /// </summary>
        public const string I7UPMJ = "I7UPMJ";

        /// <summary>
        /// I7UPMT.
        /// </summary>
        public const string I7UPMT = "I7UPMT";

        /// <summary>
        /// I7JOBN.
        /// </summary>
        public const string I7JOBN = "I7JOBN";

        /// <summary>
        /// I7PID.
        /// </summary>
        public const string I7PID = "I7PID";

        /// <summary>
        /// I7HSIECD.
        /// </summary>
        public const string I7HSIECD = "I7HSIECD";

        /// <summary>
        /// I7HSIACD.
        /// </summary>
        public const string I7HSIACD = "I7HSIACD";

        /// <summary>
        /// I7HSIT6.
        /// </summary>
        public const string I7HSIT6 = "I7HSIT6";

        /// <summary>
        /// I7HSIT7.
        /// </summary>
        public const string I7HSIT7 = "I7HSIT7";

        /// <summary>
        /// I7HSIT8.
        /// </summary>
        public const string I7HSIT8 = "I7HSIT8";

        /// <summary>
        /// I7HSIT9.
        /// </summary>
        public const string I7HSIT9 = "I7HSIT9";

        /// <summary>
        /// I7HSIT10.
        /// </summary>
        public const string I7HSIT10 = "I7HSIT10";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS06M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I7HSINO", "I7HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I7UKID", "I7UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I7HSIMN", "I7HSIMN", JdeDataType.Numeric, null, true, true),
        new JdeField("I7HSIMT", "I7HSIMT", JdeDataType.String, 2),
        new JdeField("I7MODDT", "I7MODDT", JdeDataType.Numeric),
        new JdeField("I7RCK7", "I7RCK7", JdeDataType.Numeric),
        new JdeField("I7ISSUE", "I7ISSUE", JdeDataType.String, 160),
        new JdeField("I7DL01", "I7DL01", JdeDataType.String, 60),
        new JdeField("I7HSITT", "I7HSITT", JdeDataType.String, 4),
        new JdeField("I7PRIOR", "I7PRIOR", JdeDataType.String, 4),
        new JdeField("I7CLST", "I7CLST", JdeDataType.String, 6),
        new JdeField("I7ANP", "I7ANP", JdeDataType.Numeric),
        new JdeField("I7NAME", "I7NAME", JdeDataType.String, 60),
        new JdeField("I7HSITBD", "I7HSITBD", JdeDataType.Numeric),
        new JdeField("I7HSITED", "I7HSITED", JdeDataType.Numeric),
        new JdeField("I7REM1", "I7REM1", JdeDataType.String, 80),
        new JdeField("I7HSIT1", "I7HSIT1", JdeDataType.String, 6),
        new JdeField("I7HSIT2", "I7HSIT2", JdeDataType.String, 6),
        new JdeField("I7HSIT3", "I7HSIT3", JdeDataType.String, 6),
        new JdeField("I7HSIT4", "I7HSIT4", JdeDataType.String, 6),
        new JdeField("I7HSIT5", "I7HSIT5", JdeDataType.String, 6),
        new JdeField("I7URAB", "I7URAB", JdeDataType.Numeric),
        new JdeField("I7URCD", "I7URCD", JdeDataType.String, 4),
        new JdeField("I7URAT", "I7URAT", JdeDataType.Numeric),
        new JdeField("I7URDT", "I7URDT", JdeDataType.Numeric),
        new JdeField("I7URRF", "I7URRF", JdeDataType.String, 30),
        new JdeField("I7USER", "I7USER", JdeDataType.String, 20),
        new JdeField("I7UPMJ", "I7UPMJ", JdeDataType.Numeric),
        new JdeField("I7UPMT", "I7UPMT", JdeDataType.Numeric),
        new JdeField("I7JOBN", "I7JOBN", JdeDataType.String, 20),
        new JdeField("I7PID", "I7PID", JdeDataType.String, 20),
        new JdeField("I7HSIECD", "I7HSIECD", JdeDataType.Numeric),
        new JdeField("I7HSIACD", "I7HSIACD", JdeDataType.Numeric),
        new JdeField("I7HSIT6", "I7HSIT6", JdeDataType.String, 20),
        new JdeField("I7HSIT7", "I7HSIT7", JdeDataType.String, 20),
        new JdeField("I7HSIT8", "I7HSIT8", JdeDataType.String, 20),
        new JdeField("I7HSIT9", "I7HSIT9", JdeDataType.String, 20),
        new JdeField("I7HSIT10", "I7HSIT10", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS06M_0", "Primary Key on I7HSINO, I7UKID, I7HSIMN", new[] { "I7HSINO", "I7UKID", "I7HSIMN" }, isUnique: true, isPrimaryKey: true)
    };
}
