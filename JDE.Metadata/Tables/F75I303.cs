using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I303 - .
/// </summary>
public class F75I303 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q2YEXU.
        /// </summary>
        public const string Q2YEXU = "Q2YEXU";

        /// <summary>
        /// Q2BDSN.
        /// </summary>
        public const string Q2BDSN = "Q2BDSN";

        /// <summary>
        /// Q2YEAR.
        /// </summary>
        public const string Q2YEAR = "Q2YEAR";

        /// <summary>
        /// Q2ONM.
        /// </summary>
        public const string Q2ONM = "Q2ONM";

        /// <summary>
        /// Q2DSCR.
        /// </summary>
        public const string Q2DSCR = "Q2DSCR";

        /// <summary>
        /// Q2BDPD.
        /// </summary>
        public const string Q2BDPD = "Q2BDPD";

        /// <summary>
        /// Q2AEXD.
        /// </summary>
        public const string Q2AEXD = "Q2AEXD";

        /// <summary>
        /// Q2ANOG.
        /// </summary>
        public const string Q2ANOG = "Q2ANOG";

        /// <summary>
        /// Q2ALPH.
        /// </summary>
        public const string Q2ALPH = "Q2ALPH";

        /// <summary>
        /// Q2ADD1.
        /// </summary>
        public const string Q2ADD1 = "Q2ADD1";

        /// <summary>
        /// Q2EV01.
        /// </summary>
        public const string Q2EV01 = "Q2EV01";

        /// <summary>
        /// Q2ADD2.
        /// </summary>
        public const string Q2ADD2 = "Q2ADD2";

        /// <summary>
        /// Q2CUAM.
        /// </summary>
        public const string Q2CUAM = "Q2CUAM";

        /// <summary>
        /// Q2USER.
        /// </summary>
        public const string Q2USER = "Q2USER";

        /// <summary>
        /// Q2JOBN.
        /// </summary>
        public const string Q2JOBN = "Q2JOBN";

        /// <summary>
        /// Q2UPMT.
        /// </summary>
        public const string Q2UPMT = "Q2UPMT";

        /// <summary>
        /// Q2PID.
        /// </summary>
        public const string Q2PID = "Q2PID";

        /// <summary>
        /// Q2UPMJ.
        /// </summary>
        public const string Q2UPMJ = "Q2UPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F75I303";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q2YEXU", "Q2YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2BDSN", "Q2BDSN", JdeDataType.String, 44, true, true),
        new JdeField("Q2YEAR", "Q2YEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("Q2ONM", "Q2ONM", JdeDataType.String, 60),
        new JdeField("Q2DSCR", "Q2DSCR", JdeDataType.String, 80),
        new JdeField("Q2BDPD", "Q2BDPD", JdeDataType.Numeric),
        new JdeField("Q2AEXD", "Q2AEXD", JdeDataType.Numeric),
        new JdeField("Q2ANOG", "Q2ANOG", JdeDataType.Numeric),
        new JdeField("Q2ALPH", "Q2ALPH", JdeDataType.String, 80),
        new JdeField("Q2ADD1", "Q2ADD1", JdeDataType.String, 80),
        new JdeField("Q2EV01", "Q2EV01", JdeDataType.String, 2),
        new JdeField("Q2ADD2", "Q2ADD2", JdeDataType.String, 80),
        new JdeField("Q2CUAM", "Q2CUAM", JdeDataType.Numeric),
        new JdeField("Q2USER", "Q2USER", JdeDataType.String, 20),
        new JdeField("Q2JOBN", "Q2JOBN", JdeDataType.String, 20),
        new JdeField("Q2UPMT", "Q2UPMT", JdeDataType.Numeric),
        new JdeField("Q2PID", "Q2PID", JdeDataType.String, 20),
        new JdeField("Q2UPMJ", "Q2UPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I303_0", "Primary Key on Q2YEXU, Q2BDSN, Q2YEAR", new[] { "Q2YEXU", "Q2BDSN", "Q2YEAR" }, isUnique: true, isPrimaryKey: true)
    };
}
