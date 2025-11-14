using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75013 - .
/// </summary>
public class F75013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J3PAAP.
        /// </summary>
        public const string J3PAAP = "J3PAAP";

        /// <summary>
        /// J3STAM.
        /// </summary>
        public const string J3STAM = "J3STAM";

        /// <summary>
        /// J3CRCD.
        /// </summary>
        public const string J3CRCD = "J3CRCD";

        /// <summary>
        /// J3USER.
        /// </summary>
        public const string J3USER = "J3USER";

        /// <summary>
        /// J3PID.
        /// </summary>
        public const string J3PID = "J3PID";

        /// <summary>
        /// J3UPMJ.
        /// </summary>
        public const string J3UPMJ = "J3UPMJ";

        /// <summary>
        /// J3JOBN.
        /// </summary>
        public const string J3JOBN = "J3JOBN";

        /// <summary>
        /// J3UPMT.
        /// </summary>
        public const string J3UPMT = "J3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J3PAAP", "J3PAAP", JdeDataType.Numeric, null, true, true),
        new JdeField("J3STAM", "J3STAM", JdeDataType.Numeric),
        new JdeField("J3CRCD", "J3CRCD", JdeDataType.String, 6),
        new JdeField("J3USER", "J3USER", JdeDataType.String, 20),
        new JdeField("J3PID", "J3PID", JdeDataType.String, 20),
        new JdeField("J3UPMJ", "J3UPMJ", JdeDataType.Numeric),
        new JdeField("J3JOBN", "J3JOBN", JdeDataType.String, 20),
        new JdeField("J3UPMT", "J3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75013_0", "Primary Key on J3PAAP", new[] { "J3PAAP" }, isUnique: true, isPrimaryKey: true)
    };
}
