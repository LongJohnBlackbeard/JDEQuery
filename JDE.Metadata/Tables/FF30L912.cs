using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L912 - .
/// </summary>
public class FF30L912 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMDFLNID.
        /// </summary>
        public const string LMDFLNID = "LMDFLNID";

        /// <summary>
        /// LMDFLNNA.
        /// </summary>
        public const string LMDFLNNA = "LMDFLNNA";

        /// <summary>
        /// LMDS01.
        /// </summary>
        public const string LMDS01 = "LMDS01";

        /// <summary>
        /// LMFSCID.
        /// </summary>
        public const string LMFSCID = "LMFSCID";

        /// <summary>
        /// LMLDWC.
        /// </summary>
        public const string LMLDWC = "LMLDWC";

        /// <summary>
        /// LMDFMCU.
        /// </summary>
        public const string LMDFMCU = "LMDFMCU";

        /// <summary>
        /// LMURCD.
        /// </summary>
        public const string LMURCD = "LMURCD";

        /// <summary>
        /// LMURDT.
        /// </summary>
        public const string LMURDT = "LMURDT";

        /// <summary>
        /// LMURAT.
        /// </summary>
        public const string LMURAT = "LMURAT";

        /// <summary>
        /// LMURAB.
        /// </summary>
        public const string LMURAB = "LMURAB";

        /// <summary>
        /// LMURRF.
        /// </summary>
        public const string LMURRF = "LMURRF";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMMKEY.
        /// </summary>
        public const string LMMKEY = "LMMKEY";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMUUPMJ.
        /// </summary>
        public const string LMUUPMJ = "LMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L912";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMDFLNID", "LMDFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("LMDFLNNA", "LMDFLNNA", JdeDataType.String, 60),
        new JdeField("LMDS01", "LMDS01", JdeDataType.String, 160),
        new JdeField("LMFSCID", "LMFSCID", JdeDataType.Numeric),
        new JdeField("LMLDWC", "LMLDWC", JdeDataType.String, 24),
        new JdeField("LMDFMCU", "LMDFMCU", JdeDataType.String, 24),
        new JdeField("LMURCD", "LMURCD", JdeDataType.String, 4),
        new JdeField("LMURDT", "LMURDT", JdeDataType.Numeric),
        new JdeField("LMURAT", "LMURAT", JdeDataType.Numeric),
        new JdeField("LMURAB", "LMURAB", JdeDataType.Numeric),
        new JdeField("LMURRF", "LMURRF", JdeDataType.String, 30),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMMKEY", "LMMKEY", JdeDataType.String, 30),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMUUPMJ", "LMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L912_0", "Primary Key on LMDFLNID", new[] { "LMDFLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L912_2", "Unique Index on LMDFLNNA, LMFSCID", new[] { "LMDFLNNA", "LMFSCID" }, isUnique: true),
        new JdeIndex("FF30L912_3", "Index on LMFSCID", new[] { "LMFSCID" }),
        new JdeIndex("FF30L912_4", "Index on LMLDWC, LMDFMCU, LMFSCID", new[] { "LMLDWC", "LMDFMCU", "LMFSCID" })
    };
}
