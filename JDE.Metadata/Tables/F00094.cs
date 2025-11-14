using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00094 - .
/// </summary>
public class F00094 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T1AN8.
        /// </summary>
        public const string T1AN8 = "T1AN8";

        /// <summary>
        /// T1AGENT.
        /// </summary>
        public const string T1AGENT = "T1AGENT";

        /// <summary>
        /// T1PH1.
        /// </summary>
        public const string T1PH1 = "T1PH1";

        /// <summary>
        /// T1OBNM.
        /// </summary>
        public const string T1OBNM = "T1OBNM";

        /// <summary>
        /// T1FMNM.
        /// </summary>
        public const string T1FMNM = "T1FMNM";

        /// <summary>
        /// T1VER.
        /// </summary>
        public const string T1VER = "T1VER";

        /// <summary>
        /// T1USER.
        /// </summary>
        public const string T1USER = "T1USER";

        /// <summary>
        /// T1JOBN.
        /// </summary>
        public const string T1JOBN = "T1JOBN";

        /// <summary>
        /// T1UPMJ.
        /// </summary>
        public const string T1UPMJ = "T1UPMJ";

        /// <summary>
        /// T1UPMT.
        /// </summary>
        public const string T1UPMT = "T1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F00094";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T1AN8", "T1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("T1AGENT", "T1AGENT", JdeDataType.String, 40),
        new JdeField("T1PH1", "T1PH1", JdeDataType.String, 40),
        new JdeField("T1OBNM", "T1OBNM", JdeDataType.String, 20),
        new JdeField("T1FMNM", "T1FMNM", JdeDataType.String, 20),
        new JdeField("T1VER", "T1VER", JdeDataType.String, 20),
        new JdeField("T1USER", "T1USER", JdeDataType.String, 20),
        new JdeField("T1JOBN", "T1JOBN", JdeDataType.String, 20),
        new JdeField("T1UPMJ", "T1UPMJ", JdeDataType.Numeric),
        new JdeField("T1UPMT", "T1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00094_0", "Primary Key on T1AN8", new[] { "T1AN8" }, isUnique: true, isPrimaryKey: true)
    };
}
