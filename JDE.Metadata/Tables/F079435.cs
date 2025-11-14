using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F079435 - .
/// </summary>
public class F079435 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PFAN8.
        /// </summary>
        public const string PFAN8 = "PFAN8";

        /// <summary>
        /// PFPWPDBA.
        /// </summary>
        public const string PFPWPDBA = "PFPWPDBA";

        /// <summary>
        /// PFPDBA.
        /// </summary>
        public const string PFPDBA = "PFPDBA";

        /// <summary>
        /// PFPRTR.
        /// </summary>
        public const string PFPRTR = "PFPRTR";

        /// <summary>
        /// PFDWK.
        /// </summary>
        public const string PFDWK = "PFDWK";

        /// <summary>
        /// PFPWFRT.
        /// </summary>
        public const string PFPWFRT = "PFPWFRT";

        /// <summary>
        /// PFPWAR.
        /// </summary>
        public const string PFPWAR = "PFPWAR";

        /// <summary>
        /// PFPWHR.
        /// </summary>
        public const string PFPWHR = "PFPWHR";

        /// <summary>
        /// PFPWMULT.
        /// </summary>
        public const string PFPWMULT = "PFPWMULT";

        /// <summary>
        /// PFCKCN.
        /// </summary>
        public const string PFCKCN = "PFCKCN";

        /// <summary>
        /// PFPAYD.
        /// </summary>
        public const string PFPAYD = "PFPAYD";

        /// <summary>
        /// PFPWCH05.
        /// </summary>
        public const string PFPWCH05 = "PFPWCH05";

        /// <summary>
        /// PFPWCH06.
        /// </summary>
        public const string PFPWCH06 = "PFPWCH06";

        /// <summary>
        /// PFPWCH07.
        /// </summary>
        public const string PFPWCH07 = "PFPWCH07";

        /// <summary>
        /// PFPWJD05.
        /// </summary>
        public const string PFPWJD05 = "PFPWJD05";

        /// <summary>
        /// PFPWJD06.
        /// </summary>
        public const string PFPWJD06 = "PFPWJD06";

        /// <summary>
        /// PFPWJD07.
        /// </summary>
        public const string PFPWJD07 = "PFPWJD07";

        /// <summary>
        /// PFPWST05.
        /// </summary>
        public const string PFPWST05 = "PFPWST05";

        /// <summary>
        /// PFPWST06.
        /// </summary>
        public const string PFPWST06 = "PFPWST06";

        /// <summary>
        /// PFPWST07.
        /// </summary>
        public const string PFPWST07 = "PFPWST07";

        /// <summary>
        /// PFPWMN05.
        /// </summary>
        public const string PFPWMN05 = "PFPWMN05";

        /// <summary>
        /// PFPWMN06.
        /// </summary>
        public const string PFPWMN06 = "PFPWMN06";

        /// <summary>
        /// PFPWMN07.
        /// </summary>
        public const string PFPWMN07 = "PFPWMN07";

        /// <summary>
        /// PFUSER.
        /// </summary>
        public const string PFUSER = "PFUSER";

        /// <summary>
        /// PFPID.
        /// </summary>
        public const string PFPID = "PFPID";

        /// <summary>
        /// PFJOBN.
        /// </summary>
        public const string PFJOBN = "PFJOBN";

        /// <summary>
        /// PFUPMJ.
        /// </summary>
        public const string PFUPMJ = "PFUPMJ";

        /// <summary>
        /// PFUPMT.
        /// </summary>
        public const string PFUPMT = "PFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F079435";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PFAN8", "PFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PFPWPDBA", "PFPWPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("PFPDBA", "PFPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("PFPRTR", "PFPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("PFDWK", "PFDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("PFPWFRT", "PFPWFRT", JdeDataType.Numeric),
        new JdeField("PFPWAR", "PFPWAR", JdeDataType.String, 2),
        new JdeField("PFPWHR", "PFPWHR", JdeDataType.Numeric),
        new JdeField("PFPWMULT", "PFPWMULT", JdeDataType.Numeric),
        new JdeField("PFCKCN", "PFCKCN", JdeDataType.Numeric),
        new JdeField("PFPAYD", "PFPAYD", JdeDataType.String, 20),
        new JdeField("PFPWCH05", "PFPWCH05", JdeDataType.String, 2),
        new JdeField("PFPWCH06", "PFPWCH06", JdeDataType.String, 2),
        new JdeField("PFPWCH07", "PFPWCH07", JdeDataType.String, 2),
        new JdeField("PFPWJD05", "PFPWJD05", JdeDataType.Numeric),
        new JdeField("PFPWJD06", "PFPWJD06", JdeDataType.Numeric),
        new JdeField("PFPWJD07", "PFPWJD07", JdeDataType.Numeric),
        new JdeField("PFPWST05", "PFPWST05", JdeDataType.String, 40),
        new JdeField("PFPWST06", "PFPWST06", JdeDataType.String, 40),
        new JdeField("PFPWST07", "PFPWST07", JdeDataType.String, 80),
        new JdeField("PFPWMN05", "PFPWMN05", JdeDataType.Numeric),
        new JdeField("PFPWMN06", "PFPWMN06", JdeDataType.Numeric),
        new JdeField("PFPWMN07", "PFPWMN07", JdeDataType.Numeric),
        new JdeField("PFUSER", "PFUSER", JdeDataType.String, 20),
        new JdeField("PFPID", "PFPID", JdeDataType.String, 20),
        new JdeField("PFJOBN", "PFJOBN", JdeDataType.String, 20),
        new JdeField("PFUPMJ", "PFUPMJ", JdeDataType.Numeric),
        new JdeField("PFUPMT", "PFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F079435_0", "Primary Key on PFAN8, PFPWPDBA, PFPDBA, PFPRTR, PFDWK", new[] { "PFAN8", "PFPWPDBA", "PFPDBA", "PFPRTR", "PFDWK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F079435_2", "Index on PFAN8, PFCKCN", new[] { "PFAN8", "PFCKCN" })
    };
}
