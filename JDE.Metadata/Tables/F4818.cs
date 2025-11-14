using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4818 - .
/// </summary>
public class F4818 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBDOCO.
        /// </summary>
        public const string CBDOCO = "CBDOCO";

        /// <summary>
        /// CBGRPG.
        /// </summary>
        public const string CBGRPG = "CBGRPG";

        /// <summary>
        /// CBOSEQ.
        /// </summary>
        public const string CBOSEQ = "CBOSEQ";

        /// <summary>
        /// CBAN8.
        /// </summary>
        public const string CBAN8 = "CBAN8";

        /// <summary>
        /// CBAPFL.
        /// </summary>
        public const string CBAPFL = "CBAPFL";

        /// <summary>
        /// CBAPDJ.
        /// </summary>
        public const string CBAPDJ = "CBAPDJ";

        /// <summary>
        /// CBDS40.
        /// </summary>
        public const string CBDS40 = "CBDS40";

        /// <summary>
        /// CBUSER.
        /// </summary>
        public const string CBUSER = "CBUSER";

        /// <summary>
        /// CBPID.
        /// </summary>
        public const string CBPID = "CBPID";

        /// <summary>
        /// CBUPMJ.
        /// </summary>
        public const string CBUPMJ = "CBUPMJ";

        /// <summary>
        /// CBJOBN.
        /// </summary>
        public const string CBJOBN = "CBJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F4818";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBDOCO", "CBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CBGRPG", "CBGRPG", JdeDataType.Numeric, null, true, true),
        new JdeField("CBOSEQ", "CBOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CBAN8", "CBAN8", JdeDataType.Numeric),
        new JdeField("CBAPFL", "CBAPFL", JdeDataType.String, 2),
        new JdeField("CBAPDJ", "CBAPDJ", JdeDataType.Numeric),
        new JdeField("CBDS40", "CBDS40", JdeDataType.String, 80),
        new JdeField("CBUSER", "CBUSER", JdeDataType.String, 20),
        new JdeField("CBPID", "CBPID", JdeDataType.String, 20),
        new JdeField("CBUPMJ", "CBUPMJ", JdeDataType.Numeric),
        new JdeField("CBJOBN", "CBJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4818_0", "Primary Key on CBDOCO, CBGRPG, CBOSEQ", new[] { "CBDOCO", "CBGRPG", "CBOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4818_1", "Index on CBDOCO", new[] { "CBDOCO" }),
        new JdeIndex("F4818_2", "Index on CBAN8, CBDOCO", new[] { "CBAN8", "CBDOCO" })
    };
}
