using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L201 - .
/// </summary>
public class FF30L201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VMVOLID.
        /// </summary>
        public const string VMVOLID = "VMVOLID";

        /// <summary>
        /// VMFSCID.
        /// </summary>
        public const string VMFSCID = "VMFSCID";

        /// <summary>
        /// VMVOLDESC.
        /// </summary>
        public const string VMVOLDESC = "VMVOLDESC";

        /// <summary>
        /// VMVDN.
        /// </summary>
        public const string VMVDN = "VMVDN";

        /// <summary>
        /// VMDTYPE.
        /// </summary>
        public const string VMDTYPE = "VMDTYPE";

        /// <summary>
        /// VMMKEY.
        /// </summary>
        public const string VMMKEY = "VMMKEY";

        /// <summary>
        /// VMUSER.
        /// </summary>
        public const string VMUSER = "VMUSER";

        /// <summary>
        /// VMPID.
        /// </summary>
        public const string VMPID = "VMPID";

        /// <summary>
        /// VMUPMT.
        /// </summary>
        public const string VMUPMT = "VMUPMT";

        /// <summary>
        /// VMURAT.
        /// </summary>
        public const string VMURAT = "VMURAT";

        /// <summary>
        /// VMURRF.
        /// </summary>
        public const string VMURRF = "VMURRF";

        /// <summary>
        /// VMURAB.
        /// </summary>
        public const string VMURAB = "VMURAB";

        /// <summary>
        /// VMURDT.
        /// </summary>
        public const string VMURDT = "VMURDT";

        /// <summary>
        /// VMUUPMJ.
        /// </summary>
        public const string VMUUPMJ = "VMUUPMJ";

        /// <summary>
        /// VMURCD.
        /// </summary>
        public const string VMURCD = "VMURCD";

        /// <summary>
        /// VMVOLCHG.
        /// </summary>
        public const string VMVOLCHG = "VMVOLCHG";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VMVOLID", "VMVOLID", JdeDataType.Numeric, null, true, true),
        new JdeField("VMFSCID", "VMFSCID", JdeDataType.Numeric),
        new JdeField("VMVOLDESC", "VMVOLDESC", JdeDataType.String, 160),
        new JdeField("VMVDN", "VMVDN", JdeDataType.String, 60),
        new JdeField("VMDTYPE", "VMDTYPE", JdeDataType.String, 4),
        new JdeField("VMMKEY", "VMMKEY", JdeDataType.String, 30),
        new JdeField("VMUSER", "VMUSER", JdeDataType.String, 20),
        new JdeField("VMPID", "VMPID", JdeDataType.String, 20),
        new JdeField("VMUPMT", "VMUPMT", JdeDataType.Numeric),
        new JdeField("VMURAT", "VMURAT", JdeDataType.Numeric),
        new JdeField("VMURRF", "VMURRF", JdeDataType.String, 30),
        new JdeField("VMURAB", "VMURAB", JdeDataType.Numeric),
        new JdeField("VMURDT", "VMURDT", JdeDataType.Numeric),
        new JdeField("VMUUPMJ", "VMUUPMJ", JdeDataType.Date),
        new JdeField("VMURCD", "VMURCD", JdeDataType.String, 4),
        new JdeField("VMVOLCHG", "VMVOLCHG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L201_0", "Primary Key on VMVOLID", new[] { "VMVOLID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L201_2", "Index on VMFSCID", new[] { "VMFSCID" }),
        new JdeIndex("FF30L201_3", "Index on VMVDN, VMVOLID, VMDTYPE", new[] { "VMVDN", "VMVOLID", "VMDTYPE" }),
        new JdeIndex("FF30L201_4", "Index on VMVDN, VMFSCID", new[] { "VMVDN", "VMFSCID" }),
        new JdeIndex("FF30L201_5", "Unique Index on VMFSCID, VMVDN, VMDTYPE", new[] { "VMFSCID", "VMVDN", "VMDTYPE" }, isUnique: true)
    };
}
