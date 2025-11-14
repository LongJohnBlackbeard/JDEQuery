using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3009T - .
/// </summary>
public class F3009T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IAMMCU.
        /// </summary>
        public const string IAMMCU = "IAMMCU";

        /// <summary>
        /// IAWRH2.
        /// </summary>
        public const string IAWRH2 = "IAWRH2";

        /// <summary>
        /// IAWRH3.
        /// </summary>
        public const string IAWRH3 = "IAWRH3";

        /// <summary>
        /// IAWRH4.
        /// </summary>
        public const string IAWRH4 = "IAWRH4";

        /// <summary>
        /// IAWRH5.
        /// </summary>
        public const string IAWRH5 = "IAWRH5";

        /// <summary>
        /// IAWRH6.
        /// </summary>
        public const string IAWRH6 = "IAWRH6";

        /// <summary>
        /// IASHFT.
        /// </summary>
        public const string IASHFT = "IASHFT";

        /// <summary>
        /// IASHF2.
        /// </summary>
        public const string IASHF2 = "IASHF2";

        /// <summary>
        /// IASHF3.
        /// </summary>
        public const string IASHF3 = "IASHF3";

        /// <summary>
        /// IASHF4.
        /// </summary>
        public const string IASHF4 = "IASHF4";

        /// <summary>
        /// IASHF5.
        /// </summary>
        public const string IASHF5 = "IASHF5";

        /// <summary>
        /// IASHF6.
        /// </summary>
        public const string IASHF6 = "IASHF6";

        /// <summary>
        /// IASRS1.
        /// </summary>
        public const string IASRS1 = "IASRS1";

        /// <summary>
        /// IAMARS.
        /// </summary>
        public const string IAMARS = "IAMARS";

        /// <summary>
        /// IALARS.
        /// </summary>
        public const string IALARS = "IALARS";
    }

    /// <inheritdoc />
    public override string TableName => "F3009T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IAMMCU", "IAMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IAWRH2", "IAWRH2", JdeDataType.Numeric),
        new JdeField("IAWRH3", "IAWRH3", JdeDataType.Numeric),
        new JdeField("IAWRH4", "IAWRH4", JdeDataType.Numeric),
        new JdeField("IAWRH5", "IAWRH5", JdeDataType.Numeric),
        new JdeField("IAWRH6", "IAWRH6", JdeDataType.Numeric),
        new JdeField("IASHFT", "IASHFT", JdeDataType.String, 2),
        new JdeField("IASHF2", "IASHF2", JdeDataType.String, 2),
        new JdeField("IASHF3", "IASHF3", JdeDataType.String, 2),
        new JdeField("IASHF4", "IASHF4", JdeDataType.String, 2),
        new JdeField("IASHF5", "IASHF5", JdeDataType.String, 2),
        new JdeField("IASHF6", "IASHF6", JdeDataType.String, 2),
        new JdeField("IASRS1", "IASRS1", JdeDataType.String, 4),
        new JdeField("IAMARS", "IAMARS", JdeDataType.String, 2),
        new JdeField("IALARS", "IALARS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3009T_0", "Primary Key on IAMMCU", new[] { "IAMMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
