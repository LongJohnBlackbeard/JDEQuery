using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3003T - .
/// </summary>
public class F3003T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRTRT.
        /// </summary>
        public const string IRTRT = "IRTRT";

        /// <summary>
        /// IRKIT.
        /// </summary>
        public const string IRKIT = "IRKIT";

        /// <summary>
        /// IRMMCU.
        /// </summary>
        public const string IRMMCU = "IRMMCU";

        /// <summary>
        /// IRLINE.
        /// </summary>
        public const string IRLINE = "IRLINE";

        /// <summary>
        /// IROPSQ.
        /// </summary>
        public const string IROPSQ = "IROPSQ";

        /// <summary>
        /// IREFFF.
        /// </summary>
        public const string IREFFF = "IREFFF";

        /// <summary>
        /// IRBQTY.
        /// </summary>
        public const string IRBQTY = "IRBQTY";

        /// <summary>
        /// IROPSC.
        /// </summary>
        public const string IROPSC = "IROPSC";

        /// <summary>
        /// IRLOCN.
        /// </summary>
        public const string IRLOCN = "IRLOCN";

        /// <summary>
        /// IRRUC.
        /// </summary>
        public const string IRRUC = "IRRUC";

        /// <summary>
        /// IRCAPU.
        /// </summary>
        public const string IRCAPU = "IRCAPU";

        /// <summary>
        /// IRNUMB.
        /// </summary>
        public const string IRNUMB = "IRNUMB";
    }

    /// <inheritdoc />
    public override string TableName => "F3003T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRTRT", "IRTRT", JdeDataType.String, 6, true, true),
        new JdeField("IRKIT", "IRKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("IRMMCU", "IRMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IRLINE", "IRLINE", JdeDataType.String, 24, true, true),
        new JdeField("IROPSQ", "IROPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IREFFF", "IREFFF", JdeDataType.Numeric, null, true, true),
        new JdeField("IRBQTY", "IRBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("IROPSC", "IROPSC", JdeDataType.String, 4, true, true),
        new JdeField("IRLOCN", "IRLOCN", JdeDataType.String, 40),
        new JdeField("IRRUC", "IRRUC", JdeDataType.Numeric),
        new JdeField("IRCAPU", "IRCAPU", JdeDataType.String, 4),
        new JdeField("IRNUMB", "IRNUMB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3003T_0", "Primary Key on IRMMCU, IRKIT, IRTRT, IRBQTY, IROPSQ, IROPSC, IRLINE, IREFFF", new[] { "IRMMCU", "IRKIT", "IRTRT", "IRBQTY", "IROPSQ", "IROPSC", "IRLINE", "IREFFF" }, isUnique: true, isPrimaryKey: true)
    };
}
