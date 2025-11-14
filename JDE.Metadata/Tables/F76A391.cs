using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A391 - .
/// </summary>
public class F76A391 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C1AAJU.
        /// </summary>
        public const string C1AAJU = "C1AAJU";

        /// <summary>
        /// C1CTRY.
        /// </summary>
        public const string C1CTRY = "C1CTRY";

        /// <summary>
        /// C1YR.
        /// </summary>
        public const string C1YR = "C1YR";

        /// <summary>
        /// C1MT.
        /// </summary>
        public const string C1MT = "C1MT";

        /// <summary>
        /// C1AIND.
        /// </summary>
        public const string C1AIND = "C1AIND";

        /// <summary>
        /// C1TORG.
        /// </summary>
        public const string C1TORG = "C1TORG";

        /// <summary>
        /// C1USER.
        /// </summary>
        public const string C1USER = "C1USER";

        /// <summary>
        /// C1PID.
        /// </summary>
        public const string C1PID = "C1PID";

        /// <summary>
        /// C1UPMJ.
        /// </summary>
        public const string C1UPMJ = "C1UPMJ";

        /// <summary>
        /// C1UPMT.
        /// </summary>
        public const string C1UPMT = "C1UPMT";

        /// <summary>
        /// C1JOBN.
        /// </summary>
        public const string C1JOBN = "C1JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A391";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C1AAJU", "C1AAJU", JdeDataType.String, 20, true, true),
        new JdeField("C1CTRY", "C1CTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("C1YR", "C1YR", JdeDataType.Numeric, null, true, true),
        new JdeField("C1MT", "C1MT", JdeDataType.Numeric, null, true, true),
        new JdeField("C1AIND", "C1AIND", JdeDataType.Numeric),
        new JdeField("C1TORG", "C1TORG", JdeDataType.String, 20),
        new JdeField("C1USER", "C1USER", JdeDataType.String, 20),
        new JdeField("C1PID", "C1PID", JdeDataType.String, 20),
        new JdeField("C1UPMJ", "C1UPMJ", JdeDataType.Numeric),
        new JdeField("C1UPMT", "C1UPMT", JdeDataType.Numeric),
        new JdeField("C1JOBN", "C1JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A391_0", "Primary Key on C1AAJU, C1CTRY, C1YR, C1MT", new[] { "C1AAJU", "C1CTRY", "C1YR", "C1MT" }, isUnique: true, isPrimaryKey: true)
    };
}
