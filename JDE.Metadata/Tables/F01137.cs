using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01137 - .
/// </summary>
public class F01137 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZXAN8.
        /// </summary>
        public const string ZXAN8 = "ZXAN8";

        /// <summary>
        /// ZXWRFLG.
        /// </summary>
        public const string ZXWRFLG = "ZXWRFLG";

        /// <summary>
        /// ZXWRFLU.
        /// </summary>
        public const string ZXWRFLU = "ZXWRFLU";

        /// <summary>
        /// ZXMBDS.
        /// </summary>
        public const string ZXMBDS = "ZXMBDS";

        /// <summary>
        /// ZXUSER.
        /// </summary>
        public const string ZXUSER = "ZXUSER";

        /// <summary>
        /// ZXJOBN.
        /// </summary>
        public const string ZXJOBN = "ZXJOBN";

        /// <summary>
        /// ZXUPMJ.
        /// </summary>
        public const string ZXUPMJ = "ZXUPMJ";

        /// <summary>
        /// ZXTDAY.
        /// </summary>
        public const string ZXTDAY = "ZXTDAY";

        /// <summary>
        /// ZXPID.
        /// </summary>
        public const string ZXPID = "ZXPID";
    }

    /// <inheritdoc />
    public override string TableName => "F01137";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZXAN8", "ZXAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZXWRFLG", "ZXWRFLG", JdeDataType.Numeric, null, true, true),
        new JdeField("ZXWRFLU", "ZXWRFLU", JdeDataType.Numeric, null, true, true),
        new JdeField("ZXMBDS", "ZXMBDS", JdeDataType.String, 4, true, true),
        new JdeField("ZXUSER", "ZXUSER", JdeDataType.String, 20),
        new JdeField("ZXJOBN", "ZXJOBN", JdeDataType.String, 20),
        new JdeField("ZXUPMJ", "ZXUPMJ", JdeDataType.Numeric),
        new JdeField("ZXTDAY", "ZXTDAY", JdeDataType.Numeric),
        new JdeField("ZXPID", "ZXPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01137_0", "Primary Key on ZXWRFLU, ZXWRFLG, ZXMBDS, ZXAN8", new[] { "ZXWRFLU", "ZXWRFLG", "ZXMBDS", "ZXAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01137_2", "Index on ZXWRFLU, ZXMBDS, ZXAN8", new[] { "ZXWRFLU", "ZXMBDS", "ZXAN8" }),
        new JdeIndex("F01137_3", "Index on ZXWRFLU, ZXAN8, ZXMBDS", new[] { "ZXWRFLU", "ZXAN8", "ZXMBDS" })
    };
}
