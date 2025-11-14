using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G034 - .
/// </summary>
public class F40G034 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HIWVID.
        /// </summary>
        public const string HIWVID = "HIWVID";

        /// <summary>
        /// HIBLUID.
        /// </summary>
        public const string HIBLUID = "HIBLUID";

        /// <summary>
        /// HIITM.
        /// </summary>
        public const string HIITM = "HIITM";

        /// <summary>
        /// HILITM.
        /// </summary>
        public const string HILITM = "HILITM";

        /// <summary>
        /// HIAITM.
        /// </summary>
        public const string HIAITM = "HIAITM";

        /// <summary>
        /// HIHARPAT.
        /// </summary>
        public const string HIHARPAT = "HIHARPAT";

        /// <summary>
        /// HIURCD.
        /// </summary>
        public const string HIURCD = "HIURCD";

        /// <summary>
        /// HIURDT.
        /// </summary>
        public const string HIURDT = "HIURDT";

        /// <summary>
        /// HIURRF.
        /// </summary>
        public const string HIURRF = "HIURRF";

        /// <summary>
        /// HIURAB.
        /// </summary>
        public const string HIURAB = "HIURAB";

        /// <summary>
        /// HIURAT.
        /// </summary>
        public const string HIURAT = "HIURAT";

        /// <summary>
        /// HIUSER.
        /// </summary>
        public const string HIUSER = "HIUSER";

        /// <summary>
        /// HIPID.
        /// </summary>
        public const string HIPID = "HIPID";

        /// <summary>
        /// HIJOBN.
        /// </summary>
        public const string HIJOBN = "HIJOBN";

        /// <summary>
        /// HITORG.
        /// </summary>
        public const string HITORG = "HITORG";

        /// <summary>
        /// HIUUPMJ.
        /// </summary>
        public const string HIUUPMJ = "HIUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G034";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HIWVID", "HIWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("HIBLUID", "HIBLUID", JdeDataType.Numeric),
        new JdeField("HIITM", "HIITM", JdeDataType.Numeric),
        new JdeField("HILITM", "HILITM", JdeDataType.String, 50),
        new JdeField("HIAITM", "HIAITM", JdeDataType.String, 50),
        new JdeField("HIHARPAT", "HIHARPAT", JdeDataType.String, 20),
        new JdeField("HIURCD", "HIURCD", JdeDataType.String, 4),
        new JdeField("HIURDT", "HIURDT", JdeDataType.Numeric),
        new JdeField("HIURRF", "HIURRF", JdeDataType.String, 30),
        new JdeField("HIURAB", "HIURAB", JdeDataType.Numeric),
        new JdeField("HIURAT", "HIURAT", JdeDataType.Numeric),
        new JdeField("HIUSER", "HIUSER", JdeDataType.String, 20),
        new JdeField("HIPID", "HIPID", JdeDataType.String, 20),
        new JdeField("HIJOBN", "HIJOBN", JdeDataType.String, 20),
        new JdeField("HITORG", "HITORG", JdeDataType.String, 20),
        new JdeField("HIUUPMJ", "HIUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G034_0", "Primary Key on HIWVID", new[] { "HIWVID" }, isUnique: true, isPrimaryKey: true)
    };
}
