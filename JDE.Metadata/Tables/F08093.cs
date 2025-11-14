using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08093 - .
/// </summary>
public class F08093 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JYRCOD.
        /// </summary>
        public const string JYRCOD = "JYRCOD";

        /// <summary>
        /// JYTYRC.
        /// </summary>
        public const string JYTYRC = "JYTYRC";

        /// <summary>
        /// JYAN8.
        /// </summary>
        public const string JYAN8 = "JYAN8";

        /// <summary>
        /// JYJBCD.
        /// </summary>
        public const string JYJBCD = "JYJBCD";

        /// <summary>
        /// JYJBST.
        /// </summary>
        public const string JYJBST = "JYJBST";

        /// <summary>
        /// JYKY.
        /// </summary>
        public const string JYKY = "JYKY";

        /// <summary>
        /// JYEFT.
        /// </summary>
        public const string JYEFT = "JYEFT";

        /// <summary>
        /// JYLIN.
        /// </summary>
        public const string JYLIN = "JYLIN";

        /// <summary>
        /// JYDS80.
        /// </summary>
        public const string JYDS80 = "JYDS80";

        /// <summary>
        /// JYUSER.
        /// </summary>
        public const string JYUSER = "JYUSER";

        /// <summary>
        /// JYUPMJ.
        /// </summary>
        public const string JYUPMJ = "JYUPMJ";

        /// <summary>
        /// JYJOBN.
        /// </summary>
        public const string JYJOBN = "JYJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08093";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JYRCOD", "JYRCOD", JdeDataType.String, 2, true, true),
        new JdeField("JYTYRC", "JYTYRC", JdeDataType.String, 4, true, true),
        new JdeField("JYAN8", "JYAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JYJBCD", "JYJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JYJBST", "JYJBST", JdeDataType.String, 8, true, true),
        new JdeField("JYKY", "JYKY", JdeDataType.String, 20, true, true),
        new JdeField("JYEFT", "JYEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("JYLIN", "JYLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("JYDS80", "JYDS80", JdeDataType.String, 160),
        new JdeField("JYUSER", "JYUSER", JdeDataType.String, 20),
        new JdeField("JYUPMJ", "JYUPMJ", JdeDataType.Numeric),
        new JdeField("JYJOBN", "JYJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08093_0", "Primary Key on JYRCOD, JYTYRC, JYAN8, JYJBCD, JYJBST, JYKY, JYEFT, JYLIN", new[] { "JYRCOD", "JYTYRC", "JYAN8", "JYJBCD", "JYJBST", "JYKY", "JYEFT", "JYLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08093_2", "Index on JYRCOD, JYAN8, JYJBCD, JYJBST, JYTYRC, JYKY, JYEFT, JYLIN", new[] { "JYRCOD", "JYAN8", "JYJBCD", "JYJBST", "JYTYRC", "JYKY", "JYEFT", "JYLIN" })
    };
}
