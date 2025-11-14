using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51X006 - .
/// </summary>
public class F51X006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JLUSER.
        /// </summary>
        public const string JLUSER = "JLUSER";

        /// <summary>
        /// JLJOBS.
        /// </summary>
        public const string JLJOBS = "JLJOBS";

        /// <summary>
        /// JLMCU.
        /// </summary>
        public const string JLMCU = "JLMCU";

        /// <summary>
        /// JLCO.
        /// </summary>
        public const string JLCO = "JLCO";
    }

    /// <inheritdoc />
    public override string TableName => "F51X006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JLUSER", "JLUSER", JdeDataType.String, 20, true, true),
        new JdeField("JLJOBS", "JLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("JLMCU", "JLMCU", JdeDataType.String, 24, true, true),
        new JdeField("JLCO", "JLCO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51X006_0", "Primary Key on JLUSER, JLJOBS, JLMCU", new[] { "JLUSER", "JLJOBS", "JLMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F51X006_2", "Index on JLUSER, JLJOBS, JLCO", new[] { "JLUSER", "JLJOBS", "JLCO" })
    };
}
