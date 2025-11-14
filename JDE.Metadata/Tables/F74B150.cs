using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74B150 - .
/// </summary>
public class F74B150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YTMID.
        /// </summary>
        public const string YTMID = "YTMID";

        /// <summary>
        /// YTLMEM.
        /// </summary>
        public const string YTLMEM = "YTLMEM";

        /// <summary>
        /// YTYR.
        /// </summary>
        public const string YTYR = "YTYR";

        /// <summary>
        /// YTPQTR.
        /// </summary>
        public const string YTPQTR = "YTPQTR";

        /// <summary>
        /// YTAPTA.
        /// </summary>
        public const string YTAPTA = "YTAPTA";
    }

    /// <inheritdoc />
    public override string TableName => "F74B150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YTMID", "YTMID", JdeDataType.String, 20, true, true),
        new JdeField("YTLMEM", "YTLMEM", JdeDataType.String, 12, true, true),
        new JdeField("YTYR", "YTYR", JdeDataType.Numeric),
        new JdeField("YTPQTR", "YTPQTR", JdeDataType.String, 2),
        new JdeField("YTAPTA", "YTAPTA", JdeDataType.String, 3000)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74B150_0", "Primary Key on YTMID, YTLMEM", new[] { "YTMID", "YTLMEM" }, isUnique: true, isPrimaryKey: true)
    };
}
