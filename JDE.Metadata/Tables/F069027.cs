using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069027 - .
/// </summary>
public class F069027 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y2PRUM.
        /// </summary>
        public const string Y2PRUM = "Y2PRUM";

        /// <summary>
        /// Y2EXA.
        /// </summary>
        public const string Y2EXA = "Y2EXA";

        /// <summary>
        /// Y2LGL1.
        /// </summary>
        public const string Y2LGL1 = "Y2LGL1";

        /// <summary>
        /// Y2LGL2.
        /// </summary>
        public const string Y2LGL2 = "Y2LGL2";

        /// <summary>
        /// Y2LGL3.
        /// </summary>
        public const string Y2LGL3 = "Y2LGL3";

        /// <summary>
        /// Y2LGL4.
        /// </summary>
        public const string Y2LGL4 = "Y2LGL4";

        /// <summary>
        /// Y2LGL5.
        /// </summary>
        public const string Y2LGL5 = "Y2LGL5";

        /// <summary>
        /// Y2DBA1.
        /// </summary>
        public const string Y2DBA1 = "Y2DBA1";

        /// <summary>
        /// Y2DBA2.
        /// </summary>
        public const string Y2DBA2 = "Y2DBA2";

        /// <summary>
        /// Y2DBA3.
        /// </summary>
        public const string Y2DBA3 = "Y2DBA3";
    }

    /// <inheritdoc />
    public override string TableName => "F069027";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y2PRUM", "Y2PRUM", JdeDataType.String, 4, true, true),
        new JdeField("Y2EXA", "Y2EXA", JdeDataType.String, 60),
        new JdeField("Y2LGL1", "Y2LGL1", JdeDataType.String, 100),
        new JdeField("Y2LGL2", "Y2LGL2", JdeDataType.String, 100),
        new JdeField("Y2LGL3", "Y2LGL3", JdeDataType.String, 100),
        new JdeField("Y2LGL4", "Y2LGL4", JdeDataType.String, 100),
        new JdeField("Y2LGL5", "Y2LGL5", JdeDataType.String, 100),
        new JdeField("Y2DBA1", "Y2DBA1", JdeDataType.String, 2),
        new JdeField("Y2DBA2", "Y2DBA2", JdeDataType.String, 2),
        new JdeField("Y2DBA3", "Y2DBA3", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069027_0", "Primary Key on Y2PRUM", new[] { "Y2PRUM" }, isUnique: true, isPrimaryKey: true)
    };
}
