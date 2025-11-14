using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I305 - .
/// </summary>
public class F75I305 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q3YEXU.
        /// </summary>
        public const string Q3YEXU = "Q3YEXU";

        /// <summary>
        /// Q3BDSN.
        /// </summary>
        public const string Q3BDSN = "Q3BDSN";

        /// <summary>
        /// Q3YEAR.
        /// </summary>
        public const string Q3YEAR = "Q3YEAR";

        /// <summary>
        /// Q3ONM.
        /// </summary>
        public const string Q3ONM = "Q3ONM";

        /// <summary>
        /// Q3DSCR.
        /// </summary>
        public const string Q3DSCR = "Q3DSCR";

        /// <summary>
        /// Q3BDPD.
        /// </summary>
        public const string Q3BDPD = "Q3BDPD";

        /// <summary>
        /// Q3AEXD.
        /// </summary>
        public const string Q3AEXD = "Q3AEXD";

        /// <summary>
        /// Q3ANOG.
        /// </summary>
        public const string Q3ANOG = "Q3ANOG";

        /// <summary>
        /// Q3ALPH.
        /// </summary>
        public const string Q3ALPH = "Q3ALPH";

        /// <summary>
        /// Q3ADD1.
        /// </summary>
        public const string Q3ADD1 = "Q3ADD1";

        /// <summary>
        /// Q3ADD2.
        /// </summary>
        public const string Q3ADD2 = "Q3ADD2";

        /// <summary>
        /// Q3BDNO.
        /// </summary>
        public const string Q3BDNO = "Q3BDNO";

        /// <summary>
        /// Q3CUAM.
        /// </summary>
        public const string Q3CUAM = "Q3CUAM";

        /// <summary>
        /// Q3USER.
        /// </summary>
        public const string Q3USER = "Q3USER";

        /// <summary>
        /// Q3JOBN.
        /// </summary>
        public const string Q3JOBN = "Q3JOBN";

        /// <summary>
        /// Q3PID.
        /// </summary>
        public const string Q3PID = "Q3PID";

        /// <summary>
        /// Q3UPMJ.
        /// </summary>
        public const string Q3UPMJ = "Q3UPMJ";

        /// <summary>
        /// Q3TDAY.
        /// </summary>
        public const string Q3TDAY = "Q3TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I305";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q3YEXU", "Q3YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3BDSN", "Q3BDSN", JdeDataType.String, 44, true, true),
        new JdeField("Q3YEAR", "Q3YEAR", JdeDataType.Numeric, null, true, true),
        new JdeField("Q3ONM", "Q3ONM", JdeDataType.String, 60),
        new JdeField("Q3DSCR", "Q3DSCR", JdeDataType.String, 80),
        new JdeField("Q3BDPD", "Q3BDPD", JdeDataType.Numeric),
        new JdeField("Q3AEXD", "Q3AEXD", JdeDataType.Numeric),
        new JdeField("Q3ANOG", "Q3ANOG", JdeDataType.Numeric),
        new JdeField("Q3ALPH", "Q3ALPH", JdeDataType.String, 80),
        new JdeField("Q3ADD1", "Q3ADD1", JdeDataType.String, 80),
        new JdeField("Q3ADD2", "Q3ADD2", JdeDataType.String, 80),
        new JdeField("Q3BDNO", "Q3BDNO", JdeDataType.Numeric),
        new JdeField("Q3CUAM", "Q3CUAM", JdeDataType.Numeric),
        new JdeField("Q3USER", "Q3USER", JdeDataType.String, 20),
        new JdeField("Q3JOBN", "Q3JOBN", JdeDataType.String, 20),
        new JdeField("Q3PID", "Q3PID", JdeDataType.String, 20),
        new JdeField("Q3UPMJ", "Q3UPMJ", JdeDataType.Numeric),
        new JdeField("Q3TDAY", "Q3TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I305_0", "Primary Key on Q3YEXU, Q3BDSN, Q3YEAR", new[] { "Q3YEXU", "Q3BDSN", "Q3YEAR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I305_2", "Index on Q3YEXU, Q3BDSN, Q3BDNO", new[] { "Q3YEXU", "Q3BDSN", "Q3BDNO" })
    };
}
