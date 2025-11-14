using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B33W - .
/// </summary>
public class F31B33W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RWWLOTN.
        /// </summary>
        public const string RWWLOTN = "RWWLOTN";

        /// <summary>
        /// RWMCU.
        /// </summary>
        public const string RWMCU = "RWMCU";

        /// <summary>
        /// RWWVTY.
        /// </summary>
        public const string RWWVTY = "RWWVTY";

        /// <summary>
        /// RWWVID.
        /// </summary>
        public const string RWWVID = "RWWVID";

        /// <summary>
        /// RWUKID.
        /// </summary>
        public const string RWUKID = "RWUKID";

        /// <summary>
        /// RWUSER.
        /// </summary>
        public const string RWUSER = "RWUSER";

        /// <summary>
        /// RWUPMJ.
        /// </summary>
        public const string RWUPMJ = "RWUPMJ";

        /// <summary>
        /// RWUPMT.
        /// </summary>
        public const string RWUPMT = "RWUPMT";

        /// <summary>
        /// RWJOBN.
        /// </summary>
        public const string RWJOBN = "RWJOBN";

        /// <summary>
        /// RWMKEY.
        /// </summary>
        public const string RWMKEY = "RWMKEY";

        /// <summary>
        /// RWPID.
        /// </summary>
        public const string RWPID = "RWPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B33W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RWWLOTN", "RWWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("RWMCU", "RWMCU", JdeDataType.String, 24),
        new JdeField("RWWVTY", "RWWVTY", JdeDataType.String, 2),
        new JdeField("RWWVID", "RWWVID", JdeDataType.Numeric),
        new JdeField("RWUKID", "RWUKID", JdeDataType.Numeric),
        new JdeField("RWUSER", "RWUSER", JdeDataType.String, 20),
        new JdeField("RWUPMJ", "RWUPMJ", JdeDataType.Numeric),
        new JdeField("RWUPMT", "RWUPMT", JdeDataType.Numeric),
        new JdeField("RWJOBN", "RWJOBN", JdeDataType.String, 20),
        new JdeField("RWMKEY", "RWMKEY", JdeDataType.String, 30),
        new JdeField("RWPID", "RWPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B33W_0", "Primary Key on RWWLOTN", new[] { "RWWLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B33W_2", "Index on RWMCU, RWWVTY, RWWVID", new[] { "RWMCU", "RWWVTY", "RWWVID" })
    };
}
