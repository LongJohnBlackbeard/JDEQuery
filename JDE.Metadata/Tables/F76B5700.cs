using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B5700 - .
/// </summary>
public class F76B5700 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CNCO.
        /// </summary>
        public const string CNCO = "CNCO";

        /// <summary>
        /// CNGCPWD.
        /// </summary>
        public const string CNGCPWD = "CNGCPWD";

        /// <summary>
        /// CNEXEP.
        /// </summary>
        public const string CNEXEP = "CNEXEP";

        /// <summary>
        /// CNRESPATH.
        /// </summary>
        public const string CNRESPATH = "CNRESPATH";
    }

    /// <inheritdoc />
    public override string TableName => "F76B5700";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CNCO", "CNCO", JdeDataType.String, 10, true, true),
        new JdeField("CNGCPWD", "CNGCPWD", JdeDataType.String, 160),
        new JdeField("CNEXEP", "CNEXEP", JdeDataType.String, 510),
        new JdeField("CNRESPATH", "CNRESPATH", JdeDataType.String, 510)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B5700_0", "Primary Key on CNCO", new[] { "CNCO" }, isUnique: true, isPrimaryKey: true)
    };
}
