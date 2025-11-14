using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L904 - .
/// </summary>
public class FF30L904 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WCPMAPID.
        /// </summary>
        public const string WCPMAPID = "WCPMAPID";

        /// <summary>
        /// WCFSCID.
        /// </summary>
        public const string WCFSCID = "WCFSCID";

        /// <summary>
        /// WCDFITM.
        /// </summary>
        public const string WCDFITM = "WCDFITM";

        /// <summary>
        /// WCDFMCU.
        /// </summary>
        public const string WCDFMCU = "WCDFMCU";

        /// <summary>
        /// WCPROID.
        /// </summary>
        public const string WCPROID = "WCPROID";

        /// <summary>
        /// WCDFRID.
        /// </summary>
        public const string WCDFRID = "WCDFRID";

        /// <summary>
        /// WCDFRDESC.
        /// </summary>
        public const string WCDFRDESC = "WCDFRDESC";

        /// <summary>
        /// WCDFRDESC1.
        /// </summary>
        public const string WCDFRDESC1 = "WCDFRDESC1";

        /// <summary>
        /// WCDFRT.
        /// </summary>
        public const string WCDFRT = "WCDFRT";

        /// <summary>
        /// WCDFRAMT.
        /// </summary>
        public const string WCDFRAMT = "WCDFRAMT";

        /// <summary>
        /// WCDFRALT.
        /// </summary>
        public const string WCDFRALT = "WCDFRALT";

        /// <summary>
        /// WCDFRALS.
        /// </summary>
        public const string WCDFRALS = "WCDFRALS";

        /// <summary>
        /// WCDFRAMS.
        /// </summary>
        public const string WCDFRAMS = "WCDFRAMS";

        /// <summary>
        /// WCDFRALM.
        /// </summary>
        public const string WCDFRALM = "WCDFRALM";

        /// <summary>
        /// WCDFRAMM.
        /// </summary>
        public const string WCDFRAMM = "WCDFRAMM";

        /// <summary>
        /// WCURCD.
        /// </summary>
        public const string WCURCD = "WCURCD";

        /// <summary>
        /// WCURDT.
        /// </summary>
        public const string WCURDT = "WCURDT";

        /// <summary>
        /// WCURAT.
        /// </summary>
        public const string WCURAT = "WCURAT";

        /// <summary>
        /// WCURAB.
        /// </summary>
        public const string WCURAB = "WCURAB";

        /// <summary>
        /// WCURRF.
        /// </summary>
        public const string WCURRF = "WCURRF";

        /// <summary>
        /// WCMKEY.
        /// </summary>
        public const string WCMKEY = "WCMKEY";

        /// <summary>
        /// WCUSER.
        /// </summary>
        public const string WCUSER = "WCUSER";

        /// <summary>
        /// WCPID.
        /// </summary>
        public const string WCPID = "WCPID";

        /// <summary>
        /// WCUUPMJ.
        /// </summary>
        public const string WCUUPMJ = "WCUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L904";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WCPMAPID", "WCPMAPID", JdeDataType.Numeric, null, true, true),
        new JdeField("WCFSCID", "WCFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("WCDFITM", "WCDFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WCDFMCU", "WCDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("WCPROID", "WCPROID", JdeDataType.Numeric, null, true, true),
        new JdeField("WCDFRID", "WCDFRID", JdeDataType.Numeric, null, true, true),
        new JdeField("WCDFRDESC", "WCDFRDESC", JdeDataType.String, 60),
        new JdeField("WCDFRDESC1", "WCDFRDESC1", JdeDataType.String, 60),
        new JdeField("WCDFRT", "WCDFRT", JdeDataType.String, 4),
        new JdeField("WCDFRAMT", "WCDFRAMT", JdeDataType.Numeric),
        new JdeField("WCDFRALT", "WCDFRALT", JdeDataType.Numeric),
        new JdeField("WCDFRALS", "WCDFRALS", JdeDataType.Numeric),
        new JdeField("WCDFRAMS", "WCDFRAMS", JdeDataType.Numeric),
        new JdeField("WCDFRALM", "WCDFRALM", JdeDataType.Numeric),
        new JdeField("WCDFRAMM", "WCDFRAMM", JdeDataType.Numeric),
        new JdeField("WCURCD", "WCURCD", JdeDataType.String, 4),
        new JdeField("WCURDT", "WCURDT", JdeDataType.Numeric),
        new JdeField("WCURAT", "WCURAT", JdeDataType.Numeric),
        new JdeField("WCURAB", "WCURAB", JdeDataType.Numeric),
        new JdeField("WCURRF", "WCURRF", JdeDataType.String, 30),
        new JdeField("WCMKEY", "WCMKEY", JdeDataType.String, 30),
        new JdeField("WCUSER", "WCUSER", JdeDataType.String, 20),
        new JdeField("WCPID", "WCPID", JdeDataType.String, 20),
        new JdeField("WCUUPMJ", "WCUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L904_0", "Primary Key on WCPMAPID, WCFSCID, WCDFITM, WCDFMCU, WCPROID, WCDFRID", new[] { "WCPMAPID", "WCFSCID", "WCDFITM", "WCDFMCU", "WCPROID", "WCDFRID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L904_3", "Index on WCPMAPID, WCFSCID, WCDFITM, WCDFMCU, WCPROID, WCDFRT", new[] { "WCPMAPID", "WCFSCID", "WCDFITM", "WCDFMCU", "WCPROID", "WCDFRT" })
    };
}
