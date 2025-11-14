using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46096 - .
/// </summary>
public class F46096 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OUMCU.
        /// </summary>
        public const string OUMCU = "OUMCU";

        /// <summary>
        /// OUUOM.
        /// </summary>
        public const string OUUOM = "OUUOM";

        /// <summary>
        /// OUUMGP.
        /// </summary>
        public const string OUUMGP = "OUUMGP";

        /// <summary>
        /// OUUSER.
        /// </summary>
        public const string OUUSER = "OUUSER";

        /// <summary>
        /// OUUPMJ.
        /// </summary>
        public const string OUUPMJ = "OUUPMJ";

        /// <summary>
        /// OUTDAY.
        /// </summary>
        public const string OUTDAY = "OUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46096";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OUMCU", "OUMCU", JdeDataType.String, 24, true, true),
        new JdeField("OUUOM", "OUUOM", JdeDataType.String, 4, true, true),
        new JdeField("OUUMGP", "OUUMGP", JdeDataType.String, 4),
        new JdeField("OUUSER", "OUUSER", JdeDataType.String, 20),
        new JdeField("OUUPMJ", "OUUPMJ", JdeDataType.Numeric),
        new JdeField("OUTDAY", "OUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46096_0", "Primary Key on OUMCU, OUUOM", new[] { "OUMCU", "OUUOM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46096_2", "Index on OUMCU, OUUMGP, OUUOM", new[] { "OUMCU", "OUUMGP", "OUUOM" })
    };
}
