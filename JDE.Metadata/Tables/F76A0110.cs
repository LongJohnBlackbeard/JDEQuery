using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A0110 - .
/// </summary>
public class F76A0110 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// U1AN8.
        /// </summary>
        public const string U1AN8 = "U1AN8";

        /// <summary>
        /// U1AN8J.
        /// </summary>
        public const string U1AN8J = "U1AN8J";

        /// <summary>
        /// U1AMPE.
        /// </summary>
        public const string U1AMPE = "U1AMPE";

        /// <summary>
        /// U1RP1.
        /// </summary>
        public const string U1RP1 = "U1RP1";

        /// <summary>
        /// U1USER.
        /// </summary>
        public const string U1USER = "U1USER";

        /// <summary>
        /// U1PID.
        /// </summary>
        public const string U1PID = "U1PID";

        /// <summary>
        /// U1JOBN.
        /// </summary>
        public const string U1JOBN = "U1JOBN";

        /// <summary>
        /// U1UPMT.
        /// </summary>
        public const string U1UPMT = "U1UPMT";

        /// <summary>
        /// U1UPMJ.
        /// </summary>
        public const string U1UPMJ = "U1UPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76A0110";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("U1AN8", "U1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("U1AN8J", "U1AN8J", JdeDataType.Numeric, null, true, true),
        new JdeField("U1AMPE", "U1AMPE", JdeDataType.Numeric),
        new JdeField("U1RP1", "U1RP1", JdeDataType.String, 2),
        new JdeField("U1USER", "U1USER", JdeDataType.String, 20),
        new JdeField("U1PID", "U1PID", JdeDataType.String, 20),
        new JdeField("U1JOBN", "U1JOBN", JdeDataType.String, 20),
        new JdeField("U1UPMT", "U1UPMT", JdeDataType.Numeric),
        new JdeField("U1UPMJ", "U1UPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A0110_0", "Primary Key on U1AN8, U1AN8J", new[] { "U1AN8", "U1AN8J" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A0110_2", "Index on U1AN8J", new[] { "U1AN8J" })
    };
}
