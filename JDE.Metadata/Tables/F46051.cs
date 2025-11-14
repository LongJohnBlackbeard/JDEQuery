using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46051 - .
/// </summary>
public class F46051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LYMCU.
        /// </summary>
        public const string LYMCU = "LYMCU";

        /// <summary>
        /// LYLOCN.
        /// </summary>
        public const string LYLOCN = "LYLOCN";

        /// <summary>
        /// LYKZON.
        /// </summary>
        public const string LYKZON = "LYKZON";

        /// <summary>
        /// LYSEQ.
        /// </summary>
        public const string LYSEQ = "LYSEQ";

        /// <summary>
        /// LYZONR.
        /// </summary>
        public const string LYZONR = "LYZONR";

        /// <summary>
        /// LYUSER.
        /// </summary>
        public const string LYUSER = "LYUSER";

        /// <summary>
        /// LYUPMJ.
        /// </summary>
        public const string LYUPMJ = "LYUPMJ";

        /// <summary>
        /// LYTDAY.
        /// </summary>
        public const string LYTDAY = "LYTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LYMCU", "LYMCU", JdeDataType.String, 24, true, true),
        new JdeField("LYLOCN", "LYLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LYKZON", "LYKZON", JdeDataType.String, 12, true, true),
        new JdeField("LYSEQ", "LYSEQ", JdeDataType.Numeric),
        new JdeField("LYZONR", "LYZONR", JdeDataType.String, 12, true, true),
        new JdeField("LYUSER", "LYUSER", JdeDataType.String, 20),
        new JdeField("LYUPMJ", "LYUPMJ", JdeDataType.Numeric),
        new JdeField("LYTDAY", "LYTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46051_0", "Primary Key on LYMCU, LYKZON, LYLOCN, LYZONR", new[] { "LYMCU", "LYKZON", "LYLOCN", "LYZONR" }, isUnique: true, isPrimaryKey: true)
    };
}
