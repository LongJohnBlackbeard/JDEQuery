using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q911 - .
/// </summary>
public class F43Q911 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCAN8.
        /// </summary>
        public const string BCAN8 = "BCAN8";

        /// <summary>
        /// BCCNTRY.
        /// </summary>
        public const string BCCNTRY = "BCCNTRY";

        /// <summary>
        /// BCVATID.
        /// </summary>
        public const string BCVATID = "BCVATID";

        /// <summary>
        /// BCURCD.
        /// </summary>
        public const string BCURCD = "BCURCD";

        /// <summary>
        /// BCURDT.
        /// </summary>
        public const string BCURDT = "BCURDT";

        /// <summary>
        /// BCURAT.
        /// </summary>
        public const string BCURAT = "BCURAT";

        /// <summary>
        /// BCURAB.
        /// </summary>
        public const string BCURAB = "BCURAB";

        /// <summary>
        /// BCURRF.
        /// </summary>
        public const string BCURRF = "BCURRF";

        /// <summary>
        /// BCTORG.
        /// </summary>
        public const string BCTORG = "BCTORG";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCTDAY.
        /// </summary>
        public const string BCTDAY = "BCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q911";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCAN8", "BCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BCCNTRY", "BCCNTRY", JdeDataType.String, 6, true, true),
        new JdeField("BCVATID", "BCVATID", JdeDataType.String, 40),
        new JdeField("BCURCD", "BCURCD", JdeDataType.String, 4),
        new JdeField("BCURDT", "BCURDT", JdeDataType.Numeric),
        new JdeField("BCURAT", "BCURAT", JdeDataType.Numeric),
        new JdeField("BCURAB", "BCURAB", JdeDataType.Numeric),
        new JdeField("BCURRF", "BCURRF", JdeDataType.String, 30),
        new JdeField("BCTORG", "BCTORG", JdeDataType.String, 20),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCTDAY", "BCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q911_0", "Primary Key on BCAN8, BCCNTRY", new[] { "BCAN8", "BCCNTRY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q911_2", "Index on BCAN8", new[] { "BCAN8" })
    };
}
