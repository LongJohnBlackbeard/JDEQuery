using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051124 - .
/// </summary>
public class F051124 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y4HMCO.
        /// </summary>
        public const string Y4HMCO = "Y4HMCO";

        /// <summary>
        /// Y4HMCU.
        /// </summary>
        public const string Y4HMCU = "Y4HMCU";

        /// <summary>
        /// Y4CCPR.
        /// </summary>
        public const string Y4CCPR = "Y4CCPR";

        /// <summary>
        /// Y4LNGP.
        /// </summary>
        public const string Y4LNGP = "Y4LNGP";

        /// <summary>
        /// Y4PID.
        /// </summary>
        public const string Y4PID = "Y4PID";

        /// <summary>
        /// Y4USER.
        /// </summary>
        public const string Y4USER = "Y4USER";

        /// <summary>
        /// Y4JOBN.
        /// </summary>
        public const string Y4JOBN = "Y4JOBN";

        /// <summary>
        /// Y4UPMJ.
        /// </summary>
        public const string Y4UPMJ = "Y4UPMJ";

        /// <summary>
        /// Y4UPMT.
        /// </summary>
        public const string Y4UPMT = "Y4UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F051124";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y4HMCO", "Y4HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y4HMCU", "Y4HMCU", JdeDataType.String, 24, true, true),
        new JdeField("Y4CCPR", "Y4CCPR", JdeDataType.String, 6, true, true),
        new JdeField("Y4LNGP", "Y4LNGP", JdeDataType.String, 4, true, true),
        new JdeField("Y4PID", "Y4PID", JdeDataType.String, 20),
        new JdeField("Y4USER", "Y4USER", JdeDataType.String, 20),
        new JdeField("Y4JOBN", "Y4JOBN", JdeDataType.String, 20),
        new JdeField("Y4UPMJ", "Y4UPMJ", JdeDataType.Numeric),
        new JdeField("Y4UPMT", "Y4UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051124_0", "Primary Key on Y4HMCO, Y4HMCU, Y4CCPR, Y4LNGP", new[] { "Y4HMCO", "Y4HMCU", "Y4CCPR", "Y4LNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
