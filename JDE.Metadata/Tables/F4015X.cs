using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4015X - .
/// </summary>
public class F4015X : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OGSNKY.
        /// </summary>
        public const string OGSNKY = "OGSNKY";

        /// <summary>
        /// OGORTP.
        /// </summary>
        public const string OGORTP = "OGORTP";

        /// <summary>
        /// OGAN8.
        /// </summary>
        public const string OGAN8 = "OGAN8";

        /// <summary>
        /// OGOSEQ.
        /// </summary>
        public const string OGOSEQ = "OGOSEQ";

        /// <summary>
        /// OGUORG.
        /// </summary>
        public const string OGUORG = "OGUORG";

        /// <summary>
        /// OGUOM.
        /// </summary>
        public const string OGUOM = "OGUOM";

        /// <summary>
        /// OGUPRC.
        /// </summary>
        public const string OGUPRC = "OGUPRC";
    }

    /// <inheritdoc />
    public override string TableName => "F4015X";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OGSNKY", "OGSNKY", JdeDataType.String, 64, true, true),
        new JdeField("OGORTP", "OGORTP", JdeDataType.String, 16, true, true),
        new JdeField("OGAN8", "OGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OGOSEQ", "OGOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OGUORG", "OGUORG", JdeDataType.Numeric),
        new JdeField("OGUOM", "OGUOM", JdeDataType.String, 4),
        new JdeField("OGUPRC", "OGUPRC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4015X_0", "Primary Key on OGSNKY, OGORTP, OGAN8, OGOSEQ", new[] { "OGSNKY", "OGORTP", "OGAN8", "OGOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
