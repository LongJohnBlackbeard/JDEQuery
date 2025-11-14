using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08912 - .
/// </summary>
public class F08912 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HBPAN8.
        /// </summary>
        public const string HBPAN8 = "HBPAN8";

        /// <summary>
        /// HBQE1.
        /// </summary>
        public const string HBQE1 = "HBQE1";

        /// <summary>
        /// HBQD1.
        /// </summary>
        public const string HBQD1 = "HBQD1";

        /// <summary>
        /// HBAN8.
        /// </summary>
        public const string HBAN8 = "HBAN8";

        /// <summary>
        /// HBQE2.
        /// </summary>
        public const string HBQE2 = "HBQE2";

        /// <summary>
        /// HBQD2.
        /// </summary>
        public const string HBQD2 = "HBQD2";

        /// <summary>
        /// HBQDM2.
        /// </summary>
        public const string HBQDM2 = "HBQDM2";

        /// <summary>
        /// HBCVP2.
        /// </summary>
        public const string HBCVP2 = "HBCVP2";
    }

    /// <inheritdoc />
    public override string TableName => "F08912";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HBPAN8", "HBPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HBQE1", "HBQE1", JdeDataType.String, 4, true, true),
        new JdeField("HBQD1", "HBQD1", JdeDataType.Numeric, null, true, true),
        new JdeField("HBAN8", "HBAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HBQE2", "HBQE2", JdeDataType.String, 4, true, true),
        new JdeField("HBQD2", "HBQD2", JdeDataType.Numeric, null, true, true),
        new JdeField("HBQDM2", "HBQDM2", JdeDataType.Numeric),
        new JdeField("HBCVP2", "HBCVP2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08912_0", "Primary Key on HBPAN8, HBQE1, HBQD1, HBAN8, HBQE2, HBQD2", new[] { "HBPAN8", "HBQE1", "HBQD1", "HBAN8", "HBQE2", "HBQD2" }, isUnique: true, isPrimaryKey: true)
    };
}
