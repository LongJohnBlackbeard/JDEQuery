using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A60 - .
/// </summary>
public class F76A60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BYPYID.
        /// </summary>
        public const string BYPYID = "BYPYID";

        /// <summary>
        /// BYACLE.
        /// </summary>
        public const string BYACLE = "BYACLE";

        /// <summary>
        /// BYACVA.
        /// </summary>
        public const string BYACVA = "BYACVA";

        /// <summary>
        /// BYADEA.
        /// </summary>
        public const string BYADEA = "BYADEA";

        /// <summary>
        /// BYADNU.
        /// </summary>
        public const string BYADNU = "BYADNU";

        /// <summary>
        /// BYAPTT.
        /// </summary>
        public const string BYAPTT = "BYAPTT";

        /// <summary>
        /// BYARDA.
        /// </summary>
        public const string BYARDA = "BYARDA";

        /// <summary>
        /// BYACOD.
        /// </summary>
        public const string BYACOD = "BYACOD";

        /// <summary>
        /// BYURRF.
        /// </summary>
        public const string BYURRF = "BYURRF";

        /// <summary>
        /// BYURCD.
        /// </summary>
        public const string BYURCD = "BYURCD";

        /// <summary>
        /// BYURDT.
        /// </summary>
        public const string BYURDT = "BYURDT";

        /// <summary>
        /// BYURAT.
        /// </summary>
        public const string BYURAT = "BYURAT";

        /// <summary>
        /// BYURAB.
        /// </summary>
        public const string BYURAB = "BYURAB";

        /// <summary>
        /// BYUSER.
        /// </summary>
        public const string BYUSER = "BYUSER";

        /// <summary>
        /// BYPID.
        /// </summary>
        public const string BYPID = "BYPID";

        /// <summary>
        /// BYJOBN.
        /// </summary>
        public const string BYJOBN = "BYJOBN";

        /// <summary>
        /// BYUPMT.
        /// </summary>
        public const string BYUPMT = "BYUPMT";

        /// <summary>
        /// BYTDAY.
        /// </summary>
        public const string BYTDAY = "BYTDAY";

        /// <summary>
        /// BYADSTS.
        /// </summary>
        public const string BYADSTS = "BYADSTS";

        /// <summary>
        /// BYMCU.
        /// </summary>
        public const string BYMCU = "BYMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F76A60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BYPYID", "BYPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("BYACLE", "BYACLE", JdeDataType.String, 4),
        new JdeField("BYACVA", "BYACVA", JdeDataType.String, 20),
        new JdeField("BYADEA", "BYADEA", JdeDataType.String, 20),
        new JdeField("BYADNU", "BYADNU", JdeDataType.Numeric),
        new JdeField("BYAPTT", "BYAPTT", JdeDataType.String, 2),
        new JdeField("BYARDA", "BYARDA", JdeDataType.Numeric),
        new JdeField("BYACOD", "BYACOD", JdeDataType.Numeric),
        new JdeField("BYURRF", "BYURRF", JdeDataType.String, 30),
        new JdeField("BYURCD", "BYURCD", JdeDataType.String, 4),
        new JdeField("BYURDT", "BYURDT", JdeDataType.Numeric),
        new JdeField("BYURAT", "BYURAT", JdeDataType.Numeric),
        new JdeField("BYURAB", "BYURAB", JdeDataType.Numeric),
        new JdeField("BYUSER", "BYUSER", JdeDataType.String, 20),
        new JdeField("BYPID", "BYPID", JdeDataType.String, 20),
        new JdeField("BYJOBN", "BYJOBN", JdeDataType.String, 20),
        new JdeField("BYUPMT", "BYUPMT", JdeDataType.Numeric),
        new JdeField("BYTDAY", "BYTDAY", JdeDataType.Numeric),
        new JdeField("BYADSTS", "BYADSTS", JdeDataType.String, 2),
        new JdeField("BYMCU", "BYMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A60_0", "Primary Key on BYPYID", new[] { "BYPYID" }, isUnique: true, isPrimaryKey: true)
    };
}
