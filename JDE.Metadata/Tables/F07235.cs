using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07235 - .
/// </summary>
public class F07235 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y6PAYD.
        /// </summary>
        public const string Y6PAYD = "Y6PAYD";

        /// <summary>
        /// Y6PID.
        /// </summary>
        public const string Y6PID = "Y6PID";

        /// <summary>
        /// Y6VERS.
        /// </summary>
        public const string Y6VERS = "Y6VERS";

        /// <summary>
        /// Y6HMCO.
        /// </summary>
        public const string Y6HMCO = "Y6HMCO";

        /// <summary>
        /// Y6HMCU.
        /// </summary>
        public const string Y6HMCU = "Y6HMCU";

        /// <summary>
        /// Y6MATH06.
        /// </summary>
        public const string Y6MATH06 = "Y6MATH06";

        /// <summary>
        /// Y6APTA.
        /// </summary>
        public const string Y6APTA = "Y6APTA";
    }

    /// <inheritdoc />
    public override string TableName => "F07235";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y6PAYD", "Y6PAYD", JdeDataType.String, 20, true, true),
        new JdeField("Y6PID", "Y6PID", JdeDataType.String, 20, true, true),
        new JdeField("Y6VERS", "Y6VERS", JdeDataType.String, 20, true, true),
        new JdeField("Y6HMCO", "Y6HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y6HMCU", "Y6HMCU", JdeDataType.String, 24, true, true),
        new JdeField("Y6MATH06", "Y6MATH06", JdeDataType.Numeric, null, true, true),
        new JdeField("Y6APTA", "Y6APTA", JdeDataType.String, 3000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07235_0", "Primary Key on Y6PAYD, Y6PID, Y6VERS, Y6HMCO, Y6HMCU, Y6MATH06", new[] { "Y6PAYD", "Y6PID", "Y6VERS", "Y6HMCO", "Y6HMCU", "Y6MATH06" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07235_2", "Index on Y6PAYD, Y6PID, Y6VERS, Y6MATH06", new[] { "Y6PAYD", "Y6PID", "Y6VERS", "Y6MATH06" })
    };
}
