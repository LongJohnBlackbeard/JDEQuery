using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F071072 - .
/// </summary>
public class F071072 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JXAN8.
        /// </summary>
        public const string JXAN8 = "JXAN8";

        /// <summary>
        /// JXRTAM.
        /// </summary>
        public const string JXRTAM = "JXRTAM";

        /// <summary>
        /// JXDEDM.
        /// </summary>
        public const string JXDEDM = "JXDEDM";

        /// <summary>
        /// JXDESQ.
        /// </summary>
        public const string JXDESQ = "JXDESQ";

        /// <summary>
        /// JXUSER.
        /// </summary>
        public const string JXUSER = "JXUSER";

        /// <summary>
        /// JXPID.
        /// </summary>
        public const string JXPID = "JXPID";

        /// <summary>
        /// JXUPMJ.
        /// </summary>
        public const string JXUPMJ = "JXUPMJ";

        /// <summary>
        /// JXUPMT.
        /// </summary>
        public const string JXUPMT = "JXUPMT";

        /// <summary>
        /// JXJOBN.
        /// </summary>
        public const string JXJOBN = "JXJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F071072";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JXAN8", "JXAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JXRTAM", "JXRTAM", JdeDataType.Numeric),
        new JdeField("JXDEDM", "JXDEDM", JdeDataType.String, 2),
        new JdeField("JXDESQ", "JXDESQ", JdeDataType.String, 2),
        new JdeField("JXUSER", "JXUSER", JdeDataType.String, 20),
        new JdeField("JXPID", "JXPID", JdeDataType.String, 20),
        new JdeField("JXUPMJ", "JXUPMJ", JdeDataType.Numeric),
        new JdeField("JXUPMT", "JXUPMT", JdeDataType.Numeric),
        new JdeField("JXJOBN", "JXJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F071072_0", "Primary Key on JXAN8", new[] { "JXAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
