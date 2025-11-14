using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F8915CV2 - .
/// </summary>
public class F8915CV2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N9FILE.
        /// </summary>
        public const string N9FILE = "N9FILE";

        /// <summary>
        /// N9UK01.
        /// </summary>
        public const string N9UK01 = "N9UK01";

        /// <summary>
        /// N9KSTR.
        /// </summary>
        public const string N9KSTR = "N9KSTR";

        /// <summary>
        /// N9DL011.
        /// </summary>
        public const string N9DL011 = "N9DL011";

        /// <summary>
        /// N9EV01.
        /// </summary>
        public const string N9EV01 = "N9EV01";

        /// <summary>
        /// N9UPMJ.
        /// </summary>
        public const string N9UPMJ = "N9UPMJ";

        /// <summary>
        /// N9UPMT.
        /// </summary>
        public const string N9UPMT = "N9UPMT";

        /// <summary>
        /// N9JOBN.
        /// </summary>
        public const string N9JOBN = "N9JOBN";

        /// <summary>
        /// N9USER.
        /// </summary>
        public const string N9USER = "N9USER";
    }

    /// <inheritdoc />
    public override string TableName => "F8915CV2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N9FILE", "N9FILE", JdeDataType.String, 20, true, true),
        new JdeField("N9UK01", "N9UK01", JdeDataType.Numeric, null, true, true),
        new JdeField("N9KSTR", "N9KSTR", JdeDataType.String, 160),
        new JdeField("N9DL011", "N9DL011", JdeDataType.String, 200),
        new JdeField("N9EV01", "N9EV01", JdeDataType.String, 2),
        new JdeField("N9UPMJ", "N9UPMJ", JdeDataType.Numeric),
        new JdeField("N9UPMT", "N9UPMT", JdeDataType.Numeric),
        new JdeField("N9JOBN", "N9JOBN", JdeDataType.String, 20),
        new JdeField("N9USER", "N9USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F8915CV2_0", "Primary Key on N9FILE, N9UK01", new[] { "N9FILE", "N9UK01" }, isUnique: true, isPrimaryKey: true)
    };
}
