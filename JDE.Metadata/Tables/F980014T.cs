using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F980014T - .
/// </summary>
public class F980014T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTOBNM.
        /// </summary>
        public const string MTOBNM = "MTOBNM";

        /// <summary>
        /// MTABFN.
        /// </summary>
        public const string MTABFN = "MTABFN";

        /// <summary>
        /// MTSTOKEN.
        /// </summary>
        public const string MTSTOKEN = "MTSTOKEN";

        /// <summary>
        /// MTETOKEN.
        /// </summary>
        public const string MTETOKEN = "MTETOKEN";

        /// <summary>
        /// MTMSTOKEN.
        /// </summary>
        public const string MTMSTOKEN = "MTMSTOKEN";

        /// <summary>
        /// MTFTYPE.
        /// </summary>
        public const string MTFTYPE = "MTFTYPE";
    }

    /// <inheritdoc />
    public override string TableName => "F980014T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTOBNM", "MTOBNM", JdeDataType.String, 20, true, true),
        new JdeField("MTABFN", "MTABFN", JdeDataType.Numeric),
        new JdeField("MTSTOKEN", "MTSTOKEN", JdeDataType.String, 10),
        new JdeField("MTETOKEN", "MTETOKEN", JdeDataType.String, 10),
        new JdeField("MTMSTOKEN", "MTMSTOKEN", JdeDataType.String, 2),
        new JdeField("MTFTYPE", "MTFTYPE", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F980014T_0", "Primary Key on MTOBNM", new[] { "MTOBNM" }, isUnique: true, isPrimaryKey: true)
    };
}
