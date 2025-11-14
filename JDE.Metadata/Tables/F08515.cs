using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08515 - .
/// </summary>
public class F08515 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QBPDBA.
        /// </summary>
        public const string QBPDBA = "QBPDBA";

        /// <summary>
        /// QBDBAR.
        /// </summary>
        public const string QBDBAR = "QBDBAR";

        /// <summary>
        /// QBUSER.
        /// </summary>
        public const string QBUSER = "QBUSER";

        /// <summary>
        /// QBPID.
        /// </summary>
        public const string QBPID = "QBPID";

        /// <summary>
        /// QBJOBN.
        /// </summary>
        public const string QBJOBN = "QBJOBN";

        /// <summary>
        /// QBUPMJ.
        /// </summary>
        public const string QBUPMJ = "QBUPMJ";

        /// <summary>
        /// QBTME0.
        /// </summary>
        public const string QBTME0 = "QBTME0";
    }

    /// <inheritdoc />
    public override string TableName => "F08515";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QBPDBA", "QBPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("QBDBAR", "QBDBAR", JdeDataType.Numeric),
        new JdeField("QBUSER", "QBUSER", JdeDataType.String, 20),
        new JdeField("QBPID", "QBPID", JdeDataType.String, 20),
        new JdeField("QBJOBN", "QBJOBN", JdeDataType.String, 20),
        new JdeField("QBUPMJ", "QBUPMJ", JdeDataType.Numeric),
        new JdeField("QBTME0", "QBTME0", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08515_0", "Primary Key on QBPDBA", new[] { "QBPDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
