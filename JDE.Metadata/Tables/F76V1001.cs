using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V1001 - .
/// </summary>
public class F76V1001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCAN8.
        /// </summary>
        public const string WCAN8 = "WCAN8";

        /// <summary>
        /// WCV76ISLR.
        /// </summary>
        public const string WCV76ISLR = "WCV76ISLR";

        /// <summary>
        /// WCV76MUNW.
        /// </summary>
        public const string WCV76MUNW = "WCV76MUNW";

        /// <summary>
        /// WCV76VATW.
        /// </summary>
        public const string WCV76VATW = "WCV76VATW";

        /// <summary>
        /// WCV76ISFC.
        /// </summary>
        public const string WCV76ISFC = "WCV76ISFC";

        /// <summary>
        /// WCV76SUTY.
        /// </summary>
        public const string WCV76SUTY = "WCV76SUTY";

        /// <summary>
        /// WCV76PETY.
        /// </summary>
        public const string WCV76PETY = "WCV76PETY";

        /// <summary>
        /// WCURAB.
        /// </summary>
        public const string WCURAB = "WCURAB";

        /// <summary>
        /// WCURAT.
        /// </summary>
        public const string WCURAT = "WCURAT";

        /// <summary>
        /// WCURCD.
        /// </summary>
        public const string WCURCD = "WCURCD";

        /// <summary>
        /// WCURDT.
        /// </summary>
        public const string WCURDT = "WCURDT";

        /// <summary>
        /// WCURRF.
        /// </summary>
        public const string WCURRF = "WCURRF";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCJOBN.
        /// </summary>
        public const string WCJOBN = "WCJOBN";

        /// <summary>
        /// WCUPMJ.
        /// </summary>
        public const string WCUPMJ = "WCUPMJ";

        /// <summary>
        /// WCUPMT.
        /// </summary>
        public const string WCUPMT = "WCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76V1001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCAN8", "WCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("WCV76ISLR", "WCV76ISLR", JdeDataType.String, 6),
        new JdeField("WCV76MUNW", "WCV76MUNW", JdeDataType.String, 2),
        new JdeField("WCV76VATW", "WCV76VATW", JdeDataType.String, 6),
        new JdeField("WCV76ISFC", "WCV76ISFC", JdeDataType.String, 2),
        new JdeField("WCV76SUTY", "WCV76SUTY", JdeDataType.String, 6),
        new JdeField("WCV76PETY", "WCV76PETY", JdeDataType.String, 6),
        new JdeField("WCURAB", "WCURAB", JdeDataType.Numeric),
        new JdeField("WCURAT", "WCURAT", JdeDataType.Numeric),
        new JdeField("WCURCD", "WCURCD", JdeDataType.String, 4),
        new JdeField("WCURDT", "WCURDT", JdeDataType.Numeric),
        new JdeField("WCURRF", "WCURRF", JdeDataType.String, 30),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCJOBN", "WCJOBN", JdeDataType.String, 20),
        new JdeField("WCUPMJ", "WCUPMJ", JdeDataType.Numeric),
        new JdeField("WCUPMT", "WCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V1001_0", "Primary Key on WCAN8", new[] { "WCAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
