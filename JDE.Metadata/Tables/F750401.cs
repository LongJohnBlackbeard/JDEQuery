using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F750401 - .
/// </summary>
public class F750401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J4AN8.
        /// </summary>
        public const string J4AN8 = "J4AN8";

        /// <summary>
        /// J4TRAP.
        /// </summary>
        public const string J4TRAP = "J4TRAP";

        /// <summary>
        /// J4JPTY.
        /// </summary>
        public const string J4JPTY = "J4JPTY";

        /// <summary>
        /// J4USER.
        /// </summary>
        public const string J4USER = "J4USER";

        /// <summary>
        /// J4PID.
        /// </summary>
        public const string J4PID = "J4PID";

        /// <summary>
        /// J4UPMJ.
        /// </summary>
        public const string J4UPMJ = "J4UPMJ";

        /// <summary>
        /// J4JOBN.
        /// </summary>
        public const string J4JOBN = "J4JOBN";

        /// <summary>
        /// J4UPMT.
        /// </summary>
        public const string J4UPMT = "J4UPMT";

        /// <summary>
        /// J4WTCJP.
        /// </summary>
        public const string J4WTCJP = "J4WTCJP";

        /// <summary>
        /// J4DRATIO.
        /// </summary>
        public const string J4DRATIO = "J4DRATIO";
    }

    /// <inheritdoc />
    public override string TableName => "F750401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J4AN8", "J4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J4TRAP", "J4TRAP", JdeDataType.String, 6),
        new JdeField("J4JPTY", "J4JPTY", JdeDataType.String, 2),
        new JdeField("J4USER", "J4USER", JdeDataType.String, 20),
        new JdeField("J4PID", "J4PID", JdeDataType.String, 20),
        new JdeField("J4UPMJ", "J4UPMJ", JdeDataType.Numeric),
        new JdeField("J4JOBN", "J4JOBN", JdeDataType.String, 20),
        new JdeField("J4UPMT", "J4UPMT", JdeDataType.Numeric),
        new JdeField("J4WTCJP", "J4WTCJP", JdeDataType.String, 2),
        new JdeField("J4DRATIO", "J4DRATIO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F750401_0", "Primary Key on J4AN8", new[] { "J4AN8" }, isUnique: true, isPrimaryKey: true)
    };
}
