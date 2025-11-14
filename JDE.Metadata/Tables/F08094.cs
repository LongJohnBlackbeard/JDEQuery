using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08094 - .
/// </summary>
public class F08094 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JWCSRF.
        /// </summary>
        public const string JWCSRF = "JWCSRF";

        /// <summary>
        /// JWTYRC.
        /// </summary>
        public const string JWTYRC = "JWTYRC";

        /// <summary>
        /// JWTYRN.
        /// </summary>
        public const string JWTYRN = "JWTYRN";

        /// <summary>
        /// JWYNDL.
        /// </summary>
        public const string JWYNDL = "JWYNDL";
    }

    /// <inheritdoc />
    public override string TableName => "F08094";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JWCSRF", "JWCSRF", JdeDataType.String, 2, true, true),
        new JdeField("JWTYRC", "JWTYRC", JdeDataType.String, 4, true, true),
        new JdeField("JWTYRN", "JWTYRN", JdeDataType.String, 4),
        new JdeField("JWYNDL", "JWYNDL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08094_0", "Primary Key on JWCSRF, JWTYRC", new[] { "JWCSRF", "JWTYRC" }, isUnique: true, isPrimaryKey: true)
    };
}
