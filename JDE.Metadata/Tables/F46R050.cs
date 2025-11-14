using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46R050 - .
/// </summary>
public class F46R050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHEPCHDR.
        /// </summary>
        public const string EHEPCHDR = "EHEPCHDR";

        /// <summary>
        /// EHEPCLEN.
        /// </summary>
        public const string EHEPCLEN = "EHEPCLEN";

        /// <summary>
        /// EHHDRLEN.
        /// </summary>
        public const string EHHDRLEN = "EHHDRLEN";

        /// <summary>
        /// EHEPCHDV.
        /// </summary>
        public const string EHEPCHDV = "EHEPCHDV";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHMKEY.
        /// </summary>
        public const string EHMKEY = "EHMKEY";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHTDAY.
        /// </summary>
        public const string EHTDAY = "EHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46R050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHEPCHDR", "EHEPCHDR", JdeDataType.String, 4, true, true),
        new JdeField("EHEPCLEN", "EHEPCLEN", JdeDataType.Numeric),
        new JdeField("EHHDRLEN", "EHHDRLEN", JdeDataType.Numeric),
        new JdeField("EHEPCHDV", "EHEPCHDV", JdeDataType.String, 24),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHMKEY", "EHMKEY", JdeDataType.String, 30),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHTDAY", "EHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46R050_0", "Primary Key on EHEPCHDR", new[] { "EHEPCHDR" }, isUnique: true, isPrimaryKey: true)
    };
}
