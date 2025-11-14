using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09190 - .
/// </summary>
public class F09190 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C9CO.
        /// </summary>
        public const string C9CO = "C9CO";

        /// <summary>
        /// C9UDHB.
        /// </summary>
        public const string C9UDHB = "C9UDHB";

        /// <summary>
        /// C9HBDG.
        /// </summary>
        public const string C9HBDG = "C9HBDG";

        /// <summary>
        /// C9CRCD.
        /// </summary>
        public const string C9CRCD = "C9CRCD";

        /// <summary>
        /// C9CRDC.
        /// </summary>
        public const string C9CRDC = "C9CRDC";

        /// <summary>
        /// C9USER.
        /// </summary>
        public const string C9USER = "C9USER";

        /// <summary>
        /// C9PID.
        /// </summary>
        public const string C9PID = "C9PID";

        /// <summary>
        /// C9JOBN.
        /// </summary>
        public const string C9JOBN = "C9JOBN";

        /// <summary>
        /// C9UPMJ.
        /// </summary>
        public const string C9UPMJ = "C9UPMJ";

        /// <summary>
        /// C9UPMT.
        /// </summary>
        public const string C9UPMT = "C9UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09190";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C9CO", "C9CO", JdeDataType.String, 10, true, true),
        new JdeField("C9UDHB", "C9UDHB", JdeDataType.String, 12),
        new JdeField("C9HBDG", "C9HBDG", JdeDataType.String, 2),
        new JdeField("C9CRCD", "C9CRCD", JdeDataType.String, 6),
        new JdeField("C9CRDC", "C9CRDC", JdeDataType.String, 6),
        new JdeField("C9USER", "C9USER", JdeDataType.String, 20),
        new JdeField("C9PID", "C9PID", JdeDataType.String, 20),
        new JdeField("C9JOBN", "C9JOBN", JdeDataType.String, 20),
        new JdeField("C9UPMJ", "C9UPMJ", JdeDataType.Numeric),
        new JdeField("C9UPMT", "C9UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09190_0", "Primary Key on C9CO", new[] { "C9CO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09190_2", "Index on C9UDHB, C9HBDG, C9CO", new[] { "C9UDHB", "C9HBDG", "C9CO" }),
        new JdeIndex("F09190_3", "Index on C9UDHB, C9CO", new[] { "C9UDHB", "C9CO" }),
        new JdeIndex("F09190_4", "Index on C9UDHB, C9HBDG", new[] { "C9UDHB", "C9HBDG" })
    };
}
